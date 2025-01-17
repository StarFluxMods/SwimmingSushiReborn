using System;
using Kitchen;
using KitchenMods;
using MessagePack;
using SwimmingSushiReborn.Components;
using SwimmingSushiReborn.Systems;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;

namespace SwimmingSushiReborn.Views
{
    public class SalmonView : UpdatableObjectView<SalmonView.ViewData>
	{
		public class UpdateView : IncrementalViewSystemBase<ViewData>, IModSystem
		{
			private EntityQuery Views;

			protected override void Initialise()
			{
				base.Initialise();

				Views = GetEntityQuery(new QueryHelper().All(typeof(CSalmon), typeof(CLinkedView)));
			}

			protected override void OnUpdate()
			{
				using var entities = Views.ToEntityArray(Allocator.Temp);
				using var views = Views.ToComponentDataArray<CLinkedView>(Allocator.Temp);

				for (var i = 0; i < views.Length; i++)
				{
					var view = views[i];

					if (Require(entities[i], out CSalmon cSalmon))
					{
						TimeSpan timeSpan = DateTime.UtcNow - cSalmon.TimePlacedInSink;
						ViewData data = new ViewData
						{
							ShouldSwim = (timeSpan.TotalSeconds >= SinkSalmon.SecondsInSink) && cSalmon.IsInSink
						};
						SendUpdate(view, data);
					}

				}
			}
		}
		
		[MessagePackObject(false)]
		public struct ViewData : ISpecificViewData, IViewData.ICheckForChanges<ViewData>
		{
			[Key(1)] public bool ShouldSwim;

			public IUpdatableObject GetRelevantSubview(IObjectView view) => view.GetSubView<SalmonView>();

			public bool IsChangedFrom(ViewData cached)
			{
				return ShouldSwim != cached.ShouldSwim;
			}
		}

		private static readonly int SwimDownSink = Animator.StringToHash("SwimDownSink");
		public Animator animator;
		protected override void UpdateData(ViewData view_data)
		{
			animator.SetBool(SwimDownSink, view_data.ShouldSwim);
		}
	}
}