using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A178105
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,4L,0L,6L,0L,6L,0L,0L,0L,4L,0L,0L,0L,6L,6L,10L,0L,4L,0L,6L,0L,6L,0L,14L,0L,4L,9L,6L,0L,8L,0L,8L,6L,4L,0L,10L,0L,6L,15L,12L,0L,4L,20L,6L,18L,6L,0L,18L,0L,4L,6L,6L,10L,9L,0L,14L,9L,4L,0L,6L,0L,6L,12L,8L,21L,4L,0L,6L,6L,6L,0L,16L,20L,4L,18L,6L,0L,6L,28L,10L,9L,4L,15L,9L,0L,6L,6L,14L };
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
public class A178105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178105Inst : IEnumerable<long>
{
public static readonly long[] Value=A178105.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178105.Bytes);
public long this[int i]=>Value[i];

public static A178105Inst Instance=new A178105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178106
{
public static readonly long[] Value={ 33820044L,28133728L,18569808L,10127744L,5015108L,2289760L,1036368L,435040L,184104L,73056L,28064L,10336L,3760L,1088L,352L,96L,16L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
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
public class A178106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178106Inst : IEnumerable<long>
{
public static readonly long[] Value=A178106.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178106.Bytes);
public long this[int i]=>Value[i];

public static A178106Inst Instance=new A178106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178107
{
public static readonly long[] Value={ 1L,0L,1L,-1L,0L,1L,0L,-2L,0L,1L,3L,0L,-5L,0L,1L,0L,9L,0L,-8L,0L,1L,-15L,0L,34L,0L,-13L,0L,1L,0L,-60L,0L,74L,0L,-18L,0L,1L,105L,0L,-298L,0L,165L,0L,-25L,0L,1L,0L,525L,0L,-816L,0L,291L,0L,-32L,0L,1L,-945L,0L,3207L,0L,-2301L,0L,516L,0L,-41L,0L,1L,0L,-5670L,0L,10551L,0L,-4920L,0L,804L,0L };
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
public class A178107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178107Inst : IEnumerable<long>
{
public static readonly long[] Value=A178107.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178107.Bytes);
public long this[int i]=>Value[i];

public static A178107Inst Instance=new A178107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178108
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,0L,2L,0L,1L,2L,0L,5L,0L,1L,0L,7L,0L,8L,0L,1L,7L,0L,31L,0L,13L,0L,1L,0L,38L,0L,70L,0L,18L,0L,1L,38L,0L,248L,0L,160L,0L,25L,0L,1L,0L,286L,0L,728L,0L,285L,0L,32L,0L,1L,286L,0L,2470L,0L,2153L,0L,509L,0L,41L,0L,1L,0L,2756L,0L,8929L,0L,4698L,0L,796L,0L,50L,0L,1L,2756L,0L,29543L,0L };
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
public class A178108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178108Inst : IEnumerable<long>
{
public static readonly long[] Value=A178108.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178108.Bytes);
public long this[int i]=>Value[i];

public static A178108Inst Instance=new A178108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178109
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,4L,0L,6L,0L,6L,0L,0L,0L,4L,0L,0L,0L,8L,6L,10L,0L,8L,0L,14L,0L,14L,0L,15L,0L,14L,9L,14L,0L,9L,0L,10L,15L,20L,0L,22L,0L,22L,21L,18L,0L,21L,20L,22L,24L,24L,0L,26L,0L,28L,24L,30L,10L,28L,0L,30L,24L,26L,0L,33L,0L,30L,20L,30L,21L,28L,0L,38L,33L,38L,0L,28L,20L,36L };
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
public class A178109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178109Inst : IEnumerable<long>
{
public static readonly long[] Value=A178109.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178109.Bytes);
public long this[int i]=>Value[i];

public static A178109Inst Instance=new A178109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178110
{
public static readonly long[] Value={ 16L,18L,26L,27L,32L,34L,40L,45L,50L,56L,58L,63L,64L,72L,74L,80L,81L,82L,88L,90L,98L,99L };
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
public class A178110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178110Inst : IEnumerable<long>
{
public static readonly long[] Value=A178110.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178110.Bytes);
public long this[int i]=>Value[i];

public static A178110Inst Instance=new A178110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178111
{
public static readonly long[] Value={ 1L,0L,1L,-1L,0L,1L,0L,-1L,0L,1L,1L,0L,-2L,0L,1L,0L,1L,0L,-2L,0L,1L,-1L,0L,3L,0L,-3L,0L,1L,0L,-1L,0L,3L,0L,-3L,0L,1L,1L,0L,-4L,0L,6L,0L,-4L,0L,1L,0L,1L,0L,-4L,0L,6L,0L,-4L,0L,1L,-1L,0L,5L,0L,-10L,0L,10L,0L,-5L,0L,1L,0L,-1L,0L,5L,0L,-10L,0L,10L,0L,-5L,0L,1L,1L,0L,-6L,0L,15L,0L,-20L,0L,15L,0L,-6L,0L,1L };
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
public class A178111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178111Inst : IEnumerable<long>
{
public static readonly long[] Value=A178111.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178111.Bytes);
public long this[int i]=>Value[i];

public static A178111Inst Instance=new A178111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178112
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,2L,0L,1L,0L,1L,0L,2L,0L,1L,1L,0L,3L,0L,3L,0L,1L,0L,1L,0L,3L,0L,3L,0L,1L,1L,0L,4L,0L,6L,0L,4L,0L,1L,0L,1L,0L,4L,0L,6L,0L,4L,0L,1L,1L,0L,5L,0L,10L,0L,10L,0L,5L,0L,1L,0L,1L,0L,5L,0L,10L,0L,10L,0L,5L,0L,1L,1L,0L,6L,0L,15L,0L,20L,0L,15L,0L,6L,0L,1L };
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
public class A178112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178112Inst : IEnumerable<long>
{
public static readonly long[] Value=A178112.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178112.Bytes);
public long this[int i]=>Value[i];

public static A178112Inst Instance=new A178112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178113
{
public static readonly long[] Value={ 1L,2L,2L,4L,5L,10L,13L,26L,35L,70L,96L,192L,267L,534L,750L,1500L,2123L,4246L,6046L,12092L,17303L,34606L,49721L,99442L,143365L,286730L,414584L,829168L,1201917L,2403834L,3492117L,6984234L,10165779L,20331558L,29643870L,59287740L,86574831L,173149662L };
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
public class A178113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178113Inst : IEnumerable<long>
{
public static readonly long[] Value=A178113.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178113.Bytes);
public long this[int i]=>Value[i];

public static A178113Inst Instance=new A178113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178114
{
public static readonly long[] Value={ 1L,1L,-1L,-3L,0L,8L,6L,-21L,-37L,45L,175L,-22L,-703L,-533L,2370L,4321L,-5930L,-23560L,3534L,104035L,81083L,-376267L,-705158L,993738L,4047745L,-604007L,-18622243L,-14895477L,69622834L,133284470L,-188549209L,-784970693L,110402283L };
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
public class A178114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178114Inst : IEnumerable<long>
{
public static readonly long[] Value=A178114.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178114.Bytes);
public long this[int i]=>Value[i];

public static A178114Inst Instance=new A178114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178115
{
public static readonly long[] Value={ 1L,-2L,-2L,5L,5L,-13L,-13L,34L,34L,-89L,-89L,233L,233L,-610L,-610L,1597L,1597L,-4181L,-4181L,10946L,10946L,-28657L,-28657L,75025L,75025L,-196418L,-196418L,514229L,514229L,-1346269L,-1346269L,3524578L,3524578L,-9227465L,-9227465L,24157817L };
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
public class A178115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178115Inst : IEnumerable<long>
{
public static readonly long[] Value=A178115.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178115.Bytes);
public long this[int i]=>Value[i];

public static A178115Inst Instance=new A178115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178116
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,0L,3L,0L,1L,4L,0L,7L,0L,1L,0L,22L,0L,13L,0L,1L,36L,0L,85L,0L,22L,0L,1L,0L,300L,0L,241L,0L,34L,0L,1L,576L,0L,1660L,0L,593L,0L,50L,0L,1L,0L,6576L,0L,6480L,0L,1273L,0L,70L,0L,1L,14400L,0L,48076L,0L,21305L,0L,2523L,0L,95L,0L,1L,0L,211680L,0L,242476L,0L,59495L,0L,4623L };
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
public class A178116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178116Inst : IEnumerable<long>
{
public static readonly long[] Value=A178116.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178116.Bytes);
public long this[int i]=>Value[i];

public static A178116Inst Instance=new A178116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178117
{
public static readonly long[] Value={ 1L,0L,1L,-1L,0L,1L,0L,-3L,0L,1L,3L,0L,-7L,0L,1L,0L,17L,0L,-13L,0L,1L,-17L,0L,69L,0L,-22L,0L,1L,0L,-155L,0L,201L,0L,-34L,0L,1L,155L,0L,-959L,0L,507L,0L,-50L,0L,1L,0L,2073L,0L,-4001L,0L,1107L,0L,-70L,0L,1L,-2073L,0L,18077L,0L,-13964L,0L,2227L,0L,-95L,0L,1L,0L,-38227L,0L,101861L,0L };
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
public class A178117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178117Inst : IEnumerable<long>
{
public static readonly long[] Value=A178117.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178117.Bytes);
public long this[int i]=>Value[i];

public static A178117Inst Instance=new A178117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178118
{
public static readonly long[] Value={ 0L,1L,1L,2L,7L,25L,100L,469L,2481L,14406L,90995L,621553L,4561112L,35736921L,297435521L,2618575194L,24297706927L,236870849417L,2419213831452L,25820011544781L,287327296473585L,3326999636488190L,40011485288491131L };
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
public class A178118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178118Inst : IEnumerable<long>
{
public static readonly long[] Value=A178118.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178118.Bytes);
public long this[int i]=>Value[i];

public static A178118Inst Instance=new A178118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178119
{
public static readonly long[] Value={ 1L,2L,5L,16L,64L,308L,1727L,11008L,78244L,611060L,5184338L,47366320L,462782080L,4807659368L,52853722811L,612426360832L,7453621425532L,94997205901940L,1264555335831662L,17540102647480336L,252979919852470672L };
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
public class A178119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178119Inst : IEnumerable<long>
{
public static readonly long[] Value=A178119.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178119.Bytes);
public long this[int i]=>Value[i];

public static A178119Inst Instance=new A178119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178120
{
public static readonly long[] Value={ 1L,-2L,1L,7L,-6L,1L,-36L,40L,-12L,1L,253L,-326L,131L,-20L,1L,-2278L,3233L,-1552L,324L,-30L,1L,25059L,-38140L,20678L,-5260L,675L,-42L,1L,-325768L,523456L,-310560L,90754L,-14380L,1252L,-56L,1L,4886521L,-8205244L,5223602L,-1694244L,312059L,-33866L,2135L };
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
public class A178120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178120Inst : IEnumerable<long>
{
public static readonly long[] Value=A178120.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178120.Bytes);
public long this[int i]=>Value[i];

public static A178120Inst Instance=new A178120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178121
{
public static readonly long[] Value={ 1L,2L,1L,5L,6L,1L,16L,32L,12L,1L,64L,180L,109L,20L,1L,308L,1111L,934L,276L,30L,1L,1727L,7554L,8095L,3352L,585L,42L,1L,11008L,56228L,72884L,39006L,9580L,1100L,56L,1L,78244L,454572L,688562L,451992L,144706L,23396L,1897L,72L,1L,611060L,3962218L,6845904L,5317440L };
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
public class A178121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178121Inst : IEnumerable<long>
{
public static readonly long[] Value=A178121.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178121.Bytes);
public long this[int i]=>Value[i];

public static A178121Inst Instance=new A178121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178122
{
public static readonly long[] Value={ 1L,1L,1L,1L,8L,1L,1L,27L,27L,1L,1L,82L,240L,82L,1L,1L,245L,1700L,1700L,245L,1L,1L,732L,10571L,23586L,10571L,732L,1L,1L,2191L,60697L,259791L,259791L,60697L,2191L,1L,1L,6566L,331666L,2485398L,4675152L,2485398L,331666L,6566L,1L,1L,19689L,1756410L,21708138L };
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
public class A178122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178122Inst : IEnumerable<long>
{
public static readonly long[] Value=A178122.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178122.Bytes);
public long this[int i]=>Value[i];

public static A178122Inst Instance=new A178122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178123
{
public static readonly long[] Value={ 1L,1L,2L,5L,16L,61L,269L,1337L,7354L,44155L,286397L,1990427L,14725738L,115356349L,952592288L,8261093885L,74994333994L,710656444489L,7012302313061L,71892455879393L,764331907463476L,8411953721081635L,95684448908132498L };
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
public class A178123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178123Inst : IEnumerable<long>
{
public static readonly long[] Value=A178123.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178123.Bytes);
public long this[int i]=>Value[i];

public static A178123Inst Instance=new A178123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178124
{
public static readonly long[] Value={ 1L,-1L,1L,1L,-3L,1L,0L,7L,-6L,1L,-5L,-13L,26L,-10L,1L,25L,11L,-101L,69L,-15L,1L,-105L,76L,383L,-425L,150L,-21L,1L,460L,-758L,-1494L,2599L,-1310L,286L,-28L,1L,-2315L,5536L,6215L,-16761L,11129L,-3325L,497L,-36L,1L,13935L,-40769L,-27989L,118079L,-97272L,36764L };
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
public class A178124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178124Inst : IEnumerable<long>
{
public static readonly long[] Value=A178124.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178124.Bytes);
public long this[int i]=>Value[i];

public static A178124Inst Instance=new A178124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178125
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,1L,5L,11L,6L,1L,16L,45L,34L,10L,1L,61L,208L,197L,81L,15L,1L,269L,1068L,1204L,626L,165L,21L,1L,1337L,6017L,7810L,4863L,1640L,302L,28L,1L,7354L,36801L,53762L,38742L,15781L,3760L,511L,36L,1L,44155L,242242L,391797L,319197L,151487L,43962L,7805L,814L };
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
public class A178125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178125Inst : IEnumerable<long>
{
public static readonly long[] Value=A178125.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178125.Bytes);
public long this[int i]=>Value[i];

public static A178125Inst Instance=new A178125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178126
{
public static readonly long[] Value={ 1L,1L,2L,4L,6L,9L,9L,24L,56L,24L,16L,120L,250L,275L,50L,25L,720L,1884L,1350L,960L,90L,36L,5040L,12348L,14896L,5145L,2695L,147L,49L,40320L,114624L,105056L,80416L,15680L,6496L,224L,64L,362880L,986256L,1282284L,605556L,336609L,40824L,13986L,324L,81L,3628800L };
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
public class A178126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178126Inst : IEnumerable<long>
{
public static readonly long[] Value=A178126.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178126.Bytes);
public long this[int i]=>Value[i];

public static A178126Inst Instance=new A178126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178127
{
public static readonly long[] Value={ 149L,179L,227L,239L,347L,431L,569L,599L,641L,821L,1019L,1049L,1061L,1427L,1487L,1607L,1787L,1997L,2081L,2129L,2237L,2267L,2657L,2687L,2711L,2789L,2999L,3167L,3257L,3299L,3359L,3527L,3539L,3581L,3671L,3917L,4091L,4127L,4229L,4241L,4337L,4547L,4637L,4649L };
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
public class A178127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178127Inst : IEnumerable<long>
{
public static readonly long[] Value=A178127.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178127.Bytes);
public long this[int i]=>Value[i];

public static A178127Inst Instance=new A178127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178128
{
public static readonly long[] Value={ 11L,17L,29L,41L,59L,71L,101L,107L,149L,179L,227L,239L,269L,281L,311L,347L,419L,431L,461L,569L,599L,641L,659L,809L,821L,827L,857L,881L,1019L,1031L,1049L,1061L,1091L,1151L,1229L,1277L,1289L,1301L,1427L,1451L,1481L,1487L,1607L,1667L,1721L,1787L,1871L,1877L,1997L };
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
public class A178128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178128Inst : IEnumerable<long>
{
public static readonly long[] Value=A178128.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178128.Bytes);
public long this[int i]=>Value[i];

public static A178128Inst Instance=new A178128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178129
{
public static readonly long[] Value={ 0L,2L,8L,23L,47L,87L,147L,224L,328L,463L,623L,821L,1049L,1322L,1644L,2004L,2420L,2896L,3418L,4007L,4647L,5361L,6153L,7004L,7940L,8940L,10032L,11220L,12480L,13843L,15313L,16863L,18527L,20276L,22146L,24141L,26229L,28449L,30767L,33224L,35824L,38530L };
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
public class A178129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178129Inst : IEnumerable<long>
{
public static readonly long[] Value=A178129.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178129.Bytes);
public long this[int i]=>Value[i];

public static A178129Inst Instance=new A178129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178130
{
public static readonly long[] Value={ 8L,19L,24L,28L,32L,36L,75L,81L,88L,96L,136L,176L,224L,225L,250L,328L,369L,395L,432L,432L,468L,500L,512L,537L,648L,701L,710L,864L,980L,1000L,1078L,1089L,1125L,1216L,1225L,1296L,1440L,1536L,1620L,1734L,1764L,1792L,1800L,1944L,1944L,2000L,2028L,2048L,2178L,2304L };
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
public class A178130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178130Inst : IEnumerable<long>
{
public static readonly long[] Value=A178130.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178130.Bytes);
public long this[int i]=>Value[i];

public static A178130Inst Instance=new A178130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178131
{
public static readonly long[] Value={ 1L,4L,5L,5L,7L,4L,8L,6L,5L,2L,0L,5L,1L,0L,3L,0L,5L,8L,9L,3L,9L,7L,8L,9L,0L,6L,8L,1L,2L,4L,6L,1L,1L,9L,1L,4L,5L,1L,1L,4L,9L,0L,4L,1L,0L,1L,7L,8L,2L,5L,8L,3L,2L,7L,6L,9L,3L,0L,6L,8L,9L,7L,8L,6L,5L,7L,1L,8L,0L,0L,3L,1L,0L,3L,9L,0L,7L,8L,3L,0L,9L,7L,6L,3L,6L,0L,6L,3L,8L,0L,4L,6L,1L,6L,4L,9L,0L,2L,9L,9L,8L,8L,4L,2L,8L };
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
public class A178131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178131Inst : IEnumerable<long>
{
public static readonly long[] Value=A178131.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178131.Bytes);
public long this[int i]=>Value[i];

public static A178131Inst Instance=new A178131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178132
{
public static readonly long[] Value={ 0L,1L,5L,10L,19L,29L,42L,56L,72L,89L,109L,130L,155L,181L,210L,240L,274L,309L,345L,382L,420L,459L,499L,540L,582L,627L,673L,722L,772L,823L,875L,928L,982L,1037L,1093L,1150L,1208L,1267L,1328L,1390L,1453L,1517L,1582L,1648L,1716L,1785L,1855L,1926L,1999L,2073L,2148L };
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
public class A178132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178132Inst : IEnumerable<long>
{
public static readonly long[] Value=A178132.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178132.Bytes);
public long this[int i]=>Value[i];

public static A178132Inst Instance=new A178132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178133
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,1L,3L,3L,5L,3L,5L,4L,4L,9L,5L,4L,10L,6L,7L,8L,8L,11L,10L,8L,8L,14L,11L,12L,11L,13L,10L,13L,14L,15L,14L,16L,17L,12L,14L,14L,18L,19L,17L,19L,15L,21L,16L,17L,23L,22L,17L,16L,21L,24L,28L,24L,21L,23L,20L,24L,22L,24L,21L,27L,28L,28L,26L,28L,32L,19L,31L,29L,27L,29L,28L,22L,37L };
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
public class A178133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178133Inst : IEnumerable<long>
{
public static readonly long[] Value=A178133.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178133.Bytes);
public long this[int i]=>Value[i];

public static A178133Inst Instance=new A178133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178134
{
public static readonly long[] Value={ 0L,1L,1L,2L,-3L,-2L,-32L,-81L,-311L,-810L,-2515L,-6864L,-19944L,-55043L,-156023L,-433522L,-1217427L,-3391226L,-9488456L,-26462205L,-73933535L,-206293134L,-576040339L,-1607642688L,-4488069168L,-12526662167L,-34967630447L };
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
public class A178134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178134Inst : IEnumerable<long>
{
public static readonly long[] Value=A178134.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178134.Bytes);
public long this[int i]=>Value[i];

public static A178134Inst Instance=new A178134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178135
{
public static readonly long[] Value={ 6314447L,7855163L,9715103L,10133467L,10851497L,12820427L,13442537L,14064317L,14172007L,15945437L,18715547L,20208163L,21488263L,22916767L,23924827L,24079357L,25660883L,27099283L,27245627L,27613093L,29162977L,31215643L };
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
public class A178135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178135Inst : IEnumerable<long>
{
public static readonly long[] Value=A178135.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178135.Bytes);
public long this[int i]=>Value[i];

public static A178135Inst Instance=new A178135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178136
{
public static readonly long[] Value={ 4911311L,5309599L,9113323L,11355857L,11397163L,13940117L,14306263L,14313587L,14585149L,17172581L,21126169L,24419341L,24581863L,24861691L,24922351L,25308859L,26241811L,26722583L,27408253L,28740979L,29675197L,30045871L };
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
public class A178136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178136Inst : IEnumerable<long>
{
public static readonly long[] Value=A178136.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178136.Bytes);
public long this[int i]=>Value[i];

public static A178136Inst Instance=new A178136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178137
{
public static readonly long[] Value={ 2L,5L,10L,17L,28L,51L,94L,161L,250L,351L,460L,671L,894L,1127L,1560L,2003L,2680L,3467L,4344L,5231L,6240L,7349L,8472L,9695L,11806L,14027L,16360L,19581L,22904L,26247L,29680L,34247L,39690L,47479L,55356L,64243L,73242L,82243L,91254L,101141L,111042L };
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
public class A178137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178137Inst : IEnumerable<long>
{
public static readonly long[] Value=A178137.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178137.Bytes);
public long this[int i]=>Value[i];

public static A178137Inst Instance=new A178137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178138
{
public static readonly long[] Value={ 2L,11L,37L,97L,219L,444L,830L,1454L,2416L,3845L,5901L,8781L,12723L,18008L,24964L,33972L,45472L,59965L,78019L,100273L,127439L,160308L,199754L,246740L,302326L,367673L,444045L,532813L,635457L,753570L,888872L,1043214L,1218584L };
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
public class A178138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178138Inst : IEnumerable<long>
{
public static readonly long[] Value=A178138.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178138.Bytes);
public long this[int i]=>Value[i];

public static A178138Inst Instance=new A178138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178139
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,4L,4L,1L,4L,2L,6L,4L,1L,6L,8L,2L,2L,4L,7L,1L,3L,6L,12L,1L,7L,1L,2L,2L,12L,6L,16L,1L,1L,3L,4L,4L,1L,7L,14L,2L,2L,4L,1L,5L,3L,6L,24L,2L,2L,4L,11L,6L,2L,2L,4L,1L,4L,2L,21L,6L,3L,3L,32L,4L,2L,4L,2L,5L,5L,2L,8L,6L,3L,1L,2L,5L,14L,4L,28L };
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
public class A178139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178139Inst : IEnumerable<long>
{
public static readonly long[] Value=A178139.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178139.Bytes);
public long this[int i]=>Value[i];

public static A178139Inst Instance=new A178139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178140
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,5040L,589824L,6531840L,98304000L,548856000L,3822059520L,14841066240L,67711795200L,208702494000L,726855843840L,1906252508160L,5500708061184L,12796310741760L,32142458880000L,68146033536000L };
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
public class A178140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178140Inst : IEnumerable<long>
{
public static readonly long[] Value=A178140.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178140.Bytes);
public long this[int i]=>Value[i];

public static A178140Inst Instance=new A178140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178141
{
public static readonly long[] Value={ 4L,-1L,2L,-4L,1L,2L,4L,-1L,2L,-4L,1L,2L,4L,-1L,2L,-4L,1L,2L,4L,-1L,2L,-4L,1L,2L,4L,-1L,2L,-4L,1L,2L,4L,-1L,2L,-4L,1L,2L,4L,-1L,2L,-4L,1L,2L,4L,-1L,2L,-4L,1L,2L,4L,-1L,2L,-4L,1L,2L,4L,-1L,2L,-4L,1L,2L,4L,-1L,2L,-4L,1L,2L,4L,-1L,2L,-4L,1L,2L,4L,-1L,2L,-4L,1L,2L };
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
public class A178141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178141Inst : IEnumerable<long>
{
public static readonly long[] Value=A178141.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178141.Bytes);
public long this[int i]=>Value[i];

public static A178141Inst Instance=new A178141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178142
{
public static readonly long[] Value={ 0L,2L,3L,2L,0L,5L,0L,2L,3L,2L,0L,5L,0L,2L,3L,2L,0L,5L,0L,2L,3L,2L,0L,5L,0L,2L,3L,2L,0L,5L,0L,2L,3L,2L,0L,5L,0L,2L,3L,2L,0L,5L,0L,2L,3L,2L,0L,5L,0L,2L,3L,2L,0L,5L,0L,2L,3L,2L,0L,5L,0L,2L,3L,2L,0L,5L,0L,2L,3L,2L,0L,5L,0L,2L,3L,2L,0L,5L,0L,2L,3L,2L,0L,5L,0L,2L,3L,2L,0L,5L,0L,2L,3L,2L,0L,5L,0L,2L,3L,2L,0L,5L,0L,2L,3L };
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
public class A178142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178142Inst : IEnumerable<long>
{
public static readonly long[] Value=A178142.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178142.Bytes);
public long this[int i]=>Value[i];

public static A178142Inst Instance=new A178142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178143
{
public static readonly long[] Value={ 0L,4L,9L,4L,0L,13L,0L,4L,9L,4L,0L,13L,0L,4L,9L,4L,0L,13L,0L,4L,9L,4L,0L,13L,0L,4L,9L,4L,0L,13L,0L,4L,9L,4L,0L,13L,0L,4L,9L,4L,0L,13L,0L,4L,9L,4L,0L,13L,0L,4L,9L,4L,0L,13L,0L,4L,9L,4L,0L,13L,0L,4L,9L,4L,0L,13L,0L,4L,9L,4L,0L,13L,0L,4L,9L,4L,0L,13L,0L,4L,9L,4L };
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
public class A178143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178143Inst : IEnumerable<long>
{
public static readonly long[] Value=A178143.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178143.Bytes);
public long this[int i]=>Value[i];

public static A178143Inst Instance=new A178143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178144
{
public static readonly long[] Value={ 0L,2L,3L,2L,5L,5L,0L,2L,3L,7L,0L,5L,0L,2L,8L,2L,0L,5L,0L,7L,3L,2L,0L,5L,5L,2L,3L,2L,0L,10L,0L,2L,3L,2L,5L,5L,0L,2L,3L,7L,0L,5L,0L,2L,8L,2L,0L,5L,0L,7L,3L,2L,0L,5L,5L,2L,3L,2L,0L,10L,0L,2L,3L,2L,5L,5L,0L,2L,3L,7L,0L,5L,0L,2L,8L,2L,0L,5L,0L,7L,3L,2L,0L,5L,5L,2L,3L,2L,0L,10L,0L,2L,3L,2L,5L,5L,0L,2L,3L,7L,0L,5L,0L,2L,8L };
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
public class A178144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178144Inst : IEnumerable<long>
{
public static readonly long[] Value=A178144.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178144.Bytes);
public long this[int i]=>Value[i];

public static A178144Inst Instance=new A178144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178145
{
public static readonly long[] Value={ 1L,2L,17L,32L,137L,247L,312L,347L,542L,577L,942L,1572L,2167L,2607L,2622L,2677L,3007L,3152L,3237L,3502L,3712L,4217L,5287L,5807L,7297L,8557L,9222L,10497L,11202L,11582L,12037L,12877L,13282L,13507L,13787L,14802L,16307L,16522L,16852L,18307L,19422L };
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
public class A178145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178145Inst : IEnumerable<long>
{
public static readonly long[] Value=A178145.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178145.Bytes);
public long this[int i]=>Value[i];

public static A178145Inst Instance=new A178145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178146
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,0L,1L,1L,2L,0L,2L,0L,1L,2L,1L,0L,2L,0L,2L,1L,1L,0L,2L,1L,1L,1L,1L,0L,3L,0L,1L,1L,1L,1L,2L,0L,1L,1L,2L,0L,2L,0L,1L,2L,1L,0L,2L,0L,2L,1L,1L,0L,2L,1L,1L,1L,1L,0L,3L,0L,1L,1L,1L,1L,2L,0L,1L,1L,2L,0L,2L,0L,1L,2L,1L,0L,2L,0L,2L,1L,1L,0L,2L,1L,1L,1L,1L,0L,3L,0L,1L,1L,1L,1L,2L,0L,1L,1L,2L,0L,2L,0L,1L,2L };
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
public class A178146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178146Inst : IEnumerable<long>
{
public static readonly long[] Value=A178146.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178146.Bytes);
public long this[int i]=>Value[i];

public static A178146Inst Instance=new A178146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178147
{
public static readonly long[] Value={ 0L,4L,9L,4L,25L,13L,0L,4L,9L,29L,0L,13L,0L,4L,34L,4L,0L,13L,0L,29L,9L,4L,0L,13L,25L,4L,9L,4L,0L,38L,0L,4L,9L,4L,25L,13L,0L,4L,9L,29L,0L,13L,0L,4L,34L,4L,0L,13L,0L,29L,9L,4L,0L,13L,25L,4L,9L,4L,0L,38L,0L,4L,9L,4L,25L,13L,0L,4L,9L,29L,0L,13L,0L,4L,34L,4L,0L,13L,0L };
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
public class A178147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178147Inst : IEnumerable<long>
{
public static readonly long[] Value=A178147.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178147.Bytes);
public long this[int i]=>Value[i];

public static A178147Inst Instance=new A178147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178148
{
public static readonly long[] Value={ 1L,3L,1L,8L,3L,9L,0L,6L,2L,5L,0L,6L,0L,3L,9L,8L,6L,2L,4L,6L,5L,9L,1L,7L,1L,9L,4L,0L,2L,0L,3L,6L,7L,1L,3L,1L,7L,9L,3L,6L,3L,7L,8L,3L,8L,7L,2L,6L,2L,7L,4L,2L,5L,8L,0L,0L,8L,7L,1L,8L,0L,7L,5L,4L,6L,6L,3L,8L,1L,6L,2L,5L,5L,1L,1L,2L,0L,9L,6L,3L,6L,7L,7L,9L,0L,0L,3L,0L,7L,6L,7L,5L,7L,3L,7L,2L,1L,6L,4L,2L,5L,1L,8L,5L,8L };
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
public class A178148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178148Inst : IEnumerable<long>
{
public static readonly long[] Value=A178148.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178148.Bytes);
public long this[int i]=>Value[i];

public static A178148Inst Instance=new A178148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178149
{
public static readonly long[] Value={ 1L,7L,3L,1L,5L,3L,0L,2L,1L,3L,4L,6L,0L,7L,4L,4L,3L,9L,9L,7L,2L,1L,1L,8L,7L,0L,5L,3L,3L,2L,6L,5L,7L,1L,4L,0L,1L,8L,8L,3L,8L,6L,5L,8L,0L,7L,4L,3L,9L,0L,5L,1L,9L,5L,8L,2L,1L,3L,0L,2L,1L,3L,9L,6L,2L,8L,3L,0L,8L,8L,6L,8L,8L,9L,0L,8L,3L,8L,6L,4L,9L,0L,0L,6L,9L,6L,7L,6L,8L,0L,2L,0L,1L,8L,1L,5L,5L,0L,9L,6L,7L,9L,3L,7L,5L };
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
public class A178149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178149Inst : IEnumerable<long>
{
public static readonly long[] Value=A178149.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178149.Bytes);
public long this[int i]=>Value[i];

public static A178149Inst Instance=new A178149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178150
{
public static readonly long[] Value={ 11L,19L,31L,71L,79L,101L,103L,109L,167L,211L,223L,263L,293L,337L,367L,379L,419L,431L,461L,479L,503L,571L,601L,659L,769L,839L,967L,1009L,1039L,1049L,1087L,1151L,1223L,1231L,1427L,1451L,1511L,1553L,1559L,1663L,1699L,1741L,1747L,1759L,1931L,1951L,2011L,2089L };
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
public class A178150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178150Inst : IEnumerable<long>
{
public static readonly long[] Value=A178150.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178150.Bytes);
public long this[int i]=>Value[i];

public static A178150Inst Instance=new A178150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178151
{
public static readonly long[] Value={ 1L,1L,2L,4L,3L,4L,6L,7L,7L,9L,9L,10L,12L,14L,13L,19L,15L,18L,21L,18L,22L,25L,22L,24L,25L,28L,31L,27L,28L,34L,40L,34L,39L,37L,41L,39L,42L,47L,43L,52L,45L,54L,48L,49L,54L,57L,59L,64L,57L,58L,67L,60L,73L,64L,72L,67L,73L,69L,70L,75L,73L,81L,87L,78L,79L,87L,84L,94L,87L,88L,99L,96L,93L };
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
public class A178151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178151Inst : IEnumerable<long>
{
public static readonly long[] Value=A178151.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178151.Bytes);
public long this[int i]=>Value[i];

public static A178151Inst Instance=new A178151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178152
{
public static readonly long[] Value={ 0L,1L,1L,1L,3L,4L,3L,4L,7L,6L,9L,10L,9L,9L,13L,10L,15L,15L,14L,18L,17L,16L,22L,24L,25L,23L,22L,27L,28L,29L,25L,34L,30L,37L,34L,39L,39L,36L,43L,37L,45L,41L,48L,49L,45L,48L,52L,49L,57L,58L,52L,60L,52L,64L,59L,67L,62L,69L,70L,66L,73L,72L,68L,78L,79L,78L,84L,79L,87L,88L,80L,87L,93L,90L };
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
public class A178152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178152Inst : IEnumerable<long>
{
public static readonly long[] Value=A178152.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178152.Bytes);
public long this[int i]=>Value[i];

public static A178152Inst Instance=new A178152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178153
{
public static readonly long[] Value={ 1L,0L,1L,3L,0L,0L,3L,3L,0L,3L,0L,0L,3L,5L,0L,9L,0L,3L,7L,0L,5L,9L,0L,0L,0L,5L,9L,0L,0L,5L,15L,0L,9L,0L,7L,0L,3L,11L,0L,15L,0L,13L,0L,0L,9L,9L,7L,15L,0L,0L,15L,0L,21L,0L,13L,0L,11L,0L,0L,9L,0L,9L,19L,0L,0L,9L,0L,15L,0L,0L,19L,9L,0L,9L,17L,0L,0L,0L,0L,27L,0L,21L,0L,15L,15L,0L,0L,0L,7L,21L,25L,7L,27L,9L,21L,0L };
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
public class A178153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178153Inst : IEnumerable<long>
{
public static readonly long[] Value=A178153.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178153.Bytes);
public long this[int i]=>Value[i];

public static A178153Inst Instance=new A178153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178154
{
public static readonly long[] Value={ 1L,1L,3L,3L,3L,3L,3L,5L,9L,3L,7L,5L,9L,5L,9L,5L,15L,9L,7L,3L,11L,15L,13L,9L,9L,7L,15L,15L,21L,13L,11L,9L,9L,19L,9L,15L,19L,9L,9L,17L,27L,21L,15L,15L,7L,21L,25L,7L,27L,9L,21L,15L,9L,27L,15L,21L,25L,13L,15L,13L,9L,23L,33L,15L,15L,31L,13L,15L,21L,15L,15L,21L,9L,21L,33L,21L,21L,9L,29L,9L,31L,19L };
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
public class A178154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178154Inst : IEnumerable<long>
{
public static readonly long[] Value=A178154.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178154.Bytes);
public long this[int i]=>Value[i];

public static A178154Inst Instance=new A178154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178155
{
public static readonly long[] Value={ 1L,3L,7L,17L,37L,85L,189L,471L,967L,2033L,4493L,10621L,23461L,52841L,127745L,340473L,708489L,1367785L,2738841L,5675977L,12313209L,27929825L,66361381L,162909213L,361319381L,780460693L,1722272781L,3904263759L,9528920767L,24294326763L,66213009251L,187941084483L,395937137667L,756194730883L,1395731222259L,2540709556499L,4903320997075L,9814465115099L };
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
public class A178155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178155Inst : IEnumerable<long>
{
public static readonly long[] Value=A178155.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178155.Bytes);
public long this[int i]=>Value[i];

public static A178155Inst Instance=new A178155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178156
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,13L,14L,17L,19L,22L,23L,26L,29L,31L,34L,37L,38L,41L,43L,46L,47L,53L,58L,59L,61L,62L,67L,71L,73L,74L,79L,82L,83L,86L,89L,94L,97L,101L,103L,106L,107L,109L,113L,118L,122L,127L,131L,134L,137L,139L,142L,146L,149L,151L,157L,158L,163L };
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
public class A178156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178156Inst : IEnumerable<long>
{
public static readonly long[] Value=A178156.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178156.Bytes);
public long this[int i]=>Value[i];

public static A178156Inst Instance=new A178156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178157
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,22L,24L,26L,28L,30L,33L,36L,39L,40L,44L,48L,50L,55L,60L,66L,70L,77L,80L,88L,90L,99L,100L,110L,120L,130L,140L,150L,160L,170L,180L,190L,200L,210L,220L,230L,240L,250L,260L,270L,280L,290L,300L,330L,360L,390L,400L,420L,440L,460L,480L,500L,510L,520L,530L,540L,550L,560L };
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
public class A178157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178157Inst : IEnumerable<long>
{
public static readonly long[] Value=A178157.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178157.Bytes);
public long this[int i]=>Value[i];

public static A178157Inst Instance=new A178157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178158
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,12L,15L,21L,22L,24L,25L,31L,32L,33L,35L,36L,41L,42L,44L,45L,48L,51L,52L,55L,61L,62L,63L,64L,65L,66L,71L,72L,75L,77L,81L,82L,84L,85L,88L,91L,92L,93L,95L,96L,99L,101L,102L,104L,105L,125L,201L,202L,204L,205L,208L,225L,301L,302L,303L,304L,305L,306L,312L,315L,325L,375L,401L,402L,404L,405L,408L,425L,501L,502L,504L,505L,525L,601L,602L,603L,604L };
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
public class A178158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178158Inst : IEnumerable<long>
{
public static readonly long[] Value=A178158.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178158.Bytes);
public long this[int i]=>Value[i];

public static A178158Inst Instance=new A178158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178159
{
public static readonly long[] Value={ 1L,2L,8L,22L,68L,188L,532L,1444L,3921L,10446L,27704L,72714L,189912L,492760L,1273064L,3273896L,8389489L,21423994L,54550728L,138520286L,350899964L,886925652L,2237284668L,5633150988L,14159465505L,35535456518L,89053087224L,222870328210L,557074041840L,1390807477040L };
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
public class A178159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178159Inst : IEnumerable<long>
{
public static readonly long[] Value=A178159.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178159.Bytes);
public long this[int i]=>Value[i];

public static A178159Inst Instance=new A178159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178160
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,12L,13L,14L,15L,16L,21L,22L,23L,24L,25L,26L,27L,31L,32L,33L,34L,35L,36L,37L,42L,43L,44L,45L,46L,47L,48L,52L,53L,54L,55L,56L,57L,58L,62L,63L,64L,65L,66L,67L,68L,72L,73L,74L,75L,76L,77L,78L,82L,83L,84L,85L,86L,87L,88L,92L,93L,94L,95L,96L,97L,98L,99L };
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
public class A178160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178160Inst : IEnumerable<long>
{
public static readonly long[] Value=A178160.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178160.Bytes);
public long this[int i]=>Value[i];

public static A178160Inst Instance=new A178160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178161
{
public static readonly long[] Value={ 9L,63L,296L,693L,4117L,14071L,79586L,232069L,1356627L,4222935L,24394044L,73910079L,429075206L,1314629842L };
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
public class A178161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178161Inst : IEnumerable<long>
{
public static readonly long[] Value=A178161.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178161.Bytes);
public long this[int i]=>Value[i];

public static A178161Inst Instance=new A178161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178162
{
public static readonly long[] Value={ 3755L,48269854L,15751525912L };
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
public class A178162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178162Inst : IEnumerable<long>
{
public static readonly long[] Value=A178162.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178162.Bytes);
public long this[int i]=>Value[i];

public static A178162Inst Instance=new A178162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178163
{
public static readonly long[] Value={ 1L,1L,8L,1L,1L,6L,9L,1L,1L,1L,8L,1L,1L,1L,6L,1L,1L,1L,6L,1L,1L,1L,5L,1L,1L,1L,5L,1L,1L,1L,5L,1L,1L,1L,7L,1L,1L,1L,5L,1L,1L,1L,6L,1L,1L,3L,9L,1L,1L,1L,6L,1L,1L,1L,4L,1L,1L,1L,4L,1L,1L,1L,4L,1L,1L,1L,2L,1L,1L,3L,8L,1L,1L,8L,9L,1L,1L,1L,5L,1L,1L,1L,9L,1L,1L,1L,7L,1L,1L,1L,5L,1L,1L,2L,9L,1L,1L,8L,9L,1L,1L,5L,9L,1L,1L };
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
public class A178163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178163Inst : IEnumerable<long>
{
public static readonly long[] Value=A178163.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178163.Bytes);
public long this[int i]=>Value[i];

public static A178163Inst Instance=new A178163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178164
{
public static readonly long[] Value={ 9L,9L,1L,9L,9L,1L,9L,9L,9L,7L,9L,8L,9L,9L,9L,3L,7L,9L,9L,1L,1L,9L,9L,3L,2L,9L,9L,2L,9L,9L,9L,1L,9L,9L,9L,1L,5L,9L,9L,1L,1L,9L,9L,9L,9L,9L,9L,1L,4L,9L,9L,1L,6L,9L,9L,1L,7L,9L,9L,1L,1L,9L,9L,1L,3L,9L,9L,1L,5L,9L,9L,1L,9L,9L,9L,1L,1L,9L,9L,6L,9L,9L,9L,1L,9L,9L,9L,4L,4L,9L,9L,1L,8L,9L,9L,1L,1L,9L,9L,1L,2L,9L,9L,2L,9L };
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
public class A178164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178164Inst : IEnumerable<long>
{
public static readonly long[] Value=A178164.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178164.Bytes);
public long this[int i]=>Value[i];

public static A178164Inst Instance=new A178164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178165
{
public static readonly BigInteger[] Value={ 1L,2L,8L,59L,652L,9736L,186478L,4421018L,126317785L,4260664251L,166884941780L,7489637988545L,380861594219460L,21739310882945458L,1381634777325000263L,BigInteger.Parse("97089956842985393297"),BigInteger.Parse("7497783115765911443879"),BigInteger.Parse("632884743974716421132084") };
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
public class A178165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178165Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A178165.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178165.Bytes);
public BigInteger this[int i]=>Value[i];

public static A178165Inst Instance=new A178165Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178166
{
public static readonly BigInteger[] Value={ 10L,10L,10L,10L,100L,10L,10L,1000L,1000L,10L,10L,10000L,1000000L,10000L,10L,10L,100000L,10000000000L,10000000000L,100000L,10L,10L,1000000L,1000000000000000L,BigInteger.Parse("100000000000000000000"),1000000000000000L,1000000L,10L,10L,10000000L,BigInteger.Parse("1000000000000000000000") };
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
public class A178166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178166Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A178166.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178166.Bytes);
public BigInteger this[int i]=>Value[i];

public static A178166Inst Instance=new A178166Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178167
{
public static readonly long[] Value={ 3L,8L,20L,50L,122L,290L,674L,1538L,3462L,7720L,17104L,37708L,82768L,180880L,393488L,851914L,1835470L,3935808L,8402158L,17865738L,37858268L,79991512L,168605710L,354649382L,744605426L,1560666296L,3265699888L,6822355756L,14229565634L };
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
public class A178167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178167Inst : IEnumerable<long>
{
public static readonly long[] Value=A178167.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178167.Bytes);
public long this[int i]=>Value[i];

public static A178167Inst Instance=new A178167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178168
{
public static readonly BigInteger[] Value={ 1L,2L,153600L,8L,5120L,921600L,704889816350720000L,64L,BigInteger.Parse("2486851272085340160000"),51200L,4577206599680000L,11059200L,532480000L,9868457428910080000UL,BigInteger.Parse("114523513552896000000000"),1024L,12238520320000L,BigInteger.Parse("44763322897536122880000") };
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
public class A178168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178168Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A178168.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178168.Bytes);
public BigInteger this[int i]=>Value[i];

public static A178168Inst Instance=new A178168Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178169
{
public static readonly long[] Value={ 1L,2L,8L,64L,1024L,5120L,32768L,51200L,153600L,921600L,1024000L,2097152L,11059200L,40960000L,44040192L,265420800L,268435456L,532480000L,1849688064L,3276800000L,12740198400L,13844480000L,68719476736L,155373797376L,524288000000L };
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
public class A178169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178169Inst : IEnumerable<long>
{
public static readonly long[] Value=A178169.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178169.Bytes);
public long this[int i]=>Value[i];

public static A178169Inst Instance=new A178169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178170
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,5L,32L,10L,3L,6L,20L,64L,12L,40L,21L,24L,128L,13L,42L,80L,48L,26L,256L,84L,160L,52L,96L,85L,17L,168L,53L,512L,104L,320L,192L,34L,170L,106L,11L,336L,208L,68L,1024L,384L,22L,35L,640L,340L,212L,7L,69L,136L,44L,672L,416L,70L,14L,341L,213L,113L,768L,2048L,1280L };
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
public class A178170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178170Inst : IEnumerable<long>
{
public static readonly long[] Value=A178170.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178170.Bytes);
public long this[int i]=>Value[i];

public static A178170Inst Instance=new A178170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178171
{
public static readonly long[] Value={ 1L,2L,8L,109L,3623L,200522L,16514461L };
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
public class A178171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178171Inst : IEnumerable<long>
{
public static readonly long[] Value=A178171.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178171.Bytes);
public long this[int i]=>Value[i];

public static A178171Inst Instance=new A178171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178172
{
public static readonly BigInteger[] Value={ 7L,2699L,103669L,1088429L,40938135737L,78638210671L,294591811249L,89540991316447487L,BigInteger.Parse("72003397880992782229"),BigInteger.Parse("254817218437479631303"),BigInteger.Parse("297853453602437702393397023"),BigInteger.Parse("3199628601055396119933058397"),BigInteger.Parse("558554606804743021307746074767") };
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
public class A178172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178172Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A178172.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178172.Bytes);
public BigInteger this[int i]=>Value[i];

public static A178172Inst Instance=new A178172Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178173
{
public static readonly long[] Value={ 1L,2L,8L,128L,11087L,2232875L };
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
public class A178173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178173Inst : IEnumerable<long>
{
public static readonly long[] Value=A178173.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178173.Bytes);
public long this[int i]=>Value[i];

public static A178173Inst Instance=new A178173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178174
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,5L,3L,11L,7L,13L,17L,3L,5L,19L,11L,19L,3L,13L,23L,29L,17L,41L,11L,7L,19L,13L,5L,11L,3L,2L,7L,23L,7L,13L,5L,3L,7L,7L,11L,7L,2L,3L,23L,7L,7L,5L,7L,13L,2L,3L,5L,23L,11L,7L,23L,2L,43L,5L,73L,41L,3L,61L,89L,97L,5L,7L,11L,5L,7L,5L,7L,3L,11L,13L,17L,11L,13L,3L,11L,19L,23L,7L,5L,3L,19L,17L,11L,5L,13L,23L,13L,3L,13L,13L,7L,3L,3L,13L,13L,2L,31L,59L,7L,11L,3L,5L,13L,2L,23L,43L,3L,71L,7L,31L };
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
public class A178174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178174Inst : IEnumerable<long>
{
public static readonly long[] Value=A178174.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178174.Bytes);
public long this[int i]=>Value[i];

public static A178174Inst Instance=new A178174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178175
{
public static readonly long[] Value={ 2L,3L,6L,33L,48L,74L,231L,3206L,4544L,7064L,13634L,41384L,64862L,82790L };
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
public class A178175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178175Inst : IEnumerable<long>
{
public static readonly long[] Value=A178175.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178175.Bytes);
public long this[int i]=>Value[i];

public static A178175Inst Instance=new A178175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178176
{
public static readonly long[] Value={ 0L,0L,2L,0L,0L,0L,0L,2L,0L,2L,0L,0L,0L,1L,3L,0L,0L,0L,0L,0L,4L,0L,0L,2L,0L,0L,0L,4L,0L,0L,0L,0L,0L,0L,4L,4L,0L,0L,0L,0L,0L,0L,0L,0L,3L,0L,0L,2L,0L,0L,0L,1L,0L,0L,4L,0L,0L,0L,0L,0L,0L,0L,4L,0L,0L,4L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,6L,0L,3L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,3L,0L,0L,0L,0L,0L,0L,0L,4L };
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
public class A178176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178176Inst : IEnumerable<long>
{
public static readonly long[] Value=A178176.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178176.Bytes);
public long this[int i]=>Value[i];

public static A178176Inst Instance=new A178176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178177
{
public static readonly long[] Value={ 3L,23L,25L,47L,53L,67L,73L,89L,101L,103L,109L,117L,143L,145L,151L,157L,179L,187L,229L,273L,289L,297L,339L,375L,385L,395L,429L,455L,497L,521L,543L,557L,569L,619L,639L,649L,661L,703L,749L,759L,791L,795L,817L,821L,843L,889L,915L,961L,977L,1013L,1087L,1113L,1115L,1129L,1141L,1165L,1277L,1311L,1321L,1349L,1405L,1407L,1451L,1495L,1507L,1559L,1561L,1573L,1591L,1607L,1627L,1701L,1717L,1741L,1851L,1867L,1871L,1893L,1895L,1925L,1949L,1991L };
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
public class A178177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178177Inst : IEnumerable<long>
{
public static readonly long[] Value=A178177.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178177.Bytes);
public long this[int i]=>Value[i];

public static A178177Inst Instance=new A178177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178178
{
public static readonly long[] Value={ 2L,3L,7L,17L,41L,31L,73L,109L,241L,13L,613L,751L,937L,197L,3L,311L,433L,1481L,307L,739L,7151L,4297L,4451L,5521L,739L,12613L,9817L,13763L,16661L,13177L,14951L,11941L,2861L,7331L,4421L,6361L,37199L,31189L,40163L,8941L,13441L,9491L,32321L,53791L,40819L,23869L,73291L,67447L,38629L };
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
public class A178178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178178Inst : IEnumerable<long>
{
public static readonly long[] Value=A178178.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178178.Bytes);
public long this[int i]=>Value[i];

public static A178178Inst Instance=new A178178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178179
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,5L,3L,5L,13L,7L,5L,5L,17L,3L,5L,5L,13L,23L,41L,11L,5L,19L,7L,31L,19L,19L,23L,61L,103L,17L,181L,43L,241L,31L,7L,31L,23L,61L,23L,107L,191L,107L,5L,101L,71L,59L,11L,47L,13L,71L,131L,43L,7L,181L,11L,199L,23L,233L,13L,269L,103L,11L,383L,71L,31L,97L,199L,109L,5L,313L,61L,379L,251L,691L,1321L,73L,139L,73L,19L,11L,103L,19L,19L,47L,17L,83L,7L,107L,197L,311L,41L,61L,59L,23L,13L,19L,11L,43L,73L,127L,3L,29L,53L,17L,11L,3L,31L };
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
public class A178179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178179Inst : IEnumerable<long>
{
public static readonly long[] Value=A178179.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178179.Bytes);
public long this[int i]=>Value[i];

public static A178179Inst Instance=new A178179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178180
{
public static readonly long[] Value={ 1L,8L,18L,21L,39L,40L,51L,55L,67L,85L,86L,87L,123L,175L,179L,185L,199L,200L,216L,227L,247L,248L,260L,292L,314L,351L,360L,361L,407L,413L,434L,441L,445L,465L,479L,494L,514L,515L,565L,573L,576L,580L,583L,622L,629L,670L,679L,684L,691L,698L,712L,717L,724L,734L };
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
public class A178180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178180Inst : IEnumerable<long>
{
public static readonly long[] Value=A178180.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178180.Bytes);
public long this[int i]=>Value[i];

public static A178180Inst Instance=new A178180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178181
{
public static readonly long[] Value={ 0L,5L,10L,16L,21L,27L,32L,38L,43L,49L,54L };
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
public class A178181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178181Inst : IEnumerable<long>
{
public static readonly long[] Value=A178181.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178181.Bytes);
public long this[int i]=>Value[i];

public static A178181Inst Instance=new A178181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178182
{
public static readonly long[] Value={ 4L,4L,12L,1L,20L,12L,28L,8L,36L,20L,44L,6L,52L,28L,60L,16L,68L,36L,76L,5L,84L,44L,92L,24L,100L,52L,108L,14L,116L,60L,124L,32L,132L,68L,140L,9L,148L,76L,156L,40L,164L,84L,172L,22L,180L,92L,188L,48L,196L,100L,204L,13L,212L,108L,220L,56L,228L,116L,236L,30L,244L,124L,252L,64L,260L,132L,268L,17L,276L,140L,284L,72L,292L,148L,300L,38L,308L,156L,316L,80L };
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
public class A178182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178182Inst : IEnumerable<long>
{
public static readonly long[] Value=A178182.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178182.Bytes);
public long this[int i]=>Value[i];

public static A178182Inst Instance=new A178182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178183
{
public static readonly long[] Value={ 1L,2L,4L,7L,7L,12L,13L,16L,16L,13L,18L,12L,11L,6L,4L,1L,0L };
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
public class A178183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178183Inst : IEnumerable<long>
{
public static readonly long[] Value=A178183.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178183.Bytes);
public long this[int i]=>Value[i];

public static A178183Inst Instance=new A178183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178184
{
public static readonly BigInteger[] Value={ 4L,36L,548L,16932L,1065508L,135283236L,34495021604L,17626681066020L,18032025190548004L,BigInteger.Parse("36911520172609651236"),BigInteger.Parse("151152638972001256489508"),BigInteger.Parse("1238091191924352276155613732"),BigInteger.Parse("20283647694843594776223406899748") };
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
public class A178184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178184Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A178184.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178184.Bytes);
public BigInteger this[int i]=>Value[i];

public static A178184Inst Instance=new A178184Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178185
{
public static readonly BigInteger[] Value={ 1L,9L,145L,4641L,297025L,38019201L,9732915457L,4983252713985L,5102850779120641L,10450638395639072769UL,BigInteger.Parse("42805814868537642061825"),BigInteger.Parse("350665235403060363770470401"),BigInteger.Parse("5745299216843741000015387049985") };
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
public class A178185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178185Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A178185.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178185.Bytes);
public BigInteger this[int i]=>Value[i];

public static A178185Inst Instance=new A178185Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178186
{
public static readonly BigInteger[] Value={ 9L,252L,19935L,4802904L,3491587305L,7629089072292L,50039174188071999L,BigInteger.Parse("984820941357799304880"),BigInteger.Parse("58150721823981417489695049"),BigInteger.Parse("10301109611599361435391036962892"),BigInteger.Parse("5474411390529830981438591324606714655") };
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
public class A178186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178186Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A178186.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178186.Bytes);
public BigInteger this[int i]=>Value[i];

public static A178186Inst Instance=new A178186Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178187
{
public static readonly BigInteger[] Value={ 1L,28L,2269L,551368L,401947273L,879058686052L,5767504039187173L,BigInteger.Parse("113521782003321126160"),BigInteger.Parse("6703347705514109178621841"),BigInteger.Parse("1187477935988707898665323267628"),BigInteger.Parse("631074461779774914374598062671491949") };
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
public class A178187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178187Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A178187.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178187.Bytes);
public BigInteger this[int i]=>Value[i];

public static A178187Inst Instance=new A178187Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178188
{
public static readonly BigInteger[] Value={ 25L,3150L,1956275L,6105471900L,95373537112525L,7450675970460940650L,BigInteger.Parse("2910390496349340822268775"),BigInteger.Parse("5684344796471297836309816409400"),BigInteger.Parse("55511156915602623492479419714357425025") };
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
public class A178188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178188Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A178188.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178188.Bytes);
public BigInteger this[int i]=>Value[i];

public static A178188Inst Instance=new A178188Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178189
{
public static readonly BigInteger[] Value={ 1L,126L,78751L,246096876L,3845263687501L,300411225586015626L,BigInteger.Parse("117348134994537353906251"),BigInteger.Parse("229195576161205769348146484376"),BigInteger.Parse("2238238048449275091290493011484375001") };
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
public class A178189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178189Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A178189.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178189.Bytes);
public BigInteger this[int i]=>Value[i];

public static A178189Inst Instance=new A178189Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178190
{
public static readonly BigInteger[] Value={ 49L,16856L,40370463L,678263443312L,79792944561055313L,BigInteger.Parse("65712442156478841194856"),BigInteger.Parse("378818757978106938161558820799"),BigInteger.Parse("15286701010761334171872123930835647200") };
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
public class A178190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178190Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A178190.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178190.Bytes);
public BigInteger this[int i]=>Value[i];

public static A178190Inst Instance=new A178190Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178191
{
public static readonly BigInteger[] Value={ 1L,344L,825945L,13881657616L,1633163136864785L,BigInteger.Parse("1344980069223035633256"),BigInteger.Parse("7753542448037025041629822057"),BigInteger.Parse("312883404805904029979088478768109600"),BigInteger.Parse("88381817680515537538446482833052972519290401") };
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
public class A178191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178191Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A178191.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178191.Bytes);
public BigInteger this[int i]=>Value[i];

public static A178191Inst Instance=new A178191Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178192
{
public static readonly BigInteger[] Value={ 121L,161172L,2358108863L,379752191692104L,BigInteger.Parse("672750374684751701305"),BigInteger.Parse("13109994864250305051813161676"),BigInteger.Parse("2810243697916419649311518955166566527"),BigInteger.Parse("6626407610546884801816680266380777080570215568") };
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
public class A178192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178192Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A178192.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178192.Bytes);
public BigInteger this[int i]=>Value[i];

public static A178192Inst Instance=new A178192Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178193
{
public static readonly long[] Value={ 3777L,7773L,17418L,30777L,53921L,66111L,97731L,111916L,119217L,122519L,128131L,133195L,135488L,138878L,145229L,178814L,180174L,198581L,257376L,269636L,281179L,296396L,317686L,358256L,362996L,366514L,394114L,435777L,457377L,469552L,475856L,502960L,513833L };
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
public class A178193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178193Inst : IEnumerable<long>
{
public static readonly long[] Value=A178193.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178193.Bytes);
public long this[int i]=>Value[i];

public static A178193Inst Instance=new A178193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178194
{
public static readonly long[] Value={ 1L,2L,31L,5L,29L,7L,21L,13L,13684967L,10L,23L,14L,15L,538L,19L,42L,17L,35L,25L,49L,16861L,60L,55L,26L,1157L,38L,511L,54L,30197665L,106L,14691L,46L,155L,37L,18791L,62L,369L,164L,145L,93L,63517L,92L,115L,1046L,3113077L,58L,1376107L,1042L,105L,50L,221L };
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
public class A178194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178194Inst : IEnumerable<long>
{
public static readonly long[] Value=A178194.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178194.Bytes);
public long this[int i]=>Value[i];

public static A178194Inst Instance=new A178194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178195
{
public static readonly long[] Value={ 1L,3L,1154L,31L,5L,29L,7L,39297L,13L,19055L,18L,23L,22L,21L,535L,19L,20L,62537L,1138L,45L,142L,2092793L,42L,19547L,25L,39279L,50L,749L,36L,39055L,1126L,39L,188L,93641L,35L,634815079L,70L,171L,86L,355L,52L,65387L,713L,69L,148L,253L,74L };
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
public class A178195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178195Inst : IEnumerable<long>
{
public static readonly long[] Value=A178195.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178195.Bytes);
public long this[int i]=>Value[i];

public static A178195Inst Instance=new A178195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178196
{
public static readonly long[] Value={ 1L,2L,3L,26L,31L,10L,29L,14L,9L,13L,55L,57L,23L,92L,21L,22L,19L,99L,187L,134L,2105L,28L,169L,1202L,593791L,30L,27L,1198L,203L,46L,695L,66L,42843L,248L,4023706859L,37L,449467L,132L,327L,1186L,565L,74L,581L,394L,14277L,110L,59867L,62L,1311139L,56L,75L };
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
public class A178196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178196Inst : IEnumerable<long>
{
public static readonly long[] Value=A178196.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178196.Bytes);
public long this[int i]=>Value[i];

public static A178196Inst Instance=new A178196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178197
{
public static readonly long[] Value={ 1L,5L,17L,11L,34L,31L,10L,29L,14L,213L,13L,1585L,39L,23L,1282L,21L,20L,19L,142L,56413361L,22L,445L,26L,169L,87L,341L,50L,33L,332L,33607L,57L,55329163L,158L,46623L,1262L,33763L,37L,167987937385549L,74L,123L,284L,12091L,51L,119L,626L,531L,2630L,960641L,104L,473L,98L,75L,116L,424381L,174L,7751L,62L,951L,781L,364789L,206L,545L,1234L,93L,77L,205591L,78L,51367L,614L,159L,1226L,623L,207L,23147L,94L,11847L,100L,3551L,161L,332089L,176L,99L,143L,361841L,202L,73969L,590L,129L,302L };
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
public class A178197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178197Inst : IEnumerable<long>
{
public static readonly long[] Value=A178197.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178197.Bytes);
public long this[int i]=>Value[i];

public static A178197Inst Instance=new A178197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178198
{
public static readonly long[] Value={ 1L,2L,5L,17L,11L,22L,31L,25L,29L,10L,51L,13L,2585L,15L,23L,1354L,3157L,26L,19L,30L,14366417L,332L,85L,55L,510647L,44L,341L,122L,135L,52L,49L,33L,27905L,136L,141L,46L,55319L,41L,115L,190L,50613L,166L,205L,75L,252701L,284L,203L,1322L,395L,50L,1247L };
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
public class A178198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178198Inst : IEnumerable<long>
{
public static readonly long[] Value=A178198.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178198.Bytes);
public long this[int i]=>Value[i];

public static A178198Inst Instance=new A178198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178199
{
public static readonly long[] Value={ 1L,37L,3L,5L,6L,11L,1438L,31L,9L,29L,18L,45021L,13L,5249L,22L,23L,20L,69L,25L,437L,21L,227643018837677L,42L,141L,50L,19877L,27L,121L,36L,303L,98L,49L,75L,329L,94L,261L,116L,9200543L,39L,87541720241623L,52L,1119L,1402L,510025L,356L,24829L,466L,51L };
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
public class A178199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178199Inst : IEnumerable<long>
{
public static readonly long[] Value=A178199.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178199.Bytes);
public long this[int i]=>Value[i];

public static A178199Inst Instance=new A178199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178200
{
public static readonly long[] Value={ 1L,2L,37L,6L,5L,17L,11L,1514L,31L,12L,29L,70L,159L,26L,85L,21L,23L,94L,33L,1502L,779L,30L,253529023201L,214L,25L,28L,299L,54L,2905241561L,115L,77L,298L,96172711L,48L,13243955L,1486L,63L,106L,1841252062709911L,41L,13343L,74L,59277L,1478L,119L,82L,697L,134L,69L,176L,70961L,150L,481L,116L,55L,1466L,3161L,84L,437L,86L,511L,146L,13787L,153L,90224135L,104L,6789L,1454L,140459L,132L,958471L,1303310L,87L,362L,175L,482L,1369L,244L,93L,98L,2501L,88L,119239L,1438L,1077L,692L,2258141L,102L,9066799L,358L,99L,130L,46859L,506L,121L,217L,187L,124L,163067L,105L,40649L };
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
public class A178200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178200Inst : IEnumerable<long>
{
public static readonly long[] Value=A178200.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178200.Bytes);
public long this[int i]=>Value[i];

public static A178200Inst Instance=new A178200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178201
{
public static readonly long[] Value={ 1L,3L,19L,37L,6L,7L,17L,11L,92L,31L,15L,29L,794L,21L,26L,215L,22L,23L,98L,49L,124L,19849L,42L,12405874306277L,284L,75L,1574L,221L,36L,323L,70L,119L,56L,133L,58L,685L,44L,69L,142L,187L,41L,31561L,82L,3197L,148L,10073L,51L,511L,176L,37603L,62L,437L,86L,1339L,1546L,63L,386L,12599L,138L,3017L,140L,493L,1538L,529L,72L,935L,118L,303L,253L,277061L,95L };
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
public class A178201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178201Inst : IEnumerable<long>
{
public static readonly long[] Value=A178201.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178201.Bytes);
public long this[int i]=>Value[i];

public static A178201Inst Instance=new A178201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178202
{
public static readonly long[] Value={ 1L,2L,3L,19L,37L,76L,7L,17L,9L,22L,31L,15L,29L,77L,309L,34L,7194589L,26L,23L,341L,21L,55L,799L,1658L,476983L,46L,27L,427L,629L,52L,142241L,138L,68889L,136L,1897L,129L,30935L,44L,19303L,1642L,34943L,43L,8858994648397L,102L,117L,436L,7715L,86L,49L };
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
public class A178202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178202Inst : IEnumerable<long>
{
public static readonly long[] Value=A178202.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178202.Bytes);
public long this[int i]=>Value[i];

public static A178202Inst Instance=new A178202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178203
{
public static readonly long[] Value={ 414966L,443166L,454266L,1274664L,1371372L,1701856L,1713732L,1734616L,1771248L,1858436L,1858616L,2075664L,2624976L,3606691L,3771031L,3771301L,4266914L,4414866L,4461786L,4605146L,4670576L,4710739L,5209663L,5281767L,5434572L,5836565L,5861712L,5871968L,6046357L };
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
public class A178203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178203Inst : IEnumerable<long>
{
public static readonly long[] Value=A178203.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178203.Bytes);
public long this[int i]=>Value[i];

public static A178203Inst Instance=new A178203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178204
{
public static readonly long[] Value={ 40844882L,113986781L,130852098L,141176320L,168137185L,170774472L,178180163L,181681157L,181693781L,183161897L,187117638L,215149451L,261666000L,284804842L,294557945L,307711074L,335524949L,337194240L,344552927L,347391040L,355318188L,358831104L,368657536L };
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
public class A178204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178204Inst : IEnumerable<long>
{
public static readonly long[] Value=A178204.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A178204.Bytes);
public long this[int i]=>Value[i];

public static A178204Inst Instance=new A178204Inst();

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