using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A088263
{
public static readonly long[] Value={ 11L,13L,37L,79L,911L,1213L,2417L,1619L,2521L,1823L,3727L,3329L,2731L,3833L,4637L,4339L,5741L,5843L,5347L,6949L,5651L,6353L,5657L,7459L,8461L,8363L,8467L,9769L,10771L,9173L,10177L,10979L,11681L,11483L,11087L,11789L,12391L,13093L,12697L,13499L,182101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088263Inst : IEnumerable<long>
{
public static readonly long[] Value=A088263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088263.Bytes);
public long this[int i]=>Value[i];

public static A088263Inst Instance=new A088263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088264
{
public static readonly long[] Value={ 1L,189L,8L,94L,156L,32L,34L,18L,14L,1L,1653L,101L,2764L,99L,326L,715L,144L,1322L,4300L,768L,122L,67L,72L,500L,427L,3L,77L,22L,285L,119L,25L,294L,632L,55L,51L,3974L,217L,1230L,1022L,346L,1461L,260L,19L,9L,536L,463L,3L,299L,1L,69L,539L,1285L,1833L,116L,397L,3951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088264Inst : IEnumerable<long>
{
public static readonly long[] Value=A088264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088264.Bytes);
public long this[int i]=>Value[i];

public static A088264Inst Instance=new A088264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088265
{
public static readonly long[] Value={ 11L,13L,17L,19L,101L,103L,107L,109L,1001L,1003L,1007L,1009L,10001L,10003L,10007L,10009L,100001L,100003L,100007L,100009L,1000001L,1000003L,1000007L,1000009L,10000001L,10000003L,10000007L,10000009L,100000001L,100000003L,100000007L,100000009L,1000000001L,1000000003L,1000000007L,1000000009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088265Inst : IEnumerable<long>
{
public static readonly long[] Value=A088265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088265.Bytes);
public long this[int i]=>Value[i];

public static A088265Inst Instance=new A088265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088266
{
public static readonly long[] Value={ 2L,3L,3L,189L,210L,31296L,105441L,105441L,46814571L,665216481L,111581348556L,1199096907504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088266Inst : IEnumerable<long>
{
public static readonly long[] Value=A088266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088266.Bytes);
public long this[int i]=>Value[i];

public static A088266Inst Instance=new A088266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088267
{
public static readonly long[] Value={ 2L,1L,3L,4L,5L,1L,5L,1L,2L,1L,6L,9L,18L,9L,5L,4L,2L,7L,3L,1L,6L,3L,11L,9L,20L,6L,32L,16L,11L,13L,11L,1L,6L,15L,6L,21L,18L,1L,5L,13L,14L,1L,6L,18L,15L,9L,12L,3L,50L,19L,56L,12L,9L,3L,5L,66L,27L,1L,8L,24L,11L,9L,11L,13L,24L,79L,3L,43L,26L,19L,11L,4L,39L,3L,45L,9L,11L,6L,6L,15L,2L,1L,41L,18L,5L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088267Inst : IEnumerable<long>
{
public static readonly long[] Value=A088267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088267.Bytes);
public long this[int i]=>Value[i];

public static A088267Inst Instance=new A088267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088268
{
public static readonly long[] Value={ 5L,11L,101L,191L,16061L,1748471L,179868971L,11027472011L,13160106131L,15130003151L,15843234851L,16420302461L,16782228761L,16861316861L,17060706071L,17374347371L,18491419481L,18697979681L,19497279491L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088268Inst : IEnumerable<long>
{
public static readonly long[] Value=A088268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088268.Bytes);
public long this[int i]=>Value[i];

public static A088268Inst Instance=new A088268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088269
{
public static readonly long[] Value={ 3L,5L,131L,383L,797L,11411L,16061L,16361L,19391L,33533L,36263L,73037L,75557L,79397L,1074701L,1126211L,1145411L,1175711L,1221221L,1243421L,1287821L,1303031L,1311131L,1328231L,1363631L,1489841L,1579751L,1600061L,1707071L,1748471L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088269Inst : IEnumerable<long>
{
public static readonly long[] Value=A088269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088269.Bytes);
public long this[int i]=>Value[i];

public static A088269Inst Instance=new A088269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088270
{
public static readonly long[] Value={ 5L,7L,101L,151L,353L,727L,757L,929L,10301L,10601L,12721L,15551L,16061L,16661L,18181L,19391L,19891L,30403L,30703L,31013L,31513L,35353L,36263L,36563L,38083L,39293L,72227L,73237L,76367L,77377L,77477L,78487L,79397L,79997L,93139L,94649L,94849L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088270Inst : IEnumerable<long>
{
public static readonly long[] Value=A088270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088270.Bytes);
public long this[int i]=>Value[i];

public static A088270Inst Instance=new A088270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088271
{
public static readonly long[] Value={ 2L,5L,131L,191L,797L,11411L,15551L,30203L,31013L,32423L,36263L,36563L,38183L,39293L,72227L,74747L,77477L,94349L,94949L,1003001L,1055501L,1074701L,1085801L,1120211L,1123211L,1153511L,1178711L,1183811L,1221221L,1311131L,1317131L,1363631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088271Inst : IEnumerable<long>
{
public static readonly long[] Value=A088271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088271.Bytes);
public long this[int i]=>Value[i];

public static A088271Inst Instance=new A088271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088272
{
public static readonly long[] Value={ 2L,101L,313L,373L,757L,787L,10301L,12721L,12821L,17471L,17971L,19991L,32423L,35153L,35753L,37573L,72727L,73237L,77977L,78787L,78887L,90709L,93139L,93239L,97879L,1035301L,1117111L,1120211L,1129211L,1134311L,1178711L,1183811L,1186811L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088272Inst : IEnumerable<long>
{
public static readonly long[] Value=A088272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088272.Bytes);
public long this[int i]=>Value[i];

public static A088272Inst Instance=new A088272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088273
{
public static readonly long[] Value={ 1L,2L,5L,6L,11L,17L,18L,39L,56L,101L,105L,107L,123L,413L,426L,2607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088273Inst : IEnumerable<long>
{
public static readonly long[] Value=A088273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088273.Bytes);
public long this[int i]=>Value[i];

public static A088273Inst Instance=new A088273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088274
{
public static readonly long[] Value={ 1L,2L,4L,8L,9L,24L,60L,110L,134L,222L,412L,700L,999L,1383L,5076L,5543L,6344L,14600L,15093L,21717L,23636L,30221L,50711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088274Inst : IEnumerable<long>
{
public static readonly long[] Value=A088274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088274.Bytes);
public long this[int i]=>Value[i];

public static A088274Inst Instance=new A088274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088275
{
public static readonly long[] Value={ 1L,2L,3L,4L,9L,18L,22L,45L,49L,56L,69L,146L,202L,272L,2730L,2841L,4562L,31810L,43186L,48109L,92691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088275Inst : IEnumerable<long>
{
public static readonly long[] Value=A088275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088275.Bytes);
public long this[int i]=>Value[i];

public static A088275Inst Instance=new A088275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088308
{
public static readonly long[] Value={ 2L,4L,6L,8L,9L,0L,2L,4L,5L,6L,8L,0L,1L,2L,4L,5L,6L,7L,8L,0L,2L,3L,4L,5L,6L,8L,9L,0L,2L,4L,5L,6L,8L,9L,0L,1L,2L,4L,5L,6L,7L,8L,0L,2L,3L,4L,5L,6L,8L,9L,0L,2L,4L,5L,6L,7L,8L,0L,1L,2L,4L,5L,6L,7L,8L,0L,1L,2L,3L,4L,5L,6L,8L,9L,0L,2L,4L,5L,6L,8L,0L,1L,2L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,4L,5L,6L,8L,9L,0L,2L,3L,4L,5L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088308Inst : IEnumerable<long>
{
public static readonly long[] Value=A088308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088308.Bytes);
public long this[int i]=>Value[i];

public static A088308Inst Instance=new A088308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088309
{
public static readonly BigInteger[] Value={ 1L,2L,5L,44L,1411L,159656L,62055868L,82060884560L,371036717493194L,5812014504668066528L,BigInteger.Parse("320454239459072905856944"),BigInteger.Parse("63156145369562679089674952768"),BigInteger.Parse("45090502574837184532027563736271152"),BigInteger.Parse("117910805393665959622047902193019284914432"),BigInteger.Parse("1139353529410754170844431642119963019965901238144") };
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
public class A088309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088309Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088309.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A088309.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088309Inst Instance=new A088309Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088310
{
public static readonly BigInteger[] Value={ 1L,2L,10L,264L,33864L,19158720L,44680224960L,413586858182400L,14960200449325582080UL,BigInteger.Parse("2109063823453947981680640"),BigInteger.Parse("1162864344149083760773678387200"),BigInteger.Parse("2520991223487759548686737154649702400"),BigInteger.Parse("21598422878151131130336454273775859841843200"),BigInteger.Parse("734233037731110118818452425552296701963294284185600") };
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
public class A088310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088310Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088310.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A088310.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088310Inst Instance=new A088310Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088311
{
public static readonly long[] Value={ 1L,1L,2L,12L,48L,360L,2880L,25200L,241920L,2903040L,36288000L,479001600L,7185024000L,112086374400L,1917922406400L,35307207936000L,669529276416000L,13516122267648000L,294509190463488000L,6568835422076928000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088311Inst : IEnumerable<long>
{
public static readonly long[] Value=A088311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088311.Bytes);
public long this[int i]=>Value[i];

public static A088311Inst Instance=new A088311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088312
{
public static readonly BigInteger[] Value={ 1L,0L,1L,6L,37L,260L,2101L,19362L,201097L,2326536L,29668681L,413257790L,6238931821L,101415565836L,1765092183037L,32734873484250L,644215775792401L,13404753632014352L,293976795292186897L,6775966692145553526L,BigInteger.Parse("163735077313046119861"),BigInteger.Parse("4138498600079573989140") };
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
public class A088312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088312Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088312.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A088312.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088312Inst Instance=new A088312Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088313
{
public static readonly BigInteger[] Value={ 0L,1L,2L,7L,36L,241L,1950L,18271L,193256L,2270017L,29272410L,410815351L,6231230412L,101560835377L,1769925341366L,32838929702671L,646218442877520L,13441862819232001L,294656673023216946L,6788407001443004647L,BigInteger.Parse("163962850573039534580"),BigInteger.Parse("4142654439686285737201") };
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
public class A088313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088313Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088313.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A088313.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088313Inst Instance=new A088313Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088314
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,6L,10L,12L,18L,22L,30L,37L,51L,61L,79L,96L,124L,148L,186L,222L,275L,326L,400L,473L,575L,673L,811L,946L,1132L,1317L,1558L,1813L,2138L,2463L,2893L,3323L,3882L,4461L,5177L,5917L,6847L,7818L,8994L,10251L,11766L,13334L,15281L,17309L,19732L,22307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088314Inst : IEnumerable<long>
{
public static readonly long[] Value=A088314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088314.Bytes);
public long this[int i]=>Value[i];

public static A088314Inst Instance=new A088314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088315
{
public static readonly long[] Value={ 5L,13L,7L,11L,53L,29L,21L,29L,89L,19L,89L,75L,89L,77L,189L,59L,61L,103L,185L,203L,189L,95L,167L,253L,107L,187L,79L,37L,289L,173L,257L,43L,169L,135L,175L,179L,155L,291L,189L,311L,155L,141L,157L,449L,119L,129L,349L,131L,609L,383L,391L,429L,409L,839L,201L,371L,425L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088315Inst : IEnumerable<long>
{
public static readonly long[] Value=A088315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088315.Bytes);
public long this[int i]=>Value[i];

public static A088315Inst Instance=new A088315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088316
{
public static readonly long[] Value={ 2L,13L,171L,2236L,29239L,382343L,4999698L,65378417L,854919119L,11179326964L,146186169651L,1911599532427L,24996980091202L,326872340718053L,4274337409425891L,55893258663254636L,730886700031736159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088316Inst : IEnumerable<long>
{
public static readonly long[] Value=A088316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088316.Bytes);
public long this[int i]=>Value[i];

public static A088316Inst Instance=new A088316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088317
{
public static readonly long[] Value={ 1L,4L,33L,268L,2177L,17684L,143649L,1166876L,9478657L,76996132L,625447713L,5080577836L,41270070401L,335241141044L,2723199198753L,22120834731068L,179689877047297L,1459639851109444L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088317Inst : IEnumerable<long>
{
public static readonly long[] Value=A088317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088317.Bytes);
public long this[int i]=>Value[i];

public static A088317Inst Instance=new A088317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088318
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,2L,3L,5L,7L,10L,13L,18L,24L,32L,40L,51L,66L,83L,103L,128L,158L,194L,237L,288L,348L,419L,500L,612L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088318Inst : IEnumerable<long>
{
public static readonly long[] Value=A088318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088318.Bytes);
public long this[int i]=>Value[i];

public static A088318Inst Instance=new A088318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088319
{
public static readonly long[] Value={ 41L,205L,389L,689L,1565L,1625L,1781L,3865L,4105L,4549L,5989L,7421L,9161L,9685L,10225L,10685L,13025L,17509L,17965L,18329L,21349L,21701L,25801L,33161L,33169L,33529L,36749L,38581L,39709L,49325L,51649L,52429L,52721L,56785L,57065L,67205L,70801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088319Inst : IEnumerable<long>
{
public static readonly long[] Value=A088319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088319.Bytes);
public long this[int i]=>Value[i];

public static A088319Inst Instance=new A088319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088320
{
public static readonly long[] Value={ 1L,5L,51L,515L,5201L,52525L,530451L,5357035L,54100801L,546365045L,5517751251L,55723877555L,562756526801L,5683289145565L,57395647982451L,579639768970075L,5853793337683201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088320Inst : IEnumerable<long>
{
public static readonly long[] Value=A088320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088320.Bytes);
public long this[int i]=>Value[i];

public static A088320Inst Instance=new A088320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088321
{
public static readonly BigInteger[] Value={ 1L,2L,16L,4096L,4294967296L,BigInteger.Parse("1208925819614629174706176") };
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
public class A088321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088321Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088321.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A088321.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088321Inst Instance=new A088321Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088322
{
public static readonly BigInteger[] Value={ 1L,3L,36L,8000L,796594176L,BigInteger.Parse("25039893834551321901"),BigInteger.Parse("230156231509903526722108570920314496786496"),BigInteger.Parse("478651764962008689839230538296564128023598629748415103570025502338085999191479922367872") };
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
public class A088322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088322Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088322.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A088322.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088322Inst Instance=new A088322Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088323
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088323Inst : IEnumerable<long>
{
public static readonly long[] Value=A088323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088323.Bytes);
public long this[int i]=>Value[i];

public static A088323Inst Instance=new A088323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088356
{
public static readonly long[] Value={ 1L,1L,2L,5L,9L,23L,48L,113L,254L,581L,1332L,3038L,6979L,15955L,36616L,83861L,192325L,440833L,1010769L,2317433L,5313413L,12183136L,27934106L,64050992L,146862260L,336745545L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088356Inst : IEnumerable<long>
{
public static readonly long[] Value=A088356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088356.Bytes);
public long this[int i]=>Value[i];

public static A088356Inst Instance=new A088356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088357
{
public static readonly long[] Value={ 1L,1L,1L,3L,5L,11L,27L,55L,127L,285L,647L,1457L,3297L,7489L,16945L,38523L,87293L,198179L,449907L,1021135L,2318527L,5263581L,11950967L,27133985L,61609953L,139888777L,317629465L,721215027L,1637598485L,3718378619L,8443065363L,19171129327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088357Inst : IEnumerable<long>
{
public static readonly long[] Value=A088357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088357.Bytes);
public long this[int i]=>Value[i];

public static A088357Inst Instance=new A088357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088358
{
public static readonly BigInteger[] Value={ 1L,1L,3L,16L,127L,1321L,16680L,244518L,4049199L,74404069L,1498276873L,32764372213L,772675039936L,19541627299052L,527590805816280L,15146369004674536L,460804123171138079L,14811876349937896743UL,BigInteger.Parse("501663013214822053815"),BigInteger.Parse("17858867621856721343253"),BigInteger.Parse("666744417234185576463077") };
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
public class A088358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088358Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088358.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A088358.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088358Inst Instance=new A088358Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088359
{
public static readonly long[] Value={ 3L,5L,6L,9L,10L,11L,13L,17L,18L,19L,20L,22L,23L,25L,28L,33L,34L,35L,36L,37L,39L,40L,41L,43L,44L,46L,49L,50L,52L,55L,59L,65L,66L,67L,68L,69L,70L,72L,73L,74L,75L,77L,78L,79L,81L,82L,84L,87L,88L,89L,91L,92L,94L,97L,98L,100L,103L,107L,108L,110L,113L,117L,122L,129L,130L,131L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088359Inst : IEnumerable<long>
{
public static readonly long[] Value=A088359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088359.Bytes);
public long this[int i]=>Value[i];

public static A088359Inst Instance=new A088359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088360
{
public static readonly long[] Value={ 1L,824L,1476L,1632L,2462L,2484L,2520L,3064L,3402L,3820L,4026L,6640L,7026L,7158L,9070L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088360Inst : IEnumerable<long>
{
public static readonly long[] Value=A088360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088360.Bytes);
public long this[int i]=>Value[i];

public static A088360Inst Instance=new A088360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088361
{
public static readonly long[] Value={ 1L,150L,2558L,4650L,4772L,11272L,13236L,15048L,23302L,26946L,29504L,31614L,33308L,35054L,36702L,37062L,39020L,39056L,43738L,44174L,45654L,46502L,47348L,49190L,49204L,49544L,54514L,57210L,59770L,61184L,66894L,68194L,70574L,72446L,82642L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088361Inst : IEnumerable<long>
{
public static readonly long[] Value=A088361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088361.Bytes);
public long this[int i]=>Value[i];

public static A088361Inst Instance=new A088361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088362
{
public static readonly long[] Value={ 1L,1534L,7316L,17582L,18224L,28234L,34954L,41336L,48824L,51558L,51914L,57394L,61686L,62060L,89762L,96632L,98242L,100540L,101578L,109696L,110540L,114690L,125440L,125442L,127596L,138068L,144362L,154908L,157310L,161822L,161900L,166224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088362Inst : IEnumerable<long>
{
public static readonly long[] Value=A088362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088362.Bytes);
public long this[int i]=>Value[i];

public static A088362Inst Instance=new A088362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088363
{
public static readonly long[] Value={ 3L,1L,2L,15L,3L,13L,18L,17L,63L,38L,168L,10L,316L,240L,128L,30L,271L,408L,286L,255L,354L,362L,600L,260L,672L,138L,7L,768L,792L,876L,960L,513L,248L,1080L,546L,2328L,1248L,4008L,1392L,751L,2188L,250L,94L,1728L,3528L,3470L,1848L,2460L,3912L,4008L,3063L,2088L,1554L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088363Inst : IEnumerable<long>
{
public static readonly long[] Value=A088363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088363.Bytes);
public long this[int i]=>Value[i];

public static A088363Inst Instance=new A088363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088364
{
public static readonly long[] Value={ 1L,3L,6L,9L,13L,16L,19L,21L,26L,28L,30L,33L,37L,39L,43L,48L,50L,53L,56L,61L,63L,66L,68L,70L,73L,75L,78L,80L,82L,86L,90L,94L,96L,98L,102L,105L,108L,112L,115L,119L,124L,128L,132L,134L,136L,139L,141L,144L,146L,148L,150L,152L,156L,158L,160L,165L,168L,171L,173L,176L,180L,182L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088364Inst : IEnumerable<long>
{
public static readonly long[] Value=A088364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088364.Bytes);
public long this[int i]=>Value[i];

public static A088364Inst Instance=new A088364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088365
{
public static readonly long[] Value={ 4L,9L,17L,40L,74L,54L,151L,120L,307L,312L,199L,408L,356L,424L,912L,1032L,1217L,840L,1872L,423L,1608L,2518L,1588L,1920L,1230L,2112L,3713L,1560L,5208L,2832L,3952L,2872L,3192L,3288L,3432L,8400L,5738L,4080L,4272L,4512L,6288L,8280L,8520L,5232L,5352L,3672L,8892L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088365Inst : IEnumerable<long>
{
public static readonly long[] Value=A088365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088365.Bytes);
public long this[int i]=>Value[i];

public static A088365Inst Instance=new A088365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088366
{
public static readonly long[] Value={ 2L,5L,8L,11L,15L,18L,20L,25L,27L,29L,31L,36L,38L,42L,45L,49L,51L,54L,58L,62L,64L,67L,69L,71L,74L,76L,79L,81L,84L,89L,92L,95L,97L,99L,104L,106L,111L,113L,117L,122L,126L,130L,133L,135L,137L,140L,143L,145L,147L,149L,151L,154L,157L,159L,162L,167L,170L,172L,175L,179L,181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088366Inst : IEnumerable<long>
{
public static readonly long[] Value=A088366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088366.Bytes);
public long this[int i]=>Value[i];

public static A088366Inst Instance=new A088366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088367
{
public static readonly long[] Value={ 1L,7L,8L,2L,2L,1L,3L,9L,7L,8L,1L,9L,1L,3L,6L,9L,1L,1L,1L,7L,7L,4L,4L,1L,3L,4L,5L,2L,9L,7L,2L,5L,4L,9L,3L,4L,0L,7L,9L,1L,7L,3L,1L,9L,0L,9L,7L,7L,3L,2L,3L,9L,3L,8L,1L,0L,2L,4L,9L,5L,9L,9L,5L,6L,8L,8L,5L,1L,5L,4L,1L,2L,8L,7L,6L,3L,7L,8L,4L,0L,8L,0L,2L,4L,3L,1L,6L,7L,6L,6L,3L,5L,7L,8L,2L,5L,5L,3L,0L,8L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088367Inst : IEnumerable<long>
{
public static readonly long[] Value=A088367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088367.Bytes);
public long this[int i]=>Value[i];

public static A088367Inst Instance=new A088367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088368
{
public static readonly long[] Value={ 1L,1L,3L,13L,69L,421L,2867L,21477L,175769L,1567273L,15213955L,160727997L,1846282381L,23013527421L,310284575683L,4506744095141L,70199956070705L,1167389338452753L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088368Inst : IEnumerable<long>
{
public static readonly long[] Value=A088368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088368.Bytes);
public long this[int i]=>Value[i];

public static A088368Inst Instance=new A088368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088369
{
public static readonly long[] Value={ 1L,0L,2L,9L,44L,390L,3474L,37800L,471344L,6602904L,103271400L,1779944760L,33542915592L,686101244400L,15139184749584L,358465510133640L,9066087526045440L,243928110816129600L,6956913949298380224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088369Inst : IEnumerable<long>
{
public static readonly long[] Value=A088369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088369.Bytes);
public long this[int i]=>Value[i];

public static A088369Inst Instance=new A088369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088370
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,1L,3L,2L,4L,1L,5L,3L,2L,4L,1L,5L,3L,2L,6L,4L,1L,5L,3L,7L,2L,6L,4L,1L,5L,3L,7L,2L,6L,4L,8L,1L,9L,5L,3L,7L,2L,6L,4L,8L,1L,9L,5L,3L,7L,2L,10L,6L,4L,8L,1L,9L,5L,3L,11L,7L,2L,10L,6L,4L,8L,1L,9L,5L,3L,11L,7L,2L,10L,6L,4L,12L,8L,1L,9L,5L,13L,3L,11L,7L,2L,10L,6L,4L,12L,8L,1L,9L,5L,13L,3L,11L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088370Inst : IEnumerable<long>
{
public static readonly long[] Value=A088370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088370.Bytes);
public long this[int i]=>Value[i];

public static A088370Inst Instance=new A088370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088371
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,5L,4L,8L,2L,7L,5L,11L,4L,11L,8L,16L,2L,11L,7L,17L,5L,16L,11L,23L,4L,17L,11L,25L,8L,23L,16L,32L,2L,19L,11L,29L,7L,26L,17L,37L,5L,26L,16L,38L,11L,34L,23L,47L,4L,29L,17L,43L,11L,38L,25L,53L,8L,37L,23L,53L,16L,47L,32L,64L,2L,35L,19L,53L,11L,46L,29L,65L,7L,44L,26L,64L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088371Inst : IEnumerable<long>
{
public static readonly long[] Value=A088371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088371.Bytes);
public long this[int i]=>Value[i];

public static A088371Inst Instance=new A088371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088388
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,1L,1L,3L,2L,1L,1L,2L,1L,1L,1L,4L,1L,2L,1L,1L,1L,1L,1L,3L,2L,1L,3L,1L,1L,1L,1L,5L,1L,1L,1L,2L,1L,1L,1L,3L,1L,1L,1L,1L,2L,1L,1L,4L,2L,2L,1L,1L,1L,3L,1L,3L,1L,1L,1L,1L,1L,1L,2L,6L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,4L,4L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,5L,1L,2L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088388Inst : IEnumerable<long>
{
public static readonly long[] Value=A088388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088388.Bytes);
public long this[int i]=>Value[i];

public static A088388Inst Instance=new A088388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088389
{
public static readonly long[] Value={ 1L,3L,29L,940L,104286L,40050850L,53640013886L,251995529844792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088389Inst : IEnumerable<long>
{
public static readonly long[] Value=A088389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088389.Bytes);
public long this[int i]=>Value[i];

public static A088389Inst Instance=new A088389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088390
{
public static readonly long[] Value={ 6L,3L,47L,10L,324L,23L,1338L,3261L,2779L,2314L,13067L,526096L,4308L,43369732L,205883268L,418113170L,1636119595L,1938732984L,35048134702L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088390Inst : IEnumerable<long>
{
public static readonly long[] Value=A088390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088390.Bytes);
public long this[int i]=>Value[i];

public static A088390Inst Instance=new A088390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088391
{
public static readonly BigInteger[] Value={ 2L,1L,0L,5L,4L,0L,143L,25L,0L,2L,1L,0L,77L,715L,0L,125L,5882353L,0L,52631579L,1L,0L,5L,4347826087L,0L,8L,385L,0L,3575L,3448275862069L,0L,0L,625L,0L,29411765L,286L,0L,0L,263157895L,0L,5L,0L,0L,0L,25L,0L,21739130435L,BigInteger.Parse("2127659574468085106383"),0L };
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
public class A088391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088391Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088391.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A088391.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088391Inst Instance=new A088391Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088392
{
public static readonly long[] Value={ 3L,6L,1L,3L,6L,2L,3L,15L,0L,3L,0L,1L,777L,15L,2L,75L,6L,0L,579L,6L,1L,0L,87L,5L,12L,3885L,0L,75L,69L,1L,322581L,375L,0L,3L,6L,0L,3L,2895L,259L,3L,0L,5L,2327907L,0L,0L,435L,213L,25L,22449L,6L,2L,19425L,1887L,0L,0L,375L,193L,345L,339L,2L,1641L,1612905L,0L,1875L,1554L,0L,3L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088392Inst : IEnumerable<long>
{
public static readonly long[] Value=A088392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088392.Bytes);
public long this[int i]=>Value[i];

public static A088392Inst Instance=new A088392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088393
{
public static readonly long[] Value={ 4L,2L,0L,1L,8L,0L,16L,5L,0L,4L,2L,0L,1L,8L,0L,7L,59L,0L,58L,2L,0L,1L,44L,0L,16L,5L,0L,4L,38L,0L,1L,35L,0L,295L,32L,0L,0L,29L,0L,1L,0L,0L,7L,5L,0L,22L,6383L,0L,2449L,8L,0L,25L,18887L,0L,4L,2L,0L,19L,17L,0L,163951L,5L,0L,175L,2L,0L,14925403L,1475L,0L,16L,2831L,0L,274L,0L,0L,145L,26L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088393Inst : IEnumerable<long>
{
public static readonly long[] Value=A088393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088393.Bytes);
public long this[int i]=>Value[i];

public static A088393Inst Instance=new A088393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088394
{
public static readonly long[] Value={ 5L,7L,0L,8L,1L,0L,2L,4L,0L,5L,0L,0L,8L,1L,0L,2L,13L,0L,59L,7L,0L,0L,1L,0L,2L,4L,0L,5L,7L,0L,71L,1L,0L,65L,4L,0L,0L,79L,0L,8L,1L,0L,47L,0L,0L,5L,43L,0L,449L,1L,0L,2L,4L,0L,0L,25L,0L,35L,19L,0L,2L,355L,0L,5L,16L,0L,1493L,325L,0L,2L,31L,0L,14L,0L,0L,395L,0L,0L,38L,4L,0L,5L,241L,0L,26L,235L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088394Inst : IEnumerable<long>
{
public static readonly long[] Value=A088394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088394.Bytes);
public long this[int i]=>Value[i];

public static A088394Inst Instance=new A088394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088395
{
public static readonly long[] Value={ 6L,3L,2L,6L,3L,1L,6L,3L,0L,6L,3L,2L,24L,3L,1L,15L,3L,0L,6L,3L,2L,6L,48L,1L,6L,12L,0L,15L,39L,2L,33L,66L,1L,6L,3L,0L,6L,3L,8L,6L,3L,1L,24L,3L,0L,24L,3L,5L,249L,3L,1L,6L,21L,0L,6L,75L,2L,69L,39L,1L,33L,21L,0L,33L,48L,2L,6L,3L,16L,6L,3L,0L,411L,3L,2L,15L,3L,4L,519L,3L,0L,15L,147L,5L,6L,12L,13L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088395Inst : IEnumerable<long>
{
public static readonly long[] Value=A088395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088395.Bytes);
public long this[int i]=>Value[i];

public static A088395Inst Instance=new A088395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088396
{
public static readonly long[] Value={ 7L,8L,0L,4L,5L,0L,1L,2L,0L,7L,0L,0L,4L,5L,0L,1L,2L,0L,7L,8L,0L,0L,5L,0L,1L,2L,0L,25L,8L,0L,4L,5L,0L,1L,2L,0L,0L,8L,0L,4L,5L,0L,1L,0L,0L,7L,26L,0L,49L,5L,0L,1L,2L,0L,0L,125L,0L,4L,68L,0L,1L,2L,0L,16L,8L,0L,166L,5L,0L,1L,2L,0L,7L,0L,0L,4L,0L,0L,19L,2L,0L,16L,17L,0L,4L,5L,0L,0L,227L,0L,133L,35L,0L,13L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088396Inst : IEnumerable<long>
{
public static readonly long[] Value=A088396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088396.Bytes);
public long this[int i]=>Value[i];

public static A088396Inst Instance=new A088396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088397
{
public static readonly long[] Value={ 8L,4L,0L,2L,7L,0L,5L,1L,0L,8L,4L,0L,2L,16L,0L,5L,1L,0L,8L,4L,0L,2L,7L,0L,5L,1L,0L,8L,4L,0L,2L,7L,0L,5L,1L,0L,0L,4L,0L,2L,25L,0L,5L,1L,0L,35L,13L,0L,29L,7L,0L,5L,1L,0L,8L,4L,0L,2L,7L,0L,5L,1L,0L,8L,4L,0L,2L,25L,0L,5L,1L,0L,17L,0L,0L,2L,16L,0L,14L,1L,0L,26L,4L,0L,2L,7L,0L,5L,118L,0L,44L,22L,0L,11L,16L,0L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088397Inst : IEnumerable<long>
{
public static readonly long[] Value=A088397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088397.Bytes);
public long this[int i]=>Value[i];

public static A088397Inst Instance=new A088397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088398
{
public static readonly long[] Value={ 9L,9L,3L,9L,9L,3L,9L,9L,1L,9L,0L,3L,9L,9L,3L,9L,9L,1L,9L,9L,3L,0L,9L,3L,9L,9L,1L,9L,9L,3L,36L,36L,0L,9L,9L,1L,9L,9L,3L,9L,27L,3L,27L,0L,1L,9L,9L,3L,9L,9L,3L,27L,27L,1L,0L,9L,3L,9L,9L,3L,171L,18L,1L,18L,18L,0L,9L,9L,3L,9L,72L,1L,18L,18L,3L,27L,0L,3L,9L,9L,1L,27L,27L,3L,18L,27L,3L,0L,9L,1L,144L,36L,12L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088398Inst : IEnumerable<long>
{
public static readonly long[] Value=A088398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088398.Bytes);
public long this[int i]=>Value[i];

public static A088398Inst Instance=new A088398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088399
{
public static readonly long[] Value={ 19L,14L,0L,7L,11L,0L,4L,8L,0L,19L,5L,0L,7L,2L,0L,4L,8L,0L,1L,14L,0L,7L,2L,0L,13L,8L,0L,1L,5L,0L,7L,2L,0L,4L,8L,0L,1L,5L,0L,7L,2L,0L,4L,8L,0L,1L,5L,0L,7L,11L,0L,4L,8L,0L,1L,5L,0L,7L,2L,0L,4L,17L,0L,1L,5L,0L,16L,2L,0L,4L,17L,0L,1L,5L,0L,7L,2L,0L,4L,8L,0L,1L,5L,0L,16L,2L,0L,4L,8L,0L,1L,5L,0L,16L,2L,0L,13L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088399Inst : IEnumerable<long>
{
public static readonly long[] Value=A088399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088399.Bytes);
public long this[int i]=>Value[i];

public static A088399Inst Instance=new A088399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088400
{
public static readonly long[] Value={ 29L,19L,0L,14L,13L,0L,8L,7L,0L,29L,19L,0L,5L,4L,0L,8L,7L,0L,2L,19L,0L,14L,4L,0L,17L,7L,0L,2L,1L,0L,5L,4L,0L,8L,7L,0L,2L,1L,0L,14L,4L,0L,8L,7L,0L,2L,1L,0L,5L,13L,0L,8L,7L,0L,11L,1L,0L,5L,4L,0L,17L,7L,0L,2L,1L,0L,5L,4L,0L,8L,16L,0L,2L,1L,0L,5L,4L,0L,8L,7L,0L,2L,1L,0L,5L,4L,0L,8L,7L,0L,2L,1L,0L,5L,4L,0L,26L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088400Inst : IEnumerable<long>
{
public static readonly long[] Value=A088400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088400.Bytes);
public long this[int i]=>Value[i];

public static A088400Inst Instance=new A088400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088401
{
public static readonly long[] Value={ 5L,1L,6L,2L,7L,3L,8L,4L,9L,14L,19L,24L,29L,34L,39L,44L,49L,99L,149L,199L,249L,299L,349L,399L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088401Inst : IEnumerable<long>
{
public static readonly long[] Value=A088401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088401.Bytes);
public long this[int i]=>Value[i];

public static A088401Inst Instance=new A088401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088402
{
public static readonly long[] Value={ 2L,4L,6L,8L,1L,3L,5L,7L,9L,11L,13L,15L,17L,19L,39L,59L,79L,99L,119L,139L,159L,179L,199L,399L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088402Inst : IEnumerable<long>
{
public static readonly long[] Value=A088402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088402.Bytes);
public long this[int i]=>Value[i];

public static A088402Inst Instance=new A088402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088403
{
public static readonly long[] Value={ 125L,25L,15L,5L,4L,3L,2L,1L,9L,8L,7L,6L,23L,22L,12L,11L,37L,36L,62L,61L,87L,86L,112L,111L,236L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088403Inst : IEnumerable<long>
{
public static readonly long[] Value=A088403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088403.Bytes);
public long this[int i]=>Value[i];

public static A088403Inst Instance=new A088403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088420
{
public static readonly long[] Value={ 3L,3L,1L,3L,3L,1L,3L,2L,1L,3L,1L,1L,2L,3L,1L,1L,3L,1L,3L,3L,1L,2L,1L,1L,3L,1L,1L,2L,2L,1L,1L,3L,1L,3L,2L,1L,1L,2L,1L,3L,1L,1L,2L,1L,1L,1L,3L,1L,3L,2L,1L,3L,2L,1L,3L,1L,1L,1L,1L,1L,1L,3L,1L,2L,1L,1L,3L,2L,1L,1L,1L,1L,2L,2L,1L,1L,3L,1L,1L,2L,1L,3L,1L,1L,2L,1L,1L,2L,3L,1L,1L,1L,1L,3L,3L,1L,2L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088420Inst : IEnumerable<long>
{
public static readonly long[] Value=A088420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088420.Bytes);
public long this[int i]=>Value[i];

public static A088420Inst Instance=new A088420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088421
{
public static readonly long[] Value={ 2L,1L,5L,2L,1L,5L,2L,1L,4L,1L,1L,3L,2L,1L,1L,2L,1L,2L,2L,1L,5L,1L,1L,5L,1L,1L,4L,2L,1L,1L,2L,1L,3L,2L,1L,1L,2L,1L,2L,1L,1L,4L,1L,1L,1L,2L,1L,5L,2L,1L,2L,2L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,5L,1L,1L,4L,2L,1L,1L,1L,1L,3L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,3L,2L,1L,1L,1L,1L,2L,2L,1L,3L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088421Inst : IEnumerable<long>
{
public static readonly long[] Value=A088421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088421.Bytes);
public long this[int i]=>Value[i];

public static A088421Inst Instance=new A088421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088422
{
public static readonly long[] Value={ 1L,2L,3L,1L,2L,4L,1L,2L,1L,1L,2L,2L,1L,1L,6L,1L,2L,3L,1L,2L,1L,1L,2L,1L,1L,2L,2L,1L,1L,3L,1L,2L,3L,1L,1L,4L,1L,2L,1L,1L,2L,1L,1L,1L,2L,1L,2L,3L,1L,2L,4L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,2L,3L,1L,1L,1L,1L,2L,2L,1L,1L,7L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,2L,2L,1L,1L,1L,1L,2L,3L,1L,2L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088422Inst : IEnumerable<long>
{
public static readonly long[] Value=A088422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088422.Bytes);
public long this[int i]=>Value[i];

public static A088422Inst Instance=new A088422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088423
{
public static readonly long[] Value={ 2L,1L,4L,2L,1L,2L,1L,1L,3L,2L,1L,1L,2L,1L,5L,2L,1L,3L,1L,1L,2L,1L,1L,3L,2L,1L,1L,2L,1L,6L,2L,1L,1L,2L,1L,2L,1L,1L,3L,1L,1L,1L,2L,1L,4L,2L,1L,2L,2L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,3L,1L,1L,4L,2L,1L,1L,1L,1L,2L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,3L,2L,1L,1L,1L,1L,2L,2L,1L,4L,2L,1L,1L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088423Inst : IEnumerable<long>
{
public static readonly long[] Value=A088423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088423.Bytes);
public long this[int i]=>Value[i];

public static A088423Inst Instance=new A088423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088424
{
public static readonly long[] Value={ 1L,2L,2L,1L,2L,1L,1L,2L,2L,1L,1L,3L,1L,2L,4L,1L,2L,1L,1L,2L,1L,1L,2L,4L,1L,1L,2L,1L,2L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,1L,3L,1L,2L,6L,1L,2L,2L,1L,2L,1L,1L,1L,1L,1L,1L,3L,1L,2L,1L,1L,2L,2L,1L,1L,1L,1L,2L,2L,1L,1L,2L,1L,1L,5L,1L,2L,1L,1L,2L,1L,1L,2L,3L,1L,1L,1L,1L,2L,3L,1L,2L,2L,1L,1L,1L,1L,1L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088424Inst : IEnumerable<long>
{
public static readonly long[] Value=A088424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088424.Bytes);
public long this[int i]=>Value[i];

public static A088424Inst Instance=new A088424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088425
{
public static readonly long[] Value={ 2L,1L,3L,1L,1L,4L,2L,1L,1L,2L,1L,2L,2L,1L,2L,1L,1L,3L,1L,1L,3L,2L,1L,1L,2L,1L,2L,2L,1L,1L,2L,1L,3L,1L,1L,2L,1L,1L,1L,2L,1L,2L,2L,1L,3L,2L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,3L,2L,1L,1L,1L,1L,3L,2L,1L,1L,2L,1L,1L,2L,1L,5L,1L,1L,2L,1L,1L,2L,2L,1L,1L,1L,1L,2L,2L,1L,2L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088425Inst : IEnumerable<long>
{
public static readonly long[] Value=A088425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088425.Bytes);
public long this[int i]=>Value[i];

public static A088425Inst Instance=new A088425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088426
{
public static readonly long[] Value={ 1L,2L,1L,1L,2L,3L,1L,1L,2L,1L,2L,3L,1L,2L,1L,1L,2L,1L,1L,2L,3L,1L,1L,2L,1L,2L,4L,1L,1L,4L,1L,2L,1L,1L,2L,1L,1L,1L,2L,1L,2L,2L,1L,2L,3L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,2L,2L,1L,1L,1L,1L,2L,3L,1L,1L,2L,1L,1L,3L,1L,2L,1L,1L,2L,1L,1L,2L,2L,1L,1L,1L,1L,2L,4L,1L,2L,3L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088426Inst : IEnumerable<long>
{
public static readonly long[] Value=A088426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088426.Bytes);
public long this[int i]=>Value[i];

public static A088426Inst Instance=new A088426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088427
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,1L,2L,1L,3L,2L,1L,3L,1L,1L,4L,1L,1L,2L,2L,1L,1L,2L,1L,2L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,1L,2L,1L,4L,2L,1L,3L,2L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,4L,1L,1L,3L,2L,1L,1L,1L,1L,2L,2L,1L,1L,2L,1L,1L,2L,1L,3L,1L,1L,2L,1L,1L,2L,2L,1L,1L,1L,1L,3L,2L,1L,2L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088427Inst : IEnumerable<long>
{
public static readonly long[] Value=A088427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088427.Bytes);
public long this[int i]=>Value[i];

public static A088427Inst Instance=new A088427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088428
{
public static readonly long[] Value={ 2L,1L,1L,2L,1L,3L,2L,1L,2L,1L,1L,2L,1L,1L,3L,2L,1L,1L,2L,1L,3L,2L,1L,1L,2L,1L,4L,1L,1L,3L,1L,1L,1L,2L,1L,3L,2L,1L,2L,2L,1L,4L,1L,1L,1L,1L,1L,1L,2L,1L,3L,1L,1L,2L,2L,1L,1L,1L,1L,5L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,4L,1L,1L,2L,2L,1L,1L,1L,1L,3L,2L,1L,2L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088428Inst : IEnumerable<long>
{
public static readonly long[] Value=A088428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088428.Bytes);
public long this[int i]=>Value[i];

public static A088428Inst Instance=new A088428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088429
{
public static readonly long[] Value={ 1L,1L,3L,1L,2L,2L,1L,2L,1L,1L,2L,1L,1L,2L,2L,1L,1L,4L,1L,2L,2L,1L,1L,3L,1L,2L,1L,1L,2L,1L,1L,1L,4L,1L,2L,2L,1L,2L,2L,1L,2L,1L,1L,1L,1L,1L,1L,3L,1L,2L,1L,1L,2L,2L,1L,1L,1L,1L,2L,3L,1L,1L,4L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,2L,3L,1L,1L,1L,1L,2L,2L,1L,2L,3L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088429Inst : IEnumerable<long>
{
public static readonly long[] Value=A088429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088429.Bytes);
public long this[int i]=>Value[i];

public static A088429Inst Instance=new A088429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088430
{
public static readonly BigInteger[] Value={ 1L,2L,6L,150L,1536160080L,9918821194590L,BigInteger.Parse("341976204789992332560"),BigInteger.Parse("2166703103992332274919550") };
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
public class A088430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088430Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088430.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A088430.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088430Inst Instance=new A088430Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088431
{
public static readonly long[] Value={ 2L,1L,2L,2L,3L,2L,1L,2L,3L,1L,2L,3L,2L,2L,1L,2L,3L,1L,2L,2L,3L,2L,1L,3L,2L,1L,2L,3L,2L,2L,1L,2L,3L,1L,2L,2L,3L,2L,1L,2L,3L,1L,2L,3L,2L,2L,1L,3L,2L,1L,2L,2L,3L,2L,1L,3L,2L,1L,2L,3L,2L,2L,1L,2L,3L,1L,2L,2L,3L,2L,1L,2L,3L,1L,2L,3L,2L,2L,1L,2L,3L,1L,2L,2L,3L,2L,1L,3L,2L,1L,2L,3L,2L,2L,1L,3L,2L,1L,2L,2L,3L,2L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088431Inst : IEnumerable<long>
{
public static readonly long[] Value=A088431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088431.Bytes);
public long this[int i]=>Value[i];

public static A088431Inst Instance=new A088431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088432
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,0L,1L,1L,1L,0L,2L,0L,1L,1L,2L,0L,3L,0L,2L,1L,1L,0L,4L,1L,1L,1L,2L,0L,4L,0L,3L,1L,1L,1L,5L,0L,1L,1L,4L,0L,4L,0L,2L,2L,1L,0L,7L,1L,3L,1L,2L,0L,4L,1L,4L,1L,1L,0L,8L,0L,1L,2L,4L,1L,4L,0L,2L,1L,4L,0L,9L,0L,1L,3L,2L,1L,4L,0L,6L,2L,1L,0L,8L,1L,1L,1L,4L,0L,8L,1L,2L,1L,1L,1L,9L,0L,3L,2L,6L,0L,4L,0L,4L,4L,1L,0L,9L,0L,4L,1L,6L,0L,4L,1L,2L,2L,1L,1L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088432Inst : IEnumerable<long>
{
public static readonly long[] Value=A088432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088432.Bytes);
public long this[int i]=>Value[i];

public static A088432Inst Instance=new A088432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088433
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,4L,1L,2L,2L,3L,1L,3L,1L,4L,2L,2L,1L,6L,1L,2L,2L,4L,1L,5L,1L,4L,2L,2L,2L,7L,1L,2L,2L,6L,1L,5L,1L,4L,4L,2L,1L,8L,1L,3L,2L,4L,1L,6L,2L,6L,2L,2L,1L,10L,1L,2L,4L,5L,2L,5L,1L,4L,2L,5L,1L,11L,1L,2L,3L,4L,2L,5L,1L,9L,3L,2L,1L,10L,2L,2L,2L,6L,1L,10L,2L,4L,2L,2L,2L,12L,1L,3L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088433Inst : IEnumerable<long>
{
public static readonly long[] Value=A088433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088433.Bytes);
public long this[int i]=>Value[i];

public static A088433Inst Instance=new A088433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088434
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,2L,0L,1L,1L,1L,0L,2L,0L,2L,1L,1L,0L,4L,0L,1L,1L,2L,0L,4L,0L,2L,1L,1L,1L,4L,0L,1L,1L,4L,0L,4L,0L,2L,2L,1L,0L,6L,0L,2L,1L,2L,0L,4L,1L,4L,1L,1L,0L,8L,0L,1L,2L,3L,1L,4L,0L,2L,1L,4L,0L,8L,0L,1L,2L,2L,1L,4L,0L,6L,1L,1L,0L,8L,1L,1L,1L,4L,0L,8L,1L,2L,1L,1L,1L,9L,0L,2L,2L,4L,0L,4L,0L,4L,4L,1L,0L,8L,0L,4L,1L,6L,0L,4L,1L,2L,2L,1L,1L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088434Inst : IEnumerable<long>
{
public static readonly long[] Value=A088434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088434.Bytes);
public long this[int i]=>Value[i];

public static A088434Inst Instance=new A088434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088435
{
public static readonly long[] Value={ 3L,2L,2L,1L,2L,3L,2L,1L,3L,2L,1L,2L,2L,3L,2L,1L,3L,2L,2L,1L,2L,3L,1L,2L,3L,2L,1L,2L,2L,3L,2L,1L,3L,2L,2L,1L,2L,3L,2L,1L,3L,2L,1L,2L,2L,3L,1L,2L,3L,2L,2L,1L,2L,3L,1L,2L,3L,2L,1L,2L,2L,3L,2L,1L,3L,2L,2L,1L,2L,3L,2L,1L,3L,2L,1L,2L,2L,3L,2L,1L,3L,2L,2L,1L,2L,3L,1L,2L,3L,2L,1L,2L,2L,3L,1L,2L,3L,2L,2L,1L,2L,3L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088435Inst : IEnumerable<long>
{
public static readonly long[] Value=A088435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088435.Bytes);
public long this[int i]=>Value[i];

public static A088435Inst Instance=new A088435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088436
{
public static readonly long[] Value={ 0L,1L,3L,6L,30L,225L,1575L,12180L,109620L,1100925L,12110175L,145259730L,1888376490L,26438216805L,396573252075L,6345155817000L,107867648889000L,1941617990136825L,36890741812599675L,737814829704702750L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088436Inst : IEnumerable<long>
{
public static readonly long[] Value=A088436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088436.Bytes);
public long this[int i]=>Value[i];

public static A088436Inst Instance=new A088436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088437
{
public static readonly BigInteger[] Value={ 1L,1L,1L,2L,6L,32L,288L,4608L,130560L,6684672L,621674496L,106099113984L,33421220904960L,19556188689530880L,BigInteger.Parse("21359269286705627136"),BigInteger.Parse("43743783499173124374528"),BigInteger.Parse("168632285389312394463805440"),BigInteger.Parse("1227942828363775231508883701760"),BigInteger.Parse("16941927202935006869128068433182720"),BigInteger.Parse("444122456468619444070070837134825095168") };
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
public class A088437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088437Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A088437.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A088437.Bytes);
public BigInteger this[int i]=>Value[i];

public static A088437Inst Instance=new A088437Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088438
{
public static readonly long[] Value={ 2L,6L,4L,7L,24L,35L,8L,18L,70L,88L,12L,29L,140L,165L,16L,40L,234L,266L,20L,52L,352L,391L,24L,64L,494L,540L,28L,76L,660L,713L,32L,88L,850L,910L,36L,99L,1064L,1131L,40L,111L,1302L,1376L,44L,123L,1564L,1645L,48L,135L,1850L,1938L,52L,147L,2160L,2255L,56L,159L,2494L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088438Inst : IEnumerable<long>
{
public static readonly long[] Value=A088438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088438.Bytes);
public long this[int i]=>Value[i];

public static A088438Inst Instance=new A088438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088439
{
public static readonly long[] Value={ 0L,1L,1L,3L,1L,1L,6L,1L,1L,9L,1L,1L,12L,1L,1L,15L,1L,1L,18L,1L,1L,21L,1L,1L,24L,1L,1L,27L,1L,1L,30L,1L,1L,33L,1L,1L,36L,1L,1L,39L,1L,1L,42L,1L,1L,45L,1L,1L,48L,1L,1L,51L,1L,1L,54L,1L,1L,57L,1L,1L,60L,1L,1L,63L,1L,1L,66L,1L,1L,69L,1L,1L,72L,1L,1L,75L,1L,1L,78L,1L,1L,81L,1L,1L,84L,1L,1L,87L,1L,1L,90L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088439Inst : IEnumerable<long>
{
public static readonly long[] Value=A088439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088439.Bytes);
public long this[int i]=>Value[i];

public static A088439Inst Instance=new A088439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088440
{
public static readonly long[] Value={ 0L,1L,1L,1L,4L,1L,1L,1L,8L,1L,1L,1L,12L,1L,1L,1L,16L,1L,1L,1L,20L,1L,1L,1L,24L,1L,1L,1L,28L,1L,1L,1L,32L,1L,1L,1L,36L,1L,1L,1L,40L,1L,1L,1L,44L,1L,1L,1L,48L,1L,1L,1L,52L,1L,1L,1L,56L,1L,1L,1L,60L,1L,1L,1L,64L,1L,1L,1L,68L,1L,1L,1L,72L,1L,1L,1L,76L,1L,1L,1L,80L,1L,1L,1L,84L,1L,1L,1L,88L,1L,1L,1L,92L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088440Inst : IEnumerable<long>
{
public static readonly long[] Value=A088440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088440.Bytes);
public long this[int i]=>Value[i];

public static A088440Inst Instance=new A088440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088441
{
public static readonly long[] Value={ 1L,3L,1L,1L,6L,2L,1L,9L,4L,1L,12L,5L,1L,15L,7L,1L,18L,8L,1L,21L,10L,1L,24L,11L,1L,27L,13L,1L,30L,14L,1L,33L,16L,1L,36L,17L,1L,39L,19L,1L,42L,20L,1L,45L,22L,1L,48L,23L,1L,51L,25L,1L,54L,26L,1L,57L,28L,1L,60L,29L,1L,63L,31L,1L,66L,32L,1L,69L,34L,1L,72L,35L,1L,75L,37L,1L,78L,38L,1L,81L,40L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088441Inst : IEnumerable<long>
{
public static readonly long[] Value=A088441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088441.Bytes);
public long this[int i]=>Value[i];

public static A088441Inst Instance=new A088441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088442
{
public static readonly long[] Value={ 1L,3L,1L,3L,9L,11L,9L,11L,1L,3L,1L,3L,9L,11L,9L,11L,33L,35L,33L,35L,41L,43L,41L,43L,33L,35L,33L,35L,41L,43L,41L,43L,1L,3L,1L,3L,9L,11L,9L,11L,1L,3L,1L,3L,9L,11L,9L,11L,33L,35L,33L,35L,41L,43L,41L,43L,33L,35L,33L,35L,41L,43L,41L,43L,129L,131L,129L,131L,137L,139L,137L,139L,129L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088442Inst : IEnumerable<long>
{
public static readonly long[] Value=A088442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088442.Bytes);
public long this[int i]=>Value[i];

public static A088442Inst Instance=new A088442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088443
{
public static readonly long[] Value={ 1L,2L,1L,4L,1L,1L,7L,8L,8L,1L,2L,1L,2L,5L,14L,14L,17L,17L,17L,17L,14L,2L,1L,4L,1L,1L,2L,4L,4L,5L,11L,32L,31L,34L,31L,31L,37L,38L,38L,38L,41L,37L,38L,37L,38L,31L,31L,1L,4L,5L,1L,7L,8L,8L,1L,2L,1L,2L,5L,4L,1L,8L,8L,8L,8L,11L,11L,20L,23L,25L,71L,71L,68L,70L,68L,76L,74L,68L,68L,68L,70L,82L,83L,82L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088443Inst : IEnumerable<long>
{
public static readonly long[] Value=A088443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088443.Bytes);
public long this[int i]=>Value[i];

public static A088443Inst Instance=new A088443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088444
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,2L,7L,2L,3L,5L,11L,3L,13L,7L,3L,4L,17L,3L,19L,4L,3L,11L,23L,3L,5L,13L,9L,7L,29L,5L,31L,8L,11L,17L,5L,6L,37L,19L,13L,5L,41L,6L,43L,11L,5L,23L,47L,6L,7L,5L,17L,13L,53L,6L,5L,7L,19L,29L,59L,5L,61L,31L,7L,8L,5L,6L,67L,17L,23L,5L,71L,6L,73L,37L,5L,19L,7L,6L,79L,5L,9L,41L,83L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088444Inst : IEnumerable<long>
{
public static readonly long[] Value=A088444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088444.Bytes);
public long this[int i]=>Value[i];

public static A088444Inst Instance=new A088444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088445
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,3L,1L,4L,3L,2L,1L,4L,1L,2L,5L,4L,1L,6L,1L,5L,7L,2L,1L,8L,5L,2L,3L,4L,1L,6L,1L,4L,3L,2L,7L,6L,1L,2L,3L,8L,1L,7L,1L,4L,9L,2L,1L,8L,7L,10L,3L,4L,1L,9L,11L,8L,3L,2L,1L,12L,1L,2L,9L,8L,13L,11L,1L,4L,3L,14L,1L,12L,1L,2L,15L,4L,11L,13L,1L,16L,9L,2L,1L,14L,17L,2L,3L,11L,1L,18L,13L,4L,3L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088445Inst : IEnumerable<long>
{
public static readonly long[] Value=A088445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088445.Bytes);
public long this[int i]=>Value[i];

public static A088445Inst Instance=new A088445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088446
{
public static readonly long[] Value={ 1L,4L,7L,2L,16L,8L,12L,16L,5L,8L,22L,28L,76L,59L,16L,51L,57L,35L,45L,22L,78L,284L,31L,154L,125L,147L,106L,365L,226L,227L,421L,201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088446Inst : IEnumerable<long>
{
public static readonly long[] Value=A088446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088446.Bytes);
public long this[int i]=>Value[i];

public static A088446Inst Instance=new A088446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088447
{
public static readonly long[] Value={ 1L,2L,3L,16L,5L,36L,7L,32L,27L,100L,11L,156L,13L,126L,135L,256L,17L,162L,19L,440L,147L,484L,23L,696L,125L,1222L,243L,1148L,29L,930L,31L,1376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088447Inst : IEnumerable<long>
{
public static readonly long[] Value=A088447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088447.Bytes);
public long this[int i]=>Value[i];

public static A088447Inst Instance=new A088447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088448
{
public static readonly long[] Value={ 1L,8L,24L,20L,90L,84L,119L,200L,117L,190L,319L,528L,1131L,1134L,525L,1328L,1343L,1332L,1330L,1340L,2478L,7260L,1334L,5352L,4300L,5954L,4833L,13188L,8468L,10800L,15686L,11744L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088448Inst : IEnumerable<long>
{
public static readonly long[] Value=A088448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088448.Bytes);
public long this[int i]=>Value[i];

public static A088448Inst Instance=new A088448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088449
{
public static readonly long[] Value={ 1L,16L,20L,27L,32L,36L,42L,48L,54L,64L,66L,72L,78L,81L,84L,88L,96L,99L,100L,104L,108L,110L,117L,120L,125L,126L,128L,130L,135L,136L,140L,144L,147L,150L,152L,156L,160L,162L,168L,170L,175L,176L,180L,184L,189L,190L,192L,196L,200L,204L,210L,216L,224L,225L,228L,238L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088449Inst : IEnumerable<long>
{
public static readonly long[] Value=A088449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088449.Bytes);
public long this[int i]=>Value[i];

public static A088449Inst Instance=new A088449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088450
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,13L,15L,17L,19L,21L,23L,25L,29L,31L,35L,37L,41L,43L,47L,49L,53L,55L,59L,61L,65L,67L,71L,73L,77L,79L,83L,85L,89L,91L,97L,101L,103L,107L,109L,113L,119L,121L,127L,131L,137L,139L,143L,149L,151L,157L,163L,167L,169L,173L,179L,181L,187L,191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088450Inst : IEnumerable<long>
{
public static readonly long[] Value=A088450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088450.Bytes);
public long this[int i]=>Value[i];

public static A088450Inst Instance=new A088450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088451
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,9L,10L,11L,12L,13L,14L,17L,18L,19L,22L,23L,24L,25L,26L,28L,29L,30L,31L,33L,34L,37L,38L,39L,40L,41L,43L,44L,45L,46L,47L,49L,50L,51L,52L,53L,56L,57L,58L,59L,60L,61L,62L,63L,67L,68L,69L,71L,73L,74L,75L,76L,79L,80L,82L,83L,86L,87L,89L,90L,92L,93L,94L,95L,97L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088451Inst : IEnumerable<long>
{
public static readonly long[] Value=A088451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088451.Bytes);
public long this[int i]=>Value[i];

public static A088451Inst Instance=new A088451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088484
{
public static readonly long[] Value={ 5L,11L,29L,1721L,3539L,8009L,10301L,17291L,552791L,579881L,1424441L,5815331L,7094231L,7450169L,9069131L,10378061L,10572251L,11899049L,22576751L,38112101L,43553399L,46696721L,52265669L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088484Inst : IEnumerable<long>
{
public static readonly long[] Value=A088484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088484.Bytes);
public long this[int i]=>Value[i];

public static A088484Inst Instance=new A088484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088485
{
public static readonly long[] Value={ 2L,3L,5L,6L,8L,15L,20L,21L,24L,38L,41L,50L,54L,59L,66L,89L,101L,131L,138L,141L,153L,155L,164L,176L,188L,203L,206L,209L,215L,218L,231L,236L,246L,288L,290L,309L,314L,351L,378L,395L,405L,453L,455L,456L,495L,500L,518L,530L,551L,560L,624L,644L,668L,686L,720L,728L,743L,761L,798L,825L,890L,915L,950L,974L,981L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088485Inst : IEnumerable<long>
{
public static readonly long[] Value=A088485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088485.Bytes);
public long this[int i]=>Value[i];

public static A088485Inst Instance=new A088485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088486
{
public static readonly long[] Value={ 5L,11L,29L,41L,71L,239L,419L,461L,599L,1481L,1721L,2549L,2969L,3539L,4421L,8009L,10301L,17291L,19181L,20021L,23561L,24179L,27059L,31151L,35531L,41411L,42641L,43889L,46439L,47741L,53591L,55931L,60761L,83231L,84389L,95789L,98909L,123551L,143261L,156419L,164429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088486Inst : IEnumerable<long>
{
public static readonly long[] Value=A088486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088486.Bytes);
public long this[int i]=>Value[i];

public static A088486Inst Instance=new A088486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088487
{
public static readonly long[] Value={ 8L,10L,8L,8L,13L,8L,8L,24L,8L,8L,19L,8L,8L,22L,8L,8L,42L,8L,8L,28L,8L,8L,31L,8L,8L,86L,8L,8L,37L,8L,8L,40L,8L,8L,78L,8L,8L,46L,8L,8L,49L,8L,8L,96L,8L,8L,55L,8L,8L,58L,8L,8L,167L,8L,8L,64L,8L,8L,67L,8L,8L,132L,8L,8L,73L,8L,8L,76L,8L,8L,150L,8L,8L,82L,8L,8L,85L,8L,8L,328L,8L,8L,91L,8L,8L,94L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088487Inst : IEnumerable<long>
{
public static readonly long[] Value=A088487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088487.Bytes);
public long this[int i]=>Value[i];

public static A088487Inst Instance=new A088487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088488
{
public static readonly long[] Value={ 8L,17L,22L,26L,40L,43L,49L,66L,65L,69L,87L,87L,68L,109L,108L,109L,137L,130L,130L,157L,153L,133L,180L,174L,171L,211L,196L,191L,227L,218L,186L,250L,240L,232L,280L,262L,253L,298L,285L,164L,319L,304L,292L,350L,327L,313L,367L,349L,292L,390L,371L,354L,426L,393L,375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088488Inst : IEnumerable<long>
{
public static readonly long[] Value=A088488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088488.Bytes);
public long this[int i]=>Value[i];

public static A088488Inst Instance=new A088488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088489
{
public static readonly long[] Value={ 0L,0L,0L,54L,63L,27L,36L,54L,0L,594L,594L,792L,792L,0L,594L,495L,693L,693L,99L,198L,396L,495L,297L,297L,396L,396L,396L,99L,495L,297L,99L,693L,99L,99L,693L,8082L,270L,8352L,540L,810L,360L,7992L,6444L,8532L,270L,7812L,5814L,90L,360L,6354L,5454L,7542L,5994L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088489Inst : IEnumerable<long>
{
public static readonly long[] Value=A088489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088489.Bytes);
public long this[int i]=>Value[i];

public static A088489Inst Instance=new A088489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A088490
{
public static readonly long[] Value={ 0L,0L,18L,72L,18L,9L,45L,36L,198L,792L,792L,0L,0L,198L,792L,693L,99L,99L,99L,0L,594L,297L,99L,99L,198L,396L,495L,297L,297L,495L,693L,495L,99L,99L,495L,180L,2268L,450L,2538L,2808L,2358L,90L,8442L,630L,1728L,90L,7812L,2088L,2358L,8352L,7452L,360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A088490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A088490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A088490Inst : IEnumerable<long>
{
public static readonly long[] Value=A088490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A088490.Bytes);
public long this[int i]=>Value[i];

public static A088490Inst Instance=new A088490Inst();

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