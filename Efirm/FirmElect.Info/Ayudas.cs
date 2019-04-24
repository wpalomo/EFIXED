/*

using System; como esta ahora 

utilizando System.Data.Entity; 
utilizando System.Data.Entity.Infrastructure; 
<# 
if (container.FunctionImports.Any ()) {
>

utilizando System.Data.Objects; 
utilizando System.Data.Objects.DataClasses; 
utilizando System.Linq; 
<# 
}
>

Después de edición: debe quedar 
using System;

utilizando System.Data.Entity; 
utilizando System.Data.Entity.Infrastructure; 
<# 
if (container.FunctionImports.Any ()) {
>

utilizando System.Data.Entity.Core.Objects; 
// usando System.Data.Objects; 
// usando System.Data.Objects.DataClasses; 
// usando System.Linq; 
<# 
}
>

NOTA: - Este es para apenas arreglo temporal para desarrollar EF 6.
*/
