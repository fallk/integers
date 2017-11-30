using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A133402
{
public static readonly BigInteger[] Value={ 1L,96L,405504L,77007421440L,661630022502580224L,BigInteger.Parse("257876005135691663309537280"),BigInteger.Parse("4565900567740737406606787243126292480"),BigInteger.Parse("3675506444195600567841408683430769715388692299776") };
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
public class A133402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133402Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A133402.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A133402.Bytes);
public BigInteger this[int i]=>Value[i];

public static A133402Inst Instance=new A133402Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133403
{
public static readonly long[] Value={ 12L,18L,41L,64L,53L,83L,94L,148L,106L,167L,147L,232L,159L,251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133403Inst : IEnumerable<long>
{
public static readonly long[] Value=A133403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133403.Bytes);
public long this[int i]=>Value[i];

public static A133403Inst Instance=new A133403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133404
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,1L,4L,3L,5L,2L,1L,5L,4L,3L,5L,7L,2L,1L,6L,5L,4L,7L,3L,8L,5L,7L,9L,2L,1L,7L,6L,5L,4L,7L,3L,8L,5L,7L,9L,11L,2L,1L,8L,7L,6L,5L,9L,4L,7L,10L,3L,11L,8L,5L,12L,7L,9L,11L,13L,2L,1L,9L,8L,7L,6L,5L,9L,4L,11L,7L,10L,3L,11L,8L,13L,5L,12L,7L,9L,11L,13L,15L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133404Inst : IEnumerable<long>
{
public static readonly long[] Value=A133404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133404.Bytes);
public long this[int i]=>Value[i];

public static A133404Inst Instance=new A133404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133405
{
public static readonly long[] Value={ 0L,0L,0L,1L,3L,9L,26L,78L,234L,703L,2109L,6327L,18980L,56940L,170820L,512461L,1537383L,4612149L,13836446L,41509338L,124528014L,373584043L,1120752129L,3362256387L,10086769160L,30260307480L,90780922440L,272342767321L,817028301963L,2451084905889L,7353254717666L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133405Inst : IEnumerable<long>
{
public static readonly long[] Value=A133405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133405.Bytes);
public long this[int i]=>Value[i];

public static A133405Inst Instance=new A133405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133406
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,4L,10L,9L,26L,24L,76L,69L,236L,214L,760L,696L,2522L,2326L,8556L,7942L,29504L,27562L,103130L,96862L,364548L,344004L,1300820L,1232567L,4679472L,4449850L,16952162L,16171118L,61790442L,59107890L,226451036L,217157069L,833918840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133406Inst : IEnumerable<long>
{
public static readonly long[] Value=A133406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133406.Bytes);
public long this[int i]=>Value[i];

public static A133406Inst Instance=new A133406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133407
{
public static readonly long[] Value={ 1L,2L,7L,17L,52L,137L,397L,1082L,3067L,8477L,23812L,66197L,185257L,516242L,1442527L,4023737L,11236372L,31355057L,87536917L,244312202L,681996787L,1903557797L,5313541732L,14831330717L,41399039377L,115555692962L,322550889847L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133407Inst : IEnumerable<long>
{
public static readonly long[] Value=A133407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133407.Bytes);
public long this[int i]=>Value[i];

public static A133407Inst Instance=new A133407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133408
{
public static readonly long[] Value={ 0L,1L,2L,4L,8L,16L,32L,41L,64L,128L,256L,512L,1024L,2048L,4096L,8192L,16384L,32768L,65536L,131072L,262144L,524288L,1048576L,2097152L,4194304L,8388608L,16777216L,33554432L,67108864L,134217728L,268435456L,536870912L,1073741824L,2147483648L,4294967296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133408Inst : IEnumerable<long>
{
public static readonly long[] Value=A133408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133408.Bytes);
public long this[int i]=>Value[i];

public static A133408Inst Instance=new A133408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133409
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,4L,13L,39L,117L,351L,1054L,3163L,9490L,28470L,85410L,256230L,768691L,2306074L,6918223L,20754669L,62264007L,186792021L,560376064L,1681128193L,5043384580L,15130153740L,45390461220L,136171383660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133409Inst : IEnumerable<long>
{
public static readonly long[] Value=A133409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133409.Bytes);
public long this[int i]=>Value[i];

public static A133409Inst Instance=new A133409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133410
{
public static readonly long[] Value={ 2L,11L,17L,23L,29L,37L,41L,47L,53L,59L,67L,71L,79L,83L,89L,97L,101L,107L,113L,127L,127L,131L,137L,149L,149L,157L,163L,167L,173L,179L,191L,191L,197L,211L,211L,223L,223L,227L,233L,239L,251L,251L,257L,263L,269L,277L,281L,293L,293L,307L,307L,311L,317L,331L,331L,337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133410Inst : IEnumerable<long>
{
public static readonly long[] Value=A133410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133410.Bytes);
public long this[int i]=>Value[i];

public static A133410Inst Instance=new A133410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133411
{
public static readonly long[] Value={ 1L,2L,4L,12L,24L,48L,240L,720L,5040L,10080L,20160L,221760L,665280L,8648640L,17297280L,294053760L,5587021440L,27935107200L,642507465600L,1927522396800L,13492656777600L,26985313555200L,782574093100800L,24259796886124800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133411Inst : IEnumerable<long>
{
public static readonly long[] Value=A133411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133411.Bytes);
public long this[int i]=>Value[i];

public static A133411Inst Instance=new A133411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133412
{
public static readonly long[] Value={ 5L,7L,0L,24L,0L,36L,0L,23L,0L,60L,0L,0L,37L,0L,84L,47L,0L,53L,0L,0L,120L,0L,67L,144L,0L,79L,83L,0L,0L,89L,0L,0L,0L,301L,216L,113L,0L,0L,0L,0L,0L,127L,131L,0L,276L,0L,0L,0L,0L,300L,157L,0L,0L,163L,167L,173L,0L,360L,0L,0L,384L,396L,0L,0L,0L,0L,0L,211L,0L,0L,0L,0L,0L,0L,223L,689L,0L,480L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133412Inst : IEnumerable<long>
{
public static readonly long[] Value=A133412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133412.Bytes);
public long this[int i]=>Value[i];

public static A133412Inst Instance=new A133412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133413
{
public static readonly BigInteger[] Value={ 1L,2L,24L,492L,202064L,100202536L,888531141152L,8548846756027594L,BigInteger.Parse("1400822035743239844640"),BigInteger.Parse("241149984205773848119833656"),BigInteger.Parse("691305758149247080625180837349904") };
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
public class A133413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133413Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A133413.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A133413.Bytes);
public BigInteger this[int i]=>Value[i];

public static A133413Inst Instance=new A133413Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133414
{
public static readonly BigInteger[] Value={ 1L,9L,403840L,3134895604437030L,BigInteger.Parse("2672411782638277673724960927991328") };
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
public class A133414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133414Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A133414.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A133414.Bytes);
public BigInteger this[int i]=>Value[i];

public static A133414Inst Instance=new A133414Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133415
{
public static readonly BigInteger[] Value={ 0L,0L,12L,560L,15504L,346104L,6906900L,129024512L,2310796740L,40226003064L,686392118544L,11543525003120L,192052217662812L,3169185696976320L,51968632068982524L,848016349271816384L,13784507849163060240UL,BigInteger.Parse("223382961205435729512"),BigInteger.Parse("3611184426083530971300"),BigInteger.Parse("58264040214444951056384") };
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
public class A133415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133415Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A133415.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A133415.Bytes);
public BigInteger this[int i]=>Value[i];

public static A133415Inst Instance=new A133415Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133448
{
public static readonly long[] Value={ 2L,5L,13L,40L,121L,365L,1094L,3281L,9841L,29524L,88573L,265721L,797162L,2391485L,7174453L,21523360L,64570081L,193710245L,581130734L,1743392201L,5230176601L,15690529804L,47071589413L,141214768241L,423644304722L,1270932914165L,3812798742493L,11438396227480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133448Inst : IEnumerable<long>
{
public static readonly long[] Value=A133448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133448.Bytes);
public long this[int i]=>Value[i];

public static A133448Inst Instance=new A133448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133449
{
public static readonly long[] Value={ 9561L,924591L,10306101L,40379541L,45964621L,13860931L,97601931L,206197461L,39350401L,70495851L,736139881L,120414601L,614399751L,422650131L,862677661L,5344474491L,1622536021L,502698841L,3425985241L,806838691L,4484608141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133449Inst : IEnumerable<long>
{
public static readonly long[] Value=A133449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133449.Bytes);
public long this[int i]=>Value[i];

public static A133449Inst Instance=new A133449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133450
{
public static readonly long[] Value={ 0L,1L,2L,0L,1L,0L,1L,2L,0L,1L,1L,2L,1L,4L,3L,-2L,-2L,2L,1L,1L,-4L,-5L,-5L,1L,10L,1L,3L,7L,-2L,0L,4L,0L,3L,-5L,4L,0L,2L,12L,0L,-9L,-2L,6L,-6L,-3L,3L,0L,2L,1L,-3L,10L,-9L,1L,10L,-3L,1L,0L,4L,2L,-2L,5L,1L,1L,8L,-12L,5L,-1L,8L,-2L,0L,0L,-3L,-1L,1L,2L,8L,-4L,12L,3L,4L,5L,1L,-2L,-10L,0L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133450Inst : IEnumerable<long>
{
public static readonly long[] Value=A133450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133450.Bytes);
public long this[int i]=>Value[i];

public static A133450Inst Instance=new A133450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133451
{
public static readonly long[] Value={ 6L,9L,11L,1L,4L,9L,12L,2L,4L,17L,11L,2L,4L,6L,9L,1L,4L,6L,8L,11L,4L,7L,9L,11L,2L,6L,9L,11L,1L,4L,9L,12L,2L,4L,17L,11L,2L,4L,6L,9L,1L,4L,6L,8L,11L,4L,7L,9L,11L,2L,6L,9L,11L,1L,4L,9L,12L,2L,4L,17L,11L,2L,4L,6L,9L,1L,4L,6L,8L,11L,4L,7L,9L,11L,2L,6L,9L,11L,1L,4L,9L,12L,2L,4L,17L,11L,2L,4L,6L,9L,1L,4L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133451Inst : IEnumerable<long>
{
public static readonly long[] Value=A133451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133451.Bytes);
public long this[int i]=>Value[i];

public static A133451Inst Instance=new A133451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133452
{
public static readonly long[] Value={ 3L,5L,7L,10L,1L,3L,10L,12L,1L,3L,10L,12L,1L,5L,7L,12L,3L,5L,7L,10L,1L,5L,7L,10L,1L,5L,7L,12L,3L,5L,7L,10L,3L,5L,7L,10L,1L,5L,7L,10L,1L,5L,7L,12L,3L,5L,7L,10L,3L,5L,7L,10L,1L,3L,10L,12L,1L,3L,10L,12L,3L,5L,7L,10L,4L,6L,8L,11L,2L,4L,9L,11L,2L,4L,9L,11L,4L,6L,8L,11L,4L,6L,8L,11L,2L,6L,8L,9L,4L,6L,8L,11L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133452Inst : IEnumerable<long>
{
public static readonly long[] Value=A133452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133452.Bytes);
public long this[int i]=>Value[i];

public static A133452Inst Instance=new A133452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133453
{
public static readonly long[] Value={ 2L,4L,13L,40L,122L,365L,1094L,3280L,9841L,29524L,88574L,265721L,797162L,2391484L,7174453L,21523360L,64570082L,193710245L,581130734L,1743392200L,5230176601L,15690529804L,47071589414L,141214768241L,423644304722L,1270932914164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133453Inst : IEnumerable<long>
{
public static readonly long[] Value=A133453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133453.Bytes);
public long this[int i]=>Value[i];

public static A133453Inst Instance=new A133453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133454
{
public static readonly long[] Value={ 4L,6L,12L,60L,5040L,293318625600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133454Inst : IEnumerable<long>
{
public static readonly long[] Value=A133454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133454.Bytes);
public long this[int i]=>Value[i];

public static A133454Inst Instance=new A133454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133455
{
public static readonly long[] Value={ 4L,2L,1L,5L,16L,35L,67L,128L,253L,509L,1024L,2051L,4099L,8192L,16381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133455Inst : IEnumerable<long>
{
public static readonly long[] Value=A133455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133455.Bytes);
public long this[int i]=>Value[i];

public static A133455Inst Instance=new A133455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133456
{
public static readonly long[] Value={ 3L,3L,-5L,0L,3L,-1L,-3L,0L,7L,-3L,-3L,5L,0L,-3L,1L,3L,0L,-7L,3L,3L,-5L,0L,3L,-1L,-3L,0L,7L,-3L,-3L,5L,0L,-3L,1L,3L,0L,-7L,3L,3L,-5L,0L,3L,-1L,-3L,0L,7L,-3L,-3L,5L,0L,-3L,1L,3L,0L,-7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133456Inst : IEnumerable<long>
{
public static readonly long[] Value=A133456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133456.Bytes);
public long this[int i]=>Value[i];

public static A133456Inst Instance=new A133456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133457
{
public static readonly long[] Value={ 0L,1L,0L,1L,2L,0L,2L,1L,2L,0L,1L,2L,3L,0L,3L,1L,3L,0L,1L,3L,2L,3L,0L,2L,3L,1L,2L,3L,0L,1L,2L,3L,4L,0L,4L,1L,4L,0L,1L,4L,2L,4L,0L,2L,4L,1L,2L,4L,0L,1L,2L,4L,3L,4L,0L,3L,4L,1L,3L,4L,0L,1L,3L,4L,2L,3L,4L,0L,2L,3L,4L,1L,2L,3L,4L,0L,1L,2L,3L,4L,5L,0L,5L,1L,5L,0L,1L,5L,2L,5L,0L,2L,5L,1L,2L,5L,0L,1L,2L,5L,3L,5L,0L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133457Inst : IEnumerable<long>
{
public static readonly long[] Value=A133457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133457.Bytes);
public long this[int i]=>Value[i];

public static A133457Inst Instance=new A133457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133458
{
public static readonly long[] Value={ 1L,35L,393L,2128L,8135L,24017L,60691L,134512L,273127L,512365L,908755L,1528688L,2473325L,3852919L,5832765L,8582336L,12354469L,17395119L,24072133L,32726960L,43874139L,57971221L,75715487L,97702640L,124853275L,157924585L,198105727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133458Inst : IEnumerable<long>
{
public static readonly long[] Value=A133458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133458.Bytes);
public long this[int i]=>Value[i];

public static A133458Inst Instance=new A133458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133459
{
public static readonly long[] Value={ 2L,7L,12L,19L,24L,36L,41L,46L,58L,76L,80L,81L,93L,115L,127L,132L,144L,150L,166L,197L,201L,202L,214L,236L,252L,271L,289L,294L,306L,322L,328L,363L,392L,406L,411L,414L,423L,445L,480L,484L,531L,551L,556L,568L,576L,590L,601L,625L,676L,693L,727L,732L,744L,746L,766L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133459Inst : IEnumerable<long>
{
public static readonly long[] Value=A133459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133459.Bytes);
public long this[int i]=>Value[i];

public static A133459Inst Instance=new A133459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133460
{
public static readonly BigInteger[] Value={ 1L,6L,144L,13824L,5308416L,8153726976L,50096498540544L,1231171548132409344L,BigInteger.Parse("121029087867608368152576"),BigInteger.Parse("47590573814949492091483324416"),BigInteger.Parse("74853500292876717928978827574247424") };
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
public class A133460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133460Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A133460.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A133460.Bytes);
public BigInteger this[int i]=>Value[i];

public static A133460Inst Instance=new A133460Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133461
{
public static readonly BigInteger[] Value={ 1L,12L,1296L,1259712L,11019960576L,867623536069632L,BigInteger.Parse("614787626176508399616"),BigInteger.Parse("3920680210114437604803919872"),BigInteger.Parse("225029902846690098194536797915119616"),BigInteger.Parse("116241593333982893165313951169026429498949632") };
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
public class A133461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133461Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A133461.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A133461.Bytes);
public BigInteger this[int i]=>Value[i];

public static A133461Inst Instance=new A133461Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133462
{
public static readonly long[] Value={ 1L,1L,4L,37L,370L,3703L,37036L,370369L,3703702L,37037035L,370370368L,3703703701L,37037037034L,370370370367L,3703703703700L,37037037037033L,370370370370366L,3703703703703699L,37037037037037032L,370370370370370365L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133462Inst : IEnumerable<long>
{
public static readonly long[] Value=A133462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133462.Bytes);
public long this[int i]=>Value[i];

public static A133462Inst Instance=new A133462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133463
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,9L,12L,15L,18L,27L,36L,45L,54L,81L,108L,135L,162L,243L,324L,405L,486L,729L,972L,1215L,1458L,2187L,2916L,3645L,4374L,6561L,8748L,10935L,13122L,19683L,26244L,32805L,39366L,59049L,78732L,98415L,118098L,177147L,236196L,295245L,354294L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133463Inst : IEnumerable<long>
{
public static readonly long[] Value=A133463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133463.Bytes);
public long this[int i]=>Value[i];

public static A133463Inst Instance=new A133463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133528
{
public static readonly long[] Value={ 134067L,1905564L,6731644L,30853588L,77781820L,224046148L,814042660L,1677408772L,4196089300L,8798157652L,14524697380L,24416409028L,44015043748L,81445473148L,126644484460L,206323651300L,312259574092L,421413266740L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133528Inst : IEnumerable<long>
{
public static readonly long[] Value=A133528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133528.Bytes);
public long this[int i]=>Value[i];

public static A133528Inst Instance=new A133528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133529
{
public static readonly long[] Value={ 38L,83L,195L,339L,579L,819L,1179L,1731L,2331L,3171L,4011L,4899L,5739L,6867L,8499L,10011L,11691L,13251L,14859L,16611L,18459L,21051L,24219L,27531L,30219L,32259L,33939L,36099L,40779L,46059L,52059L,55251L,60291L,64323L,69651L,74019L,79107L,84387L,89859L,94731L,101283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133529Inst : IEnumerable<long>
{
public static readonly long[] Value=A133529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133529.Bytes);
public long this[int i]=>Value[i];

public static A133529Inst Instance=new A133529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133530
{
public static readonly long[] Value={ 160L,495L,1799L,3871L,8441L,13969L,23939L,43415L,66347L,104833L,149365L,199081L,252251L,332207L,458079L,581237L,733123L,885655L,1047691L,1239967L,1453843L,1769795L,2189429L,2647943L,3035701L,3348071L,3612799L,3962969L,4786309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133530Inst : IEnumerable<long>
{
public static readonly long[] Value=A133530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133530.Bytes);
public long this[int i]=>Value[i];

public static A133530Inst Instance=new A133530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133531
{
public static readonly long[] Value={ 722L,3107L,17667L,45603L,126723L,242403L,493683L,1117443L,1910643L,3504963L,5623443L,8118723L,11124243L,16188963L,24887523L,33853683L,46114323L,59408643L,73961043L,92760003L,114806643L,149150643L,198729843L,255331923L,305140563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133531Inst : IEnumerable<long>
{
public static readonly long[] Value=A133531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133531.Bytes);
public long this[int i]=>Value[i];

public static A133531Inst Instance=new A133531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133532
{
public static readonly long[] Value={ 3400L,20175L,180983L,549151L,1952201L,4267249L,10332299L,29423591L,55576643L,118484257L,213829309L,332208601L,492209651L,794548943L,1362464799L,1977716093L,2909645707L,3998950759L,5227426051L,6954357343L,9089168635L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133532Inst : IEnumerable<long>
{
public static readonly long[] Value=A133532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133532.Bytes);
public long this[int i]=>Value[i];

public static A133532Inst Instance=new A133532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133533
{
public static readonly long[] Value={ 16418L,134003L,1904835L,6716019L,30735939L,76010259L,219219339L,789905091L,1630362891L,4048053411L,8203334331L,13637193699L,21850682619L,39264939507L,75124110099L,115865269131L,184159290171L,270079040451L,369892892379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133533Inst : IEnumerable<long>
{
public static readonly long[] Value=A133533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133533.Bytes);
public long this[int i]=>Value[i];

public static A133533Inst Instance=new A133533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133534
{
public static readonly long[] Value={ 35L,152L,468L,1674L,3528L,7110L,11772L,19026L,36556L,54180L,80444L,119574L,148428L,183330L,252700L,354256L,432360L,527744L,658674L,746928L,882056L,1064826L,1276756L,1617642L,1942974L,2123028L,2317770L,2520072L,2737926L,3491280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133534Inst : IEnumerable<long>
{
public static readonly long[] Value=A133534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133534.Bytes);
public long this[int i]=>Value[i];

public static A133534Inst Instance=new A133534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133535
{
public static readonly long[] Value={ 97L,706L,3026L,17042L,43202L,112082L,213842L,410162L,987122L,1630802L,2797682L,4699922L,6244562L,8298482L,12770162L,20007842L,25963202L,33996962L,45562802L,53809922L,67348322L,86408402L,110200562L,151271522L,192589682L,216611282L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133535Inst : IEnumerable<long>
{
public static readonly long[] Value=A133535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133535.Bytes);
public long this[int i]=>Value[i];

public static A133535Inst Instance=new A133535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133536
{
public static readonly long[] Value={ 275L,3368L,19932L,177858L,532344L,1791150L,3895956L,8912442L,26947492L,49140300L,97973108L,185200158L,262864644L,376353450L,647540500L,1133119792L,1559520600L,2194721408L,3154354458L,3877300944L,5150127992L,7016097042L,9523100092L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133536Inst : IEnumerable<long>
{
public static readonly long[] Value=A133536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133536.Bytes);
public long this[int i]=>Value[i];

public static A133536Inst Instance=new A133536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133537
{
public static readonly long[] Value={ 793L,16354L,133274L,1889210L,6598370L,28964378L,71183450L,195081770L,742859210L,1482327002L,3453230090L,7315830650L,11071467290L,17100578378L,32943576458L,64344894770L,93700908002L,141978756530L,218558666090L,279434510210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133537Inst : IEnumerable<long>
{
public static readonly long[] Value=A133537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133537.Bytes);
public long this[int i]=>Value[i];

public static A133537Inst Instance=new A133537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133538
{
public static readonly long[] Value={ 2315L,80312L,901668L,20310714L,82235688L,473087190L,1304210412L,4298697186L,20654701756L,44762490420L,122444491244L,289686151014L,466572884988L,778441731570L,1681334260300L,3663362624656L,5631394320840L,9203454441344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133538Inst : IEnumerable<long>
{
public static readonly long[] Value=A133538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133538.Bytes);
public long this[int i]=>Value[i];

public static A133538Inst Instance=new A133538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133539
{
public static readonly long[] Value={ 1834L,4023L,8909L,15643L,27467L,50525L,78119L,123859L,185921L,253261L,332695L,451781L,606507L,764567L,985823L,1239911L,1480051L,1767711L,2112517L,2516723L,3071485L,3712769L,4312457L,4965713L,5555773L,6085997L,7104079L,8259443L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133539Inst : IEnumerable<long>
{
public static readonly long[] Value=A133539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133539.Bytes);
public long this[int i]=>Value[i];

public static A133539Inst Instance=new A133539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133540
{
public static readonly long[] Value={ 17764L,46309L,129749L,259445L,536885L,1229525L,2124485L,3915125L,6610565L,9749525L,13921925L,20888885L,31132085L,42152165L,58884485L,79416485L,99924245L,126756965L,160369445L,202960565L,266078165L,341740325L,415341125L,498962405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133540Inst : IEnumerable<long>
{
public static readonly long[] Value=A133540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133540.Bytes);
public long this[int i]=>Value[i];

public static A133540Inst Instance=new A133540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133541
{
public static readonly long[] Value={ 181258L,552519L,1972133L,4445107L,10864643L,31214741L,59472599L,127396699L,240776801L,381348901L,590182759L,979749101L,1625329443L,2354069543L,3557186207L,5132070551L,6786946651L,9149078751L,12243523093L,16477457435L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133541Inst : IEnumerable<long>
{
public static readonly long[] Value=A133541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133541.Bytes);
public long this[int i]=>Value[i];

public static A133541Inst Instance=new A133541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133542
{
public static readonly long[] Value={ 1905628L,6732373L,30869213L,77899469L,225817709L,818869469L,1701546341L,4243135181L,8946193541L,15119520701L,25303912709L,46580770157L,86195577389L,132965847509L,217102866629L,334423935221L,463593800381L,664500722261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133542Inst : IEnumerable<long>
{
public static readonly long[] Value=A133542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133542.Bytes);
public long this[int i]=>Value[i];

public static A133542Inst Instance=new A133542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133543
{
public static readonly long[] Value={ 20391154L,83139543L,493476029L,1387269643L,4791271547L,22021660685L,49471526279L,143993064739L,337853466881L,606267252541L,1095640496695L,2242839022421L,4636558630107L,7584547192247L,13373440186463L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133543Inst : IEnumerable<long>
{
public static readonly long[] Value=A133543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133543.Bytes);
public long this[int i]=>Value[i];

public static A133543Inst Instance=new A133543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133624
{
public static readonly long[] Value={ 0L,1L,2L,2L,1L,0L,1L,7L,4L,1L,1L,8L,1L,8L,6L,13L,1L,7L,1L,6L,8L,12L,1L,3L,1L,1L,10L,8L,1L,26L,1L,25L,12L,1L,1L,22L,1L,20L,14L,31L,1L,15L,1L,12L,16L,24L,1L,5L,1L,1L,18L,14L,1L,46L,1L,43L,20L,1L,1L,36L,1L,32L,22L,49L,1L,23L,1L,18L,24L,36L,1L,7L,1L,1L,26L,20L,1L,66L,1L,61L,28L,1L,1L,50L,1L,44L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133624Inst : IEnumerable<long>
{
public static readonly long[] Value=A133624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133624.Bytes);
public long this[int i]=>Value[i];

public static A133624Inst Instance=new A133624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133625
{
public static readonly long[] Value={ 0L,1L,2L,2L,2L,0L,1L,7L,4L,3L,1L,8L,1L,8L,9L,13L,1L,7L,1L,10L,8L,12L,1L,3L,6L,1L,10L,8L,1L,2L,1L,25L,12L,1L,8L,22L,1L,20L,14L,39L,1L,15L,1L,12L,25L,24L,1L,5L,1L,11L,18L,14L,1L,46L,12L,43L,20L,1L,1L,48L,1L,32L,22L,49L,14L,23L,1L,18L,24L,50L,1L,7L,1L,1L,41L,20L,1L,66L,1L,77L,28L,1L,1L,50L,18L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133625Inst : IEnumerable<long>
{
public static readonly long[] Value=A133625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133625.Bytes);
public long this[int i]=>Value[i];

public static A133625Inst Instance=new A133625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133626
{
public static readonly long[] Value={ 119L,129L,139L,149L,159L,169L,179L,189L,190L,191L,192L,193L,194L,195L,196L,197L,198L,199L,229L,239L,249L,259L,269L,279L,289L,290L,291L,292L,293L,294L,295L,296L,297L,298L,299L,339L,349L,359L,369L,379L,389L,390L,391L,392L,393L,394L,395L,396L,397L,398L,399L,449L,459L,469L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133626Inst : IEnumerable<long>
{
public static readonly long[] Value=A133626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133626.Bytes);
public long this[int i]=>Value[i];

public static A133626Inst Instance=new A133626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133627
{
public static readonly long[] Value={ 9L,9L,1L,3L,3L,2L,3L,3L,0L,8L,1L,0L,1L,0L,4L,6L,3L,2L,3L,5L,7L,8L,7L,0L,6L,7L,4L,3L,1L,9L,1L,4L,3L,1L,3L,7L,6L,7L,4L,5L,9L,1L,2L,9L,7L,4L,8L,9L,3L,4L,1L,3L,5L,6L,7L,0L,2L,1L,0L,5L,8L,2L,0L,7L,0L,3L,1L,1L,9L,4L,4L,5L,9L,2L,4L,7L,5L,3L,4L,4L,6L,7L,6L,7L,3L,1L,0L,5L,3L,7L,9L,0L,2L,1L,8L,0L,8L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133627Inst : IEnumerable<long>
{
public static readonly long[] Value=A133627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133627.Bytes);
public long this[int i]=>Value[i];

public static A133627Inst Instance=new A133627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133628
{
public static readonly long[] Value={ 1L,4L,8L,20L,36L,84L,148L,340L,596L,1364L,2388L,5460L,9556L,21844L,38228L,87380L,152916L,349524L,611668L,1398100L,2446676L,5592404L,9786708L,22369620L,39146836L,89478484L,156587348L,357913940L,626349396L,1431655764L,2505397588L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133628Inst : IEnumerable<long>
{
public static readonly long[] Value=A133628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133628.Bytes);
public long this[int i]=>Value[i];

public static A133628Inst Instance=new A133628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133629
{
public static readonly long[] Value={ 1L,5L,10L,30L,55L,155L,280L,780L,1405L,3905L,7030L,19530L,35155L,97655L,175780L,488280L,878905L,2441405L,4394530L,12207030L,21972655L,61035155L,109863280L,305175780L,549316405L,1525878905L,2746582030L,7629394530L,13732910155L,38146972655L,68664550780L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133629Inst : IEnumerable<long>
{
public static readonly long[] Value=A133629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133629.Bytes);
public long this[int i]=>Value[i];

public static A133629Inst Instance=new A133629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133630
{
public static readonly long[] Value={ 4L,33L,57L,68L,85L,87L,111L,121L,141L,143L,164L,169L,185L,187L,209L,219L,221L,235L,247L,249L,253L,260L,289L,292L,299L,303L,319L,323L,327L,335L,341L,356L,361L,377L,381L,388L,391L,403L,407L,411L,435L,437L,451L,452L,473L,481L,484L,485L,489L,493L,516L,517L,519L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133630Inst : IEnumerable<long>
{
public static readonly long[] Value=A133630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133630.Bytes);
public long this[int i]=>Value[i];

public static A133630Inst Instance=new A133630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133631
{
public static readonly long[] Value={ 1L,2L,-2L,-10L,-2L,38L,46L,-106L,-290L,134L,1294L,758L,-4418L,-7450L,10222L,40022L,-866L,-160954L,-157490L,486326L,1116286L,-829018L,-5294162L,-1978090L,19198558L,27110918L,-49683314L,-158126986L,40606270L,673114214L,510689134L,-2181767722L,-4224524258L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133631Inst : IEnumerable<long>
{
public static readonly long[] Value=A133631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133631.Bytes);
public long this[int i]=>Value[i];

public static A133631Inst Instance=new A133631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133632
{
public static readonly long[] Value={ 1L,4L,5L,20L,25L,100L,125L,500L,625L,2500L,3125L,12500L,15625L,62500L,78125L,312500L,390625L,1562500L,1953125L,7812500L,9765625L,39062500L,48828125L,195312500L,244140625L,976562500L,1220703125L,4882812500L,6103515625L,24414062500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133632Inst : IEnumerable<long>
{
public static readonly long[] Value=A133632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133632.Bytes);
public long this[int i]=>Value[i];

public static A133632Inst Instance=new A133632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133633
{
public static readonly long[] Value={ 25L,35L,49L,55L,65L,77L,85L,91L,95L,115L,119L,121L,125L,133L,143L,145L,155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133633Inst : IEnumerable<long>
{
public static readonly long[] Value=A133633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133633.Bytes);
public long this[int i]=>Value[i];

public static A133633Inst Instance=new A133633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133634
{
public static readonly long[] Value={ 10L,25L,26L,34L,35L,49L,50L,55L,58L,65L,74L,77L,82L,85L,91L,95L,98L,106L,115L,119L,121L,122L,125L,130L,133L,143L,145L,146L,154L,155L,161L,169L,170L,175L,178L,185L,187L,194L,202L,203L,205L,209L,215L,217L,218L,221L,226L,235L,242L,245L,247L,250L,253L,259L,265L,266L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133634Inst : IEnumerable<long>
{
public static readonly long[] Value=A133634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133634.Bytes);
public long this[int i]=>Value[i];

public static A133634Inst Instance=new A133634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133635
{
public static readonly long[] Value={ 26L,34L,49L,58L,74L,77L,82L,91L,98L,106L,119L,121L,122L,133L,143L,146L,154L,161L,169L,178L,187L,194L,202L,203L,209L,217L,218L,221L,226L,242L,247L,253L,259L,266L,274L,287L,289L,298L,299L,301L,314L,319L,322L,323L,329L,338L,341L,343L,346L,361L,362L,371L,377L,386L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133635Inst : IEnumerable<long>
{
public static readonly long[] Value=A133635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133635.Bytes);
public long this[int i]=>Value[i];

public static A133635Inst Instance=new A133635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133636
{
public static readonly long[] Value={ 9L,27L,49L,63L,77L,81L,91L,99L,117L,119L,121L,133L,143L,153L,161L,169L,171L,187L,189L,203L,207L,209L,217L,221L,243L,247L,253L,259L,261L,279L,287L,289L,297L,299L,301L,319L,323L,329L,333L,341L,343L,351L,361L,369L,371L,377L,387L,391L,403L,407L,413L,423L,427L,437L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133636Inst : IEnumerable<long>
{
public static readonly long[] Value=A133636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133636.Bytes);
public long this[int i]=>Value[i];

public static A133636Inst Instance=new A133636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133637
{
public static readonly long[] Value={ 1L,-1L,0L,2L,-3L,0L,4L,-6L,0L,10L,-12L,0L,20L,-24L,0L,36L,-45L,0L,64L,-78L,0L,112L,-132L,0L,189L,-222L,0L,308L,-363L,0L,492L,-576L,0L,778L,-900L,0L,1210L,-1392L,0L,1844L,-2121L,0L,2776L,-3180L,0L,4144L,-4716L,0L,6114L,-6936L,0L,8914L,-10098L,0L,12884L,-14550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133637Inst : IEnumerable<long>
{
public static readonly long[] Value=A133637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133637.Bytes);
public long this[int i]=>Value[i];

public static A133637Inst Instance=new A133637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133638
{
public static readonly long[] Value={ 1L,2L,4L,7L,14L,19L,26L,31L,38L,51L,58L,69L,80L,85L,92L,105L,120L,127L,138L,149L,154L,165L,176L,189L,208L,221L,226L,233L,238L,245L,274L,293L,306L,313L,332L,343L,354L,369L,380L,393L,408L,415L,434L,445L,452L,457L,480L,513L,530L,535L,542L,555L,562L,581L,600L,615L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133638Inst : IEnumerable<long>
{
public static readonly long[] Value=A133638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133638.Bytes);
public long this[int i]=>Value[i];

public static A133638Inst Instance=new A133638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133639
{
public static readonly long[] Value={ 1L,-1L,-1L,0L,-1L,1L,-1L,0L,0L,1L,-1L,0L,-1L,1L,1L,0L,-1L,0L,-1L,0L,1L,1L,-1L,0L,1L,1L,0L,0L,-1L,-1L,-1L,0L,1L,1L,1L,0L,-1L,1L,1L,0L,-1L,-1L,-1L,0L,0L,1L,-1L,0L,1L,-1L,1L,0L,-1L,0L,1L,0L,1L,1L,-1L,0L,-1L,1L,0L,0L,1L,-1L,-1L,0L,1L,-1L,-1L,0L,-1L,1L,-1L,0L,1L,-1L,-1L,0L,0L,1L,-1L,0L,1L,1L,1L,0L,-1L,0L,1L,0L,1L,1L,1L,0L,-1L,-1L,0L,0L,-1L,-1L,-1L,0L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133639Inst : IEnumerable<long>
{
public static readonly long[] Value=A133639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133639.Bytes);
public long this[int i]=>Value[i];

public static A133639Inst Instance=new A133639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133688
{
public static readonly long[] Value={ 5391411025L,5775L,1575L,945L,81081L,78975L,1468935L,6375105L,436444281L,5356826865L,21873816315L,371922783705L,2241870572475L,158639164165575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133688Inst : IEnumerable<long>
{
public static readonly long[] Value=A133688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133688.Bytes);
public long this[int i]=>Value[i];

public static A133688Inst Instance=new A133688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133689
{
public static readonly long[] Value={ 3L,4L,6L,6L,12L,8L,12L,12L,20L,12L,24L,14L,28L,30L,24L,18L,36L,20L,40L,42L,44L,24L,48L,30L,52L,36L,56L,30L,60L,32L,48L,66L,68L,70L,72L,38L,76L,78L,80L,42L,84L,44L,88L,90L,92L,48L,96L,56L,100L,102L,104L,54L,108L,110L,112L,114L,116L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133689Inst : IEnumerable<long>
{
public static readonly long[] Value=A133689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133689.Bytes);
public long this[int i]=>Value[i];

public static A133689Inst Instance=new A133689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133690
{
public static readonly long[] Value={ 1L,-4L,8L,-16L,24L,-24L,32L,-32L,24L,-52L,48L,-48L,96L,-56L,64L,-96L,24L,-72L,104L,-80L,144L,-128L,96L,-96L,96L,-124L,112L,-160L,192L,-120L,192L,-128L,24L,-192L,144L,-192L,312L,-152L,160L,-224L,144L,-168L,256L,-176L,288L,-312L,192L,-192L,96L,-228L,248L,-288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133690Inst : IEnumerable<long>
{
public static readonly long[] Value=A133690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133690.Bytes);
public long this[int i]=>Value[i];

public static A133690Inst Instance=new A133690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133691
{
public static readonly long[] Value={ 1L,-2L,4L,-6L,6L,-8L,8L,-6L,13L,-12L,12L,-24L,14L,-16L,24L,-6L,18L,-26L,20L,-36L,32L,-24L,24L,-24L,31L,-28L,40L,-48L,30L,-48L,32L,-6L,48L,-36L,48L,-78L,38L,-40L,56L,-36L,42L,-64L,44L,-72L,78L,-48L,48L,-24L,57L,-62L,72L,-84L,54L,-80L,72L,-48L,80L,-60L,60L,-144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133691Inst : IEnumerable<long>
{
public static readonly long[] Value=A133691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133691.Bytes);
public long this[int i]=>Value[i];

public static A133691Inst Instance=new A133691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133692
{
public static readonly long[] Value={ 1L,-2L,2L,-4L,2L,0L,4L,0L,2L,-6L,0L,-4L,4L,0L,0L,0L,2L,-4L,6L,-4L,0L,0L,4L,0L,4L,-2L,0L,-8L,0L,0L,0L,0L,2L,-8L,4L,0L,6L,0L,4L,0L,0L,-4L,0L,-4L,4L,0L,0L,0L,4L,-2L,2L,-8L,0L,0L,8L,0L,0L,-8L,0L,-4L,0L,0L,0L,0L,2L,0L,8L,-4L,4L,0L,0L,0L,6L,-4L,0L,-4L,4L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133692Inst : IEnumerable<long>
{
public static readonly long[] Value=A133692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133692.Bytes);
public long this[int i]=>Value[i];

public static A133692Inst Instance=new A133692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133693
{
public static readonly long[] Value={ 1L,-1L,2L,-1L,0L,-2L,0L,-1L,3L,0L,2L,-2L,0L,0L,0L,-1L,2L,-3L,2L,0L,0L,-2L,0L,-2L,1L,0L,4L,0L,0L,0L,0L,-1L,4L,-2L,0L,-3L,0L,-2L,0L,0L,2L,0L,2L,-2L,0L,0L,0L,-2L,1L,-1L,4L,0L,0L,-4L,0L,0L,4L,0L,2L,0L,0L,0L,0L,-1L,0L,-4L,2L,-2L,0L,0L,0L,-3L,2L,0L,2L,-2L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133693Inst : IEnumerable<long>
{
public static readonly long[] Value=A133693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133693.Bytes);
public long this[int i]=>Value[i];

public static A133693Inst Instance=new A133693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133694
{
public static readonly long[] Value={ 1L,7L,16L,28L,43L,61L,82L,106L,133L,163L,196L,232L,271L,313L,358L,406L,457L,511L,568L,628L,691L,757L,826L,898L,973L,1051L,1132L,1216L,1303L,1393L,1486L,1582L,1681L,1783L,1888L,1996L,2107L,2221L,2338L,2458L,2581L,2707L,2836L,2968L,3103L,3241L,3382L,3526L,3673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133694Inst : IEnumerable<long>
{
public static readonly long[] Value=A133694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133694.Bytes);
public long this[int i]=>Value[i];

public static A133694Inst Instance=new A133694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133695
{
public static readonly long[] Value={ 1L,-3L,-3L,-1L,-3L,1L,-3L,-1L,-1L,1L,-3L,-1L,-3L,1L,1L,-1L,-3L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133695Inst : IEnumerable<long>
{
public static readonly long[] Value=A133695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133695.Bytes);
public long this[int i]=>Value[i];

public static A133695Inst Instance=new A133695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133696
{
public static readonly long[] Value={ 1L,2L,0L,2L,1L,0L,2L,2L,1L,0L,2L,2L,1L,1L,0L,2L,0L,0L,0L,1L,0L,2L,2L,2L,2L,1L,1L,0L,2L,4L,3L,0L,2L,1L,1L,0L,2L,3L,10L,4L,3L,5L,1L,1L,0L,2L,0L,5L,11L,0L,8L,2L,0L,1L,0L,2L,3L,6L,8L,9L,8L,5L,2L,1L,1L,0L,2L,6L,0L,0L,14L,78L,10L,0L,0L,1L,1L,0L,2L,4L,8L,14L,20L,23L,19L,13L,7L,3L,1L,1L,0L,2L,0L,9L,0L,29L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133696Inst : IEnumerable<long>
{
public static readonly long[] Value=A133696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133696.Bytes);
public long this[int i]=>Value[i];

public static A133696Inst Instance=new A133696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133697
{
public static readonly long[] Value={ 7L,69L,420L,1796L,12073L,101397L,1139211L,5440508L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133697Inst : IEnumerable<long>
{
public static readonly long[] Value=A133697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133697.Bytes);
public long this[int i]=>Value[i];

public static A133697Inst Instance=new A133697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133698
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,2L,0L,0L,0L,1L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,3L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133698Inst : IEnumerable<long>
{
public static readonly long[] Value=A133698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133698.Bytes);
public long this[int i]=>Value[i];

public static A133698Inst Instance=new A133698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133699
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,2L,1L,1L,0L,1L,1L,0L,0L,0L,2L,1L,1L,2L,0L,0L,2L,1L,0L,0L,0L,0L,0L,2L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,2L,0L,0L,0L,0L,0L,3L,1L,1L,0L,0L,2L,0L,0L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133699Inst : IEnumerable<long>
{
public static readonly long[] Value=A133699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133699.Bytes);
public long this[int i]=>Value[i];

public static A133699Inst Instance=new A133699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133700
{
public static readonly long[] Value={ 1L,2L,3L,3L,3L,6L,3L,4L,6L,6L,3L,9L,3L,6L,9L,5L,3L,12L,3L,9L,9L,6L,3L,12L,6L,6L,10L,9L,3L,18L,3L,6L,9L,6L,9L,18L,3L,6L,9L,12L,3L,18L,3L,9L,18L,6L,3L,15L,6L,12L,9L,9L,3L,20L,9L,12L,9L,6L,3L,27L,3L,6L,18L,7L,9L,18L,3L,9L,9L,18L,3L,24L,3L,6L,18L,9L,9L,18L,3L,15L,15L,6L,3L,27L,9L,6L,9L,12L,3L,36L,9L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133700Inst : IEnumerable<long>
{
public static readonly long[] Value=A133700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133700.Bytes);
public long this[int i]=>Value[i];

public static A133700Inst Instance=new A133700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133701
{
public static readonly long[] Value={ 1L,1L,1L,2L,0L,2L,1L,1L,0L,1L,2L,0L,0L,0L,2L,2L,2L,2L,0L,0L,2L,2L,0L,0L,0L,0L,0L,2L,1L,1L,0L,1L,0L,0L,0L,1L,3L,0L,3L,0L,0L,0L,0L,0L,3L,2L,2L,0L,0L,2L,0L,0L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133701Inst : IEnumerable<long>
{
public static readonly long[] Value=A133701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133701.Bytes);
public long this[int i]=>Value[i];

public static A133701Inst Instance=new A133701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133702
{
public static readonly long[] Value={ 1L,2L,4L,3L,4L,8L,4L,4L,9L,8L,4L,12L,4L,8L,16L,5L,6L,18L,4L,12L,16L,8L,4L,16L,9L,8L,16L,12L,4L,32L,8L,6L,16L,12L,16L,27L,4L,8L,16L,16L,6L,32L,8L,12L,36L,8L,4L,20L,9L,18L,24L,12L,4L,32L,16L,16L,16L,8L,4L,48L,4L,16L,44L,7L,20L,32L,4L,18L,16L,32L,4L,36L,10L,8L,36L,12L,16L,32L,4L,20L,25L,12L,4L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133702Inst : IEnumerable<long>
{
public static readonly long[] Value=A133702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133702.Bytes);
public long this[int i]=>Value[i];

public static A133702Inst Instance=new A133702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133703
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,2L,0L,0L,0L,1L,1L,0L,0L,0L,2L,0L,1L,0L,0L,0L,2L,1L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,0L,0L,0L,0L,3L,0L,1L,0L,0L,0L,0L,0L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133703Inst : IEnumerable<long>
{
public static readonly long[] Value=A133703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133703.Bytes);
public long this[int i]=>Value[i];

public static A133703Inst Instance=new A133703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133736
{
public static readonly BigInteger[] Value={ 1L,1L,2L,3L,7L,15L,52L,236L,2018L,33044L,1181670L,87720798L,12886156666L,3633055848955L,1944000061673516L,1967881435350411681L,BigInteger.Parse("3768516013573481061951"),BigInteger.Parse("13670271805989797561408684") };
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
public class A133736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133736Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A133736.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A133736.Bytes);
public BigInteger this[int i]=>Value[i];

public static A133736Inst Instance=new A133736Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133737
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,2L,4L,2L,2L,3L,5L,2L,2L,3L,6L,6L,3L,4L,3L,6L,7L,7L,3L,4L,3L,6L,7L,14L,8L,4L,4L,6L,6L,7L,14L,17L,9L,4L,6L,6L,6L,7L,14L,17L,27L,10L,5L,6L,6L,12L,7L,14L,17L,27L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133737Inst : IEnumerable<long>
{
public static readonly long[] Value=A133737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133737.Bytes);
public long this[int i]=>Value[i];

public static A133737Inst Instance=new A133737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133738
{
public static readonly long[] Value={ 1L,0L,-2L,-2L,2L,2L,-2L,0L,2L,4L,-2L,-4L,2L,0L,-2L,-2L,2L,4L,-4L,-4L,2L,2L,-2L,0L,4L,4L,0L,-6L,2L,0L,-2L,0L,2L,6L,-4L,-4L,4L,0L,-4L,-2L,0L,4L,-2L,-4L,2L,0L,0L,0L,4L,4L,-2L,-6L,2L,0L,-6L,2L,2L,8L,0L,-4L,2L,0L,0L,0L,2L,2L,-6L,-4L,2L,0L,-2L,0L,4L,4L,0L,-6L,2L,-2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133738Inst : IEnumerable<long>
{
public static readonly long[] Value=A133738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133738.Bytes);
public long this[int i]=>Value[i];

public static A133738Inst Instance=new A133738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133739
{
public static readonly long[] Value={ 1L,9L,31L,45L,6L,-45L,8L,117L,121L,54L,12L,-9L,14L,72L,186L,261L,18L,-207L,20L,270L,248L,108L,24L,63L,31L,126L,391L,360L,30L,-270L,32L,549L,372L,162L,48L,-171L,38L,180L,434L,702L,42L,-360L,44L,540L,726L,216L,48L,207L,57L,279L,558L,630L,54L,-693L,72L,936L,620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133739Inst : IEnumerable<long>
{
public static readonly long[] Value=A133739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133739.Bytes);
public long this[int i]=>Value[i];

public static A133739Inst Instance=new A133739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133740
{
public static readonly long[] Value={ 19L,179L,419L,499L,643L,673L,769L,883L,1153L,1409L,1459L,1889L,2003L,2083L,2131L,2579L,2609L,2659L,2689L,2819L,3169L,3779L,3889L,3907L,4099L,4129L,4259L,4339L,4513L,4723L,4993L,5009L,5059L,5233L,5347L,5443L,5683L,6529L,6659L,6689L,6899L,7219L,7283L,7459L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133740Inst : IEnumerable<long>
{
public static readonly long[] Value=A133740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133740.Bytes);
public long this[int i]=>Value[i];

public static A133740Inst Instance=new A133740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133741
{
public static readonly long[] Value={ 8L,0L,7L,9L,4L,5L,5L,0L,6L,5L,9L,9L,0L,3L,4L,4L,1L,8L,6L,3L,7L,9L,2L,3L,4L,8L,0L,1L,3L,2L,6L,3L,0L,8L,8L,5L,8L,0L,4L,4L,7L,1L,9L,2L,9L,1L,4L,8L,1L,9L,6L,8L,4L,4L,5L,0L,0L,1L,9L,5L,2L,0L,3L,4L,6L,7L,7L,4L,1L,0L,9L,9L,9L,4L,2L,5L,9L,0L,7L,0L,7L,0L,0L,2L,4L,8L,6L,7L,8L,0L,3L,3L,0L,4L,4L,5L,4L,5L,7L,4L,1L,8L,9L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133741Inst : IEnumerable<long>
{
public static readonly long[] Value=A133741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133741.Bytes);
public long this[int i]=>Value[i];

public static A133741Inst Instance=new A133741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133742
{
public static readonly long[] Value={ 5L,9L,6L,0L,2L,7L,2L,4L,6L,7L,0L,0L,4L,8L,2L,7L,9L,0L,6L,8L,1L,0L,3L,8L,2L,5L,9L,9L,3L,3L,6L,8L,4L,5L,5L,7L,0L,9L,7L,7L,6L,4L,0L,3L,5L,4L,2L,5L,9L,0L,1L,5L,7L,7L,7L,4L,9L,9L,0L,2L,3L,9L,8L,2L,6L,6L,1L,2L,9L,4L,5L,0L,0L,2L,8L,7L,0L,4L,6L,4L,6L,4L,9L,8L,7L,5L,6L,6L,0L,9L,8L,3L,4L,7L,7L,7L,2L,7L,1L,2L,9L,0L,5L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133742Inst : IEnumerable<long>
{
public static readonly long[] Value=A133742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133742.Bytes);
public long this[int i]=>Value[i];

public static A133742Inst Instance=new A133742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133743
{
public static readonly long[] Value={ 1L,4L,9L,16L,25L,36L,49L,100L,144L,169L,225L,256L,361L,441L,484L,625L,729L,784L,1156L,1521L,1600L,1764L,2401L,2704L,3364L,4096L,4225L,4356L,4900L,5184L,5929L,6889L,7921L,8836L,9216L,9409L,10404L,11881L,13689L,13924L,14161L,18496L,19321L,20449L,21316L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133743Inst : IEnumerable<long>
{
public static readonly long[] Value=A133743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133743.Bytes);
public long this[int i]=>Value[i];

public static A133743Inst Instance=new A133743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133744
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,15L,-19L,-44L,0L,31L,33L,80L,43L,92L,0L,112L,305L,140L,-77L,336L,261L,0L,-103L,-228L,129L,131L,268L,429L,292L,-153L,-805L,-352L,189L,985L,2040L,1260L,440L,-693L,-468L,239L,-2367L,-1365L,-285L,885L,596L,3531L,2608L,3360L,2752L,-2196L,0L,2709L,4367L,4411L,2105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133744Inst : IEnumerable<long>
{
public static readonly long[] Value=A133744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133744.Bytes);
public long this[int i]=>Value[i];

public static A133744Inst Instance=new A133744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133745
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,10L,16L,23L,52L,71L,137L,224L,260L,361L,668L,695L,699L,1518L,1775L,1776L,3285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133745Inst : IEnumerable<long>
{
public static readonly long[] Value=A133745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133745.Bytes);
public long this[int i]=>Value[i];

public static A133745Inst Instance=new A133745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133746
{
public static readonly long[] Value={ 5L,2L,3L,8L,2L,2L,5L,7L,1L,3L,8L,9L,8L,6L,4L,4L,0L,6L,4L,5L,0L,9L,5L,8L,2L,9L,4L,3L,8L,3L,2L,5L,5L,6L,6L,7L,6L,1L,5L,2L,4L,8L,0L,3L,0L,0L,6L,7L,0L,0L,7L,3L,9L,0L,8L,6L,5L,3L,0L,2L,5L,0L,5L,6L,2L,3L,0L,4L,4L,1L,9L,4L,4L,7L,6L,2L,4L,2L,6L,7L,0L,8L,1L,6L,0L,9L,0L,2L,8L,6L,1L,2L,5L,5L,1L,7L,2L,6L,5L,0L,1L,5L,7L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133746Inst : IEnumerable<long>
{
public static readonly long[] Value=A133746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133746.Bytes);
public long this[int i]=>Value[i];

public static A133746Inst Instance=new A133746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133747
{
public static readonly long[] Value={ 1L,8L,9L,0L,7L,2L,7L,2L,0L,1L,2L,9L,2L,3L,3L,8L,5L,2L,2L,9L,3L,0L,6L,1L,3L,9L,6L,5L,3L,4L,9L,2L,1L,3L,1L,3L,3L,9L,8L,7L,3L,1L,1L,6L,1L,2L,7L,0L,8L,9L,1L,1L,4L,6L,3L,0L,8L,2L,3L,2L,4L,2L,1L,4L,4L,3L,0L,5L,5L,5L,9L,0L,2L,6L,0L,9L,6L,4L,7L,6L,7L,2L,9L,6L,6L,5L,2L,1L,6L,6L,3L,7L,3L,0L,4L,4L,7L,0L,4L,9L,3L,4L,0L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133747Inst : IEnumerable<long>
{
public static readonly long[] Value=A133747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133747.Bytes);
public long this[int i]=>Value[i];

public static A133747Inst Instance=new A133747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133748
{
public static readonly long[] Value={ 6L,8L,7L,5L,1L,8L,5L,8L,1L,8L,0L,2L,0L,3L,7L,2L,8L,2L,7L,4L,9L,0L,0L,9L,5L,7L,7L,9L,8L,1L,0L,5L,5L,7L,1L,9L,7L,9L,0L,0L,8L,5L,6L,4L,5L,1L,8L,1L,9L,1L,6L,0L,8L,9L,6L,2L,7L,4L,4L,8L,7L,8L,9L,1L,5L,3L,6L,0L,0L,3L,2L,7L,9L,6L,0L,1L,1L,1L,5L,6L,5L,2L,5L,8L,0L,3L,1L,6L,7L,5L,7L,6L,2L,1L,3L,0L,2L,7L,7L,0L,3L,1L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133748Inst : IEnumerable<long>
{
public static readonly long[] Value=A133748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133748.Bytes);
public long this[int i]=>Value[i];

public static A133748Inst Instance=new A133748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133749
{
public static readonly long[] Value={ 6L,9L,4L,5L,9L,2L,7L,1L,0L,6L,6L,7L,7L,2L,1L,3L,9L,5L,4L,0L,6L,8L,6L,6L,5L,0L,7L,0L,7L,7L,2L,5L,9L,1L,8L,4L,0L,0L,1L,5L,0L,2L,7L,0L,8L,7L,3L,6L,2L,7L,7L,5L,4L,8L,9L,4L,4L,9L,6L,5L,5L,1L,2L,5L,2L,8L,2L,6L,3L,2L,8L,8L,5L,5L,6L,0L,5L,8L,9L,4L,1L,6L,8L,6L,0L,6L,6L,4L,5L,2L,6L,2L,9L,5L,9L,8L,2L,9L,6L,0L,4L,7L,8L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133749Inst : IEnumerable<long>
{
public static readonly long[] Value=A133749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133749.Bytes);
public long this[int i]=>Value[i];

public static A133749Inst Instance=new A133749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133750
{
public static readonly long[] Value={ 5L,659L,709L,739L,929L,1283L,1409L,1493L,1523L,1877L,1907L,2099L,2179L,2339L,2689L,2803L,3109L,3187L,3299L,3539L,3733L,3923L,4339L,4357L,5009L,5059L,5443L,5683L,5939L,5987L,6053L,6133L,6529L,7219L,7349L,7459L,7699L,7829L,8419L,8609L,8819L,8849L,9043L,9539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133750Inst : IEnumerable<long>
{
public static readonly long[] Value=A133750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133750.Bytes);
public long this[int i]=>Value[i];

public static A133750Inst Instance=new A133750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133751
{
public static readonly long[] Value={ 5L,14L,52L,248L,1456L,10112L,80704L,725888L,7257856L,79834112L,958004224L,12454043648L,174356586496L,2615348744192L,41845579792384L,711374856224768L,12804747411521536L,243290200817795072L,4865804016353542144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133751Inst : IEnumerable<long>
{
public static readonly long[] Value=A133751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133751.Bytes);
public long this[int i]=>Value[i];

public static A133751Inst Instance=new A133751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134040
{
public static readonly BigInteger[] Value={ 1L,2L,4L,14L,140L,4964L,808870L,726210606L,4161522164020L,170403742275382924L,BigInteger.Parse("54674613696351170731038"),BigInteger.Parse("148019646825727958873435181692"),BigInteger.Parse("3596203368022579371689526442266893534") };
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
public class A134040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134040Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134040.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134040.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134040Inst Instance=new A134040Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134041
{
public static readonly BigInteger[] Value={ 1L,2L,2L,4L,6L,14L,36L,114L,450L,2268L,14442L,118686L,1264678L,17519842L,318273566L,7607402556L,240151303078L,10055927801538L,559859566727028L,41582482495661986L,4129785050606801246L,BigInteger.Parse("549628445573614296188"),BigInteger.Parse("98256218721544814784486"),BigInteger.Parse("23631541930531250077261282") };
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
public class A134041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134041Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134041.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134041.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134041Inst Instance=new A134041Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134042
{
public static readonly long[] Value={ -4L,2L,8L,11L,26L,422L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134042Inst : IEnumerable<long>
{
public static readonly long[] Value=A134042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134042.Bytes);
public long this[int i]=>Value[i];

public static A134042Inst Instance=new A134042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134043
{
public static readonly long[] Value={ 7L,11L,25L,38L,133L,8669L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134043Inst : IEnumerable<long>
{
public static readonly long[] Value=A134043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134043.Bytes);
public long this[int i]=>Value[i];

public static A134043Inst Instance=new A134043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134044
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,15L,30L,58L,113L,220L,429L,835L,1627L,3169L,6172L,12023L,23419L,45616L,88853L,173073L,337118L,656656L,1279065L,2491423L,4852911L,9452731L,18412473L,35864686L,69858930L,136074521L,265052378L,516281541L,1005637564L,1958828336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134044Inst : IEnumerable<long>
{
public static readonly long[] Value=A134044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134044.Bytes);
public long this[int i]=>Value[i];

public static A134044Inst Instance=new A134044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134045
{
public static readonly long[] Value={ 1L,3L,7L,18L,61L,258L,1177L,5358L,23821L,103338L,439297L,1838598L,7605781L,31191618L,127100617L,515462238L,2083142941L,8396683098L,33779525137L,135697396278L,544529307301L,2183340065778L,8749036112857L,35043186680718L,140313902770861L,561679137947658L,2247987249823777L,8995761328275558L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134045Inst : IEnumerable<long>
{
public static readonly long[] Value=A134045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134045.Bytes);
public long this[int i]=>Value[i];

public static A134045Inst Instance=new A134045Inst();

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