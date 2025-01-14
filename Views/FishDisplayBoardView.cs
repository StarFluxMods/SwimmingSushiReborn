using Kitchen;
using Kitchen.Components;
using KitchenMods;
using MessagePack;
using SwimmingSushiReborn.Components;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;

namespace SwimmingSushiReborn.Views
{
    public class FishDisplayBoardView : UpdatableObjectView<FishDisplayBoardView.ViewData>
	{
		public class UpdateView : IncrementalViewSystemBase<ViewData>, IModSystem
		{
			private EntityQuery Views;

			protected override void Initialise()
			{
				base.Initialise();

				Views = GetEntityQuery(new QueryHelper().All(typeof(CFishDisplayBoardView), typeof(CLinkedView)));
			}

			protected override void OnUpdate()
			{
				using var entities = Views.ToEntityArray(Allocator.Temp);
				using var views = Views.ToComponentDataArray<CLinkedView>(Allocator.Temp);

				for (var i = 0; i < views.Length; i++)
				{
					var view = views[i];

					if (Require(entities[i], out CFishDisplayBoardView cFishDisplayBoardView))
					{
						ViewData data = new ViewData
						{
							isBeingInteractedWith = cFishDisplayBoardView.isBeingInteractedWith
						};
						SendUpdate(view, data);

						if (cFishDisplayBoardView.isBeingInteractedWith)
						{
							cFishDisplayBoardView.isBeingInteractedWith = false;
							Set(entities[i], cFishDisplayBoardView);
						}
					}

				}
			}
		}
		
		[MessagePackObject(false)]
		public struct ViewData : ISpecificViewData, IViewData.ICheckForChanges<ViewData>
		{
			[Key(1)] public bool isBeingInteractedWith;

			public IUpdatableObject GetRelevantSubview(IObjectView view) => view.GetSubView<FishDisplayBoardView>();

			public bool IsChangedFrom(ViewData cached)
			{
				return isBeingInteractedWith != cached.isBeingInteractedWith;
			}
		}

		private static readonly int ShouldSlap = Animator.StringToHash("ShouldSlap");
		public Animator animator;
		public SoundSource soundSource;
		protected override void UpdateData(ViewData view_data)
		{
			Mod.Logger.LogInfo("UPDATING " + view_data.isBeingInteractedWith);
			animator.SetBool(ShouldSlap, view_data.isBeingInteractedWith);
			soundSource.Play();
		}
	}
}