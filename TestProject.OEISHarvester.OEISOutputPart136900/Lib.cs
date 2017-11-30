using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A166205
{
public static readonly long[] Value={ 1L,11L,4L,14L,274L,1310L,16010L,875990L,10795845L,510043341L,106992734072L,3763253632418L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166205Inst : IEnumerable<long>
{
public static readonly long[] Value=A166205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166205.Bytes);
public long this[int i]=>Value[i];

public static A166205Inst Instance=new A166205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166206
{
public static readonly long[] Value={ 1L,12L,4L,16L,357L,1880L,26443L,1765534L,25412877L,1480441810L,406769105056L,17832789481005L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166206Inst : IEnumerable<long>
{
public static readonly long[] Value=A166206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166206.Bytes);
public long this[int i]=>Value[i];

public static A166206Inst Instance=new A166206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166207
{
public static readonly long[] Value={ 1L,13L,5L,19L,479L,2636L,42285L,3484228L,56578703L,4011008946L,1447700846889L,76408068978456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166207Inst : IEnumerable<long>
{
public static readonly long[] Value=A166207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166207.Bytes);
public long this[int i]=>Value[i];

public static A166207Inst Instance=new A166207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166208
{
public static readonly long[] Value={ 1L,14L,5L,21L,616L,3614L,65576L,6508702L,119636627L,10193915255L,4710009299519L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166208Inst : IEnumerable<long>
{
public static readonly long[] Value=A166208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166208.Bytes);
public long this[int i]=>Value[i];

public static A166208Inst Instance=new A166208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166209
{
public static readonly long[] Value={ 1L,15L,5L,24L,768L,4862L,99088L,11604117L,241988291L,24508598458L,14166568176196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166209Inst : IEnumerable<long>
{
public static readonly long[] Value=A166209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166209.Bytes);
public long this[int i]=>Value[i];

public static A166209Inst Instance=new A166209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166210
{
public static readonly long[] Value={ 1L,16L,6L,27L,977L,6434L,146337L,20390870L,470828929L,56179164262L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166210Inst : IEnumerable<long>
{
public static readonly long[] Value=A166210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166210.Bytes);
public long this[int i]=>Value[i];

public static A166210Inst Instance=new A166210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166211
{
public static readonly long[] Value={ 1L,17L,6L,30L,1207L,8387L,211677L,34490146L,884190706L,123191992504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166211Inst : IEnumerable<long>
{
public static readonly long[] Value=A166211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166211.Bytes);
public long this[int i]=>Value[i];

public static A166211Inst Instance=new A166211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166212
{
public static readonly long[] Value={ 1L,3L,6L,14L,25L,39L,66L,99L,138L,201L,274L,357L,479L,616L,768L,977L,1207L,1458L,1788L,2146L,2532L,3022L,3548L,4110L,4805L,5545L,6330L,7280L,8285L,9345L,10606L,11933L,13326L,14959L,16670L,18459L,20531L,22694L,24948L,27531L,30219L,33012L,36184L,39476L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166212Inst : IEnumerable<long>
{
public static readonly long[] Value=A166212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166212.Bytes);
public long this[int i]=>Value[i];

public static A166212Inst Instance=new A166212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166213
{
public static readonly long[] Value={ 1L,4L,12L,30L,64L,122L,218L,364L,579L,886L,1310L,1880L,2636L,3614L,4862L,6434L,8387L,10784L,13704L,17220L,21422L,26408L,32280L,39148L,47143L,56388L,67028L,79218L,93118L,108898L,126754L,146872L,169465L,194758L,222982L,254380L,289226L,327782L,370342L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166213Inst : IEnumerable<long>
{
public static readonly long[] Value=A166213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166213.Bytes);
public long this[int i]=>Value[i];

public static A166213Inst Instance=new A166213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166214
{
public static readonly long[] Value={ 1L,6L,26L,89L,249L,604L,1340L,2718L,5166L,9309L,16010L,26443L,42285L,65576L,99088L,146337L,211677L,300467L,419570L,576863L,782184L,1047233L,1385738L,1813757L,2350697L,3018141L,3841784L,4851076L,6079477L,7564937L,9351702L,11488015L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166214Inst : IEnumerable<long>
{
public static readonly long[] Value=A166214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166214.Bytes);
public long this[int i]=>Value[i];

public static A166214Inst Instance=new A166214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166215
{
public static readonly long[] Value={ 1L,13L,90L,553L,2376L,8064L,25771L,70603L,172012L,405175L,875990L,1765534L,3484228L,6508702L,11604117L,20390870L,34490146L,56425254L,91343551L,143775379L,220716013L,336122564L,500966646L,732267501L,1063633842L,1518831488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166215Inst : IEnumerable<long>
{
public static readonly long[] Value=A166215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166215.Bytes);
public long this[int i]=>Value[i];

public static A166215Inst Instance=new A166215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166216
{
public static readonly long[] Value={ 1L,17L,200L,1588L,9030L,40848L,157803L,526484L,1571016L,4285591L,10795845L,25412877L,56578703L,119636627L,241988291L,470828929L,884190706L,1608280291L,2844350256L,4899912505L,8243127504L,13571819655L,21901928396L,34695730340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166216Inst : IEnumerable<long>
{
public static readonly long[] Value=A166216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166216.Bytes);
public long this[int i]=>Value[i];

public static A166216Inst Instance=new A166216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166217
{
public static readonly long[] Value={ 1L,34L,665L,8865L,76249L,495985L,2661967L,11908924L,46316901L,161588843L,510043341L,1480441810L,4011008946L,10193915255L,24508598458L,56179164262L,123191992504L,259647495716L,528503830704L,1041183396446L,1991316075404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166217Inst : IEnumerable<long>
{
public static readonly long[] Value=A166217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166217.Bytes);
public long this[int i]=>Value[i];

public static A166217Inst Instance=new A166217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166218
{
public static readonly long[] Value={ 1L,101L,3980L,104510L,1598732L,16474555L,140020892L,931368996L,5087344969L,25012399727L,106992734072L,406769105056L,1447700846889L,4710009299519L,14166568176196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166218Inst : IEnumerable<long>
{
public static readonly long[] Value=A166218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166218.Bytes);
public long this[int i]=>Value[i];

public static A166218Inst Instance=new A166218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166219
{
public static readonly long[] Value={ 1L,146L,10515L,444424L,10091912L,153952919L,1770255356L,15702838676L,113781268522L,703336933599L,3763253632418L,17832789481005L,76408068978456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166219Inst : IEnumerable<long>
{
public static readonly long[] Value=A166219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166219.Bytes);
public long this[int i]=>Value[i];

public static A166219Inst Instance=new A166219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166220
{
public static readonly long[] Value={ 1L,325L,52518L,4173156L,165533393L,4118194905L,73044448611L,958018305487L,9916013916442L,84913600697770L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166220Inst : IEnumerable<long>
{
public static readonly long[] Value=A166220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166220.Bytes);
public long this[int i]=>Value[i];

public static A166220Inst Instance=new A166220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166221
{
public static readonly long[] Value={ 1L,1195L,433447L,81325310L,6511049130L,283350411160L,8966527587527L,191827791698093L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166221Inst : IEnumerable<long>
{
public static readonly long[] Value=A166221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166221.Bytes);
public long this[int i]=>Value[i];

public static A166221Inst Instance=new A166221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166222
{
public static readonly long[] Value={ 1L,2277L,1973317L,652489468L,90909213960L,6779925069586L,317675182498031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166222Inst : IEnumerable<long>
{
public static readonly long[] Value=A166222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166222.Bytes);
public long this[int i]=>Value[i];

public static A166222Inst Instance=new A166222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166223
{
public static readonly long[] Value={ 1L,6460L,14252749L,10459516337L,2908246084285L,398461742491565L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166223Inst : IEnumerable<long>
{
public static readonly long[] Value=A166223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166223.Bytes);
public long this[int i]=>Value[i];

public static A166223Inst Instance=new A166223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166224
{
public static readonly long[] Value={ 1L,27376L,166762668L,342881668736L,219536965840260L,59492448257857640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166224Inst : IEnumerable<long>
{
public static readonly long[] Value=A166224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166224.Bytes);
public long this[int i]=>Value[i];

public static A166224Inst Instance=new A166224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166225
{
public static readonly BigInteger[] Value={ 1L,41L,1640L,65600L,2624000L,104960000L,4198400000L,167936000000L,6717440000000L,268697600000000L,10747903999999180L,429916159999934400L,17196646399996064820UL,BigInteger.Parse("687865855999790145600"),BigInteger.Parse("27514634239989507936000") };
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
public class A166225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166225Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166225.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A166225.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166225Inst Instance=new A166225Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166226
{
public static readonly long[] Value={ 0L,0L,2L,3L,2L,5L,2L,4L,6L,5L,2L,1L,2L,12L,5L,3L,2L,13L,2L,12L,15L,5L,2L,9L,3L,18L,10L,3L,2L,27L,2L,12L,4L,5L,0L,1L,2L,24L,28L,27L,2L,23L,2L,8L,5L,5L,2L,33L,24L,20L,49L,39L,2L,5L,27L,28L,34L,5L,2L,57L,2L,36L,6L,51L,47L,19L,2L,52L,15L,25L,2L,49L,2L,42L,22L,71L,59L,19L,2L,44L,23L,5L,2L,65L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166226Inst : IEnumerable<long>
{
public static readonly long[] Value=A166226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166226.Bytes);
public long this[int i]=>Value[i];

public static A166226Inst Instance=new A166226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166227
{
public static readonly long[] Value={ 793312220L,388244100L,33554978L,405027808L,34381363L,16824237L,17647707L,3341086L,16824184L,33601606L,140025L,3388L,33554486L,16830688L,50424989L,791621836L,405114593L,387427281L,35201810L,16780376L,18517643L,17650825L,17653671L,1743552L,830081L,33554462L,53476L,873607L,18470986L,421845378L,34381644L,16824695L,404294403L,387421546L,17651084L,17650799L,776537847L,20121452L,3396L,387467199L,793312220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166227Inst : IEnumerable<long>
{
public static readonly long[] Value=A166227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166227.Bytes);
public long this[int i]=>Value[i];

public static A166227Inst Instance=new A166227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166228
{
public static readonly long[] Value={ 1L,1L,5L,17L,73L,321L,1485L,7073L,34513L,171585L,866133L,4427313L,22870425L,119208321L,626178717L,3311424321L,17615732385L,94202293633L,506116560293L,2730607756881L,14788011564009L,80361643637953L,438070231780973L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166228Inst : IEnumerable<long>
{
public static readonly long[] Value=A166228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166228.Bytes);
public long this[int i]=>Value[i];

public static A166228Inst Instance=new A166228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166229
{
public static readonly long[] Value={ 1L,2L,8L,36L,176L,912L,4928L,27472L,156864L,912832L,5394176L,32282240L,195264000L,1191825920L,7331457024L,45406194944L,282896763904L,1771868302336L,11150040870912L,70461597988864L,446971590516736L,2845144452292608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166229Inst : IEnumerable<long>
{
public static readonly long[] Value=A166229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166229.Bytes);
public long this[int i]=>Value[i];

public static A166229Inst Instance=new A166229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166230
{
public static readonly BigInteger[] Value={ 1L,42L,1722L,70602L,2894682L,118681962L,4865960442L,199504378122L,8179679503002L,335366859623082L,13750041244545501L,563751691026330240L,BigInteger.Parse("23113819332078093360"),BigInteger.Parse("947666592615142522080"),BigInteger.Parse("38854330297218411872400") };
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
public class A166230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166230Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166230.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A166230.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166230Inst Instance=new A166230Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166231
{
public static readonly BigInteger[] Value={ 1L,4L,48L,1280L,69632L,7602176L,1660944384L,725849473024L,634418209226752L,1109011408239984640L,BigInteger.Parse("3877275019992826380288"),BigInteger.Parse("27111105978154633171828736"),BigInteger.Parse("379138479844261543254652092416"),BigInteger.Parse("10604214183559196000870296488771584") };
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
public class A166231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166231Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166231.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A166231.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166231Inst Instance=new A166231Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166232
{
public static readonly BigInteger[] Value={ 1L,1L,3L,20L,272L,7424L,405504L,44302336L,9680453632L,4230542786560L,3697657604210688L,6463791365183504384L,BigInteger.Parse("22598414411798807576576"),BigInteger.Parse("158015104883301198495481856"),BigInteger.Parse("2209780998563745292895322636288") };
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
public class A166232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166232Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166232.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A166232.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166232Inst Instance=new A166232Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166233
{
public static readonly BigInteger[] Value={ 1L,43L,1806L,75852L,3185784L,133802928L,5619722976L,236028364992L,9913191329664L,416354035845888L,17486869505526393L,734448519232070580L,BigInteger.Parse("30846837807745372371"),BigInteger.Parse("1295567187925238776044"),BigInteger.Parse("54413821892857220325252") };
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
public class A166233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166233Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166233.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A166233.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166233Inst Instance=new A166233Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166234
{
public static readonly long[] Value={ 1L,1L,1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,-1L,1L,1L,1L,0L,1L,-1L,1L,-1L,1L,1L,1L,-1L,-1L,1L,-1L,-1L,1L,1L,1L,-1L,1L,1L,1L,1L,1L,1L,1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,0L,-1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,1L,1L,-1L,1L,1L,-1L,1L,1L,1L,1L,-1L,1L,1L,1L,1L,1L,1L,-1L,-1L,1L,1L,1L,0L,0L,1L,1L,-1L,1L,1L,1L,-1L,1L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166234Inst : IEnumerable<long>
{
public static readonly long[] Value=A166234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166234.Bytes);
public long this[int i]=>Value[i];

public static A166234Inst Instance=new A166234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166235
{
public static readonly long[] Value={ 1L,-2L,-1L,2L,1L,4L,4L,-7L,-8L,2L,4L,1L,-8L,-12L,18L,35L,-6L,-33L,-10L,9L,6L,1L,16L,32L,-40L,-120L,1L,160L,76L,-80L,-74L,0L,20L,8L,1L,-32L,-80L,80L,360L,70L,-601L,-430L,405L,540L,-10L,-268L,-110L,30L,35L,10L,1L,64L,192L,-144L,-992L,-420L,1932L,1961L,-1512L,-2946L,-140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166235Inst : IEnumerable<long>
{
public static readonly long[] Value=A166235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166235.Bytes);
public long this[int i]=>Value[i];

public static A166235Inst Instance=new A166235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166236
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,5L,7L,6L,5L,7L,6L,5L,6L,5L,5L,3L,4L,4L,3L,4L,3L,2L,1L,2L,3L,2L,1L,1L,1L,5L,6L,8L,8L,12L,11L,12L,14L,13L,15L,17L,17L,19L,19L,19L,19L,23L,27L,28L,27L,28L,28L,28L,32L,34L,34L,34L,34L,36L,37L,37L,40L,46L,47L,47L,48L,53L,53L,56L,56L,55L,57L,60L,62L,63L,64L,65L,68L,68L,71L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166236Inst : IEnumerable<long>
{
public static readonly long[] Value=A166236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166236.Bytes);
public long this[int i]=>Value[i];

public static A166236Inst Instance=new A166236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166237
{
public static readonly long[] Value={ 4L,4L,1L,6L,1L,4L,7L,1L,1L,3L,1L,7L,5L,4L,2L,1L,4L,3L,4L,5L,3L,5L,3L,1L,1L,4L,2L,1L,1L,11L,5L,4L,3L,1L,3L,1L,6L,4L,1L,7L,1L,1L,2L,1L,9L,3L,1L,2L,5L,11L,1L,5L,2L,2L,7L,7L,1L,1L,2L,1L,3L,4L,1L,1L,2L,1L,1L,2L,5L,9L,2L,10L,2L,4L,1L,5L,3L,3L,2L,7L,4L,9L,4L,4L,3L,1L,2L,1L,1L,2L,4L,5L,5L,2L,2L,3L,1L,2L,5L,1L,4L,2L,5L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166237Inst : IEnumerable<long>
{
public static readonly long[] Value=A166237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166237.Bytes);
public long this[int i]=>Value[i];

public static A166237Inst Instance=new A166237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166238
{
public static readonly long[] Value={ 0L,1L,2L,3L,0L,4L,0L,1L,5L,0L,1L,2L,6L,0L,1L,2L,3L,0L,7L,0L,1L,2L,3L,0L,4L,0L,1L,8L,0L,1L,2L,3L,0L,4L,0L,1L,5L,0L,1L,2L,9L,0L,1L,2L,3L,0L,4L,0L,1L,5L,0L,1L,2L,6L,0L,1L,2L,3L,0L,10L,0L,1L,2L,3L,0L,4L,0L,1L,5L,0L,1L,2L,6L,0L,1L,2L,3L,0L,7L,0L,1L,2L,3L,0L,4L,0L,1L,11L,0L,1L,2L,3L,0L,4L,0L,1L,5L,0L,1L,2L,6L,0L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166238Inst : IEnumerable<long>
{
public static readonly long[] Value=A166238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166238.Bytes);
public long this[int i]=>Value[i];

public static A166238Inst Instance=new A166238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166239
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,5L,7L,9L,13L,16L,19L,27L,33L,40L,54L,63L,75L,99L,116L,140L,175L,198L,244L,293L,349L,401L,491L,563L,666L,790L,912L,1046L,1266L,1419L,1667L,1929L,2221L,2528L,2979L,3345L,3868L,4422L,5057L,5709L,6638L,7395L,8480L,9626L,10925L,12237L,14052L,15622L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166239Inst : IEnumerable<long>
{
public static readonly long[] Value=A166239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166239.Bytes);
public long this[int i]=>Value[i];

public static A166239Inst Instance=new A166239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166240
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,2L,1L,1L,1L,3L,2L,2L,1L,1L,1L,3L,4L,2L,2L,1L,1L,1L,4L,4L,4L,2L,2L,1L,1L,1L,1L,4L,6L,4L,4L,2L,2L,1L,1L,1L,5L,6L,7L,4L,4L,2L,2L,1L,1L,1L,5L,9L,7L,7L,4L,4L,2L,2L,1L,1L,1L,6L,9L,11L,7L,7L,4L,4L,2L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166240Inst : IEnumerable<long>
{
public static readonly long[] Value=A166240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166240.Bytes);
public long this[int i]=>Value[i];

public static A166240Inst Instance=new A166240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166241
{
public static readonly BigInteger[] Value={ 3L,83L,292299923L,684331371443L,BigInteger.Parse("191640836307771341507"),BigInteger.Parse("9388970456309004899603"),BigInteger.Parse("30363584636685952989516426809065192841572196335875312999038527044324069339846978313376123672504677550327603") };
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
public class A166241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166241Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166241.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A166241.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166241Inst Instance=new A166241Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166242
{
public static readonly long[] Value={ 1L,2L,4L,2L,4L,8L,4L,2L,4L,8L,16L,8L,4L,8L,4L,2L,4L,8L,16L,8L,16L,32L,16L,8L,4L,8L,16L,8L,4L,8L,4L,2L,4L,8L,16L,8L,16L,32L,16L,8L,16L,32L,64L,32L,16L,32L,16L,8L,4L,8L,16L,8L,16L,32L,16L,8L,4L,8L,16L,8L,4L,8L,4L,2L,4L,8L,16L,8L,16L,32L,16L,8L,16L,32L,64L,32L,16L,32L,16L,8L,16L,32L,64L,32L,64L,128L,64L,32L,16L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166242Inst : IEnumerable<long>
{
public static readonly long[] Value=A166242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166242.Bytes);
public long this[int i]=>Value[i];

public static A166242Inst Instance=new A166242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166243
{
public static readonly long[] Value={ 0L,1L,0L,0L,-3L,0L,2L,0L,0L,9L,-2L,0L,0L,-18L,0L,0L,-27L,0L,0L,36L,0L,0L,108L,0L,0L,81L,0L,152L,0L,0L,-360L,0L,0L,-540L,0L,0L,-243L,-152L,0L,0L,-16440L,0L,0L,2700L,0L,0L,2430L,0L,0L,729L,0L,0L,24240L,0L,0L,1311840L,0L,0L,-17010L,0L,0L,-10206L,0L,0L,-2187L,0L,6848L,0L,0L,-2974800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166243Inst : IEnumerable<long>
{
public static readonly long[] Value=A166243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166243.Bytes);
public long this[int i]=>Value[i];

public static A166243Inst Instance=new A166243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166244
{
public static readonly long[] Value={ 0L,1L,-3L,0L,0L,9L,0L,0L,2L,0L,-27L,0L,0L,-18L,0L,0L,-2L,81L,0L,0L,108L,0L,0L,36L,0L,0L,-243L,0L,0L,-540L,0L,0L,-360L,0L,0L,152L,0L,729L,0L,0L,2430L,0L,0L,2700L,0L,0L,-16440L,0L,0L,-152L,-2187L,0L,0L,-10206L,0L,0L,-17010L,0L,0L,1311840L,0L,0L,24240L,0L,0L,6561L,0L,0L,40824L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166244Inst : IEnumerable<long>
{
public static readonly long[] Value=A166244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166244.Bytes);
public long this[int i]=>Value[i];

public static A166244Inst Instance=new A166244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166245
{
public static readonly long[] Value={ 1L,2L,4L,8L,10L,12L,16L,20L,24L,26L,28L,32L,34L,36L,40L,42L,44L,48L,50L,52L,56L,58L,64L,66L,68L,72L,74L,76L,80L,84L,88L,90L,92L,96L,98L,100L,104L,106L,112L,114L,116L,120L,122L,128L,130L,132L,136L,138L,140L,144L,148L,152L,154L,156L,160L,162L,168L,170L,172L,176L,178L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166245Inst : IEnumerable<long>
{
public static readonly long[] Value=A166245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166245.Bytes);
public long this[int i]=>Value[i];

public static A166245Inst Instance=new A166245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166246
{
public static readonly long[] Value={ 2L,7L,13L,17L,19L,31L,37L,43L,53L,61L,67L,71L,79L,89L,97L,103L,107L,127L,139L,151L,157L,163L,179L,193L,197L,211L,223L,229L,233L,241L,251L,269L,271L,277L,283L,313L,331L,337L,349L,359L,367L,373L,379L,397L,409L,421L,431L,433L,439L,449L,457L,463L,467L,499L,503L,521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166246Inst : IEnumerable<long>
{
public static readonly long[] Value=A166246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166246.Bytes);
public long this[int i]=>Value[i];

public static A166246Inst Instance=new A166246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166247
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,6L,9L,12L,14L,16L,23L,25L,29L,34L,39L,44L,52L,55L,65L,69L,73L,80L,99L,105L,105L,115L,129L,132L,152L,151L,168L,183L,187L,200L,221L,224L,234L,251L,272L,278L,298L,297L,326L,336L,347L,361L,404L,422L,416L,428L,452L,462L,506L,512L,532L,540L,556L,581L,636L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166247Inst : IEnumerable<long>
{
public static readonly long[] Value=A166247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166247.Bytes);
public long this[int i]=>Value[i];

public static A166247Inst Instance=new A166247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166248
{
public static readonly long[] Value={ 1L,2L,2L,3L,1L,3L,1L,0L,3L,3L,11L,5L,15L,17L,21L,20L,34L,29L,45L,41L,49L,55L,75L,61L,78L,86L,98L,96L,122L,108L,136L,135L,151L,163L,183L,162L,196L,210L,230L,218L,256L,242L,282L,284L,294L,312L,356L,326L,365L,370L,398L,402L,452L,438L,474L,464L,496L,520L,576L,526L,584L,610L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166248Inst : IEnumerable<long>
{
public static readonly long[] Value=A166248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166248.Bytes);
public long this[int i]=>Value[i];

public static A166248Inst Instance=new A166248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166249
{
public static readonly long[] Value={ 1L,1L,0L,2L,5L,12L,22L,43L,84L,170L,341L,684L,1366L,2731L,5460L,10922L,21845L,43692L,87382L,174763L,349524L,699050L,1398101L,2796204L,5592406L,11184811L,22369620L,44739242L,89478485L,178956972L,357913942L,715827883L,1431655764L,2863311530L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166249Inst : IEnumerable<long>
{
public static readonly long[] Value=A166249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166249.Bytes);
public long this[int i]=>Value[i];

public static A166249Inst Instance=new A166249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166250
{
public static readonly long[] Value={ 2L,3L,5L,5L,8L,7L,11L,11L,14L,11L,17L,13L,20L,19L,23L,17L,26L,19L,29L,27L,32L,23L,35L,29L,38L,35L,41L,29L,44L,31L,47L,43L,50L,41L,53L,37L,56L,51L,59L,41L,62L,43L,65L,59L,68L,47L,71L,55L,74L,67L,77L,53L,80L,65L,83L,75L,86L,59L,89L,61L,92L,83L,95L,77L,98L,67L,101L,91L,104L,71L,107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166250Inst : IEnumerable<long>
{
public static readonly long[] Value=A166250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166250.Bytes);
public long this[int i]=>Value[i];

public static A166250Inst Instance=new A166250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166251
{
public static readonly long[] Value={ 5L,7L,23L,37L,79L,83L,89L,163L,211L,223L,257L,277L,317L,331L,337L,359L,383L,389L,397L,449L,457L,467L,479L,541L,547L,557L,563L,631L,673L,701L,709L,761L,787L,797L,839L,863L,877L,887L,919L,929L,977L,1129L,1181L,1201L,1213L,1237L,1283L,1307L,1327L,1361L,1399L,1409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166251Inst : IEnumerable<long>
{
public static readonly long[] Value=A166251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166251.Bytes);
public long this[int i]=>Value[i];

public static A166251Inst Instance=new A166251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166252
{
public static readonly long[] Value={ 71L,101L,109L,151L,181L,191L,229L,233L,239L,241L,269L,283L,311L,349L,373L,409L,419L,433L,439L,491L,571L,593L,599L,601L,607L,643L,647L,653L,659L,683L,727L,823L,827L,857L,941L,947L,991L,1021L,1031L,1033L,1051L,1061L,1063L,1091L,1103L,1301L,1373L,1427L,1429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166252Inst : IEnumerable<long>
{
public static readonly long[] Value=A166252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166252.Bytes);
public long this[int i]=>Value[i];

public static A166252Inst Instance=new A166252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166253
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,1L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166253Inst : IEnumerable<long>
{
public static readonly long[] Value=A166253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166253.Bytes);
public long this[int i]=>Value[i];

public static A166253Inst Instance=new A166253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166254
{
public static readonly BigInteger[] Value={ 1L,44L,1892L,81356L,3498308L,150427244L,6468371492L,278139974156L,11960018888708L,514280812214444L,22114074925220146L,950905221784425600L,BigInteger.Parse("40888924536728552592"),BigInteger.Parse("1758223755079252588512"),BigInteger.Parse("75603621468404628869424") };
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
public class A166254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166254Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166254.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A166254.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166254Inst Instance=new A166254Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166255
{
public static readonly long[] Value={ 71L,201L,1024L,1594L,10915L,36934L,51050L,60054L,60914L,71822L,80331L,85230L,92916L,96352L,103271L,114667L,151019L,158591L,183484L,184348L,193979L,196078L,223587L,277476L,295890L,309502L,317601L,334181L,338139L,369101L,485330L,494188L,530832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166255Inst : IEnumerable<long>
{
public static readonly long[] Value=A166255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166255.Bytes);
public long this[int i]=>Value[i];

public static A166255Inst Instance=new A166255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166256
{
public static readonly long[] Value={ 200L,322L,770L,982L,2848L,5552L,6622L,7236L,7292L,7972L,8472L,8750L,9166L,9350L,9708L,10272L,11922L,12242L,13246L,13280L,13648L,13728L,14736L,16552L,17134L,17556L,17800L,18294L,18410L,19296L,22352L,22570L,23454L,24120L,24340L,24424L,24432L,26194L,28740L,32248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166256Inst : IEnumerable<long>
{
public static readonly long[] Value=A166256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166256.Bytes);
public long this[int i]=>Value[i];

public static A166256Inst Instance=new A166256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166257
{
public static readonly long[] Value={ 1L,7L,11L,15L,17L,19L,23L,27L,29L,31L,35L,39L,41L,43L,47L,49L,51L,53L,55L,59L,63L,65L,67L,69L,71L,75L,77L,79L,83L,87L,89L,91L,95L,97L,99L,101L,103L,107L,109L,111L,113L,115L,119L,123L,125L,127L,129L,131L,135L,137L,139L,143L,147L,149L,151L,153L,155L,159L,161L,163L,167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166257Inst : IEnumerable<long>
{
public static readonly long[] Value=A166257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166257.Bytes);
public long this[int i]=>Value[i];

public static A166257Inst Instance=new A166257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166258
{
public static readonly BigInteger[] Value={ 1L,45L,1980L,87120L,3833280L,168664320L,7421230080L,326534123520L,14367501434880L,632170063134720L,27815482777926690L,1223881242228730800L,BigInteger.Parse("53850774658062239550"),BigInteger.Parse("2369434084954654251600"),BigInteger.Parse("104255099738001078372000") };
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
public class A166258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166258Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166258.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A166258.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166258Inst Instance=new A166258Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166259
{
public static readonly long[] Value={ 2L,18L,32L,50L,72L,98L,128L,162L,200L,242L,338L,392L,450L,512L,578L,648L,722L,882L,968L,1058L,1152L,1250L,1352L,1458L,1682L,1800L,1922L,2048L,2178L,2312L,2401L,2450L,2662L,2738L,2809L,2888L,3042L,3174L,3200L,3362L,3528L,3698L,3750L,4050L,4225L,4232L,4418L,4489L,4608L,4802L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166259Inst : IEnumerable<long>
{
public static readonly long[] Value=A166259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166259.Bytes);
public long this[int i]=>Value[i];

public static A166259Inst Instance=new A166259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166260
{
public static readonly long[] Value={ 0L,1L,2L,0L,4L,0L,6L,0L,0L,0L,10L,0L,12L,0L,0L,0L,16L,0L,18L,0L,0L,0L,22L,0L,0L,0L,0L,0L,28L,0L,30L,0L,0L,0L,0L,0L,36L,0L,0L,0L,40L,0L,42L,0L,0L,0L,46L,0L,0L,0L,0L,0L,52L,0L,0L,0L,0L,0L,58L,0L,60L,0L,0L,0L,0L,0L,66L,0L,0L,0L,70L,0L,72L,0L,0L,0L,0L,0L,78L,0L,0L,0L,82L,0L,0L,0L,0L,0L,88L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166260Inst : IEnumerable<long>
{
public static readonly long[] Value=A166260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166260.Bytes);
public long this[int i]=>Value[i];

public static A166260Inst Instance=new A166260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166261
{
public static readonly long[] Value={ 10917L,11527L,50923L,73894L,111468L,118436L,128662L,139123L,195234L,249281L,332863L,435489L,438080L,482557L,538373L,542299L,650254L,679958L,722145L,803501L,810871L,820409L,962582L,970711L,1003544L,1027732L,1030010L,1190134L,1204929L,1305603L,1636065L,1689410L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166261Inst : IEnumerable<long>
{
public static readonly long[] Value=A166261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166261.Bytes);
public long this[int i]=>Value[i];

public static A166261Inst Instance=new A166261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166262
{
public static readonly long[] Value={ 3734L,3846L,8660L,10602L,13248L,13690L,14318L,14936L,17934L,20458L,23902L,27614L,27704L,29176L,30942L,31064L,34238L,35070L,36216L,38346L,38532L,38774L,42236L,42428L,43190L,43742L,43794L,47308L,47622L,49708L,56070L,57036L,58856L,65692L,66122L,66940L,68016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166262Inst : IEnumerable<long>
{
public static readonly long[] Value=A166262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166262.Bytes);
public long this[int i]=>Value[i];

public static A166262Inst Instance=new A166262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166263
{
public static readonly long[] Value={ 348511L,38L,155L,389L,778L,1296L,1828L,2321L,3683L,3935L,4078L,6184L,8783L,9013L,9880L,15182L,12449L,19828L,18884L,14593L,22316L,25738L,26064L,26670L,31953L,33332L,45025L,35788L,37881L,50299L,39562L,49598L,77850L,56777L,53024L,70443L,71992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166263Inst : IEnumerable<long>
{
public static readonly long[] Value=A166263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166263.Bytes);
public long this[int i]=>Value[i];

public static A166263Inst Instance=new A166263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166264
{
public static readonly long[] Value={ 174195L,6L,16L,25L,31L,34L,41L,37L,68L,45L,47L,85L,68L,95L,93L,83L,73L,101L,103L,85L,115L,109L,106L,154L,107L,132L,159L,114L,163L,179L,128L,132L,216L,164L,120L,209L,150L,119L,237L,216L,175L,228L,150L,221L,222L,192L,214L,262L,241L,185L,289L,196L,181L,379L,189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166264Inst : IEnumerable<long>
{
public static readonly long[] Value=A166264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166264.Bytes);
public long this[int i]=>Value[i];

public static A166264Inst Instance=new A166264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166265
{
public static readonly long[] Value={ 3L,6L,9L,11L,14L,18L,19L,21L,26L,27L,30L,33L,35L,38L,41L,42L,46L,51L,53L,54L,59L,62L,66L,69L,73L,74L,75L,81L,83L,86L,90L,91L,98L,99L,101L,102L,105L,107L,110L,114L,117L,118L,123L,126L,129L,131L,137L,138L,146L,147L,149L,150L,154L,158L,161L,163L,165L,170L,171L,174L,179L,181L,182L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166265Inst : IEnumerable<long>
{
public static readonly long[] Value=A166265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166265.Bytes);
public long this[int i]=>Value[i];

public static A166265Inst Instance=new A166265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166266
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,3L,5L,7L,4L,8L,8L,10L,10L,12L,14L,15L,15L,16L,22L,19L,25L,29L,25L,31L,25L,31L,28L,39L,32L,35L,41L,42L,46L,47L,46L,52L,49L,52L,59L,53L,59L,55L,75L,69L,58L,68L,62L,85L,81L,82L,55L,81L,82L,89L,89L,97L,87L,96L,92L,95L,103L,99L,120L,105L,105L,113L,106L,126L,125L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166266Inst : IEnumerable<long>
{
public static readonly long[] Value=A166266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166266.Bytes);
public long this[int i]=>Value[i];

public static A166266Inst Instance=new A166266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166267
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,4L,3L,4L,4L,7L,5L,8L,6L,7L,10L,11L,10L,8L,13L,12L,12L,14L,16L,17L,11L,14L,17L,20L,16L,17L,19L,21L,23L,17L,17L,19L,24L,24L,25L,18L,29L,26L,29L,26L,26L,29L,35L,29L,26L,40L,29L,33L,33L,38L,36L,34L,28L,38L,42L,40L,37L,34L,40L,27L,45L,35L,37L,41L,40L,44L,48L,45L,41L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166267Inst : IEnumerable<long>
{
public static readonly long[] Value=A166267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166267.Bytes);
public long this[int i]=>Value[i];

public static A166267Inst Instance=new A166267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166268
{
public static readonly long[] Value={ 1L,3L,4L,5L,5L,5L,7L,2L,9L,7L,6L,11L,8L,10L,1L,9L,14L,10L,15L,7L,7L,14L,14L,16L,8L,13L,13L,12L,18L,14L,13L,15L,0L,16L,9L,0L,22L,16L,19L,16L,11L,17L,16L,23L,19L,9L,22L,18L,16L,2L,18L,27L,12L,23L,11L,15L,24L,4L,27L,9L,23L,23L,20L,0L,19L,15L,22L,24L,22L,17L,18L,28L,26L,27L,17L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166268Inst : IEnumerable<long>
{
public static readonly long[] Value=A166268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166268.Bytes);
public long this[int i]=>Value[i];

public static A166268Inst Instance=new A166268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166269
{
public static readonly long[] Value={ -1L,-1L,-1L,-2L,-2L,-3L,-1L,-2L,-3L,-2L,-4L,-3L,-3L,-3L,-4L,-3L,-2L,-2L,-6L,0L,-3L,-5L,-3L,-5L,-4L,-5L,-3L,-4L,-5L,-4L,-5L,-4L,-5L,-7L,-6L,-7L,-3L,-3L,0L,-4L,-8L,-4L,-4L,-5L,-2L,-6L,-5L,-6L,-7L,-8L,-6L,-4L,-6L,-9L,-6L,-8L,-6L,-4L,-4L,-4L,-11L,-7L,-4L,-11L,-4L,-9L,-6L,-7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166269Inst : IEnumerable<long>
{
public static readonly long[] Value=A166269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166269.Bytes);
public long this[int i]=>Value[i];

public static A166269Inst Instance=new A166269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166270
{
public static readonly long[] Value={ 2L,6L,8L,10L,10L,10L,14L,4L,18L,14L,12L,22L,16L,20L,2L,18L,28L,20L,30L,14L,14L,28L,28L,32L,16L,26L,26L,24L,36L,28L,26L,30L,0L,32L,18L,0L,44L,32L,38L,32L,22L,34L,32L,46L,38L,18L,44L,36L,32L,4L,36L,54L,24L,46L,22L,30L,48L,8L,54L,18L,46L,46L,40L,0L,38L,30L,44L,48L,44L,34L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166270Inst : IEnumerable<long>
{
public static readonly long[] Value=A166270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166270.Bytes);
public long this[int i]=>Value[i];

public static A166270Inst Instance=new A166270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166271
{
public static readonly long[] Value={ 2L,2L,2L,4L,4L,6L,2L,4L,6L,4L,8L,6L,6L,6L,8L,6L,4L,4L,12L,0L,6L,10L,6L,10L,8L,10L,6L,8L,10L,8L,10L,8L,10L,14L,12L,14L,6L,6L,0L,8L,16L,8L,8L,10L,4L,12L,10L,12L,14L,16L,12L,8L,12L,18L,12L,16L,12L,8L,8L,8L,22L,14L,8L,22L,8L,18L,12L,14L,16L,4L,22L,10L,10L,16L,16L,20L,12L,10L,20L,12L,16L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166271Inst : IEnumerable<long>
{
public static readonly long[] Value=A166271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166271.Bytes);
public long this[int i]=>Value[i];

public static A166271Inst Instance=new A166271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166272
{
public static readonly long[] Value={ 1L,13L,29L,121L,164L,269L,407L,758L,749L,1093L,1217L,1484L,2459L,2429L,3242L,3671L,4133L,3298L,5132L,6830L,7454L,6749L,9841L,10208L,8158L,10961L,11747L,13364L,15149L,17012L,18983L,15178L,19964L,22139L,18749L,25544L,21869L,27947L,29186L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166272Inst : IEnumerable<long>
{
public static readonly long[] Value=A166272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166272.Bytes);
public long this[int i]=>Value[i];

public static A166272Inst Instance=new A166272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166273
{
public static readonly long[] Value={ 3L,3L,3L,6L,6L,9L,3L,6L,9L,6L,12L,9L,9L,9L,12L,9L,6L,6L,18L,0L,9L,15L,9L,15L,12L,15L,9L,12L,15L,12L,15L,12L,15L,21L,18L,21L,9L,9L,0L,12L,24L,12L,12L,15L,6L,18L,15L,18L,21L,24L,18L,12L,18L,27L,18L,24L,18L,12L,12L,12L,33L,21L,12L,33L,12L,27L,18L,21L,24L,6L,33L,15L,15L,24L,24L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166273Inst : IEnumerable<long>
{
public static readonly long[] Value=A166273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166273.Bytes);
public long this[int i]=>Value[i];

public static A166273Inst Instance=new A166273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166274
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,8L,9L,10L,14L,15L,16L,17L,18L,20L,22L,30L,31L,32L,33L,34L,35L,36L,37L,38L,42L,46L,62L,63L,64L,65L,66L,67L,68L,69L,70L,72L,74L,76L,78L,86L,94L,126L,127L,128L,129L,130L,131L,132L,133L,134L,135L,136L,137L,138L,140L,141L,142L,146L,150L,154L,158L,174L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166274Inst : IEnumerable<long>
{
public static readonly long[] Value=A166274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166274.Bytes);
public long this[int i]=>Value[i];

public static A166274Inst Instance=new A166274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166275
{
public static readonly long[] Value={ 5L,11L,12L,13L,19L,21L,23L,24L,25L,26L,27L,28L,29L,39L,40L,41L,43L,44L,45L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,71L,73L,75L,77L,79L,80L,81L,82L,83L,84L,85L,87L,88L,89L,90L,91L,92L,93L,95L,96L,97L,98L,99L,100L,101L,102L,103L,104L,105L,106L,107L,108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166275Inst : IEnumerable<long>
{
public static readonly long[] Value=A166275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166275.Bytes);
public long this[int i]=>Value[i];

public static A166275Inst Instance=new A166275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166276
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,9L,6L,7L,8L,14L,10L,23L,16L,25L,11L,12L,13L,21L,15L,34L,24L,36L,17L,53L,38L,55L,27L,79L,40L,58L,18L,19L,20L,32L,22L,49L,35L,51L,26L,75L,54L,77L,39L,109L,57L,81L,28L,113L,83L,115L,60L,159L,85L,118L,42L,219L,120L,164L,62L,223L,88L,123L,29L,30L,31L,47L,33L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166276Inst : IEnumerable<long>
{
public static readonly long[] Value=A166276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166276.Bytes);
public long this[int i]=>Value[i];

public static A166276Inst Instance=new A166276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166277
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,6L,8L,9L,12L,10L,19L,13L,20L,11L,14L,15L,21L,16L,30L,22L,31L,17L,45L,32L,46L,23L,67L,33L,47L,18L,24L,25L,34L,26L,48L,35L,49L,27L,68L,50L,69L,36L,97L,51L,70L,28L,98L,71L,99L,52L,139L,72L,100L,37L,195L,101L,140L,53L,196L,73L,102L,29L,38L,39L,54L,40L,74L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166277Inst : IEnumerable<long>
{
public static readonly long[] Value=A166277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166277.Bytes);
public long this[int i]=>Value[i];

public static A166277Inst Instance=new A166277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166278
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,2L,0L,1L,3L,3L,0L,1L,4L,6L,4L,0L,1L,6L,10L,10L,5L,0L,1L,8L,19L,20L,15L,6L,0L,1L,12L,33L,46L,35L,21L,7L,0L,1L,16L,63L,100L,94L,56L,28L,8L,0L,1L,24L,111L,220L,242L,172L,84L,36L,9L,0L,1L,32L,201L,488L,633L,514L,290L,120L,45L,10L,0L,1L,48L,369L,1104L,1643L,1518L,984L,460L,165L,55L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166278Inst : IEnumerable<long>
{
public static readonly long[] Value=A166278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166278.Bytes);
public long this[int i]=>Value[i];

public static A166278Inst Instance=new A166278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166279
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,2L,2L,1L,1L,1L,0L,0L,1L,1L,1L,2L,1L,0L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,2L,1L,0L,0L,0L,0L,0L,1L,2L,1L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,1L,2L,2L,2L,1L,0L,0L,0L,1L,2L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166279Inst : IEnumerable<long>
{
public static readonly long[] Value=A166279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166279.Bytes);
public long this[int i]=>Value[i];

public static A166279Inst Instance=new A166279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166280
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,1L,0L,0L,0L,1L,1L,1L,1L,0L,1L,0L,0L,0L,1L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,0L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,0L,0L,0L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166280Inst : IEnumerable<long>
{
public static readonly long[] Value=A166280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166280.Bytes);
public long this[int i]=>Value[i];

public static A166280Inst Instance=new A166280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166281
{
public static readonly long[] Value={ 1L,2L,3L,4L,2L,3L,8L,3L,3L,8L,8L,8L,3L,3L,20L,2L,3L,4L,8L,13L,16L,3L,3L,3L,26L,3L,3L,20L,13L,8L,8L,3L,48L,2L,8L,3L,8L,20L,3L,20L,3L,3L,44L,3L,8L,32L,3L,13L,8L,3L,13L,76L,3L,8L,8L,3L,13L,48L,8L,3L,44L,3L,3L,3L,20L,44L,3L,8L,3L,3L,3L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166281Inst : IEnumerable<long>
{
public static readonly long[] Value=A166281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166281.Bytes);
public long this[int i]=>Value[i];

public static A166281Inst Instance=new A166281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166282
{
public static readonly long[] Value={ 1L,-1L,1L,-1L,0L,1L,1L,-1L,-1L,1L,-1L,0L,0L,0L,1L,1L,-1L,0L,0L,-1L,1L,1L,0L,-1L,0L,-1L,0L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,-1L,0L,0L,0L,0L,0L,0L,-1L,1L,1L,0L,-1L,0L,0L,0L,0L,0L,-1L,0L,1L,-1L,1L,1L,-1L,0L,0L,0L,0L,1L,-1L,-1L,1L,1L,0L,0L,0L,-1L,0L,0L,0L,-1L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166282Inst : IEnumerable<long>
{
public static readonly long[] Value=A166282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166282.Bytes);
public long this[int i]=>Value[i];

public static A166282Inst Instance=new A166282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166283
{
public static readonly long[] Value={ 3L,7L,13L,37L,59L,61L,83L,103L,113L,149L,151L,179L,181L,197L,199L,251L,263L,269L,271L,283L,353L,421L,431L,439L,479L,487L,523L,631L,643L,653L,661L,677L,709L,769L,811L,829L,853L,937L,947L,1019L,1039L,1049L,1051L,1277L,1319L,1399L,1427L,1433L,1489L,1543L,1663L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166283Inst : IEnumerable<long>
{
public static readonly long[] Value=A166283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166283.Bytes);
public long this[int i]=>Value[i];

public static A166283Inst Instance=new A166283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166284
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,4L,3L,1L,7L,7L,3L,13L,17L,6L,1L,26L,36L,16L,4L,52L,77L,45L,10L,1L,104L,173L,111L,30L,5L,212L,387L,268L,95L,15L,1L,438L,857L,666L,266L,50L,6L,910L,1911L,1641L,714L,175L,21L,1L,1903L,4287L,3975L,1940L,546L,77L,7L,4009L,9619L,9606L,5205L,1610L,294L,28L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166284Inst : IEnumerable<long>
{
public static readonly long[] Value=A166284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166284.Bytes);
public long this[int i]=>Value[i];

public static A166284Inst Instance=new A166284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166285
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,5L,3L,9L,8L,17L,19L,1L,34L,43L,5L,70L,97L,18L,147L,219L,56L,1L,313L,498L,160L,7L,673L,1140L,438L,32L,1459L,2623L,1168L,122L,1L,3185L,6061L,3062L,418L,9L,6995L,14053L,7932L,1342L,50L,15445L,32677L,20360L,4124L,225L,1L,34265L,76171L,51886L,12274L,895L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166285Inst : IEnumerable<long>
{
public static readonly long[] Value=A166285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166285.Bytes);
public long this[int i]=>Value[i];

public static A166285Inst Instance=new A166285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166286
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,9L,17L,34L,70L,147L,313L,673L,1459L,3185L,6995L,15445L,34265L,76342L,170744L,383214L,862814L,1948299L,4411167L,10011973L,22775773L,51920833L,118593423L,271376295L,622047011L,1428128025L,3283679333L,7560750299L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166286Inst : IEnumerable<long>
{
public static readonly long[] Value=A166286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166286.Bytes);
public long this[int i]=>Value[i];

public static A166286Inst Instance=new A166286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166287
{
public static readonly long[] Value={ 0L,0L,0L,1L,3L,8L,21L,53L,133L,334L,839L,2112L,5329L,13475L,34143L,86674L,220400L,561309L,1431522L,3655480L,9345287L,23916622L,61267207L,157088278L,403103955L,1035192885L,2660312103L,6841157380L,17603254230L,45321606641L,116748360064L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166287Inst : IEnumerable<long>
{
public static readonly long[] Value=A166287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166287.Bytes);
public long this[int i]=>Value[i];

public static A166287Inst Instance=new A166287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166288
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,4L,1L,1L,4L,5L,6L,1L,1L,6L,12L,9L,8L,1L,1L,9L,23L,24L,14L,10L,1L,1L,17L,38L,56L,40L,20L,12L,1L,1L,26L,84L,100L,110L,60L,27L,14L,1L,1L,46L,145L,250L,210L,190L,84L,35L,16L,1L,1L,81L,280L,480L,580L,385L,301L,112L,44L,18L,1L,1L,135L,551L,995L,1225L,1155L,644L,448L,144L,54L,20L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166288Inst : IEnumerable<long>
{
public static readonly long[] Value=A166288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166288.Bytes);
public long this[int i]=>Value[i];

public static A166288Inst Instance=new A166288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166289
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,4L,6L,9L,17L,26L,46L,81L,135L,246L,428L,757L,1373L,2431L,4411L,7990L,14434L,26423L,48137L,88144L,162086L,297662L,549342L,1014677L,1876551L,3480596L,6458974L,12008923L,22361683L,41675773L,77797373L,145368548L,271917704L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166289Inst : IEnumerable<long>
{
public static readonly long[] Value=A166289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166289.Bytes);
public long this[int i]=>Value[i];

public static A166289Inst Instance=new A166289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166290
{
public static readonly long[] Value={ 0L,0L,1L,3L,9L,24L,63L,164L,423L,1088L,2794L,7168L,18385L,47158L,120991L,310537L,797381L,2048456L,5265059L,13539331L,34834238L,89665630L,230913976L,594938458L,1533501169L,3954384384L,10201142803L,26326101399L,67964928779L,175524139820L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166290Inst : IEnumerable<long>
{
public static readonly long[] Value=A166290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166290.Bytes);
public long this[int i]=>Value[i];

public static A166290Inst Instance=new A166290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166291
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,1L,2L,0L,1L,2L,2L,3L,0L,1L,3L,6L,3L,4L,0L,1L,5L,10L,12L,4L,5L,0L,1L,8L,20L,22L,20L,5L,6L,0L,1L,13L,36L,52L,40L,30L,6L,7L,0L,1L,21L,66L,104L,109L,65L,42L,7L,8L,0L,1L,34L,118L,214L,240L,200L,98L,56L,8L,9L,0L,1L,55L,210L,421L,549L,481L,335L,140L,72L,9L,10L,0L,1L,89L,370L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166291Inst : IEnumerable<long>
{
public static readonly long[] Value=A166291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166291.Bytes);
public long this[int i]=>Value[i];

public static A166291Inst Instance=new A166291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166292
{
public static readonly long[] Value={ 0L,1L,2L,5L,12L,29L,72L,181L,460L,1178L,3030L,7815L,20188L,52193L,134992L,349205L,903398L,2337135L,6046310L,15642402L,40469824L,104708914L,270937964L,701129755L,1814581514L,4696886211L,12159165336L,31481922733L,81523933604L,211143257951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166292Inst : IEnumerable<long>
{
public static readonly long[] Value=A166292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166292.Bytes);
public long this[int i]=>Value[i];

public static A166292Inst Instance=new A166292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166293
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,4L,7L,4L,1L,1L,5L,13L,12L,5L,1L,1L,6L,22L,28L,18L,6L,1L,1L,7L,35L,59L,50L,25L,7L,1L,1L,8L,54L,114L,124L,80L,33L,8L,1L,1L,9L,82L,210L,279L,226L,119L,42L,9L,1L,1L,10L,124L,374L,592L,576L,375L,168L,52L,10L,1L,1L,11L,188L,653L,1199L,1374L,1062L,582L,228L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166293Inst : IEnumerable<long>
{
public static readonly long[] Value=A166293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166293.Bytes);
public long this[int i]=>Value[i];

public static A166293Inst Instance=new A166293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166294
{
public static readonly long[] Value={ 0L,1L,4L,12L,34L,92L,242L,628L,1616L,4138L,10570L,26970L,68798L,175545L,448176L,1145058L,2927924L,7493021L,19191836L,49195806L,126205062L,324000494L,832371414L,2139802870L,5504256592L,14166936063L,36483006046L,94000206216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166294Inst : IEnumerable<long>
{
public static readonly long[] Value=A166294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166294.Bytes);
public long this[int i]=>Value[i];

public static A166294Inst Instance=new A166294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166295
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,6L,2L,12L,5L,26L,10L,1L,57L,22L,3L,128L,48L,9L,291L,109L,22L,1L,670L,250L,54L,4L,1558L,582L,129L,14L,3655L,1366L,311L,40L,1L,8639L,3232L,750L,109L,5L,20554L,7696L,1818L,284L,20L,49185L,18432L,4419L,730L,65L,1L,118301L,44368L,10776L,1856L,195L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166295Inst : IEnumerable<long>
{
public static readonly long[] Value=A166295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166295.Bytes);
public long this[int i]=>Value[i];

public static A166295Inst Instance=new A166295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166296
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,12L,26L,57L,128L,291L,670L,1558L,3655L,8639L,20554L,49185L,118301L,285840L,693480L,1688683L,4125882L,10111393L,24849532L,61226546L,151212789L,374271925L,928254590L,2306569185L,5741561804L,14315544330L,35748249574L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166296Inst : IEnumerable<long>
{
public static readonly long[] Value=A166296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166296.Bytes);
public long this[int i]=>Value[i];

public static A166296Inst Instance=new A166296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166297
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,5L,12L,28L,66L,156L,370L,882L,2112L,5079L,12264L,29725L,72298L,176414L,431754L,1059595L,2607090L,6429913L,15893330L,39365876L,97692372L,242875105L,604836072L,1508619585L,3768496102L,9426815859L,23612178180L,59217406914L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166297Inst : IEnumerable<long>
{
public static readonly long[] Value=A166297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166297.Bytes);
public long this[int i]=>Value[i];

public static A166297Inst Instance=new A166297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166298
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,19L,140L,956L,6506L,45659L,336996L,2643979L,22160244L,198618081L,1901082872L,19381817300L,209829985306L,2404750030651L,29088407474132L,370369420974335L,4951491489003676L,69348849926870881L,1015423795024288712L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166298Inst : IEnumerable<long>
{
public static readonly long[] Value=A166298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166298.Bytes);
public long this[int i]=>Value[i];

public static A166298Inst Instance=new A166298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166299
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,1L,0L,1L,2L,2L,0L,5L,2L,0L,1L,10L,4L,3L,0L,22L,11L,3L,0L,1L,50L,22L,6L,4L,0L,113L,49L,18L,4L,0L,1L,260L,114L,36L,8L,5L,0L,605L,260L,81L,26L,5L,0L,1L,1418L,604L,193L,52L,10L,6L,0L,3350L,1419L,444L,118L,35L,6L,0L,1L,7967L,3350L,1041L,288L,70L,12L,7L,0L,19055L,7966L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166299Inst : IEnumerable<long>
{
public static readonly long[] Value=A166299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166299.Bytes);
public long this[int i]=>Value[i];

public static A166299Inst Instance=new A166299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166300
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,2L,5L,10L,22L,50L,113L,260L,605L,1418L,3350L,7967L,19055L,45810L,110637L,268301L,653066L,1594980L,3907395L,9599326L,23643751L,58374972L,144442170L,358136905L,889671937L,2214015802L,5518884019L,13778312440L,34448765740L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166300Inst : IEnumerable<long>
{
public static readonly long[] Value=A166300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166300.Bytes);
public long this[int i]=>Value[i];

public static A166300Inst Instance=new A166300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166301
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,2L,0L,0L,0L,0L,1L,3L,0L,0L,0L,0L,1L,2L,5L,0L,0L,0L,0L,1L,2L,6L,8L,0L,0L,0L,0L,1L,2L,8L,13L,13L,0L,0L,0L,0L,1L,2L,10L,19L,29L,21L,0L,0L,0L,0L,1L,2L,12L,25L,51L,60L,34L,0L,0L,0L,0L,1L,2L,14L,31L,78L,120L,122L,55L,0L,0L,0L,0L,1L,2L,16L,37L,110L,200L,282L,241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166301Inst : IEnumerable<long>
{
public static readonly long[] Value=A166301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166301.Bytes);
public long this[int i]=>Value[i];

public static A166301Inst Instance=new A166301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166302
{
public static readonly long[] Value={ 0L,0L,2L,3L,8L,19L,44L,106L,257L,628L,1549L,3844L,9588L,24020L,60391L,152298L,385085L,975904L,2478129L,6303861L,16060946L,40977605L,104682165L,267730426L,685451776L,1756593392L,4505537267L,11565724164L,29711413595L,76379060176L,196473781247L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166302Inst : IEnumerable<long>
{
public static readonly long[] Value=A166302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166302.Bytes);
public long this[int i]=>Value[i];

public static A166302Inst Instance=new A166302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166303
{
public static readonly BigInteger[] Value={ 1L,46L,2070L,93150L,4191750L,188628750L,8488293750L,381973218750L,17188794843750L,773495767968750L,34807309558592715L,1566328930136625600L,BigInteger.Parse("70484801856146057160"),BigInteger.Parse("3171816083526478304400"),BigInteger.Parse("142731723758687281647000") };
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
public class A166303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166303Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166303.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A166303.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166303Inst Instance=new A166303Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166304
{
public static readonly long[] Value={ 4L,5L,16L,11L,28L,17L,40L,23L,52L,29L,64L,35L,76L,41L,88L,47L,100L,53L,112L,59L,124L,65L,136L,71L,148L,77L,160L,83L,172L,89L,184L,95L,196L,101L,208L,107L,220L,113L,232L,119L,244L,125L,256L,131L,268L,137L,280L,143L,292L,149L,304L,155L,316L,161L,328L,167L,340L,173L,352L,179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166304Inst : IEnumerable<long>
{
public static readonly long[] Value=A166304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166304.Bytes);
public long this[int i]=>Value[i];

public static A166304Inst Instance=new A166304Inst();

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