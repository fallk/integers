using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A253182
{
public static readonly long[] Value={ 4L,3L,1L,5L,38L,2L,1L,65L,1L,1L,2L,2L,3L,5L,1L,1L,38L,1L,1L,1L,5L,16L,1L,1L,1L,1L,5L,1L,97L,1L,1L,1L,1L,1L,1L,10L,4L,1L,6L,3L,3L,10L,6L,1L,2L,1L,1L,1L,1L,1L,2L,2L,1L,2L,2L,2L,1L,1L,1L,1L,1L,4L,5L,1L,14L,2L,5L,12L,2L,2L,2L,2L,1L,3L,2L,1L,1L,2L,4L,1L,1L,6L,3L,1L,4L,2L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253182Inst : IEnumerable<long>
{
public static readonly long[] Value=A253182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253182.Bytes);
public long this[int i]=>Value[i];

public static A253182Inst Instance=new A253182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253183
{
public static readonly long[] Value={ 1L,2L,1L,2L,2L,0L,3L,2L,0L,2L,2L,2L,1L,2L,0L,2L,4L,0L,2L,0L,1L,4L,2L,2L,6L,4L,4L,6L,2L,8L,5L,4L,4L,4L,6L,2L,8L,2L,6L,10L,0L,4L,3L,4L,8L,6L,5L,6L,7L,4L,6L,8L,7L,4L,8L,6L,5L,8L,3L,10L,6L,8L,8L,0L,4L,8L,9L,6L,6L,12L,8L,8L,11L,8L,10L,8L,9L,4L,14L,12L,10L,12L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253183Inst : IEnumerable<long>
{
public static readonly long[] Value=A253183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253183.Bytes);
public long this[int i]=>Value[i];

public static A253183Inst Instance=new A253183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253184
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,0L,2L,0L,1L,0L,0L,3L,0L,1L,0L,1L,0L,4L,0L,1L,1L,0L,3L,0L,5L,0L,1L,0L,2L,0L,6L,0L,6L,0L,1L,0L,0L,4L,0L,10L,0L,7L,0L,1L,0L,2L,0L,8L,0L,15L,0L,8L,0L,1L,0L,0L,6L,0L,15L,0L,21L,0L,9L,0L,1L,0L,0L,0L,13L,0L,26L,0L,28L,0L,10L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253184Inst : IEnumerable<long>
{
public static readonly long[] Value=A253184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253184.Bytes);
public long this[int i]=>Value[i];

public static A253184Inst Instance=new A253184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253185
{
public static readonly long[] Value={ 1L,-4L,4L,0L,4L,-8L,0L,0L,4L,-4L,8L,0L,0L,-8L,0L,0L,4L,-8L,4L,0L,8L,0L,0L,-4L,16L,-28L,8L,-16L,32L,-8L,0L,-16L,20L,-32L,8L,0L,36L,-8L,0L,-16L,40L,-24L,0L,-32L,0L,-8L,4L,-16L,64L,-36L,28L,-32L,40L,-8L,16L,-32L,32L,-32L,8L,-48L,32L,-8L,16L,-64L,52L,-16L,32L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253185Inst : IEnumerable<long>
{
public static readonly long[] Value=A253185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253185.Bytes);
public long this[int i]=>Value[i];

public static A253185Inst Instance=new A253185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253186
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,4L,6L,7L,9L,11L,13L,15L,18L,20L,23L,26L,29L,32L,36L,39L,43L,47L,51L,55L,60L,64L,69L,74L,79L,84L,90L,95L,101L,107L,113L,119L,126L,132L,139L,146L,153L,160L,168L,175L,183L,191L,199L,207L,216L,224L,233L,242L,251L,260L,270L,279L,289L,299L,309L,319L,330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253186Inst : IEnumerable<long>
{
public static readonly long[] Value=A253186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253186.Bytes);
public long this[int i]=>Value[i];

public static A253186Inst Instance=new A253186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253187
{
public static readonly long[] Value={ 1L,2L,2L,2L,1L,1L,1L,3L,4L,2L,2L,1L,4L,3L,3L,4L,2L,3L,1L,3L,2L,2L,5L,3L,3L,3L,3L,6L,3L,6L,4L,2L,3L,1L,7L,2L,4L,5L,5L,4L,1L,5L,5L,2L,3L,4L,4L,5L,5L,5L,3L,5L,7L,6L,4L,3L,1L,6L,6L,8L,5L,3L,6L,4L,7L,4L,2L,6L,5L,5L,3L,4L,8L,3L,3L,3L,6L,6L,7L,9L,6L,2L,5L,6L,7L,7L,4L,6L,6L,7L,5L,3L,10L,6L,3L,4L,5L,7L,3L,10L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253187Inst : IEnumerable<long>
{
public static readonly long[] Value=A253187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253187.Bytes);
public long this[int i]=>Value[i];

public static A253187Inst Instance=new A253187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253188
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,4L,4L,5L,6L,7L,8L,9L,10L,10L,11L,12L,13L,14L,15L,16L,17L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253188Inst : IEnumerable<long>
{
public static readonly long[] Value=A253188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253188.Bytes);
public long this[int i]=>Value[i];

public static A253188Inst Instance=new A253188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253189
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,2L,0L,0L,1L,0L,0L,3L,0L,0L,1L,0L,0L,0L,4L,0L,0L,1L,0L,1L,0L,0L,5L,0L,0L,1L,0L,0L,3L,0L,0L,6L,0L,0L,1L,0L,0L,0L,6L,0L,0L,7L,0L,0L,1L,0L,0L,0L,0L,10L,0L,0L,8L,0L,0L,1L,0L,0L,1L,0L,0L,15L,0L,0L,9L,0L,0L,1L,1L,0L,0L,4L,0L,0L,21L,0L,0L,10L,0L,0L,1L,0L,2L,0L,0L,10L,0L,0L,28L,0L,0L,11L,0L,0L,1L,0L,0L,3L,0L,0L,20L,0L,0L,36L,0L,0L,12L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253189Inst : IEnumerable<long>
{
public static readonly long[] Value=A253189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253189.Bytes);
public long this[int i]=>Value[i];

public static A253189Inst Instance=new A253189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253190
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,0L,2L,0L,1L,1L,0L,3L,0L,1L,0L,3L,0L,4L,0L,1L,2L,0L,6L,0L,5L,0L,1L,0L,6L,0L,10L,0L,6L,0L,1L,3L,0L,13L,0L,15L,0L,7L,0L,1L,0L,11L,0L,24L,0L,21L,0L,8L,0L,1L,5L,0L,27L,0L,40L,0L,28L,0L,9L,0L,1L,0L,20L,0L,55L,0L,62L,0L,36L,0L,10L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253190Inst : IEnumerable<long>
{
public static readonly long[] Value=A253190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253190.Bytes);
public long this[int i]=>Value[i];

public static A253190Inst Instance=new A253190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253191
{
public static readonly long[] Value={ 4L,8L,0L,4L,5L,3L,0L,1L,3L,9L,1L,8L,2L,0L,1L,4L,2L,4L,6L,6L,7L,1L,0L,2L,5L,2L,6L,3L,2L,6L,6L,6L,4L,9L,7L,1L,7L,3L,0L,5L,5L,2L,9L,5L,1L,5L,9L,4L,5L,4L,5L,5L,8L,6L,8L,6L,6L,8L,6L,4L,1L,3L,3L,6L,2L,3L,6L,6L,5L,3L,8L,2L,2L,5L,9L,8L,3L,4L,4L,7L,2L,1L,9L,9L,9L,4L,8L,2L,6L,3L,4L,4L,3L,9L,2L,6L,9L,9L,0L,9L,3L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253191Inst : IEnumerable<long>
{
public static readonly long[] Value=A253191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253191.Bytes);
public long this[int i]=>Value[i];

public static A253191Inst Instance=new A253191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253192
{
public static readonly long[] Value={ 1L,0L,5L,6L,35L,80L,309L,890L,3058L,9580L,31863L,103054L,340415L,1116032L,3688745L,12176814L,40344505L,133742500L,444262378L,1477142040L,4918099660L,16390294664L,54679621775L,182572812266L,610115196150L,2040383498748L,6828408179435L,22866979920390L,76623655367703L,256899191586880L,861774049296325L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253192Inst : IEnumerable<long>
{
public static readonly long[] Value=A253192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253192.Bytes);
public long this[int i]=>Value[i];

public static A253192Inst Instance=new A253192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253193
{
public static readonly long[] Value={ 1L,0L,-1L,-1L,0L,-2L,2L,-1L,2L,2L,-4L,3L,3L,2L,-4L,0L,2L,0L,-2L,-2L,-6L,-2L,1L,5L,-1L,0L,1L,-4L,-3L,2L,3L,5L,8L,-2L,4L,-2L,0L,0L,-3L,-4L,-1L,-2L,0L,6L,0L,0L,-1L,-6L,1L,-4L,2L,-3L,-2L,2L,-4L,-6L,2L,0L,4L,2L,-2L,6L,4L,1L,0L,6L,-4L,0L,-1L,0L,11L,-2L,9L,-2L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253193Inst : IEnumerable<long>
{
public static readonly long[] Value=A253193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253193.Bytes);
public long this[int i]=>Value[i];

public static A253193Inst Instance=new A253193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253194
{
public static readonly long[] Value={ 1L,3L,10L,39L,162L,707L,3190L,14766L,69719L,334481L,1625846L,7989908L,39631204L,198151579L,997623275L,5053274850L,25734158411L,131680565544L,676693557574L,3490897656337L,18071699948492L,93851485181749L,488815126122166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253194Inst : IEnumerable<long>
{
public static readonly long[] Value=A253194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253194.Bytes);
public long this[int i]=>Value[i];

public static A253194Inst Instance=new A253194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253195
{
public static readonly long[] Value={ 5L,8L,14L,17L,23L,26L,32L,35L,41L,44L,50L,53L,59L,62L,68L,71L,77L,80L,86L,89L,95L,98L,104L,107L,113L,116L,122L,125L,131L,134L,140L,143L,149L,152L,158L,161L,167L,170L,176L,179L,185L,188L,194L,197L,203L,206L,212L,215L,221L,224L,230L,233L,239L,242L,248L,251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253195Inst : IEnumerable<long>
{
public static readonly long[] Value=A253195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253195.Bytes);
public long this[int i]=>Value[i];

public static A253195Inst Instance=new A253195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253196
{
public static readonly long[] Value={ 1L,2L,2L,2L,1L,2L,4L,2L,2L,2L,2L,0L,1L,4L,2L,4L,2L,2L,4L,4L,2L,2L,0L,1L,2L,4L,0L,2L,2L,4L,2L,4L,4L,2L,4L,4L,2L,0L,0L,0L,1L,4L,2L,0L,2L,4L,2L,2L,8L,2L,2L,2L,0L,2L,4L,4L,4L,4L,2L,2L,0L,0L,1L,2L,4L,4L,4L,4L,2L,8L,2L,4L,2L,4L,0L,2L,4L,2L,4L,4L,0L,2L,2L,0L,0L,0L,0L,0L,1L,4L,0L,0L,0L,2L,4L,4L,2L,2L,4L,0L,4L,4L,4L,4L,4L,4L,2L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253196Inst : IEnumerable<long>
{
public static readonly long[] Value=A253196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253196.Bytes);
public long this[int i]=>Value[i];

public static A253196Inst Instance=new A253196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253197
{
public static readonly long[] Value={ 0L,1L,3L,4L,9L,15L,24L,41L,67L,108L,177L,287L,464L,753L,1219L,1972L,3193L,5167L,8360L,13529L,21891L,35420L,57313L,92735L,150048L,242785L,392835L,635620L,1028457L,1664079L,2692536L,4356617L,7049155L,11405772L,18454929L,29860703L,48315632L,78176337L,126491971L,204668308L,331160281L,535828591L,866988872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253197Inst : IEnumerable<long>
{
public static readonly long[] Value=A253197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253197.Bytes);
public long this[int i]=>Value[i];

public static A253197Inst Instance=new A253197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253198
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,10L,16L,25L,42L,68L,109L,178L,288L,465L,754L,1220L,1973L,3194L,5168L,8361L,13530L,21892L,35421L,57314L,92736L,150049L,242786L,392836L,635621L,1028458L,1664080L,2692537L,4356618L,7049156L,11405773L,18454930L,29860704L,48315633L,78176338L,126491972L,204668309L,331160282L,535828592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253198Inst : IEnumerable<long>
{
public static readonly long[] Value=A253198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253198.Bytes);
public long this[int i]=>Value[i];

public static A253198Inst Instance=new A253198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253199
{
public static readonly long[] Value={ 1L,4L,14L,52L,165L,468L,1234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253199Inst : IEnumerable<long>
{
public static readonly long[] Value=A253199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253199.Bytes);
public long this[int i]=>Value[i];

public static A253199Inst Instance=new A253199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253200
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,6L,7L,9L,10L,11L,14L,15L,18L,19L,20L,21L,22L,25L,28L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253200Inst : IEnumerable<long>
{
public static readonly long[] Value=A253200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253200.Bytes);
public long this[int i]=>Value[i];

public static A253200Inst Instance=new A253200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253201
{
public static readonly long[] Value={ 0L,1L,3L,5L,6L,7L,8L,10L,12L,14L,17L,18L,19L,20L,21L,22L,23L,24L,27L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253201Inst : IEnumerable<long>
{
public static readonly long[] Value=A253201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253201.Bytes);
public long this[int i]=>Value[i];

public static A253201Inst Instance=new A253201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253202
{
public static readonly long[] Value={ 0L,0L,0L,4L,7L,71L,2555L,24897L,970556L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253202Inst : IEnumerable<long>
{
public static readonly long[] Value=A253202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253202.Bytes);
public long this[int i]=>Value[i];

public static A253202Inst Instance=new A253202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253203
{
public static readonly long[] Value={ 9L,4L,9L,16L,9L,16L,9L,16L,25L,16L,25L,16L,25L,16L,25L,36L,25L,36L,25L,36L,25L,36L,25L,36L,49L,36L,49L,36L,49L,36L,49L,36L,49L,36L,49L,64L,49L,64L,49L,64L,49L,64L,49L,64L,49L,64L,49L,64L,81L,64L,81L,64L,81L,64L,81L,64L,81L,64L,81L,64L,81L,64L,81L,100L,81L,100L,81L,100L,81L,100L,81L,100L,81L,100L,81L,100L,81L,100L,81L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253203Inst : IEnumerable<long>
{
public static readonly long[] Value=A253203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253203.Bytes);
public long this[int i]=>Value[i];

public static A253203Inst Instance=new A253203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253204
{
public static readonly long[] Value={ 1L,3L,5L,17L,25L,257L,289L,65537L,66049L,4295098369L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253204Inst : IEnumerable<long>
{
public static readonly long[] Value=A253204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253204.Bytes);
public long this[int i]=>Value[i];

public static A253204Inst Instance=new A253204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253205
{
public static readonly long[] Value={ 1L,10L,11L,13L,17L,41L,43L,56L,91L,97L,100L,101L,106L,121L,131L,155L,157L,161L,181L,188L,221L,232L,233L,239L,254L,271L,274L,301L,305L,311L,353L,361L,365L,385L,391L,401L,421L,451L,452L,491L,494L,508L,521L,529L,541L,551L,599L,610L,617L,625L,631L,647L,650L,673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253205Inst : IEnumerable<long>
{
public static readonly long[] Value=A253205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253205.Bytes);
public long this[int i]=>Value[i];

public static A253205Inst Instance=new A253205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253206
{
public static readonly long[] Value={ 1L,-1L,-1L,0L,-1L,1L,-1L,0L,0L,1L,-1L,0L,-1L,1L,1L,0L,-1L,0L,-1L,0L,1L,1L,-1L,0L,0L,1L,0L,0L,-1L,-1L,-1L,1L,1L,1L,1L,0L,-1L,1L,1L,0L,-1L,-1L,-1L,0L,0L,1L,-1L,0L,0L,0L,1L,0L,-1L,0L,1L,0L,1L,1L,-1L,0L,-1L,1L,0L,-1L,1L,-1L,-1L,0L,1L,-1L,-1L,0L,-1L,1L,0L,0L,1L,-1L,-1L,0L,0L,1L,-1L,0L,1L,1L,1L,0L,-1L,0L,1L,0L,1L,1L,1L,-1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253206Inst : IEnumerable<long>
{
public static readonly long[] Value=A253206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253206.Bytes);
public long this[int i]=>Value[i];

public static A253206Inst Instance=new A253206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253207
{
public static readonly long[] Value={ 11L,59L,359L,1799L,7091L,22995L,64143L,159093L,359348L,752180L,1478204L,2754752L,4906202L,8402522L,13907394L,22337388L,34933761L,53348561L,79746821L,116926733L,168459797L,238853045L,333735545L,460071495L,626402322L,843120306L,1122776354L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253207Inst : IEnumerable<long>
{
public static readonly long[] Value=A253207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253207.Bytes);
public long this[int i]=>Value[i];

public static A253207Inst Instance=new A253207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253208
{
public static readonly long[] Value={ 4L,7L,19L,67L,259L,1027L,4099L,16387L,65539L,262147L,1048579L,4194307L,16777219L,67108867L,268435459L,1073741827L,4294967299L,17179869187L,68719476739L,274877906947L,1099511627779L,4398046511107L,17592186044419L,70368744177667L,281474976710659L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253208Inst : IEnumerable<long>
{
public static readonly long[] Value=A253208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253208.Bytes);
public long this[int i]=>Value[i];

public static A253208Inst Instance=new A253208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253209
{
public static readonly long[] Value={ 6L,11L,41L,221L,1301L,7781L,46661L,279941L,1679621L,10077701L,60466181L,362797061L,2176782341L,13060694021L,78364164101L,470184984581L,2821109907461L,16926659444741L,101559956668421L,609359740010501L,3656158440062981L,21936950640377861L,131621703842267141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253209Inst : IEnumerable<long>
{
public static readonly long[] Value=A253209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253209.Bytes);
public long this[int i]=>Value[i];

public static A253209Inst Instance=new A253209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253210
{
public static readonly long[] Value={ 7L,13L,55L,349L,2407L,16813L,117655L,823549L,5764807L,40353613L,282475255L,1977326749L,13841287207L,96889010413L,678223072855L,4747561509949L,33232930569607L,232630513987213L,1628413597910455L,11398895185373149L,79792266297612007L,558545864083284013L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253210Inst : IEnumerable<long>
{
public static readonly long[] Value=A253210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253210.Bytes);
public long this[int i]=>Value[i];

public static A253210Inst Instance=new A253210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253211
{
public static readonly long[] Value={ 8L,15L,71L,519L,4103L,32775L,262151L,2097159L,16777223L,134217735L,1073741831L,8589934599L,68719476743L,549755813895L,4398046511111L,35184372088839L,281474976710663L,2251799813685255L,18014398509481991L,144115188075855879L,1152921504606846983L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253211Inst : IEnumerable<long>
{
public static readonly long[] Value=A253211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253211.Bytes);
public long this[int i]=>Value[i];

public static A253211Inst Instance=new A253211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253212
{
public static readonly ulong[] Value={ 9L,17L,89L,737L,6569L,59057L,531449L,4782977L,43046729L,387420497L,3486784409L,31381059617L,282429536489L,2541865828337L,22876792454969L,205891132094657L,1853020188851849L,16677181699666577L,150094635296999129L,1350851717672992097L,12157665459056928809UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253212Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A253212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253212.Bytes);
public ulong this[int i]=>Value[i];

public static A253212Inst Instance=new A253212Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253213
{
public static readonly ulong[] Value={ 10L,19L,109L,1009L,10009L,100009L,1000009L,10000009L,100000009L,1000000009L,10000000009L,100000000009L,1000000000009L,10000000000009L,100000000000009L,1000000000000009L,10000000000000009L,100000000000000009L,1000000000000000009L,10000000000000000009UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253213Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A253213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253213.Bytes);
public ulong this[int i]=>Value[i];

public static A253213Inst Instance=new A253213Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253214
{
public static readonly long[] Value={ 3L,1L,4L,1L,5L,9L,2L,6L,5L,3L,5L,8L,9L,7L,9L,3L,0L,1L,6L,4L,9L,5L,8L,8L,8L,6L,5L,3L,1L,9L,6L,7L,2L,3L,7L,4L,6L,4L,0L,6L,8L,2L,4L,8L,8L,1L,4L,3L,8L,4L,4L,3L,9L,3L,9L,5L,8L,3L,7L,7L,3L,5L,6L,1L,9L,3L,6L,2L,8L,7L,0L,8L,6L,3L,8L,6L,2L,1L,8L,2L,6L,1L,6L,9L,8L,6L,0L,4L,9L,3L,7L,9L,0L,6L,7L,2L,3L,4L,9L,9L,5L,5L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253214Inst : IEnumerable<long>
{
public static readonly long[] Value=A253214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253214.Bytes);
public long this[int i]=>Value[i];

public static A253214Inst Instance=new A253214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253215
{
public static readonly long[] Value={ 2L,6L,6L,12L,12L,18L,18L,30L,30L,30L,30L,42L,42L,42L,42L,60L,60L,60L,60L,66L,66L,66L,66L,90L,90L,90L,90L,90L,90L,90L,90L,120L,120L,120L,120L,126L,126L,126L,126L,150L,150L,150L,150L,150L,150L,150L,150L,210L,210L,210L,210L,210L,210L,210L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253215Inst : IEnumerable<long>
{
public static readonly long[] Value=A253215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253215.Bytes);
public long this[int i]=>Value[i];

public static A253215Inst Instance=new A253215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253216
{
public static readonly long[] Value={ 1091L,15791L,30091L,369991L,421691L,501191L,661091L,1101091L,1539991L,2042591L,2210291L,2542091L,2811191L,3351191L,3512291L,3864691L,4411391L,4675591L,5960791L,5992291L,5998691L,6884191L,6918391L,7516891L,8608591L,8697791L,9297091L,9622891L,9646291L,12013091L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253216Inst : IEnumerable<long>
{
public static readonly long[] Value=A253216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253216.Bytes);
public long this[int i]=>Value[i];

public static A253216Inst Instance=new A253216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253217
{
public static readonly long[] Value={ 0L,0L,1L,19L,268L,3568L,47698L,649712L,9023385L,127419681L,1823918697L,26398702645L,385582981615L,5674890516295L,84060883775765L,1252066289632643L,18738613233957420L,281620474177057788L,4248088188086420832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253217Inst : IEnumerable<long>
{
public static readonly long[] Value=A253217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253217.Bytes);
public long this[int i]=>Value[i];

public static A253217Inst Instance=new A253217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253218
{
public static readonly long[] Value={ 1L,1L,1L,19L,102L,263L,504L,825L,1226L,1707L,2268L,2909L,3630L,4431L,5312L,6273L,7314L,8435L,9636L,10917L,12278L,13719L,15240L,16841L,18522L,20283L,22124L,24045L,26046L,28127L,30288L,32529L,34850L,37251L,39732L,42293L,44934L,47655L,50456L,53337L,56298L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253218Inst : IEnumerable<long>
{
public static readonly long[] Value=A253218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253218.Bytes);
public long this[int i]=>Value[i];

public static A253218Inst Instance=new A253218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253219
{
public static readonly long[] Value={ 3L,9L,19L,19L,268L,1249L,3140L,5986L,9792L,14558L,20284L,26970L,34616L,43222L,52788L,63314L,74800L,87246L,100652L,115018L,130344L,146630L,163876L,182082L,201248L,221374L,242460L,264506L,287512L,311478L,336404L,362290L,389136L,416942L,445708L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253219Inst : IEnumerable<long>
{
public static readonly long[] Value=A253219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253219.Bytes);
public long this[int i]=>Value[i];

public static A253219Inst Instance=new A253219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253220
{
public static readonly long[] Value={ 6L,25L,102L,268L,268L,3568L,16028L,40238L,77063L,126673L,189083L,264293L,352303L,453113L,566723L,693133L,832343L,984353L,1149163L,1326773L,1517183L,1720393L,1936403L,2165213L,2406823L,2661233L,2928443L,3208453L,3501263L,3806873L,4125283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253220Inst : IEnumerable<long>
{
public static readonly long[] Value=A253220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253220.Bytes);
public long this[int i]=>Value[i];

public static A253220Inst Instance=new A253220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253221
{
public static readonly long[] Value={ 10L,49L,263L,1249L,3568L,3568L,47698L,213155L,538444L,1039060L,1719174L,2579462L,3619974L,4840710L,6241670L,7822854L,9584262L,11525894L,13647750L,15949830L,18432134L,21094662L,23937414L,26960390L,30163590L,33547014L,37110662L,40854534L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253221Inst : IEnumerable<long>
{
public static readonly long[] Value=A253221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253221.Bytes);
public long this[int i]=>Value[i];

public static A253221Inst Instance=new A253221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253222
{
public static readonly long[] Value={ 15L,81L,504L,3140L,16028L,47698L,47698L,649712L,2913793L,7415837L,14420585L,24015795L,36221327L,51039931L,68471783L,88516883L,111175231L,136446827L,164331671L,194829763L,227941103L,263665691L,302003527L,342954611L,386518943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253222Inst : IEnumerable<long>
{
public static readonly long[] Value=A253222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253222.Bytes);
public long this[int i]=>Value[i];

public static A253222Inst Instance=new A253222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253223
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,3L,1L,1L,3L,6L,9L,1L,9L,6L,10L,25L,19L,19L,25L,10L,15L,49L,102L,19L,102L,49L,15L,21L,81L,263L,268L,268L,263L,81L,21L,28L,121L,504L,1249L,268L,1249L,504L,121L,28L,36L,169L,825L,3140L,3568L,3568L,3140L,825L,169L,36L,45L,225L,1226L,5986L,16028L,3568L,16028L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253223Inst : IEnumerable<long>
{
public static readonly long[] Value=A253223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253223.Bytes);
public long this[int i]=>Value[i];

public static A253223Inst Instance=new A253223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253224
{
public static readonly long[] Value={ 16L,132L,494L,1498L,3936L,9630L,22656L,52110L,118182L,265458L,591924L,1311966L,2892738L,6348402L,13873152L,30199422L,65504766L,141618834L,305248332L,656098110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253224Inst : IEnumerable<long>
{
public static readonly long[] Value=A253224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253224.Bytes);
public long this[int i]=>Value[i];

public static A253224Inst Instance=new A253224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253225
{
public static readonly long[] Value={ 47L,132L,306L,742L,1775L,4158L,9551L,21591L,48179L,106371L,232787L,505683L,1091603L,2343699L,5008403L,10658835L,22601747L,47771667L,100679699L,211632147L,443809811L,928710675L,1939603475L,4043571219L,8415870995L,17489199123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253225Inst : IEnumerable<long>
{
public static readonly long[] Value=A253225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253225.Bytes);
public long this[int i]=>Value[i];

public static A253225Inst Instance=new A253225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253226
{
public static readonly long[] Value={ 125L,306L,494L,914L,1709L,3241L,6231L,12122L,23800L,47037L,93377L,185908L,370806L,740423L,1479463L,2957334L,5912852L,11823649L,23644989L,47287400L,94571938L,189140715L,378277955L,756552106L,1513100064L,3026195621L,6052386361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253226Inst : IEnumerable<long>
{
public static readonly long[] Value=A253226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253226.Bytes);
public long this[int i]=>Value[i];

public static A253226Inst Instance=new A253226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253227
{
public static readonly long[] Value={ 335L,742L,914L,1498L,2543L,4490L,8216L,15476L,29780L,58148L,114620L,227276L,452276L,901940L,1800908L,3598460L,7193156L,14382116L,28759580L,57514028L,115022420L,230038676L,460070636L,920133980L,1840260068L,3680511620L,7361014076L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253227Inst : IEnumerable<long>
{
public static readonly long[] Value=A253227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253227.Bytes);
public long this[int i]=>Value[i];

public static A253227Inst Instance=new A253227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253228
{
public static readonly long[] Value={ 907L,1775L,1709L,2543L,3936L,6414L,11022L,19851L,37083L,71082L,138576L,273021L,541329L,1077324L,2148654L,4290615L,8573799L,17139390L,34269756L,68529633L,137048493L,274085280L,548157882L,1096302075L,2192589411L,4385162994L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253228Inst : IEnumerable<long>
{
public static readonly long[] Value=A253228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253228.Bytes);
public long this[int i]=>Value[i];

public static A253228Inst Instance=new A253228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253229
{
public static readonly long[] Value={ 2470L,4158L,3241L,4490L,6414L,9630L,15363L,26064L,46635L,86880L,166407L,324432L,639387L,1268136L,2524407L,5035656L,10056795L,20097648L,40177863L,80336736L,160652859L,321283416L,642542775L,1285059672L,2570091579L,5140153440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253229Inst : IEnumerable<long>
{
public static readonly long[] Value=A253229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253229.Bytes);
public long this[int i]=>Value[i];

public static A253229Inst Instance=new A253229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253230
{
public static readonly long[] Value={ 6740L,9551L,6231L,8216L,11022L,15363L,22656L,35736L,60273L,107607L,200418L,384066L,749271L,1477473L,2931552L,5837268L,11646141L,23261211L,46488558L,92940342L,185840883L,371638821L,743231436L,1486413288L,2972773497L,5945490303L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253230Inst : IEnumerable<long>
{
public static readonly long[] Value=A253230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253230.Bytes);
public long this[int i]=>Value[i];

public static A253230Inst Instance=new A253230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253231
{
public static readonly long[] Value={ 16L,47L,47L,125L,132L,125L,335L,306L,306L,335L,907L,742L,494L,742L,907L,2470L,1775L,914L,914L,1775L,2470L,6740L,4158L,1709L,1498L,1709L,4158L,6740L,18406L,9551L,3241L,2543L,2543L,3241L,9551L,18406L,50278L,21591L,6231L,4490L,3936L,4490L,6231L,21591L,50278L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253231Inst : IEnumerable<long>
{
public static readonly long[] Value=A253231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253231.Bytes);
public long this[int i]=>Value[i];

public static A253231Inst Instance=new A253231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253232
{
public static readonly long[] Value={ 61L,83L,89L,593L,1399L,2063L,2287L,2351L,2441L,3491L,5081L,5171L,5479L,6599L,9497L,12073L,16561L,17569L,21377L,23099L,23189L,28573L,29063L,32143L,36293L,36497L,36587L,39569L,49279L,61291L,62383L,65449L,66373L,71167L,72379L,75347L,81457L,88591L,92377L,94261L,104369L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253232Inst : IEnumerable<long>
{
public static readonly long[] Value=A253232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253232.Bytes);
public long this[int i]=>Value[i];

public static A253232Inst Instance=new A253232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253233
{
public static readonly long[] Value={ 4L,286L,124L,16806L,28L,70L,244L,742L,1228L,906L,1852L,154L,28L,286L,52L,66L,496L,442L,66L,1834L,344L,526974L,76L,506L,66L,70L,286L,1266L,2296L,946L,130L,5662L,112L,154L,14246L,370L,276L,8614L,2806L,2626L,112L,1558L,276L,2626L,19126L,1446L,322L,658L,176L,742L,190L,946L,5356L,742L,186L,190L,176L,8474L,2806L,2242L,148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253233Inst : IEnumerable<long>
{
public static readonly long[] Value=A253233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253233.Bytes);
public long this[int i]=>Value[i];

public static A253233Inst Instance=new A253233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253234
{
public static readonly long[] Value={ 1093L,23L,5L,3L,3457L,72673L,13L,67L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253234Inst : IEnumerable<long>
{
public static readonly long[] Value=A253234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253234.Bytes);
public long this[int i]=>Value[i];

public static A253234Inst Instance=new A253234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253235
{
public static readonly long[] Value={ 1L,12L,15L,24L,28L,30L,33L,35L,36L,40L,44L,45L,48L,51L,56L,60L,63L,65L,66L,69L,70L,72L,75L,76L,77L,80L,84L,85L,87L,88L,90L,91L,92L,95L,96L,99L,102L,104L,105L,108L,112L,115L,117L,119L,120L,123L,124L,126L,130L,132L,133L,135L,138L,140L,141L,143L,144L,145L,150L,152L,153L,154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253235Inst : IEnumerable<long>
{
public static readonly long[] Value=A253235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253235.Bytes);
public long this[int i]=>Value[i];

public static A253235Inst Instance=new A253235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253236
{
public static readonly long[] Value={ 0L,2L,3L,2L,5L,3L,7L,2L,3L,5L,11L,0L,13L,7L,0L,2L,17L,3L,19L,5L,7L,11L,23L,0L,5L,13L,3L,0L,29L,0L,31L,2L,0L,17L,0L,0L,37L,19L,13L,0L,41L,7L,43L,0L,0L,23L,47L,0L,7L,5L,0L,13L,53L,3L,11L,0L,19L,29L,59L,0L,61L,31L,0L,2L,0L,0L,67L,17L,0L,0L,71L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253236Inst : IEnumerable<long>
{
public static readonly long[] Value=A253236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253236.Bytes);
public long this[int i]=>Value[i];

public static A253236Inst Instance=new A253236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253237
{
public static readonly long[] Value={ 8L,25L,125L,121L,27L,0L,32761L,97336L,64000L,2187L,3364L,2197L,4900L,0L,1295029L,128L,143384152904L,343L,503284356L,196L,100L,2187L,2025L,542939080312L,144L,6436343L,216L,131044L,196L,6859L,225L,7744L,256L,0L,1296L,1728L,14348907L,1331L,10609L,2704L,400L,0L,441L,125L,9216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253237Inst : IEnumerable<long>
{
public static readonly long[] Value=A253237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253237.Bytes);
public long this[int i]=>Value[i];

public static A253237Inst Instance=new A253237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253238
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,3L,1L,1L,1L,2L,1L,1L,1L,2L,1L,3L,1L,2L,0L,1L,1L,4L,2L,2L,2L,1L,3L,2L,2L,3L,1L,2L,4L,4L,2L,2L,1L,2L,2L,4L,2L,3L,1L,3L,2L,4L,2L,2L,2L,3L,4L,2L,1L,2L,1L,2L,3L,3L,1L,2L,3L,3L,4L,4L,2L,2L,2L,2L,1L,5L,1L,4L,2L,3L,3L,2L,1L,5L,2L,1L,4L,4L,3L,2L,1L,2L,4L,3L,2L,3L,2L,2L,4L,2L,2L,2L,2L,3L,2L,6L,2L,4L,2L,2L,4L,5L,2L,3L,1L,3L,3L,5L,2L,3L,1L,2L,4L,4L,3L,3L,2L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253238Inst : IEnumerable<long>
{
public static readonly long[] Value=A253238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253238.Bytes);
public long this[int i]=>Value[i];

public static A253238Inst Instance=new A253238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253239
{
public static readonly long[] Value={ 1L,2L,3L,6L,7L,11L,12L,13L,14L,16L,17L,19L,20L,21L,22L,23L,24L,25L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,42L,43L,44L,45L,46L,47L,48L,49L,50L,53L,55L,56L,57L,58L,59L,64L,65L,66L,67L,72L,73L,74L,75L,77L,78L,81L,84L,85L,86L,87L,90L,91L,92L,93L,94L,95L,98L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253239Inst : IEnumerable<long>
{
public static readonly long[] Value=A253239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253239.Bytes);
public long this[int i]=>Value[i];

public static A253239Inst Instance=new A253239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253240
{
public static readonly long[] Value={ 1L,1L,-1L,1L,0L,1L,1L,1L,2L,1L,1L,2L,3L,3L,1L,1L,3L,4L,7L,2L,1L,1L,4L,5L,13L,5L,5L,1L,1L,5L,6L,21L,10L,31L,1L,1L,1L,6L,7L,31L,17L,121L,3L,7L,1L,1L,7L,8L,43L,26L,341L,7L,127L,2L,1L,1L,8L,9L,57L,37L,781L,13L,1093L,17L,3L,1L,1L,9L,10L,73L,50L,1555L,21L,5461L,82L,73L,1L,1L,1L,10L,11L,91L,65L,2801L,31L,19531L,257L,757L,11L,11L,1L,1L,11L,12L,111L,82L,4681L,43L,55987L,626L,4161L,61L,2047L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253240Inst : IEnumerable<long>
{
public static readonly long[] Value=A253240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253240.Bytes);
public long this[int i]=>Value[i];

public static A253240Inst Instance=new A253240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253241
{
public static readonly long[] Value={ 0L,2L,4L,6L,8L,10L,13L,39L,65L,91L,117L,143L,13L,26L,39L,52L,65L,78L,91L,104L,117L,130L,143L,169L,26L,39L,52L,65L,78L,91L,104L,117L,130L,143L,169L,169L,39L,52L,65L,78L,91L,104L,117L,130L,143L,169L,169L,507L,52L,65L,78L,91L,104L,117L,130L,143L,169L,169L,507L,676L,65L,78L,91L,104L,117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253241Inst : IEnumerable<long>
{
public static readonly long[] Value=A253241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253241.Bytes);
public long this[int i]=>Value[i];

public static A253241Inst Instance=new A253241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253242
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,2L,-1L,0L,0L,1L,0L,0L,1L,1L,0L,2L,0L,1L,1L,0L,0L,2L,1L,0L,1L,-1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253242Inst : IEnumerable<long>
{
public static readonly long[] Value=A253242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253242.Bytes);
public long this[int i]=>Value[i];

public static A253242Inst Instance=new A253242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253243
{
public static readonly long[] Value={ 1L,0L,-2L,2L,0L,-4L,1L,0L,0L,2L,0L,0L,3L,0L,-4L,2L,0L,0L,2L,0L,-2L,0L,0L,-4L,2L,0L,0L,2L,0L,-4L,1L,0L,-4L,4L,0L,0L,0L,0L,0L,2L,0L,0L,3L,0L,0L,2L,0L,-4L,2L,0L,-4L,0L,0L,0L,4L,0L,-2L,2L,0L,-4L,2L,0L,0L,0L,0L,0L,0L,0L,-8L,2L,0L,0L,1L,0L,0L,4L,0L,-4L,2L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253243Inst : IEnumerable<long>
{
public static readonly long[] Value=A253243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253243.Bytes);
public long this[int i]=>Value[i];

public static A253243Inst Instance=new A253243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253244
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,3L,9L,23L,65L,186L,507L,1380L,3764L,10270L,28001L,76568L,209749L,575900L,1584769L,4371279L,12083764L,33477190L,92939305L,258537475L,720575302L,2012021934L,5627886815L,15768237664L,44249863373L,124365487416L,350038837208L,986579529425L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253244Inst : IEnumerable<long>
{
public static readonly long[] Value=A253244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253244.Bytes);
public long this[int i]=>Value[i];

public static A253244Inst Instance=new A253244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253245
{
public static readonly long[] Value={ 37L,1117L,1319L,1723L,4759L,89101L,97103L,101107L,113131L,151163L,181193L,223229L,227233L,239251L,251263L,293311L,313331L,337349L,389401L,421433L,461467L,491503L,587599L,631643L,647659L,683701L,691709L,701719L,739751L,761773L,809821L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253245Inst : IEnumerable<long>
{
public static readonly long[] Value=A253245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253245.Bytes);
public long this[int i]=>Value[i];

public static A253245Inst Instance=new A253245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253246
{
public static readonly long[] Value={ 3L,2L,12L,16L,8L,52L,16L,40L,22L,28L,64L,76L,28L,42L,96L,26L,24L,30L,136L,144L,148L,26L,168L,180L,196L,50L,102L,106L,20L,112L,126L,10L,92L,138L,300L,304L,156L,328L,336L,86L,178L,180L,190L,388L,396L,198L,30L,448L,456L,460L,116L,160L,484L,250L,128L,262L,268L,544L,138L,564L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253246Inst : IEnumerable<long>
{
public static readonly long[] Value=A253246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253246.Bytes);
public long this[int i]=>Value[i];

public static A253246Inst Instance=new A253246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253247
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,1L,7L,8L,9L,5L,11L,4L,13L,7L,5L,16L,17L,9L,19L,10L,21L,11L,23L,8L,25L,13L,27L,7L,29L,5L,31L,32L,33L,17L,35L,36L,37L,19L,39L,40L,41L,7L,43L,11L,45L,23L,47L,16L,49L,25L,51L,26L,53L,27L,55L,14L,57L,29L,59L,10L,61L,31L,63L,64L,65L,11L,67L,17L,69L,35L,71L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253247Inst : IEnumerable<long>
{
public static readonly long[] Value=A253247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253247.Bytes);
public long this[int i]=>Value[i];

public static A253247Inst Instance=new A253247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253248
{
public static readonly long[] Value={ 1L,2L,3L,4L,4L,6L,6L,8L,8L,10L,8L,12L,10L,13L,14L,16L,13L,18L,14L,20L,19L,20L,17L,24L,20L,25L,24L,27L,19L,30L,23L,31L,29L,30L,30L,36L,25L,35L,34L,39L,30L,42L,31L,41L,41L,41L,34L,48L,38L,48L,44L,51L,36L,53L,46L,55L,48L,51L,42L,60L,43L,57L,59L,63L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253248Inst : IEnumerable<long>
{
public static readonly long[] Value=A253248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253248.Bytes);
public long this[int i]=>Value[i];

public static A253248Inst Instance=new A253248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253249
{
public static readonly long[] Value={ 1L,3L,3L,7L,3L,11L,3L,15L,7L,11L,3L,31L,3L,11L,11L,31L,3L,31L,3L,31L,11L,11L,3L,79L,7L,11L,15L,31L,3L,51L,3L,63L,11L,11L,11L,103L,3L,11L,11L,79L,3L,51L,3L,31L,31L,11L,3L,191L,7L,31L,11L,31L,3L,79L,11L,79L,11L,11L,3L,175L,3L,11L,31L,127L,11L,51L,3L,31L,11L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253249Inst : IEnumerable<long>
{
public static readonly long[] Value=A253249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253249.Bytes);
public long this[int i]=>Value[i];

public static A253249Inst Instance=new A253249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253250
{
public static readonly long[] Value={ 2L,3L,4L,3L,4L,4L,4L,4L,6L,4L,6L,5L,4L,5L,4L,7L,5L,6L,5L,5L,6L,5L,7L,5L,5L,6L,5L,5L,8L,5L,6L,8L,6L,7L,6L,6L,8L,5L,6L,7L,5L,6L,6L,6L,6L,7L,9L,5L,8L,5L,6L,7L,6L,5L,4L,9L,9L,6L,6L,6L,8L,8L,6L,6L,10L,5L,8L,9L,9L,7L,8L,5L,6L,8L,5L,8L,8L,7L,9L,8L,6L,6L,7L,8L,7L,8L,5L,6L,7L,6L,8L,6L,8L,5L,8L,5L,8L,10L,9L,11L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253250Inst : IEnumerable<long>
{
public static readonly long[] Value=A253250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253250.Bytes);
public long this[int i]=>Value[i];

public static A253250Inst Instance=new A253250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253251
{
public static readonly long[] Value={ 1L,2L,7L,8L,9L,10L,11L,20L,25L,29L,32L,35L,37L,39L,41L,43L,45L,47L,49L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,90L,91L,92L,93L,94L,95L,96L,97L,98L,99L,100L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253251Inst : IEnumerable<long>
{
public static readonly long[] Value=A253251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253251.Bytes);
public long this[int i]=>Value[i];

public static A253251Inst Instance=new A253251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253252
{
public static readonly long[] Value={ 29L,41L,43L,61L,1021L,1049L,1061L,1063L,1229L,1289L,1427L,1429L,1481L,1483L,1487L,1489L,1607L,1609L,1621L,1667L,1669L,2129L,2141L,2143L,2237L,2239L,2309L,2341L,2381L,2383L,2549L,2657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253252Inst : IEnumerable<long>
{
public static readonly long[] Value=A253252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253252.Bytes);
public long this[int i]=>Value[i];

public static A253252Inst Instance=new A253252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253253
{
public static readonly long[] Value={ 1L,23L,2L,3L,4L,67L,6L,89L,5L,337L,8L,1213L,9L,283L,379L,7L,859L,17L,10L,43L,1061L,13L,14L,25L,421L,37L,11L,41L,293L,433L,12L,53L,1667L,15L,16L,3637L,21L,349L,20L,449L,19L,4243L,24L,35L,2273L,1549L,1187L,373L,18L,5051L,28L,51L,2677L,1091L,463L,5657L,2879L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253253Inst : IEnumerable<long>
{
public static readonly long[] Value=A253253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253253.Bytes);
public long this[int i]=>Value[i];

public static A253253Inst Instance=new A253253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253254
{
public static readonly long[] Value={ 11L,5L,29L,19L,47L,7L,13L,37L,83L,23L,101L,13L,17L,5L,137L,73L,31L,41L,173L,13L,191L,23L,19L,109L,227L,59L,7L,127L,263L,31L,281L,29L,23L,11L,317L,163L,67L,43L,353L,181L,53L,43L,389L,199L,37L,47L,17L,31L,443L,113L,461L,53L,479L,61L,71L,23L,103L,131L,41L,271L,31L,7L,569L,17L,587L,149L,17L,307L,89L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253254Inst : IEnumerable<long>
{
public static readonly long[] Value=A253254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253254.Bytes);
public long this[int i]=>Value[i];

public static A253254Inst Instance=new A253254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253255
{
public static readonly BigInteger[] Value={ 1L,4L,26L,202L,1731L,15780L,150117L,1473292L,14807363L,151638550L,1576616125L,16598802248L,176599380271L,1895767748376L,20508188211018L,223348309510194L,2446792909432683L,26944972018189698L,298111489130625351L,3312016395569631402L,BigInteger.Parse("36935315970911333184"),BigInteger.Parse("413308467174788509668") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253255Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A253255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253255.Bytes);
public BigInteger this[int i]=>Value[i];

public static A253255Inst Instance=new A253255Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253256
{
public static readonly BigInteger[] Value={ 1L,2L,11L,79L,647L,5727L,53367L,515802L,5123303L,51977485L,536320688L,5610909773L,59379328267L,634538481389L,6837466955193L,74210071037031L,810527496757335L,8901979424068377L,98253966680382102L,1089260346498608721L,12123804391067414676UL,BigInteger.Parse("135427509933882292680"),BigInteger.Parse("1517725698030921469890") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253256Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A253256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253256.Bytes);
public BigInteger this[int i]=>Value[i];

public static A253256Inst Instance=new A253256Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253257
{
public static readonly long[] Value={ 1L,2L,3L,1L,3L,12L,47L,9L,1L,100L,502L,6L,3L,1817L,1L,362L,3141L,4L,104L,50L,14157L,251L,222L,3L,27L,76L,25L,5423L,416L,73L,28764L,181L,488L,3860L,1249L,2L,138L,52L,1L,25L,8734L,65719L,7089L,214L,15L,111L,7L,990L,6254L,20L,1047L,38L,367L,880L,435L,3712L,3287L,208L,5194L,598L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253257Inst : IEnumerable<long>
{
public static readonly long[] Value=A253257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253257.Bytes);
public long this[int i]=>Value[i];

public static A253257Inst Instance=new A253257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253258
{
public static readonly long[] Value={ 1L,2L,6L,3L,12L,60L,4L,15L,72L,120L,5L,18L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253258Inst : IEnumerable<long>
{
public static readonly long[] Value=A253258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253258.Bytes);
public long this[int i]=>Value[i];

public static A253258Inst Instance=new A253258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253259
{
public static readonly long[] Value={ 1L,1L,17L,93L,465L,1746L,5741L,16238L,41650L,97407L,212412L,434767L,845366L,1569344L,2801696L,4828140L,8069053L,13114785L,20796651L,32242621L,48986553L,73052382L,107114645L,154621230L,220021932L,308940815L,428492880L,587520315L,797019526L,1070458096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253259Inst : IEnumerable<long>
{
public static readonly long[] Value=A253259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253259.Bytes);
public long this[int i]=>Value[i];

public static A253259Inst Instance=new A253259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253260
{
public static readonly long[] Value={ 16L,36L,64L,81L,100L,121L,144L,196L,225L,256L,324L,400L,441L,484L,576L,625L,676L,729L,784L,900L,1024L,1089L,1156L,1225L,1296L,1444L,1521L,1600L,1764L,1936L,2025L,2116L,2304L,2401L,2500L,2601L,2704L,2916L,3025L,3136L,3249L,3364L,3600L,3844L,3969L,4096L,4225L,4356L,4624L,4761L,4900L,5184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253260Inst : IEnumerable<long>
{
public static readonly long[] Value=A253260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253260.Bytes);
public long this[int i]=>Value[i];

public static A253260Inst Instance=new A253260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253261
{
public static readonly long[] Value={ 81L,121L,225L,441L,625L,729L,1089L,1225L,1521L,2025L,2401L,2601L,3025L,3249L,3969L,4225L,4761L,5625L,5929L,6561L,7225L,7569L,8281L,8649L,9025L,9801L,11025L,12321L,13225L,13689L,14161L,14641L,15129L,15625L,16641L,17689L,18225L,19881L,20449L,21025L,21609L,23409L,24025L,25281L,25921L,27225L,28561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253261Inst : IEnumerable<long>
{
public static readonly long[] Value=A253261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253261.Bytes);
public long this[int i]=>Value[i];

public static A253261Inst Instance=new A253261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253262
{
public static readonly long[] Value={ 0L,1L,2L,2L,1L,0L,-1L,-2L,-2L,-1L,0L,1L,2L,2L,1L,0L,-1L,-2L,-2L,-1L,0L,1L,2L,2L,1L,0L,-1L,-2L,-2L,-1L,0L,1L,2L,2L,1L,0L,-1L,-2L,-2L,-1L,0L,1L,2L,2L,1L,0L,-1L,-2L,-2L,-1L,0L,1L,2L,2L,1L,0L,-1L,-2L,-2L,-1L,0L,1L,2L,2L,1L,0L,-1L,-2L,-2L,-1L,0L,1L,2L,2L,1L,0L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253262Inst : IEnumerable<long>
{
public static readonly long[] Value=A253262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253262.Bytes);
public long this[int i]=>Value[i];

public static A253262Inst Instance=new A253262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253263
{
public static readonly long[] Value={ 1L,1L,73L,1417L,19834L,190131L,1398547L,8246011L,40837569L,174901563L,664006236L,2274999093L,7139338769L,20758868781L,56466073587L,144806582536L,352420554194L,818441723112L,1822255658908L,3905392549491L,8084697432576L,16214886608495L,31590986308810L,59926495673780L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253263Inst : IEnumerable<long>
{
public static readonly long[] Value=A253263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253263.Bytes);
public long this[int i]=>Value[i];

public static A253263Inst Instance=new A253263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253264
{
public static readonly long[] Value={ 2L,1644103L,3892831L,5178193L,5497949L,5657699L,11078437L,13379917L,14471147L,14890693L,19861879L,25219343L,27671803L,28012511L,29878997L,31848277L,32550769L,34190399L,40630441L,42081719L,47187919L,53964661L,54795553L,55912781L,59327927L,64749281L,68818993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253264Inst : IEnumerable<long>
{
public static readonly long[] Value=A253264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253264.Bytes);
public long this[int i]=>Value[i];

public static A253264Inst Instance=new A253264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253265
{
public static readonly BigInteger[] Value={ 1L,7L,82L,877L,9565L,103960L,1130701L,12296275L,133724242L,1454268793L,15815379409L,171994465072L,1870463946217L,20341557798991L,221217294787570L,2405769114915733L,26163076626035413L,284527128680078536L,3094272440210485525L,BigInteger.Parse("33650646877362841531"),BigInteger.Parse("365955505581792121138") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253265Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A253265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253265.Bytes);
public BigInteger this[int i]=>Value[i];

public static A253265Inst Instance=new A253265Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253266
{
public static readonly long[] Value={ 14399L,34595L,82943L,89999L,100793L,116963L,158389L,172975L,224675L,244783L,245021L,266255L,278783L,281957L,285155L,304703L,331177L,338723L,343387L,380545L,417571L,446369L,447557L,484415L,497021L,532763L,580601L,585221L,588115L,590359L,608399L,619157L,627263L,629993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253266Inst : IEnumerable<long>
{
public static readonly long[] Value=A253266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253266.Bytes);
public long this[int i]=>Value[i];

public static A253266Inst Instance=new A253266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253267
{
public static readonly long[] Value={ 1L,0L,9L,6L,4L,1L,4L,0L,7L,2L,5L,0L,7L,3L,2L,4L,4L,2L,3L,1L,1L,0L,2L,1L,5L,9L,9L,8L,8L,4L,4L,4L,4L,0L,3L,7L,5L,9L,4L,5L,9L,2L,9L,6L,0L,8L,7L,7L,7L,6L,9L,7L,9L,3L,8L,4L,6L,5L,0L,5L,6L,8L,1L,3L,7L,8L,0L,1L,4L,0L,5L,2L,1L,9L,3L,3L,3L,3L,6L,7L,0L,7L,3L,1L,2L,6L,9L,2L,8L,7L,5L,4L,6L,4L,1L,6L,9L,3L,7L,3L,9L,4L,1L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253267Inst : IEnumerable<long>
{
public static readonly long[] Value=A253267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253267.Bytes);
public long this[int i]=>Value[i];

public static A253267Inst Instance=new A253267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253268
{
public static readonly BigInteger[] Value={ 1L,1L,8L,648L,2025000L,530841600000L,BigInteger.Parse("33309523161907200000"),BigInteger.Parse("1259861409934788058133299200000"),BigInteger.Parse("76494996113757662751632456649087438028800000"),BigInteger.Parse("19375812441937279261781767910157290423127539712000000000000000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253268Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A253268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253268.Bytes);
public BigInteger this[int i]=>Value[i];

public static A253268Inst Instance=new A253268Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253269
{
public static readonly long[] Value={ 89391959L,89591959L,519512471L,519512473L,531324041L,561324041L,699023791L,699023891L,874481011L,874487011L,1862537503L,2232483271L,2232483871L,2608559351L,3127181789L,3157181789L,3928401949L,3928401989L,4070171669L,4070171969L,5225628323L,5309756339L,5525628323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253269Inst : IEnumerable<long>
{
public static readonly long[] Value=A253269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253269.Bytes);
public long this[int i]=>Value[i];

public static A253269Inst Instance=new A253269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253270
{
public static readonly long[] Value={ 1L,1L,1L,8L,8L,6L,7L,4L,4L,3L,8L,6L,1L,7L,7L,8L,9L,5L,0L,1L,7L,3L,5L,3L,5L,5L,6L,9L,0L,5L,5L,7L,7L,1L,1L,0L,0L,5L,4L,9L,2L,6L,7L,2L,6L,4L,2L,4L,2L,2L,2L,3L,7L,4L,2L,8L,1L,5L,7L,1L,2L,2L,5L,3L,1L,3L,1L,8L,0L,1L,4L,3L,2L,9L,5L,7L,3L,2L,0L,6L,6L,5L,0L,3L,9L,0L,6L,7L,0L,8L,9L,6L,4L,8L,3L,0L,6L,8L,3L,0L,1L,1L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253270Inst : IEnumerable<long>
{
public static readonly long[] Value=A253270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253270.Bytes);
public long this[int i]=>Value[i];

public static A253270Inst Instance=new A253270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253271
{
public static readonly long[] Value={ 1L,1L,6L,7L,6L,3L,7L,5L,7L,9L,1L,5L,9L,4L,5L,2L,9L,2L,9L,1L,8L,3L,9L,5L,0L,3L,0L,2L,0L,0L,6L,6L,7L,0L,8L,7L,1L,7L,5L,6L,9L,0L,1L,4L,3L,8L,8L,4L,0L,8L,8L,1L,7L,0L,2L,2L,1L,1L,0L,1L,3L,0L,5L,8L,0L,6L,0L,8L,8L,7L,1L,5L,6L,5L,3L,7L,5L,0L,8L,0L,1L,1L,0L,5L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253271Inst : IEnumerable<long>
{
public static readonly long[] Value=A253271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253271.Bytes);
public long this[int i]=>Value[i];

public static A253271Inst Instance=new A253271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253272
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,3L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,5L,6L,6L,7L,6L,7L,6L,6L,6L,7L,7L,7L,7L,7L,7L,6L,7L,7L,8L,7L,8L,7L,8L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,7L,8L,7L,9L,8L,9L,8L,9L,8L,9L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,7L,9L,8L,9L,8L,10L,9L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253272Inst : IEnumerable<long>
{
public static readonly long[] Value=A253272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253272.Bytes);
public long this[int i]=>Value[i];

public static A253272Inst Instance=new A253272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253273
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,3L,1L,4L,7L,4L,1L,5L,12L,14L,5L,1L,6L,18L,30L,25L,6L,1L,7L,25L,53L,66L,41L,7L,1L,8L,33L,84L,136L,132L,63L,8L,1L,9L,42L,124L,244L,315L,245L,92L,9L,1L,10L,52L,174L,400L,636L,673L,428L,129L,10L,1L,11L,63L,235L,615L,1152L,1522L,1346L,711L,175L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253273Inst : IEnumerable<long>
{
public static readonly long[] Value=A253273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253273.Bytes);
public long this[int i]=>Value[i];

public static A253273Inst Instance=new A253273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253274
{
public static readonly long[] Value={ 1L,0L,2L,0L,3L,0L,3L,2L,3L,5L,3L,6L,2L,12L,3L,13L,3L,9L,6L,13L,10L,9L,7L,13L,9L,13L,5L,14L,6L,12L,11L,26L,0L,14L,15L,17L,6L,20L,15L,18L,17L,35L,10L,8L,23L,11L,15L,10L,16L,29L,32L,12L,19L,27L,25L,26L,18L,24L,33L,22L,36L,13L,24L,18L,24L,43L,16L,29L,35L,18L,12L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253274Inst : IEnumerable<long>
{
public static readonly long[] Value=A253274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253274.Bytes);
public long this[int i]=>Value[i];

public static A253274Inst Instance=new A253274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253275
{
public static readonly long[] Value={ 0L,1L,2L,5L,7L,9L,14L,17L,20L,23L,32L,31L,43L,41L,45L,53L,67L,57L,80L,71L,80L,87L,108L,91L,116L,113L,122L,121L,155L,121L,172L,153L,164L,171L,183L,165L,225L,203L,211L,201L,261L,205L,280L,241L,245L,271L,318L,253L,324L,287L,317L,309L,379L,305L,363L,335L,374L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253275Inst : IEnumerable<long>
{
public static readonly long[] Value=A253275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253275.Bytes);
public long this[int i]=>Value[i];

public static A253275Inst Instance=new A253275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253276
{
public static readonly BigInteger[] Value={ 1L,1L,7L,120L,3157L,109935L,4754200L,245722477L,14779601837L,1014260971581L,78214593177825L,6696084566881710L,630196627700087272L,BigInteger.Parse("64671387743952373150"),BigInteger.Parse("7186999700934499032405"),BigInteger.Parse("859879811676654352591875"),BigInteger.Parse("110201017079975901129209565"),BigInteger.Parse("15061748014412378814910531365") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253276Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A253276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253276.Bytes);
public BigInteger this[int i]=>Value[i];

public static A253276Inst Instance=new A253276Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253277
{
public static readonly long[] Value={ 3L,6L,9L,12L,18L,21L,24L,27L,30L,33L,36L,39L,42L,48L,49L,54L,60L,63L,66L,72L,75L,78L,81L,84L,90L,96L,99L,108L,114L,117L,120L,126L,132L,138L,144L,147L,150L,156L,162L,168L,180L,189L,192L,196L,198L,204L,210L,216L,222L,225L,227L,228L,234L,240L,243L,252L,264L,270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253277Inst : IEnumerable<long>
{
public static readonly long[] Value=A253277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253277.Bytes);
public long this[int i]=>Value[i];

public static A253277Inst Instance=new A253277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253278
{
public static readonly long[] Value={ 1L,2L,3L,4L,8L,9L,11L,16L,17L,19L,27L,32L,33L,43L,51L,57L,59L,64L,67L,73L,81L,83L,89L,97L,99L,107L,113L,121L,128L,129L,131L,139L,146L,153L,163L,171L,177L,178L,179L,187L,193L,201L,209L,211L,227L,233L,241L,243L,249L,251L,256L,267L,281L,283L,289L,292L,297L,307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253278Inst : IEnumerable<long>
{
public static readonly long[] Value=A253278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253278.Bytes);
public long this[int i]=>Value[i];

public static A253278Inst Instance=new A253278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253279
{
public static readonly long[] Value={ 1L,2L,6L,3L,12L,4L,10L,5L,20L,8L,14L,16L,18L,9L,15L,21L,7L,28L,22L,24L,26L,30L,25L,35L,40L,32L,34L,36L,38L,42L,27L,33L,39L,45L,48L,56L,44L,70L,46L,50L,52L,13L,65L,60L,51L,75L,55L,66L,54L,57L,72L,58L,62L,64L,68L,78L,63L,69L,81L,84L,80L,74L,76L,82L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253279Inst : IEnumerable<long>
{
public static readonly long[] Value=A253279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253279.Bytes);
public long this[int i]=>Value[i];

public static A253279Inst Instance=new A253279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253280
{
public static readonly BigInteger[] Value={ 3795L,8925840L,56446139763L,568059199631352L,4114789794835622912L,BigInteger.Parse("75005556404194608192050"),BigInteger.Parse("1744054672674891153663590400"),BigInteger.Parse("49598666989151226098104244512918"),BigInteger.Parse("1754638089240473418053140582402752512") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253280Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A253280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253280.Bytes);
public BigInteger this[int i]=>Value[i];

public static A253280Inst Instance=new A253280Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A253281
{
public static readonly long[] Value={ 0L,1L,2L,1L,3L,2L,3L,3L,3L,4L,4L,4L,3L,5L,5L,4L,5L,4L,5L,6L,5L,3L,5L,5L,5L,6L,6L,4L,4L,4L,5L,6L,6L,6L,5L,5L,4L,5L,4L,6L,7L,6L,5L,6L,5L,5L,5L,5L,5L,7L,7L,5L,6L,6L,6L,6L,6L,5L,6L,6L,7L,6L,6L,6L,7L,7L,6L,7L,6L,6L,7L,6L,6L,7L,6L,7L,8L,7L,6L,7L,7L,6L,7L,7L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A253281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A253281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A253281Inst : IEnumerable<long>
{
public static readonly long[] Value=A253281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A253281.Bytes);
public long this[int i]=>Value[i];

public static A253281Inst Instance=new A253281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}