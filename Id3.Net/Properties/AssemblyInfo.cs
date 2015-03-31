#region --- License & Copyright Notice ---
/*
Copyright (c) 2005-2012 Jeevan James
All rights reserved.

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/
#endregion

using System.Reflection;
using System.Runtime.CompilerServices;

[assembly: AssemblyTitle("ID3.NET Core")]
[assembly: AssemblyDescription(".NET class library that implements the full ID3 v1.x/v2.x & Lyrics3 v2 specs for reading & writing from MP3 files. Provides an extensible framework for retrieving lyrics, album art (cover art) & other ID3 information from online services.")]

[assembly: InternalsVisibleTo("Id3.Serialization")]
[assembly: InternalsVisibleTo("Id3.Tests")]