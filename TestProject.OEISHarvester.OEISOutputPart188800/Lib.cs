using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A219257
{
public static readonly long[] Value={ 0L,9L,13L,40L,48L,93L,105L,168L,184L,265L,285L,384L,408L,525L,553L,688L,720L,873L,909L,1080L,1120L,1309L,1353L,1560L,1608L,1833L,1885L,2128L,2184L,2445L,2505L,2784L,2848L,3145L,3213L,3528L,3600L,3933L,4009L,4360L,4440L,4809L,4893L,5280L,5368L,5773L,5865L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219257Inst : IEnumerable<long>
{
public static readonly long[] Value=A219257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219257.Bytes);
public long this[int i]=>Value[i];

public static A219257Inst Instance=new A219257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219258
{
public static readonly long[] Value={ 0L,25L,29L,104L,112L,237L,249L,424L,440L,665L,685L,960L,984L,1309L,1337L,1712L,1744L,2169L,2205L,2680L,2720L,3245L,3289L,3864L,3912L,4537L,4589L,5264L,5320L,6045L,6105L,6880L,6944L,7769L,7837L,8712L,8784L,9709L,9785L,10760L,10840L,11865L,11949L,13024L,13112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219258Inst : IEnumerable<long>
{
public static readonly long[] Value=A219258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219258.Bytes);
public long this[int i]=>Value[i];

public static A219258Inst Instance=new A219258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219259
{
public static readonly long[] Value={ 0L,23L,27L,96L,104L,219L,231L,392L,408L,615L,635L,888L,912L,1211L,1239L,1584L,1616L,2007L,2043L,2480L,2520L,3003L,3047L,3576L,3624L,4199L,4251L,4872L,4928L,5595L,5655L,6368L,6432L,7191L,7259L,8064L,8136L,8987L,9063L,9960L,10040L,10983L,11067L,12056L,12144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219259Inst : IEnumerable<long>
{
public static readonly long[] Value=A219259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219259.Bytes);
public long this[int i]=>Value[i];

public static A219259Inst Instance=new A219259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219260
{
public static readonly long[] Value={ 1L,1L,3L,10L,37L,143L,576L,2393L,10178L,44133L,194341L,866867L,3908454L,17784385L,81562890L,376637216L,1749704080L,8171760933L,38346326963L,180707395127L,854850922373L,4057990958069L,19324260613400L,92288612451684L,441919933724974L,2121281845071105L,10205443975074195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219260Inst : IEnumerable<long>
{
public static readonly long[] Value=A219260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219260.Bytes);
public long this[int i]=>Value[i];

public static A219260Inst Instance=new A219260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219261
{
public static readonly long[] Value={ 1L,1L,3L,9L,33L,124L,503L,2089L,8960L,39142L,173978L,783347L,3567123L,16395199L,75966835L,354447193L,1663921966L,7853325055L,37244059607L,177388171005L,848148206917L,4069483589180L,19588001935380L,94559416543623L,457697632011720L,2220852281129195L,10800560004895426L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219261Inst : IEnumerable<long>
{
public static readonly long[] Value=A219261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219261.Bytes);
public long this[int i]=>Value[i];

public static A219261Inst Instance=new A219261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219262
{
public static readonly long[] Value={ 1L,1L,3L,11L,43L,179L,772L,3446L,15737L,73315L,346869L,1662593L,8055433L,39390631L,194145569L,963490818L,4810435187L,24145458246L,121771909878L,616744946740L,3135657413451L,15997777629900L,81877262767137L,420263466778106L,2162874177974610L,11158378099471260L,57696623896231494L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219262Inst : IEnumerable<long>
{
public static readonly long[] Value=A219262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219262.Bytes);
public long this[int i]=>Value[i];

public static A219262Inst Instance=new A219262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219263
{
public static readonly long[] Value={ 1L,1L,3L,10L,39L,159L,693L,3101L,14292L,67116L,320448L,1549834L,7579037L,37406737L,186102602L,932294987L,4698796087L,23809155711L,121219100012L,619800529792L,3181291257740L,16385813881342L,84666104373097L,438742341955132L,2279628504172080L,11873579440176774L,61984238371422197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219263Inst : IEnumerable<long>
{
public static readonly long[] Value=A219263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219263.Bytes);
public long this[int i]=>Value[i];

public static A219263Inst Instance=new A219263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219264
{
public static readonly BigInteger[] Value={ 1L,1L,8L,128L,3259L,120082L,6151625L,433404057L,42180568185L,5720993700540L,1088246094845838L,291276119631119408L,BigInteger.Parse("109983236494820652007"),BigInteger.Parse("58741463418913578672779"),BigInteger.Parse("44466318283501559718838424"),BigInteger.Parse("47771843216826858235974983400"),BigInteger.Parse("72930986725295232949801895385998") };
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
public class A219264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219264Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219264.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219264.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219264Inst Instance=new A219264Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219265
{
public static readonly BigInteger[] Value={ 1L,1L,8L,160L,6918L,609469L,106947753L,37651271215L,26931993643529L,39243099256414069L,BigInteger.Parse("116654228928308598913"),BigInteger.Parse("710224935200206160129234"),BigInteger.Parse("8867331728829780268501045551"),BigInteger.Parse("227187317486051730833557991305666"),BigInteger.Parse("11969414396907448200529521385052444890") };
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
public class A219265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219265Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219265.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219265.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219265Inst Instance=new A219265Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219266
{
public static readonly BigInteger[] Value={ 1L,3L,31L,1103L,171311L,149089887L,877704854447L,40451674467223423L,BigInteger.Parse("16514355739866259408591"),BigInteger.Parse("66586047491662065505372477983"),BigInteger.Parse("2923692867015618804999172694908629103"),BigInteger.Parse("1527767556403309713534536695030930443376591295"),BigInteger.Parse("10306227067090276816548435451550663056418226402352755215") };
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
public class A219266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219266Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219266.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219266.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219266Inst Instance=new A219266Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219267
{
public static readonly BigInteger[] Value={ 1L,7L,313L,110143L,431860201L,24185951471887L,BigInteger.Parse("23238336572015738041"),BigInteger.Parse("445571476975584446962639039"),BigInteger.Parse("194201470505208674769594891331807753"),BigInteger.Parse("2157794122078406207016487628429579826176795887"),BigInteger.Parse("677208230450612019931822374477208301572175793625037599321") };
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
public class A219267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219267Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219267.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219267.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219267Inst Instance=new A219267Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219268
{
public static readonly BigInteger[] Value={ 1L,3L,22L,347L,11986L,956334L,184142134L,87903876147L,105736320973732L,323943204887363938L,BigInteger.Parse("2547547949361933790328"),BigInteger.Parse("51735228018482706470521574"),BigInteger.Parse("2726127372514537039881847535054"),BigInteger.Parse("374214400937086673452020875815709240"),BigInteger.Parse("134262616041282033840675468757467513112522") };
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
public class A219268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219268Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219268.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219268.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219268Inst Instance=new A219268Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219269
{
public static readonly BigInteger[] Value={ 1L,1L,1L,8L,247L,33184L,24678266L,125237615376L,5055581949347115L,BigInteger.Parse("1834887966372111613136"),BigInteger.Parse("6658588234946979374670842054"),BigInteger.Parse("265790194051800257952649093995518288"),BigInteger.Parse("127313960109916568757252293587045497552163302"),BigInteger.Parse("792786695940715289991550398242378268738388375150573312") };
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
public class A219269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219269Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219269.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219269.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219269Inst Instance=new A219269Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219270
{
public static readonly BigInteger[] Value={ 1L,1L,3L,19L,357L,36301L,25099919L,125586786039L,5057589140280713L,BigInteger.Parse("1834978988294513263993"),BigInteger.Parse("6658624933768189847669906875"),BigInteger.Parse("265790340541205664455435665865706651"),BigInteger.Parse("127313966488883223582008076686428073754622381"),BigInteger.Parse("792786699250878346141762323574616271109902136066501317") };
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
public class A219270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219270Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219270.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219270.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219270Inst Instance=new A219270Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219271
{
public static readonly long[] Value={ 352367441L,4709250017L,16653466069L,23908162969L,51658610299L,52042712083L,53924700541L,54540661141L,64499058697L,84398639471L,100000699399L,161578812517L,169226036407L,194345988607L,201952832951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219271Inst : IEnumerable<long>
{
public static readonly long[] Value=A219271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219271.Bytes);
public long this[int i]=>Value[i];

public static A219271Inst Instance=new A219271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219272
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,3L,3L,5L,16L,1L,1L,1L,3L,4L,9L,25L,49L,70L,168L,768L,1L,1L,1L,3L,4L,10L,30L,63L,162L,372L,1506L,3300L,7887L,15015L,48048L,292864L,1L,1L,1L,3L,4L,10L,31L,69L,182L,525L,1911L,5115L,17347L,43758L,149721L,626769L,1946516L,4934930L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219272Inst : IEnumerable<long>
{
public static readonly long[] Value=A219272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219272.Bytes);
public long this[int i]=>Value[i];

public static A219272Inst Instance=new A219272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219273
{
public static readonly BigInteger[] Value={ 1L,2L,5L,30L,1099L,369267L,1299735768L,55209313116171L,BigInteger.Parse("32401252746609874301"),BigInteger.Parse("297072994236730724952120013"),BigInteger.Parse("47538200124908778784793653003318415"),BigInteger.Parse("146779873670882872946054150750588724458499598"),BigInteger.Parse("9581411392466176519699106616122834087912451590912289450") };
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
public class A219273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219273Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219273.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219273.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219273Inst Instance=new A219273Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219274
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,3L,5L,16L,1L,4L,9L,49L,70L,168L,768L,1L,5L,14L,92L,204L,738L,3300L,7887L,15015L,48048L,292864L,1L,6L,20L,153L,405L,1815L,9460L,28743L,101673L,333905L,1946516L,4934930L,14454726L,34918884L,141892608L,1100742656L,1L,7L,27L,235L,715L,3630L,21307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219274Inst : IEnumerable<long>
{
public static readonly long[] Value=A219274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219274.Bytes);
public long this[int i]=>Value[i];

public static A219274Inst Instance=new A219274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219275
{
public static readonly BigInteger[] Value={ 1L,1L,3L,25L,1069L,368168L,1299366501L,55208013380403L,BigInteger.Parse("32401197537296758130"),BigInteger.Parse("297072961835477978342245712"),BigInteger.Parse("47538199827835784548062928051198402"),BigInteger.Parse("146779873623344672821145371965795071455181183"),BigInteger.Parse("9581411392319396646028223743176779937161862866453789852") };
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
public class A219275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219275Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219275.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219275.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219275Inst Instance=new A219275Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219276
{
public static readonly long[] Value={ 2L,3L,5L,8L,10L,14L,17L,19L,31L,32L,34L,35L,39L,48L,50L,51L,53L,54L,59L,61L,73L,76L,78L,84L,88L,90L,97L,101L,102L,105L,107L,110L,121L,126L,128L,134L,135L,139L,143L,144L,146L,152L,153L,158L,167L,171L,172L,178L,180L,184L,186L,187L,189L,201L,202L,203L,205L,207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219276Inst : IEnumerable<long>
{
public static readonly long[] Value=A219276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219276.Bytes);
public long this[int i]=>Value[i];

public static A219276Inst Instance=new A219276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219277
{
public static readonly long[] Value={ 3L,4L,7L,15L,18L,19L,37L,43L,46L,47L,62L,74L,75L,84L,89L,90L,92L,96L,105L,112L,130L,139L,158L,163L,182L,189L,190L,202L,213L,217L,218L,225L,233L,255L,256L,271L,280L,288L,293L,301L,314L,317L,329L,335L,337L,349L,350L,354L,360L,364L,365L,368L,376L,396L,416L,422L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219277Inst : IEnumerable<long>
{
public static readonly long[] Value=A219277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219277.Bytes);
public long this[int i]=>Value[i];

public static A219277Inst Instance=new A219277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219278
{
public static readonly long[] Value={ 2L,13L,20L,21L,33L,74L,87L,88L,94L,104L,105L,127L,172L,182L,185L,188L,215L,224L,233L,240L,249L,258L,278L,281L,292L,293L,304L,329L,337L,365L,399L,416L,433L,440L,468L,471L,489L,502L,509L,529L,540L,573L,576L,583L,608L,612L,615L,622L,630L,631L,639L,685L,689L,707L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219278Inst : IEnumerable<long>
{
public static readonly long[] Value=A219278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219278.Bytes);
public long this[int i]=>Value[i];

public static A219278Inst Instance=new A219278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219279
{
public static readonly BigInteger[] Value={ 708158977L,BigInteger.Parse("21293229181234844660737"),BigInteger.Parse("21260958687099552174028801"),BigInteger.Parse("46453251497945783267589121"),BigInteger.Parse("64576903826545426454350012417"),BigInteger.Parse("26475257580698876650533675799180801"),BigInteger.Parse("352799899930156494230719582325262337"),BigInteger.Parse("423592588581159655917184553299009537") };
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
public class A219279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219279Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219279.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219279.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219279Inst Instance=new A219279Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219280
{
public static readonly BigInteger[] Value={ 2L,7L,97L,665857L,708158977L,BigInteger.Parse("150038171394905030432003281854339710977") };
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
public class A219280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219280Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219280.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219280.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219280Inst Instance=new A219280Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219281
{
public static readonly long[] Value={ 2L,2L,2L,3L,2L,8L,164L,29L,60L,213L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219281Inst : IEnumerable<long>
{
public static readonly long[] Value=A219281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219281.Bytes);
public long this[int i]=>Value[i];

public static A219281Inst Instance=new A219281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219282
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,6L,9L,13L,18L,25L,35L,49L,68L,93L,126L,170L,229L,308L,413L,551L,731L,965L,1269L,1664L,2177L,2842L,3701L,4806L,6222L,8031L,10337L,13272L,17003L,21740L,27745L,35343L,44936L,57021L,72213L,91274L,115149L,145010L,182309L,228841L,286819L,358964L,448614L,559857L,697694L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219282Inst : IEnumerable<long>
{
public static readonly long[] Value=A219282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219282.Bytes);
public long this[int i]=>Value[i];

public static A219282Inst Instance=new A219282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219283
{
public static readonly BigInteger[] Value={ 6431804812640900941L,BigInteger.Parse("31211427601852046808999765129652549"),BigInteger.Parse("4519079836942618423019040742735616921552429101"),BigInteger.Parse("22137406298265966315641393147750228275603823278911109") };
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
public class A219283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219283Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219283.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219283.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219283Inst Instance=new A219283Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219284
{
public static readonly long[] Value={ 371281L,141903217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219284Inst : IEnumerable<long>
{
public static readonly long[] Value=A219284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219284.Bytes);
public long this[int i]=>Value[i];

public static A219284Inst Instance=new A219284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219285
{
public static readonly long[] Value={ 2L,3L,19L,149L,1751L,35654L,1455308L,127423164L,23439798583L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219285Inst : IEnumerable<long>
{
public static readonly long[] Value=A219285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219285.Bytes);
public long this[int i]=>Value[i];

public static A219285Inst Instance=new A219285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219286
{
public static readonly long[] Value={ 3L,6L,19L,42L,79L,136L,220L,339L,502L,719L,1001L,1360L,1809L,2362L,3034L,3841L,4800L,5929L,7247L,8774L,10531L,12540L,14824L,17407L,20314L,23571L,27205L,31244L,35717L,40654L,46086L,52045L,58564L,65677L,73419L,81826L,90935L,100784L,111412L,122859L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219286Inst : IEnumerable<long>
{
public static readonly long[] Value=A219286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219286.Bytes);
public long this[int i]=>Value[i];

public static A219286Inst Instance=new A219286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219287
{
public static readonly long[] Value={ 4L,9L,42L,149L,423L,1092L,2623L,5937L,12729L,26009L,50896L,95774L,173920L,305737L,521743L,866485L,1403565L,2221983L,3444020L,5234902L,7814504L,11471371L,16579351L,23617153L,33191161L,46061853L,63174192L,85692374L,115039336L,152941445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219287Inst : IEnumerable<long>
{
public static readonly long[] Value=A219287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219287.Bytes);
public long this[int i]=>Value[i];

public static A219287Inst Instance=new A219287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219288
{
public static readonly long[] Value={ 5L,12L,79L,423L,1751L,6546L,22970L,76311L,240506L,721669L,2070006L,5692328L,15039421L,38255848L,93891578L,222815518L,512310486L,1143423966L,2481561322L,5245536144L,10815752321L,21783909864L,42913710064L,82788030040L,156582776591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219288Inst : IEnumerable<long>
{
public static readonly long[] Value=A219288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219288.Bytes);
public long this[int i]=>Value[i];

public static A219288Inst Instance=new A219288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219289
{
public static readonly long[] Value={ 6L,15L,136L,1092L,6546L,35654L,185295L,919934L,4332241L,19354356L,82377686L,335088654L,1305431736L,4881371319L,17561579850L,60931312824L,204316648265L,663428883748L,2089694277830L,6395581415830L,19047707831769L,55281031168927L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219289Inst : IEnumerable<long>
{
public static readonly long[] Value=A219289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219289.Bytes);
public long this[int i]=>Value[i];

public static A219289Inst Instance=new A219289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219290
{
public static readonly long[] Value={ 7L,18L,220L,2623L,22970L,185295L,1455308L,11001188L,78655701L,530818425L,3400770086L,20765160878L,121095265926L,675886798131L,3619746974319L,18647969101899L,92619652248187L,444385154988709L,2063495070975608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219290Inst : IEnumerable<long>
{
public static readonly long[] Value=A219290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219290.Bytes);
public long this[int i]=>Value[i];

public static A219290Inst Instance=new A219290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219291
{
public static readonly long[] Value={ 2L,2L,2L,3L,3L,3L,4L,6L,6L,4L,5L,9L,19L,9L,5L,6L,12L,42L,42L,12L,6L,7L,15L,79L,149L,79L,15L,7L,8L,18L,136L,423L,423L,136L,18L,8L,9L,21L,220L,1092L,1751L,1092L,220L,21L,9L,10L,24L,339L,2623L,6546L,6546L,2623L,339L,24L,10L,11L,27L,502L,5937L,22970L,35654L,22970L,5937L,502L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219291Inst : IEnumerable<long>
{
public static readonly long[] Value=A219291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219291.Bytes);
public long this[int i]=>Value[i];

public static A219291Inst Instance=new A219291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219292
{
public static readonly long[] Value={ 3L,7L,77L,1540L,80488L,10000720L,2898775988L,2236908145276L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219292Inst : IEnumerable<long>
{
public static readonly long[] Value=A219292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219292.Bytes);
public long this[int i]=>Value[i];

public static A219292Inst Instance=new A219292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219293
{
public static readonly long[] Value={ 3L,7L,17L,35L,62L,103L,165L,257L,390L,577L,833L,1175L,1622L,2195L,2917L,3813L,4910L,6237L,7825L,9707L,11918L,14495L,17477L,20905L,24822L,29273L,34305L,39967L,46310L,53387L,61253L,69965L,79582L,90165L,101777L,114483L,128350L,143447L,159845L,177617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219293Inst : IEnumerable<long>
{
public static readonly long[] Value=A219293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219293.Bytes);
public long this[int i]=>Value[i];

public static A219293Inst Instance=new A219293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219294
{
public static readonly long[] Value={ 6L,17L,77L,261L,800L,2361L,6647L,17675L,44508L,106958L,246970L,550538L,1188820L,2493637L,5093382L,10153065L,19790653L,37786838L,70775454L,130209424L,235560181L,419452123L,735792808L,1272482264L,2171035995L,3656523015L,6082717651L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219294Inst : IEnumerable<long>
{
public static readonly long[] Value=A219294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219294.Bytes);
public long this[int i]=>Value[i];

public static A219294Inst Instance=new A219294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219295
{
public static readonly long[] Value={ 10L,35L,261L,1540L,8424L,42938L,204842L,912956L,3824676L,15209685L,57837351L,211203417L,742716089L,2521452690L,8283479640L,26391360139L,81707036845L,246254219675L,723671248714L,2076719332039L,5827511255940L,16010189488131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219295Inst : IEnumerable<long>
{
public static readonly long[] Value=A219295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219295.Bytes);
public long this[int i]=>Value[i];

public static A219295Inst Instance=new A219295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219296
{
public static readonly long[] Value={ 15L,62L,800L,8424L,80488L,696879L,5595137L,42137183L,299422108L,2021265987L,13038610049L,80654932004L,479604953245L,2748191485086L,15213541621965L,81562622654551L,424391554645577L,2147199449175464L,10580989217496262L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219296Inst : IEnumerable<long>
{
public static readonly long[] Value=A219296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219296.Bytes);
public long this[int i]=>Value[i];

public static A219296Inst Instance=new A219296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219297
{
public static readonly long[] Value={ 21L,103L,2361L,42938L,696879L,10000720L,132409292L,1666872519L,20066430819L,230659006886L,2533164156501L,26642899561323L,269106482492802L,2617519574246115L,24584394461026549L,223533029891507710L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219297Inst : IEnumerable<long>
{
public static readonly long[] Value=A219297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219297.Bytes);
public long this[int i]=>Value[i];

public static A219297Inst Instance=new A219297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219298
{
public static readonly BigInteger[] Value={ 28L,165L,6647L,204842L,5595137L,132409292L,2898775988L,61440315340L,1268571836942L,25181695745066L,476652751338079L,8610780294241502L,149111690333129713L,2485299355179037240L,BigInteger.Parse("39992792294223348706") };
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
public class A219298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219298Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219298.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219298.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219298Inst Instance=new A219298Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219299
{
public static readonly long[] Value={ 3L,3L,3L,6L,7L,6L,10L,17L,17L,10L,15L,35L,77L,35L,15L,21L,62L,261L,261L,62L,21L,28L,103L,800L,1540L,800L,103L,28L,36L,165L,2361L,8424L,8424L,2361L,165L,36L,45L,257L,6647L,42938L,80488L,42938L,6647L,257L,45L,55L,390L,17675L,204842L,696879L,696879L,204842L,17675L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219299Inst : IEnumerable<long>
{
public static readonly long[] Value=A219299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219299.Bytes);
public long this[int i]=>Value[i];

public static A219299Inst Instance=new A219299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219300
{
public static readonly long[] Value={ 1L,1L,8L,8L,3L,6L,8L,1L,4L,7L,5L,0L,8L,2L,2L,3L,5L,8L,8L,1L,4L,2L,9L,6L,0L,9L,5L,8L,6L,2L,9L,5L,9L,3L,5L,9L,4L,7L,0L,4L,7L,0L,4L,5L,6L,0L,0L,6L,2L,9L,0L,5L,6L,8L,8L,7L,4L,1L,4L,5L,3L,3L,7L,1L,2L,9L,1L,9L,6L,0L,6L,4L,1L,4L,0L,2L,1L,7L,4L,5L,8L,9L,4L,7L,5L,8L,3L,5L,0L,9L,8L,8L,0L,6L,7L,9L,6L,7L,7L,4L,5L,0L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219300Inst : IEnumerable<long>
{
public static readonly long[] Value=A219300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219300.Bytes);
public long this[int i]=>Value[i];

public static A219300Inst Instance=new A219300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219301
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,9L,11L,12L,13L,16L,17L,19L,23L,25L,27L,29L,31L,32L,37L,41L,43L,47L,49L,53L,59L,61L,64L,67L,71L,72L,73L,79L,80L,81L,83L,89L,97L,101L,103L,107L,109L,113L,121L,125L,127L,128L,131L,135L,137L,139L,149L,151L,157L,163L,167L,169L,173L,179L,181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219301Inst : IEnumerable<long>
{
public static readonly long[] Value=A219301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219301.Bytes);
public long this[int i]=>Value[i];

public static A219301Inst Instance=new A219301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219302
{
public static readonly long[] Value={ 12L,72L,80L,135L,432L,448L,800L,875L,1701L,2025L,2160L,2592L,6272L,8000L,11264L,15552L,17303L,30375L,30625L,35721L,53248L,56000L,64800L,80000L,87808L,93312L,93347L,108864L,184877L,212625L,216513L,247808L,455625L,559872L,750141L,756059L,800000L,859375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219302Inst : IEnumerable<long>
{
public static readonly long[] Value=A219302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219302.Bytes);
public long this[int i]=>Value[i];

public static A219302Inst Instance=new A219302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219303
{
public static readonly long[] Value={ 8L,14L,15L,18L,23L,28L,39L,51L,53L,65L,83L,139L,172L,174L,194L,197L,198L,226L,292L,318L,325L,335L,355L,358L,388L,493L,513L,518L,523L,530L,558L,573L,612L,638L,667L,708L,709L,715L,717L,748L,761L,766L,785L,830L,832L,847L,858L,863L,864L,935L,944L,979L,999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219303Inst : IEnumerable<long>
{
public static readonly long[] Value=A219303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219303.Bytes);
public long this[int i]=>Value[i];

public static A219303Inst Instance=new A219303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219304
{
public static readonly long[] Value={ 1L,6L,90L,3334L,326444L,89981627L,68906619754L,144049729095880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219304Inst : IEnumerable<long>
{
public static readonly long[] Value=A219304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219304.Bytes);
public long this[int i]=>Value[i];

public static A219304Inst Instance=new A219304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219305
{
public static readonly long[] Value={ 4L,18L,90L,423L,1958L,9233L,43725L,206269L,971794L,4583164L,21622807L,101988408L,481001317L,2268654909L,10700463129L,50469641870L,238042556300L,1122743524739L,5295505220276L,24976631418525L,117804014337453L,555630918690165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219305Inst : IEnumerable<long>
{
public static readonly long[] Value=A219305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219305.Bytes);
public long this[int i]=>Value[i];

public static A219305Inst Instance=new A219305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219306
{
public static readonly long[] Value={ 7L,51L,423L,3334L,25647L,200376L,1574278L,12334824L,96480571L,755212375L,5914093280L,46306103745L,362524633360L,2838264260603L,22221912955624L,173982894127917L,1362160216940837L,10664747935404835L,83497581682654109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219306Inst : IEnumerable<long>
{
public static readonly long[] Value=A219306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219306.Bytes);
public long this[int i]=>Value[i];

public static A219306Inst Instance=new A219306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219307
{
public static readonly long[] Value={ 12L,142L,1958L,25647L,326444L,4215579L,54797587L,710493819L,9194088812L,119051026450L,1542298398563L,19977719144984L,258742519096389L,3351214351286909L,43406104354037517L,562207779495312746L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219307Inst : IEnumerable<long>
{
public static readonly long[] Value=A219307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219307.Bytes);
public long this[int i]=>Value[i];

public static A219307Inst Instance=new A219307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219308
{
public static readonly BigInteger[] Value={ 21L,405L,9233L,200376L,4215579L,89981627L,1935133104L,41520773667L,888957906061L,19043081452793L,408152775865291L,8747035260806150L,187430143072289130L,4016312124315997845L,BigInteger.Parse("86065761676864158937") };
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
public class A219308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219308Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219308.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219308.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219308Inst Instance=new A219308Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219309
{
public static readonly long[] Value={ 37L,1157L,43725L,1574278L,54797587L,1935133104L,68906619754L,2448261182674L,86782430779997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219309Inst : IEnumerable<long>
{
public static readonly long[] Value=A219309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219309.Bytes);
public long this[int i]=>Value[i];

public static A219309Inst Instance=new A219309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219310
{
public static readonly long[] Value={ 1L,2L,2L,4L,6L,4L,7L,18L,18L,7L,12L,51L,90L,51L,12L,21L,142L,423L,423L,142L,21L,37L,405L,1958L,3334L,1958L,405L,37L,65L,1157L,9233L,25647L,25647L,9233L,1157L,65L,114L,3289L,43725L,200376L,326444L,200376L,43725L,3289L,114L,200L,9344L,206269L,1574278L,4215579L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219310Inst : IEnumerable<long>
{
public static readonly long[] Value=A219310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219310.Bytes);
public long this[int i]=>Value[i];

public static A219310Inst Instance=new A219310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219311
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,2L,0L,1L,3L,0L,1L,9L,0L,1L,14L,16L,0L,1L,34L,35L,0L,1L,55L,134L,0L,1L,125L,435L,0L,1L,209L,1213L,768L,0L,1L,461L,3454L,2310L,0L,1L,791L,10484L,11407L,0L,1L,1715L,28249L,44187L,0L,1L,3002L,80302L,200044L,0L,1L,6434L,231895L,680160L,292864L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219311Inst : IEnumerable<long>
{
public static readonly long[] Value=A219311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219311.Bytes);
public long this[int i]=>Value[i];

public static A219311Inst Instance=new A219311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219312
{
public static readonly long[] Value={ 0L,1L,4L,15L,59L,243L,1034L,4501L,19920L,89281L,404184L,1844789L,8477571L,39183625L,182010366L,849115811L,3976405347L,18684473203L,88060677880L,416162484693L,1971567963673L,9361218368921L,44539107835094L,212308063827055L,1013779444844754L,4848597239921803L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219312Inst : IEnumerable<long>
{
public static readonly long[] Value=A219312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219312.Bytes);
public long this[int i]=>Value[i];

public static A219312Inst Instance=new A219312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219313
{
public static readonly long[] Value={ 3L,7L,7L,3L,41L,5L,89L,23L,21L,35L,55L,5L,181L,511L,241L,83L,709L,401L,3653L,901L,137L,497L,1411L,121L,281L,209L,201L,191L,1667L,89L,39L,181L,233L,2783L,85L,911L,1717L,919L,97L,1163L,1319L,971L,361L,2371L,1573L,121L,817L,733L,1657L,1895L,509L,431L,2399L,1483L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219313Inst : IEnumerable<long>
{
public static readonly long[] Value=A219313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219313.Bytes);
public long this[int i]=>Value[i];

public static A219313Inst Instance=new A219313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219314
{
public static readonly long[] Value={ 0L,1L,0L,3L,3L,13L,26L,77L,192L,529L,1412L,3873L,10603L,29315L,81318L,226763L,634627L,1782637L,5022840L,14193457L,40211105L,114191159L,324981030L,926720807L,2647513282L,7576475383L,21716189676L,62336237007L,179182653117L,515717424109L,1486119467026L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219314Inst : IEnumerable<long>
{
public static readonly long[] Value=A219314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219314.Bytes);
public long this[int i]=>Value[i];

public static A219314Inst Instance=new A219314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219315
{
public static readonly BigInteger[] Value={ 13L,10321L,1651609L,265729L,2418383311848550201L,143457011569L,BigInteger.Parse("4788279267715459491640247899801"),BigInteger.Parse("55836455668763269069656769"),BigInteger.Parse("21624792044006209908534390421"),BigInteger.Parse("996389426180855801077045825760311681"),BigInteger.Parse("97188318826075110353523764096667396436794217") };
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
public class A219315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219315Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219315.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219315.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219315Inst Instance=new A219315Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219316
{
public static readonly long[] Value={ 16L,35L,134L,435L,1213L,3454L,10484L,28249L,80302L,231895L,638406L,1798515L,5170279L,14361074L,40675562L,116701060L,327587324L,931854890L,2678822398L,7577813175L,21658478151L,62401989636L,177658786252L,509822342794L,1472491312385L,4213745453731L,12134760359950L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219316Inst : IEnumerable<long>
{
public static readonly long[] Value=A219316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219316.Bytes);
public long this[int i]=>Value[i];

public static A219316Inst Instance=new A219316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219317
{
public static readonly long[] Value={ 768L,2310L,11407L,44187L,200044L,680160L,2769674L,9826918L,38483206L,135059866L,515249581L,1829452107L,6941537898L,24678730371L,92755537994L,333149285650L,1252530682570L,4513808634840L,16936935284163L,61508180909442L,231189178986445L,843098892380280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219317Inst : IEnumerable<long>
{
public static readonly long[] Value=A219317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219317.Bytes);
public long this[int i]=>Value[i];

public static A219317Inst Instance=new A219317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219318
{
public static readonly long[] Value={ 292864L,1153152L,7194434L,33888582L,177959434L,861962968L,4036054898L,18519351642L,85808400115L,389017226948L,1778061013340L,7967135309510L,35973133665285L,161398383117645L,726152765571840L,3256479005867430L,14629885404315411L,65641088599945380L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219318Inst : IEnumerable<long>
{
public static readonly long[] Value=A219318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219318.Bytes);
public long this[int i]=>Value[i];

public static A219318Inst Instance=new A219318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219319
{
public static readonly BigInteger[] Value={ 1100742656L,5462865408L,42035926724L,238839304110L,1477773782690L,8119282473120L,49406279584740L,259405071568305L,1468158383705685L,7798557001165665L,42744495396935010L,224697430361576340L,1226112009886575180L,6397760480647576200L,BigInteger.Parse("34422065224987469772") };
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
public class A219319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219319Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219319.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219319.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219319Inst Instance=new A219319Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219320
{
public static readonly BigInteger[] Value={ 48608795688960L,295284192952320L,2741894304901440L,18535141513347030L,134524383564933720L,851007098153745060L,5822391651578231460L,BigInteger.Parse("37395948352954386420"),BigInteger.Parse("238518115727229867660"),BigInteger.Parse("1501480486903096567740"),BigInteger.Parse("9413700760748972005500"),BigInteger.Parse("58167406634979463024710") };
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
public class A219320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219320Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219320.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219320.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219320Inst Instance=new A219320Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219321
{
public static readonly BigInteger[] Value={ BigInteger.Parse("29258366996258488320"),BigInteger.Parse("212593716124699852800"),BigInteger.Parse("2338077979922915527680"),BigInteger.Parse("18541315347775500731880"),BigInteger.Parse("156386347073221236234900"),BigInteger.Parse("1136852065645214098726260"),BigInteger.Parse("8834800018708598317055880"),BigInteger.Parse("63128042819798223843289680"),BigInteger.Parse("473458147812239316816345390"),BigInteger.Parse("3325190851643455231559076330") };
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
public class A219321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219321Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219321.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219321.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219321Inst Instance=new A219321Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219322
{
public static readonly BigInteger[] Value={ BigInteger.Parse("273035280663535522487992320"),BigInteger.Parse("2329440559042398325938585600"),BigInteger.Parse("29867922172910654180714311680"),BigInteger.Parse("274273837545154589560694664960"),BigInteger.Parse("2661165012109500556315841832780"),BigInteger.Parse("22087643957707583932955480283900"),BigInteger.Parse("194567964473214023234175600529800"),BigInteger.Parse("1559754564113482833062794519391700") };
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
public class A219322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219322Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219322.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219322.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219322Inst Instance=new A219322Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219323
{
public static readonly BigInteger[] Value={ BigInteger.Parse("44261486084874072183645699204710400"),BigInteger.Parse("436729628461295765400173291136614400"),BigInteger.Parse("6441891864721973386724377238726246400"),BigInteger.Parse("67713874217528144366021825416423334400"),BigInteger.Parse("748428489363219498086429630401834036500"),BigInteger.Parse("7038929756961099433630173212155312339950") };
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
public class A219323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219323Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219323.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219323.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219323Inst Instance=new A219323Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219324
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,247L,370L,378L,407L,481L,518L,592L,629L,1360L,3075L,26027L,26933L,45018L,69781L,80487L,154791L,1920261L,2137616L,2716713L,3100883L,3480140L,3934896L,4179451L,4830936L,5218958L,11955168L,80651025L,95738203L,257059332L,278945612L,456790123L,469135802L,493827160L,494376160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219324Inst : IEnumerable<long>
{
public static readonly long[] Value=A219324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219324.Bytes);
public long this[int i]=>Value[i];

public static A219324Inst Instance=new A219324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219325
{
public static readonly long[] Value={ 1L,17298L,25947L,100990L,106090L,2718340L,36680364L,34505916416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219325Inst : IEnumerable<long>
{
public static readonly long[] Value=A219325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219325.Bytes);
public long this[int i]=>Value[i];

public static A219325Inst Instance=new A219325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219326
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,48L,247L,370L,378L,407L,481L,518L,592L,629L,1547L,26027L,26933L,45018L,69781L,80487L,123823L,289835L,1920261L,2137616L,2716713L,3100883L,3480140L,3934896L,4179451L,4830936L,5218958L,23203827L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219326Inst : IEnumerable<long>
{
public static readonly long[] Value=A219326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219326.Bytes);
public long this[int i]=>Value[i];

public static A219326Inst Instance=new A219326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219327
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,48L,247L,370L,378L,407L,481L,518L,592L,629L,1360L,1547L,3075L,26027L,26933L,45018L,69781L,80487L,123823L,154791L,289835L,1920261L,2137616L,2716713L,3100883L,3480140L,3934896L,4179451L,4830936L,5218958L,11955168L,23203827L,80651025L,95738203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219327Inst : IEnumerable<long>
{
public static readonly long[] Value=A219327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219327.Bytes);
public long this[int i]=>Value[i];

public static A219327Inst Instance=new A219327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219328
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,3L,4L,7L,3L,3L,3L,3L,3L,3L,3L,3L,3L,9L,9L,9L,9L,9L,9L,18L,14L,6L,6L,6L,6L,6L,6L,6L,6L,6L,9L,9L,12L,19L,19L,19L,19L,19L,19L,19L,19L,5L,5L,5L,5L,5L,5L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219328Inst : IEnumerable<long>
{
public static readonly long[] Value=A219328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219328.Bytes);
public long this[int i]=>Value[i];

public static A219328Inst Instance=new A219328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219329
{
public static readonly long[] Value={ 5104L,5832L,9288L,9729L,10261L,10773L,12104L,12221L,12384L,14175L,17604L,17928L,19034L,20691L,21412L,21888L,24416L,24480L,28792L,29457L,30528L,31221L,32850L,34497L,35216L,36288L,38259L,39339L,39376L,39528L,40060L,40097L,40832L,40851L,41033L,41040L,41364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219329Inst : IEnumerable<long>
{
public static readonly long[] Value=A219329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219329.Bytes);
public long this[int i]=>Value[i];

public static A219329Inst Instance=new A219329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219330
{
public static readonly BigInteger[] Value={ 7L,69L,693L,6932L,69315L,693147L,6931472L,69314718L,693147181L,6931471806L,69314718056L,693147180560L,6931471805600L,69314718055995L,693147180559945L,6931471805599453L,69314718055994531L,693147180559945310L,6931471805599453094L,BigInteger.Parse("69314718055994530942") };
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
public class A219330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219330Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219330.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219330.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219330Inst Instance=new A219330Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219331
{
public static readonly long[] Value={ 1L,1L,1L,5L,6L,7L,8L,13L,28L,36L,45L,59L,92L,134L,186L,269L,375L,538L,761L,1080L,1520L,2157L,3060L,4339L,6181L,8750L,12394L,17554L,24912L,35322L,50066L,70957L,100596L,142665L,202278L,286790L,406520L,576347L,817142L,1158528L,1642461L,2328536L,3301283L,4680417L,6635688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219331Inst : IEnumerable<long>
{
public static readonly long[] Value=A219331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219331.Bytes);
public long this[int i]=>Value[i];

public static A219331Inst Instance=new A219331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219332
{
public static readonly long[] Value={ 12613L,15737L,43189L,56263L,72337L,76289L,77783L,84067L,102559L,108179L,109789L,109843L,109891L,115727L,115901L,120557L,125927L,127247L,135613L,149287L,155599L,161461L,169843L,172973L,178307L,179233L,184559L,188519L,192271L,198461L,206489L,218833L,220793L,221671L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219332Inst : IEnumerable<long>
{
public static readonly long[] Value=A219332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219332.Bytes);
public long this[int i]=>Value[i];

public static A219332Inst Instance=new A219332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219333
{
public static readonly long[] Value={ 78233L,94693L,162791L,334183L,432749L,675823L,679519L,700643L,731593L,754969L,845309L,1143067L,1200779L,1225157L,1427927L,1597721L,1616617L,1625539L,1830481L,1862593L,1917871L,1954349L,2037911L,2149453L,2220497L,2467243L,2483713L,2585953L,2620589L,2623343L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219333Inst : IEnumerable<long>
{
public static readonly long[] Value=A219333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219333.Bytes);
public long this[int i]=>Value[i];

public static A219333Inst Instance=new A219333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219334
{
public static readonly long[] Value={ 527377L,1360847L,1490743L,1725079L,2007661L,2722957L,2845463L,4303463L,4715099L,5950559L,6667159L,7008977L,9855107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219334Inst : IEnumerable<long>
{
public static readonly long[] Value=A219334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219334.Bytes);
public long this[int i]=>Value[i];

public static A219334Inst Instance=new A219334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219335
{
public static readonly long[] Value={ 3238481L,5216111L,5620861L,9208289L,32012327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219335Inst : IEnumerable<long>
{
public static readonly long[] Value=A219335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219335.Bytes);
public long this[int i]=>Value[i];

public static A219335Inst Instance=new A219335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219336
{
public static readonly long[] Value={ 1L,5L,3L,7L,9L,3L,7L,5L,5L,6L,5L,2L,0L,0L,3L,4L,9L,3L,1L,3L,6L,8L,1L,5L,8L,7L,1L,6L,0L,2L,6L,3L,2L,6L,8L,1L,5L,6L,0L,8L,6L,4L,5L,0L,8L,9L,8L,6L,3L,2L,1L,9L,6L,3L,3L,3L,2L,4L,6L,4L,3L,1L,1L,6L,3L,0L,0L,9L,2L,7L,6L,4L,1L,4L,2L,6L,1L,2L,9L,3L,4L,2L,5L,2L,3L,7L,7L,9L,3L,8L,0L,1L,3L,1L,4L,4L,2L,2L,9L,9L,5L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219336Inst : IEnumerable<long>
{
public static readonly long[] Value=A219336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219336.Bytes);
public long this[int i]=>Value[i];

public static A219336Inst Instance=new A219336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219337
{
public static readonly BigInteger[] Value={ 2L,6L,44L,741L,31574L,3488556L,1013594692L,781364430891L,1607468795310696L,8860626201053673385L,BigInteger.Parse("131236127104980388766388"),BigInteger.Parse("5233794723805693339116465076"),BigInteger.Parse("562910255724699183203714725974687"),BigInteger.Parse("163474435977817298005300626019111283694") };
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
public class A219337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219337Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219337.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219337.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219337Inst Instance=new A219337Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219338
{
public static readonly BigInteger[] Value={ 4L,16L,27L,3125L,3375L,65536L,823543L,3748096L,52521875L,285311670611L,7625597484987L,302875106592253L,1156831381426176L,66182427701415936L,BigInteger.Parse("827240261886336764177"),BigInteger.Parse("511324276025564512546607"),BigInteger.Parse("1978419655660313589123979"),BigInteger.Parse("281633339785852578930098176") };
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
public class A219338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219338Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219338.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219338.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219338Inst Instance=new A219338Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219339
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,5L,16L,49L,70L,168L,768L,3300L,7887L,15015L,48048L,292864L,1946516L,4934930L,14454726L,34918884L,141892608L,1100742656L,9732668946L,32773404950L,97848532782L,344699731090L,1020872973120L,5091106775040L,48608795688960L,586393249199550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219339Inst : IEnumerable<long>
{
public static readonly long[] Value=A219339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219339.Bytes);
public long this[int i]=>Value[i];

public static A219339Inst Instance=new A219339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219340
{
public static readonly long[] Value={ 361L,551L,703L,1007L,1273L,1691L,1843L,2033L,2071L,2183L,2413L,2603L,2641L,2701L,2831L,2923L,3071L,3173L,3293L,3743L,3781L,4033L,4313L,4351L,4541L,5143L,5263L,5513L,6023L,6031L,6401L,6403L,6623L,6631L,6821L,7081L,7141L,7363L,7391L,7543L,8303L,8341L,8531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219340Inst : IEnumerable<long>
{
public static readonly long[] Value=A219340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219340.Bytes);
public long this[int i]=>Value[i];

public static A219340Inst Instance=new A219340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219341
{
public static readonly long[] Value={ 2L,3L,0L,11L,397L,839L,1459L,2081L,7297L,53849L,3499L,70589L,792277L,20399L,11173873L,929057L,232591L,6782759L,5834299L,26812151L,40269673L,88529891L,368454343L,616767917L,1167319801L,709939943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219341Inst : IEnumerable<long>
{
public static readonly long[] Value=A219341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219341.Bytes);
public long this[int i]=>Value[i];

public static A219341Inst Instance=new A219341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219342
{
public static readonly BigInteger[] Value={ 1L,1L,2L,33L,939L,101175L,26230876L,21032800086L,48319626581926L,319633065306440005L,BigInteger.Parse("6299181667747767151873"),BigInteger.Parse("359980854813102654362716667"),BigInteger.Parse("60552379844778585329083453881153"),BigInteger.Parse("30125614945616982039421647789900799744"),BigInteger.Parse("43971297878008421196972637327280065832735828") };
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
public class A219342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219342Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219342.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219342.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219342Inst Instance=new A219342Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219343
{
public static readonly BigInteger[] Value={ 1L,1L,32L,3183L,650929L,226009218L,119298668857L,89086101638412L,89480710389500666L,BigInteger.Parse("116491795770107486363"),BigInteger.Parse("191172400354899371561288"),BigInteger.Parse("387419202671209086703674709"),BigInteger.Parse("956322827450633453264262285623"),BigInteger.Parse("2859815748552720894795327258080881"),BigInteger.Parse("10430012061189048036456303441601971435") };
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
public class A219343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219343Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219343.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219343.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219343Inst Instance=new A219343Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219344
{
public static readonly BigInteger[] Value={ 1L,2L,14L,238L,6636L,273354L,15920706L,1292724636L,146453417488L,23281175674462L,5218509363479914L,1654434832566803018L,BigInteger.Parse("743482275590960686464"),BigInteger.Parse("474454676244907785390480"),BigInteger.Parse("430533281246889283353506596"),BigInteger.Parse("556106522019612061492965277720"),BigInteger.Parse("1023417606325146596408758881753232") };
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
public class A219344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219344Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219344.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219344.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219344Inst Instance=new A219344Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219345
{
public static readonly BigInteger[] Value={ 1L,3L,27L,579L,20175L,1040841L,76289391L,7835014803L,1126950503895L,227980114864785L,65140785692441331L,BigInteger.Parse("26367726770770632279"),BigInteger.Parse("15152326633140931387863"),BigInteger.Parse("12381287437737118684516329"),BigInteger.Parse("14402892135028851541909453959"),BigInteger.Parse("23874983932956218191360201222107") };
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
public class A219345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219345Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219345.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219345.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219345Inst Instance=new A219345Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219346
{
public static readonly BigInteger[] Value={ 4578627124156945861L,BigInteger.Parse("57406119388190085241"),BigInteger.Parse("71879404939979986441"),BigInteger.Parse("98654983210791303661"),BigInteger.Parse("109509947374633729561"),BigInteger.Parse("153653468307592928221"),BigInteger.Parse("213717603347521018201"),BigInteger.Parse("541537521095562280381"),BigInteger.Parse("608114634633795825901"),BigInteger.Parse("721729926215346550321"),BigInteger.Parse("1062575800959998723581") };
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
public class A219346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219346Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A219346.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A219346.Bytes);
public BigInteger this[int i]=>Value[i];

public static A219346Inst Instance=new A219346Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219347
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,2L,1L,1L,1L,3L,2L,2L,1L,1L,1L,4L,3L,2L,2L,1L,1L,1L,5L,4L,3L,2L,2L,1L,1L,1L,6L,5L,4L,3L,2L,2L,1L,1L,1L,8L,6L,5L,4L,3L,2L,2L,1L,1L,1L,10L,8L,6L,5L,4L,3L,2L,2L,1L,1L,1L,12L,10L,8L,6L,5L,4L,3L,2L,2L,1L,1L,1L,15L,12L,10L,8L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219347Inst : IEnumerable<long>
{
public static readonly long[] Value=A219347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219347.Bytes);
public long this[int i]=>Value[i];

public static A219347Inst Instance=new A219347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219348
{
public static readonly long[] Value={ 2L,2L,8L,35L,247L,2482L,39967L,1086910L,54162362L,4835495936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219348Inst : IEnumerable<long>
{
public static readonly long[] Value=A219348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219348.Bytes);
public long this[int i]=>Value[i];

public static A219348Inst Instance=new A219348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219349
{
public static readonly long[] Value={ 3L,3L,8L,15L,27L,46L,76L,122L,190L,287L,421L,601L,837L,1140L,1522L,1996L,2576L,3277L,4115L,5107L,6271L,7626L,9192L,10990L,13042L,15371L,18001L,20957L,24265L,27952L,32046L,36576L,41572L,47065L,53087L,59671L,66851L,74662L,83140L,92322L,102246L,112951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219349Inst : IEnumerable<long>
{
public static readonly long[] Value=A219349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219349.Bytes);
public long this[int i]=>Value[i];

public static A219349Inst Instance=new A219349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219350
{
public static readonly long[] Value={ 4L,4L,15L,35L,81L,174L,364L,740L,1459L,2778L,5105L,9069L,15615L,26129L,42600L,67827L,105680L,161425L,242124L,357122L,518634L,742446L,1048745L,1463094L,2017569L,2752076L,3715867L,4969275L,6585689L,8653791L,11280078L,14591693L,18739590L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219350Inst : IEnumerable<long>
{
public static readonly long[] Value=A219350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219350.Bytes);
public long this[int i]=>Value[i];

public static A219350Inst Instance=new A219350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219351
{
public static readonly long[] Value={ 5L,5L,27L,81L,247L,689L,1880L,4994L,12917L,32349L,78303L,183394L,416639L,920413L,1981261L,4162372L,8546000L,17167884L,33780382L,65167959L,123374673L,229412791L,419339608L,754065406L,1334958446L,2328338561L,4003430115L,6790454936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219351Inst : IEnumerable<long>
{
public static readonly long[] Value=A219351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219351.Bytes);
public long this[int i]=>Value[i];

public static A219351Inst Instance=new A219351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219352
{
public static readonly long[] Value={ 6L,6L,46L,174L,689L,2482L,8744L,30122L,101738L,333863L,1060075L,3255831L,9692064L,28025330L,78861460L,216288179L,578998244L,1514942606L,3879328902L,9733779695L,23957650511L,57898956666L,137513675891L,321232670338L,738605315409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219352Inst : IEnumerable<long>
{
public static readonly long[] Value=A219352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219352.Bytes);
public long this[int i]=>Value[i];

public static A219352Inst Instance=new A219352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219353
{
public static readonly long[] Value={ 7L,7L,76L,364L,1880L,8744L,39967L,180591L,808247L,3528186L,14892204L,60674978L,239213184L,915248981L,3405898937L,12347166730L,43666667442L,150852326689L,509698451147L,1686262966158L,5467965888270L,17394300884165L,54328408742819L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219353Inst : IEnumerable<long>
{
public static readonly long[] Value=A219353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219353.Bytes);
public long this[int i]=>Value[i];

public static A219353Inst Instance=new A219353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219354
{
public static readonly long[] Value={ 2L,2L,2L,3L,2L,3L,4L,3L,3L,4L,5L,4L,8L,4L,5L,6L,5L,15L,15L,5L,6L,7L,6L,27L,35L,27L,6L,7L,8L,7L,46L,81L,81L,46L,7L,8L,9L,8L,76L,174L,247L,174L,76L,8L,9L,10L,9L,122L,364L,689L,689L,364L,122L,9L,10L,11L,10L,190L,740L,1880L,2482L,1880L,740L,190L,10L,11L,12L,11L,287L,1459L,4994L,8744L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219354Inst : IEnumerable<long>
{
public static readonly long[] Value=A219354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219354.Bytes);
public long this[int i]=>Value[i];

public static A219354Inst Instance=new A219354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219355
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,40L,90L,189L,400L,828L,1690L,3421L,6864L,13676L,27090L,53385L,104736L,204680L,398610L,773889L,1498320L,2893632L,5575658L,10721381L,20577072L,39424100L,75412714L,144040437L,274743952L,523380516L,995841570L,1892692817L,3593501760L,6816026448L,12916524962L,24455934265L,46266661008L,87461480600L,165214492666L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219355Inst : IEnumerable<long>
{
public static readonly long[] Value=A219355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219355.Bytes);
public long this[int i]=>Value[i];

public static A219355Inst Instance=new A219355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A219356
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,3L,1L,4L,5L,1L,5L,9L,16L,1L,6L,14L,49L,1L,7L,20L,92L,70L,1L,8L,27L,153L,204L,168L,1L,9L,35L,235L,405L,738L,768L,1L,10L,44L,341L,715L,1815L,3300L,1L,11L,54L,474L,1166L,3630L,9460L,7887L,1L,12L,65L,637L,1794L,6578L,21307L,28743L,15015L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A219356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A219356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A219356Inst : IEnumerable<long>
{
public static readonly long[] Value=A219356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A219356.Bytes);
public long this[int i]=>Value[i];

public static A219356Inst Instance=new A219356Inst();

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