using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A009994
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,12L,13L,14L,15L,16L,17L,18L,19L,22L,23L,24L,25L,26L,27L,28L,29L,33L,34L,35L,36L,37L,38L,39L,44L,45L,46L,47L,48L,49L,55L,56L,57L,58L,59L,66L,67L,68L,69L,77L,78L,79L,88L,89L,99L,111L,112L,113L,114L,115L,116L,117L,118L,119L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009994Inst : IEnumerable<long>
{
public static readonly long[] Value=A009994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009994.Bytes);
public long this[int i]=>Value[i];

public static A009994Inst Instance=new A009994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009993
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,12L,13L,14L,15L,16L,17L,18L,19L,23L,24L,25L,26L,27L,28L,29L,34L,35L,36L,37L,38L,39L,45L,46L,47L,48L,49L,56L,57L,58L,59L,67L,68L,69L,78L,79L,89L,123L,124L,125L,126L,127L,128L,129L,134L,135L,136L,137L,138L,139L,145L,146L,147L,148L,149L,156L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009993Inst : IEnumerable<long>
{
public static readonly long[] Value=A009993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009993.Bytes);
public long this[int i]=>Value[i];

public static A009993Inst Instance=new A009993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009992
{
public static readonly BigInteger[] Value={ 1L,48L,2304L,110592L,5308416L,254803968L,12230590464L,587068342272L,28179280429056L,1352605460594688L,64925062108545024L,3116402981210161152L,BigInteger.Parse("149587343098087735296"),BigInteger.Parse("7180192468708211294208"),BigInteger.Parse("344649238497994142121984"),BigInteger.Parse("16543163447903718821855232") };
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
public class A009992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009992Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009992.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A009992.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009992Inst Instance=new A009992Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009991
{
public static readonly BigInteger[] Value={ 1L,47L,2209L,103823L,4879681L,229345007L,10779215329L,506623120463L,23811286661761L,1119130473102767L,52599132235830049L,2472159215084012303L,BigInteger.Parse("116191483108948578241"),BigInteger.Parse("5460999706120583177327") };
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
public class A009991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009991Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009991.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A009991.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009991Inst Instance=new A009991Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009990
{
public static readonly BigInteger[] Value={ 1L,46L,2116L,97336L,4477456L,205962976L,9474296896L,435817657216L,20047612231936L,922190162669056L,42420747482776576L,1951354384207722496L,BigInteger.Parse("89762301673555234816"),BigInteger.Parse("4129065876983540801536"),BigInteger.Parse("189937030341242876870656") };
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
public class A009990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009990Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009990.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A009990.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009990Inst Instance=new A009990Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009989
{
public static readonly BigInteger[] Value={ 1L,45L,2025L,91125L,4100625L,184528125L,8303765625L,373669453125L,16815125390625L,756680642578125L,34050628916015625L,1532278301220703125L,BigInteger.Parse("68952523554931640625"),BigInteger.Parse("3102863559971923828125"),BigInteger.Parse("139628860198736572265625") };
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
public class A009989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009989Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009989.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A009989.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009989Inst Instance=new A009989Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009988
{
public static readonly BigInteger[] Value={ 1L,44L,1936L,85184L,3748096L,164916224L,7256313856L,319277809664L,14048223625216L,618121839509504L,27197360938418176L,1196683881290399744L,BigInteger.Parse("52654090776777588736"),BigInteger.Parse("2316779994178213904384"),BigInteger.Parse("101938319743841411792896") };
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
public class A009988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009988Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009988.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A009988.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009988Inst Instance=new A009988Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009987
{
public static readonly BigInteger[] Value={ 1L,43L,1849L,79507L,3418801L,147008443L,6321363049L,271818611107L,11688200277601L,502592611936843L,21611482313284249L,929293739471222707L,BigInteger.Parse("39959630797262576401"),BigInteger.Parse("1718264124282290785243"),BigInteger.Parse("73885357344138503765449") };
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
public class A009987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009987Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009987.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A009987.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009987Inst Instance=new A009987Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009986
{
public static readonly BigInteger[] Value={ 1L,42L,1764L,74088L,3111696L,130691232L,5489031744L,230539333248L,9682651996416L,406671383849472L,17080198121677824L,717368321110468608L,BigInteger.Parse("30129469486639681536"),BigInteger.Parse("1265437718438866624512"),BigInteger.Parse("53148384174432398229504") };
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
public class A009986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009986Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009986.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A009986.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009986Inst Instance=new A009986Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009985
{
public static readonly BigInteger[] Value={ 1L,41L,1681L,68921L,2825761L,115856201L,4750104241L,194754273881L,7984925229121L,327381934393961L,13422659310152401L,550329031716248441L,BigInteger.Parse("22563490300366186081"),BigInteger.Parse("925103102315013629321"),BigInteger.Parse("37929227194915558802161") };
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
public class A009985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009985Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009985.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A009985.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009985Inst Instance=new A009985Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009984
{
public static readonly BigInteger[] Value={ 1L,40L,1600L,64000L,2560000L,102400000L,4096000000L,163840000000L,6553600000000L,262144000000000L,10485760000000000L,419430400000000000L,16777216000000000000UL,BigInteger.Parse("671088640000000000000"),BigInteger.Parse("26843545600000000000000") };
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
public class A009984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009984Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009984.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A009984.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009984Inst Instance=new A009984Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009983
{
public static readonly BigInteger[] Value={ 1L,39L,1521L,59319L,2313441L,90224199L,3518743761L,137231006679L,5352009260481L,208728361158759L,8140406085191601L,317475837322472439L,12381557655576425121UL,BigInteger.Parse("482880748567480579719"),BigInteger.Parse("18832349194131742609041") };
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
public class A009983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009983Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009983.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A009983.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009983Inst Instance=new A009983Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009982
{
public static readonly BigInteger[] Value={ 1L,38L,1444L,54872L,2085136L,79235168L,3010936384L,114415582592L,4347792138496L,165216101262848L,6278211847988224L,238572050223552512L,9065737908494995456L,BigInteger.Parse("344498040522809827328"),BigInteger.Parse("13090925539866773438464"),BigInteger.Parse("497455170514937390661632") };
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
public class A009982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009982Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009982.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A009982.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009982Inst Instance=new A009982Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009981
{
public static readonly BigInteger[] Value={ 1L,37L,1369L,50653L,1874161L,69343957L,2565726409L,94931877133L,3512479453921L,129961739795077L,4808584372417849L,177917621779460413L,6582952005840035281L,BigInteger.Parse("243569224216081305397"),BigInteger.Parse("9012061295995008299689") };
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
public class A009981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009981Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009981.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A009981.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009981Inst Instance=new A009981Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009980
{
public static readonly BigInteger[] Value={ 1L,36L,1296L,46656L,1679616L,60466176L,2176782336L,78364164096L,2821109907456L,101559956668416L,3656158440062976L,131621703842267136L,4738381338321616896L,BigInteger.Parse("170581728179578208256"),BigInteger.Parse("6140942214464815497216") };
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
public class A009980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009980Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009980.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A009980.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009980Inst Instance=new A009980Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009979
{
public static readonly BigInteger[] Value={ 1L,35L,1225L,42875L,1500625L,52521875L,1838265625L,64339296875L,2251875390625L,78815638671875L,2758547353515625L,96549157373046875L,3379220508056640625L,BigInteger.Parse("118272717781982421875"),BigInteger.Parse("4139545122369384765625") };
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
public class A009979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009979Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009979.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A009979.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009979Inst Instance=new A009979Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009978
{
public static readonly BigInteger[] Value={ 1L,34L,1156L,39304L,1336336L,45435424L,1544804416L,52523350144L,1785793904896L,60716992766464L,2064377754059776L,70188843638032384L,2386420683693101056L,BigInteger.Parse("81138303245565435904"),BigInteger.Parse("2758702310349224820736") };
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
public class A009978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009978Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009978.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A009978.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009978Inst Instance=new A009978Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009977
{
public static readonly BigInteger[] Value={ 1L,33L,1089L,35937L,1185921L,39135393L,1291467969L,42618442977L,1406408618241L,46411484401953L,1531578985264449L,50542106513726817L,1667889514952984961L,BigInteger.Parse("55040353993448503713"),BigInteger.Parse("1816331681783800622529") };
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
public class A009977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009977Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009977.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A009977.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009977Inst Instance=new A009977Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009976
{
public static readonly BigInteger[] Value={ 1L,32L,1024L,32768L,1048576L,33554432L,1073741824L,34359738368L,1099511627776L,35184372088832L,1125899906842624L,36028797018963968L,1152921504606846976L,BigInteger.Parse("36893488147419103232"),BigInteger.Parse("1180591620717411303424") };
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
public class A009976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009976Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009976.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A009976.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009976Inst Instance=new A009976Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009975
{
public static readonly BigInteger[] Value={ 1L,31L,961L,29791L,923521L,28629151L,887503681L,27512614111L,852891037441L,26439622160671L,819628286980801L,25408476896404831L,787662783788549761L,BigInteger.Parse("24417546297445042591"),BigInteger.Parse("756943935220796320321"),BigInteger.Parse("23465261991844685929951") };
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
public class A009975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009975Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009975.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A009975.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009975Inst Instance=new A009975Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009974
{
public static readonly BigInteger[] Value={ 1L,30L,900L,27000L,810000L,24300000L,729000000L,21870000000L,656100000000L,19683000000000L,590490000000000L,17714700000000000L,531441000000000000L,15943230000000000000UL,BigInteger.Parse("478296900000000000000"),BigInteger.Parse("14348907000000000000000") };
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
public class A009974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009974Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009974.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A009974.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009974Inst Instance=new A009974Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009973
{
public static readonly BigInteger[] Value={ 1L,29L,841L,24389L,707281L,20511149L,594823321L,17249876309L,500246412961L,14507145975869L,420707233300201L,12200509765705829L,353814783205469041L,10260628712958602189UL,BigInteger.Parse("297558232675799463481"),BigInteger.Parse("8629188747598184440949") };
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
public class A009973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009973Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009973.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A009973.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009973Inst Instance=new A009973Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009972
{
public static readonly BigInteger[] Value={ 1L,28L,784L,21952L,614656L,17210368L,481890304L,13492928512L,377801998336L,10578455953408L,296196766695424L,8293509467471872L,232218265089212416L,6502111422497947648L,BigInteger.Parse("182059119829942534144"),BigInteger.Parse("5097655355238390956032") };
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
public class A009972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009972Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009972.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A009972.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009972Inst Instance=new A009972Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009971
{
public static readonly BigInteger[] Value={ 1L,27L,729L,19683L,531441L,14348907L,387420489L,10460353203L,282429536481L,7625597484987L,205891132094649L,5559060566555523L,150094635296999121L,4052555153018976267L,BigInteger.Parse("109418989131512359209"),BigInteger.Parse("2954312706550833698643") };
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
public class A009971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009971Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009971.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A009971.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009971Inst Instance=new A009971Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009970
{
public static readonly BigInteger[] Value={ 1L,26L,676L,17576L,456976L,11881376L,308915776L,8031810176L,208827064576L,5429503678976L,141167095653376L,3670344486987776L,95428956661682176L,2481152873203736576L,BigInteger.Parse("64509974703297150976"),BigInteger.Parse("1677259342285725925376"),BigInteger.Parse("43608742899428874059776"),BigInteger.Parse("1133827315385150725554176"),BigInteger.Parse("29479510200013918864408576"),BigInteger.Parse("766467265200361890474622976"),BigInteger.Parse("19928148895209409152340197376") };
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
public class A009970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009970Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009970.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A009970.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009970Inst Instance=new A009970Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009969
{
public static readonly BigInteger[] Value={ 1L,25L,625L,15625L,390625L,9765625L,244140625L,6103515625L,152587890625L,3814697265625L,95367431640625L,2384185791015625L,59604644775390625L,1490116119384765625L,BigInteger.Parse("37252902984619140625"),BigInteger.Parse("931322574615478515625"),BigInteger.Parse("23283064365386962890625"),BigInteger.Parse("582076609134674072265625"),BigInteger.Parse("14551915228366851806640625"),BigInteger.Parse("363797880709171295166015625"),BigInteger.Parse("9094947017729282379150390625") };
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
public class A009969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009969Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009969.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A009969.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009969Inst Instance=new A009969Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009968
{
public static readonly BigInteger[] Value={ 1L,24L,576L,13824L,331776L,7962624L,191102976L,4586471424L,110075314176L,2641807540224L,63403380965376L,1521681143169024L,36520347436056576L,876488338465357824L,BigInteger.Parse("21035720123168587776"),BigInteger.Parse("504857282956046106624"),BigInteger.Parse("12116574790945106558976"),BigInteger.Parse("290797794982682557415424"),BigInteger.Parse("6979147079584381377970176"),BigInteger.Parse("167499529910025153071284224"),BigInteger.Parse("4019988717840603673710821376") };
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
public class A009968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009968Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009968.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A009968.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009968Inst Instance=new A009968Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009967
{
public static readonly BigInteger[] Value={ 1L,23L,529L,12167L,279841L,6436343L,148035889L,3404825447L,78310985281L,1801152661463L,41426511213649L,952809757913927L,21914624432020321L,504036361936467383L,11592836324538749809UL,BigInteger.Parse("266635235464391245607"),BigInteger.Parse("6132610415680998648961"),BigInteger.Parse("141050039560662968926103"),BigInteger.Parse("3244150909895248285300369"),BigInteger.Parse("74615470927590710561908487"),BigInteger.Parse("1716155831334586342923895201") };
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
public class A009967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009967Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009967.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A009967.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009967Inst Instance=new A009967Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009966
{
public static readonly BigInteger[] Value={ 1L,22L,484L,10648L,234256L,5153632L,113379904L,2494357888L,54875873536L,1207269217792L,26559922791424L,584318301411328L,12855002631049216L,282810057883082752L,6221821273427820544L,BigInteger.Parse("136880068015412051968"),BigInteger.Parse("3011361496339065143296"),BigInteger.Parse("66249952919459433152512"),BigInteger.Parse("1457498964228107529355264"),BigInteger.Parse("32064977213018365645815808"),BigInteger.Parse("705429498686404044207947776") };
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
public class A009966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009966Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009966.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A009966.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009966Inst Instance=new A009966Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009965
{
public static readonly BigInteger[] Value={ 1L,21L,441L,9261L,194481L,4084101L,85766121L,1801088541L,37822859361L,794280046581L,16679880978201L,350277500542221L,7355827511386641L,154472377739119461L,3243919932521508681L,BigInteger.Parse("68122318582951682301"),BigInteger.Parse("1430568690241985328321"),BigInteger.Parse("30041942495081691894741"),BigInteger.Parse("630880792396715529789561"),BigInteger.Parse("13248496640331026125580781"),BigInteger.Parse("278218429446951548637196401") };
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
public class A009965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009965Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009965.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A009965.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009965Inst Instance=new A009965Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009964
{
public static readonly BigInteger[] Value={ 1L,20L,400L,8000L,160000L,3200000L,64000000L,1280000000L,25600000000L,512000000000L,10240000000000L,204800000000000L,4096000000000000L,81920000000000000L,1638400000000000000L,BigInteger.Parse("32768000000000000000") };
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
public class A009964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009964Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009964.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A009964.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009964Inst Instance=new A009964Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009963
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,6L,6L,1L,1L,24L,72L,24L,1L,1L,120L,1440L,1440L,120L,1L,1L,720L,43200L,172800L,43200L,720L,1L,1L,5040L,1814400L,36288000L,36288000L,1814400L,5040L,1L,1L,40320L,101606400L,12192768000L,60963840000L,12192768000L,101606400L,40320L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009963Inst : IEnumerable<long>
{
public static readonly long[] Value=A009963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009963.Bytes);
public long this[int i]=>Value[i];

public static A009963Inst Instance=new A009963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009962
{
public static readonly long[] Value={ 1L,15L,51L,125L,225L,366L,535L,729L,963L,1247L,1522L,1861L,2213L,2601L,3037L,3502L,4011L,4535L,5039L,5693L,6252L,6937L,7669L,8347L,9119L,9918L,10659L,11541L,12421L,13323L,14316L,15299L,16283L,17285L,18407L,19456L,20597L,21893L,23029L,24259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009962Inst : IEnumerable<long>
{
public static readonly long[] Value=A009962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009962.Bytes);
public long this[int i]=>Value[i];

public static A009962Inst Instance=new A009962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009961
{
public static readonly long[] Value={ 1L,14L,51L,119L,222L,353L,518L,719L,943L,1208L,1507L,1837L,2192L,2584L,2992L,3449L,3980L,4476L,5043L,5664L,6194L,6889L,7603L,8276L,9067L,9862L,10650L,11498L,12365L,13253L,14211L,15235L,16216L,17263L,18396L,19360L,20548L,21776L,22914L,24174L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009961Inst : IEnumerable<long>
{
public static readonly long[] Value=A009961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009961.Bytes);
public long this[int i]=>Value[i];

public static A009961Inst Instance=new A009961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009960
{
public static readonly long[] Value={ 1L,14L,50L,113L,207L,345L,505L,698L,932L,1191L,1494L,1813L,2157L,2561L,2968L,3464L,3943L,4457L,5024L,5538L,6217L,6886L,7504L,8321L,9048L,9764L,10610L,11395L,12295L,13275L,14214L,15186L,16187L,17231L,18174L,19334L,20545L,21664L,22950L,24254L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009960Inst : IEnumerable<long>
{
public static readonly long[] Value=A009960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009960.Bytes);
public long this[int i]=>Value[i];

public static A009960Inst Instance=new A009960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009959
{
public static readonly long[] Value={ 1L,12L,49L,111L,218L,340L,504L,699L,929L,1189L,1492L,1802L,2186L,2545L,2973L,3426L,3918L,4467L,5033L,5565L,6230L,6806L,7534L,8277L,9009L,9787L,10621L,11475L,12259L,13202L,14214L,15094L,16188L,17291L,18204L,19425L,20459L,21577L,22931L,24156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009959Inst : IEnumerable<long>
{
public static readonly long[] Value=A009959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009959.Bytes);
public long this[int i]=>Value[i];

public static A009959Inst Instance=new A009959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009958
{
public static readonly long[] Value={ 1L,12L,48L,106L,218L,350L,504L,690L,936L,1216L,1508L,1806L,2176L,2598L,2990L,3450L,3908L,4498L,5052L,5596L,6312L,6806L,7548L,8306L,8890L,9962L,10728L,11402L,12376L,13204L,14196L,15122L,16236L,17302L,18394L,19454L,20412L,21670L,22984L,23932L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009958Inst : IEnumerable<long>
{
public static readonly long[] Value=A009958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009958.Bytes);
public long this[int i]=>Value[i];

public static A009958Inst Instance=new A009958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009957
{
public static readonly long[] Value={ 1L,6L,18L,44L,68L,120L,152L,234L,270L,386L,422L,576L,608L,804L,828L,1070L,1082L,1374L,1370L,1716L,1692L,2096L,2048L,2514L,2438L,2970L,2862L,3464L,3320L,3996L,3812L,4566L,4338L,5174L,4898L,5820L,5492L,6504L,6120L,7226L,6782L,7986L,7478L,8784L,8208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009957Inst : IEnumerable<long>
{
public static readonly long[] Value=A009957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009957.Bytes);
public long this[int i]=>Value[i];

public static A009957Inst Instance=new A009957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009956
{
public static readonly long[] Value={ 1L,4L,18L,37L,70L,105L,169L,206L,292L,343L,469L,513L,664L,719L,919L,958L,1186L,1233L,1519L,1541L,1858L,1885L,2269L,2262L,2680L,2675L,3169L,3121L,3652L,3603L,4219L,4118L,4774L,4669L,5419L,5253L,6046L,5873L,6769L,6526L,7468L,7215L,8269L,7937L,9040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009956Inst : IEnumerable<long>
{
public static readonly long[] Value=A009956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009956.Bytes);
public long this[int i]=>Value[i];

public static A009956Inst Instance=new A009956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009955
{
public static readonly long[] Value={ 1L,6L,16L,40L,60L,106L,134L,206L,236L,340L,368L,506L,530L,706L,720L,940L,940L,1206L,1190L,1506L,1468L,1840L,1776L,2206L,2114L,2606L,2480L,3040L,2876L,3506L,3302L,4006L,3756L,4540L,4240L,5106L,4754L,5706L,5296L,6340L,5868L,7006L,6470L,7706L,7100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009955Inst : IEnumerable<long>
{
public static readonly long[] Value=A009955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009955.Bytes);
public long this[int i]=>Value[i];

public static A009955Inst Instance=new A009955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009954
{
public static readonly long[] Value={ 1L,4L,17L,34L,64L,93L,153L,181L,262L,298L,422L,445L,593L,621L,824L,826L,1058L,1061L,1359L,1325L,1656L,1618L,2028L,1941L,2387L,2293L,2830L,2674L,3252L,3085L,3765L,3525L,4250L,3994L,4834L,4493L,5381L,5021L,6036L,5578L,6646L,6165L,7371L,6781L,8044L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009954Inst : IEnumerable<long>
{
public static readonly long[] Value=A009954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009954.Bytes);
public long this[int i]=>Value[i];

public static A009954Inst Instance=new A009954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009953
{
public static readonly long[] Value={ 1L,16L,52L,104L,214L,352L,476L,700L,922L,1148L,1432L,1726L,2048L,2464L,2872L,3254L,3712L,4312L,4784L,5290L,5896L,6512L,7150L,7816L,8516L,9292L,10054L,10820L,11596L,12544L,13478L,14236L,15340L,16334L,17248L,18232L,19328L,20374L,21664L,22748L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009953Inst : IEnumerable<long>
{
public static readonly long[] Value=A009953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009953.Bytes);
public long this[int i]=>Value[i];

public static A009953Inst Instance=new A009953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009952
{
public static readonly long[] Value={ 1L,16L,49L,110L,211L,337L,491L,691L,898L,1163L,1420L,1720L,2084L,2470L,2863L,3254L,3748L,4231L,4739L,5326L,5887L,6515L,7183L,7753L,8543L,9331L,9982L,10817L,11692L,12496L,13376L,14353L,15217L,16256L,17275L,18220L,19328L,20599L,21511L,22688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009952Inst : IEnumerable<long>
{
public static readonly long[] Value=A009952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009952.Bytes);
public long this[int i]=>Value[i];

public static A009952Inst Instance=new A009952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009951
{
public static readonly long[] Value={ 1L,13L,49L,114L,204L,323L,499L,683L,890L,1153L,1413L,1728L,2089L,2446L,2842L,3281L,3723L,4220L,4750L,5298L,5876L,6509L,7143L,7807L,8533L,9274L,10028L,10843L,11628L,12476L,13408L,14277L,15252L,16253L,17214L,18265L,19365L,20447L,21604L,22744L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009951Inst : IEnumerable<long>
{
public static readonly long[] Value=A009951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009951.Bytes);
public long this[int i]=>Value[i];

public static A009951Inst Instance=new A009951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009950
{
public static readonly long[] Value={ 1L,12L,49L,113L,205L,327L,490L,691L,908L,1129L,1426L,1735L,2063L,2455L,2857L,3272L,3730L,4205L,4750L,5313L,5892L,6487L,7138L,7837L,8489L,9239L,10079L,10819L,11622L,12496L,13363L,14336L,15266L,16196L,17245L,18282L,19324L,20428L,21614L,22753L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009950Inst : IEnumerable<long>
{
public static readonly long[] Value=A009950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009950.Bytes);
public long this[int i]=>Value[i];

public static A009950Inst Instance=new A009950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009933
{
public static readonly long[] Value={ 1L,12L,50L,110L,216L,350L,518L,720L,966L,1224L,1554L,1874L,2226L,2650L,3144L,3486L,4106L,4664L,5102L,5782L,6606L,6946L,7816L,8702L,9224L,10080L,11224L,11658L,12812L,13836L,14620L,15684L,16960L,17544L,19136L,20174L,21058L,22548L,24006L,24598L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009933Inst : IEnumerable<long>
{
public static readonly long[] Value=A009933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009933.Bytes);
public long this[int i]=>Value[i];

public static A009933Inst Instance=new A009933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009932
{
public static readonly long[] Value={ 1L,12L,50L,110L,212L,356L,518L,712L,966L,1234L,1532L,1856L,2262L,2646L,3104L,3566L,4050L,4648L,5182L,5718L,6476L,7138L,7732L,8600L,9474L,9952L,11018L,12010L,12628L,13666L,14890L,15572L,16724L,18022L,18854L,19994L,21458L,22320L,23816L,25072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009932Inst : IEnumerable<long>
{
public static readonly long[] Value=A009932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009932.Bytes);
public long this[int i]=>Value[i];

public static A009932Inst Instance=new A009932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009931
{
public static readonly long[] Value={ 1L,16L,52L,130L,244L,380L,538L,784L,986L,1268L,1588L,1930L,2236L,2764L,3086L,3592L,4126L,4676L,5084L,5962L,6364L,7096L,7846L,8624L,9094L,10372L,10808L,11786L,12760L,13768L,14254L,16000L,16430L,17656L,18856L,20114L,20576L,22840L,23218L,24712L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009931Inst : IEnumerable<long>
{
public static readonly long[] Value=A009931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009931.Bytes);
public long this[int i]=>Value[i];

public static A009931Inst Instance=new A009931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009930
{
public static readonly long[] Value={ 1L,12L,50L,110L,216L,356L,528L,704L,968L,1230L,1514L,1838L,2276L,2562L,3074L,3540L,3998L,4490L,5244L,5570L,6374L,7052L,7662L,8300L,9438L,9740L,10862L,11754L,12512L,13280L,14852L,15060L,16544L,17658L,18542L,19418L,21492L,21542L,23414L,24752L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009930Inst : IEnumerable<long>
{
public static readonly long[] Value=A009930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009930.Bytes);
public long this[int i]=>Value[i];

public static A009930Inst Instance=new A009930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009929
{
public static readonly long[] Value={ 1L,1L,15L,9L,19L,33L,41L,6L,54L,119L,74L,165L,0L,191L,92L,286L,150L,214L,389L,297L,168L,439L,432L,386L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009929Inst : IEnumerable<long>
{
public static readonly long[] Value=A009929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009929.Bytes);
public long this[int i]=>Value[i];

public static A009929Inst Instance=new A009929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009928
{
public static readonly long[] Value={ 1L,14L,50L,114L,214L,350L,510L,710L,930L,1186L,1474L,1798L,2142L,2526L,2934L,3382L,3858L,4362L,4890L,5470L,6070L,6694L,7350L,8054L,8778L,9530L,10306L,11134L,11990L,12862L,13758L,14718L,15698L,16690L,17714L,18798L,19902L,21022L,22166L,23374L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009928Inst : IEnumerable<long>
{
public static readonly long[] Value=A009928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009928.Bytes);
public long this[int i]=>Value[i];

public static A009928Inst Instance=new A009928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009927
{
public static readonly long[] Value={ 1L,12L,50L,120L,218L,344L,546L,728L,902L,1212L,1526L,1784L,2154L,2552L,2954L,3432L,3854L,4340L,4998L,5504L,6002L,6768L,7442L,8024L,8814L,9572L,10334L,11232L,11978L,12824L,13938L,14768L,15590L,16812L,17846L,18752L,19962L,21080L,22202L,23520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009927Inst : IEnumerable<long>
{
public static readonly long[] Value=A009927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009927.Bytes);
public long this[int i]=>Value[i];

public static A009927Inst Instance=new A009927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009926
{
public static readonly long[] Value={ 1L,8L,12L,48L,42L,128L,92L,248L,162L,408L,252L,608L,362L,848L,492L,1128L,642L,1448L,812L,1808L,1002L,2208L,1212L,2648L,1442L,3128L,1692L,3648L,1962L,4208L,2252L,4808L,2562L,5448L,2892L,6128L,3242L,6848L,3612L,7608L,4002L,8408L,4412L,9248L,4842L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009926Inst : IEnumerable<long>
{
public static readonly long[] Value=A009926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009926.Bytes);
public long this[int i]=>Value[i];

public static A009926Inst Instance=new A009926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009925
{
public static readonly long[] Value={ 1L,4L,22L,24L,82L,64L,182L,124L,322L,204L,502L,304L,722L,424L,982L,564L,1282L,724L,1622L,904L,2002L,1104L,2422L,1324L,2882L,1564L,3382L,1824L,3922L,2104L,4502L,2404L,5122L,2724L,5782L,3064L,6482L,3424L,7222L,3804L,8002L,4204L,8822L,4624L,9682L,5064L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009925Inst : IEnumerable<long>
{
public static readonly long[] Value=A009925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009925.Bytes);
public long this[int i]=>Value[i];

public static A009925Inst Instance=new A009925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009924
{
public static readonly long[] Value={ 1L,10L,34L,82L,142L,218L,322L,434L,562L,722L,886L,1066L,1282L,1498L,1730L,2002L,2270L,2554L,2882L,3202L,3538L,3922L,4294L,4682L,5122L,5546L,5986L,6482L,6958L,7450L,8002L,8530L,9074L,9682L,10262L,10858L,11522L,12154L,12802L,13522L,14206L,14906L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009924Inst : IEnumerable<long>
{
public static readonly long[] Value=A009924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009924.Bytes);
public long this[int i]=>Value[i];

public static A009924Inst Instance=new A009924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009923
{
public static readonly long[] Value={ 1L,8L,36L,78L,140L,230L,308L,438L,572L,710L,884L,1086L,1260L,1502L,1748L,1982L,2268L,2582L,2852L,3206L,3564L,3894L,4292L,4718L,5084L,5550L,6020L,6446L,6956L,7494L,7956L,8534L,9116L,9638L,10260L,10910L,11468L,12158L,12852L,13470L,14204L,14966L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009923Inst : IEnumerable<long>
{
public static readonly long[] Value=A009923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009923.Bytes);
public long this[int i]=>Value[i];

public static A009923Inst Instance=new A009923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009922
{
public static readonly long[] Value={ 1L,4L,9L,17L,32L,53L,74L,98L,128L,165L,208L,250L,293L,344L,401L,457L,519L,591L,663L,737L,814L,897L,988L,1079L,1174L,1276L,1380L,1483L,1593L,1713L,1835L,1961L,2090L,2220L,2356L,2495L,2636L,2788L,2946L,3101L,3260L,3425L,3593L,3765L,3945L,4131L,4316L,4500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009922Inst : IEnumerable<long>
{
public static readonly long[] Value=A009922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009922.Bytes);
public long this[int i]=>Value[i];

public static A009922Inst Instance=new A009922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009921
{
public static readonly long[] Value={ 1L,4L,10L,18L,33L,57L,77L,95L,129L,172L,209L,248L,292L,341L,401L,466L,527L,587L,656L,736L,820L,903L,989L,1079L,1171L,1273L,1382L,1487L,1597L,1718L,1837L,1955L,2083L,2223L,2364L,2499L,2639L,2785L,2939L,3104L,3270L,3428L,3586L,3763L,3949L,4134L,4318L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009921Inst : IEnumerable<long>
{
public static readonly long[] Value=A009921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009921.Bytes);
public long this[int i]=>Value[i];

public static A009921Inst Instance=new A009921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009920
{
public static readonly long[] Value={ 1L,4L,9L,19L,33L,53L,78L,100L,126L,166L,213L,250L,287L,342L,405L,464L,522L,589L,662L,733L,813L,905L,992L,1077L,1171L,1273L,1380L,1488L,1600L,1716L,1836L,1956L,2080L,2221L,2365L,2502L,2636L,2781L,2945L,3107L,3263L,3427L,3594L,3760L,3941L,4135L,4322L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009920Inst : IEnumerable<long>
{
public static readonly long[] Value=A009920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009920.Bytes);
public long this[int i]=>Value[i];

public static A009920Inst Instance=new A009920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009919
{
public static readonly long[] Value={ 1L,4L,10L,21L,34L,47L,72L,108L,136L,162L,200L,247L,300L,352L,400L,454L,519L,591L,665L,739L,815L,898L,986L,1079L,1180L,1277L,1375L,1486L,1598L,1711L,1834L,1964L,2093L,2218L,2349L,2495L,2648L,2797L,2945L,3094L,3250L,3424L,3605L,3777L,3945L,4119L,4304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009919Inst : IEnumerable<long>
{
public static readonly long[] Value=A009919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009919.Bytes);
public long this[int i]=>Value[i];

public static A009919Inst Instance=new A009919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009918
{
public static readonly long[] Value={ 1L,4L,8L,18L,32L,52L,70L,98L,132L,152L,200L,242L,286L,324L,404L,422L,520L,564L,646L,690L,828L,820L,988L,1026L,1154L,1188L,1400L,1354L,1608L,1620L,1806L,1826L,2124L,2016L,2376L,2354L,2606L,2596L,2996L,2814L,3296L,3220L,3550L,3506L,4020L,3740L,4364L,4226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009918Inst : IEnumerable<long>
{
public static readonly long[] Value=A009918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009918.Bytes);
public long this[int i]=>Value[i];

public static A009918Inst Instance=new A009918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009901
{
public static readonly long[] Value={ 1L,4L,12L,22L,40L,58L,82L,116L,154L,186L,232L,280L,332L,388L,464L,520L,584L,658L,754L,844L,926L,1004L,1118L,1218L,1334L,1430L,1576L,1680L,1796L,1934L,2088L,2206L,2366L,2488L,2696L,2816L,2966L,3142L,3366L,3510L,3668L,3832L,4108L,4254L,4470L,4642L,4894L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009901Inst : IEnumerable<long>
{
public static readonly long[] Value=A009901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009901.Bytes);
public long this[int i]=>Value[i];

public static A009901Inst Instance=new A009901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009900
{
public static readonly long[] Value={ 1L,4L,11L,21L,37L,62L,85L,114L,148L,185L,232L,284L,335L,389L,447L,520L,594L,673L,749L,822L,920L,1022L,1118L,1226L,1322L,1435L,1562L,1678L,1807L,1942L,2073L,2214L,2359L,2506L,2660L,2829L,2992L,3149L,3320L,3496L,3688L,3890L,4069L,4243L,4445L,4668L,4882L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009900Inst : IEnumerable<long>
{
public static readonly long[] Value=A009900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009900.Bytes);
public long this[int i]=>Value[i];

public static A009900Inst Instance=new A009900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009899
{
public static readonly long[] Value={ 1L,4L,11L,23L,38L,58L,86L,114L,148L,189L,234L,280L,332L,390L,453L,520L,591L,668L,751L,833L,917L,1013L,1121L,1225L,1327L,1439L,1554L,1681L,1811L,1935L,2080L,2214L,2349L,2510L,2668L,2829L,2985L,3143L,3329L,3507L,3688L,3870L,4060L,4269L,4454L,4655L,4881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009899Inst : IEnumerable<long>
{
public static readonly long[] Value=A009899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009899.Bytes);
public long this[int i]=>Value[i];

public static A009899Inst Instance=new A009899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009898
{
public static readonly long[] Value={ 1L,4L,10L,21L,38L,60L,84L,113L,148L,192L,232L,274L,335L,397L,450L,517L,591L,668L,745L,828L,933L,1024L,1105L,1210L,1333L,1454L,1550L,1670L,1822L,1942L,2059L,2206L,2371L,2527L,2645L,2805L,3005L,3166L,3310L,3493L,3708L,3880L,4031L,4252L,4492L,4682L,4839L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009898Inst : IEnumerable<long>
{
public static readonly long[] Value=A009898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009898.Bytes);
public long this[int i]=>Value[i];

public static A009898Inst Instance=new A009898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009897
{
public static readonly long[] Value={ 1L,4L,10L,21L,37L,58L,87L,116L,146L,185L,232L,282L,335L,390L,449L,518L,596L,669L,746L,828L,918L,1023L,1121L,1217L,1325L,1436L,1561L,1683L,1805L,1937L,2070L,2219L,2362L,2504L,2665L,2817L,2990L,3162L,3313L,3499L,3690L,3879L,4073L,4246L,4446L,4667L,4885L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009897Inst : IEnumerable<long>
{
public static readonly long[] Value=A009897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009897.Bytes);
public long this[int i]=>Value[i];

public static A009897Inst Instance=new A009897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009896
{
public static readonly long[] Value={ 1L,4L,10L,18L,31L,55L,77L,103L,134L,165L,214L,255L,299L,353L,408L,471L,539L,606L,669L,753L,842L,918L,1017L,1105L,1188L,1310L,1426L,1516L,1632L,1758L,1874L,2012L,2147L,2265L,2407L,2564L,2706L,2861L,3018L,3159L,3347L,3521L,3674L,3865L,4035L,4215L,4438L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009896Inst : IEnumerable<long>
{
public static readonly long[] Value=A009896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009896.Bytes);
public long this[int i]=>Value[i];

public static A009896Inst Instance=new A009896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009895
{
public static readonly long[] Value={ 1L,4L,10L,19L,31L,50L,82L,106L,130L,168L,203L,260L,312L,349L,399L,467L,544L,611L,677L,743L,828L,937L,1015L,1099L,1197L,1297L,1426L,1540L,1618L,1736L,1893L,2017L,2148L,2274L,2379L,2550L,2748L,2869L,2988L,3170L,3323L,3526L,3729L,3830L,4005L,4245L,4430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009895Inst : IEnumerable<long>
{
public static readonly long[] Value=A009895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009895.Bytes);
public long this[int i]=>Value[i];

public static A009895Inst Instance=new A009895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009894
{
public static readonly long[] Value={ 1L,4L,10L,21L,36L,54L,75L,100L,136L,181L,214L,244L,295L,358L,422L,478L,526L,593L,685L,766L,836L,918L,1005L,1107L,1219L,1304L,1399L,1526L,1640L,1766L,1893L,1985L,2120L,2301L,2431L,2549L,2700L,2839L,3019L,3220L,3335L,3474L,3690L,3864L,4054L,4258L,4385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009894Inst : IEnumerable<long>
{
public static readonly long[] Value=A009894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009894.Bytes);
public long this[int i]=>Value[i];

public static A009894Inst Instance=new A009894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009893
{
public static readonly long[] Value={ 1L,4L,11L,21L,34L,53L,78L,108L,137L,165L,207L,259L,308L,357L,404L,465L,541L,611L,680L,752L,833L,922L,1016L,1109L,1199L,1308L,1416L,1520L,1642L,1753L,1874L,2021L,2145L,2264L,2409L,2560L,2711L,2872L,3016L,3154L,3344L,3525L,3681L,3869L,4036L,4210L,4434L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009893Inst : IEnumerable<long>
{
public static readonly long[] Value=A009893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009893.Bytes);
public long this[int i]=>Value[i];

public static A009893Inst Instance=new A009893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009892
{
public static readonly long[] Value={ 1L,4L,11L,21L,35L,57L,80L,106L,139L,176L,218L,261L,311L,365L,422L,487L,551L,622L,698L,777L,862L,948L,1042L,1138L,1238L,1345L,1454L,1568L,1684L,1808L,1937L,2065L,2200L,2341L,2485L,2633L,2785L,2942L,3103L,3268L,3439L,3612L,3790L,3973L,4159L,4352L,4546L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009892Inst : IEnumerable<long>
{
public static readonly long[] Value=A009892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009892.Bytes);
public long this[int i]=>Value[i];

public static A009892Inst Instance=new A009892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009891
{
public static readonly long[] Value={ 1L,4L,10L,22L,37L,54L,79L,108L,140L,176L,215L,262L,312L,365L,423L,484L,552L,623L,698L,777L,860L,950L,1041L,1138L,1240L,1343L,1453L,1568L,1687L,1808L,1933L,2066L,2202L,2341L,2484L,2632L,2786L,2942L,3103L,3269L,3437L,3612L,3791L,3973L,4160L,4350L,4546L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009891Inst : IEnumerable<long>
{
public static readonly long[] Value=A009891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009891.Bytes);
public long this[int i]=>Value[i];

public static A009891Inst Instance=new A009891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009890
{
public static readonly long[] Value={ 1L,4L,10L,19L,33L,56L,81L,105L,136L,175L,219L,262L,307L,363L,425L,485L,548L,622L,699L,776L,859L,948L,1042L,1137L,1236L,1344L,1456L,1566L,1681L,1808L,1937L,2065L,2198L,2339L,2486L,2633L,2782L,2940L,3105L,3268L,3435L,3612L,3791L,3971L,4157L,4351L,4548L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009890Inst : IEnumerable<long>
{
public static readonly long[] Value=A009890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009890.Bytes);
public long this[int i]=>Value[i];

public static A009890Inst Instance=new A009890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009889
{
public static readonly long[] Value={ 1L,4L,8L,20L,44L,55L,80L,118L,152L,204L,228L,272L,354L,404L,464L,517L,594L,690L,778L,858L,920L,1036L,1152L,1276L,1362L,1439L,1576L,1730L,1900L,1982L,2064L,2282L,2398L,2632L,2802L,2711L,3102L,3284L,3382L,3682L,3646L,3916L,4286L,4378L,4568L,4713L,4956L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009889Inst : IEnumerable<long>
{
public static readonly long[] Value=A009889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009889.Bytes);
public long this[int i]=>Value[i];

public static A009889Inst Instance=new A009889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009888
{
public static readonly long[] Value={ 1L,4L,11L,21L,40L,61L,89L,116L,145L,191L,239L,294L,339L,390L,474L,535L,601L,688L,747L,839L,973L,1057L,1130L,1239L,1354L,1499L,1619L,1667L,1830L,2003L,2122L,2326L,2422L,2509L,2752L,2926L,3076L,3178L,3336L,3599L,3824L,4030L,4134L,4319L,4632L,4803L,5025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009888Inst : IEnumerable<long>
{
public static readonly long[] Value=A009888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009888.Bytes);
public long this[int i]=>Value[i];

public static A009888Inst Instance=new A009888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009887
{
public static readonly long[] Value={ 1L,4L,9L,21L,42L,57L,82L,119L,151L,188L,239L,277L,345L,410L,443L,540L,603L,663L,771L,862L,921L,1042L,1157L,1249L,1356L,1472L,1557L,1742L,1858L,1935L,2158L,2245L,2409L,2626L,2704L,2872L,3038L,3235L,3391L,3584L,3782L,3891L,4232L,4430L,4449L,4878L,4930L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009887Inst : IEnumerable<long>
{
public static readonly long[] Value=A009887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009887.Bytes);
public long this[int i]=>Value[i];

public static A009887Inst Instance=new A009887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009886
{
public static readonly long[] Value={ 1L,4L,10L,21L,37L,58L,91L,117L,144L,194L,241L,287L,343L,388L,454L,549L,617L,664L,760L,860L,944L,1053L,1131L,1218L,1369L,1498L,1617L,1722L,1817L,1968L,2172L,2291L,2344L,2543L,2743L,2901L,3147L,3204L,3331L,3663L,3795L,3954L,4153L,4252L,4541L,4901L,5048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009886Inst : IEnumerable<long>
{
public static readonly long[] Value=A009886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009886.Bytes);
public long this[int i]=>Value[i];

public static A009886Inst Instance=new A009886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009869
{
public static readonly long[] Value={ 1L,4L,11L,18L,31L,52L,77L,98L,126L,164L,205L,245L,285L,340L,407L,452L,503L,582L,662L,726L,797L,887L,974L,1072L,1162L,1244L,1360L,1477L,1576L,1682L,1810L,1937L,2053L,2191L,2334L,2455L,2605L,2756L,2902L,3060L,3211L,3381L,3547L,3718L,3899L,4063L,4256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009869Inst : IEnumerable<long>
{
public static readonly long[] Value=A009869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009869.Bytes);
public long this[int i]=>Value[i];

public static A009869Inst Instance=new A009869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009868
{
public static readonly long[] Value={ 1L,4L,10L,19L,32L,50L,73L,101L,132L,164L,199L,240L,293L,350L,394L,443L,510L,587L,666L,730L,791L,879L,984L,1074L,1154L,1250L,1357L,1470L,1589L,1697L,1801L,1922L,2061L,2196L,2326L,2464L,2600L,2754L,2914L,3058L,3215L,3376L,3550L,3727L,3886L,4071L,4252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009868Inst : IEnumerable<long>
{
public static readonly long[] Value=A009868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009868.Bytes);
public long this[int i]=>Value[i];

public static A009868Inst Instance=new A009868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009867
{
public static readonly long[] Value={ 1L,4L,10L,18L,32L,53L,78L,105L,140L,179L,218L,260L,314L,374L,430L,487L,560L,637L,706L,780L,874L,974L,1062L,1149L,1260L,1375L,1474L,1580L,1714L,1854L,1974L,2091L,2240L,2393L,2522L,2660L,2834L,3014L,3166L,3313L,3500L,3691L,3850L,4020L,4234L,4454L,4638L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009867Inst : IEnumerable<long>
{
public static readonly long[] Value=A009867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009867.Bytes);
public long this[int i]=>Value[i];

public static A009867Inst Instance=new A009867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009866
{
public static readonly long[] Value={ 1L,4L,11L,21L,36L,56L,81L,109L,142L,179L,221L,266L,316L,371L,431L,494L,562L,634L,711L,791L,876L,966L,1061L,1159L,1262L,1369L,1481L,1596L,1716L,1841L,1971L,2104L,2242L,2384L,2531L,2681L,2836L,2996L,3161L,3329L,3502L,3679L,3861L,4046L,4236L,4431L,4631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009866Inst : IEnumerable<long>
{
public static readonly long[] Value=A009866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009866.Bytes);
public long this[int i]=>Value[i];

public static A009866Inst Instance=new A009866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009865
{
public static readonly long[] Value={ 1L,4L,9L,17L,29L,45L,64L,85L,110L,141L,178L,218L,256L,295L,343L,400L,457L,509L,565L,633L,707L,778L,847L,924L,1013L,1106L,1194L,1279L,1373L,1480L,1590L,1694L,1796L,1908L,2032L,2158L,2279L,2400L,2533L,2678L,2821L,2956L,3094L,3247L,3409L,3566L,3718L,3876L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009865Inst : IEnumerable<long>
{
public static readonly long[] Value=A009865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009865.Bytes);
public long this[int i]=>Value[i];

public static A009865Inst Instance=new A009865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009864
{
public static readonly long[] Value={ 1L,3L,9L,21L,36L,53L,69L,90L,119L,156L,201L,239L,276L,330L,386L,432L,492L,560L,618L,687L,773L,852L,927L,1022L,1125L,1215L,1298L,1395L,1503L,1607L,1722L,1857L,1979L,2091L,2232L,2375L,2493L,2622L,2777L,2922L,3063L,3227L,3396L,3558L,3728L,3912L,4086L,4244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009864Inst : IEnumerable<long>
{
public static readonly long[] Value=A009864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009864.Bytes);
public long this[int i]=>Value[i];

public static A009864Inst Instance=new A009864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009863
{
public static readonly long[] Value={ 1L,4L,9L,19L,34L,49L,67L,94L,125L,157L,195L,236L,278L,326L,380L,436L,492L,552L,622L,698L,771L,847L,933L,1020L,1109L,1207L,1304L,1397L,1501L,1618L,1734L,1848L,1969L,2097L,2226L,2357L,2495L,2634L,2771L,2919L,3079L,3234L,3388L,3556L,3728L,3896L,4070L,4250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009863Inst : IEnumerable<long>
{
public static readonly long[] Value=A009863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009863.Bytes);
public long this[int i]=>Value[i];

public static A009863Inst Instance=new A009863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009862
{
public static readonly long[] Value={ 1L,4L,9L,16L,27L,46L,73L,102L,129L,157L,191L,232L,277L,323L,371L,427L,494L,565L,632L,698L,771L,851L,932L,1012L,1095L,1188L,1296L,1413L,1525L,1628L,1733L,1848L,1968L,2088L,2211L,2342L,2484L,2636L,2790L,2938L,3084L,3237L,3395L,3551L,3708L,3875L,4055L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009862Inst : IEnumerable<long>
{
public static readonly long[] Value=A009862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009862.Bytes);
public long this[int i]=>Value[i];

public static A009862Inst Instance=new A009862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009861
{
public static readonly long[] Value={ 1L,4L,8L,16L,29L,44L,61L,88L,120L,142L,174L,218L,256L,302L,349L,400L,455L,512L,578L,634L,706L,788L,858L,942L,1021L,1106L,1197L,1288L,1396L,1486L,1596L,1716L,1812L,1930L,2043L,2166L,2297L,2428L,2570L,2688L,2838L,2986L,3114L,3278L,3425L,3590L,3763L,3918L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009861Inst : IEnumerable<long>
{
public static readonly long[] Value=A009861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009861.Bytes);
public long this[int i]=>Value[i];

public static A009861Inst Instance=new A009861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009860
{
public static readonly long[] Value={ 1L,4L,10L,17L,25L,42L,69L,95L,116L,142L,178L,218L,256L,293L,341L,408L,475L,521L,558L,616L,708L,806L,880L,935L,999L,1100L,1215L,1305L,1378L,1470L,1600L,1734L,1838L,1917L,2009L,2156L,2321L,2451L,2560L,2682L,2838L,3000L,3130L,3245L,3393L,3600L,3805L,3949L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009860Inst : IEnumerable<long>
{
public static readonly long[] Value=A009860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009860.Bytes);
public long this[int i]=>Value[i];

public static A009860Inst Instance=new A009860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009859
{
public static readonly long[] Value={ 1L,3L,7L,15L,29L,47L,63L,83L,114L,146L,176L,216L,257L,300L,355L,396L,443L,516L,579L,646L,716L,770L,846L,945L,1029L,1105L,1199L,1289L,1385L,1507L,1595L,1682L,1816L,1937L,2056L,2184L,2289L,2408L,2563L,2704L,2825L,2977L,3129L,3279L,3454L,3584L,3720L,3911L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009859Inst : IEnumerable<long>
{
public static readonly long[] Value=A009859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009859.Bytes);
public long this[int i]=>Value[i];

public static A009859Inst Instance=new A009859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009858
{
public static readonly long[] Value={ 1L,3L,8L,16L,29L,49L,68L,94L,123L,162L,203L,229L,276L,334L,400L,446L,481L,569L,654L,723L,781L,847L,971L,1064L,1129L,1229L,1331L,1463L,1550L,1645L,1799L,1901L,2041L,2141L,2275L,2469L,2559L,2716L,2847L,3003L,3221L,3324L,3499L,3645L,3828L,4083L,4188L,4380L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009858Inst : IEnumerable<long>
{
public static readonly long[] Value=A009858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009858.Bytes);
public long this[int i]=>Value[i];

public static A009858Inst Instance=new A009858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009857
{
public static readonly long[] Value={ 1L,4L,10L,19L,33L,52L,72L,102L,126L,161L,204L,240L,292L,332L,391L,455L,510L,580L,637L,719L,808L,879L,969L,1043L,1141L,1267L,1345L,1456L,1550L,1665L,1824L,1912L,2045L,2149L,2293L,2481L,2576L,2736L,2851L,3016L,3242L,3341L,3518L,3658L,3839L,4100L,4208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009857Inst : IEnumerable<long>
{
public static readonly long[] Value=A009857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009857.Bytes);
public long this[int i]=>Value[i];

public static A009857Inst Instance=new A009857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009856
{
public static readonly long[] Value={ 1L,4L,9L,19L,33L,51L,77L,96L,126L,162L,203L,250L,279L,333L,390L,457L,526L,561L,634L,723L,810L,900L,944L,1030L,1157L,1266L,1378L,1419L,1529L,1692L,1820L,1961L,1988L,2122L,2330L,2479L,2640L,2662L,2812L,3064L,3244L,3419L,3428L,3603L,3902L,4102L,4307L,4292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009856Inst : IEnumerable<long>
{
public static readonly long[] Value=A009856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009856.Bytes);
public long this[int i]=>Value[i];

public static A009856Inst Instance=new A009856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009855
{
public static readonly long[] Value={ 1L,4L,9L,18L,31L,48L,71L,99L,132L,162L,197L,241L,288L,345L,392L,439L,506L,581L,662L,722L,776L,869L,980L,1080L,1145L,1213L,1338L,1475L,1596L,1669L,1748L,1909L,2069L,2210L,2300L,2384L,2569L,2765L,2930L,3025L,3117L,3331L,3562L,3756L,3849L,3940L,4199L,4463L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009855Inst : IEnumerable<long>
{
public static readonly long[] Value=A009855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009855.Bytes);
public long this[int i]=>Value[i];

public static A009855Inst Instance=new A009855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009854
{
public static readonly long[] Value={ 1L,3L,5L,10L,18L,29L,45L,56L,65L,86L,110L,130L,151L,177L,210L,246L,292L,344L,384L,430L,491L,541L,581L,630L,690L,750L,805L,882L,985L,1069L,1138L,1225L,1313L,1378L,1441L,1542L,1654L,1725L,1794L,1895L,1992L,2092L,2226L,2377L,2503L,2596L,2708L,2842L,2951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009854Inst : IEnumerable<long>
{
public static readonly long[] Value=A009854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009854.Bytes);
public long this[int i]=>Value[i];

public static A009854Inst Instance=new A009854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009837
{
public static readonly BigInteger[] Value={ 1L,56L,46336L,182844416L,2205641015296L,63603482126974976L,BigInteger.Parse("3748468097940723859456"),BigInteger.Parse("404963012992964559934324736"),BigInteger.Parse("74035562436962891333631597346816") };
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
public class A009837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009837Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009837.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A009837.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009837Inst Instance=new A009837Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009836
{
public static readonly BigInteger[] Value={ 0L,2L,8L,368L,16512L,1583104L,199552000L,36445579264L,8620299812864L,2621816292114432L,987354046567284736L,BigInteger.Parse("452732308336619290624"),BigInteger.Parse("247917555997339251900416"),BigInteger.Parse("159904531672039230122491904") };
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
public class A009836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009836Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009836.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A009836.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009836Inst Instance=new A009836Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009835
{
public static readonly BigInteger[] Value={ 0L,2L,-4L,38L,-1800L,49354L,-2224652L,213407470L,-19515213328L,2214421360530L,-370704748056596L,69183566673997750L,BigInteger.Parse("-14893989315954214168"),BigInteger.Parse("4017468897454451692634"),BigInteger.Parse("-1237828661076392935858716") };
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
public class A009835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009835Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009835.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A009835.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009835Inst Instance=new A009835Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009834
{
public static readonly BigInteger[] Value={ 0L,2L,-4L,38L,-3144L,-49526L,-10349516L,-460714706L,-91894143376L,-6277401116142L,-1574511126111380L,-81923064774031562L,BigInteger.Parse("-27289817479229247448"),BigInteger.Parse("10031662078758108490394"),BigInteger.Parse("3820037980300331336027556") };
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
public class A009834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009834Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009834.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A009834.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009834Inst Instance=new A009834Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009833
{
public static readonly BigInteger[] Value={ 0L,2L,-16L,248L,-6336L,242464L,-13219328L,982066816L,-95757641728L,11884764271104L,-1830773338714112L,342819066285905920L,BigInteger.Parse("-76695821135067430912"),BigInteger.Parse("20204454465377182490624"),BigInteger.Parse("-6190555048037337840746496") };
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
public class A009833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009833Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009833.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A009833.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009833Inst Instance=new A009833Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009832
{
public static readonly BigInteger[] Value={ 0L,1L,2L,1L,-4L,1L,62L,1L,-1384L,1L,50522L,1L,-2702764L,1L,199360982L,1L,-19391512144L,1L,2404879675442L,1L,-370371188237524L,1L,69348874393137902L,1L,BigInteger.Parse("-15514534163557086904"),1L,BigInteger.Parse("4087072509293123892362"),1L,BigInteger.Parse("-1252259641403629865468284"),1L };
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
public class A009832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009832Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A009832.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A009832.Bytes);
public BigInteger this[int i]=>Value[i];

public static A009832Inst Instance=new A009832Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A009831
{
public static readonly long[] Value={ 0L,1L,2L,1L,-12L,-39L,118L,1233L,-536L,-50831L,-116246L,2696321L,16364252L,-173033847L,-2126232482L,12037460945L,306170653648L,-631883857695L,-50385573229614L,-72323545938047L,9466502482856388L,51175586766916153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A009831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A009831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A009831Inst : IEnumerable<long>
{
public static readonly long[] Value=A009831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A009831.Bytes);
public long this[int i]=>Value[i];

public static A009831Inst Instance=new A009831Inst();

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