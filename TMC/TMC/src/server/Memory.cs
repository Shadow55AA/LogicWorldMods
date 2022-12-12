using LogicAPI.Server.Components;

namespace TMC.Server.LogicCode
{
    public class WordDLatch : LogicComponent
    {
        protected override void DoLogicUpdate()
        {
            if(Inputs[Inputs.Count-1].On)
            {
                for(int i=0;i<Inputs.Count-1;i++)
                {
                    Outputs[i].On = Inputs[i].On;
                }
            }
        }
    }

    public class WordRelay : LogicComponent
    {
        private bool PreviouslyOpen;

        protected override void DoLogicUpdate()
        {
            bool openNow = Inputs[Inputs.Count - 1].On;
            if(openNow != PreviouslyOpen)
            {
                int nbits = (Inputs.Count - 1) / 2;
                if(openNow)
                {
                    for(int i=0;i<nbits;i++)
                    {
                        Inputs[i].AddPhasicLinkWithUnsafe(Inputs[i + nbits]);
                    }
                }
                else
                {
                    for (int i = 0; i < nbits; i++)
                    {
                        Inputs[i].RemovePhasicLinkWithUnsafe(Inputs[i + nbits]);
                    }
                }
                PreviouslyOpen = openNow;
            }
        }

        public override bool InputAtIndexShouldTriggerComponentLogicUpdates(int inputIndex)
        {
            return inputIndex == Inputs.Count - 1;
        }
    }
}