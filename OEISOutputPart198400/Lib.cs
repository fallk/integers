using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A249062
{
public static readonly long[] Value={ 1L,2L,5L,18L,69L,306L,1497L,7890L,45033L,273474L,1760301L,11961522L,85265325L,636026418L,4947725889L,40019230386L,335868650577L,2918173355010L,26199114476373L,242657102748114L,2314964975130261L,22717352863875762L,229029972003647145L,2369438933865972498L };
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
public class A249062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249062Inst : IEnumerable<long>
{
public static readonly long[] Value=A249062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249062.Bytes);
public long this[int i]=>Value[i];

public static A249062Inst Instance=new A249062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249063
{
public static readonly long[] Value={ 0L,-1L,-2L,-2L,0L,2L,3L,-1L,-4L,-4L,0L,4L,5L,0L,-5L,-6L,-2L,4L,7L,3L,-5L,-8L,-5L,3L,8L,5L,-3L,-9L,-8L,1L,10L,9L,-1L,-10L,-10L,-2L,9L,11L,3L,-9L,-13L,-6L,7L,13L,7L,-7L,-15L,-10L,4L,14L,11L,-3L,-15L,-14L,0L,13L,14L,1L,-14L,-17L,-5L,12L,17L,7L,-11L,-18L,-10L,8L };
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
public class A249063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249063Inst : IEnumerable<long>
{
public static readonly long[] Value=A249063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249063.Bytes);
public long this[int i]=>Value[i];

public static A249063Inst Instance=new A249063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249064
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,7L,9L,11L,13L,8L,17L,19L,23L,25L,29L,31L,21L,37L,16L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L,103L,107L,22L,109L,113L,27L,35L,127L,131L,137L,139L,149L,151L,157L,163L,167L,169L,173L,179L,181L,191L,193L,197L,199L,211L,32L,121L,223L,227L,229L,233L,239L,241L,51L,251L,257L,263L,269L,271L,277L,281L,283L,49L,95L };
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
public class A249064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249064Inst : IEnumerable<long>
{
public static readonly long[] Value=A249064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249064.Bytes);
public long this[int i]=>Value[i];

public static A249064Inst Instance=new A249064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249065
{
public static readonly long[] Value={ 12L,420L,966L,2700L,5700L,5940L,7440L,12540L,71100L,76680L,107880L,118680L,121920L,156420L,160650L,161880L,259080L,284580L,339150L,353430L,395850L,498420L,585200L,600780L,701220L,746130L,752100L,771420L,870870L,1052220L,1249680L,1654620L,1684020L,1696080L };
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
public class A249065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249065Inst : IEnumerable<long>
{
public static readonly long[] Value=A249065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249065.Bytes);
public long this[int i]=>Value[i];

public static A249065Inst Instance=new A249065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249066
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L };
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
public class A249066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249066Inst : IEnumerable<long>
{
public static readonly long[] Value=A249066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249066.Bytes);
public long this[int i]=>Value[i];

public static A249066Inst Instance=new A249066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249067
{
public static readonly long[] Value={ 9L,45L,27L,23L,18L,15L,13L,12L,9L,9L,9L,42L,62L,43L,54L,44L,53L,45L,43L,45L,43L,41L,35L,34L,36L,35L,34L,33L,32L,27L,26L,25L,25L,27L,26L,25L,25L,24L,24L,23L,22L,22L,21L,21L,18L,18L,18L,17L,17L,18L,18L,18L,17L,17L,17L,17L,16L,16L,16L,15L,15L,15L,15L,15L,14L,14L,14L,14L,14L,13L,13L,13L,13L,13L,12L,12L,12L,12L,12L,12L,12L,11L,11L,11L,11L,11L,11L,11L };
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
public class A249067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249067Inst : IEnumerable<long>
{
public static readonly long[] Value=A249067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249067.Bytes);
public long this[int i]=>Value[i];

public static A249067Inst Instance=new A249067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249068
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,3L,1L,4L,1L,5L,1L,6L,1L,7L,1L,8L,2L,2L,3L,2L,4L,2L,5L,2L,6L,2L,7L,2L,8L,3L,3L,4L,3L,5L,3L,6L,3L,7L,3L,8L,4L,4L,5L,4L,6L,4L,7L,4L,8L,5L,5L,6L,5L,7L,5L,8L,6L,6L,7L,6L,8L,7L,7L,8L,8L,9L,18L,10L,11L,9L,22L,9L,24L,10L,13L,9L,28L,9L,30L,10L,14L,11L,13L,10L,15L,9L,38L,12L,11L,14L,13L,11L,15L };
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
public class A249068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249068Inst : IEnumerable<long>
{
public static readonly long[] Value=A249068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249068.Bytes);
public long this[int i]=>Value[i];

public static A249068Inst Instance=new A249068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249069
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,5L,1L,7L,9L,12L,2L,13L,3L,16L,5L,6L,18L,1L,19L,2L,21L,3L,25L,27L,30L,32L,35L,38L,40L,41L,43L,45L,48L,13L,14L,15L,16L,18L,6L,53L,20L,7L,57L,21L,8L,64L,24L,65L,27L,69L,28L,72L,10L,73L,11L,76L,12L,33L,80L,13L,34L,85L,14L,37L,89L,15L,41L,94L,17L,46L,96L,1L,97L,2L,99L,3L,103L,4L,48L,49L,50L };
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
public class A249069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249069Inst : IEnumerable<long>
{
public static readonly long[] Value=A249069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249069.Bytes);
public long this[int i]=>Value[i];

public static A249069Inst Instance=new A249069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249070
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,5L,1L,7L,9L,12L,2L,13L,3L,16L,5L,6L,18L,1L,19L,2L,21L,3L,25L,27L,30L,32L,35L,7L,40L,9L,44L,4L,10L,11L,12L,13L,14L,15L,16L,18L,5L,19L,6L,56L,20L,7L,61L,22L,8L,64L,26L,66L,9L,69L,10L,29L,30L,76L,11L,32L,81L,12L,33L,88L,13L,36L,37L,38L,39L,40L,42L,14L,43L,15L,44L,16L,46L,17L,49L,50L,51L,52L };
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
public class A249070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249070Inst : IEnumerable<long>
{
public static readonly long[] Value=A249070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249070.Bytes);
public long this[int i]=>Value[i];

public static A249070Inst Instance=new A249070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249071
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,1L,0L,1L,2L,2L,2L,2L,2L,1L,0L,1L,2L,2L,3L,3L,4L,4L,3L,4L,4L,3L,3L,2L,2L,1L,0L,1L,2L,3L,3L,4L,4L,5L,5L,6L,6L,5L,6L,6L,7L,7L,6L,7L,7L,6L,6L,5L,6L,6L,5L,5L,4L,4L,3L,3L,2L,1L,0L,1L,2L,3L,3L,4L,5L,5L,6L,7L,7L,8L,8L,8L,8L,8L,9L,9L,10L,10L,11L,11L,10L,11L,11L,12L,12L,11L,12L,12L,11L,11L,10L,11L,11L,12L,12L,11L,12L,12L,11L,11L,10L,11L,11L,10L,10L,9L,9L,8L,8L,8L,8L,8L,7L,7L,6L,5L,5L,4L,3L,3L,2L,1L,0L };
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
public class A249071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249071Inst : IEnumerable<long>
{
public static readonly long[] Value=A249071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249071.Bytes);
public long this[int i]=>Value[i];

public static A249071Inst Instance=new A249071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249072
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,2L,0L,2L,1L,2L,2L,2L,3L,0L,2L,3L,1L,3L,2L,4L,0L,3L,2L,3L,3L,3L,4L,1L,3L,3L,4L,2L,4L,2L,4L,3L,4L,3L,5L,0L,3L,4L,4L,3L,6L,0L,4L,4L,4L,5L,1L,4L,4L,6L,1L,3L,5L,2L,5L,2L,4L,5L,3L,5L,3L,4L,5L,4L,4L,7L,0L,3L,7L,1L,4L,5L,3L,5L,4L,8L,0L,4L,5L,4L,6L,2L,6L,2L,5L,5L,4L,6L,3L,8L,1L,4L,9L,0L };
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
public class A249072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249072Inst : IEnumerable<long>
{
public static readonly long[] Value=A249072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249072.Bytes);
public long this[int i]=>Value[i];

