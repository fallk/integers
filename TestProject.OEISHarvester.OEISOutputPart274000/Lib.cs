using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A071371
{
public static readonly long[] Value={ 1829413731L,13096880161L,28273111011L,32480018341L,79089694311L,330780346261L,363500177041L,602794125781L,679251409201L,905780175301L,956731265701L,1010903523841L,1011470714101L,1086338816631L,1312670706051L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071371Inst : IEnumerable<long>
{
public static readonly long[] Value=A071371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071371.Bytes);
public long this[int i]=>Value[i];

public static A071371Inst Instance=new A071371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071372
{
public static readonly long[] Value={ 1676641682L,1829413730L,862353305089L,2394196081201L,7816812203762L,9089234694530L,10689865119781L,10988437006262L,13826845745989L,17242727247890L,21487725800102L,24653435773682L,28779837186662L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071372Inst : IEnumerable<long>
{
public static readonly long[] Value=A071372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071372.Bytes);
public long this[int i]=>Value[i];

public static A071372Inst Instance=new A071372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071373
{
public static readonly long[] Value={ 2L,3L,4L,7L,211L,18362L,2914913L,10780552L,1829413731L,1676641682L,21487725800101L,22755817971366481L,107271326364325201L,7272877497848202226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071373Inst : IEnumerable<long>
{
public static readonly long[] Value=A071373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071373.Bytes);
public long this[int i]=>Value[i];

public static A071373Inst Instance=new A071373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071374
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071374Inst : IEnumerable<long>
{
public static readonly long[] Value=A071374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071374.Bytes);
public long this[int i]=>Value[i];

public static A071374Inst Instance=new A071374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071375
{
public static readonly long[] Value={ 1L,0L,2L,3L,0L,5L,0L,7L,0L,0L,0L,6L,0L,13L,0L,0L,0L,10L,0L,19L,0L,0L,0L,14L,0L,0L,0L,0L,0L,29L,0L,21L,0L,0L,0L,22L,0L,37L,0L,0L,0L,26L,0L,43L,0L,0L,0L,33L,0L,0L,0L,0L,0L,34L,0L,39L,0L,0L,0L,38L,0L,61L,0L,0L,0L,0L,0L,67L,0L,0L,0L,30L,0L,73L,0L,0L,0L,0L,0L,57L,0L,0L,0L,65L,0L,0L,0L,0L,0L,58L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071375Inst : IEnumerable<long>
{
public static readonly long[] Value=A071375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071375.Bytes);
public long this[int i]=>Value[i];

public static A071375Inst Instance=new A071375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071376
{
public static readonly long[] Value={ 0L,2L,3L,0L,5L,0L,7L,15L,14L,21L,11L,35L,13L,33L,26L,39L,17L,65L,19L,51L,38L,57L,23L,95L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071376Inst : IEnumerable<long>
{
public static readonly long[] Value=A071376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071376.Bytes);
public long this[int i]=>Value[i];

public static A071376Inst Instance=new A071376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071377
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,6L,7L,8L,9L,10L,11L,12L,13L,13L,14L,15L,16L,17L,18L,19L,20L,20L,21L,22L,23L,24L,24L,25L,26L,26L,27L,28L,29L,30L,31L,32L,33L,33L,34L,35L,36L,37L,38L,39L,40L,40L,41L,42L,43L,44L,45L,46L,47L,47L,48L,49L,50L,51L,51L,52L,53L,53L,54L,55L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071377Inst : IEnumerable<long>
{
public static readonly long[] Value=A071377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071377.Bytes);
public long this[int i]=>Value[i];

public static A071377Inst Instance=new A071377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071378
{
public static readonly long[] Value={ 4L,9L,32L,25L,108L,49L,256L,243L,500L,121L,864L,169L,1372L,1125L,2048L,289L,2916L,361L,4000L,3087L,5324L,529L,6912L,3125L,8788L,6561L,10976L,841L,13500L,961L,16384L,11979L,19652L,8575L,23328L,1369L,27436L,19773L,32000L,1681L,37044L,1849L,42592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071378Inst : IEnumerable<long>
{
public static readonly long[] Value=A071378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071378.Bytes);
public long this[int i]=>Value[i];

public static A071378Inst Instance=new A071378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071379
{
public static readonly BigInteger[] Value={ 1L,1L,209L,163121L,326922081L,1346634725665L,9939316337679281L,BigInteger.Parse("119802044788535500753"),BigInteger.Parse("2205421644124274191535553"),BigInteger.Parse("58945667435045762187763602753"),BigInteger.Parse("2198513228897522394476415669503377"),BigInteger.Parse("110833342180980170285766876408530089329") };
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
public class A071379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071379Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A071379.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A071379.Bytes);
public BigInteger this[int i]=>Value[i];

public static A071379Inst Instance=new A071379Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071380
{
public static readonly long[] Value={ 11L,109L,227L,277L,347L,857L,2297L,9043L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071380Inst : IEnumerable<long>
{
public static readonly long[] Value=A071380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071380.Bytes);
public long this[int i]=>Value[i];

public static A071380Inst Instance=new A071380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071381
{
public static readonly long[] Value={ 3L,19L,373L,419L,491L,1031L,83497L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071381Inst : IEnumerable<long>
{
public static readonly long[] Value=A071381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071381.Bytes);
public long this[int i]=>Value[i];

public static A071381Inst Instance=new A071381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071382
{
public static readonly long[] Value={ 139L,173L,547L,829L,2087L,2719L,3109L,10159L,56543L,80599L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071382Inst : IEnumerable<long>
{
public static readonly long[] Value=A071382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071382.Bytes);
public long this[int i]=>Value[i];

public static A071382Inst Instance=new A071382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071383
{
public static readonly long[] Value={ 0L,1L,5L,25L,65L,325L,1105L,4225L,5525L,27625L,71825L,138125L,160225L,801125L,2082925L,4005625L,5928325L,29641625L,77068225L,148208125L,243061325L,1215306625L,3159797225L,6076533125L,12882250225L,53716552825L,64411251125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071383Inst : IEnumerable<long>
{
public static readonly long[] Value=A071383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071383.Bytes);
public long this[int i]=>Value[i];

public static A071383Inst Instance=new A071383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071384
{
public static readonly long[] Value={ 0L,1L,3L,5L,9L,19L,34L,65L,75L,167L,269L,372L,401L,896L,1444L,2002L,2435L,5445L,8779L,12175L,15591L,34862L,56213L,77953L,113501L,231769L,253794L,409231L,567501L,886464L,1687299L,1982193L,3196190L,4432317L,7146896L,13178226L,15980946L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071384Inst : IEnumerable<long>
{
public static readonly long[] Value=A071384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071384.Bytes);
public long this[int i]=>Value[i];

public static A071384Inst Instance=new A071384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071385
{
public static readonly long[] Value={ 1L,4L,8L,12L,16L,24L,32L,36L,48L,64L,72L,80L,96L,128L,144L,160L,192L,256L,288L,320L,384L,512L,576L,640L,768L,864L,1024L,1152L,1280L,1536L,1728L,2048L,2304L,2560L,3072L,3456L,3840L,4096L,4608L,5120L,6144L,6912L,7680L,8192L,9216L,10240L,11520L,12288L,13824L,15360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071385Inst : IEnumerable<long>
{
public static readonly long[] Value=A071385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071385.Bytes);
public long this[int i]=>Value[i];

public static A071385Inst Instance=new A071385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071386
{
public static readonly long[] Value={ 2L,8L,20L,32L,40L,44L,48L,56L,60L,72L,92L,96L,104L,108L,116L,120L,128L,132L,140L,144L,156L,164L,192L,204L,212L,216L,220L,240L,252L,260L,272L,276L,296L,300L,332L,344L,356L,360L,368L,380L,384L,392L,396L,400L,416L,420L,440L,444L,452L,456L,476L,480L,500L,504L,512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071386Inst : IEnumerable<long>
{
public static readonly long[] Value=A071386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071386.Bytes);
public long this[int i]=>Value[i];

public static A071386Inst Instance=new A071386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071387
{
public static readonly long[] Value={ 0L,2L,8L,32L,40L,48L,396L,704L,72L,216L,144L,1056L,360L,384L,1320L,240L,9000L,7128L,480L,1296L,15936L,3072L,864L,7344L,720L,4992L,2016L,6000L,4752L,3024L,9984L,1920L,7560L,22848L,29160L,3360L,13248L,27720L,9072L,9360L,4032L,4800L,16896L,3840L,9504L,23520L,5040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071387Inst : IEnumerable<long>
{
public static readonly long[] Value=A071387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071387.Bytes);
public long this[int i]=>Value[i];

public static A071387Inst Instance=new A071387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071388
{
public static readonly long[] Value={ 1L,2L,8L,10L,20L,22L,28L,30L,32L,44L,46L,48L,52L,54L,56L,58L,66L,70L,72L,78L,82L,92L,96L,102L,104L,106L,110L,116L,120L,126L,130L,132L,136L,138L,140L,148L,150L,156L,164L,166L,172L,178L,190L,196L,198L,204L,210L,212L,216L,220L,222L,226L,228L,238L,240L,250L,260L,262L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071388Inst : IEnumerable<long>
{
public static readonly long[] Value=A071388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071388.Bytes);
public long this[int i]=>Value[i];

public static A071388Inst Instance=new A071388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071389
{
public static readonly long[] Value={ 1L,2L,8L,32L,48L,396L,72L,216L,1056L,1320L,240L,480L,15936L,3072L,7344L,2016L,3024L,9984L,22848L,3360L,13248L,9360L,4800L,9504L,9216L,23328L,7680L,53280L,12480L,29376L,91200L,159744L,22464L,228960L,29952L,179200L,47040L,68544L,15840L,20736L,61440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071389Inst : IEnumerable<long>
{
public static readonly long[] Value=A071389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071389.Bytes);
public long this[int i]=>Value[i];

public static A071389Inst Instance=new A071389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071390
{
public static readonly long[] Value={ 0L,2L,0L,0L,4L,0L,9L,0L,0L,6L,8L,0L,0L,10L,49L,15L,0L,14L,0L,21L,0L,27L,16L,12L,0L,22L,169L,33L,0L,26L,0L,39L,18L,20L,289L,65L,0L,34L,361L,51L,0L,38L,0L,28L,0L,0L,32L,95L,0L,46L,0L,24L,0L,45L,0L,115L,0L,0L,841L,161L,0L,58L,961L,30L,0L,62L,81L,63L,0L,0L,0L,155L,50L,40L,1369L,217L,0L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071390Inst : IEnumerable<long>
{
public static readonly long[] Value=A071390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071390.Bytes);
public long this[int i]=>Value[i];

public static A071390Inst Instance=new A071390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071391
{
public static readonly long[] Value={ 0L,1L,0L,2L,0L,3L,0L,0L,4L,5L,0L,0L,0L,6L,0L,0L,0L,0L,8L,0L,0L,10L,0L,0L,0L,13L,0L,0L,0L,14L,0L,12L,0L,17L,0L,0L,0L,19L,16L,0L,0L,0L,0L,21L,18L,22L,0L,0L,0L,20L,25L,0L,0L,26L,0L,0L,0L,27L,0L,0L,0L,31L,0L,0L,0L,0L,0L,24L,0L,34L,0L,35L,0L,37L,0L,0L,0L,38L,32L,30L,0L,41L,0L,0L,0L,43L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071391Inst : IEnumerable<long>
{
public static readonly long[] Value=A071391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071391.Bytes);
public long this[int i]=>Value[i];

public static A071391Inst Instance=new A071391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071392
{
public static readonly long[] Value={ 1L,73L,247L,2573L,2627L,2839L,3379L,5609L,7501L,9113L,9827L,10081L,10877L,11531L,12851L,13949L,14909L,16279L,16367L,17323L,18833L,22151L,26039L,26753L,29749L,31589L,31807L,34099L,35039L,35711L,36517L,36991L,39049L,41353L,43289L,43679L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071392Inst : IEnumerable<long>
{
public static readonly long[] Value=A071392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071392.Bytes);
public long this[int i]=>Value[i];

public static A071392Inst Instance=new A071392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071393
{
public static readonly long[] Value={ 1L,558L,1456L,2170L,2976L,4680L,5328L,6816L,7098L,7812L,9796L,10230L,13192L,13578L,14058L,14260L,15066L,19096L,22320L,26128L,26350L,28542L,28768L,30600L,32338L,33696L,36828L,38440L,40612L,40950L,50268L,53946L,57510L,58590L,62196L,64750L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071393Inst : IEnumerable<long>
{
public static readonly long[] Value=A071393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071393.Bytes);
public long this[int i]=>Value[i];

public static A071393Inst Instance=new A071393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071394
{
public static readonly long[] Value={ 4L,6L,33L,335L,355L,3073L,8408L,64690L,481044L,1304693L,1304719L,3524318L,3524654L,9559785L,9559905L,70115803L,189963234L,189963918L,514278263L,1394194660L,3779856591L,10246935974L,75370122456L,204475052725L,204475053325L,1505578023783L,1505578024917L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071394Inst : IEnumerable<long>
{
public static readonly long[] Value=A071394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071394.Bytes);
public long this[int i]=>Value[i];

public static A071394Inst Instance=new A071394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071395
{
public static readonly long[] Value={ 20L,70L,88L,104L,272L,304L,368L,464L,550L,572L,650L,748L,836L,945L,1184L,1312L,1376L,1430L,1504L,1575L,1696L,1870L,1888L,1952L,2002L,2090L,2205L,2210L,2470L,2530L,2584L,2990L,3128L,3190L,3230L,3410L,3465L,3496L,3770L,3944L,4030L,4070L,4095L,4216L,4288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071395Inst : IEnumerable<long>
{
public static readonly long[] Value=A071395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071395.Bytes);
public long this[int i]=>Value[i];

public static A071395Inst Instance=new A071395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071396
{
public static readonly long[] Value={ 0L,3L,14L,31L,55L,87L,125L,170L,222L,281L,346L,419L,499L,585L,679L,779L,887L,1001L,1122L,1251L,1386L,1528L,1677L,1833L,1995L,2165L,2342L,2525L,2716L,2913L,3118L,3329L,3547L,3772L,4005L,4244L,4489L,4742L,5002L,5269L,5543L,5823L,6111L,6405L,6707L,7015L,7330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071396Inst : IEnumerable<long>
{
public static readonly long[] Value=A071396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071396.Bytes);
public long this[int i]=>Value[i];

public static A071396Inst Instance=new A071396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071397
{
public static readonly long[] Value={ 0L,21L,83L,186L,330L,516L,743L,1012L,1321L,1672L,2065L,2498L,2973L,3489L,4047L,4645L,5285L,5967L,6689L,7453L,8258L,9105L,9993L,10922L,11892L,12904L,13957L,15051L,16186L,17363L,18581L,19841L,21141L,22483L,23866L,25291L,26757L,28264L,29812L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071397Inst : IEnumerable<long>
{
public static readonly long[] Value=A071397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071397.Bytes);
public long this[int i]=>Value[i];

public static A071397Inst Instance=new A071397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071398
{
public static readonly long[] Value={ 0L,9L,35L,78L,139L,217L,312L,424L,554L,701L,866L,1048L,1247L,1464L,1697L,1949L,2217L,2503L,2806L,3126L,3464L,3819L,4192L,4581L,4988L,5413L,5854L,6313L,6790L,7283L,7794L,8323L,8868L,9431L,10011L,10609L,11224L,11856L,12505L,13172L,13856L,14558L,15277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071398Inst : IEnumerable<long>
{
public static readonly long[] Value=A071398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071398.Bytes);
public long this[int i]=>Value[i];

public static A071398Inst Instance=new A071398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071399
{
public static readonly long[] Value={ 0L,0L,1L,3L,8L,15L,25L,40L,60L,86L,118L,157L,204L,259L,323L,398L,483L,579L,687L,808L,943L,1091L,1255L,1434L,1629L,1841L,2071L,2320L,2587L,2874L,3182L,3511L,3862L,4235L,4632L,5053L,5498L,5970L,6467L,6991L,7542L,8122L,8731L,9370L,10039L,10739L,11471L,12236L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071399Inst : IEnumerable<long>
{
public static readonly long[] Value=A071399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071399.Bytes);
public long this[int i]=>Value[i];

public static A071399Inst Instance=new A071399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071400
{
public static readonly long[] Value={ 0L,0L,4L,13L,30L,59L,102L,162L,241L,344L,471L,627L,815L,1036L,1294L,1591L,1931L,2316L,2749L,3233L,3771L,4366L,5020L,5736L,6517L,7366L,8285L,9279L,10348L,11497L,12728L,14044L,15447L,16941L,18528L,20211L,21994L,23878L,25867L,27963L,30170L,32490L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071400Inst : IEnumerable<long>
{
public static readonly long[] Value=A071400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071400.Bytes);
public long this[int i]=>Value[i];

public static A071400Inst Instance=new A071400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071401
{
public static readonly long[] Value={ 0L,8L,61L,207L,490L,958L,1655L,2628L,3924L,5586L,7663L,10200L,13242L,16836L,21028L,25863L,31388L,37649L,44691L,52561L,61305L,70968L,81597L,93237L,105935L,119736L,134687L,150833L,168221L,186896L,206904L,228292L,251105L,275390L,301191L,328556L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071401Inst : IEnumerable<long>
{
public static readonly long[] Value=A071401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071401.Bytes);
public long this[int i]=>Value[i];

public static A071401Inst Instance=new A071401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071402
{
public static readonly long[] Value={ 0L,2L,17L,59L,140L,273L,471L,748L,1117L,1590L,2182L,2904L,3770L,4793L,5987L,7363L,8936L,10719L,12724L,14964L,17454L,20205L,23231L,26545L,30160L,34089L,38345L,42942L,47893L,53209L,58906L,64995L,71490L,78404L,85749L,93540L,101789L,110509L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071402Inst : IEnumerable<long>
{
public static readonly long[] Value=A071402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071402.Bytes);
public long this[int i]=>Value[i];

public static A071402Inst Instance=new A071402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071403
{
public static readonly long[] Value={ 2L,3L,4L,6L,8L,9L,12L,13L,16L,18L,20L,24L,27L,29L,31L,33L,37L,38L,42L,45L,46L,50L,52L,56L,61L,62L,64L,67L,68L,71L,78L,81L,84L,86L,92L,93L,96L,100L,103L,105L,109L,110L,117L,118L,121L,122L,130L,139L,141L,142L,145L,149L,150L,154L,158L,162L,166L,167L,170L,172L,174L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071403Inst : IEnumerable<long>
{
public static readonly long[] Value=A071403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071403.Bytes);
public long this[int i]=>Value[i];

public static A071403Inst Instance=new A071403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071404
{
public static readonly long[] Value={ 1L,3L,5L,9L,13L,18L,25L,31L,39L,46L,55L,66L,76L,86L,99L,112L,125L,142L,157L,172L,187L,206L,225L,244L,264L,285L,307L,328L,353L,377L,400L,429L,453L,480L,507L,534L,562L,593L,623L,656L,691L,725L,762L,795L,831L,867L,904L,941L,977L,1019L,1059L,1101L,1145L,1185L,1226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071404Inst : IEnumerable<long>
{
public static readonly long[] Value=A071404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071404.Bytes);
public long this[int i]=>Value[i];

public static A071404Inst Instance=new A071404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071405
{
public static readonly BigInteger[] Value={ 1L,3L,33L,495L,186135L,4171377L,2466841857L,63503364807L,45502121922063L,1000280542916542065L,BigInteger.Parse("28769246281107682239"),BigInteger.Parse("725108164366019776175793"),BigInteger.Parse("647570641899231298169462337"),BigInteger.Parse("19531524543125261885413183191") };
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
public class A071405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071405Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A071405.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A071405.Bytes);
public BigInteger this[int i]=>Value[i];

public static A071405Inst Instance=new A071405Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071406
{
public static readonly long[] Value={ 4L,2L,1L,3L,2L,17L,7L,6L,3L,14L,29L,30L,48L,27L,9L,24L,12L,97L,78L,47L,71L,80L,55L,13L,57L,20L,81L,259L,108L,163L,81L,118L,63L,215L,173L,513L,420L,561L,537L,1162L,158L,33L,122L,286L,459L,391L,305L,288L,114L,307L,15L,680L,355L,365L,338L,70L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071406Inst : IEnumerable<long>
{
public static readonly long[] Value=A071406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071406.Bytes);
public long this[int i]=>Value[i];

public static A071406Inst Instance=new A071406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071407
{
public static readonly long[] Value={ 2L,2L,6L,6L,18L,24L,6L,12L,6L,12L,42L,54L,30L,24L,6L,120L,18L,258L,24L,18L,84L,132L,54L,48L,114L,42L,6L,6L,48L,24L,144L,30L,6L,12L,12L,78L,24L,36L,30L,54L,132L,18L,90L,36L,66L,18L,42L,30L,120L,30L,36L,42L,18L,18L,54L,84L,60L,12L,210L,12L,6L,60L,150L,102L,6L,210L,30L,24L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071407Inst : IEnumerable<long>
{
public static readonly long[] Value=A071407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071407.Bytes);
public long this[int i]=>Value[i];

public static A071407Inst Instance=new A071407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071408
{
public static readonly long[] Value={ 0L,1L,4L,7L,10L,15L,20L,25L,32L,39L,46L,55L,64L,73L,84L,95L,106L,119L,132L,145L,160L,175L,190L,207L,224L,241L,260L,279L,298L,319L,340L,361L,384L,407L,430L,455L,480L,505L,532L,559L,586L,615L,644L,673L,704L,735L,766L,799L,832L,865L,900L,935L,970L,1007L,1044L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071408Inst : IEnumerable<long>
{
public static readonly long[] Value=A071408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071408.Bytes);
public long this[int i]=>Value[i];

public static A071408Inst Instance=new A071408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071409
{
public static readonly BigInteger[] Value={ 2L,7L,80L,2692L,-188160L,673763328L,53114341552128L,11442355482580107264UL,BigInteger.Parse("101868843539003372580372480"),BigInteger.Parse("-11188458083483956358422238173593600"),BigInteger.Parse("39367352051951445285669984261580278202368000") };
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
public class A071409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071409Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A071409.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A071409.Bytes);
public BigInteger this[int i]=>Value[i];

public static A071409Inst Instance=new A071409Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071410
{
public static readonly BigInteger[] Value={ 1L,196L,65028096L,1540115470208876544L,BigInteger.Parse("861787404007697994335390269440000"),BigInteger.Parse("3024149801599872168810739614376506649075557335040000"),BigInteger.Parse("25610879735369429335666530857036523659955793212506655095941286757767577600000000") };
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
public class A071410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071410Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A071410.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A071410.Bytes);
public BigInteger this[int i]=>Value[i];

public static A071410Inst Instance=new A071410Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071411
{
public static readonly long[] Value={ 1L,0L,-1L,-2L,0L,3L,8L,13L,21L,34L,47L,64L,84L,105L,128L,156L,189L,223L,262L,303L,344L,390L,439L,493L,554L,617L,681L,748L,815L,884L,966L,1051L,1140L,1230L,1329L,1429L,1534L,1643L,1755L,1872L,1994L,2117L,2248L,2379L,2513L,2648L,2794L,2951L,3110L,3270L,3433L,3600L,3767L,3943L,4124L,4310L,4501L,4692L,4888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071411Inst : IEnumerable<long>
{
public static readonly long[] Value=A071411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071411.Bytes);
public long this[int i]=>Value[i];

public static A071411Inst Instance=new A071411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071428
{
public static readonly long[] Value={ 4L,6L,16L,18L,28L,30L,42L,52L,78L,88L,100L,112L,126L,136L,138L,148L,162L,172L,196L,198L,210L,222L,232L,256L,268L,280L,282L,292L,316L,330L,352L,378L,388L,400L,448L,460L,462L,486L,508L,520L,556L,568L,570L,592L,606L,616L,630L,640L,652L,676L,690L,700L,738L,750L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071428Inst : IEnumerable<long>
{
public static readonly long[] Value=A071428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071428.Bytes);
public long this[int i]=>Value[i];

public static A071428Inst Instance=new A071428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071429
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,2L,1L,2L,2L,1L,0L,4L,1L,4L,4L,1L,2L,2L,1L,2L,0L,1L,0L,4L,1L,2L,6L,1L,6L,4L,1L,4L,0L,1L,0L,2L,1L,2L,6L,1L,4L,4L,1L,4L,6L,1L,2L,2L,1L,2L,0L,1L,0L,8L,1L,6L,6L,1L,6L,4L,1L,4L,0L,1L,0L,2L,1L,2L,2L,1L,0L,4L,1L,4L,6L,1L,6L,2L,1L,2L,0L,1L,0L,8L,1L,2L,6L,1L,6L,4L,1L,4L,0L,1L,0L,2L,1L,2L,6L,1L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071429Inst : IEnumerable<long>
{
public static readonly long[] Value=A071429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071429.Bytes);
public long this[int i]=>Value[i];

public static A071429Inst Instance=new A071429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071430
{
public static readonly long[] Value={ 1L,0L,0L,1L,2L,2L,1L,4L,0L,1L,4L,2L,1L,4L,0L,1L,4L,2L,1L,4L,2L,1L,0L,2L,1L,4L,2L,1L,4L,5L,1L,4L,2L,1L,4L,2L,1L,4L,2L,3L,4L,2L,3L,4L,2L,3L,4L,2L,3L,4L,2L,3L,4L,2L,1L,4L,2L,3L,3L,2L,5L,4L,2L,5L,4L,2L,3L,1L,2L,5L,4L,2L,3L,4L,2L,5L,4L,2L,3L,3L,2L,5L,4L,2L,5L,3L,2L,5L,3L,2L,1L,4L,2L,5L,3L,2L,5L,4L,2L,5L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071430Inst : IEnumerable<long>
{
public static readonly long[] Value=A071430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071430.Bytes);
public long this[int i]=>Value[i];

public static A071430Inst Instance=new A071430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071431
{
public static readonly long[] Value={ 0L,1L,1L,0L,2L,1L,3L,0L,1L,1L,3L,2L,2L,3L,4L,1L,5L,3L,2L,2L,3L,1L,1L,0L,3L,1L,2L,0L,1L,1L,4L,4L,2L,6L,4L,1L,1L,0L,2L,1L,3L,0L,1L,1L,3L,2L,2L,3L,4L,4L,5L,7L,2L,2L,3L,1L,1L,0L,3L,1L,2L,0L,1L,1L,4L,4L,3L,6L,4L,1L,1L,0L,2L,1L,3L,0L,1L,1L,3L,2L,2L,3L,4L,4L,5L,7L,2L,2L,3L,1L,1L,0L,3L,1L,2L,0L,1L,1L,4L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071431Inst : IEnumerable<long>
{
public static readonly long[] Value=A071431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071431.Bytes);
public long this[int i]=>Value[i];

public static A071431Inst Instance=new A071431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071432
{
public static readonly long[] Value={ 1L,0L,2L,1L,0L,2L,1L,3L,2L,1L,3L,2L,4L,3L,0L,4L,3L,2L,4L,1L,2L,3L,1L,2L,0L,1L,2L,4L,1L,5L,4L,1L,5L,4L,1L,5L,2L,1L,0L,2L,1L,3L,2L,1L,3L,2L,4L,3L,2L,4L,3L,2L,4L,3L,2L,4L,3L,2L,0L,3L,2L,4L,8L,5L,4L,3L,5L,4L,6L,5L,2L,6L,5L,2L,1L,3L,2L,1L,3L,2L,4L,3L,2L,4L,3L,2L,4L,3L,2L,4L,3L,2L,0L,3L,2L,4L,3L,5L,4L,3L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071432Inst : IEnumerable<long>
{
public static readonly long[] Value=A071432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071432.Bytes);
public long this[int i]=>Value[i];

public static A071432Inst Instance=new A071432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071433
{
public static readonly long[] Value={ 1L,2L,0L,1L,2L,3L,1L,2L,3L,4L,0L,3L,4L,2L,1L,3L,2L,1L,0L,2L,1L,4L,5L,1L,4L,5L,1L,2L,0L,1L,2L,3L,1L,2L,3L,4L,2L,3L,4L,2L,3L,4L,2L,1L,0L,2L,8L,4L,5L,3L,4L,5L,6L,2L,5L,1L,2L,3L,1L,2L,3L,4L,2L,3L,4L,2L,3L,4L,2L,3L,0L,2L,3L,4L,5L,3L,4L,5L,6L,4L,5L,6L,2L,3L,1L,2L,3L,4L,2L,3L,4L,2L,3L,4L,2L,3L,0L,2L,3L,4L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071433Inst : IEnumerable<long>
{
public static readonly long[] Value=A071433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071433.Bytes);
public long this[int i]=>Value[i];

public static A071433Inst Instance=new A071433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071434
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,1L,1L,4L,4L,3L,3L,2L,2L,1L,1L,4L,4L,2L,2L,6L,6L,4L,4L,1L,1L,2L,2L,7L,7L,1L,1L,4L,4L,3L,3L,2L,2L,1L,1L,4L,4L,6L,6L,7L,7L,4L,4L,1L,1L,2L,2L,8L,8L,5L,5L,4L,4L,7L,7L,2L,2L,1L,1L,8L,8L,6L,6L,7L,7L,4L,4L,1L,1L,2L,2L,3L,3L,1L,1L,4L,4L,7L,7L,2L,2L,1L,1L,8L,8L,2L,2L,7L,7L,4L,4L,1L,1L,2L,2L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071434Inst : IEnumerable<long>
{
public static readonly long[] Value=A071434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071434.Bytes);
public long this[int i]=>Value[i];

public static A071434Inst Instance=new A071434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071435
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,1L,1L,4L,4L,3L,2L,2L,1L,1L,4L,2L,2L,6L,4L,4L,1L,1L,2L,2L,7L,1L,1L,4L,4L,3L,2L,2L,1L,1L,4L,8L,2L,7L,4L,4L,1L,1L,2L,2L,7L,8L,1L,4L,4L,7L,2L,2L,1L,1L,4L,4L,2L,7L,7L,4L,1L,1L,2L,2L,7L,7L,1L,1L,4L,7L,2L,2L,1L,1L,4L,4L,6L,2L,7L,4L,1L,1L,2L,2L,8L,8L,5L,1L,4L,7L,2L,2L,1L,1L,8L,8L,6L,7L,7L,4L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071435Inst : IEnumerable<long>
{
public static readonly long[] Value=A071435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071435.Bytes);
public long this[int i]=>Value[i];

public static A071435Inst Instance=new A071435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071436
{
public static readonly long[] Value={ 1L,0L,2L,2L,4L,1L,1L,3L,2L,4L,4L,6L,6L,2L,1L,1L,7L,6L,8L,4L,1L,1L,6L,5L,4L,8L,1L,1L,12L,4L,5L,6L,1L,1L,3L,12L,6L,6L,8L,9L,2L,11L,6L,6L,4L,2L,1L,1L,12L,13L,4L,10L,8L,1L,12L,12L,5L,11L,1L,16L,2L,2L,12L,6L,1L,1L,2L,13L,12L,6L,6L,8L,1L,1L,7L,6L,11L,4L,16L,16L,6L,5L,5L,19L,1L,1L,12L,4L,14L,16L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071436Inst : IEnumerable<long>
{
public static readonly long[] Value=A071436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071436.Bytes);
public long this[int i]=>Value[i];

public static A071436Inst Instance=new A071436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071437
{
public static readonly long[] Value={ 1L,2L,3L,4L,1L,5L,3L,2L,1L,5L,4L,2L,6L,8L,1L,2L,3L,7L,4L,5L,8L,2L,9L,5L,4L,7L,6L,8L,1L,4L,6L,2L,7L,4L,11L,2L,3L,8L,5L,4L,3L,8L,2L,1L,11L,8L,2L,9L,5L,1L,2L,13L,8L,4L,5L,3L,2L,1L,5L,14L,7L,2L,8L,4L,14L,2L,8L,4L,10L,11L,8L,7L,5L,4L,11L,7L,8L,16L,4L,15L,3L,2L,4L,1L,14L,8L,9L,4L,14L,16L,17L,8L,19L,4L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071437Inst : IEnumerable<long>
{
public static readonly long[] Value=A071437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071437.Bytes);
public long this[int i]=>Value[i];

public static A071437Inst Instance=new A071437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071438
{
public static readonly long[] Value={ 1L,0L,1L,2L,3L,2L,4L,1L,4L,6L,2L,3L,2L,1L,5L,1L,7L,6L,8L,5L,1L,10L,11L,2L,6L,8L,4L,5L,10L,6L,2L,1L,5L,1L,5L,6L,2L,6L,8L,1L,11L,10L,6L,12L,8L,5L,4L,10L,11L,16L,8L,1L,5L,11L,2L,3L,6L,1L,4L,1L,10L,16L,12L,8L,12L,18L,11L,10L,6L,8L,9L,5L,10L,11L,16L,9L,8L,4L,5L,10L,6L,7L,9L,5L,16L,10L,11L,20L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071438Inst : IEnumerable<long>
{
public static readonly long[] Value=A071438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071438.Bytes);
public long this[int i]=>Value[i];

public static A071438Inst Instance=new A071438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071439
{
public static readonly long[] Value={ 1L,0L,2L,3L,4L,1L,6L,2L,3L,4L,1L,6L,7L,3L,2L,1L,6L,7L,5L,2L,8L,9L,6L,5L,2L,8L,7L,1L,10L,4L,3L,7L,1L,10L,4L,2L,8L,6L,1L,3L,2L,8L,14L,7L,10L,2L,3L,8L,7L,11L,12L,4L,8L,1L,6L,10L,4L,14L,1L,7L,10L,3L,2L,6L,7L,10L,5L,9L,8L,7L,12L,10L,5L,3L,7L,6L,10L,16L,8L,9L,18L,10L,3L,8L,9L,18L,7L,11L,5L,8L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071439Inst : IEnumerable<long>
{
public static readonly long[] Value=A071439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071439.Bytes);
public long this[int i]=>Value[i];

public static A071439Inst Instance=new A071439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071440
{
public static readonly long[] Value={ 1L,2L,6L,42L,26L,48L,92L,96L,132L,20L,6L,42L,26L,48L,92L,96L,132L,20L,6L,42L,26L,48L,92L,96L,132L,20L,6L,42L,26L,48L,92L,96L,132L,20L,6L,42L,26L,48L,92L,96L,132L,20L,6L,42L,26L,48L,92L,96L,132L,20L,6L,42L,26L,48L,92L,96L,132L,20L,6L,42L,26L,48L,92L,96L,132L,20L,6L,42L,26L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071440Inst : IEnumerable<long>
{
public static readonly long[] Value=A071440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071440.Bytes);
public long this[int i]=>Value[i];

public static A071440Inst Instance=new A071440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071441
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,0L,3L,3L,3L,1L,1L,1L,1L,0L,4L,4L,3L,3L,3L,3L,2L,2L,2L,2L,4L,4L,4L,0L,5L,5L,5L,2L,2L,2L,2L,3L,3L,3L,3L,5L,5L,0L,1L,1L,1L,1L,3L,3L,3L,3L,2L,2L,2L,4L,4L,4L,1L,0L,5L,5L,5L,6L,6L,6L,2L,3L,3L,7L,7L,8L,8L,0L,1L,9L,9L,9L,7L,7L,2L,3L,2L,2L,3L,9L,5L,5L,1L,4L,4L,4L,8L,6L,6L,5L,2L,3L,3L,10L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071441Inst : IEnumerable<long>
{
public static readonly long[] Value=A071441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071441.Bytes);
public long this[int i]=>Value[i];

public static A071441Inst Instance=new A071441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071442
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,2L,2L,0L,3L,3L,4L,1L,1L,0L,1L,5L,4L,3L,3L,3L,2L,2L,2L,1L,6L,0L,1L,0L,4L,5L,2L,2L,1L,6L,6L,5L,7L,0L,1L,0L,1L,1L,2L,5L,5L,0L,3L,8L,4L,8L,1L,0L,1L,5L,4L,5L,3L,3L,7L,2L,2L,1L,6L,6L,1L,4L,4L,5L,4L,2L,1L,6L,6L,6L,7L,0L,7L,0L,10L,1L,2L,5L,9L,0L,7L,7L,4L,8L,6L,0L,1L,5L,4L,5L,4L,4L,1L,8L,9L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071442Inst : IEnumerable<long>
{
public static readonly long[] Value=A071442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071442.Bytes);
public long this[int i]=>Value[i];

public static A071442Inst Instance=new A071442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071443
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,0L,3L,3L,1L,1L,1L,2L,2L,4L,3L,3L,3L,5L,5L,2L,1L,4L,4L,3L,3L,3L,2L,2L,2L,1L,1L,1L,4L,0L,5L,0L,2L,2L,2L,4L,4L,7L,5L,5L,5L,6L,6L,4L,2L,7L,7L,8L,8L,6L,1L,9L,1L,2L,2L,2L,3L,3L,6L,6L,9L,9L,5L,4L,4L,3L,6L,6L,6L,2L,9L,1L,1L,1L,4L,8L,5L,5L,5L,9L,3L,1L,1L,8L,8L,5L,5L,5L,9L,3L,10L,2L,2L,7L,8L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071443Inst : IEnumerable<long>
{
public static readonly long[] Value=A071443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071443.Bytes);
public long this[int i]=>Value[i];

public static A071443Inst Instance=new A071443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071460
{
public static readonly long[] Value={ 1L,1L,0L,0L,2L,1L,2L,0L,2L,1L,1L,0L,4L,4L,1L,5L,2L,4L,1L,1L,2L,0L,4L,1L,2L,0L,4L,1L,1L,5L,4L,4L,2L,5L,2L,0L,2L,1L,5L,4L,4L,8L,5L,8L,2L,8L,2L,5L,2L,4L,10L,1L,10L,0L,10L,5L,2L,4L,2L,5L,1L,1L,4L,0L,5L,1L,2L,0L,2L,1L,1L,4L,10L,5L,1L,4L,2L,0L,1L,1L,2L,0L,10L,1L,2L,0L,10L,1L,1L,8L,9L,8L,1L,8L,2L,0L,1L,1L,2L,0L,10L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071460Inst : IEnumerable<long>
{
public static readonly long[] Value=A071460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071460.Bytes);
public long this[int i]=>Value[i];

public static A071460Inst Instance=new A071460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071461
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,2L,1L,3L,0L,2L,1L,3L,0L,1L,1L,3L,0L,2L,3L,3L,2L,2L,3L,4L,2L,5L,0L,4L,2L,5L,3L,2L,2L,3L,3L,2L,0L,3L,1L,1L,0L,3L,1L,2L,0L,3L,1L,2L,0L,1L,1L,4L,0L,5L,5L,4L,7L,2L,6L,4L,7L,5L,0L,4L,1L,1L,0L,2L,1L,3L,0L,2L,1L,3L,0L,1L,1L,3L,0L,2L,3L,3L,2L,2L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071461Inst : IEnumerable<long>
{
public static readonly long[] Value=A071461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071461.Bytes);
public long this[int i]=>Value[i];

public static A071461Inst Instance=new A071461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071462
{
public static readonly long[] Value={ 1L,0L,2L,1L,1L,0L,2L,1L,3L,0L,1L,1L,3L,0L,2L,3L,4L,2L,2L,3L,4L,2L,5L,3L,2L,2L,5L,3L,2L,0L,3L,1L,1L,0L,3L,1L,2L,0L,1L,1L,2L,0L,4L,4L,5L,5L,2L,6L,5L,7L,4L,0L,2L,1L,1L,0L,2L,1L,3L,0L,1L,1L,3L,8L,2L,3L,4L,8L,2L,5L,4L,7L,5L,6L,2L,5L,5L,6L,2L,0L,3L,1L,1L,0L,3L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071462Inst : IEnumerable<long>
{
public static readonly long[] Value=A071462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071462.Bytes);
public long this[int i]=>Value[i];

public static A071462Inst Instance=new A071462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071463
{
public static readonly long[] Value={ 1L,0L,0L,2L,1L,3L,3L,2L,1L,0L,4L,2L,5L,0L,3L,1L,5L,0L,4L,1L,5L,0L,4L,1L,3L,0L,4L,1L,3L,0L,2L,2L,3L,4L,4L,5L,3L,7L,2L,2L,3L,4L,4L,0L,3L,1L,2L,5L,3L,4L,6L,5L,8L,4L,6L,3L,7L,7L,5L,8L,4L,9L,2L,8L,3L,9L,2L,8L,1L,9L,2L,8L,4L,6L,5L,7L,4L,9L,8L,7L,10L,5L,6L,4L,9L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071463Inst : IEnumerable<long>
{
public static readonly long[] Value=A071463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071463.Bytes);
public long this[int i]=>Value[i];

public static A071463Inst Instance=new A071463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071464
{
public static readonly long[] Value={ 1L,0L,2L,2L,1L,0L,4L,4L,1L,2L,2L,0L,1L,4L,4L,6L,1L,7L,7L,0L,1L,2L,2L,6L,1L,4L,4L,8L,1L,2L,7L,8L,1L,0L,7L,2L,6L,8L,1L,4L,9L,8L,1L,2L,6L,0L,1L,4L,6L,2L,1L,8L,9L,0L,1L,6L,2L,2L,7L,0L,1L,8L,3L,2L,1L,4L,4L,8L,9L,2L,7L,8L,1L,0L,9L,2L,2L,6L,4L,4L,1L,8L,3L,2L,1L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071464Inst : IEnumerable<long>
{
public static readonly long[] Value=A071464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071464.Bytes);
public long this[int i]=>Value[i];

public static A071464Inst Instance=new A071464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071465
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,1L,2L,0L,3L,1L,2L,0L,3L,1L,1L,0L,3L,1L,2L,2L,3L,3L,2L,2L,4L,3L,5L,1L,4L,3L,5L,2L,2L,3L,3L,2L,2L,1L,3L,0L,1L,1L,3L,0L,2L,1L,3L,0L,2L,1L,1L,0L,4L,1L,5L,4L,4L,6L,2L,7L,4L,6L,5L,1L,4L,0L,1L,1L,2L,0L,3L,1L,2L,0L,3L,1L,1L,0L,3L,1L,2L,2L,3L,3L,2L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071465Inst : IEnumerable<long>
{
public static readonly long[] Value=A071465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071465.Bytes);
public long this[int i]=>Value[i];

public static A071465Inst Instance=new A071465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071466
{
public static readonly long[] Value={ 1L,1L,2L,0L,1L,1L,2L,0L,3L,1L,1L,0L,3L,1L,2L,2L,4L,3L,2L,2L,4L,3L,5L,2L,2L,3L,5L,2L,2L,1L,3L,0L,1L,1L,3L,0L,2L,1L,1L,0L,2L,1L,4L,5L,5L,4L,2L,7L,5L,6L,4L,1L,2L,0L,1L,1L,2L,0L,3L,1L,1L,0L,3L,8L,2L,2L,4L,8L,2L,4L,4L,6L,5L,7L,2L,4L,5L,7L,2L,1L,3L,0L,1L,1L,3L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071466Inst : IEnumerable<long>
{
public static readonly long[] Value=A071466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071466.Bytes);
public long this[int i]=>Value[i];

public static A071466Inst Instance=new A071466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071467
{
public static readonly long[] Value={ 1L,1L,0L,0L,2L,1L,3L,0L,2L,1L,1L,0L,2L,2L,3L,3L,4L,2L,5L,1L,4L,2L,2L,3L,3L,4L,2L,0L,1L,1L,2L,0L,3L,1L,2L,0L,5L,1L,4L,4L,5L,5L,2L,4L,6L,5L,1L,8L,4L,6L,2L,1L,3L,0L,2L,1L,8L,0L,2L,2L,3L,3L,4L,2L,5L,5L,8L,2L,7L,3L,3L,2L,2L,0L,5L,1L,2L,9L,3L,8L,2L,9L,5L,5L,4L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071467Inst : IEnumerable<long>
{
public static readonly long[] Value=A071467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071467.Bytes);
public long this[int i]=>Value[i];

public static A071467Inst Instance=new A071467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071468
{
public static readonly long[] Value={ 1L,0L,0L,2L,2L,2L,1L,1L,0L,3L,3L,2L,4L,1L,0L,6L,3L,2L,3L,1L,0L,1L,6L,2L,2L,4L,0L,1L,1L,5L,3L,3L,8L,4L,0L,6L,2L,3L,5L,5L,1L,1L,7L,3L,2L,2L,0L,1L,7L,6L,3L,3L,4L,5L,0L,6L,6L,2L,4L,5L,5L,1L,7L,7L,8L,4L,0L,10L,0L,2L,8L,4L,5L,5L,10L,7L,6L,8L,2L,2L,4L,9L,0L,1L,12L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071468Inst : IEnumerable<long>
{
public static readonly long[] Value=A071468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071468.Bytes);
public long this[int i]=>Value[i];

public static A071468Inst Instance=new A071468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071469
{
public static readonly long[] Value={ 1L,0L,1L,2L,2L,2L,0L,1L,0L,4L,2L,2L,1L,5L,0L,4L,7L,2L,2L,8L,0L,4L,1L,2L,2L,2L,8L,1L,0L,4L,2L,2L,1L,5L,0L,4L,7L,2L,2L,8L,0L,4L,1L,2L,2L,2L,8L,1L,1L,4L,2L,2L,6L,5L,0L,4L,7L,2L,2L,8L,0L,1L,1L,2L,3L,2L,8L,1L,1L,4L,4L,2L,6L,6L,0L,4L,4L,2L,2L,6L,0L,1L,1L,2L,3L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071469Inst : IEnumerable<long>
{
public static readonly long[] Value=A071469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071469.Bytes);
public long this[int i]=>Value[i];

public static A071469Inst Instance=new A071469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071470
{
public static readonly long[] Value={ 1L,0L,0L,2L,2L,2L,4L,1L,1L,1L,3L,3L,2L,4L,4L,4L,6L,6L,6L,2L,3L,1L,1L,1L,7L,6L,6L,8L,4L,2L,1L,1L,7L,6L,5L,3L,4L,8L,1L,1L,1L,6L,9L,4L,5L,5L,11L,1L,1L,1L,8L,8L,4L,4L,6L,6L,1L,9L,8L,3L,14L,10L,10L,6L,6L,8L,9L,2L,3L,11L,1L,1L,7L,8L,8L,10L,14L,11L,1L,1L,6L,4L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071470Inst : IEnumerable<long>
{
public static readonly long[] Value=A071470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071470.Bytes);
public long this[int i]=>Value[i];

public static A071470Inst Instance=new A071470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071471
{
public static readonly long[] Value={ 1L,1L,0L,2L,2L,2L,0L,1L,0L,4L,3L,2L,3L,1L,0L,1L,3L,2L,2L,4L,0L,1L,0L,4L,2L,2L,3L,1L,0L,1L,3L,2L,3L,4L,0L,1L,0L,2L,2L,2L,0L,1L,0L,4L,3L,2L,3L,4L,0L,1L,0L,2L,2L,2L,0L,1L,0L,4L,3L,2L,3L,1L,0L,1L,3L,2L,2L,4L,0L,1L,0L,4L,2L,2L,3L,1L,0L,1L,3L,2L,3L,4L,0L,1L,0L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071471Inst : IEnumerable<long>
{
public static readonly long[] Value=A071471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071471.Bytes);
public long this[int i]=>Value[i];

public static A071471Inst Instance=new A071471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071472
{
public static readonly long[] Value={ 1L,1L,0L,2L,2L,2L,4L,4L,1L,1L,1L,3L,2L,2L,4L,4L,4L,6L,6L,6L,2L,1L,1L,1L,5L,7L,6L,6L,8L,8L,1L,1L,1L,2L,6L,5L,5L,5L,8L,1L,1L,2L,2L,12L,5L,4L,5L,6L,6L,1L,1L,1L,4L,5L,5L,6L,6L,6L,1L,1L,1L,2L,2L,11L,6L,6L,6L,1L,1L,1L,2L,2L,8L,5L,5L,11L,8L,11L,1L,2L,2L,13L,5L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071472Inst : IEnumerable<long>
{
public static readonly long[] Value=A071472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071472.Bytes);
public long this[int i]=>Value[i];

public static A071472Inst Instance=new A071472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071473
{
public static readonly long[] Value={ 1L,0L,0L,2L,2L,3L,1L,1L,0L,4L,2L,2L,6L,1L,0L,3L,4L,2L,6L,6L,0L,5L,4L,2L,3L,3L,0L,1L,4L,2L,8L,3L,6L,5L,1L,4L,2L,3L,0L,8L,6L,4L,5L,5L,9L,7L,0L,10L,2L,3L,3L,7L,6L,1L,9L,4L,4L,10L,6L,11L,12L,5L,3L,9L,6L,6L,7L,10L,4L,3L,9L,11L,6L,2L,15L,3L,8L,10L,1L,7L,15L,3L,0L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071473Inst : IEnumerable<long>
{
public static readonly long[] Value=A071473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071473.Bytes);
public long this[int i]=>Value[i];

public static A071473Inst Instance=new A071473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071474
{
public static readonly long[] Value={ 1L,0L,2L,2L,3L,1L,0L,4L,2L,2L,6L,1L,0L,4L,2L,2L,6L,1L,0L,4L,3L,2L,2L,1L,0L,4L,3L,2L,6L,5L,0L,4L,3L,2L,6L,1L,0L,5L,3L,2L,6L,1L,0L,5L,3L,2L,6L,4L,0L,5L,7L,2L,8L,8L,0L,10L,7L,2L,8L,5L,0L,4L,6L,2L,3L,5L,0L,1L,6L,2L,3L,5L,0L,1L,6L,2L,3L,4L,0L,5L,6L,2L,3L,4L,0L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071474Inst : IEnumerable<long>
{
public static readonly long[] Value=A071474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071474.Bytes);
public long this[int i]=>Value[i];

public static A071474Inst Instance=new A071474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071475
{
public static readonly long[] Value={ 1L,0L,0L,1L,2L,2L,3L,4L,4L,5L,1L,1L,6L,3L,2L,2L,3L,4L,1L,5L,6L,6L,7L,3L,8L,2L,1L,1L,10L,7L,6L,6L,7L,5L,5L,4L,1L,10L,8L,2L,6L,6L,12L,4L,4L,5L,11L,15L,2L,2L,1L,8L,5L,4L,10L,5L,6L,2L,7L,8L,1L,1L,10L,5L,16L,12L,6L,7L,7L,17L,1L,10L,2L,2L,8L,12L,9L,13L,15L,4L,11L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071475Inst : IEnumerable<long>
{
public static readonly long[] Value=A071475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071475.Bytes);
public long this[int i]=>Value[i];

public static A071475Inst Instance=new A071475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071540
{
public static readonly long[] Value={ 4L,57L,664L,7068L,73130L,747244L,7590269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071540Inst : IEnumerable<long>
{
public static readonly long[] Value=A071540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071540.Bytes);
public long this[int i]=>Value[i];

public static A071540Inst Instance=new A071540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071541
{
public static readonly long[] Value={ 6L,43L,336L,2932L,26870L,252756L,2409731L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071541Inst : IEnumerable<long>
{
public static readonly long[] Value=A071541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071541.Bytes);
public long this[int i]=>Value[i];

public static A071541Inst Instance=new A071541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071542
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,7L,7L,7L,8L,8L,9L,9L,10L,10L,10L,10L,11L,11L,11L,11L,12L,12L,12L,12L,13L,13L,14L,14L,15L,15L,15L,15L,16L,16L,16L,16L,17L,17L,17L,17L,18L,18L,18L,18L,19L,19L,19L,19L,20L,20L,20L,20L,21L,21L,21L,21L,22L,22L,23L,23L,24L,24L,24L,24L,25L,25L,25L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071542Inst : IEnumerable<long>
{
public static readonly long[] Value=A071542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071542.Bytes);
public long this[int i]=>Value[i];

public static A071542Inst Instance=new A071542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071543
{
public static readonly BigInteger[] Value={ 1L,3L,-4L,12L,144L,576L,-7104L,45248L,450432L,2240512L,5292544L,-88076288L,-62210048L,391122944L,-1489174528L,-165174853632L,2565388042240L,-28667557511168L,-1065163492556800L,-14206520416796672L,-115544734381899776L,5968167755906547712L,BigInteger.Parse("-258278630548029046784") };
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
public class A071543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071543Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A071543.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A071543.Bytes);
public BigInteger this[int i]=>Value[i];

public static A071543Inst Instance=new A071543Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071544
{
public static readonly long[] Value={ 5L,2L,3L,4L,5L,3L,5L,4L,6L,5L,7L,4L,7L,6L,3L,8L,7L,6L,5L,4L,6L,8L,7L,6L,5L,6L,8L,4L,7L,6L,9L,8L,7L,6L,5L,9L,8L,7L,6L,8L,7L,6L,11L,4L,5L,10L,9L,6L,7L,10L,9L,8L,7L,6L,5L,7L,13L,12L,11L,10L,9L,8L,7L,8L,7L,6L,13L,12L,11L,5L,9L,8L,7L,6L,9L,8L,7L,12L,11L,10L,9L,8L,7L,6L,11L,10L,9L,8L,11L,6L,7L,4L,12L,11L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071544Inst : IEnumerable<long>
{
public static readonly long[] Value=A071544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071544.Bytes);
public long this[int i]=>Value[i];

public static A071544Inst Instance=new A071544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071545
{
public static readonly long[] Value={ 5L,1L,3L,4L,4L,2L,3L,4L,5L,5L,7L,3L,7L,4L,5L,5L,7L,6L,5L,4L,7L,8L,5L,6L,5L,6L,3L,7L,7L,5L,9L,4L,7L,6L,5L,9L,5L,7L,6L,8L,7L,6L,11L,4L,9L,9L,7L,8L,7L,10L,5L,8L,7L,6L,5L,7L,9L,6L,11L,10L,9L,8L,7L,8L,5L,6L,8L,4L,11L,10L,9L,8L,7L,6L,9L,8L,7L,12L,5L,10L,9L,8L,7L,6L,11L,10L,9L,8L,11L,6L,13L,8L,11L,11L,10L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071545Inst : IEnumerable<long>
{
public static readonly long[] Value=A071545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071545.Bytes);
public long this[int i]=>Value[i];

public static A071545Inst Instance=new A071545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071546
{
public static readonly long[] Value={ 5L,2L,5L,10L,17L,26L,37L,5L,65L,82L,101L,2L,13L,170L,197L,226L,61L,10L,325L,362L,5L,61L,13L,530L,577L,626L,41L,149L,785L,65L,73L,17L,149L,146L,1157L,1226L,41L,74L,1445L,1522L,1601L,317L,397L,373L,1937L,221L,97L,74L,2305L,26L,2501L,130L,493L,2810L,5L,3026L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071546Inst : IEnumerable<long>
{
public static readonly long[] Value=A071546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071546.Bytes);
public long this[int i]=>Value[i];

public static A071546Inst Instance=new A071546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071547
{
public static readonly BigInteger[] Value={ 0L,-1L,2L,0L,-2L,3L,8L,-259L,-9006L,37575L,1988916L,41615129L,-444915500L,4752358604L,-50506657344L,532544416084L,-4450492081868L,-10234691885873L,241215169689690L,21696729746925312L,123619114295636184L,174381272189413488L,BigInteger.Parse("-43909101832286346168"),BigInteger.Parse("-439142701170244441024") };
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
public class A071547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071547Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A071547.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A071547.Bytes);
public BigInteger this[int i]=>Value[i];

public static A071547Inst Instance=new A071547Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071548
{
public static readonly long[] Value={ 0L,-1L,2L,0L,0L,0L,2L,1L,-4L,12L,0L,-12L,-4L,7L,44L,48L,0L,-48L,44L,345L,334L,-1196L,2328L,4796L,8022L,-35417L,123840L,-118503L,89082L,48160L,-414248L,2107104L,-2358342L,-27802725L,-168156872L,415198413L,804518348L,-2450715149L,-711441100L,3648319725L,-2721771200L,-17289389524L,205130688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071548Inst : IEnumerable<long>
{
public static readonly long[] Value=A071548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071548.Bytes);
public long this[int i]=>Value[i];

public static A071548Inst Instance=new A071548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071549
{
public static readonly BigInteger[] Value={ 1L,5040L,681080400L,182509367040000L,BigInteger.Parse("66475579247327250000"),BigInteger.Parse("28837919555681211870935040"),BigInteger.Parse("14007180988362844601443040716800"),BigInteger.Parse("7363615666157189603982585462030336000") };
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
public class A071549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071549Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A071549.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A071549.Bytes);
public BigInteger this[int i]=>Value[i];

public static A071549Inst Instance=new A071549Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071550
{
public static readonly BigInteger[] Value={ 1L,40320L,81729648000L,369398958888960000L,BigInteger.Parse("2390461829733887910000000"),BigInteger.Parse("18975581770994682860770223800320"),BigInteger.Parse("171889289584866507880743491472699801600") };
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
public class A071550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071550Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A071550.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A071550.Bytes);
public BigInteger this[int i]=>Value[i];

public static A071550Inst Instance=new A071550Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071551
{
public static readonly BigInteger[] Value={ 1L,362880L,12504636144000L,BigInteger.Parse("1080491954750208000000"),BigInteger.Parse("140810154080474667338550000000"),BigInteger.Parse("23183587808948692737291767860055162880"),BigInteger.Parse("4439413043841128802009762476941510771390464000") };
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
public class A071551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071551Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A071551.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A071551.Bytes);
public BigInteger this[int i]=>Value[i];

public static A071551Inst Instance=new A071551Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071552
{
public static readonly BigInteger[] Value={ 1L,3628800L,2375880867360000L,BigInteger.Parse("4386797336285844480000000"),BigInteger.Parse("12868639981414579848070084500000000"),BigInteger.Parse("49120458506088132224064306071170476903628800") };
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
public class A071552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071552Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A071552.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A071552.Bytes);
public BigInteger this[int i]=>Value[i];

public static A071552Inst Instance=new A071552Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071553
{
public static readonly long[] Value={ 2L,3L,7L,5L,61L,11L,421L,13L,121L,71L,27721L,23L,360361L,4159L,841L,307L,12252241L,1121L,232792561L,2393L,4398241L,483209L,5354228881L,4093L,1460244241L,11232649L,61934401L,7598557L,2329089562801L,406639L,72201776446801L,6998993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071553Inst : IEnumerable<long>
{
public static readonly long[] Value=A071553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071553.Bytes);
public long this[int i]=>Value[i];

public static A071553Inst Instance=new A071553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071554
{
public static readonly BigInteger[] Value={ 4L,16L,106L,1156L,15016L,255256L,4849846L,111546436L,3234846616L,100280245066L,3710369067406L,152125131763606L,6541380665835016L,307444891294245706L,16294579238595022366UL,BigInteger.Parse("961380175077106319536"),BigInteger.Parse("58644190679703485491636") };
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
public class A071554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071554Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A071554.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A071554.Bytes);
public BigInteger this[int i]=>Value[i];

public static A071554Inst Instance=new A071554Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071555
{
public static readonly BigInteger[] Value={ 6L,36L,386L,5006L,85086L,1616616L,37182146L,1078282206L,33426748356L,1236789689136L,50708377254536L,2180460221945006L,102481630431415236L,5431526412865007456L,BigInteger.Parse("320460058359035439846"),BigInteger.Parse("19548063559901161830546") };
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
public class A071555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071555Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A071555.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A071555.Bytes);
public BigInteger this[int i]=>Value[i];

public static A071555Inst Instance=new A071555Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071572
{
public static readonly long[] Value={ 1L,2L,2L,1L,2L,1L,5L,1L,1L,2L,1L,1L,2L,1L,1L,1L,2L,1L,1L,3L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,3L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,4L,1L,1L,1L,5L,1L,1L,2L,1L,1L,1L,1L,5L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071572Inst : IEnumerable<long>
{
public static readonly long[] Value=A071572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071572.Bytes);
public long this[int i]=>Value[i];

public static A071572Inst Instance=new A071572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071573
{
public static readonly long[] Value={ 1L,14L,114L,594L,2532L,9658L,34066L,113930L,366358L,1141614L,3465398L,10291022L,29988178L,85961454L,242870564L,677436550L,1867877934L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071573Inst : IEnumerable<long>
{
public static readonly long[] Value=A071573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071573.Bytes);
public long this[int i]=>Value[i];

public static A071573Inst Instance=new A071573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071574
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,6L,5L,4L,14L,12L,15L,10L,13L,8L,28L,24L,11L,30L,9L,20L,26L,16L,29L,56L,48L,22L,60L,18L,25L,40L,31L,52L,32L,58L,112L,96L,21L,44L,120L,36L,27L,50L,17L,80L,62L,104L,57L,64L,116L,224L,192L,42L,49L,88L,240L,72L,54L,100L,23L,34L,61L,160L,124L,208L,114L,128L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071574Inst : IEnumerable<long>
{
public static readonly long[] Value=A071574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071574.Bytes);
public long this[int i]=>Value[i];

public static A071574Inst Instance=new A071574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071575
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,3L,1L,3L,2L,4L,1L,4L,1L,4L,2L,4L,1L,5L,1L,5L,3L,5L,1L,5L,2L,5L,3L,5L,1L,6L,1L,5L,2L,6L,2L,6L,1L,6L,3L,6L,1L,7L,1L,6L,4L,6L,1L,6L,2L,7L,2L,6L,1L,7L,3L,6L,4L,7L,1L,7L,1L,6L,4L,6L,2L,7L,1L,7L,3L,7L,1L,7L,1L,7L,3L,7L,2L,8L,1L,7L,4L,8L,1L,8L,4L,7L,2L,7L,1L,8L,2L,7L,3L,7L,2L,7L,1L,7L,4L,8L,1L,8L,1L,7L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071575Inst : IEnumerable<long>
{
public static readonly long[] Value=A071575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071575.Bytes);
public long this[int i]=>Value[i];

public static A071575Inst Instance=new A071575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071576
{
public static readonly long[] Value={ 1L,1L,1L,165L,5415L,12705L,256410L,256410L,6480303060L,217245863835L,946622690475L,35511547806735L,439116128090640L,5714676453270219435L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071576Inst : IEnumerable<long>
{
public static readonly long[] Value=A071576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071576.Bytes);
public long this[int i]=>Value[i];

public static A071576Inst Instance=new A071576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071577
{
public static readonly long[] Value={ 1L,1L,1L,5L,5L,5L,5L,9L,9L,9L,9L,9L,9L,9L,9L,63L,63L,63L,63L,63L,63L,63L,63L,135L,135L,135L,135L,135L,135L,135L,135L,135L,135L,135L,135L,135L,135L,135L,135L,135L,135L,135L,135L,735L,735L,735L,945L,945L,945L,1155L,1155L,1155L,1155L,1155L,1155L,1155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071577Inst : IEnumerable<long>
{
public static readonly long[] Value=A071577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071577.Bytes);
public long this[int i]=>Value[i];

public static A071577Inst Instance=new A071577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071578
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071578Inst : IEnumerable<long>
{
public static readonly long[] Value=A071578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071578.Bytes);
public long this[int i]=>Value[i];

public static A071578Inst Instance=new A071578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071579
{
public static readonly BigInteger[] Value={ 1L,4L,56L,10864L,408855776L,579069776145402304L,BigInteger.Parse("1161588808526051807570761628582646656"),BigInteger.Parse("4674072680304961790168962360144614650442718636276775741658113370728376064") };
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
public class A071579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071579Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A071579.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A071579.Bytes);
public BigInteger this[int i]=>Value[i];

public static A071579Inst Instance=new A071579Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071580
{
public static readonly BigInteger[] Value={ 2L,3L,7L,43L,3613L,65250781L,5109197227031017L,BigInteger.Parse("21753246920584523633819544186061"),BigInteger.Parse("993727878334632126576336773629979379563850938567846991629270287") };
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
public class A071580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071580Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A071580.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A071580.Bytes);
public BigInteger this[int i]=>Value[i];

public static A071580Inst Instance=new A071580Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071581
{
public static readonly long[] Value={ 3L,5L,7L,6L,6L,8L,7L,9L,6L,4L,6L,4L,3L,10L,9L,4L,2L,8L,6L,5L,4L,9L,6L,3L,-4L,-4L,-2L,2L,4L,11L,2L,2L,0L,2L,0L,1L,0L,-2L,5L,0L,-2L,0L,-7L,-5L,-4L,-2L,-10L,-14L,-14L,-12L,0L,-3L,-4L,-10L,-9L,-14L,-16L,-3L,-8L,-4L,-2L,-9L,-14L,-10L,-4L,-4L,-14L,-8L,-15L,-12L,-12L,-15L,-18L,-20L,-6L,-7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071581Inst : IEnumerable<long>
{
public static readonly long[] Value=A071581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071581.Bytes);
public long this[int i]=>Value[i];

public static A071581Inst Instance=new A071581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A071582
{
public static readonly long[] Value={ 1L,4L,61L,46L,652L,4201L,6904L,48361L,63556L,441262L,6758401L,4034914L,61277761L,46880176L,654534862L,4281473701L,6927694924L,48196897171L,63767491786L,449609778472L,6777261159901L,4011156408934L,61444068129571L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A071582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A071582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A071582Inst : IEnumerable<long>
{
public static readonly long[] Value=A071582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A071582.Bytes);
public long this[int i]=>Value[i];

public static A071582Inst Instance=new A071582Inst();

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