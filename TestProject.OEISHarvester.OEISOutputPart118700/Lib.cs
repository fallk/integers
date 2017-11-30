using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A148005
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,15L,44L,91L,286L,633L,2072L,4796L,16180L,38727L,133548L,327895L,1150226L,2881857L,10247072L,26099008L,93830568L,242264113L,878987980L,2295723288L,8393889812L,22139557300L,81484257064L,216757035756L,802324361696L,2150196732767L,7998562017700L,21576806128743L,80615634684738L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148005Inst : IEnumerable<long>
{
public static readonly long[] Value=A148005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148005.Bytes);
public long this[int i]=>Value[i];

public static A148005Inst Instance=new A148005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148006
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,15L,44L,91L,300L,675L,2246L,5225L,18369L,44590L,157351L,389281L,1418064L,3598815L,13127212L,33721485L,125539307L,327997148L,1221478559L,3218359939L,12154464884L,32412375855L,122407772319L,328464178536L,1253012930330L,3392521591292L,12940473812157L,35205364700389L,135293932230274L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148006Inst : IEnumerable<long>
{
public static readonly long[] Value=A148006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148006.Bytes);
public long this[int i]=>Value[i];

public static A148006Inst Instance=new A148006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148007
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,15L,44L,91L,314L,717L,2462L,5786L,20723L,50596L,188018L,473183L,1804072L,4645335L,17787660L,46419584L,181375177L,481275126L,1911271468L,5141399599L,20539168658L,55762292565L,224393416829L,614548182426L,2502149168249L,6916703340431L,28335787685261L,78869864682145L,324320769451124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148007Inst : IEnumerable<long>
{
public static readonly long[] Value=A148007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148007.Bytes);
public long this[int i]=>Value[i];

public static A148007Inst Instance=new A148007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148008
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,15L,44L,91L,328L,759L,2636L,6215L,23704L,59033L,220830L,556591L,2236464L,5852471L,22914792L,60201671L,249117796L,672658877L,2717264406L,7345845087L,31036174078L,85697043495L,353999837354L,977097682671L,4193053543778L,11773887108191L,49467365565802L,138720176659439L,602452741040616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148008Inst : IEnumerable<long>
{
public static readonly long[] Value=A148008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148008.Bytes);
public long this[int i]=>Value[i];

public static A148008Inst Instance=new A148008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148009
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,15L,44L,101L,324L,807L,2562L,6874L,22021L,63456L,208798L,634362L,2070911L,6467596L,21207233L,68259541L,227890492L,755089500L,2534135422L,8468506831L,28559647176L,96623136254L,330263074825L,1136529083058L,3923257279683L,13556679447462L,46939729799301L,163098846274142L,569596080479337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148009Inst : IEnumerable<long>
{
public static readonly long[] Value=A148009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148009.Bytes);
public long this[int i]=>Value[i];

public static A148009Inst Instance=new A148009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148010
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,15L,44L,101L,334L,817L,2752L,7084L,24607L,67680L,245864L,697772L,2553885L,7409054L,27480303L,82521955L,313794525L,959852546L,3664001178L,11345504079L,43619693769L,138028015239L,539448885144L,1727930112762L,6767820538432L,21845264940373L,85933511671898L,281615411418059L,1121090889944370L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148010Inst : IEnumerable<long>
{
public static readonly long[] Value=A148010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148010.Bytes);
public long this[int i]=>Value[i];

public static A148010Inst Instance=new A148010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148011
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,15L,44L,101L,338L,849L,2736L,7555L,25254L,73321L,243290L,762927L,2557674L,8162769L,27492592L,92263125L,312597658L,1055555063L,3634419897L,12618793174L,43555825107L,151808509939L,534943761678L,1891289995128L,6664938234011L,23709504232076L,85097685030264L,304700197997170L,1093145659514525L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148011Inst : IEnumerable<long>
{
public static readonly long[] Value=A148011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148011.Bytes);
public long this[int i]=>Value[i];

public static A148011Inst Instance=new A148011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148012
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,15L,44L,101L,348L,859L,2926L,7765L,28092L,77797L,288226L,835551L,3149704L,9376877L,36183832L,110801091L,431609988L,1350519440L,5338560871L,17003928647L,67861860571L,219953201097L,885178666480L,2907032661937L,11800981627623L,39264792923311L,160349091607954L,539475559104643L,2217553429366461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148012Inst : IEnumerable<long>
{
public static readonly long[] Value=A148012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148012.Bytes);
public long this[int i]=>Value[i];

public static A148012Inst Instance=new A148012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148013
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,15L,49L,105L,370L,849L,3095L,7414L,28588L,71396L,281514L,721183L,2905532L,7606055L,31290641L,83451040L,347766974L,940689178L,3969426742L,10871603407L,46382673907L,128408010535L,552374664184L,1542959571105L,6691007154080L,18841696947244L,82260632828431L,233277631001465L,1024405633824630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148013Inst : IEnumerable<long>
{
public static readonly long[] Value=A148013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148013.Bytes);
public long this[int i]=>Value[i];

public static A148013Inst Instance=new A148013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148014
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,17L,46L,110L,307L,848L,2420L,6962L,20273L,61162L,185870L,568890L,1757412L,5477941L,17377747L,55272016L,176736009L,568644124L,1842453512L,6025347906L,19741386691L,64938905399L,214606827546L,712767674928L,2380612859574L,7963607476122L,26723258224939L,89989967039606L,304134328175480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148014Inst : IEnumerable<long>
{
public static readonly long[] Value=A148014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148014.Bytes);
public long this[int i]=>Value[i];

public static A148014Inst Instance=new A148014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148015
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,17L,46L,110L,335L,932L,2810L,7952L,24816L,77649L,246474L,775403L,2494697L,8205868L,27285758L,89808549L,299916394L,1015055715L,3470516713L,11875011937L,40535085083L,140299654185L,489869705096L,1712127093499L,5997291296577L,21043269839009L,74602647699984L,265584478448207L,944077259383298L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148015Inst : IEnumerable<long>
{
public static readonly long[] Value=A148015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148015.Bytes);
public long this[int i]=>Value[i];

public static A148015Inst Instance=new A148015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148016
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,17L,46L,117L,337L,954L,2765L,8334L,25350L,78302L,244664L,777806L,2495210L,8049224L,26288829L,86510067L,286120463L,952818316L,3193840880L,10759053541L,36391963273L,123723824745L,422498010677L,1447387300427L,4976890447866L,17175794352740L,59448688148611L,206336010280396L,718237279107642L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148016Inst : IEnumerable<long>
{
public static readonly long[] Value=A148016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148016.Bytes);
public long this[int i]=>Value[i];

public static A148016Inst Instance=new A148016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148017
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,17L,46L,117L,365L,1038L,3155L,9720L,31261L,99782L,322517L,1078436L,3639101L,12237485L,41922026L,146103022L,508439432L,1781167516L,6315381661L,22553829270L,80707216930L,290156888459L,1053694190563L,3840261414949L,14000670459904L,51441715144852L,190036544389434L,702284944553435L,2606556569184976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148017Inst : IEnumerable<long>
{
public static readonly long[] Value=A148017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148017.Bytes);
public long this[int i]=>Value[i];

