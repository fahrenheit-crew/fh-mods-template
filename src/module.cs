// SPDX-License-Identifier: MIT

namespace Fahrenheit.Mods.Template;

/* [fkelava 27/6/25 00:30]
 * All aspects of Fahrenheit modding are covered on our wiki at https://github.com/fahrenheit-crew/fahrenheit/wiki.
 *
 * Begin by consulting the quick-start guide: https://github.com/fahrenheit-crew/fahrenheit/wiki/Modding-quick-start-guide.
 */

[FhLoad(FhGameId.FFX)]
public class TemplateModule : FhModule {
    /* [fkelava 20/10/26 14:44]
     * Read the Startup article at https://github.com/fahrenheit-crew/fahrenheit/wiki/Startup
     * to see the respective roles of the constructor and `init` method.
     */

    public TemplateModule() { }

    public override bool init(FhModContext mod_context, FileStream global_state_file) { return true; }

    /* [fkelava 20/10/26 14:44]
     * Read the State article at https://github.com/fahrenheit-crew/fahrenheit/wiki/State
     * to see how and why to take advantage of local state.
     */

    public override void load_local_state(FileStream? local_state_file, FhLocalStateInfo local_state_info) { }
    public override void save_local_state(FileStream  local_state_file)                                    { }
}
