using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A274562
{
public static readonly long[] Value={ 9L,10L,11L,12L,14L,17L,38L,92L,168L,170L,248L,752L,988L,2528L,2808L,8648L,12008L,34688L,63248L,117808L,526688L,531968L,820808L,1292768L,1495688L,2095208L,2112512L,3477608L,4495808L,8419328L,12026888L,13192768L,16102808L,26347688L,29322008L,33653888L,169371008L,173631608L,293947648L,537116672L,883927808L,2147975168L,2493705728L,5556840416L,13092865928L,42783299288L,69662739968L,80999455688L,217898810368L,546409576448L,1020401174528L,1081071376208L,1282330216448L,1473186024448L,1577975316488L,1608005456768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274562Inst : IEnumerable<long>
{
public static readonly long[] Value=A274562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274562.Bytes);
public long this[int i]=>Value[i];

public static A274562Inst Instance=new A274562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274563
{
public static readonly long[] Value={ 15L,208L,6976L,8415L,31815L,351351L,2077696L,20487159L,159030135L,536559616L,2586415095L,137433972736L,2199003332608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274563Inst : IEnumerable<long>
{
public static readonly long[] Value=A274563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274563.Bytes);
public long this[int i]=>Value[i];

public static A274563Inst Instance=new A274563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274564
{
public static readonly long[] Value={ 10L,11L,15L,19L,24L,33L,105L,33705L,33624064L,2199041081344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274564Inst : IEnumerable<long>
{
public static readonly long[] Value=A274564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274564.Bytes);
public long this[int i]=>Value[i];

public static A274564Inst Instance=new A274564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274565
{
public static readonly long[] Value={ 14L,176L,1376L,3230L,3770L,6848L,114256L,125696L,544310L,561824L,740870L,2075648L,4199030L,4607296L,8436950L,33468416L,134045696L,199272950L,624032630L,1113445430L,1550860550L,85905593344L,2199001235456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274565Inst : IEnumerable<long>
{
public static readonly long[] Value=A274565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274565.Bytes);
public long this[int i]=>Value[i];

public static A274565Inst Instance=new A274565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274566
{
public static readonly long[] Value={ 11L,12L,14L,22L,40L,42L,46L,154L,190L,2656L,6490L,44650L,318250L,1360810L,1503370L,1788490L,3214090L,103712410L,3915380170L,6077111050L,9796360330L,10828121356L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274566Inst : IEnumerable<long>
{
public static readonly long[] Value=A274566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274566.Bytes);
public long this[int i]=>Value[i];

public static A274566Inst Instance=new A274566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274567
{
public static readonly long[] Value={ 3L,81L,51L,291L,1251L,339L,62499L,1971L,5201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274567Inst : IEnumerable<long>
{
public static readonly long[] Value=A274567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274567.Bytes);
public long this[int i]=>Value[i];

public static A274567Inst Instance=new A274567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274568
{
public static readonly long[] Value={ 2L,0L,2L,3L,7L,2L,3L,2L,9L,2L,3L,13L,2L,7L,3L,2L,15L,2L,3L,19L,2L,9L,3L,7L,2L,21L,2L,3L,27L,2L,13L,3L,2L,7L,9L,2L,3L,33L,2L,15L,3L,2L,7L,2L,3L,37L,2L,9L,19L,3L,13L,2L,39L,2L,3L,7L,49L,2L,21L,3L,2L,9L,15L,2L,3L,7L,2L,3L,2L,13L,27L,51L,2L,3L,55L,2L,7L,9L,3L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274568Inst : IEnumerable<long>
{
public static readonly long[] Value=A274568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274568.Bytes);
public long this[int i]=>Value[i];

public static A274568Inst Instance=new A274568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274569
{
public static readonly long[] Value={ 1L,1L,-1L,-2L,2L,9L,1L,-29L,-24L,88L,153L,-234L,-796L,327L,3509L,1301L,-13924L,-16511L,47366L,109639L,-121886L,-583921L,79027L,2691465L,1808431L,-10775705L,-16965876L,35686874L,107103382L,-77820607L,-560120299L,-95094380L,2536045800L,2521002564L,-9832805334L,-19928899203L,29983217002L,118838292930L,-44109504096L,-600237397739L,-285632368107L,2622720919077L,3530864633371L,-9611558966277L,-24857829812388L,25472208656701L,140445352832736L,-5891793579597L,-680872708032455L,-537359624615144L,2838471301330439L,4957200244969051L,-9600812793387365L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274569Inst : IEnumerable<long>
{
public static readonly long[] Value=A274569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274569.Bytes);
public long this[int i]=>Value[i];

public static A274569Inst Instance=new A274569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274570
{
public static readonly long[] Value={ 1L,1L,1L,7L,2L,1L,127L,20L,3L,1L,4377L,470L,39L,4L,1L,245481L,19912L,1125L,64L,5L,1L,20391523L,1326382L,56505L,2188L,95L,6L,1L,2354116899L,127677580L,4354923L,127056L,3755L,132L,7L,1L,360734454993L,16767030632L,476265591L,11117244L,247465L,5922L,175L,8L,1L,70865037282673L,2880746218304L,70056231213L,1360983976L,24228925L,436632L,8785L,224L,9L,1L,17367953099244051L,627213971899610L,13329387478113L,221585119536L,3281909155L,47290506L,716457L,12440L,279L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274570Inst : IEnumerable<long>
{
public static readonly long[] Value=A274570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274570.Bytes);
public long this[int i]=>Value[i];

public static A274570Inst Instance=new A274570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274571
{
public static readonly BigInteger[] Value={ 1L,1L,7L,127L,4377L,245481L,20391523L,2354116899L,360734454993L,70865037282673L,17367953099244051L,5195706189463681299L,BigInteger.Parse("1863485648739527246569"),BigInteger.Parse("789370246456579516316121"),BigInteger.Parse("389929989984983783920348611"),BigInteger.Parse("222178771969671609391720410691"),BigInteger.Parse("144648509476124539709343154760897"),BigInteger.Parse("106712830948451223242311469280356609"),BigInteger.Parse("88557950557114913966623605248882438755"),BigInteger.Parse("82132537612235618834557329353828430430755") };
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
public class A274571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274571Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274571.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274571.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274571Inst Instance=new A274571Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274572
{
public static readonly BigInteger[] Value={ 1L,2L,20L,470L,19912L,1326382L,127677580L,16767030632L,2880746218304L,627213971899610L,168767535712912684L,BigInteger.Parse("54994347890521005100"),BigInteger.Parse("21342142821229037730064"),BigInteger.Parse("9726400286221416303901358"),BigInteger.Parse("5143644030714149522751534524"),BigInteger.Parse("3124088412968372614077895431788"),BigInteger.Parse("2159818183532141245447039295746240"),BigInteger.Parse("1686295004858842334963772859214802354"),BigInteger.Parse("1476540037893212558044217633785452773068"),BigInteger.Parse("1440964034588041764141738802548853847618732") };
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
public class A274572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274572Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274572.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274572.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274572Inst Instance=new A274572Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274573
{
public static readonly BigInteger[] Value={ 1L,3L,39L,1125L,56505L,4354923L,476265591L,70056231213L,13329387478113L,3184105899176739L,932720103991595919L,BigInteger.Parse("328710383679927689157"),BigInteger.Parse("137188135970104212440721"),BigInteger.Parse("66909975066823379752742835"),BigInteger.Parse("37706189062081696231083478647"),BigInteger.Parse("24312515006613477431766856702797"),BigInteger.Parse("17784145956730483348850500758855969"),BigInteger.Parse("14647274671009402833580157237962722147"),BigInteger.Parse("13492886769176913829412675003231182928079") };
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
public class A274573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274573Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274573.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274573.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274573Inst Instance=new A274573Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274574
{
public static readonly BigInteger[] Value={ 1L,2L,39L,2188L,247465L,47290506L,13732594855L,5645761143968L,3124313624563281L,2240929551882269890L,BigInteger.Parse("2023001689428835457551"),BigInteger.Parse("2245340983227461222262600"),BigInteger.Parse("3005921392102922941037743561"),BigInteger.Parse("4777188534537036418050441999458"),BigInteger.Parse("8892651921874938986718539648539335"),BigInteger.Parse("19167346139929272962512547586833106016"),BigInteger.Parse("47363669252787891219004826832547428944065"),BigInteger.Parse("133017373943189884985366059167726505579520322"),BigInteger.Parse("421334607602498277189468756234637306051458074191"),BigInteger.Parse("1495034827615578030423476599123008111000477082402040"),BigInteger.Parse("5906697677063490360959940664316005473632429506949424681") };
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
public class A274574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274574Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274574.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274574.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274574Inst Instance=new A274574Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274575
{
public static readonly long[] Value={ 0L,-1L,1L,-2L,0L,0L,2L,-3L,-1L,-1L,1L,-1L,1L,1L,3L,-4L,-2L,-2L,0L,-2L,0L,0L,2L,-2L,0L,0L,2L,0L,2L,2L,4L,-5L,-3L,-3L,-1L,-3L,-1L,-1L,1L,-3L,-1L,-1L,1L,-1L,1L,1L,3L,-3L,-1L,-1L,1L,-1L,1L,1L,3L,-1L,1L,1L,3L,1L,3L,3L,5L,-6L,-4L,-4L,-2L,-4L,-2L,-2L,0L,-4L,-2L,-2L,0L,-2L,0L,0L,2L,-4L,-2L,-2L,0L,-2L,0L,0L,2L,-2L,0L,0L,2L,0L,2L,2L,4L,-4L,-2L,-2L,0L,-2L,0L,0L,2L,-2L,0L,0L,2L,0L,2L,2L,4L,-2L,0L,0L,2L,0L,2L,2L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274575Inst : IEnumerable<long>
{
public static readonly long[] Value=A274575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274575.Bytes);
public long this[int i]=>Value[i];

public static A274575Inst Instance=new A274575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274576
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,1L,0L,2L,1L,2L,0L,3L,1L,3L,0L,4L,2L,4L,1L,5L,2L,5L,0L,6L,3L,6L,1L,7L,3L,7L,0L,8L,4L,8L,2L,9L,4L,9L,1L,10L,5L,10L,2L,11L,5L,11L,0L,12L,6L,12L,3L,13L,6L,13L,1L,14L,7L,14L,3L,15L,7L,15L,0L,16L,8L,16L,4L,17L,8L,17L,2L,18L,9L,18L,4L,19L,9L,19L,1L,20L,10L,20L,5L,21L,10L,21L,2L,22L,11L,22L,5L,23L,11L,23L,0L,24L,12L,24L,6L,25L,12L,25L,3L,26L,13L,26L,6L,27L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274576Inst : IEnumerable<long>
{
public static readonly long[] Value=A274576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274576.Bytes);
public long this[int i]=>Value[i];

public static A274576Inst Instance=new A274576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274577
{
public static readonly long[] Value={ 18L,72L,98L,162L,242L,245L,288L,392L,490L,605L,648L,722L,882L,968L,980L,1058L,1152L,1210L,1225L,1458L,1568L,1805L,1922L,1960L,2178L,2205L,2420L,2450L,2592L,2645L,2888L,3025L,3528L,3610L,3698L,3872L,3920L,4232L,4410L,4418L,4608L,4693L,4802L,4805L,4840L,4900L,5290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274577Inst : IEnumerable<long>
{
public static readonly long[] Value=A274577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274577.Bytes);
public long this[int i]=>Value[i];

public static A274577Inst Instance=new A274577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274578
{
public static readonly long[] Value={ 2305L,2629L,4117L,7060L,37444L,46081L,113320L,208545L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274578Inst : IEnumerable<long>
{
public static readonly long[] Value=A274578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274578.Bytes);
public long this[int i]=>Value[i];

public static A274578Inst Instance=new A274578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274579
{
public static readonly long[] Value={ 0L,1L,7L,27L,540L,2002L,10660L,39501L,779247L,2887450L,15372280L,56960982L,1123674201L,4163701465L,22166817667L,82137697110L,1620337419162L,6004054625647L,31964535704101L,118442502272205L,2336525434757970L,8657842606482076L,46092838318496542L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274579Inst : IEnumerable<long>
{
public static readonly long[] Value=A274579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274579.Bytes);
public long this[int i]=>Value[i];

public static A274579Inst Instance=new A274579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274580
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,1L,0L,-1L,-2L,-3L,-4L,-5L,-6L,-7L,-8L,2L,1L,0L,-1L,-2L,-3L,-4L,-5L,-6L,-7L,3L,2L,1L,0L,-1L,-2L,-3L,-4L,-5L,-6L,4L,3L,2L,1L,0L,-1L,-2L,-3L,-4L,-5L,5L,4L,3L,2L,1L,0L,-1L,-2L,-3L,-4L,6L,5L,4L,3L,2L,1L,0L,-1L,-2L,-3L,7L,6L,5L,4L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274580Inst : IEnumerable<long>
{
public static readonly long[] Value=A274580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274580.Bytes);
public long this[int i]=>Value[i];

public static A274580Inst Instance=new A274580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274581
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,1L,2L,1L,0L,1L,3L,3L,1L,0L,1L,5L,7L,4L,1L,0L,1L,7L,14L,12L,5L,1L,0L,1L,11L,30L,33L,19L,6L,1L,0L,1L,15L,57L,84L,62L,27L,7L,1L,0L,1L,23L,119L,222L,204L,108L,37L,8L,1L,0L,1L,31L,224L,545L,627L,409L,169L,48L,9L,1L,0L,1L,47L,460L,1425L,2006L,1558L,763L,254L,61L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274581Inst : IEnumerable<long>
{
public static readonly long[] Value=A274581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274581.Bytes);
public long this[int i]=>Value[i];

public static A274581Inst Instance=new A274581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274582
{
public static readonly long[] Value={ 1L,1L,4L,10L,24L,51L,109L,222L,452L,890L,1732L,3298L,6204L,11470L,20970L,37842L,67572L,119368L,208943L,362389L,623438L,1064061L,1802976L,3033711L,5071418L,8424788L,13913192L,22847028L,37315678L,60631940L,98030644L,157743554L,252671288L,402944731L,639871871L,1011956958L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274582Inst : IEnumerable<long>
{
public static readonly long[] Value=A274582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274582.Bytes);
public long this[int i]=>Value[i];

public static A274582Inst Instance=new A274582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274583
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,9L,10L,13L,16L,17L,21L,25L,26L,31L,36L,37L,43L,49L,50L,57L,64L,65L,73L,81L,82L,91L,100L,101L,111L,121L,122L,133L,144L,145L,157L,169L,170L,183L,196L,197L,211L,225L,226L,241L,256L,257L,273L,289L,290L,307L,324L,325L,343L,361L,362L,381L,400L,401L,421L,441L,442L,463L,484L,485L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274583Inst : IEnumerable<long>
{
public static readonly long[] Value=A274583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274583.Bytes);
public long this[int i]=>Value[i];

public static A274583Inst Instance=new A274583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274584
{
public static readonly long[] Value={ 4L,8L,9L,10L,14L,15L,16L,18L,20L,21L,22L,26L,28L,30L,32L,33L,34L,35L,38L,39L,40L,42L,45L,51L,52L,54L,60L,62L,63L,65L,66L,72L,74L,75L,76L,82L,93L,94L,98L,105L,106L,111L,112L,119L,121L,122L,123L,124L,132L,135L,136L,140L,142L,144L,145L,152L,156L,158L,160L,172L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274584Inst : IEnumerable<long>
{
public static readonly long[] Value=A274584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274584.Bytes);
public long this[int i]=>Value[i];

public static A274584Inst Instance=new A274584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274585
{
public static readonly long[] Value={ 3L,10L,58L,178L,558L,1255L,2532L,4786L,7804L,12292L,18966L,28540L,39117L,56107L,73924L,96010L,124704L,164815L,203316L,258706L,311296L,377998L,458862L,560827L,649011L,775336L,908974L,1056604L,1215174L,1428283L,1607964L,1866103L,2111587L,2399647L,2694115L,3040309L,3356544L,3811501L,4253191L,4720222L,5180589L,5806813L,6325035L,7036081L,7691035L,8392174L,9180471L,10136431L,10894698L,11930983L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274585Inst : IEnumerable<long>
{
public static readonly long[] Value=A274585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274585.Bytes);
public long this[int i]=>Value[i];

public static A274585Inst Instance=new A274585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274586
{
public static readonly long[] Value={ 3L,21L,132L,429L,1272L,2826L,5640L,10461L,17094L,26847L,41046L,61041L,84051L,118974L,157209L,204393L,264855L,346524L,428880L,541683L,654087L,793611L,961179L,1167468L,1357515L,1615209L,1891980L,2198019L,2530275L,2957808L,3341439L,3860652L,4371006L,4959636L,5572167L,6277722L,6950064L,7859406L,8763780L,9722571L,10687506L,11934912L,13029834L,14450598L,15805026L,17250795L,18863397L,20763204L,22372839L,24450474L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274586Inst : IEnumerable<long>
{
public static readonly long[] Value=A274586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274586.Bytes);
public long this[int i]=>Value[i];

public static A274586Inst Instance=new A274586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274587
{
public static readonly BigInteger[] Value={ 1L,23L,176L,5968L,888778L,30192278L,233944673L,7947232183L,1183597668523L,40207478867501L,311547395822378L,10583440358908726L,1576213585538112676L,BigInteger.Parse("53544862512524597468"),BigInteger.Parse("414892028679967914251"),BigInteger.Parse("14094115694115827467213"),BigInteger.Parse("2099065698850118586101173") };
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
public class A274587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274587Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274587.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274587.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274587Inst Instance=new A274587Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274588
{
public static readonly BigInteger[] Value={ 1L,8L,638L,6931L,572671L,6223778L,514257668L,5588945461L,461802812941L,5018866799948L,414698411763098L,4506936797407591L,372398711960448811L,4047224225205216518L,BigInteger.Parse("334413628642071268928"),BigInteger.Parse("3634402847297487025321"),BigInteger.Parse("300303066121868039048281") };
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
public class A274588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274588Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274588.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274588.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274588Inst Instance=new A274588Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274589
{
public static readonly long[] Value={ 2L,3L,13L,17L,19L,29L,37L,41L,43L,53L,61L,67L,73L,89L,97L,101L,103L,109L,113L,131L,137L,139L,149L,157L,163L,173L,181L,193L,197L,199L,211L,229L,233L,241L,251L,257L,269L,277L,281L,283L,293L,307L,311L,313L,317L,331L,337L,349L,353L,367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274589Inst : IEnumerable<long>
{
public static readonly long[] Value=A274589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274589.Bytes);
public long this[int i]=>Value[i];

public static A274589Inst Instance=new A274589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274590
{
public static readonly long[] Value={ 9L,19L,33L,35L,73L,99L,145L,161L,163L,195L,243L,393L,483L,513L,577L,721L,723L,1153L,1763L,2177L,2305L,2593L,4803L,5185L,5833L,6273L,6963L,7057L,7395L,8713L,9523L,9603L,10083L,12483L,13923L,14113L,15875L,17425L,17673L,19043L,19601L,20737L,26243L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274590Inst : IEnumerable<long>
{
public static readonly long[] Value=A274590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274590.Bytes);
public long this[int i]=>Value[i];

public static A274590Inst Instance=new A274590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274591
{
public static readonly long[] Value={ 73L,22049L,90707201L,4359889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274591Inst : IEnumerable<long>
{
public static readonly long[] Value=A274591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274591.Bytes);
public long this[int i]=>Value[i];

public static A274591Inst Instance=new A274591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274592
{
public static readonly BigInteger[] Value={ 3L,31L,1011L,32119L,1020995L,32454831L,1031656755L,32793751175L,1042430160131L,33136210400191L,1053316070160371L,33482245865136407L,1064315659783638083L,BigInteger.Parse("33831894915991351119"),BigInteger.Parse("1075430116136187973171"),BigInteger.Parse("34185195288781394584359"),BigInteger.Parse("1086660638750543922795523") };
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
public class A274592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274592Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274592.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274592.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274592Inst Instance=new A274592Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274593
{
public static readonly long[] Value={ 0L,1L,2L,4L,4L,7L,6L,11L,8L,13L,10L,18L,12L,19L,14L,26L,16L,25L,18L,32L,20L,31L,22L,41L,24L,37L,26L,46L,28L,43L,30L,57L,32L,49L,34L,60L,36L,55L,38L,71L,40L,61L,42L,74L,44L,67L,46L,88L,48L,73L,50L,88L,52L,79L,54L,101L,56L,85L,58L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274593Inst : IEnumerable<long>
{
public static readonly long[] Value=A274593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274593.Bytes);
public long this[int i]=>Value[i];

public static A274593Inst Instance=new A274593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274594
{
public static readonly long[] Value={ 1L,2L,5L,12L,29L,64L,139L,286L,582L,1148L,2227L,4234L,7950L,14692L,26842L,48438L,86509L,152902L,267783L,464766L,800095L,1366512L,2316840L,3900502L,6523432L,10841282L,17909533L,29416966L,48055443L,78093926L,126276743L,203211038L,325518314L,519138982L,824414851L,1303853212L,2053981256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274594Inst : IEnumerable<long>
{
public static readonly long[] Value=A274594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274594.Bytes);
public long this[int i]=>Value[i];

public static A274594Inst Instance=new A274594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274595
{
public static readonly long[] Value={ 0L,4L,12L,24L,40L,48L,60L,68L,72L,84L,104L,112L,132L,140L,144L,148L,176L,180L,192L,204L,216L,220L,252L,264L,276L,284L,312L,320L,324L,364L,372L,384L,392L,396L,408L,420L,428L,444L,456L,468L,472L,480L,528L,544L,588L,600L,612L,624L,636L,644L,648L,660L,684L,688L,708L,720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274595Inst : IEnumerable<long>
{
public static readonly long[] Value=A274595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274595.Bytes);
public long this[int i]=>Value[i];

public static A274595Inst Instance=new A274595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274596
{
public static readonly long[] Value={ 1L,3L,7L,19L,44L,98L,213L,448L,918L,1832L,3584L,6882L,13012L,24220L,44480L,80678L,144697L,256775L,451305L,786008L,1357414L,2325540L,3954366L,6676369L,11196599L,18657454L,30901434L,50884452L,83327163L,135733071L,219978688L,354780782L,569519349L,910130189L,1448166991L,2294680459L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274596Inst : IEnumerable<long>
{
public static readonly long[] Value=A274596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274596.Bytes);
public long this[int i]=>Value[i];

public static A274596Inst Instance=new A274596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274597
{
public static readonly long[] Value={ 1L,4L,10L,28L,68L,158L,350L,750L,1559L,3170L,6292L,12252L,23445L,44164L,81995L,150288L,272150L,487388L,863887L,1516592L,2638648L,4552488L,7792566L,13239698L,22336630L,37433466L,62337628L,103186612L,169824540L,277967860L,452594316L,733229626L,1182159039L,1897140990L,3031012912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274597Inst : IEnumerable<long>
{
public static readonly long[] Value=A274597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274597.Bytes);
public long this[int i]=>Value[i];

public static A274597Inst Instance=new A274597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274598
{
public static readonly long[] Value={ 1L,5L,14L,40L,103L,247L,567L,1252L,2668L,5539L,11214L,22247L,43300L,82871L,156152L,290202L,532430L,965395L,1731351L,3073660L,5404984L,9420512L,16282463L,27922063L,47527430L,80331385L,134873275L,225015223L,373141724L,615224276L,1008792896L,1645443771L,2670372299L,4312780664L,6933014899L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274598Inst : IEnumerable<long>
{
public static readonly long[] Value=A274598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274598.Bytes);
public long this[int i]=>Value[i];

public static A274598Inst Instance=new A274598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274599
{
public static readonly long[] Value={ 1L,6L,19L,56L,152L,378L,898L,2042L,4476L,9526L,19740L,39978L,79342L,154650L,296489L,560022L,1043404L,1919708L,3491081L,6280514L,11185375L,19734004L,34509347L,59847208L,102976946L,175877782L,298279841L,502496682L,841161007L,1399559416L,2315201903L,3808746574L,6232651705L,10147431024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274599Inst : IEnumerable<long>
{
public static readonly long[] Value=A274599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274599.Bytes);
public long this[int i]=>Value[i];

public static A274599Inst Instance=new A274599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274600
{
public static readonly BigInteger[] Value={ 1L,-1L,1L,2L,7L,59L,616L,6992L,90847L,1352549L,22591681L,417527582L,8465505412L,186906393764L,4463901355096L,114672825810272L,3153127461349327L,92405864554182329L,2875362251645606611L,BigInteger.Parse("94680648376734042062"),BigInteger.Parse("3289274269898822961967"),BigInteger.Parse("120235993277078434540619") };
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
public class A274600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274600Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274600.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274600.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274600Inst Instance=new A274600Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274601
{
public static readonly long[] Value={ 1L,4L,3L,2L,13L,12L,11L,10L,9L,8L,7L,6L,5L,40L,39L,38L,37L,36L,35L,34L,33L,32L,31L,30L,29L,28L,27L,26L,25L,24L,23L,22L,21L,20L,19L,18L,17L,16L,15L,14L,121L,120L,119L,118L,117L,116L,115L,114L,113L,112L,111L,110L,109L,108L,107L,106L,105L,104L,103L,102L,101L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274601Inst : IEnumerable<long>
{
public static readonly long[] Value=A274601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274601.Bytes);
public long this[int i]=>Value[i];

public static A274601Inst Instance=new A274601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274602
{
public static readonly long[] Value={ 0L,1L,1L,2L,5L,2L,3L,11L,9L,3L,4L,19L,20L,13L,4L,5L,29L,35L,29L,17L,5L,6L,41L,54L,51L,38L,21L,6L,7L,55L,77L,79L,67L,47L,25L,7L,8L,71L,104L,113L,104L,83L,56L,29L,8L,9L,89L,135L,153L,149L,129L,99L,65L,33L,9L,10L,109L,170L,199L,202L,185L,154L,115L,74L,37L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274602Inst : IEnumerable<long>
{
public static readonly long[] Value=A274602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274602.Bytes);
public long this[int i]=>Value[i];

public static A274602Inst Instance=new A274602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274603
{
public static readonly BigInteger[] Value={ 45L,4455L,436590L,42781410L,4192141635L,410787098865L,40252943547180L,3944377680524820L,386508759747885225L,BigInteger.Parse("37873914077612227275"),BigInteger.Parse("3711257070846250387770"),BigInteger.Parse("363665319028854925774230"),BigInteger.Parse("35635490007756936475486815"),BigInteger.Parse("3491914355441150919671933685") };
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
public class A274603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274603Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274603.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274603.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274603Inst Instance=new A274603Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274604
{
public static readonly long[] Value={ 0L,1L,0L,2L,3L,3L,1L,4L,3L,5L,5L,6L,8L,7L,4L,8L,9L,9L,7L,10L,10L,11L,10L,12L,10L,13L,14L,14L,17L,15L,11L,16L,15L,17L,17L,18L,20L,19L,16L,20L,20L,21L,20L,22L,23L,23L,21L,24L,26L,25L,22L,26L,25L,27L,27L,28L,25L,29L,31L,30L,34L,31L,26L,32L,33L,33L,31L,34L,34L,35L,34L,36L,34L,37L,38L,38L,41L,39L,35L,40L,40L,41L,40L,42L,43L,43L,41L,44L,43L,45L,45L,46L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274604Inst : IEnumerable<long>
{
public static readonly long[] Value=A274604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274604.Bytes);
public long this[int i]=>Value[i];

public static A274604Inst Instance=new A274604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274605
{
public static readonly long[] Value={ 3L,6L,8L,14L,60L,72L,216L,328L,361L,23268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274605Inst : IEnumerable<long>
{
public static readonly long[] Value=A274605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274605.Bytes);
public long this[int i]=>Value[i];

public static A274605Inst Instance=new A274605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274606
{
public static readonly long[] Value={ 1L,10L,2L,11L,5L,12L,60L,3L,30L,6L,31L,15L,32L,160L,4L,20L,21L,210L,7L,70L,14L,71L,35L,72L,360L,8L,40L,41L,410L,82L,16L,80L,81L,810L,9L,90L,18L,91L,45L,92L,460L,23L,230L,46L,231L,115L,22L,110L,55L,25L,50L,51L,510L,17L,170L,34L,171L,85L,172L,860L,43L,430L,86L,431L,215L,42L,211L,105L,100L,101L,1010L,202L,200L,201L,2010L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274606Inst : IEnumerable<long>
{
public static readonly long[] Value=A274606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274606.Bytes);
public long this[int i]=>Value[i];

public static A274606Inst Instance=new A274606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274607
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,8L,7L,10L,12L,16L,11L,15L,20L,24L,32L,13L,25L,30L,40L,48L,64L,17L,35L,50L,60L,80L,96L,128L,19L,55L,75L,100L,120L,160L,192L,256L,23L,77L,125L,150L,200L,240L,320L,384L,512L,29L,121L,175L,250L,300L,400L,480L,640L,768L,1024L,31L,143L,275L,375L,500L,600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274607Inst : IEnumerable<long>
{
public static readonly long[] Value=A274607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274607.Bytes);
public long this[int i]=>Value[i];

public static A274607Inst Instance=new A274607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274608
{
public static readonly long[] Value={ 2L,3L,6L,5L,10L,30L,7L,15L,42L,210L,11L,22L,70L,330L,2310L,13L,35L,110L,462L,2730L,30030L,17L,55L,165L,770L,4290L,39270L,510510L,19L,77L,231L,1155L,6006L,46410L,570570L,9699690L,23L,91L,385L,1430L,10010L,72930L,746130L,11741730L,223092870L,29L,143L,455L,2145L,15015L,102102L,903210L,14804790L,281291010L,6469693230L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274608Inst : IEnumerable<long>
{
public static readonly long[] Value=A274608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274608.Bytes);
public long this[int i]=>Value[i];

public static A274608Inst Instance=new A274608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274609
{
public static readonly long[] Value={ 2L,3L,31L,331L,1171L,2011L,2281L,3181L,4621L,4861L,6151L,6211L,6961L,7951L,8521L,9151L,11251L,12211L,13411L,15661L,17491L,18121L,19141L,20641L,22531L,23071L,23581L,24631L,25411L,26041L,26161L,26431L,26641L,27091L,27271L,27361L,27691L,28201L,28621L,29221L,31891L,33151L,34261L,35491L,36451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274609Inst : IEnumerable<long>
{
public static readonly long[] Value=A274609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274609.Bytes);
public long this[int i]=>Value[i];

public static A274609Inst Instance=new A274609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274610
{
public static readonly long[] Value={ 1L,22L,118L,358L,1678L,3478L,5038L,6238L,10198L,17158L,19318L,22798L,32758L,36478L,52438L,58078L,72358L,109558L,143638L,177238L,212518L,229438L,248998L,259078L,326038L,410878L,434278L,502678L,737878L,863038L,982078L,1062958L,1100398L,1274638L,1442398L,1515358L,1559998L,1635838L,1907158L,2042038L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274610Inst : IEnumerable<long>
{
public static readonly long[] Value=A274610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274610.Bytes);
public long this[int i]=>Value[i];

public static A274610Inst Instance=new A274610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274611
{
public static readonly long[] Value={ 2L,4L,6L,8L,10L,12L,14L,1L,18L,20L,22L,24L,26L,28L,30L,32L,34L,36L,38L,40L,42L,44L,46L,3L,50L,52L,54L,56L,58L,60L,62L,64L,66L,68L,70L,72L,74L,76L,78L,5L,82L,84L,86L,88L,90L,92L,94L,96L,98L,100L,102L,104L,106L,108L,110L,7L,114L,116L,118L,120L,122L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274611Inst : IEnumerable<long>
{
public static readonly long[] Value=A274611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274611.Bytes);
public long this[int i]=>Value[i];

public static A274611Inst Instance=new A274611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274612
{
public static readonly long[] Value={ 101L,102L,103L,104L,105L,106L,107L,108L,109L,201L,202L,203L,204L,205L,206L,207L,208L,209L,301L,302L,303L,304L,305L,306L,307L,308L,309L,401L,402L,403L,404L,405L,406L,407L,408L,409L,501L,502L,503L,504L,505L,506L,507L,508L,509L,601L,602L,603L,604L,605L,606L,607L,608L,609L,701L,702L,703L,704L,705L,706L,707L,708L,709L,801L,802L,803L,804L,805L,806L,807L,808L,809L,901L,902L,903L,904L,905L,906L,907L,908L,909L,1011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274612Inst : IEnumerable<long>
{
public static readonly long[] Value=A274612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274612.Bytes);
public long this[int i]=>Value[i];

public static A274612Inst Instance=new A274612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274613
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,3L,1L,3L,1L,1L,1L,3L,5L,1L,1L,5L,3L,1L,1L,5L,15L,7L,1L,5L,5L,21L,1L,1L,1L,15L,35L,7L,9L,1L,3L,35L,7L,9L,5L,1L,1L,21L,35L,21L,45L,11L,1L,7L,7L,63L,15L,55L,3L,1L,1L,7L,63L,105L,165L,33L,13L,1L,1L,21L,63L,165L,55L,39L,7L,1L,1L,9L,105L,231L,495L,143L,91L,15L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274613Inst : IEnumerable<long>
{
public static readonly long[] Value=A274613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274613.Bytes);
public long this[int i]=>Value[i];

public static A274613Inst Instance=new A274613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274614
{
public static readonly long[] Value={ 2L,5L,6L,3L,1L,9L,4L,7L,8L,13L,14L,11L,12L,10L,18L,15L,16L,21L,22L,19L,17L,25L,20L,23L,24L,29L,30L,27L,28L,26L,34L,31L,32L,37L,38L,35L,33L,41L,36L,39L,40L,45L,46L,43L,44L,42L,50L,47L,48L,53L,54L,51L,49L,57L,52L,55L,56L,61L,62L,59L,60L,58L,66L,63L,64L,69L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274614Inst : IEnumerable<long>
{
public static readonly long[] Value=A274614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274614.Bytes);
public long this[int i]=>Value[i];

public static A274614Inst Instance=new A274614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274615
{
public static readonly long[] Value={ 1L,4L,5L,2L,0L,8L,3L,6L,7L,12L,13L,10L,11L,9L,17L,14L,15L,20L,21L,18L,16L,24L,19L,22L,23L,28L,29L,26L,27L,25L,33L,30L,31L,36L,37L,34L,32L,40L,35L,38L,39L,44L,45L,42L,43L,41L,49L,46L,47L,52L,53L,50L,48L,56L,51L,54L,55L,60L,61L,58L,59L,57L,65L,62L,63L,68L,69L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274615Inst : IEnumerable<long>
{
public static readonly long[] Value=A274615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274615.Bytes);
public long this[int i]=>Value[i];

public static A274615Inst Instance=new A274615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274616
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,4L,5L,5L,6L,7L,7L,8L,9L,9L,10L,11L,11L,12L,13L,13L,14L,15L,15L,16L,17L,17L,18L,19L,19L,20L,21L,21L,22L,23L,23L,24L,25L,25L,26L,27L,27L,28L,29L,29L,30L,31L,31L,32L,33L,33L,34L,35L,35L,36L,37L,37L,38L,39L,39L,40L,41L,41L,42L,43L,43L,44L,45L,45L,46L,47L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274616Inst : IEnumerable<long>
{
public static readonly long[] Value=A274616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274616.Bytes);
public long this[int i]=>Value[i];

public static A274616Inst Instance=new A274616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274617
{
public static readonly long[] Value={ 6L,1L,2L,5L,4L,7L,3L,9L,10L,11L,12L,8L,14L,13L,16L,17L,18L,19L,15L,21L,20L,23L,22L,25L,26L,27L,28L,24L,30L,29L,32L,33L,34L,35L,31L,37L,36L,39L,38L,41L,42L,43L,44L,40L,46L,45L,48L,49L,50L,51L,47L,53L,52L,55L,54L,57L,58L,59L,60L,56L,62L,61L,64L,65L,66L,67L,63L,69L,68L,71L,70L,73L,74L,75L,76L,72L,78L,77L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274617Inst : IEnumerable<long>
{
public static readonly long[] Value=A274617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274617.Bytes);
public long this[int i]=>Value[i];

public static A274617Inst Instance=new A274617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274618
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,7L,3L,3L,2L,2L,8L,8L,9L,9L,7L,7L,6L,6L,5L,5L,4L,4L,3L,3L,2L,2L,8L,8L,9L,9L,4L,4L,5L,5L,12L,12L,13L,13L,9L,9L,8L,8L,2L,2L,3L,3L,4L,4L,5L,5L,15L,15L,14L,14L,3L,3L,2L,2L,8L,8L,9L,9L,7L,7L,6L,6L,5L,5L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274618Inst : IEnumerable<long>
{
public static readonly long[] Value=A274618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274618.Bytes);
public long this[int i]=>Value[i];

public static A274618Inst Instance=new A274618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274619
{
public static readonly long[] Value={ 5L,0L,1L,4L,3L,6L,2L,8L,9L,10L,11L,7L,13L,12L,15L,16L,17L,18L,14L,20L,19L,22L,21L,24L,25L,26L,27L,23L,29L,28L,31L,32L,33L,34L,30L,36L,35L,38L,37L,40L,41L,42L,43L,39L,45L,44L,47L,48L,49L,50L,46L,52L,51L,54L,53L,56L,57L,58L,59L,55L,61L,60L,63L,64L,65L,66L,62L,68L,67L,70L,69L,72L,73L,74L,75L,71L,77L,76L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274619Inst : IEnumerable<long>
{
public static readonly long[] Value=A274619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274619.Bytes);
public long this[int i]=>Value[i];

public static A274619Inst Instance=new A274619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274620
{
public static readonly long[] Value={ 11L,24L,39L,146L,255L,366L,479L,684L,891L,11000L,11121L,11244L,11369L,11496L,21525L,21656L,21789L,31824L,31961L,42000L,42141L,42284L,52329L,52476L,62525L,62676L,72729L,72884L,82941L,93000L,93161L,103224L,103389L,113456L,123525L,123696L,133769L,143844L,153921L,164000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274620Inst : IEnumerable<long>
{
public static readonly long[] Value=A274620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274620.Bytes);
public long this[int i]=>Value[i];

public static A274620Inst Instance=new A274620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274621
{
public static readonly long[] Value={ 1L,-2L,3L,-6L,11L,-18L,28L,-44L,69L,-104L,152L,-222L,323L,-460L,645L,-902L,1254L,-1722L,2343L,-3174L,4278L,-5722L,7601L,-10056L,13250L,-17358L,22623L,-29382L,38021L,-48984L,62857L,-80404L,102528L,-130282L,165002L,-208398L,262495L,-329666L,412878L,-515840L,642941L,-799362L,991478L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274621Inst : IEnumerable<long>
{
public static readonly long[] Value=A274621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274621.Bytes);
public long this[int i]=>Value[i];

public static A274621Inst Instance=new A274621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274622
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,4L,4L,1L,2L,8L,8L,2L,4L,14L,14L,4L,8L,24L,24L,8L,1L,14L,40L,40L,14L,1L,2L,24L,64L,64L,24L,2L,4L,40L,100L,100L,40L,4L,8L,64L,154L,154L,64L,8L,14L,100L,232L,232L,100L,14L,24L,154L,344L,344L,154L,24L,1L,40L,232L,504L,504L,232L,40L,1L,2L,64L,344L,728L,728L,344L,64L,2L,4L,100L,504L,1040L,1040L,504L,100L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274622Inst : IEnumerable<long>
{
public static readonly long[] Value=A274622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274622.Bytes);
public long this[int i]=>Value[i];

public static A274622Inst Instance=new A274622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274623
{
public static readonly long[] Value={ 1L,2L,1L,4L,2L,8L,4L,14L,8L,24L,1L,14L,40L,2L,24L,64L,4L,40L,100L,8L,64L,154L,14L,100L,232L,24L,154L,344L,1L,40L,232L,504L,2L,64L,344L,728L,4L,100L,504L,1040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274623Inst : IEnumerable<long>
{
public static readonly long[] Value=A274623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274623.Bytes);
public long this[int i]=>Value[i];

public static A274623Inst Instance=new A274623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274624
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,4L,2L,4L,8L,4L,1L,8L,14L,8L,1L,2L,14L,24L,14L,2L,4L,24L,40L,24L,4L,8L,40L,64L,40L,8L,14L,64L,100L,64L,14L,1L,24L,100L,154L,100L,24L,1L,2L,40L,154L,232L,154L,40L,2L,4L,64L,232L,344L,232L,64L,4L,8L,100L,344L,504L,344L,100L,8L,14L,154L,504L,728L,504L,154L,14L,24L,232L,728L,1040L,728L,232L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274624Inst : IEnumerable<long>
{
public static readonly long[] Value=A274624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274624.Bytes);
public long this[int i]=>Value[i];

public static A274624Inst Instance=new A274624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274625
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,4L,8L,1L,8L,14L,2L,14L,24L,4L,24L,40L,8L,40L,64L,14L,64L,100L,1L,24L,100L,154L,2L,40L,154L,232L,4L,64L,232L,344L,8L,100L,344L,504L,14L,154L,504L,728L,24L,232L,728L,1040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274625Inst : IEnumerable<long>
{
public static readonly long[] Value=A274625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274625.Bytes);
public long this[int i]=>Value[i];

public static A274625Inst Instance=new A274625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274626
{
public static readonly long[] Value={ 0L,0L,0L,1L,3L,9L,27L,63L,147L,343L,735L,1575L,3375L,6975L,14415L,29791L,60543L,123039L,250047L,504063L,1016127L,2048383L,4112895L,8258175L,16581375L,33227775L,66585855L,133432831L,267126783L,534776319L,1070599167L,2142244863L,4286583807L,8577357823L,17158905855L,34326194175L,68669157375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274626Inst : IEnumerable<long>
{
public static readonly long[] Value=A274626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274626.Bytes);
public long this[int i]=>Value[i];

public static A274626Inst Instance=new A274626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274627
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,3L,9L,27L,81L,189L,441L,1029L,2401L,5145L,11025L,23625L,50625L,104625L,216225L,446865L,923521L,1876833L,3814209L,7751457L,15752961L,31755969L,64016001L,129048129L,260144641L,522337665L,1048788225L,2105834625L,4228250625L,8473082625L,16979393025L,34025371905L,68184176641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274627Inst : IEnumerable<long>
{
public static readonly long[] Value=A274627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274627.Bytes);
public long this[int i]=>Value[i];

public static A274627Inst Instance=new A274627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274628
{
public static readonly long[] Value={ 1L,4L,7L,13L,15L,26L,25L,39L,40L,54L,49L,79L,63L,88L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274628Inst : IEnumerable<long>
{
public static readonly long[] Value=A274628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274628.Bytes);
public long this[int i]=>Value[i];

public static A274628Inst Instance=new A274628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274629
{
public static readonly long[] Value={ 1L,5L,12L,25L,40L,66L,91L,130L,170L,224L,273L,352L,415L,503L,591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274629Inst : IEnumerable<long>
{
public static readonly long[] Value=A274629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274629.Bytes);
public long this[int i]=>Value[i];

public static A274629Inst Instance=new A274629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274630
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,3L,7L,8L,2L,5L,1L,9L,4L,7L,6L,2L,10L,11L,1L,5L,7L,4L,12L,6L,3L,9L,8L,8L,9L,11L,13L,2L,10L,6L,4L,10L,12L,1L,3L,4L,7L,13L,11L,9L,9L,6L,2L,5L,8L,1L,12L,14L,3L,10L,11L,13L,3L,7L,6L,14L,9L,5L,1L,12L,15L,12L,8L,4L,14L,9L,11L,10L,3L,15L,2L,7L,13L,13L,10L,5L,1L,12L,15L,2L,16L,6L,4L,8L,14L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274630Inst : IEnumerable<long>
{
public static readonly long[] Value=A274630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274630.Bytes);
public long this[int i]=>Value[i];

public static A274630Inst Instance=new A274630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274631
{
public static readonly long[] Value={ 1L,2L,4L,3L,5L,6L,7L,8L,10L,9L,11L,12L,13L,14L,16L,15L,17L,18L,19L,20L,22L,21L,24L,23L,26L,25L,28L,27L,30L,29L,32L,31L,34L,33L,36L,35L,38L,37L,39L,40L,42L,41L,44L,43L,46L,45L,48L,47L,50L,49L,52L,51L,54L,53L,56L,55L,58L,57L,59L,60L,62L,61L,64L,63L,66L,65L,68L,67L,70L,69L,72L,71L,74L,73L,76L,75L,78L,77L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274631Inst : IEnumerable<long>
{
public static readonly long[] Value=A274631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274631.Bytes);
public long this[int i]=>Value[i];

public static A274631Inst Instance=new A274631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274632
{
public static readonly long[] Value={ 1L,3L,6L,2L,7L,5L,8L,4L,9L,10L,15L,13L,11L,18L,12L,20L,16L,22L,25L,27L,14L,28L,29L,31L,33L,34L,38L,32L,35L,36L,41L,40L,39L,17L,46L,43L,44L,52L,19L,48L,57L,50L,61L,53L,58L,21L,23L,24L,63L,65L,56L,60L,26L,71L,66L,68L,74L,78L,30L,77L,73L,80L,84L,69L,76L,82L,79L,89L,92L,85L,90L,87L,91L,93L,94L,37L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274632Inst : IEnumerable<long>
{
public static readonly long[] Value=A274632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274632.Bytes);
public long this[int i]=>Value[i];

public static A274632Inst Instance=new A274632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274633
{
public static readonly long[] Value={ 1L,5L,9L,6L,4L,14L,2L,19L,11L,3L,20L,15L,8L,10L,25L,22L,33L,27L,7L,28L,43L,29L,36L,17L,12L,13L,16L,62L,18L,40L,66L,35L,71L,59L,77L,74L,50L,45L,49L,85L,60L,21L,24L,58L,23L,99L,30L,78L,32L,31L,67L,103L,110L,37L,42L,34L,26L,38L,73L,83L,80L,39L,134L,47L,79L,105L,41L,95L,148L,106L,150L,102L,44L,92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274633Inst : IEnumerable<long>
{
public static readonly long[] Value=A274633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274633.Bytes);
public long this[int i]=>Value[i];

public static A274633Inst Instance=new A274633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274634
{
public static readonly BigInteger[] Value={ 0L,2L,24L,744L,35160L,2394720L,222712560L,27154350720L,4205374225920L,806700010233600L,187793061031699200L,BigInteger.Parse("52162131258836121600"),BigInteger.Parse("17043501717850146739200"),BigInteger.Parse("6471785359791584459827200"),BigInteger.Parse("2826261760629911644744704000"),BigInteger.Parse("1406604814631643298586923008000") };
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
public class A274634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274634Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274634.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274634.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274634Inst Instance=new A274634Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274635
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,3L,1L,3L,0L,0L,0L,3L,3L,3L,3L,0L,0L,0L,7L,3L,9L,3L,7L,0L,0L,0L,7L,7L,9L,9L,7L,7L,0L,0L,0L,15L,7L,21L,9L,21L,7L,15L,0L,0L,0L,15L,15L,21L,21L,21L,21L,15L,15L,0L,0L,0L,31L,15L,45L,21L,49L,21L,45L,15L,31L,0L,0L,0L,31L,31L,45L,45L,49L,49L,45L,45L,31L,31L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274635Inst : IEnumerable<long>
{
public static readonly long[] Value=A274635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274635.Bytes);
public long this[int i]=>Value[i];

public static A274635Inst Instance=new A274635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274636
{
public static readonly long[] Value={ 4L,4L,6L,6L,6L,6L,6L,9L,6L,10L,10L,9L,9L,10L,10L,10L,15L,9L,15L,10L,18L,18L,15L,15L,15L,15L,18L,18L,18L,27L,15L,25L,15L,27L,18L,34L,34L,27L,27L,25L,25L,27L,27L,34L,34L,34L,51L,27L,45L,25L,45L,27L,51L,34L,66L,66L,51L,51L,45L,45L,45L,45L,51L,51L,66L,66L,66L,99L,51L,85L,45L,81L,45L,85L,51L,99L,66L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274636Inst : IEnumerable<long>
{
public static readonly long[] Value=A274636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274636.Bytes);
public long this[int i]=>Value[i];

public static A274636Inst Instance=new A274636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274637
{
public static readonly long[] Value={ 0L,0L,0L,2L,0L,0L,2L,3L,0L,0L,6L,3L,3L,0L,0L,6L,9L,3L,5L,0L,0L,14L,9L,9L,5L,5L,0L,0L,14L,21L,9L,15L,5L,9L,0L,0L,30L,21L,21L,15L,15L,9L,9L,0L,0L,30L,45L,21L,35L,15L,27L,9L,17L,0L,0L,62L,45L,45L,35L,35L,27L,27L,17L,17L,0L,0L,62L,93L,45L,75L,35L,63L,27L,51L,17L,33L,0L,0L,126L,93L,93L,75L,75L,63L,63L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274637Inst : IEnumerable<long>
{
public static readonly long[] Value=A274637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274637.Bytes);
public long this[int i]=>Value[i];

public static A274637Inst Instance=new A274637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274638
{
public static readonly long[] Value={ 0L,0L,3L,5L,15L,27L,63L,119L,255L,495L,1023L,2015L,4095L,8127L,16383L,32639L,65535L,130815L,262143L,523775L,1048575L,2096127L,4194303L,8386559L,16777215L,33550335L,67108863L,134209535L,268435455L,536854527L,1073741823L,2147450879L,4294967295L,8589869055L,17179869183L,34359607295L,68719476735L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274638Inst : IEnumerable<long>
{
public static readonly long[] Value=A274638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274638.Bytes);
public long this[int i]=>Value[i];

public static A274638Inst Instance=new A274638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274639
{
public static readonly BigInteger[] Value={ 33L,242L,7939375L,3388031791L,104228508212890623L,BigInteger.Parse("1489106237081787109375"),BigInteger.Parse("273062471666259918212890623"),BigInteger.Parse("804505911103256259918212890623"),BigInteger.Parse("490685203356467392256259918212890623"),BigInteger.Parse("6794675247932944436619977392256259918212890623"),BigInteger.Parse("329757106427071213106619977392256259918212890623"),BigInteger.Parse("4459248710164424946384890995893380022607743740081787109375"),BigInteger.Parse("3685099958690838758895720896109004106619977392256259918212890623") };
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
public class A274639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274639Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274639.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274639.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274639Inst Instance=new A274639Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274640
{
public static readonly long[] Value={ 1L,2L,3L,4L,2L,3L,4L,5L,6L,1L,4L,6L,2L,1L,6L,5L,3L,1L,5L,2L,6L,1L,2L,4L,5L,3L,7L,8L,5L,4L,9L,7L,8L,3L,10L,11L,4L,7L,8L,6L,3L,9L,5L,7L,8L,9L,10L,11L,12L,6L,8L,9L,11L,10L,12L,13L,7L,6L,10L,9L,12L,13L,14L,15L,8L,2L,9L,12L,7L,10L,11L,13L,14L,10L,9L,6L,13L,5L,3L,15L,16L,7L,1L,10L,13L,12L,14L,11L,15L,3L,8L,5L,1L,12L,11L,14L,7L,4L,2L,16L,9L,17L,1L,8L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274640Inst : IEnumerable<long>
{
public static readonly long[] Value=A274640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274640.Bytes);
public long this[int i]=>Value[i];

public static A274640Inst Instance=new A274640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274641
{
public static readonly long[] Value={ 0L,1L,2L,3L,1L,2L,3L,4L,5L,0L,3L,5L,1L,0L,5L,4L,2L,0L,4L,1L,5L,0L,1L,3L,4L,2L,6L,7L,4L,3L,8L,6L,7L,2L,9L,10L,3L,6L,7L,5L,2L,8L,4L,6L,7L,8L,9L,10L,11L,5L,7L,8L,10L,9L,11L,12L,6L,5L,9L,8L,11L,12L,13L,14L,7L,1L,8L,11L,6L,9L,10L,12L,13L,9L,8L,5L,12L,4L,2L,14L,15L,6L,0L,9L,12L,11L,13L,10L,14L,2L,7L,4L,0L,11L,10L,13L,6L,3L,1L,15L,8L,16L,0L,7L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274641Inst : IEnumerable<long>
{
public static readonly long[] Value=A274641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274641.Bytes);
public long this[int i]=>Value[i];

public static A274641Inst Instance=new A274641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274642
{
public static readonly long[] Value={ 28L,55L,60L,79L,92L,95L,112L,240L,368L,448L,960L,1472L,1792L,3840L,5888L,7168L,15360L,23552L,28672L,61440L,94208L,114688L,245760L,376832L,458752L,983040L,1507328L,1835008L,3932160L,6029312L,7340032L,15728640L,24117248L,29360128L,62914560L,96468992L,117440512L,251658240L,385875968L,469762048L,1006632960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274642Inst : IEnumerable<long>
{
public static readonly long[] Value=A274642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274642.Bytes);
public long this[int i]=>Value[i];

public static A274642Inst Instance=new A274642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274643
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,4L,4L,1L,1L,6L,10L,6L,1L,1L,10L,23L,22L,9L,1L,1L,14L,44L,61L,41L,12L,1L,1L,22L,88L,158L,147L,71L,16L,1L,1L,30L,151L,353L,436L,300L,114L,20L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274643Inst : IEnumerable<long>
{
public static readonly long[] Value=A274643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274643.Bytes);
public long this[int i]=>Value[i];

public static A274643Inst Instance=new A274643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274644
{
public static readonly BigInteger[] Value={ 1L,6L,71L,1266L,30206L,902796L,32420011L,1359292626L,65164480466L,3515569641156L,210779736073446L,13903319821066836L,1000559812125494272L,BigInteger.Parse("78012524487061307392"),BigInteger.Parse("6550837823204595073024"),BigInteger.Parse("589404446176366091567104"),BigInteger.Parse("56568586570039156279345152"),BigInteger.Parse("5768723174387470083567910912"),BigInteger.Parse("622900652040379384928709640192") };
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
public class A274644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274644Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274644.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274644.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274644Inst Instance=new A274644Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274645
{
public static readonly BigInteger[] Value={ 1L,20L,1301L,177260L,41385102L,14760468600L,7465847167005L,5083351577582300L,4483012419041095680L,BigInteger.Parse("4971032496120058085376"),BigInteger.Parse("6769339545226095791964160"),BigInteger.Parse("11105730970797793499164966912"),BigInteger.Parse("21604722570792867452576610648064") };
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
public class A274645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274645Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274645.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274645.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274645Inst Instance=new A274645Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274646
{
public static readonly BigInteger[] Value={ 1L,70L,26599L,29609650L,72574079902L,332014782982540L,2545213373338499072L,BigInteger.Parse("30302687687176712355840"),BigInteger.Parse("529556871638491591748878336"),BigInteger.Parse("13004213964445490176628310933504"),BigInteger.Parse("433440210434110194677894532074307584") };
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
public class A274646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274646Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274646.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274646.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274646Inst Instance=new A274646Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274647
{
public static readonly long[] Value={ 0L,1L,3L,6L,2L,7L,13L,20L,12L,21L,11L,22L,10L,23L,9L,24L,8L,25L,43L,62L,42L,63L,41L,18L,66L,91L,65L,38L,94L,123L,93L,124L,92L,59L,127L,162L,126L,89L,51L,90L,50L,132L,174L,131L,87L,177L,223L,176L,128L,79L,29L,80L,28L,81L,27L,82L,26L,83L,141L,200L,140L,201L,139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274647Inst : IEnumerable<long>
{
public static readonly long[] Value=A274647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274647.Bytes);
public long this[int i]=>Value[i];

public static A274647Inst Instance=new A274647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274648
{
public static readonly long[] Value={ 0L,1L,3L,6L,2L,7L,13L,20L,12L,21L,11L,22L,10L,23L,9L,24L,8L,25L,43L,5L,45L,66L,44L,67L,19L,69L,17L,71L,15L,73L,103L,72L,40L,106L,38L,108L,36L,110L,34L,112L,32L,114L,30L,116L,28L,118L,26L,120L,168L,119L,169L,16L,68L,121L,175L,65L,177L,63L,179L,61L,181L,59L,183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274648Inst : IEnumerable<long>
{
public static readonly long[] Value=A274648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274648.Bytes);
public long this[int i]=>Value[i];

public static A274648Inst Instance=new A274648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274649
{
public static readonly long[] Value={ 5L,3L,30915397L,11339869L,3L,5L,859L,3L,41L,233L,3L,7L,4175194313L,3L,307L,5L,3L,1459L,7L,3L,5L,9907L,3L,647L,13L,3L,31L,11L,3L,193L,5L,3L,7L,2939L,3L,5L,3167L,3L,11L,7L,3L,1321L,86629L,3L,17L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274649Inst : IEnumerable<long>
{
public static readonly long[] Value=A274649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274649.Bytes);
public long this[int i]=>Value[i];

public static A274649Inst Instance=new A274649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274650
{
public static readonly long[] Value={ 0L,1L,2L,3L,0L,1L,2L,4L,3L,5L,5L,1L,0L,2L,3L,4L,3L,5L,1L,6L,7L,6L,7L,2L,0L,5L,4L,8L,8L,5L,9L,4L,7L,2L,10L,6L,7L,10L,8L,3L,0L,6L,9L,5L,4L,11L,6L,12L,7L,1L,8L,3L,10L,9L,13L,9L,8L,4L,11L,2L,0L,1L,12L,6L,7L,10L,10L,11L,7L,12L,4L,3L,2L,9L,8L,14L,13L,15L,12L,9L,10L,6L,8L,1L,0L,11L,7L,4L,16L,14L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274650Inst : IEnumerable<long>
{
public static readonly long[] Value=A274650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274650.Bytes);
public long this[int i]=>Value[i];

public static A274650Inst Instance=new A274650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274651
{
public static readonly long[] Value={ 1L,2L,3L,4L,1L,2L,3L,5L,4L,6L,6L,2L,1L,3L,4L,5L,4L,6L,2L,7L,8L,7L,8L,3L,1L,6L,5L,9L,9L,6L,10L,5L,8L,3L,11L,7L,8L,11L,9L,4L,1L,7L,10L,6L,5L,12L,7L,13L,8L,2L,9L,4L,11L,10L,14L,10L,9L,5L,12L,3L,1L,2L,13L,7L,8L,11L,11L,12L,8L,13L,5L,4L,3L,10L,9L,15L,14L,16L,13L,10L,11L,7L,9L,2L,1L,12L,8L,5L,17L,15L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274651Inst : IEnumerable<long>
{
public static readonly long[] Value=A274651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274651.Bytes);
public long this[int i]=>Value[i];

public static A274651Inst Instance=new A274651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274652
{
public static readonly long[] Value={ 0L,3L,6L,12L,13L,25L,36L,43L,57L,67L,100L,134L,115L,163L,153L,186L,185L,248L,277L,258L,306L,366L,370L,381L,528L,471L,607L,662L,610L,706L,778L,760L,783L,782L,950L,970L,975L,1194L,1206L,1175L,1301L,1393L,1438L,1261L,1584L,1549L,1592L,1645L,1776L,1783L,2010L,1956L,1953L,2353L,2441L,2258L,2468L,2342L,2635L,2663L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274652Inst : IEnumerable<long>
{
public static readonly long[] Value=A274652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274652.Bytes);
public long this[int i]=>Value[i];

public static A274652Inst Instance=new A274652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274653
{
public static readonly BigInteger[] Value={ 0L,1L,21L,185L,18655L,307503L,12548151L,305496477L,138343008375L,4464248592375L,323592065474535L,13015087974100485L,2301190559547593805L,BigInteger.Parse("110887163426713235625"),BigInteger.Parse("11570760017278599886875"),BigInteger.Parse("649837647729572203369125"),BigInteger.Parse("1250848387902442801195686375"),BigInteger.Parse("80233244659365977333374518375") };
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
public class A274653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274653Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274653.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274653.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274653Inst Instance=new A274653Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274654
{
public static readonly long[] Value={ 1L,2L,32L,128L,4096L,16384L,131072L,524288L,33554432L,134217728L,1073741824L,4294967296L,68719476736L,274877906944L,2199023255552L,8796093022208L,1125899906842624L,4503599627370496L,36028797018963968L,144115188075855872L,2305843009213693952L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274654Inst : IEnumerable<long>
{
public static readonly long[] Value=A274654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274654.Bytes);
public long this[int i]=>Value[i];

public static A274654Inst Instance=new A274654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274655
{
public static readonly BigInteger[] Value={ 0L,1L,21L,185L,18655L,102501L,1394239L,33944053L,3074289075L,99205524275L,7190934788323L,4590859955591L,2435122285235549L,23468182735812325L,38870446014205425L,145536272272236993L,BigInteger.Parse("280137373064011153371"),BigInteger.Parse("1633533514217325226737"),BigInteger.Parse("74200692627870055029475") };
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
public class A274655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274655Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274655.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274655.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274655Inst Instance=new A274655Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274656
{
public static readonly BigInteger[] Value={ 1L,2L,64L,768L,98304L,655360L,10485760L,293601280L,30064771072L,1082331758592L,86586540687360L,60473139527680L,34832528367943680L,362258295026614272L,644014746713980928L,2576058986855923712L,BigInteger.Parse("5275768805080931762176"),BigInteger.Parse("32613843522318487257088") };
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
public class A274656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274656Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274656.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274656.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274656Inst Instance=new A274656Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274657
{
public static readonly BigInteger[] Value={ 1L,1L,9L,75L,3675L,59535L,2401245L,57972915L,13043905875L,418854310875L,30241281245175L,1212400457192925L,213786613951685775L,10278202593831046875UL,BigInteger.Parse("1070401384414690453125"),BigInteger.Parse("60013837619516978071875"),BigInteger.Parse("57673297952355815927071875"),BigInteger.Parse("3694483615889146090857721875") };
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
public class A274657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274657Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A274657.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A274657.Bytes);
public BigInteger this[int i]=>Value[i];

public static A274657Inst Instance=new A274657Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274658
{
public static readonly long[] Value={ 1L,1L,3L,1L,5L,1L,7L,1L,3L,9L,1L,11L,1L,13L,1L,3L,5L,15L,1L,17L,1L,19L,1L,3L,7L,21L,1L,23L,1L,5L,25L,1L,3L,9L,27L,1L,29L,1L,31L,1L,3L,11L,33L,1L,5L,7L,35L,1L,37L,1L,3L,13L,39L,1L,41L,1L,43L,1L,3L,5L,9L,15L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274658Inst : IEnumerable<long>
{
public static readonly long[] Value=A274658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274658.Bytes);
public long this[int i]=>Value[i];

public static A274658Inst Instance=new A274658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274659
{
public static readonly long[] Value={ 1L,1L,1L,-1L,0L,1L,-1L,-2L,0L,1L,2L,1L,-2L,0L,1L,2L,3L,0L,-2L,0L,1L,-4L,-2L,3L,0L,-2L,0L,1L,-4L,-5L,1L,3L,0L,-2L,0L,1L,7L,3L,-6L,0L,3L,0L,-2L,0L,1L,7L,9L,-2L,-6L,0L,3L,0L,-2L,0L,1L,-11L,-5L,11L,1L,-6L,0L,3L,0L,-2L,0L,1L,-11L,-15L,3L,11L,0L,-6L,0L,3L,0L,-2L,0L,1L,17L,9L,-17L,-2L,11L,0L,-6L,0L,3L,0L,-2L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274659Inst : IEnumerable<long>
{
public static readonly long[] Value=A274659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274659.Bytes);
public long this[int i]=>Value[i];

public static A274659Inst Instance=new A274659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274660
{
public static readonly long[] Value={ 1L,-1L,3L,1L,5L,-1L,7L,1L,-3L,9L,-1L,11L,1L,13L,-1L,3L,-5L,15L,1L,17L,-1L,19L,1L,-3L,-7L,21L,-1L,23L,1L,5L,25L,-1L,3L,-9L,27L,1L,29L,-1L,31L,1L,-3L,-11L,33L,-1L,-5L,7L,35L,1L,37L,-1L,3L,-13L,39L,1L,41L,-1L,43L,1L,-3L,5L,9L,-15L,45L,-1L,47L,1L,-7L,49L,-1L,3L,-17L,51L,1L,53L,-1L,-5L,11L,55L,1L,-3L,-19L,57L,-1L,59L,1L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274660Inst : IEnumerable<long>
{
public static readonly long[] Value=A274660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274660.Bytes);
public long this[int i]=>Value[i];

public static A274660Inst Instance=new A274660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A274661
{
public static readonly long[] Value={ 1L,-1L,1L,-1L,0L,1L,1L,-2L,0L,1L,2L,-1L,-2L,0L,1L,-2L,3L,0L,-2L,0L,1L,-4L,2L,3L,0L,-2L,0L,1L,4L,-5L,-1L,3L,0L,-2L,0L,1L,7L,-3L,-6L,0L,3L,0L,-2L,0L,1L,-7L,9L,2L,-6L,0L,3L,0L,-2L,0L,1L,-11L,5L,11L,-1L,-6L,0L,3L,0L,-2L,0L,1L,11L,-15L,-3L,11L,0L,-6L,0L,3L,0L,-2L,0L,1L,17L,-9L,-17L,2L,11L,0L,-6L,0L,3L,0L,-2L,0L,1L,-17L,23L,6L,-18L,-1L,11L,0L,-6L,0L,3L,0L,-2L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A274661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A274661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A274661Inst : IEnumerable<long>
{
public static readonly long[] Value=A274661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A274661.Bytes);
public long this[int i]=>Value[i];

public static A274661Inst Instance=new A274661Inst();

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