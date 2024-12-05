using KitchenData;
using KitchenLib.Customs;
using SwimmingSushiReborn.Utilies;

namespace SwimmingSushiReborn.Customs.Processes
{
    public class Roll : CustomProcess
    {
        public override string UniqueNameID => "Roll";
        public override GameDataObject BasicEnablingAppliance => GDOReferences.Countertop;
        public override bool CanObfuscateProgress => true;
    }
}