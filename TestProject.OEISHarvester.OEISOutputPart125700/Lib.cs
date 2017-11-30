using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A155005
{
public static readonly long[] Value={ 1L,10L,12L,110L,120L,1020L,1200L,1248L,10250L,11250L,12480L,31248L,132600L,124800L,112500L,312480L,1248000L,1312500L,1125000L,3124800L,14437500L,16250000L,11250000L,31248000L,103125000L,144375000L,112500000L,131250000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155005Inst : IEnumerable<long>
{
public static readonly long[] Value=A155005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155005.Bytes);
public long this[int i]=>Value[i];

public static A155005Inst Instance=new A155005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155006
{
public static readonly long[] Value={ 5L,7L,13L,23L,37L,43L,73L,167L,233L,263L,433L,557L,587L,593L,607L,727L,857L,1153L,1597L,1627L,1753L,2143L,2663L,2713L,3433L,3607L,3863L,3947L,4027L,4363L,4423L,4673L,5147L,5477L,5623L,5807L,5903L,6277L,7237L,7333L,7577L,8287L,8647L,8837L,8887L,9043L,10067L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155006Inst : IEnumerable<long>
{
public static readonly long[] Value=A155006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155006.Bytes);
public long this[int i]=>Value[i];

public static A155006Inst Instance=new A155006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155007
{
public static readonly long[] Value={ 7L,17L,37L,113L,157L,227L,283L,293L,313L,347L,443L,587L,787L,883L,1063L,1097L,1237L,1303L,1327L,1427L,1567L,1723L,1933L,1973L,2087L,2347L,2467L,2687L,2777L,3457L,3593L,4447L,4703L,4793L,4967L,5737L,5827L,6317L,6607L,6793L,6857L,8297L,8563L,8803L,9433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155007Inst : IEnumerable<long>
{
public static readonly long[] Value=A155007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155007.Bytes);
public long this[int i]=>Value[i];

public static A155007Inst Instance=new A155007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155008
{
public static readonly long[] Value={ 3L,5L,7L,11L,19L,29L,31L,59L,101L,139L,239L,271L,829L,1031L,1201L,1439L,1511L,1531L,2251L,2609L,3929L,4349L,4969L,5449L,5639L,5711L,5801L,5881L,5981L,6521L,6569L,6701L,6949L,6959L,8221L,8831L,9001L,9181L,9209L,9419L,9511L,9929L,10139L,10711L,11839L,11981L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155008Inst : IEnumerable<long>
{
public static readonly long[] Value=A155008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155008.Bytes);
public long this[int i]=>Value[i];

public static A155008Inst Instance=new A155008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155009
{
public static readonly long[] Value={ 2L,7L,11L,17L,19L,23L,41L,43L,61L,67L,107L,109L,131L,137L,179L,197L,263L,269L,331L,353L,397L,641L,677L,743L,859L,941L,1163L,1171L,1213L,1303L,1319L,1433L,1447L,1453L,1543L,1601L,1783L,2221L,2351L,2371L,2417L,2503L,2657L,2689L,2791L,2797L,2909L,3037L,3301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155009Inst : IEnumerable<long>
{
public static readonly long[] Value=A155009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155009.Bytes);
public long this[int i]=>Value[i];

public static A155009Inst Instance=new A155009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155010
{
public static readonly long[] Value={ 7L,37L,587L,28703L,35677L,36857L,99367L,326707L,361687L,578167L,613573L,619007L,656407L,688783L,702203L,713467L,874823L,922027L,940573L,1045763L,1057907L,1244687L,1371157L,1419697L,1555187L,1665767L,1687187L,1687327L,1799453L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155010Inst : IEnumerable<long>
{
public static readonly long[] Value=A155010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155010.Bytes);
public long this[int i]=>Value[i];

public static A155010Inst Instance=new A155010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155011
{
public static readonly BigInteger[] Value={ 2L,3L,5L,89L,233L,BigInteger.Parse("10597999265301490732599643671505003412515860435409421932560009680142974347195483140293254396195769876129909") };
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
public class A155011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155011Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155011.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A155011.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155011Inst Instance=new A155011Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155012
{
public static readonly BigInteger[] Value={ 3L,5L,13L,89L,233L,1597L,514229L,99194853094755497L,BigInteger.Parse("19134702400093278081449423917") };
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
public class A155012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155012Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155012.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A155012.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155012Inst Instance=new A155012Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155013
{
public static readonly long[] Value={ 1L,5L,15L,32L,55L,88L,129L,181L,243L,316L,401L,498L,609L,733L,871L,1024L,1191L,1374L,1573L,1788L,2020L,2270L,2536L,2821L,3125L,3446L,3787L,4148L,4528L,4929L,5350L,5792L,6255L,6740L,7247L,7776L,8327L,8901L,9498L,10119L,10763L,11432L,12124L,12841L,13584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155013Inst : IEnumerable<long>
{
public static readonly long[] Value=A155013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155013.Bytes);
public long this[int i]=>Value[i];

public static A155013Inst Instance=new A155013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155014
{
public static readonly long[] Value={ 0L,1L,11L,46L,128L,279L,529L,907L,1448L,2187L,3162L,4414L,5985L,7921L,10267L,13071L,16384L,20256L,24743L,29897L,35777L,42439L,49943L,58350L,67723L,78125L,89620L,102275L,116159L,131338L,147885L,165869L,185363L,206442L,229179L,253651L,279936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155014Inst : IEnumerable<long>
{
public static readonly long[] Value=A155014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155014.Bytes);
public long this[int i]=>Value[i];

public static A155014Inst Instance=new A155014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155015
{
public static readonly long[] Value={ 0L,1L,45L,420L,2048L,6987L,19047L,44467L,92681L,177147L,316227L,534145L,861979L,1338715L,2012353L,2941046L,4194304L,5854220L,8016758L,10793065L,14310835L,18715701L,24172676L,30867616L,39008731L,48828125L,60583368L,74559107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155015Inst : IEnumerable<long>
{
public static readonly long[] Value=A155015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155015.Bytes);
public long this[int i]=>Value[i];

public static A155015Inst Instance=new A155015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155016
{
public static readonly long[] Value={ 0L,1L,90L,1262L,8192L,34938L,114283L,311269L,741455L,1594323L,3162277L,5875603L,10343751L,17403307L,28172943L,44115700L,67108864L,99521746L,144301645L,205068240L,286216701L,393029741L,531798888L,709955183L,936209559L,1220703125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155016Inst : IEnumerable<long>
{
public static readonly long[] Value=A155016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155016.Bytes);
public long this[int i]=>Value[i];

public static A155016Inst Instance=new A155016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155017
{
public static readonly long[] Value={ 1L,1L,19L,280L,4510L,70300L,1108900L,17416000L,273961000L,4307050000L,67726990000L,1064904400000L,16744473100000L,263286127000000L,4139863849000000L,65094389920000000L,1023531645610000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155017Inst : IEnumerable<long>
{
public static readonly long[] Value=A155017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155017.Bytes);
public long this[int i]=>Value[i];

public static A155017Inst Instance=new A155017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155018
{
public static readonly long[] Value={ 0L,1L,181L,3787L,32768L,174692L,685700L,2178889L,5931641L,14348907L,31622776L,64631634L,124125023L,226242995L,394421215L,661735513L,1073741824L,1691869691L,2597429617L,3896296578L,5724334022L,8253624572L,11699575548L,16328969210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155018Inst : IEnumerable<long>
{
public static readonly long[] Value=A155018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155018.Bytes);
public long this[int i]=>Value[i];

public static A155018Inst Instance=new A155018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155019
{
public static readonly long[] Value={ 0L,1L,362L,11363L,131072L,873464L,4114202L,15252229L,47453132L,129140163L,316227766L,710947978L,1489500287L,2941158941L,5521897022L,9926032708L,17179869184L,28761784747L,46753733110L,74029634996L,114486680447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155019Inst : IEnumerable<long>
{
public static readonly long[] Value=A155019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155019.Bytes);
public long this[int i]=>Value[i];

public static A155019Inst Instance=new A155019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155020
{
public static readonly long[] Value={ 1L,1L,3L,8L,22L,60L,164L,448L,1224L,3344L,9136L,24960L,68192L,186304L,508992L,1390592L,3799168L,10379520L,28357376L,77473792L,211662336L,578272256L,1579869184L,4316282880L,11792304128L,32217174016L,88018956288L,240472260608L,656982433792L,1794909388800L,4903783645184L,13397386067968L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155020Inst : IEnumerable<long>
{
public static readonly long[] Value=A155020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155020.Bytes);
public long this[int i]=>Value[i];

public static A155020Inst Instance=new A155020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155021
{
public static readonly long[] Value={ 0L,42L,1566L,2154L,4482L,6054L,6252L,7566L,7968L,8478L,9546L,10128L,10992L,14286L,14574L,15846L,16212L,16248L,16854L,17268L,17976L,18186L,22434L,23658L,23952L,24234L,24408L,26154L,26742L,28908L,29262L,30018L,30522L,32424L,33174L,33378L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155021Inst : IEnumerable<long>
{
public static readonly long[] Value=A155021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155021.Bytes);
public long this[int i]=>Value[i];

public static A155021Inst Instance=new A155021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155022
{
public static readonly long[] Value={ 0L,66L,516L,3450L,7200L,8850L,12480L,16500L,18234L,18534L,19440L,21246L,26466L,28596L,39036L,41634L,43500L,43710L,54186L,54876L,59316L,68886L,77184L,81540L,82134L,88044L,89064L,95796L,97530L,98610L,108294L,111864L,113160L,120534L,120696L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155022Inst : IEnumerable<long>
{
public static readonly long[] Value=A155022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155022.Bytes);
public long this[int i]=>Value[i];

public static A155022Inst Instance=new A155022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155023
{
public static readonly long[] Value={ 0L,1770L,10182L,11700L,12090L,16548L,24192L,27570L,29142L,29148L,60648L,62790L,63120L,97110L,104502L,115140L,116718L,119682L,122130L,127728L,147210L,151848L,170292L,189318L,190452L,192738L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155023Inst : IEnumerable<long>
{
public static readonly long[] Value=A155023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155023.Bytes);
public long this[int i]=>Value[i];

public static A155023Inst Instance=new A155023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155024
{
public static readonly long[] Value={ 19L,41L,61L,89L,109L,149L,401L,409L,419L,461L,491L,601L,619L,641L,691L,809L,941L,1049L,1069L,1409L,1489L,1609L,4019L,4091L,4691L,4801L,4861L,6089L,6091L,6481L,6491L,6841L,8069L,8419L,8461L,8609L,8641L,8941L,9041L,9461L,9601L,14869L,18049L,40169L,40189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155024Inst : IEnumerable<long>
{
public static readonly long[] Value=A155024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155024.Bytes);
public long this[int i]=>Value[i];

public static A155024Inst Instance=new A155024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155025
{
public static readonly long[] Value={ 2L,19L,23L,29L,43L,47L,53L,71L,73L,79L,89L,97L,101L,107L,131L,137L,139L,163L,167L,173L,193L,223L,227L,229L,233L,239L,257L,281L,293L,307L,311L,313L,317L,337L,347L,349L,359L,373L,379L,383L,389L,397L,409L,419L,433L,443L,449L,457L,463L,467L,491L,499L,503L,521L,541L,557L,569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155025Inst : IEnumerable<long>
{
public static readonly long[] Value=A155025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155025.Bytes);
public long this[int i]=>Value[i];

public static A155025Inst Instance=new A155025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155026
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,17L,19L,31L,37L,41L,43L,53L,59L,61L,71L,73L,79L,83L,97L,113L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L,211L,241L,251L,271L,281L,311L,313L,317L,331L,337L,347L,349L,353L,359L,367L,373L,379L,383L,389L,397L,419L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155026Inst : IEnumerable<long>
{
public static readonly long[] Value=A155026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155026.Bytes);
public long this[int i]=>Value[i];

public static A155026Inst Instance=new A155026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155027
{
public static readonly long[] Value={ 7L,10L,18L,26L,36L,48L,60L,76L,90L,106L,120L,130L,140L,160L,170L,192L,204L,252L,274L,322L,364L,414L,466L,512L,550L,554L,628L,632L,706L,750L,798L,862L,902L,928L,950L,970L,1008L,1072L,1114L,1228L,1276L,1488L,1522L,1682L,1702L,1806L,2350L,2442L,3094L,3098L,3244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155027Inst : IEnumerable<long>
{
public static readonly long[] Value=A155027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155027.Bytes);
public long this[int i]=>Value[i];

public static A155027Inst Instance=new A155027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155028
{
public static readonly long[] Value={ 2L,5L,7L,13L,23L,47L,79L,89L,103L,109L,137L,139L,193L,223L,229L,257L,277L,293L,317L,347L,379L,389L,443L,457L,499L,593L,607L,653L,677L,709L,733L,823L,853L,883L,907L,953L,1013L,1033L,1087L,1103L,1117L,1283L,1297L,1307L,1327L,1367L,1409L,1489L,1523L,1549L,1597L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155028Inst : IEnumerable<long>
{
public static readonly long[] Value=A155028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155028.Bytes);
public long this[int i]=>Value[i];

public static A155028Inst Instance=new A155028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155029
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155029Inst : IEnumerable<long>
{
public static readonly long[] Value=A155029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155029.Bytes);
public long this[int i]=>Value[i];

public static A155029Inst Instance=new A155029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155030
{
public static readonly long[] Value={ 5L,11L,17L,31L,41L,67L,109L,127L,157L,191L,211L,241L,277L,331L,367L,401L,461L,509L,547L,563L,587L,599L,617L,739L,773L,797L,859L,877L,919L,967L,991L,1031L,1063L,1087L,1153L,1171L,1201L,1217L,1297L,1409L,1447L,1471L,1499L,1523L,1597L,1621L,1669L,1723L,1741L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155030Inst : IEnumerable<long>
{
public static readonly long[] Value=A155030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155030.Bytes);
public long this[int i]=>Value[i];

public static A155030Inst Instance=new A155030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155031
{
public static readonly long[] Value={ 1L,0L,1L,0L,-1L,1L,0L,0L,-1L,1L,0L,-1L,-1L,-1L,1L,0L,0L,0L,-1L,-1L,1L,0L,-1L,-1L,-1L,-1L,-1L,1L,0L,0L,-1L,0L,-1L,-1L,-1L,1L,0L,-1L,0L,-1L,-1L,-1L,-1L,-1L,1L,0L,0L,-1L,-1L,0L,-1L,-1L,-1L,-1L,1L,0L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,0L,0L,0L,0L,-1L,0L,-1L,-1L,-1L,-1L,-1L,1L,0L,-1L,-1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155031Inst : IEnumerable<long>
{
public static readonly long[] Value=A155031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155031.Bytes);
public long this[int i]=>Value[i];

public static A155031Inst Instance=new A155031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155032
{
public static readonly long[] Value={ 3L,59L,83L,179L,283L,353L,431L,709L,1433L,2269L,2381L,3559L,3593L,4153L,5503L,6899L,7109L,7351L,7649L,8513L,11909L,13297L,14107L,14437L,14591L,16073L,16127L,16451L,16901L,17117L,17539L,17987L,18149L,19777L,20759L,21317L,22027L,24439L,25357L,26783L,27437L,29269L,30253L,32299L,34057L,34259L,34421L,34543L,35617L,36307L,37049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155032Inst : IEnumerable<long>
{
public static readonly long[] Value=A155032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155032.Bytes);
public long this[int i]=>Value[i];

public static A155032Inst Instance=new A155032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155033
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,3L,2L,1L,1L,0L,4L,3L,2L,1L,1L,0L,10L,7L,4L,2L,1L,1L,0L,18L,13L,7L,4L,2L,1L,1L,0L,37L,26L,15L,8L,4L,2L,1L,1L,0L,71L,51L,29L,15L,8L,4L,2L,1L,1L,0L,146L,104L,59L,31L,16L,8L,4L,2L,1L,1L,0L,285L,203L,115L,61L,31L,16L,8L,4L,2L,1L,1L,0L,577L,411L,233L,123L,63L,32L,16L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155033Inst : IEnumerable<long>
{
public static readonly long[] Value=A155033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155033.Bytes);
public long this[int i]=>Value[i];

public static A155033Inst Instance=new A155033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155034
{
public static readonly long[] Value={ 3L,5L,7L,37L,43L,53L,59L,73L,79L,83L,97L,337L,347L,349L,353L,359L,367L,373L,379L,383L,389L,397L,433L,439L,443L,463L,557L,563L,569L,577L,587L,593L,599L,643L,653L,659L,673L,683L,733L,739L,743L,757L,773L,787L,797L,839L,853L,857L,859L,863L,877L,883L,887L,937L,953L,977L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155034Inst : IEnumerable<long>
{
public static readonly long[] Value=A155034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155034.Bytes);
public long this[int i]=>Value[i];

public static A155034Inst Instance=new A155034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155035
{
public static readonly long[] Value={ 1L,8L,2L,9L,4L,8L,2L,8L,0L,0L,4L,3L,5L,1L,5L,0L,4L,8L,6L,8L,8L,2L,8L,2L,8L,1L,8L,0L,4L,8L,0L,6L,4L,9L,8L,2L,9L,1L,7L,8L,0L,7L,8L,3L,3L,0L,9L,1L,0L,6L,7L,8L,3L,8L,4L,0L,7L,4L,6L,1L,1L,5L,5L,5L,8L,1L,1L,5L,2L,5L,6L,3L,9L,2L,8L,6L,9L,8L,4L,3L,9L,1L,2L,6L,2L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155035Inst : IEnumerable<long>
{
public static readonly long[] Value=A155035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155035.Bytes);
public long this[int i]=>Value[i];

public static A155035Inst Instance=new A155035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155036
{
public static readonly long[] Value={ 7L,13L,37L,61L,103L,113L,149L,151L,181L,197L,199L,251L,263L,269L,271L,421L,439L,479L,487L,523L,631L,643L,653L,661L,677L,769L,811L,829L,853L,937L,947L,1019L,1039L,1049L,1051L,1277L,1319L,1399L,1427L,1489L,1543L,1663L,1753L,1759L,1831L,1867L,1901L,1933L,1949L,1999L,2039L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155036Inst : IEnumerable<long>
{
public static readonly long[] Value=A155036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155036.Bytes);
public long this[int i]=>Value[i];

public static A155036Inst Instance=new A155036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155037
{
public static readonly long[] Value={ 2L,4L,8L,10L,12L,14L,18L,22L,34L,42L,44L,48L,56L,62L,64L,76L,78L,80L,88L,90L,100L,102L,116L,130L,134L,136L,144L,146L,154L,162L,168L,184L,186L,212L,222L,226L,230L,234L,238L,248L,260L,264L,270L,282L,284L,288L,300L,310L,314L,316L,350L,356L,378L,400L,404L,418L,424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155037Inst : IEnumerable<long>
{
public static readonly long[] Value=A155037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155037.Bytes);
public long this[int i]=>Value[i];

public static A155037Inst Instance=new A155037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155038
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,4L,2L,1L,1L,8L,4L,2L,1L,1L,16L,8L,4L,2L,1L,1L,32L,16L,8L,4L,2L,1L,1L,64L,32L,16L,8L,4L,2L,1L,1L,128L,64L,32L,16L,8L,4L,2L,1L,1L,256L,128L,64L,32L,16L,8L,4L,2L,1L,1L,512L,256L,128L,64L,32L,16L,8L,4L,2L,1L,1L,1024L,512L,256L,128L,64L,32L,16L,8L,4L,2L,1L,1L,2048L,1024L,512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155038Inst : IEnumerable<long>
{
public static readonly long[] Value=A155038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155038.Bytes);
public long this[int i]=>Value[i];

public static A155038Inst Instance=new A155038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155039
{
public static readonly long[] Value={ 0L,1L,0L,2L,0L,0L,4L,1L,0L,0L,8L,1L,0L,0L,0L,16L,4L,1L,0L,0L,0L,32L,6L,1L,0L,0L,0L,0L,64L,14L,3L,1L,0L,0L,0L,0L,128L,27L,6L,1L,0L,0L,0L,0L,0L,256L,57L,13L,3L,1L,0L,0L,0L,0L,0L,512L,110L,24L,5L,1L,0L,0L,0L,0L,0L,0L,1024L,227L,53L,13L,3L,1L,0L,0L,0L,0L,0L,0L,2048L,447L,101L,23L,5L,1L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155039Inst : IEnumerable<long>
{
public static readonly long[] Value=A155039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155039.Bytes);
public long this[int i]=>Value[i];

public static A155039Inst Instance=new A155039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155040
{
public static readonly long[] Value={ 1L,1L,1L,1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,1L,-1L,1L,1L,-1L,1L,1L,-1L,1L,1L,-1L,1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,1L,-1L,-1L,1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155040Inst : IEnumerable<long>
{
public static readonly long[] Value=A155040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155040.Bytes);
public long this[int i]=>Value[i];

public static A155040Inst Instance=new A155040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155041
{
public static readonly long[] Value={ 1L,1L,2L,0L,1L,-1L,2L,0L,3L,-1L,2L,-2L,3L,-1L,4L,-2L,3L,-3L,4L,-2L,5L,-3L,4L,-4L,5L,-3L,6L,-4L,5L,-5L,6L,-4L,7L,-5L,6L,-6L,7L,-5L,8L,-6L,7L,-7L,8L,-6L,9L,-7L,8L,-8L,9L,-7L,10L,-8L,9L,-9L,10L,-8L,11L,-9L,10L,-10L,11L,-9L,12L,-10L,11L,-11L,12L,-10L,13L,-11L,12L,-12L,13L,-11L,14L,-12L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155041Inst : IEnumerable<long>
{
public static readonly long[] Value=A155041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155041.Bytes);
public long this[int i]=>Value[i];

public static A155041Inst Instance=new A155041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155042
{
public static readonly long[] Value={ 0L,1L,2L,5L,9L,21L,39L,82L,162L,330L,652L,1321L,2625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155042Inst : IEnumerable<long>
{
public static readonly long[] Value=A155042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155042.Bytes);
public long this[int i]=>Value[i];

public static A155042Inst Instance=new A155042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155043
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,2L,4L,3L,3L,3L,4L,3L,5L,4L,5L,5L,6L,4L,7L,5L,7L,5L,8L,6L,6L,6L,9L,6L,10L,6L,11L,7L,11L,7L,12L,10L,13L,8L,13L,8L,14L,8L,15L,9L,14L,9L,15L,9L,10L,10L,16L,10L,17L,10L,17L,10L,18L,11L,19L,10L,20L,12L,19L,19L,21L,12L,22L,13L,22L,13L,23L,11L,24L,14L,23L,14L,25L,14L,26L,14L,15L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155043Inst : IEnumerable<long>
{
public static readonly long[] Value=A155043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155043.Bytes);
public long this[int i]=>Value[i];

public static A155043Inst Instance=new A155043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155044
{
public static readonly long[] Value={ 1L,6L,4L,3L,3L,2L,2L,6L,8L,3L,5L,0L,4L,4L,9L,6L,9L,4L,4L,3L,3L,1L,3L,4L,1L,4L,4L,5L,4L,6L,6L,9L,4L,6L,7L,2L,7L,2L,1L,9L,7L,8L,3L,6L,7L,1L,6L,7L,9L,4L,1L,9L,4L,1L,8L,6L,1L,3L,7L,1L,3L,5L,3L,4L,4L,8L,7L,9L,4L,7L,7L,9L,6L,2L,6L,7L,6L,9L,5L,0L,9L,7L,9L,2L,8L,2L,7L,3L,8L,1L,0L,5L,0L,9L,1L,4L,5L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155044Inst : IEnumerable<long>
{
public static readonly long[] Value=A155044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155044.Bytes);
public long this[int i]=>Value[i];

public static A155044Inst Instance=new A155044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155045
{
public static readonly long[] Value={ 3L,5L,7L,13L,17L,19L,31L,37L,53L,59L,71L,73L,79L,97L,137L,139L,157L,173L,179L,193L,197L,317L,359L,379L,397L,571L,593L,719L,739L,751L,937L,953L,971L,1579L,1597L,1753L,1759L,1973L,3517L,3571L,3719L,3917L,5179L,5197L,5791L,7159L,7193L,7351L,7591L,7951L,9137L,9157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155045Inst : IEnumerable<long>
{
public static readonly long[] Value=A155045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155045.Bytes);
public long this[int i]=>Value[i];

public static A155045Inst Instance=new A155045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155046
{
public static readonly long[] Value={ 1L,1L,3L,2L,7L,5L,17L,12L,41L,29L,99L,70L,239L,169L,577L,408L,1393L,985L,3363L,2378L,8119L,5741L,19601L,13860L,47321L,33461L,114243L,80782L,275807L,195025L,665857L,470832L,1607521L,1136689L,3880899L,2744210L,9369319L,6625109L,22619537L,15994428L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155046Inst : IEnumerable<long>
{
public static readonly long[] Value=A155046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155046.Bytes);
public long this[int i]=>Value[i];

public static A155046Inst Instance=new A155046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155047
{
public static readonly long[] Value={ 1L,2L,3L,3L,3L,3L,5L,5L,5L,5L,7L,7L,7L,7L,7L,7L,11L,11L,11L,11L,11L,11L,13L,13L,13L,13L,13L,13L,17L,17L,17L,17L,17L,17L,19L,19L,19L,19L,19L,19L,23L,23L,23L,23L,23L,23L,23L,23L,23L,23L,29L,29L,29L,29L,29L,29L,29L,29L,31L,31L,31L,31L,31L,31L,31L,31L,37L,37L,37L,37L,37L,37L,37L,37L,37L,37L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155047Inst : IEnumerable<long>
{
public static readonly long[] Value=A155047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155047.Bytes);
public long this[int i]=>Value[i];

public static A155047Inst Instance=new A155047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155048
{
public static readonly long[] Value={ 7L,11L,17L,19L,23L,191L,199L,211L,227L,251L,277L,281L,311L,337L,347L,353L,359L,373L,383L,389L,397L,401L,409L,419L,439L,463L,467L,479L,523L,547L,557L,569L,571L,577L,593L,599L,613L,619L,641L,643L,653L,659L,673L,677L,683L,701L,709L,743L,751L,757L,769L,787L,809L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155048Inst : IEnumerable<long>
{
public static readonly long[] Value=A155048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155048.Bytes);
public long this[int i]=>Value[i];

public static A155048Inst Instance=new A155048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155049
{
public static readonly BigInteger[] Value={ 1L,18L,224L,2732L,33276L,405268L,4935724L,60111732L,732095276L,8916121268L,108588623724L,1322490895732L,16106495407276L,196159531337268L,2389008953311724L,29095521079679732L,354351684502719276L,4315616687738553268L,BigInteger.Parse("52559500095573999724"),BigInteger.Parse("640117334365076463732") };
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
public class A155049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155049Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155049.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A155049.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155049Inst Instance=new A155049Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155050
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,2L,5L,2L,1L,1L,1L,1L,2L,5L,5L,2L,1L,1L,1L,1L,2L,5L,14L,5L,2L,1L,1L,1L,1L,2L,5L,14L,14L,5L,2L,1L,1L,1L,1L,2L,5L,14L,42L,14L,5L,2L,1L,1L,1L,1L,2L,5L,14L,42L,42L,14L,5L,2L,1L,1L,1L,1L,2L,5L,14L,42L,132L,42L,14L,5L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155050Inst : IEnumerable<long>
{
public static readonly long[] Value=A155050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155050.Bytes);
public long this[int i]=>Value[i];

public static A155050Inst Instance=new A155050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155051
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,13L,18L,32L,46L,88L,130L,262L,394L,823L,1252L,2682L,4112L,8974L,13836L,30632L,47428L,106214L,165000L,373012L,581024L,1323924L,2066824L,4741264L,7415704L,17110549L,26805394L,62163064L,97520734L,227165524L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155051Inst : IEnumerable<long>
{
public static readonly long[] Value=A155051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155051.Bytes);
public long this[int i]=>Value[i];

public static A155051Inst Instance=new A155051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155052
{
public static readonly long[] Value={ 1L,-1L,1L,1L,-1L,1L,-1L,1L,-1L,1L,1L,-1L,2L,-1L,1L,-1L,1L,-2L,2L,-1L,1L,1L,-1L,2L,1L,2L,-1L,1L,-1L,1L,-2L,-1L,1L,2L,-1L,1L,1L,-1L,2L,1L,8L,1L,2L,-1L,1L,-1L,1L,-2L,-1L,-8L,8L,1L,2L,-1L,1L,1L,-1L,2L,1L,8L,20L,8L,1L,2L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155052Inst : IEnumerable<long>
{
public static readonly long[] Value=A155052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155052.Bytes);
public long this[int i]=>Value[i];

public static A155052Inst Instance=new A155052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155053
{
public static readonly long[] Value={ 5L,7L,11L,13L,19L,29L,31L,37L,41L,43L,47L,53L,67L,79L,83L,89L,97L,101L,113L,127L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L,239L,241L,251L,257L,263L,269L,271L,277L,281L,283L,293L,307L,311L,313L,317L,331L,347L,349L,353L,359L,379L,397L,409L,421L,431L,433L,439L,443L,449L,467L,479L,491L,523L,541L,557L,563L,569L,571L,577L,601L,613L,617L,619L,641L,643L,647L,653L,673L,677L,683L,691L,701L,709L,719L,727L,743L,751L,757L,761L,769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155053Inst : IEnumerable<long>
{
public static readonly long[] Value=A155053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155053.Bytes);
public long this[int i]=>Value[i];

public static A155053Inst Instance=new A155053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155054
{
public static readonly long[] Value={ 5L,13L,29L,41L,43L,47L,53L,79L,83L,89L,97L,109L,113L,127L,149L,157L,163L,167L,173L,179L,181L,193L,197L,223L,229L,233L,239L,257L,263L,271L,283L,293L,313L,317L,379L,421L,431L,433L,443L,449L,487L,541L,563L,601L,607L,617L,631L,647L,661L,691L,719L,761L,773L,797L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155054Inst : IEnumerable<long>
{
public static readonly long[] Value=A155054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155054.Bytes);
public long this[int i]=>Value[i];

public static A155054Inst Instance=new A155054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155055
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,17L,19L,31L,37L,53L,59L,71L,73L,79L,97L,101L,103L,107L,109L,113L,131L,137L,139L,151L,157L,173L,179L,191L,193L,197L,199L,307L,311L,313L,317L,331L,337L,353L,359L,373L,379L,397L,503L,509L,557L,571L,577L,593L,599L,701L,709L,719L,733L,739L,751L,757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155055Inst : IEnumerable<long>
{
public static readonly long[] Value=A155055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155055.Bytes);
public long this[int i]=>Value[i];

public static A155055Inst Instance=new A155055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155056
{
public static readonly long[] Value={ 2L,3L,31L,37L,59L,61L,67L,71L,73L,101L,103L,107L,131L,137L,139L,151L,241L,269L,307L,331L,349L,367L,457L,461L,491L,499L,503L,509L,521L,587L,727L,733L,739L,823L,827L,907L,929L,937L,953L,983L,1033L,1049L,1063L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155056Inst : IEnumerable<long>
{
public static readonly long[] Value=A155056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155056.Bytes);
public long this[int i]=>Value[i];

public static A155056Inst Instance=new A155056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155057
{
public static readonly BigInteger[] Value={ 48988659276962496L,490593422681271000L,6355491080314102272L,BigInteger.Parse("27365551142421413376"),BigInteger.Parse("47893568195858112000"),BigInteger.Parse("55634997032869710456"),BigInteger.Parse("68243313527087529096"),BigInteger.Parse("265781191139199122625"),BigInteger.Parse("276114357544758340608") };
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
public class A155057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155057Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155057.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A155057.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155057Inst Instance=new A155057Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155058
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,17L,19L,23L,29L,31L,37L,47L,53L,59L,67L,71L,73L,79L,89L,97L,101L,103L,107L,109L,113L,127L,131L,137L,139L,149L,151L,157L,167L,173L,179L,191L,193L,197L,199L,223L,227L,229L,233L,239L,251L,257L,269L,271L,277L,293L,307L,311L,313L,317L,331L,337L,347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155058Inst : IEnumerable<long>
{
public static readonly long[] Value=A155058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155058.Bytes);
public long this[int i]=>Value[i];

public static A155058Inst Instance=new A155058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155059
{
public static readonly long[] Value={ 1L,5L,1L,3L,1L,4L,2L,3L,1L,0L,6L,0L,2L,5L,1L,4L,6L,4L,7L,6L,1L,4L,8L,2L,7L,8L,2L,7L,1L,6L,8L,8L,2L,7L,8L,9L,7L,4L,9L,5L,8L,7L,0L,4L,2L,7L,3L,8L,1L,1L,3L,5L,7L,3L,1L,6L,0L,4L,4L,8L,3L,4L,6L,8L,1L,8L,1L,4L,2L,2L,8L,4L,6L,5L,2L,7L,4L,6L,7L,4L,1L,3L,4L,0L,5L,8L,7L,0L,5L,7L,2L,0L,1L,6L,1L,6L,2L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155059Inst : IEnumerable<long>
{
public static readonly long[] Value=A155059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155059.Bytes);
public long this[int i]=>Value[i];

public static A155059Inst Instance=new A155059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155060
{
public static readonly long[] Value={ 1L,4L,1L,5L,9L,7L,5L,8L,3L,7L,8L,1L,4L,5L,2L,8L,4L,9L,7L,9L,3L,1L,1L,7L,3L,1L,4L,0L,9L,6L,8L,9L,4L,4L,8L,0L,7L,5L,6L,4L,5L,0L,2L,5L,2L,3L,2L,2L,0L,5L,1L,1L,3L,3L,8L,1L,9L,3L,8L,4L,1L,5L,7L,6L,9L,5L,4L,8L,5L,5L,0L,6L,9L,4L,0L,1L,8L,2L,1L,6L,2L,8L,9L,3L,4L,2L,3L,6L,0L,1L,8L,0L,5L,7L,3L,9L,2L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155060Inst : IEnumerable<long>
{
public static readonly long[] Value=A155060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155060.Bytes);
public long this[int i]=>Value[i];

public static A155060Inst Instance=new A155060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155061
{
public static readonly long[] Value={ 1L,3L,4L,0L,0L,7L,1L,9L,2L,9L,6L,2L,3L,1L,8L,7L,6L,7L,2L,4L,2L,5L,2L,8L,3L,3L,1L,0L,1L,0L,9L,5L,9L,7L,5L,6L,5L,2L,3L,3L,0L,7L,1L,4L,2L,1L,3L,4L,7L,1L,7L,6L,6L,1L,0L,9L,1L,8L,4L,4L,4L,2L,7L,8L,2L,5L,8L,9L,7L,0L,4L,3L,5L,8L,6L,7L,5L,1L,4L,6L,5L,4L,9L,3L,8L,6L,3L,7L,2L,3L,8L,4L,2L,4L,8L,7L,7L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155061Inst : IEnumerable<long>
{
public static readonly long[] Value=A155061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155061.Bytes);
public long this[int i]=>Value[i];

public static A155061Inst Instance=new A155061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155062
{
public static readonly long[] Value={ 1L,2L,7L,8L,7L,5L,3L,6L,0L,0L,9L,5L,2L,8L,2L,8L,9L,6L,1L,5L,3L,6L,3L,3L,3L,4L,7L,5L,7L,5L,6L,9L,2L,9L,3L,1L,7L,9L,5L,1L,1L,2L,9L,3L,3L,7L,3L,9L,4L,4L,9L,7L,5L,9L,8L,9L,0L,6L,8L,1L,8L,8L,6L,8L,7L,0L,7L,7L,5L,0L,8L,4L,1L,3L,5L,0L,6L,4L,2L,7L,2L,2L,8L,9L,4L,3L,8L,4L,4L,2L,0L,9L,0L,0L,2L,0L,5L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155062Inst : IEnumerable<long>
{
public static readonly long[] Value=A155062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155062.Bytes);
public long this[int i]=>Value[i];

public static A155062Inst Instance=new A155062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155063
{
public static readonly long[] Value={ 1L,2L,2L,7L,9L,2L,6L,4L,2L,8L,8L,8L,4L,5L,4L,7L,2L,8L,5L,1L,4L,6L,1L,6L,7L,9L,4L,5L,8L,0L,7L,1L,5L,5L,9L,8L,5L,5L,0L,8L,9L,6L,7L,2L,0L,3L,8L,2L,6L,5L,0L,5L,5L,6L,5L,9L,1L,1L,1L,3L,3L,3L,2L,6L,1L,6L,7L,4L,9L,6L,2L,6L,6L,7L,3L,7L,5L,6L,8L,7L,2L,8L,0L,1L,2L,8L,0L,9L,5L,3L,4L,5L,9L,0L,6L,1L,5L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155063Inst : IEnumerable<long>
{
public static readonly long[] Value=A155063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155063.Bytes);
public long this[int i]=>Value[i];

public static A155063Inst Instance=new A155063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155064
{
public static readonly long[] Value={ 1L,1L,8L,4L,9L,2L,9L,4L,1L,3L,5L,1L,2L,4L,3L,3L,2L,0L,4L,7L,1L,3L,4L,8L,7L,1L,4L,9L,7L,9L,2L,5L,6L,4L,8L,6L,2L,5L,4L,7L,2L,5L,3L,2L,4L,9L,8L,8L,5L,0L,6L,0L,4L,2L,9L,1L,2L,3L,9L,8L,4L,5L,5L,9L,1L,8L,3L,2L,6L,1L,4L,8L,5L,8L,6L,3L,0L,5L,9L,3L,2L,6L,4L,1L,6L,0L,5L,9L,7L,7L,1L,0L,8L,3L,1L,0L,8L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155064Inst : IEnumerable<long>
{
public static readonly long[] Value=A155064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155064.Bytes);
public long this[int i]=>Value[i];

public static A155064Inst Instance=new A155064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155065
{
public static readonly long[] Value={ 1L,1L,4L,7L,9L,5L,2L,0L,9L,1L,3L,7L,4L,0L,2L,8L,0L,1L,3L,0L,6L,4L,7L,7L,5L,5L,9L,7L,1L,1L,0L,6L,3L,6L,4L,5L,9L,4L,8L,4L,0L,9L,2L,9L,1L,9L,4L,4L,9L,7L,6L,6L,6L,1L,2L,3L,2L,9L,1L,4L,5L,0L,3L,2L,5L,2L,3L,0L,0L,4L,6L,5L,2L,2L,4L,6L,9L,6L,7L,8L,1L,5L,1L,9L,3L,6L,6L,0L,8L,4L,6L,0L,5L,7L,8L,4L,1L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155065Inst : IEnumerable<long>
{
public static readonly long[] Value=A155065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155065.Bytes);
public long this[int i]=>Value[i];

public static A155065Inst Instance=new A155065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155066
{
public static readonly long[] Value={ 1L,1L,1L,5L,7L,1L,6L,1L,8L,6L,2L,7L,7L,6L,5L,9L,4L,7L,4L,4L,5L,9L,7L,9L,5L,8L,1L,1L,4L,2L,8L,3L,8L,5L,9L,9L,3L,1L,6L,9L,4L,6L,6L,8L,5L,5L,0L,2L,5L,9L,6L,9L,6L,8L,6L,0L,6L,3L,2L,5L,9L,8L,6L,9L,7L,7L,6L,6L,7L,5L,7L,3L,2L,1L,0L,6L,5L,1L,4L,1L,5L,3L,3L,0L,5L,3L,9L,1L,0L,6L,3L,5L,1L,6L,2L,8L,4L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155066Inst : IEnumerable<long>
{
public static readonly long[] Value=A155066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155066.Bytes);
public long this[int i]=>Value[i];

public static A155066Inst Instance=new A155066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155067
{
public static readonly long[] Value={ 3L,6L,6L,6L,8L,10L,6L,12L,8L,6L,10L,14L,6L,6L,18L,10L,12L,8L,10L,12L,12L,6L,14L,16L,6L,8L,16L,12L,8L,6L,24L,6L,18L,16L,6L,14L,12L,10L,12L,18L,12L,8L,10L,12L,6L,20L,12L,10L,14L,24L,16L,8L,16L,12L,8L,10L,14L,12L,10L,8L,16L,14L,18L,18L,12L,12L,10L,12L,24L,14L,12L,6L,24L,6L,18L,6L,24L,12L,18L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155067Inst : IEnumerable<long>
{
public static readonly long[] Value=A155067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155067.Bytes);
public long this[int i]=>Value[i];

public static A155067Inst Instance=new A155067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155068
{
public static readonly long[] Value={ 1L,0L,8L,7L,2L,9L,1L,1L,3L,5L,8L,7L,6L,2L,9L,1L,0L,7L,6L,6L,4L,9L,1L,5L,1L,4L,3L,4L,4L,6L,0L,2L,9L,9L,4L,3L,7L,7L,9L,0L,0L,9L,3L,9L,0L,0L,2L,8L,0L,7L,1L,2L,5L,2L,4L,9L,5L,1L,0L,2L,2L,9L,8L,0L,8L,4L,8L,5L,0L,3L,2L,9L,1L,4L,1L,3L,0L,2L,8L,7L,7L,2L,4L,1L,1L,3L,6L,2L,8L,1L,1L,9L,2L,5L,9L,8L,7L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155068Inst : IEnumerable<long>
{
public static readonly long[] Value=A155068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155068.Bytes);
public long this[int i]=>Value[i];

public static A155068Inst Instance=new A155068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155069
{
public static readonly long[] Value={ 1L,1L,2L,6L,22L,90L,394L,1806L,8558L,41586L,206098L,1037718L,5293446L,27297738L,142078746L,745387038L,3937603038L,20927156706L,111818026018L,600318853926L,3236724317174L,17518619320890L,95149655201962L,518431875418926L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155069Inst : IEnumerable<long>
{
public static readonly long[] Value=A155069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155069.Bytes);
public long this[int i]=>Value[i];

public static A155069Inst Instance=new A155069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155070
{
public static readonly long[] Value={ 11L,19L,29L,41L,43L,59L,61L,79L,83L,89L,97L,101L,109L,139L,149L,163L,179L,181L,191L,193L,197L,199L,229L,239L,241L,263L,269L,281L,283L,293L,349L,359L,379L,383L,389L,397L,401L,409L,419L,421L,431L,433L,439L,443L,449L,461L,463L,479L,487L,491L,499L,509L,563L,569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155070Inst : IEnumerable<long>
{
public static readonly long[] Value=A155070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155070.Bytes);
public long this[int i]=>Value[i];

public static A155070Inst Instance=new A155070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155071
{
public static readonly long[] Value={ 11L,13L,17L,19L,31L,37L,53L,59L,71L,73L,79L,97L,101L,103L,107L,109L,127L,149L,163L,167L,181L,211L,233L,239L,251L,257L,271L,277L,293L,307L,347L,349L,367L,383L,389L,419L,431L,433L,439L,457L,479L,491L,499L,503L,509L,521L,523L,541L,547L,563L,569L,587L,613L,617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155071Inst : IEnumerable<long>
{
public static readonly long[] Value=A155071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155071.Bytes);
public long this[int i]=>Value[i];

public static A155071Inst Instance=new A155071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155072
{
public static readonly long[] Value={ 17L,41L,97L,137L,193L,313L,401L,409L,449L,521L,569L,761L,769L,809L,857L,929L,977L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155072Inst : IEnumerable<long>
{
public static readonly long[] Value=A155072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155072.Bytes);
public long this[int i]=>Value[i];

public static A155072Inst Instance=new A155072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155073
{
public static readonly BigInteger[] Value={ 1L,18L,224L,2832L,35776L,451968L,5709824L,72133632L,911282176L,11512455168L,145439719424L,1837376274432L,23212033048576L,293243406778368L,3704617145729024L,46801353002975232L,591253173201534976L,7469448902442221568L,BigInteger.Parse("94363412214918938624"),BigInteger.Parse("1192116537798565036032") };
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
public class A155073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155073Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155073.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A155073.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155073Inst Instance=new A155073Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155074
{
public static readonly long[] Value={ 23L,31L,71L,113L,131L,167L,271L,293L,317L,347L,359L,373L,379L,389L,491L,571L,631L,673L,677L,719L,761L,773L,811L,877L,911L,929L,937L,941L,971L,983L,997L,1031L,1091L,1103L,1171L,1193L,1223L,1231L,1283L,1291L,1361L,1409L,1433L,1511L,1523L,1531L,1571L,1607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155074Inst : IEnumerable<long>
{
public static readonly long[] Value=A155074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155074.Bytes);
public long this[int i]=>Value[i];

public static A155074Inst Instance=new A155074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155075
{
public static readonly long[] Value={ 11L,101L,113L,131L,151L,181L,191L,199L,211L,223L,227L,229L,233L,277L,311L,313L,331L,337L,353L,373L,383L,433L,443L,449L,499L,557L,577L,599L,661L,677L,727L,733L,757L,773L,787L,797L,811L,877L,881L,883L,887L,911L,919L,929L,977L,991L,997L,1009L,1013L,1019L,1021L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155075Inst : IEnumerable<long>
{
public static readonly long[] Value=A155075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155075.Bytes);
public long this[int i]=>Value[i];

public static A155075Inst Instance=new A155075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155076
{
public static readonly long[] Value={ 1L,-1L,1L,-1L,0L,1L,-1L,-1L,0L,1L,-1L,-1L,0L,0L,1L,-1L,-1L,-1L,0L,0L,1L,-1L,-1L,-1L,0L,0L,0L,1L,-1L,-1L,-1L,-1L,0L,0L,0L,1L,-1L,-1L,-1L,-1L,0L,0L,0L,0L,1L,-1L,-1L,-1L,-1L,-1L,0L,0L,0L,0L,1L,-1L,-1L,-1L,-1L,-1L,0L,0L,0L,0L,0L,1L,-1L,-1L,-1L,-1L,-1L,-1L,0L,0L,0L,0L,0L,1L,-1L,-1L,-1L,-1L,-1L,-1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155076Inst : IEnumerable<long>
{
public static readonly long[] Value=A155076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155076.Bytes);
public long this[int i]=>Value[i];

public static A155076Inst Instance=new A155076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155077
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,2L,1L,0L,1L,2L,1L,0L,0L,1L,3L,1L,1L,0L,0L,1L,3L,1L,1L,0L,0L,0L,1L,5L,2L,1L,1L,0L,0L,0L,1L,5L,2L,1L,1L,0L,0L,0L,0L,1L,7L,3L,1L,1L,1L,0L,0L,0L,0L,1L,7L,3L,1L,1L,1L,0L,0L,0L,0L,0L,1L,10L,4L,2L,1L,1L,1L,0L,0L,0L,0L,0L,1L,10L,4L,2L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,13L,5L,3L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155077Inst : IEnumerable<long>
{
public static readonly long[] Value=A155077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155077.Bytes);
public long this[int i]=>Value[i];

public static A155077Inst Instance=new A155077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155078
{
public static readonly long[] Value={ 3L,4L,5L,4L,3L,3L,4L,4L,5L,3L,13L,3L,15L,4L,8L,4L,8L,5L,21L,8L,4L,22L,25L,6L,27L,26L,5L,4L,31L,3L,4L,4L,8L,8L,32L,3L,39L,38L,38L,8L,43L,4L,45L,22L,8L,23L,19L,6L,9L,50L,8L,26L,24L,5L,46L,4L,5L,29L,18L,3L,63L,4L,5L,4L,7L,6L,69L,8L,25L,30L,47L,6L,4L,74L,17L,38L,79L,12L,60L,8L,79L,82L,85L,4L,8L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155078Inst : IEnumerable<long>
{
public static readonly long[] Value=A155078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155078.Bytes);
public long this[int i]=>Value[i];

public static A155078Inst Instance=new A155078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155079
{
public static readonly long[] Value={ 1L,0L,6L,1L,9L,8L,1L,8L,7L,8L,3L,6L,0L,8L,9L,6L,3L,7L,3L,4L,4L,8L,3L,7L,9L,8L,5L,5L,7L,2L,6L,7L,0L,8L,6L,0L,5L,6L,7L,3L,3L,7L,6L,8L,9L,2L,4L,1L,5L,3L,8L,3L,5L,0L,3L,6L,4L,5L,3L,8L,1L,1L,8L,2L,7L,1L,6L,1L,4L,1L,3L,0L,2L,0L,5L,1L,3L,6L,6L,2L,2L,1L,7L,0L,0L,6L,7L,7L,0L,1L,3L,5L,4L,3L,0L,4L,4L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155079Inst : IEnumerable<long>
{
public static readonly long[] Value=A155079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155079.Bytes);
public long this[int i]=>Value[i];

public static A155079Inst Instance=new A155079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155080
{
public static readonly long[] Value={ 1L,0L,3L,9L,2L,5L,7L,7L,6L,9L,0L,4L,2L,9L,0L,1L,0L,8L,4L,7L,7L,7L,8L,0L,7L,4L,6L,7L,0L,8L,3L,6L,0L,1L,0L,3L,5L,0L,9L,9L,7L,2L,1L,1L,8L,1L,2L,2L,2L,6L,5L,5L,8L,2L,5L,0L,2L,1L,7L,6L,7L,1L,1L,7L,8L,9L,0L,7L,0L,4L,9L,3L,0L,4L,3L,2L,0L,7L,8L,1L,4L,0L,3L,7L,3L,5L,2L,5L,7L,7L,8L,4L,0L,8L,2L,6L,8L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155080Inst : IEnumerable<long>
{
public static readonly long[] Value=A155080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155080.Bytes);
public long this[int i]=>Value[i];

public static A155080Inst Instance=new A155080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155081
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,31L,37L,47L,53L,67L,71L,73L,101L,113L,137L,173L,227L,233L,241L,257L,271L,307L,331L,347L,367L,521L,523L,557L,571L,577L,607L,613L,673L,727L,733L,743L,751L,1277L,1307L,1361L,1367L,1451L,1453L,1471L,1511L,1523L,1553L,1567L,1571L,1627L,1657L,1663L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155081Inst : IEnumerable<long>
{
public static readonly long[] Value=A155081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155081.Bytes);
public long this[int i]=>Value[i];

public static A155081Inst Instance=new A155081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155082
{
public static readonly long[] Value={ 9L,14L,24L,27L,39L,42L,45L,58L,60L,64L,65L,74L,76L,95L,99L,102L,105L,114L,115L,119L,122L,141L,146L,152L,168L,172L,175L,176L,178L,182L,187L,194L,196L,201L,204L,217L,231L,234L,243L,244L,249L,261L,268L,273L,275L,278L,279L,280L,287L,291L,298L,300L,301L,304L,312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155082Inst : IEnumerable<long>
{
public static readonly long[] Value=A155082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155082.Bytes);
public long this[int i]=>Value[i];

public static A155082Inst Instance=new A155082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155083
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,1L,5L,9L,6L,1L,13L,29L,25L,10L,1L,35L,92L,100L,55L,15L,1L,96L,291L,377L,266L,105L,21L,1L,267L,915L,1375L,1169L,602L,182L,28L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155083Inst : IEnumerable<long>
{
public static readonly long[] Value=A155083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155083.Bytes);
public long this[int i]=>Value[i];

public static A155083Inst Instance=new A155083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155084
{
public static readonly long[] Value={ 1L,2L,8L,32L,132L,552L,2328L,9872L,42020L,179336L,766888L,3284272L,14081224L,60426576L,259490736L,1114965792L,4792924356L,20611174920L,88662405768L,381494338032L,1641837542232L,7067257125744L,30425523536592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155084Inst : IEnumerable<long>
{
public static readonly long[] Value=A155084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155084.Bytes);
public long this[int i]=>Value[i];

public static A155084Inst Instance=new A155084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155085
{
public static readonly long[] Value={ 2L,5L,7L,11L,11L,18L,15L,23L,22L,28L,23L,40L,27L,38L,39L,47L,35L,57L,39L,62L,53L,58L,47L,84L,56L,68L,67L,84L,59L,102L,63L,95L,81L,88L,83L,127L,75L,98L,95L,130L,83L,138L,87L,128L,123L,118L,95L,172L,106L,143L,123L,150L,107L,174L,127L,176L,137L,148L,119L,228L,123L,158L,167L,191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155085Inst : IEnumerable<long>
{
public static readonly long[] Value=A155085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155085.Bytes);
public long this[int i]=>Value[i];

public static A155085Inst Instance=new A155085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155086
{
public static readonly long[] Value={ 5L,8L,18L,21L,31L,34L,44L,47L,57L,60L,70L,73L,83L,86L,96L,99L,109L,112L,122L,125L,135L,138L,148L,151L,161L,164L,174L,177L,187L,190L,200L,203L,213L,216L,226L,229L,239L,242L,252L,255L,265L,268L,278L,281L,291L,294L,304L,307L,317L,320L,330L,333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155086Inst : IEnumerable<long>
{
public static readonly long[] Value=A155086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155086.Bytes);
public long this[int i]=>Value[i];

public static A155086Inst Instance=new A155086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155087
{
public static readonly long[] Value={ 37L,71L,103L,109L,151L,157L,163L,181L,233L,257L,263L,271L,281L,307L,397L,443L,457L,509L,599L,607L,653L,677L,691L,709L,719L,797L,821L,883L,907L,971L,1033L,1049L,1051L,1063L,1069L,1091L,1093L,1097L,1109L,1181L,1277L,1279L,1327L,1361L,1367L,1399L,1429L,1447L,1453L,1489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155087Inst : IEnumerable<long>
{
public static readonly long[] Value=A155087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155087.Bytes);
public long this[int i]=>Value[i];

public static A155087Inst Instance=new A155087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155088
{
public static readonly long[] Value={ 2L,3L,55L,332L,352L,375L,733L,3573L,3575L,7235L,22222L,22223L,22322L,252323L,252335L,253777L,255225L,372755L,372772L,522532L,523255L,525737L,2275325L,2275327L,2275337L,2277333L,2277337L,3325772L,27727257L,27727277L,27727732L,27737332L,27737722L,27737723L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155088Inst : IEnumerable<long>
{
public static readonly long[] Value=A155088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155088.Bytes);
public long this[int i]=>Value[i];

public static A155088Inst Instance=new A155088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155089
{
public static readonly long[] Value={ 17L,19L,29L,41L,43L,59L,79L,89L,97L,109L,127L,131L,139L,149L,157L,163L,167L,179L,191L,193L,197L,199L,211L,223L,229L,239L,251L,263L,269L,293L,317L,337L,349L,359L,373L,379L,389L,397L,401L,409L,419L,421L,433L,439L,443L,449L,457L,461L,463L,467L,479L,487L,491L,499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155089Inst : IEnumerable<long>
{
public static readonly long[] Value=A155089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155089.Bytes);
public long this[int i]=>Value[i];

public static A155089Inst Instance=new A155089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155090
{
public static readonly long[] Value={ 4L,8L,12L,15L,21L,26L,30L,33L,35L,38L,40L,44L,46L,49L,55L,58L,63L,66L,68L,70L,77L,81L,84L,86L,88L,90L,92L,94L,100L,102L,106L,108L,110L,112L,116L,118L,121L,123L,126L,129L,134L,136L,140L,142L,144L,146L,150L,154L,156L,158L,160L,162L,165L,169L,171L,176L,180L,183L,185L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155090Inst : IEnumerable<long>
{
public static readonly long[] Value=A155090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155090.Bytes);
public long this[int i]=>Value[i];

public static A155090Inst Instance=new A155090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155091
{
public static readonly long[] Value={ 1L,-1L,1L,0L,-1L,1L,0L,-1L,-1L,1L,0L,0L,-1L,-1L,1L,0L,0L,-1L,-1L,-1L,1L,0L,0L,0L,-1L,-1L,-1L,1L,0L,0L,0L,-1L,-1L,-1L,-1L,1L,0L,0L,0L,0L,-1L,-1L,-1L,-1L,1L,0L,0L,0L,0L,-1L,-1L,-1L,-1L,-1L,1L,0L,0L,0L,0L,0L,-1L,-1L,-1L,-1L,-1L,1L,0L,0L,0L,0L,0L,-1L,-1L,-1L,-1L,-1L,-1L,1L,0L,0L,0L,0L,0L,0L,-1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155091Inst : IEnumerable<long>
{
public static readonly long[] Value=A155091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155091.Bytes);
public long this[int i]=>Value[i];

public static A155091Inst Instance=new A155091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155092
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,3L,3L,2L,1L,1L,6L,6L,4L,2L,1L,1L,11L,11L,7L,4L,2L,1L,1L,22L,22L,14L,8L,4L,2L,1L,1L,42L,42L,27L,15L,8L,4L,2L,1L,1L,84L,84L,54L,30L,16L,8L,4L,2L,1L,1L,165L,165L,106L,59L,31L,16L,8L,4L,2L,1L,1L,330L,330L,212L,118L,62L,32L,16L,8L,4L,2L,1L,1L,654L,654L,420L,234L,123L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155092Inst : IEnumerable<long>
{
public static readonly long[] Value=A155092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155092.Bytes);
public long this[int i]=>Value[i];

public static A155092Inst Instance=new A155092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155093
{
public static readonly long[] Value={ 13L,23L,61L,83L,103L,107L,151L,181L,277L,281L,283L,311L,313L,353L,383L,431L,587L,601L,631L,643L,647L,653L,683L,701L,761L,787L,821L,823L,827L,857L,877L,881L,883L,1021L,1031L,1033L,1061L,1063L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155093Inst : IEnumerable<long>
{
public static readonly long[] Value=A155093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155093.Bytes);
public long this[int i]=>Value[i];

public static A155093Inst Instance=new A155093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155094
{
public static readonly long[] Value={ 1L,0L,1L,8L,7L,0L,5L,9L,7L,4L,8L,0L,1L,5L,3L,5L,5L,8L,4L,4L,9L,3L,6L,1L,8L,2L,3L,2L,0L,8L,0L,7L,2L,8L,9L,9L,9L,6L,1L,1L,8L,7L,1L,7L,3L,4L,5L,3L,5L,1L,6L,7L,8L,7L,9L,7L,2L,8L,1L,5L,3L,9L,2L,4L,0L,2L,7L,0L,7L,1L,8L,2L,8L,9L,4L,3L,3L,7L,2L,2L,4L,0L,3L,7L,5L,6L,6L,9L,6L,8L,4L,8L,1L,1L,3L,9L,5L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155094Inst : IEnumerable<long>
{
public static readonly long[] Value=A155094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155094.Bytes);
public long this[int i]=>Value[i];

public static A155094Inst Instance=new A155094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155095
{
public static readonly long[] Value={ 4L,13L,21L,30L,38L,47L,55L,64L,72L,81L,89L,98L,106L,115L,123L,132L,140L,149L,157L,166L,174L,183L,191L,200L,208L,217L,225L,234L,242L,251L,259L,268L,276L,285L,293L,302L,310L,319L,327L,336L,344L,353L,361L,370L,378L,387L,395L,404L,412L,421L,429L,438L,446L,455L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155095Inst : IEnumerable<long>
{
public static readonly long[] Value=A155095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155095.Bytes);
public long this[int i]=>Value[i];

public static A155095Inst Instance=new A155095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155096
{
public static readonly long[] Value={ 12L,17L,41L,46L,70L,75L,99L,104L,128L,133L,157L,162L,186L,191L,215L,220L,244L,249L,273L,278L,302L,307L,331L,336L,360L,365L,389L,394L,418L,423L,447L,452L,476L,481L,505L,510L,534L,539L,563L,568L,592L,597L,621L,626L,650L,655L,679L,684L,708L,713L,737L,742L,766L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155096Inst : IEnumerable<long>
{
public static readonly long[] Value=A155096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155096.Bytes);
public long this[int i]=>Value[i];

public static A155096Inst Instance=new A155096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155097
{
public static readonly long[] Value={ 6L,31L,43L,68L,80L,105L,117L,142L,154L,179L,191L,216L,228L,253L,265L,290L,302L,327L,339L,364L,376L,401L,413L,438L,450L,475L,487L,512L,524L,549L,561L,586L,598L,623L,635L,660L,672L,697L,709L,734L,746L,771L,783L,808L,820L,845L,857L,882L,894L,919L,931L,956L,968L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155097Inst : IEnumerable<long>
{
public static readonly long[] Value=A155097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155097.Bytes);
public long this[int i]=>Value[i];

public static A155097Inst Instance=new A155097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155098
{
public static readonly long[] Value={ 9L,32L,50L,73L,91L,114L,132L,155L,173L,196L,214L,237L,255L,278L,296L,319L,337L,360L,378L,401L,419L,442L,460L,483L,501L,524L,542L,565L,583L,606L,624L,647L,665L,688L,706L,729L,747L,770L,788L,811L,829L,852L,870L,893L,911L,934L,952L,975L,993L,1016L,1034L,1057L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155098Inst : IEnumerable<long>
{
public static readonly long[] Value=A155098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155098.Bytes);
public long this[int i]=>Value[i];

public static A155098Inst Instance=new A155098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155099
{
public static readonly long[] Value={ 1L,1L,2L,4L,7L,14L,27L,54L,106L,212L,420L,840L,1673L,3346L,6678L,13356L,26685L,53370L,106686L,213372L,426638L,853276L,1706340L,3412680L,6824940L,13649880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155099Inst : IEnumerable<long>
{
public static readonly long[] Value=A155099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155099.Bytes);
public long this[int i]=>Value[i];

public static A155099Inst Instance=new A155099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155100
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,0L,2L,0L,2L,2L,0L,8L,0L,6L,0L,16L,0L,40L,0L,24L,16L,0L,136L,0L,240L,0L,120L,0L,272L,0L,1232L,0L,1680L,0L,720L,272L,0L,3968L,0L,12096L,0L,13440L,0L,5040L,0L,7936L,0L,56320L,0L,129024L,0L,120960L,0L,40320L,7936L,0L,176896L,0L,814080L,0L,1491840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155100Inst : IEnumerable<long>
{
public static readonly long[] Value=A155100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155100.Bytes);
public long this[int i]=>Value[i];

public static A155100Inst Instance=new A155100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155101
{
public static readonly long[] Value={ 1L,4L,8L,9L,10L,12L,15L,20L,21L,24L,26L,28L,33L,34L,35L,38L,40L,42L,45L,46L,49L,50L,51L,55L,56L,58L,60L,63L,66L,68L,70L,72L,74L,75L,80L,81L,84L,88L,90L,92L,96L,98L,99L,100L,102L,104L,105L,106L,108L,110L,117L,118L,119L,121L,123L,124L,128L,129L,130L,133L,136L,140L,142L,143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155101Inst : IEnumerable<long>
{
public static readonly long[] Value=A155101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155101.Bytes);
public long this[int i]=>Value[i];

public static A155101Inst Instance=new A155101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155102
{
public static readonly long[] Value={ 1L,-2L,1L,0L,0L,1L,0L,-3L,0L,1L,0L,0L,0L,0L,1L,0L,0L,-4L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,-5L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,-6L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,-7L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,-8L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155102Inst : IEnumerable<long>
{
public static readonly long[] Value=A155102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155102.Bytes);
public long this[int i]=>Value[i];

public static A155102Inst Instance=new A155102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155103
{
public static readonly long[] Value={ 1L,2L,1L,0L,0L,1L,6L,3L,0L,1L,0L,0L,0L,0L,1L,0L,0L,4L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,30L,15L,0L,5L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,6L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,28L,0L,0L,7L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,8L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155103Inst : IEnumerable<long>
{
public static readonly long[] Value=A155103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155103.Bytes);
public long this[int i]=>Value[i];

public static A155103Inst Instance=new A155103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155104
{
public static readonly BigInteger[] Value={ 1L,5L,45L,765L,25245L,1640925L,211679325L,54401586525L,27908013887325L,28605714234508125L,BigInteger.Parse("58613108466507148125"),BigInteger.Parse("240137905387279785868125"),BigInteger.Parse("1967449858837983285617548125"),BigInteger.Parse("32236665937060356134843526028125") };
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
public class A155104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155104Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155104.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A155104.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155104Inst Instance=new A155104Inst();

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