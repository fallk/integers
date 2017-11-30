using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A286027
{
public static readonly BigInteger[] Value={ 1L,1L,0L,11L,10000L,111L,1000000L,1111L,100000000L,10011111L,11000000000L,1100111111L,0L,1111111L,1110000000000L,1000000011111111L,11000000000000L,1100111111111L,1000000000000000000L,1001001111111111L,0L,BigInteger.Parse("1100000000011111111111"),1111100000000000000L };
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
public class A286027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286027Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286027.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286027Inst Instance=new A286027Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286028
{
public static readonly long[] Value={ 1L,2L,0L,12L,1L,56L,1L,240L,1L,996L,3L,4044L,0L,16256L,28L,65281L,24L,261728L,1L,1047696L,0L,4192259L,496L,16773127L,64L,67102265L,192L,268421177L,448L,1073709088L,4161L,4294901792L,1104L,17179768832L,1091L,68719247368L,67L,274877382688L,101443L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286028Inst : IEnumerable<long>
{
public static readonly long[] Value=A286028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286028.Bytes);
public long this[int i]=>Value[i];

public static A286028Inst Instance=new A286028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286029
{
public static readonly long[] Value={ 1L,1L,0L,3L,16L,7L,64L,15L,256L,159L,1536L,831L,0L,127L,7168L,33023L,12288L,6655L,262144L,37887L,0L,3147775L,507904L,14684159L,262144L,41000959L,1572864L,163659775L,7340032L,16809983L,1090781184L,67174399L,339738624L,7995391L,26055016448L,4296278015L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286029Inst : IEnumerable<long>
{
public static readonly long[] Value=A286029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286029.Bytes);
public long this[int i]=>Value[i];

public static A286029Inst Instance=new A286029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286030
{
public static readonly long[] Value={ 1L,1L,2L,1L,6L,2L,1L,8L,6L,12L,1L,10L,20L,20L,30L,1L,12L,30L,30L,20L,120L,30L,1L,14L,42L,42L,70L,210L,140L,210L,1L,16L,56L,56L,112L,336L,70L,560L,420L,560L,1L,18L,72L,72L,168L,504L,252L,1008L,756L,630L,2520L,560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286030Inst : IEnumerable<long>
{
public static readonly long[] Value=A286030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286030.Bytes);
public long this[int i]=>Value[i];

public static A286030Inst Instance=new A286030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286031
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,9L,11L,12L,13L,14L,16L,17L,20L,21L,23L,24L,26L,27L,30L,31L,33L,34L,36L,37L,40L,41L,43L,44L,45L,46L,48L,49L,52L,53L,55L,56L,58L,59L,62L,63L,66L,67L,70L,71L,73L,74L,76L,77L,80L,81L,83L,84L,85L,86L,88L,89L,92L,93L,95L,96L,98L,99L,102L,103L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286031Inst : IEnumerable<long>
{
public static readonly long[] Value=A286031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286031.Bytes);
public long this[int i]=>Value[i];

public static A286031Inst Instance=new A286031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286032
{
public static readonly long[] Value={ 1L,1L,-1L,-4L,0L,20L,20L,-120L,-280L,800L,3600L,-5200L,-48400L,19200L,696800L,408800L,-10740000L,-17689600L,175630400L,511732800L,-3000875200L,-13747264000L,52271990400L,368459062400L,-886068707200L,-10097545267200L,12940241120000L,285573963334400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286032Inst : IEnumerable<long>
{
public static readonly long[] Value=A286032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286032.Bytes);
public long this[int i]=>Value[i];

public static A286032Inst Instance=new A286032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286033
{
public static readonly long[] Value={ 0L,3L,5L,21L,69L,253L,923L,3433L,12869L,48621L,184755L,705433L,2704155L,10400601L,40116599L,155117521L,601080389L,2333606221L,9075135299L,35345263801L,137846528819L,538257874441L,2104098963719L,8233430727601L,32247603683099L,126410606437753L,495918532948103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286033Inst : IEnumerable<long>
{
public static readonly long[] Value=A286033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286033.Bytes);
public long this[int i]=>Value[i];

public static A286033Inst Instance=new A286033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286034
{
public static readonly long[] Value={ 1L,8L,3L,49L,8L,34L,3L,239L,124L,97L,8L,165L,30L,34L,34L,1051L,47L,1237L,17L,508L,21L,97L,8L,727L,565L,331L,74L,165L,122L,733L,3L,4403L,34L,502L,34L,7911L,192L,196L,72L,2302L,233L,526L,68L,508L,1237L,97L,8L,3051L,1774L,5368L,97L,1782L,380L,727L,97L,727L,51L,1231L,122L,3220L,498L,34L,288L,18019L,331L,733L,155L,2713L,34L,733L,47L,35317L,705L,1897L,873L,1047L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286034Inst : IEnumerable<long>
{
public static readonly long[] Value=A286034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286034.Bytes);
public long this[int i]=>Value[i];

public static A286034Inst Instance=new A286034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286035
{
public static readonly BigInteger[] Value={ 0L,18315L,210375L,17232775560L,197941645440L,16214284059063255L,186242898311223435L,BigInteger.Parse("15255987442587265956120"),BigInteger.Parse("175235570535035566127880"),BigInteger.Parse("14354328072739259079522561195"),BigInteger.Parse("164878797845087651200279041495"),BigInteger.Parse("13505958574968967401962031517525680"),BigInteger.Parse("155134131134672045268505114018663320") };
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
public class A286035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286035Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286035.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286035Inst Instance=new A286035Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286036
{
public static readonly BigInteger[] Value={ 0L,2478630L,96492000L,2262209634604920L,88065491686677120L,BigInteger.Parse("2064651070850763887750940"),BigInteger.Parse("80374740223699340246041830"),BigInteger.Parse("1884345278651963087653858708518360"),BigInteger.Parse("73355621393690297028946986338029560"),BigInteger.Parse("1719785575058362227821108881720941727234290"),BigInteger.Parse("66949481579385248741161156467886515267346140") };
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
public class A286036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286036Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286036.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286036Inst Instance=new A286036Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286037
{
public static readonly BigInteger[] Value={ 0L,37271025L,4917515625L,BigInteger.Parse("32996505944592590400"),BigInteger.Parse("4353432777721630310400"),BigInteger.Parse("29211445283110309395256454577225"),BigInteger.Parse("3854046352373857001854365165911025"),BigInteger.Parse("25860572538708927496411840821477504196161600"),BigInteger.Parse("3411945020082158343071838489442339152945921600"),BigInteger.Parse("22894081602203374655543296113789919615194083223613314225") };
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
public class A286037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286037Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286037.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286037Inst Instance=new A286037Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286038
{
public static readonly BigInteger[] Value={ 0L,12L,396L,21672L,1918920L,250696980L,45304472052L,10816917169296L,3296928965854032L,1248938916843586140L,BigInteger.Parse("575559130836761023260"),BigInteger.Parse("317049200473798671358392"),BigInteger.Parse("205722831410326997504441496"),BigInteger.Parse("155295648728262284680608862692"),BigInteger.Parse("134934407215203512994225979686660") };
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
public class A286038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286038Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286038.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286038Inst Instance=new A286038Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286087
{
public static readonly long[] Value={ 1L,10L,10L,100L,100L,1000L,101000L,1010000L,10000L,100000L,110100000L,1101000000L,100001000000L,1000010000000L,101010000000L,1010100000000L,100000100000000L,1000001000000000L,101000101000000000L,1010001010000000000L,1100010000000000L,11000100000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286087Inst : IEnumerable<long>
{
public static readonly long[] Value=A286087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286087.Bytes);
public long this[int i]=>Value[i];

public static A286087Inst Instance=new A286087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286088
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,4L,10L,10L,16L,16L,44L,44L,66L,66L,168L,168L,260L,260L,650L,650L,1120L,1120L,2704L,2704L,4200L,4200L,10372L,10372L,18010L,18010L,43392L,43392L,67152L,67152L,174312L,174312L,270148L,270148L,664490L,664490L,1137926L,1137926L,2801314L,2801314L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286088Inst : IEnumerable<long>
{
public static readonly long[] Value=A286088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286088.Bytes);
public long this[int i]=>Value[i];

public static A286088Inst Instance=new A286088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286089
{
public static readonly long[] Value={ 1L,2L,2L,4L,4L,8L,40L,80L,16L,32L,416L,832L,2112L,4224L,2688L,5376L,16640L,33280L,166400L,332800L,50176L,100352L,305152L,610304L,2887680L,5775360L,17342464L,34684928L,189546496L,379092992L,13271040L,26542080L,348192768L,696385536L,3098148864L,6196297728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286089Inst : IEnumerable<long>
{
public static readonly long[] Value=A286089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286089.Bytes);
public long this[int i]=>Value[i];

public static A286089Inst Instance=new A286089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286090
{
public static readonly long[] Value={ 3L,7L,3L,8L,2L,2L,15L,3L,3L,3L,15L,2L,2L,2L,2L,21L,6L,1L,1L,4L,2L,19L,3L,2L,3L,2L,3L,1L,27L,8L,2L,1L,1L,2L,5L,2L,29L,7L,2L,2L,2L,2L,2L,3L,2L,31L,7L,4L,2L,0L,0L,2L,4L,3L,1L,32L,9L,3L,3L,2L,4L,2L,3L,3L,4L,1L,41L,9L,3L,3L,0L,0L,0L,0L,3L,3L,4L,2L,39L,11L,6L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286090Inst : IEnumerable<long>
{
public static readonly long[] Value=A286090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286090.Bytes);
public long this[int i]=>Value[i];

public static A286090Inst Instance=new A286090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286091
{
public static readonly long[] Value={ 1L,1L,2L,5L,11L,4L,3L,18L,26L,35L,48L,15L,76L,64L,97L,135L,29L,6L,175L,98L,212L,240L,260L,73L,22L,316L,41L,232L,7L,165L,424L,472L,399L,519L,214L,353L,606L,27L,660L,100L,787L,845L,924L,963L,376L,156L,1095L,766L,356L,621L,1206L,32L,501L,1292L,1409L,1169L,1464L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286091Inst : IEnumerable<long>
{
public static readonly long[] Value=A286091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286091.Bytes);
public long this[int i]=>Value[i];

public static A286091Inst Instance=new A286091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286092
{
public static readonly long[] Value={ 2L,3L,8L,10L,13L,19L,20L,26L,37L,39L,232L,308L,381L,382L,706L,872L,1707L,1929L,2195L,9211L,15567L,58306L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286092Inst : IEnumerable<long>
{
public static readonly long[] Value=A286092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286092.Bytes);
public long this[int i]=>Value[i];

public static A286092Inst Instance=new A286092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286093
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,1L,1L,3L,4L,1L,1L,2L,2L,4L,4L,1L,5L,2L,1L,1L,2L,3L,1L,1L,3L,5L,1L,1L,5L,6L,1L,1L,2L,2L,3L,1L,1L,3L,4L,1L,1L,2L,2L,4L,4L,1L,6L,2L,1L,1L,2L,7L,1L,1L,3L,2L,1L,1L,2L,4L,1L,1L,3L,2L,5L,1L,1L,2L,2L,3L,1L,1L,3L,6L,8L,1L,1L,2L,2L,3L,1L,1L,3L,4L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286093Inst : IEnumerable<long>
{
public static readonly long[] Value=A286093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286093.Bytes);
public long this[int i]=>Value[i];

public static A286093Inst Instance=new A286093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286094
{
public static readonly long[] Value={ 1L,12L,22L,24L,28L,30L,40L,44L,50L,62L,63L,68L,74L,77L,85L,94L,99L,110L,117L,118L,120L,122L,129L,134L,143L,145L,154L,162L,164L,165L,172L,175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286094Inst : IEnumerable<long>
{
public static readonly long[] Value=A286094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286094.Bytes);
public long this[int i]=>Value[i];

public static A286094Inst Instance=new A286094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286095
{
public static readonly long[] Value={ 49L,81L,121L,169L,361L,529L,625L,841L,961L,1024L,1369L,1849L,2209L,2809L,3721L,4489L,5329L,6241L,6889L,9409L,10609L,11449L,11881L,12769L,14641L,16129L,18769L,19321L,22201L,22801L,24649L,26569L,32041L,32761L,36481L,37249L,38809L,39601L,44521L,49729L,51529L,52441L,54289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286095Inst : IEnumerable<long>
{
public static readonly long[] Value=A286095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286095.Bytes);
public long this[int i]=>Value[i];

public static A286095Inst Instance=new A286095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286096
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,0L,3L,0L,1L,3L,0L,4L,0L,1L,0L,10L,0L,5L,0L,1L,10L,0L,15L,0L,6L,0L,1L,0L,35L,0L,21L,0L,7L,0L,1L,35L,0L,56L,0L,28L,0L,8L,0L,1L,0L,126L,0L,84L,0L,36L,0L,9L,0L,1L,126L,0L,210L,0L,120L,0L,45L,0L,10L,0L,1L,0L,462L,0L,330L,0L,165L,0L,55L,0L,11L,0L,1L,462L,0L,792L,0L,495L,0L,220L,0L,66L,0L,12L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286096Inst : IEnumerable<long>
{
public static readonly long[] Value=A286096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286096.Bytes);
public long this[int i]=>Value[i];

public static A286096Inst Instance=new A286096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286097
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,6L,10L,13L,20L,26L,37L,48L,68L,86L,119L,152L,204L,258L,342L,428L,560L,698L,897L,1114L,1421L,1748L,2210L,2712L,3390L,4140L,5140L,6240L,7702L,9314L,11402L,13741L,16742L,20071L,24333L,29087L,35056L,41770L,50137L,59503L,71148L,84195L,100213L,118275L,140307L,165041L,195139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286097Inst : IEnumerable<long>
{
public static readonly long[] Value=A286097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286097.Bytes);
public long this[int i]=>Value[i];

public static A286097Inst Instance=new A286097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286098
{
public static readonly long[] Value={ 0L,1L,1L,3L,4L,3L,6L,6L,6L,6L,10L,11L,12L,11L,10L,15L,15L,17L,17L,15L,15L,21L,22L,21L,24L,21L,22L,21L,28L,28L,28L,28L,28L,28L,28L,28L,36L,37L,38L,37L,40L,37L,38L,37L,36L,45L,45L,47L,47L,49L,49L,47L,47L,45L,45L,55L,56L,55L,58L,59L,60L,59L,58L,55L,56L,55L,66L,66L,66L,66L,70L,70L,70L,70L,66L,66L,66L,66L,78L,79L,80L,79L,78L,83L,84L,83L,78L,79L,80L,79L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286098Inst : IEnumerable<long>
{
public static readonly long[] Value=A286098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286098.Bytes);
public long this[int i]=>Value[i];

public static A286098Inst Instance=new A286098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286099
{
public static readonly long[] Value={ 0L,2L,2L,5L,4L,5L,9L,9L,9L,9L,14L,13L,12L,13L,14L,20L,20L,18L,18L,20L,20L,27L,26L,27L,24L,27L,26L,27L,35L,35L,35L,35L,35L,35L,35L,35L,44L,43L,42L,43L,40L,43L,42L,43L,44L,54L,54L,52L,52L,50L,50L,52L,52L,54L,54L,65L,64L,65L,62L,61L,60L,61L,62L,65L,64L,65L,77L,77L,77L,77L,73L,73L,73L,73L,77L,77L,77L,77L,90L,89L,88L,89L,90L,85L,84L,85L,90L,89L,88L,89L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286099Inst : IEnumerable<long>
{
public static readonly long[] Value=A286099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286099.Bytes);
public long this[int i]=>Value[i];

public static A286099Inst Instance=new A286099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286100
{
public static readonly long[] Value={ 1L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,3L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,4L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,5L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,6L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,7L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,8L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286100Inst : IEnumerable<long>
{
public static readonly long[] Value=A286100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286100.Bytes);
public long this[int i]=>Value[i];

public static A286100Inst Instance=new A286100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286101
{
public static readonly long[] Value={ 1L,2L,2L,4L,5L,4L,7L,16L,16L,7L,11L,12L,13L,12L,11L,16L,46L,67L,67L,46L,16L,22L,23L,106L,25L,106L,23L,22L,29L,92L,31L,191L,191L,31L,92L,29L,37L,38L,211L,80L,41L,80L,211L,38L,37L,46L,154L,277L,379L,436L,436L,379L,277L,154L,46L,56L,57L,58L,59L,596L,61L,596L,59L,58L,57L,56L,67L,232L,436L,631L,781L,862L,862L,781L,631L,436L,232L,67L,79L,80L,529L,212L,991L,302L,85L,302L,991L,212L,529L,80L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286101Inst : IEnumerable<long>
{
public static readonly long[] Value=A286101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286101.Bytes);
public long this[int i]=>Value[i];

public static A286101Inst Instance=new A286101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286102
{
public static readonly long[] Value={ 1L,3L,3L,6L,5L,6L,10L,21L,21L,10L,15L,14L,13L,14L,15L,21L,55L,78L,78L,55L,21L,28L,27L,120L,25L,120L,27L,28L,36L,105L,34L,210L,210L,34L,105L,36L,45L,44L,231L,90L,41L,90L,231L,44L,45L,55L,171L,300L,406L,465L,465L,406L,300L,171L,55L,66L,65L,64L,63L,630L,61L,630L,63L,64L,65L,66L,78L,253L,465L,666L,820L,903L,903L,820L,666L,465L,253L,78L,91L,90L,561L,230L,1035L,324L,85L,324L,1035L,230L,561L,90L,91L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286102Inst : IEnumerable<long>
{
public static readonly long[] Value=A286102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286102.Bytes);
public long this[int i]=>Value[i];

public static A286102Inst Instance=new A286102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286199
{
public static readonly long[] Value={ 1L,1L,0L,3L,16L,7L,0L,15L,448L,31L,1024L,63L,768L,127L,24576L,4351L,68608L,511L,32768L,17407L,12288L,2047L,393216L,69631L,49152L,6299647L,1572864L,278527L,50528256L,8421375L,6291456L,403767295L,67895296L,33685503L,3246391296L,541327359L,271581184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286199Inst : IEnumerable<long>
{
public static readonly long[] Value=A286199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286199.Bytes);
public long this[int i]=>Value[i];

public static A286199Inst Instance=new A286199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286200
{
public static readonly BigInteger[] Value={ 1L,10L,11L,1100L,11L,111100L,1111L,11110110L,1001L,1111110110L,11L,111111110100L,11111L,11111111110000L,11101100L,1111111101110111L,11111100L,111111111100001011L,1100L,11111111111111100011UL,110111110L,BigInteger.Parse("1111111111111010101011"),110111010L };
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
public class A286200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286200Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286200.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286200Inst Instance=new A286200Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286201
{
public static readonly ulong[] Value={ 1L,1L,110L,11L,11000L,1111L,1111000L,1101111L,100100000L,110111111L,11000000000L,1011111111L,1111100000000L,1111111111L,1101110000000L,1110111011111111L,111111000000000L,110100001111111111L,11000000000000000L,11000111111111111111UL,11111011000000000000UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286201Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A286201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286201.Bytes);
public ulong this[int i]=>Value[i];

public static A286201Inst Instance=new A286201Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286202
{
public static readonly long[] Value={ 1L,2L,3L,12L,3L,60L,15L,246L,9L,1014L,3L,4084L,31L,16368L,236L,65399L,252L,261899L,12L,1048547L,446L,4193963L,442L,16776767L,434L,67108589L,1014L,268435381L,698L,1073740669L,65520L,4294934312L,37559L,17179833308L,4075L,68719440450L,107471L,274877869242L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286202Inst : IEnumerable<long>
{
public static readonly long[] Value=A286202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286202.Bytes);
public long this[int i]=>Value[i];

public static A286202Inst Instance=new A286202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286203
{
public static readonly long[] Value={ 1L,1L,6L,3L,24L,15L,120L,111L,288L,447L,1536L,767L,7936L,1023L,7040L,61183L,32256L,214015L,98304L,819199L,1028096L,3497983L,3063808L,16547839L,10158080L,48103423L,58589184L,182452223L,195559424L,800587775L,134184960L,352255999L,7961968640L,4013686783L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286203Inst : IEnumerable<long>
{
public static readonly long[] Value=A286203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286203.Bytes);
public long this[int i]=>Value[i];

public static A286203Inst Instance=new A286203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286204
{
public static readonly BigInteger[] Value={ 1L,11L,11L,1111L,11L,111111L,1111L,11111111L,1111L,1111111111L,1111L,111111111111L,1111L,11111111111111L,11001111L,1111111111111111L,11111111L,111111111111111111L,11111111L,11111111111111111111UL,11111111L,BigInteger.Parse("1111111111111111111111"),11110111L };
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
public class A286204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286204Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286204.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286204Inst Instance=new A286204Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286205
{
public static readonly ulong[] Value={ 1L,11L,110L,1111L,11000L,111111L,1111000L,11111111L,111100000L,1111111111L,11110000000L,111111111111L,1111000000000L,11111111111111L,111100110000000L,1111111111111111L,11111111000000000L,111111111111111111L,1111111100000000000L,11111111111111111111UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286205Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A286205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286205.Bytes);
public ulong this[int i]=>Value[i];

public static A286205Inst Instance=new A286205Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286206
{
public static readonly long[] Value={ 1L,3L,3L,15L,3L,63L,15L,255L,15L,1023L,15L,4095L,15L,16383L,207L,65535L,255L,262143L,255L,1048575L,255L,4194303L,247L,16777215L,255L,67108863L,255L,268435455L,255L,1073741823L,50175L,4294967295L,58367L,17179869183L,62463L,68719476735L,63431L,274877906943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286206Inst : IEnumerable<long>
{
public static readonly long[] Value=A286206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286206.Bytes);
public long this[int i]=>Value[i];

public static A286206Inst Instance=new A286206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286207
{
public static readonly long[] Value={ 1L,3L,6L,15L,24L,63L,120L,255L,480L,1023L,1920L,4095L,7680L,16383L,31104L,65535L,130560L,262143L,522240L,1048575L,2088960L,4194303L,7831552L,16777215L,33423360L,67108863L,133693440L,268435455L,534773760L,1073741823L,2145484800L,4294967295L,8582463488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286207Inst : IEnumerable<long>
{
public static readonly long[] Value=A286207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286207.Bytes);
public long this[int i]=>Value[i];

public static A286207Inst Instance=new A286207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286208
{
public static readonly BigInteger[] Value={ 7853L,594278556271609021L,BigInteger.Parse("4259842839142238791410741595983041626644087509") };
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
public class A286208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286208Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286208.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286208Inst Instance=new A286208Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286209
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,3L,10L,24L,60L,134L,304L,656L,1420L,2996L,6312L,13112L,27167L,55825L,114412L,233282L,474563L,962159L,1947098L,3931288L,7925708L,15952866L,32072580L,64404708L,129213082L,259009006L,518818124L,1038549912L,2077775396L,4154785904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286209Inst : IEnumerable<long>
{
public static readonly long[] Value=A286209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286209.Bytes);
public long this[int i]=>Value[i];

public static A286209Inst Instance=new A286209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286210
{
public static readonly long[] Value={ 0L,4L,17L,62L,238L,912L,3468L,13224L,50655L,194672L,750165L,2897898L,11219322L,43520672L,169113746L,658172740L,2565143148L,10010037116L,39107620002L,152948221004L,598750691827L,2346021879720L,9199672561659L,36102743330922L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286210Inst : IEnumerable<long>
{
public static readonly long[] Value=A286210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286210.Bytes);
public long this[int i]=>Value[i];

public static A286210Inst Instance=new A286210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286211
{
public static readonly long[] Value={ 0L,17L,52L,684L,2128L,34896L,123541L,1891998L,7565509L,106100847L,470286934L,6070072444L,29342743563L,352400491431L,1833102380708L,20699165970978L,114576111229319L,1227555854005393L,7163217232141967L,73387852919316000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286211Inst : IEnumerable<long>
{
public static readonly long[] Value=A286211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286211.Bytes);
public long this[int i]=>Value[i];

public static A286211Inst Instance=new A286211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286212
{
public static readonly BigInteger[] Value={ 0L,62L,684L,10056L,141018L,2053994L,30004158L,443275636L,6591532114L,98620717026L,1483077002788L,22402256622648L,339716751362128L,5169528508115318L,78910865975553660L,1207934007828690708L,BigInteger.Parse("18537787151292561428") };
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
public class A286212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286212Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286212.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286212Inst Instance=new A286212Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286213
{
public static readonly BigInteger[] Value={ 0L,238L,2128L,141018L,1656022L,113258929L,1569283128L,97311031516L,1540259241508L,86480812173044L,1526208889551285L,78586854206474282L,1517934653629840928L,BigInteger.Parse("72607979076706778162"),BigInteger.Parse("1512452308916246272882") };
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
public class A286213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286213Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286213.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286213Inst Instance=new A286213Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286214
{
public static readonly BigInteger[] Value={ 1L,912L,34896L,2053994L,113258929L,6553131164L,380797680269L,22418184755710L,1330080388106827L,79466576915681740L,4775393278095153395L,BigInteger.Parse("288397740505442452180"),BigInteger.Parse("17492553727454266741242"),BigInteger.Parse("1065040889415828916901252") };
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
public class A286214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286214Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286214.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286214Inst Instance=new A286214Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286279
{
public static readonly long[] Value={ 11L,25L,28L,31L,33L,35L,33L,75L,73L,47L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286279Inst : IEnumerable<long>
{
public static readonly long[] Value=A286279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286279.Bytes);
public long this[int i]=>Value[i];

public static A286279Inst Instance=new A286279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286280
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,2L,5L,4L,8L,2L,11L,4L,8L,10L,15L,4L,14L,3L,22L,13L,8L,2L,34L,11L,13L,20L,26L,4L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286280Inst : IEnumerable<long>
{
public static readonly long[] Value=A286280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286280.Bytes);
public long this[int i]=>Value[i];

public static A286280Inst Instance=new A286280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286281
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,3L,4L,3L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,3L,4L,3L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,3L,4L,3L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,3L,4L,5L,4L,3L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286281Inst : IEnumerable<long>
{
public static readonly long[] Value=A286281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286281.Bytes);
public long this[int i]=>Value[i];

public static A286281Inst Instance=new A286281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286282
{
public static readonly BigInteger[] Value={ 1L,2L,5L,18L,79L,408L,2469L,17314L,138555L,1247052L,12470593L,137176614L,1646119479L,21399553360L,299593747197L,4493906208138L,71902499330419L,1222342488617364L,22002164795112825L,418041131107143982L,8360822622142879983L,BigInteger.Parse("175577275065000480024"),BigInteger.Parse("3862700051430010560949") };
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
public class A286282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286282Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286282.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286282Inst Instance=new A286282Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286283
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,3L,5L,7L,9L,11L,14L,17L,21L,24L,28L,32L,37L,42L,47L,52L,58L,64L,70L,77L,84L,91L,98L,106L,114L,122L,131L,140L,149L,158L,168L,178L,189L,199L,210L,221L,233L,245L,257L,269L,282L,295L,308L,322L,336L,350L,364L,379L,394L,409L,425L,441L,457L,473L,490L,507L,525L,542L,560L,578L,597L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286283Inst : IEnumerable<long>
{
public static readonly long[] Value=A286283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286283.Bytes);
public long this[int i]=>Value[i];

public static A286283Inst Instance=new A286283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286284
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,20L,82L,565L,5688L,102039L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286284Inst : IEnumerable<long>
{
public static readonly long[] Value=A286284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286284.Bytes);
public long this[int i]=>Value[i];

public static A286284Inst Instance=new A286284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286285
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,20L,82L,565L,5688L,102039L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286285Inst : IEnumerable<long>
{
public static readonly long[] Value=A286285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286285.Bytes);
public long this[int i]=>Value[i];

public static A286285Inst Instance=new A286285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286286
{
public static readonly BigInteger[] Value={ 0L,1L,4L,21L,148L,1333L,14664L,190633L,2859496L,48611433L,923617228L,19395961789L,446107121148L,11152678028701L,301122306774928L,8732546896472913L,270708953790660304L,8933395475091790033L,BigInteger.Parse("312668841628212651156"),BigInteger.Parse("11568747140243868092773") };
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
public class A286286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286286Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286286.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286286Inst Instance=new A286286Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286287
{
public static readonly long[] Value={ 106L,11L,13L,7L,512L,1L,1941L,141L,6847L,211L,195031L,82321L,808083L,534077L,3355906L,526093L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286287Inst : IEnumerable<long>
{
public static readonly long[] Value=A286287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286287.Bytes);
public long this[int i]=>Value[i];

public static A286287Inst Instance=new A286287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286288
{
public static readonly long[] Value={ 46L,5L,43L,1L,2021L,121L,25202L,2521L,162121L,460801L,27268546L,23553169L,244068841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286288Inst : IEnumerable<long>
{
public static readonly long[] Value=A286288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286288.Bytes);
public long this[int i]=>Value[i];

public static A286288Inst Instance=new A286288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286289
{
public static readonly long[] Value={ 314L,6L,315L,14L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286289Inst : IEnumerable<long>
{
public static readonly long[] Value=A286289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286289.Bytes);
public long this[int i]=>Value[i];

public static A286289Inst Instance=new A286289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286290
{
public static readonly long[] Value={ 1L,6L,12L,20L,35L,56L,72L,90L,110L,143L,182L,210L,240L,272L,306L,342L,399L,462L,506L,552L,600L,650L,702L,756L,812L,870L,930L,992L,1056L,1122L,1224L,1332L,1406L,1482L,1560L,1640L,1722L,1806L,1892L,1980L,2070L,2162L,2256L,2352L,2450L,2550L,2652L,2756L,2862L,2970L,3135L,3306L,3422L,3540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286290Inst : IEnumerable<long>
{
public static readonly long[] Value=A286290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286290.Bytes);
public long this[int i]=>Value[i];

public static A286290Inst Instance=new A286290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286291
{
public static readonly long[] Value={ 2L,3L,4L,5L,7L,8L,9L,10L,11L,13L,14L,15L,16L,17L,18L,19L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,73L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L,84L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286291Inst : IEnumerable<long>
{
public static readonly long[] Value=A286291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286291.Bytes);
public long this[int i]=>Value[i];

public static A286291Inst Instance=new A286291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286292
{
public static readonly long[] Value={ 3L,4L,6L,13L,19L,14L,16L,18L,31L,37L,26L,28L,30L,32L,34L,55L,61L,42L,44L,46L,48L,50L,52L,54L,56L,58L,60L,62L,64L,100L,106L,72L,74L,76L,78L,80L,82L,84L,86L,88L,90L,92L,94L,96L,98L,100L,102L,104L,106L,163L,169L,114L,116L,118L,120L,122L,124L,126L,128L,130L,132L,134L,136L,138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286292Inst : IEnumerable<long>
{
public static readonly long[] Value=A286292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286292.Bytes);
public long this[int i]=>Value[i];

public static A286292Inst Instance=new A286292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286293
{
public static readonly long[] Value={ 1L,2L,4L,11L,17L,12L,14L,16L,29L,35L,24L,26L,28L,30L,32L,53L,59L,40L,42L,44L,46L,48L,50L,52L,54L,56L,58L,60L,62L,98L,104L,70L,72L,74L,76L,78L,80L,82L,84L,86L,88L,90L,92L,94L,96L,98L,100L,102L,104L,161L,167L,112L,114L,116L,118L,120L,122L,124L,126L,128L,130L,132L,134L,136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286293Inst : IEnumerable<long>
{
public static readonly long[] Value=A286293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286293.Bytes);
public long this[int i]=>Value[i];

public static A286293Inst Instance=new A286293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286294
{
public static readonly long[] Value={ 0L,1L,3L,2L,5L,4L,6L,8L,7L,11L,9L,10L,12L,13L,15L,14L,16L,18L,17L,19L,20L,22L,21L,23L,25L,24L,27L,26L,28L,29L,31L,30L,32L,33L,35L,34L,36L,38L,37L,40L,39L,41L,44L,42L,43L,45L,46L,47L,49L,48L,50L,51L,53L,52L,54L,55L,57L,56L,58L,60L,59L,62L,61L,64L,65L,63L,66L,68L,67L,70L,71L,69L,72L,73L,75L,74L,76L,77L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286294Inst : IEnumerable<long>
{
public static readonly long[] Value=A286294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286294.Bytes);
public long this[int i]=>Value[i];

public static A286294Inst Instance=new A286294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286375
{
public static readonly long[] Value={ 1L,2L,2L,36L,2L,96L,36L,840L,2L,1260L,96L,1260L,36L,2310L,840L,5040L,2L,1260L,1260L,69300L,96L,4620L,1260L,4320L,36L,1680L,2310L,12600L,840L,36960L,5040L,30240L,2L,1260L,1260L,831600L,1260L,415800L,69300L,2646000L,96L,27720L,4620L,900900L,1260L,221760L,4320L,277200L,36L,83160L,1680L,13860L,2310L,180180L,12600L,166320L,840L,15315300L,36960L,13860L,5040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286375Inst : IEnumerable<long>
{
public static readonly long[] Value=A286375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286375.Bytes);
public long this[int i]=>Value[i];

public static A286375Inst Instance=new A286375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286376
{
public static readonly long[] Value={ 2L,2L,6L,2L,24L,6L,12L,2L,60L,24L,180L,6L,120L,12L,24L,2L,60L,60L,420L,24L,180L,180L,60L,6L,192L,120L,384L,12L,240L,24L,48L,2L,60L,60L,420L,60L,720L,420L,360L,24L,420L,180L,1260L,180L,4620L,60L,420L,6L,720L,192L,5040L,120L,5040L,384L,1680L,12L,1440L,240L,4320L,24L,480L,48L,96L,2L,60L,60L,420L,60L,2520L,420L,1260L,60L,420L,720L,1260L,420L,1260L,360L,180L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286376Inst : IEnumerable<long>
{
public static readonly long[] Value=A286376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286376.Bytes);
public long this[int i]=>Value[i];

public static A286376Inst Instance=new A286376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286377
{
public static readonly BigInteger[] Value={ 1L,2L,2L,60L,2L,2520L,60L,138600L,2L,87318000L,2520L,189189000L,60L,792148896000000L,138600L,70756686000L,2L,2288271225240000L,87318000L,BigInteger.Parse("944154902157667200000000"),2520L,BigInteger.Parse("20388496616888400000000"),189189000L,BigInteger.Parse("127170673342713000000"),60L,BigInteger.Parse("701323506627727183200000000"),792148896000000L,BigInteger.Parse("21149759041410320377056000000000000000"),138600L };
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
public class A286377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286377Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286377.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286377Inst Instance=new A286377Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286378
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,4L,3L,5L,2L,6L,4L,7L,3L,8L,5L,9L,2L,10L,6L,11L,4L,12L,7L,13L,3L,13L,8L,14L,5L,15L,9L,16L,2L,17L,10L,18L,6L,19L,11L,20L,4L,21L,12L,22L,7L,23L,13L,24L,3L,24L,13L,25L,8L,26L,14L,27L,5L,28L,15L,29L,9L,30L,16L,31L,2L,32L,17L,33L,10L,34L,18L,35L,6L,36L,19L,37L,11L,38L,20L,39L,4L,40L,21L,41L,12L,42L,22L,43L,7L,44L,23L,45L,13L,46L,24L,47L,3L,47L,24L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286378Inst : IEnumerable<long>
{
public static readonly long[] Value=A286378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286378.Bytes);
public long this[int i]=>Value[i];

public static A286378Inst Instance=new A286378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286379
{
public static readonly long[] Value={ 1L,2L,7L,5L,16L,18L,29L,14L,31L,50L,67L,42L,67L,98L,195L,44L,16L,100L,67L,115L,637L,242L,277L,117L,125L,289L,955L,224L,277L,450L,497L,152L,131L,248L,160L,271L,436L,454L,643L,320L,436L,1246L,1771L,550L,2716L,1058L,1129L,375L,160L,655L,1343L,692L,1771L,1918L,3332L,623L,880L,1355L,2557L,1020L,1129L,1922L,3507L,560L,166L,736L,67L,775L,1349L,1070L,277L,856L,436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286379Inst : IEnumerable<long>
{
public static readonly long[] Value=A286379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286379.Bytes);
public long this[int i]=>Value[i];

public static A286379Inst Instance=new A286379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286380
{
public static readonly long[] Value={ 0L,1L,2L,1L,1L,3L,5L,1L,6L,2L,4L,3L,2L,6L,5L,1L,3L,7L,6L,2L,1L,5L,4L,3L,7L,3L,41L,6L,5L,6L,39L,1L,8L,4L,3L,7L,6L,7L,11L,2L,40L,2L,9L,5L,4L,5L,38L,3L,7L,8L,7L,3L,2L,42L,41L,6L,10L,6L,10L,6L,5L,40L,39L,1L,8L,9L,8L,4L,3L,4L,37L,7L,42L,7L,3L,7L,6L,12L,11L,2L,6L,41L,40L,2L,1L,10L,9L,5L,9L,5L,33L,5L,4L,39L,38L,3L,43L,8L,7L,8L,7L,8L,31L,3L,12L,3L,36L,42L,41L,42L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286380Inst : IEnumerable<long>
{
public static readonly long[] Value=A286380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286380.Bytes);
public long this[int i]=>Value[i];

public static A286380Inst Instance=new A286380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286381
{
public static readonly long[] Value={ 2L,5L,16L,12L,67L,9L,16L,23L,436L,80L,1771L,18L,67L,80L,1771L,668L,16111L,48L,277L,302L,7141L,2630L,64621L,14L,16L,23L,436L,80L,1771L,31L,436L,467L,21946L,1832L,87991L,94L,1771L,1832L,87991L,16292L,793171L,328L,7141L,7262L,352381L,64982L,3173941L,25L,67L,80L,1771L,668L,16111L,94L,1771L,1832L,87991L,16292L,793171L,706L,16111L,16292L,793171L,405452L,19841851L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286381Inst : IEnumerable<long>
{
public static readonly long[] Value=A286381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286381.Bytes);
public long this[int i]=>Value[i];

public static A286381Inst Instance=new A286381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286382
{
public static readonly long[] Value={ 2L,5L,16L,12L,67L,9L,16L,23L,436L,80L,1771L,18L,67L,80L,1771L,668L,16111L,48L,277L,302L,7141L,2630L,64621L,156L,1129L,1178L,28681L,10442L,258841L,14L,16L,23L,436L,80L,1771L,31L,436L,467L,21946L,1832L,87991L,94L,1771L,1832L,87991L,16292L,793171L,328L,7141L,7262L,352381L,64982L,3173941L,1228L,28681L,28922L,1410361L,259562L,12698281L,25L,67L,80L,1771L,668L,16111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286382Inst : IEnumerable<long>
{
public static readonly long[] Value=A286382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286382.Bytes);
public long this[int i]=>Value[i];

public static A286382Inst Instance=new A286382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286383
{
public static readonly long[] Value={ 1L,2L,2L,6L,2L,4L,4L,12L,2L,8L,6L,12L,2L,6L,8L,24L,2L,12L,6L,24L,2L,6L,12L,36L,4L,6L,6L,30L,2L,16L,16L,48L,6L,32L,6L,60L,2L,6L,12L,72L,2L,12L,6L,30L,2L,12L,24L,72L,2L,6L,12L,30L,2L,24L,12L,60L,2L,12L,6L,48L,6L,6L,32L,96L,2L,12L,30L,96L,2L,30L,12L,180L,2L,6L,6L,30L,8L,24L,24L,216L,6L,6L,6L,60L,6L,12L,12L,60L,2L,48L,6L,60L,2L,6L,48L,144L,4L,30L,6L,30L,2L,64L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286383Inst : IEnumerable<long>
{
public static readonly long[] Value=A286383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286383.Bytes);
public long this[int i]=>Value[i];

public static A286383Inst Instance=new A286383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286384
{
public static readonly long[] Value={ 1L,2L,2L,2L,6L,4L,4L,8L,6L,12L,2L,8L,6L,2L,12L,2L,24L,12L,6L,24L,2L,12L,6L,16L,16L,2L,30L,6L,6L,36L,4L,12L,6L,72L,2L,24L,12L,2L,30L,48L,6L,32L,6L,2L,60L,12L,6L,32L,6L,6L,48L,12L,6L,60L,2L,2L,30L,12L,24L,72L,2L,6L,12L,6L,60L,12L,12L,216L,6L,6L,6L,48L,6L,2L,60L,48L,6L,60L,2L,96L,2L,12L,30L,2L,96L,12L,30L,6L,6L,180L,2L,24L,24L,8L,30L,64L,36L,2L,30L,6L,30L,144L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286384Inst : IEnumerable<long>
{
public static readonly long[] Value=A286384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286384.Bytes);
public long this[int i]=>Value[i];

public static A286384Inst Instance=new A286384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286385
{
public static readonly long[] Value={ 0L,0L,1L,2L,1L,3L,3L,12L,12L,3L,1L,17L,3L,9L,11L,50L,1L,36L,3L,21L,23L,3L,5L,75L,18L,9L,85L,43L,1L,33L,5L,180L,17L,3L,29L,134L,3L,9L,29L,99L,1L,69L,3L,33L,97L,15L,5L,281L,64L,54L,23L,55L,5L,255L,19L,177L,35L,3L,1L,147L,5L,15L,171L,602L,35L,51L,3L,45L,49L,87L,1L,480L,5L,9L,121L,67L,47L,87L,3L,381L,504L,3L,5L,271L,25L,9L,35L,171L,7L,291L,75L,93L,57L,15L,41L,963L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286385Inst : IEnumerable<long>
{
public static readonly long[] Value=A286385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286385.Bytes);
public long this[int i]=>Value[i];

public static A286385Inst Instance=new A286385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286386
{
public static readonly long[] Value={ 3L,12L,14L,21L,10L,28L,14L,36L,31L,44L,14L,52L,10L,60L,46L,69L,10L,76L,14L,84L,62L,92L,14L,100L,43L,108L,78L,116L,10L,124L,14L,132L,94L,140L,58L,149L,10L,156L,110L,164L,10L,172L,14L,180L,126L,188L,14L,196L,63L,204L,142L,212L,10L,220L,90L,228L,158L,236L,14L,244L,10L,252L,174L,261L,106L,268L,14L,276L,190L,284L,14L,292L,10L,300L,206L,308L,94L,316L,14L,324L,223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286386Inst : IEnumerable<long>
{
public static readonly long[] Value=A286386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286386.Bytes);
public long this[int i]=>Value[i];

public static A286386Inst Instance=new A286386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286387
{
public static readonly long[] Value={ 0L,1L,1L,4L,1L,7L,4L,9L,1L,14L,7L,13L,4L,29L,9L,16L,1L,23L,14L,43L,7L,36L,13L,29L,4L,43L,29L,64L,9L,67L,16L,25L,1L,34L,23L,89L,14L,115L,43L,46L,7L,85L,36L,79L,13L,46L,29L,79L,4L,97L,43L,142L,29L,89L,64L,91L,9L,136L,67L,157L,16L,121L,25L,36L,1L,47L,34L,151L,23L,236L,89L,157L,14L,211L,115L,104L,43L,225L,46L,109L,7L,162L,85L,235L,36L,139L,79L,174L,13L,101L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286387Inst : IEnumerable<long>
{
public static readonly long[] Value=A286387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286387.Bytes);
public long this[int i]=>Value[i];

public static A286387Inst Instance=new A286387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286388
{
public static readonly long[] Value={ 0L,1L,4L,3L,2L,6L,7L,10L,9L,15L,4L,21L,2L,28L,41L,36L,2L,45L,4L,55L,35L,66L,7L,78L,20L,91L,64L,105L,2L,120L,16L,136L,77L,153L,43L,171L,2L,190L,133L,210L,2L,231L,4L,253L,135L,276L,11L,300L,35L,325L,188L,351L,2L,378L,102L,406L,209L,435L,4L,465L,2L,496L,372L,528L,104L,561L,4L,595L,299L,630L,7L,666L,2L,703L,376L,741L,77L,780L,11L,820L,405L,861L,4L,903L,170L,946L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286388Inst : IEnumerable<long>
{
public static readonly long[] Value=A286388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286388.Bytes);
public long this[int i]=>Value[i];

public static A286388Inst Instance=new A286388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286389
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,4L,4L,5L,6L,7L,8L,8L,9L,10L,10L,11L,12L,13L,14L,14L,15L,16L,16L,17L,18L,18L,19L,20L,20L,21L,22L,23L,24L,24L,25L,26L,26L,27L,28L,29L,30L,30L,31L,32L,32L,33L,34L,34L,35L,36L,36L,37L,38L,39L,40L,40L,41L,42L,42L,43L,44L,45L,46L,46L,47L,48L,48L,49L,50L,51L,52L,52L,53L,54L,54L,55L,56L,57L,58L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286389Inst : IEnumerable<long>
{
public static readonly long[] Value=A286389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286389.Bytes);
public long this[int i]=>Value[i];

public static A286389Inst Instance=new A286389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286390
{
public static readonly long[] Value={ 0L,2L,-1L,3L,-5L,7L,-12L,20L,-31L,51L,-83L,133L,-216L,350L,-565L,915L,-1481L,2395L,-3876L,6272L,-10147L,16419L,-26567L,42985L,-69552L,112538L,-182089L,294627L,-476717L,771343L,-1248060L,2019404L,-3267463L,5286867L,-8554331L,13841197L,-22395528L,36236726L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286390Inst : IEnumerable<long>
{
public static readonly long[] Value=A286390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286390.Bytes);
public long this[int i]=>Value[i];

public static A286390Inst Instance=new A286390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286471
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,2L,0L,1L,1L,3L,0L,1L,0L,4L,2L,1L,0L,2L,0L,1L,3L,5L,0L,1L,1L,6L,1L,1L,0L,2L,0L,1L,4L,7L,2L,1L,0L,8L,5L,1L,0L,2L,0L,1L,1L,9L,0L,1L,1L,3L,6L,1L,0L,2L,3L,1L,7L,10L,0L,1L,0L,11L,1L,1L,4L,2L,0L,1L,8L,3L,0L,1L,0L,12L,2L,1L,2L,2L,0L,1L,1L,13L,0L,1L,5L,14L,9L,1L,0L,2L,3L,1L,10L,15L,6L,1L,0L,4L,1L,1L,0L,2L,0L,1L,2L,16L,0L,1L,0L,3L,11L,1L,0L,2L,7L,1L,1L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286471Inst : IEnumerable<long>
{
public static readonly long[] Value=A286471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286471.Bytes);
public long this[int i]=>Value[i];

public static A286471Inst Instance=new A286471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286472
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,6L,2L,8L,6L,11L,2L,12L,2L,15L,10L,16L,2L,18L,2L,20L,15L,23L,2L,24L,10L,27L,18L,28L,2L,30L,2L,32L,23L,35L,14L,36L,2L,39L,27L,40L,2L,42L,2L,44L,30L,47L,2L,48L,14L,51L,35L,52L,2L,54L,23L,56L,39L,59L,2L,60L,2L,63L,42L,64L,27L,66L,2L,68L,47L,71L,2L,72L,2L,75L,50L,76L,22L,78L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286472Inst : IEnumerable<long>
{
public static readonly long[] Value=A286472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286472.Bytes);
public long this[int i]=>Value[i];

public static A286472Inst Instance=new A286472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286473
{
public static readonly long[] Value={ 1L,6L,7L,10L,5L,14L,7L,18L,15L,22L,7L,26L,5L,30L,23L,34L,5L,38L,7L,42L,31L,46L,7L,50L,21L,54L,39L,58L,5L,62L,7L,66L,47L,70L,29L,74L,5L,78L,55L,82L,5L,86L,7L,90L,63L,94L,7L,98L,31L,102L,71L,106L,5L,110L,45L,114L,79L,118L,7L,122L,5L,126L,87L,130L,53L,134L,7L,138L,95L,142L,7L,146L,5L,150L,103L,154L,47L,158L,7L,162L,111L,166L,7L,170L,69L,174L,119L,178L,5L,182L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286473Inst : IEnumerable<long>
{
public static readonly long[] Value=A286473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286473.Bytes);
public long this[int i]=>Value[i];

public static A286473Inst Instance=new A286473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286474
{
public static readonly long[] Value={ 1L,6L,7L,8L,5L,14L,7L,16L,13L,22L,7L,24L,5L,30L,23L,32L,5L,38L,7L,40L,29L,46L,7L,48L,21L,54L,39L,56L,5L,62L,7L,64L,45L,70L,31L,72L,5L,78L,55L,80L,5L,86L,7L,88L,61L,94L,7L,96L,29L,102L,71L,104L,5L,110L,47L,112L,77L,118L,7L,120L,5L,126L,87L,128L,53L,134L,7L,136L,93L,142L,7L,144L,5L,150L,103L,152L,45L,158L,7L,160L,109L,166L,7L,168L,69L,174L,119L,176L,5L,182L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286474Inst : IEnumerable<long>
{
public static readonly long[] Value=A286474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286474.Bytes);
public long this[int i]=>Value[i];

public static A286474Inst Instance=new A286474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286475
{
public static readonly long[] Value={ 1L,8L,9L,14L,11L,20L,7L,26L,21L,32L,11L,38L,7L,44L,33L,50L,11L,56L,7L,62L,45L,68L,11L,74L,35L,80L,57L,86L,11L,92L,7L,98L,69L,104L,47L,110L,7L,116L,81L,122L,11L,128L,7L,134L,93L,140L,11L,146L,43L,152L,105L,158L,11L,164L,71L,170L,117L,176L,11L,182L,7L,188L,129L,194L,83L,200L,7L,206L,141L,212L,11L,218L,7L,224L,153L,230L,67L,236L,7L,242L,165L,248L,11L,254L,107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286475Inst : IEnumerable<long>
{
public static readonly long[] Value=A286475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286475.Bytes);
public long this[int i]=>Value[i];

public static A286475Inst Instance=new A286475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286476
{
public static readonly long[] Value={ 1L,8L,9L,16L,11L,18L,7L,26L,21L,34L,11L,36L,7L,44L,33L,52L,11L,54L,7L,62L,45L,70L,11L,72L,31L,80L,57L,88L,11L,90L,7L,98L,69L,106L,47L,108L,7L,116L,81L,124L,11L,126L,7L,134L,93L,142L,11L,144L,43L,152L,105L,160L,11L,162L,67L,170L,117L,178L,11L,180L,7L,188L,129L,196L,83L,198L,7L,206L,141L,214L,11L,216L,7L,224L,153L,232L,71L,234L,7L,242L,165L,250L,11L,252L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286476Inst : IEnumerable<long>
{
public static readonly long[] Value=A286476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286476.Bytes);
public long this[int i]=>Value[i];

public static A286476Inst Instance=new A286476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286477
{
public static readonly long[] Value={ 1L,2L,3L,1L,4L,1L,5L,1L,2L,1L,6L,1L,7L,1L,2L,1L,8L,1L,9L,1L,2L,1L,10L,1L,3L,1L,2L,1L,11L,1L,12L,1L,2L,1L,3L,1L,13L,1L,2L,1L,14L,1L,15L,1L,2L,1L,16L,1L,4L,1L,2L,1L,17L,1L,3L,1L,2L,1L,18L,1L,19L,1L,2L,1L,3L,1L,20L,1L,2L,1L,21L,1L,22L,1L,2L,1L,4L,1L,23L,1L,2L,1L,24L,1L,3L,1L,2L,1L,25L,1L,4L,1L,2L,1L,3L,1L,26L,1L,2L,1L,27L,1L,28L,1L,2L,1L,29L,1L,30L,1L,2L,1L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286477Inst : IEnumerable<long>
{
public static readonly long[] Value=A286477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286477.Bytes);
public long this[int i]=>Value[i];

public static A286477Inst Instance=new A286477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286478
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,3L,3L,4L,2L,3L,1L,5L,4L,5L,2L,3L,1L,6L,4L,5L,2L,3L,1L,4L,6L,7L,7L,8L,6L,8L,9L,10L,7L,8L,4L,11L,9L,10L,5L,6L,2L,11L,7L,8L,3L,4L,1L,9L,12L,13L,12L,13L,9L,14L,14L,15L,10L,11L,5L,16L,12L,13L,6L,7L,2L,14L,8L,9L,3L,4L,1L,15L,17L,18L,15L,16L,10L,19L,17L,18L,11L,12L,5L,19L,13L,14L,6L,7L,2L,15L,8L,9L,3L,4L,1L,20L,20L,21L,16L,17L,10L,22L,18L,19L,11L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286478Inst : IEnumerable<long>
{
public static readonly long[] Value=A286478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286478.Bytes);
public long this[int i]=>Value[i];

public static A286478Inst Instance=new A286478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286479
{
public static readonly long[] Value={ 2L,4L,2L,2L,2L,6L,4L,12L,12L,6L,2L,12L,6L,12L,2L,6L,2L,24L,6L,6L,4L,6L,4L,32L,12L,30L,2L,6L,2L,6L,6L,6L,2L,6L,6L,12L,6L,30L,2L,48L,2L,12L,12L,12L,6L,12L,4L,6L,12L,24L,6L,6L,6L,6L,2L,64L,2L,6L,2L,72L,12L,30L,6L,2L,6L,6L,6L,6L,2L,30L,2L,60L,12L,30L,16L,6L,16L,6L,16L,60L,6L,6L,6L,96L,2L,60L,6L,96L,6L,30L,6L,12L,2L,12L,12L,72L,12L,24L,30L,2L,2L,30L,30L,48L,2L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286479Inst : IEnumerable<long>
{
public static readonly long[] Value=A286479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286479.Bytes);
public long this[int i]=>Value[i];

public static A286479Inst Instance=new A286479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286480
{
public static readonly long[] Value={ 2L,12L,5L,14L,5L,61L,12L,179L,109L,61L,5L,265L,23L,142L,27L,226L,5L,607L,23L,148L,42L,61L,12L,1509L,109L,601L,44L,148L,5L,625L,23L,698L,27L,61L,61L,1117L,23L,601L,27L,2509L,5L,850L,80L,265L,148L,142L,12L,1426L,109L,607L,61L,148L,23L,430L,27L,3765L,27L,61L,5L,8575L,80L,601L,148L,2144L,61L,625L,23L,148L,27L,1741L,5L,8587L,80L,601L,363L,148L,216L,625L,138L,5719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286480Inst : IEnumerable<long>
{
public static readonly long[] Value=A286480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286480.Bytes);
public long this[int i]=>Value[i];

public static A286480Inst Instance=new A286480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286481
{
public static readonly long[] Value={ 1003062289999939142L,1003062299899939142L,1003062389989939142L,1003062399889939142L,1003062489979939142L,1003062499879939142L,1003062589969939142L,1003062599869939142L,1003062689959939142L,1003062699859939142L,1003062789949939142L,1003062799849939142L,1003062889939939142L,1003062899839939142L,1003062989929939142L,1003062999829939142L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286481Inst : IEnumerable<long>
{
public static readonly long[] Value=A286481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286481.Bytes);
public long this[int i]=>Value[i];

public static A286481Inst Instance=new A286481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286482
{
public static readonly long[] Value={ 1L,1L,6L,6L,26L,12L,42L,6L,24L,2L,48L,2L,64L,2L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286482Inst : IEnumerable<long>
{
public static readonly long[] Value=A286482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286482.Bytes);
public long this[int i]=>Value[i];

public static A286482Inst Instance=new A286482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286483
{
public static readonly BigInteger[] Value={ 1L,0L,5L,0L,238L,0L,51508L,0L,35028576L,0L,59053389408L,0L,209726098354368L,0L,1397532391623302400L,0L,BigInteger.Parse("16043549794523492290560"),0L,BigInteger.Parse("297285345537576037788672000"),0L,BigInteger.Parse("8447414796960536731803240038400") };
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
public class A286483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286483Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286483.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286483Inst Instance=new A286483Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286484
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286484Inst : IEnumerable<long>
{
public static readonly long[] Value=A286484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286484.Bytes);
public long this[int i]=>Value[i];

public static A286484Inst Instance=new A286484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286485
{
public static readonly long[] Value={ 1L,4L,6L,7L,10L,13L,15L,18L,19L,22L,24L,25L,28L,31L,32L,35L,37L,40L,42L,43L,46L,49L,51L,54L,55L,58L,60L,63L,65L,66L,69L,72L,73L,76L,78L,79L,82L,85L,87L,90L,91L,94L,96L,97L,100L,103L,104L,107L,109L,112L,114L,115L,118L,121L,122L,125L,127L,128L,131L,134L,136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286485Inst : IEnumerable<long>
{
public static readonly long[] Value=A286485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286485.Bytes);
public long this[int i]=>Value[i];

public static A286485Inst Instance=new A286485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286486
{
public static readonly long[] Value={ 2L,3L,5L,8L,9L,11L,12L,14L,16L,17L,20L,21L,23L,26L,27L,29L,30L,33L,34L,36L,38L,39L,41L,44L,45L,47L,48L,50L,52L,53L,56L,57L,59L,61L,62L,64L,67L,68L,70L,71L,74L,75L,77L,80L,81L,83L,84L,86L,88L,89L,92L,93L,95L,98L,99L,101L,102L,105L,106L,108L,110L,111L,113L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286486Inst : IEnumerable<long>
{
public static readonly long[] Value=A286486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286486.Bytes);
public long this[int i]=>Value[i];

public static A286486Inst Instance=new A286486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286567
{
public static readonly long[] Value={ 1L,1L,3L,5L,11L,3L,43L,5L,3L,11L,683L,3L,2731L,43L,3L,5L,43691L,3L,174763L,5L,3L,23L,2796203L,3L,11L,2731L,3L,5L,59L,3L,715827883L,5L,3L,43691L,11L,3L,1777L,174763L,3L,5L,83L,3L,2932031007403L,5L,3L,47L,283L,3L,43L,11L,3L,5L,107L,3L,11L,5L,3L,59L,2833L,3L,768614336404564651L,715827883L,3L,5L,11L,3L,7327657L,5L,3L,11L,56409643L,3L,1753L,223L,3L,5L,43L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286567Inst : IEnumerable<long>
{
public static readonly long[] Value=A286567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286567.Bytes);
public long this[int i]=>Value[i];

public static A286567Inst Instance=new A286567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286568
{
public static readonly long[] Value={ 1L,1L,8L,3L,14L,8L,42L,10L,21L,14L,76L,19L,90L,42L,63L,36L,152L,21L,208L,44L,148L,76L,322L,53L,210L,90L,228L,117L,434L,63L,625L,136L,296L,152L,402L,78L,702L,208L,375L,152L,860L,148L,988L,251L,324L,322L,1271L,169L,903L,210L,627L,324L,1430L,228L,943L,375L,816L,434L,1828L,187L,1890L,625L,777L,528L,1273L,296L,2344L,560L,1220L,402L,2698L,300L,2700L,702L,901L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286568Inst : IEnumerable<long>
{
public static readonly long[] Value=A286568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286568.Bytes);
public long this[int i]=>Value[i];

public static A286568Inst Instance=new A286568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286569
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,2L,2L,1L,3L,2L,1L,1L,4L,2L,2L,2L,1L,1L,1L,3L,5L,4L,3L,3L,2L,1L,1L,1L,6L,2L,1L,4L,4L,3L,3L,2L,3L,3L,3L,3L,3L,5L,5L,7L,7L,8L,9L,9L,2L,5L,9L,1L,3L,7L,2L,3L,1L,1L,1L,1L,10L,2L,5L,6L,1L,7L,4L,4L,3L,3L,1L,5L,5L,7L,3L,9L,9L,5L,5L,9L,9L,5L,9L,7L,5L,7L,11L,7L,9L,11L,11L,12L,12L,13L,14L,9L,5L,3L,15L,7L,9L,16L,4L,12L,11L,5L,1L,16L,3L,3L,17L,1L,6L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286569Inst : IEnumerable<long>
{
public static readonly long[] Value=A286569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286569.Bytes);
public long this[int i]=>Value[i];

public static A286569Inst Instance=new A286569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286570
{
public static readonly long[] Value={ 1L,3L,3L,10L,3L,61L,3L,36L,10L,27L,3L,117L,3L,27L,34L,136L,3L,103L,3L,90L,21L,27L,3L,619L,10L,27L,36L,753L,3L,625L,3L,528L,34L,27L,21L,666L,3L,27L,21L,552L,3L,625L,3L,117L,103L,27L,3L,1323L,10L,78L,34L,90L,3L,430L,21L,489L,21L,27L,3L,2545L,3L,27L,78L,2080L,21L,625L,3L,90L,34L,495L,3L,2773L,3L,27L,78L,117L,21L,625L,3L,1224L,136L,27L,3L,3801L,21L,27L,34L,375L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286570Inst : IEnumerable<long>
{
public static readonly long[] Value=A286570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286570.Bytes);
public long this[int i]=>Value[i];

public static A286570Inst Instance=new A286570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286571
{
public static readonly long[] Value={ 1L,5L,8L,25L,17L,21L,30L,113L,70L,51L,68L,103L,93L,72L,51L,481L,155L,148L,192L,222L,331L,126L,278L,324L,382L,159L,569L,78L,437L,591L,498L,1985L,126L,237L,786L,2521L,705L,282L,952L,375L,863L,660L,948L,243L,337L,384L,1130L,1759L,1330L,1842L,237L,678L,1433L,520L,1776L,459L,1897L,567L,1772L,2076L,1893L,636L,2713L,8065L,2421L,810L,2280L,1002L,384L,2046L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286571Inst : IEnumerable<long>
{
public static readonly long[] Value=A286571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286571.Bytes);
public long this[int i]=>Value[i];

public static A286571Inst Instance=new A286571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286572
{
public static readonly long[] Value={ 0L,1L,7L,22L,23L,67L,29L,122L,79L,173L,67L,408L,107L,277L,328L,531L,214L,742L,191L,949L,530L,631L,277L,1894L,498L,905L,781L,1598L,467L,2704L,497L,2149L,1178L,1600L,1228L,4188L,743L,1771L,1656L,4282L,949L,4658L,947L,3572L,3163L,2557L,1129L,8005L,1597L,4373L,2855L,4953L,1487L,7141L,2704L,7384L,3242L,4097L,1771L,14539L,1955L,4561L,5462L,8520L,3745L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286572Inst : IEnumerable<long>
{
public static readonly long[] Value=A286572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286572.Bytes);
public long this[int i]=>Value[i];

public static A286572Inst Instance=new A286572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286573
{
public static readonly long[] Value={ 1L,2L,5L,7L,14L,23L,9L,29L,42L,40L,65L,80L,90L,31L,40L,121L,44L,142L,189L,109L,61L,115L,77L,302L,273L,148L,318L,94L,434L,532L,20L,497L,115L,86L,148L,826L,702L,271L,148L,355L,230L,601L,119L,220L,265L,131L,299L,1178L,297L,485L,86L,265L,1430L,838L,320L,328L,271L,556L,1769L,1957L,1890L,50L,142L,2017L,148L,751L,2277L,179L,373L,832L,665L,2932L,54L,856L,485L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286573Inst : IEnumerable<long>
{
public static readonly long[] Value=A286573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286573.Bytes);
public long this[int i]=>Value[i];

public static A286573Inst Instance=new A286573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286574
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,1L,2L,1L,2L,2L,2L,1L,2L,2L,1L,1L,2L,2L,2L,2L,3L,2L,3L,1L,2L,2L,2L,2L,3L,1L,2L,1L,2L,2L,2L,2L,3L,2L,3L,2L,3L,3L,3L,2L,3L,3L,2L,1L,2L,2L,2L,2L,3L,2L,3L,2L,3L,3L,3L,1L,2L,2L,2L,1L,2L,2L,2L,2L,3L,2L,3L,2L,3L,3L,3L,2L,3L,3L,2L,2L,3L,3L,3L,3L,4L,3L,4L,2L,3L,3L,3L,3L,4L,2L,3L,1L,2L,2L,2L,2L,3L,2L,3L,2L,3L,3L,3L,2L,3L,3L,2L,2L,3L,3L,3L,3L,4L,3L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286574Inst : IEnumerable<long>
{
public static readonly long[] Value=A286574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286574.Bytes);
public long this[int i]=>Value[i];

public static A286574Inst Instance=new A286574Inst();

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