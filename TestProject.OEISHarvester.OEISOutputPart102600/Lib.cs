using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A122241
{
public static readonly long[] Value={ 4L,22L,54L,169L,516L,1841L,6076L,19256L,66140L,252691L,888179L,2900616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122241Inst : IEnumerable<long>
{
public static readonly long[] Value=A122241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122241.Bytes);
public long this[int i]=>Value[i];

public static A122241Inst Instance=new A122241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122242
{
public static readonly long[] Value={ 42L,240L,916L,3748L,14960L,62104L,248176L,969304L,3876576L,15962544L,63772488L,248169896L,993554240L,4086635408L,16350541128L,63529835824L,254129143040L,1046249323840L,4184725760584L,16276030608712L,65054467548432L,267635134298624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122242Inst : IEnumerable<long>
{
public static readonly long[] Value=A122242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122242.Bytes);
public long this[int i]=>Value[i];

public static A122242Inst Instance=new A122242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122243
{
public static readonly BigInteger[] Value={ 101010L,11110000L,1110010100L,111010100100L,11101001110000L,1111001010011000L,111100100101110000L,11101100101001011000UL,BigInteger.Parse("1110110010011011100000"),BigInteger.Parse("111100111001000110110000") };
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
public class A122243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122243Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A122243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122243.Bytes);
public BigInteger this[int i]=>Value[i];

public static A122243Inst Instance=new A122243Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122244
{
public static readonly long[] Value={ 5L,21L,55L,183L,512L,1724L,6085L,20899L,66106L,231841L,888275L,3188220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122244Inst : IEnumerable<long>
{
public static readonly long[] Value=A122244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122244.Bytes);
public long this[int i]=>Value[i];

public static A122244Inst Instance=new A122244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122245
{
public static readonly long[] Value={ 44L,232L,920L,3876L,14936L,60568L,248240L,996440L,3876264L,15524272L,63773584L,255477160L,993549616L,3970767760L,16350559552L,65386339632L,254129067336L,1016476056896L,4184726043136L,16740063237448L,65054466609736L,260416091191808L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122245Inst : IEnumerable<long>
{
public static readonly long[] Value=A122245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122245.Bytes);
public long this[int i]=>Value[i];

public static A122245Inst Instance=new A122245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122246
{
public static readonly BigInteger[] Value={ 101100L,11101000L,1110011000L,111100100100L,11101001011000L,1110110010011000L,111100100110110000L,11110011010001011000UL,BigInteger.Parse("1110110010010110101000"),BigInteger.Parse("111011001110000110110000") };
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
public class A122246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122246Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A122246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122246.Bytes);
public BigInteger this[int i]=>Value[i];

public static A122246Inst Instance=new A122246Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122247
{
public static readonly long[] Value={ 0L,1L,4L,8L,15L,23L,33L,44L,59L,75L,93L,112L,134L,157L,182L,208L,239L,271L,305L,340L,378L,417L,458L,500L,546L,593L,642L,692L,745L,799L,855L,912L,975L,1039L,1105L,1172L,1242L,1313L,1386L,1460L,1538L,1617L,1698L,1780L,1865L,1951L,2039L,2128L,2222L,2317L,2414L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122247Inst : IEnumerable<long>
{
public static readonly long[] Value=A122247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122247.Bytes);
public long this[int i]=>Value[i];

public static A122247Inst Instance=new A122247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122248
{
public static readonly long[] Value={ 0L,1L,3L,5L,9L,13L,18L,23L,31L,39L,48L,57L,68L,79L,91L,103L,119L,135L,152L,169L,188L,207L,227L,247L,270L,293L,317L,341L,367L,393L,420L,447L,479L,511L,544L,577L,612L,647L,683L,719L,758L,797L,837L,877L,919L,961L,1004L,1047L,1094L,1141L,1189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122248Inst : IEnumerable<long>
{
public static readonly long[] Value=A122248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122248.Bytes);
public long this[int i]=>Value[i];

public static A122248Inst Instance=new A122248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122249
{
public static readonly BigInteger[] Value={ 1L,4L,256L,65536L,1073741824L,70368744177664L,BigInteger.Parse("73786976294838206464"),BigInteger.Parse("309485009821345068724781056"),BigInteger.Parse("332306998946228968225951765070086144"),BigInteger.Parse("1427247692705959881058285969449495136382746624") };
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
public class A122249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122249Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A122249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122249.Bytes);
public BigInteger this[int i]=>Value[i];

public static A122249Inst Instance=new A122249Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122250
{
public static readonly long[] Value={ 0L,1L,3L,7L,12L,18L,26L,35L,45L,58L,72L,87L,104L,122L,141L,162L,184L,207L,233L,260L,288L,318L,349L,381L,415L,450L,486L,526L,567L,609L,653L,698L,744L,792L,841L,891L,944L,998L,1053L,1110L,1168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122250Inst : IEnumerable<long>
{
public static readonly long[] Value=A122250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122250.Bytes);
public long this[int i]=>Value[i];

public static A122250Inst Instance=new A122250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122251
{
public static readonly BigInteger[] Value={ 1L,9L,729L,4782969L,282429536481L,150094635296999121L,BigInteger.Parse("6461081889226673298932241"),BigInteger.Parse("2503155504993241601315571986085849"),BigInteger.Parse("8727963568087712425891397479476727340041449") };
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
public class A122251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122251Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A122251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122251.Bytes);
public BigInteger this[int i]=>Value[i];

public static A122251Inst Instance=new A122251Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122252
{
public static readonly BigInteger[] Value={ 1L,1L,59L,29L,533L,1577L,280361L,69311L,36226519L,7178335L,64766889203L,32128227179L,459253205417L,325788932161L,2311165698322609L,287144996287039L,1215091897184850539L,402833263943353393L,BigInteger.Parse("476099430416027805187") };
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
public class A122252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122252Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A122252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122252.Bytes);
public BigInteger this[int i]=>Value[i];

public static A122252Inst Instance=new A122252Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122253
{
public static readonly long[] Value={ 12L,12L,360L,60L,280L,168L,5040L,180L,11880L,264L,240240L,10920L,13104L,720L,367200L,3060L,813960L,15960L,1053360L,27720L,3825360L,16560L,5023200L,163800L,982800L,3024L,2630880L,6960L,33227040L,229152L,116867520L,235620L,282744L,2520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122253Inst : IEnumerable<long>
{
public static readonly long[] Value=A122253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122253.Bytes);
public long this[int i]=>Value[i];

public static A122253Inst Instance=new A122253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122254
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,24L,26L,27L,28L,30L,32L,34L,35L,36L,37L,38L,39L,40L,42L,45L,48L,51L,52L,54L,56L,57L,60L,63L,64L,65L,68L,70L,72L,73L,74L,76L,78L,80L,81L,84L,85L,90L,91L,95L,96L,97L,102L,104L,105L,108L,109L,111L,112L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122254Inst : IEnumerable<long>
{
public static readonly long[] Value=A122254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122254.Bytes);
public long this[int i]=>Value[i];

public static A122254Inst Instance=new A122254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122255
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122255Inst : IEnumerable<long>
{
public static readonly long[] Value=A122255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122255.Bytes);
public long this[int i]=>Value[i];

public static A122255Inst Instance=new A122255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122256
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,20L,20L,21L,21L,22L,23L,24L,24L,25L,25L,26L,26L,27L,28L,29L,30L,31L,32L,33L,33L,34L,34L,34L,35L,35L,35L,36L,36L,36L,37L,38L,38L,39L,39L,40L,41L,41L,41L,42L,42L,42L,43L,44L,45L,45L,45L,46L,46L,47L,47L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122256Inst : IEnumerable<long>
{
public static readonly long[] Value=A122256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122256.Bytes);
public long this[int i]=>Value[i];

public static A122256Inst Instance=new A122256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122257
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122257Inst : IEnumerable<long>
{
public static readonly long[] Value=A122257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122257.Bytes);
public long this[int i]=>Value[i];

public static A122257Inst Instance=new A122257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122258
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122258Inst : IEnumerable<long>
{
public static readonly long[] Value=A122258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122258.Bytes);
public long this[int i]=>Value[i];

public static A122258Inst Instance=new A122258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122259
{
public static readonly long[] Value={ 11L,23L,29L,31L,41L,43L,47L,53L,59L,61L,67L,71L,79L,83L,89L,101L,103L,107L,113L,127L,131L,137L,139L,149L,151L,157L,167L,173L,179L,181L,191L,197L,199L,211L,223L,227L,229L,233L,239L,241L,251L,263L,269L,271L,277L,281L,283L,293L,307L,311L,313L,317L,331L,337L,347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122259Inst : IEnumerable<long>
{
public static readonly long[] Value=A122259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122259.Bytes);
public long this[int i]=>Value[i];

public static A122259Inst Instance=new A122259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122260
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,24L,25L,26L,27L,28L,30L,32L,34L,35L,36L,37L,38L,39L,40L,42L,45L,48L,49L,50L,51L,52L,54L,56L,57L,60L,63L,64L,65L,68L,70L,72L,73L,74L,75L,76L,78L,80L,81L,84L,85L,90L,91L,95L,96L,97L,98L,100L,102L,104L,105L,108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122260Inst : IEnumerable<long>
{
public static readonly long[] Value=A122260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122260.Bytes);
public long this[int i]=>Value[i];

public static A122260Inst Instance=new A122260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122261
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122261Inst : IEnumerable<long>
{
public static readonly long[] Value=A122261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122261.Bytes);
public long this[int i]=>Value[i];

public static A122261Inst Instance=new A122261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122262
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,20L,20L,21L,22L,23L,24L,25L,25L,26L,26L,27L,27L,28L,29L,30L,31L,32L,33L,34L,34L,35L,35L,35L,36L,36L,36L,37L,38L,39L,40L,41L,41L,42L,42L,43L,44L,44L,44L,45L,45L,45L,46L,47L,48L,48L,48L,49L,49L,50L,50L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122262Inst : IEnumerable<long>
{
public static readonly long[] Value=A122262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122262.Bytes);
public long this[int i]=>Value[i];

public static A122262Inst Instance=new A122262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122263
{
public static readonly long[] Value={ 2L,3L,8L,21L,38L,63L,92L,129L,178L,231L,296L,369L,446L,531L,628L,737L,850L,975L,1108L,1245L,1394L,1551L,1720L,1905L,2098L,2295L,2500L,2709L,2926L,3171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122263Inst : IEnumerable<long>
{
public static readonly long[] Value=A122263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122263.Bytes);
public long this[int i]=>Value[i];

public static A122263Inst Instance=new A122263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122264
{
public static readonly long[] Value={ 2L,7L,12L,25L,30L,43L,48L,61L,82L,87L,108L,121L,126L,139L,160L,181L,186L,207L,220L,225L,246L,259L,280L,309L,322L,327L,340L,345L,358L,411L,424L,445L,450L,487L,492L,513L,534L,547L,568L,589L,594L,631L,636L,649L,654L,699L,744L,757L,762L,775L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122264Inst : IEnumerable<long>
{
public static readonly long[] Value=A122264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122264.Bytes);
public long this[int i]=>Value[i];

public static A122264Inst Instance=new A122264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122265
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,2L,4L,8L,16L,32L,64L,128L,256L,512L,1023L,2045L,4088L,8172L,16336L,32656L,65280L,130496L,260864L,521472L,1042432L,2083841L,4165637L,8327186L,16646200L,33276064L,66519472L,132973664L,265816832L,531372800L,1062224128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122265Inst : IEnumerable<long>
{
public static readonly long[] Value=A122265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122265.Bytes);
public long this[int i]=>Value[i];

public static A122265Inst Instance=new A122265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122266
{
public static readonly long[] Value={ 1L,238L,1679L,2162L,2401L,-6958L,-1442L,-23040L,1918L,-9362L,14641L,0L,80640L,-20398L,28083L,64078L,-38398L,-69120L,0L,-90482L,-58562L,0L,-241920L,100558L,146879L,0L,-193438L,399602L,104638L,114002L,130321L,24242L,0L,107282L,-276962L,351118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122266Inst : IEnumerable<long>
{
public static readonly long[] Value=A122266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122266.Bytes);
public long this[int i]=>Value[i];

public static A122266Inst Instance=new A122266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122267
{
public static readonly long[] Value={ 1L,-506L,-15625L,-89206L,-271151L,-420838L,-638066L,0L,56446L,2172742L,1771561L,5443200L,0L,7082714L,-4570773L,-98282L,-13055614L,0L,-29937600L,4072822L,-26439842L,0L,0L,26266966L,-24137569L,70761600L,38871506L,7906250L,52240606L,56926298L,-29158919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122267Inst : IEnumerable<long>
{
public static readonly long[] Value=A122267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122267.Bytes);
public long this[int i]=>Value[i];

public static A122267Inst Instance=new A122267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122268
{
public static readonly long[] Value={ 1L,478L,60959L,925922L,5764801L,20722082L,54717118L,103864320L,173379838L,194669278L,214358881L,0L,-92574720L,-799067998L,-815502237L,-1959423842L,-1300569598L,-2939811840L,0L,-2686875362L,3317297278L,0L,8406236160L,1662767518L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122268Inst : IEnumerable<long>
{
public static readonly long[] Value=A122268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122268.Bytes);
public long this[int i]=>Value[i];

public static A122268Inst Instance=new A122268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122269
{
public static readonly long[] Value={ 1L,230L,-205L,-6510L,18615L,478L,0L,-181220L,221595L,246380L,-329666L,360910L,-1444915L,0L,2504645L,925922L,-2420665L,0L,109940L,-8382140L,5764801L,6217240L,13420615L,-12214840L,-17672945L,20722082L,-24540725L,0L,0L,17018700L,54717118L,-97990L,-61107435L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122269Inst : IEnumerable<long>
{
public static readonly long[] Value=A122269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122269.Bytes);
public long this[int i]=>Value[i];

public static A122269Inst Instance=new A122269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122270
{
public static readonly long[] Value={ 250L,686L,750L,1250L,1372L,1750L,2250L,2662L,2744L,2750L,3250L,3430L,3750L,4250L,4394L,4750L,4802L,5250L,5488L,5750L,6250L,6750L,6860L,7250L,7546L,7750L,7986L,8250L,8750L,8788L,8918L,9250L,9604L,9750L,9826L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122270Inst : IEnumerable<long>
{
public static readonly long[] Value=A122270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122270.Bytes);
public long this[int i]=>Value[i];

public static A122270Inst Instance=new A122270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122271
{
public static readonly long[] Value={ 5L,7L,5L,5L,7L,5L,5L,11L,7L,5L,5L,7L,5L,5L,13L,5L,7L,5L,7L,5L,5L,5L,7L,5L,7L,5L,11L,5L,5L,13L,7L,5L,7L,5L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122271Inst : IEnumerable<long>
{
public static readonly long[] Value=A122271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122271.Bytes);
public long this[int i]=>Value[i];

public static A122271Inst Instance=new A122271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122272
{
public static readonly long[] Value={ 1250L,3750L,4802L,6250L,8750L,9604L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122272Inst : IEnumerable<long>
{
public static readonly long[] Value=A122272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122272.Bytes);
public long this[int i]=>Value[i];

public static A122272Inst Instance=new A122272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122273
{
public static readonly long[] Value={ 5L,5L,7L,5L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122273Inst : IEnumerable<long>
{
public static readonly long[] Value=A122273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122273.Bytes);
public long this[int i]=>Value[i];

public static A122273Inst Instance=new A122273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122274
{
public static readonly long[] Value={ 1L,-3L,0L,5L,0L,-1L,-4L,0L,-5L,0L,8L,10L,0L,-5L,0L,-20L,7L,0L,0L,0L,2L,13L,0L,0L,0L,12L,-16L,0L,-10L,0L,0L,-20L,0L,15L,0L,10L,14L,0L,20L,0L,-11L,-24L,0L,0L,0L,-10L,-4L,0L,0L,0L,8L,0L,0L,-15L,0L,40L,13L,0L,0L,0L,-22L,20L,0L,-20L,0L,-21L,-16L,0L,0L,0L,-28L,40L,0L,0L,0L,10L,26L,0L,20L,0L,2L,-6L,0L,-25L,0L,-9L,0L,0L,-10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122274Inst : IEnumerable<long>
{
public static readonly long[] Value=A122274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122274.Bytes);
public long this[int i]=>Value[i];

public static A122274Inst Instance=new A122274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122275
{
public static readonly long[] Value={ 1L,-1L,-1L,0L,0L,-2L,3L,4L,0L,0L,-3L,0L,-4L,0L,0L,4L,-5L,-2L,0L,0L,8L,0L,6L,0L,0L,0L,1L,-8L,0L,0L,-12L,4L,7L,0L,0L,-8L,0L,-2L,0L,0L,2L,5L,7L,0L,0L,10L,0L,0L,0L,0L,4L,-8L,-16L,0L,0L,4L,-10L,10L,0L,0L,0L,0L,-12L,0L,0L,-2L,5L,0L,0L,0L,6L,0L,14L,0L,0L,-8L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122275Inst : IEnumerable<long>
{
public static readonly long[] Value=A122275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122275.Bytes);
public long this[int i]=>Value[i];

public static A122275Inst Instance=new A122275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122276
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122276Inst : IEnumerable<long>
{
public static readonly long[] Value=A122276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122276.Bytes);
public long this[int i]=>Value[i];

public static A122276Inst Instance=new A122276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122277
{
public static readonly long[] Value={ 5L,3L,5L,4L,2L,2L,2L,1L,4L,3L,2L,1L,5L,2L,4L,2L,2L,1L,3L,1L,2L,1L,3L,2L,1L,2L,4L,1L,2L,3L,1L,1L,2L,1L,2L,2L,2L,1L,2L,2L,1L,1L,1L,2L,1L,2L,2L,2L,3L,2L,3L,2L,2L,2L,3L,3L,2L,1L,2L,1L,2L,2L,3L,2L,1L,5L,2L,2L,2L,2L,1L,4L,4L,2L,1L,2L,1L,2L,1L,2L,2L,2L,3L,3L,2L,3L,1L,1L,2L,1L,2L,1L,2L,2L,3L,1L,5L,1L,2L,3L,3L,3L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122277Inst : IEnumerable<long>
{
public static readonly long[] Value=A122277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122277.Bytes);
public long this[int i]=>Value[i];

public static A122277Inst Instance=new A122277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122278
{
public static readonly long[] Value={ 5L,7L,11L,12L,13L,19L,20L,21L,25L,27L,28L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122278Inst : IEnumerable<long>
{
public static readonly long[] Value=A122278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122278.Bytes);
public long this[int i]=>Value[i];

public static A122278Inst Instance=new A122278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122279
{
public static readonly long[] Value={ 1L,114L,472L,86520L,397603L,514911L,5123504L,382611481L,1166422075L,24846586495L,62401902289L,344065155571L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122279Inst : IEnumerable<long>
{
public static readonly long[] Value=A122279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122279.Bytes);
public long this[int i]=>Value[i];

public static A122279Inst Instance=new A122279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122280
{
public static readonly long[] Value={ 1L,2L,4L,6L,3L,9L,12L,10L,5L,15L,18L,8L,14L,7L,21L,24L,22L,11L,33L,27L,30L,16L,26L,13L,39L,36L,34L,17L,51L,42L,20L,25L,35L,28L,38L,19L,57L,45L,40L,46L,23L,69L,48L,50L,32L,54L,44L,55L,60L,58L,29L,87L,63L,49L,56L,62L,31L,93L,66L,52L,65L,70L,64L,74L,37L,111L,72L,75L,78L,68L,82L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122280Inst : IEnumerable<long>
{
public static readonly long[] Value=A122280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122280.Bytes);
public long this[int i]=>Value[i];

public static A122280Inst Instance=new A122280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122281
{
public static readonly long[] Value={ 1L,2L,5L,3L,9L,4L,14L,12L,6L,8L,18L,7L,24L,13L,10L,22L,28L,11L,36L,31L,15L,17L,41L,16L,32L,23L,20L,34L,51L,21L,57L,45L,19L,27L,33L,26L,65L,35L,25L,39L,72L,30L,79L,47L,38L,40L,84L,43L,54L,44L,29L,60L,95L,46L,48L,55L,37L,50L,104L,49L,112L,56L,53L,63L,61L,59L,121L,70L,42L,62L,135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122281Inst : IEnumerable<long>
{
public static readonly long[] Value=A122281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122281.Bytes);
public long this[int i]=>Value[i];

public static A122281Inst Instance=new A122281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122282
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,8L,7L,9L,10L,11L,13L,12L,14L,15L,19L,21L,22L,16L,20L,17L,18L,23L,24L,25L,27L,26L,28L,29L,33L,35L,36L,30L,34L,31L,32L,37L,38L,39L,41L,40L,51L,52L,56L,58L,59L,60L,62L,63L,64L,42L,43L,53L,57L,61L,44L,54L,45L,46L,47L,55L,48L,49L,50L,65L,66L,67L,69L,68L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122282Inst : IEnumerable<long>
{
public static readonly long[] Value=A122282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122282.Bytes);
public long this[int i]=>Value[i];

public static A122282Inst Instance=new A122282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122283
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,0L,3L,3L,1L,0L,4L,2L,2L,1L,0L,5L,8L,3L,2L,1L,0L,6L,7L,4L,3L,2L,1L,0L,7L,6L,6L,5L,3L,2L,1L,0L,8L,4L,5L,4L,5L,3L,2L,1L,0L,9L,5L,7L,6L,6L,6L,3L,2L,1L,0L,10L,22L,8L,7L,4L,5L,6L,3L,2L,1L,0L,11L,21L,9L,8L,7L,4L,4L,4L,3L,2L,1L,0L,12L,20L,10L,12L,8L,7L,5L,5L,4L,3L,2L,1L,0L,13L,17L,14L,13L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122283Inst : IEnumerable<long>
{
public static readonly long[] Value=A122283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122283.Bytes);
public long this[int i]=>Value[i];

public static A122283Inst Instance=new A122283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122284
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,0L,3L,3L,1L,0L,4L,2L,2L,1L,0L,5L,7L,3L,2L,1L,0L,6L,8L,4L,3L,2L,1L,0L,7L,6L,6L,5L,3L,2L,1L,0L,8L,5L,5L,4L,5L,3L,2L,1L,0L,9L,4L,7L,6L,6L,6L,3L,2L,1L,0L,10L,17L,8L,7L,4L,5L,6L,3L,2L,1L,0L,11L,18L,9L,8L,7L,4L,4L,4L,3L,2L,1L,0L,12L,20L,10L,12L,8L,7L,5L,5L,4L,3L,2L,1L,0L,13L,22L,14L,13L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122284Inst : IEnumerable<long>
{
public static readonly long[] Value=A122284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122284.Bytes);
public long this[int i]=>Value[i];

public static A122284Inst Instance=new A122284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122285
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,0L,3L,3L,1L,0L,4L,2L,2L,1L,0L,5L,8L,3L,2L,1L,0L,6L,7L,4L,3L,2L,1L,0L,7L,6L,6L,5L,3L,2L,1L,0L,8L,5L,5L,4L,5L,3L,2L,1L,0L,9L,4L,7L,6L,6L,6L,3L,2L,1L,0L,10L,22L,8L,7L,4L,5L,6L,3L,2L,1L,0L,11L,21L,9L,8L,7L,4L,4L,4L,3L,2L,1L,0L,12L,20L,14L,13L,8L,7L,5L,5L,4L,3L,2L,1L,0L,13L,18L,11L,12L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122285Inst : IEnumerable<long>
{
public static readonly long[] Value=A122285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122285.Bytes);
public long this[int i]=>Value[i];

public static A122285Inst Instance=new A122285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122286
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,0L,3L,3L,1L,0L,4L,2L,2L,1L,0L,5L,8L,3L,2L,1L,0L,6L,7L,4L,3L,2L,1L,0L,7L,6L,6L,5L,3L,2L,1L,0L,8L,5L,5L,4L,5L,3L,2L,1L,0L,9L,4L,7L,6L,6L,6L,3L,2L,1L,0L,10L,22L,8L,7L,4L,5L,6L,3L,2L,1L,0L,11L,21L,9L,8L,7L,4L,4L,4L,3L,2L,1L,0L,12L,20L,14L,13L,8L,7L,5L,5L,4L,3L,2L,1L,0L,13L,17L,11L,12L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122286Inst : IEnumerable<long>
{
public static readonly long[] Value=A122286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122286.Bytes);
public long this[int i]=>Value[i];

public static A122286Inst Instance=new A122286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122287
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,0L,3L,3L,1L,0L,4L,2L,2L,1L,0L,5L,7L,3L,2L,1L,0L,6L,8L,4L,3L,2L,1L,0L,7L,6L,6L,5L,3L,2L,1L,0L,8L,5L,5L,4L,5L,3L,2L,1L,0L,9L,4L,7L,6L,6L,6L,3L,2L,1L,0L,10L,17L,8L,7L,4L,5L,6L,3L,2L,1L,0L,11L,18L,9L,8L,7L,4L,4L,4L,3L,2L,1L,0L,12L,20L,14L,13L,8L,7L,5L,5L,4L,3L,2L,1L,0L,13L,21L,11L,12L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122287Inst : IEnumerable<long>
{
public static readonly long[] Value=A122287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122287.Bytes);
public long this[int i]=>Value[i];

public static A122287Inst Instance=new A122287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122288
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,0L,3L,3L,1L,0L,4L,2L,2L,1L,0L,5L,8L,3L,2L,1L,0L,6L,7L,4L,3L,2L,1L,0L,7L,6L,6L,5L,3L,2L,1L,0L,8L,4L,5L,4L,5L,3L,2L,1L,0L,9L,5L,7L,6L,6L,6L,3L,2L,1L,0L,10L,22L,8L,7L,4L,5L,6L,3L,2L,1L,0L,11L,21L,9L,8L,7L,4L,4L,4L,3L,2L,1L,0L,12L,20L,14L,13L,8L,7L,5L,5L,4L,3L,2L,1L,0L,13L,17L,11L,12L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122288Inst : IEnumerable<long>
{
public static readonly long[] Value=A122288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122288.Bytes);
public long this[int i]=>Value[i];

public static A122288Inst Instance=new A122288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122289
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,0L,3L,3L,1L,0L,4L,2L,2L,1L,0L,5L,7L,3L,2L,1L,0L,6L,8L,4L,3L,2L,1L,0L,7L,6L,6L,5L,3L,2L,1L,0L,8L,4L,5L,4L,5L,3L,2L,1L,0L,9L,5L,7L,6L,6L,6L,3L,2L,1L,0L,10L,18L,8L,7L,4L,5L,6L,3L,2L,1L,0L,11L,17L,9L,8L,7L,4L,4L,4L,3L,2L,1L,0L,12L,20L,10L,12L,8L,7L,5L,5L,4L,3L,2L,1L,0L,13L,22L,14L,13L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122289Inst : IEnumerable<long>
{
public static readonly long[] Value=A122289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122289.Bytes);
public long this[int i]=>Value[i];

public static A122289Inst Instance=new A122289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122290
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,0L,3L,3L,1L,0L,4L,2L,2L,1L,0L,5L,7L,3L,2L,1L,0L,6L,8L,4L,3L,2L,1L,0L,7L,6L,6L,5L,3L,2L,1L,0L,8L,4L,5L,4L,5L,3L,2L,1L,0L,9L,5L,7L,6L,6L,6L,3L,2L,1L,0L,10L,18L,8L,7L,4L,5L,6L,3L,2L,1L,0L,11L,17L,9L,8L,7L,4L,4L,4L,3L,2L,1L,0L,12L,20L,10L,12L,8L,7L,5L,5L,4L,3L,2L,1L,0L,13L,22L,14L,13L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122290Inst : IEnumerable<long>
{
public static readonly long[] Value=A122290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122290.Bytes);
public long this[int i]=>Value[i];

public static A122290Inst Instance=new A122290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122291
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,8L,7L,6L,9L,10L,13L,12L,11L,21L,20L,22L,17L,18L,19L,16L,14L,15L,23L,24L,27L,26L,25L,35L,34L,36L,31L,32L,33L,30L,28L,29L,58L,59L,57L,54L,55L,64L,61L,63L,45L,46L,62L,50L,49L,48L,56L,53L,60L,44L,47L,51L,42L,37L,38L,52L,43L,41L,40L,39L,65L,66L,69L,68L,67L,77L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122291Inst : IEnumerable<long>
{
public static readonly long[] Value=A122291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122291.Bytes);
public long this[int i]=>Value[i];

public static A122291Inst Instance=new A122291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122292
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,8L,7L,6L,9L,10L,13L,12L,11L,21L,22L,20L,17L,18L,19L,15L,14L,16L,23L,24L,27L,26L,25L,35L,36L,34L,31L,32L,33L,29L,28L,30L,58L,59L,64L,63L,62L,57L,61L,54L,45L,46L,55L,50L,49L,48L,56L,60L,52L,40L,41L,51L,39L,37L,38L,53L,43L,47L,44L,42L,65L,66L,69L,68L,67L,77L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122292Inst : IEnumerable<long>
{
public static readonly long[] Value=A122292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122292.Bytes);
public long this[int i]=>Value[i];

public static A122292Inst Instance=new A122292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122293
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,8L,6L,7L,9L,10L,13L,11L,12L,20L,21L,19L,14L,15L,22L,16L,17L,18L,23L,24L,27L,25L,26L,34L,35L,33L,28L,29L,36L,30L,31L,32L,54L,55L,57L,58L,59L,53L,56L,51L,37L,38L,52L,41L,39L,40L,61L,64L,60L,42L,43L,62L,44L,45L,46L,63L,47L,50L,48L,49L,65L,66L,69L,67L,68L,76L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122293Inst : IEnumerable<long>
{
public static readonly long[] Value=A122293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122293.Bytes);
public long this[int i]=>Value[i];

public static A122293Inst Instance=new A122293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122294
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,8L,6L,9L,10L,12L,13L,11L,17L,18L,20L,21L,22L,16L,14L,15L,19L,23L,24L,26L,27L,25L,31L,32L,34L,35L,36L,30L,28L,29L,33L,45L,46L,49L,50L,48L,54L,55L,57L,58L,59L,61L,63L,64L,62L,44L,47L,42L,37L,38L,43L,39L,40L,41L,53L,51L,56L,60L,52L,65L,66L,68L,69L,67L,73L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122294Inst : IEnumerable<long>
{
public static readonly long[] Value=A122294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122294.Bytes);
public long this[int i]=>Value[i];

public static A122294Inst Instance=new A122294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122295
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,7L,8L,5L,4L,15L,14L,16L,18L,17L,19L,22L,20L,11L,12L,21L,13L,10L,9L,39L,40L,41L,38L,37L,43L,42L,47L,48L,49L,44L,50L,46L,45L,52L,51L,60L,62L,63L,53L,61L,55L,29L,28L,54L,30L,32L,31L,56L,64L,57L,33L,36L,59L,34L,25L,26L,58L,35L,27L,24L,23L,113L,112L,114L,116L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122295Inst : IEnumerable<long>
{
public static readonly long[] Value=A122295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122295.Bytes);
public long this[int i]=>Value[i];

public static A122295Inst Instance=new A122295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122296
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,7L,4L,5L,6L,22L,21L,17L,18L,20L,10L,9L,11L,13L,12L,14L,16L,19L,15L,64L,63L,58L,59L,62L,46L,45L,48L,50L,49L,54L,57L,61L,55L,27L,26L,23L,24L,25L,29L,28L,33L,36L,35L,30L,31L,32L,34L,38L,37L,42L,47L,44L,51L,53L,60L,56L,39L,43L,40L,41L,52L,196L,195L,189L,190L,194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122296Inst : IEnumerable<long>
{
public static readonly long[] Value=A122296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122296.Bytes);
public long this[int i]=>Value[i];

public static A122296Inst Instance=new A122296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122297
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,6L,7L,5L,4L,22L,20L,19L,15L,14L,21L,16L,18L,13L,11L,17L,12L,10L,9L,64L,62L,61L,55L,54L,60L,53L,52L,41L,39L,51L,40L,38L,37L,63L,57L,56L,43L,42L,59L,47L,50L,36L,34L,48L,33L,29L,28L,58L,44L,49L,35L,30L,46L,32L,27L,25L,45L,31L,26L,24L,23L,196L,194L,193L,185L,184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122297Inst : IEnumerable<long>
{
public static readonly long[] Value=A122297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122297.Bytes);
public long this[int i]=>Value[i];

public static A122297Inst Instance=new A122297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122298
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,7L,5L,6L,4L,22L,21L,18L,20L,17L,13L,12L,15L,19L,16L,11L,10L,14L,9L,64L,63L,59L,62L,58L,50L,49L,55L,61L,57L,48L,46L,54L,45L,36L,35L,32L,34L,31L,41L,40L,52L,60L,56L,43L,47L,53L,44L,33L,30L,29L,27L,26L,39L,38L,51L,42L,28L,25L,24L,37L,23L,196L,195L,190L,194L,189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122298Inst : IEnumerable<long>
{
public static readonly long[] Value=A122298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122298.Bytes);
public long this[int i]=>Value[i];

public static A122298Inst Instance=new A122298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122299
{
public static readonly long[] Value={ 0L,1L,1L,5L,12L,38L,107L,316L,915L,2671L,7771L,22640L,65922L,191993L,559112L,1628281L,4741905L,13809541L,40216516L,117119750L,341079507L,993301748L,2892722267L,8424270271L,24533405595L,71446899736L,208069745986L,605946785585L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122299Inst : IEnumerable<long>
{
public static readonly long[] Value=A122299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122299.Bytes);
public long this[int i]=>Value[i];

public static A122299Inst Instance=new A122299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122300
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,5L,7L,8L,9L,10L,14L,16L,19L,11L,15L,12L,17L,20L,13L,18L,21L,22L,23L,24L,25L,26L,27L,37L,38L,42L,44L,53L,51L,47L,56L,60L,28L,29L,39L,43L,52L,30L,40L,31L,45L,46L,34L,54L,57L,61L,33L,41L,32L,48L,55L,35L,49L,58L,62L,36L,50L,59L,63L,64L,65L,66L,67L,68L,69L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122300Inst : IEnumerable<long>
{
public static readonly long[] Value=A122300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122300.Bytes);
public long this[int i]=>Value[i];

public static A122300Inst Instance=new A122300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122301
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,7L,6L,4L,5L,22L,21L,20L,17L,18L,19L,16L,14L,9L,10L,15L,11L,13L,12L,64L,63L,62L,58L,59L,61L,57L,54L,45L,46L,55L,48L,50L,49L,60L,56L,53L,44L,47L,51L,42L,37L,23L,24L,38L,25L,27L,26L,52L,43L,39L,28L,29L,41L,33L,36L,35L,40L,30L,34L,31L,32L,196L,195L,194L,189L,190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122301Inst : IEnumerable<long>
{
public static readonly long[] Value=A122301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122301.Bytes);
public long this[int i]=>Value[i];

public static A122301Inst Instance=new A122301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122302
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,8L,6L,5L,4L,17L,18L,20L,22L,21L,16L,19L,15L,12L,13L,14L,11L,10L,9L,45L,46L,48L,50L,49L,54L,55L,61L,63L,64L,57L,62L,59L,58L,44L,47L,53L,60L,56L,43L,52L,40L,31L,32L,41L,34L,36L,35L,42L,51L,39L,30L,33L,38L,29L,26L,27L,37L,28L,25L,24L,23L,129L,130L,132L,134L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122302Inst : IEnumerable<long>
{
public static readonly long[] Value=A122302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122302.Bytes);
public long this[int i]=>Value[i];

public static A122302Inst Instance=new A122302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122303
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,4L,6L,7L,8L,12L,13L,11L,9L,10L,15L,14L,16L,18L,17L,19L,20L,21L,22L,32L,31L,34L,35L,36L,30L,33L,28L,23L,24L,29L,25L,26L,27L,40L,41L,39L,37L,38L,43L,42L,47L,49L,50L,44L,48L,45L,46L,52L,51L,53L,55L,54L,56L,57L,59L,58L,60L,61L,62L,63L,64L,91L,92L,90L,87L,88L,97L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122303Inst : IEnumerable<long>
{
public static readonly long[] Value=A122303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122303.Bytes);
public long this[int i]=>Value[i];

public static A122303Inst Instance=new A122303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122304
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,4L,6L,7L,8L,12L,13L,11L,9L,10L,15L,14L,16L,18L,17L,19L,20L,21L,22L,31L,32L,34L,35L,36L,30L,33L,28L,24L,23L,29L,25L,26L,27L,40L,41L,39L,37L,38L,43L,42L,47L,49L,50L,44L,48L,45L,46L,52L,51L,53L,55L,54L,56L,57L,59L,58L,60L,61L,62L,63L,64L,87L,88L,90L,91L,92L,96L,97L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122304Inst : IEnumerable<long>
{
public static readonly long[] Value=A122304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122304.Bytes);
public long this[int i]=>Value[i];

public static A122304Inst Instance=new A122304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122305
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,4L,7L,8L,12L,13L,15L,16L,19L,11L,14L,9L,18L,20L,10L,17L,21L,22L,32L,34L,31L,35L,36L,40L,41L,43L,47L,53L,52L,44L,56L,60L,30L,33L,39L,42L,51L,28L,37L,23L,49L,50L,24L,55L,57L,61L,29L,38L,25L,48L,54L,26L,45L,59L,62L,27L,46L,58L,63L,64L,91L,92L,97L,99L,103L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122305Inst : IEnumerable<long>
{
public static readonly long[] Value=A122305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122305.Bytes);
public long this[int i]=>Value[i];

public static A122305Inst Instance=new A122305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122306
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,4L,5L,7L,8L,16L,19L,14L,9L,10L,15L,11L,12L,20L,17L,13L,18L,21L,22L,44L,47L,53L,56L,60L,42L,51L,37L,25L,23L,38L,24L,26L,27L,43L,52L,39L,28L,29L,40L,30L,34L,57L,61L,31L,54L,45L,46L,41L,33L,32L,55L,48L,35L,49L,62L,58L,36L,50L,59L,63L,64L,128L,131L,137L,140L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122306Inst : IEnumerable<long>
{
public static readonly long[] Value=A122306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122306.Bytes);
public long this[int i]=>Value[i];

public static A122306Inst Instance=new A122306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122307
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,5L,4L,7L,8L,16L,19L,15L,12L,13L,14L,11L,9L,20L,18L,10L,17L,21L,22L,53L,47L,44L,56L,60L,43L,52L,40L,34L,32L,41L,31L,35L,36L,42L,51L,39L,30L,33L,37L,28L,23L,57L,61L,24L,55L,49L,50L,38L,29L,25L,54L,48L,26L,45L,62L,59L,27L,46L,58L,63L,64L,165L,179L,159L,140L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122307Inst : IEnumerable<long>
{
public static readonly long[] Value=A122307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122307.Bytes);
public long this[int i]=>Value[i];

public static A122307Inst Instance=new A122307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122308
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,5L,4L,7L,8L,16L,19L,15L,12L,13L,14L,11L,9L,20L,18L,10L,17L,21L,22L,44L,47L,53L,56L,60L,43L,52L,40L,34L,32L,41L,31L,35L,36L,42L,51L,39L,30L,33L,37L,28L,25L,57L,61L,24L,55L,49L,50L,38L,29L,23L,54L,48L,26L,45L,62L,59L,27L,46L,58L,63L,64L,128L,131L,137L,140L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122308Inst : IEnumerable<long>
{
public static readonly long[] Value=A122308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122308.Bytes);
public long this[int i]=>Value[i];

public static A122308Inst Instance=new A122308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122309
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,4L,5L,7L,8L,16L,19L,14L,9L,10L,15L,11L,12L,20L,17L,13L,18L,21L,22L,53L,44L,47L,56L,60L,42L,51L,37L,23L,24L,38L,25L,26L,27L,43L,52L,39L,28L,29L,40L,30L,34L,57L,61L,31L,54L,45L,46L,41L,33L,32L,55L,48L,35L,49L,62L,58L,36L,50L,59L,63L,64L,165L,179L,156L,128L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122309Inst : IEnumerable<long>
{
public static readonly long[] Value=A122309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122309.Bytes);
public long this[int i]=>Value[i];

public static A122309Inst Instance=new A122309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122310
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,4L,7L,8L,12L,13L,15L,16L,19L,11L,14L,9L,18L,20L,10L,17L,21L,22L,31L,32L,34L,35L,36L,40L,41L,43L,47L,53L,52L,44L,56L,60L,30L,33L,39L,42L,51L,28L,37L,24L,49L,50L,25L,55L,57L,61L,29L,38L,23L,48L,54L,26L,45L,59L,62L,27L,46L,58L,63L,64L,87L,88L,90L,91L,92L,96L,97L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122310Inst : IEnumerable<long>
{
public static readonly long[] Value=A122310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122310.Bytes);
public long this[int i]=>Value[i];

public static A122310Inst Instance=new A122310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122311
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,8L,7L,9L,10L,11L,12L,13L,14L,15L,19L,22L,21L,16L,20L,17L,18L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,36L,35L,37L,38L,39L,40L,41L,51L,52L,60L,64L,63L,56L,62L,58L,59L,42L,43L,53L,61L,57L,44L,54L,45L,46L,47L,55L,48L,49L,50L,65L,66L,67L,68L,69L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122311Inst : IEnumerable<long>
{
public static readonly long[] Value=A122311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122311.Bytes);
public long this[int i]=>Value[i];

public static A122311Inst Instance=new A122311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122312
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,8L,7L,9L,10L,11L,12L,13L,14L,15L,19L,21L,22L,16L,20L,18L,17L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,36L,35L,37L,38L,39L,40L,41L,51L,52L,56L,58L,59L,60L,62L,63L,64L,42L,43L,53L,57L,61L,47L,55L,49L,50L,44L,54L,48L,46L,45L,65L,66L,67L,68L,69L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122312Inst : IEnumerable<long>
{
public static readonly long[] Value=A122312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122312.Bytes);
public long this[int i]=>Value[i];

public static A122312Inst Instance=new A122312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122313
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,6L,8L,9L,10L,11L,12L,13L,17L,18L,16L,14L,15L,21L,19L,20L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,35L,34L,36L,45L,46L,48L,49L,50L,44L,47L,42L,37L,38L,43L,39L,40L,41L,58L,59L,56L,51L,52L,57L,53L,54L,55L,63L,60L,61L,62L,64L,65L,66L,67L,68L,69L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122313Inst : IEnumerable<long>
{
public static readonly long[] Value=A122313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122313.Bytes);
public long this[int i]=>Value[i];

public static A122313Inst Instance=new A122313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122314
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,6L,8L,9L,10L,11L,12L,13L,17L,18L,16L,14L,15L,20L,21L,19L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,35L,34L,36L,45L,46L,48L,49L,50L,44L,47L,42L,37L,38L,43L,39L,40L,41L,54L,55L,57L,58L,59L,53L,56L,51L,52L,61L,62L,63L,60L,64L,65L,66L,67L,68L,69L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122314Inst : IEnumerable<long>
{
public static readonly long[] Value=A122314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122314.Bytes);
public long this[int i]=>Value[i];

public static A122314Inst Instance=new A122314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122315
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,8L,6L,9L,10L,11L,12L,13L,17L,18L,21L,22L,20L,16L,19L,14L,15L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,35L,36L,34L,45L,46L,48L,49L,50L,58L,59L,63L,64L,62L,57L,61L,54L,55L,44L,47L,56L,60L,53L,42L,51L,37L,38L,43L,52L,39L,40L,41L,65L,66L,67L,68L,69L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122315Inst : IEnumerable<long>
{
public static readonly long[] Value=A122315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122315.Bytes);
public long this[int i]=>Value[i];

public static A122315Inst Instance=new A122315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122316
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,8L,6L,7L,9L,10L,11L,12L,13L,21L,22L,19L,14L,15L,20L,18L,16L,17L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,36L,34L,35L,58L,59L,62L,63L,64L,56L,60L,51L,37L,38L,52L,39L,40L,41L,57L,61L,55L,49L,50L,53L,47L,42L,43L,54L,48L,46L,44L,45L,65L,66L,67L,68L,69L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122316Inst : IEnumerable<long>
{
public static readonly long[] Value=A122316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122316.Bytes);
public long this[int i]=>Value[i];

public static A122316Inst Instance=new A122316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122317
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,8L,7L,6L,9L,10L,11L,12L,13L,21L,20L,22L,17L,18L,19L,16L,14L,15L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,36L,35L,34L,58L,59L,57L,54L,55L,64L,61L,63L,45L,46L,62L,48L,49L,50L,56L,53L,60L,44L,47L,51L,42L,37L,38L,52L,43L,39L,40L,41L,65L,66L,67L,68L,69L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122317Inst : IEnumerable<long>
{
public static readonly long[] Value=A122317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122317.Bytes);
public long this[int i]=>Value[i];

public static A122317Inst Instance=new A122317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122318
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,8L,7L,6L,9L,10L,11L,12L,13L,21L,22L,20L,17L,18L,19L,15L,14L,16L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,36L,35L,34L,58L,59L,62L,63L,64L,57L,61L,54L,45L,46L,55L,48L,49L,50L,56L,60L,52L,40L,41L,51L,39L,37L,38L,53L,43L,47L,44L,42L,65L,66L,67L,68L,69L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122318Inst : IEnumerable<long>
{
public static readonly long[] Value=A122318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122318.Bytes);
public long this[int i]=>Value[i];

public static A122318Inst Instance=new A122318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122319
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,8L,6L,7L,9L,10L,11L,12L,13L,20L,21L,19L,14L,15L,22L,16L,17L,18L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,36L,34L,35L,54L,55L,57L,58L,59L,53L,56L,51L,37L,38L,52L,39L,40L,41L,61L,64L,60L,42L,43L,62L,44L,45L,46L,63L,47L,48L,49L,50L,65L,66L,67L,68L,69L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122319Inst : IEnumerable<long>
{
public static readonly long[] Value=A122319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122319.Bytes);
public long this[int i]=>Value[i];

public static A122319Inst Instance=new A122319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122320
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,8L,6L,9L,10L,11L,12L,13L,17L,18L,20L,21L,22L,16L,14L,15L,19L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,35L,36L,34L,45L,46L,48L,49L,50L,54L,55L,57L,58L,59L,61L,62L,63L,64L,44L,47L,42L,37L,38L,43L,39L,40L,41L,53L,51L,56L,60L,52L,65L,66L,67L,68L,69L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122320Inst : IEnumerable<long>
{
public static readonly long[] Value=A122320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122320.Bytes);
public long this[int i]=>Value[i];

public static A122320Inst Instance=new A122320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122321
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,8L,7L,4L,5L,14L,15L,19L,20L,22L,16L,21L,17L,9L,10L,18L,11L,13L,12L,37L,38L,39L,41L,40L,51L,52L,53L,54L,55L,60L,61L,62L,64L,42L,43L,56L,57L,63L,44L,58L,45L,23L,24L,46L,25L,27L,26L,47L,59L,48L,28L,29L,50L,33L,34L,36L,49L,30L,35L,31L,32L,107L,108L,109L,111L,110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122321Inst : IEnumerable<long>
{
public static readonly long[] Value=A122321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122321.Bytes);
public long this[int i]=>Value[i];

public static A122321Inst Instance=new A122321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122322
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,8L,4L,6L,5L,17L,18L,20L,22L,21L,9L,10L,14L,16L,19L,11L,12L,15L,13L,45L,46L,48L,50L,49L,54L,55L,61L,63L,64L,57L,58L,62L,59L,23L,24L,25L,27L,26L,37L,38L,42L,44L,47L,51L,53L,60L,56L,28L,29L,30L,31L,32L,39L,40L,43L,52L,33L,34L,35L,41L,36L,129L,130L,132L,134L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122322Inst : IEnumerable<long>
{
public static readonly long[] Value=A122322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122322.Bytes);
public long this[int i]=>Value[i];

public static A122322Inst Instance=new A122322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122323
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,7L,8L,4L,5L,14L,15L,16L,17L,18L,19L,22L,20L,9L,10L,21L,11L,13L,12L,37L,38L,39L,41L,40L,42L,43L,44L,45L,46L,47L,48L,50L,49L,51L,52L,60L,62L,63L,53L,61L,54L,23L,24L,55L,25L,27L,26L,56L,64L,57L,28L,29L,58L,33L,34L,35L,59L,30L,36L,31L,32L,107L,108L,109L,111L,110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122323Inst : IEnumerable<long>
{
public static readonly long[] Value=A122323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122323.Bytes);
public long this[int i]=>Value[i];

public static A122323Inst Instance=new A122323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122324
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,8L,4L,5L,6L,17L,18L,20L,22L,21L,9L,10L,11L,12L,13L,14L,16L,19L,15L,45L,46L,48L,50L,49L,54L,55L,61L,63L,64L,57L,58L,59L,62L,23L,24L,25L,27L,26L,28L,29L,30L,31L,32L,33L,34L,36L,35L,37L,38L,42L,44L,47L,51L,53L,56L,60L,39L,43L,40L,41L,52L,129L,130L,132L,134L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122324Inst : IEnumerable<long>
{
public static readonly long[] Value=A122324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122324.Bytes);
public long this[int i]=>Value[i];

public static A122324Inst Instance=new A122324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122325
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,6L,7L,4L,5L,22L,20L,19L,14L,15L,21L,16L,17L,9L,10L,18L,11L,13L,12L,64L,62L,61L,54L,55L,60L,53L,51L,37L,38L,52L,39L,41L,40L,63L,57L,56L,42L,43L,58L,44L,45L,23L,24L,46L,25L,27L,26L,59L,47L,48L,28L,29L,50L,33L,36L,34L,49L,30L,35L,31L,32L,196L,194L,193L,184L,185L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122325Inst : IEnumerable<long>
{
public static readonly long[] Value=A122325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122325.Bytes);
public long this[int i]=>Value[i];

public static A122325Inst Instance=new A122325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122326
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,8L,5L,6L,4L,17L,18L,20L,22L,21L,12L,13L,15L,16L,19L,11L,10L,14L,9L,45L,46L,48L,50L,49L,54L,55L,61L,63L,64L,57L,59L,62L,58L,31L,32L,34L,36L,35L,40L,41L,43L,44L,47L,52L,53L,60L,56L,30L,33L,29L,26L,27L,39L,38L,42L,51L,28L,25L,24L,37L,23L,129L,130L,132L,134L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122326Inst : IEnumerable<long>
{
public static readonly long[] Value=A122326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122326.Bytes);
public long this[int i]=>Value[i];

public static A122326Inst Instance=new A122326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122327
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,8L,6L,4L,5L,17L,18L,20L,21L,22L,16L,19L,14L,9L,10L,15L,11L,13L,12L,45L,46L,48L,50L,49L,54L,55L,57L,58L,59L,61L,62L,63L,64L,44L,47L,53L,56L,60L,42L,51L,37L,23L,24L,38L,25L,27L,26L,43L,52L,39L,28L,29L,41L,33L,35L,36L,40L,30L,34L,31L,32L,129L,130L,132L,134L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122327Inst : IEnumerable<long>
{
public static readonly long[] Value=A122327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122327.Bytes);
public long this[int i]=>Value[i];

public static A122327Inst Instance=new A122327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122328
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,8L,6L,4L,5L,17L,18L,20L,22L,21L,16L,19L,14L,9L,10L,15L,11L,12L,13L,45L,46L,48L,50L,49L,54L,55L,61L,63L,64L,57L,62L,58L,59L,44L,47L,53L,60L,56L,42L,51L,37L,23L,24L,38L,25L,27L,26L,43L,52L,39L,28L,29L,40L,30L,31L,32L,41L,33L,34L,35L,36L,129L,130L,132L,134L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122328Inst : IEnumerable<long>
{
public static readonly long[] Value=A122328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122328.Bytes);
public long this[int i]=>Value[i];

public static A122328Inst Instance=new A122328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122329
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,6L,8L,4L,5L,17L,18L,16L,14L,15L,22L,19L,21L,9L,10L,20L,11L,13L,12L,45L,46L,48L,50L,49L,44L,47L,42L,37L,38L,43L,39L,41L,40L,63L,62L,60L,51L,52L,64L,56L,58L,23L,24L,59L,25L,27L,26L,61L,53L,57L,28L,29L,54L,33L,35L,34L,55L,30L,36L,31L,32L,129L,130L,132L,134L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122329Inst : IEnumerable<long>
{
public static readonly long[] Value=A122329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122329.Bytes);
public long this[int i]=>Value[i];

public static A122329Inst Instance=new A122329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122330
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,8L,5L,4L,6L,17L,18L,20L,22L,21L,12L,13L,11L,9L,10L,15L,19L,16L,14L,45L,46L,48L,50L,49L,54L,55L,61L,63L,64L,57L,59L,58L,62L,31L,32L,34L,36L,35L,30L,33L,28L,23L,24L,29L,25L,27L,26L,40L,41L,52L,56L,60L,43L,53L,44L,47L,39L,51L,38L,37L,42L,129L,130L,132L,134L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122330Inst : IEnumerable<long>
{
public static readonly long[] Value=A122330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122330.Bytes);
public long this[int i]=>Value[i];

public static A122330Inst Instance=new A122330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122331
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,7L,4L,5L,6L,22L,21L,17L,18L,20L,9L,10L,11L,13L,12L,14L,15L,19L,16L,64L,63L,58L,59L,62L,45L,46L,48L,50L,49L,54L,55L,61L,57L,23L,24L,25L,27L,26L,28L,29L,33L,36L,35L,30L,31L,32L,34L,37L,38L,39L,41L,40L,51L,52L,60L,56L,42L,43L,44L,47L,53L,196L,195L,189L,190L,194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122331Inst : IEnumerable<long>
{
public static readonly long[] Value=A122331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122331.Bytes);
public long this[int i]=>Value[i];

public static A122331Inst Instance=new A122331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122332
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,7L,8L,5L,4L,14L,15L,16L,18L,17L,19L,20L,22L,11L,12L,21L,13L,10L,9L,37L,38L,39L,41L,40L,42L,43L,47L,48L,49L,44L,50L,46L,45L,51L,52L,53L,55L,54L,60L,61L,62L,28L,29L,63L,30L,32L,31L,56L,57L,64L,33L,34L,59L,36L,25L,26L,58L,35L,27L,24L,23L,107L,108L,109L,111L,110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122332Inst : IEnumerable<long>
{
public static readonly long[] Value=A122332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122332.Bytes);
public long this[int i]=>Value[i];

public static A122332Inst Instance=new A122332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122333
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,7L,4L,6L,5L,22L,21L,17L,20L,18L,9L,10L,14L,19L,16L,11L,15L,13L,12L,64L,63L,58L,62L,59L,45L,46L,54L,61L,57L,48L,55L,50L,49L,23L,24L,25L,27L,26L,37L,38L,51L,60L,56L,42L,44L,53L,47L,28L,29L,39L,52L,43L,33L,41L,36L,35L,30L,40L,31L,34L,32L,196L,195L,189L,194L,190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122333Inst : IEnumerable<long>
{
public static readonly long[] Value=A122333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122333.Bytes);
public long this[int i]=>Value[i];

public static A122333Inst Instance=new A122333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122334
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,8L,7L,5L,4L,14L,15L,19L,22L,21L,16L,20L,18L,11L,13L,17L,12L,10L,9L,37L,38L,39L,41L,40L,51L,52L,60L,62L,64L,56L,63L,59L,58L,42L,43L,53L,61L,57L,47L,55L,48L,28L,29L,50L,33L,36L,35L,44L,54L,49L,30L,34L,46L,32L,25L,27L,45L,31L,26L,24L,23L,107L,108L,109L,111L,110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122334Inst : IEnumerable<long>
{
public static readonly long[] Value=A122334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122334.Bytes);
public long this[int i]=>Value[i];

public static A122334Inst Instance=new A122334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122335
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,7L,5L,4L,6L,22L,21L,18L,17L,20L,13L,12L,11L,9L,10L,15L,14L,19L,16L,64L,63L,59L,58L,62L,50L,49L,48L,45L,46L,55L,54L,61L,57L,36L,35L,32L,31L,34L,33L,30L,28L,23L,24L,29L,25L,27L,26L,41L,40L,39L,37L,38L,52L,51L,60L,56L,43L,42L,47L,44L,53L,196L,195L,190L,189L,194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122335Inst : IEnumerable<long>
{
public static readonly long[] Value=A122335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122335.Bytes);
public long this[int i]=>Value[i];

public static A122335Inst Instance=new A122335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122336
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,6L,8L,5L,4L,17L,18L,16L,15L,14L,20L,19L,22L,12L,11L,21L,13L,10L,9L,45L,46L,48L,50L,49L,44L,47L,43L,40L,39L,42L,41L,38L,37L,54L,55L,53L,52L,51L,61L,60L,63L,31L,32L,62L,30L,29L,28L,57L,56L,64L,34L,33L,59L,36L,26L,25L,58L,35L,27L,24L,23L,129L,130L,132L,134L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122336Inst : IEnumerable<long>
{
public static readonly long[] Value=A122336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122336.Bytes);
public long this[int i]=>Value[i];

public static A122336Inst Instance=new A122336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122337
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,7L,5L,6L,4L,22L,21L,18L,20L,17L,13L,12L,15L,19L,16L,11L,14L,9L,10L,64L,63L,59L,62L,58L,50L,49L,55L,61L,57L,48L,54L,45L,46L,36L,35L,32L,34L,31L,41L,40L,52L,60L,56L,43L,47L,53L,44L,33L,30L,39L,51L,42L,28L,37L,23L,24L,29L,38L,25L,27L,26L,196L,195L,190L,194L,189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122337Inst : IEnumerable<long>
{
public static readonly long[] Value=A122337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122337.Bytes);
public long this[int i]=>Value[i];

public static A122337Inst Instance=new A122337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122338
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,6L,7L,5L,4L,21L,22L,19L,15L,14L,20L,16L,18L,13L,11L,17L,12L,10L,9L,58L,59L,62L,64L,63L,56L,60L,52L,41L,39L,51L,40L,38L,37L,57L,61L,53L,43L,42L,55L,47L,50L,35L,36L,48L,33L,29L,28L,54L,44L,49L,34L,30L,46L,32L,27L,25L,45L,31L,26L,24L,23L,170L,171L,174L,176L,175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122338Inst : IEnumerable<long>
{
public static readonly long[] Value=A122338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122338.Bytes);
public long this[int i]=>Value[i];

public static A122338Inst Instance=new A122338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122339
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,7L,6L,5L,4L,22L,21L,20L,18L,17L,19L,16L,15L,13L,12L,14L,11L,9L,10L,64L,63L,62L,59L,58L,61L,57L,55L,50L,49L,54L,48L,45L,46L,60L,56L,53L,47L,44L,52L,43L,41L,36L,35L,40L,34L,32L,31L,51L,42L,39L,33L,30L,37L,28L,23L,24L,38L,29L,25L,27L,26L,196L,195L,194L,190L,189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122339Inst : IEnumerable<long>
{
public static readonly long[] Value=A122339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122339.Bytes);
public long this[int i]=>Value[i];

public static A122339Inst Instance=new A122339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122340
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,7L,6L,5L,4L,21L,22L,20L,18L,17L,19L,16L,15L,13L,12L,14L,11L,10L,9L,58L,59L,62L,64L,63L,57L,61L,55L,50L,49L,54L,48L,46L,45L,56L,60L,53L,47L,44L,52L,43L,41L,35L,36L,40L,34L,32L,31L,51L,42L,39L,33L,30L,38L,29L,27L,26L,37L,28L,25L,24L,23L,170L,171L,174L,176L,175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122340Inst : IEnumerable<long>
{
public static readonly long[] Value=A122340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122340.Bytes);
public long this[int i]=>Value[i];

public static A122340Inst Instance=new A122340Inst();

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