public static A148017Inst Instance=new A148017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148018
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,17L,46L,120L,345L,1022L,2910L,9040L,27530L,88493L,283253L,912384L,3037696L,9955390L,33803098L,113920402L,390162517L,1349732321L,4642227231L,16328414313L,56978655042L,202131478689L,717829790091L,2553299150122L,9196541401438L,32928272615601L,119572300555189L,433085570807293L,1577395594151588L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148018Inst : IEnumerable<long>
{
public static readonly long[] Value=A148018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148018.Bytes);
public long this[int i]=>Value[i];

public static A148018Inst Instance=new A148018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148019
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,17L,46L,120L,355L,1032L,3100L,9340L,29696L,95081L,313347L,1029034L,3432205L,11592025L,39779168L,137877429L,481249138L,1686693258L,5964861195L,21272314918L,76492455917L,276544510969L,1003517401394L,3658674178950L,13417837913677L,49490455637968L,183410344857840L,681873034580703L,2542965407836124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148019Inst : IEnumerable<long>
{
public static readonly long[] Value=A148019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148019.Bytes);
public long this[int i]=>Value[i];

public static A148019Inst Instance=new A148019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148020
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,17L,46L,127L,375L,1128L,3367L,10920L,34671L,112564L,378464L,1276401L,4367446L,15059481L,53064595L,187243903L,663669380L,2400056392L,8678448201L,31543452428L,115945737265L,428333746174L,1587547930666L,5915108954182L,22227724053667L,83642770868524L,315723019652527L,1201396034129496L,4579065456128057L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148020Inst : IEnumerable<long>
{
public static readonly long[] Value=A148020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148020.Bytes);
public long this[int i]=>Value[i];

public static A148020Inst Instance=new A148020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148021
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,17L,46L,127L,385L,1138L,3557L,11332L,36949L,122262L,415624L,1427497L,4962532L,17550068L,62626410L,225373569L,821372128L,3016299522L,11145989333L,41593856129L,156190755015L,589476598936L,2241899251552L,8571688434648L,32908712661363L,127130928921437L,493347655801103L,1921175991853967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148021Inst : IEnumerable<long>
{
public static readonly long[] Value=A148021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148021.Bytes);
public long this[int i]=>Value[i];

public static A148021Inst Instance=new A148021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148022
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,17L,48L,112L,347L,911L,2885L,7886L,26162L,76110L,255274L,759672L,2620889L,8108113L,28152858L,88374823L,312756148L,1008227273L,3582900787L,11668371798L,42040174135L,139593853572L,504390828353L,1687460696573L,6161171277397L,20919952263418L,76541691561718L,261399509898279L,964264021616684L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148022Inst : IEnumerable<long>
{
public static readonly long[] Value=A148022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148022.Bytes);
public long this[int i]=>Value[i];

public static A148022Inst Instance=new A148022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148023
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,17L,48L,112L,375L,995L,3275L,8876L,31891L,94113L,332788L,988399L,3711314L,11670675L,43086404L,135569589L,524171391L,1721594540L,6545887952L,21443044036L,84642973041L,286949416617L,1114660916146L,3762532807703L,15084773785655L,52390499421050L,206856697348630L,714656828323522L,2900243191235136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148023Inst : IEnumerable<long>
{
public static readonly long[] Value=A148023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148023.Bytes);
public long this[int i]=>Value[i];

public static A148023Inst Instance=new A148023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148024
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,17L,48L,122L,385L,1085L,3375L,10198L,33933L,108092L,360915L,1200813L,4160537L,14151588L,49403091L,173696887L,621438061L,2207940184L,7968530425L,29011615994L,106385931309L,389703992683L,1443181807466L,5383725194018L,20138557270914L,75459796182832L,285124650193756L,1082982696807654L,4118074811287305L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148024Inst : IEnumerable<long>
{
public static readonly long[] Value=A148024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148024.Bytes);
public long this[int i]=>Value[i];

public static A148024Inst Instance=new A148024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148025
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,17L,48L,122L,395L,1095L,3565L,10498L,36423L,113588L,400915L,1294654L,4695827L,15653358L,57750008L,197633230L,741156506L,2588878371L,9831118022L,34990852607L,134443887666L,485956154601L,1885108450335L,6907726533691L,27031307573009L,100253775053709L,395319971702985L,1481798570737401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148025Inst : IEnumerable<long>
{
public static readonly long[] Value=A148025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148025.Bytes);
public long this[int i]=>Value[i];

public static A148025Inst Instance=new A148025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148026
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,17L,50L,123L,396L,1073L,3584L,10339L,35708L,108047L,382030L,1198693L,4313758L,13924021L,50809793L,167788571L,619059420L,2082876857L,7753892022L,26497831246L,99373513569L,344089136230L,1298396791328L,4546613757388L,17245911614695L,60979103246505L,232332342270363L,828469298335246L,3168602775158065L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148026Inst : IEnumerable<long>
{
public static readonly long[] Value=A148026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148026.Bytes);
public long this[int i]=>Value[i];

public static A148026Inst Instance=new A148026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148027
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,17L,50L,123L,424L,1157L,4118L,11905L,44192L,134684L,512943L,1629383L,6357396L,20847452L,83017169L,279238026L,1129642409L,3880637177L,15899231818L,55624783220L,230299526462L,818618381183L,3420635838769L,12326916547038L,51935674211138L,189400178549430L,803816332741202L,2962211262398908L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148027Inst : IEnumerable<long>
{
public static readonly long[] Value=A148027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148027.Bytes);
public long this[int i]=>Value[i];

public static A148027Inst Instance=new A148027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148028
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,17L,50L,133L,434L,1275L,4246L,13515L,46550L,156419L,555534L,1951733L,7092896L,25736111L,95429785L,354788330L,1338863594L,5077947025L,19463581574L,75041004927L,291655368276L,1139929297661L,4484645500788L,17733661901866L,70514235062726L,281674503226354L,1130639774956010L,4557063998438378L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148028Inst : IEnumerable<long>
{
public static readonly long[] Value=A148028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148028.Bytes);
public long this[int i]=>Value[i];

public static A148028Inst Instance=new A148028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148029
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,17L,50L,133L,444L,1285L,4464L,13843L,49914L,163593L,610856L,2088251L,7990733L,28245697L,110166136L,400127699L,1586561639L,5894252839L,23698567732L,89752409685L,365114337371L,1405748118093L,5777029425175L,22561596032231L,93548973357243L,369931166153771L,1545961273469806L,6181098706942459L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148029Inst : IEnumerable<long>
{
public static readonly long[] Value=A148029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148029.Bytes);
public long this[int i]=>Value[i];

