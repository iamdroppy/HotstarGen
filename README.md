# HotstarGen
RDR3: A simple yet useful nativedb to code conversor with Liquid support

## Binaries
.NET 5 portable binaries are uploaded in the Release Folder.

## Natives
You can find updated natives at https://github.com/alloc8or/rdr3-nativedb-data

## Samples

This is CLI, you can use `--help` anytime to get argument help.

### C#

Command:

`-i csharp.liquid -e .cs -o output -y -v`

*input template csharp.liquid, export with extension .cs, on folder output, without ask any prompt, in verbose mode.*

It will lookup for the native.json on the folder, but you can use `-n native_custom.json` or `--natives native_custom.json`

Template file:

```csharp
using System;

namespace Hotstar
{
    public enum NATIVE_{{ category }} : ulong
    { {% for native in natives %}
        {% if native.comment != "" %}
        /// <summary>
        /// {{ native.comment | replace: "\n", "\n        /// " }}
        ///
        {% for params in native.params %}
        /// > {{ params.type }} {{ params.name }}
        {%endfor%}
        ///
        /// </summary>
        {% endif %}
        {{ native.name }} = {{ native.hash }},
    {% endfor %}
    }

    public static class NATIVE_{{ category }}_EXTENSIONS
    {
        public static void Call(this NATIVE_{{ category }} hash, params RDR2.Native.InputArgument[] arguments)
        {
            RDR2.Native.Function.Call((ulong) hash, arguments);
        }
        public static T Call<T>(this NATIVE_{{ category }} hash, params RDR2.Native.InputArgument[] arguments)
        {
            return RDR2.Native.Function.Call<T>((ulong) hash, arguments);
        }
    }
}

```

The template system can output to any language or framework.

Output sample:

```csharp
        /// <summary>
        /// STREAMING::REQUEST_MODELS_IN_ROOM(l_13BC, "V_FIB01_cur_elev");
        /// STREAMING::REQUEST_MODELS_IN_ROOM(l_13BC, "limbo");
        /// STREAMING::REQUEST_MODELS_IN_ROOM(l_13BB, "V_Office_gnd_lifts");
        /// STREAMING::REQUEST_MODELS_IN_ROOM(l_13BB, "limbo");
        /// STREAMING::REQUEST_MODELS_IN_ROOM(l_13BC, "v_fib01_jan_elev");
        /// STREAMING::REQUEST_MODELS_IN_ROOM(l_13BC, "limbo");
        ///
        /// > Interior interior
        /// > const char* roomName
        ///
        /// </summary>
        REQUEST_MODELS_IN_ROOM = 0x8A7A40100EDFEC58,
        /// <summary>
        /// Unloads model from memory
        ///
        /// > Hash model
        ///
        /// </summary>
        SET_MODEL_AS_NO_LONGER_NEEDED = 0xE532F5D78798DAAB,
```
