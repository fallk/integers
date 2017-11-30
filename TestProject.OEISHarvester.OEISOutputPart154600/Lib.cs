using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A184673
{
public static readonly long[] Value={ 150L,1740L,1740L,19269L,67330L,19269L,216912L,2405797L,2405797L,216912L,2430631L,88458672L,266060160L,88458672L,2430631L,27278035L,3225439429L,30765364899L,30765364899L,3225439429L,27278035L,305991368L,117938741095L,3509487618613L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184673Inst : IEnumerable<long>
{
public static readonly long[] Value=A184673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184673.Bytes);
public long this[int i]=>Value[i];

public static A184673Inst Instance=new A184673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184674
{
public static readonly long[] Value={ 1L,2L,4L,7L,10L,14L,18L,23L,28L,34L,40L,47L,54L,62L,70L,79L,88L,98L,108L,119L,130L,142L,154L,167L,180L,194L,208L,223L,238L,254L,270L,287L,304L,322L,340L,359L,378L,398L,418L,439L,460L,482L,504L,527L,550L,574L,598L,623L,648L,674L,700L,727L,754L,782L,810L,839L,868L,898L,928L,959L,990L,1022L,1054L,1087L,1120L,1154L,1188L,1223L,1258L,1294L,1330L,1367L,1404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184674Inst : IEnumerable<long>
{
public static readonly long[] Value=A184674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184674.Bytes);
public long this[int i]=>Value[i];

public static A184674Inst Instance=new A184674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184675
{
public static readonly long[] Value={ 3L,5L,6L,8L,9L,11L,12L,13L,15L,16L,17L,19L,20L,21L,22L,24L,25L,26L,27L,29L,30L,31L,32L,33L,35L,36L,37L,38L,39L,41L,42L,43L,44L,45L,46L,48L,49L,50L,51L,52L,53L,55L,56L,57L,58L,59L,60L,61L,63L,64L,65L,66L,67L,68L,69L,71L,72L,73L,74L,75L,76L,77L,78L,80L,81L,82L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184675Inst : IEnumerable<long>
{
public static readonly long[] Value=A184675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184675.Bytes);
public long this[int i]=>Value[i];

public static A184675Inst Instance=new A184675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184676
{
public static readonly long[] Value={ 1L,2L,5L,7L,11L,14L,19L,23L,29L,34L,41L,47L,55L,62L,71L,79L,89L,98L,109L,119L,131L,142L,155L,167L,181L,194L,209L,223L,239L,254L,271L,287L,305L,322L,341L,359L,379L,398L,419L,439L,461L,482L,505L,527L,551L,574L,599L,623L,649L,674L,701L,727L,755L,782L,811L,839L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184676Inst : IEnumerable<long>
{
public static readonly long[] Value=A184676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184676.Bytes);
public long this[int i]=>Value[i];

public static A184676Inst Instance=new A184676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184677
{
public static readonly long[] Value={ 1L,3L,7L,16L,30L,61L,88L,138L,177L,248L,361L,423L,569L,690L,777L,924L,1137L,1370L,1495L,1765L,1979L,2129L,2452L,2711L,3075L,3563L,3871L,4078L,4412L,4639L,4996L,6027L,6427L,6988L,7272L,8181L,8494L,9135L,9803L,10320L,11031L,11768L,12140L,13315L,13713L,14330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184677Inst : IEnumerable<long>
{
public static readonly long[] Value=A184677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184677.Bytes);
public long this[int i]=>Value[i];

public static A184677Inst Instance=new A184677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184678
{
public static readonly BigInteger[] Value={ 10L,128L,3360L,221968L,31817360L,10876933264L,8344809419152L,14901599172048528L,BigInteger.Parse("60581954550463205264"),BigInteger.Parse("567946901826257621019792"),BigInteger.Parse("12186523252504462055625831824"),BigInteger.Parse("601019440996497914601529636314768") };
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
public class A184678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184678Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184678.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184678Inst Instance=new A184678Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184679
{
public static readonly long[] Value={ 28L,128L,544L,2384L,10384L,45392L,198352L,867152L,3791056L,16575056L,72469456L,316854608L,1385372368L,6057228368L,26483886544L,115794964304L,506288081104L,2213633766992L,9678629263312L,42317689343312L,185024841512656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184679Inst : IEnumerable<long>
{
public static readonly long[] Value=A184679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184679.Bytes);
public long this[int i]=>Value[i];

public static A184679Inst Instance=new A184679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184680
{
public static readonly long[] Value={ 76L,544L,3360L,21968L,140816L,909520L,5858896L,37779664L,243525712L,1569965008L,10120785744L,65244856016L,420606054992L,2711476238800L,17479769838928L,112684908266704L,726433311008848L,4683017326649296L,30189489673849680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184680Inst : IEnumerable<long>
{
public static readonly long[] Value=A184680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184680.Bytes);
public long this[int i]=>Value[i];

public static A184680Inst Instance=new A184680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184681
{
public static readonly long[] Value={ 208L,2384L,21968L,221968L,2171152L,21547024L,212829840L,2107074576L,20846869136L,206331811088L,2041995275664L,20210243538448L,200025118846608L,1979715148636944L,19593894295270288L,193927696142858256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184681Inst : IEnumerable<long>
{
public static readonly long[] Value=A184681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184681.Bytes);
public long this[int i]=>Value[i];

public static A184681Inst Instance=new A184681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184682
{
public static readonly ulong[] Value={ 568L,10384L,140816L,2171152L,31817360L,476660624L,7079094288L,105530924944L,1570852959248L,23397537190544L,348412932162320L,5188788920597392L,77271414617633808L,1150747018045489296L,17137111768900018448UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184682Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A184682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184682.Bytes);
public ulong this[int i]=>Value[i];

public static A184682Inst Instance=new A184682Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184683
{
public static readonly BigInteger[] Value={ 1552L,45392L,909520L,21547024L,476660624L,10876933264L,245133874960L,5556396815504L,125663816659728L,2845061488472976L,64387245566119440L,1457456269843957904L,BigInteger.Parse("32988377007885609744"),BigInteger.Parse("746694792891303623056") };
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
public class A184683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184683Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184683.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184683Inst Instance=new A184683Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184780
{
public static readonly BigInteger[] Value={ 12792L,260268L,5299212L,107810856L,2193592920L,44633574216L,908160565032L,18478374229416L,375980327644488L,7650088026679752L,155656671056370024L,3167153029248451944L,BigInteger.Parse("64442199825855185928"),BigInteger.Parse("1311208229754332950152") };
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
public class A184780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184780Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184780.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184780Inst Instance=new A184780Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184781
{
public static readonly BigInteger[] Value={ 260268L,13313404L,681288932L,34797264276L,1778231844136L,90873049503556L,4643641622051596L,237295567539569352L,12126082907249375676UL,BigInteger.Parse("619655984740726276728"),BigInteger.Parse("31665112274179396900624"),BigInteger.Parse("1618122571180552272792264") };
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
public class A184781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184781Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184781.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184781Inst Instance=new A184781Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184782
{
public static readonly BigInteger[] Value={ 5299212L,681288932L,87624157296L,11238839929536L,1442620554904424L,185182404965507590L,BigInteger.Parse("23768874596866639628"),BigInteger.Parse("3050891859512202940466"),BigInteger.Parse("391603512195940259715146"),BigInteger.Parse("50264915559793952509998504") };
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
public class A184782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184782Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184782.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184782Inst Instance=new A184782Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184783
{
public static readonly long[] Value={ 107810856L,34797264276L,11238839929536L,3617921434188172L,1165690391152078172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184783Inst : IEnumerable<long>
{
public static readonly long[] Value=A184783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184783.Bytes);
public long this[int i]=>Value[i];

public static A184783Inst Instance=new A184783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184784
{
public static readonly long[] Value={ 12792L,260268L,260268L,5299212L,13313404L,5299212L,107810856L,681288932L,681288932L,107810856L,2193592920L,34797264276L,87624157296L,34797264276L,2193592920L,44633574216L,1778231844136L,11238839929536L,11238839929536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184784Inst : IEnumerable<long>
{
public static readonly long[] Value=A184784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184784.Bytes);
public long this[int i]=>Value[i];

public static A184784Inst Instance=new A184784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184785
{
public static readonly long[] Value={ 1L,1L,1L,3L,6L,14L,34L,83L,205L,516L,1317L,3396L,8848L,23253L,61570L,164094L,439860L,1185086L,3207477L,8716726L,23776459L,65072379L,178637758L,491772915L,1357288318L,3754989329L,10411112464L,28924678247L,80512118330L,224501827180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184785Inst : IEnumerable<long>
{
public static readonly long[] Value=A184785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184785.Bytes);
public long this[int i]=>Value[i];

public static A184785Inst Instance=new A184785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184786
{
public static readonly long[] Value={ 1L,1L,2L,8L,35L,147L,654L,3009L,14219L,68605L,336623L,1674517L,8425573L,42806200L,219285459L,1131431170L,5874504011L,30670279153L,160916320637L,847994498527L,4486473924741L,23821682237692L,126897559943046L,677992017255423L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184786Inst : IEnumerable<long>
{
public static readonly long[] Value=A184786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184786.Bytes);
public long this[int i]=>Value[i];

public static A184786Inst Instance=new A184786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184787
{
public static readonly long[] Value={ 6891L,100941L,1451439L,19143309L,264517911L,3635551053L,49631761863L,680594596269L,9325198131783L,127707459851229L,1749659420599239L,23968756658981133L,328340087728123527L,4497988332883770237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184787Inst : IEnumerable<long>
{
public static readonly long[] Value=A184787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184787.Bytes);
public long this[int i]=>Value[i];

public static A184787Inst Instance=new A184787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184788
{
public static readonly BigInteger[] Value={ 100941L,3637117L,125979493L,3680493357L,120704703909L,3913579500845L,125215483941877L,4056621402505637L,131193539880289661L,4239492954003616253L,BigInteger.Parse("137174736996008387253"),BigInteger.Parse("4437555899647670803381"),BigInteger.Parse("143550933862609616020893") };
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
public class A184788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184788Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184788.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184788Inst Instance=new A184788Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184789
{
public static readonly BigInteger[] Value={ 1451439L,125979493L,10547404447L,680930052757L,54363498790639L,4325955651178757L,341301081544065511L,BigInteger.Parse("27648236452749367053"),BigInteger.Parse("2246186004487991819871"),BigInteger.Parse("182943306389766685985005") };
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
public class A184789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184789Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184789.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184789Inst Instance=new A184789Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184790
{
public static readonly BigInteger[] Value={ 19143309L,3680493357L,680930052757L,69241919671789L,10528776249588829L,1538284657636677453L,BigInteger.Parse("203556499352081029533") };
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
public class A184790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184790Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184790.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184790Inst Instance=new A184790Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184791
{
public static readonly long[] Value={ 6891L,100941L,100941L,1451439L,3637117L,1451439L,19143309L,125979493L,125979493L,19143309L,264517911L,3680493357L,10547404447L,3680493357L,264517911L,3635551053L,120704703909L,680930052757L,680930052757L,120704703909L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184791Inst : IEnumerable<long>
{
public static readonly long[] Value=A184791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184791.Bytes);
public long this[int i]=>Value[i];

public static A184791Inst Instance=new A184791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184792
{
public static readonly long[] Value={ 2L,7L,11L,12L,18L,23L,27L,33L,37L,38L,42L,44L,49L,60L,63L,64L,70L,79L,81L,85L,86L,101L,107L,111L,112L,122L,123L,131L,138L,142L,148L,149L,159L,163L,168L,174L,175L,190L,194L,196L,205L,215L,216L,222L,227L,231L,237L,241L,248L,253L,259L,268L,274L,278L,283L,285L,289L,301L,304L,309L,311L,315L,322L,348L,352L,353L,357L,363L,367L,372L,379L,383L,390L,398L,400L,404L,409L,416L,419L,457L,468L,478L,487L,493L,500L,508L,509L,519L,530L,531L,545L,546L,561L,568L,582L,589L,598L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184792Inst : IEnumerable<long>
{
public static readonly long[] Value=A184792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184792.Bytes);
public long this[int i]=>Value[i];

public static A184792Inst Instance=new A184792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184793
{
public static readonly long[] Value={ 2L,5L,7L,8L,10L,12L,14L,16L,17L,18L,19L,20L,22L,25L,26L,27L,30L,31L,32L,33L,34L,38L,40L,41L,42L,45L,46L,47L,48L,50L,52L,53L,55L,56L,58L,60L,61L,63L,65L,66L,67L,69L,70L,72L,73L,74L,76L,77L,79L,80L,81L,84L,86L,87L,88L,89L,91L,93L,94L,95L,96L,97L,98L,103L,104L,105L,106L,107L,108L,110L,112L,114L,115L,117L,118L,119L,121L,122L,123L,131L,134L,137L,138L,139L,140L,142L,143L,146L,148L,149L,152L,153L,155L,157L,160L,162L,163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184793Inst : IEnumerable<long>
{
public static readonly long[] Value=A184793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184793.Bytes);
public long this[int i]=>Value[i];

public static A184793Inst Instance=new A184793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184794
{
public static readonly long[] Value={ 1L,2L,3L,5L,9L,12L,16L,18L,28L,32L,34L,41L,42L,57L,58L,60L,64L,73L,74L,87L,89L,96L,103L,106L,112L,119L,129L,135L,145L,152L,161L,165L,168L,177L,183L,200L,207L,209L,213L,229L,232L,236L,245L,252L,261L,264L,268L,271L,275L,278L,280L,284L,287L,291L,294L,310L,316L,317L,326L,330L,335L,339L,348L,355L,358L,362L,371L,381L,387L,390L,394L,397L,401L,417L,427L,429L,440L,456L,459L,465L,481L,488L,497L,498L,504L,507L,520L,546L,550L,553L,555L,562L,566L,568L,569L,582L,585L,592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184794Inst : IEnumerable<long>
{
public static readonly long[] Value=A184794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184794.Bytes);
public long this[int i]=>Value[i];

public static A184794Inst Instance=new A184794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184795
{
public static readonly long[] Value={ 1L,3L,4L,6L,9L,11L,13L,15L,21L,23L,24L,28L,29L,35L,36L,37L,39L,43L,44L,49L,51L,54L,57L,59L,62L,64L,68L,71L,75L,78L,82L,83L,85L,90L,92L,99L,100L,101L,102L,109L,111L,113L,116L,120L,124L,125L,126L,127L,128L,129L,130L,132L,133L,135L,136L,141L,144L,145L,147L,150L,151L,154L,156L,158L,159L,161L,164L,168L,170L,172L,173L,175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184795Inst : IEnumerable<long>
{
public static readonly long[] Value=A184795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184795.Bytes);
public long this[int i]=>Value[i];

public static A184795Inst Instance=new A184795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184860
{
public static readonly long[] Value={ 1L,2L,3L,7L,8L,12L,14L,18L,19L,23L,29L,33L,38L,44L,45L,49L,51L,55L,60L,66L,70L,81L,86L,92L,97L,101L,103L,107L,112L,118L,119L,122L,123L,138L,140L,144L,148L,149L,155L,159L,166L,171L,175L,181L,190L,192L,196L,208L,216L,218L,222L,227L,234L,237L,248L,253L,259L,260L,274L,285L,286L,296L,301L,311L,322L,323L,338L,344L,348L,353L,363L,370L,375L,379L,390L,396L,400L,407L,416L,422L,427L,433L,438L,453L,457L,459L,464L,468L,475L,478L,500L,501L,511L,527L,531L,542L,546L,548L,563L,568L,574L,579L,585L,589L,600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184860Inst : IEnumerable<long>
{
public static readonly long[] Value=A184860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184860.Bytes);
public long this[int i]=>Value[i];

public static A184860Inst Instance=new A184860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184861
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,8L,9L,10L,11L,12L,15L,16L,18L,20L,21L,22L,23L,24L,25L,28L,30L,32L,34L,35L,37L,38L,39L,40L,42L,43L,44L,45L,46L,48L,49L,51L,52L,53L,54L,55L,57L,59L,61L,62L,63L,64L,66L,68L,70L,71L,72L,73L,75L,76L,79L,80L,81L,82L,86L,89L,90L,92L,93L,96L,98L,99L,101L,102L,103L,105L,107L,109L,111L,112L,115L,116L,118L,120L,122L,124L,125L,126L,127L,130L,131L,132L,133L,134L,136L,137L,140L,141L,144L,147L,149L,151L,153L,154L,156L,157L,158L,159L,161L,162L,164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184861Inst : IEnumerable<long>
{
public static readonly long[] Value=A184861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184861.Bytes);
public long this[int i]=>Value[i];

public static A184861Inst Instance=new A184861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184862
{
public static readonly long[] Value={ 7L,17L,41L,43L,59L,67L,101L,103L,109L,127L,137L,151L,179L,211L,229L,263L,271L,281L,313L,331L,347L,373L,389L,397L,431L,433L,439L,449L,457L,467L,491L,499L,509L,541L,569L,577L,593L,601L,617L,619L,643L,653L,661L,677L,719L,727L,761L,787L,797L,821L,823L,829L,839L,857L,863L,881L,907L,941L,967L,983L,991L,1009L,1033L,1049L,1051L,1069L,1093L,1109L,1117L,1151L,1153L,1187L,1193L,1213L,1229L,1237L,1279L,1289L,1297L,1321L,1373L,1381L,1399L,1423L,1433L,1439L,1483L,1499L,1543L,1549L,1559L,1567L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184862Inst : IEnumerable<long>
{
public static readonly long[] Value=A184862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184862.Bytes);
public long this[int i]=>Value[i];

public static A184862Inst Instance=new A184862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184863
{
public static readonly long[] Value={ 3L,7L,16L,17L,23L,26L,39L,40L,42L,49L,53L,58L,69L,81L,88L,101L,104L,108L,120L,127L,133L,143L,149L,152L,165L,166L,168L,172L,175L,179L,188L,191L,195L,207L,218L,221L,227L,230L,236L,237L,246L,250L,253L,259L,275L,278L,291L,301L,305L,314L,315L,317L,321L,328L,330L,337L,347L,360L,370L,376L,379L,386L,395L,401L,402L,409L,418L,424L,427L,440L,441L,454L,456L,464L,470L,473L,489L,493L,496L,505L,525L,528L,535L,544L,548L,550L,567L,573L,590L,592L,596L,599L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184863Inst : IEnumerable<long>
{
public static readonly long[] Value=A184863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184863.Bytes);
public long this[int i]=>Value[i];

public static A184863Inst Instance=new A184863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184864
{
public static readonly long[] Value={ 4L,7L,13L,14L,17L,19L,26L,27L,29L,31L,33L,36L,41L,47L,50L,56L,58L,60L,65L,67L,69L,74L,77L,78L,83L,84L,85L,87L,88L,91L,94L,95L,97L,100L,104L,106L,108L,110L,113L,114L,117L,119L,121L,123L,128L,129L,135L,138L,139L,142L,143L,145L,146L,148L,150L,152L,155L,160L,163L,166L,167L,169L,174L,176L,177L,180L,183L,186L,187L,190L,191L,195L,196L,198L,201L,203L,207L,209L,211L,216L,220L,221L,222L,224L,227L,228L,235L,239L,243L,244L,246L,247L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184864Inst : IEnumerable<long>
{
public static readonly long[] Value=A184864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184864.Bytes);
public long this[int i]=>Value[i];

public static A184864Inst Instance=new A184864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184865
{
public static readonly long[] Value={ 3L,7L,11L,13L,17L,23L,31L,37L,41L,47L,59L,61L,71L,79L,83L,89L,103L,107L,109L,113L,127L,137L,139L,151L,157L,163L,167L,173L,181L,191L,197L,199L,211L,223L,229L,233L,239L,257L,263L,269L,277L,281L,283L,293L,307L,311L,313L,317L,331L,337L,349L,359L,373L,379L,383L,389L,397L,409L,419L,421L,431L,433L,443L,457L,461L,467L,479L,491L,499L,503L,509L,523L,547L,557L,563L,569L,571L,577L,587L,593L,601L,607L,617L,619L,631L,641L,643L,653L,659L,673L,677L,683L,701L,709L,727L,733L,751L,757L,761L,769L,809L,823L,827L,829L,839L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184865Inst : IEnumerable<long>
{
public static readonly long[] Value=A184865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184865.Bytes);
public long this[int i]=>Value[i];

public static A184865Inst Instance=new A184865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184866
{
public static readonly long[] Value={ 2L,5L,8L,9L,12L,16L,22L,26L,29L,33L,42L,43L,50L,56L,59L,63L,73L,76L,77L,80L,90L,97L,98L,107L,111L,115L,118L,122L,128L,135L,139L,141L,149L,158L,162L,165L,169L,182L,186L,190L,196L,199L,200L,207L,217L,220L,221L,224L,234L,238L,247L,254L,264L,268L,271L,275L,281L,289L,296L,298L,305L,306L,313L,323L,326L,330L,339L,347L,353L,356L,360L,370L,387L,394L,398L,402L,404L,408L,415L,419L,425L,429L,436L,438L,446L,453L,455L,462L,466L,476L,479L,483L,496L,501L,514L,518L,531L,535L,538L,544L,572L,582L,585L,586L,593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184866Inst : IEnumerable<long>
{
public static readonly long[] Value=A184866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184866.Bytes);
public long this[int i]=>Value[i];

public static A184866Inst Instance=new A184866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184867
{
public static readonly long[] Value={ 2L,4L,5L,6L,7L,9L,11L,12L,13L,15L,17L,18L,20L,22L,23L,24L,27L,28L,29L,30L,31L,33L,34L,36L,37L,38L,39L,40L,42L,43L,45L,46L,47L,48L,50L,51L,52L,55L,56L,57L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,70L,72L,74L,75L,76L,77L,78L,80L,81L,82L,83L,84L,86L,88L,89L,91L,92L,94L,95L,96L,97L,99L,101L,102L,103L,104L,105L,106L,107L,108L,110L,111L,113L,114L,115L,116L,117L,119L,120L,122L,123L,124L,126L,127L,129L,130L,133L,134L,135L,136L,140L,143L,144L,145L,146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184867Inst : IEnumerable<long>
{
public static readonly long[] Value=A184867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184867.Bytes);
public long this[int i]=>Value[i];

public static A184867Inst Instance=new A184867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184868
{
public static readonly long[] Value={ 2L,5L,19L,29L,43L,53L,67L,73L,97L,101L,131L,149L,179L,193L,227L,241L,251L,271L,347L,353L,367L,401L,439L,449L,463L,487L,521L,541L,599L,613L,647L,661L,691L,719L,739L,743L,773L,787L,797L,811L,821L,859L,883L,937L,941L,947L,971L,1009L,1019L,1033L,1087L,1091L,1163L,1193L,1217L,1231L,1279L,1289L,1303L,1361L,1367L,1381L,1429L,1439L,1453L,1483L,1487L,1511L,1531L,1559L,1579L,1613L,1627L,1637L,1699L,1709L,1733L,1753L,1777L,1787L,1801L,1811L,1873L,1907L,1931L,1951L,1979L,1999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184868Inst : IEnumerable<long>
{
public static readonly long[] Value=A184868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184868.Bytes);
public long this[int i]=>Value[i];

public static A184868Inst Instance=new A184868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184869
{
public static readonly long[] Value={ 1L,2L,6L,9L,13L,16L,20L,22L,29L,30L,39L,44L,53L,57L,67L,71L,74L,80L,102L,104L,108L,118L,129L,132L,136L,143L,153L,159L,176L,180L,190L,194L,203L,211L,217L,218L,227L,231L,234L,238L,241L,252L,259L,275L,276L,278L,285L,296L,299L,303L,319L,320L,341L,350L,357L,361L,375L,378L,382L,399L,401L,405L,419L,422L,426L,435L,436L,443L,449L,457L,463L,473L,477L,480L,498L,501L,508L,514L,521L,524L,528L,531L,549L,559L,566L,572L,580L,586L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184869Inst : IEnumerable<long>
{
public static readonly long[] Value=A184869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184869.Bytes);
public long this[int i]=>Value[i];

public static A184869Inst Instance=new A184869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184870
{
public static readonly long[] Value={ 1L,3L,8L,10L,14L,16L,19L,21L,25L,26L,32L,35L,41L,44L,49L,53L,54L,58L,69L,71L,73L,79L,85L,87L,90L,93L,98L,100L,109L,112L,118L,121L,125L,128L,131L,132L,137L,138L,139L,141L,142L,149L,153L,159L,160L,161L,164L,169L,171L,174L,181L,182L,192L,196L,199L,202L,207L,209L,213L,218L,219L,221L,226L,228L,231L,235L,236L,240L,242L,246L,249L,255L,258L,259L,266L,267L,270L,273L,275L,277L,279L,280L,287L,292L,294L,297L,299L,303L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184870Inst : IEnumerable<long>
{
public static readonly long[] Value=A184870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184870.Bytes);
public long this[int i]=>Value[i];

public static A184870Inst Instance=new A184870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184871
{
public static readonly long[] Value={ 4L,9L,13L,19L,23L,28L,34L,38L,43L,48L,53L,58L,63L,68L,72L,78L,82L,87L,93L,97L,102L,107L,112L,117L,122L,127L,131L,137L,141L,146L,151L,156L,161L,165L,171L,176L,180L,186L,190L,195L,200L,205L,210L,215L,220L,224L,230L,235L,239L,245L,249L,254L,260L,264L,269L,274L,279L,283L,288L,294L,298L,303L,308L,313L,318L,323L,328L,332L,338L,342L,347L,353L,357L,362L,367L,372L,377L,382L,387L,391L,397L,401L,406L,412L,416L,421L,426L,431L,436L,440L,446L,450L,455L,460L,465L,470L,475L,480L,484L,490L,495L,499L,505L,509L,514L,520L,524L,529L,534L,539L,543L,549L,554L,558L,564L,568L,573L,578L,583L,588L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184871Inst : IEnumerable<long>
{
public static readonly long[] Value=A184871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184871.Bytes);
public long this[int i]=>Value[i];

public static A184871Inst Instance=new A184871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184872
{
public static readonly long[] Value={ 2L,5L,8L,11L,15L,17L,21L,24L,27L,30L,33L,36L,40L,42L,45L,49L,51L,55L,57L,61L,64L,67L,70L,74L,76L,80L,83L,86L,89L,91L,95L,98L,101L,104L,108L,110L,114L,116L,120L,123L,126L,129L,132L,135L,138L,142L,144L,148L,150L,154L,157L,160L,163L,167L,169L,173L,175L,178L,182L,184L,188L,191L,194L,197L,201L,203L,207L,209L,213L,216L,219L,222L,225L,228L,231L,234L,237L,241L,243L,247L,250L,253L,256L,259L,262L,265L,268L,271L,275L,277L,281L,284L,287L,290L,293L,296L,300L,302L,306L,309L,311L,315L,317L,321L,324L,327L,330L,334L,336L,340L,343L,346L,349L,352L,355L,358L,361L,364L,368L,370L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184872Inst : IEnumerable<long>
{
public static readonly long[] Value=A184872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184872.Bytes);
public long this[int i]=>Value[i];

public static A184872Inst Instance=new A184872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184873
{
public static readonly long[] Value={ 1L,3L,6L,7L,10L,12L,14L,16L,18L,20L,22L,25L,26L,29L,31L,32L,35L,37L,39L,41L,44L,46L,47L,50L,52L,54L,56L,59L,60L,62L,65L,66L,69L,71L,73L,75L,77L,79L,81L,84L,85L,88L,90L,92L,94L,96L,99L,100L,103L,105L,106L,109L,111L,113L,115L,118L,119L,121L,124L,125L,128L,130L,133L,134L,136L,139L,140L,143L,145L,147L,149L,152L,153L,155L,158L,159L,162L,164L,166L,168L,170L,172L,174L,177L,179L,181L,183L,185L,187L,189L,192L,193L,196L,198L,199L,202L,204L,206L,208L,211L,212L,214L,217L,218L,221L,223L,226L,227L,229L,232L,233L,236L,238L,240L,242L,244L,246L,248L,251L,252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184873Inst : IEnumerable<long>
{
public static readonly long[] Value=A184873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184873.Bytes);
public long this[int i]=>Value[i];

public static A184873Inst Instance=new A184873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184874
{
public static readonly long[] Value={ 6L,8L,9L,14L,16L,25L,28L,31L,32L,33L,36L,52L,57L,61L,65L,69L,71L,73L,78L,79L,82L,83L,95L,97L,111L,112L,113L,118L,121L,125L,126L,136L,140L,146L,147L,151L,154L,155L,156L,160L,167L,171L,176L,179L,180L,183L,185L,193L,194L,197L,209L,215L,220L,225L,233L,234L,240L,244L,249L,250L,255L,256L,260L,261L,262L,265L,268L,271L,287L,289L,293L,302L,312L,317L,324L,325L,329L,331L,335L,339L,357L,360L,361L,363L,365L,367L,369L,370L,374L,385L,386L,389L,392L,394L,396L,400L,404L,406L,408L,417L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184874Inst : IEnumerable<long>
{
public static readonly long[] Value=A184874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184874.Bytes);
public long this[int i]=>Value[i];

public static A184874Inst Instance=new A184874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184875
{
public static readonly long[] Value={ 1L,3L,5L,7L,18L,19L,23L,24L,26L,37L,38L,39L,40L,43L,45L,53L,58L,59L,60L,62L,64L,66L,70L,76L,77L,84L,85L,88L,89L,90L,91L,92L,94L,96L,100L,101L,104L,106L,107L,117L,119L,120L,123L,124L,129L,130L,131L,133L,134L,135L,137L,139L,145L,150L,152L,157L,159L,161L,162L,165L,166L,172L,174L,175L,178L,188L,189L,192L,198L,203L,204L,205L,208L,216L,217L,218L,219L,222L,224L,226L,227L,228L,230L,245L,246L,254L,257L,258L,264L,266L,269L,270L,279L,280L,283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184875Inst : IEnumerable<long>
{
public static readonly long[] Value=A184875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184875.Bytes);
public long this[int i]=>Value[i];

public static A184875Inst Instance=new A184875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184924
{
public static readonly long[] Value={ 6L,14L,21L,28L,37L,44L,52L,59L,67L,75L,83L,89L,98L,106L,112L,120L,128L,136L,143L,150L,158L,167L,173L,181L,189L,197L,204L,212L,219L,227L,235L,242L,250L,257L,265L,273L,280L,287L,296L,303L,311L,318L,326L,334L,341L,348L,357L,364L,371L,379L,387L,395L,402L,409L,417L,425L,432L,440L,448L,455L,463L,471L,478L,486L,493L,501L,509L,516L,524L,532L,538L,546L,555L,562L,569L,577L,585L,593L,600L,607L,616L,623L,630L,638L,646L,653L,661L,668L,677L,684L,691L,699L,707L,714L,722L,729L,737L,745L,752L,760L,767L,775L,783L,791L,797L,806L,814L,821L,828L,836L,844L,851L,858L,866L,875L,881L,889L,897L,905L,912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184924Inst : IEnumerable<long>
{
public static readonly long[] Value=A184924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184924.Bytes);
public long this[int i]=>Value[i];

public static A184924Inst Instance=new A184924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184925
{
public static readonly long[] Value={ 3L,8L,11L,17L,20L,25L,30L,34L,38L,42L,47L,51L,55L,61L,64L,69L,72L,78L,82L,86L,92L,95L,100L,103L,109L,113L,117L,122L,126L,130L,135L,139L,144L,147L,153L,156L,161L,166L,170L,175L,178L,184L,187L,192L,196L,201L,205L,209L,214L,218L,222L,228L,231L,236L,241L,245L,249L,253L,259L,262L,267L,271L,276L,279L,284L,289L,293L,297L,302L,306L,310L,314L,320L,324L,328L,333L,337L,342L,345L,351L,354L,359L,363L,368L,372L,377L,381L,385L,389L,394L,399L,403L,408L,412L,416L,420L,426L,429L,434L,438L,443L,446L,451L,456L,460L,464L,469L,473L,477L,483L,487L,491L,495L,500L,504L,508L,513L,518L,521L,526L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184925Inst : IEnumerable<long>
{
public static readonly long[] Value=A184925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184925.Bytes);
public long this[int i]=>Value[i];

public static A184925Inst Instance=new A184925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184926
{
public static readonly long[] Value={ 2L,5L,9L,12L,15L,19L,23L,26L,29L,32L,36L,40L,43L,46L,49L,53L,57L,60L,63L,66L,70L,74L,77L,80L,84L,87L,90L,94L,97L,101L,104L,107L,111L,115L,118L,121L,124L,127L,132L,134L,138L,141L,145L,149L,152L,155L,159L,162L,164L,169L,172L,176L,179L,182L,186L,190L,193L,195L,199L,202L,207L,210L,213L,216L,220L,224L,226L,230L,233L,237L,240L,244L,247L,251L,254L,256L,261L,264L,268L,270L,274L,278L,282L,285L,288L,291L,294L,299L,301L,305L,308L,312L,316L,319L,322L,325L,329L,331L,336L,339L,343L,346L,349L,353L,356L,360L,362L,366L,369L,374L,376L,380L,383L,386L,391L,393L,397L,400L,404L,406L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184926Inst : IEnumerable<long>
{
public static readonly long[] Value=A184926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184926.Bytes);
public long this[int i]=>Value[i];

public static A184926Inst Instance=new A184926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184927
{
public static readonly long[] Value={ 1L,4L,7L,10L,13L,16L,18L,22L,24L,27L,31L,33L,35L,39L,41L,45L,48L,50L,54L,56L,58L,62L,65L,68L,71L,73L,76L,79L,81L,85L,88L,91L,93L,96L,99L,102L,105L,108L,110L,114L,116L,119L,123L,125L,129L,131L,133L,137L,140L,142L,146L,148L,151L,154L,157L,160L,163L,165L,168L,171L,174L,177L,180L,183L,185L,188L,191L,194L,198L,200L,203L,206L,208L,211L,215L,217L,221L,223L,225L,229L,232L,234L,238L,239L,243L,246L,248L,252L,255L,258L,260L,263L,266L,269L,272L,275L,277L,281L,283L,286L,290L,292L,295L,298L,300L,304L,307L,309L,313L,315L,317L,321L,323L,327L,330L,332L,335L,338L,340L,344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184927Inst : IEnumerable<long>
{
public static readonly long[] Value=A184927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184927.Bytes);
public long this[int i]=>Value[i];

public static A184927Inst Instance=new A184927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184928
{
public static readonly long[] Value={ 1L,5L,8L,11L,14L,18L,21L,23L,27L,30L,33L,37L,40L,43L,45L,49L,52L,55L,59L,62L,65L,68L,71L,74L,77L,81L,84L,87L,91L,93L,96L,99L,103L,106L,109L,113L,116L,118L,121L,125L,128L,131L,135L,138L,140L,144L,147L,150L,153L,157L,160L,163L,166L,169L,172L,175L,179L,183L,185L,188L,191L,194L,198L,201L,204L,207L,211L,213L,216L,220L,223L,226L,229L,233L,236L,238L,242L,245L,248L,252L,255L,258L,260L,264L,267L,270L,274L,277L,280L,282L,286L,290L,292L,296L,299L,302L,306L,308L,312L,314L,318L,321L,324L,328L,330L,333L,336L,340L,344L,346L,350L,352L,355L,359L,362L,366L,368L,372L,375L,377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184928Inst : IEnumerable<long>
{
public static readonly long[] Value=A184928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184928.Bytes);
public long this[int i]=>Value[i];

public static A184928Inst Instance=new A184928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184929
{
public static readonly long[] Value={ 2L,6L,10L,13L,17L,20L,24L,28L,32L,35L,38L,42L,46L,50L,54L,57L,60L,64L,67L,72L,76L,78L,82L,86L,89L,94L,98L,101L,104L,108L,112L,115L,119L,123L,126L,130L,134L,137L,141L,145L,148L,152L,156L,158L,162L,167L,170L,174L,178L,180L,184L,189L,192L,196L,199L,203L,206L,210L,215L,217L,221L,225L,228L,232L,237L,239L,243L,247L,250L,254L,257L,261L,265L,269L,272L,276L,279L,283L,287L,291L,294L,297L,301L,305L,309L,313L,317L,319L,323L,327L,331L,335L,338L,341L,345L,349L,353L,357L,360L,363L,367L,371L,374L,378L,382L,385L,389L,393L,395L,400L,404L,408L,411L,415L,418L,421L,426L,430L,433L,436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184929Inst : IEnumerable<long>
{
public static readonly long[] Value=A184929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184929.Bytes);
public long this[int i]=>Value[i];

public static A184929Inst Instance=new A184929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184930
{
public static readonly long[] Value={ 3L,7L,12L,16L,22L,25L,29L,34L,39L,44L,48L,51L,56L,61L,66L,70L,75L,79L,83L,88L,92L,97L,102L,105L,110L,114L,120L,124L,129L,132L,136L,142L,146L,151L,155L,159L,164L,168L,173L,177L,182L,186L,190L,195L,200L,205L,209L,212L,218L,222L,227L,231L,235L,240L,244L,249L,253L,259L,263L,266L,271L,275L,281L,285L,289L,293L,298L,303L,307L,311L,316L,320L,325L,329L,334L,339L,343L,347L,351L,356L,361L,365L,369L,373L,379L,383L,388L,392L,396L,401L,405L,410L,414L,419L,423L,427L,432L,437L,442L,446L,449L,454L,459L,464L,468L,472L,477L,481L,486L,490L,494L,500L,503L,508L,512L,518L,522L,526L,530L,534L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184930Inst : IEnumerable<long>
{
public static readonly long[] Value=A184930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184930.Bytes);
public long this[int i]=>Value[i];

public static A184930Inst Instance=new A184930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184931
{
public static readonly long[] Value={ 4L,9L,15L,19L,26L,31L,36L,41L,47L,53L,58L,63L,69L,73L,80L,85L,90L,95L,100L,107L,111L,117L,122L,127L,133L,139L,143L,149L,154L,161L,165L,171L,176L,181L,187L,193L,197L,202L,208L,214L,219L,224L,230L,234L,241L,246L,251L,256L,262L,268L,273L,278L,284L,288L,295L,300L,304L,310L,315L,322L,326L,332L,337L,342L,348L,354L,358L,364L,370L,376L,380L,386L,391L,397L,402L,407L,413L,417L,424L,429L,434L,439L,445L,450L,456L,461L,467L,471L,478L,483L,488L,493L,499L,504L,509L,515L,520L,525L,531L,537L,541L,547L,552L,558L,563L,569L,574L,579L,585L,591L,595L,601L,606L,611L,617L,622L,628L,632L,639L,644L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184931Inst : IEnumerable<long>
{
public static readonly long[] Value=A184931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184931.Bytes);
public long this[int i]=>Value[i];

public static A184931Inst Instance=new A184931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184932
{
public static readonly long[] Value={ 1L,1L,2L,9L,44L,285L,2574L,17479L,240120L,4294809L,-53319430L,2888052651L,28103393988L,-7708254850907L,595898006060070L,-20913075474597585L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184932Inst : IEnumerable<long>
{
public static readonly long[] Value=A184932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184932.Bytes);
public long this[int i]=>Value[i];

public static A184932Inst Instance=new A184932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184933
{
public static readonly long[] Value={ 1L,1L,0L,-1L,28L,-199L,-810L,84125L,-2231672L,18619009L,1886209290L,-144396954219L,5326540123980L,55447790609537L,-28933469725898738L,2773000675491639437L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184933Inst : IEnumerable<long>
{
public static readonly long[] Value=A184933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184933.Bytes);
public long this[int i]=>Value[i];

public static A184933Inst Instance=new A184933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184934
{
public static readonly BigInteger[] Value={ 1L,1L,1L,5L,-11L,205L,-1765L,5777L,694649L,-38461879L,1422488295L,-31213820867L,-964128307963L,193023347206989L,-16143387806661765L,823270824766914937L,7651066510933806705L,BigInteger.Parse("-8731968937328466812015"),BigInteger.Parse("1366901331794928400963087") };
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
public class A184934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184934Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184934.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184934Inst Instance=new A184934Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184935
{
public static readonly long[] Value={ 3L,7L,23L,83L,181L,239L,563L,1013L,1447L,1607L,2129L,2729L,3167L,3881L,4673L,5849L,6481L,7489L,8563L,9719L,11813L,18713L,21563L,25247L,27197L,29221L,33469L,36467L,47977L,50683L,51599L,56237L,69257L,71389L,75731L,96893L,107119L,115163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184935Inst : IEnumerable<long>
{
public static readonly long[] Value=A184935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184935.Bytes);
public long this[int i]=>Value[i];

public static A184935Inst Instance=new A184935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184936
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,19L,41L,87L,188L,399L,855L,1839L,3908L,8300L,18406L,37287L,78412L,217444L,208980L,752447L,6966312L,-32965587L,103369671L,665090041L,-9555165542L,56572244738L,-57544084949L,-2431577060646L,28175813965760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184936Inst : IEnumerable<long>
{
public static readonly long[] Value=A184936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184936.Bytes);
public long this[int i]=>Value[i];

public static A184936Inst Instance=new A184936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184937
{
public static readonly long[] Value={ 3L,6L,19L,65L,231L,840L,3102L,11583L,43615L,165308L,629850L,2410226L,9256534L,35659200L,137733660L,533216475L,2068423695L,8037976980L,31285334850L,121941160110L,475898730450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184937Inst : IEnumerable<long>
{
public static readonly long[] Value=A184937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184937.Bytes);
public long this[int i]=>Value[i];

public static A184937Inst Instance=new A184937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184938
{
public static readonly long[] Value={ 1L,9L,17L,5L,13L,21L,3L,11L,19L,7L,15L,23L,2L,10L,18L,6L,14L,22L,20L,8L,16L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184938Inst : IEnumerable<long>
{
public static readonly long[] Value=A184938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184938.Bytes);
public long this[int i]=>Value[i];

public static A184938Inst Instance=new A184938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184939
{
public static readonly long[] Value={ 1L,2L,6L,7L,8L,9L,10L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,78L,79L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,90L,91L,92L,93L,94L,95L,96L,97L,98L,99L,100L,130L,131L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184939Inst : IEnumerable<long>
{
public static readonly long[] Value=A184939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184939.Bytes);
public long this[int i]=>Value[i];

public static A184939Inst Instance=new A184939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185020
{
public static readonly BigInteger[] Value={ 1L,2L,12L,80L,616L,5040L,43296L,384384L,3500640L,32517056L,306896512L,2934597120L,28369508608L,276810483200L,2722537128960L,26963147796480L,268659456837120L,2691301381401600L,27089160416102400L,273833161582632960L,2778754123765002240L,BigInteger.Parse("28296326851107594240") };
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
public class A185020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185020Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A185020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185020.Bytes);
public BigInteger this[int i]=>Value[i];

public static A185020Inst Instance=new A185020Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185021
{
public static readonly long[] Value={ 1L,2L,6L,12L,60L,120L,840L,840L,7560L,15120L,166320L,110880L,1441440L,2882880L,43243200L,10810800L,183783600L,367567200L,6983776800L,2793510720L,58663725120L,117327450240L,2698531355520L,299836817280L,7495920432000L,14991840864000L,404779703328000L,115651343808000L,3353888970432000L,6707777940864000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185021Inst : IEnumerable<long>
{
public static readonly long[] Value=A185021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185021.Bytes);
public long this[int i]=>Value[i];

public static A185021Inst Instance=new A185021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185022
{
public static readonly long[] Value={ 5L,7L,17L,19L,29L,47L,59L,89L,127L,139L,167L,199L,227L,239L,257L,269L,397L,409L,419L,467L,479L,607L,619L,727L,797L,929L,997L,1009L,1039L,1277L,1279L,1427L,1447L,1459L,1487L,1499L,1559L,1597L,1697L,1709L,1777L,1877L,1889L,1987L,2087L,2129L,2269L,2399L,2609L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185022Inst : IEnumerable<long>
{
public static readonly long[] Value=A185022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185022.Bytes);
public long this[int i]=>Value[i];

public static A185022Inst Instance=new A185022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185023
{
public static readonly long[] Value={ 0L,2L,1L,5L,4L,3L,3L,7L,2L,21L,6L,6L,20L,10L,5L,5L,19L,4L,9L,4L,4L,23L,18L,8L,8L,8L,3L,27L,22L,22L,17L,12L,7L,7L,7L,7L,26L,21L,21L,16L,16L,11L,11L,11L,6L,6L,6L,6L,25L,20L,20L,20L,15L,5L,15L,10L,10L,10L,10L,5L,5L,29L,5L,24L,24L,24L,19L,19L,19L,19L,14L,9L,14L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185023Inst : IEnumerable<long>
{
public static readonly long[] Value=A185023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185023.Bytes);
public long this[int i]=>Value[i];

public static A185023Inst Instance=new A185023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185024
{
public static readonly long[] Value={ 2L,3L,4L,5L,7L,8L,9L,11L,12L,13L,14L,16L,17L,18L,19L,22L,23L,24L,25L,26L,27L,29L,30L,31L,32L,33L,34L,37L,38L,39L,40L,41L,42L,43L,44L,46L,47L,48L,49L,50L,51L,52L,53L,54L,57L,58L,59L,60L,61L,62L,63L,64L,65L,67L,68L,69L,71L,72L,73L,74L,75L,76L,77L,79L,80L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185024Inst : IEnumerable<long>
{
public static readonly long[] Value=A185024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185024.Bytes);
public long this[int i]=>Value[i];

public static A185024Inst Instance=new A185024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185025
{
public static readonly long[] Value={ 1L,1L,3L,1L,18L,9L,163L,90L,3L,1950L,1100L,75L,28821L,16245L,1575L,15L,505876L,283122L,33810L,735L,10270569L,5699932L,780150L,26460L,105L,236644092L,130267440L,19615932L,884520L,8505L,6098971555L,3332614725L,538325550L,29619450L,467775L,945L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185025Inst : IEnumerable<long>
{
public static readonly long[] Value=A185025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185025.Bytes);
public long this[int i]=>Value[i];

public static A185025Inst Instance=new A185025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185026
{
public static readonly long[] Value={ 1L,2L,3L,3L,5L,6L,2L,8L,9L,3L,11L,10L,9L,14L,15L,5L,6L,18L,6L,20L,21L,6L,23L,21L,8L,26L,10L,9L,29L,30L,3L,6L,33L,11L,35L,36L,10L,15L,39L,27L,41L,8L,14L,44L,6L,15L,18L,48L,15L,50L,51L,6L,53L,54L,18L,56L,22L,6L,24L,55L,20L,50L,63L,21L,65L,9L,18L,68L,69L,23L,30L,14L,21L,74L,75L,24L,30L,78L,26L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185026Inst : IEnumerable<long>
{
public static readonly long[] Value=A185026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185026.Bytes);
public long this[int i]=>Value[i];

public static A185026Inst Instance=new A185026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185027
{
public static readonly long[] Value={ 1L,1L,4L,1L,1L,10L,1L,1L,4L,11L,1L,10L,1L,1L,19L,1L,1L,10L,1L,11L,25L,1L,1L,10L,1L,1L,4L,29L,1L,35L,1L,1L,4L,1L,1L,46L,1L,1L,4L,11L,1L,31L,1L,1L,64L,1L,1L,10L,1L,11L,4L,1L,1L,10L,56L,29L,4L,1L,1L,35L,1L,1L,25L,1L,1L,76L,1L,1L,4L,11L,1L,46L,1L,1L,19L,1L,1L,88L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185027Inst : IEnumerable<long>
{
public static readonly long[] Value=A185027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185027.Bytes);
public long this[int i]=>Value[i];

public static A185027Inst Instance=new A185027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185028
{
public static readonly long[] Value={ 1L,55L,555L,7777L,66666L,888888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185028Inst : IEnumerable<long>
{
public static readonly long[] Value=A185028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185028.Bytes);
public long this[int i]=>Value[i];

public static A185028Inst Instance=new A185028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185029
{
public static readonly BigInteger[] Value={ 1L,1L,2L,65L,3524L,1364432L,1445333132L,7913299718555L,162327934705456532L,BigInteger.Parse("14083866155101076361024"),BigInteger.Parse("5251111824344114834186373747"),BigInteger.Parse("7956883819596423111541696080219295"),BigInteger.Parse("51760975171209084256721290749117849746987"),BigInteger.Parse("1424616119143714906580708999710589586791029920856") };
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
public class A185029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185029Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A185029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185029.Bytes);
public BigInteger this[int i]=>Value[i];

public static A185029Inst Instance=new A185029Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185030
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,4L,6L,10L,20L,36L,66L,132L,250L,478L,956L,1854L,3612L,7224L,14178L,27898L,55796L,110246L,218166L,436332L,865618L,1718902L,3437804L,6837398L,13607250L,27214500L,54216128L,108053078L,216106156L,431001044L,859831354L,1719662708L,3432314834L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185030Inst : IEnumerable<long>
{
public static readonly long[] Value=A185030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185030.Bytes);
public long this[int i]=>Value[i];

public static A185030Inst Instance=new A185030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185031
{
public static readonly long[] Value={ 5L,6L,12L,14L,17L,28L,37L,38L,44L,70L,88L,92L,98L,101L,108L,110L,134L,152L,168L,170L,172L,197L,206L,220L,248L,257L,284L,348L,374L,398L,401L,410L,428L,434L,496L,550L,577L,580L,590L,604L,632L,638L,677L,726L,748L,752L,798L,884L,910L,918L,952L,974L,988L,1032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185031Inst : IEnumerable<long>
{
public static readonly long[] Value=A185031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185031.Bytes);
public long this[int i]=>Value[i];

public static A185031Inst Instance=new A185031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185032
{
public static readonly long[] Value={ 30L,230L,644L,1308L,2664L,6850L,10280L,39693L,44360L,48919L,218972L,534078L,2699915L,526095L,17233173L,127890362L,29138958036L,146216247221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185032Inst : IEnumerable<long>
{
public static readonly long[] Value=A185032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185032.Bytes);
public long this[int i]=>Value[i];

public static A185032Inst Instance=new A185032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185033
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,8L,29L,138L,774L,5678L,53324L,622716L,8604351L,135344959L,2363662004L,45134533117L,933058713014L,20735549517852L,492653820710746L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185033Inst : IEnumerable<long>
{
public static readonly long[] Value=A185033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185033.Bytes);
public long this[int i]=>Value[i];

public static A185033Inst Instance=new A185033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185034
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,2L,9L,35L,176L,1151L,10329L,120456L,1701834L,27500216L,492269472L,9599036308L,201954501535L,4555108534562L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185034Inst : IEnumerable<long>
{
public static readonly long[] Value=A185034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185034.Bytes);
public long this[int i]=>Value[i];

public static A185034Inst Instance=new A185034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185035
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,12L,67L,597L,7134L,107820L,1876672L,35924730L,741405102L,16356067055L,383931363314L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185035Inst : IEnumerable<long>
{
public static readonly long[] Value=A185035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185035.Bytes);
public long this[int i]=>Value[i];

public static A185035Inst Instance=new A185035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185196
{
public static readonly long[] Value={ 7L,4L,6L,7L,1L,8L,3L,1L,1L,4L,7L,6L,2L,1L,0L,7L,3L,6L,1L,5L,2L,1L,3L,1L,8L,3L,3L,8L,0L,8L,0L,7L,3L,0L,1L,4L,6L,4L,9L,5L,6L,7L,1L,6L,7L,6L,7L,7L,2L,0L,2L,2L,5L,6L,3L,5L,7L,3L,8L,6L,1L,0L,7L,7L,8L,5L,1L,0L,6L,9L,1L,9L,7L,2L,8L,3L,1L,4L,6L,0L,1L,2L,9L,6L,5L,4L,5L,9L,5L,0L,3L,2L,4L,4L,3L,0L,9L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185196Inst : IEnumerable<long>
{
public static readonly long[] Value=A185196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185196.Bytes);
public long this[int i]=>Value[i];

public static A185196Inst Instance=new A185196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185197
{
public static readonly long[] Value={ 2L,0L,2L,6L,4L,2L,3L,6L,7L,2L,8L,4L,6L,7L,5L,5L,4L,2L,8L,8L,7L,7L,5L,8L,9L,2L,6L,4L,1L,9L,4L,5L,5L,2L,7L,7L,8L,0L,8L,7L,1L,7L,5L,4L,9L,3L,4L,4L,4L,9L,3L,0L,9L,7L,6L,9L,1L,2L,1L,8L,0L,6L,3L,7L,8L,8L,3L,4L,6L,2L,4L,1L,9L,2L,4L,4L,7L,0L,8L,8L,2L,3L,8L,2L,4L,1L,8L,5L,4L,7L,8L,5L,1L,2L,4L,3L,6L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185197Inst : IEnumerable<long>
{
public static readonly long[] Value=A185197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185197.Bytes);
public long this[int i]=>Value[i];

public static A185197Inst Instance=new A185197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185198
{
public static readonly long[] Value={ 2L,3L,4L,5L,8L,8L,4L,7L,6L,1L,6L,3L,4L,6L,3L,8L,6L,4L,4L,1L,2L,0L,1L,7L,0L,0L,3L,5L,4L,0L,2L,5L,0L,0L,4L,7L,0L,5L,0L,9L,9L,6L,6L,7L,1L,0L,8L,3L,2L,7L,0L,9L,5L,8L,0L,7L,0L,4L,0L,3L,4L,0L,4L,4L,7L,4L,5L,7L,3L,4L,2L,5L,1L,0L,6L,4L,4L,6L,0L,4L,7L,2L,4L,8L,3L,7L,7L,7L,4L,5L,6L,8L,0L,2L,2L,4L,6L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185198Inst : IEnumerable<long>
{
public static readonly long[] Value=A185198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185198.Bytes);
public long this[int i]=>Value[i];

public static A185198Inst Instance=new A185198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185199
{
public static readonly long[] Value={ 4L,0L,5L,2L,8L,4L,7L,3L,4L,5L,6L,9L,3L,5L,1L,0L,8L,5L,7L,7L,5L,5L,1L,7L,8L,5L,2L,8L,3L,8L,9L,1L,0L,5L,5L,5L,6L,1L,7L,4L,3L,5L,0L,9L,8L,6L,8L,8L,9L,8L,6L,1L,9L,5L,3L,8L,2L,4L,3L,6L,1L,2L,7L,5L,7L,6L,6L,9L,2L,4L,8L,3L,8L,4L,8L,9L,4L,1L,7L,6L,4L,7L,6L,4L,8L,3L,7L,0L,9L,5L,7L,0L,2L,4L,8L,7L,3L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185199Inst : IEnumerable<long>
{
public static readonly long[] Value=A185199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185199.Bytes);
public long this[int i]=>Value[i];

public static A185199Inst Instance=new A185199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185200
{
public static readonly long[] Value={ 6L,8L,8L,10L,12L,10L,12L,16L,20L,12L,14L,20L,38L,28L,14L,16L,24L,60L,52L,48L,16L,18L,28L,80L,84L,134L,60L,18L,20L,32L,100L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185200Inst : IEnumerable<long>
{
public static readonly long[] Value=A185200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185200.Bytes);
public long this[int i]=>Value[i];

public static A185200Inst Instance=new A185200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185201
{
public static readonly long[] Value={ 5L,11L,9L,33L,11L,21L,27L,29L,71L,57L,53L,39L,137L,29L,53L,83L,23L,33L,57L,27L,113L,71L,53L,303L,321L,249L,107L,261L,53L,17L,81L,119L,47L,513L,237L,179L,123L,123L,173L,27L,203L,137L,119L,77L,119L,147L,83L,47L,183L,161L,333L,339L,611L,579L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185201Inst : IEnumerable<long>
{
public static readonly long[] Value=A185201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185201.Bytes);
public long this[int i]=>Value[i];

public static A185201Inst Instance=new A185201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185202
{
public static readonly long[] Value={ 1L,1L,2L,6L,20L,70L,255L,961L,3717L,14663L,58758L,238524L,978844L,4054152L,16924986L,71145392L,300876074L,1279225578L,5464762332L,23444755016L,100968932096L,436355661280L,1891770895672L,8225329914410L,35858439130786L,156708088823482L,686392551655052L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185202Inst : IEnumerable<long>
{
public static readonly long[] Value=A185202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185202.Bytes);
public long this[int i]=>Value[i];

public static A185202Inst Instance=new A185202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185203
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,11L,550L,806174L,2585947720L,9802278927562L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185203Inst : IEnumerable<long>
{
public static readonly long[] Value=A185203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185203.Bytes);
public long this[int i]=>Value[i];

public static A185203Inst Instance=new A185203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185204
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,2L,1L,0L,2L,1L,1L,4L,1L,1L,0L,4L,0L,1L,1L,6L,2L,1L,0L,7L,0L,1L,1L,10L,9L,1L,1L,0L,11L,0L,0L,1L,1L,15L,35L,2L,1L,0L,17L,0L,2L,1L,1L,23L,177L,15L,1L,1L,0L,26L,0L,35L,0L,1L,1L,33L,1153L,247L,1L,1L,0L,38L,0L,1692L,0L,1L,1L,49L,10341L,17409L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185204Inst : IEnumerable<long>
{
public static readonly long[] Value=A185204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185204.Bytes);
public long this[int i]=>Value[i];

public static A185204Inst Instance=new A185204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185205
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,2L,1L,0L,2L,1L,1L,3L,1L,0L,4L,1L,1L,5L,1L,0L,6L,1L,1L,8L,1L,0L,9L,1L,1L,12L,1L,1L,0L,14L,0L,1L,1L,17L,2L,1L,0L,20L,0L,1L,1L,25L,12L,1L,0L,29L,0L,1L,1L,35L,67L,1L,0L,41L,0L,1L,1L,49L,598L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185205Inst : IEnumerable<long>
{
public static readonly long[] Value=A185205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185205.Bytes);
public long this[int i]=>Value[i];

public static A185205Inst Instance=new A185205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185206
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,2L,1L,0L,2L,1L,1L,3L,1L,0L,3L,1L,1L,5L,1L,0L,5L,1L,1L,7L,1L,0L,8L,1L,1L,10L,1L,0L,11L,1L,1L,15L,1L,0L,16L,1L,1L,20L,1L,0L,23L,1L,1L,28L,1L,1L,0L,31L,0L,1L,1L,39L,1L,1L,0L,43L,0L,1L,1L,52L,6L,1L,0L,59L,0L,1L,1L,70L,37L,1L,0L,79L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185206Inst : IEnumerable<long>
{
public static readonly long[] Value=A185206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185206.Bytes);
public long this[int i]=>Value[i];

public static A185206Inst Instance=new A185206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185207
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,2L,1L,0L,2L,1L,1L,3L,1L,0L,3L,1L,1L,4L,1L,0L,5L,1L,1L,6L,1L,0L,7L,1L,1L,9L,1L,0L,10L,1L,1L,12L,1L,0L,14L,1L,1L,17L,1L,0L,19L,1L,1L,23L,1L,0L,26L,1L,1L,31L,1L,0L,35L,1L,1L,41L,1L,0L,47L,1L,1L,55L,1L,0L,62L,1L,1L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185207Inst : IEnumerable<long>
{
public static readonly long[] Value=A185207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185207.Bytes);
public long this[int i]=>Value[i];

public static A185207Inst Instance=new A185207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185208
{
public static readonly long[] Value={ 1L,5L,11L,13L,17L,19L,23L,25L,29L,37L,41L,43L,47L,53L,55L,59L,61L,65L,67L,71L,73L,79L,83L,85L,89L,95L,97L,101L,103L,107L,109L,113L,115L,121L,125L,131L,137L,139L,143L,145L,149L,151L,157L,163L,167L,169L,173L,179L,181L,185L,187L,191L,193L,197L,199L,205L,209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185208Inst : IEnumerable<long>
{
public static readonly long[] Value=A185208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185208.Bytes);
public long this[int i]=>Value[i];

public static A185208Inst Instance=new A185208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185209
{
public static readonly long[] Value={ 1L,1L,0L,2L,1L,0L,5L,8L,0L,0L,14L,49L,8L,0L,0L,42L,268L,151L,0L,0L,0L,132L,1375L,1760L,180L,0L,0L,0L,429L,6768L,16184L,5712L,0L,0L,0L,0L,1430L,32354L,128578L,102917L,8064L,0L,0L,0L,0L,4862L,151336L,923799L,1379384L,369944L,0L,0L,0L,0L,0L,16796L,696027L,6164460L,15283308L,9233512L,604800L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185209Inst : IEnumerable<long>
{
public static readonly long[] Value=A185209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185209.Bytes);
public long this[int i]=>Value[i];

public static A185209Inst Instance=new A185209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185210
{
public static readonly long[] Value={ 6L,24L,30L,42L,48L,54L,60L,84L,96L,108L,120L,144L,150L,156L,168L,180L,192L,210L,216L,240L,270L,294L,330L,336L,378L,384L,390L,420L,432L,462L,480L,486L,504L,510L,528L,540L,546L,576L,594L,600L,624L,630L,672L,714L,720L,726L,750L,756L,768L,810L,840L,864L,924L,930L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185210Inst : IEnumerable<long>
{
public static readonly long[] Value=A185210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185210.Bytes);
public long this[int i]=>Value[i];

public static A185210Inst Instance=new A185210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185211
{
public static readonly long[] Value={ 1L,6L,153L,231L,351L,465L,741L,6786L,24531L,57291L,58311L,123753L,153181L,167331L,278631L,325221L,372816L,613278L,783126L,1136278L,1476621L,1511191L,1516411L,1783216L,2191371L,2512161L,2676141L,9127128L,37311841L,44731611L,51121216L,135112141L,137141641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185211Inst : IEnumerable<long>
{
public static readonly long[] Value=A185211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185211.Bytes);
public long this[int i]=>Value[i];

public static A185211Inst Instance=new A185211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185228
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,2L,2L,3L,3L,4L,4L,6L,6L,8L,9L,11L,12L,15L,16L,20L,22L,26L,29L,35L,38L,45L,50L,59L,65L,76L,84L,98L,109L,125L,139L,161L,178L,204L,227L,259L,288L,328L,364L,414L,460L,520L,578L,654L,725L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185228Inst : IEnumerable<long>
{
public static readonly long[] Value=A185228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185228.Bytes);
public long this[int i]=>Value[i];

public static A185228Inst Instance=new A185228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185229
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,2L,2L,3L,3L,4L,4L,5L,6L,7L,8L,10L,11L,13L,15L,17L,19L,23L,25L,29L,33L,38L,42L,49L,54L,62L,70L,79L,88L,101L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185229Inst : IEnumerable<long>
{
public static readonly long[] Value=A185229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185229.Bytes);
public long this[int i]=>Value[i];

public static A185229Inst Instance=new A185229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185230
{
public static readonly long[] Value={ 5L,67L,157L,12211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185230Inst : IEnumerable<long>
{
public static readonly long[] Value=A185230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185230.Bytes);
public long this[int i]=>Value[i];

public static A185230Inst Instance=new A185230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185231
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,13L,23L,43L,83L,163L,317L,631L,1259L,2503L,5003L,9973L,19937L,39869L,79699L,159389L,318751L,637499L,1274989L,2549951L,5099893L,10199767L,20399531L,40799041L,81598067L,163196129L,326392249L,652784471L,1305568919L,2611137817L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185231Inst : IEnumerable<long>
{
public static readonly long[] Value=A185231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185231.Bytes);
public long this[int i]=>Value[i];

public static A185231Inst Instance=new A185231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185232
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,4L,0L,0L,0L,1520L,0L,0L,0L,235072L,0L,0L,705280L,278539264L,0L,0L,0L,226593936L,0L,0L,0L,295266178368L,0L,24143851798528L,27L,10557680820452065280UL,0L,0L,0L,BigInteger.Parse("2821525007683005301391360"),0L,0L,BigInteger.Parse("2821525007683005301391360"),BigInteger.Parse("43942858408664114852524638339072") };
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
public class A185232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185232Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A185232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185232.Bytes);
public BigInteger this[int i]=>Value[i];

public static A185232Inst Instance=new A185232Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185233
{
public static readonly long[] Value={ 5L,14L,27L,39L,65L,54L,104L,125L,242L,209L,374L,459L,350L,275L,714L,782L,350L,1155L,1224L,1022L,1425L,840L,594L,1715L,1700L,1869L,702L,1260L,1224L,1014L,2645L,2430L,3185L,1127L,4094L,3317L,1274L,5124L,6060L,3834L,3059L,6174L,5565L,7749L,8349L,7395L,7344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185233Inst : IEnumerable<long>
{
public static readonly long[] Value=A185233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185233.Bytes);
public long this[int i]=>Value[i];

public static A185233Inst Instance=new A185233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185234
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,2L,9L,35L,177L,1153L,10341L,120523L,1702432L,27507351L,492377298L,9600913017L,201990426697L,4555849947783L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185234Inst : IEnumerable<long>
{
public static readonly long[] Value=A185234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185234.Bytes);
public long this[int i]=>Value[i];

public static A185234Inst Instance=new A185234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185235
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,12L,67L,598L,7135L,107826L,1876709L,35925162L,741413221L,16356258309L,383936219233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185235Inst : IEnumerable<long>
{
public static readonly long[] Value=A185235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185235.Bytes);
public long this[int i]=>Value[i];

public static A185235Inst Instance=new A185235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185236
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,6L,37L,432L,8119L,191254L,4855919L,127937854L,3482858263L,98176518259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185236Inst : IEnumerable<long>
{
public static readonly long[] Value=A185236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185236.Bytes);
public long this[int i]=>Value[i];

public static A185236Inst Instance=new A185236Inst();

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