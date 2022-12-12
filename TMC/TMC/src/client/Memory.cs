using JimmysUnityUtilities;
using LogicAPI.Data;
using LogicWorld.ClientCode;
using LogicWorld.Interfaces;
using LogicWorld.Rendering.Components;

namespace TMC.Client.ClientCode
{
    public class WordDLatch : ComponentClientCode<WordDLatch.IData>, IColorableClientCode, IComponentClientCode
    {
        public interface IData
        {
            Color24 Color { get; set; }
        }

        public Color24 Color { get { return Data.Color; } set { Data.Color = value; } }

        public string ColorsFileKey => "WordDLatch";

        public float MinColorValue => 0f;

        protected override void SetDataDefaultValues()
        {
            Data.Color = new Color24(0x349F16);
        }

        protected override void DataUpdate()
        {
            SetBlockColor(Data.Color.ToGpuColor());
        }
    }

    public class WordRelay : ComponentClientCode<WordRelay.IData>, IColorableClientCode, IComponentClientCode
    {
        public interface IData
        {
            Color24 Color { get; set; }
        }

        public Color24 Color { get { return Data.Color; } set { Data.Color = value; } }

        public string ColorsFileKey => "WordRelay";

        public float MinColorValue => 0f;

        protected override void SetDataDefaultValues()
        {
            Data.Color = new Color24(0x7E133B);
        }

        protected override void DataUpdate()
        {
            SetBlockColor(Data.Color.ToGpuColor());
        }
    }
}