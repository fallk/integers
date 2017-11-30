using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A008293
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,8L,6L,16L,40L,24L,16L,136L,240L,120L,272L,1232L,1680L,720L,272L,3968L,12096L,13440L,5040L,7936L,56320L,129024L,120960L,40320L,7936L,176896L,814080L,1491840L,1209600L,362880L,353792L,3610112L,12207360L,18627840L,13305600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008293Inst : IEnumerable<long>
{
public static readonly long[] Value=A008293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008293.Bytes);
public long this[int i]=>Value[i];

public static A008293Inst Instance=new A008293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008292
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,11L,11L,1L,1L,26L,66L,26L,1L,1L,57L,302L,302L,57L,1L,1L,120L,1191L,2416L,1191L,120L,1L,1L,247L,4293L,15619L,15619L,4293L,247L,1L,1L,502L,14608L,88234L,156190L,88234L,14608L,502L,1L,1L,1013L,47840L,455192L,1310354L,1310354L,455192L,47840L,1013L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008292Inst : IEnumerable<long>
{
public static readonly long[] Value=A008292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008292.Bytes);
public long this[int i]=>Value[i];

public static A008292Inst Instance=new A008292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008291
{
public static readonly long[] Value={ 1L,2L,3L,9L,8L,6L,44L,45L,20L,10L,265L,264L,135L,40L,15L,1854L,1855L,924L,315L,70L,21L,14833L,14832L,7420L,2464L,630L,112L,28L,133496L,133497L,66744L,22260L,5544L,1134L,168L,36L,1334961L,1334960L,667485L,222480L,55650L,11088L,1890L,240L,45L,14684570L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008291Inst : IEnumerable<long>
{
public static readonly long[] Value=A008291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008291.Bytes);
public long this[int i]=>Value[i];

public static A008291Inst Instance=new A008291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008290
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,2L,3L,0L,1L,9L,8L,6L,0L,1L,44L,45L,20L,10L,0L,1L,265L,264L,135L,40L,15L,0L,1L,1854L,1855L,924L,315L,70L,21L,0L,1L,14833L,14832L,7420L,2464L,630L,112L,28L,0L,1L,133496L,133497L,66744L,22260L,5544L,1134L,168L,36L,0L,1L,1334961L,1334960L,667485L,222480L,55650L,11088L,1890L,240L,45L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008290Inst : IEnumerable<long>
{
public static readonly long[] Value=A008290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008290.Bytes);
public long this[int i]=>Value[i];

public static A008290Inst Instance=new A008290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008289
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,3L,1L,1L,3L,2L,1L,4L,3L,1L,4L,4L,1L,1L,5L,5L,1L,1L,5L,7L,2L,1L,6L,8L,3L,1L,6L,10L,5L,1L,7L,12L,6L,1L,1L,7L,14L,9L,1L,1L,8L,16L,11L,2L,1L,8L,19L,15L,3L,1L,9L,21L,18L,5L,1L,9L,24L,23L,7L,1L,10L,27L,27L,10L,1L,1L,10L,30L,34L,13L,1L,1L,11L,33L,39L,18L,2L,1L,11L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008289Inst : IEnumerable<long>
{
public static readonly long[] Value=A008289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008289.Bytes);
public long this[int i]=>Value[i];

public static A008289Inst Instance=new A008289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008288
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,5L,5L,1L,1L,7L,13L,7L,1L,1L,9L,25L,25L,9L,1L,1L,11L,41L,63L,41L,11L,1L,1L,13L,61L,129L,129L,61L,13L,1L,1L,15L,85L,231L,321L,231L,85L,15L,1L,1L,17L,113L,377L,681L,681L,377L,113L,17L,1L,1L,19L,145L,575L,1289L,1683L,1289L,575L,145L,19L,1L,1L,21L,181L,833L,2241L,3653L,3653L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008288Inst : IEnumerable<long>
{
public static readonly long[] Value=A008288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008288.Bytes);
public long this[int i]=>Value[i];

public static A008288Inst Instance=new A008288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008287
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,3L,4L,3L,2L,1L,1L,3L,6L,10L,12L,12L,10L,6L,3L,1L,1L,4L,10L,20L,31L,40L,44L,40L,31L,20L,10L,4L,1L,1L,5L,15L,35L,65L,101L,135L,155L,155L,135L,101L,65L,35L,15L,5L,1L,1L,6L,21L,56L,120L,216L,336L,456L,546L,580L,546L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008287Inst : IEnumerable<long>
{
public static readonly long[] Value=A008287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008287.Bytes);
public long this[int i]=>Value[i];

public static A008287Inst Instance=new A008287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008286
{
public static readonly long[] Value={ 1L,2L,5L,14L,61L,320L,3037L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008286Inst : IEnumerable<long>
{
public static readonly long[] Value=A008286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008286.Bytes);
public long this[int i]=>Value[i];

public static A008286Inst Instance=new A008286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008269
{
public static readonly BigInteger[] Value={ 1L,2L,9L,112L,2921L,126966L,8204497L,735944084L,87394386417L,13265365173706L,2504688393449081L,575664638548522392L,BigInteger.Parse("158222202503521622809"),BigInteger.Parse("51242608446417388426622"),BigInteger.Parse("19312113111034490954560641") };
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
public class A008269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008269Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A008269.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008269.Bytes);
public BigInteger this[int i]=>Value[i];

public static A008269Inst Instance=new A008269Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008268
{
public static readonly long[] Value={ 1L,4L,10L,23L,47L,83L,127L,174L,221L,276L,356L,428L,494L,603L,698L,781L,912L,1035L,1131L,1289L,1435L,1542L,1735L,1903L,2014L,2245L,2435L,2556L,2817L,3032L,3160L,3459L,3694L,3824L,4166L,4426L,4551L,4937L,5222L,5345L,5771L,6083L,6204L,6675L,7004L,7125L,7645L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008268Inst : IEnumerable<long>
{
public static readonly long[] Value=A008268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008268.Bytes);
public long this[int i]=>Value[i];

public static A008268Inst Instance=new A008268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008267
{
public static readonly long[] Value={ 1L,4L,10L,22L,47L,83L,125L,171L,215L,288L,349L,415L,518L,591L,674L,816L,904L,1002L,1177L,1271L,1388L,1617L,1710L,1840L,2112L,2204L,2358L,2684L,2769L,2939L,3314L,3391L,3581L,4023L,4084L,4287L,4791L,4833L,5054L,5633L,5655L,5893L,6533L,6526L,6788L,7513L,7479L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008267Inst : IEnumerable<long>
{
public static readonly long[] Value=A008267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008267.Bytes);
public long this[int i]=>Value[i];

public static A008267Inst Instance=new A008267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008266
{
public static readonly long[] Value={ 1L,4L,9L,18L,32L,48L,67L,92L,120L,150L,185L,224L,266L,312L,361L,414L,472L,532L,595L,664L,736L,810L,889L,972L,1058L,1148L,1241L,1338L,1440L,1544L,1651L,1764L,1880L,1998L,2121L,2248L,2378L,2512L,2649L,2790L,2936L,3084L,3235L,3392L,3552L,3714L,3881L,4052L,4226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008266Inst : IEnumerable<long>
{
public static readonly long[] Value=A008266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008266.Bytes);
public long this[int i]=>Value[i];

public static A008266Inst Instance=new A008266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008265
{
public static readonly long[] Value={ 1L,4L,11L,22L,37L,59L,85L,114L,147L,184L,230L,280L,331L,386L,445L,515L,589L,662L,739L,820L,914L,1012L,1107L,1206L,1309L,1427L,1549L,1666L,1787L,1912L,2054L,2200L,2339L,2482L,2629L,2795L,2965L,3126L,3291L,3460L,3650L,3844L,4027L,4214L,4405L,4619L,4837L,5042L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008265Inst : IEnumerable<long>
{
public static readonly long[] Value=A008265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008265.Bytes);
public long this[int i]=>Value[i];

public static A008265Inst Instance=new A008265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008264
{
public static readonly long[] Value={ 1L,4L,12L,25L,44L,67L,96L,130L,170L,214L,264L,319L,380L,445L,516L,592L,674L,760L,852L,949L,1052L,1159L,1272L,1390L,1514L,1642L,1776L,1915L,2060L,2209L,2364L,2524L,2690L,2860L,3036L,3217L,3404L,3595L,3792L,3994L,4202L,4414L,4632L,4855L,5084L,5317L,5556L,5800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008264Inst : IEnumerable<long>
{
public static readonly long[] Value=A008264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008264.Bytes);
public long this[int i]=>Value[i];

public static A008264Inst Instance=new A008264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008263
{
public static readonly long[] Value={ 1L,4L,11L,26L,43L,58L,90L,132L,159L,196L,257L,308L,352L,418L,495L,568L,637L,712L,810L,910L,993L,1092L,1213L,1324L,1432L,1550L,1681L,1830L,1961L,2076L,2238L,2416L,2547L,2692L,2887L,3068L,3224L,3394L,3595L,3808L,3987L,4160L,4396L,4632L,4811L,5022L,5281L,5514L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008263Inst : IEnumerable<long>
{
public static readonly long[] Value=A008263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008263.Bytes);
public long this[int i]=>Value[i];

public static A008263Inst Instance=new A008263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008262
{
public static readonly long[] Value={ 1L,4L,11L,20L,40L,68L,93L,120L,157L,206L,254L,299L,355L,430L,495L,549L,633L,735L,813L,886L,995L,1111L,1207L,1306L,1434L,1573L,1687L,1798L,1949L,2114L,2243L,2377L,2552L,2727L,2879L,3036L,3224L,3426L,3604L,3766L,3977L,4212L,4397L,4578L,4819L,5067L,5270L,5478L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008262Inst : IEnumerable<long>
{
public static readonly long[] Value=A008262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008262.Bytes);
public long this[int i]=>Value[i];

public static A008262Inst Instance=new A008262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008261
{
public static readonly long[] Value={ 1L,4L,12L,30L,52L,80L,116L,156L,204L,258L,318L,384L,458L,536L,622L,714L,812L,916L,1028L,1144L,1268L,1398L,1534L,1676L,1826L,1980L,2142L,2310L,2484L,2664L,2852L,3044L,3244L,3450L,3662L,3880L,4106L,4336L,4574L,4818L,5068L,5324L,5588L,5856L,6132L,6414L,6702L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008261Inst : IEnumerable<long>
{
public static readonly long[] Value=A008261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008261.Bytes);
public long this[int i]=>Value[i];

public static A008261Inst Instance=new A008261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008260
{
public static readonly long[] Value={ 1L,4L,10L,21L,37L,57L,81L,109L,142L,180L,222L,268L,318L,373L,433L,497L,565L,637L,714L,796L,882L,972L,1066L,1165L,1269L,1377L,1489L,1605L,1726L,1852L,1982L,2116L,2254L,2397L,2545L,2697L,2853L,3013L,3178L,3348L,3522L,3700L,3882L,4069L,4261L,4457L,4657L,4861L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008260Inst : IEnumerable<long>
{
public static readonly long[] Value=A008260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008260.Bytes);
public long this[int i]=>Value[i];

public static A008260Inst Instance=new A008260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008259
{
public static readonly long[] Value={ 1L,4L,11L,24L,41L,62L,90L,122L,157L,200L,247L,296L,354L,416L,479L,552L,629L,706L,794L,886L,977L,1080L,1187L,1292L,1410L,1532L,1651L,1784L,1921L,2054L,2202L,2354L,2501L,2664L,2831L,2992L,3170L,3352L,3527L,3720L,3917L,4106L,4314L,4526L,4729L,4952L,5179L,5396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008259Inst : IEnumerable<long>
{
public static readonly long[] Value=A008259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008259.Bytes);
public long this[int i]=>Value[i];

public static A008259Inst Instance=new A008259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008258
{
public static readonly long[] Value={ 1L,4L,10L,24L,40L,64L,90L,120L,160L,200L,244L,300L,354L,412L,484L,552L,624L,712L,794L,880L,984L,1080L,1180L,1300L,1410L,1524L,1660L,1784L,1912L,2064L,2202L,2344L,2512L,2664L,2820L,3004L,3170L,3340L,3540L,3720L,3904L,4120L,4314L,4512L,4744L,4952L,5164L,5412L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008258Inst : IEnumerable<long>
{
public static readonly long[] Value=A008258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008258.Bytes);
public long this[int i]=>Value[i];

public static A008258Inst Instance=new A008258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008257
{
public static readonly long[] Value={ 1L,4L,12L,22L,36L,58L,94L,136L,164L,194L,248L,320L,382L,440L,500L,568L,664L,760L,844L,936L,1030L,1134L,1268L,1384L,1498L,1618L,1758L,1898L,2048L,2184L,2344L,2504L,2680L,2830L,3014L,3190L,3390L,3572L,3776L,3950L,4178L,4384L,4624L,4828L,5060L,5260L,5540L,5772L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008257Inst : IEnumerable<long>
{
public static readonly long[] Value=A008257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008257.Bytes);
public long this[int i]=>Value[i];

public static A008257Inst Instance=new A008257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008256
{
public static readonly long[] Value={ 1L,4L,10L,22L,43L,69L,95L,123L,162L,215L,269L,319L,372L,435L,513L,597L,675L,754L,843L,943L,1052L,1162L,1268L,1381L,1507L,1640L,1776L,1912L,2052L,2204L,2362L,2520L,2682L,2854L,3034L,3216L,3399L,3585L,3782L,3992L,4202L,4411L,4623L,4842L,5077L,5319L,5555L,5791L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008256Inst : IEnumerable<long>
{
public static readonly long[] Value=A008256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008256.Bytes);
public long this[int i]=>Value[i];

public static A008256Inst Instance=new A008256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008255
{
public static readonly long[] Value={ 1L,4L,10L,22L,38L,56L,82L,112L,142L,182L,226L,268L,322L,380L,434L,502L,574L,640L,722L,808L,886L,982L,1082L,1172L,1282L,1396L,1498L,1622L,1750L,1864L,2002L,2144L,2270L,2422L,2578L,2716L,2882L,3052L,3202L,3382L,3566L,3728L,3922L,4120L,4294L,4502L,4714L,4900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008255Inst : IEnumerable<long>
{
public static readonly long[] Value=A008255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008255.Bytes);
public long this[int i]=>Value[i];

public static A008255Inst Instance=new A008255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008254
{
public static readonly long[] Value={ 1L,4L,10L,20L,38L,58L,80L,112L,144L,180L,226L,270L,320L,380L,436L,500L,574L,642L,720L,808L,888L,980L,1082L,1174L,1280L,1396L,1500L,1620L,1750L,1866L,2000L,2144L,2272L,2420L,2578L,2718L,2880L,3052L,3204L,3380L,3566L,3730L,3920L,4120L,4296L,4500L,4714L,4902L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008254Inst : IEnumerable<long>
{
public static readonly long[] Value=A008254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008254.Bytes);
public long this[int i]=>Value[i];

public static A008254Inst Instance=new A008254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008253
{
public static readonly long[] Value={ 1L,4L,12L,24L,42L,64L,92L,124L,162L,204L,252L,304L,362L,424L,492L,564L,642L,724L,812L,904L,1002L,1104L,1212L,1324L,1442L,1564L,1692L,1824L,1962L,2104L,2252L,2404L,2562L,2724L,2892L,3064L,3242L,3424L,3612L,3804L,4002L,4204L,4412L,4624L,4842L,5064L,5292L,5524L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008253Inst : IEnumerable<long>
{
public static readonly long[] Value=A008253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008253.Bytes);
public long this[int i]=>Value[i];

public static A008253Inst Instance=new A008253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008252
{
public static readonly long[] Value={ 1L,4L,11L,23L,46L,70L,100L,131L,177L,230L,280L,332L,395L,471L,554L,620L,714L,797L,909L,998L,1120L,1226L,1353L,1453L,1618L,1736L,1906L,1995L,2195L,2336L,2540L,2646L,2861L,3011L,3268L,3374L,3642L,3771L,4071L,4194L,4502L,4648L,4961L,5083L,5456L,5600L,5976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008252Inst : IEnumerable<long>
{
public static readonly long[] Value=A008252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008252.Bytes);
public long this[int i]=>Value[i];

public static A008252Inst Instance=new A008252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008251
{
public static readonly long[] Value={ 1L,4L,10L,24L,42L,58L,106L,136L,170L,216L,262L,356L,394L,448L,550L,606L,726L,788L,872L,1036L,1068L,1240L,1346L,1452L,1606L,1686L,1884L,2084L,2114L,2352L,2448L,2720L,2850L,2976L,3192L,3438L,3578L,3844L,3942L,4284L,4380L,4700L,4872L,5204L,5318L,5626L,5866L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008251Inst : IEnumerable<long>
{
public static readonly long[] Value=A008251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008251.Bytes);
public long this[int i]=>Value[i];

public static A008251Inst Instance=new A008251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008250
{
public static readonly long[] Value={ 1L,4L,11L,24L,42L,65L,97L,135L,176L,221L,277L,337L,400L,469L,547L,629L,716L,807L,907L,1013L,1122L,1235L,1359L,1487L,1618L,1755L,1901L,2051L,2206L,2365L,2533L,2707L,2884L,3065L,3257L,3453L,3652L,3857L,4071L,4289L,4512L,4739L,4975L,5217L,5462L,5711L,5971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008250Inst : IEnumerable<long>
{
public static readonly long[] Value=A008250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008250.Bytes);
public long this[int i]=>Value[i];

public static A008250Inst Instance=new A008250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008249
{
public static readonly long[] Value={ 1L,4L,11L,22L,42L,67L,97L,133L,176L,223L,277L,335L,400L,471L,547L,627L,716L,809L,907L,1011L,1122L,1237L,1359L,1485L,1618L,1757L,1901L,2049L,2206L,2367L,2533L,2705L,2884L,3067L,3257L,3451L,3652L,3859L,4071L,4287L,4512L,4741L,4975L,5215L,5462L,5713L,5971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008249Inst : IEnumerable<long>
{
public static readonly long[] Value=A008249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008249.Bytes);
public long this[int i]=>Value[i];

public static A008249Inst Instance=new A008249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008248
{
public static readonly long[] Value={ 1L,4L,10L,22L,39L,61L,89L,118L,153L,198L,241L,287L,349L,409L,465L,541L,619L,688L,777L,871L,954L,1056L,1165L,1264L,1380L,1501L,1615L,1748L,1882L,2008L,2158L,2307L,2444L,2611L,2776L,2923L,3105L,3288L,3448L,3642L,3841L,4016L,4223L,4437L,4627L,4848L,5075L,5280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008248Inst : IEnumerable<long>
{
public static readonly long[] Value=A008248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008248.Bytes);
public long this[int i]=>Value[i];

public static A008248Inst Instance=new A008248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008247
{
public static readonly long[] Value={ 1L,4L,11L,22L,39L,61L,88L,120L,155L,192L,241L,295L,344L,404L,473L,539L,613L,696L,776L,863L,961L,1057L,1159L,1270L,1378L,1495L,1624L,1746L,1875L,2017L,2154L,2301L,2457L,2605L,2765L,2939L,3103L,3274L,3463L,3641L,3826L,4031L,4224L,4423L,4639L,4847L,5064L,5295L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008247Inst : IEnumerable<long>
{
public static readonly long[] Value=A008247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008247.Bytes);
public long this[int i]=>Value[i];

public static A008247Inst Instance=new A008247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008246
{
public static readonly long[] Value={ 1L,4L,10L,18L,30L,44L,60L,80L,106L,135L,168L,207L,248L,286L,330L,382L,436L,489L,548L,612L,676L,741L,816L,896L,974L,1055L,1142L,1231L,1324L,1420L,1522L,1626L,1730L,1837L,1948L,2064L,2188L,2313L,2440L,2572L,2704L,2835L,2974L,3121L,3272L,3420L,3572L,3730L,3886L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008246Inst : IEnumerable<long>
{
public static readonly long[] Value=A008246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008246.Bytes);
public long this[int i]=>Value[i];

public static A008246Inst Instance=new A008246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008245
{
public static readonly long[] Value={ 1L,4L,11L,20L,31L,44L,61L,82L,108L,139L,174L,209L,246L,287L,333L,382L,436L,493L,552L,611L,674L,743L,817L,895L,977L,1060L,1145L,1232L,1324L,1421L,1523L,1627L,1733L,1840L,1951L,2066L,2186L,2312L,2442L,2572L,2704L,2839L,2979L,3122L,3270L,3422L,3576L,3730L,3888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008245Inst : IEnumerable<long>
{
public static readonly long[] Value=A008245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008245.Bytes);
public long this[int i]=>Value[i];

public static A008245Inst Instance=new A008245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008244
{
public static readonly long[] Value={ 1L,4L,12L,22L,39L,66L,95L,130L,158L,208L,270L,320L,375L,428L,491L,612L,678L,742L,828L,918L,1077L,1176L,1233L,1354L,1466L,1668L,1806L,1862L,2007L,2174L,2387L,2552L,2610L,2774L,3002L,3256L,3439L,3508L,3657L,3966L,4256L,4426L,4536L,4686L,5035L,5418L,5555L,5678L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008244Inst : IEnumerable<long>
{
public static readonly long[] Value=A008244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008244.Bytes);
public long this[int i]=>Value[i];

public static A008244Inst Instance=new A008244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008243
{
public static readonly long[] Value={ 1L,4L,12L,22L,41L,68L,97L,118L,166L,224L,258L,302L,371L,458L,521L,560L,660L,764L,860L,932L,1009L,1168L,1273L,1366L,1500L,1618L,1776L,1870L,2039L,2238L,2311L,2470L,2658L,2888L,3044L,3092L,3365L,3602L,3797L,3952L,4064L,4418L,4628L,4802L,5045L,5216L,5545L,5710L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008243Inst : IEnumerable<long>
{
public static readonly long[] Value=A008243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008243.Bytes);
public long this[int i]=>Value[i];

public static A008243Inst Instance=new A008243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008242
{
public static readonly long[] Value={ 1L,4L,12L,23L,43L,66L,91L,128L,169L,214L,258L,306L,381L,450L,509L,574L,659L,771L,848L,924L,1038L,1148L,1274L,1373L,1491L,1636L,1743L,1902L,2051L,2188L,2340L,2466L,2689L,2864L,2991L,3170L,3343L,3611L,3776L,3910L,4166L,4362L,4626L,4813L,5007L,5296L,5461L,5768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008242Inst : IEnumerable<long>
{
public static readonly long[] Value=A008242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008242.Bytes);
public long this[int i]=>Value[i];

public static A008242Inst Instance=new A008242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008241
{
public static readonly long[] Value={ 1L,4L,12L,24L,40L,61L,96L,133L,163L,204L,262L,326L,375L,427L,504L,595L,678L,744L,834L,944L,1042L,1152L,1258L,1372L,1494L,1619L,1776L,1907L,2023L,2170L,2350L,2540L,2651L,2789L,3008L,3217L,3402L,3530L,3722L,3978L,4182L,4390L,4566L,4786L,5038L,5269L,5552L,5745L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008241Inst : IEnumerable<long>
{
public static readonly long[] Value=A008241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008241.Bytes);
public long this[int i]=>Value[i];

public static A008241Inst Instance=new A008241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008240
{
public static readonly long[] Value={ 1L,4L,8L,18L,34L,50L,68L,100L,130L,160L,204L,246L,286L,338L,392L,448L,514L,580L,648L,726L,802L,878L,968L,1060L,1150L,1252L,1356L,1458L,1570L,1682L,1796L,1924L,2050L,2176L,2316L,2454L,2590L,2738L,2888L,3040L,3202L,3364L,3528L,3702L,3874L,4046L,4232L,4420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008240Inst : IEnumerable<long>
{
public static readonly long[] Value=A008240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008240.Bytes);
public long this[int i]=>Value[i];

public static A008240Inst Instance=new A008240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008239
{
public static readonly long[] Value={ 1L,4L,9L,19L,33L,50L,74L,100L,129L,165L,201L,242L,290L,338L,393L,453L,513L,580L,650L,722L,801L,883L,969L,1060L,1154L,1252L,1353L,1459L,1569L,1682L,1802L,1924L,2049L,2181L,2313L,2450L,2594L,2738L,2889L,3045L,3201L,3364L,3530L,3698L,3873L,4051L,4233L,4420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008239Inst : IEnumerable<long>
{
public static readonly long[] Value=A008239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008239.Bytes);
public long this[int i]=>Value[i];

public static A008239Inst Instance=new A008239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008238
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,2L,2L,4L,6L,6L,6L,9L,12L,12L,12L,16L,20L,20L,20L,25L,30L,30L,30L,36L,42L,42L,42L,49L,56L,56L,56L,64L,72L,72L,72L,81L,90L,90L,90L,100L,110L,110L,110L,121L,132L,132L,132L,144L,156L,156L,156L,169L,182L,182L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008238Inst : IEnumerable<long>
{
public static readonly long[] Value=A008238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008238.Bytes);
public long this[int i]=>Value[i];

public static A008238Inst Instance=new A008238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008221
{
public static readonly long[] Value={ 1L,4L,9L,18L,32L,49L,69L,94L,123L,153L,186L,225L,270L,318L,365L,417L,479L,543L,607L,676L,748L,823L,906L,995L,1083L,1170L,1265L,1368L,1469L,1573L,1686L,1800L,1915L,2038L,2167L,2295L,2421L,2555L,2701L,2847L,2993L,3146L,3300L,3455L,3620L,3793L,3963L,4132L,4311L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008221Inst : IEnumerable<long>
{
public static readonly long[] Value=A008221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008221.Bytes);
public long this[int i]=>Value[i];

public static A008221Inst Instance=new A008221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008220
{
public static readonly long[] Value={ 1L,4L,9L,18L,32L,49L,70L,95L,122L,154L,191L,230L,272L,318L,369L,424L,482L,544L,608L,675L,749L,827L,907L,992L,1080L,1170L,1265L,1365L,1469L,1576L,1686L,1801L,1919L,2039L,2164L,2293L,2426L,2564L,2705L,2848L,2993L,3143L,3300L,3460L,3623L,3791L,3960L,4131L,4309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008220Inst : IEnumerable<long>
{
public static readonly long[] Value=A008220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008220.Bytes);
public long this[int i]=>Value[i];

public static A008220Inst Instance=new A008220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008219
{
public static readonly long[] Value={ 1L,4L,9L,18L,31L,47L,68L,91L,117L,151L,188L,225L,268L,317L,368L,425L,485L,542L,602L,676L,758L,829L,899L,987L,1081L,1169L,1266L,1372L,1470L,1568L,1683L,1806L,1918L,2032L,2163L,2295L,2422L,2562L,2710L,2846L,2985L,3147L,3312L,3459L,3612L,3788L,3961L,4128L,4313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008219Inst : IEnumerable<long>
{
public static readonly long[] Value=A008219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008219.Bytes);
public long this[int i]=>Value[i];

public static A008219Inst Instance=new A008219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008218
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,2L,4L,8L,8L,12L,18L,27L,27L,36L,48L,64L,64L,80L,100L,125L,125L,150L,180L,216L,216L,252L,294L,343L,343L,392L,448L,512L,512L,576L,648L,729L,729L,810L,900L,1000L,1000L,1100L,1210L,1331L,1331L,1452L,1584L,1728L,1728L,1872L,2028L,2197L,2197L,2366L,2548L,2744L,2744L,2940L,3150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008218Inst : IEnumerable<long>
{
public static readonly long[] Value=A008218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008218.Bytes);
public long this[int i]=>Value[i];

public static A008218Inst Instance=new A008218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008217
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,1L,2L,4L,4L,4L,6L,9L,9L,9L,12L,16L,16L,16L,20L,25L,25L,25L,30L,36L,36L,36L,42L,49L,49L,49L,56L,64L,64L,64L,72L,81L,81L,81L,90L,100L,100L,100L,110L,121L,121L,121L,132L,144L,144L,144L,156L,169L,169L,169L,182L,196L,196L,196L,210L,225L,225L,225L,240L,256L,256L,256L,272L,289L,289L,289L,306L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008217Inst : IEnumerable<long>
{
public static readonly long[] Value=A008217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008217.Bytes);
public long this[int i]=>Value[i];

public static A008217Inst Instance=new A008217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008216
{
public static readonly long[] Value={ 1L,4L,12L,24L,40L,62L,92L,142L,166L,214L,262L,324L,400L,460L,514L,604L,702L,794L,868L,986L,1062L,1216L,1340L,1442L,1540L,1704L,1846L,2000L,2144L,2262L,2418L,2688L,2792L,2970L,3112L,3322L,3604L,3770L,3928L,4118L,4326L,4682L,4806L,5052L,5210L,5500L,5914L,6040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008216Inst : IEnumerable<long>
{
public static readonly long[] Value=A008216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008216.Bytes);
public long this[int i]=>Value[i];

public static A008216Inst Instance=new A008216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008215
{
public static readonly long[] Value={ 1L,4L,12L,24L,41L,65L,97L,133L,173L,212L,267L,337L,390L,463L,533L,610L,702L,795L,882L,972L,1097L,1221L,1328L,1454L,1565L,1699L,1873L,2001L,2123L,2288L,2479L,2651L,2806L,2967L,3143L,3374L,3586L,3763L,3940L,4134L,4399L,4641L,4828L,5036L,5267L,5577L,5853L,6075L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008215Inst : IEnumerable<long>
{
public static readonly long[] Value=A008215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008215.Bytes);
public long this[int i]=>Value[i];

public static A008215Inst Instance=new A008215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008214
{
public static readonly long[] Value={ 1L,4L,11L,23L,44L,72L,95L,124L,170L,229L,279L,325L,386L,467L,542L,612L,693L,788L,910L,1004L,1081L,1187L,1320L,1466L,1581L,1726L,1836L,1961L,2191L,2329L,2466L,2615L,2770L,3028L,3189L,3348L,3512L,3730L,4037L,4171L,4378L,4574L,4799L,5182L,5312L,5527L,5759L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008214Inst : IEnumerable<long>
{
public static readonly long[] Value=A008214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008214.Bytes);
public long this[int i]=>Value[i];

public static A008214Inst Instance=new A008214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008213
{
public static readonly long[] Value={ 1L,4L,12L,24L,39L,64L,99L,130L,174L,217L,262L,321L,403L,464L,517L,621L,710L,779L,889L,972L,1079L,1218L,1345L,1428L,1555L,1718L,1862L,1990L,2149L,2271L,2464L,2658L,2802L,2961L,3140L,3352L,3602L,3754L,3921L,4134L,4407L,4620L,4834L,5044L,5242L,5576L,5876L,6031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008213Inst : IEnumerable<long>
{
public static readonly long[] Value=A008213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008213.Bytes);
public long this[int i]=>Value[i];

public static A008213Inst Instance=new A008213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008212
{
public static readonly long[] Value={ 1L,4L,12L,25L,42L,67L,95L,133L,174L,219L,273L,331L,388L,462L,545L,615L,691L,797L,884L,991L,1096L,1203L,1327L,1451L,1592L,1703L,1844L,2009L,2133L,2325L,2459L,2612L,2825L,2978L,3193L,3355L,3526L,3773L,3955L,4198L,4364L,4586L,4861L,5047L,5355L,5535L,5765L,6107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008212Inst : IEnumerable<long>
{
public static readonly long[] Value=A008212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008212.Bytes);
public long this[int i]=>Value[i];

public static A008212Inst Instance=new A008212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008211
{
public static readonly long[] Value={ 1L,4L,12L,24L,32L,50L,88L,120L,152L,180L,226L,304L,374L,422L,460L,524L,628L,738L,812L,876L,954L,1072L,1208L,1282L,1404L,1540L,1662L,1804L,1932L,2054L,2184L,2362L,2512L,2678L,2856L,3006L,3158L,3338L,3556L,3764L,3930L,4084L,4326L,4560L,4764L,4982L,5160L,5410L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008211Inst : IEnumerable<long>
{
public static readonly long[] Value=A008211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008211.Bytes);
public long this[int i]=>Value[i];

public static A008211Inst Instance=new A008211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008210
{
public static readonly long[] Value={ 1L,4L,12L,22L,35L,55L,83L,119L,151L,184L,237L,303L,364L,417L,468L,534L,631L,731L,802L,877L,966L,1080L,1188L,1301L,1407L,1525L,1670L,1802L,1932L,2053L,2197L,2353L,2517L,2686L,2841L,2999L,3171L,3353L,3555L,3746L,3917L,4123L,4322L,4545L,4770L,4960L,5189L,5429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008210Inst : IEnumerable<long>
{
public static readonly long[] Value=A008210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008210.Bytes);
public long this[int i]=>Value[i];

public static A008210Inst Instance=new A008210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008209
{
public static readonly long[] Value={ 1L,4L,11L,24L,40L,63L,86L,114L,158L,208L,255L,299L,336L,402L,492L,570L,633L,693L,789L,910L,991L,1061L,1172L,1303L,1434L,1557L,1648L,1764L,1939L,2080L,2194L,2354L,2519L,2682L,2842L,2995L,3184L,3384L,3550L,3712L,3915L,4147L,4352L,4532L,4722L,4972L,5243L,5437L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008209Inst : IEnumerable<long>
{
public static readonly long[] Value=A008209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008209.Bytes);
public long this[int i]=>Value[i];

public static A008209Inst Instance=new A008209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008208
{
public static readonly long[] Value={ 1L,4L,12L,20L,31L,57L,84L,118L,150L,187L,237L,287L,364L,409L,459L,568L,620L,693L,810L,884L,960L,1084L,1183L,1277L,1433L,1545L,1627L,1789L,1942L,2045L,2203L,2348L,2504L,2691L,2843L,2996L,3153L,3362L,3561L,3711L,3913L,4118L,4348L,4550L,4724L,4969L,5196L,5415L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008208Inst : IEnumerable<long>
{
public static readonly long[] Value=A008208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008208.Bytes);
public long this[int i]=>Value[i];

public static A008208Inst Instance=new A008208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008207
{
public static readonly long[] Value={ 1L,4L,12L,20L,34L,57L,88L,125L,158L,192L,224L,292L,371L,421L,471L,537L,621L,714L,811L,883L,951L,1081L,1223L,1307L,1393L,1519L,1644L,1804L,1943L,2052L,2187L,2357L,2529L,2676L,2836L,2998L,3176L,3364L,3534L,3745L,3935L,4106L,4330L,4546L,4746L,4984L,5184L,5395L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008207Inst : IEnumerable<long>
{
public static readonly long[] Value=A008207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008207.Bytes);
public long this[int i]=>Value[i];

public static A008207Inst Instance=new A008207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008206
{
public static readonly long[] Value={ 1L,4L,12L,22L,38L,57L,86L,118L,152L,196L,245L,297L,346L,409L,485L,556L,630L,703L,789L,886L,994L,1078L,1170L,1298L,1428L,1537L,1654L,1783L,1914L,2079L,2211L,2349L,2513L,2674L,2843L,3001L,3176L,3364L,3548L,3724L,3917L,4138L,4342L,4535L,4744L,4959L,5200L,5448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008206Inst : IEnumerable<long>
{
public static readonly long[] Value=A008206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008206.Bytes);
public long this[int i]=>Value[i];

public static A008206Inst Instance=new A008206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008157
{
public static readonly long[] Value={ 1L,4L,12L,25L,42L,69L,100L,129L,176L,229L,277L,338L,404L,481L,556L,647L,731L,812L,930L,1036L,1120L,1255L,1388L,1501L,1640L,1796L,1919L,2071L,2254L,2389L,2564L,2764L,2919L,3096L,3310L,3508L,3676L,3915L,4141L,4325L,4581L,4821L,5030L,5281L,5546L,5782L,6026L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008157Inst : IEnumerable<long>
{
public static readonly long[] Value=A008157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008157.Bytes);
public long this[int i]=>Value[i];

public static A008157Inst Instance=new A008157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008156
{
public static readonly long[] Value={ 1L,4L,12L,21L,40L,63L,83L,124L,155L,197L,244L,289L,352L,410L,484L,544L,618L,697L,800L,872L,962L,1072L,1168L,1300L,1397L,1518L,1628L,1768L,1910L,2050L,2179L,2318L,2486L,2638L,2828L,2968L,3136L,3321L,3510L,3696L,3872L,4064L,4276L,4507L,4702L,4926L,5112L,5342L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008156Inst : IEnumerable<long>
{
public static readonly long[] Value=A008156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008156.Bytes);
public long this[int i]=>Value[i];

public static A008156Inst Instance=new A008156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008155
{
public static readonly long[] Value={ 1L,4L,11L,23L,38L,57L,88L,126L,158L,191L,236L,299L,363L,410L,462L,536L,621L,705L,790L,879L,976L,1076L,1169L,1266L,1383L,1521L,1660L,1786L,1902L,2017L,2159L,2342L,2511L,2646L,2792L,2959L,3146L,3327L,3497L,3684L,3882L,4096L,4295L,4471L,4680L,4907L,5140L,5374L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008155Inst : IEnumerable<long>
{
public static readonly long[] Value=A008155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008155.Bytes);
public long this[int i]=>Value[i];

public static A008155Inst Instance=new A008155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008154
{
public static readonly long[] Value={ 1L,4L,11L,22L,36L,57L,90L,127L,157L,194L,244L,299L,353L,403L,465L,552L,642L,707L,768L,854L,975L,1101L,1194L,1275L,1370L,1503L,1659L,1786L,1896L,2023L,2185L,2367L,2507L,2614L,2758L,2960L,3185L,3365L,3492L,3649L,3867L,4111L,4324L,4476L,4649L,4888L,5156L,5406L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008154Inst : IEnumerable<long>
{
public static readonly long[] Value=A008154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008154.Bytes);
public long this[int i]=>Value[i];

public static A008154Inst Instance=new A008154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008153
{
public static readonly long[] Value={ 1L,4L,12L,23L,38L,59L,87L,122L,158L,198L,243L,292L,352L,412L,473L,548L,624L,705L,789L,871L,965L,1073L,1184L,1291L,1392L,1509L,1644L,1768L,1906L,2043L,2182L,2337L,2486L,2644L,2800L,2966L,3146L,3330L,3507L,3690L,3879L,4076L,4290L,4484L,4693L,4909L,5131L,5372L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008153Inst : IEnumerable<long>
{
public static readonly long[] Value=A008153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008153.Bytes);
public long this[int i]=>Value[i];

public static A008153Inst Instance=new A008153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008152
{
public static readonly long[] Value={ 1L,4L,12L,23L,38L,62L,91L,116L,155L,203L,244L,291L,344L,417L,482L,546L,615L,704L,796L,878L,962L,1057L,1181L,1293L,1413L,1517L,1623L,1759L,1910L,2057L,2188L,2318L,2470L,2651L,2823L,2981L,3127L,3310L,3519L,3703L,3876L,4065L,4265L,4495L,4722L,4921L,5125L,5336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008152Inst : IEnumerable<long>
{
public static readonly long[] Value=A008152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008152.Bytes);
public long this[int i]=>Value[i];

public static A008152Inst Instance=new A008152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008151
{
public static readonly long[] Value={ 1L,4L,11L,23L,38L,61L,93L,121L,153L,198L,246L,296L,350L,412L,480L,544L,619L,706L,787L,880L,973L,1068L,1179L,1283L,1396L,1517L,1643L,1776L,1902L,2040L,2186L,2329L,2484L,2648L,2809L,2970L,3144L,3323L,3506L,3694L,3877L,4079L,4286L,4489L,4701L,4907L,5134L,5362L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008151Inst : IEnumerable<long>
{
public static readonly long[] Value=A008151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008151.Bytes);
public long this[int i]=>Value[i];

public static A008151Inst Instance=new A008151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008150
{
public static readonly long[] Value={ 1L,4L,12L,21L,36L,63L,88L,121L,153L,192L,249L,299L,354L,405L,467L,543L,629L,706L,789L,866L,969L,1088L,1170L,1280L,1379L,1514L,1668L,1781L,1890L,2017L,2178L,2355L,2501L,2633L,2788L,2956L,3164L,3349L,3492L,3664L,3873L,4092L,4312L,4486L,4668L,4899L,5142L,5387L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008150Inst : IEnumerable<long>
{
public static readonly long[] Value=A008150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008150.Bytes);
public long this[int i]=>Value[i];

public static A008150Inst Instance=new A008150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008149
{
public static readonly long[] Value={ 1L,4L,9L,18L,30L,39L,67L,98L,121L,147L,189L,234L,279L,319L,356L,412L,498L,555L,600L,678L,766L,836L,904L,1002L,1116L,1188L,1254L,1372L,1502L,1588L,1677L,1809L,1941L,2070L,2197L,2315L,2455L,2589L,2724L,2877L,3024L,3175L,3353L,3511L,3651L,3819L,4011L,4176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008149Inst : IEnumerable<long>
{
public static readonly long[] Value=A008149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008149.Bytes);
public long this[int i]=>Value[i];

public static A008149Inst Instance=new A008149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008148
{
public static readonly long[] Value={ 1L,4L,10L,16L,26L,46L,66L,94L,114L,158L,194L,222L,262L,334L,384L,404L,464L,564L,634L,670L,748L,826L,934L,1002L,1092L,1160L,1280L,1378L,1504L,1566L,1710L,1816L,1956L,2024L,2206L,2328L,2464L,2542L,2748L,2876L,3052L,3132L,3364L,3492L,3688L,3798L,4028L,4152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008148Inst : IEnumerable<long>
{
public static readonly long[] Value=A008148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008148.Bytes);
public long this[int i]=>Value[i];

public static A008148Inst Instance=new A008148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008147
{
public static readonly long[] Value={ 1L,4L,10L,17L,30L,46L,67L,91L,123L,153L,190L,226L,274L,319L,373L,424L,480L,544L,616L,689L,752L,834L,917L,1005L,1081L,1179L,1277L,1388L,1475L,1590L,1702L,1823L,1933L,2061L,2181L,2317L,2452L,2591L,2727L,2876L,3022L,3180L,3340L,3497L,3667L,3827L,4001L,4172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008147Inst : IEnumerable<long>
{
public static readonly long[] Value=A008147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008147.Bytes);
public long this[int i]=>Value[i];

public static A008147Inst Instance=new A008147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008146
{
public static readonly long[] Value={ 1L,4L,9L,18L,30L,46L,63L,94L,125L,152L,183L,232L,277L,315L,363L,433L,484L,536L,616L,688L,757L,829L,918L,1003L,1087L,1177L,1289L,1371L,1475L,1595L,1710L,1798L,1939L,2071L,2184L,2307L,2449L,2600L,2739L,2853L,3023L,3198L,3334L,3489L,3671L,3834L,3987L,4176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008146Inst : IEnumerable<long>
{
public static readonly long[] Value=A008146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008146.Bytes);
public long this[int i]=>Value[i];

public static A008146Inst Instance=new A008146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008145
{
public static readonly long[] Value={ 1L,4L,10L,21L,36L,53L,74L,104L,138L,174L,212L,255L,302L,349L,408L,474L,542L,610L,680L,755L,836L,923L,1014L,1110L,1206L,1308L,1410L,1521L,1644L,1767L,1892L,2016L,2142L,2270L,2408L,2559L,2716L,2871L,3026L,3186L,3346L,3512L,3688L,3871L,4056L,4237L,4420L,4612L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008145Inst : IEnumerable<long>
{
public static readonly long[] Value=A008145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008145.Bytes);
public long this[int i]=>Value[i];

public static A008145Inst Instance=new A008145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008144
{
public static readonly long[] Value={ 1L,4L,10L,20L,35L,54L,78L,104L,134L,171L,210L,255L,303L,355L,413L,472L,535L,605L,680L,758L,838L,923L,1016L,1107L,1202L,1311L,1418L,1525L,1640L,1759L,1883L,2009L,2143L,2284L,2420L,2563L,2714L,2860L,3017L,3185L,3348L,3516L,3691L,3869L,4048L,4232L,4432L,4627L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008144Inst : IEnumerable<long>
{
public static readonly long[] Value=A008144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008144.Bytes);
public long this[int i]=>Value[i];

public static A008144Inst Instance=new A008144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008143
{
public static readonly long[] Value={ 1L,4L,9L,17L,30L,49L,72L,97L,125L,158L,197L,242L,291L,342L,398L,462L,532L,602L,669L,739L,816L,899L,988L,1082L,1181L,1283L,1388L,1499L,1615L,1737L,1867L,2006L,2150L,2293L,2434L,2574L,2715L,2856L,2999L,3150L,3312L,3484L,3661L,3842L,4027L,4214L,4403L,4597L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008143Inst : IEnumerable<long>
{
public static readonly long[] Value=A008143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008143.Bytes);
public long this[int i]=>Value[i];

public static A008143Inst Instance=new A008143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008142
{
public static readonly long[] Value={ 1L,4L,10L,20L,33L,50L,71L,97L,129L,163L,200L,240L,287L,343L,401L,461L,523L,591L,665L,741L,822L,905L,990L,1080L,1178L,1285L,1394L,1505L,1621L,1744L,1872L,2001L,2135L,2275L,2420L,2566L,2712L,2861L,3013L,3171L,3332L,3494L,3659L,3832L,4019L,4212L,4407L,4606L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008142Inst : IEnumerable<long>
{
public static readonly long[] Value=A008142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008142.Bytes);
public long this[int i]=>Value[i];

public static A008142Inst Instance=new A008142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008125
{
public static readonly long[] Value={ 1L,4L,10L,19L,32L,52L,74L,99L,126L,162L,203L,240L,282L,337L,394L,444L,503L,574L,646L,715L,787L,872L,962L,1048L,1135L,1235L,1340L,1442L,1549L,1661L,1780L,1901L,2023L,2151L,2286L,2422L,2558L,2706L,2856L,3004L,3159L,3322L,3488L,3652L,3822L,4001L,4184L,4363L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008125Inst : IEnumerable<long>
{
public static readonly long[] Value=A008125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008125.Bytes);
public long this[int i]=>Value[i];

public static A008125Inst Instance=new A008125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008124
{
public static readonly long[] Value={ 1L,4L,10L,20L,33L,51L,74L,99L,128L,161L,199L,243L,288L,333L,386L,449L,511L,571L,638L,715L,796L,874L,954L,1044L,1142L,1239L,1336L,1439L,1549L,1665L,1781L,1898L,2022L,2153L,2286L,2421L,2561L,2704L,2853L,3007L,3162L,3320L,3484L,3654L,3826L,4000L,4179L,4365L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008124Inst : IEnumerable<long>
{
public static readonly long[] Value=A008124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008124.Bytes);
public long this[int i]=>Value[i];

public static A008124Inst Instance=new A008124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008123
{
public static readonly long[] Value={ 1L,4L,9L,17L,29L,45L,64L,86L,112L,141L,173L,209L,249L,292L,338L,388L,441L,497L,557L,621L,688L,758L,832L,909L,989L,1073L,1161L,1252L,1346L,1444L,1545L,1649L,1757L,1869L,1984L,2102L,2224L,2349L,2477L,2609L,2745L,2884L,3026L,3172L,3321L,3473L,3629L,3789L,3952L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008123Inst : IEnumerable<long>
{
public static readonly long[] Value=A008123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008123.Bytes);
public long this[int i]=>Value[i];

public static A008123Inst Instance=new A008123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008122
{
public static readonly long[] Value={ 1L,4L,12L,24L,36L,56L,86L,118L,146L,176L,228L,286L,330L,376L,438L,518L,588L,650L,732L,818L,906L,998L,1100L,1206L,1292L,1402L,1542L,1668L,1770L,1874L,2036L,2204L,2322L,2442L,2598L,2788L,2948L,3084L,3260L,3440L,3618L,3800L,3996L,4196L,4356L,4556L,4806L,5026L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008122Inst : IEnumerable<long>
{
public static readonly long[] Value=A008122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008122.Bytes);
public long this[int i]=>Value[i];

public static A008122Inst Instance=new A008122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008121
{
public static readonly long[] Value={ 1L,4L,10L,21L,39L,61L,81L,107L,148L,192L,228L,266L,324L,393L,449L,503L,575L,659L,738L,814L,906L,1002L,1090L,1191L,1311L,1427L,1521L,1629L,1780L,1926L,2036L,2148L,2308L,2487L,2625L,2753L,2919L,3105L,3274L,3432L,3618L,3808L,3978L,4169L,4391L,4601L,4769L,4959L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008121Inst : IEnumerable<long>
{
public static readonly long[] Value=A008121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008121.Bytes);
public long this[int i]=>Value[i];

public static A008121Inst Instance=new A008121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008120
{
public static readonly long[] Value={ 1L,4L,12L,18L,34L,62L,88L,110L,132L,196L,254L,278L,312L,382L,486L,540L,574L,652L,754L,868L,938L,1008L,1116L,1228L,1364L,1466L,1562L,1680L,1808L,1992L,2126L,2216L,2348L,2526L,2750L,2878L,2978L,3156L,3364L,3600L,3744L,3878L,4086L,4304L,4564L,4740L,4900L,5116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008120Inst : IEnumerable<long>
{
public static readonly long[] Value=A008120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008120.Bytes);
public long this[int i]=>Value[i];

public static A008120Inst Instance=new A008120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008119
{
public static readonly long[] Value={ 1L,4L,11L,21L,35L,61L,89L,111L,146L,194L,243L,281L,322L,398L,474L,531L,586L,662L,767L,854L,934L,1024L,1122L,1243L,1353L,1464L,1572L,1685L,1837L,1980L,2112L,2231L,2365L,2554L,2725L,2869L,3003L,3171L,3391L,3574L,3737L,3906L,4099L,4334L,4540L,4735L,4923L,5127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008119Inst : IEnumerable<long>
{
public static readonly long[] Value=A008119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008119.Bytes);
public long this[int i]=>Value[i];

public static A008119Inst Instance=new A008119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008118
{
public static readonly long[] Value={ 1L,4L,10L,19L,37L,58L,84L,109L,149L,201L,236L,274L,328L,399L,474L,521L,585L,670L,767L,861L,923L,1011L,1130L,1248L,1363L,1448L,1563L,1697L,1836L,1989L,2097L,2221L,2381L,2555L,2732L,2844L,2996L,3194L,3391L,3583L,3715L,3893L,4116L,4336L,4556L,4707L,4909L,5153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008118Inst : IEnumerable<long>
{
public static readonly long[] Value=A008118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008118.Bytes);
public long this[int i]=>Value[i];

public static A008118Inst Instance=new A008118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008117
{
public static readonly long[] Value={ 1L,4L,11L,23L,39L,55L,82L,127L,158L,178L,221L,291L,361L,393L,434L,519L,619L,698L,741L,821L,936L,1047L,1152L,1224L,1323L,1453L,1595L,1734L,1822L,1932L,2087L,2271L,2435L,2523L,2654L,2852L,3066L,3240L,3341L,3504L,3735L,3964L,4158L,4291L,4477L,4718L,4975L,5210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008117Inst : IEnumerable<long>
{
public static readonly long[] Value=A008117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008117.Bytes);
public long this[int i]=>Value[i];

public static A008117Inst Instance=new A008117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008116
{
public static readonly long[] Value={ 1L,4L,10L,20L,34L,62L,85L,104L,148L,201L,241L,274L,323L,400L,471L,531L,582L,661L,774L,859L,928L,1011L,1120L,1254L,1358L,1460L,1564L,1682L,1841L,1985L,2112L,2221L,2361L,2567L,2725L,2859L,2996L,3173L,3404L,3577L,3730L,3892L,4094L,4351L,4545L,4728L,4909L,5127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008116Inst : IEnumerable<long>
{
public static readonly long[] Value=A008116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008116.Bytes);
public long this[int i]=>Value[i];

public static A008116Inst Instance=new A008116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008115
{
public static readonly long[] Value={ 1L,4L,10L,20L,34L,52L,78L,110L,140L,176L,212L,258L,320L,366L,418L,488L,546L,618L,710L,772L,850L,964L,1038L,1132L,1262L,1332L,1440L,1596L,1676L,1792L,1964L,2050L,2184L,2384L,2468L,2610L,2838L,2926L,3080L,3324L,3410L,3582L,3860L,3948L,4124L,4424L,4514L,4712L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008115Inst : IEnumerable<long>
{
public static readonly long[] Value=A008115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008115.Bytes);
public long this[int i]=>Value[i];

public static A008115Inst Instance=new A008115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008114
{
public static readonly long[] Value={ 1L,4L,10L,20L,34L,58L,82L,102L,136L,176L,220L,266L,306L,362L,428L,484L,550L,626L,694L,778L,868L,942L,1042L,1146L,1230L,1350L,1468L,1554L,1684L,1822L,1926L,2072L,2214L,2322L,2494L,2654L,2764L,2950L,3126L,3246L,3450L,3638L,3762L,3984L,4188L,4322L,4566L,4778L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008114Inst : IEnumerable<long>
{
public static readonly long[] Value=A008114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008114.Bytes);
public long this[int i]=>Value[i];

public static A008114Inst Instance=new A008114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008113
{
public static readonly long[] Value={ 1L,4L,9L,19L,36L,56L,76L,106L,142L,172L,217L,265L,306L,367L,426L,480L,554L,626L,690L,779L,868L,940L,1046L,1146L,1227L,1352L,1462L,1554L,1695L,1818L,1918L,2075L,2215L,2321L,2497L,2650L,2762L,2958L,3121L,3242L,3457L,3632L,3760L,3993L,4184L,4317L,4570L,4774L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008113Inst : IEnumerable<long>
{
public static readonly long[] Value=A008113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008113.Bytes);
public long this[int i]=>Value[i];

public static A008113Inst Instance=new A008113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008112
{
public static readonly long[] Value={ 1L,4L,10L,20L,36L,55L,77L,108L,140L,174L,219L,263L,309L,368L,423L,480L,555L,623L,690L,782L,865L,942L,1050L,1144L,1230L,1355L,1459L,1554L,1696L,1813L,1918L,2078L,2210L,2323L,2502L,2647L,2766L,2963L,3117L,3243L,3460L,3626L,3759L,3996L,4178L,4318L,4575L,4770L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008112Inst : IEnumerable<long>
{
public static readonly long[] Value=A008112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008112.Bytes);
public long this[int i]=>Value[i];

public static A008112Inst Instance=new A008112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008111
{
public static readonly long[] Value={ 1L,4L,9L,19L,36L,56L,80L,102L,132L,180L,220L,260L,310L,359L,423L,496L,548L,613L,707L,772L,853L,967L,1033L,1125L,1259L,1338L,1446L,1593L,1670L,1792L,1972L,2052L,2178L,2381L,2470L,2613L,2833L,2919L,3079L,3330L,3416L,3582L,3856L,3941L,4125L,4434L,4518L,4705L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008111Inst : IEnumerable<long>
{
public static readonly long[] Value=A008111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008111.Bytes);
public long this[int i]=>Value[i];

public static A008111Inst Instance=new A008111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008110
{
public static readonly long[] Value={ 1L,4L,9L,17L,29L,45L,65L,89L,116L,144L,175L,213L,256L,300L,346L,397L,452L,509L,570L,636L,705L,777L,853L,932L,1013L,1098L,1189L,1284L,1381L,1480L,1582L,1689L,1801L,1916L,2033L,2154L,2280L,2408L,2538L,2673L,2813L,2956L,3102L,3252L,3404L,3558L,3718L,3884L,4052L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008110Inst : IEnumerable<long>
{
public static readonly long[] Value=A008110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008110.Bytes);
public long this[int i]=>Value[i];

public static A008110Inst Instance=new A008110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008093
{
public static readonly long[] Value={ 1L,4L,9L,17L,30L,50L,75L,98L,118L,144L,185L,238L,288L,326L,360L,408L,479L,560L,631L,687L,743L,817L,910L,1009L,1101L,1185L,1271L,1367L,1474L,1588L,1705L,1822L,1936L,2050L,2172L,2307L,2451L,2593L,2728L,2863L,3010L,3172L,3337L,3494L,3647L,3810L,3990L,4177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008093Inst : IEnumerable<long>
{
public static readonly long[] Value=A008093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008093.Bytes);
public long this[int i]=>Value[i];

public static A008093Inst Instance=new A008093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008092
{
public static readonly long[] Value={ 1L,4L,12L,20L,39L,66L,90L,118L,164L,214L,245L,292L,373L,443L,487L,546L,660L,753L,803L,888L,1032L,1142L,1198L,1313L,1486L,1607L,1677L,1813L,2027L,2164L,2229L,2389L,2649L,2801L,2862L,3056L,3351L,3516L,3577L,3795L,4138L,4315L,4370L,4621L,5017L,5183L,5231L,5537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008092Inst : IEnumerable<long>
{
public static readonly long[] Value=A008092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008092.Bytes);
public long this[int i]=>Value[i];

public static A008092Inst Instance=new A008092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008091
{
public static readonly long[] Value={ 1L,4L,12L,22L,37L,64L,94L,119L,161L,204L,252L,304L,366L,430L,488L,564L,657L,736L,805L,904L,1033L,1123L,1198L,1331L,1487L,1588L,1678L,1835L,2024L,2138L,2231L,2424L,2646L,2765L,2863L,3094L,3353L,3473L,3582L,3836L,4136L,4275L,4370L,4665L,5011L,5147L,5238L,5576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008091Inst : IEnumerable<long>
{
public static readonly long[] Value=A008091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008091.Bytes);
public long this[int i]=>Value[i];

public static A008091Inst Instance=new A008091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008090
{
public static readonly long[] Value={ 1L,4L,11L,24L,42L,63L,93L,127L,160L,206L,262L,308L,356L,429L,510L,572L,634L,731L,846L,919L,983L,1117L,1263L,1340L,1424L,1589L,1753L,1846L,1944L,2129L,2334L,2442L,2535L,2758L,3001L,3105L,3206L,3468L,3748L,3867L,3959L,4244L,4583L,4701L,4778L,5127L,5510L,5599L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008090Inst : IEnumerable<long>
{
public static readonly long[] Value=A008090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008090.Bytes);
public long this[int i]=>Value[i];

public static A008090Inst Instance=new A008090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008089
{
public static readonly long[] Value={ 1L,4L,9L,16L,25L,37L,53L,73L,96L,120L,145L,174L,210L,251L,292L,331L,371L,418L,475L,539L,602L,659L,713L,772L,843L,925L,1011L,1093L,1168L,1241L,1321L,1415L,1520L,1625L,1722L,1813L,1908L,2015L,2133L,2254L,2371L,2486L,2606L,2732L,2860L,2988L,3120L,3261L,3410L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008089Inst : IEnumerable<long>
{
public static readonly long[] Value=A008089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008089.Bytes);
public long this[int i]=>Value[i];

public static A008089Inst Instance=new A008089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008088
{
public static readonly long[] Value={ 1L,4L,9L,16L,25L,37L,53L,73L,97L,124L,152L,180L,210L,245L,287L,336L,388L,437L,481L,526L,581L,648L,722L,797L,866L,929L,993L,1066L,1153L,1249L,1347L,1439L,1522L,1604L,1695L,1802L,1920L,2039L,2152L,2257L,2361L,2472L,2596L,2732L,2873L,3013L,3146L,3271L,3396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008088Inst : IEnumerable<long>
{
public static readonly long[] Value=A008088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008088.Bytes);
public long this[int i]=>Value[i];

public static A008088Inst Instance=new A008088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008087
{
public static readonly long[] Value={ 1L,4L,9L,16L,25L,37L,53L,73L,96L,121L,148L,179L,214L,252L,294L,338L,382L,427L,477L,534L,595L,657L,718L,779L,846L,923L,1006L,1087L,1165L,1245L,1330L,1421L,1517L,1615L,1714L,1815L,1918L,2023L,2131L,2247L,2370L,2494L,2616L,2737L,2863L,2995L,3132L,3271L,3410L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008087Inst : IEnumerable<long>
{
public static readonly long[] Value=A008087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008087.Bytes);
public long this[int i]=>Value[i];

public static A008087Inst Instance=new A008087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008086
{
public static readonly long[] Value={ 1L,4L,9L,16L,25L,37L,53L,73L,96L,121L,148L,178L,212L,250L,291L,335L,381L,428L,479L,534L,591L,651L,716L,784L,854L,928L,1003L,1078L,1158L,1244L,1335L,1430L,1523L,1613L,1706L,1806L,1914L,2029L,2145L,2256L,2366L,2480L,2600L,2731L,2870L,3008L,3139L,3266L,3399L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008086Inst : IEnumerable<long>
{
public static readonly long[] Value=A008086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008086.Bytes);
public long this[int i]=>Value[i];

public static A008086Inst Instance=new A008086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008085
{
public static readonly long[] Value={ 1L,4L,8L,18L,32L,52L,74L,100L,128L,162L,204L,244L,286L,340L,396L,450L,512L,580L,650L,724L,800L,882L,972L,1060L,1150L,1252L,1356L,1458L,1568L,1684L,1802L,1924L,2048L,2178L,2316L,2452L,2590L,2740L,2892L,3042L,3200L,3364L,3530L,3700L,3872L,4050L,4236L,4420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008085Inst : IEnumerable<long>
{
public static readonly long[] Value=A008085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008085.Bytes);
public long this[int i]=>Value[i];

public static A008085Inst Instance=new A008085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008084
{
public static readonly long[] Value={ 1L,4L,9L,19L,35L,52L,72L,100L,131L,163L,201L,244L,290L,340L,393L,451L,515L,580L,648L,724L,803L,883L,969L,1060L,1154L,1252L,1353L,1459L,1571L,1684L,1800L,1924L,2051L,2179L,2313L,2452L,2594L,2740L,2889L,3043L,3203L,3364L,3528L,3700L,3875L,4051L,4233L,4420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008084Inst : IEnumerable<long>
{
public static readonly long[] Value=A008084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008084.Bytes);
public long this[int i]=>Value[i];

public static A008084Inst Instance=new A008084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008083
{
public static readonly long[] Value={ 1L,4L,10L,20L,32L,46L,66L,94L,128L,162L,192L,222L,262L,318L,382L,440L,488L,536L,598L,678L,766L,848L,920L,992L,1076L,1174L,1280L,1386L,1488L,1588L,1692L,1806L,1930L,2060L,2190L,2316L,2442L,2576L,2722L,2874L,3024L,3172L,3324L,3486L,3656L,3826L,3992L,4160L,4340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008083Inst : IEnumerable<long>
{
public static readonly long[] Value=A008083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008083.Bytes);
public long this[int i]=>Value[i];

public static A008083Inst Instance=new A008083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008082
{
public static readonly long[] Value={ 1L,4L,9L,17L,30L,49L,71L,92L,115L,147L,190L,238L,283L,323L,363L,413L,479L,554L,624L,684L,745L,820L,910L,1006L,1099L,1187L,1274L,1367L,1471L,1585L,1703L,1819L,1933L,2050L,2175L,2309L,2449L,2590L,2728L,2866L,3012L,3169L,3330L,3488L,3647L,3815L,3993L,4174L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008082Inst : IEnumerable<long>
{
public static readonly long[] Value=A008082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008082.Bytes);
public long this[int i]=>Value[i];

public static A008082Inst Instance=new A008082Inst();

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