// SPDX-License-Identifier: MIT

namespace Fahrenheit.Mods.Template;

[FhLoad(FhGameId.FFX)]
public class TemplateModule : FhModule {
    /* [fkelava 27/6/25 00:30]
     * A module's constructor must be parameterless. Use it to initialize local fields and objects.
     * Fahrenheit initialization is performed in `init` instead. Read that method's XML documentation comment for more details.
     */
    public TemplateModule() { }

    public override bool init(FhModContext mod_context, FileStream global_state_file) { return true; }

    public override void load_local_state(FileStream? local_state_file, FhLocalStateInfo local_state_info) { }
    public override void save_local_state(FileStream  local_state_file)                                    { }
}
