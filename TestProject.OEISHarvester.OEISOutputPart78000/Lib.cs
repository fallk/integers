using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A097641
{
public static readonly long[] Value={ 1L,2L,135L,2537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097641Inst : IEnumerable<long>
{
public static readonly long[] Value=A097641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097641.Bytes);
public long this[int i]=>Value[i];

public static A097641Inst Instance=new A097641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097642
{
public static readonly long[] Value={ 3L,115L,6576L,80855L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097642Inst : IEnumerable<long>
{
public static readonly long[] Value=A097642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097642.Bytes);
public long this[int i]=>Value[i];

public static A097642Inst Instance=new A097642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097643
{
public static readonly long[] Value={ 4L,46L,478L,944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097643Inst : IEnumerable<long>
{
public static readonly long[] Value=A097643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097643.Bytes);
public long this[int i]=>Value[i];

public static A097643Inst Instance=new A097643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097644
{
public static readonly long[] Value={ 51L,130L,370L,8201L,73270L,82080L,26113610L,4854248220L,37682961610L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097644Inst : IEnumerable<long>
{
public static readonly long[] Value=A097644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097644.Bytes);
public long this[int i]=>Value[i];

public static A097644Inst Instance=new A097644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097645
{
public static readonly long[] Value={ 1L,6L,54L,78L,1296L,1482L,6480L,6552L,14040L,20160L,36936L,1273896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097645Inst : IEnumerable<long>
{
public static readonly long[] Value=A097645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097645.Bytes);
public long this[int i]=>Value[i];

public static A097645Inst Instance=new A097645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097646
{
public static readonly long[] Value={ 1L,2L,6L,10L,20L,22L,46L,48L,58L,82L,106L,166L,178L,180L,208L,226L,262L,346L,358L,382L,466L,478L,502L,562L,586L,718L,838L,862L,864L,886L,982L,1018L,1120L,1186L,1282L,1306L,1318L,1366L,1368L,1438L,1486L,1522L,1618L,1822L,1906L,2026L,2038L,2062L,2098L,2206L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097646Inst : IEnumerable<long>
{
public static readonly long[] Value=A097646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097646.Bytes);
public long this[int i]=>Value[i];

public static A097646Inst Instance=new A097646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097647
{
public static readonly long[] Value={ 190L,427L,429L,724L,924L,4147L,4697L,6276L,6726L,7414L,7964L,9079L,9709L,10040L,10940L,14450L,15860L,19190L,20493L,20553L,28092L,28215L,29082L,35502L,39402L,41847L,42777L,44629L,46899L,49929L,51282L,51845L,53075L,54815L,57035L,57677L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097647Inst : IEnumerable<long>
{
public static readonly long[] Value=A097647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097647.Bytes);
public long this[int i]=>Value[i];

public static A097647Inst Instance=new A097647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097648
{
public static readonly long[] Value={ 10040L,110440L,1014040L,11154440L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097648Inst : IEnumerable<long>
{
public static readonly long[] Value=A097648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097648.Bytes);
public long this[int i]=>Value[i];

public static A097648Inst Instance=new A097648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097649
{
public static readonly long[] Value={ 1L,11L,101L,1111L,10291L,100651L,1004251L,10165751L,100064101L,1000078501L,10000222501L,100062501601L,1000062516001L,10000062660001L,100002441447211L,1003922328562757L,10000390625025601L,100000002482366251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097649Inst : IEnumerable<long>
{
public static readonly long[] Value=A097649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097649.Bytes);
public long this[int i]=>Value[i];

public static A097649Inst Instance=new A097649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097650
{
public static readonly long[] Value={ 0L,1L,1L,111L,291L,651L,4251L,165751L,64101L,78501L,222501L,62501601L,62516001L,62660001L,2441447211L,3922328562757L,390625025601L,2482366251L,2851006251L,62500000160001L,390881000001L,412041406251L,15259444422501L,40002500000001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097650Inst : IEnumerable<long>
{
public static readonly long[] Value=A097650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097650.Bytes);
public long this[int i]=>Value[i];

public static A097650Inst Instance=new A097650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097651
{
public static readonly long[] Value={ 2L,11L,37L,169L,917L,1087L,15407L,10379L,30451L,64591L,187063L,498419L,1304707L,3523969L,9558541L,26042629L,73134517L,189963073L,528839387L,1394194181L,3779851321L,10246935931L,27800769133L,75370121689L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097651Inst : IEnumerable<long>
{
public static readonly long[] Value=A097651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097651.Bytes);
public long this[int i]=>Value[i];

public static A097651Inst Instance=new A097651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097652
{
public static readonly long[] Value={ 1L,2L,20L,48L,180L,208L,864L,1120L,1368L,3552L,58320L,76416L,79968L,95488L,107520L,338688L,570240L,595968L,653184L,1347840L,5199552L,7918848L,14592000L,93699072L,159138176L,167078784L,246688000L,281640960L,314548224L,323985408L,338411520L,347578368L,352002048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097652Inst : IEnumerable<long>
{
public static readonly long[] Value=A097652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097652.Bytes);
public long this[int i]=>Value[i];

public static A097652Inst Instance=new A097652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097653
{
public static readonly long[] Value={ 1L,2L,3L,107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097653Inst : IEnumerable<long>
{
public static readonly long[] Value=A097653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097653.Bytes);
public long this[int i]=>Value[i];

public static A097653Inst Instance=new A097653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097654
{
public static readonly long[] Value={ 1L,2L,3L,380L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097654Inst : IEnumerable<long>
{
public static readonly long[] Value=A097654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097654.Bytes);
public long this[int i]=>Value[i];

public static A097654Inst Instance=new A097654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097655
{
public static readonly BigInteger[] Value={ 1L,2L,3L,15L,18432L,75600L,276531978240000L,BigInteger.Parse("4810168001497883738112000"),BigInteger.Parse("215788176336727572480000000"),BigInteger.Parse("2178419737991700039289327133392896000000000000") };
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
public class A097655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097655Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097655.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A097655.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097655Inst Instance=new A097655Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097656
{
public static readonly long[] Value={ 2L,4L,9L,24L,81L,358L,2021L,13828L,109857L,986922L,9865125L,108507160L,1302065441L,16926805678L,236975181189L,3554627504844L,56874039618753L,966858672535762L,17403456103546565L,330665665962928288L,6613313319249128577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097656Inst : IEnumerable<long>
{
public static readonly long[] Value=A097656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097656.Bytes);
public long this[int i]=>Value[i];

public static A097656Inst Instance=new A097656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097657
{
public static readonly long[] Value={ 11L,23L,34L,57L,91L,148L,239L,387L,626L,1013L,1639L,2652L,4291L,6943L,11234L,18177L,29411L,47588L,76999L,124587L,201586L,326173L,527759L,853932L,1381691L,2235623L,3617314L,5852937L,9470251L,15323188L,24793439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097657Inst : IEnumerable<long>
{
public static readonly long[] Value=A097657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097657.Bytes);
public long this[int i]=>Value[i];

public static A097657Inst Instance=new A097657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097658
{
public static readonly long[] Value={ 0L,9L,24L,45L,72L,105L,144L,189L,240L,297L,360L,429L,504L,585L,672L,765L,864L,969L,1080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097658Inst : IEnumerable<long>
{
public static readonly long[] Value=A097658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097658.Bytes);
public long this[int i]=>Value[i];

public static A097658Inst Instance=new A097658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097659
{
public static readonly BigInteger[] Value={ 1L,1001L,1002001L,1003003001L,1004006004001L,1005010010005001L,1006015020015006001L,BigInteger.Parse("1007021035035021007001"),BigInteger.Parse("1008028056070056028008001"),BigInteger.Parse("1009036084126126084036009001"),BigInteger.Parse("1010045120210252210120045010001") };
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
public class A097659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097659Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097659.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A097659.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097659Inst Instance=new A097659Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097660
{
public static readonly long[] Value={ 0L,2L,4L,6L,8L,10L,10L,10L,12L,10L,12L,8L,8L,6L,18L,14L,10L,10L,8L,5L,12L,14L,9L,7L,10L,18L,14L,13L,15L,13L,15L,10L,14L,12L,17L,16L,17L,15L,13L,21L,24L,15L,9L,16L,12L,22L,20L,21L,20L,16L,19L,16L,21L,20L,25L,20L,20L,21L,26L,19L,20L,19L,22L,19L,17L,23L,28L,24L,22L,20L,27L,26L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097660Inst : IEnumerable<long>
{
public static readonly long[] Value=A097660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097660.Bytes);
public long this[int i]=>Value[i];

public static A097660Inst Instance=new A097660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097661
{
public static readonly long[] Value={ 4L,7L,16L,44L,1376L,1885518L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097661Inst : IEnumerable<long>
{
public static readonly long[] Value=A097661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097661.Bytes);
public long this[int i]=>Value[i];

public static A097661Inst Instance=new A097661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097662
{
public static readonly BigInteger[] Value={ 0L,1L,6L,33L,208L,1545L,13326L,130921L,1441728L,17572113L,234662230L,3405357681L,53334454416L,896324308633L,16083557845278L,306827170866105L,6199668952527616L,132240988644215841L,2968971263911288998L,BigInteger.Parse("69974827707903049153"),BigInteger.Parse("1727194482044146637520"),BigInteger.Parse("44552237162692939114281") };
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
public class A097662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097662Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097662.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A097662.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097662Inst Instance=new A097662Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097663
{
public static readonly long[] Value={ 2L,3L,3L,1L,1L,9L,0L,9L,3L,1L,8L,4L,5L,6L,4L,1L,1L,7L,3L,0L,5L,3L,7L,5L,6L,2L,3L,2L,6L,5L,4L,4L,2L,8L,9L,5L,7L,4L,4L,6L,0L,8L,5L,8L,7L,0L,2L,5L,9L,2L,4L,5L,6L,4L,1L,4L,0L,9L,6L,0L,0L,7L,8L,7L,5L,6L,1L,6L,8L,2L,8L,5L,3L,1L,1L,5L,3L,1L,7L,4L,6L,3L,3L,5L,1L,1L,2L,2L,5L,5L,6L,6L,9L,4L,0L,6L,7L,7L,7L,0L,3L,3L,8L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097663Inst : IEnumerable<long>
{
public static readonly long[] Value=A097663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097663.Bytes);
public long this[int i]=>Value[i];

public static A097663Inst Instance=new A097663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097664
{
public static readonly long[] Value={ 1L,4L,2L,9L,8L,8L,4L,3L,0L,8L,4L,0L,1L,2L,3L,4L,2L,0L,5L,6L,6L,1L,7L,9L,0L,4L,2L,4L,7L,7L,5L,1L,3L,8L,0L,9L,6L,5L,6L,4L,9L,8L,2L,3L,6L,7L,6L,7L,5L,6L,4L,4L,6L,4L,8L,8L,7L,6L,3L,4L,6L,2L,1L,4L,8L,8L,3L,6L,9L,9L,4L,5L,0L,9L,1L,2L,2L,0L,3L,9L,6L,1L,6L,1L,8L,2L,1L,9L,5L,9L,1L,4L,6L,9L,0L,1L,8L,4L,6L,3L,6L,2L,3L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097664Inst : IEnumerable<long>
{
public static readonly long[] Value=A097664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097664.Bytes);
public long this[int i]=>Value[i];

public static A097664Inst Instance=new A097664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097665
{
public static readonly long[] Value={ 1L,0L,3L,9L,3L,9L,7L,8L,8L,1L,7L,5L,3L,8L,0L,9L,5L,4L,2L,7L,3L,4L,7L,7L,8L,0L,9L,9L,1L,7L,4L,8L,9L,3L,8L,5L,0L,1L,6L,9L,3L,8L,9L,2L,0L,8L,1L,5L,8L,8L,4L,8L,0L,4L,0L,3L,7L,5L,6L,7L,9L,4L,1L,5L,2L,7L,7L,0L,9L,9L,3L,8L,6L,4L,2L,7L,4L,1L,0L,6L,9L,8L,9L,4L,3L,0L,0L,1L,3L,8L,9L,3L,2L,7L,1L,3L,0L,1L,7L,6L,7L,0L,2L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097665Inst : IEnumerable<long>
{
public static readonly long[] Value=A097665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097665.Bytes);
public long this[int i]=>Value[i];

public static A097665Inst Instance=new A097665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097666
{
public static readonly long[] Value={ 2L,4L,0L,5L,2L,3L,8L,6L,9L,0L,4L,8L,2L,6L,7L,5L,8L,2L,7L,7L,3L,6L,5L,1L,7L,8L,3L,3L,3L,5L,1L,9L,1L,6L,5L,6L,3L,1L,9L,5L,0L,8L,5L,4L,3L,7L,3L,3L,2L,2L,6L,7L,4L,7L,0L,0L,1L,0L,4L,0L,7L,7L,4L,4L,6L,2L,1L,2L,7L,5L,9L,5L,2L,4L,4L,5L,7L,9L,1L,0L,6L,8L,3L,7L,4L,3L,5L,2L,3L,8L,3L,2L,9L,1L,9L,4L,1L,6L,7L,7L,3L,2L,8L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097666Inst : IEnumerable<long>
{
public static readonly long[] Value=A097666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097666.Bytes);
public long this[int i]=>Value[i];

public static A097666Inst Instance=new A097666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097667
{
public static readonly long[] Value={ 0L,4L,4L,9L,4L,1L,8L,2L,8L,7L,7L,9L,2L,0L,8L,8L,2L,0L,6L,0L,8L,4L,6L,7L,3L,9L,6L,4L,2L,7L,6L,6L,5L,2L,0L,3L,4L,0L,2L,3L,8L,5L,9L,4L,3L,7L,1L,0L,5L,9L,8L,6L,9L,8L,0L,5L,8L,6L,1L,6L,7L,2L,9L,6L,3L,2L,5L,8L,8L,5L,3L,0L,7L,8L,6L,1L,2L,5L,6L,2L,7L,4L,7L,6L,8L,5L,8L,5L,5L,0L,9L,5L,9L,6L,1L,7L,3L,8L,6L,8L,6L,0L,8L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097667Inst : IEnumerable<long>
{
public static readonly long[] Value=A097667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097667.Bytes);
public long this[int i]=>Value[i];

public static A097667Inst Instance=new A097667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097668
{
public static readonly long[] Value={ 6L,8L,7L,4L,7L,4L,2L,0L,6L,9L,9L,0L,8L,0L,1L,9L,6L,0L,7L,0L,8L,1L,6L,4L,2L,2L,1L,3L,3L,3L,9L,8L,4L,7L,5L,4L,9L,9L,7L,7L,7L,3L,5L,3L,0L,7L,8L,3L,2L,0L,5L,9L,3L,2L,3L,7L,3L,2L,7L,7L,5L,7L,1L,6L,4L,9L,6L,1L,3L,3L,4L,7L,9L,6L,8L,5L,6L,6L,7L,4L,7L,1L,1L,0L,0L,0L,9L,9L,2L,6L,7L,4L,2L,8L,4L,8L,2L,0L,1L,6L,9L,7L,8L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097668Inst : IEnumerable<long>
{
public static readonly long[] Value=A097668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097668.Bytes);
public long this[int i]=>Value[i];

public static A097668Inst Instance=new A097668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097669
{
public static readonly long[] Value={ 1L,9L,0L,7L,9L,5L,9L,5L,3L,2L,5L,4L,3L,5L,4L,2L,5L,2L,2L,5L,5L,3L,3L,3L,8L,1L,3L,9L,7L,2L,9L,5L,2L,0L,3L,6L,9L,0L,8L,5L,1L,6L,0L,6L,8L,3L,5L,9L,0L,8L,2L,9L,6L,8L,2L,2L,8L,2L,2L,3L,5L,9L,6L,0L,8L,1L,0L,7L,0L,6L,3L,7L,8L,6L,8L,8L,6L,5L,5L,0L,4L,0L,3L,9L,9L,7L,2L,3L,6L,3L,5L,8L,3L,0L,9L,0L,1L,3L,8L,0L,7L,5L,3L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097669Inst : IEnumerable<long>
{
public static readonly long[] Value=A097669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097669.Bytes);
public long this[int i]=>Value[i];

public static A097669Inst Instance=new A097669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097670
{
public static readonly long[] Value={ 3L,3L,9L,2L,7L,6L,4L,2L,7L,8L,9L,2L,7L,8L,4L,9L,8L,0L,7L,7L,0L,4L,7L,5L,5L,0L,5L,6L,5L,5L,4L,4L,7L,1L,2L,8L,3L,9L,2L,7L,4L,0L,1L,0L,9L,2L,5L,8L,6L,0L,8L,4L,4L,2L,2L,3L,4L,7L,8L,0L,8L,4L,4L,1L,9L,3L,5L,2L,4L,6L,3L,6L,1L,5L,9L,8L,0L,3L,4L,6L,1L,3L,5L,1L,7L,3L,5L,0L,1L,0L,5L,1L,9L,3L,2L,9L,7L,8L,5L,7L,3L,4L,6L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097670Inst : IEnumerable<long>
{
public static readonly long[] Value=A097670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097670.Bytes);
public long this[int i]=>Value[i];

public static A097670Inst Instance=new A097670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097671
{
public static readonly long[] Value={ 0L,1L,9L,0L,0L,3L,1L,1L,4L,8L,9L,8L,1L,4L,0L,4L,4L,7L,6L,2L,0L,2L,9L,2L,0L,9L,4L,3L,2L,9L,7L,3L,4L,2L,7L,0L,0L,9L,4L,4L,6L,2L,7L,0L,1L,5L,0L,0L,3L,4L,1L,3L,7L,6L,0L,4L,2L,2L,4L,2L,5L,1L,8L,7L,4L,8L,0L,4L,2L,5L,7L,8L,9L,3L,1L,5L,4L,3L,2L,6L,4L,0L,5L,9L,3L,2L,3L,1L,8L,2L,4L,5L,1L,5L,4L,6L,3L,2L,4L,1L,8L,2L,6L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097671Inst : IEnumerable<long>
{
public static readonly long[] Value=A097671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097671.Bytes);
public long this[int i]=>Value[i];

public static A097671Inst Instance=new A097671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097672
{
public static readonly long[] Value={ 4L,3L,8L,5L,2L,4L,5L,9L,8L,6L,2L,5L,0L,8L,0L,8L,1L,7L,3L,6L,9L,9L,4L,8L,9L,9L,4L,3L,2L,2L,9L,5L,6L,2L,0L,7L,7L,6L,5L,0L,8L,0L,1L,2L,8L,5L,0L,0L,9L,0L,2L,7L,6L,3L,0L,4L,2L,0L,0L,6L,5L,5L,4L,6L,7L,7L,6L,4L,3L,3L,1L,5L,6L,4L,6L,0L,8L,4L,8L,1L,1L,5L,4L,4L,3L,9L,9L,7L,3L,9L,5L,5L,1L,5L,6L,0L,8L,7L,7L,8L,8L,4L,6L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097672Inst : IEnumerable<long>
{
public static readonly long[] Value=A097672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097672.Bytes);
public long this[int i]=>Value[i];

public static A097672Inst Instance=new A097672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097673
{
public static readonly long[] Value={ 0L,0L,3L,2L,4L,1L,1L,2L,2L,8L,3L,0L,0L,9L,6L,3L,0L,7L,3L,7L,4L,7L,5L,1L,1L,7L,1L,2L,1L,7L,9L,1L,9L,0L,1L,7L,0L,1L,0L,7L,3L,8L,4L,7L,9L,2L,2L,1L,5L,1L,0L,4L,0L,0L,6L,9L,2L,9L,9L,0L,5L,9L,2L,3L,0L,5L,1L,8L,5L,7L,1L,1L,0L,2L,1L,3L,7L,4L,1L,0L,1L,1L,3L,2L,7L,9L,8L,7L,0L,4L,4L,4L,3L,6L,4L,9L,4L,7L,3L,7L,7L,4L,7L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097673Inst : IEnumerable<long>
{
public static readonly long[] Value=A097673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097673.Bytes);
public long this[int i]=>Value[i];

public static A097673Inst Instance=new A097673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097674
{
public static readonly long[] Value={ 9L,0L,7L,2L,4L,5L,8L,1L,7L,8L,8L,2L,1L,6L,4L,6L,0L,7L,5L,3L,8L,7L,9L,4L,5L,2L,4L,7L,9L,2L,0L,8L,1L,2L,1L,3L,7L,8L,7L,7L,7L,5L,2L,5L,4L,2L,3L,5L,8L,7L,4L,9L,5L,9L,0L,6L,8L,7L,1L,8L,5L,3L,7L,9L,4L,1L,1L,7L,5L,9L,2L,2L,5L,6L,2L,2L,2L,4L,4L,6L,9L,0L,5L,4L,4L,4L,2L,7L,0L,6L,8L,3L,1L,3L,0L,4L,9L,1L,8L,7L,8L,8L,7L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097674Inst : IEnumerable<long>
{
public static readonly long[] Value=A097674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097674.Bytes);
public long this[int i]=>Value[i];

public static A097674Inst Instance=new A097674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097675
{
public static readonly long[] Value={ 3L,3L,3L,3L,2L,5L,2L,1L,2L,6L,5L,8L,5L,4L,1L,7L,2L,1L,5L,4L,0L,0L,3L,9L,0L,7L,6L,9L,7L,2L,1L,0L,2L,2L,1L,1L,7L,4L,3L,9L,8L,0L,2L,5L,9L,7L,2L,7L,6L,5L,5L,4L,6L,9L,6L,6L,2L,8L,2L,7L,2L,9L,1L,3L,5L,2L,7L,9L,3L,4L,3L,6L,8L,2L,1L,4L,6L,6L,0L,7L,0L,5L,8L,9L,7L,4L,3L,8L,2L,5L,4L,1L,8L,2L,9L,5L,0L,2L,6L,6L,2L,0L,6L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097675Inst : IEnumerable<long>
{
public static readonly long[] Value=A097675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097675.Bytes);
public long this[int i]=>Value[i];

public static A097675Inst Instance=new A097675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097676
{
public static readonly long[] Value={ 6L,3L,7L,6L,6L,3L,2L,4L,8L,9L,4L,1L,6L,6L,7L,7L,8L,5L,5L,0L,0L,1L,7L,6L,2L,5L,9L,3L,8L,2L,5L,1L,0L,7L,9L,0L,6L,2L,6L,7L,4L,3L,5L,3L,2L,6L,7L,8L,6L,4L,6L,2L,1L,6L,7L,6L,7L,3L,0L,6L,4L,1L,0L,7L,4L,3L,4L,2L,6L,4L,5L,4L,9L,1L,5L,2L,5L,9L,9L,9L,3L,9L,0L,8L,8L,3L,3L,7L,3L,3L,1L,6L,4L,3L,8L,3L,2L,7L,6L,5L,5L,5L,3L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097676Inst : IEnumerable<long>
{
public static readonly long[] Value=A097676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097676.Bytes);
public long this[int i]=>Value[i];

public static A097676Inst Instance=new A097676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097677
{
public static readonly long[] Value={ 1L,3L,9L,33L,171L,1053L,7119L,57267L,525609L,5164803L,56726649L,690532857L,8889138531L,124010345277L,1880154795519L,29907812576187L,506398197859281L,9190226159295363L,173999328850897641L,3466197108906552657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097677Inst : IEnumerable<long>
{
public static readonly long[] Value=A097677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097677.Bytes);
public long this[int i]=>Value[i];

public static A097677Inst Instance=new A097677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097678
{
public static readonly ulong[] Value={ 1L,0L,3L,6L,27L,252L,1125L,10206L,108297L,811944L,10272339L,131572350L,1410753267L,22363938324L,342373389813L,4790641828518L,90549635310225L,1626834238205904L,28073013793245603L,614304628556766966L,12727707975543382731UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097678Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A097678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097678.Bytes);
public ulong this[int i]=>Value[i];

public static A097678Inst Instance=new A097678Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097679
{
public static readonly long[] Value={ 1L,4L,16L,64L,280L,1600L,12160L,102400L,880000L,8358400L,94720000L,1189888000L,15213952000L,204285952000L,3092697088000L,51351519232000L,869951500288000L,15148619579392000L,287722152460288000L,5927812334878720000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097679Inst : IEnumerable<long>
{
public static readonly long[] Value=A097679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097679.Bytes);
public long this[int i]=>Value[i];

public static A097679Inst Instance=new A097679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097680
{
public static readonly ulong[] Value={ 1L,5L,25L,125L,625L,3245L,19825L,162125L,1650625L,17703125L,186644425L,2032320125L,25569960625L,382772328125L,6166860390625L,98093486946125L,1555728351450625L,26765871718953125L,527380555479765625L,11241893092061328125UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097680Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A097680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097680.Bytes);
public ulong this[int i]=>Value[i];

public static A097680Inst Instance=new A097680Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097681
{
public static readonly long[] Value={ 1L,6L,36L,216L,1296L,7776L,47376L,314496L,2612736L,28740096L,368395776L,4796983296L,60300205056L,750367328256L,10151357239296L,164475953381376L,3110937349718016L,61410199093641216L,1174438559356747776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097681Inst : IEnumerable<long>
{
public static readonly long[] Value=A097681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097681.Bytes);
public long this[int i]=>Value[i];

public static A097681Inst Instance=new A097681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097682
{
public static readonly long[] Value={ 1L,8L,64L,512L,4096L,32768L,262144L,2097152L,16817536L,137443328L,1215668224L,13131579392L,186802241536L,3194809745408L,57299125141504L,1002518381330432L,16747075923705856L,268695698674024448L,4294396462470529024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097682Inst : IEnumerable<long>
{
public static readonly long[] Value=A097682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097682.Bytes);
public long this[int i]=>Value[i];

public static A097682Inst Instance=new A097682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097683
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,9L,11L,24L,84L,221L,1314L,2952L,20016L,51054L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097683Inst : IEnumerable<long>
{
public static readonly long[] Value=A097683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097683.Bytes);
public long this[int i]=>Value[i];

public static A097683Inst Instance=new A097683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097684
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,23L,29L,40L,131L,136L,215L,611L,767L,2153L,2576L,22973L,42689L,85712L,85864L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097684Inst : IEnumerable<long>
{
public static readonly long[] Value=A097684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097684.Bytes);
public long this[int i]=>Value[i];

public static A097684Inst Instance=new A097684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097685
{
public static readonly long[] Value={ 2L,5L,6L,8L,17L,50L,684L,720L,1452L,1679L,3146L,72821L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097685Inst : IEnumerable<long>
{
public static readonly long[] Value=A097685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097685.Bytes);
public long this[int i]=>Value[i];

public static A097685Inst Instance=new A097685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097686
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,3L,4L,2L,1L,4L,2L,1L,5L,5L,6L,3L,5L,7L,7L,8L,4L,2L,1L,6L,3L,6L,3L,7L,9L,9L,10L,5L,8L,4L,2L,1L,7L,10L,5L,9L,11L,11L,12L,6L,3L,8L,4L,2L,1L,8L,4L,2L,1L,9L,12L,6L,3L,9L,13L,13L,14L,7L,11L,13L,15L,15L,16L,8L,4L,2L,1L,10L,5L,10L,5L,11L,14L,7L,12L,6L,3L,10L,5L,12L,6L,3L,11L,15L,17L,17L,18L,9L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097686Inst : IEnumerable<long>
{
public static readonly long[] Value=A097686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097686.Bytes);
public long this[int i]=>Value[i];

public static A097686Inst Instance=new A097686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097687
{
public static readonly long[] Value={ 1L,3L,5L,7L,13L,15L,18L,20L,29L,31L,41L,43L,59L,61L,65L,67L,89L,91L,115L,117L,133L,135L,153L,155L,173L,175L,207L,209L,243L,245L,250L,252L,305L,307L,338L,340L,389L,391L,407L,409L,447L,449L,527L,529L,554L,556L,613L,615L,663L,665L,699L,701L,761L,763L,788L,790L,869L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097687Inst : IEnumerable<long>
{
public static readonly long[] Value=A097687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097687.Bytes);
public long this[int i]=>Value[i];

public static A097687Inst Instance=new A097687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097688
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,3L,3L,3L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097688Inst : IEnumerable<long>
{
public static readonly long[] Value=A097688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097688.Bytes);
public long this[int i]=>Value[i];

public static A097688Inst Instance=new A097688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097689
{
public static readonly long[] Value={ 0L,0L,1L,3L,4L,8L,8L,13L,15L,16L,16L,20L,22L,30L,32L,33L,33L,41L,44L,50L,54L,58L,58L,66L,69L,73L,76L,76L,78L,88L,88L,100L,103L,107L,109L,111L,113L,123L,127L,129L,131L,142L,146L,159L,165L,167L,169L,183L,191L,193L,197L,201L,204L,214L,218L,224L,230L,233L,233L,245L,252L,268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097689Inst : IEnumerable<long>
{
public static readonly long[] Value=A097689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097689.Bytes);
public long this[int i]=>Value[i];

public static A097689Inst Instance=new A097689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097690
{
public static readonly BigInteger[] Value={ 1L,3L,21L,209L,2640L,40391L,726103L,15003009L,350382231L,9127651499L,262424759520L,8254109243953L,281944946167261L,10393834843080975L,411313439034311505L,17391182043967249409UL,BigInteger.Parse("782469083251377707328") };
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
public class A097690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097690Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097690.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A097690.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097690Inst Instance=new A097690Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097691
{
public static readonly BigInteger[] Value={ 1L,2L,8L,56L,551L,6930L,105937L,1905632L,39424240L,922080050L,24057287759L,692686638072L,21817946138353L,746243766783074L,27543862067299424L,1091228270370045824L,BigInteger.Parse("46187969968474139807"),BigInteger.Parse("2080128468827570457762"),BigInteger.Parse("99318726126650358502921"),BigInteger.Parse("5011361251329169946919800") };
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
public class A097691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097691Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097691.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A097691.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097691Inst Instance=new A097691Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097692
{
public static readonly long[] Value={ 1L,2L,4L,2L,10L,8L,2L,26L,30L,12L,2L,70L,104L,60L,16L,2L,192L,350L,260L,100L,20L,2L,534L,1152L,1050L,520L,150L,24L,2L,1500L,3738L,4032L,2450L,910L,210L,28L,2L,4246L,12000L,14952L,10752L,4900L,1456L,280L,32L,2L,12092L,38214L,54000L,44856L,24192L,8820L,2184L,360L,36L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097692Inst : IEnumerable<long>
{
public static readonly long[] Value=A097692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097692.Bytes);
public long this[int i]=>Value[i];

public static A097692Inst Instance=new A097692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097693
{
public static readonly long[] Value={ 86L,216L,438L,776L,1254L,1896L,2726L,3768L,5046L,6584L,8406L,10536L,12998L,15816L,19014L,22616L,26646L,31128L,36086L,41544L,47526L,54056L,61158L,68856L,77174L,86136L,95766L,106088L,117126L,128904L,141446L,154776L,168918L,183896L,199734L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097693Inst : IEnumerable<long>
{
public static readonly long[] Value=A097693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097693.Bytes);
public long this[int i]=>Value[i];

public static A097693Inst Instance=new A097693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097694
{
public static readonly long[] Value={ 36000L,50736L,69828L,94092L,124699L,162604L,208697L,264094L,329983L,407624L,498349L,603562L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097694Inst : IEnumerable<long>
{
public static readonly long[] Value=A097694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097694.Bytes);
public long this[int i]=>Value[i];

public static A097694Inst Instance=new A097694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097695
{
public static readonly long[] Value={ 10324L,19920L,35791L,60122L,95610L,145362L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097695Inst : IEnumerable<long>
{
public static readonly long[] Value=A097695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097695.Bytes);
public long this[int i]=>Value[i];

public static A097695Inst Instance=new A097695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097696
{
public static readonly long[] Value={ 7343L,8784L,12065L,16800L,21600L,26400L,31200L,36000L,40800L,45600L,50400L,55200L,60000L,64800L,69600L,74400L,79200L,84000L,88800L,93600L,98400L,103200L,108000L,112800L,117600L,122400L,127200L,132000L,136800L,141600L,146400L,151200L,156000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097696Inst : IEnumerable<long>
{
public static readonly long[] Value=A097696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097696.Bytes);
public long this[int i]=>Value[i];

public static A097696Inst Instance=new A097696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097697
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,11L,14L,19L,25L,26L,31L,32L,35L,37L,38L,46L,47L,53L,56L,61L,65L,67L,70L,73L,77L,79L,80L,86L,89L,109L,115L,121L,122L,124L,128L,137L,143L,149L,152L,158L,161L,163L,170L,175L,178L,182L,184L,199L,203L,208L,212L,215L,217L,220L,229L,235L,236L,242L,254L,256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097697Inst : IEnumerable<long>
{
public static readonly long[] Value=A097697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097697.Bytes);
public long this[int i]=>Value[i];

public static A097697Inst Instance=new A097697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097698
{
public static readonly long[] Value={ 2L,4L,5L,7L,32L,46L,56L,70L,73L,86L,109L,149L,152L,161L,163L,170L,175L,178L,208L,220L,235L,254L,277L,280L,290L,313L,317L,326L,334L,343L,347L,352L,364L,368L,373L,385L,403L,409L,434L,446L,460L,527L,541L,551L,565L,578L,598L,628L,632L,689L,709L,710L,737L,761L,812L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097698Inst : IEnumerable<long>
{
public static readonly long[] Value=A097698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097698.Bytes);
public long this[int i]=>Value[i];

public static A097698Inst Instance=new A097698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097699
{
public static readonly long[] Value={ 2L,3L,4L,6L,10L,15L,20L,21L,50L,105L,175L,196L,490L,887L,1176L,3490L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097699Inst : IEnumerable<long>
{
public static readonly long[] Value=A097699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097699.Bytes);
public long this[int i]=>Value[i];

public static A097699Inst Instance=new A097699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097700
{
public static readonly long[] Value={ 5L,7L,10L,13L,14L,15L,20L,21L,23L,26L,28L,29L,30L,31L,35L,37L,39L,40L,42L,45L,46L,47L,52L,53L,55L,56L,58L,60L,61L,62L,63L,65L,69L,70L,71L,74L,77L,78L,79L,80L,84L,85L,87L,90L,91L,92L,93L,94L,95L,101L,103L,104L,105L,106L,109L,110L,111L,112L,115L,116L,117L,119L,120L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097700Inst : IEnumerable<long>
{
public static readonly long[] Value=A097700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097700.Bytes);
public long this[int i]=>Value[i];

public static A097700Inst Instance=new A097700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097701
{
public static readonly long[] Value={ 1L,2L,5L,9L,16L,25L,39L,56L,80L,109L,147L,192L,249L,315L,396L,489L,600L,726L,874L,1040L,1232L,1446L,1690L,1960L,2265L,2600L,2975L,3385L,3840L,4335L,4881L,5472L,6120L,6819L,7581L,8400L,9289L,10241L,11270L,12369L,13552L,14812L,16164L,17600L,19136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097701Inst : IEnumerable<long>
{
public static readonly long[] Value=A097701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097701.Bytes);
public long this[int i]=>Value[i];

public static A097701Inst Instance=new A097701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097702
{
public static readonly long[] Value={ 0L,2L,3L,5L,6L,8L,9L,11L,14L,15L,17L,18L,20L,21L,23L,26L,27L,29L,30L,32L,33L,35L,36L,38L,39L,41L,42L,44L,45L,47L,48L,50L,51L,53L,54L,56L,57L,59L,63L,65L,66L,68L,69L,71L,72L,74L,75L,77L,78L,80L,81L,83L,86L,89L,90L,92L,93L,95L,96L,98L,99L,101L,102L,104L,105L,107L,108L,110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097702Inst : IEnumerable<long>
{
public static readonly long[] Value=A097702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097702.Bytes);
public long this[int i]=>Value[i];

public static A097702Inst Instance=new A097702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097703
{
public static readonly long[] Value={ 1L,4L,7L,10L,12L,13L,16L,19L,22L,24L,25L,28L,31L,34L,37L,40L,43L,46L,49L,52L,55L,58L,60L,61L,62L,64L,67L,70L,73L,76L,79L,82L,84L,85L,87L,88L,91L,94L,97L,100L,103L,106L,109L,112L,115L,118L,121L,122L,124L,127L,130L,133L,136L,137L,139L,142L,144L,145L,148L,151L,154L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097703Inst : IEnumerable<long>
{
public static readonly long[] Value=A097703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097703.Bytes);
public long this[int i]=>Value[i];

public static A097703Inst Instance=new A097703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097704
{
public static readonly long[] Value={ 12L,24L,60L,62L,84L,87L,122L,137L,144L,162L,171L,180L,212L,237L,264L,269L,287L,302L,312L,318L,362L,387L,416L,420L,422L,423L,437L,462L,465L,480L,512L,537L,563L,587L,591L,612L,662L,665L,684L,687L,710L,722L,737L,759L,762L,786L,812L,837L,840L,857L,887L,902L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097704Inst : IEnumerable<long>
{
public static readonly long[] Value=A097704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097704.Bytes);
public long this[int i]=>Value[i];

public static A097704Inst Instance=new A097704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097705
{
public static readonly long[] Value={ 1L,4L,33L,200L,1361L,8844L,58513L,384400L,2532321L,16664084L,109705793L,722112600L,4753448881L,31289709724L,205967469873L,1355794944800L,8924626767041L,58747021129764L,386706739558753L,2545526317441000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097705Inst : IEnumerable<long>
{
public static readonly long[] Value=A097705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097705.Bytes);
public long this[int i]=>Value[i];

public static A097705Inst Instance=new A097705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097706
{
public static readonly long[] Value={ 1L,1L,3L,1L,1L,3L,7L,1L,9L,1L,11L,3L,1L,7L,3L,1L,1L,9L,19L,1L,21L,11L,23L,3L,1L,1L,27L,7L,1L,3L,31L,1L,33L,1L,7L,9L,1L,19L,3L,1L,1L,21L,43L,11L,9L,23L,47L,3L,49L,1L,3L,1L,1L,27L,11L,7L,57L,1L,59L,3L,1L,31L,63L,1L,1L,33L,67L,1L,69L,7L,71L,9L,1L,1L,3L,19L,77L,3L,79L,1L,81L,1L,83L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097706Inst : IEnumerable<long>
{
public static readonly long[] Value=A097706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097706.Bytes);
public long this[int i]=>Value[i];

public static A097706Inst Instance=new A097706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097707
{
public static readonly long[] Value={ 1L,1L,3L,3L,3L,9L,63L,63L,567L,567L,6237L,18711L,18711L,130977L,392931L,392931L,392931L,3536379L,67191201L,67191201L,1411015221L,15521167431L,356986850913L,1070960552739L,1070960552739L,1070960552739L,28915934923953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097707Inst : IEnumerable<long>
{
public static readonly long[] Value=A097707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097707.Bytes);
public long this[int i]=>Value[i];

public static A097707Inst Instance=new A097707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097708
{
public static readonly BigInteger[] Value={ 0L,11L,122L,11233L,1122344L,11112233455L,1122223344566L,11112233334455677L,1122223344445566788L,BigInteger.Parse("11112233334455556677899"),BigInteger.Parse("11111122223344445566667789010"),BigInteger.Parse("1122222233334455556677778900121") };
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
public class A097708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097708Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097708.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A097708.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097708Inst Instance=new A097708Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097709
{
public static readonly long[] Value={ 2L,0L,5L,6L,23L,16L,35L,54L,35L,10L,11L,40L,57L,30L,477L,58L,215L,0L,715L,264L,83L,16L,105L,30L,379L,238L,5L,462L,851L,538L,1L,70L,199L,618L,85L,84L,881L,454L,53L,310L,223L,330L,1109L,540L,2059L,398L,305L,120L,185L,574L,411L,340L,539L,318L,209L,648L,421L,2444L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097709Inst : IEnumerable<long>
{
public static readonly long[] Value=A097709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097709.Bytes);
public long this[int i]=>Value[i];

public static A097709Inst Instance=new A097709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097710
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,1L,7L,13L,7L,1L,41L,88L,61L,15L,1L,397L,951L,781L,257L,31L,1L,6377L,16691L,15566L,6231L,1041L,63L,1L,171886L,484490L,500057L,231721L,48303L,4161L,127L,1L,7892642L,23701698L,26604323L,13843968L,3406505L,374127L,16577L,255L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097710Inst : IEnumerable<long>
{
public static readonly long[] Value=A097710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097710.Bytes);
public long this[int i]=>Value[i];

public static A097710Inst Instance=new A097710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097711
{
public static readonly BigInteger[] Value={ 1L,3L,13L,88L,951L,16691L,484490L,23701698L,1990327810L,291750344191L,75757923092106L,35286335933354828L,BigInteger.Parse("29791358931890967248"),BigInteger.Parse("45989706937220594708463"),BigInteger.Parse("130760311958838053647976497") };
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
public class A097711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097711Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097711.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A097711.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097711Inst Instance=new A097711Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097712
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,8L,7L,1L,1L,25L,44L,15L,1L,1L,111L,346L,208L,31L,1L,1L,809L,4045L,3720L,912L,63L,1L,1L,10360L,77351L,99776L,35136L,3840L,127L,1L,1L,236952L,2535715L,4341249L,2032888L,308976L,15808L,255L,1L,1L,9708797L,145895764L,319822055L,189724354L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097712Inst : IEnumerable<long>
{
public static readonly long[] Value=A097712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097712.Bytes);
public long this[int i]=>Value[i];

public static A097712Inst Instance=new A097712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097713
{
public static readonly BigInteger[] Value={ 1L,3L,8L,25L,111L,809L,10360L,236952L,9708797L,714862984L,95000655195L,22902964060238L,10070812803900694L,8120691251242651341L,BigInteger.Parse("12070960239863869828931"),BigInteger.Parse("33238610095183531376362138") };
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
public class A097713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097713Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097713.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A097713.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097713Inst Instance=new A097713Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097714
{
public static readonly long[] Value={ 60L,100L,140L,220L,340L,540L,900L,1500L,2500L,4140L,6900L,11500L,19140L,31900L,53140L,88540L,147540L,245900L,409820L,683020L,1138340L,1897220L,3162020L,5270020L,8783340L,14638900L,24398140L,40663540L,67772540L,112954220L,188257020L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097714Inst : IEnumerable<long>
{
public static readonly long[] Value=A097714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097714.Bytes);
public long this[int i]=>Value[i];

public static A097714Inst Instance=new A097714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097715
{
public static readonly long[] Value={ 6L,0L,6L,2L,1L,7L,7L,8L,2L,6L,4L,9L,1L,0L,7L,0L,5L,2L,7L,3L,4L,6L,0L,6L,2L,1L,9L,5L,2L,7L,0L,5L,5L,3L,2L,8L,4L,2L,9L,9L,8L,1L,8L,3L,8L,8L,3L,3L,6L,3L,3L,2L,1L,9L,8L,1L,9L,5L,3L,2L,4L,4L,2L,8L,0L,8L,1L,7L,6L,5L,5L,5L,9L,1L,8L,0L,8L,0L,0L,1L,2L,9L,7L,8L,4L,0L,1L,1L,6L,5L,3L,6L,5L,0L,3L,7L,0L,0L,1L,4L,8L,6L,4L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097715Inst : IEnumerable<long>
{
public static readonly long[] Value=A097715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097715.Bytes);
public long this[int i]=>Value[i];

public static A097715Inst Instance=new A097715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097716
{
public static readonly BigInteger[] Value={ 1L,-1L,2L,-17L,124L,-2764L,43688L,-1859138L,51236656L,-3550889296L,151107728672L,-15494138893232L,941930695305664L,-133994296272170944L,11024086088089751168UL,BigInteger.Parse("-2077570618897716831248"),BigInteger.Parse("222290021402867410844416"),BigInteger.Parse("-53603997631397508980982016"),BigInteger.Parse("7234385689981722178901729792") };
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
public class A097716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097716Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097716.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A097716.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097716Inst Instance=new A097716Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097717
{
public static readonly BigInteger[] Value={ 1L,105263157894736842L,BigInteger.Parse("1034482758620689655172413793"),102564L,714285L,BigInteger.Parse("1016949152542372881355932203389830508474576271186440677966"),BigInteger.Parse("1014492753623188405797"),1012658227848L,BigInteger.Parse("10112359550561797752808988764044943820224719") };
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
public class A097717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097717Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097717.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A097717.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097717Inst Instance=new A097717Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097718
{
public static readonly long[] Value={ 1L,-1L,-1L,2L,21L,54L,-605L,-8422L,-17815L,915470L,13791711L,-14182158L,-3814159811L,-55759417546L,472583147387L,33181980839114L,418144112565969L,-10448831982433506L,-511822958265199817L,-4431070683610565086L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097718Inst : IEnumerable<long>
{
public static readonly long[] Value=A097718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097718.Bytes);
public long this[int i]=>Value[i];

public static A097718Inst Instance=new A097718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097719
{
public static readonly long[] Value={ 0L,1L,2L,1L,2L,3L,6L,7L,9L,13L,20L,27L,37L,51L,71L,98L,136L,187L,258L,357L,494L,681L,940L,1298L,1792L,2474L,3415L,4714L,6506L,8981L,12396L,17110L,23617L,32599L,44996L,62107L,85725L,118324L,163320L,225427L,311153L,429477L,592798L,818226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097719Inst : IEnumerable<long>
{
public static readonly long[] Value=A097719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097719.Bytes);
public long this[int i]=>Value[i];

public static A097719Inst Instance=new A097719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097720
{
public static readonly long[] Value={ 5L,11L,5L,11L,17L,19L,18L,19L,16L,12L,13L,17L,16L,15L,15L,16L,13L,15L,15L,14L,16L,15L,16L,10L,15L,26L,19L,18L,27L,20L,20L,24L,21L,17L,18L,18L,19L,18L,23L,20L,20L,17L,20L,21L,25L,20L,20L,18L,17L,19L,16L,19L,16L,15L,17L,18L,16L,20L,17L,16L,22L,18L,18L,19L,14L,20L,16L,19L,20L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097720Inst : IEnumerable<long>
{
public static readonly long[] Value=A097720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097720.Bytes);
public long this[int i]=>Value[i];

public static A097720Inst Instance=new A097720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097721
{
public static readonly long[] Value={ 3L,2L,2L,2L,13L,3L,7L,11L,2L,2L,3L,3L,11L,3L,7L,3L,5L,11L,7L,7L,3L,7L,3L,19L,7L,11L,13L,17L,19L,11L,17L,11L,13L,13L,19L,11L,17L,13L,17L,13L,17L,11L,11L,13L,17L,19L,11L,23L,127L,29L,23L,23L,41L,151L,157L,23L,29L,71L,227L,181L,23L,23L,37L,11L,13L,17L,31L,37L,37L,149L,53L,59L,37L,37L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097721Inst : IEnumerable<long>
{
public static readonly long[] Value=A097721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097721.Bytes);
public long this[int i]=>Value[i];

public static A097721Inst Instance=new A097721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097722
{
public static readonly long[] Value={ 29L,83L,59L,97L,911L,613L,617L,919L,823L,929L,631L,937L,941L,743L,947L,953L,859L,761L,967L,971L,773L,797L,983L,859L,997L,8101L,9103L,5107L,9109L,6113L,9127L,6131L,9137L,4139L,1949L,9151L,9157L,6163L,8167L,9173L,8179L,9181L,8191L,7193L,6197L,9199L,7211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097722Inst : IEnumerable<long>
{
public static readonly long[] Value=A097722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097722.Bytes);
public long this[int i]=>Value[i];

public static A097722Inst Instance=new A097722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097723
{
public static readonly long[] Value={ 1L,2L,3L,6L,5L,6L,10L,8L,12L,14L,11L,12L,18L,18L,15L,26L,17L,18L,31L,20L,21L,30L,28L,30L,39L,26L,27L,38L,36L,36L,42L,32L,33L,60L,35L,42L,57L,38L,48L,54L,41L,42L,65L,62L,45L,62L,54L,48L,84L,50L,60L,78L,53L,66L,74L,56L,57L,96L,72L,60L,91L,70L,63L,108L,76L,66L,90L,68L,93L,104L,71L,84L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097723Inst : IEnumerable<long>
{
public static readonly long[] Value=A097723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097723.Bytes);
public long this[int i]=>Value[i];

public static A097723Inst Instance=new A097723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097724
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,3L,3L,1L,4L,6L,6L,4L,1L,8L,13L,13L,10L,5L,1L,17L,28L,30L,24L,15L,6L,1L,37L,62L,69L,59L,40L,21L,7L,1L,82L,140L,160L,144L,105L,62L,28L,8L,1L,185L,320L,375L,350L,271L,174L,91L,36L,9L,1L,423L,740L,885L,852L,690L,474L,273L,128L,45L,10L,1L,978L,1728L,2102L,2077L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097724Inst : IEnumerable<long>
{
public static readonly long[] Value=A097724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097724.Bytes);
public long this[int i]=>Value[i];

public static A097724Inst Instance=new A097724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097725
{
public static readonly BigInteger[] Value={ 1L,102L,10403L,1061004L,108212005L,11036563506L,1125621265607L,114802332528408L,11708712296632009L,1194173851923936510L,BigInteger.Parse("121794024183944892011"),BigInteger.Parse("12421796292910455048612"),BigInteger.Parse("1266901427852682470066413"),BigInteger.Parse("129211523844680701491725514"),BigInteger.Parse("13178308530729578869685936015") };
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
public class A097725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097725Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097725.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A097725.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097725Inst Instance=new A097725Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097726
{
public static readonly BigInteger[] Value={ 1L,103L,10505L,1071407L,109273009L,11144775511L,1136657829113L,115927953794015L,11823514629160417L,1205882564220568519L,BigInteger.Parse("122988198035868828521"),BigInteger.Parse("12543590317094399940623"),BigInteger.Parse("1279323224145592925115025"),BigInteger.Parse("130478425272533383961791927"),BigInteger.Parse("13307520054574259571177661529") };
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
public class A097726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097726Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097726.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A097726.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097726Inst Instance=new A097726Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097727
{
public static readonly BigInteger[] Value={ 1L,101L,10301L,1050601L,107151001L,10928351501L,1114584702101L,113676711262801L,11593909964103601L,1182465139627304501L,BigInteger.Parse("120599850332020955501"),BigInteger.Parse("12300002268726510156601"),BigInteger.Parse("1254479631559772015017801"),BigInteger.Parse("127944622416828019021659101"),BigInteger.Parse("13049097006884898168194210501") };
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
public class A097727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097727Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097727.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A097727.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097727Inst Instance=new A097727Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097728
{
public static readonly BigInteger[] Value={ 1L,146L,21315L,3111844L,454307909L,66325842870L,9683118751111L,1413669011819336L,206385992606871945L,BigInteger.Parse("30130941251591484634"),BigInteger.Parse("4398911036739749884619"),BigInteger.Parse("642210880422751891669740") };
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
public class A097728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097728Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097728.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A097728.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097728Inst Instance=new A097728Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097729
{
public static readonly BigInteger[] Value={ 1L,147L,21461L,3133159L,457419753L,66780150779L,9749444593981L,1423352130570447L,207799661618691281L,BigInteger.Parse("30337327244198356579"),BigInteger.Parse("4429041977991341369253"),BigInteger.Parse("646609791459491641554359"),BigInteger.Parse("94400600511107788325567161"),BigInteger.Parse("13781841064830277603891251147") };
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
public class A097729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097729Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097729.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A097729.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097729Inst Instance=new A097729Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097730
{
public static readonly BigInteger[] Value={ 1L,145L,21169L,3090529L,451196065L,65871534961L,9616792908241L,1403985893068225L,204972323595052609L,BigInteger.Parse("29924555258984612689"),BigInteger.Parse("4368780095488158399985"),BigInteger.Parse("637811969386012141785121") };
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
public class A097730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097730Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097730.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A097730.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097730Inst Instance=new A097730Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097731
{
public static readonly BigInteger[] Value={ 1L,198L,39203L,7761996L,1536836005L,304285766994L,60247045028807L,11928610629936792L,2361804657682456009L,BigInteger.Parse("467625393610496352990"),BigInteger.Parse("92587466130220595436011"),BigInteger.Parse("18331850668390067399977188") };
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
public class A097731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097731Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097731.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A097731.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097731Inst Instance=new A097731Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097732
{
public static readonly BigInteger[] Value={ 1L,199L,39401L,7801199L,1544598001L,305822602999L,60551330795801L,11988857674965599L,2373733268312392801L,BigInteger.Parse("469987198268178808999"),BigInteger.Parse("93055091523831091789001"),BigInteger.Parse("18424438134520287995413199") };
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
public class A097732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097732Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097732.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A097732.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097732Inst Instance=new A097732Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097733
{
public static readonly BigInteger[] Value={ 1L,197L,39005L,7722793L,1529074009L,302748930989L,59942759261813L,11868363584907985L,2349876047052519217L,BigInteger.Parse("465263588952813896981"),BigInteger.Parse("92119840736610099083021"),BigInteger.Parse("18239263202259846804541177") };
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
public class A097733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097733Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097733.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A097733.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097733Inst Instance=new A097733Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097734
{
public static readonly BigInteger[] Value={ 1L,258L,66563L,17172996L,4430566405L,1143068959494L,294907360983047L,76084956064666632L,BigInteger.Parse("19629623757323008009"),BigInteger.Parse("5064366844433271399690"),BigInteger.Parse("1306587016240026698112011"),BigInteger.Parse("337094385823082454841499148") };
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
public class A097734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097734Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097734.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A097734.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097734Inst Instance=new A097734Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097735
{
public static readonly BigInteger[] Value={ 1L,259L,66821L,17239559L,4447739401L,1147499525899L,296050429942541L,76379863425649679L,BigInteger.Parse("19705708713387674641"),BigInteger.Parse("5083996468190594407699"),BigInteger.Parse("1311651383084459969511701"),BigInteger.Parse("338400972839322481539611159") };
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
public class A097735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097735Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097735.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A097735.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097735Inst Instance=new A097735Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097736
{
public static readonly BigInteger[] Value={ 1L,257L,66305L,17106433L,4413393409L,1138638393089L,293764292023553L,75790048703683585L,BigInteger.Parse("19553538801258341377"),BigInteger.Parse("5044737220675948391681"),BigInteger.Parse("1301522649395593426712321"),BigInteger.Parse("335787798806842428143387137") };
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
public class A097736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097736Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097736.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A097736.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097736Inst Instance=new A097736Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097737
{
public static readonly BigInteger[] Value={ 1L,326L,106275L,34645324L,11294269349L,3681897162450L,1200287180689351L,391289939007565976L,BigInteger.Parse("127559319829285818825"),BigInteger.Parse("41583946974408169370974"),BigInteger.Parse("13556239154337233929118699"),BigInteger.Parse("4419292380366963852723324900") };
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
public class A097737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097737Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097737.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A097737.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097737Inst Instance=new A097737Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097738
{
public static readonly BigInteger[] Value={ 1L,327L,106601L,34751599L,11328914673L,3693191431799L,1203969077851801L,392490226188255327L,BigInteger.Parse("127950609768293384801"),BigInteger.Parse("41711506294237455189799"),BigInteger.Parse("13597823101311642098489673"),BigInteger.Parse("4432848619521301086652443599") };
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
public class A097738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097738Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097738.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A097738.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097738Inst Instance=new A097738Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097739
{
public static readonly BigInteger[] Value={ 1L,325L,105949L,34539049L,11259624025L,3670602893101L,1196605283526901L,390089651826876625L,BigInteger.Parse("127168029890278252849"),BigInteger.Parse("41456387654578883552149"),BigInteger.Parse("13514655207362825759747725"),BigInteger.Parse("4405736141212626618794206201") };
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
public class A097739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097739Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097739.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A097739.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097739Inst Instance=new A097739Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097740
{
public static readonly BigInteger[] Value={ 1L,402L,161603L,64964004L,26115368005L,10498312974006L,4220295700182407L,1696548373160353608L,BigInteger.Parse("682008225714761968009"),BigInteger.Parse("274165610188961150786010"),BigInteger.Parse("110213893287736667854008011"),BigInteger.Parse("44305710936059951516160434412") };
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
public class A097740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097740Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097740.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A097740.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097740Inst Instance=new A097740Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}