using static MicroOCR.TrainTool;
using TorchSharp;
using OpenCvSharp;

namespace MicroOCR
{
    static class Program
    {
        public static void Main()
        {  
            var cfg = BuildCfg();
            TrainModel(cfg);
        }

        public static Dictionary<CfgNode, object> BuildCfg()
        {
            Dictionary<CfgNode, object> cfg = new Dictionary<CfgNode, object>();
            cfg.Add(CfgNode.TrainRoot, "D:/dataset/gen/train");
            cfg.Add(CfgNode.TestRoot, "D:/dataset/gen/test");
            cfg.Add(CfgNode.TrainLabel, "D:/dataset/gen/train.txt");
            cfg.Add(CfgNode.TestLabel, "D:/dataset/gen/test.txt");
            cfg.Add(CfgNode.VocabularyPath, "./english.txt");
            //cfg.Add(CfgNode.ModelPath, "G:\\microOCR\\MicroOCR\\bin\\x64\\Debug\\net6.0\\save_model\\MicroOcr_nh128_depth2_epoch3_wordAcc0.0060_charAcc0.6845.pth");
            cfg.Add(CfgNode.ModelType, "MicroOcr");
            cfg.Add(CfgNode.Nh, 256);
            cfg.Add(CfgNode.Depth, 2);
            cfg.Add(CfgNode.InChannels, 3);
            cfg.Add(CfgNode.Lr, 0.001);
            cfg.Add(CfgNode.BatchSize, 32);
            cfg.Add(CfgNode.Epochs, 20);
            cfg.Add(CfgNode.DisplayStepInterval, 50);
            cfg.Add(CfgNode.EvalStepInterval, 100);
            cfg.Add(CfgNode.SaveEpochInterval, 1);
            cfg.Add(CfgNode.ShowStrSize, 10);
            cfg.Add(CfgNode.GpuIndex, 0);
            return cfg;
        }
    }
};