public static A148029Inst Instance=new A148029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148030
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,17L,51L,124L,377L,1022L,3227L,9549L,30594L,94752L,308328L,995440L,3313435L,11004039L,37111768L,125537597L,430051506L,1482855865L,5154990100L,17995511516L,63180065010L,223006649457L,792069518708L,2827088092087L,10130979648145L,36430022870106L,131512379743192L,476756297335430L,1735161308936077L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148030Inst : IEnumerable<long>
{
public static readonly long[] Value=A148030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148030.Bytes);
public long this[int i]=>Value[i];

public static A148030Inst Instance=new A148030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148031
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,17L,51L,124L,391L,1078L,3457L,10222L,33470L,105976L,352741L,1152698L,3894734L,13186214L,45455545L,156630035L,545896294L,1916833851L,6797318020L,24192288369L,86537326784L,311338858949L,1127841550001L,4103950196701L,14983432787528L,54911164910029L,202215706417259L,747845475495009L,2774088058155236L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148031Inst : IEnumerable<long>
{
public static readonly long[] Value=A148031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148031.Bytes);
public long this[int i]=>Value[i];

public static A148031Inst Instance=new A148031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148032
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,17L,51L,131L,407L,1151L,3648L,11252L,36653L,118809L,396854L,1329494L,4535199L,15607323L,54270912L,190374303L,673495642L,2399088521L,8606861861L,31077805874L,112828345565L,411949470606L,1511681054358L,5572207053222L,20632605392372L,76715149014356L,286295403263327L,1072428008443227L,4031011482598696L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148032Inst : IEnumerable<long>
{
public static readonly long[] Value=A148032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148032.Bytes);
public long this[int i]=>Value[i];

public static A148032Inst Instance=new A148032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148033
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,17L,51L,131L,421L,1207L,3878L,12057L,40118L,130680L,441485L,1497749L,5185040L,17987644L,63307623L,224664807L,803719579L,2891171202L,10485345696L,38262391388L,140319647872L,517205785586L,1916799857203L,7134782171482L,26659616659966L,100023181578858L,376737643518470L,1423639450605206L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148033Inst : IEnumerable<long>
{
public static readonly long[] Value=A148033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148033.Bytes);
public long this[int i]=>Value[i];

public static A148033Inst Instance=new A148033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148034
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,17L,53L,126L,417L,1085L,3802L,10606L,38490L,112222L,418270L,1269365L,4841684L,15139700L,58700203L,188206735L,740895946L,2427550418L,9670669705L,32250337866L,129828603088L,439937208900L,1787205873684L,6138540983094L,25131758572895L,87374979409409L,360251498822223L,1266021425020819L,5251892786594921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148034Inst : IEnumerable<long>
{
public static readonly long[] Value=A148034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148034.Bytes);
public long this[int i]=>Value[i];

public static A148034Inst Instance=new A148034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148035
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,17L,53L,126L,431L,1141L,4046L,11293L,42267L,125308L,476076L,1453581L,5712452L,18140643L,71884868L,232645573L,943383733L,3139026545L,12795771881L,43148544469L,178859656585L,615743018905L,2561534313985L,8906628231923L,37528126025030L,132601880616631L,560156057424649L,1994657576103465L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148035Inst : IEnumerable<long>
{
public static readonly long[] Value=A148035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148035.Bytes);
public long this[int i]=>Value[i];

public static A148035Inst Instance=new A148035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148036
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,17L,55L,137L,475L,1281L,4671L,13561L,51649L,158164L,619616L,1970703L,7889055L,25897272L,105597628L,355925249L,1472958168L,5073075343L,21248105272L,74525835058L,315355167249L,1123653233699L,4796820059745L,17327386969144L,74532011152878L,272468321876405L,1179733310810498L,4358597694512184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148036Inst : IEnumerable<long>
{
public static readonly long[] Value=A148036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148036.Bytes);
public long this[int i]=>Value[i];

public static A148036Inst Instance=new A148036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148037
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,17L,55L,137L,489L,1337L,4963L,14489L,56081L,172374L,685860L,2193107L,8924006L,29455832L,121957898L,413105672L,1734505507L,6003091829L,25496609376L,89865317945L,385361938143L,1379626758090L,5964466413469L,21644518493658L,94229149045835L,346030467616141L,1515554809560380L,5624080488702325L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148037Inst : IEnumerable<long>
{
public static readonly long[] Value=A148037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148037.Bytes);
public long this[int i]=>Value[i];

public static A148037Inst Instance=new A148037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148038
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,19L,53L,150L,435L,1373L,4234L,13803L,45615L,152565L,525436L,1807917L,6370454L,22648924L,81045274L,294605006L,1074167523L,3960848064L,14708826191L,54866285401L,206578823690L,780529431496L,2967546723380L,11346226883771L,43526990900201L,167962909112062L,650320995547081L,2527858507702086L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148038Inst : IEnumerable<long>
{
public static readonly long[] Value=A148038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148038.Bytes);
public long this[int i]=>Value[i];

public static A148038Inst Instance=new A148038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148039
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,19L,55L,145L,438L,1319L,4258L,13442L,44510L,148574L,512622L,1765355L,6199765L,21989638L,79344998L,287621419L,1052530049L,3883860734L,14482939260L,54310810535L,204858164609L,777520351881L,2972596559904L,11423778936131L,44092393135378L,170962910891491L,666445496840772L,2609633213350411L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148039Inst : IEnumerable<long>
{
public static readonly long[] Value=A148039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148039.Bytes);
public long this[int i]=>Value[i];

public static A148039Inst Instance=new A148039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148040
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,19L,55L,152L,475L,1462L,4746L,15587L,53395L,183704L,645336L,2304003L,8369954L,30628353L,113457813L,425476602L,1610303851L,6134996528L,23581388253L,91405898719L,356438621366L,1397836274856L,5518769111515L,21915664391127L,87424025172871L,350422697792128L,1411783576129019L,5711966700811943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148040Inst : IEnumerable<long>
{
public static readonly long[] Value=A148040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148040.Bytes);
public long this[int i]=>Value[i];

public static A148040Inst Instance=new A148040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148041
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,19L,57L,158L,498L,1539L,5153L,17072L,59518L,206979L,745464L,2692747L,9954863L,37024599L,139880339L,532405810L,2049337223L,7946429854L,31083121339L,122394588218L,485449765051L,1936684059573L,7774072536288L,31366998291556L,127230398294122L,518455863490298L,2122312706665651L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148041Inst : IEnumerable<long>
{
public static readonly long[] Value=A148041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148041.Bytes);
public long this[int i]=>Value[i];

public static A148041Inst Instance=new A148041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148042
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,19L,57L,165L,535L,1700L,5761L,19596L,69357L,247143L,904969L,3344222L,12578803L,47771691L,183784047L,713153652L,2795057882L,11038817438L,43945343994L,176118626035L,710510882943L,2883088313211L,11764647473938L,48250711908615L,198849105981280L,823144145532963L,3421816206647552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148042Inst : IEnumerable<long>
{
public static readonly long[] Value=A148042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148042.Bytes);
public long this[int i]=>Value[i];

