using Sledge.Common.Translations;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sledge.BspEditor.Environment.Source
{
    [Export(typeof(IEnvironmentFactory))]
    [AutoTranslate]
    public class SourceEnvironmentFactory : IEnvironmentFactory
    {
        public Type Type => typeof(SourceEnvironment);
        public string TypeName => "SourceEnvironment";
        public string Description { get; set; } = "Source";

        private T GetVal<T>(Dictionary<string, string> dictionary, string key, T def = default(T))
        {
            if (dictionary.TryGetValue(key, out var val))
            {
                try
                {
                    return (T)Convert.ChangeType(val, typeof(T), CultureInfo.InvariantCulture);
                }
                catch
                {
                    //
                }
            }
            return def;
        }

        public IEnvironment Deserialise(SerialisedEnvironment environment)
        {
            var gse = new SourceEnvironment()
            {
                ID = environment.ID,
                Name = environment.Name,
                BaseDirectory = GetVal(environment.Properties, "BaseDirectory", ""),
                GameDirectory = GetVal(environment.Properties, "GameDirectory", ""),
                GameExe = GetVal(environment.Properties, "GameExe", ""),
                LoadHdModels = GetVal(environment.Properties, "LoadHdModels", true),

                FgdFiles = GetVal(environment.Properties, "FgdFiles", "").Split(';').Where(x => !String.IsNullOrWhiteSpace(x)).ToList(),
                DefaultPointEntity = GetVal(environment.Properties, "DefaultPointEntity", ""),
                DefaultBrushEntity = GetVal(environment.Properties, "DefaultBrushEntity", ""),
                OverrideMapSize = GetVal(environment.Properties, "OverrideMapSize", false),
                MapSizeLow = GetVal(environment.Properties, "MapSizeLow", -16384m),
                MapSizeHigh = GetVal(environment.Properties, "MapSizeHigh", 16384m),

                ToolsDirectory = GetVal(environment.Properties, "ToolsDirectory", ""),
                BspExe = GetVal(environment.Properties, "BspExe", ""),
                VisExe = GetVal(environment.Properties, "VisExe", ""),
                RadExe = GetVal(environment.Properties, "RadExe", ""),

                GameCopyBsp = GetVal(environment.Properties, "GameCopyBsp", true),
                GameRun = GetVal(environment.Properties, "GameRun", true),
                GameAsk = GetVal(environment.Properties, "GameAsk", true),

                MapCopyBsp = GetVal(environment.Properties, "MapCopyBsp", false),
                MapCopyMap = GetVal(environment.Properties, "MapCopyMap", false),
                MapCopyLog = GetVal(environment.Properties, "MapCopyLog", false),
                MapCopyErr = GetVal(environment.Properties, "MapCopyErr", false),
                MapCopyRes = GetVal(environment.Properties, "MapCopyRes", false),

                DefaultTextureScale = GetVal(environment.Properties, "DefaultTextureScale", 0.25m),
                ExcludedWads = GetVal(environment.Properties, "ExcludedWads", "").Split(';').Where(x => !String.IsNullOrWhiteSpace(x)).ToList(),
            };
            return gse;
        }

        public SerialisedEnvironment Serialise(IEnvironment environment)
        {
            var env = (SourceEnvironment)environment;
            var se = new SerialisedEnvironment
            {
                ID = environment.ID,
                Name = environment.Name,
                Type = TypeName,
                Properties =
                {
                    { "BaseDirectory", env.BaseDirectory },
                    { "GameDirectory", env.GameDirectory },
                    { "GameExe", env.GameExe },
                    { "LoadHdModels", Convert.ToString(env.LoadHdModels, CultureInfo.InvariantCulture) },

                    { "FgdFiles", String.Join(";", env.FgdFiles) },
                    { "DefaultPointEntity", env.DefaultPointEntity },
                    { "DefaultBrushEntity", env.DefaultBrushEntity },
                    { "OverrideMapSize", Convert.ToString(env.OverrideMapSize, CultureInfo.InvariantCulture) },
                    { "MapSizeLow", Convert.ToString(env.MapSizeLow, CultureInfo.InvariantCulture) },
                    { "MapSizeHigh", Convert.ToString(env.MapSizeHigh, CultureInfo.InvariantCulture) },

                    { "ToolsDirectory", env.ToolsDirectory },
                    { "BspExe", env.BspExe },
                    { "VisExe", env.VisExe },
                    { "RadExe", env.RadExe },

                    { "GameCopyBsp", Convert.ToString(env.GameCopyBsp, CultureInfo.InvariantCulture) },
                    { "GameRun", Convert.ToString(env.GameRun, CultureInfo.InvariantCulture) },
                    { "GameAsk", Convert.ToString(env.GameAsk, CultureInfo.InvariantCulture) },

                    { "MapCopyBsp", Convert.ToString(env.MapCopyBsp, CultureInfo.InvariantCulture) },
                    { "MapCopyMap", Convert.ToString(env.MapCopyMap, CultureInfo.InvariantCulture) },
                    { "MapCopyLog", Convert.ToString(env.MapCopyLog, CultureInfo.InvariantCulture) },
                    { "MapCopyErr", Convert.ToString(env.MapCopyErr, CultureInfo.InvariantCulture) },
                    { "MapCopyRes", Convert.ToString(env.MapCopyRes, CultureInfo.InvariantCulture) },

                    { "DefaultTextureScale", Convert.ToString(env.DefaultTextureScale, CultureInfo.InvariantCulture) },

                    { "ExcludedWads", String.Join(";", env.ExcludedWads) },
                }
            };
            return se;
        }

        public IEnvironment CreateEnvironment()
        {
            return new SourceEnvironment();
        }

        public IEnvironmentEditor CreateEditor()
        {
            return new SourceEnvironmentEditor();
        }
    }
}
