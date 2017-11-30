using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A255382
{
public static readonly long[] Value={ 1L,3L,9L,31L,141L,969L,11289L,265577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255382Inst : IEnumerable<long>
{
public static readonly long[] Value=A255382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255382.Bytes);
public long this[int i]=>Value[i];

public static A255382Inst Instance=new A255382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255383
{
public static readonly long[] Value={ 0L,4L,12L,0L,1L,41L,0L,72L,2L,0L,48L,126L,0L,20L,0L,0L,90L,95L,115L,4L,0L,140L,161L,90L,261L,138L,208L,512L,72L,420L,51L,0L,0L,924L,899L,29L,893L,72L,840L,727L,129L,1185L,194L,732L,1080L,1612L,566L,175L,1352L,1192L,1204L,1360L,428L,957L,2170L,0L,0L,513L,2240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255383Inst : IEnumerable<long>
{
public static readonly long[] Value=A255383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255383.Bytes);
public long this[int i]=>Value[i];

public static A255383Inst Instance=new A255383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255384
{
public static readonly long[] Value={ -2L,0L,3L,8L,15L,13L,35L,20L,18L,29L,99L,25L,143L,53L,34L,32L,255L,28L,323L,41L,58L,125L,483L,33L,50L,173L,27L,65L,783L,40L,899L,36L,130L,293L,74L,28L,1295L,365L,178L,41L,1599L,60L,1763L,137L,31L,533L,2115L,25L,98L,44L,298L,185L,2703L,13L,146L,57L,370L,845L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255384Inst : IEnumerable<long>
{
public static readonly long[] Value=A255384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255384.Bytes);
public long this[int i]=>Value[i];

public static A255384Inst Instance=new A255384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255385
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,10L,12L,15L,16L,18L,20L,26L,24L,26L,28L,34L,32L,39L,36L,44L,40L,42L,44L,60L,48L,50L,54L,62L,56L,72L,60L,73L,64L,66L,68L,94L,72L,74L,76L,98L,80L,100L,84L,98L,96L,90L,92L,130L,96L,107L,100L,116L,104L,130L,108L,136L,112L,114L,116L,172L,120L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255385Inst : IEnumerable<long>
{
public static readonly long[] Value=A255385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255385.Bytes);
public long this[int i]=>Value[i];

public static A255385Inst Instance=new A255385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255386
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,4L,10L,20L,42L,84L,166L,320L,608L,1140L,2116L,3892L,7102L,12868L,23170L,41488L,73918L,131104L,231578L,407520L,714672L,1249368L,2177736L,3785688L,6564362L,11355940L,19602154L,33767228L,58056786L,99638364L,170711134L,292011872L,498747632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255386Inst : IEnumerable<long>
{
public static readonly long[] Value=A255386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255386.Bytes);
public long this[int i]=>Value[i];

public static A255386Inst Instance=new A255386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255387
{
public static readonly BigInteger[] Value={ 281L,59221L,BigInteger.Parse("769449701919846533025514621") };
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
public class A255387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255387Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A255387.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A255387.Bytes);
public BigInteger this[int i]=>Value[i];

public static A255387Inst Instance=new A255387Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255388
{
public static readonly BigInteger[] Value={ 313L,73477L,102850464108757L,BigInteger.Parse("2202194587566133922938215539676032221") };
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
public class A255388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255388Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A255388.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A255388.Bytes);
public BigInteger this[int i]=>Value[i];

public static A255388Inst Instance=new A255388Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255389
{
public static readonly long[] Value={ 331L,82171L,3751197451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255389Inst : IEnumerable<long>
{
public static readonly long[] Value=A255389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255389.Bytes);
public long this[int i]=>Value[i];

public static A255389Inst Instance=new A255389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255390
{
public static readonly BigInteger[] Value={ 89269L,184438202074309L,BigInteger.Parse("379889466040169687349246148321558634248221737128245658182879616485078366262882828905566134219669") };
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
public class A255390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255390Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A255390.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A255390.Bytes);
public BigInteger this[int i]=>Value[i];

public static A255390Inst Instance=new A255390Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255391
{
public static readonly long[] Value={ 1L,-2L,1L,0L,-1L,0L,1L,0L,2L,0L,-1L,0L,-2L,0L,-1L,0L,3L,0L,0L,0L,-4L,0L,1L,0L,5L,0L,1L,0L,-7L,0L,0L,0L,8L,0L,0L,0L,-10L,0L,-1L,0L,13L,0L,-2L,0L,-16L,0L,0L,0L,20L,0L,3L,0L,-24L,0L,2L,0L,30L,0L,-2L,0L,-36L,0L,-4L,0L,43L,0L,0L,0L,-52L,0L,3L,0L,61L,0L,2L,0L,-73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255391Inst : IEnumerable<long>
{
public static readonly long[] Value=A255391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255391.Bytes);
public long this[int i]=>Value[i];

public static A255391Inst Instance=new A255391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255392
{
public static readonly long[] Value={ 40L,53L,88L,106L,120L,121L,122L,125L,131L,139L,143L,145L,159L,161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255392Inst : IEnumerable<long>
{
public static readonly long[] Value=A255392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255392.Bytes);
public long this[int i]=>Value[i];

public static A255392Inst Instance=new A255392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255393
{
public static readonly long[] Value={ 1L,2L,3L,7L,9L,27L,40L,53L,81L,88L,122L,143L,145L,161L,232L,243L,364L,391L,395L,397L,413L,415L,431L,433L,485L,729L,736L,772L,1013L,1021L,1049L,1063L,1067L,1094L,1187L,1189L,1205L,1207L,1223L,1225L,1241L,1243L,1295L,1297L,1457L,1864L,1868L,1888L,1916L,1936L,2060L,2068L,2072L,2144L,2164L,2180L,2187L,2194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255393Inst : IEnumerable<long>
{
public static readonly long[] Value=A255393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255393.Bytes);
public long this[int i]=>Value[i];

public static A255393Inst Instance=new A255393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255394
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,44L,100L,268L,676L,1924L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255394Inst : IEnumerable<long>
{
public static readonly long[] Value=A255394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255394.Bytes);
public long this[int i]=>Value[i];

public static A255394Inst Instance=new A255394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255395
{
public static readonly long[] Value={ 1L,2L,3L,2L,3L,4L,5L,6L,7L,6L,7L,7L,7L,8L,9L,9L,9L,10L,10L,11L,12L,12L,13L,13L,13L,14L,13L,13L,14L,15L,15L,16L,17L,17L,18L,19L,19L,18L,19L,19L,20L,21L,20L,21L,22L,22L,21L,22L,22L,23L,24L,24L,25L,26L,26L,27L,27L,28L,27L,26L,25L,26L,27L,24L,25L,26L,26L,27L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255395Inst : IEnumerable<long>
{
public static readonly long[] Value=A255395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255395.Bytes);
public long this[int i]=>Value[i];

public static A255395Inst Instance=new A255395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255396
{
public static readonly long[] Value={ 1L,2L,1L,0L,-1L,0L,1L,0L,2L,0L,-1L,0L,-2L,0L,-1L,0L,3L,0L,0L,0L,-4L,0L,1L,0L,5L,0L,1L,0L,-7L,0L,0L,0L,8L,0L,0L,0L,-10L,0L,-1L,0L,13L,0L,-2L,0L,-16L,0L,0L,0L,20L,0L,3L,0L,-24L,0L,2L,0L,30L,0L,-2L,0L,-36L,0L,-4L,0L,43L,0L,0L,0L,-52L,0L,3L,0L,61L,0L,2L,0L,-73L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255396Inst : IEnumerable<long>
{
public static readonly long[] Value=A255396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255396.Bytes);
public long this[int i]=>Value[i];

public static A255396Inst Instance=new A255396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255397
{
public static readonly long[] Value={ 1L,4L,18L,92L,528L,3356L,23344L,175984L,1426520L,12352600L,113645488L,1105760224L,11333738336L,121957021744L,1373618201360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255397Inst : IEnumerable<long>
{
public static readonly long[] Value=A255397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255397.Bytes);
public long this[int i]=>Value[i];

public static A255397Inst Instance=new A255397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255398
{
public static readonly long[] Value={ 0L,2L,3L,5L,6L,7L,8L,15L,16L,17L,18L,20L,22L,23L,24L,25L,26L,27L,28L,30L,45L,47L,48L,50L,52L,53L,55L,57L,58L,60L,62L,63L,64L,65L,66L,67L,68L,70L,73L,74L,75L,76L,77L,78L,80L,82L,83L,84L,85L,86L,87L,88L,92L,93L,94L,95L,97L,98L,143L,144L,150L,153L,155L,156L,157L,158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255398Inst : IEnumerable<long>
{
public static readonly long[] Value=A255398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255398.Bytes);
public long this[int i]=>Value[i];

public static A255398Inst Instance=new A255398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255399
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,1L,6L,1L,6L,5L,6L,5L,3L,5L,24L,2L,3L,2L,27L,2L,25L,23L,29L,26L,17L,1L,13L,22L,22L,18L,6L,19L,7L,9L,11L,10L,4L,15L,1L,9L,8L,6L,173L,10L,158L,4L,184L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255399Inst : IEnumerable<long>
{
public static readonly long[] Value=A255399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255399.Bytes);
public long this[int i]=>Value[i];

public static A255399Inst Instance=new A255399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255400
{
public static readonly long[] Value={ 0L,5L,10L,15L,20L,264L,25L,30L,35L,40L,45L,101805L,50L,55L,60L,65L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255400Inst : IEnumerable<long>
{
public static readonly long[] Value=A255400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255400.Bytes);
public long this[int i]=>Value[i];

public static A255400Inst Instance=new A255400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255401
{
public static readonly long[] Value={ 1L,3L,5L,17L,25L,39L,57L,201L,257L,289L,291L,323L,393L,579L,1083L,2307L,7955L,8815L,9399L,12297L,12909L,13737L,36867L,40521L,43797L,50349L,65537L,66049L,66291L,66531L,68457L,80457L,98313L,160329L,196617L,197633L,230691L,299559L,599079L,786441L,922179L,1278537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255401Inst : IEnumerable<long>
{
public static readonly long[] Value=A255401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255401.Bytes);
public long this[int i]=>Value[i];

public static A255401Inst Instance=new A255401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255402
{
public static readonly long[] Value={ 2L,3L,3L,4L,4L,4L,4L,4L,4L,6L,5L,6L,4L,5L,4L,4L,8L,5L,6L,5L,4L,6L,6L,7L,6L,6L,5L,5L,4L,8L,6L,6L,8L,6L,6L,7L,5L,7L,6L,6L,8L,5L,7L,6L,5L,7L,6L,9L,6L,8L,5L,6L,7L,6L,4L,4L,9L,9L,6L,5L,6L,9L,9L,6L,6L,10L,5L,9L,8L,8L,7L,7L,6L,6L,8L,6L,8L,8L,7L,7L,7L,7L,6L,8L,8L,7L,7L,6L,7L,6L,6L,8L,5L,9L,5L,9L,6L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255402Inst : IEnumerable<long>
{
public static readonly long[] Value=A255402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255402.Bytes);
public long this[int i]=>Value[i];

public static A255402Inst Instance=new A255402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255403
{
public static readonly BigInteger[] Value={ 1L,24L,BigInteger.Parse("261332866810040451858432000000") };
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
public class A255403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255403Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A255403.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A255403.Bytes);
public BigInteger this[int i]=>Value[i];

public static A255403Inst Instance=new A255403Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255404
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,4L,3L,2L,1L,4L,2L,1L,2L,1L,2L,2L,1L,1L,1L,2L,1L,1L,1L,3L,1L,1L,1L,1L,2L,2L,1L,2L,2L,1L,1L,1L,4L,6L,4L,1L,2L,1L,5L,5L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,5L,2L,2L,1L,1L,4L,1L,1L,2L,3L,1L,8L,2L,1L,1L,3L,1L,1L,1L,3L,1L,1L,3L,1L,6L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,5L,1L,3L,2L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255404Inst : IEnumerable<long>
{
public static readonly long[] Value=A255404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255404.Bytes);
public long this[int i]=>Value[i];

public static A255404Inst Instance=new A255404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255405
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,2L,2L,3L,3L,4L,4L,5L,6L,6L,7L,8L,9L,11L,12L,14L,16L,18L,20L,23L,26L,29L,33L,37L,42L,47L,53L,60L,68L,77L,87L,98L,111L,125L,141L,159L,180L,203L,229L,258L,292L,329L,371L,419L,473L,534L,602L,680L,767L,865L,977L,1102L,1244L,1403L,1584L,1787L,2016L,2275L,2567L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255405Inst : IEnumerable<long>
{
public static readonly long[] Value=A255405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255405.Bytes);
public long this[int i]=>Value[i];

public static A255405Inst Instance=new A255405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255406
{
public static readonly BigInteger[] Value={ 1L,18L,26460L,288149400L,11799717930000L,1303467640855380000L,BigInteger.Parse("318564884489773161240000"),BigInteger.Parse("150951970515479012453574000000"),BigInteger.Parse("126206413988876537942059614180000000"),BigInteger.Parse("173464405707011357574463836709701000000000"),BigInteger.Parse("370958141678992170468287850863450040726000000000") };
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
public class A255406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255406Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A255406.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A255406.Bytes);
public BigInteger this[int i]=>Value[i];

public static A255406Inst Instance=new A255406Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255407
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,23L,20L,21L,22L,25L,24L,19L,26L,27L,28L,29L,30L,37L,32L,33L,34L,35L,36L,41L,38L,39L,40L,43L,42L,47L,44L,45L,46L,53L,48L,31L,50L,51L,52L,61L,54L,49L,56L,57L,58L,67L,60L,71L,62L,63L,64L,65L,66L,77L,68L,69L,70L,83L,72L,89L,74L,75L,76L,59L,78L,91L,80L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255407Inst : IEnumerable<long>
{
public static readonly long[] Value=A255407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255407.Bytes);
public long this[int i]=>Value[i];

public static A255407Inst Instance=new A255407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255408
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,25L,20L,21L,22L,19L,24L,23L,26L,27L,28L,29L,30L,49L,32L,33L,34L,35L,36L,31L,38L,39L,40L,37L,42L,41L,44L,45L,46L,43L,48L,55L,50L,51L,52L,47L,54L,121L,56L,57L,58L,77L,60L,53L,62L,63L,64L,65L,66L,59L,68L,69L,70L,61L,72L,169L,74L,75L,76L,67L,78L,85L,80L,81L,82L,71L,84L,91L,86L,87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255408Inst : IEnumerable<long>
{
public static readonly long[] Value=A255408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255408.Bytes);
public long this[int i]=>Value[i];

public static A255408Inst Instance=new A255408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255409
{
public static readonly long[] Value={ 0L,1L,4L,18L,24L,27L,160L,1470L,1500L,1701L,1920L,2205L,25515L,27951L,392392L,424710L,429000L,481250L,500500L,8824530L,8825856L,185435250L,194922000L,204289085L,214451328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255409Inst : IEnumerable<long>
{
public static readonly long[] Value=A255409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255409.Bytes);
public long this[int i]=>Value[i];

public static A255409Inst Instance=new A255409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255410
{
public static readonly long[] Value={ 2L,9L,35L,85L,203L,325L,547L,911L,1181L,1591L,2347L,2923L,3421L,4151L,5161L,6461L,7693L,8785L,10237L,11789L,13469L,14621L,16523L,19225L,21775L,23669L,25237L,27715L,29891L,34073L,36977L,40487L,43151L,48091L,50429L,53407L,55843L,61541L,68797L,71603L,77279L,80291L,84091L,88771L,91997L,96119L,101927L,108833L,115031L,123187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255410Inst : IEnumerable<long>
{
public static readonly long[] Value=A255410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255410.Bytes);
public long this[int i]=>Value[i];

public static A255410Inst Instance=new A255410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255411
{
public static readonly long[] Value={ 0L,4L,12L,16L,18L,22L,48L,52L,60L,64L,66L,70L,72L,76L,84L,88L,90L,94L,96L,100L,108L,112L,114L,118L,240L,244L,252L,256L,258L,262L,288L,292L,300L,304L,306L,310L,312L,316L,324L,328L,330L,334L,336L,340L,348L,352L,354L,358L,360L,364L,372L,376L,378L,382L,408L,412L,420L,424L,426L,430L,432L,436L,444L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255411Inst : IEnumerable<long>
{
public static readonly long[] Value=A255411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255411.Bytes);
public long this[int i]=>Value[i];

public static A255411Inst Instance=new A255411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255412
{
public static readonly long[] Value={ 4800L,28800L,57600L,67200L,86400L,96000L,115200L,148800L,144000L,142800L,153600L,182400L,201600L,211200L,230400L,259200L,345600L,288000L,297600L,403200L,326400L,345600L,355200L,384000L,403200L,518400L,432000L,576000L,470400L,489600L,499200L,518400L,528000L,547200L,691200L,638400L,748800L,614400L,633600L,662400L,672000L,806400L,864000L,856800L,720000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255412Inst : IEnumerable<long>
{
public static readonly long[] Value=A255412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255412.Bytes);
public long this[int i]=>Value[i];

public static A255412Inst Instance=new A255412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255413
{
public static readonly long[] Value={ 5L,19L,35L,49L,65L,79L,95L,109L,125L,139L,155L,169L,185L,199L,215L,229L,245L,259L,275L,289L,305L,319L,335L,349L,365L,379L,395L,409L,425L,439L,455L,469L,485L,499L,515L,529L,545L,559L,575L,589L,605L,619L,635L,649L,665L,679L,695L,709L,725L,739L,755L,769L,785L,799L,815L,829L,845L,859L,875L,889L,905L,919L,935L,949L,965L,979L,995L,1009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255413Inst : IEnumerable<long>
{
public static readonly long[] Value=A255413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255413.Bytes);
public long this[int i]=>Value[i];

public static A255413Inst Instance=new A255413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255414
{
public static readonly long[] Value={ 7L,31L,59L,85L,113L,137L,163L,191L,217L,241L,269L,295L,323L,347L,373L,401L,427L,451L,479L,505L,533L,557L,583L,611L,637L,661L,689L,715L,743L,767L,793L,821L,847L,871L,899L,925L,953L,977L,1003L,1031L,1057L,1081L,1109L,1135L,1163L,1187L,1213L,1241L,1267L,1291L,1319L,1345L,1373L,1397L,1423L,1451L,1477L,1501L,1529L,1555L,1583L,1607L,1633L,1661L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255414Inst : IEnumerable<long>
{
public static readonly long[] Value=A255414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255414.Bytes);
public long this[int i]=>Value[i];

public static A255414Inst Instance=new A255414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255415
{
public static readonly long[] Value={ 11L,55L,103L,151L,203L,251L,299L,343L,391L,443L,491L,539L,587L,631L,683L,731L,779L,827L,877L,923L,971L,1019L,1067L,1117L,1165L,1211L,1259L,1307L,1357L,1405L,1453L,1499L,1547L,1597L,1645L,1693L,1741L,1787L,1837L,1885L,1933L,1981L,2033L,2077L,2125L,2173L,2221L,2273L,2321L,2365L,2413L,2461L,2513L,2561L,2609L,2653L,2701L,2753L,2801L,2849L,2897L,2941L,2993L,3041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255415Inst : IEnumerable<long>
{
public static readonly long[] Value=A255415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255415.Bytes);
public long this[int i]=>Value[i];

public static A255415Inst Instance=new A255415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255416
{
public static readonly long[] Value={ 13L,73L,133L,197L,263L,325L,385L,449L,511L,571L,641L,701L,761L,823L,887L,947L,1013L,1075L,1139L,1199L,1261L,1327L,1387L,1447L,1513L,1573L,1637L,1703L,1763L,1825L,1889L,1951L,2011L,2071L,2141L,2201L,2261L,2327L,2387L,2453L,2515L,2575L,2639L,2699L,2767L,2827L,2887L,2953L,3013L,3073L,3143L,3203L,3265L,3325L,3389L,3451L,3511L,3581L,3641L,3701L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255416Inst : IEnumerable<long>
{
public static readonly long[] Value=A255416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255416.Bytes);
public long this[int i]=>Value[i];

public static A255416Inst Instance=new A255416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255417
{
public static readonly long[] Value={ 17L,101L,187L,281L,367L,461L,547L,629L,721L,809L,901L,989L,1079L,1169L,1253L,1343L,1433L,1523L,1613L,1697L,1783L,1873L,1963L,2051L,2143L,2231L,2311L,2407L,2491L,2587L,2671L,2759L,2851L,2935L,3029L,3115L,3205L,3295L,3383L,3467L,3557L,3647L,3737L,3823L,3913L,4001L,4091L,4177L,4271L,4357L,4447L,4537L,4619L,4711L,4799L,4885L,4979L,5065L,5155L,5243L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255417Inst : IEnumerable<long>
{
public static readonly long[] Value=A255417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255417.Bytes);
public long this[int i]=>Value[i];

public static A255417Inst Instance=new A255417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255418
{
public static readonly long[] Value={ 23L,145L,271L,403L,523L,655L,781L,911L,1037L,1157L,1289L,1417L,1543L,1673L,1801L,1927L,2057L,2183L,2305L,2437L,2563L,2693L,2819L,2951L,3071L,3197L,3331L,3457L,3587L,3713L,3841L,3967L,4093L,4223L,4349L,4477L,4603L,4735L,4855L,4987L,5113L,5237L,5369L,5489L,5621L,5747L,5875L,6001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255418Inst : IEnumerable<long>
{
public static readonly long[] Value=A255418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255418.Bytes);
public long this[int i]=>Value[i];

public static A255418Inst Instance=new A255418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255419
{
public static readonly long[] Value={ 25L,167L,311L,457L,599L,745L,883L,1033L,1181L,1321L,1469L,1615L,1753L,1903L,2041L,2191L,2339L,2483L,2623L,2773L,2911L,3059L,3211L,3353L,3493L,3637L,3781L,3929L,4067L,4217L,4367L,4507L,4657L,4795L,4937L,5087L,5227L,5377L,5527L,5665L,5813L,5957L,6101L,6241L,6389L,6535L,6683L,6821L,6971L,7111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255419Inst : IEnumerable<long>
{
public static readonly long[] Value=A255419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255419.Bytes);
public long this[int i]=>Value[i];

public static A255419Inst Instance=new A255419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255420
{
public static readonly long[] Value={ 1L,2L,3L,5L,11L,37L,181L,1361L,13927L,183871L,3005533L,59045717L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255420Inst : IEnumerable<long>
{
public static readonly long[] Value=A255420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255420.Bytes);
public long this[int i]=>Value[i];

public static A255420Inst Instance=new A255420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255421
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,23L,19L,20L,21L,25L,22L,24L,26L,27L,28L,29L,34L,37L,30L,31L,32L,36L,33L,41L,35L,38L,39L,43L,40L,47L,42L,49L,52L,53L,44L,45L,46L,51L,48L,61L,57L,50L,54L,55L,59L,67L,56L,71L,64L,58L,66L,70L,72L,97L,60L,62L,63L,77L,69L,83L,65L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255421Inst : IEnumerable<long>
{
public static readonly long[] Value=A255421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255421.Bytes);
public long this[int i]=>Value[i];

public static A255421Inst Instance=new A255421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255422
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,20L,21L,22L,24L,19L,25L,23L,26L,27L,28L,29L,32L,33L,34L,36L,30L,38L,35L,31L,39L,40L,42L,37L,44L,41L,48L,49L,50L,43L,52L,45L,55L,51L,46L,47L,56L,57L,60L,54L,63L,58L,68L,53L,69L,70L,62L,74L,64L,59L,77L,72L,65L,61L,66L,78L,80L,84L,76L,71L,87L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255422Inst : IEnumerable<long>
{
public static readonly long[] Value=A255422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255422.Bytes);
public long this[int i]=>Value[i];

public static A255422Inst Instance=new A255422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255423
{
public static readonly long[] Value={ 2058L,10290L,22638L,26754L,34986L,39102L,47334L,51450L,59682L,52728L,63798L,76146L,84378L,88494L,96726L,109074L,113190L,121422L,125538L,133770L,137886L,146118L,150234L,162582L,170814L,174930L,183162L,195510L,199626L,207858L,211974L,220206L,224322L,232554L,236670L,249018L,257250L,261366L,269598L,281946L,286062L,294294L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255423Inst : IEnumerable<long>
{
public static readonly long[] Value=A255423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255423.Bytes);
public long this[int i]=>Value[i];

public static A255423Inst Instance=new A255423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255424
{
public static readonly long[] Value={ 42L,210L,462L,546L,714L,798L,966L,210L,1218L,78L,1302L,1554L,1722L,1806L,1974L,2226L,2310L,2478L,2562L,2730L,2814L,2982L,3066L,3318L,3486L,3570L,3738L,3990L,4074L,4242L,4326L,4494L,4578L,4746L,4830L,462L,210L,5334L,5502L,5754L,5838L,6006L,6090L,390L,6258L,6342L,6510L,6594L,6846L,7014L,546L,7266L,7518L,7602L,7770L,7854L,8022L,8106L,8274L,8358L,8610L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255424Inst : IEnumerable<long>
{
public static readonly long[] Value=A255424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255424.Bytes);
public long this[int i]=>Value[i];

public static A255424Inst Instance=new A255424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255425
{
public static readonly long[] Value={ 36L,36L,36L,36L,36L,36L,36L,180L,36L,576L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,396L,900L,36L,36L,36L,36L,36L,36L,576L,36L,36L,36L,36L,36L,36L,468L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,576L,36L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255425Inst : IEnumerable<long>
{
public static readonly long[] Value=A255425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255425.Bytes);
public long this[int i]=>Value[i];

public static A255425Inst Instance=new A255425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255426
{
public static readonly long[] Value={ 49L,49L,49L,49L,49L,49L,49L,245L,49L,676L,49L,49L,49L,49L,49L,49L,49L,49L,49L,49L,49L,49L,49L,49L,49L,49L,49L,49L,49L,49L,49L,49L,49L,49L,49L,539L,1225L,49L,49L,49L,49L,49L,49L,676L,49L,49L,49L,49L,49L,49L,637L,49L,49L,49L,49L,49L,49L,49L,49L,49L,49L,676L,49L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255426Inst : IEnumerable<long>
{
public static readonly long[] Value=A255426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255426.Bytes);
public long this[int i]=>Value[i];

public static A255426Inst Instance=new A255426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255427
{
public static readonly long[] Value={ 3L,15L,105L,35L,385L,5005L,15015L,255255L,4849845L,1616615L,37182145L,37182145L,22309287L,646969323L,20056049013L,33426748355L,33426748355L,1236789689135L,1236789689135L,50708377254535L,2180460221945005L,2180460221945005L,102481630431415235L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255427Inst : IEnumerable<long>
{
public static readonly long[] Value=A255427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255427.Bytes);
public long this[int i]=>Value[i];

public static A255427Inst Instance=new A255427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255428
{
public static readonly long[] Value={ 1L,8L,15L,46L,53L,102L,133L,278L,285L,334L,383L,600L,631L,848L,993L,1594L,1601L,1650L,1699L,1916L,1965L,2308L,2525L,3540L,3571L,3788L,4005L,4966L,5111L,6126L,6727L,9278L,9285L,9334L,9383L,9600L,9649L,9992L,10209L,11224L,11273L,11616L,11959L,13478L,13695L,15214L,16229L,20436L,20467L,20684L,20901L,21862L,22079L,23598L,24559L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255428Inst : IEnumerable<long>
{
public static readonly long[] Value=A255428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255428.Bytes);
public long this[int i]=>Value[i];

public static A255428Inst Instance=new A255428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255429
{
public static readonly long[] Value={ 6L,8L,10L,14L,15L,16L,21L,22L,26L,27L,33L,34L,35L,36L,38L,39L,46L,51L,55L,57L,58L,62L,64L,65L,69L,74L,77L,81L,82L,85L,86L,87L,91L,93L,94L,95L,100L,106L,111L,115L,118L,119L,122L,123L,125L,129L,133L,134L,141L,142L,143L,144L,145L,146L,155L,158L,159L,161L,166L,177L,178L,183L,185L,187L,194L,196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255429Inst : IEnumerable<long>
{
public static readonly long[] Value=A255429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255429.Bytes);
public long this[int i]=>Value[i];

public static A255429Inst Instance=new A255429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255430
{
public static readonly long[] Value={ 2L,3L,5L,6L,7L,8L,22L,23L,24L,25L,26L,27L,28L,45L,47L,48L,52L,53L,55L,57L,58L,62L,63L,64L,65L,66L,67L,68L,73L,74L,75L,76L,77L,78L,82L,83L,84L,85L,86L,87L,88L,92L,93L,94L,95L,97L,98L,202L,205L,206L,207L,208L,222L,223L,225L,232L,233L,234L,235L,236L,238L,242L,243L,244L,245L,252L,253L,255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255430Inst : IEnumerable<long>
{
public static readonly long[] Value=A255430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255430.Bytes);
public long this[int i]=>Value[i];

public static A255430Inst Instance=new A255430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255431
{
public static readonly long[] Value={ 22L,62L,82L,472L,522L,662L,822L,832L,932L,972L,2362L,2382L,2522L,2562L,2632L,2972L,4522L,4832L,4862L,4882L,4932L,4972L,5022L,5062L,5082L,5322L,5472L,6062L,6382L,6632L,6662L,6782L,6972L,7022L,7382L,7432L,7472L,7632L,8322L,8332L,8362L,8672L,8882L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255431Inst : IEnumerable<long>
{
public static readonly long[] Value=A255431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255431.Bytes);
public long this[int i]=>Value[i];

public static A255431Inst Instance=new A255431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255432
{
public static readonly ulong[] Value={ 1L,1L,2L,4L,12L,36L,160L,680L,4368L,24976L,219616L,1599104L,18145600L,160805568L,2245960704L,23437238656L,389201754368L,4669754525952L,89893314615808L,1218303508421632L,26673872401980416L,402798557886395392L,9883555312758398976UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255432Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A255432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255432.Bytes);
public ulong this[int i]=>Value[i];

public static A255432Inst Instance=new A255432Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255433
{
public static readonly BigInteger[] Value={ 1L,2L,18L,504L,32760L,4127760L,895723920L,308129028480L,158070191610240L,115391239875475200L,BigInteger.Parse("115506631115350675200"),BigInteger.Parse("153854832645647099366400"),BigInteger.Parse("266015005644323834804505600"),BigInteger.Parse("584700982406223788900303308800"),BigInteger.Parse("1605004196705084300531332582656000") };
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
public class A255433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255433Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A255433.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A255433.Bytes);
public BigInteger this[int i]=>Value[i];

public static A255433Inst Instance=new A255433Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255434
{
public static readonly BigInteger[] Value={ 1L,2L,34L,2788L,716516L,448539016L,581755103752L,1397375759212304L,5725048485492809488L,BigInteger.Parse("37567768161803815860256"),BigInteger.Parse("375715249386199962418420256"),BigInteger.Parse("5501222681512739849730509388352"),BigInteger.Parse("114078854746529686263861573186255424"),BigInteger.Parse("3258320249270380899068414253345827420288") };
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
public class A255434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255434Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A255434.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A255434.Bytes);
public BigInteger this[int i]=>Value[i];

public static A255434Inst Instance=new A255434Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255435
{
public static readonly BigInteger[] Value={ 1L,2L,66L,16104L,16506600L,51599631600L,401290334953200L,6744887949893385600L,BigInteger.Parse("221023233230056352726400"),BigInteger.Parse("13051421922234827628493920000"),BigInteger.Parse("1305155243645404997677020493920000"),BigInteger.Parse("210197862299579765685879504586803840000"),BigInteger.Parse("52304164669591331834914454764848159918720000") };
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
public class A255435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255435Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A255435.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A255435.Bytes);
public BigInteger this[int i]=>Value[i];

public static A255435Inst Instance=new A255435Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255436
{
public static readonly long[] Value={ 1L,1L,3L,4L,12L,26L,88L,257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255436Inst : IEnumerable<long>
{
public static readonly long[] Value=A255436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255436.Bytes);
public long this[int i]=>Value[i];

public static A255436Inst Instance=new A255436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255437
{
public static readonly long[] Value={ 1L,2L,3L,1L,3L,5L,6L,7L,8L,1L,3L,5L,10L,11L,12L,13L,14L,15L,1L,3L,5L,7L,17L,18L,19L,20L,21L,22L,23L,24L,1L,3L,5L,7L,9L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,1L,3L,5L,7L,9L,11L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,1L,3L,5L,7L,9L,11L,13L,50L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255437Inst : IEnumerable<long>
{
public static readonly long[] Value=A255437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255437.Bytes);
public long this[int i]=>Value[i];

public static A255437Inst Instance=new A255437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255438
{
public static readonly long[] Value={ 6L,6L,4L,4L,9L,8L,7L,9L,1L,8L,7L,0L,6L,3L,5L,4L,0L,4L,9L,4L,8L,3L,1L,1L,8L,3L,1L,6L,7L,3L,7L,8L,4L,2L,6L,6L,0L,0L,7L,5L,3L,6L,2L,6L,5L,2L,0L,0L,5L,2L,0L,1L,5L,6L,1L,3L,2L,6L,2L,9L,0L,4L,2L,8L,7L,1L,0L,3L,7L,1L,4L,7L,3L,4L,0L,3L,3L,7L,9L,5L,6L,1L,2L,9L,5L,0L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255438Inst : IEnumerable<long>
{
public static readonly long[] Value=A255438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255438.Bytes);
public long this[int i]=>Value[i];

public static A255438Inst Instance=new A255438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255439
{
public static readonly long[] Value={ 1L,1L,3L,5L,4L,9L,5L,4L,7L,4L,9L,7L,2L,9L,7L,8L,2L,3L,1L,2L,1L,0L,6L,6L,3L,0L,5L,9L,2L,4L,5L,0L,2L,1L,5L,7L,8L,1L,0L,1L,4L,0L,4L,6L,1L,3L,7L,1L,2L,0L,0L,7L,9L,8L,3L,2L,9L,2L,8L,0L,2L,3L,9L,6L,0L,7L,8L,8L,1L,8L,8L,2L,6L,2L,8L,0L,7L,9L,9L,1L,2L,5L,1L,5L,9L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255439Inst : IEnumerable<long>
{
public static readonly long[] Value=A255439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255439.Bytes);
public long this[int i]=>Value[i];

public static A255439Inst Instance=new A255439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255440
{
public static readonly BigInteger[] Value={ 1L,1L,4L,24L,288L,3240L,74160L,1970640L,55762560L,2271628800L,118676275200L,5949399456000L,389282684313600L,31351069535385600L,2431871996666112000L,BigInteger.Parse("227068393053325824000"),BigInteger.Parse("25547764411931553792000"),BigInteger.Parse("2795442523571128983552000"),BigInteger.Parse("350437557048098924371968000") };
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
public class A255440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255440Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A255440.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A255440.Bytes);
public BigInteger this[int i]=>Value[i];

public static A255440Inst Instance=new A255440Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255441
{
public static readonly long[] Value={ 252601L,3828001L,82929001L,366652201L,8251854001L,12173703001L,25749237001L,67495942201L,82380774001L,285983187601L,802204143001L,1039708768201L,1068674250001L,1158788350201L,2997587784001L,3236207713201L,4467180843001L,7902515425201L,8470346587201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255441Inst : IEnumerable<long>
{
public static readonly long[] Value=A255441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255441.Bytes);
public long this[int i]=>Value[i];

public static A255441Inst Instance=new A255441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255442
{
public static readonly long[] Value={ 1L,5L,15L,51L,153L,477L,1431L,4347L,13041L,39285L,117855L,354051L,1062153L,3187917L,9563751L,28695627L,86086881L,258273765L,774821295L,2324503251L,6973509753L,20920647357L,62761942071L,188286180507L,564858541521L,1694576687445L,5083730062335L,15251193375651L,45753580126953L,137260749946797L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255442Inst : IEnumerable<long>
{
public static readonly long[] Value=A255442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255442.Bytes);
public long this[int i]=>Value[i];

public static A255442Inst Instance=new A255442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255443
{
public static readonly long[] Value={ 1L,5L,5L,19L,5L,25L,19L,73L,5L,25L,25L,95L,19L,95L,73L,271L,5L,25L,25L,95L,25L,125L,95L,365L,19L,95L,95L,361L,73L,365L,271L,993L,5L,25L,25L,95L,25L,125L,95L,365L,25L,125L,125L,475L,95L,475L,365L,1355L,19L,95L,95L,361L,95L,475L,361L,1387L,73L,365L,365L,1387L,271L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255443Inst : IEnumerable<long>
{
public static readonly long[] Value=A255443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255443.Bytes);
public long this[int i]=>Value[i];

public static A255443Inst Instance=new A255443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255444
{
public static readonly long[] Value={ 1L,5L,19L,73L,271L,993L,3643L,13309L,48655L,177805L,649699L,2374129L,8674999L,31698625L,115826659L,423229469L,1546477863L,5650815053L,20648028987L,75447710625L,275685244735L,1007351382097L,3680852748715L,13449802390397L,49145455249183L,179577045144493L,656172884958899L,2397649735785777L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255444Inst : IEnumerable<long>
{
public static readonly long[] Value=A255444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255444.Bytes);
public long this[int i]=>Value[i];

public static A255444Inst Instance=new A255444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255445
{
public static readonly long[] Value={ 1L,5L,5L,19L,5L,25L,19L,71L,5L,25L,25L,95L,19L,95L,71L,265L,5L,25L,25L,95L,25L,125L,95L,355L,19L,95L,95L,361L,71L,355L,265L,989L,5L,25L,25L,95L,25L,125L,95L,355L,25L,125L,125L,475L,95L,475L,355L,1325L,19L,95L,95L,361L,95L,475L,361L,1349L,71L,355L,355L,1349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255445Inst : IEnumerable<long>
{
public static readonly long[] Value=A255445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255445.Bytes);
public long this[int i]=>Value[i];

public static A255445Inst Instance=new A255445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255446
{
public static readonly long[] Value={ 1L,5L,5L,21L,5L,25L,21L,79L,5L,25L,25L,105L,21L,105L,79L,291L,5L,25L,25L,105L,25L,125L,105L,395L,21L,105L,105L,441L,79L,395L,291L,1043L,5L,25L,25L,105L,25L,125L,105L,395L,25L,125L,125L,525L,105L,525L,395L,1455L,21L,105L,105L,441L,105L,525L,441L,1659L,79L,395L,395L,1659L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255446Inst : IEnumerable<long>
{
public static readonly long[] Value=A255446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255446.Bytes);
public long this[int i]=>Value[i];

public static A255446Inst Instance=new A255446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255447
{
public static readonly long[] Value={ 1L,5L,21L,79L,291L,1043L,3725L,13205L,46793L,165471L,585191L,2068315L,7310897L,25837453L,91315845L,322715687L,1140515523L,4030652683L,14244666301L,50341596733L,177910950553L,628749519543L,2222045769223L,7852864484723L,27752577642625L,98079551982773L,346620034979541L,1224979511026399L,4329163636559235L,15299568080670371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255447Inst : IEnumerable<long>
{
public static readonly long[] Value=A255447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255447.Bytes);
public long this[int i]=>Value[i];

public static A255447Inst Instance=new A255447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255448
{
public static readonly long[] Value={ 1L,5L,5L,19L,5L,25L,19L,71L,5L,25L,25L,95L,19L,95L,71L,257L,5L,25L,25L,95L,25L,125L,95L,355L,19L,95L,95L,361L,71L,355L,257L,925L,5L,25L,25L,95L,25L,125L,95L,355L,25L,125L,125L,475L,95L,475L,355L,1285L,19L,95L,95L,361L,95L,475L,361L,1349L,71L,355L,355L,1349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255448Inst : IEnumerable<long>
{
public static readonly long[] Value=A255448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255448.Bytes);
public long this[int i]=>Value[i];

public static A255448Inst Instance=new A255448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255449
{
public static readonly long[] Value={ 1L,5L,19L,71L,257L,925L,3323L,11919L,42729L,153173L,549075L,1968247L,7055601L,25292621L,90668587L,325028895L,1165167673L,4176914949L,14973497539L,53677355783L,192423938625L,689806295677L,2472835597211L,8864685923631L,31778359388937L,113919900383925L,408383064188083L,1463982386475159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255449Inst : IEnumerable<long>
{
public static readonly long[] Value=A255449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255449.Bytes);
public long this[int i]=>Value[i];

public static A255449Inst Instance=new A255449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255450
{
public static readonly long[] Value={ 1L,5L,5L,21L,5L,25L,21L,85L,5L,25L,25L,105L,21L,105L,85L,333L,5L,25L,25L,105L,25L,125L,105L,425L,21L,105L,105L,441L,85L,425L,333L,1293L,5L,25L,25L,105L,25L,125L,105L,425L,25L,125L,125L,525L,105L,525L,425L,1665L,21L,105L,105L,441L,105L,525L,441L,1785L,85L,425L,425L,1785L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255450Inst : IEnumerable<long>
{
public static readonly long[] Value=A255450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255450.Bytes);
public long this[int i]=>Value[i];

public static A255450Inst Instance=new A255450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255451
{
public static readonly long[] Value={ 1L,5L,21L,85L,333L,1293L,4997L,19269L,74237L,285885L,1100725L,4237685L,16314029L,62803821L,241772773L,930737317L,3582994525L,13793193757L,53098638101L,204409869525L,786901384973L,3029275306957L,11661574029893L,44892686930437L,172820009444029L,665292226131325L,2561125574008437L,9859372988945461L,37954888549712749L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255451Inst : IEnumerable<long>
{
public static readonly long[] Value=A255451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255451.Bytes);
public long this[int i]=>Value[i];

public static A255451Inst Instance=new A255451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255452
{
public static readonly long[] Value={ 1L,5L,5L,21L,5L,25L,21L,77L,5L,25L,25L,105L,21L,105L,77L,277L,5L,25L,25L,105L,25L,125L,105L,385L,21L,105L,105L,441L,77L,385L,277L,1005L,5L,25L,25L,105L,25L,125L,105L,385L,25L,125L,125L,525L,105L,525L,385L,1385L,21L,105L,105L,441L,105L,525L,441L,1617L,77L,385L,385L,1617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255452Inst : IEnumerable<long>
{
public static readonly long[] Value=A255452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255452.Bytes);
public long this[int i]=>Value[i];

public static A255452Inst Instance=new A255452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255453
{
public static readonly long[] Value={ 1L,5L,21L,77L,277L,1005L,3669L,13421L,49109L,179693L,657493L,2405741L,8802517L,32208109L,117848405L,431203437L,1577759189L,5772968941L,21123103317L,77288739693L,282796954325L,1034744746733L,3786096966485L,13853204169325L,50688418034645L,185467253023213L,678618573585493L,2483043021926765L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255453Inst : IEnumerable<long>
{
public static readonly long[] Value=A255453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255453.Bytes);
public long this[int i]=>Value[i];

public static A255453Inst Instance=new A255453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255454
{
public static readonly long[] Value={ 1L,5L,5L,19L,5L,25L,19L,73L,5L,25L,25L,95L,19L,95L,73L,263L,5L,25L,25L,95L,25L,125L,95L,365L,19L,95L,95L,361L,73L,365L,263L,973L,5L,25L,25L,95L,25L,125L,95L,365L,25L,125L,125L,475L,95L,475L,365L,1315L,19L,95L,95L,361L,95L,475L,361L,1387L,73L,365L,365L,1387L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255454Inst : IEnumerable<long>
{
public static readonly long[] Value=A255454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255454.Bytes);
public long this[int i]=>Value[i];

public static A255454Inst Instance=new A255454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255455
{
public static readonly long[] Value={ 1L,5L,19L,73L,263L,973L,3531L,12965L,47251L,173009L,631631L,2310273L,8440503L,30859717L,112776995L,412263309L,1506786763L,5507802233L,20131419959L,73585107241L,268963530095L,983115443149L,3593443967243L,13134702768181L,48009561539555L,175483552150433L,641422737413919L,2344513580442321L,8569606120531879L,31323418577252629L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255455Inst : IEnumerable<long>
{
public static readonly long[] Value=A255455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255455.Bytes);
public long this[int i]=>Value[i];

public static A255455Inst Instance=new A255455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255456
{
public static readonly long[] Value={ 1L,5L,5L,23L,5L,25L,23L,93L,5L,25L,25L,115L,23L,115L,93L,359L,5L,25L,25L,115L,25L,125L,115L,465L,23L,115L,115L,529L,93L,465L,359L,1335L,5L,25L,25L,115L,25L,125L,115L,465L,25L,125L,125L,575L,115L,575L,465L,1795L,23L,115L,115L,529L,115L,575L,529L,2139L,93L,465L,465L,2139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255456Inst : IEnumerable<long>
{
public static readonly long[] Value=A255456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255456.Bytes);
public long this[int i]=>Value[i];

public static A255456Inst Instance=new A255456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255457
{
public static readonly long[] Value={ 1L,5L,23L,93L,359L,1335L,4873L,17535L,62601L,222181L,785855L,2772717L,9768351L,34378167L,120910529L,425062511L,1493898001L,5249371781L,18443445415L,64795091709L,227625068503L,799619495287L,2808906276921L,9866994688223L,34659998140825L,121750158651877L,427670046315727L,1502266603229837L,5276968090316303L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255457Inst : IEnumerable<long>
{
public static readonly long[] Value=A255457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255457.Bytes);
public long this[int i]=>Value[i];

public static A255457Inst Instance=new A255457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255458
{
public static readonly long[] Value={ 1L,5L,5L,25L,5L,25L,25L,101L,5L,25L,25L,125L,25L,125L,101L,361L,5L,25L,25L,125L,25L,125L,125L,505L,25L,125L,125L,625L,101L,505L,361L,1205L,5L,25L,25L,125L,25L,125L,125L,505L,25L,125L,125L,625L,125L,625L,505L,1805L,25L,125L,125L,625L,125L,625L,625L,2525L,101L,505L,505L,2525L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255458Inst : IEnumerable<long>
{
public static readonly long[] Value=A255458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255458.Bytes);
public long this[int i]=>Value[i];

public static A255458Inst Instance=new A255458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255459
{
public static readonly long[] Value={ 1L,5L,25L,101L,361L,1205L,3865L,12101L,37321L,114005L,346105L,1046501L,3155881L,9500405L,28566745L,85831301L,257756041L,773792405L,2322425785L,6969374501L,20912317801L,62745342005L,188252803225L,564791964101L,1694443001161L,5083463221205L,15250658099065L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255459Inst : IEnumerable<long>
{
public static readonly long[] Value=A255459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255459.Bytes);
public long this[int i]=>Value[i];

public static A255459Inst Instance=new A255459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255460
{
public static readonly long[] Value={ 1L,6L,6L,22L,6L,36L,22L,82L,6L,36L,36L,132L,22L,132L,82L,306L,6L,36L,36L,132L,36L,216L,132L,492L,22L,132L,132L,484L,82L,492L,306L,1142L,6L,36L,36L,132L,36L,216L,132L,492L,36L,216L,216L,792L,132L,792L,492L,1836L,22L,132L,132L,484L,132L,792L,484L,1804L,82L,492L,492L,1804L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255460Inst : IEnumerable<long>
{
public static readonly long[] Value=A255460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255460.Bytes);
public long this[int i]=>Value[i];

public static A255460Inst Instance=new A255460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255461
{
public static readonly long[] Value={ 1L,6L,22L,82L,306L,1142L,4250L,15806L,58730L,218142L,810074L,3007886L,11167914L,41463774L,153942330L,571535534L,2121906442L,7877856190L,29247532442L,108585059214L,403135208426L,1496688037406L,5556634000122L,20629669372526L,76590116106186L,284349965403518L,1055683240842074L,3919350217589838L,14551056119534250L,54022534883643358L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255461Inst : IEnumerable<long>
{
public static readonly long[] Value=A255461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255461.Bytes);
public long this[int i]=>Value[i];

public static A255461Inst Instance=new A255461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255462
{
public static readonly long[] Value={ 1L,6L,6L,30L,6L,36L,30L,138L,6L,36L,36L,180L,30L,180L,138L,606L,6L,36L,36L,180L,36L,216L,180L,828L,30L,180L,180L,900L,138L,828L,606L,2586L,6L,36L,36L,180L,36L,216L,180L,828L,36L,216L,216L,1080L,180L,1080L,828L,3636L,30L,180L,180L,900L,180L,1080L,900L,4140L,138L,828L,828L,4140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255462Inst : IEnumerable<long>
{
public static readonly long[] Value=A255462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255462.Bytes);
public long this[int i]=>Value[i];

public static A255462Inst Instance=new A255462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255463
{
public static readonly long[] Value={ 1L,6L,30L,138L,606L,2586L,10830L,44778L,183486L,747066L,3027630L,12228618L,49268766L,198137946L,795740430L,3192527658L,12798808446L,51281327226L,205383589230L,822309197898L,3291561314526L,13173218826906L,52713796014030L,210917946175338L,843860071059006L,3376005143308986L,13505715150454830L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255463Inst : IEnumerable<long>
{
public static readonly long[] Value=A255463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255463.Bytes);
public long this[int i]=>Value[i];

public static A255463Inst Instance=new A255463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255464
{
public static readonly long[] Value={ 1L,6L,6L,22L,6L,36L,22L,90L,6L,36L,36L,132L,22L,132L,90L,358L,6L,36L,36L,132L,36L,216L,132L,540L,22L,132L,132L,484L,90L,540L,358L,1434L,6L,36L,36L,132L,36L,216L,132L,540L,36L,216L,216L,792L,132L,792L,540L,2148L,22L,132L,132L,484L,132L,792L,484L,1980L,90L,540L,540L,1980L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255464Inst : IEnumerable<long>
{
public static readonly long[] Value=A255464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255464.Bytes);
public long this[int i]=>Value[i];

public static A255464Inst Instance=new A255464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255465
{
public static readonly long[] Value={ 1L,6L,22L,90L,358L,1434L,5734L,22938L,91750L,367002L,1468006L,5872026L,23488102L,93952410L,375809638L,1503238554L,6012954214L,24051816858L,96207267430L,384829069722L,1539316278886L,6157265115546L,24629060462182L,98516241848730L,394064967394918L,1576259869579674L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255465Inst : IEnumerable<long>
{
public static readonly long[] Value=A255465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255465.Bytes);
public long this[int i]=>Value[i];

public static A255465Inst Instance=new A255465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255466
{
public static readonly long[] Value={ 1L,6L,6L,26L,6L,36L,26L,110L,6L,36L,36L,156L,26L,156L,110L,450L,6L,36L,36L,156L,36L,216L,156L,660L,26L,156L,156L,676L,110L,660L,450L,1822L,6L,36L,36L,156L,36L,216L,156L,660L,36L,216L,216L,936L,156L,936L,660L,2700L,26L,156L,156L,676L,156L,936L,676L,2860L,110L,660L,660L,2860L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255466Inst : IEnumerable<long>
{
public static readonly long[] Value=A255466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255466.Bytes);
public long this[int i]=>Value[i];

public static A255466Inst Instance=new A255466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255467
{
public static readonly long[] Value={ 1L,6L,26L,110L,450L,1822L,7330L,29406L,117794L,471518L,1886754L,7548382L,30196258L,120790494L,483172898L,1932713438L,7730897442L,30923677150L,123694883362L,494779882974L,1979120230946L,7916482321886L,31665932083746L,126663733927390L,506654946894370L,2026619809947102L,8106479284527650L,32425917227589086L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255467Inst : IEnumerable<long>
{
public static readonly long[] Value=A255467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255467.Bytes);
public long this[int i]=>Value[i];

public static A255467Inst Instance=new A255467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255468
{
public static readonly long[] Value={ 1L,6L,6L,20L,6L,36L,20L,84L,6L,36L,36L,120L,20L,120L,84L,296L,6L,36L,36L,120L,36L,216L,120L,504L,20L,120L,120L,400L,84L,504L,296L,1124L,6L,36L,36L,120L,36L,216L,120L,504L,36L,216L,216L,720L,120L,720L,504L,1776L,20L,120L,120L,400L,120L,720L,400L,1680L,84L,504L,504L,1680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255468Inst : IEnumerable<long>
{
public static readonly long[] Value=A255468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255468.Bytes);
public long this[int i]=>Value[i];

public static A255468Inst Instance=new A255468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255469
{
public static readonly long[] Value={ 1L,6L,20L,84L,296L,1124L,4056L,15100L,55288L,204740L,753336L,2782588L,10252952L,37831684L,139470616L,514443580L,1896954168L,6996160196L,25799583352L,95147186940L,350881763288L,1294007162500L,4772059430872L,17598637988284L,64900766401656L,239343741625668L,882659972822840L,3255107458681212L,12004301666699032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255469Inst : IEnumerable<long>
{
public static readonly long[] Value=A255469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255469.Bytes);
public long this[int i]=>Value[i];

public static A255469Inst Instance=new A255469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255470
{
public static readonly long[] Value={ 1L,6L,6L,24L,6L,36L,24L,100L,6L,36L,36L,144L,24L,144L,100L,396L,6L,36L,36L,144L,36L,216L,144L,600L,24L,144L,144L,576L,100L,600L,396L,1596L,6L,36L,36L,144L,36L,216L,144L,600L,36L,216L,216L,864L,144L,864L,600L,2376L,24L,144L,144L,576L,144L,864L,576L,2400L,100L,600L,600L,2400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255470Inst : IEnumerable<long>
{
public static readonly long[] Value=A255470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255470.Bytes);
public long this[int i]=>Value[i];

public static A255470Inst Instance=new A255470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255471
{
public static readonly long[] Value={ 1L,6L,24L,100L,396L,1596L,6364L,25500L,101916L,407836L,1631004L,6524700L,26097436L,104392476L,417564444L,1670268700L,6681052956L,26724255516L,106896934684L,427587913500L,1710351304476L,6841405916956L,27365622269724L,109462491875100L,437849961907996L,1751399858816796L,7005599412897564L,28022397696329500L,112089590695839516L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255471Inst : IEnumerable<long>
{
public static readonly long[] Value=A255471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255471.Bytes);
public long this[int i]=>Value[i];

public static A255471Inst Instance=new A255471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255472
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,1L,2L,2L,2L,2L,2L,3L,3L,2L,3L,1L,4L,4L,1L,3L,4L,3L,3L,4L,4L,3L,5L,3L,3L,6L,1L,5L,6L,2L,5L,5L,4L,5L,6L,4L,4L,8L,4L,3L,8L,3L,5L,7L,2L,5L,7L,5L,6L,6L,6L,6L,9L,5L,4L,12L,3L,5L,10L,2L,5L,7L,6L,5L,6L,6L,5L,11L,5L,4L,11L,2L,8L,8L,3L,7L,10L,5L,4L,9L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255472Inst : IEnumerable<long>
{
public static readonly long[] Value=A255472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255472.Bytes);
public long this[int i]=>Value[i];

public static A255472Inst Instance=new A255472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255473
{
public static readonly long[] Value={ 1L,6L,6L,24L,6L,36L,24L,88L,6L,36L,36L,144L,24L,144L,88L,336L,6L,36L,36L,144L,36L,216L,144L,528L,24L,144L,144L,576L,88L,528L,336L,1280L,6L,36L,36L,144L,36L,216L,144L,528L,36L,216L,216L,864L,144L,864L,528L,2016L,24L,144L,144L,576L,144L,864L,576L,2112L,88L,528L,528L,2112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255473Inst : IEnumerable<long>
{
public static readonly long[] Value=A255473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255473.Bytes);
public long this[int i]=>Value[i];

public static A255473Inst Instance=new A255473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255474
{
public static readonly long[] Value={ 1L,6L,24L,88L,336L,1280L,4928L,19072L,74240L,290304L,1139712L,4489216L,17731584L,70197248L,278429696L,1106083840L,4399628288L,17518559232L,69815500800L,278424715264L,1110989340672L,4435189170176L,17712382214144L,70757707153408L,282733687341056L,1129973180006400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255474Inst : IEnumerable<long>
{
public static readonly long[] Value=A255474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255474.Bytes);
public long this[int i]=>Value[i];

public static A255474Inst Instance=new A255474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255475
{
public static readonly long[] Value={ 1L,6L,6L,24L,6L,36L,24L,94L,6L,36L,36L,144L,24L,144L,94L,356L,6L,36L,36L,144L,36L,216L,144L,564L,24L,144L,144L,576L,94L,564L,356L,1338L,6L,36L,36L,144L,36L,216L,144L,564L,36L,216L,216L,864L,144L,864L,564L,2136L,24L,144L,144L,576L,144L,864L,576L,2256L,94L,564L,564L,2256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255475Inst : IEnumerable<long>
{
public static readonly long[] Value=A255475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255475.Bytes);
public long this[int i]=>Value[i];

public static A255475Inst Instance=new A255475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255476
{
public static readonly long[] Value={ 1L,6L,24L,94L,356L,1338L,5036L,18942L,71264L,268114L,1008728L,3795162L,14278632L,53720914L,202115688L,760425734L,2860971568L,10763916406L,40497394188L,152364521390L,573245456832L,2156738015294L,8114358001856L,30528884544598L,114859708062884L,432140012215626L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255476Inst : IEnumerable<long>
{
public static readonly long[] Value=A255476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255476.Bytes);
public long this[int i]=>Value[i];

public static A255476Inst Instance=new A255476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255477
{
public static readonly long[] Value={ 1L,80L,80L,624L,80L,6400L,624L,16480L,80L,6400L,6400L,49920L,624L,49920L,16480L,221888L,80L,6400L,6400L,49920L,6400L,512000L,49920L,1318400L,624L,49920L,49920L,389376L,16480L,1318400L,221888L,4245888L,80L,6400L,6400L,49920L,6400L,512000L,49920L,1318400L,6400L,512000L,512000L,3993600L,49920L,3993600L,1318400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255477Inst : IEnumerable<long>
{
public static readonly long[] Value=A255477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255477.Bytes);
public long this[int i]=>Value[i];

public static A255477Inst Instance=new A255477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255478
{
public static readonly BigInteger[] Value={ 1L,80L,624L,16480L,221888L,4245888L,66759424L,1158095360L,18967114752L,318729757696L,5260906022912L,87309457787904L,1439402906245120L,23729936541559808L,389928297670440960L,6398667538798480384L,BigInteger.Parse("104773970517568231424"),BigInteger.Parse("1712967144350639066112"),BigInteger.Parse("27958316901583753934848") };
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
public class A255478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255478Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A255478.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A255478.Bytes);
public BigInteger this[int i]=>Value[i];

public static A255478Inst Instance=new A255478Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255479
{
public static readonly long[] Value={ 1L,2L,3L,4L,10L,5L,13L,6L,7L,8L,21L,9L,24L,11L,12L,16L,31L,14L,38L,18L,15L,23L,43L,20L,30L,22L,17L,25L,51L,28L,59L,27L,19L,29L,32L,37L,67L,36L,26L,34L,78L,35L,81L,39L,42L,41L,90L,44L,52L,46L,33L,48L,101L,47L,58L,50L,40L,49L,108L,55L,119L,57L,54L,64L,60L,63L,131L,66L,45L,62L,136L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255479Inst : IEnumerable<long>
{
public static readonly long[] Value=A255479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255479.Bytes);
public long this[int i]=>Value[i];

public static A255479Inst Instance=new A255479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255480
{
public static readonly long[] Value={ 1L,2L,3L,4L,3L,2L,3L,5L,2L,5L,7L,3L,7L,2L,3L,4L,3L,4L,11L,2L,11L,13L,2L,13L,4L,3L,2L,5L,17L,5L,17L,5L,3L,2L,6L,19L,4L,19L,2L,3L,23L,3L,23L,2L,3L,2L,2L,4L,29L,7L,29L,7L,3L,7L,2L,11L,31L,5L,31L,5L,3L,2L,2L,4L,37L,4L,37L,3L,3L,5L,3L,4L,9L,2L,6L,41L,2L,41L,43L,3L,43L,8L,3L,4L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255480Inst : IEnumerable<long>
{
public static readonly long[] Value=A255480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255480.Bytes);
public long this[int i]=>Value[i];

public static A255480Inst Instance=new A255480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A255481
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,3L,1L,1L,2L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,1L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,3L,1L,2L,2L,2L,2L,1L,1L,1L,3L,3L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,1L,1L,3L,3L,3L,2L,1L,1L,2L,2L,2L,1L,1L,1L,1L,1L,3L,1L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A255481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A255481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A255481Inst : IEnumerable<long>
{
public static readonly long[] Value=A255481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A255481.Bytes);
public long this[int i]=>Value[i];

public static A255481Inst Instance=new A255481Inst();

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