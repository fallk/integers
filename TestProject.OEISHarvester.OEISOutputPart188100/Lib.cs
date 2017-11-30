using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A218557
{
public static readonly long[] Value={ 2L,2L,3L,5L,7L,11L,19L,29L,47L,79L,127L,199L,331L,521L,853L,1367L,2207L,3571L,5779L,9349L,15131L,24481L,39607L,64081L,103687L,167771L,271451L,439217L,710663L,1149857L,1860503L,3010349L,4870861L,7881221L,12752053L,20633279L,33385291L,54018521L,87403831L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218557Inst : IEnumerable<long>
{
public static readonly long[] Value=A218557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218557.Bytes);
public long this[int i]=>Value[i];

public static A218557Inst Instance=new A218557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218558
{
public static readonly long[] Value={ 8L,12L,27L,42L,42L,52L,63L,75L,92L,92L,102L,114L,124L,138L,147L,153L,164L,171L,182L,195L,207L,212L,222L,231L,242L,255L,261L,273L,282L,292L,310L,316L,322L,332L,343L,354L,363L,374L,385L,399L,402L,412L,423L,434L,442L,452L,465L,474L,483L,494L,506L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218558Inst : IEnumerable<long>
{
public static readonly long[] Value=A218558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218558.Bytes);
public long this[int i]=>Value[i];

public static A218558Inst Instance=new A218558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218559
{
public static readonly BigInteger[] Value={ 0L,6L,714L,1047188L,30515132780L,21936856591278330L,BigInteger.Parse("459986443452971306412268"),BigInteger.Parse("324518550895166392891543292552264"),BigInteger.Parse("8727963565271662417355532872177263437534624"),BigInteger.Parse("9999999999888888888777777776666666555555444443333222110") };
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
public class A218559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218559Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218559.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218559Inst Instance=new A218559Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218560
{
public static readonly long[] Value={ 0L,1L,2L,9L,10L,12L,14L,16L,17L,18L,20L,22L,23L,24L,25L,248L,250L,251L,254L,257L,258L,259L,262L,263L,264L,265L,267L,269L,272L,275L,276L,277L,281L,285L,287L,288L,289L,291L,293L,295L,296L,298L,299L,300L,301L,303L,305L,306L,307L,309L,311L,313L,314L,315L,317L,319L,320L,321L,322L,326L,329L,330L,331L,335L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218560Inst : IEnumerable<long>
{
public static readonly long[] Value=A218560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218560.Bytes);
public long this[int i]=>Value[i];

public static A218560Inst Instance=new A218560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218561
{
public static readonly long[] Value={ 29L,71L,137L,197L,239L,269L,347L,419L,431L,641L,659L,809L,821L,1061L,1091L,1151L,1289L,1489L,1607L,1721L,1783L,1877L,1949L,1993L,2083L,2141L,2267L,2339L,2381L,2389L,2549L,2729L,2801L,2833L,2969L,2999L,3019L,3041L,3217L,3253L,3299L,3329L,3389L,3461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218561Inst : IEnumerable<long>
{
public static readonly long[] Value=A218561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218561.Bytes);
public long this[int i]=>Value[i];

public static A218561Inst Instance=new A218561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218562
{
public static readonly long[] Value={ 57L,68L,182L,193L,239L,307L,318L,432L,443L,557L,568L,682L,693L,807L,818L,932L,943L,1057L,1068L,1182L,1193L,1307L,1318L,1432L,1443L,1557L,1568L,1682L,1693L,1807L,1818L,1932L,1943L,1958L,1985L,2057L,2068L,2182L,2193L,2307L,2318L,2432L,2436L,2443L,2557L,2568L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218562Inst : IEnumerable<long>
{
public static readonly long[] Value=A218562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218562.Bytes);
public long this[int i]=>Value[i];

public static A218562Inst Instance=new A218562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218563
{
public static readonly long[] Value={ 182L,239L,443L,807L,1068L,1432L,1693L,2057L,2318L,2682L,2943L,3307L,3568L,3932L,4193L,4557L,4818L,5182L,5443L,5807L,6068L,6432L,6693L,7057L,7318L,7682L,7943L,8307L,8568L,8932L,9193L,9557L,9818L,10182L,10443L,10807L,11068L,11432L,11693L,12057L,12318L,12682L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218563Inst : IEnumerable<long>
{
public static readonly long[] Value=A218563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218563.Bytes);
public long this[int i]=>Value[i];

public static A218563Inst Instance=new A218563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218564
{
public static readonly long[] Value={ 1068L,2057L,4193L,5182L,7318L,8307L,10443L,11432L,13568L,14557L,16693L,17682L,19818L,20807L,22943L,23932L,26068L,27057L,29193L,30182L,32318L,33307L,35443L,36432L,38568L,39557L,41693L,42682L,44818L,45807L,47943L,48932L,51068L,52057L,54193L,55182L,57318L,58307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218564Inst : IEnumerable<long>
{
public static readonly long[] Value=A218564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218564.Bytes);
public long this[int i]=>Value[i];

public static A218564Inst Instance=new A218564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218565
{
public static readonly long[] Value={ 1068L,14557L,16693L,30182L,32318L,45807L,47943L,61432L,63568L,77057L,79193L,92682L,94818L,108307L,110443L,123932L,126068L,139557L,141693L,155182L,157318L,170807L,172943L,186432L,188568L,202057L,204193L,217682L,219818L,233307L,235443L,248932L,251068L,264557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218565Inst : IEnumerable<long>
{
public static readonly long[] Value=A218565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218565.Bytes);
public long this[int i]=>Value[i];

public static A218565Inst Instance=new A218565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218566
{
public static readonly BigInteger[] Value={ 0L,1L,3L,2L,12L,240L,3L,27L,1080L,226800L,4L,48L,2880L,1209600L,3657830400L,5L,75L,6000L,3780000L,22861440000L,1267438233600000L,6L,108L,10800L,9072000L,82301184000L,9125555281920000L,BigInteger.Parse("11274806061917798400000") };
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
public class A218566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218566Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218566.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218566Inst Instance=new A218566Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218567
{
public static readonly long[] Value={ 1L,1L,3L,3L,7L,8L,13L,16L,24L,27L,40L,46L,60L,71L,92L,103L,131L,149L,181L,206L,247L,275L,329L,366L,424L,474L,548L,601L,690L,759L,858L,942L,1059L,1152L,1293L,1404L,1555L,1690L,1869L,2013L,2218L,2390L,2614L,2812L,3066L,3282L,3574L,3820L,4131L,4415L,4769L,5071L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218567Inst : IEnumerable<long>
{
public static readonly long[] Value=A218567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218567.Bytes);
public long this[int i]=>Value[i];

public static A218567Inst Instance=new A218567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218568
{
public static readonly long[] Value={ 1L,1L,3L,3L,7L,8L,14L,17L,26L,31L,45L,54L,73L,87L,114L,135L,171L,200L,249L,290L,352L,406L,487L,560L,660L,752L,879L,997L,1153L,1298L,1489L,1671L,1900L,2121L,2397L,2665L,2992L,3311L,3701L,4081L,4535L,4982L,5514L,6042L,6655L,7265L,7977L,8686L,9502L,10314L,11248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218568Inst : IEnumerable<long>
{
public static readonly long[] Value=A218568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218568.Bytes);
public long this[int i]=>Value[i];

public static A218568Inst Instance=new A218568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218569
{
public static readonly long[] Value={ 1L,1L,3L,3L,7L,8L,14L,18L,27L,33L,49L,59L,81L,100L,131L,158L,205L,243L,306L,365L,448L,527L,642L,748L,896L,1042L,1231L,1418L,1667L,1906L,2215L,2527L,2909L,3298L,3781L,4260L,4847L,5446L,6158L,6886L,7756L,8633L,9669L,10738L,11970L,13239L,14713L,16212L,17943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218569Inst : IEnumerable<long>
{
public static readonly long[] Value=A218569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218569.Bytes);
public long this[int i]=>Value[i];

public static A218569Inst Instance=new A218569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218570
{
public static readonly long[] Value={ 1L,1L,3L,3L,7L,8L,14L,18L,28L,34L,51L,63L,86L,108L,144L,175L,229L,278L,351L,425L,529L,630L,775L,919L,1109L,1309L,1565L,1827L,2167L,2518L,2952L,3414L,3975L,4563L,5281L,6036L,6931L,7889L,9012L,10200L,11598L,13078L,14785L,16613L,18704L,20925L,23470L,26174L,29229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218570Inst : IEnumerable<long>
{
public static readonly long[] Value=A218570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218570.Bytes);
public long this[int i]=>Value[i];

public static A218570Inst Instance=new A218570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218571
{
public static readonly long[] Value={ 1L,1L,3L,3L,7L,8L,14L,18L,28L,35L,52L,65L,90L,113L,152L,188L,246L,302L,387L,471L,591L,714L,884L,1059L,1292L,1538L,1857L,2193L,2621L,3077L,3646L,4254L,4999L,5801L,6772L,7815L,9062L,10409L,12002L,13719L,15733L,17909L,20438L,23169L,26318L,29722L,33623L,37833L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218571Inst : IEnumerable<long>
{
public static readonly long[] Value=A218571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218571.Bytes);
public long this[int i]=>Value[i];

public static A218571Inst Instance=new A218571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218572
{
public static readonly long[] Value={ 1L,1L,3L,3L,7L,8L,14L,18L,28L,35L,53L,66L,92L,117L,157L,196L,259L,319L,411L,507L,638L,777L,970L,1171L,1438L,1728L,2098L,2501L,3012L,3563L,4251L,5008L,5923L,6931L,8152L,9486L,11078L,12835L,14900L,17177L,19844L,22768L,26169L,29916L,34219L,38954L,44387L,50338L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218572Inst : IEnumerable<long>
{
public static readonly long[] Value=A218572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218572.Bytes);
public long this[int i]=>Value[i];

public static A218572Inst Instance=new A218572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218573
{
public static readonly long[] Value={ 1L,1L,3L,3L,7L,8L,14L,18L,28L,35L,53L,67L,93L,119L,161L,201L,267L,332L,428L,531L,674L,824L,1034L,1258L,1552L,1877L,2294L,2749L,3332L,3970L,4762L,5645L,6723L,7916L,9367L,10974L,12894L,15036L,17571L,20381L,23696L,27370L,31652L,36416L,41926L,48029L,55071L,62860L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218573Inst : IEnumerable<long>
{
public static readonly long[] Value=A218573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218573.Bytes);
public long this[int i]=>Value[i];

public static A218573Inst Instance=new A218573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218574
{
public static readonly long[] Value={ 32318L,45807L,110443L,123932L,188568L,202057L,266693L,280182L,344818L,358307L,422943L,436432L,501068L,514557L,579193L,592682L,657318L,670807L,735443L,748932L,813568L,827057L,891693L,905182L,969818L,983307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218574Inst : IEnumerable<long>
{
public static readonly long[] Value=A218574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218574.Bytes);
public long this[int i]=>Value[i];

public static A218574Inst Instance=new A218574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218575
{
public static readonly long[] Value={ 1L,1L,2L,5L,11L,26L,56L,125L,269L,578L,1228L,2600L,5447L,11366L,23575L,48664L,99950L,204383L,416196L,844299L,1706368L,3436555L,6898255L,13803732L,27539833L,54788703L,108703105L,215112006L,424628345L,836218453L,1643005834L,3221104945L,6301628342L,12303151494L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218575Inst : IEnumerable<long>
{
public static readonly long[] Value=A218575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218575.Bytes);
public long this[int i]=>Value[i];

public static A218575Inst Instance=new A218575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218576
{
public static readonly long[] Value={ 1L,1L,2L,4L,7L,14L,25L,44L,79L,137L,237L,408L,689L,1162L,1946L,3231L,5342L,8776L,14340L,23326L,37758L,60847L,97670L,156145L,248697L,394719L,624343L,984360L,1547187L,2424581L,3788730L,5904230L,9176723L,14226914L,22002523L,33947526L,52258177L,80268131L,123028407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218576Inst : IEnumerable<long>
{
public static readonly long[] Value=A218576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218576.Bytes);
public long this[int i]=>Value[i];

public static A218576Inst Instance=new A218576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218577
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,7L,6L,1L,1L,15L,25L,11L,1L,1L,31L,90L,74L,20L,1L,1L,63L,301L,402L,209L,37L,1L,1L,127L,966L,1951L,1629L,590L,70L,1L,1L,255L,3025L,8869L,10839L,6430L,1685L,135L,1L,1L,511L,9330L,38720L,65720L,56878L,25313L,4870L,264L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218577Inst : IEnumerable<long>
{
public static readonly long[] Value=A218577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218577.Bytes);
public long this[int i]=>Value[i];

public static A218577Inst Instance=new A218577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218578
{
public static readonly long[] Value={ 2L,1L,3L,1L,1L,3L,2L,0L,2L,2L,2L,1L,2L,1L,3L,1L,2L,0L,4L,0L,2L,2L,1L,2L,0L,2L,2L,1L,3L,1L,2L,1L,2L,3L,0L,1L,2L,2L,1L,1L,2L,1L,2L,0L,3L,1L,2L,1L,2L,0L,4L,1L,2L,3L,2L,0L,2L,1L,2L,0L,2L,1L,0L,2L,0L,3L,3L,0L,4L,1L,2L,0L,2L,1L,3L,2L,0L,0L,3L,1L,0L,3L,2L,3L,0L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218578Inst : IEnumerable<long>
{
public static readonly long[] Value=A218578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218578.Bytes);
public long this[int i]=>Value[i];

public static A218578Inst Instance=new A218578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218579
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,5L,2L,3L,5L,15L,5L,8L,10L,15L,53L,15L,26L,32L,38L,53L,217L,53L,99L,122L,142L,164L,217L,1014L,217L,433L,537L,619L,704L,797L,1014L,5335L,1014L,2143L,2683L,3069L,3464L,3876L,4321L,5335L,31240L,5335L,11854L,15015L,17063L,19140L,21294L,23522L,25905L,31240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218579Inst : IEnumerable<long>
{
public static readonly long[] Value=A218579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218579.Bytes);
public long this[int i]=>Value[i];

public static A218579Inst Instance=new A218579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218580
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,4L,5L,5L,1L,8L,13L,15L,16L,1L,16L,35L,47L,56L,62L,1L,32L,97L,153L,204L,248L,279L,1L,64L,275L,515L,770L,1030L,1257L,1423L,1L,128L,793L,1785L,3000L,4424L,5869L,7140L,8100L,1L,256L,2315L,6347L,12026L,19582L,28293L,37058L,44843L,50887L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218580Inst : IEnumerable<long>
{
public static readonly long[] Value=A218580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218580.Bytes);
public long this[int i]=>Value[i];

public static A218580Inst Instance=new A218580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218581
{
public static readonly long[] Value={ 1L,0L,2L,0L,1L,4L,0L,1L,4L,10L,0L,1L,6L,15L,31L,0L,1L,10L,29L,62L,115L,0L,1L,18L,63L,148L,288L,496L,0L,1L,34L,149L,392L,826L,1496L,2437L,0L,1L,66L,375L,1120L,2592L,5036L,8615L,13435L,0L,1L,130L,989L,3392L,8698L,18332L,33391L,54548L,82127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218581Inst : IEnumerable<long>
{
public static readonly long[] Value=A218581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218581.Bytes);
public long this[int i]=>Value[i];

public static A218581Inst Instance=new A218581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218582
{
public static readonly long[] Value={ 2L,5L,11L,13L,17L,19L,29L,37L,41L,43L,53L,59L,61L,67L,71L,73L,79L,83L,97L,101L,103L,107L,109L,113L,131L,137L,139L,149L,151L,157L,163L,173L,179L,181L,191L,193L,197L,199L,211L,227L,229L,239L,241L,251L,257L,269L,271L,277L,281L,283L,293L,307L,311L,313L,317L,331L,337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218582Inst : IEnumerable<long>
{
public static readonly long[] Value=A218582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218582.Bytes);
public long this[int i]=>Value[i];

public static A218582Inst Instance=new A218582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218583
{
public static readonly long[] Value={ 0L,6L,1L,3L,3L,1L,2L,4L,2L,3L,0L,0L,0L,8L,3L,5L,1L,2L,3L,4L,3L,9L,8L,5L,5L,9L,9L,6L,9L,5L,0L,0L,6L,0L,4L,5L,0L,6L,1L,2L,1L,0L,2L,6L,4L,5L,2L,8L,7L,7L,9L,7L,3L,3L,6L,4L,2L,5L,7L,5L,2L,0L,6L,6L,3L,4L,7L,8L,1L,6L,6L,9L,5L,6L,2L,0L,2L,8L,9L,4L,7L,0L,1L,6L,5L,1L,8L,3L,8L,9L,2L,5L,7L,9L,7L,4L,4L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218583Inst : IEnumerable<long>
{
public static readonly long[] Value=A218583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218583.Bytes);
public long this[int i]=>Value[i];

public static A218583Inst Instance=new A218583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218584
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,13L,15L,21L,27L,35L,39L,45L,63L,65L,81L,91L,105L,117L,135L,169L,189L,195L,273L,315L,351L,405L,455L,507L,567L,585L,819L,845L,945L,1053L,1183L,1365L,1521L,1701L,1755L,2457L,2535L,2835L,3159L,3549L,4095L,4563L,5265L,5915L,7371L,7605L,8505L,10647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218584Inst : IEnumerable<long>
{
public static readonly long[] Value=A218584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218584.Bytes);
public long this[int i]=>Value[i];

public static A218584Inst Instance=new A218584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218585
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,2L,0L,3L,1L,2L,1L,3L,2L,3L,2L,2L,1L,4L,1L,4L,3L,4L,2L,3L,3L,3L,3L,5L,2L,6L,2L,4L,4L,5L,3L,5L,2L,8L,4L,4L,4L,7L,3L,5L,2L,8L,4L,7L,2L,8L,4L,7L,5L,7L,4L,7L,3L,8L,4L,9L,3L,11L,4L,8L,5L,10L,4L,9L,5L,9L,6L,8L,5L,6L,6L,10L,5L,10L,3L,12L,7L,10L,6L,8L,6L,11L,4L,7L,4L,15L,8L,13L,6L,9L,5L,15L,9L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218585Inst : IEnumerable<long>
{
public static readonly long[] Value=A218585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218585.Bytes);
public long this[int i]=>Value[i];

public static A218585Inst Instance=new A218585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218586
{
public static readonly BigInteger[] Value={ 1L,13L,449L,56629L,28543403L,57707873919L,467122877883141L,15124271280844676313UL,BigInteger.Parse("1958173356335852318774549"),BigInteger.Parse("1013875932726564267833657180687") };
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
public class A218586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218586Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218586.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218586Inst Instance=new A218586Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218587
{
public static readonly long[] Value={ 7L,57L,449L,3567L,28305L,224643L,1782855L,14149449L,112295673L,891223263L,7073103393L,56134970523L,445509522567L,3535741318617L,28061053779825L,222703718478543L,1767465563243697L,14027311885918707L,111326343684867783L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218587Inst : IEnumerable<long>
{
public static readonly long[] Value=A218587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218587.Bytes);
public long this[int i]=>Value[i];

public static A218587Inst Instance=new A218587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218588
{
public static readonly ulong[] Value={ 13L,225L,3565L,56629L,900213L,14309253L,227451273L,3615431533L,57468767413L,913489632033L,14520292432269L,230806004700461L,3668756125551981L,58316383606459589L,926962839870918025L,14734454596844709749UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218588Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A218588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218588.Bytes);
public ulong this[int i]=>Value[i];

public static A218588Inst Instance=new A218588Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218589
{
public static readonly BigInteger[] Value={ 25L,895L,28325L,898763L,28543403L,906390787L,28782653703L,913998678577L,29024205558587L,921669292406117L,29267787550042425L,929404283528404253L,BigInteger.Parse("29513413706384880845"),BigInteger.Parse("937204189864632464075"),BigInteger.Parse("29761101248357058984601") };
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
public class A218589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218589Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218589.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218589Inst Instance=new A218589Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218590
{
public static readonly BigInteger[] Value={ 49L,3565L,225647L,14313773L,908914463L,57707873919L,3663996495065L,232634494299223L,14770432493750847L,937804521455278797L,BigInteger.Parse("59543098444313115311"),BigInteger.Parse("3780511282396595054063"),BigInteger.Parse("240032277959119287777081") };
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
public class A218590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218590Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218590.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218590Inst Instance=new A218590Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218591
{
public static readonly BigInteger[] Value={ 97L,14189L,1798967L,228191491L,28976110305L,3679019688741L,467122877883141L,59310238629598533L,7530575876378444705L,BigInteger.Parse("956151509525182089139"),BigInteger.Parse("121401831920934712845239"),BigInteger.Parse("15414298517143294281162561") };
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
public class A218591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218591Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218591.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218591Inst Instance=new A218591Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218592
{
public static readonly long[] Value={ 1L,3L,1L,7L,13L,1L,13L,57L,49L,1L,25L,225L,449L,191L,1L,49L,895L,3565L,3567L,737L,1L,97L,3565L,28325L,56629L,28305L,2849L,1L,191L,14189L,225647L,898763L,900213L,224643L,11011L,1L,375L,56489L,1798967L,14313773L,28543403L,14309253L,1782855L,42557L,1L,737L,224891L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218592Inst : IEnumerable<long>
{
public static readonly long[] Value=A218592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218592.Bytes);
public long this[int i]=>Value[i];

public static A218592Inst Instance=new A218592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218593
{
public static readonly long[] Value={ 1L,13L,57L,225L,895L,3565L,14189L,56489L,224891L,895325L,3564433L,14190565L,56494859L,224914869L,895421261L,3564812065L,14192074291L,56500867089L,224938787413L,895516488309L,3565191179595L,14193583605661L,56506875907213L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218593Inst : IEnumerable<long>
{
public static readonly long[] Value=A218593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218593.Bytes);
public long this[int i]=>Value[i];

public static A218593Inst Instance=new A218593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218594
{
public static readonly long[] Value={ 1L,49L,449L,3565L,28325L,225647L,1798967L,14344301L,114371203L,911903915L,7270785113L,57971383761L,462217176543L,3685347946655L,29383999805463L,234284375881311L,1867995138191173L,14893890483791275L,118751901014588395L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218594Inst : IEnumerable<long>
{
public static readonly long[] Value=A218594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218594.Bytes);
public long this[int i]=>Value[i];

public static A218594Inst Instance=new A218594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218595
{
public static readonly ulong[] Value={ 1L,191L,3567L,56629L,898763L,14313773L,228191491L,3638365943L,58007785937L,924827168901L,14744666323421L,235076662350533L,3747866807725781L,59752871465350263L,952650082055322631L,15188260508053833233UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218595Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A218595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218595.Bytes);
public ulong this[int i]=>Value[i];

public static A218595Inst Instance=new A218595Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218596
{
public static readonly BigInteger[] Value={ 1L,737L,28305L,900213L,28543403L,908914463L,28976110305L,923902607653L,29456613886229L,939145718670695L,29942165452165937L,954626864774112217L,BigInteger.Parse("30435761282996284955"),BigInteger.Parse("970364022192333797121"),BigInteger.Parse("30937498799139172046789") };
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
public class A218596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218596Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218596.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218596Inst Instance=new A218596Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218597
{
public static readonly BigInteger[] Value={ 1L,2849L,224643L,14309253L,906390787L,57707873919L,3679019688741L,234587060833513L,14956980852954693L,953622639363956241L,BigInteger.Parse("60800788454758533673"),BigInteger.Parse("3876520842651206103055"),BigInteger.Parse("247158250520323924145773") };
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
public class A218597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218597Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218597.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218597Inst Instance=new A218597Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218598
{
public static readonly BigInteger[] Value={ 1L,11011L,1782855L,227451273L,28782653703L,3663996495065L,467122877883141L,59564772010560679L,7594747878648617511L,BigInteger.Parse("968342656073731373915"),BigInteger.Parse("123465264778955860526245"),BigInteger.Parse("15742032324396343036237669") };
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
public class A218598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218598Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218598.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218598Inst Instance=new A218598Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218599
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,2L,1L,0L,4L,3L,2L,1L,0L,8L,7L,6L,5L,4L,3L,2L,1L,0L,16L,15L,14L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,29L,28L,27L,26L,25L,24L,23L,22L,21L,20L,19L,18L,17L,16L,15L,14L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218599Inst : IEnumerable<long>
{
public static readonly long[] Value=A218599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218599.Bytes);
public long this[int i]=>Value[i];

public static A218599Inst Instance=new A218599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218600
{
public static readonly long[] Value={ 0L,1L,2L,4L,7L,12L,21L,38L,68L,122L,220L,399L,729L,1343L,2493L,4655L,8727L,16405L,30901L,58319L,110298L,209098L,397407L,757296L,1446945L,2771951L,5323982L,10250571L,19780122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218600Inst : IEnumerable<long>
{
public static readonly long[] Value=A218600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218600.Bytes);
public long this[int i]=>Value[i];

public static A218600Inst Instance=new A218600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218601
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,1L,2L,0L,1L,2L,3L,4L,0L,1L,2L,3L,4L,5L,6L,7L,8L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218601Inst : IEnumerable<long>
{
public static readonly long[] Value=A218601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218601.Bytes);
public long this[int i]=>Value[i];

public static A218601Inst Instance=new A218601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218602
{
public static readonly long[] Value={ 0L,1L,2L,4L,3L,7L,6L,5L,12L,11L,10L,9L,8L,21L,20L,19L,18L,17L,16L,15L,14L,13L,38L,37L,36L,35L,34L,33L,32L,31L,30L,29L,28L,27L,26L,25L,24L,23L,22L,68L,67L,66L,65L,64L,63L,62L,61L,60L,59L,58L,57L,56L,55L,54L,53L,52L,51L,50L,49L,48L,47L,46L,45L,44L,43L,42L,41L,40L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218602Inst : IEnumerable<long>
{
public static readonly long[] Value=A218602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218602.Bytes);
public long this[int i]=>Value[i];

public static A218602Inst Instance=new A218602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218603
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,0L,1L,3L,0L,1L,3L,2L,3L,0L,1L,3L,2L,2L,1L,1L,1L,3L,0L,1L,3L,2L,2L,1L,1L,1L,2L,1L,1L,0L,1L,0L,0L,0L,1L,0L,1L,3L,2L,2L,1L,1L,1L,2L,1L,1L,0L,1L,0L,0L,0L,0L,1L,1L,0L,1L,1L,3L,5L,3L,5L,4L,2L,3L,5L,0L,1L,3L,2L,2L,1L,1L,1L,2L,1L,1L,0L,1L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218603Inst : IEnumerable<long>
{
public static readonly long[] Value=A218603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218603.Bytes);
public long this[int i]=>Value[i];

public static A218603Inst Instance=new A218603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218604
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,2L,2L,2L,0L,1L,0L,0L,1L,1L,2L,2L,2L,1L,2L,2L,3L,2L,3L,3L,5L,0L,1L,0L,0L,1L,1L,2L,2L,2L,1L,2L,2L,3L,2L,3L,3L,5L,1L,2L,2L,3L,2L,2L,0L,0L,0L,0L,1L,3L,2L,0L,1L,0L,0L,1L,1L,2L,2L,2L,1L,2L,2L,3L,2L,3L,3L,5L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218604Inst : IEnumerable<long>
{
public static readonly long[] Value=A218604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218604.Bytes);
public long this[int i]=>Value[i];

public static A218604Inst Instance=new A218604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218605
{
public static readonly long[] Value={ 1L,2L,4L,6L,9L,14L,23L,34L,36L,37L,38L,40L,51L,53L,54L,55L,56L,59L,70L,81L,83L,84L,85L,86L,89L,102L,119L,124L,135L,137L,138L,139L,140L,143L,156L,173L,180L,197L,208L,213L,222L,233L,235L,236L,237L,238L,241L,254L,271L,278L,295L,306L,311L,322L,339L,350L,355L,370L,375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218605Inst : IEnumerable<long>
{
public static readonly long[] Value=A218605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218605.Bytes);
public long this[int i]=>Value[i];

public static A218605Inst Instance=new A218605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218606
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,8L,10L,11L,13L,15L,16L,22L,24L,25L,39L,41L,42L,62L,63L,64L,65L,69L,71L,72L,92L,93L,94L,95L,105L,106L,107L,108L,114L,123L,125L,126L,146L,147L,148L,149L,159L,160L,161L,162L,168L,183L,184L,185L,186L,192L,203L,221L,223L,224L,244L,245L,246L,247L,257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218606Inst : IEnumerable<long>
{
public static readonly long[] Value=A218606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218606.Bytes);
public long this[int i]=>Value[i];

public static A218606Inst Instance=new A218606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218607
{
public static readonly long[] Value={ 0L,1L,3L,5L,8L,13L,22L,33L,35L,36L,37L,39L,50L,52L,53L,54L,55L,58L,69L,80L,82L,83L,84L,85L,88L,101L,118L,123L,134L,136L,137L,138L,139L,142L,155L,172L,179L,196L,207L,212L,221L,232L,234L,235L,236L,237L,240L,253L,270L,277L,294L,305L,310L,321L,338L,349L,354L,369L,374L,383L,400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218607Inst : IEnumerable<long>
{
public static readonly long[] Value=A218607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218607.Bytes);
public long this[int i]=>Value[i];

public static A218607Inst Instance=new A218607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218608
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,7L,9L,10L,12L,14L,15L,21L,23L,24L,38L,40L,41L,61L,62L,63L,64L,68L,70L,71L,91L,92L,93L,94L,104L,105L,106L,107L,113L,122L,124L,125L,145L,146L,147L,148L,158L,159L,160L,161L,167L,182L,183L,184L,185L,191L,202L,220L,222L,223L,243L,244L,245L,246L,256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218608Inst : IEnumerable<long>
{
public static readonly long[] Value=A218608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218608.Bytes);
public long this[int i]=>Value[i];

public static A218608Inst Instance=new A218608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218609
{
public static readonly BigInteger[] Value={ 0L,1L,2L,8L,3L,60L,172L,12L,20L,49L,54L,3016L,10096L,125744802L,101035235L,25L,1358590114L,40796719636668219L,70L,19049L,1770L,18L,7L,16261L,82682568533587123L,17L,36L,307L,315899951699378231L,3871315398L,15215587727307698L,59L,BigInteger.Parse("9097520004151634187729920190004140") };
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
public class A218609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218609Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218609.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218609Inst Instance=new A218609Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218610
{
public static readonly BigInteger[] Value={ 0L,1L,3L,4L,2L,37L,110L,18L,11L,32L,33L,4755L,16127L,73542063L,97105360L,62L,1306632183L,39288694215537689L,193L,8150L,719L,12L,5L,13505L,246941338376004599L,13L,45L,407L,944077158106260984L,4975012595L,5738426278308884L,26L,BigInteger.Parse("27439590092251146768825651348524279") };
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
public class A218610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218610Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218610.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218610Inst Instance=new A218610Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218611
{
public static readonly long[] Value={ 1L,5L,9L,16L,32L,59L,62L,115L,118L,208L,212L,213L,384L,389L,649L,654L,686L,703L,708L,716L,720L,723L,1310L,1326L,1328L,1338L,2236L,2369L,2422L,2432L,2452L,2458L,2466L,2476L,2486L,2488L,4545L,4601L,4625L,4627L,4637L,7811L,7817L,7819L,7826L,8287L,8511L,8526L,8631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218611Inst : IEnumerable<long>
{
public static readonly long[] Value=A218611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218611.Bytes);
public long this[int i]=>Value[i];

public static A218611Inst Instance=new A218611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218612
{
public static readonly long[] Value={ 2L,10L,22L,47L,105L,208L,224L,471L,486L,943L,966L,974L,1934L,1972L,3509L,3546L,3765L,3893L,3930L,3995L,4027L,4049L,7912L,8041L,8058L,8146L,14291L,15315L,15738L,15827L,15995L,16040L,16122L,16211L,16312L,16334L,31694L,32207L,32440L,32462L,32568L,57145L,57208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218612Inst : IEnumerable<long>
{
public static readonly long[] Value=A218612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218612.Bytes);
public long this[int i]=>Value[i];

public static A218612Inst Instance=new A218612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218613
{
public static readonly long[] Value={ 0L,1L,2L,3L,2L,5L,6L,4L,4L,5L,5L,9L,10L,17L,17L,5L,19L,32L,6L,10L,8L,4L,3L,10L,33L,4L,5L,7L,34L,20L,31L,5L,62L,4L,7L,4L,5L,14L,33L,7L,54L,32L,12L,14L,3L,34L,47L,4L,8L,31L,32L,143L,10L,11L,17L,169L,13L,240L,59L,8L,7L,15L,18L,12L,33L,102L,5L,66L,116L,6L,11L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218613Inst : IEnumerable<long>
{
public static readonly long[] Value=A218613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218613.Bytes);
public long this[int i]=>Value[i];

public static A218613Inst Instance=new A218613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218614
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,9L,13L,21L,29L,37L,53L,69L,101L,85L,117L,181L,245L,309L,437L,565L,821L,693L,949L,1205L,1717L,1461L,1973L,2741L,3765L,2485L,3509L,5557L,7605L,9653L,13749L,17845L,26037L,21941L,30133L,38325L,54709L,46517L,62901L,87477L,120245L,79285L,112053L,144821L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218614Inst : IEnumerable<long>
{
public static readonly long[] Value=A218614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218614.Bytes);
public long this[int i]=>Value[i];

public static A218614Inst Instance=new A218614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218615
{
public static readonly long[] Value={ 1L,3L,2L,6L,4L,14L,10L,26L,18L,58L,42L,122L,90L,106L,74L,202L,138L,458L,330L,970L,714L,842L,586L,1866L,1354L,1610L,1098L,3402L,2378L,3658L,2634L,6730L,4682L,14922L,10826L,31306L,23114L,27210L,19018L,59978L,43594L,51786L,35402L,109130L,76362L,117322L,84554L,248394L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218615Inst : IEnumerable<long>
{
public static readonly long[] Value=A218615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218615.Bytes);
public long this[int i]=>Value[i];

public static A218615Inst Instance=new A218615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218616
{
public static readonly long[] Value={ 0L,1L,3L,7L,4L,15L,11L,8L,31L,26L,23L,19L,16L,63L,57L,53L,49L,46L,42L,39L,35L,32L,127L,120L,116L,112L,109L,104L,101L,97L,94L,89L,85L,81L,78L,74L,71L,67L,64L,255L,247L,240L,236L,231L,225L,221L,215L,209L,205L,200L,197L,193L,190L,184L,180L,176L,173L,168L,165L,161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218616Inst : IEnumerable<long>
{
public static readonly long[] Value=A218616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218616.Bytes);
public long this[int i]=>Value[i];

public static A218616Inst Instance=new A218616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218617
{
public static readonly long[] Value={ 0L,1L,18L,59L,7814L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218617Inst : IEnumerable<long>
{
public static readonly long[] Value=A218617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218617.Bytes);
public long this[int i]=>Value[i];

public static A218617Inst Instance=new A218617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218618
{
public static readonly long[] Value={ 0L,1L,-1L,1L,-1L,3L,1L,-1L,3L,5L,-1L,1L,-1L,3L,5L,-1L,-7L,1L,1L,3L,1L,-1L,3L,5L,-1L,-7L,1L,1L,3L,-7L,1L,1L,-5L,1L,-5L,-3L,-1L,1L,-1L,3L,5L,-1L,-7L,1L,1L,3L,-7L,1L,1L,-5L,1L,-5L,-3L,-1L,-7L,1L,1L,-5L,1L,11L,1L,1L,13L,1L,-5L,-1L,3L,1L,-1L,3L,5L,-1L,-7L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218618Inst : IEnumerable<long>
{
public static readonly long[] Value=A218618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218618.Bytes);
public long this[int i]=>Value[i];

public static A218618Inst Instance=new A218618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218619
{
public static readonly BigInteger[] Value={ 1L,1L,11L,72L,734L,6994L,74641L,803196L,8989482L,102192197L,1184211027L,13897707080L,165052834584L,1978844990494L,23924151189858L,291313067897212L,3569576082827250L,43981925261314302L,544590342185545146L,6772925262506494672L,BigInteger.Parse("84567358373934285042") };
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
public class A218619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218619Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218619.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218619Inst Instance=new A218619Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218620
{
public static readonly long[] Value={ 7L,1L,0L,2L,18L,128L,443L,2666L,1353L,2706L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218620Inst : IEnumerable<long>
{
public static readonly long[] Value=A218620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218620.Bytes);
public long this[int i]=>Value[i];

public static A218620Inst Instance=new A218620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218621
{
public static readonly long[] Value={ 1L,2L,1L,4L,1L,2L,1L,8L,3L,2L,1L,4L,1L,2L,3L,16L,1L,2L,1L,4L,3L,2L,1L,8L,5L,2L,3L,4L,1L,6L,1L,32L,3L,2L,5L,4L,1L,2L,3L,8L,1L,6L,1L,4L,5L,2L,1L,16L,7L,10L,3L,4L,1L,6L,5L,8L,3L,2L,1L,4L,1L,2L,7L,64L,5L,6L,1L,4L,3L,10L,1L,8L,1L,2L,5L,4L,7L,6L,1L,16L,9L,2L,1L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218621Inst : IEnumerable<long>
{
public static readonly long[] Value=A218621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218621.Bytes);
public long this[int i]=>Value[i];

public static A218621Inst Instance=new A218621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218622
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,1L,0L,2L,2L,2L,2L,1L,1L,1L,2L,1L,1L,0L,0L,2L,2L,2L,0L,2L,2L,2L,2L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,1L,0L,0L,0L,0L,0L,2L,2L,2L,0L,2L,2L,0L,0L,2L,2L,2L,0L,2L,2L,2L,2L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,1L,0L,2L,2L,2L,2L,1L,1L,1L,2L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218622Inst : IEnumerable<long>
{
public static readonly long[] Value=A218622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218622.Bytes);
public long this[int i]=>Value[i];

public static A218622Inst Instance=new A218622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218623
{
public static readonly long[] Value={ 0L,0L,0L,1L,5L,7L,16L,21L,34L,48L,69L,89L,129L,166L,220L,287L,377L,478L,619L,778L,992L,1247L,1565L,1941L,2428L,3000L,3706L,4553L,5594L,6826L,8341L,10129L,12300L,14873L,17962L,21619L,26009L,31175L,37324L,44567L,53164L,63245L,75167L,89118L,105544L,124746L,147261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218623Inst : IEnumerable<long>
{
public static readonly long[] Value=A218623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218623.Bytes);
public long this[int i]=>Value[i];

public static A218623Inst Instance=new A218623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218624
{
public static readonly long[] Value={ 0L,0L,0L,0L,3L,5L,17L,22L,39L,57L,85L,107L,162L,208L,273L,360L,474L,597L,774L,970L,1233L,1553L,1937L,2396L,2991L,3694L,4539L,5572L,6822L,8309L,10125L,12278L,14859L,17950L,21605L,25972L,31171L,37312L,44553L,53132L,63241L,75135L,89114L,105522L,124722L,147249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218624Inst : IEnumerable<long>
{
public static readonly long[] Value=A218624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218624.Bytes);
public long this[int i]=>Value[i];

public static A218624Inst Instance=new A218624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218625
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,3L,16L,21L,43L,65L,101L,125L,202L,253L,336L,444L,591L,736L,964L,1193L,1529L,1917L,2390L,2933L,3678L,4519L,5548L,6782L,8303L,10067L,12272L,14819L,17926L,21585L,25946L,31103L,37306L,44533L,53108L,63181L,75129L,89056L,105516L,124682L,147205L,173480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218625Inst : IEnumerable<long>
{
public static readonly long[] Value=A218625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218625.Bytes);
public long this[int i]=>Value[i];

public static A218625Inst Instance=new A218625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218626
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,13L,18L,43L,69L,115L,140L,243L,302L,402L,539L,726L,896L,1183L,1458L,1873L,2356L,2923L,3572L,4489L,5514L,6738L,8231L,10057L,12164L,14809L,17854L,21541L,25912L,31053L,37180L,44523L,53074L,63137L,75017L,89046L,105408L,124672L,147133L,173396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218626Inst : IEnumerable<long>
{
public static readonly long[] Value=A218626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218626.Bytes);
public long this[int i]=>Value[i];

public static A218626Inst Instance=new A218626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218627
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,8L,13L,41L,71L,126L,152L,288L,352L,475L,644L,882L,1077L,1444L,1759L,2286L,2871L,3558L,4317L,5466L,6686L,8161L,9939L,12150L,14632L,17840L,21423L,25842L,31001L,37096L,44313L,53060L,63085L,74947L,88858L,105394L,124492L,147119L,173278L,203994L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218627Inst : IEnumerable<long>
{
public static readonly long[] Value=A218627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218627.Bytes);
public long this[int i]=>Value[i];

public static A218627Inst Instance=new A218627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218628
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,4L,8L,35L,67L,132L,158L,330L,399L,547L,755L,1055L,1276L,1737L,2103L,2757L,3476L,4295L,5184L,6605L,8079L,9823L,11956L,14610L,17544L,21401L,25646L,30885L,37014L,44169L,52707L,63063L,74865L,88742L,105074L,124470L,146816L,173256L,203798L,239540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218628Inst : IEnumerable<long>
{
public static readonly long[] Value=A218628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218628.Bytes);
public long this[int i]=>Value[i];

public static A218628Inst Instance=new A218628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218629
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,4L,27L,59L,132L,158L,371L,443L,619L,871L,1246L,1493L,2073L,2485L,3306L,4175L,5154L,6177L,7955L,9703L,11782L,14312L,17514L,20942L,25616L,30583L,36838L,44049L,52479L,62509L,74835L,88622L,104898L,123964L,146786L,172780L,203768L,239236L,280917L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218629Inst : IEnumerable<long>
{
public static readonly long[] Value=A218629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218629.Bytes);
public long this[int i]=>Value[i];

public static A218629Inst Instance=new A218629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218630
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,18L,47L,124L,150L,403L,477L,684L,986L,1449L,1719L,2441L,2906L,3921L,4978L,6133L,7310L,9512L,11604L,14046L,17058L,20898L,24906L,30539L,36372L,43777L,52301L,62149L,73968L,88578L,104720L,123692L,145988L,172736L,203019L,239192L,280445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218630Inst : IEnumerable<long>
{
public static readonly long[] Value=A218630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218630.Bytes);
public long this[int i]=>Value[i];

public static A218630Inst Instance=new A218630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218631
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,10L,34L,110L,136L,425L,500L,740L,1097L,1661L,1954L,2846L,3357L,4616L,5885L,7250L,8582L,11324L,13794L,16674L,20228L,24846L,29487L,36312L,43087L,51903L,61895L,73424L,87274L,104660L,123438L,145588L,171526L,202959L,238060L,280385L,328137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218631Inst : IEnumerable<long>
{
public static readonly long[] Value=A218631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218631.Bytes);
public long this[int i]=>Value[i];

public static A218631Inst Instance=new A218631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218632
{
public static readonly ulong[] Value={ 1L,15L,511L,65523L,33546641L,68702054721L,562806164441653L,18442026828339805665UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218632Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A218632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218632.Bytes);
public ulong this[int i]=>Value[i];

public static A218632Inst Instance=new A218632Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218633
{
public static readonly long[] Value={ 7L,63L,511L,4087L,32689L,261505L,2092027L,16736081L,133887639L,1071093011L,8568679227L,68548914887L,548387167731L,4387064131261L,35096247367295L,280767853492265L,2246125824498091L,17968870569494163L,143749876352266497L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218633Inst : IEnumerable<long>
{
public static readonly long[] Value=A218633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218633.Bytes);
public long this[int i]=>Value[i];

public static A218633Inst Instance=new A218633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218634
{
public static readonly ulong[] Value={ 15L,255L,4095L,65523L,1048353L,16773633L,268378101L,4294049121L,68704778799L,1099276346403L,17588419711983L,281414686103379L,4502634509040741L,72042144646840065L,1152674194384463589L,18442785190711981653UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218634Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A218634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218634.Bytes);
public ulong this[int i]=>Value[i];

public static A218634Inst Instance=new A218634Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218635
{
public static readonly BigInteger[] Value={ 29L,1017L,32753L,1048363L,33546641L,1073490145L,34351677143L,1099253514899L,35176108628465L,1125635352180227L,36020327300636471L,1152650346591335547L,BigInteger.Parse("36884807025995093735"),BigInteger.Parse("1180313694754197978059"),BigInteger.Parse("37770034069649980076795") };
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
public class A218635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218635Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218635.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218635Inst Instance=new A218635Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218636
{
public static readonly BigInteger[] Value={ 57L,4065L,262017L,16773477L,1073471633L,68702054721L,4396930705721L,281403528942981L,18009823835462025L,1152628595873880165L,BigInteger.Parse("73768221838169850821"),BigInteger.Parse("4721165666554240664629"),BigInteger.Parse("302154568669832438214889") };
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
public class A218636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218636Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218636.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218636Inst Instance=new A218636Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218637
{
public static readonly BigInteger[] Value={ 113L,16257L,2096129L,268375113L,34351030657L,4396923919617L,562806164441653L,72039179359935185L,9221013924842933937L,BigInteger.Parse("1180289649641919709529"),BigInteger.Parse("151077058155294314735841"),BigInteger.Parse("19337861267846477086600769") };
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
public class A218637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218637Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218637.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218637Inst Instance=new A218637Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218638
{
public static readonly long[] Value={ 1L,3L,1L,7L,15L,1L,15L,63L,63L,1L,29L,255L,511L,251L,1L,57L,1017L,4095L,4087L,1001L,1L,113L,4065L,32753L,65523L,32689L,4001L,1L,225L,16257L,262017L,1048363L,1048353L,261505L,16001L,1L,449L,65025L,2096129L,16773477L,33546641L,16773633L,2092027L,63985L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218638Inst : IEnumerable<long>
{
public static readonly long[] Value=A218638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218638.Bytes);
public long this[int i]=>Value[i];

public static A218638Inst Instance=new A218638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218639
{
public static readonly ulong[] Value={ 1L,251L,4087L,65523L,1048363L,16773477L,268375113L,4294000777L,68704008397L,1099264075379L,17588224239783L,281411572315259L,4502584908606667L,72041354562688477L,1152661609402891673L,18442584732844711745UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218639Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A218639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218639.Bytes);
public ulong this[int i]=>Value[i];

public static A218639Inst Instance=new A218639Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218640
{
public static readonly BigInteger[] Value={ 1L,1001L,32689L,1048353L,33546641L,1073471633L,34351030657L,1099232741569L,35175445605065L,1125614194685977L,36019652123390673L,1152628800344096833L,BigInteger.Parse("36884119447102424865"),BigInteger.Parse("1180291753062182528225"),BigInteger.Parse("37769333882150509728449") };
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
public class A218640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218640Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218640.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218640Inst Instance=new A218640Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218641
{
public static readonly BigInteger[] Value={ 1L,4001L,261505L,16773633L,1073490145L,68702054721L,4396923919617L,281403077821441L,18009795930773137L,1152626873213807201L,BigInteger.Parse("73768115566393606785"),BigInteger.Parse("4721159119167361543169"),BigInteger.Parse("302154165890141908970689") };
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
public class A218641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218641Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218641.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218641Inst Instance=new A218641Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218642
{
public static readonly long[] Value={ 1L,16001L,2092027L,268378101L,34351677143L,4396930705721L,562806164441653L,72039176523059285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218642Inst : IEnumerable<long>
{
public static readonly long[] Value=A218642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218642.Bytes);
public long this[int i]=>Value[i];

public static A218642Inst Instance=new A218642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218643
{
public static readonly long[] Value={ 2L,4L,11L,8L,14L,23L,16L,12L,21L,31L,32L,16L,27L,33L,41L,64L,32L,24L,42L,46L,53L,128L,64L,32L,36L,42L,51L,61L,256L,128L,64L,32L,54L,52L,62L,71L,512L,256L,128L,64L,48L,54L,63L,74L,83L,1024L,512L,256L,128L,64L,72L,81L,75L,82L,97L,2048L,1024L,512L,256L,128L,64L,72L,81L,92L,91L,101L,4096L,2048L,1024L,512L,256L,128L,64L,72L,81L,92L,106L,113L,8192L,4096L,2048L,1024L,512L,256L,128L,96L,108L,100L,102L,111L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218643Inst : IEnumerable<long>
{
public static readonly long[] Value=A218643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218643.Bytes);
public long this[int i]=>Value[i];

public static A218643Inst Instance=new A218643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218644
{
public static readonly BigInteger[] Value={ 4L,16L,610L,82188L,45453172L,99181510254L,817394844786996L,BigInteger.Parse("26269231937922520406") };
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
public class A218644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218644Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218644.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218644Inst Instance=new A218644Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218645
{
public static readonly long[] Value={ 4L,16L,66L,292L,1280L,5644L,24782L,108940L,478862L,2104866L,9252000L,40667620L,178756504L,785732636L,3453724976L,15181011874L,66728857148L,293309853452L,1289257359676L,5666991817956L,24909531073894L,109491024206644L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218645Inst : IEnumerable<long>
{
public static readonly long[] Value=A218645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218645.Bytes);
public long this[int i]=>Value[i];

public static A218645Inst Instance=new A218645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218646
{
public static readonly long[] Value={ 16L,66L,610L,4946L,44712L,391888L,3441914L,30316230L,266671334L,2346850058L,20652411898L,181738545458L,1599310922692L,14073950030962L,123851052268298L,1089892156540672L,9591074382276762L,84401670396996900L,742736585615588566L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218646Inst : IEnumerable<long>
{
public static readonly long[] Value=A218646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218646.Bytes);
public long this[int i]=>Value[i];

public static A218646Inst Instance=new A218646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218647
{
public static readonly BigInteger[] Value={ 36L,292L,4946L,82188L,1374954L,23370578L,394655980L,6688451956L,113330380248L,1919929942392L,32533805101006L,551254991578840L,9340671432312772L,158272966584027210L,2681844781855552786L,BigInteger.Parse("45442423044091925218") };
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
public class A218647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218647Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218647.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218647Inst Instance=new A218647Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218648
{
public static readonly BigInteger[] Value={ 94L,1280L,44712L,1374954L,45453172L,1519211492L,50119569324L,1664686049742L,55271550032162L,1834389849757758L,60908824469453990L,2022184882918753962L,BigInteger.Parse("67138807540703516826"),BigInteger.Parse("2229116172523577249680"),BigInteger.Parse("74009789156374427379680") };
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
public class A218648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218648Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218648.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218648Inst Instance=new A218648Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218649
{
public static readonly BigInteger[] Value={ 236L,5644L,391888L,23370578L,1519211492L,99181510254L,6431987350130L,419623464236488L,27357863689722514L,1783200625332610748L,BigInteger.Parse("116285423303246786898"),BigInteger.Parse("7582253123955997499522"),BigInteger.Parse("494404195464186732399198") };
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
public class A218649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218649Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218649.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218649Inst Instance=new A218649Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218650
{
public static readonly BigInteger[] Value={ 602L,24782L,3441914L,394655980L,50119569324L,6431987350130L,817394844786996L,104563780472177342L,13375235335809957170UL,BigInteger.Parse("1710137926295211991338"),BigInteger.Parse("218764828600351495270866"),BigInteger.Parse("27982536987440234040232618") };
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
public class A218650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218650Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218650.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218650Inst Instance=new A218650Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218651
{
public static readonly long[] Value={ 4L,4L,4L,16L,16L,16L,36L,66L,66L,36L,94L,292L,610L,292L,94L,236L,1280L,4946L,4946L,1280L,236L,602L,5644L,44712L,82188L,44712L,5644L,602L,1528L,24782L,391888L,1374954L,1374954L,391888L,24782L,1528L,3882L,108940L,3441914L,23370578L,45453172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218651Inst : IEnumerable<long>
{
public static readonly long[] Value=A218651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218651.Bytes);
public long this[int i]=>Value[i];

public static A218651Inst Instance=new A218651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218652
{
public static readonly BigInteger[] Value={ 1L,2L,12L,108L,1320L,20400L,381360L,8366400L,210712320L,5991572160L,189846961920L,6632804344320L,253310120743680L,10498203901785600L,469251125818675200L,BigInteger.Parse("22501933753870771200"),BigInteger.Parse("1152276591132072806400"),BigInteger.Parse("62756742945031098163200"),BigInteger.Parse("3622251744055050294988800") };
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
public class A218652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218652Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218652.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218652Inst Instance=new A218652Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218653
{
public static readonly BigInteger[] Value={ 1L,1L,4L,27L,264L,3400L,54480L,1045800L,23412480L,599157216L,17258814720L,552733695360L,19485393903360L,749871707270400L,31283408387911680L,1406370859616923200L,BigInteger.Parse("67780975948945459200"),BigInteger.Parse("3486485719168394342400"),BigInteger.Parse("190644828634476331315200"),BigInteger.Parse("11043310871932837194977280") };
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
public class A218653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218653Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218653.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218653Inst Instance=new A218653Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218654
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,2L,2L,2L,1L,4L,1L,4L,2L,4L,2L,3L,2L,6L,3L,4L,3L,6L,2L,6L,3L,4L,3L,8L,3L,8L,2L,5L,5L,8L,4L,8L,6L,5L,4L,8L,2L,10L,6L,6L,3L,11L,4L,9L,6L,9L,7L,10L,4L,14L,6L,9L,3L,11L,4L,12L,7L,9L,10L,10L,4L,11L,5L,10L,9L,15L,4L,15L,9L,9L,8L,14L,6L,12L,8L,9L,8L,18L,4L,17L,11L,9L,11L,20L,5L,14L,10L,13L,7L,16L,9L,17L,6L,16L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218654Inst : IEnumerable<long>
{
public static readonly long[] Value=A218654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218654.Bytes);
public long this[int i]=>Value[i];

public static A218654Inst Instance=new A218654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218655
{
public static readonly long[] Value={ 2L,4L,13L,-176L,-786L,-3452L,54483L,237722L,1037569L,-16329149L,-71279530L,-311145495L,4897036897L,21376227709L,93310132523L,-1468582101731L,-6410560285891L,-27982966049682L,440416091468393L,1922476035761802L,8391868916275609L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218655Inst : IEnumerable<long>
{
public static readonly long[] Value=A218655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218655.Bytes);
public long this[int i]=>Value[i];

public static A218655Inst Instance=new A218655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218656
{
public static readonly long[] Value={ 1L,2L,3L,2L,3L,3L,1L,5L,4L,4L,4L,5L,4L,7L,6L,5L,3L,10L,4L,9L,8L,4L,9L,6L,7L,11L,7L,5L,11L,9L,9L,9L,11L,4L,14L,14L,9L,8L,9L,7L,11L,8L,12L,12L,10L,9L,11L,17L,10L,12L,16L,7L,13L,14L,8L,15L,9L,11L,23L,16L,9L,17L,23L,8L,15L,15L,11L,21L,18L,12L,19L,14L,15L,19L,21L,17L,16L,23L,13L,21L,20L,17L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218656Inst : IEnumerable<long>
{
public static readonly long[] Value=A218656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218656.Bytes);
public long this[int i]=>Value[i];

public static A218656Inst Instance=new A218656Inst();

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