public static A148042Inst Instance=new A148042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148043
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,19L,59L,160L,540L,1623L,5782L,18621L,69373L,235874L,905452L,3204843L,12614718L,46142381L,185206756L,695627226L,2838006420L,10897855854L,45068748877L,176317050793L,737653565662L,2932209752379L,12390079057651L,49934682230051L,212833823146874L,868150513527291L,3728495506882947L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148043Inst : IEnumerable<long>
{
public static readonly long[] Value=A148043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148043.Bytes);
public long this[int i]=>Value[i];

public static A148043Inst Instance=new A148043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148044
{
public static readonly long[] Value={ 1L,1L,2L,3L,10L,20L,58L,119L,418L,960L,3058L,6996L,25166L,61594L,204930L,496191L,1809682L,4597480L,15689026L,39347480L,144815566L,377111538L,1308570866L,3361896292L,12453614038L,33008818730L,115909050138L,303076342734L,1128183183958L,3030390874566L,10736386125842L,28453800826831L,106322156254386L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148044Inst : IEnumerable<long>
{
public static readonly long[] Value=A148044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148044.Bytes);
public long this[int i]=>Value[i];

public static A148044Inst Instance=new A148044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148045
{
public static readonly long[] Value={ 1L,1L,2L,3L,10L,20L,58L,119L,446L,1044L,3448L,7986L,31689L,79898L,281279L,694389L,2846170L,7495572L,27436672L,70493078L,295037033L,799668270L,3004460457L,7933577956L,33692390947L,93207860220L,356841845618L,961310281239L,4126690311286L,11592618439035L,45016592572833L,123137553148637L,532997729810330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148045Inst : IEnumerable<long>
{
public static readonly long[] Value=A148045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148045.Bytes);
public long this[int i]=>Value[i];

public static A148045Inst Instance=new A148045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148046
{
public static readonly long[] Value={ 1L,1L,2L,3L,10L,20L,58L,129L,456L,1134L,3548L,9794L,33807L,96578L,306887L,967425L,3255598L,10137930L,32871380L,110954830L,371459199L,1212221590L,4058086695L,14072357534L,47559861357L,159489386798L,550988433164L,1927971427275L,6601530164918L,22631882518193L,79913196165907L,280987658710751L,973663407984038L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148046Inst : IEnumerable<long>
{
public static readonly long[] Value=A148046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148046.Bytes);
public long this[int i]=>Value[i];

public static A148046Inst Instance=new A148046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148047
{
public static readonly long[] Value={ 1L,1L,2L,3L,10L,20L,58L,129L,466L,1144L,3828L,10104L,37281L,101810L,369043L,1061567L,3973614L,11649570L,44090410L,133431028L,508513935L,1566776842L,6059123603L,19007334896L,73793026201L,235333880634L,921738292786L,2975020974513L,11720384280152L,38315348976215L,151639320458975L,500740054300233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148047Inst : IEnumerable<long>
{
public static readonly long[] Value=A148047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148047.Bytes);
public long this[int i]=>Value[i];

public static A148047Inst Instance=new A148047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148048
{
public static readonly long[] Value={ 1L,1L,2L,3L,10L,20L,58L,139L,438L,1140L,3258L,9772L,28562L,85882L,251866L,805191L,2408942L,7397564L,23342986L,72959148L,230591190L,716489490L,2346086618L,7379407456L,23549213138L,76289251170L,246337916414L,799728360510L,2563657338846L,8524590676290L,27557309877842L,89945529675023L,296436681030158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148048Inst : IEnumerable<long>
{
public static readonly long[] Value=A148048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148048.Bytes);
public long this[int i]=>Value[i];

public static A148048Inst Instance=new A148048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148049
{
public static readonly long[] Value={ 1L,1L,2L,3L,10L,20L,58L,139L,438L,1140L,3418L,9932L,30628L,88108L,280662L,840825L,2681258L,8069994L,26491824L,81571012L,264345958L,834289608L,2744822564L,8655497466L,28654030002L,91833730268L,305378072266L,978386996766L,3289069655984L,10666263089892L,35684640821198L,116837930295941L,393934299599316L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148049Inst : IEnumerable<long>
{
public static readonly long[] Value=A148049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148049.Bytes);
public long this[int i]=>Value[i];

public static A148049Inst Instance=new A148049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148050
{
public static readonly long[] Value={ 1L,1L,2L,3L,10L,20L,58L,139L,458L,1160L,3818L,10392L,34670L,97442L,333818L,969459L,3328978L,9938088L,34450338L,104523080L,366290046L,1131762090L,3975840690L,12469787368L,44066215102L,139601191058L,496316131002L,1590475923282L,5665647301990L,18329790880270L,65557254590130L,213555494493479L,766770413340810L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148050Inst : IEnumerable<long>
{
public static readonly long[] Value=A148050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148050.Bytes);
public long this[int i]=>Value[i];

public static A148050Inst Instance=new A148050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148051
{
public static readonly long[] Value={ 1L,1L,2L,3L,10L,20L,63L,133L,488L,1134L,4159L,9977L,38619L,96551L,380001L,972913L,3913896L,10241310L,41846263L,111378893L,461040755L,1244667953L,5208010325L,14229194099L,60121447699L,165980137990L,706675809803L,1968160352808L,8441479695283L,23696553049202L,102251059507356L,289003009054919L,1253963610330642L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148051Inst : IEnumerable<long>
{
public static readonly long[] Value=A148051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148051.Bytes);
public long this[int i]=>Value[i];

public static A148051Inst Instance=new A148051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148052
{
public static readonly long[] Value={ 1L,1L,2L,3L,10L,20L,63L,133L,516L,1218L,4465L,10703L,44548L,113711L,450058L,1153535L,4996768L,13352786L,55352661L,147886291L,657261944L,1810272037L,7740475160L,21274221703L,96257801996L,270869293600L,1184198800343L,3322353778443L,15231848541136L,43555542439718L,193622102777095L,551782565099753L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148052Inst : IEnumerable<long>
{
public static readonly long[] Value=A148052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148052.Bytes);
public long this[int i]=>Value[i];

public static A148052Inst Instance=new A148052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148053
{
public static readonly long[] Value={ 1L,1L,2L,3L,10L,20L,68L,147L,502L,1140L,4144L,9922L,36386L,89466L,328014L,821631L,3085210L,7905952L,29799808L,77378450L,291573466L,764676082L,2917759330L,7750067028L,29633931858L,79340993790L,303289413308L,817097085372L,3147742901542L,8549940110218L,32980631719052L,90060584656107L,347313308917902L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148053Inst : IEnumerable<long>
{
public static readonly long[] Value=A148053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148053.Bytes);
public long this[int i]=>Value[i];

public static A148053Inst Instance=new A148053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148054
{
public static readonly long[] Value={ 1L,1L,2L,3L,10L,20L,68L,147L,530L,1224L,4408L,10516L,39378L,97474L,365038L,920535L,3501858L,9009592L,34248844L,89167304L,343038006L,905754654L,3484015834L,9277353140L,35924495108L,96578927300L,373891285428L,1011485913642L,3936897107170L,10729182442150L,41760445053660L,114370464498523L,446706120848602L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148054Inst : IEnumerable<long>
{
public static readonly long[] Value=A148054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148054.Bytes);
public long this[int i]=>Value[i];

public static A148054Inst Instance=new A148054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148055
{
public static readonly long[] Value={ 1L,1L,2L,3L,10L,20L,68L,147L,558L,1308L,4840L,11638L,45142L,112918L,431806L,1095775L,4299562L,11168048L,43431360L,113876158L,449752342L,1197311782L,4700292130L,12596627212L,49945553674L,135283990390L,534123243068L,1454033588472L,5779639647718L,15857393541418L,62837646837160L,173088744641491L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148055Inst : IEnumerable<long>
{
public static readonly long[] Value=A148055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148055.Bytes);
public long this[int i]=>Value[i];

public static A148055Inst Instance=new A148055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148056
{
public static readonly long[] Value={ 1L,1L,2L,3L,10L,22L,65L,152L,509L,1466L,4645L,13532L,44434L,146454L,483958L,1573257L,5245446L,18189431L,62918036L,215842095L,743114400L,2625979396L,9395162641L,33370716692L,118291958507L,424227452507L,1546163643295L,5636678152183L,20454730175647L,74489593325489L,274498234923989L,1018318442708743L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148056Inst : IEnumerable<long>
{
public static readonly long[] Value=A148056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148056.Bytes);
public long this[int i]=>Value[i];

public static A148056Inst Instance=new A148056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148057
{
public static readonly long[] Value={ 1L,1L,2L,3L,10L,22L,65L,166L,562L,1648L,5199L,16864L,57266L,191065L,643174L,2276667L,8015333L,28228639L,101105139L,370143123L,1348702341L,4928075168L,18351289405L,68700034715L,256666572281L,966636795221L,3682287354587L,14030329659617L,53521499184005L,206034637093149L,796949050223031L,3081474368398721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148057Inst : IEnumerable<long>
{
public static readonly long[] Value=A148057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148057.Bytes);
public long this[int i]=>Value[i];

public static A148057Inst Instance=new A148057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148058
{
public static readonly long[] Value={ 1L,1L,2L,3L,10L,22L,67L,154L,568L,1550L,5395L,14789L,57575L,175048L,652147L,1970803L,7935097L,25771324L,100086938L,321963277L,1326586894L,4506499578L,18002375075L,60497955037L,253509127261L,889894534837L,3628463886414L,12595624469633L,53465517732990L,192448886725638L,797022172851503L,2837071346803048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148058Inst : IEnumerable<long>
{
public static readonly long[] Value=A148058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148058.Bytes);
public long this[int i]=>Value[i];

public static A148058Inst Instance=new A148058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148059
{
public static readonly long[] Value={ 1L,1L,2L,3L,10L,22L,71L,174L,653L,1814L,6915L,20546L,82095L,257809L,1056914L,3465493L,14500386L,49162222L,209454739L,730286285L,3154572233L,11256937646L,49204919325L,179067026571L,790635748409L,2926364462640L,13031956988866L,48947868670643L,219613554134575L,835550047444947L,3773438077994772L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148059Inst : IEnumerable<long>
{
public static readonly long[] Value=A148059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148059.Bytes);
public long this[int i]=>Value[i];

public static A148059Inst Instance=new A148059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148060
{
public static readonly long[] Value={ 1L,1L,2L,3L,12L,25L,77L,161L,676L,1629L,5631L,13233L,56856L,146445L,534726L,1335663L,5817552L,15578341L,58752167L,152411825L,669911668L,1840568181L,7092254088L,18880772519L,83533908814L,233748333865L,914652294617L,2481366615201L,11032801951506L,31299828328161L,123901443023541L,341011261634337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148060Inst : IEnumerable<long>
{
public static readonly long[] Value=A148060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148060.Bytes);
public long this[int i]=>Value[i];

public static A148060Inst Instance=new A148060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148061
{
public static readonly long[] Value={ 1L,1L,2L,3L,12L,25L,77L,181L,696L,1809L,5831L,17449L,61892L,186457L,600842L,2051147L,6945364L,22680521L,75134871L,268438305L,907010728L,3061029857L,10612359584L,37969347183L,130531373630L,448942777209L,1612222313869L,5736135981173L,20029567607770L,70478817022013L,256828452008261L,914595405417761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148061Inst : IEnumerable<long>
{
public static readonly long[] Value=A148061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148061.Bytes);
public long this[int i]=>Value[i];

public static A148061Inst Instance=new A148061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148062
{
public static readonly long[] Value={ 1L,1L,2L,3L,12L,25L,77L,181L,696L,1809L,5991L,17609L,63958L,188683L,653258L,2112627L,7535840L,23721089L,85713509L,286499693L,1026150382L,3374608955L,12502467560L,42456829669L,153777339420L,523923695731L,1958207627323L,6732073221545L,24744903814780L,86428974845565L,323611236508025L,1126150114881781L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148062Inst : IEnumerable<long>
{
public static readonly long[] Value=A148062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148062.Bytes);
public long this[int i]=>Value[i];

public static A148062Inst Instance=new A148062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148063
{
public static readonly long[] Value={ 1L,1L,2L,3L,12L,25L,77L,181L,716L,1829L,6571L,18269L,70996L,201473L,781810L,2337483L,9127008L,27781965L,110943651L,346119897L,1377659748L,4386994929L,17681473032L,57009873027L,230888035146L,756580283257L,3072648844241L,10174862781405L,41615444481006L,139228467433317L,570476590959141L,1927512584564957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148063Inst : IEnumerable<long>
{
public static readonly long[] Value=A148063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148063.Bytes);
public long this[int i]=>Value[i];

public static A148063Inst Instance=new A148063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148064
{
public static readonly long[] Value={ 1L,1L,2L,3L,12L,25L,77L,201L,716L,1989L,6191L,20565L,67734L,215087L,713712L,2478469L,8338392L,27654245L,97731829L,339498647L,1168538528L,4069674521L,14553720972L,51368033395L,179774661926L,647707788441L,2325800861917L,8285237018781L,29798207595310L,108258428232621L,392093814282707L,1413452299369805L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148064Inst : IEnumerable<long>
{
public static readonly long[] Value=A148064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148064.Bytes);
public long this[int i]=>Value[i];

public static A148064Inst Instance=new A148064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148065
{
public static readonly long[] Value={ 1L,1L,2L,3L,12L,25L,77L,201L,736L,2009L,7091L,21545L,78274L,237897L,903894L,2872275L,10734876L,35317989L,135653517L,448156807L,1740713832L,5905699865L,22903738044L,78582846753L,310297396582L,1073392254315L,4242820759859L,14918080113383L,59228120312530L,209118568989577L,838914634762489L,2988126622770495L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148065Inst : IEnumerable<long>
{
public static readonly long[] Value=A148065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148065.Bytes);
public long this[int i]=>Value[i];

public static A148065Inst Instance=new A148065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148066
{
public static readonly long[] Value={ 1L,1L,2L,3L,12L,25L,87L,189L,760L,1809L,7305L,18007L,74346L,189189L,801954L,2096447L,8935024L,23759693L,102684825L,277639875L,1210611350L,3316240457L,14535629368L,40233950255L,177800903860L,497069933555L,2205417993827L,6213590376519L,27705013475520L,78620729029039L,352058669816049L,1005414336636801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148066Inst : IEnumerable<long>
{
public static readonly long[] Value=A148066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148066.Bytes);
public long this[int i]=>Value[i];

public static A148066Inst Instance=new A148066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148067
{
public static readonly long[] Value={ 1L,1L,2L,3L,12L,25L,87L,189L,788L,1893L,7569L,18601L,80506L,207493L,874156L,2280579L,10100264L,27140517L,117684741L,318421209L,1430927370L,3951930221L,17460909038L,48431305459L,219878196682L,619212387825L,2771909420147L,7828026283149L,35809758410988L,102329069152021L,462524102337463L,1324171950218941L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148067Inst : IEnumerable<long>
{
public static readonly long[] Value=A148067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148067.Bytes);
public long this[int i]=>Value[i];

public static A148067Inst Instance=new A148067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148068
{
public static readonly long[] Value={ 1L,1L,2L,3L,12L,25L,87L,189L,844L,2061L,8265L,20317L,94014L,246389L,1051736L,2752635L,12971752L,35409589L,156545721L,425681757L,2028643354L,5687451021L,25714495202L,71753924987L,344569097136L,984453928825L,4520756671327L,12852585508149L,62061211995954L,179832324062041L,835295154466845L,2408594166730577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148068Inst : IEnumerable<long>
{
public static readonly long[] Value=A148068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148068.Bytes);
public long this[int i]=>Value[i];

public static A148068Inst Instance=new A148068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148069
{
public static readonly long[] Value={ 1L,1L,2L,3L,12L,25L,97L,217L,872L,2073L,8739L,21791L,94168L,242515L,1052724L,2768883L,12208052L,32759425L,146062195L,398210911L,1784256044L,4923235527L,22189335102L,61880489173L,280668260110L,790141842345L,3597552961167L,10206542166177L,46623204529182L,133170203047901L,610549741362451L,1754713551161917L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148069Inst : IEnumerable<long>
{
public static readonly long[] Value=A148069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148069.Bytes);
public long this[int i]=>Value[i];

public static A148069Inst Instance=new A148069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148070
{
public static readonly long[] Value={ 1L,1L,2L,3L,12L,25L,97L,217L,984L,2409L,10215L,25487L,118874L,312013L,1396444L,3700827L,17618644L,48201953L,221644603L,608941279L,2931135298L,8236542965L,38529196470L,108470810209L,526019556566L,1506349925585L,7129197496267L,20427829442487L,99578663297064L,289201492121849L,1380244537295549L,4008026266125961L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148070Inst : IEnumerable<long>
{
public static readonly long[] Value=A148070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148070.Bytes);
public long this[int i]=>Value[i];

public static A148070Inst Instance=new A148070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148071
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,21L,51L,143L,374L,1071L,3095L,8934L,26170L,77812L,239576L,719583L,2245728L,7027771L,21874554L,68780246L,217957471L,699596665L,2221050242L,7204830752L,23364983444L,75490995551L,245743450650L,803146080439L,2641243592039L,8638752159115L,28638848337491L,94831340109958L,313328526209055L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148071Inst : IEnumerable<long>
{
public static readonly long[] Value=A148071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148071.Bytes);
public long this[int i]=>Value[i];

public static A148071Inst Instance=new A148071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148072
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,21L,56L,148L,421L,1207L,3535L,10407L,31879L,97111L,304344L,958636L,3045621L,9696563L,31478459L,101764723L,334038583L,1100234409L,3639933291L,12057585459L,40418753669L,135042191401L,455549125751L,1540601216083L,5223311667307L,17725604119599L,60646085848546L,206928271796266L,710805289086933L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148072Inst : IEnumerable<long>
{
public static readonly long[] Value=A148072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148072.Bytes);
public long this[int i]=>Value[i];

public static A148072Inst Instance=new A148072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148073
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,21L,56L,153L,431L,1269L,3748L,11283L,34892L,109201L,346671L,1113914L,3599997L,11754161L,38738445L,128543670L,429827021L,1444670782L,4879545858L,16575721093L,56568953256L,193962159926L,667744908521L,2306563486959L,7996271742308L,27813368946061L,97050437964778L,339653854810804L,1191781442742137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148073Inst : IEnumerable<long>
{
public static readonly long[] Value=A148073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148073.Bytes);
public long this[int i]=>Value[i];

public static A148073Inst Instance=new A148073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148074
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,21L,56L,164L,472L,1443L,4442L,13543L,42538L,140125L,461051L,1540007L,5230724L,17608645L,59481321L,206130290L,720298004L,2523815677L,8951596054L,31724219609L,111972880599L,399889272475L,1443126871712L,5216771470535L,18978785870361L,69268966498148L,251874465187235L,919122479206908L,3382867597156114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148074Inst : IEnumerable<long>
{
public static readonly long[] Value=A148074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148074.Bytes);
public long this[int i]=>Value[i];

public static A148074Inst Instance=new A148074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148075
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,21L,56L,169L,482L,1505L,4655L,14419L,46683L,153632L,522567L,1760914L,6050077L,20830801L,72215812L,256321026L,908687720L,3272602542L,11754785559L,42458425816L,154767487534L,565357807589L,2092065007291L,7725542715670L,28717905731799L,106970060346082L,399403757982693L,1504067532147492L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148075Inst : IEnumerable<long>
{
public static readonly long[] Value=A148075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148075.Bytes);
public long this[int i]=>Value[i];

public static A148075Inst Instance=new A148075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148076
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,21L,61L,174L,529L,1641L,5095L,16033L,53457L,179040L,611600L,2114005L,7286191L,25434141L,90624740L,324820786L,1175997883L,4277780903L,15565099278L,57172451188L,211915699815L,789384452140L,2957220530771L,11099880354961L,41758569166532L,158093763382620L,601507196523586L,2297362832884187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148076Inst : IEnumerable<long>
{
public static readonly long[] Value=A148076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148076.Bytes);
public long this[int i]=>Value[i];

public static A148076Inst Instance=new A148076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148077
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,24L,60L,171L,482L,1397L,4253L,12734L,39807L,124496L,393876L,1271415L,4091866L,13406172L,44050521L,145678352L,486558215L,1626299970L,5484672863L,18549475207L,63002376085L,215196629904L,736195482482L,2531826112640L,8727353541961L,30175242044617L,104712273647938L,363933649177806L,1269272249934532L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148077Inst : IEnumerable<long>
{
public static readonly long[] Value=A148077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148077.Bytes);
public long this[int i]=>Value[i];

public static A148077Inst Instance=new A148077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148078
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,24L,60L,187L,533L,1633L,5160L,15870L,53517L,171668L,585244L,1975988L,6674839L,23482783L,80233596L,286909515L,1007392268L,3586586050L,12951852657L,46106951430L,169300422921L,610788829219L,2244880160948L,8256288325005L,30256079492301L,112973372869465L,416123464655364L,1560839118401024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148078Inst : IEnumerable<long>
{
public static readonly long[] Value=A148078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148078.Bytes);
public long this[int i]=>Value[i];

public static A148078Inst Instance=new A148078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148079
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,24L,63L,183L,537L,1618L,5055L,15861L,51109L,166314L,547505L,1827009L,6133802L,20809959L,71063163L,244205379L,844896468L,2936454598L,10260887025L,36010311788L,126874109569L,448803378080L,1592742931810L,5671060122989L,20251948686857L,72515863744189L,260339300061495L,936826545096596L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148079Inst : IEnumerable<long>
{
public static readonly long[] Value=A148079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148079.Bytes);
public long this[int i]=>Value[i];

public static A148079Inst Instance=new A148079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148080
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,24L,63L,199L,588L,1854L,6186L,19807L,67858L,232652L,807683L,2855387L,10155678L,36943753L,133283070L,490587798L,1824978741L,6745329088L,25387210981L,95888617570L,362818250454L,1383558309095L,5303541508493L,20420961071190L,78692710853813L,305683656774197L,1191240685138316L,4639998004350009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148080Inst : IEnumerable<long>
{
public static readonly long[] Value=A148080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148080.Bytes);
public long this[int i]=>Value[i];

public static A148080Inst Instance=new A148080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148081
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,24L,65L,192L,580L,1769L,5600L,18261L,60327L,204364L,695916L,2390408L,8372916L,29567259L,105555351L,380076126L,1372150571L,4999652704L,18372034289L,67871175118L,252393439474L,941509545219L,3525458643396L,13285908529457L,50291134312222L,191155727584836L,729023307273060L,2786384917159514L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148081Inst : IEnumerable<long>
{
public static readonly long[] Value=A148081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148081.Bytes);
public long this[int i]=>Value[i];

public static A148081Inst Instance=new A148081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148082
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,24L,65L,197L,590L,1831L,5907L,19246L,65628L,223075L,772202L,2715962L,9613099L,34850427L,126250204L,462501869L,1709044861L,6342910025L,23890157291L,89977511284L,341462174862L,1302976354195L,4987822604239L,19285789090167L,74581371919137L,290008960011264L,1132019544597872L,4429381684162681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148082Inst : IEnumerable<long>
{
public static readonly long[] Value=A148082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148082.Bytes);
public long this[int i]=>Value[i];

public static A148082Inst Instance=new A148082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148083
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,24L,68L,204L,635L,2048L,6684L,22581L,77989L,271706L,968228L,3500939L,12729468L,47024807L,175664979L,658360378L,2498042454L,9560670342L,36669158456L,142032179940L,553961114253L,2163565785558L,8518522634671L,33731910890175L,133687274886976L,533438652268653L,2138794101079053L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148083Inst : IEnumerable<long>
{
public static readonly long[] Value=A148083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148083.Bytes);
public long this[int i]=>Value[i];

public static A148083Inst Instance=new A148083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148084
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,24L,68L,209L,645L,2110L,7049L,23776L,84050L,297599L,1072298L,3959753L,14643758L,55107010L,209726918L,802227580L,3108865505L,12121597818L,47579974069L,188383403156L,749420131640L,3000330585064L,12082350090766L,48870669671270L,198714418653910L,811557507388532L,3327859096146249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148084Inst : IEnumerable<long>
{
public static readonly long[] Value=A148084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148084.Bytes);
public long this[int i]=>Value[i];

public static A148084Inst Instance=new A148084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148085
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,27L,72L,227L,708L,2223L,7676L,25430L,89027L,315152L,1111571L,4083639L,14835745L,54972549L,206172592L,771640657L,2944008745L,11222552195L,43125977024L,167242399629L,648464893456L,2539375564202L,9966074965351L,39263987655425L,155693239075679L,617924738330054L,2466007594800224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148085Inst : IEnumerable<long>
{
public static readonly long[] Value=A148085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148085.Bytes);
public long this[int i]=>Value[i];

public static A148085Inst Instance=new A148085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148086
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,22L,59L,149L,396L,1041L,2907L,7760L,21816L,60298L,169741L,475054L,1359128L,3816950L,10972685L,31304334L,89879700L,257711500L,747124581L,2144777317L,6229523512L,18035524556L,52361269786L,152014079572L,443837403206L,1288731108002L,3768163857728L,11001149176426L,32145852887328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148086Inst : IEnumerable<long>
{
public static readonly long[] Value=A148086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148086.Bytes);
public long this[int i]=>Value[i];

public static A148086Inst Instance=new A148086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148087
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,23L,67L,176L,542L,1543L,4877L,14356L,47083L,143445L,480083L,1507064L,5092272L,16235880L,55737752L,180527103L,626181805L,2059548580L,7179842453L,23828111246L,83800665215L,280652471697L,993179081013L,3357496019781L,11918701536097L,40528744480241L,144678133648536L,494906147902751L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148087Inst : IEnumerable<long>
{
public static readonly long[] Value=A148087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148087.Bytes);
public long this[int i]=>Value[i];

public static A148087Inst Instance=new A148087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148088
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,24L,68L,191L,571L,1723L,5293L,16671L,53094L,172307L,563812L,1861398L,6205635L,20824194L,70511559L,240014778L,821599856L,2827041912L,9769219609L,33929479056L,118266254690L,413775330014L,1452493361222L,5113896832373L,18062859626325L,63964741855443L,227106603716388L,808239933828179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148088Inst : IEnumerable<long>
{
public static readonly long[] Value=A148088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148088.Bytes);
public long this[int i]=>Value[i];

public static A148088Inst Instance=new A148088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148089
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,24L,69L,193L,590L,1764L,5563L,17405L,56664L,183567L,610476L,2021736L,6829184L,23033270L,78880450L,269888858L,933922349L,3230929825L,11279210350L,39390678315L,138553842436L,487618273180L,1725964559833L,6113971964633L,21760644309885L,77519044920785L,277226106750016L,992352935678065L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148089Inst : IEnumerable<long>
{
public static readonly long[] Value=A148089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148089.Bytes);
public long this[int i]=>Value[i];

public static A148089Inst Instance=new A148089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148090
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,24L,74L,214L,695L,2166L,7106L,23361L,80689L,278290L,986215L,3470804L,12422826L,44857992L,164333810L,605851165L,2248012785L,8356195207L,31310333219L,118096170532L,448467623116L,1710002315918L,6536696182906L,25065265795150L,96586728914920L,373879518394390L,1452827184593812L,5658040612566495L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148090Inst : IEnumerable<long>
{
public static readonly long[] Value=A148090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148090.Bytes);
public long this[int i]=>Value[i];

public static A148090Inst Instance=new A148090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148091
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,24L,75L,216L,714L,2207L,7436L,24191L,86048L,293747L,1067294L,3730715L,13746151L,49287908L,185552315L,679296274L,2582590609L,9579477462L,36808351636L,138548906824L,538038570723L,2047494127395L,8001858907158L,30725643664976L,120983795801398L,468789378026079L,1857083738842685L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148091Inst : IEnumerable<long>
{
public static readonly long[] Value=A148091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148091.Bytes);
public long this[int i]=>Value[i];

public static A148091Inst Instance=new A148091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148092
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,52L,203L,876L,4131L,21065L,115274L,672673L,4163743L,27216840L,187160429L,1349511178L,10173555345L,79982663997L,654277037674L,5557624876513L,48931106059451L,445790174654588L,4196351007814659L,40757862664061104L,407944375184911787L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148092Inst : IEnumerable<long>
{
public static readonly long[] Value=A148092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148092.Bytes);
public long this[int i]=>Value[i];

public static A148092Inst Instance=new A148092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148093
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,25L,70L,212L,639L,2000L,6451L,21617L,71791L,246306L,858806L,3031680L,10707284L,38611784L,140802398L,514700655L,1893610027L,7056144208L,26475930759L,99365898413L,375942742181L,1434074803915L,5489981644607L,21037233338679L,81212735932262L,315232763329880L,1225469410310123L,4774478236859757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148093Inst : IEnumerable<long>
{
public static readonly long[] Value=A148093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148093.Bytes);
public long this[int i]=>Value[i];

public static A148093Inst Instance=new A148093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148094
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,25L,75L,217L,686L,2136L,7143L,23473L,81750L,280112L,1000476L,3529443L,12926899L,46740449L,174248545L,642573826L,2432741851L,9116884251L,34979496027L,132930156161L,515588023612L,1982470289972L,7765603476152L,30166998260556L,119166643516657L,467106203960011L,1859074152674149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148094Inst : IEnumerable<long>
{
public static readonly long[] Value=A148094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148094.Bytes);
public long this[int i]=>Value[i];

public static A148094Inst Instance=new A148094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148095
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,25L,75L,222L,696L,2203L,7371L,24787L,86008L,301117L,1077079L,3884641L,14241326L,52666805L,196980204L,742074660L,2821601164L,10806383704L,41688390675L,161765527299L,631511352222L,2479059137090L,9782815644799L,38784291290400L,154442952504946L,617627277390419L,2479845218105827L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148095Inst : IEnumerable<long>
{
public static readonly long[] Value=A148095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148095.Bytes);
public long this[int i]=>Value[i];

public static A148095Inst Instance=new A148095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148096
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,25L,76L,231L,743L,2389L,7896L,26880L,93731L,332056L,1186315L,4276398L,15613592L,57674835L,215106287L,807023678L,3045302991L,11566813790L,44234290091L,170156563119L,657452881298L,2550494701625L,9935922370990L,38875057057452L,152697762641138L,601752794728566L,2378478902181928L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148096Inst : IEnumerable<long>
{
public static readonly long[] Value=A148096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148096.Bytes);
public long this[int i]=>Value[i];

public static A148096Inst Instance=new A148096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148097
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,26L,72L,210L,633L,1965L,6255L,20320L,67115L,225180L,765236L,2629300L,9128886L,31973878L,112868208L,401357573L,1436347656L,5170091107L,18710588629L,68041269378L,248527107385L,911543126026L,3355925436811L,12398020132566L,45952857513263L,170833589869361L,636858717536370L,2380437498466650L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148097Inst : IEnumerable<long>
{
public static readonly long[] Value=A148097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148097.Bytes);
public long this[int i]=>Value[i];

public static A148097Inst Instance=new A148097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148098
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,26L,72L,226L,684L,2201L,7370L,24777L,85667L,300962L,1080541L,3892497L,14248086L,53141562L,197833744L,746885311L,2853338098L,10921983580L,42150766750L,164034497858L,641789674983L,2518722296593L,9956335914662L,39595246582945L,157622034823680L,631255495574749L,2541632161450543L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148098Inst : IEnumerable<long>
{
public static readonly long[] Value=A148098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148098.Bytes);
public long this[int i]=>Value[i];

public static A148098Inst Instance=new A148098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148099
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,26L,76L,223L,702L,2214L,7304L,24164L,82489L,282164L,987881L,3463409L,12359141L,44151318L,159911910L,579698430L,2124693327L,7792875067L,28839353888L,106787736502L,398354778453L,1486699269986L,5582988776700L,20973971137343L,79208990291815L,299233839402802L,1135531152080614L,4310296717819132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148099Inst : IEnumerable<long>
{
public static readonly long[] Value=A148099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148099.Bytes);
public long this[int i]=>Value[i];

public static A148099Inst Instance=new A148099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148100
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,26L,76L,239L,753L,2540L,8572L,30128L,106501L,387844L,1422789L,5316121L,20099588L,76671429L,296355338L,1151184226L,4524804463L,17853802855L,71134139857L,284557313732L,1146559570375L,4641910594671L,18885060480277L,77240337339152L,316960064504831L,1307542974531887L,5407643110588584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148100Inst : IEnumerable<long>
{
public static readonly long[] Value=A148100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148100.Bytes);
public long this[int i]=>Value[i];

public static A148100Inst Instance=new A148100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148101
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,26L,77L,231L,731L,2363L,7920L,27084L,94817L,336983L,1216568L,4453388L,16502271L,61814816L,233856348L,892573723L,3434288432L,13314937000L,51972107496L,204140373934L,806591451331L,3204158551284L,12792440649653L,51316797101243L,206757825981157L,836465018168185L,3397296971539772L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148101Inst : IEnumerable<long>
{
public static readonly long[] Value=A148101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148101.Bytes);
public long this[int i]=>Value[i];

public static A148101Inst Instance=new A148101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148102
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,26L,77L,236L,741L,2430L,8179L,28208L,99475L,356501L,1296199L,4783652L,17871126L,67465415L,257298969L,989810000L,3838658082L,15001356476L,59013879343L,233616780902L,930237304959L,3723778727143L,14981506373914L,60554119697080L,245812410995518L,1001928721763590L,4099422669401518L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148102Inst : IEnumerable<long>
{
public static readonly long[] Value=A148102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148102.Bytes);
public long this[int i]=>Value[i];

public static A148102Inst Instance=new A148102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148103
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,26L,81L,244L,819L,2695L,9463L,32922L,120808L,437836L,1659640L,6217694L,24120576L,92725987L,366692792L,1438275924L,5781789727L,23060129968L,93964095455L,380158396326L,1566773918574L,6416020471974L,26705782715536L,110498732504920L,463940330488819L,1937038870676946L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148103Inst : IEnumerable<long>
{
public static readonly long[] Value=A148103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148103.Bytes);
public long this[int i]=>Value[i];

public static A148103Inst Instance=new A148103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A148104
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,26L,81L,249L,829L,2781L,9734L,34536L,126493L,467981L,1772281L,6773484L,26300887L,103087732L,408575953L,1633521878L,6587707484L,26766158187L,109535161586L,451095906037L,1868996075017L,7786154256547L,32603467462740L,137177326830502L,579721759893509L,2460236646799349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A148104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A148104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A148104Inst : IEnumerable<long>
{
public static readonly long[] Value=A148104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A148104.Bytes);
public long this[int i]=>Value[i];

public static A148104Inst Instance=new A148104Inst();

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