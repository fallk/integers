using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A195257
{
public static readonly BigInteger[] Value={ 1L,5L,30L,185L,1180L,7845L,54850L,407225L,3241200L,27882725L,260710150L,2655929625L,29459366500L,354733101125L,4617633830250L,64677391201625L,970313455915000L,15525778234093125L,263942044676848750L,4750975877669605625L,BigInteger.Parse("90268637043154147500") };
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
public class A195257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195257Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195257.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195257Inst Instance=new A195257Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195258
{
public static readonly long[] Value={ 3L,2L,3L,293L,307L,317L,1373L,1451L,1481L,1487L,6947L,7109L,7331L,7349L,7411L,7173L,8423L,8467L,8681L,8693L,8713L,6221L,6269L,6311L,6379L,6521L,6529L,6551L,44221L,48497L,49307L,50111L,50177L,50497L,50527L,50543L,14813L,14891L,14957L,15053L,15161L,15187L,15227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195258Inst : IEnumerable<long>
{
public static readonly long[] Value=A195258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195258.Bytes);
public long this[int i]=>Value[i];

public static A195258Inst Instance=new A195258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195259
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,25L,138L,1036L,11270L,194105L,5600367L,275058868L,22805688464L,3173290832407L,739292604671606L,288039050041591288L,BigInteger.Parse("188101949731185856592"),BigInteger.Parse("205677982188934721693289"),BigInteger.Parse("377993929252274297946197815"),BigInteger.Parse("1165828413037318706712871579130") };
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
public class A195259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195259Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195259.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195259Inst Instance=new A195259Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195260
{
public static readonly BigInteger[] Value={ 1L,1L,4L,25L,200L,1948L,23293L,366698L,8669713L,354287410L,26296911212L,3452678049185L,778932197922145L,297680194679224221L,BigInteger.Parse("192063113715788790619"),BigInteger.Parse("208413189299565620902495"),BigInteger.Parse("381159431868835826320370849"),BigInteger.Parse("1171978295935406653806412222411") };
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
public class A195260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195260Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195260.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195260Inst Instance=new A195260Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195261
{
public static readonly long[] Value={ 1L,1L,3L,12L,56L,284L,1520L,8449L,48303L,282207L,1677489L,10112546L,61678702L,379919672L,2359991520L,14767164162L,92993252612L,588904075546L,3748029131834L,23960546501520L,153790930664222L,990690415079898L,6402865318618654L,41506375396111624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195261Inst : IEnumerable<long>
{
public static readonly long[] Value=A195261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195261.Bytes);
public long this[int i]=>Value[i];

public static A195261Inst Instance=new A195261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195262
{
public static readonly long[] Value={ 1L,1L,4L,21L,125L,805L,5459L,38403L,277667L,2050771L,15405655L,117344350L,904175038L,7035182178L,55197856415L,436221495843L,3469249248383L,27744896161177L,222987118478532L,1800106801933350L,14589674016207940L,118674224290447850L,968474133792224994L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195262Inst : IEnumerable<long>
{
public static readonly long[] Value=A195262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195262.Bytes);
public long this[int i]=>Value[i];

public static A195262Inst Instance=new A195262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195263
{
public static readonly BigInteger[] Value={ 1L,3L,75L,4809L,578415L,112024353L,31851411375L,12493267169169L,6464106627329055L,4265281191267407073L,BigInteger.Parse("3495556570494504442575"),BigInteger.Parse("3483310917470882398369329"),BigInteger.Parse("4147647341931988462919773695"),BigInteger.Parse("5815857702618060221437908948993"),BigInteger.Parse("9485411994735540168549266106329775") };
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
public class A195263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195263Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195263.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195263Inst Instance=new A195263Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195264
{
public static readonly long[] Value={ 1L,2L,3L,211L,5L,23L,7L,23L,2213L,2213L,11L,223L,13L,311L,1129L,233L,17L,17137L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195264Inst : IEnumerable<long>
{
public static readonly long[] Value=A195264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195264.Bytes);
public long this[int i]=>Value[i];

public static A195264Inst Instance=new A195264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195265
{
public static readonly BigInteger[] Value={ 20L,225L,3252L,223271L,297699L,399233L,715623L,3263907L,32347303L,160720129L,1153139393L,72171972859L,736728093411L,3245576031137L,11295052366467L,310807934835791L,1789205424940407L,31745337977379983L,1122916740775279751L,7251536377635958081L,BigInteger.Parse("151243563319717018007") };
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
public class A195265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195265Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195265.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195265Inst Instance=new A195265Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195266
{
public static readonly BigInteger[] Value={ 105L,357L,3717L,32759L,174147L,358049L,379677L,3196661L,13245897L,373120347L,31961239449L,364811643843L,3474632755849L,7148938489519L,19530970872089L,731453184134581L,1069684240583849L,11451757737372871L,18163269379764491L,99042547183388553L,344278174560973471L,BigInteger.Parse("71388716692555572127"),BigInteger.Parse("148872380947952962303"),BigInteger.Parse("1453102458624189919451"),BigInteger.Parse("11245912921175349453489") };
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
public class A195266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195266Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195266.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195266Inst Instance=new A195266Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195267
{
public static readonly BigInteger[] Value={ 14L,89L,3104L,265832L,42711550L,11454711984L,4840928618302L,3108267243405312L,2924919606477510504L,BigInteger.Parse("3870562086323220000000"),BigInteger.Parse("6908112063470228210507358"),BigInteger.Parse("16038451894952529045493383168"),BigInteger.Parse("47076979725683125083464370176990"),BigInteger.Parse("170928617514191160703263296201650176") };
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
public class A195267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195267Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195267.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195267Inst Instance=new A195267Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195268
{
public static readonly long[] Value={ 9L,18L,25L,36L,50L,72L,100L,144L,200L,288L,289L,400L,576L,578L,729L,800L,1152L,1156L,1458L,1600L,1681L,2304L,2312L,2401L,2916L,3200L,3362L,3481L,4608L,4624L,4802L,5041L,5832L,6400L,6724L,6962L,7921L,9216L,9248L,9604L,10082L,10201L,11664L,12800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195268Inst : IEnumerable<long>
{
public static readonly long[] Value=A195268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195268.Bytes);
public long this[int i]=>Value[i];

public static A195268Inst Instance=new A195268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195269
{
public static readonly long[] Value={ 10L,35L,148L,332L,540L,540L,7722L,22793L,107189L,107189L,513335L,1847534L,5756981L,32023025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195269Inst : IEnumerable<long>
{
public static readonly long[] Value=A195269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195269.Bytes);
public long this[int i]=>Value[i];

public static A195269Inst Instance=new A195269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195270
{
public static readonly long[] Value={ 71L,107L,137L,281L,347L,379L,443L,461L,557L,617L,641L,727L,809L,827L,853L,857L,991L,1031L,1049L,1091L,1093L,1289L,1297L,1319L,1433L,1489L,1579L,1607L,1613L,1697L,1747L,1787L,1867L,1871L,1877L,1931L,1987L,1997L,2027L,2237L,2269L,2309L,2377L,2381L,2473L,2591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195270Inst : IEnumerable<long>
{
public static readonly long[] Value=A195270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195270.Bytes);
public long this[int i]=>Value[i];

public static A195270Inst Instance=new A195270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195271
{
public static readonly long[] Value={ 2L,5L,17L,29L,41L,79L,101L,137L,149L,163L,191L,197L,227L,269L,281L,313L,349L,353L,461L,463L,521L,541L,569L,593L,599L,613L,617L,641L,757L,769L,809L,821L,827L,857L,881L,887L,941L,1009L,1049L,1061L,1087L,1093L,1097L,1117L,1151L,1223L,1229L,1277L,1279L,1289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195271Inst : IEnumerable<long>
{
public static readonly long[] Value=A195271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195271.Bytes);
public long this[int i]=>Value[i];

public static A195271Inst Instance=new A195271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195272
{
public static readonly BigInteger[] Value={ 1L,25L,2125L,626525L,649112125L,2375645170875L,30812488814662125L,BigInteger.Parse("1419187229961716246975"),BigInteger.Parse("232443697109891957009442125"),BigInteger.Parse("135513533218801266004475511024825") };
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
public class A195272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195272Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195272.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195272Inst Instance=new A195272Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195273
{
public static readonly BigInteger[] Value={ 1L,49L,11319L,12608631L,68604760497L,1833160598134397L,BigInteger.Parse("241338657495589799523"),BigInteger.Parse("156865927758847103008175635"),BigInteger.Parse("504091149328239931994947830412175") };
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
public class A195273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195273Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195273.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195273Inst Instance=new A195273Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195274
{
public static readonly BigInteger[] Value={ 1L,81L,39609L,119743353L,2266745635377L,270149651796118149L,BigInteger.Parse("203368493873412168605037"),BigInteger.Parse("969036564714736790447759054277") };
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
public class A195274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195274Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195274.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195274Inst Instance=new A195274Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195275
{
public static readonly BigInteger[] Value={ 1L,121L,107811L,724789395L,37235577669213L,14698398557250127027UL,BigInteger.Parse("44727914263743356875711779"),BigInteger.Parse("1051443054205968885835418306282537") };
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
public class A195275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195275Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195275.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195275Inst Instance=new A195275Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195276
{
public static readonly BigInteger[] Value={ 1L,169L,248261L,3249312469L,383752106451389L,BigInteger.Parse("411207789366962687359"),BigInteger.Parse("4011033701337366560359871745") };
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
public class A195276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195276Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195276.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195276Inst Instance=new A195276Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195277
{
public static readonly BigInteger[] Value={ 1L,225L,507375L,11755976175L,2834518121474625L,BigInteger.Parse("7151051711514319493625"),BigInteger.Parse("189393562987102056163761489375") };
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
public class A195277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195277Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195277.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195277Inst Instance=new A195277Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195278
{
public static readonly long[] Value={ 1L,1L,9L,1L,25L,171L,1L,49L,2125L,6939L,1L,81L,11319L,626525L,609309L,1L,121L,39609L,12608631L,649112125L,116330103L,1L,169L,107811L,119743353L,68604760497L,2375645170875L,48439766655L,1L,225L,248261L,724789395L,2266745635377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195278Inst : IEnumerable<long>
{
public static readonly long[] Value=A195278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195278.Bytes);
public long this[int i]=>Value[i];

public static A195278Inst Instance=new A195278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195279
{
public static readonly long[] Value={ 171L,2125L,11319L,39609L,107811L,248261L,507375L,948209L,1653019L,2725821L,4294951L,6515625L,9572499L,13682229L,19096031L,26102241L,35028875L,46246189L,60169239L,77260441L,98032131L,123049125L,152931279L,188356049L,230061051L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195279Inst : IEnumerable<long>
{
public static readonly long[] Value=A195279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195279.Bytes);
public long this[int i]=>Value[i];

public static A195279Inst Instance=new A195279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195280
{
public static readonly long[] Value={ 6939L,626525L,12608631L,119743353L,724789395L,3249312469L,11755976175L,36215968241L,98454861067L,242177297229L,548894457959L,1162058315625L,2322243189891L,4416808121541L,8048123047903L,14125147709409L,23983914638075L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195280Inst : IEnumerable<long>
{
public static readonly long[] Value=A195280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195280.Bytes);
public long this[int i]=>Value[i];

public static A195280Inst Instance=new A195280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195281
{
public static readonly long[] Value={ 609309L,649112125L,68604760497L,2266745635377L,37235577669213L,383752106451389L,2834518121474625L,16307551677812033L,77247504140304381L,313215736935324573L,1118258748766971057L,3590779676071640625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195281Inst : IEnumerable<long>
{
public static readonly long[] Value=A195281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195281.Bytes);
public long this[int i]=>Value[i];

public static A195281Inst Instance=new A195281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195282
{
public static readonly BigInteger[] Value={ 116330103L,2375645170875L,1833160598134397L,270149651796118149L,14698398557250127027UL,BigInteger.Parse("411207789366962687359"),BigInteger.Parse("7151051711514319493625"),BigInteger.Parse("87046671186871404342793"),BigInteger.Parse("802793502537221468366191") };
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
public class A195282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195282Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195282.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195282Inst Instance=new A195282Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195283
{
public static readonly BigInteger[] Value={ 48439766655L,30812488814662125L,BigInteger.Parse("241338657495589799523"),BigInteger.Parse("203368493873412168605037"),BigInteger.Parse("44727914263743356875711779"),BigInteger.Parse("4011033701337366560359871745"),BigInteger.Parse("189393562987102056163761489375") };
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
public class A195283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195283Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195283.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195283Inst Instance=new A195283Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195284
{
public static readonly long[] Value={ 2L,1L,0L,8L,1L,8L,5L,1L,0L,6L,7L,7L,8L,9L,1L,9L,5L,5L,4L,6L,6L,5L,9L,2L,9L,0L,2L,9L,6L,2L,1L,8L,1L,2L,3L,5L,5L,8L,1L,3L,0L,3L,6L,7L,5L,9L,5L,5L,0L,1L,4L,4L,5L,5L,1L,2L,3L,8L,3L,3L,6L,5L,6L,8L,5L,2L,8L,3L,9L,6L,2L,9L,2L,4L,2L,6L,1L,5L,8L,8L,1L,4L,2L,2L,9L,4L,9L,8L,7L,3L,8L,9L,1L,9L,5L,3L,3L,5L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195284Inst : IEnumerable<long>
{
public static readonly long[] Value=A195284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195284.Bytes);
public long this[int i]=>Value[i];

public static A195284Inst Instance=new A195284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195285
{
public static readonly long[] Value={ 5L,9L,7L,7L,2L,3L,3L,5L,0L,7L,5L,2L,0L,7L,4L,9L,4L,5L,7L,2L,3L,2L,0L,6L,6L,7L,8L,8L,9L,7L,7L,0L,7L,0L,6L,2L,3L,6L,6L,0L,8L,3L,2L,3L,9L,1L,5L,9L,6L,3L,0L,5L,3L,5L,1L,5L,5L,2L,1L,6L,1L,0L,7L,4L,9L,3L,3L,6L,5L,1L,8L,1L,2L,4L,9L,0L,1L,4L,8L,1L,5L,9L,4L,5L,3L,9L,0L,6L,8L,4L,6L,6L,2L,7L,9L,9L,9L,1L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195285Inst : IEnumerable<long>
{
public static readonly long[] Value=A195285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195285.Bytes);
public long this[int i]=>Value[i];

public static A195285Inst Instance=new A195285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195286
{
public static readonly long[] Value={ 4L,0L,7L,9L,2L,1L,5L,6L,1L,0L,8L,7L,4L,2L,2L,7L,8L,6L,4L,0L,2L,2L,5L,7L,9L,2L,8L,7L,2L,1L,8L,2L,2L,5L,5L,9L,1L,6L,5L,1L,0L,1L,6L,7L,5L,6L,8L,7L,9L,6L,7L,7L,1L,2L,6L,0L,6L,7L,9L,7L,6L,6L,4L,3L,5L,4L,0L,7L,4L,6L,9L,0L,5L,6L,4L,9L,7L,7L,9L,3L,5L,6L,4L,7L,0L,6L,7L,9L,0L,8L,0L,8L,7L,5L,1L,4L,5L,6L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195286Inst : IEnumerable<long>
{
public static readonly long[] Value=A195286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195286.Bytes);
public long this[int i]=>Value[i];

public static A195286Inst Instance=new A195286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195287
{
public static readonly ulong[] Value={ 2L,0L,4L,8L,232L,448L,18224L,35424L,1036064L,2025472L,130960832L,257072000L,689908475264L,1358275350528L,8031885897472L,15847920983552L,7981032500085248L,15774370258485248L,12448755354530366464UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195287Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A195287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195287.Bytes);
public ulong this[int i]=>Value[i];

public static A195287Inst Instance=new A195287Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195288
{
public static readonly long[] Value={ 4L,8L,0L,7L,4L,0L,1L,7L,0L,0L,6L,1L,8L,6L,5L,2L,3L,9L,0L,8L,2L,5L,6L,2L,8L,3L,5L,6L,6L,2L,7L,3L,2L,7L,9L,2L,8L,3L,3L,5L,0L,6L,2L,0L,9L,8L,4L,6L,0L,3L,2L,8L,2L,8L,3L,6L,1L,3L,9L,3L,7L,4L,0L,8L,3L,0L,2L,8L,8L,9L,2L,6L,4L,3L,9L,0L,6L,8L,0L,5L,9L,3L,6L,0L,6L,1L,5L,8L,7L,7L,6L,0L,2L,4L,6L,5L,4L,2L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195288Inst : IEnumerable<long>
{
public static readonly long[] Value=A195288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195288.Bytes);
public long this[int i]=>Value[i];

public static A195288Inst Instance=new A195288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195289
{
public static readonly long[] Value={ 4L,8L,4L,7L,8L,2L,3L,8L,5L,3L,6L,6L,1L,7L,5L,3L,4L,8L,3L,3L,5L,1L,6L,5L,4L,1L,8L,0L,2L,2L,8L,1L,1L,5L,2L,7L,8L,0L,8L,8L,2L,5L,5L,4L,5L,2L,2L,8L,2L,5L,9L,9L,2L,3L,4L,1L,2L,9L,5L,4L,4L,3L,3L,4L,6L,0L,2L,1L,8L,8L,6L,9L,4L,6L,2L,9L,6L,2L,9L,3L,6L,8L,4L,9L,2L,7L,9L,5L,9L,9L,8L,0L,7L,0L,1L,2L,2L,0L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195289Inst : IEnumerable<long>
{
public static readonly long[] Value=A195289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195289.Bytes);
public long this[int i]=>Value[i];

public static A195289Inst Instance=new A195289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195290
{
public static readonly long[] Value={ 6L,0L,6L,0L,9L,1L,5L,2L,6L,7L,3L,1L,3L,2L,6L,4L,4L,9L,4L,8L,6L,4L,3L,8L,0L,2L,4L,6L,6L,1L,2L,9L,9L,1L,7L,6L,5L,2L,9L,8L,5L,9L,3L,7L,5L,1L,6L,1L,5L,4L,9L,1L,7L,4L,2L,1L,8L,5L,7L,7L,0L,3L,0L,5L,6L,7L,4L,5L,6L,7L,7L,6L,4L,8L,3L,7L,6L,0L,1L,5L,9L,5L,0L,7L,3L,0L,8L,9L,4L,3L,2L,8L,3L,2L,7L,4L,9L,5L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195290Inst : IEnumerable<long>
{
public static readonly long[] Value=A195290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195290.Bytes);
public long this[int i]=>Value[i];

public static A195290Inst Instance=new A195290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195291
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,9L,10L,11L,13L,14L,15L,17L,18L,19L,21L,22L,23L,25L,26L,27L,29L,30L,31L,33L,34L,35L,37L,38L,39L,41L,42L,43L,45L,46L,47L,49L,50L,51L,53L,54L,55L,57L,58L,59L,61L,62L,63L,65L,66L,67L,69L,70L,71L,73L,74L,75L,77L,78L,79L,81L,82L,83L,85L,86L,87L,89L,90L,91L,93L,94L,95L,97L,98L,99L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195291Inst : IEnumerable<long>
{
public static readonly long[] Value=A195291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195291.Bytes);
public long this[int i]=>Value[i];

public static A195291Inst Instance=new A195291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195292
{
public static readonly long[] Value={ 3L,9L,3L,6L,8L,2L,0L,8L,2L,8L,8L,4L,8L,5L,4L,1L,9L,2L,6L,3L,7L,0L,4L,4L,8L,6L,7L,7L,1L,1L,9L,8L,5L,3L,6L,1L,3L,6L,9L,9L,3L,9L,7L,3L,2L,2L,1L,2L,0L,9L,2L,5L,0L,3L,2L,3L,6L,5L,3L,3L,0L,1L,3L,1L,0L,0L,3L,3L,8L,6L,1L,8L,4L,9L,3L,0L,4L,0L,0L,6L,8L,3L,6L,0L,2L,7L,5L,2L,6L,1L,4L,0L,7L,1L,1L,7L,8L,3L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195292Inst : IEnumerable<long>
{
public static readonly long[] Value=A195292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195292.Bytes);
public long this[int i]=>Value[i];

public static A195292Inst Instance=new A195292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195293
{
public static readonly long[] Value={ 6L,1L,8L,4L,6L,5L,8L,4L,3L,8L,4L,2L,6L,4L,9L,0L,8L,2L,4L,7L,3L,2L,1L,1L,4L,7L,8L,3L,9L,6L,1L,1L,1L,5L,5L,3L,7L,7L,2L,0L,7L,9L,8L,8L,3L,8L,0L,6L,0L,4L,3L,0L,6L,5L,1L,5L,9L,7L,9L,5L,0L,3L,5L,9L,6L,4L,2L,4L,3L,1L,5L,1L,9L,5L,0L,6L,4L,3L,2L,3L,9L,0L,3L,8L,1L,7L,9L,5L,4L,7L,6L,2L,1L,6L,0L,2L,6L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195293Inst : IEnumerable<long>
{
public static readonly long[] Value=A195293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195293.Bytes);
public long this[int i]=>Value[i];

public static A195293Inst Instance=new A195293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195294
{
public static readonly long[] Value={ 101L,313L,2L,3L,11411L,5L,10601L,7L,181L,191L,11L,0L,0L,0L,0L,0L,0L,0L,0L,101L,1311131L,1212121L,131L,11411L,151L,1616161L,1117111L,181L,191L,1120211L,1221221L,72227L,32323L,12421L,3425243L,1126211L,12721L,12821L,1129211L,73037L,313L,73237L,13331L,1134311L,353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195294Inst : IEnumerable<long>
{
public static readonly long[] Value=A195294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195294.Bytes);
public long this[int i]=>Value[i];

public static A195294Inst Instance=new A195294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195295
{
public static readonly long[] Value={ 0L,1L,2L,5L,8L,22L,53L,151L,435L,1314L,4239L,13705L,45746L,153850L,525236L,1817111L,6341424L,22336060L,79287664L,283277225L,1018369893L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195295Inst : IEnumerable<long>
{
public static readonly long[] Value=A195295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195295.Bytes);
public long this[int i]=>Value[i];

public static A195295Inst Instance=new A195295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195296
{
public static readonly long[] Value={ 6L,9L,9L,7L,1L,4L,2L,2L,7L,3L,8L,1L,4L,3L,6L,0L,5L,6L,5L,0L,4L,8L,9L,8L,3L,4L,5L,3L,0L,5L,4L,6L,9L,9L,6L,9L,1L,8L,2L,5L,6L,7L,8L,0L,0L,1L,8L,6L,3L,1L,6L,6L,3L,4L,5L,3L,4L,0L,0L,0L,8L,0L,9L,3L,8L,4L,1L,3L,7L,2L,0L,7L,4L,3L,9L,6L,0L,5L,5L,1L,5L,3L,1L,9L,8L,2L,8L,8L,3L,9L,1L,7L,4L,3L,6L,4L,2L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195296Inst : IEnumerable<long>
{
public static readonly long[] Value=A195296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195296.Bytes);
public long this[int i]=>Value[i];

public static A195296Inst Instance=new A195296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195297
{
public static readonly long[] Value={ 5L,4L,1L,6L,7L,7L,0L,5L,2L,1L,6L,1L,9L,8L,5L,5L,4L,2L,0L,6L,4L,7L,8L,0L,7L,6L,4L,5L,5L,6L,8L,5L,0L,0L,9L,2L,5L,2L,4L,1L,1L,2L,7L,0L,2L,3L,0L,4L,6L,3L,2L,1L,3L,5L,8L,9L,9L,9L,5L,0L,9L,2L,2L,0L,3L,5L,7L,0L,4L,9L,6L,1L,6L,1L,6L,8L,7L,8L,2L,4L,4L,4L,1L,7L,0L,6L,0L,2L,2L,6L,8L,4L,8L,1L,3L,7L,9L,5L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195297Inst : IEnumerable<long>
{
public static readonly long[] Value=A195297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195297.Bytes);
public long this[int i]=>Value[i];

public static A195297Inst Instance=new A195297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195298
{
public static readonly long[] Value={ 2L,0L,8L,0L,0L,3L,1L,3L,9L,6L,9L,3L,7L,2L,9L,0L,9L,3L,4L,5L,9L,9L,2L,2L,9L,2L,8L,3L,2L,9L,3L,4L,3L,7L,9L,4L,1L,0L,7L,9L,3L,3L,4L,1L,9L,5L,0L,2L,1L,8L,5L,0L,6L,9L,6L,6L,7L,9L,4L,8L,0L,5L,1L,1L,7L,9L,5L,4L,6L,1L,6L,3L,9L,6L,0L,7L,1L,1L,5L,7L,6L,6L,6L,6L,5L,5L,9L,4L,1L,1L,6L,8L,8L,0L,2L,6L,4L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195298Inst : IEnumerable<long>
{
public static readonly long[] Value=A195298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195298.Bytes);
public long this[int i]=>Value[i];

public static A195298Inst Instance=new A195298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195299
{
public static readonly long[] Value={ 2L,2L,8L,7L,9L,1L,7L,8L,0L,9L,1L,0L,8L,2L,2L,2L,2L,9L,2L,3L,9L,9L,4L,1L,5L,4L,3L,6L,4L,8L,8L,3L,4L,4L,4L,3L,9L,7L,1L,0L,8L,4L,4L,7L,6L,0L,7L,7L,5L,9L,9L,0L,4L,2L,7L,1L,6L,5L,4L,6L,8L,0L,0L,9L,1L,9L,9L,5L,6L,9L,3L,6L,1L,7L,7L,7L,2L,8L,6L,3L,9L,4L,2L,2L,8L,7L,8L,9L,5L,5L,8L,5L,2L,3L,9L,0L,3L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195299Inst : IEnumerable<long>
{
public static readonly long[] Value=A195299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195299.Bytes);
public long this[int i]=>Value[i];

public static A195299Inst Instance=new A195299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195300
{
public static readonly long[] Value={ 5L,7L,1L,1L,4L,0L,9L,7L,8L,6L,3L,4L,2L,6L,2L,1L,6L,8L,6L,1L,9L,2L,0L,8L,1L,0L,8L,5L,8L,7L,3L,9L,5L,1L,2L,2L,0L,5L,7L,8L,9L,8L,6L,2L,7L,5L,0L,4L,1L,0L,6L,1L,3L,2L,5L,5L,5L,4L,2L,1L,2L,6L,9L,6L,0L,1L,3L,0L,9L,2L,0L,3L,0L,4L,0L,3L,6L,6L,3L,6L,8L,1L,4L,2L,4L,7L,2L,9L,1L,6L,1L,9L,5L,1L,9L,4L,5L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195300Inst : IEnumerable<long>
{
public static readonly long[] Value=A195300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195300.Bytes);
public long this[int i]=>Value[i];

public static A195300Inst Instance=new A195300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195301
{
public static readonly long[] Value={ 6L,3L,4L,0L,5L,0L,6L,7L,1L,1L,2L,4L,4L,2L,8L,8L,5L,0L,6L,8L,5L,0L,5L,2L,8L,8L,5L,3L,4L,3L,9L,6L,2L,2L,1L,3L,1L,9L,8L,9L,1L,0L,0L,0L,3L,5L,6L,9L,5L,5L,3L,6L,1L,2L,9L,8L,9L,9L,8L,5L,8L,4L,0L,1L,0L,1L,7L,7L,1L,7L,5L,8L,3L,2L,3L,6L,9L,1L,8L,9L,6L,9L,6L,3L,2L,4L,9L,4L,5L,6L,6L,6L,3L,1L,1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195301Inst : IEnumerable<long>
{
public static readonly long[] Value=A195301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195301.Bytes);
public long this[int i]=>Value[i];

public static A195301Inst Instance=new A195301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195302
{
public static readonly long[] Value={ 2L,3L,5L,7L,211L,223L,229L,241L,271L,283L,311L,313L,317L,331L,337L,347L,353L,359L,367L,373L,379L,383L,389L,397L,523L,541L,547L,571L,719L,743L,761L,773L,797L,211151L,211193L,211199L,211229L,211241L,211271L,211283L,211313L,211349L,211373L,211433L,211457L,211499L,211571L,211619L,211643L,211661L,211691L,211727L,211811L,211859L,211877L,211997L,213131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195302Inst : IEnumerable<long>
{
public static readonly long[] Value=A195302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195302.Bytes);
public long this[int i]=>Value[i];

public static A195302Inst Instance=new A195302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195303
{
public static readonly long[] Value={ 6L,1L,4L,0L,5L,8L,9L,7L,1L,0L,3L,2L,2L,1L,2L,6L,1L,1L,5L,4L,6L,3L,8L,4L,8L,9L,2L,5L,3L,9L,3L,8L,5L,4L,0L,8L,2L,6L,0L,3L,6L,7L,3L,8L,6L,8L,9L,6L,9L,9L,6L,8L,9L,2L,7L,6L,4L,7L,9L,4L,1L,9L,1L,7L,6L,7L,3L,2L,8L,5L,7L,4L,5L,1L,7L,0L,3L,8L,0L,3L,8L,4L,9L,2L,8L,5L,5L,8L,3L,1L,6L,0L,3L,1L,2L,0L,5L,5L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195303Inst : IEnumerable<long>
{
public static readonly long[] Value=A195303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195303.Bytes);
public long this[int i]=>Value[i];

public static A195303Inst Instance=new A195303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195304
{
public static readonly long[] Value={ 1L,8L,9L,6L,3L,0L,0L,5L,6L,6L,3L,0L,9L,2L,0L,2L,0L,1L,4L,7L,5L,3L,8L,6L,7L,2L,0L,3L,6L,5L,4L,8L,1L,9L,9L,1L,7L,0L,8L,0L,1L,0L,3L,2L,8L,2L,9L,8L,1L,9L,2L,8L,6L,6L,6L,4L,1L,0L,2L,7L,8L,4L,3L,9L,4L,4L,4L,2L,9L,7L,6L,3L,7L,7L,2L,5L,4L,6L,2L,9L,2L,1L,1L,7L,4L,3L,4L,9L,5L,1L,7L,5L,2L,6L,6L,7L,2L,1L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195304Inst : IEnumerable<long>
{
public static readonly long[] Value=A195304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195304.Bytes);
public long this[int i]=>Value[i];

public static A195304Inst Instance=new A195304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195305
{
public static readonly long[] Value={ 3L,2L,8L,8L,5L,5L,4L,1L,8L,5L,1L,4L,5L,0L,3L,0L,0L,6L,4L,1L,8L,2L,8L,4L,8L,1L,0L,8L,8L,9L,6L,3L,5L,1L,4L,1L,4L,3L,6L,1L,5L,8L,3L,8L,2L,3L,0L,3L,0L,2L,0L,1L,0L,6L,8L,3L,5L,6L,7L,4L,9L,8L,8L,8L,1L,7L,1L,4L,7L,4L,0L,4L,6L,4L,1L,6L,1L,2L,7L,9L,2L,6L,9L,2L,1L,8L,7L,6L,8L,0L,7L,2L,8L,8L,8L,3L,4L,5L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195305Inst : IEnumerable<long>
{
public static readonly long[] Value=A195305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195305.Bytes);
public long this[int i]=>Value[i];

public static A195305Inst Instance=new A195305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195306
{
public static readonly long[] Value={ 2L,3L,7L,2L,5L,9L,1L,6L,7L,4L,9L,5L,6L,7L,4L,9L,3L,0L,8L,0L,7L,5L,0L,9L,8L,5L,2L,9L,9L,4L,0L,3L,2L,0L,1L,5L,0L,0L,5L,7L,3L,6L,1L,3L,2L,7L,0L,9L,0L,4L,6L,2L,3L,9L,2L,7L,4L,9L,3L,7L,2L,8L,5L,0L,0L,3L,7L,0L,0L,1L,9L,2L,5L,1L,5L,1L,9L,5L,1L,6L,9L,6L,7L,1L,2L,1L,8L,5L,7L,5L,2L,0L,3L,1L,2L,4L,7L,1L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195306Inst : IEnumerable<long>
{
public static readonly long[] Value=A195306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195306.Bytes);
public long this[int i]=>Value[i];

public static A195306Inst Instance=new A195306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195307
{
public static readonly long[] Value={ 1L,2L,6L,12L,60L,180L,360L,420L,840L,1260L,2520L,5040L,13860L,27720L,55440L,83160L,166320L,277200L,360360L,720720L,1081080L,2162160L,2827440L,4324320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195307Inst : IEnumerable<long>
{
public static readonly long[] Value=A195307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195307.Bytes);
public long this[int i]=>Value[i];

public static A195307Inst Instance=new A195307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195308
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,5L,7L,11L,15L,22L,30L,43L,58L,81L,109L,150L,200L,271L,359L,481L,633L,838L,1095L,1438L,1867L,2430L,3136L,4053L,5200L,6676L,8519L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195308Inst : IEnumerable<long>
{
public static readonly long[] Value=A195308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195308.Bytes);
public long this[int i]=>Value[i];

public static A195308Inst Instance=new A195308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195309
{
public static readonly long[] Value={ 1L,9L,11L,45L,39L,126L,94L,270L,185L,495L,321L,819L,511L,1260L,764L,1836L,1089L,2565L,1495L,3465L,1991L,4554L,2586L,5850L,3289L,7371L,4109L,9135L,5055L,11160L,6136L,13464L,7361L,16065L,8739L,18981L,10279L,22230L,11990L,25830L,13881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195309Inst : IEnumerable<long>
{
public static readonly long[] Value=A195309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195309.Bytes);
public long this[int i]=>Value[i];

public static A195309Inst Instance=new A195309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195310
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,3L,2L,4L,3L,0L,5L,4L,1L,6L,5L,2L,0L,7L,6L,3L,1L,8L,7L,4L,2L,9L,8L,5L,3L,10L,9L,6L,4L,11L,10L,7L,5L,0L,12L,11L,8L,6L,1L,13L,12L,9L,7L,2L,14L,13L,10L,8L,3L,0L,15L,14L,11L,9L,4L,1L,16L,15L,12L,10L,5L,2L,17L,16L,13L,11L,6L,3L,18L,17L,14L,12L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195310Inst : IEnumerable<long>
{
public static readonly long[] Value=A195310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195310.Bytes);
public long this[int i]=>Value[i];

public static A195310Inst Instance=new A195310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195311
{
public static readonly long[] Value={ 0L,1L,3L,5L,7L,10L,13L,17L,21L,25L,29L,33L,38L,43L,48L,54L,60L,66L,72L,78L,84L,90L,97L,104L,111L,118L,126L,134L,142L,150L,158L,166L,174L,182L,190L,199L,208L,217L,226L,235L,245L,255L,265L,275L,285L,295L,305L,315L,325L,335L,345L,356L,367L,378L,389L,400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195311Inst : IEnumerable<long>
{
public static readonly long[] Value=A195311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195311.Bytes);
public long this[int i]=>Value[i];

public static A195311Inst Instance=new A195311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195312
{
public static readonly long[] Value={ 0L,1L,9L,3L,18L,5L,27L,7L,36L,9L,45L,11L,54L,13L,63L,15L,72L,17L,81L,19L,90L,21L,99L,23L,108L,25L,117L,27L,126L,29L,135L,31L,144L,33L,153L,35L,162L,37L,171L,39L,180L,41L,189L,43L,198L,45L,207L,47L,216L,49L,225L,51L,234L,53L,243L,55L,252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195312Inst : IEnumerable<long>
{
public static readonly long[] Value=A195312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195312.Bytes);
public long this[int i]=>Value[i];

public static A195312Inst Instance=new A195312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195313
{
public static readonly long[] Value={ 0L,1L,10L,13L,31L,36L,63L,70L,106L,115L,160L,171L,225L,238L,301L,316L,388L,405L,486L,505L,595L,616L,715L,738L,846L,871L,988L,1015L,1141L,1170L,1305L,1336L,1480L,1513L,1666L,1701L,1863L,1900L,2071L,2110L,2290L,2331L,2520L,2563L,2761L,2806L,3013L,3060L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195313Inst : IEnumerable<long>
{
public static readonly long[] Value=A195313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195313.Bytes);
public long this[int i]=>Value[i];

public static A195313Inst Instance=new A195313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195314
{
public static readonly long[] Value={ 1L,29L,85L,169L,281L,421L,589L,785L,1009L,1261L,1541L,1849L,2185L,2549L,2941L,3361L,3809L,4285L,4789L,5321L,5881L,6469L,7085L,7729L,8401L,9101L,9829L,10585L,11369L,12181L,13021L,13889L,14785L,15709L,16661L,17641L,18649L,19685L,20749L,21841L,22961L,24109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195314Inst : IEnumerable<long>
{
public static readonly long[] Value=A195314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195314.Bytes);
public long this[int i]=>Value[i];

public static A195314Inst Instance=new A195314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195315
{
public static readonly long[] Value={ 1L,33L,97L,193L,321L,481L,673L,897L,1153L,1441L,1761L,2113L,2497L,2913L,3361L,3841L,4353L,4897L,5473L,6081L,6721L,7393L,8097L,8833L,9601L,10401L,11233L,12097L,12993L,13921L,14881L,15873L,16897L,17953L,19041L,20161L,21313L,22497L,23713L,24961L,26241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195315Inst : IEnumerable<long>
{
public static readonly long[] Value=A195315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195315.Bytes);
public long this[int i]=>Value[i];

public static A195315Inst Instance=new A195315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195316
{
public static readonly long[] Value={ 1L,37L,109L,217L,361L,541L,757L,1009L,1297L,1621L,1981L,2377L,2809L,3277L,3781L,4321L,4897L,5509L,6157L,6841L,7561L,8317L,9109L,9937L,10801L,11701L,12637L,13609L,14617L,15661L,16741L,17857L,19009L,20197L,21421L,22681L,23977L,25309L,26677L,28081L,29521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195316Inst : IEnumerable<long>
{
public static readonly long[] Value=A195316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195316.Bytes);
public long this[int i]=>Value[i];

public static A195316Inst Instance=new A195316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195317
{
public static readonly long[] Value={ 1L,41L,121L,241L,401L,601L,841L,1121L,1441L,1801L,2201L,2641L,3121L,3641L,4201L,4801L,5441L,6121L,6841L,7601L,8401L,9241L,10121L,11041L,12001L,13001L,14041L,15121L,16241L,17401L,18601L,19841L,21121L,22441L,23801L,25201L,26641L,28121L,29641L,31201L,32801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195317Inst : IEnumerable<long>
{
public static readonly long[] Value=A195317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195317.Bytes);
public long this[int i]=>Value[i];

public static A195317Inst Instance=new A195317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195318
{
public static readonly long[] Value={ 1L,45L,133L,265L,441L,661L,925L,1233L,1585L,1981L,2421L,2905L,3433L,4005L,4621L,5281L,5985L,6733L,7525L,8361L,9241L,10165L,11133L,12145L,13201L,14301L,15445L,16633L,17865L,19141L,20461L,21825L,23233L,24685L,26181L,27721L,29305L,30933L,32605L,34321L,36081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195318Inst : IEnumerable<long>
{
public static readonly long[] Value=A195318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195318.Bytes);
public long this[int i]=>Value[i];

public static A195318Inst Instance=new A195318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195319
{
public static readonly long[] Value={ 0L,9L,30L,63L,108L,165L,234L,315L,408L,513L,630L,759L,900L,1053L,1218L,1395L,1584L,1785L,1998L,2223L,2460L,2709L,2970L,3243L,3528L,3825L,4134L,4455L,4788L,5133L,5490L,5859L,6240L,6633L,7038L,7455L,7884L,8325L,8778L,9243L,9720L,10209L,10710L,11223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195319Inst : IEnumerable<long>
{
public static readonly long[] Value=A195319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195319.Bytes);
public long this[int i]=>Value[i];

public static A195319Inst Instance=new A195319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195320
{
public static readonly long[] Value={ 0L,7L,42L,105L,196L,315L,462L,637L,840L,1071L,1330L,1617L,1932L,2275L,2646L,3045L,3472L,3927L,4410L,4921L,5460L,6027L,6622L,7245L,7896L,8575L,9282L,10017L,10780L,11571L,12390L,13237L,14112L,15015L,15946L,16905L,17892L,18907L,19950L,21021L,22120L,23247L,24402L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195320Inst : IEnumerable<long>
{
public static readonly long[] Value=A195320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195320.Bytes);
public long this[int i]=>Value[i];

public static A195320Inst Instance=new A195320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195321
{
public static readonly long[] Value={ 0L,18L,72L,162L,288L,450L,648L,882L,1152L,1458L,1800L,2178L,2592L,3042L,3528L,4050L,4608L,5202L,5832L,6498L,7200L,7938L,8712L,9522L,10368L,11250L,12168L,13122L,14112L,15138L,16200L,17298L,18432L,19602L,20808L,22050L,23328L,24642L,25992L,27378L,28800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195321Inst : IEnumerable<long>
{
public static readonly long[] Value=A195321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195321.Bytes);
public long this[int i]=>Value[i];

public static A195321Inst Instance=new A195321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195322
{
public static readonly long[] Value={ 0L,20L,80L,180L,320L,500L,720L,980L,1280L,1620L,2000L,2420L,2880L,3380L,3920L,4500L,5120L,5780L,6480L,7220L,8000L,8820L,9680L,10580L,11520L,12500L,13520L,14580L,15680L,16820L,18000L,19220L,20480L,21780L,23120L,24500L,25920L,27380L,28880L,30420L,32000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195322Inst : IEnumerable<long>
{
public static readonly long[] Value=A195322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195322.Bytes);
public long this[int i]=>Value[i];

public static A195322Inst Instance=new A195322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195323
{
public static readonly long[] Value={ 0L,22L,88L,198L,352L,550L,792L,1078L,1408L,1782L,2200L,2662L,3168L,3718L,4312L,4950L,5632L,6358L,7128L,7942L,8800L,9702L,10648L,11638L,12672L,13750L,14872L,16038L,17248L,18502L,19800L,21142L,22528L,23958L,25432L,26950L,28512L,30118L,31768L,33462L,35200L,36982L,38808L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195323Inst : IEnumerable<long>
{
public static readonly long[] Value=A195323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195323.Bytes);
public long this[int i]=>Value[i];

public static A195323Inst Instance=new A195323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195324
{
public static readonly long[] Value={ 2L,4L,6L,32L,56L,92L,98L,122L,128L,140L,152L,176L,194L,212L,224L,242L,254L,260L,272L,296L,302L,308L,326L,332L,368L,392L,398L,410L,422L,434L,452L,458L,476L,488L,500L,512L,518L,524L,536L,542L,560L,572L,596L,602L,632L,644L,656L,662L,674L,686L,692L,704L,710L,728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195324Inst : IEnumerable<long>
{
public static readonly long[] Value=A195324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195324.Bytes);
public long this[int i]=>Value[i];

public static A195324Inst Instance=new A195324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195325
{
public static readonly long[] Value={ 2L,59L,71L,29L,59L,149L,191L,641L,149L,347L,809L,461L,3371L,1487L,857L,1301L,1877L,5849L,4721L,9239L,4271L,1619L,1481L,20507L,20981L,32117L,13337L,19379L,24977L,48779L,20441L,25301L,5651L,37991L,17747L,43577L,176777L,145757L,191249L,84809L,150209L,11717L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195325Inst : IEnumerable<long>
{
public static readonly long[] Value=A195325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195325.Bytes);
public long this[int i]=>Value[i];

public static A195325Inst Instance=new A195325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195326
{
public static readonly long[] Value={ 0L,2L,2L,7L,7L,47L,47L,5923L,5923L,426457L,426457L,15636757L,15636757L,7318002277L,7318002277L,1536780478171L,1536780478171L,603180793741L,603180793741L,142957467201379447L,142957467201379447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195326Inst : IEnumerable<long>
{
public static readonly long[] Value=A195326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195326.Bytes);
public long this[int i]=>Value[i];

public static A195326Inst Instance=new A195326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195327
{
public static readonly long[] Value={ 2L,4L,8L,16L,36L,40L,48L,100L,144L,324L,484L,900L,1296L,1764L,2116L,2704L,3600L,6084L,9216L,13728L,19044L,24336L,30000L,39204L,39360L,44100L,51984L,63888L,72900L,81648L,93636L,108900L,112896L,133956L,142884L,191844L,229376L,248004L,269568L,298116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195327Inst : IEnumerable<long>
{
public static readonly long[] Value=A195327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195327.Bytes);
public long this[int i]=>Value[i];

public static A195327Inst Instance=new A195327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195328
{
public static readonly long[] Value={ 2L,4L,6L,18L,50L,54L,162L,242L,450L,486L,882L,1058L,1782L,3042L,3078L,4050L,5202L,9522L,19602L,22050L,36450L,46818L,54450L,66978L,71442L,95922L,124002L,149058L,183618L,190962L,238050L,240570L,263538L,277830L,328050L,466578L,684450L,816642L,977202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195328Inst : IEnumerable<long>
{
public static readonly long[] Value=A195328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195328.Bytes);
public long this[int i]=>Value[i];

public static A195328Inst Instance=new A195328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195329
{
public static readonly long[] Value={ 2L,59L,71L,149L,191L,641L,809L,3371L,5849L,9239L,20507L,20981L,32117L,48779L,176777L,191249L,204509L,211061L,223679L,245129L,358877L,654161L,2342771L,3053291L,4297961L,4755347L,6750221L,8019509L,9750371L,10196759L,11237981L,23367077L,34910219L,93929219L,186635747L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195329Inst : IEnumerable<long>
{
public static readonly long[] Value=A195329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195329.Bytes);
public long this[int i]=>Value[i];

public static A195329Inst Instance=new A195329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195330
{
public static readonly long[] Value={ 32L,64L,81L,121L,125L,128L,169L,243L,256L,289L,320L,343L,361L,375L,384L,405L,448L,486L,512L,529L,567L,625L,640L,686L,729L,768L,841L,875L,896L,961L,1024L,1029L,1215L,1250L,1280L,1331L,1369L,1458L,1536L,1681L,1701L,1715L,1792L,1849L,1875L,2048L,2187L,2197L,2209L,2401L,2430L,2500L,2560L,2592L,2656L,2662L,2738L,2744L,2752L,2809L,2816L,2848L,2916L,2944L,3008L,3072L,3104L,3125L,3136L,3200L,3328L,3362L,3375L,3392L,3402L,3430L,3456L,3481L,3483L,3584L,3645L,3698L,3712L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195330Inst : IEnumerable<long>
{
public static readonly long[] Value=A195330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195330.Bytes);
public long this[int i]=>Value[i];

public static A195330Inst Instance=new A195330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195331
{
public static readonly long[] Value={ 25L,26L,34L,112L,53L,27L,132L,35L,28L,172L,265L,73L,192L,353L,273L,345L,267L,235L,29L,232L,347L,54L,275L,273L,36L,283L,292L,537L,277L,312L,210L,373L,355L,254L,285L,113L,372L,236L,293L,412L,357L,573L,287L,432L,354L,211L,37L,133L,472L,74L,2355L,2254L,295L,2534L,2583L,2113L,2372L,2373L,2643L,532L,2811L,2589L,2236L,2723L,2647L,2103L,2597L,55L,2672L,2752L,2813L,2412L,3353L,2653L,2357L,2573L,2733L,592L,3443L,297L,365L,2432L,2729L,612L,2354L,2659L,3447L,2835L,2435L,2661L,2731L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195331Inst : IEnumerable<long>
{
public static readonly long[] Value=A195331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195331.Bytes);
public long this[int i]=>Value[i];

public static A195331Inst Instance=new A195331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195332
{
public static readonly long[] Value={ 9L,18L,36L,72L,121L,144L,242L,288L,484L,576L,968L,1152L,1936L,2304L,3872L,4608L,7744L,9216L,15488L,18432L,30976L,36481L,36864L,61952L,72361L,72962L,73728L,123904L,144722L,145924L,146689L,147456L,247808L,259081L,289444L,291848L,293378L,294912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195332Inst : IEnumerable<long>
{
public static readonly long[] Value=A195332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195332.Bytes);
public long this[int i]=>Value[i];

public static A195332Inst Instance=new A195332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195333
{
public static readonly long[] Value={ 1L,2L,4L,6L,25L,27L,33L,42L,221L,274L,581L,1957L,3125L,11406L,47058L,823543L,1535573L,5056941L,19246541L,19571621L,36861842L,50330577L,2590282517L,45546909393L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195333Inst : IEnumerable<long>
{
public static readonly long[] Value=A195333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195333.Bytes);
public long this[int i]=>Value[i];

public static A195333Inst Instance=new A195333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195334
{
public static readonly long[] Value={ 4L,8L,18L,32L,50L,128L,578L,1458L,3362L,4802L,6962L,8192L,10082L,15842L,20402L,31250L,34322L,55778L,57122L,59858L,131072L,167042L,171698L,293378L,524288L,559682L,916658L,982802L,1062882L,1104098L,1158242L,1195058L,1367858L,1407842L,1414562L,1468898L,1659842L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195334Inst : IEnumerable<long>
{
public static readonly long[] Value=A195334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195334.Bytes);
public long this[int i]=>Value[i];

public static A195334Inst Instance=new A195334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195335
{
public static readonly BigInteger[] Value={ 2L,211L,211151L,2111511013L,211151101310867L,BigInteger.Parse("211151101310867100673"),BigInteger.Parse("2111511013108671006731000357"),BigInteger.Parse("211151101310867100673100035710000931"),BigInteger.Parse("211151101310867100673100035710000931100000213"),BigInteger.Parse("2111511013108671006731000357100009311000002131000000901"),BigInteger.Parse("211151101310867100673100035710000931100000213100000090110000001797") };
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
public class A195335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195335Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195335.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195335Inst Instance=new A195335Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195336
{
public static readonly long[] Value={ 8L,6L,2L,150L,96L,324L,6L,1518L,174L,168L,21384L,18L,20754L,2988L,2424L,8196L,3786L,14952L,34056L,48L,1620L,8256L,31344L,1176L,123360L,147456L,28650L,132L,90L,12834L,81126L,11790L,2340L,9702L,11496L,33000L,10716L,66954L,6816L,234L,109956L,3012L,6744L,117654L,19950L,26550L,8226L,40584L,23640L,30660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195336Inst : IEnumerable<long>
{
public static readonly long[] Value=A195336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195336.Bytes);
public long this[int i]=>Value[i];

public static A195336Inst Instance=new A195336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195337
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,38L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195337Inst : IEnumerable<long>
{
public static readonly long[] Value=A195337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195337.Bytes);
public long this[int i]=>Value[i];

public static A195337Inst Instance=new A195337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195338
{
public static readonly long[] Value={ 1L,2L,6L,12L,180L,360L,7560L,15120L,226800L,453600L,14968800L,29937600L,40864824000L,81729648000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195338Inst : IEnumerable<long>
{
public static readonly long[] Value=A195338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195338.Bytes);
public long this[int i]=>Value[i];

public static A195338Inst Instance=new A195338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195339
{
public static readonly long[] Value={ 1L,4L,16L,62L,239L,920L,3540L,13620L,52401L,201604L,775636L,2984122L,11480879L,44170640L,169938680L,653808840L,2515413201L,9677604804L,37232862856L,143246816182L,551116641919L,2120323237160L,8157566453420L,31384785713660L,120747379738401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195339Inst : IEnumerable<long>
{
public static readonly long[] Value=A195339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195339.Bytes);
public long this[int i]=>Value[i];

public static A195339Inst Instance=new A195339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195340
{
public static readonly long[] Value={ 7L,8L,4L,9L,2L,9L,6L,8L,4L,7L,6L,4L,4L,3L,4L,9L,4L,5L,2L,0L,1L,7L,2L,4L,3L,6L,3L,4L,5L,6L,7L,3L,5L,6L,7L,2L,6L,9L,4L,4L,4L,6L,1L,4L,2L,6L,3L,0L,2L,4L,6L,6L,8L,1L,0L,5L,5L,5L,4L,4L,8L,5L,5L,7L,9L,2L,3L,8L,2L,7L,5L,4L,4L,9L,4L,8L,3L,1L,3L,4L,8L,5L,5L,6L,0L,9L,0L,1L,9L,1L,7L,7L,8L,0L,0L,9L,1L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195340Inst : IEnumerable<long>
{
public static readonly long[] Value=A195340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195340.Bytes);
public long this[int i]=>Value[i];

public static A195340Inst Instance=new A195340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195341
{
public static readonly long[] Value={ 8L,9L,8L,0L,5L,5L,9L,5L,3L,1L,5L,9L,1L,7L,0L,7L,4L,4L,8L,8L,3L,8L,9L,0L,3L,0L,3L,5L,9L,5L,0L,5L,3L,5L,7L,5L,1L,5L,8L,4L,2L,4L,9L,6L,4L,6L,4L,2L,1L,6L,7L,0L,3L,8L,7L,8L,8L,9L,5L,7L,2L,6L,8L,3L,3L,7L,6L,1L,5L,1L,1L,2L,9L,5L,8L,0L,4L,1L,6L,5L,3L,1L,9L,2L,8L,6L,1L,1L,5L,5L,0L,1L,8L,6L,8L,5L,1L,6L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195341Inst : IEnumerable<long>
{
public static readonly long[] Value=A195341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195341.Bytes);
public long this[int i]=>Value[i];

public static A195341Inst Instance=new A195341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195342
{
public static readonly long[] Value={ 1L,0L,8L,0L,3L,6L,3L,0L,2L,6L,9L,5L,0L,9L,0L,5L,8L,1L,4L,4L,0L,6L,1L,7L,2L,6L,2L,8L,1L,9L,6L,3L,7L,5L,7L,0L,1L,9L,8L,9L,4L,6L,0L,4L,8L,6L,8L,0L,5L,6L,2L,7L,3L,9L,2L,6L,7L,2L,5L,3L,4L,3L,6L,1L,1L,7L,9L,6L,0L,2L,9L,9L,6L,7L,4L,7L,0L,8L,2L,8L,9L,5L,2L,0L,6L,9L,1L,4L,4L,9L,4L,6L,0L,3L,6L,2L,4L,4L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195342Inst : IEnumerable<long>
{
public static readonly long[] Value=A195342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195342.Bytes);
public long this[int i]=>Value[i];

public static A195342Inst Instance=new A195342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195343
{
public static readonly long[] Value={ 5L,2L,7L,7L,5L,2L,6L,3L,3L,6L,0L,7L,7L,1L,0L,3L,5L,6L,1L,1L,8L,2L,1L,4L,2L,9L,0L,2L,9L,3L,9L,4L,9L,5L,2L,2L,3L,8L,0L,4L,0L,2L,1L,3L,5L,2L,9L,2L,0L,4L,0L,2L,9L,8L,3L,5L,1L,1L,8L,0L,3L,5L,8L,9L,3L,0L,7L,0L,2L,0L,3L,8L,2L,2L,5L,3L,2L,5L,8L,9L,8L,0L,5L,2L,1L,1L,3L,4L,1L,4L,7L,7L,9L,8L,1L,3L,4L,3L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195343Inst : IEnumerable<long>
{
public static readonly long[] Value=A195343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195343.Bytes);
public long this[int i]=>Value[i];

public static A195343Inst Instance=new A195343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195344
{
public static readonly long[] Value={ 8L,4L,8L,6L,8L,0L,9L,6L,8L,7L,9L,3L,4L,1L,5L,9L,6L,8L,1L,3L,0L,9L,8L,9L,7L,4L,8L,3L,0L,2L,9L,8L,5L,1L,5L,9L,3L,8L,1L,8L,4L,6L,1L,8L,5L,1L,2L,0L,2L,0L,1L,5L,9L,0L,5L,2L,1L,4L,8L,4L,9L,1L,9L,7L,6L,6L,5L,2L,5L,4L,9L,2L,3L,5L,6L,3L,9L,4L,4L,0L,4L,6L,2L,4L,5L,2L,5L,0L,3L,4L,5L,3L,0L,8L,9L,5L,4L,3L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195344Inst : IEnumerable<long>
{
public static readonly long[] Value=A195344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195344.Bytes);
public long this[int i]=>Value[i];

public static A195344Inst Instance=new A195344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195345
{
public static readonly long[] Value={ 1L,0L,3L,2L,6L,4L,1L,4L,9L,1L,2L,0L,9L,3L,4L,7L,3L,6L,1L,4L,7L,5L,6L,3L,7L,6L,5L,5L,6L,5L,7L,6L,1L,1L,4L,8L,5L,4L,1L,4L,2L,2L,0L,1L,8L,5L,8L,1L,6L,7L,1L,1L,5L,6L,8L,9L,2L,7L,0L,6L,5L,3L,6L,1L,1L,0L,5L,5L,7L,9L,5L,0L,5L,3L,9L,8L,2L,3L,3L,0L,2L,4L,9L,7L,6L,0L,2L,8L,0L,4L,2L,2L,8L,7L,6L,6L,4L,8L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195345Inst : IEnumerable<long>
{
public static readonly long[] Value=A195345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195345.Bytes);
public long this[int i]=>Value[i];

public static A195345Inst Instance=new A195345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195346
{
public static readonly long[] Value={ 1L,1L,8L,4L,7L,1L,8L,2L,9L,4L,4L,9L,2L,8L,0L,0L,8L,0L,2L,3L,8L,8L,4L,0L,7L,5L,5L,9L,3L,7L,6L,2L,3L,9L,8L,4L,3L,3L,9L,7L,4L,5L,0L,7L,8L,2L,2L,8L,4L,7L,4L,0L,8L,4L,4L,1L,6L,4L,9L,2L,4L,4L,6L,1L,1L,4L,1L,8L,8L,8L,0L,6L,2L,5L,7L,2L,8L,1L,8L,3L,5L,6L,5L,7L,2L,7L,2L,1L,3L,2L,0L,5L,5L,3L,0L,0L,1L,7L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195346Inst : IEnumerable<long>
{
public static readonly long[] Value=A195346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195346.Bytes);
public long this[int i]=>Value[i];

public static A195346Inst Instance=new A195346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195347
{
public static readonly long[] Value={ 4L,2L,8L,0L,8L,1L,8L,0L,5L,8L,1L,2L,5L,2L,1L,9L,3L,5L,0L,2L,5L,2L,6L,7L,1L,5L,1L,7L,0L,3L,6L,9L,8L,0L,9L,0L,1L,5L,6L,8L,4L,4L,3L,6L,5L,5L,7L,9L,1L,6L,1L,2L,6L,4L,4L,4L,1L,3L,4L,3L,5L,9L,8L,2L,0L,8L,3L,7L,1L,5L,1L,0L,6L,3L,2L,7L,9L,2L,1L,5L,9L,8L,0L,0L,9L,5L,9L,6L,4L,6L,1L,4L,6L,2L,9L,7L,1L,1L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195347Inst : IEnumerable<long>
{
public static readonly long[] Value=A195347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195347.Bytes);
public long this[int i]=>Value[i];

public static A195347Inst Instance=new A195347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195348
{
public static readonly long[] Value={ 7L,5L,7L,8L,7L,4L,7L,6L,3L,9L,2L,6L,0L,2L,3L,9L,9L,8L,8L,1L,2L,1L,8L,6L,7L,4L,7L,4L,2L,7L,0L,0L,9L,5L,3L,0L,3L,4L,6L,7L,9L,2L,5L,4L,0L,1L,9L,4L,4L,5L,2L,0L,3L,5L,8L,4L,1L,3L,3L,3L,8L,1L,7L,4L,6L,1L,0L,0L,9L,1L,5L,8L,9L,3L,3L,7L,9L,8L,1L,0L,2L,3L,2L,1L,8L,3L,1L,2L,7L,1L,1L,0L,1L,2L,8L,5L,8L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195348Inst : IEnumerable<long>
{
public static readonly long[] Value=A195348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195348.Bytes);
public long this[int i]=>Value[i];

public static A195348Inst Instance=new A195348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195349
{
public static readonly long[] Value={ 1L,7L,19L,41L,57L,64L,68L,133L,145L,149L,164L,235L,267L,291L,317L,336L,358L,419L,433L,503L,528L,566L,599L,612L,659L,726L,801L,927L,1017L,1035L,1077L,1118L,1190L,1206L,1213L,1281L,1297L,1309L,1320L,1323L,1367L,1446L,1473L,1485L,1516L,1595L,1611L,1634L,1941L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195349Inst : IEnumerable<long>
{
public static readonly long[] Value=A195349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195349.Bytes);
public long this[int i]=>Value[i];

public static A195349Inst Instance=new A195349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195350
{
public static readonly long[] Value={ 1L,1L,3L,10L,37L,141L,541L,2080L,8001L,30781L,118423L,455610L,1752877L,6743881L,25945881L,99822160L,384048001L,1477556361L,5684635243L,21870622810L,84143330517L,323726495221L,1245480100021L,4791763116240L,18435456144001L,70927137880741L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195350Inst : IEnumerable<long>
{
public static readonly long[] Value=A195350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195350.Bytes);
public long this[int i]=>Value[i];

public static A195350Inst Instance=new A195350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195351
{
public static readonly long[] Value={ 0L,25L,27L,45L,49L,97L,99L,113L,139L,176L,186L,208L,216L,227L,232L,259L,298L,309L,332L,358L,362L,364L,387L,490L,631L,659L,662L,676L,698L,705L,718L,726L,737L,747L,781L,849L,860L,862L,901L,913L,918L,936L,958L,965L,966L,992L,998L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195351Inst : IEnumerable<long>
{
public static readonly long[] Value=A195351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195351.Bytes);
public long this[int i]=>Value[i];

public static A195351Inst Instance=new A195351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195352
{
public static readonly long[] Value={ 2L,2L,2L,3L,2L,2L,3L,2L,2L,3L,2L,3L,7L,2L,2L,3L,5L,2L,3L,2L,2L,3L,2L,3L,7L,2L,3L,7L,2L,2L,3L,5L,2L,3L,2L,2L,3L,5L,2L,3L,2L,3L,19L,2L,3L,7L,5L,2L,3L,2L,2L,3L,2L,2L,3L,2L,3L,7L,5L,11L,7L,11L,2L,3L,2L,3L,13L,2L,2L,3L,5L,5L,7L,2L,2L,3L,5L,2L,3L,7L,2L,3L,2L,3L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195352Inst : IEnumerable<long>
{
public static readonly long[] Value=A195352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195352.Bytes);
public long this[int i]=>Value[i];

public static A195352Inst Instance=new A195352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195353
{
public static readonly long[] Value={ 7L,13L,31L,91L,451L,539L,1397L,1417L,1777L,3139L,14419L,39751L,77507L,96157L,158173L,214979L,263113L,496723L,1046179L,3415297L,3546371L,4306549L,9456677L,18338311L,45521269L,243377803L,766707661L,1023263789L,8032822531L,92635306249L,151318414531L,352799777983L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195353Inst : IEnumerable<long>
{
public static readonly long[] Value=A195353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195353.Bytes);
public long this[int i]=>Value[i];

public static A195353Inst Instance=new A195353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195354
{
public static readonly long[] Value={ 2L,3L,7L,19L,31L,41L,47L,67L,79L,139L,181L,229L,233L,277L,307L,383L,421L,463L,619L,643L,659L,691L,743L,967L,1231L,1483L,1609L,1931L,2389L,2719L,2791L,2953L,2971L,3079L,3121L,3217L,3301L,3319L,3617L,3719L,3767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195354Inst : IEnumerable<long>
{
public static readonly long[] Value=A195354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195354.Bytes);
public long this[int i]=>Value[i];

public static A195354Inst Instance=new A195354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195355
{
public static readonly long[] Value={ 1L,4L,5L,6L,9L,6L,4L,1L,0L,1L,6L,1L,4L,4L,8L,5L,9L,8L,3L,8L,5L,1L,0L,9L,1L,5L,8L,7L,1L,3L,9L,2L,6L,6L,9L,8L,4L,0L,8L,2L,2L,8L,5L,1L,6L,8L,1L,0L,7L,3L,1L,9L,3L,6L,3L,0L,0L,6L,4L,7L,6L,5L,1L,5L,1L,9L,0L,4L,9L,9L,9L,7L,4L,5L,4L,4L,3L,1L,3L,1L,3L,0L,1L,6L,3L,5L,6L,0L,8L,8L,9L,8L,2L,8L,3L,4L,4L,3L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195355Inst : IEnumerable<long>
{
public static readonly long[] Value=A195355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195355.Bytes);
public long this[int i]=>Value[i];

public static A195355Inst Instance=new A195355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195356
{
public static readonly long[] Value={ 1L,5L,8L,1L,5L,9L,1L,1L,2L,9L,5L,2L,1L,7L,3L,0L,5L,5L,3L,1L,7L,8L,2L,9L,6L,3L,5L,5L,1L,3L,5L,5L,6L,8L,9L,5L,2L,4L,4L,0L,1L,8L,4L,5L,8L,7L,1L,8L,9L,7L,9L,8L,8L,5L,5L,4L,4L,2L,0L,2L,8L,5L,4L,7L,5L,5L,6L,6L,3L,1L,7L,7L,9L,6L,4L,2L,4L,6L,9L,2L,3L,1L,6L,9L,4L,6L,5L,9L,2L,9L,8L,7L,0L,0L,9L,3L,2L,0L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195356Inst : IEnumerable<long>
{
public static readonly long[] Value=A195356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195356.Bytes);
public long this[int i]=>Value[i];

public static A195356Inst Instance=new A195356Inst();

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