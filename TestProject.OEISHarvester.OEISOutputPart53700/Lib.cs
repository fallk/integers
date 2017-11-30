using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A061245
{
public static readonly long[] Value={ 3L,5L,7L,11L,31L,53L,71L,73L,97L,311L,331L,733L,751L,773L,911L,953L,971L,977L,991L,997L,3331L,5333L,5531L,7331L,7333L,7753L,9311L,9511L,9533L,9551L,9733L,9931L,9973L,33311L,33331L,55331L,55333L,55511L,73331L,75511L,75533L,75553L,77551L,77711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061245Inst : IEnumerable<long>
{
public static readonly long[] Value=A061245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061245.Bytes);
public long this[int i]=>Value[i];

public static A061245Inst Instance=new A061245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061246
{
public static readonly long[] Value={ 11L,19L,41L,101L,109L,149L,191L,199L,401L,409L,419L,449L,491L,499L,911L,919L,941L,991L,1009L,1019L,1049L,1091L,1109L,1409L,1499L,1901L,1949L,1999L,4001L,4019L,4049L,4091L,4099L,4111L,4409L,4441L,4909L,4919L,4999L,9001L,9011L,9041L,9049L,9091L,9109L,9199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061246Inst : IEnumerable<long>
{
public static readonly long[] Value=A061246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061246.Bytes);
public long this[int i]=>Value[i];

public static A061246Inst Instance=new A061246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061247
{
public static readonly long[] Value={ 11L,101L,181L,811L,881L,1181L,1801L,1811L,8011L,8081L,8101L,8111L,10111L,10181L,11801L,18181L,80111L,81001L,81101L,81181L,88001L,88801L,88811L,100801L,100811L,101081L,101111L,108011L,108881L,110881L,118081L,118801L,180001L,180181L,180811L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061247Inst : IEnumerable<long>
{
public static readonly long[] Value=A061247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061247.Bytes);
public long this[int i]=>Value[i];

public static A061247Inst Instance=new A061247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061248
{
public static readonly long[] Value={ 2L,3L,5L,7L,17L,19L,29L,59L,79L,89L,199L,389L,499L,599L,997L,1889L,1999L,2999L,4999L,6899L,8999L,29989L,39989L,49999L,59999L,79999L,98999L,199999L,389999L,598999L,599999L,799999L,989999L,2998999L,2999999L,4999999L,6999899L,8989999L,9899999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061248Inst : IEnumerable<long>
{
public static readonly long[] Value=A061248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061248.Bytes);
public long this[int i]=>Value[i];

public static A061248Inst Instance=new A061248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061249
{
public static readonly BigInteger[] Value={ 0L,1L,1L,2L,3L,5L,8L,49L,399L,7999L,1999999L,8999999999L,9999999999999999L,BigInteger.Parse("89999999999999999999999999"),BigInteger.Parse("899999999999999999999999999999999999999999"),BigInteger.Parse("79999999999999999999999999999999999999999999999999999999999999999999") };
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
public class A061249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061249Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A061249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061249.Bytes);
public BigInteger this[int i]=>Value[i];

public static A061249Inst Instance=new A061249Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061250
{
public static readonly BigInteger[] Value={ 0L,0L,8L,162L,3072L,62500L,1399680L,34588806L,939524096L,27894275208L,900000000000L,31384283767210L,1176925259169792L,47248516628391468L,2022385242251558912L,BigInteger.Parse("91957716979980468750"),BigInteger.Parse("4427218577690292387840"),BigInteger.Parse("225009351233083599856144"),BigInteger.Parse("12040000871040740498079744") };
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
public class A061250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061250Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A061250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061250.Bytes);
public BigInteger this[int i]=>Value[i];

public static A061250Inst Instance=new A061250Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061251
{
public static readonly long[] Value={ 0L,31L,59L,90L,120L,151L,181L,212L,243L,273L,304L,334L,365L,396L,424L,455L,485L,516L,546L,577L,608L,638L,669L,699L,730L,761L,789L,820L,850L,881L,911L,942L,973L,1003L,1034L,1064L,1095L,1126L,1155L,1186L,1216L,1247L,1277L,1308L,1339L,1369L,1400L,1430L,1461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061251Inst : IEnumerable<long>
{
public static readonly long[] Value=A061251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061251.Bytes);
public long this[int i]=>Value[i];

public static A061251Inst Instance=new A061251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061252
{
public static readonly ulong[] Value={ 0L,1L,31L,721L,14911L,289201L,5386591L,97576081L,1732076671L,30276117361L,522861237151L,8942430185041L,151728638820031L,2557404559011121L,42864668012537311L,715027614225987601L,11878335717996660991UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061252Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A061252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061252.Bytes);
public ulong this[int i]=>Value[i];

public static A061252Inst Instance=new A061252Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061253
{
public static readonly long[] Value={ 5L,33L,261L,2241L,19845L,177633L,1595781L,14353281L,129153285L,1162300833L,10460471301L,94143533121L,847289672325L,7625600673633L,68630386930821L,617673424981761L,5559060652648965L,50031545357280033L,450283906665838341L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061253Inst : IEnumerable<long>
{
public static readonly long[] Value=A061253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061253.Bytes);
public long this[int i]=>Value[i];

public static A061253Inst Instance=new A061253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061254
{
public static readonly long[] Value={ 9L,15L,21L,33L,35L,39L,45L,51L,63L,65L,75L,93L,105L,111L,119L,121L,123L,135L,145L,185L,195L,201L,207L,209L,225L,231L,235L,245L,285L,287L,299L,301L,321L,335L,363L,399L,423L,453L,473L,693L,707L,771L,1047L,1113L,1215L,1365L,1371L,1387L,1533L,1537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061254Inst : IEnumerable<long>
{
public static readonly long[] Value=A061254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061254.Bytes);
public long this[int i]=>Value[i];

public static A061254Inst Instance=new A061254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061255
{
public static readonly long[] Value={ 1L,1L,2L,4L,7L,13L,21L,37L,60L,98L,157L,251L,392L,612L,943L,1439L,2187L,3293L,4930L,7330L,10839L,15935L,23315L,33933L,49170L,70914L,101861L,145713L,207638L,294796L,417061L,588019L,826351L,1157651L,1616849L,2251623L,3126775L,4330271L,5981190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061255Inst : IEnumerable<long>
{
public static readonly long[] Value=A061255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061255.Bytes);
public long this[int i]=>Value[i];

public static A061255Inst Instance=new A061255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061256
{
public static readonly long[] Value={ 1L,1L,4L,8L,21L,39L,92L,170L,360L,667L,1316L,2393L,4541L,8100L,14824L,26071L,46422L,80314L,139978L,238641L,408201L,686799L,1156062L,1920992L,3189144L,5238848L,8589850L,13963467L,22641585L,36447544L,58507590L,93334008L,148449417L,234829969L,370345918L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061256Inst : IEnumerable<long>
{
public static readonly long[] Value=A061256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061256.Bytes);
public long this[int i]=>Value[i];

public static A061256Inst Instance=new A061256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061257
{
public static readonly long[] Value={ 1L,1L,2L,4L,7L,13L,21L,37L,58L,96L,153L,243L,376L,584L,897L,1353L,2046L,3060L,4552L,6714L,9862L,14386L,20898L,30198L,43427L,62159L,88600L,125804L,177881L,250615L,351819L,492203L,686294L,953954L,1321902L,1826394L,2516364L,3457332L,4737576L,6475332L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061257Inst : IEnumerable<long>
{
public static readonly long[] Value=A061257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061257.Bytes);
public long this[int i]=>Value[i];

public static A061257Inst Instance=new A061257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061258
{
public static readonly long[] Value={ 1L,3L,7L,11L,21L,21L,43L,27L,61L,63L,111L,53L,157L,129L,87L,91L,273L,183L,343L,151L,175L,333L,507L,117L,521L,471L,547L,305L,813L,261L,931L,347L,447L,819L,483L,431L,1333L,1029L,631L,327L,1641L,525L,1807L,781L,681L,1521L,2163L,373L,2101L,1563L,1095L,1103L,2757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061258Inst : IEnumerable<long>
{
public static readonly long[] Value=A061258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061258.Bytes);
public long this[int i]=>Value[i];

public static A061258Inst Instance=new A061258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061259
{
public static readonly long[] Value={ 1L,5L,10L,25L,36L,80L,106L,201L,280L,460L,617L,1024L,1314L,2000L,2685L,3897L,5050L,7280L,9311L,13020L,16747L,22665L,28866L,39000L,48986L,64654L,81550L,106124L,132386L,171295L,212103L,271065L,335345L,423594L,521046L,655396L,800570L,997885L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061259Inst : IEnumerable<long>
{
public static readonly long[] Value=A061259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061259.Bytes);
public long this[int i]=>Value[i];

public static A061259Inst Instance=new A061259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061260
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,1L,5L,6L,2L,1L,7L,11L,6L,2L,1L,11L,23L,15L,6L,2L,1L,15L,40L,32L,15L,6L,2L,1L,22L,73L,67L,37L,15L,6L,2L,1L,30L,120L,134L,79L,37L,15L,6L,2L,1L,42L,202L,255L,172L,85L,37L,15L,6L,2L,1L,56L,320L,470L,348L,187L,85L,37L,15L,6L,2L,1L,77L,511L,848L,697L,397L,194L,85L,37L,15L,6L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061260Inst : IEnumerable<long>
{
public static readonly long[] Value=A061260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061260.Bytes);
public long this[int i]=>Value[i];

public static A061260Inst Instance=new A061260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061261
{
public static readonly long[] Value={ 1L,2L,6L,15L,37L,85L,194L,423L,912L,1917L,3974L,8096L,16302L,32382L,63668L,123851L,238756L,456190L,864821L,1627016L,3039845L,5641884L,10406924L,19083836L,34802782L,63135539L,113965033L,204739662L,366156396L,652001918L,1156200929L,2042173379L,3593341512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061261Inst : IEnumerable<long>
{
public static readonly long[] Value=A061261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061261.Bytes);
public long this[int i]=>Value[i];

public static A061261Inst Instance=new A061261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061262
{
public static readonly long[] Value={ 0L,3L,12L,21L,52L,57L,91L,121L,136L,211L,192L,226L,409L,331L,367L,406L,511L,507L,886L,637L,772L,721L,871L,952L,1102L,1066L,1227L,1192L,1641L,1621L,1396L,1381L,1501L,1732L,1792L,1927L,1942L,2401L,2611L,2551L,2422L,2557L,2887L,2821L,3136L,3271L,3607L,3376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061262Inst : IEnumerable<long>
{
public static readonly long[] Value=A061262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061262.Bytes);
public long this[int i]=>Value[i];

public static A061262Inst Instance=new A061262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061263
{
public static readonly long[] Value={ 0L,0L,0L,3L,7L,13L,24L,38L,56L,81L,111L,147L,192L,244L,304L,375L,455L,545L,648L,762L,888L,1029L,1183L,1351L,1536L,1736L,1952L,2187L,2439L,2709L,3000L,3310L,3640L,3993L,4367L,4763L,5184L,5628L,6096L,6591L,7111L,7657L,8232L,8834L,9464L,10125L,10815L,11535L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061263Inst : IEnumerable<long>
{
public static readonly long[] Value=A061263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061263.Bytes);
public long this[int i]=>Value[i];

public static A061263Inst Instance=new A061263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061264
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,2L,0L,2L,1L,0L,1L,2L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,2L,1L,0L,1L,1L,0L,2L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,2L,0L,2L,1L,0L,1L,0L,0L,2L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,2L,1L,0L,0L,2L,0L,2L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061264Inst : IEnumerable<long>
{
public static readonly long[] Value=A061264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061264.Bytes);
public long this[int i]=>Value[i];

public static A061264Inst Instance=new A061264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061265
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061265Inst : IEnumerable<long>
{
public static readonly long[] Value=A061265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061265.Bytes);
public long this[int i]=>Value[i];

public static A061265Inst Instance=new A061265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061266
{
public static readonly long[] Value={ 1L,3L,2L,3L,3L,4L,4L,4L,4L,5L,5L,5L,6L,6L,5L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,9L,8L,9L,9L,8L,9L,9L,9L,9L,10L,10L,9L,10L,10L,10L,11L,10L,10L,10L,11L,10L,11L,11L,11L,12L,11L,11L,12L,11L,12L,12L,12L,11L,12L,12L,12L,12L,13L,12L,13L,12L,13L,13L,13L,13L,13L,13L,14L,13L,13L,13L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061266Inst : IEnumerable<long>
{
public static readonly long[] Value=A061266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061266.Bytes);
public long this[int i]=>Value[i];

public static A061266Inst Instance=new A061266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061267
{
public static readonly long[] Value={ 1L,4L,9L,144L,441L,14884L,44944L,48841L,132496L,214369L,268324L,288369L,294849L,346921L,436921L,511225L,617796L,938961L,1234321L,1336336L,1833316L,2325625L,2356225L,2585664L,2614689L,2778889L,2862864L,3323329L,3767481L,4691556L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061267Inst : IEnumerable<long>
{
public static readonly long[] Value=A061267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061267.Bytes);
public long this[int i]=>Value[i];

public static A061267Inst Instance=new A061267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061268
{
public static readonly long[] Value={ 1L,2L,3L,12L,21L,122L,212L,221L,364L,463L,518L,537L,543L,589L,661L,715L,786L,969L,1111L,1156L,1354L,1525L,1535L,1608L,1617L,1667L,1692L,1823L,1941L,2166L,2235L,2337L,2379L,2515L,2943L,2963L,3371L,3438L,3631L,3828L,4018L,4077L,4119L,4271L,4338L,4341L,4471L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061268Inst : IEnumerable<long>
{
public static readonly long[] Value=A061268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061268.Bytes);
public long this[int i]=>Value[i];

public static A061268Inst Instance=new A061268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061269
{
public static readonly long[] Value={ 1L,4L,9L,144L,441L,44944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061269Inst : IEnumerable<long>
{
public static readonly long[] Value=A061269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061269.Bytes);
public long this[int i]=>Value[i];

public static A061269Inst Instance=new A061269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061270
{
public static readonly long[] Value={ 1L,4L,9L,100L,144L,400L,441L,900L,10000L,10404L,14400L,40000L,40401L,44100L,44944L,90000L,1000000L,1004004L,1040400L,1440000L,4000000L,4004001L,4040100L,4410000L,4494400L,9000000L,9941409L,11909401L,100000000L,100040004L,100400400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061270Inst : IEnumerable<long>
{
public static readonly long[] Value=A061270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061270.Bytes);
public long this[int i]=>Value[i];

public static A061270Inst Instance=new A061270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061271
{
public static readonly long[] Value={ 1L,4L,9L,144L,441L,44944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061271Inst : IEnumerable<long>
{
public static readonly long[] Value=A061271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061271.Bytes);
public long this[int i]=>Value[i];

public static A061271Inst Instance=new A061271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061272
{
public static readonly long[] Value={ 0L,1L,4L,9L,100L,400L,900L,1444L,10000L,40000L,90000L,144400L,1000000L,4000000L,9000000L,14440000L,94109401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061272Inst : IEnumerable<long>
{
public static readonly long[] Value=A061272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061272.Bytes);
public long this[int i]=>Value[i];

public static A061272Inst Instance=new A061272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061273
{
public static readonly long[] Value={ 1L,3L,4L,8L,18L,45L,104L,246L,590L,1447L,3582L,8864L,22216L,55989L,141738L,360486L,920892L,2360953L,6073160L,15664216L,40510215L,105017120L,272821646L,710143301L,1851830021L,4836984396L,12653549540L,33148606878L,86954036990L,228373959896L,600482317125L,1580587864193L,4164596465439L,10983396620288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061273Inst : IEnumerable<long>
{
public static readonly long[] Value=A061273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061273.Bytes);
public long this[int i]=>Value[i];

public static A061273Inst Instance=new A061273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061274
{
public static readonly long[] Value={ 2L,2L,7L,14L,37L,100L,271L,742L,2054L,5813L,16507L,47501L,137306L,399685L,1169789L,3438915L,10153559L,30083443L,89426830L,266598341L,796863253L,2387439540L,7168302094L,21565117858L,64993345011L,196202749033L,593205591259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061274Inst : IEnumerable<long>
{
public static readonly long[] Value=A061274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061274.Bytes);
public long this[int i]=>Value[i];

public static A061274Inst Instance=new A061274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061275
{
public static readonly long[] Value={ 17L,47L,71L,283L,881L,1151L,1913L,2591L,3527L,4049L,6047L,7193L,7433L,15137L,20807L,21617L,24197L,26903L,28793L,34847L,46817L,53129L,56443L,69191L,74489L,83231L,84047L,98563L,103049L,103967L,109507L,110441L,112337L,136237L,149057L,151247L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061275Inst : IEnumerable<long>
{
public static readonly long[] Value=A061275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061275.Bytes);
public long this[int i]=>Value[i];

public static A061275Inst Instance=new A061275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061276
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,197L,198L,199L,285L,373L,461L,554L,1098L,1099L,1185L,1186L,1187L,1276L,1278L,1365L,1366L,1453L,1454L,1458L,1459L,1543L,2176L,2261L,2263L,2354L,2357L,2359L,2532L,2621L,2623L,2996L,2997L,2999L,3254L,3259L,3340L,3341L,3342L,3343L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061276Inst : IEnumerable<long>
{
public static readonly long[] Value=A061276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061276.Bytes);
public long this[int i]=>Value[i];

public static A061276Inst Instance=new A061276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061277
{
public static readonly long[] Value={ 109L,173L,235L,264L,1049L,1235L,1485L,1489L,1490L,1498L,1703L,1730L,1823L,1834L,2107L,2108L,2350L,2357L,2435L,2538L,2581L,2640L,2830L,2978L,2980L,2983L,3114L,3148L,3157L,3408L,4827L,5162L,5470L,5480L,5962L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061277Inst : IEnumerable<long>
{
public static readonly long[] Value=A061277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061277.Bytes);
public long this[int i]=>Value[i];

public static A061277Inst Instance=new A061277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061278
{
public static readonly long[] Value={ 0L,1L,5L,20L,76L,285L,1065L,3976L,14840L,55385L,206701L,771420L,2878980L,10744501L,40099025L,149651600L,558507376L,2084377905L,7779004245L,29031639076L,108347552060L,404358569165L,1509086724601L,5631988329240L,21018866592360L,78443478040201L,292755045568445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061278Inst : IEnumerable<long>
{
public static readonly long[] Value=A061278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061278.Bytes);
public long this[int i]=>Value[i];

public static A061278Inst Instance=new A061278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061279
{
public static readonly long[] Value={ 1L,2L,3L,6L,10L,18L,32L,56L,100L,176L,312L,552L,976L,1728L,3056L,5408L,9568L,16928L,29952L,52992L,93760L,165888L,293504L,519296L,918784L,1625600L,2876160L,5088768L,9003520L,15929856L,28184576L,49866752L,88228864L,156102656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061279Inst : IEnumerable<long>
{
public static readonly long[] Value=A061279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061279.Bytes);
public long this[int i]=>Value[i];

public static A061279Inst Instance=new A061279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061280
{
public static readonly long[] Value={ 10L,5L,7L,7L,5L,2L,3L,7L,3L,2L,11L,7L,6L,25L,7L,11L,4L,8L,5L,7L,6L,6L,6L,3L,4L,9L,17L,3L,6L,13L,8L,5L,8L,5L,2L,2L,2L,8L,6L,6L,5L,4L,7L,2L,6L,9L,8L,6L,2L,4L,2L,8L,6L,5L,5L,5L,3L,8L,4L,2L,3L,3L,6L,5L,6L,12L,2L,6L,3L,5L,3L,2L,2L,6L,5L,6L,3L,3L,4L,3L,4L,2L,3L,4L,2L,4L,3L,7L,2L,8L,8L,4L,2L,6L,3L,4L,7L,6L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061280Inst : IEnumerable<long>
{
public static readonly long[] Value=A061280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061280.Bytes);
public long this[int i]=>Value[i];

public static A061280Inst Instance=new A061280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061281
{
public static readonly long[] Value={ 112L,147L,185L,224L,273L,283L,294L,331L,331L,336L,370L,403L,441L,448L,485L,520L,546L,555L,559L,560L,566L,588L,592L,637L,645L,662L,662L,672L,691L,735L,740L,784L,806L,819L,849L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061281Inst : IEnumerable<long>
{
public static readonly long[] Value=A061281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061281.Bytes);
public long this[int i]=>Value[i];

public static A061281Inst Instance=new A061281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061282
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,4L,3L,4L,5L,3L,4L,5L,4L,5L,6L,5L,6L,7L,4L,5L,6L,5L,6L,7L,6L,7L,8L,4L,5L,6L,5L,6L,7L,6L,7L,8L,5L,6L,7L,6L,7L,8L,7L,8L,9L,6L,7L,8L,7L,8L,9L,8L,9L,10L,5L,6L,7L,6L,7L,8L,7L,8L,9L,6L,7L,8L,7L,8L,9L,8L,9L,10L,7L,8L,9L,8L,9L,10L,9L,10L,11L,5L,6L,7L,6L,7L,8L,7L,8L,9L,6L,7L,8L,7L,8L,9L,8L,9L,10L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061282Inst : IEnumerable<long>
{
public static readonly long[] Value=A061282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061282.Bytes);
public long this[int i]=>Value[i];

public static A061282Inst Instance=new A061282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061283
{
public static readonly long[] Value={ 1L,4L,16L,64L,36L,1024L,4096L,144L,65536L,262144L,576L,4194304L,1296L,900L,268435456L,1073741824L,9216L,5184L,68719476736L,36864L,1099511627776L,4398046511104L,3600L,70368744177664L,46656L,589824L,4503599627370496L,82944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061283Inst : IEnumerable<long>
{
public static readonly long[] Value=A061283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061283.Bytes);
public long this[int i]=>Value[i];

public static A061283Inst Instance=new A061283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061284
{
public static readonly long[] Value={ 1L,2L,4L,8L,6L,32L,64L,12L,256L,512L,24L,2048L,36L,30L,16384L,32768L,96L,72L,262144L,192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061284Inst : IEnumerable<long>
{
public static readonly long[] Value=A061284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061284.Bytes);
public long this[int i]=>Value[i];

public static A061284Inst Instance=new A061284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061285
{
public static readonly long[] Value={ 2L,4L,8L,32L,64L,256L,512L,2048L,16384L,32768L,262144L,1048576L,2097152L,8388608L,67108864L,536870912L,1073741824L,8589934592L,34359738368L,68719476736L,549755813888L,2199023255552L,17592186044416L,281474976710656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061285Inst : IEnumerable<long>
{
public static readonly long[] Value=A061285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061285.Bytes);
public long this[int i]=>Value[i];

public static A061285Inst Instance=new A061285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061286
{
public static readonly long[] Value={ 2L,4L,16L,64L,1024L,4096L,65536L,262144L,4194304L,268435456L,1073741824L,68719476736L,1099511627776L,4398046511104L,70368744177664L,4503599627370496L,288230376151711744L,1152921504606846976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061286Inst : IEnumerable<long>
{
public static readonly long[] Value=A061286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061286.Bytes);
public long this[int i]=>Value[i];

public static A061286Inst Instance=new A061286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061287
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,2L,3L,4L,5L,7L,9L,12L,15L,19L,24L,31L,39L,50L,64L,82L,104L,133L,169L,215L,273L,348L,443L,563L,717L,912L,1160L,1475L,1877L,2388L,3037L,3863L,4915L,6252L,7952L,10116L,12867L,16368L,20820L,26484L,33688L,42852L,54508L,69336L,88197L,112188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061287Inst : IEnumerable<long>
{
public static readonly long[] Value=A061287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061287.Bytes);
public long this[int i]=>Value[i];

public static A061287Inst Instance=new A061287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061288
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,4L,5L,6L,6L,7L,8L,8L,9L,10L,10L,11L,12L,13L,13L,14L,15L,15L,16L,17L,18L,18L,19L,20L,20L,21L,22L,22L,23L,24L,25L,25L,26L,27L,27L,28L,29L,30L,30L,31L,32L,32L,33L,34L,35L,35L,36L,37L,37L,38L,39L,39L,40L,41L,42L,42L,43L,44L,44L,45L,46L,47L,47L,48L,49L,49L,50L,51L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061288Inst : IEnumerable<long>
{
public static readonly long[] Value=A061288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061288.Bytes);
public long this[int i]=>Value[i];

public static A061288Inst Instance=new A061288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061289
{
public static readonly long[] Value={ 3L,7L,13L,17L,20L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061289Inst : IEnumerable<long>
{
public static readonly long[] Value=A061289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061289.Bytes);
public long this[int i]=>Value[i];

public static A061289Inst Instance=new A061289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061290
{
public static readonly long[] Value={ 1L,0L,2L,0L,1L,4L,0L,0L,3L,8L,0L,0L,1L,7L,16L,0L,0L,1L,4L,15L,32L,0L,0L,0L,4L,11L,31L,64L,0L,0L,0L,1L,11L,26L,63L,128L,0L,0L,0L,1L,5L,26L,57L,127L,256L,0L,0L,0L,1L,5L,16L,57L,120L,255L,512L,0L,0L,0L,1L,5L,16L,42L,120L,247L,511L,1024L,0L,0L,0L,0L,5L,16L,42L,99L,247L,502L,1023L,2048L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061290Inst : IEnumerable<long>
{
public static readonly long[] Value=A061290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061290.Bytes);
public long this[int i]=>Value[i];

public static A061290Inst Instance=new A061290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061291
{
public static readonly BigInteger[] Value={ 1L,1L,2L,4L,14L,150L,18406L,311742406L,96402927697811206L,BigInteger.Parse("9292975819514867485089851568784006") };
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
public class A061291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061291Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A061291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061291.Bytes);
public BigInteger this[int i]=>Value[i];

public static A061291Inst Instance=new A061291Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061292
{
public static readonly BigInteger[] Value={ 2L,2L,2L,2L,6L,22L,262L,34582L,199330642L,1806032092550706L,BigInteger.Parse("12449434806576800059248920402"),BigInteger.Parse("4481765860945171681908664776799089162954814190172722") };
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
public class A061292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061292Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A061292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061292.Bytes);
public BigInteger this[int i]=>Value[i];

public static A061292Inst Instance=new A061292Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061293
{
public static readonly long[] Value={ 1L,6L,19L,43L,79L,130L,198L,285L,392L,522L,677L,858L,1066L,1304L,1573L,1875L,2211L,2583L,2992L,3440L,3927L,4457L,5029L,5646L,6309L,7019L,7777L,8585L,9445L,10356L,11322L,12343L,13419L,14554L,15747L,17000L,18315L,19692L,21133L,22638L,24210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061293Inst : IEnumerable<long>
{
public static readonly long[] Value=A061293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061293.Bytes);
public long this[int i]=>Value[i];

public static A061293Inst Instance=new A061293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061294
{
public static readonly long[] Value={ 1L,8L,31L,77L,156L,278L,451L,687L,995L,1385L,1869L,2456L,3159L,3987L,4952L,6065L,7337L,8781L,10406L,12226L,14251L,16494L,18966L,21680L,24646L,27878L,31387L,35186L,39287L,43703L,48445L,53526L,58959L,64756L,70930L,77494L,84459L,91840L,99649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061294Inst : IEnumerable<long>
{
public static readonly long[] Value=A061294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061294.Bytes);
public long this[int i]=>Value[i];

public static A061294Inst Instance=new A061294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061295
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,4L,3L,4L,4L,3L,4L,5L,4L,5L,6L,5L,6L,5L,4L,5L,6L,5L,6L,6L,5L,6L,5L,4L,5L,6L,5L,6L,7L,6L,7L,6L,5L,6L,7L,6L,7L,8L,7L,8L,7L,6L,7L,8L,7L,8L,7L,6L,7L,6L,5L,6L,7L,6L,7L,8L,7L,8L,7L,6L,7L,8L,7L,8L,8L,7L,8L,7L,6L,7L,8L,7L,8L,7L,6L,7L,6L,5L,6L,7L,6L,7L,8L,7L,8L,7L,6L,7L,8L,7L,8L,9L,8L,9L,8L,7L,8L,9L,8L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061295Inst : IEnumerable<long>
{
public static readonly long[] Value=A061295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061295.Bytes);
public long this[int i]=>Value[i];

public static A061295Inst Instance=new A061295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061296
{
public static readonly BigInteger[] Value={ 1L,2L,6L,73L,15659L,2912352376L,BigInteger.Parse("160079598016236547942"),BigInteger.Parse("788718822327668144653795722064792832796269"),BigInteger.Parse("1892598445861688666926004180803401127603616204472788979097401996641100427218778852302757") };
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
public class A061296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061296Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A061296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061296.Bytes);
public BigInteger this[int i]=>Value[i];

public static A061296Inst Instance=new A061296Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061297
{
public static readonly long[] Value={ 1L,2L,4L,8L,14L,32L,39L,114L,166L,266L,421L,1608L,1005L,3980L,6894L,4206L,8666L,40904L,49559L,315478L,162321L,79180L,269878L,1647124L,937553L,1810092L,8445654L,7791356L,3978238L,33071544L,19578861L,283536170L,327438714L,117635956L,742042967L,154748984L,88779589L,1532487536L,10514107742L,3761632498L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061297Inst : IEnumerable<long>
{
public static readonly long[] Value=A061297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061297.Bytes);
public long this[int i]=>Value[i];

public static A061297Inst Instance=new A061297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061298
{
public static readonly long[] Value={ 1L,1L,1L,-2L,2L,1L,4L,1L,3L,1L,-8L,2L,6L,4L,1L,16L,1L,12L,13L,5L,1L,-32L,2L,24L,40L,22L,6L,1L,64L,1L,48L,121L,92L,33L,7L,1L,-128L,2L,96L,364L,376L,174L,46L,8L,1L,256L,1L,192L,1093L,1520L,897L,292L,61L,9L,1L,-512L,2L,384L,3280L,6112L,4566L,1816L,452L,78L,10L,1L,1024L,1L,768L,9841L,24512L,23073L,11152L,3289L,660L,97L,11L,1L,-2048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061298Inst : IEnumerable<long>
{
public static readonly long[] Value=A061298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061298.Bytes);
public long this[int i]=>Value[i];

public static A061298Inst Instance=new A061298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061299
{
public static readonly long[] Value={ 720L,2880L,46080L,25920L,184320L,2949120L,129600L,414720L,11796480L,1658880L,188743680L,3732480L,2073600L,26542080L,12079595520L,14929920L,48318382080L,106168320L,8294400L,3092376453120L,1698693120L,18662400L,238878720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061299Inst : IEnumerable<long>
{
public static readonly long[] Value=A061299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061299.Bytes);
public long this[int i]=>Value[i];

public static A061299Inst Instance=new A061299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061300
{
public static readonly BigInteger[] Value={ 1L,1L,2L,12L,360L,55440L,61261200L,293318625600L,6064949221531200L,BigInteger.Parse("1315675499575984747200"),BigInteger.Parse("1130066578473302698988760000"),BigInteger.Parse("8029566026151577210973143393920000") };
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
public class A061300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061300Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A061300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061300.Bytes);
public BigInteger this[int i]=>Value[i];

public static A061300Inst Instance=new A061300Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061301
{
public static readonly BigInteger[] Value={ 1L,2L,16L,4096L,4294967296L,BigInteger.Parse("1208925819614629174706176"),BigInteger.Parse("6277101735386680763835789423207666416102355444464034512896") };
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
public class A061301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061301Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A061301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061301.Bytes);
public BigInteger this[int i]=>Value[i];

public static A061301Inst Instance=new A061301Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061302
{
public static readonly BigInteger[] Value={ 0L,2L,6L,36L,320L,3750L,54432L,941192L,18874368L,430467210L,11000000000L,311249095212L,9659108818944L,326173191714734L,11905721598812160L,467086816406250000L,BigInteger.Parse("19599665578316398592"),BigInteger.Parse("875901453762003632658") };
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
public class A061302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061302Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A061302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061302.Bytes);
public BigInteger this[int i]=>Value[i];

public static A061302Inst Instance=new A061302Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061303
{
public static readonly long[] Value={ 2L,5L,13L,17L,19L,31L,37L,41L,43L,61L,67L,71L,73L,79L,89L,97L,101L,109L,113L,127L,131L,137L,139L,151L,157L,163L,181L,193L,197L,199L,211L,223L,229L,233L,239L,241L,251L,257L,271L,277L,281L,307L,313L,331L,337L,349L,353L,373L,379L,397L,401L,409L,419L,421L,431L,433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061303Inst : IEnumerable<long>
{
public static readonly long[] Value=A061303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061303.Bytes);
public long this[int i]=>Value[i];

public static A061303Inst Instance=new A061303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061304
{
public static readonly long[] Value={ 1L,3L,6L,10L,15L,21L,55L,66L,78L,91L,105L,190L,210L,231L,253L,406L,435L,465L,561L,595L,703L,741L,861L,903L,946L,1081L,1326L,1378L,1653L,1711L,1770L,1830L,1891L,2145L,2211L,2278L,2346L,2415L,2485L,2701L,2926L,3003L,3081L,3403L,3486L,3570L,3655L,3741L,4186L,4278L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061304Inst : IEnumerable<long>
{
public static readonly long[] Value=A061304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061304.Bytes);
public long this[int i]=>Value[i];

public static A061304Inst Instance=new A061304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061305
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,13L,21L,34L,55L,89L,233L,377L,610L,987L,1597L,4181L,6765L,10946L,17711L,28657L,121393L,196418L,317811L,514229L,1346269L,2178309L,3524578L,5702887L,9227465L,24157817L,39088169L,63245986L,102334155L,165580141L,433494437L,701408733L,1134903170L,1836311903L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061305Inst : IEnumerable<long>
{
public static readonly long[] Value=A061305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061305.Bytes);
public long this[int i]=>Value[i];

public static A061305Inst Instance=new A061305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061306
{
public static readonly BigInteger[] Value={ 1L,2L,52L,1382958545L,BigInteger.Parse("58205338024195872785464627063218599149503972126463") };
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
public class A061306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061306Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A061306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061306.Bytes);
public BigInteger this[int i]=>Value[i];

public static A061306Inst Instance=new A061306Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061307
{
public static readonly long[] Value={ 1L,1L,2L,12L,360L,55440L,61261200L,293318625600L,6064949221531200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061307Inst : IEnumerable<long>
{
public static readonly long[] Value=A061307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061307.Bytes);
public long this[int i]=>Value[i];

public static A061307Inst Instance=new A061307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061308
{
public static readonly long[] Value={ 3L,107L,10973L,37039L,186619L,2125757L,2634011L,5323949L,5470519L,6406447L,7443463L,8001491L,12967153L,20353771L,27435973L,29659499L,57395627L,66325487L,99588343L,104792291L,129847021L,134793059L,153090997L,172974199L,186623993L,271669247L,283831771L,343064479L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061308Inst : IEnumerable<long>
{
public static readonly long[] Value=A061308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061308.Bytes);
public long this[int i]=>Value[i];

public static A061308Inst Instance=new A061308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061309
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,-1L,0L,0L,4L,0L,-1L,1L,0L,0L,2L,-1L,0L,1L,0L,0L,-1L,0L,1L,1L,0L,-1L,1L,0L,0L,1L,-1L,0L,2L,0L,0L,-1L,2L,0L,1L,0L,-1L,4L,0L,1L,1L,-1L,0L,1L,0L,0L,-1L,0L,0L,2L,0L,-1L,1L,3L,3L,1L,-1L,0L,1L,0L,4L,-1L,0L,0L,2L,2L,-1L,5L,0L,0L,1L,-1L,0L,4L,2L,0L,-1L,0L,3L,1L,0L,-1L,4L,0L,0L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061309Inst : IEnumerable<long>
{
public static readonly long[] Value=A061309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061309.Bytes);
public long this[int i]=>Value[i];

public static A061309Inst Instance=new A061309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061310
{
public static readonly long[] Value={ 284L,307L,309L,314L,317L,379L,394L,398L,403L,411L,417L,423L,429L,431L,433L,435L,436L,437L,439L,441L,442L,443L,445L,446L,447L,449L,451L,453L,454L,457L,458L,459L,461L,463L,464L,466L,467L,469L,471L,473L,474L,487L,489L,491L,493L,494L,496L,499L,502L,506L,509L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061310Inst : IEnumerable<long>
{
public static readonly long[] Value=A061310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061310.Bytes);
public long this[int i]=>Value[i];

public static A061310Inst Instance=new A061310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061311
{
public static readonly long[] Value={ 1L,2L,2L,2L,5L,2L,14L,6L,8L,10L,21L,2L,29L,14L,5L,6L,26L,8L,63L,0L,16L,38L,109L,6L,0L,30L,18L,16L,41L,10L,25L,6L,38L,26L,30L,0L,29L,66L,29L,0L,3L,16L,37L,56L,10L,110L,8L,6L,16L,0L,26L,0L,129L,18L,65L,16L,63L,140L,184L,0L,59L,30L,29L,6L,30L,38L,51L,26L,109L,30L,26L,0L,14L,30L,0L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061311Inst : IEnumerable<long>
{
public static readonly long[] Value=A061311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061311.Bytes);
public long this[int i]=>Value[i];

public static A061311Inst Instance=new A061311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061312
{
public static readonly long[] Value={ 0L,1L,1L,4L,3L,2L,18L,14L,11L,9L,96L,78L,64L,53L,44L,600L,504L,426L,362L,309L,265L,4320L,3720L,3216L,2790L,2428L,2119L,1854L,35280L,30960L,27240L,24024L,21234L,18806L,16687L,14833L,322560L,287280L,256320L,229080L,205056L,183822L,165016L,148329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061312Inst : IEnumerable<long>
{
public static readonly long[] Value=A061312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061312.Bytes);
public long this[int i]=>Value[i];

public static A061312Inst Instance=new A061312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061313
{
public static readonly long[] Value={ 0L,1L,3L,2L,5L,4L,4L,3L,7L,6L,6L,5L,6L,5L,5L,4L,9L,8L,8L,7L,8L,7L,7L,6L,8L,7L,7L,6L,7L,6L,6L,5L,11L,10L,10L,9L,10L,9L,9L,8L,10L,9L,9L,8L,9L,8L,8L,7L,10L,9L,9L,8L,9L,8L,8L,7L,9L,8L,8L,7L,8L,7L,7L,6L,13L,12L,12L,11L,12L,11L,11L,10L,12L,11L,11L,10L,11L,10L,10L,9L,12L,11L,11L,10L,11L,10L,10L,9L,11L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061313Inst : IEnumerable<long>
{
public static readonly long[] Value=A061313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061313.Bytes);
public long this[int i]=>Value[i];

public static A061313Inst Instance=new A061313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061314
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,2L,0L,3L,6L,3L,0L,4L,15L,12L,4L,0L,5L,40L,48L,20L,5L,0L,6L,140L,304L,120L,30L,6L,0L,7L,924L,6080L,1720L,255L,42L,7L,0L,8L,24640L,1484736L,186620L,7480L,483L,56L,8L,0L,9L,12415040L,61235956672L,1393267596L,3504380L,26404L,840L,72L,9L,0L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061314Inst : IEnumerable<long>
{
public static readonly long[] Value=A061314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061314.Bytes);
public long this[int i]=>Value[i];

public static A061314Inst Instance=new A061314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061315
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,3L,1L,5L,6L,4L,1L,10L,16L,10L,5L,1L,28L,76L,40L,15L,6L,1L,154L,1216L,430L,85L,21L,7L,1L,3520L,247456L,37324L,1870L,161L,28L,8L,1L,1551880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061315Inst : IEnumerable<long>
{
public static readonly long[] Value=A061315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061315.Bytes);
public long this[int i]=>Value[i];

public static A061315Inst Instance=new A061315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061316
{
public static readonly long[] Value={ 0L,3L,15L,48L,120L,255L,483L,840L,1368L,2115L,3135L,4488L,6240L,8463L,11235L,14640L,18768L,23715L,29583L,36480L,44520L,53823L,64515L,76728L,90600L,106275L,123903L,143640L,165648L,190095L,217155L,247008L,279840L,315843L,355215L,398160L,444888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061316Inst : IEnumerable<long>
{
public static readonly long[] Value=A061316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061316.Bytes);
public long this[int i]=>Value[i];

public static A061316Inst Instance=new A061316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061317
{
public static readonly long[] Value={ 0L,3L,18L,57L,132L,255L,438L,693L,1032L,1467L,2010L,2673L,3468L,4407L,5502L,6765L,8208L,9843L,11682L,13737L,16020L,18543L,21318L,24357L,27672L,31275L,35178L,39393L,43932L,48807L,54030L,59613L,65568L,71907L,78642L,85785L,93348L,101343L,109782L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061317Inst : IEnumerable<long>
{
public static readonly long[] Value=A061317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061317.Bytes);
public long this[int i]=>Value[i];

public static A061317Inst Instance=new A061317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061318
{
public static readonly long[] Value={ 0L,4L,40L,304L,1720L,7480L,26404L,79240L,209304L,499140L,1095160L,2242504L,4332640L,7966504L,14036260L,23829040L,39156304L,62512740L,97268904L,147902080L,220270120L,321933304L,462529540L,654208504L,912130600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061318Inst : IEnumerable<long>
{
public static readonly long[] Value=A061318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061318.Bytes);
public long this[int i]=>Value[i];

public static A061318Inst Instance=new A061318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061319
{
public static readonly long[] Value={ 0L,1L,10L,76L,430L,1870L,6601L,19810L,52326L,124785L,273790L,560626L,1083160L,1991626L,3509065L,5957260L,9789076L,15628185L,24317226L,36975520L,55067530L,80483326L,115632385L,163552126L,228032650L,313759225L,426474126L,573159510L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061319Inst : IEnumerable<long>
{
public static readonly long[] Value=A061319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061319.Bytes);
public long this[int i]=>Value[i];

public static A061319Inst Instance=new A061319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061320
{
public static readonly long[] Value={ 0L,5L,140L,6080L,186620L,3504380L,43599605L,392515340L,2738219580L,15571795365L,74962059260L,314303754380L,1173239918240L,3966582090380L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061320Inst : IEnumerable<long>
{
public static readonly long[] Value=A061320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061320.Bytes);
public long this[int i]=>Value[i];

public static A061320Inst Instance=new A061320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061321
{
public static readonly long[] Value={ 0L,1L,28L,1216L,37324L,700876L,8719921L,78503068L,547643916L,3114359073L,14992411852L,62860750876L,234647983648L,793316418076L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061321Inst : IEnumerable<long>
{
public static readonly long[] Value=A061321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061321.Bytes);
public long this[int i]=>Value[i];

public static A061321Inst Instance=new A061321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061322
{
public static readonly BigInteger[] Value={ 2L,6L,15L,40L,140L,924L,24640L,12415040L,2408343949440L,BigInteger.Parse("71606426901226335015040"),BigInteger.Parse("51274803735606705472274088614112357905277056"),BigInteger.Parse("21728144612603201307908899563300049012978385050783094682272184269369267136230071558272") };
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
public class A061322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061322Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A061322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061322.Bytes);
public BigInteger this[int i]=>Value[i];

public static A061322Inst Instance=new A061322Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061323
{
public static readonly long[] Value={ 313L,337L,1021L,1297L,1783L,1873L,2137L,2971L,3221L,3313L,4051L,4339L,5233L,5531L,5743L,6073L,6301L,6337L,6553L,6793L,7177L,7753L,8233L,9109L,9697L,9829L,9931L,10273L,10781L,11059L,11149L,11257L,11617L,11941L,11971L,12143L,12457L,12577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061323Inst : IEnumerable<long>
{
public static readonly long[] Value=A061323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061323.Bytes);
public long this[int i]=>Value[i];

public static A061323Inst Instance=new A061323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061324
{
public static readonly long[] Value={ 643L,719L,769L,839L,1009L,1129L,1201L,1511L,1597L,1657L,1801L,2399L,2857L,3049L,3191L,3359L,3889L,4079L,4201L,4561L,4591L,4679L,4861L,4871L,4969L,5039L,5351L,5521L,5591L,5689L,5879L,6271L,6719L,8039L,8111L,8231L,8779L,8929L,9551L,9791L,9973L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061324Inst : IEnumerable<long>
{
public static readonly long[] Value=A061324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061324.Bytes);
public long this[int i]=>Value[i];

public static A061324Inst Instance=new A061324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061325
{
public static readonly long[] Value={ 4111L,7841L,10111L,15391L,15991L,16061L,20011L,21031L,22699L,32299L,32957L,35911L,43963L,45127L,45631L,47431L,49831L,51199L,53731L,58111L,59671L,60331L,64231L,74311L,76039L,78079L,81331L,81761L,83311L,83431L,98911L,102871L,104729L,108907L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061325Inst : IEnumerable<long>
{
public static readonly long[] Value=A061325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061325.Bytes);
public long this[int i]=>Value[i];

public static A061325Inst Instance=new A061325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061326
{
public static readonly long[] Value={ 457L,479L,1319L,1321L,1399L,2351L,2953L,3671L,3881L,3911L,4129L,4919L,5519L,5569L,6359L,6599L,6961L,7559L,7561L,8521L,8689L,8951L,9241L,9601L,9769L,10369L,11113L,11251L,12007L,12049L,12239L,12433L,12721L,12799L,12889L,13151L,14159L,14519L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061326Inst : IEnumerable<long>
{
public static readonly long[] Value=A061326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061326.Bytes);
public long this[int i]=>Value[i];

public static A061326Inst Instance=new A061326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061327
{
public static readonly long[] Value={ 1031L,1489L,1871L,3001L,4391L,5641L,6581L,8011L,12541L,12671L,12973L,17209L,17449L,18911L,21319L,21649L,22441L,24001L,24469L,24841L,28751L,31849L,35803L,38281L,38569L,38861L,40429L,40751L,41467L,42409L,43609L,45289L,50587L,51169L,53161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061327Inst : IEnumerable<long>
{
public static readonly long[] Value=A061327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061327.Bytes);
public long this[int i]=>Value[i];

public static A061327Inst Instance=new A061327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061328
{
public static readonly long[] Value={ 439L,3631L,4657L,8681L,16633L,21559L,28393L,30937L,32257L,32353L,33811L,33871L,36793L,36871L,41851L,42193L,46649L,48673L,51631L,58237L,59053L,59497L,63691L,71011L,71671L,82039L,84503L,85297L,88591L,88873L,91961L,93937L,94033L,101839L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061328Inst : IEnumerable<long>
{
public static readonly long[] Value=A061328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061328.Bytes);
public long this[int i]=>Value[i];

public static A061328Inst Instance=new A061328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061329
{
public static readonly long[] Value={ 311L,911L,1151L,2521L,2999L,3529L,4729L,5209L,6079L,6551L,7681L,8089L,8191L,8641L,9719L,14759L,16249L,16871L,16921L,18119L,19081L,21961L,23399L,24007L,24181L,27241L,27431L,27551L,29569L,29761L,30911L,33479L,34303L,35591L,36791L,37441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061329Inst : IEnumerable<long>
{
public static readonly long[] Value=A061329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061329.Bytes);
public long this[int i]=>Value[i];

public static A061329Inst Instance=new A061329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061330
{
public static readonly long[] Value={ 53173L,87541L,100621L,124909L,137341L,164341L,192611L,226549L,230101L,241861L,260317L,262909L,288661L,309541L,352309L,371029L,425701L,458701L,461891L,463741L,476029L,490741L,491461L,562021L,569869L,627661L,640069L,661621L,664141L,690541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061330Inst : IEnumerable<long>
{
public static readonly long[] Value=A061330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061330.Bytes);
public long this[int i]=>Value[i];

public static A061330Inst Instance=new A061330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061331
{
public static readonly long[] Value={ 191L,1559L,2287L,2689L,4751L,5113L,5711L,6361L,9239L,10391L,10799L,14281L,14407L,14951L,16631L,17761L,19087L,19489L,19843L,21121L,22129L,24049L,25321L,27541L,28031L,28081L,34319L,34919L,36217L,36241L,36599L,37489L,40031L,41761L,42719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061331Inst : IEnumerable<long>
{
public static readonly long[] Value=A061331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061331.Bytes);
public long this[int i]=>Value[i];

public static A061331Inst Instance=new A061331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061332
{
public static readonly long[] Value={ 107227L,151537L,235747L,332473L,382873L,418993L,440497L,551233L,584473L,607993L,727777L,737353L,838657L,920137L,922993L,983347L,995443L,1079107L,1186963L,1292593L,1469833L,1621537L,1669537L,1781803L,1858033L,1912513L,1913473L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061332Inst : IEnumerable<long>
{
public static readonly long[] Value=A061332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061332.Bytes);
public long this[int i]=>Value[i];

public static A061332Inst Instance=new A061332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061333
{
public static readonly long[] Value={ 409L,4441L,12841L,15889L,22751L,30091L,41809L,55921L,60889L,77167L,82183L,99823L,103561L,110281L,120391L,127249L,136471L,139201L,155671L,157351L,161881L,164209L,180361L,180799L,182839L,183823L,187711L,191047L,230929L,250423L,257263L,272191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061333Inst : IEnumerable<long>
{
public static readonly long[] Value=A061333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061333.Bytes);
public long this[int i]=>Value[i];

public static A061333Inst Instance=new A061333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061334
{
public static readonly long[] Value={ 3361L,6841L,9439L,13681L,14449L,26591L,26701L,28729L,39373L,40609L,41161L,41521L,54601L,61031L,66071L,66301L,68041L,68881L,70729L,82021L,85201L,89209L,90217L,93601L,96769L,104831L,110161L,112921L,117721L,121631L,125329L,126001L,128521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061334Inst : IEnumerable<long>
{
public static readonly long[] Value=A061334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061334.Bytes);
public long this[int i]=>Value[i];

public static A061334Inst Instance=new A061334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061335
{
public static readonly long[] Value={ 2161L,8761L,10559L,12479L,12911L,13729L,15601L,18121L,19009L,21787L,31249L,35281L,37321L,42841L,43201L,49921L,50951L,51239L,52711L,53231L,67489L,70249L,79801L,88919L,90121L,90289L,91393L,97919L,106129L,106391L,106681L,107881L,108529L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061335Inst : IEnumerable<long>
{
public static readonly long[] Value=A061335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061335.Bytes);
public long this[int i]=>Value[i];

public static A061335Inst Instance=new A061335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061336
{
public static readonly long[] Value={ 0L,1L,2L,1L,2L,3L,1L,2L,3L,2L,1L,2L,2L,2L,3L,1L,2L,3L,2L,3L,2L,1L,2L,3L,2L,2L,3L,2L,1L,2L,2L,2L,3L,3L,2L,3L,1L,2L,2L,2L,3L,3L,2L,2L,3L,1L,2L,3L,2L,2L,3L,2L,3L,3L,3L,1L,2L,2L,2L,3L,2L,2L,3L,3L,2L,2L,1L,2L,3L,2L,2L,3L,2L,2L,3L,3L,2L,3L,1L,2L,3L,2L,3L,2L,2L,3L,3L,2L,2L,3L,2L,1L,2L,2L,2L,3L,3L,2L,3L,2L,2L,2L,2L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061336Inst : IEnumerable<long>
{
public static readonly long[] Value=A061336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061336.Bytes);
public long this[int i]=>Value[i];

public static A061336Inst Instance=new A061336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061337
{
public static readonly long[] Value={ 0L,1L,-1L,1L,2L,-1L,1L,2L,-1L,2L,1L,2L,-1L,2L,3L,1L,2L,3L,2L,3L,4L,1L,2L,-1L,2L,2L,3L,2L,1L,2L,3L,2L,3L,-1L,2L,3L,1L,2L,2L,2L,3L,3L,2L,2L,3L,1L,2L,3L,2L,2L,3L,2L,3L,3L,3L,1L,2L,2L,2L,3L,2L,2L,3L,3L,2L,2L,1L,2L,3L,2L,2L,3L,2L,2L,3L,3L,2L,3L,1L,2L,3L,2L,3L,2L,2L,3L,3L,2L,2L,3L,3L,1L,2L,2L,2L,3L,3L,2L,3L,2L,2L,2L,2L,3L,3L,1L,2L,3L,2L,3L,3L,2L,2L,3L,2L,2L,3L,3L,3L,2L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061337Inst : IEnumerable<long>
{
public static readonly long[] Value=A061337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061337.Bytes);
public long this[int i]=>Value[i];

public static A061337Inst Instance=new A061337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061338
{
public static readonly long[] Value={ 0L,1L,2L,2L,4L,2L,3L,3L,8L,2L,3L,3L,5L,3L,4L,4L,16L,2L,3L,3L,5L,3L,4L,4L,9L,3L,4L,4L,6L,4L,5L,5L,32L,2L,3L,3L,5L,3L,4L,4L,9L,3L,4L,4L,6L,4L,5L,5L,17L,3L,4L,4L,6L,4L,5L,5L,10L,4L,5L,5L,7L,5L,6L,6L,64L,2L,3L,3L,5L,3L,4L,4L,9L,3L,4L,4L,6L,4L,5L,5L,17L,3L,4L,4L,6L,4L,5L,5L,10L,4L,5L,5L,7L,5L,6L,6L,33L,3L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061338Inst : IEnumerable<long>
{
public static readonly long[] Value=A061338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061338.Bytes);
public long this[int i]=>Value[i];

public static A061338Inst Instance=new A061338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061339
{
public static readonly long[] Value={ 0L,1L,2L,3L,3L,4L,4L,5L,4L,5L,5L,6L,5L,6L,6L,6L,5L,6L,6L,7L,6L,7L,7L,7L,6L,7L,7L,8L,7L,8L,7L,7L,6L,7L,7L,8L,7L,8L,8L,8L,7L,8L,8L,9L,8L,9L,8L,8L,7L,8L,8L,9L,8L,9L,9L,9L,8L,9L,9L,9L,8L,9L,8L,8L,7L,8L,8L,9L,8L,9L,9L,9L,8L,9L,9L,10L,9L,10L,9L,9L,8L,9L,9L,10L,9L,10L,10L,10L,9L,10L,10L,10L,9L,10L,9L,9L,8L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061339Inst : IEnumerable<long>
{
public static readonly long[] Value=A061339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061339.Bytes);
public long this[int i]=>Value[i];

public static A061339Inst Instance=new A061339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061340
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,384L,7L,8L,9L,10240L,11L,49152L,13L,229376L,491520L,16L,17L,4718592L,19L,20971520L,44040192L,92274688L,23L,402653184L,25L,1744830464L,27L,7516192768L,29L,6176733962839470L,31L,32L,283467841536L,584115552256L,1202590842880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061340Inst : IEnumerable<long>
{
public static readonly long[] Value=A061340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061340.Bytes);
public long this[int i]=>Value[i];

public static A061340Inst Instance=new A061340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061341
{
public static readonly long[] Value={ 22L,303L,1006L,2272L,3003L,6001L,6006L,10006L,30003L,50015L,50024L,60001L,60006L,60025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061341Inst : IEnumerable<long>
{
public static readonly long[] Value=A061341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061341.Bytes);
public long this[int i]=>Value[i];

public static A061341Inst Instance=new A061341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061342
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,1L,1L,2L,15L,2L,1L,2L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,2L,2L,1L,2L,1L,1L,1L,2L,1L,1L,1L,3L,2L,1L,1L,2L,1L,2L,2L,1L,2L,2L,1L,2L,2L,2L,2L,2L,1L,1L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061342Inst : IEnumerable<long>
{
public static readonly long[] Value=A061342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061342.Bytes);
public long this[int i]=>Value[i];

public static A061342Inst Instance=new A061342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061343
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,12L,27L,63L,154L,398L,1055L,2970L,8503L,25651L,78483L,250487L,811802L,2723130L,9295483L,32653552L,116866283L,428464743L,1600474365L,6102119282L,23690388631L,93631999867L,376561553417L,1538997717423L,6395852269479L,26978392034357L,115628083386280L,502520979828775L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061343Inst : IEnumerable<long>
{
public static readonly long[] Value=A061343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061343.Bytes);
public long this[int i]=>Value[i];

public static A061343Inst Instance=new A061343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A061344
{
public static readonly long[] Value={ 4L,6L,8L,10L,12L,14L,18L,20L,24L,26L,28L,30L,32L,38L,42L,44L,48L,50L,54L,60L,62L,68L,72L,74L,80L,82L,84L,90L,98L,102L,104L,108L,110L,114L,122L,126L,128L,132L,138L,140L,150L,152L,158L,164L,168L,170L,174L,180L,182L,192L,194L,198L,200L,212L,224L,228L,230L,234L,240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A061344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A061344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A061344Inst : IEnumerable<long>
{
public static readonly long[] Value=A061344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A061344.Bytes);
public long this[int i]=>Value[i];

public static A061344Inst Instance=new A061344Inst();

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