public static A249072Inst Instance=new A249072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249073
{
public static readonly long[] Value={ 1L,2L,64L,128L,729L,1458L,4096L,8192L,15625L,31250L,46656L,93312L,117649L,235298L,262144L,524288L,531441L,1000000L,1062882L,1771561L,2000000L,2985984L,3543122L,4826809L,5971968L,7529536L,9653618L,11390625L,15059072L,16777216L,22781250L,24137569L,33554432L };
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
public class A249073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249073Inst : IEnumerable<long>
{
public static readonly long[] Value=A249073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249073.Bytes);
public long this[int i]=>Value[i];

public static A249073Inst Instance=new A249073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249074
{
public static readonly long[] Value={ 1L,4L,1L,6L,4L,1L,32L,14L,4L,1L,60L,72L,24L,4L,1L,384L,228L,120L,36L,4L,1L,840L,1392L,564L,176L,50L,4L,1L,6144L,4488L,3312L,1140L,240L,66L,4L,1L,15120L,31200L,14640L,6480L,2040L,312L,84L,4L,1L,122880L,104880L,97440L,37440L,11280L,3360L,392L,104L,4L,1L,332640L };
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
public class A249074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249074Inst : IEnumerable<long>
{
public static readonly long[] Value=A249074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249074.Bytes);
public long this[int i]=>Value[i];

public static A249074Inst Instance=new A249074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249075
{
public static readonly long[] Value={ 1L,5L,11L,51L,161L,773L,3027L,15395L,69881L,377781L,1915163L,10981907L,60776145L,368269541L,2191553891L,13976179203L,88489011497L,591631462805L,3954213899691L,27619472411891L,193696456198913L,1408953242322117L,10318990227472115L,77948745858933731L };
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
public class A249075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249075Inst : IEnumerable<long>
{
public static readonly long[] Value=A249075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249075.Bytes);
public long this[int i]=>Value[i];

public static A249075Inst Instance=new A249075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249076
{
public static readonly long[] Value={ 0L,64L,46656L,2985984L,64000000L,729000000L,5489031744L,30840979456L,139314069504L,531441000000L,1771561000000L,5289852801024L,14412774445056L,36343632130624L,85766121000000L,191102976000000L,404961208827904L,820972403643456L,1600135042849344L,3010936384000000L,5489031744000000L };
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
public class A249076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249076Inst : IEnumerable<long>
{
public static readonly long[] Value=A249076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249076.Bytes);
public long this[int i]=>Value[i];

public static A249076Inst Instance=new A249076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249077
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,19L,31L,41L,61L,67L,73L,79L,83L,89L,97L,103L,137L,139L,149L,151L,157L,181L,193L,199L,211L,223L,227L,239L,241L,271L,311L,317L,331L,337L,349L,373L,421L,433L,439L,443L,449L,461L,607L,619L,631L,643L,661L,691L,719L,739L,757L,811L,823L,829L,853L,859L };
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
public class A249077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249077Inst : IEnumerable<long>
{
public static readonly long[] Value=A249077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249077.Bytes);
public long this[int i]=>Value[i];

public static A249077Inst Instance=new A249077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249078
{
public static readonly BigInteger[] Value={ 1L,1L,4L,17L,96L,595L,4516L,37104L,351020L,3604001L,41007240L,502039444L,6703536516L,95376507135L,1459072099824L,23677731306350L,408821193129564L,7443839953433701L,143258713990271960L,2893053522512463984L,BigInteger.Parse("61396438056305204020"),BigInteger.Parse("1362146168353191078195"),BigInteger.Parse("31605702195327725326560") };
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
public class A249078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249078Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249078.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A249078.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249078Inst Instance=new A249078Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249079
{
public static readonly long[] Value={ 0L,29L,58L,87L,116L,145L,174L,203L,232L,261L,290L,319L,348L,377L,406L,436L,465L,494L,523L,552L,581L,610L,639L,668L,697L,726L,755L,784L,813L,842L,871L,900L,929L,958L,987L,1016L,1045L,1074L,1103L,1132L,1161L,1190L,1219L,1248L,1278L,1307L,1336L };
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
public class A249079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249079Inst : IEnumerable<long>
{
public static readonly long[] Value=A249079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249079.Bytes);
public long this[int i]=>Value[i];

public static A249079Inst Instance=new A249079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249080
{
public static readonly long[] Value={ 1324L,1944L,2844L,4136L,5964L,8504L,11964L,18884L,29484L,45428L,68892L,102564L,149644L,243804L,391596L,618620L,958668L,1453724L,2153964L,3554444L,5775660L,9219020L,14417004L,22033164L,32862124L,54520044L,89029164L,142746476L };
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
public class A249080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249080Inst : IEnumerable<long>
{
public static readonly long[] Value=A249080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249080.Bytes);
public long this[int i]=>Value[i];

public static A249080Inst Instance=new A249080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249081
{
public static readonly long[] Value={ 5005L,8805L,15493L,27213L,47645L,83045L,143925L,263405L,480725L,874421L,1584425L,2858305L,5130445L,9561325L,17773565L,32945477L,60874349L,112077225L,205513125L,386804645L,726595221L,1361924833L,2546660077L,4749273385L,8830446345L };
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
public class A249081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249081Inst : IEnumerable<long>
{
public static readonly long[] Value=A249081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249081.Bytes);
public long this[int i]=>Value[i];

public static A249081Inst Instance=new A249081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249082
{
public static readonly long[] Value={ 14586L,28366L,55318L,108018L,211034L,412334L,805518L,1574782L,3079710L,6024336L,11786986L,23066566L,45148946L,88390980L,173082554L,338983618L,664019290L,1300937072L,2549194008L,4996025870L,9792951702L,19198463026L,37642698046L };
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
public class A249082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249082Inst : IEnumerable<long>
{
public static readonly long[] Value=A249082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249082.Bytes);
public long this[int i]=>Value[i];

public static A249082Inst Instance=new A249082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249083
{
public static readonly long[] Value={ 36247L,84067L,195519L,454487L,1054347L,2439587L,5629189L,13492099L,32245925L,76837553L,182515991L,432099083L,1019449179L,2496936523L,6093230641L,14812564513L,35863827601L,86461707451L,207519083271L,516601489575L };
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
public class A249083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249083Inst : IEnumerable<long>
{
public static readonly long[] Value=A249083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249083.Bytes);
public long this[int i]=>Value[i];

public static A249083Inst Instance=new A249083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249084
{
public static readonly long[] Value={ 78448L,202628L,525960L,1365188L,3535850L,9128450L,23480326L,61940694L,162995818L,427723930L,1118943674L,2917379528L,7579080652L,20132662668L,53324358248L,140801592674L,370556680666L,971794433086L,2539113787424L,6770428097170L };
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
public class A249084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249084Inst : IEnumerable<long>
{
public static readonly long[] Value=A249084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249084.Bytes);
public long this[int i]=>Value[i];

public static A249084Inst Instance=new A249084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249085
{
public static readonly long[] Value={ 22L,243L,22L,1324L,243L,22L,5005L,1944L,243L,22L,14586L,8805L,2844L,243L,22L,36247L,28366L,15493L,4136L,243L,22L,78448L,84067L,55318L,27213L,5964L,243L,22L,154689L,202628L,195519L,108018L,47645L,8504L,243L,22L,281470L,429069L,525960L,454487L };
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
public class A249085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249085Inst : IEnumerable<long>
{
public static readonly long[] Value=A249085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249085.Bytes);
public long this[int i]=>Value[i];

public static A249085Inst Instance=new A249085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249086
{
public static readonly long[] Value={ 22L,243L,1324L,5005L,14586L,36247L,78448L,154689L,281470L,482131L,784092L,1223413L,1840954L,2688375L,3822856L,5314177L,7238718L,9687259L,12757900L,16565301L,21232162L,26899543L,33717624L,41856745L,51497086L,62841147L,76101988L,91516789L };
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
public class A249086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249086Inst : IEnumerable<long>
{
public static readonly long[] Value=A249086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249086.Bytes);
public long this[int i]=>Value[i];

public static A249086Inst Instance=new A249086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249087
{
public static readonly long[] Value={ 22L,243L,1944L,8805L,28366L,84067L,202628L,429069L,859390L,1571551L,2675332L,4423193L,6941954L,10445275L,15438956L,22078997L,30718938L,42223499L,56770760L,74848061L,97861362L,125898023L,159689464L,201241105L,250580166L,308596907L };
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
public class A249087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249087Inst : IEnumerable<long>
{
public static readonly long[] Value=A249087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249087.Bytes);
public long this[int i]=>Value[i];

public static A249087Inst Instance=new A249087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249088
{
public static readonly long[] Value={ 22L,243L,2844L,15493L,55318L,195519L,525960L,1201225L,2645038L,5175815L,9258348L,16218441L,26602442L,41385791L,63581316L,93693521L,133477418L,188493299L,259075080L,347572337L,463553770L,606221499L,779323728L,997197941L,1257681970L };
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
public class A249088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249088Inst : IEnumerable<long>
{
public static readonly long[] Value=A249088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249088.Bytes);
public long this[int i]=>Value[i];

public static A249088Inst Instance=new A249088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249089
{
public static readonly long[] Value={ 22L,243L,4136L,27213L,108018L,454487L,1365188L,3374725L,8157330L,17098293L,32231592L,59778995L,102570498L,165348629L,263953640L,401180967L,586241418L,850471689L,1195787840L,1634832071L,2224059510L,2958717373L,3859429656L };
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
public class A249089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249089Inst : IEnumerable<long>
{
public static readonly long[] Value=A249089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249089.Bytes);
public long this[int i]=>Value[i];

public static A249089Inst Instance=new A249089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249090
{
public static readonly long[] Value={ 22L,243L,5964L,47645L,211034L,1054347L,3535850L,9493535L,25153046L,56497393L,112531790L,220767937L,396410714L,663326409L,1099809388L,1725034343L,2589206092L,3857810135L,5551077540L,7742041245L,10743080836L,14544778639L };
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
public class A249090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249090Inst : IEnumerable<long>
{
public static readonly long[] Value=A249090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249090.Bytes);
public long this[int i]=>Value[i];

public static A249090Inst Instance=new A249090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249091
{
public static readonly long[] Value={ 22L,243L,8504L,83045L,412334L,2439587L,9128450L,26718133L,77477206L,186461959L,393375414L,815573943L,1532600102L,2665869517L,4588603836L,7429078523L,11465527204L,17540618531L,25835346484L,36786441199L,52063130104L,71754093333L };
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
public class A249091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249091Inst : IEnumerable<long>
{
public static readonly long[] Value=A249091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249091.Bytes);
public long this[int i]=>Value[i];

public static A249091Inst Instance=new A249091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249092
{
public static readonly long[] Value={ 22L,243L,11964L,143925L,805518L,5629189L,23480326L,75209315L,238362040L,614349855L,1375887454L,3011935973L,5922207890L,10720937567L,19147697430L,32000182293L,50821260970L,79809454005L,120332402226L,175018554513L };
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
public class A249092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249092Inst : IEnumerable<long>
{
public static readonly long[] Value=A249092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249092.Bytes);
public long this[int i]=>Value[i];

public static A249092Inst Instance=new A249092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249093
{
public static readonly long[] Value={ 0L,0L,1L,2L,0L,4L,0L,0L,7L,0L,0L,1L,2L,0L,1L,4L,0L,0L,2L,0L,1L,2L,0L,7L,0L,0L,1L,2L,0L,1L,2L,0L,4L,0L,0L,11L,0L,0L,1L,2L,0L,4L,0L,0L,2L,0L,1L,2L,0L,1L,4L,0L,0L,18L,0L,0L,1L,2L,0L,4L,0L,0L,7L,0L,0L,1L,2L,0L,1L,2L,0L,4L,0L,0L,2L,0L,1L,4L,0L,0L,28L,0L,0L,1L,2L,0L,4L };
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
public class A249093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249093Inst : IEnumerable<long>
{
public static readonly long[] Value=A249093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249093.Bytes);
public long this[int i]=>Value[i];

public static A249093Inst Instance=new A249093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249094
{
public static readonly long[] Value={ 0L,0L,4L,1L,0L,2L,0L,0L,4L,0L,0L,4L,1L,0L,2L,1L,0L,0L,7L,0L,2L,1L,0L,2L,0L,0L,4L,1L,0L,2L,1L,0L,2L,0L,0L,4L,0L,0L,4L,1L,0L,2L,0L,0L,4L,0L,2L,1L,0L,2L,1L,0L,0L,7L,0L,0L,4L,1L,0L,2L,0L,0L,4L,0L,0L,4L,1L,0L,2L,1L,0L,2L,0L,0L,4L,0L,2L,1L,0L,0L,11L,0L,0L,4L,1L,0L,2L };
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
public class A249094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249094Inst : IEnumerable<long>
{
public static readonly long[] Value=A249094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249094.Bytes);
public long this[int i]=>Value[i];

public static A249094Inst Instance=new A249094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249095
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,3L,2L,3L,1L,1L,1L,1L,4L,3L,6L,3L,4L,1L,1L,1L,1L,5L,4L,10L,6L,10L,4L,5L,1L,1L,1L,1L,6L,5L,15L,10L,20L,10L,15L,5L,6L,1L,1L,1L,1L,7L,6L,21L,15L,35L,20L,35L,15L,21L,6L,7L,1L,1L,1L,1L,8L,7L,28L,21L,56L,35L,70L,35L,56L,21L,28L,7L,8L,1L,1L };
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
public class A249095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249095Inst : IEnumerable<long>
{
public static readonly long[] Value=A249095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249095.Bytes);
public long this[int i]=>Value[i];

public static A249095Inst Instance=new A249095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249096
{
public static readonly long[] Value={ 2L,3L,8L,12L,18L,27L,32L,48L,50L,72L,75L,98L,108L,128L,147L,162L,192L,200L,242L,243L,288L,300L,338L,363L,392L,432L,450L,507L,512L,578L,588L,648L,675L,722L,768L,800L,867L,882L,968L,972L,1058L,1083L,1152L,1200L,1250L,1323L,1352L,1452L,1458L,1568L,1587L,1682L };
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
public class A249096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249096Inst : IEnumerable<long>
{
public static readonly long[] Value=A249096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249096.Bytes);
public long this[int i]=>Value[i];

public static A249096Inst Instance=new A249096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249097
{
public static readonly long[] Value={ 1L,3L,64L,192L,729L,2187L,4096L,12288L,15625L,46656L,46875L,117649L,139968L,262144L,352947L,531441L,786432L,1000000L,1594323L,1771561L,2985984L,3000000L,4826809L,5314683L,7529536L,8957952L,11390625L,14480427L,16777216L,22588608L,24137569L,34012224L,34171875L };
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
public class A249097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249097Inst : IEnumerable<long>
{
public static readonly long[] Value=A249097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249097.Bytes);
public long this[int i]=>Value[i];

public static A249097Inst Instance=new A249097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249098
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,10L,12L,14L,16L,18L,20L,21L,23L,25L,27L,29L,31L,32L,34L,36L,38L,40L,42L,43L,45L,47L,49L,51L,53L,54L,56L,58L,60L,62L,64L,65L,67L,69L,71L,73L,75L,76L,78L,80L,82L,84L,86L,87L,89L,91L,93L,95L,97L,98L,100L,102L,104L,106L,108L,109L,111L,113L,115L };
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
public class A249098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249098Inst : IEnumerable<long>
{
public static readonly long[] Value=A249098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249098.Bytes);
public long this[int i]=>Value[i];

public static A249098Inst Instance=new A249098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249099
{
public static readonly long[] Value={ 2L,4L,6L,8L,11L,13L,15L,17L,19L,22L,24L,26L,28L,30L,33L,35L,37L,39L,41L,44L,46L,48L,50L,52L,55L,57L,59L,61L,63L,66L,68L,70L,72L,74L,77L,79L,81L,83L,85L,88L,90L,92L,94L,96L,99L,101L,103L,105L,107L,110L,112L,114L,116L,118L,121L,123L,125L,127L,129L,132L,134L };
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
public class A249099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249099Inst : IEnumerable<long>
{
public static readonly long[] Value=A249099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249099.Bytes);
public long this[int i]=>Value[i];

public static A249099Inst Instance=new A249099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249100
{
public static readonly long[] Value={ 1L,3L,1L,5L,3L,1L,21L,12L,3L,1L,45L,48L,21L,3L,1L,231L,177L,81L,32L,3L,1L,585L,855L,450L,120L,45L,3L,1L,3465L,3240L,2070L,930L,165L,60L,3L,1L,9945L,18000L,10890L,4110L,1695L,216L,77L,3L,1L,65835L,71505L,57330L,28560L,7245L,2835L,273L,96L,3L,1L,208845L,443835L };
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
public class A249100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249100Inst : IEnumerable<long>
{
public static readonly long[] Value=A249100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249100.Bytes);
public long this[int i]=>Value[i];

public static A249100Inst Instance=new A249100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249101
{
public static readonly long[] Value={ 1L,4L,9L,37L,118L,525L,2059L,9934L,44937L,233683L,1177360L,6552069L,35986069L,212891932L,1256487933L,7856137825L,49320239614L,324285063489L,2149133929207L,14796251405278L,102910742502765L,739149552929719L,5370132965554144L,40110161953250937L };
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
public class A249101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249101Inst : IEnumerable<long>
{
public static readonly long[] Value=A249101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249101.Bytes);
public long this[int i]=>Value[i];

public static A249101Inst Instance=new A249101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249102
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,6L,14L,16L,17L,18L,19L,20L,21L,23L,24L,25L,26L,27L,28L,30L,31L,32L,33L,34L,35L,37L,38L,39L,40L,41L,42L,44L,45L,46L,47L,48L,98L,100L,101L,102L,103L,104L,112L,114L,115L,116L,117L,118L,119L,121L,122L,123L,124L,125L,126L,128L,129L,130L,131L,132L,133L };
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
public class A249102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249102Inst : IEnumerable<long>
{
public static readonly long[] Value=A249102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249102.Bytes);
public long this[int i]=>Value[i];

public static A249102Inst Instance=new A249102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249103
{
public static readonly long[] Value={ 8L,6L,9L,7L,6L,6L,8L,0L,5L,3L,1L,1L,4L,8L,5L,8L,2L,6L,2L,8L,0L,2L,1L,0L,9L,8L,2L,9L,7L,2L,9L,2L,1L,0L,9L,8L,2L,9L,0L,2L,4L,0L,1L,6L,9L,3L,5L,5L,4L,5L,3L,9L,8L,0L,7L,5L,8L,1L,7L,1L,7L,4L,0L,8L,6L,5L,0L,1L,2L,1L,1L,1L,2L,3L,3L,4L,3L,8L,2L,0L,5L,0L,8L,5L,5L,8L,1L,3L,6L,9L,4L,2L,4L,0L };
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
public class A249103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249103Inst : IEnumerable<long>
{
public static readonly long[] Value=A249103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249103.Bytes);
public long this[int i]=>Value[i];

public static A249103Inst Instance=new A249103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249104
{
public static readonly long[] Value={ 8L,11L,12L,13L,16L,17L,18L,19L,21L,22L,23L,24L,26L,28L,29L,31L,32L,33L,34L,36L,37L,38L,39L,40L,41L,42L,43L,44L,46L,47L,48L,49L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,71L,72L,73L };
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
public class A249104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249104Inst : IEnumerable<long>
{
public static readonly long[] Value=A249104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249104.Bytes);
public long this[int i]=>Value[i];

public static A249104Inst Instance=new A249104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249105
{
public static readonly long[] Value={ 4L,27L,1808L,3125L,12204L,12707L,82377L,269827L,823543L,1412500L,7089739L,9534375L,46873785L,78192979L,372241436L };
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
public class A249105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249105Inst : IEnumerable<long>
{
public static readonly long[] Value=A249105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249105.Bytes);
public long this[int i]=>Value[i];

public static A249105Inst Instance=new A249105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249106
{
public static readonly long[] Value={ 19164L,129357L,14971875L,45316123L,434325391L };
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
public class A249106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249106Inst : IEnumerable<long>
{
public static readonly long[] Value=A249106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249106.Bytes);
public long this[int i]=>Value[i];

public static A249106Inst Instance=new A249106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249107
{
public static readonly long[] Value={ 4031L,10823L,416959L,496939L,1354980L,9146115L,38949392L,44472866L,262908396L,380264131L };
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
public class A249107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249107Inst : IEnumerable<long>
{
public static readonly long[] Value=A249107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249107.Bytes);
public long this[int i]=>Value[i];

public static A249107Inst Instance=new A249107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249108
{
public static readonly long[] Value={ 133L,667L,961L,1007L,2013L,3986L,5662L,15979L,17453L,33233L,46943L,51101L,94870L,101444L,119045L,134298L,136957L,179567L,188897L,213511L,226203L,246149L,279749L,299139L,306667L,310157L,434531L,449087L,449183L,518459L,519203L };
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
public class A249108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249108Inst : IEnumerable<long>
{
public static readonly long[] Value=A249108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249108.Bytes);
public long this[int i]=>Value[i];

public static A249108Inst Instance=new A249108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249109
{
public static readonly long[] Value={ 15L,26L,27L,38L,76L,194L,531L,1445L,1501L,2923L,2988L,4427L,4499L,4769L,5817L,7831L,9523L,10602L,12412L,14963L,16117L,24863L,26768L,29041L,29329L,30229L,36577L,45246L,49817L,58483L,58823L,71165L,75469L,76273L,79799L,83429L,86941L,94037L };
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
public class A249109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249109Inst : IEnumerable<long>
{
public static readonly long[] Value=A249109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249109.Bytes);
public long this[int i]=>Value[i];

public static A249109Inst Instance=new A249109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249110
{
public static readonly long[] Value={ 4L,27L,3125L,398747L,823543L };
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
public class A249110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249110Inst : IEnumerable<long>
{
public static readonly long[] Value=A249110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249110.Bytes);
public long this[int i]=>Value[i];

public static A249110Inst Instance=new A249110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249111
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,2L,4L,5L,6L,1L,2L,5L,7L,10L,11L,12L,1L,2L,6L,9L,15L,18L,22L,23L,24L,1L,2L,7L,11L,21L,27L,37L,41L,46L,47L,48L,1L,2L,8L,13L,28L,38L,58L,68L,83L,88L,94L,95L,96L,1L,2L,9L,15L,36L,51L,86L,106L,141L,156L,177L,183L,190L,191L,192L,1L,2L,10L,17L,45L,66L };
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
public class A249111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249111Inst : IEnumerable<long>
{
public static readonly long[] Value=A249111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249111.Bytes);
public long this[int i]=>Value[i];

public static A249111Inst Instance=new A249111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249112
{
public static readonly long[] Value={ 3L,2L,7L,2L,8L,10L,4L,5L,7L,2L,8L,10L,4L,5L,16L,2L,8L,10L,7L,6L,16L,5L,8L,22L,7L,5L,16L,2L,15L,22L,4L,6L,7L,9L,8L,13L,4L,5L,19L,2L,11L,10L,7L,5L,16L,5L,8L,13L,12L,6L,7L,5L,8L,22L,7L,5L,16L,2L,15L,13L,4L,9L,16L,5L,8L,13L,8L,5L,7L,2L,11L,10L,4L,14L,16L,6L,8L };
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
public class A249112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249112Inst : IEnumerable<long>
{
public static readonly long[] Value=A249112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249112.Bytes);
public long this[int i]=>Value[i];

public static A249112Inst Instance=new A249112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249113
{
public static readonly long[] Value={ 4L,5L,16L,5L,11L,13L,8L,6L,19L,6L,12L,13L,7L,9L,28L,5L,11L,13L,12L,17L,19L,6L,11L,25L,8L,6L,28L,5L,20L,37L,7L,14L,19L,10L,11L,34L,8L,6L,40L,6L,20L,25L,8L,9L,31L,6L,11L,25L,19L,21L,19L,6L,12L,25L,16L,9L,28L,5L,20L,22L,7L,14L,40L,9L,11L,34L,19L,6L,52L,17L,12L };
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
public class A249113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249113Inst : IEnumerable<long>
{
public static readonly long[] Value=A249113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249113.Bytes);
public long this[int i]=>Value[i];

public static A249113Inst Instance=new A249113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249114
{
public static readonly long[] Value={ 7L,6L,19L,10L,12L,25L,11L,9L,40L,13L,15L,25L,11L,17L,67L,6L,15L,22L,15L,18L,43L,9L,12L,34L,12L,9L,31L,9L,32L,58L,8L,21L,28L,14L,12L,37L,11L,9L,55L,13L,23L,46L,11L,14L,43L,10L,15L,34L,24L,26L,28L,9L,15L,37L,23L,18L,40L,6L,24L,61L,8L,18L,43L,22L,27L,37L,20L,9L };
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
public class A249114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249114Inst : IEnumerable<long>
{
public static readonly long[] Value=A249114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249114.Bytes);
public long this[int i]=>Value[i];

public static A249114Inst Instance=new A249114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249115
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,8L,9L,11L,12L,13L,15L,16L,17L,19L,20L,22L,23L,24L,26L,27L,29L,30L,31L,33L,34L,35L,37L,38L,40L,41L,42L,44L,45L,46L,48L,49L,51L,52L,53L,55L,56L,58L,59L,60L,62L,63L,64L,66L,67L,69L,70L,71L,73L,74L,76L,77L,78L,80L,81L,82L,84L,85L,87L,88L,89L,91L };
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
public class A249115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249115Inst : IEnumerable<long>
{
public static readonly long[] Value=A249115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249115.Bytes);
public long this[int i]=>Value[i];

public static A249115Inst Instance=new A249115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249116
{
public static readonly long[] Value={ 1L,32L,64L,729L,2048L,4096L,15625L,23328L,46656L,117649L,131072L,262144L,500000L,531441L,1000000L,1492992L,1771561L,2985984L,3764768L,4826809L,7529536L,8388608L,11390625L,16777216L,17006112L,24137569L,32000000L,34012224L,47045881L,56689952L,64000000L };
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
public class A249116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249116Inst : IEnumerable<long>
{
public static readonly long[] Value=A249116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249116.Bytes);
public long this[int i]=>Value[i];

public static A249116Inst Instance=new A249116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249117
{
public static readonly long[] Value={ 1L,3L,4L,6L,7L,9L,10L,12L,14L,15L,17L,18L,20L,21L,23L,24L,26L,28L,29L,31L,32L,34L,35L,37L,39L,40L,42L,43L,45L,46L,48L,49L,51L,53L,54L,56L,57L,59L,60L,62L,64L,65L,67L,68L,70L,71L,73L,74L,76L,78L,79L,81L,82L,84L,85L,87L,88L,90L,92L,93L,95L,96L,98L,99L,101L,103L };
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
public class A249117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249117Inst : IEnumerable<long>
{
public static readonly long[] Value=A249117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249117.Bytes);
public long this[int i]=>Value[i];

public static A249117Inst Instance=new A249117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249118
{
public static readonly long[] Value={ 2L,5L,8L,11L,13L,16L,19L,22L,25L,27L,30L,33L,36L,38L,41L,44L,47L,50L,52L,55L,58L,61L,63L,66L,69L,72L,75L,77L,80L,83L,86L,89L,91L,94L,97L,100L,102L,105L,108L,111L,114L,116L,119L,122L,125L,127L,130L,133L,136L,139L,141L,144L,147L,150L,152L,155L,158L,161L,164L };
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
public class A249118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249118Inst : IEnumerable<long>
{
public static readonly long[] Value=A249118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249118.Bytes);
public long this[int i]=>Value[i];

public static A249118Inst Instance=new A249118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249119
{
public static readonly long[] Value={ 1L,7L,0L,0L,7L,3L,5L,4L,9L,5L,2L,8L,6L,4L,0L,4L,8L,5L,1L,3L,0L,7L,3L,5L,7L,4L,3L,3L,9L,2L,2L,2L,3L,2L,6L,6L,3L,1L,8L,3L,1L,7L,2L,2L,1L,3L,9L,7L,4L,5L,6L,4L,6L,7L,6L,8L,4L,6L,0L,4L,6L,4L,5L,8L,4L,8L,2L,8L,6L,1L,8L,7L,8L,7L,4L,5L,4L,4L,1L,4L,2L,8L,9L,2L,4L,1L,9L,2L,7L,3L,1L,2L,5L,2L,2L,2L,7L,7L,4L,7L,2L,0L,8L,2L,0L };
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
public class A249119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249119Inst : IEnumerable<long>
{
public static readonly long[] Value=A249119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249119.Bytes);
public long this[int i]=>Value[i];

public static A249119Inst Instance=new A249119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249120
{
public static readonly long[] Value={ 1L,4L,13L,5L,35L,20L,86L,65L,194L,175L,14L,415L,430L,56L,844L,970L,182L,1654L,2075L,490L,3133L,4220L,1204L,30L,5773L,8270L,2716L,120L,10372L,15665L,5810L,390L,18240L,28865L,11816L,1050L,31449L,51860L,23156L,2580L,53292L,91200L,43862L,5820L,55L,88873L,157245L,80822L,12450L,220L,146095L,266460L,145208L,25320L,715L };
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
public class A249120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249120Inst : IEnumerable<long>
{
public static readonly long[] Value=A249120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249120.Bytes);
public long this[int i]=>Value[i];

public static A249120Inst Instance=new A249120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249121
{
public static readonly long[] Value={ 0L,-1L,-2L,-3L,-4L,-5L,-6L,-7L,-8L,-9L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,18L,16L,14L,12L,10L,8L,6L,4L,2L,0L,27L,24L,21L,18L,15L,12L,9L,6L,3L,0L,36L,32L,28L,24L,20L,16L,12L,8L,4L,0L,45L,40L,35L,30L,25L,20L,15L,10L,5L,0L,54L,48L,42L,36L,30L,24L,18L,12L,6L,0L,63L,56L,49L,42L,35L,28L,21L,14L,7L,0L,72L,64L,56L };
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
public class A249121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249121Inst : IEnumerable<long>
{
public static readonly long[] Value=A249121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249121.Bytes);
public long this[int i]=>Value[i];

public static A249121Inst Instance=new A249121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249122
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,0L,3L,1L,4L,0L,5L,2L,6L,0L,7L,0L,8L,3L,9L,0L,10L,4L,11L,0L,12L,0L,13L,5L,14L,1L,15L,6L,16L,2L,17L,0L,18L,7L,19L,0L,20L,8L,21L,3L,22L,1L,23L,9L,24L,1L,25L,10L,26L,0L,27L,0L,28L,11L,29L,4L,30L,12L,31L,3L,32L,0L,33L,13L,34L,5L,35L,14L,36L,0L,37L,1L };
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
public class A249122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249122Inst : IEnumerable<long>
{
public static readonly long[] Value=A249122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249122.Bytes);
public long this[int i]=>Value[i];

public static A249122Inst Instance=new A249122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249123
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,11L,13L,15L,17L,18L,20L,22L,24L,26L,28L,30L,32L,34L,35L,37L,39L,41L,43L,45L,47L,49L,51L,52L,54L,56L,58L,60L,62L,64L,66L,68L,69L,71L,73L,75L,77L,79L,81L,83L,85L,86L,88L,90L,92L,94L,96L,98L,100L,102L,103L,105L,107L,109L,111L,113L,115L,117L,119L };
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
public class A249123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249123Inst : IEnumerable<long>
{
public static readonly long[] Value=A249123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249123.Bytes);
public long this[int i]=>Value[i];

public static A249123Inst Instance=new A249123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249124
{
public static readonly long[] Value={ 2L,4L,6L,8L,10L,12L,14L,16L,19L,21L,23L,25L,27L,29L,31L,33L,36L,38L,40L,42L,44L,46L,48L,50L,53L,55L,57L,59L,61L,63L,65L,67L,70L,72L,74L,76L,78L,80L,82L,84L,87L,89L,91L,93L,95L,97L,99L,101L,104L,106L,108L,110L,112L,114L,116L,118L,120L,123L,125L,127L,129L,131L };
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
public class A249124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249124Inst : IEnumerable<long>
{
public static readonly long[] Value=A249124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249124.Bytes);
public long this[int i]=>Value[i];

public static A249124Inst Instance=new A249124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249125
{
public static readonly long[] Value={ 4L,8L,9L,16L,25L,27L,32L,49L,50L,64L,81L,100L,121L,125L,128L,169L,200L,243L,250L,256L,289L,343L,361L,400L,500L,512L,529L,625L,729L,800L,841L,961L,1000L,1024L,1250L,1331L,1369L,1600L,1681L,1849L,2000L,2048L,2187L,2197L,2209L,2401L,2500L,2809L,3125L,3200L,3481L,3721L,4000L,4096L,4489L,4913L,5000L,5041L,5329L,6241L,6250L,6400L };
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
public class A249125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249125Inst : IEnumerable<long>
{
public static readonly long[] Value=A249125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249125.Bytes);
public long this[int i]=>Value[i];

public static A249125Inst Instance=new A249125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249126
{
public static readonly BigInteger[] Value={ 6L,837L,85094L,8537238L,853922530L,85397212652L,8539729843352L,853973398759468L,85397341863406230L,8539734219628209684L,BigInteger.Parse("853973422224398765940"),BigInteger.Parse("85397342226185298383510"),BigInteger.Parse("8539734222671268708689351"),BigInteger.Parse("853973422267317150596927230"),BigInteger.Parse("85397342226735418150399772016") };
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
public class A249126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249126Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249126.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A249126.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249126Inst Instance=new A249126Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249127
{
public static readonly long[] Value={ 0L,1L,6L,12L,24L,35L,54L,70L,96L,117L,150L,176L,216L,247L,294L,330L,384L,425L,486L,532L,600L,651L,726L,782L,864L,925L,1014L,1080L,1176L,1247L,1350L,1426L,1536L,1617L,1734L,1820L,1944L,2035L,2166L,2262L,2400L,2501L,2646L,2752L,2904L,3015L,3174L,3290L,3456L,3577L,3750L,3876L,4056L,4187L,4374L,4510L };
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
public class A249127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249127Inst : IEnumerable<long>
{
public static readonly long[] Value=A249127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249127.Bytes);
public long this[int i]=>Value[i];

public static A249127Inst Instance=new A249127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249128
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,3L,1L,1L,2L,4L,5L,1L,1L,6L,11L,7L,8L,1L,1L,6L,18L,26L,10L,11L,1L,1L,24L,50L,46L,58L,14L,15L,1L,1L,24L,96L,154L,86L,102L,18L,19L,1L,1L,120L,274L,326L,444L,156L,177L,23L,24L,1L,1L,120L,600L,1044L,756L,954L,246L,272L,28L,29L,1L,1L,720L,1764L };
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
public class A249128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249128Inst : IEnumerable<long>
{
public static readonly long[] Value=A249128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249128.Bytes);
public long this[int i]=>Value[i];

public static A249128Inst Instance=new A249128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249129
{
public static readonly long[] Value={ 1L,0L,2L,3L,5L,4L,8L,6L,9L,7L,12L,10L,14L,11L,15L,13L,16L,17L,19L,18L,22L,20L,24L,21L,25L,23L,26L,27L,28L,30L,29L,31L,33L,32L,36L,34L,37L,35L,40L,38L,42L,39L,44L,41L,45L,43L,46L,47L,48L,50L,49L,51L,53L,52L,55L,54L,58L,56L,59L,57L,60L,61L,64L,62L,65L,63L,68L };
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
public class A249129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249129Inst : IEnumerable<long>
{
public static readonly long[] Value=A249129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249129.Bytes);
public long this[int i]=>Value[i];

public static A249129Inst Instance=new A249129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249130
{
public static readonly long[] Value={ 1L,2L,1L,2L,2L,1L,8L,6L,2L,1L,8L,16L,10L,2L,1L,48L,44L,28L,16L,2L,1L,48L,144L,104L,40L,22L,2L,1L,384L,400L,368L,232L,56L,30L,2L,1L,384L,1536L,1232L,688L,408L,72L,38L,2L,1L,3840L,4384L,5216L,3552L,1248L,708L,92L,48L,2L,1L,3840L,19200L,16704L,12096L,7632L,1968L };
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
public class A249130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249130Inst : IEnumerable<long>
{
public static readonly long[] Value=A249130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249130.Bytes);
public long this[int i]=>Value[i];

public static A249130Inst Instance=new A249130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249131
{
public static readonly long[] Value={ 1L,3L,5L,17L,37L,139L,361L,1473L,4361L,19091L,62701L,291793L,1044205L,5129307L,19748177L,101817089L,417787921L,2250495523L,9770678101L,54780588561L,250194150581L,1455367098923L,6959638411705L,41888448785857L,208919770666777L,1298019439099059L };
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
public class A249131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249131Inst : IEnumerable<long>
{
public static readonly long[] Value=A249131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249131.Bytes);
public long this[int i]=>Value[i];

public static A249131Inst Instance=new A249131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249132
{
public static readonly long[] Value={ 1L,0L,2L,0L,0L,5L,13L,0L,0L,17L,0L,31L,73L,0L,0L,23L,0L,11L,0L,0L,173L,0L,0L,233L,463L,293L,0L,0L,251L,919L,0L,0L,37L,0L,193L,0L,443L,0L,0L,599L,0L,19L,0L,467L,211L,0L,0L,0L,0L,107L,89L,0L,659L,0L,241L,0L,2503L,0L,337L,53L,0L,3671L,0L,0L };
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
public class A249132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249132Inst : IEnumerable<long>
{
public static readonly long[] Value=A249132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249132.Bytes);
public long this[int i]=>Value[i];

public static A249132Inst Instance=new A249132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249133
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,1L,1L,0L,0L,0L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,1L,0L,0L };
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
public class A249133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249133Inst : IEnumerable<long>
{
public static readonly long[] Value=A249133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249133.Bytes);
public long this[int i]=>Value[i];

public static A249133Inst Instance=new A249133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249134
{
public static readonly long[] Value={ 12L,24L,1308L,1884L,2004L,2364L,2532L,2724L,3804L,4008L,4044L,4188L,4236L,4668L,5052L,5064L,5268L,5388L,5484L,6252L,6492L,6564L,6756L,6852L,7044L,7188L,7356L,7404L,7608L,7764L,8124L,8412L,8472L,8796L,9084L,9228L,9852L,9876L,9924L };
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
public class A249134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249134Inst : IEnumerable<long>
{
public static readonly long[] Value=A249134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249134.Bytes);
public long this[int i]=>Value[i];

public static A249134Inst Instance=new A249134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249135
{
public static readonly long[] Value={ 6L,42L,4L,64L,0L,216L,6L,432L,80L,192L,140L,160L,729L,0L,324L,60L,32L,36L,320L,24L,0L,0L,60L,256L,126L,96L,168L,12L,18L,210L,90L,180L,0L,32L,32L,72L,196L,49L,90L,0L,6L,0L,567L,0L,567L,243L,144L,0L,225L,63L,0L,90L,320L,84L,0L,81L,126L,120L,324L,96L,224L,180L,36L };
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
public class A249135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249135Inst : IEnumerable<long>
{
public static readonly long[] Value=A249135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249135.Bytes);
public long this[int i]=>Value[i];

public static A249135Inst Instance=new A249135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249136
{
public static readonly long[] Value={ 1L,8L,7L,4L,5L,2L,1L,4L,6L,4L,0L,3L,4L,2L,6L,4L,1L,8L,7L,6L,0L,0L,3L,2L,4L,8L,2L,0L,4L,7L,0L,2L,6L,4L,1L,2L,0L,1L,4L,7L,2L,1L,9L,3L,9L,8L,9L,1L,7L,0L,5L,6L,0L,7L,4L,6L,8L,3L,7L,8L,2L,4L,8L,9L,3L,1L,6L,2L,7L,1L,0L,4L,4L,4L,7L,1L,4L,7L,3L,1L,3L,8L,8L,2L,8L,5L,6L,6L,0L,1L,8L,7L,6L,8L,7L,4L,5L,8L,2L,8L,9L,6L };
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
public class A249136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249136Inst : IEnumerable<long>
{
public static readonly long[] Value=A249136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249136.Bytes);
public long this[int i]=>Value[i];

public static A249136Inst Instance=new A249136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249137
{
public static readonly long[] Value={ 2L,1L,3L,3L,8L,7L,7L,9L,3L,9L,9L,1L,5L,0L,6L,1L,1L,1L,9L,8L,0L,7L,2L,4L,4L,6L,7L,7L,4L,0L,1L,8L,5L,2L,9L,1L,9L,2L,2L,8L,9L,6L,2L,3L,8L,5L,3L,7L,9L,6L,4L,6L,8L,6L,1L,7L,7L,7L,2L,3L,4L,5L,9L,2L,7L,1L,9L,0L,6L,1L,1L,7L,5L,5L,7L,7L,4L,9L,9L,0L,3L,8L,1L,5L,7L,5L,2L,3L,9L,9L,3L,3L,7L,4L,7L,3L,2L,9L,4L,3L,3L,5L,6L };
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
public class A249137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249137Inst : IEnumerable<long>
{
public static readonly long[] Value=A249137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249137.Bytes);
public long this[int i]=>Value[i];

public static A249137Inst Instance=new A249137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249138
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,4L,1L,1L,6L,5L,7L,1L,1L,6L,18L,8L,10L,1L,1L,24L,26L,46L,12L,14L,1L,1L,24L,96L,58L,86L,16L,18L,1L,1L,120L,154L,326L,118L,156L,21L,23L,1L,1L,120L,600L,444L,756L,198L,246L,26L,28L,1L,1L,720L,1044L,2556L,1152L,1692L,324L,384L,32L,34L,1L,1L };
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
public class A249138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249138Inst : IEnumerable<long>
{
public static readonly long[] Value=A249138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249138.Bytes);
public long this[int i]=>Value[i];

public static A249138Inst Instance=new A249138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249139
{
public static readonly long[] Value={ 1L,3L,1L,5L,2L,11L,7L,1L,21L,16L,3L,43L,41L,12L,1L,85L,94L,34L,4L,171L,219L,99L,18L,1L,341L,492L,261L,60L,5L,683L,1101L,678L,195L,25L,1L,1365L,2426L,1692L,576L,95L,6L,2731L,5311L,4149L,1644L,340L,33L,1L,5461L,11528L,9959L,4488L,1106L,140L,7L,10923L,24881L };
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
public class A249139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249139Inst : IEnumerable<long>
{
public static readonly long[] Value=A249139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249139.Bytes);
public long this[int i]=>Value[i];

public static A249139Inst Instance=new A249139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249140
{
public static readonly long[] Value={ 1L,2L,1L,4L,4L,2L,6L,8L,1L,4L,4L,12L,10L,2L,16L,12L,8L,6L,8L,1L,20L,16L,24L,4L,18L,24L,4L,12L,10L,16L,22L,2L,36L,16L,32L,12L,8L,40L,6L,36L,28L,8L,30L,24L,1L,48L,20L,16L,44L,24L,4L,36L,32L,18L,60L,24L,4L,16L,40L,12L,64L,42L,56L,10L,16L,72L,22L,60L,46L,72L,2L };
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
public class A249140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249140Inst : IEnumerable<long>
{
public static readonly long[] Value=A249140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249140.Bytes);
public long this[int i]=>Value[i];

public static A249140Inst Instance=new A249140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249141
{
public static readonly long[] Value={ 2L,1L,1L,8L,4L,5L,6L,5L,6L,3L,4L,7L,0L,1L,6L,3L,5L,3L,2L,3L,8L,2L,5L,2L,7L,7L,6L,9L,1L,0L,2L,3L,6L,4L,7L,6L,4L,2L,8L,8L,5L,9L,0L,7L,8L,5L,6L,1L,8L,5L,1L,7L,9L,1L,5L,4L,1L,4L,2L,6L,3L,8L,5L,2L,9L,0L,9L,8L,3L,4L,1L,1L,2L,3L,6L,5L,3L,4L,6L,3L,4L,5L,7L,7L,5L,5L,7L,0L,8L,2L,5L,9L,7L,8L,1L,8L,7L,6L,7L,9L,3L,9L };
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
public class A249141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249141Inst : IEnumerable<long>
{
public static readonly long[] Value=A249141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249141.Bytes);
public long this[int i]=>Value[i];

public static A249141Inst Instance=new A249141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249142
{
public static readonly long[] Value={ 0L,2L,0L,0L,0L,1L,2L,0L,0L,3L,4L,0L,1L,2L,0L,0L,1L,2L,3L,4L,0L,1L,2L,0L,0L,6L,0L,1L,2L,3L,4L,0L,1L,2L,0L,0L,4L,5L,6L,0L,1L,2L,3L,4L,0L,1L,2L,0L,0L,2L,3L,4L,5L,6L,0L,1L,2L,3L,4L,0L,1L,2L,0L,0L,0L,1L,2L,3L,4L,5L,6L,0L,1L,2L,3L,4L,0L,1L,2L,0L,0L,7L,8L,0L,1L,2L,3L,4L,5L,6L,0L,1L,2L,3L,4L,0L,1L,2L,0L,0L };
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
public class A249142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249142Inst : IEnumerable<long>
{
public static readonly long[] Value=A249142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249142.Bytes);
public long this[int i]=>Value[i];

public static A249142Inst Instance=new A249142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249143
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,3L,1L,3L,1L,2L,2L,2L,1L,1L,2L,3L,2L,3L,1L,1L,1L,1L,5L,1L,5L,1L,2L,2L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,6L,1L,6L,1L,2L,1L,1L,1L,2L,5L,2L,1L,4L,2L,1L,3L,1L,2L,2L,2L,1L,2L,1L,1L,2L,4L,1L,1L,2L,1L,3L,3L,3L,1L,2L,1L,1L,7L,1L,7L,1L,2L,1L,1L,1L,2L,1L,4L,1L,1L,1L,1L,1L,5L,1L,1L,1L,1L,1L,1L,6L,2L,2L,4L,2L,1L,1L,1L,4L,2L,1L,1L,1L,1L,1L,5L,1L,1L,1L,2L,1L,3L,3L,3L,1L,1L,2L,2L,1L };
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
public class A249143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249143Inst : IEnumerable<long>
{
public static readonly long[] Value=A249143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249143.Bytes);
public long this[int i]=>Value[i];

public static A249143Inst Instance=new A249143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249144
{
public static readonly long[] Value={ 0L,1L,2L,4L,1L,6L,7L,1L,8L,2L,11L,3L,4L,5L,17L,19L,7L,4L,8L,5L,25L,26L,29L,31L,1L,32L,2L,35L,12L,14L,37L,41L,45L,49L,50L,52L,22L,57L,58L,61L,63L,1L,64L,2L,67L,25L,69L,73L,76L,32L,3L,33L,80L,4L,34L,87L,14L,92L,35L,36L,38L,99L,42L,105L,108L,47L,5L,114L,116L,49L,119L,23L,24L,25L,123L,54L,126L,127L,1L,128L,2L };
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
public class A249144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249144Inst : IEnumerable<long>
{
public static readonly long[] Value=A249144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249144.Bytes);
public long this[int i]=>Value[i];

public static A249144Inst Instance=new A249144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249145
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,2L,2L,2L,1L,4L,1L,4L,1L,2L,3L,1L,1L,2L,3L,1L,5L,1L,3L,2L,2L,1L,2L,2L,2L,3L,2L,4L,2L,4L,2L,3L,1L,3L,2L,2L,2L,1L,3L,3L,2L,2L,3L,1L,2L,3L,2L,2L,2L,3L,2L,5L,1L,3L,2L,3L,3L,4L,1L,2L,2L,2L,3L,4L,2L,2L,1L,5L,2L,2L,2L,3L,3L,2L,4L,3L,2L,3L,2L,2L,2L,3L,2L,3L,3L,3L,2L,4L,3L,2L,5L,2L,6L,1L,2L,5L,1L,2L,4L,2L,4L,1L,3L,2L,3L,3L,4L,2L,3L,5L,2L,2L,2L,2L,4L,2L,2L,2L,1L,3L,5L,3L,4L };
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
public class A249145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249145Inst : IEnumerable<long>
{
public static readonly long[] Value=A249145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249145.Bytes);
public long this[int i]=>Value[i];

public static A249145Inst Instance=new A249145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249146
{
public static readonly long[] Value={ 0L,1L,2L,4L,1L,6L,2L,9L,3L,4L,5L,15L,1L,16L,2L,19L,7L,1L,21L,26L,8L,2L,32L,1L,34L,3L,9L,10L,43L,11L,12L,14L,4L,15L,3L,16L,4L,17L,5L,58L,6L,18L,19L,21L,71L,8L,9L,22L,23L,10L,84L,24L,11L,26L,27L,29L,12L,31L,2L,99L,13L,34L,14L,15L,5L,108L,37L,38L,40L,16L,6L,41L,42L,130L,3L,43L,44L,46L,17L,18L,47L,7L,19L,49L };
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
public class A249146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249146Inst : IEnumerable<long>
{
public static readonly long[] Value=A249146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249146.Bytes);
public long this[int i]=>Value[i];

public static A249146Inst Instance=new A249146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249147
{
public static readonly long[] Value={ 0L,1L,0L,2L,0L,1L,2L,1L,1L,1L,4L,0L,3L,0L,1L,1L,5L,0L,4L,1L,1L,1L,2L,1L,1L,1L,1L,9L,0L,1L,1L,2L,1L,1L,1L,11L,0L,2L,6L,1L,1L,12L,0L,1L,1L,2L,1L,1L,14L,0L,5L,2L,2L,1L,15L,0L,1L,4L,4L,1L,1L,1L,3L,2L,1L,1L,17L,0L,6L,3L,1L,1L,1L,2L,3L,1L,1L,1L,20L,0L,1L,1L,2L,1L,4L,2L,10L,0L,2L,1L,1L,22L,0L,1L,23L,0L,7L };
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
public class A249147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249147Inst : IEnumerable<long>
{
public static readonly long[] Value=A249147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249147.Bytes);
public long this[int i]=>Value[i];

public static A249147Inst Instance=new A249147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249148
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,4L,3L,2L,4L,6L,7L,1L,5L,1L,6L,8L,11L,1L,7L,2L,12L,14L,15L,6L,16L,20L,22L,23L,1L,8L,26L,27L,10L,28L,30L,31L,1L,9L,13L,2L,32L,37L,1L,10L,38L,39L,14L,40L,43L,1L,11L,3L,15L,16L,47L,1L,12L,49L,7L,8L,52L,54L,55L,9L,22L,56L,59L,1L,13L,5L,10L,60L,62L,63L,25L,14L,64L,70L,71L,1L,14L,72L,75L,28L,77L,15L,29L,1L,15L,30L,78L,79L,1L,16L,83L };
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
public class A249148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249148Inst : IEnumerable<long>
{
public static readonly long[] Value=A249148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249148.Bytes);
public long this[int i]=>Value[i];

public static A249148Inst Instance=new A249148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249149
{
public static readonly long[] Value={ 1L,5L,7L,14L,16L,44L,48L,240L,7200L,16560L,21600L,33120L,45360L,60480L,90720L,1179360L };
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
public class A249149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249149Inst : IEnumerable<long>
{
public static readonly long[] Value=A249149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249149.Bytes);
public long this[int i]=>Value[i];

public static A249149Inst Instance=new A249149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249150
{
public static readonly long[] Value={ 0L,0L,1L,0L,3L,1L,5L,0L,1L,3L,9L,6L,11L,5L,3L,0L,15L,1L,17L,3L,5L,9L,21L,10L,3L,11L,1L,5L,27L,24L,29L,0L,9L,15L,5L,35L,35L,17L,11L,39L,39L,5L,41L,9L,22L,21L,45L,18L,5L,3L,15L,11L,51L,1L,9L,34L,17L,27L,57L,46L,59L,29L,62L,0L,11L,9L,65L,15L,21L,48L,69L,40L,71L,35L,3L,17L,9L,11L,77L,79L,1L };
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
public class A249150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249150Inst : IEnumerable<long>
{
public static readonly long[] Value=A249150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249150.Bytes);
public long this[int i]=>Value[i];

public static A249150Inst Instance=new A249150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249151
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,2L,6L,1L,2L,4L,10L,7L,12L,6L,4L,1L,16L,2L,18L,4L,6L,10L,22L,11L,4L,12L,2L,6L,28L,25L,30L,1L,10L,16L,6L,36L,36L,18L,12L,40L,40L,6L,42L,10L,23L,22L,46L,19L,6L,4L,16L,12L,52L,2L,10L,35L,18L,28L,58L,47L,60L,30L,63L,1L,12L,10L,66L,16L,22L,49L,70L,41L,72L,36L,4L,18L,10L,12L,78L,80L,2L };
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
public class A249151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249151Inst : IEnumerable<long>
{
public static readonly long[] Value=A249151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249151.Bytes);
public long this[int i]=>Value[i];

public static A249151Inst Instance=new A249151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249152
{
public static readonly long[] Value={ 0L,0L,2L,2L,10L,10L,16L,16L,40L,40L,50L,50L,74L,74L,88L,88L,152L,152L,170L,170L,210L,210L,232L,232L,304L,304L,330L,330L,386L,386L,416L,416L,576L,576L,610L,610L,682L,682L,720L,720L,840L,840L,882L,882L,970L,970L,1016L,1016L,1208L,1208L,1258L,1258L,1362L,1362L,1416L,1416L,1584L,1584L,1642L,1642L };
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
public class A249152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249152Inst : IEnumerable<long>
{
public static readonly long[] Value=A249152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249152.Bytes);
public long this[int i]=>Value[i];

public static A249152Inst Instance=new A249152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249153
{
public static readonly long[] Value={ 0L,2L,10L,16L,40L,50L,74L,88L,152L,170L,210L,232L,304L,330L,386L,416L,576L,610L,682L,720L,840L,882L,970L,1016L,1208L,1258L,1362L,1416L,1584L,1642L,1762L,1824L,2208L,2274L,2410L,2480L,2696L,2770L,2922L,3000L,3320L,3402L,3570L,3656L,3920L,4010L,4194L,4288L,4768L,4866L,5066L,5168L,5480L,5586L,5802L,5912L };
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
public class A249153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249153Inst : IEnumerable<long>
{
public static readonly long[] Value=A249153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249153.Bytes);
public long this[int i]=>Value[i];

public static A249153Inst Instance=new A249153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249154
{
public static readonly long[] Value={ 0L,2L,3L,8L,5L,12L,14L,24L,9L,20L,22L,36L,26L,42L,45L,64L,17L,36L,38L,60L,42L,66L,69L,96L,50L,78L,81L,112L,87L,120L,124L,160L,33L,68L,70L,108L,74L,114L,117L,160L,82L,126L,129L,176L,135L,184L,188L,240L,98L,150L,153L,208L,159L,216L,220L,280L,171L,232L,236L,300L,244L,310L,315L,384L,65L };
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
public class A249154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249154Inst : IEnumerable<long>
{
public static readonly long[] Value=A249154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249154.Bytes);
public long this[int i]=>Value[i];

public static A249154Inst Instance=new A249154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249155
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,14L,80L,160L,301L,602L,693L,994L,1295L,1627L,1777L,2365L,2666L,5296L,5776L,6256L,17360L,34720L,51301L,52201L,105092L,155493L,209284L,587846L,735644L,7904800L,11495701L,80005507L,80469907L,83165017L,89731777L,90196177L };
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
public class A249155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249155Inst : IEnumerable<long>
{
public static readonly long[] Value=A249155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249155.Bytes);
public long this[int i]=>Value[i];

public static A249155Inst Instance=new A249155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249156
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,24L,57L,78L,114L,342L,624L,856L,1432L,10308L,12654L,27616L,100056L,537856L,593836L,769621L,1434168L,1473368L,1636104L,1823544L,1862744L,17968646L,18108296L,22412057L,34713713L,34853363L,39280254L,159690408L,663706192L };
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
public class A249156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249156Inst : IEnumerable<long>
{
public static readonly long[] Value=A249156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249156.Bytes);
public long this[int i]=>Value[i];

public static A249156Inst Instance=new A249156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249157
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,84L,366L,510L,732L,876L,1020L,1098L,1242L,1464L,10248L,30252L,31110L,62220L,103704L,146541L,3382050L,3698730L,4391268L,225622530L,272466250L,413186676L,713998530L,801837204L,848770222L,912265732L };
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
public class A249157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249157Inst : IEnumerable<long>
{
public static readonly long[] Value=A249157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249157.Bytes);
public long this[int i]=>Value[i];

public static A249157Inst Instance=new A249157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249158
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,8L,16L,24L,150L,300L,5952L,7752L,7955L,9755L,9958L,11904L,13704L,13907L,14110L,15707L,15910L,392850L,751043L,4585544L,12737804L,12828748L,16380296L,19289406L,19380350L,20228253L,33115710L,395849700L,1339182534L };
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
public class A249158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249158Inst : IEnumerable<long>
{
public static readonly long[] Value=A249158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249158.Bytes);
public long this[int i]=>Value[i];

public static A249158Inst Instance=new A249158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249159
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,2L,4L,7L,2L,2L,15L,18L,24L,4L,4L,24L,57L,30L,36L,4L,4L,105L,174L,282L,88L,100L,8L,8L,192L,561L,414L,570L,120L,132L,8L,8L,945L,1950L,3660L,1620L,2040L,312L,336L,16L,16L,1920L,6555L,6090L,9360L,2820L,3360L,392L,416L,16L,16L,10395L,25290L,53370L };
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
public class A249159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249159Inst : IEnumerable<long>
{
public static readonly long[] Value=A249159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249159.Bytes);
public long this[int i]=>Value[i];

public static A249159Inst Instance=new A249159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249160
{
public static readonly long[] Value={ 1L,0L,2L,1L,2L,3L,1L,2L,1L,4L,3L,2L,3L,1L,2L,1L,3L,2L,4L,3L,2L,3L,1L,2L,1L,5L,2L,3L,2L,4L,3L,2L,3L,1L,2L,1L,3L,4L,5L,2L,3L,2L,4L,3L,2L,3L,1L,2L,1L,2L,4L,3L,4L,5L,2L,3L,2L,4L,3L,2L,3L,1L,2L,1L,2L,3L,2L,4L,3L,4L,5L,2L,3L,2L,4L,3L,2L,3L,1L,2L,1L,3L,4L,2L,3L,2L,4L,3L,4L,5L,2L,3L,2L,4L,3L,2L,3L,1L,2L,1L };
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
public class A249160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249160Inst : IEnumerable<long>
{
public static readonly long[] Value=A249160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249160.Bytes);
public long this[int i]=>Value[i];

public static A249160Inst Instance=new A249160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249161
{
public static readonly long[] Value={ 1L,-1L,0L,0L,1L,-1L,2L,-1L,1L,-2L,2L,-1L,2L,-2L,1L,-2L,0L,0L,1L,-1L,2L,-1L,2L,-2L,1L,-2L,0L,0L,0L,1L,-1L,0L,1L,-1L,2L,-1L,1L,-2L,2L,-1L,2L,-2L,2L,-2L,1L,-2L,0L,0L,0L,1L,-1L,0L,1L,-1L,1L,-1L,2L,-1L,1L,-2L,0L,0L,2L,-1L,1L,-2L,2L,-1L,2L,-2L,1L,-2L,0L,0L,1L,-1L,2L };
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
public class A249161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249161Inst : IEnumerable<long>
{
public static readonly long[] Value=A249161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249161.Bytes);
public long this[int i]=>Value[i];

public static A249161Inst Instance=new A249161Inst();

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