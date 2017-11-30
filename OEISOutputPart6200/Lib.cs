using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A144591
{
public static readonly long[] Value={ 8L,16L,24L,27L,32L,32L,38L,42L,44L,48L,54L,60L,62L,68L,74L,81L,85L,91L,99L,105L,111L,128L,133L,140L,142L,152L,154L,160L,166L,170L,180L,183L,194L,201L,203L,215L,231L,234L,244L,255L,262L,268L,274L,276L,282L,284L,295L,310L,315L,318L,323L,343L,354L,361L,370L,377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144591Inst : IEnumerable<long>
{
public static readonly long[] Value=A144591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144591.Bytes);
public long this[int i]=>Value[i];

public static A144591Inst Instance=new A144591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144590
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,1L,2L,2L,2L,3L,1L,3L,4L,1L,2L,3L,3L,3L,3L,2L,2L,5L,2L,3L,6L,1L,4L,3L,1L,5L,5L,3L,3L,4L,2L,3L,7L,3L,3L,6L,2L,4L,6L,2L,4L,5L,3L,5L,3L,3L,5L,8L,1L,2L,9L,1L,7L,7L,3L,5L,5L,3L,3L,5L,4L,4L,7L,2L,4L,8L,2L,7L,5L,2L,4L,8L,3L,4L,6L,4L,6L,7L,2L,2L,12L,2L,6L,5L,2L,8L,5L,4L,6L,7L,2L,4L,11L,3L,4L,10L,3L,7L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144590Inst : IEnumerable<long>
{
public static readonly long[] Value=A144590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144590.Bytes);
public long this[int i]=>Value[i];

public static A144590Inst Instance=new A144590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144589
{
public static readonly long[] Value={ 2L,7L,19L,29L,53L,71L,97L,103L,137L,173L,193L,233L,263L,271L,311L,359L,409L,421L,463L,491L,503L,571L,607L,647L,701L,743L,757L,809L,821L,839L,971L,1009L,1049L,1061L,1151L,1181L,1231L,1283L,1303L,1367L,1429L,1451L,1543L,1553L,1579L,1601L,1699L,1831L,1873L,1879L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144589Inst : IEnumerable<long>
{
public static readonly long[] Value=A144589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144589.Bytes);
public long this[int i]=>Value[i];

public static A144589Inst Instance=new A144589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144588
{
public static readonly BigInteger[] Value={ 2439360L,BigInteger.Parse("13205954936303752529313792000") };
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
public class A144588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144588Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144588.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144588Inst Instance=new A144588Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144587
{
public static readonly BigInteger[] Value={ 2152640L,BigInteger.Parse("11948993133919100295708672000") };
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
public class A144587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144587Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144587.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144587Inst Instance=new A144587Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144586
{
public static readonly long[] Value={ 9L,9L,9L,15L,9L,21L,15L,25L,33L,21L,39L,45L,27L,49L,15L,55L,15L,33L,63L,35L,15L,15L,69L,75L,15L,25L,81L,15L,45L,85L,25L,91L,15L,51L,15L,99L,21L,105L,21L,57L,15L,111L,115L,21L,35L,21L,63L,15L,65L,129L,25L,35L,133L,25L,21L,141L,75L,27L,77L,153L,27L,25L,159L,165L,21L,87L,169L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144586Inst : IEnumerable<long>
{
public static readonly long[] Value=A144586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144586.Bytes);
public long this[int i]=>Value[i];

public static A144586Inst Instance=new A144586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144585
{
public static readonly long[] Value={ 14L,20L,24L,26L,27L,38L,44L,46L,62L,68L,74L,86L,92L,94L,105L,106L,112L,116L,122L,124L,125L,126L,134L,146L,150L,152L,158L,160L,164L,166L,171L,178L,180L,188L,192L,194L,195L,206L,208L,212L,216L,218L,226L,231L,232L,234L,236L,243L,244L,254L,255L,261L,262L,272L,275L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144585Inst : IEnumerable<long>
{
public static readonly long[] Value=A144585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144585.Bytes);
public long this[int i]=>Value[i];

public static A144585Inst Instance=new A144585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144584
{
public static readonly long[] Value={ 29L,79L,97L,127L,173L,179L,181L,197L,223L,307L,311L,313L,317L,379L,409L,421L,433L,439L,443L,479L,557L,563L,647L,673L,677L,683L,727L,751L,761L,787L,907L,911L,967L,1009L,1013L,1019L,1097L,1123L,1129L,1163L,1249L,1259L,1277L,1279L,1283L,1289L,1291L,1297L,1301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144584Inst : IEnumerable<long>
{
public static readonly long[] Value=A144584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144584.Bytes);
public long this[int i]=>Value[i];

public static A144584Inst Instance=new A144584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144551
{
public static readonly long[] Value={ 0L,2L,12L,24L,36L,45L,60L,84L,105L,120L,144L,180L,210L,231L,264L,300L,325L,351L,378L,420L,480L,528L,561L,595L,630L,684L,741L,780L,840L,924L,990L,1035L,1104L,1176L,1225L,1275L,1326L,1404L,1485L,1540L,1596L,1653L,1740L,1860L,1953L,2016L,2080L,2145L,2244L,2346L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144551Inst : IEnumerable<long>
{
public static readonly long[] Value=A144551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144551.Bytes);
public long this[int i]=>Value[i];

public static A144551Inst Instance=new A144551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144550
{
public static readonly long[] Value={ 2L,23L,37L,53L,67L,97L,131L,173L,223L,233L,263L,277L,307L,337L,409L,457L,509L,563L,593L,613L,631L,653L,797L,853L,877L,1013L,1039L,1087L,1129L,1223L,1259L,1283L,1297L,1307L,1423L,1447L,1471L,1601L,1613L,1663L,1693L,1709L,1783L,1867L,1913L,1993L,2017L,2069L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144550Inst : IEnumerable<long>
{
public static readonly long[] Value=A144550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144550.Bytes);
public long this[int i]=>Value[i];

public static A144550Inst Instance=new A144550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144549
{
public static readonly long[] Value={ 3L,6L,15L,91L,276L,703L,1431L,1770L,1891L,2701L,3486L,4005L,5356L,8646L,9730L,11175L,11476L,12403L,18721L,19503L,24976L,25878L,27261L,28680L,38503L,43071L,47278L,49141L,60378L,61075L,64620L,72010L,75855L,79003L,88831L,98346L,104653L,106491L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144549Inst : IEnumerable<long>
{
public static readonly long[] Value=A144549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144549.Bytes);
public long this[int i]=>Value[i];

public static A144549Inst Instance=new A144549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144548
{
public static readonly long[] Value={ 0L,1L,16L,36L,64L,81L,100L,144L,196L,216L,225L,256L,324L,400L,441L,484L,512L,576L,625L,676L,729L,784L,900L,1000L,1024L,1089L,1156L,1225L,1296L,1444L,1521L,1600L,1728L,1764L,1936L,2025L,2116L,2304L,2401L,2500L,2601L,2704L,2744L,2916L,3025L,3136L,3249L,3364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144548Inst : IEnumerable<long>
{
public static readonly long[] Value=A144548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144548.Bytes);
public long this[int i]=>Value[i];

public static A144548Inst Instance=new A144548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144547
{
public static readonly BigInteger[] Value={ 1L,2880L,758041804800L,BigInteger.Parse("13319336815141167562752000"),BigInteger.Parse("15354978274323252140217954794120612413440000"),BigInteger.Parse("1160183823755957350394353874696058298158177597536388268425216000000"),BigInteger.Parse("5744950321305805807513301436668994962443746225944514592041927656983526026246267317780480000000"),BigInteger.Parse("1864342934383580231084517260259192252139946430124547822192277172067265954040486594733297802503864086641393952539593932800000000") };
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
public class A144547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144547Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144547.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144547Inst Instance=new A144547Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144546
{
public static readonly BigInteger[] Value={ 1L,12L,11612160L,794088208701849600L,BigInteger.Parse("3575164027575627746190393606144000"),BigInteger.Parse("1055182047088717407398960909148529544369642384916480000"),BigInteger.Parse("20410164807073092317242309800149338693366138889849970301267088483593224192000000"),BigInteger.Parse("25872955740757748502626229629361173659982454517929458713719920139287952355803151825297413315474342543360000000") };
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
public class A144546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144546Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144546.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144546Inst Instance=new A144546Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144545
{
public static readonly BigInteger[] Value={ 2L,3L,60L,25920L,197406720L,25015379558400L,BigInteger.Parse("51615733565620224000"),BigInteger.Parse("1718194449153210615595008000"),BigInteger.Parse("918817155086936330770931156779008000"),BigInteger.Parse("7877103854727828347931810809383874168094720000"),BigInteger.Parse("1081561598265935342583934931877242782978883444539392000000") };
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
public class A144545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144545Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144545.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144545Inst Instance=new A144545Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144544
{
public static readonly long[] Value={ 6L,1L,6L,5L,1L,4L,0L,9L,2L,0L,5L,9L,4L,0L,5L,7L,0L,1L,8L,7L,6L,6L,3L,2L,8L,6L,2L,2L,5L,8L,4L,6L,2L,0L,8L,8L,3L,8L,0L,0L,5L,6L,9L,9L,8L,2L,5L,2L,1L,1L,7L,8L,5L,3L,3L,6L,7L,3L,2L,1L,7L,8L,3L,7L,0L,0L,2L,6L,6L,6L,2L,0L,7L,0L,5L,9L,0L,6L,1L,7L,5L,0L,9L,0L,7L,1L,8L,5L,0L,6L,1L,3L,2L,2L,0L,1L,1L,1L,0L,1L,7L,7L,0L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144544Inst : IEnumerable<long>
{
public static readonly long[] Value=A144544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144544.Bytes);
public long this[int i]=>Value[i];

public static A144544Inst Instance=new A144544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144543
{
public static readonly long[] Value={ 5L,7L,3L,9L,5L,8L,0L,8L,3L,5L,6L,7L,0L,9L,6L,0L,8L,6L,4L,4L,9L,3L,4L,6L,1L,1L,9L,2L,8L,3L,7L,9L,3L,8L,6L,2L,4L,7L,7L,8L,5L,8L,6L,5L,4L,4L,7L,2L,3L,9L,3L,0L,4L,9L,4L,3L,1L,4L,4L,1L,9L,0L,4L,9L,3L,0L,0L,1L,2L,2L,1L,9L,8L,5L,2L,4L,5L,2L,4L,5L,3L,6L,5L,5L,8L,6L,7L,2L,7L,5L,4L,7L,7L,4L,6L,9L,1L,8L,3L,8L,3L,7L,1L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144543Inst : IEnumerable<long>
{
public static readonly long[] Value=A144543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144543.Bytes);
public long this[int i]=>Value[i];

public static A144543Inst Instance=new A144543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144542
{
public static readonly long[] Value={ 6L,3L,3L,2L,0L,5L,7L,6L,5L,7L,7L,3L,2L,8L,2L,3L,0L,7L,7L,6L,2L,8L,8L,0L,4L,8L,1L,7L,3L,0L,6L,3L,9L,8L,8L,4L,0L,5L,3L,2L,9L,9L,2L,3L,4L,6L,7L,4L,1L,4L,3L,4L,5L,6L,1L,2L,6L,1L,4L,1L,8L,3L,1L,7L,0L,3L,9L,9L,1L,3L,6L,2L,4L,8L,0L,5L,0L,9L,3L,7L,8L,7L,0L,4L,2L,2L,8L,3L,5L,1L,3L,3L,9L,8L,0L,5L,6L,2L,4L,7L,8L,7L,3L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144542Inst : IEnumerable<long>
{
public static readonly long[] Value=A144542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144542.Bytes);
public long this[int i]=>Value[i];

public static A144542Inst Instance=new A144542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144541
{
public static readonly long[] Value={ 3L,5L,0L,5L,4L,0L,5L,5L,2L,8L,8L,4L,5L,9L,1L,8L,1L,2L,2L,4L,8L,8L,8L,7L,6L,9L,2L,0L,7L,1L,6L,8L,6L,9L,0L,4L,6L,7L,3L,2L,3L,5L,6L,8L,9L,4L,4L,3L,6L,6L,5L,6L,6L,3L,5L,9L,3L,1L,7L,0L,4L,3L,3L,7L,4L,6L,1L,4L,7L,6L,6L,9L,7L,2L,8L,5L,4L,7L,9L,3L,5L,5L,6L,7L,6L,5L,5L,8L,2L,1L,5L,0L,2L,2L,5L,4L,0L,5L,6L,8L,2L,7L,1L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144541Inst : IEnumerable<long>
{
public static readonly long[] Value=A144541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144541.Bytes);
public long this[int i]=>Value[i];

public static A144541Inst Instance=new A144541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144540
{
public static readonly long[] Value={ 6L,1L,4L,2L,1L,0L,4L,5L,4L,1L,2L,4L,4L,1L,7L,1L,3L,9L,4L,8L,5L,8L,4L,8L,5L,3L,1L,9L,5L,3L,6L,9L,3L,2L,5L,7L,1L,9L,7L,7L,7L,8L,2L,3L,3L,9L,4L,2L,1L,0L,4L,8L,5L,7L,9L,6L,7L,9L,5L,6L,2L,5L,3L,5L,7L,6L,7L,5L,4L,1L,5L,0L,8L,2L,9L,0L,3L,6L,4L,1L,0L,7L,9L,6L,2L,8L,3L,8L,0L,3L,4L,4L,1L,4L,6L,4L,3L,9L,0L,4L,2L,3L,0L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144540Inst : IEnumerable<long>
{
public static readonly long[] Value=A144540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144540.Bytes);
public long this[int i]=>Value[i];

public static A144540Inst Instance=new A144540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144539
{
public static readonly long[] Value={ 1L,1L,6L,6L,6L,6L,2L,7L,1L,9L,7L,8L,3L,0L,7L,6L,6L,2L,0L,2L,7L,1L,9L,8L,7L,9L,3L,4L,3L,2L,6L,9L,8L,1L,1L,7L,5L,1L,0L,2L,0L,4L,5L,9L,4L,3L,9L,9L,9L,4L,5L,3L,9L,3L,9L,2L,4L,3L,8L,4L,1L,6L,0L,5L,6L,8L,8L,0L,6L,4L,2L,9L,2L,6L,1L,6L,6L,4L,0L,9L,0L,3L,9L,4L,9L,6L,8L,9L,0L,8L,6L,9L,1L,8L,7L,5L,0L,5L,8L,6L,7L,4L,6L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144539Inst : IEnumerable<long>
{
public static readonly long[] Value=A144539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144539.Bytes);
public long this[int i]=>Value[i];

public static A144539Inst Instance=new A144539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144538
{
public static readonly long[] Value={ 3L,6L,16L,26L,84L,126L,424L,610987L,1597L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144538Inst : IEnumerable<long>
{
public static readonly long[] Value=A144538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144538.Bytes);
public long this[int i]=>Value[i];

public static A144538Inst Instance=new A144538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144537
{
public static readonly BigInteger[] Value={ 3L,53L,8294L,1582697L,306670058L,59487327869L,11540164172942L,2238731376614513L,434302333171290194L,BigInteger.Parse("84252413712650759237"),BigInteger.Parse("16344533955257962820918"),BigInteger.Parse("3170755334869239754891769"),BigInteger.Parse("615110190430160624256865082"),BigInteger.Parse("119328206188109096135248101773"),BigInteger.Parse("23149056890302634266012500544094") };
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
public class A144537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144537Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144537.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144537Inst Instance=new A144537Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144536
{
public static readonly long[] Value={ 1L,1L,7L,15L,97L,209L,1351L,2911L,18817L,40545L,262087L,564719L,3650401L,7865521L,50843527L,109552575L,708158977L,1525870529L,9863382151L,21252634831L,137379191137L,296011017105L,1913445293767L,4122901604639L,26650854921601L,57424611447841L,371198523608647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144536Inst : IEnumerable<long>
{
public static readonly long[] Value=A144536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144536.Bytes);
public long this[int i]=>Value[i];

public static A144536Inst Instance=new A144536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144503
{
public static readonly BigInteger[] Value={ 1L,2L,5L,20L,121L,982L,9933L,120168L,1692273L,27196522L,491229653L,9851789564L,217230600041L,5223386190526L,136025271553693L,3813930989693904L,114553954962370785L,3669540489785558994L,BigInteger.Parse("124878930607671376549"),BigInteger.Parse("4499311042365955114724"),BigInteger.Parse("171098698540513965736025") };
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
public class A144503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144503Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144503.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144503Inst Instance=new A144503Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144502
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,7L,7L,5L,1L,37L,37L,30L,16L,1L,266L,266L,229L,155L,65L,1L,2431L,2431L,2165L,1633L,946L,326L,1L,27007L,27007L,24576L,19714L,13219L,6687L,1957L,1L,353522L,353522L,326515L,272501L,198773L,119917L,53822L,13700L,1L,5329837L,5329837L,4976315L,4269271L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144502Inst : IEnumerable<long>
{
public static readonly long[] Value=A144502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144502.Bytes);
public long this[int i]=>Value[i];

public static A144502Inst Instance=new A144502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144501
{
public static readonly BigInteger[] Value={ 1L,2L,30L,1633L,198773L,42965211L,14505751627L,7051160946740L,4664901181968498L,4030793305701978223L,BigInteger.Parse("4407914679125170417031"),BigInteger.Parse("5950921219972964057360847"),BigInteger.Parse("9721118017169914469460646225"),BigInteger.Parse("18898282608956442548700379478918"),BigInteger.Parse("43117198379072165094561711078882078"),BigInteger.Parse("114089724623922992953782697056886301761") };
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
public class A144501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144501Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144501.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144501Inst Instance=new A144501Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144500
{
public static readonly BigInteger[] Value={ 1L,65L,946L,13219L,198773L,3289726L,60042295L,1203809111L,26367604594L,627370195033L,16127774194871L,445733080387750L,13185075339881521L,415765494276887249L,13925084982848794378UL,BigInteger.Parse("493754789222478044011"),BigInteger.Parse("18480155500259244528605"),BigInteger.Parse("728143711886491334229526") };
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
public class A144500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144500Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144500.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144500Inst Instance=new A144500Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144499
{
public static readonly BigInteger[] Value={ 1L,16L,155L,1633L,19714L,272501L,4269271L,74971240L,1460701853L,31295474659L,731658123646L,18541725927671L,506405138998225L,14830681754924608L,463675143369795659L,15415347314972132761UL,BigInteger.Parse("543080592733655070466"),BigInteger.Parse("20211128647048824421085"),BigInteger.Parse("792340775489805581958823") };
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
public class A144499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144499Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144499.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144499Inst Instance=new A144499Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144498
{
public static readonly BigInteger[] Value={ 1L,5L,30L,229L,2165L,24576L,326515L,4976315L,85630914L,1642623355L,34762642871L,804650577600L,20224019536825L,548535471681029L,15969883030969470L,496754110707779461L,16441934503725675485UL,BigInteger.Parse("576991048929859964160"),BigInteger.Parse("21399021201104749243099"),BigInteger.Parse("836326710446071005267035") };
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
public class A144498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144498Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144498.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144498Inst Instance=new A144498Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144497
{
public static readonly BigInteger[] Value={ 37L,266L,2165L,19714L,198773L,2199722L,26516581L,345921410L,4856217989L,73003575178L,1170146049557L,19921780455746L,359032158501205L,6828661185433514L,136693194501702533L,2872718327660671042L,BigInteger.Parse("63240895146440396261"),BigInteger.Parse("1455362908778264247050"),BigInteger.Parse("34945987212582211588789") };
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
public class A144497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144497Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144497.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144497Inst Instance=new A144497Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144496
{
public static readonly BigInteger[] Value={ 7L,37L,229L,1633L,13219L,119917L,1205857L,13318249L,160305343L,2088846709L,29297613277L,440110297777L,7050173910619L,119970793032253L,2161243124917849L,41091937905633337L,822320410135133047L,17277401903869659589UL,BigInteger.Parse("380267691288777510613"),BigInteger.Parse("8749454854573455141889") };
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
public class A144496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144496Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144496.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144496Inst Instance=new A144496Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144495
{
public static readonly BigInteger[] Value={ 2L,7L,30L,155L,946L,6687L,53822L,486355L,4877250L,53759351L,646098622L,8409146187L,117836551730L,1768850337295L,28318532194206L,481652022466307L,8673291031865602L,164849403644999655L,3297954931572397790L,BigInteger.Parse("69274457019123638011"),BigInteger.Parse("1524368720086682440242") };
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
public class A144495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144495Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144495.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144495Inst Instance=new A144495Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144494
{
public static readonly long[] Value={ 0L,0L,0L,2L,0L,2L,0L,3L,2L,2L,0L,3L,0L,2L,2L,4L,0L,3L,0L,3L,2L,2L,0L,4L,2L,2L,3L,3L,0L,3L,0L,5L,2L,2L,2L,4L,0L,2L,2L,4L,0L,3L,0L,3L,3L,2L,0L,5L,2L,3L,2L,3L,0L,4L,2L,4L,2L,2L,0L,4L,0L,2L,3L,6L,2L,3L,0L,3L,2L,3L,0L,5L,0L,2L,3L,3L,2L,3L,0L,5L,4L,2L,0L,4L,2L,2L,2L,4L,0L,4L,2L,3L,2L,2L,2L,6L,0L,3L,3L,4L,0L,3L,0L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144494Inst : IEnumerable<long>
{
public static readonly long[] Value=A144494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144494.Bytes);
public long this[int i]=>Value[i];

public static A144494Inst Instance=new A144494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144493
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,9L,9L,1L,1L,27L,45L,27L,1L,1L,81L,189L,189L,81L,1L,1L,243L,729L,999L,729L,243L,1L,1L,729L,2673L,4617L,4617L,2673L,729L,1L,1L,2187L,9477L,19683L,24705L,19683L,9477L,2187L,1L,1L,6561L,32805L,79461L,119313L,119313L,79461L,32805L,6561L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144493Inst : IEnumerable<long>
{
public static readonly long[] Value=A144493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144493.Bytes);
public long this[int i]=>Value[i];

public static A144493Inst Instance=new A144493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144492
{
public static readonly long[] Value={ 35L,130L,15463L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144492Inst : IEnumerable<long>
{
public static readonly long[] Value=A144492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144492.Bytes);
public long this[int i]=>Value[i];

public static A144492Inst Instance=new A144492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144491
{
public static readonly long[] Value={ 6125L,71825L,4331600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144491Inst : IEnumerable<long>
{
public static readonly long[] Value=A144491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144491.Bytes);
public long this[int i]=>Value[i];

public static A144491Inst Instance=new A144491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144490
{
public static readonly long[] Value={ 4500L,61200L,4393701L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144490Inst : IEnumerable<long>
{
public static readonly long[] Value=A144490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144490.Bytes);
public long this[int i]=>Value[i];

public static A144490Inst Instance=new A144490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144489
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,3L,3L,4L,5L,7L,7L,9L,9L,11L,13L,14L,14L,16L,16L,18L,20L,22L,22L,24L,25L,27L,28L,30L,30L,33L,33L,34L,36L,38L,40L,42L,42L,44L,46L,48L,48L,51L,51L,53L,55L,57L,57L,59L,60L,62L,64L,66L,66L,68L,70L,72L,74L,76L,76L,79L,79L,81L,83L,84L,86L,89L,89L,91L,93L,96L,96L,98L,98L,100L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144489Inst : IEnumerable<long>
{
public static readonly long[] Value=A144489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144489.Bytes);
public long this[int i]=>Value[i];

public static A144489Inst Instance=new A144489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144488
{
public static readonly long[] Value={ 0L,76L,75L,76L,75L,76L,71L,74L,72L,69L,52L,57L,60L,64L,69L,71L,52L,56L,64L,68L,71L,72L,52L,57L,64L,76L,75L,76L,75L,76L,71L,74L,72L,69L,52L,57L,60L,64L,69L,71L,52L,56L,64L,72L,71L,69L,52L,57L,0L,76L,75L,76L,75L,76L,71L,74L,72L,69L,52L,57L,60L,64L,69L,71L,52L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144488Inst : IEnumerable<long>
{
public static readonly long[] Value=A144488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144488.Bytes);
public long this[int i]=>Value[i];

public static A144488Inst Instance=new A144488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144471
{
public static readonly long[] Value={ 1L,3L,-5L,13L,-30L,61L,-119L,234L,-467L,937L,-1878L,3757L,-7511L,15018L,-30035L,60073L,-120150L,240301L,-480599L,961194L,-1922387L,3844777L,-7689558L,15379117L,-30758231L,61516458L,-123032915L,246065833L,-492131670L,984263341L,-1968526679L,3937053354L,-7874106707L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144471Inst : IEnumerable<long>
{
public static readonly long[] Value=A144471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144471.Bytes);
public long this[int i]=>Value[i];

public static A144471Inst Instance=new A144471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144470
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,1L,9L,9L,1L,1L,12L,54L,12L,1L,1L,15L,90L,90L,15L,1L,1L,18L,135L,540L,135L,18L,1L,1L,21L,189L,945L,945L,189L,21L,1L,1L,24L,252L,1512L,5670L,1512L,252L,24L,1L,1L,27L,324L,2268L,10206L,10206L,2268L,324L,27L,1L,1L,30L,405L,3240L,17010L,61236L,17010L,3240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144470Inst : IEnumerable<long>
{
public static readonly long[] Value=A144470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144470.Bytes);
public long this[int i]=>Value[i];

public static A144470Inst Instance=new A144470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144469
{
public static readonly long[] Value={ 102L,51L,51L,23L,28L,23L,12L,14L,14L,12L,3L,4L,8L,4L,3L,1L,2L,4L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144469Inst : IEnumerable<long>
{
public static readonly long[] Value=A144469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144469.Bytes);
public long this[int i]=>Value[i];

public static A144469Inst Instance=new A144469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144468
{
public static readonly long[] Value={ 0L,7L,4L,1L,8L,5L,2L,9L,6L,3L,0L,7L,4L,1L,8L,5L,2L,9L,6L,3L,0L,7L,4L,1L,8L,5L,2L,9L,6L,3L,0L,7L,4L,1L,8L,5L,2L,9L,6L,3L,0L,7L,4L,1L,8L,5L,2L,9L,6L,3L,0L,7L,4L,1L,8L,5L,2L,9L,6L,3L,0L,7L,4L,1L,8L,5L,2L,9L,6L,3L,0L,7L,4L,1L,8L,5L,2L,9L,6L,3L,0L,7L,4L,1L,8L,5L,2L,9L,6L,3L,0L,7L,4L,1L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144468Inst : IEnumerable<long>
{
public static readonly long[] Value=A144468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144468.Bytes);
public long this[int i]=>Value[i];

public static A144468Inst Instance=new A144468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144467
{
public static readonly long[] Value={ 3L,5L,11L,41L,919L,3517L,6691L,13709L,23669L,52301L,83101L,146051L,417959L,777901L,970231L,1076401L,1894117L,2315069L,2592269L,2641469L,2777111L,2997227L,3523343L,3788843L,4076257L,4159231L,5082059L,5271961L,5295569L,5363801L,6451931L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144467Inst : IEnumerable<long>
{
public static readonly long[] Value=A144467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144467.Bytes);
public long this[int i]=>Value[i];

public static A144467Inst Instance=new A144467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144466
{
public static readonly long[] Value={ 2L,3L,37L,257L,1021L,1601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144466Inst : IEnumerable<long>
{
public static readonly long[] Value=A144466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144466.Bytes);
public long this[int i]=>Value[i];

public static A144466Inst Instance=new A144466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144465
{
public static readonly long[] Value={ 1L,4L,23L,121L,617L,3109L,15593L,78061L,390497L,1952869L,9765113L,48827101L,244138577L,1220699029L,6103507433L,30517561741L,152587857857L,762939387589L,3814697134553L,19073486065981L,9536743111633L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144465Inst : IEnumerable<long>
{
public static readonly long[] Value=A144465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144465.Bytes);
public long this[int i]=>Value[i];

public static A144465Inst Instance=new A144465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144464
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,4L,2L,1L,1L,2L,4L,4L,2L,1L,1L,2L,4L,8L,4L,2L,1L,1L,2L,4L,8L,8L,4L,2L,1L,1L,2L,4L,8L,16L,8L,4L,2L,1L,1L,2L,4L,8L,16L,16L,8L,4L,2L,1L,1L,2L,4L,8L,16L,32L,16L,8L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144464Inst : IEnumerable<long>
{
public static readonly long[] Value=A144464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144464.Bytes);
public long this[int i]=>Value[i];

public static A144464Inst Instance=new A144464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144463
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,6L,6L,1L,1L,8L,24L,8L,1L,1L,10L,40L,40L,10L,1L,1L,12L,60L,160L,60L,12L,1L,1L,14L,84L,280L,280L,84L,14L,1L,1L,16L,112L,448L,1120L,448L,112L,16L,1L,1L,18L,144L,672L,2016L,2016L,672L,144L,18L,1L,1L,20L,180L,960L,3360L,8064L,3360L,960L,180L,20L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144463Inst : IEnumerable<long>
{
public static readonly long[] Value=A144463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144463.Bytes);
public long this[int i]=>Value[i];

public static A144463Inst Instance=new A144463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144462
{
public static readonly long[] Value={ 2L,2L,1L,2L,1L,2L,2L,1L,1L,3L,2L,1L,1L,2L,4L,2L,1L,1L,2L,2L,6L,2L,1L,1L,2L,2L,2L,9L,2L,1L,1L,2L,2L,2L,2L,14L,2L,1L,1L,2L,2L,2L,2L,2L,22L,2L,1L,1L,2L,2L,2L,2L,2L,2L,35L,2L,1L,1L,2L,2L,2L,2L,2L,2L,2L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144462Inst : IEnumerable<long>
{
public static readonly long[] Value=A144462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144462.Bytes);
public long this[int i]=>Value[i];

public static A144462Inst Instance=new A144462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144461
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,-3L,1L,1L,5L,-5L,1L,1L,7L,13L,-8L,1L,1L,10L,19L,29L,-13L,1L,1L,15L,29L,57L,86L,-21L,1L,1L,23L,45L,89L,155L,244L,-34L,1L,1L,36L,71L,141L,246L,421L,667L,-55L,1L,1L,57L,113L,225L,393L,673L,1121L,1794L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144461Inst : IEnumerable<long>
{
public static readonly long[] Value=A144461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144461.Bytes);
public long this[int i]=>Value[i];

public static A144461Inst Instance=new A144461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144460
{
public static readonly long[] Value={ 1L,1L,0L,2L,1L,1L,4L,4L,4L,4L,7L,8L,8L,9L,4L,12L,15L,15L,18L,12L,9L,20L,26L,26L,32L,24L,22L,12L,33L,44L,44L,55L,44L,44L,33L,22L,54L,73L,73L,92L,76L,79L,66L,56L,33L,88L,120L,120L,152L,128L,136L,120L,112L,88L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144460Inst : IEnumerable<long>
{
public static readonly long[] Value=A144460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144460.Bytes);
public long this[int i]=>Value[i];

public static A144460Inst Instance=new A144460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144459
{
public static readonly long[] Value={ 1L,24L,77L,160L,273L,416L,589L,792L,1025L,1288L,1581L,1904L,2257L,2640L,3053L,3496L,3969L,4472L,5005L,5568L,6161L,6784L,7437L,8120L,8833L,9576L,10349L,11152L,11985L,12848L,13741L,14664L,15617L,16600L,17613L,18656L,19729L,20832L,21965L,23128L,24321L,25544L,26797L,28080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144459Inst : IEnumerable<long>
{
public static readonly long[] Value=A144459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144459.Bytes);
public long this[int i]=>Value[i];

public static A144459Inst Instance=new A144459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144458
{
public static readonly long[] Value={ -2L,-2L,0L,-4L,2L,2L,-6L,3L,3L,0L,-10L,6L,6L,2L,3L,-16L,13L,13L,10L,15L,17L,-26L,25L,25L,24L,36L,47L,31L,-42L,49L,49L,56L,84L,119L,119L,112L,-68L,95L,95L,122L,183L,271L,318L,385L,329L,-110L,182L,182L,254L,381L,580L,741L,991L,1127L,963L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144458Inst : IEnumerable<long>
{
public static readonly long[] Value=A144458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144458.Bytes);
public long this[int i]=>Value[i];

public static A144458Inst Instance=new A144458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144457
{
public static readonly long[] Value={ 1L,-1L,1L,-3L,-8L,3L,-15L,-119L,-217L,15L,-105L,-1574L,-7440L,-10954L,105L,-945L,-22679L,-194646L,-702874L,-892281L,945L,-10395L,-363824L,-4885615L,-31288480L,-94892945L,-108046896L,10395L,-135135L,-6486479L,-124999827L,-1232430275L,-6521470845L,-17442096461L,-18261339153L,135135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144457Inst : IEnumerable<long>
{
public static readonly long[] Value=A144457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144457.Bytes);
public long this[int i]=>Value[i];

public static A144457Inst Instance=new A144457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144456
{
public static readonly long[] Value={ 1L,-1L,1L,-2L,-3L,2L,-6L,-29L,-31L,6L,-30L,-299L,-920L,-869L,30L,-210L,-3569L,-21193L,-51769L,-43853L,210L,-2310L,-64679L,-665252L,-3136692L,-6760012L,-5333173L,2310L,-30030L,-1231229L,-19579519L,-153212408L,-618042328L,-1212020249L,-901760539L,30030L,-510510L,-29609579L,-688677932L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144456Inst : IEnumerable<long>
{
public static readonly long[] Value=A144456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144456.Bytes);
public long this[int i]=>Value[i];

public static A144456Inst Instance=new A144456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144439
{
public static readonly long[] Value={ 1L,1L,1L,1L,8L,1L,1L,31L,31L,1L,1L,102L,326L,102L,1L,1L,317L,2406L,2406L,317L,1L,1L,964L,15087L,34336L,15087L,964L,1L,1L,2907L,86673L,380947L,380947L,86673L,2907L,1L,1L,8738L,473084L,3650206L,6925718L,3650206L,473084L,8738L,1L,1L,26233L,2502304L,31874880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144439Inst : IEnumerable<long>
{
public static readonly long[] Value=A144439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144439.Bytes);
public long this[int i]=>Value[i];

public static A144439Inst Instance=new A144439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144438
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,14L,14L,1L,1L,33L,89L,33L,1L,1L,72L,413L,413L,72L,1L,1L,151L,1632L,3393L,1632L,151L,1L,1L,310L,5874L,22145L,22145L,5874L,310L,1L,1L,629L,19943L,125456L,224843L,125456L,19943L,629L,1L,1L,1268L,65171L,647299L,1899096L,1899096L,647299L,65171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144438Inst : IEnumerable<long>
{
public static readonly long[] Value=A144438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144438.Bytes);
public long this[int i]=>Value[i];

public static A144438Inst Instance=new A144438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144437
{
public static readonly long[] Value={ 3L,3L,1L,3L,3L,1L,3L,3L,1L,3L,3L,1L,3L,3L,1L,3L,3L,1L,3L,3L,1L,3L,3L,1L,3L,3L,1L,3L,3L,1L,3L,3L,1L,3L,3L,1L,3L,3L,1L,3L,3L,1L,3L,3L,1L,3L,3L,1L,3L,3L,1L,3L,3L,1L,3L,3L,1L,3L,3L,1L,3L,3L,1L,3L,3L,1L,3L,3L,1L,3L,3L,1L,3L,3L,1L,3L,3L,1L,3L,3L,1L,3L,3L,1L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144437Inst : IEnumerable<long>
{
public static readonly long[] Value=A144437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144437.Bytes);
public long this[int i]=>Value[i];

public static A144437Inst Instance=new A144437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144436
{
public static readonly long[] Value={ 1L,1L,1L,1L,8L,1L,1L,23L,23L,1L,1L,54L,170L,54L,1L,1L,117L,818L,818L,117L,1L,1L,244L,3255L,7224L,3255L,244L,1L,1L,499L,11697L,48443L,48443L,11697L,499L,1L,1L,1010L,39560L,276974L,513326L,276974L,39560L,1010L,1L,1L,2033L,128756L,1431604L,4422246L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144436Inst : IEnumerable<long>
{
public static readonly long[] Value=A144436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144436.Bytes);
public long this[int i]=>Value[i];

public static A144436Inst Instance=new A144436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144435
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,0L,2L,0L,1L,1L,-1L,0L,0L,-1L,1L,1L,-2L,3L,4L,3L,-2L,1L,1L,-3L,3L,-17L,-17L,3L,-3L,1L,1L,-4L,8L,28L,110L,28L,8L,-4L,1L,1L,-5L,10L,-90L,-476L,-476L,-90L,10L,-5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144435Inst : IEnumerable<long>
{
public static readonly long[] Value=A144435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144435.Bytes);
public long this[int i]=>Value[i];

public static A144435Inst Instance=new A144435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144434
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,3L,2L,1L,1L,3L,5L,5L,3L,1L,1L,4L,7L,9L,7L,4L,1L,1L,4L,9L,14L,14L,9L,4L,1L,1L,4L,12L,21L,25L,21L,12L,4L,1L,1L,5L,15L,30L,42L,42L,30L,15L,5L,1L,1L,6L,18L,41L,66L,77L,66L,41L,18L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144434Inst : IEnumerable<long>
{
public static readonly long[] Value=A144434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144434.Bytes);
public long this[int i]=>Value[i];

public static A144434Inst Instance=new A144434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144433
{
public static readonly long[] Value={ 8L,3L,16L,5L,24L,7L,32L,9L,40L,11L,48L,13L,56L,15L,64L,17L,72L,19L,80L,21L,88L,23L,96L,25L,104L,27L,112L,29L,120L,31L,128L,33L,136L,35L,144L,37L,152L,39L,160L,41L,168L,43L,176L,45L,184L,47L,192L,49L,200L,51L,208L,53L,216L,55L,224L,57L,232L,59L,240L,61L,248L,63L,256L,65L,264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144433Inst : IEnumerable<long>
{
public static readonly long[] Value=A144433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144433.Bytes);
public long this[int i]=>Value[i];

public static A144433Inst Instance=new A144433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144432
{
public static readonly long[] Value={ -1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,1L,-1L,-1L,5L,1L,5L,-1L,-1L,11L,1L,1L,11L,-1L,-1L,19L,41L,71L,41L,19L,-1L,-1L,29L,71L,29L,29L,71L,29L,-1L,-1L,41L,239L,701L,869L,701L,239L,41L,-1L,-1L,55L,379L,811L,181L,181L,811L,379L,55L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144432Inst : IEnumerable<long>
{
public static readonly long[] Value=A144432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144432.Bytes);
public long this[int i]=>Value[i];

public static A144432Inst Instance=new A144432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144431
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,-1L,-1L,1L,1L,-2L,2L,-2L,1L,1L,-3L,2L,2L,-3L,1L,1L,-4L,7L,-8L,7L,-4L,1L,1L,-5L,9L,-5L,-5L,9L,-5L,1L,1L,-6L,16L,-26L,30L,-26L,16L,-6L,1L,1L,-7L,20L,-28L,14L,14L,-28L,20L,-7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144431Inst : IEnumerable<long>
{
public static readonly long[] Value=A144431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144431.Bytes);
public long this[int i]=>Value[i];

public static A144431Inst Instance=new A144431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144430
{
public static readonly long[] Value={ 2L,3L,4L,5L,7L,10L,11L,13L,16L,17L,19L,22L,23L,25L,28L,29L,31L,34L,35L,37L,40L,41L,43L,46L,47L,49L,52L,53L,55L,58L,59L,61L,64L,65L,67L,70L,71L,73L,76L,77L,79L,82L,83L,85L,88L,89L,91L,94L,95L,97L,100L,101L,103L,106L,107L,109L,112L,113L,115L,118L,119L,121L,124L,125L,127L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144430Inst : IEnumerable<long>
{
public static readonly long[] Value=A144430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144430.Bytes);
public long this[int i]=>Value[i];

public static A144430Inst Instance=new A144430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144429
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,9L,10L,12L,15L,16L,18L,21L,22L,24L,27L,28L,30L,33L,34L,36L,39L,40L,42L,45L,46L,48L,51L,52L,54L,57L,58L,60L,63L,64L,66L,69L,70L,72L,75L,76L,78L,81L,82L,84L,87L,88L,90L,93L,94L,96L,99L,100L,102L,105L,106L,108L,111L,112L,114L,117L,118L,120L,123L,124L,126L,129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144429Inst : IEnumerable<long>
{
public static readonly long[] Value=A144429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144429.Bytes);
public long this[int i]=>Value[i];

public static A144429Inst Instance=new A144429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144428
{
public static readonly long[] Value={ 2L,2L,3L,2L,4L,5L,2L,4L,7L,8L,2L,4L,8L,13L,13L,2L,4L,8L,15L,24L,21L,2L,4L,8L,16L,29L,44L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144428Inst : IEnumerable<long>
{
public static readonly long[] Value=A144428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144428.Bytes);
public long this[int i]=>Value[i];

public static A144428Inst Instance=new A144428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144427
{
public static readonly long[] Value={ 3L,5L,7L,11L,19L,23L,37L,41L,47L,53L,67L,67L,71L,73L,83L,97L,101L,113L,127L,127L,137L,137L,157L,181L,193L,193L,199L,223L,223L,229L,233L,241L,307L,311L,331L,337L,353L,373L,379L,397L,421L,433L,457L,467L,487L,487L,503L,547L,557L,563L,563L,577L,599L,607L,613L,613L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144427Inst : IEnumerable<long>
{
public static readonly long[] Value=A144427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144427.Bytes);
public long this[int i]=>Value[i];

public static A144427Inst Instance=new A144427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144426
{
public static readonly long[] Value={ 7L,13L,17L,19L,23L,29L,31L,37L,37L,41L,59L,83L,89L,97L,97L,101L,101L,107L,149L,157L,167L,167L,179L,197L,199L,211L,211L,223L,241L,257L,269L,283L,283L,307L,311L,313L,331L,373L,401L,433L,439L,439L,443L,443L,463L,503L,557L,569L,587L,599L,617L,619L,619L,641L,691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144426Inst : IEnumerable<long>
{
public static readonly long[] Value=A144426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144426.Bytes);
public long this[int i]=>Value[i];

public static A144426Inst Instance=new A144426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144425
{
public static readonly long[] Value={ 1L,33L,35L,39L,49L,77L,77L,105L,117L,119L,133L,145L,145L,155L,159L,185L,201L,205L,213L,213L,215L,225L,225L,235L,237L,243L,249L,255L,273L,295L,299L,301L,319L,319L,321L,327L,329L,341L,345L,345L,365L,375L,377L,381L,399L,405L,405L,413L,485L,485L,493L,493L,497L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144425Inst : IEnumerable<long>
{
public static readonly long[] Value=A144425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144425.Bytes);
public long this[int i]=>Value[i];

public static A144425Inst Instance=new A144425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144424
{
public static readonly long[] Value={ 1L,1L,9L,9L,21L,27L,33L,33L,49L,49L,51L,57L,75L,81L,81L,85L,87L,93L,141L,153L,155L,169L,183L,203L,203L,209L,217L,237L,247L,253L,255L,261L,265L,291L,297L,297L,305L,309L,319L,319L,329L,333L,339L,341L,345L,377L,411L,413L,423L,425L,445L,471L,513L,513L,517L,519L,529L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144424Inst : IEnumerable<long>
{
public static readonly long[] Value=A144424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144424.Bytes);
public long this[int i]=>Value[i];

public static A144424Inst Instance=new A144424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144391
{
public static readonly long[] Value={ 3L,13L,29L,51L,79L,113L,153L,199L,251L,309L,373L,443L,519L,601L,689L,783L,883L,989L,1101L,1219L,1343L,1473L,1609L,1751L,1899L,2053L,2213L,2379L,2551L,2729L,2913L,3103L,3299L,3501L,3709L,3923L,4143L,4369L,4601L,4839L,5083L,5333L,5589L,5851L,6119L,6393L,6673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144391Inst : IEnumerable<long>
{
public static readonly long[] Value=A144391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144391.Bytes);
public long this[int i]=>Value[i];

public static A144391Inst Instance=new A144391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144390
{
public static readonly long[] Value={ 1L,9L,23L,43L,69L,101L,139L,183L,233L,289L,351L,419L,493L,573L,659L,751L,849L,953L,1063L,1179L,1301L,1429L,1563L,1703L,1849L,2001L,2159L,2323L,2493L,2669L,2851L,3039L,3233L,3433L,3639L,3851L,4069L,4293L,4523L,4759L,5001L,5249L,5503L,5763L,6029L,6301L,6579L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144390Inst : IEnumerable<long>
{
public static readonly long[] Value=A144390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144390.Bytes);
public long this[int i]=>Value[i];

public static A144390Inst Instance=new A144390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144389
{
public static readonly long[] Value={ -1L,2L,-1L,1L,4L,-1L,4L,3L,6L,-1L,3L,16L,6L,8L,-1L,6L,15L,40L,10L,10L,-1L,5L,36L,45L,80L,15L,12L,-1L,8L,35L,126L,105L,140L,21L,14L,-1L,7L,64L,140L,336L,210L,224L,28L,16L,-1L,10L,63L,288L,420L,756L,378L,336L,36L,18L,-1L,9L,100L,315L,960L,1050L,1512L,630L,480L,45L,20L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144389Inst : IEnumerable<long>
{
public static readonly long[] Value=A144389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144389.Bytes);
public long this[int i]=>Value[i];

public static A144389Inst Instance=new A144389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144388
{
public static readonly long[] Value={ 1L,0L,1L,3L,0L,1L,-2L,9L,0L,1L,5L,-8L,18L,0L,1L,-4L,25L,-20L,30L,0L,1L,7L,-24L,75L,-40L,45L,0L,1L,-6L,49L,-84L,175L,-70L,63L,0L,1L,9L,-48L,196L,-224L,350L,-112L,84L,0L,1L,-8L,81L,-216L,588L,-504L,630L,-168L,108L,0L,1L,11L,-80L,405L,-720L,1470L,-1008L,1050L,-240L,135L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144388Inst : IEnumerable<long>
{
public static readonly long[] Value=A144388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144388.Bytes);
public long this[int i]=>Value[i];

public static A144388Inst Instance=new A144388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144387
{
public static readonly long[] Value={ 2L,2L,1L,2L,-1L,4L,2L,-3L,5L,3L,2L,-5L,8L,-2L,8L,2L,-7L,13L,-10L,10L,5L,2L,-9L,20L,-23L,20L,-5L,12L,2L,-11L,29L,-43L,43L,-25L,17L,7L,2L,-13L,40L,-72L,86L,-68L,42L,-10L,16L,2L,-15L,53L,-112L,158L,-154L,110L,-52L,26L,13L,2L,-17L,68L,-165L,270L,-312L,264L,-162L,78L,-13L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144387Inst : IEnumerable<long>
{
public static readonly long[] Value=A144387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144387.Bytes);
public long this[int i]=>Value[i];

public static A144387Inst Instance=new A144387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144386
{
public static readonly long[] Value={ 0L,1L,5L,-3L,5L,15L,3L,17L,33L,15L,35L,13L,37L,63L,35L,65L,33L,67L,31L,69L,109L,67L,111L,65L,113L,63L,115L,61L,117L,59L,119L,181L,117L,183L,115L,185L,113L,187L,111L,189L,109L,191L,107L,193L,701408540L,701408450L,701408358L,701408264L,701408168L,701408070L,701407970L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144386Inst : IEnumerable<long>
{
public static readonly long[] Value=A144386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144386.Bytes);
public long this[int i]=>Value[i];

public static A144386Inst Instance=new A144386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144385
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,0L,0L,1L,3L,7L,10L,10L,0L,0L,0L,1L,6L,25L,75L,175L,280L,280L,0L,0L,0L,0L,1L,10L,65L,315L,1225L,3780L,9100L,15400L,15400L,0L,0L,0L,0L,0L,1L,15L,140L,980L,5565L,26145L,102025L,323400L,800800L,1401400L,1401400L,0L,0L,0L,0L,0L,0L,1L,21L,266L,2520L,19425L,125895L,695695L,3273270L,12962950L,42042000L,106506400L,190590400L,190590400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144385Inst : IEnumerable<long>
{
public static readonly long[] Value=A144385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144385.Bytes);
public long this[int i]=>Value[i];

public static A144385Inst Instance=new A144385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144384
{
public static readonly long[] Value={ 1L,1L,1L,1L,-1L,1L,1L,-1L,1L,1L,1L,-1L,0L,-1L,1L,1L,-1L,0L,1L,1L,1L,1L,-1L,0L,0L,-1L,-1L,1L,1L,-1L,0L,0L,1L,0L,1L,1L,1L,-1L,0L,0L,0L,-1L,1L,-1L,1L,1L,-1L,0L,0L,0L,1L,0L,-1L,1L,1L,1L,-1L,0L,0L,0L,0L,-1L,0L,0L,-1L,1L,1L,-1L,0L,0L,0L,0L,1L,0L,1L,1L,1L,1L,1L,-1L,0L,0L,0L,0L,0L,-1L,0L,-1L,-1L,-1L,1L,1L,-1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,-1L,0L,0L,0L,0L,0L,0L,-1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144384Inst : IEnumerable<long>
{
public static readonly long[] Value=A144384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144384.Bytes);
public long this[int i]=>Value[i];

public static A144384Inst Instance=new A144384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144383
{
public static readonly long[] Value={ 1L,1L,-2L,1L,-1L,4L,1L,-1L,0L,-8L,1L,-1L,1L,1L,16L,1L,-1L,1L,-2L,-1L,-32L,1L,-1L,1L,-1L,3L,0L,64L,1L,-1L,1L,-1L,0L,-4L,1L,-128L,1L,-1L,1L,-1L,1L,1L,6L,-1L,256L,1L,-1L,1L,-1L,1L,-2L,-2L,-9L,0L,-512L,1L,-1L,1L,-1L,1L,-1L,3L,3L,13L,1L,1024L,1L,-1L,1L,-1L,1L,-1L,0L,-4L,-3L,-19L,-1L,-2048L,1L,-1L,1L,-1L,1L,-1L,1L,1L,5L,2L,28L,0L,4096L,1L,-1L,1L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144383Inst : IEnumerable<long>
{
public static readonly long[] Value=A144383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144383.Bytes);
public long this[int i]=>Value[i];

public static A144383Inst Instance=new A144383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144382
{
public static readonly long[] Value={ -1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,0L,-1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,0L,1L,-1L,-1L,-1L,-1L,-1L,1L,0L,-1L,-1L,-1L,-1L,-1L,0L,2L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,2L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,0L,2L,1L,0L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,3L,-1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,0L,2L,3L,-3L,1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,3L,2L,-4L,0L,-1L,-1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144382Inst : IEnumerable<long>
{
public static readonly long[] Value=A144382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144382.Bytes);
public long this[int i]=>Value[i];

public static A144382Inst Instance=new A144382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144381
{
public static readonly long[] Value={ 1L,677L,47175L,1709675L,44451550L,947113254L,17716715490L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144381Inst : IEnumerable<long>
{
public static readonly long[] Value=A144381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144381.Bytes);
public long this[int i]=>Value[i];

public static A144381Inst Instance=new A144381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144380
{
public static readonly BigInteger[] Value={ 1L,166L,5482L,109640L,1709675L,23077694L,284433852L,3300384000L,36740695125L,397251942790L,4206505251886L,43874389439176L,452588032465727L,4630933106076350L,47101176806668160L,476947462419456864L,4813761757416769257L,BigInteger.Parse("48466731584985480870"),BigInteger.Parse("487104579690137249650"),BigInteger.Parse("4889039701269534580360") };
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
public class A144380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144380Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144380.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144380Inst Instance=new A144380Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144379
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,2L,2L,4L,1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,4L,2L,6L,1L,1L,1L,2L,2L,2L,3L,4L,1L,1L,2L,1L,3L,2L,4L,3L,6L,1L,1L,1L,2L,2L,1L,2L,3L,2L,4L,1L,1L,2L,2L,4L,2L,6L,4L,6L,4L,10L,1L,1L,1L,1L,1L,2L,2L,3L,3L,2L,3L,4L,1L,1L,2L,2L,4L,2L,6L,4L,6L,4L,10L,4L,12L,1L,1L,1L,2L,2L,2L,3L,3L,2L,3L,4L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144379Inst : IEnumerable<long>
{
public static readonly long[] Value=A144379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144379.Bytes);
public long this[int i]=>Value[i];

public static A144379Inst Instance=new A144379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144378
{
public static readonly long[] Value={ 11L,22L,37L,136L,13L,64L,73L,163L,91L,1730L,289L,1639L,379L,1660L,2737L,919L,559L,14878L,7561L,5671L,9753L,2890L,7777L,4888L,5785L,5590L,27973L,47872L,28681L,22681L,3785L,36184L,46281L,71281L,6481L,48952L,48763L,64978L,119773L,69782L,77881L,55973L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144378Inst : IEnumerable<long>
{
public static readonly long[] Value=A144378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144378.Bytes);
public long this[int i]=>Value[i];

public static A144378Inst Instance=new A144378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144377
{
public static readonly long[] Value={ 1L,2L,0L,0L,2L,-2L,-4L,0L,0L,-2L,4L,8L,0L,0L,4L,-8L,-14L,0L,0L,-8L,14L,24L,0L,0L,12L,-22L,-40L,0L,0L,-20L,36L,64L,0L,0L,32L,-56L,-98L,0L,0L,-48L,84L,148L,0L,0L,72L,-126L,-220L,0L,0L,-106L,184L,320L,0L,0L,152L,-264L,-460L,0L,0L,-216L,376L,652L,0L,0L,306L,-528L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144377Inst : IEnumerable<long>
{
public static readonly long[] Value=A144377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144377.Bytes);
public long this[int i]=>Value[i];

public static A144377Inst Instance=new A144377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144376
{
public static readonly long[] Value={ 1L,10L,18L,54L,108L,540L,2700L,3780L,7560L,22680L,113400L,249480L,1247400L,3243240L,6486480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144376Inst : IEnumerable<long>
{
public static readonly long[] Value=A144376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144376.Bytes);
public long this[int i]=>Value[i];

public static A144376Inst Instance=new A144376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144327
{
public static readonly long[] Value={ 191L,1217L,1559L,1901L,2243L,2927L,4637L,6689L,8741L,9767L,12161L,12503L,13187L,14897L,15581L,15923L,16607L,17291L,19001L,20369L,21737L,22079L,23447L,23789L,24473L,25841L,26183L,27551L,27893L,30971L,33023L,35759L,37811L,38153L,39521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144327Inst : IEnumerable<long>
{
public static readonly long[] Value=A144327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144327.Bytes);
public long this[int i]=>Value[i];

public static A144327Inst Instance=new A144327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144326
{
public static readonly long[] Value={ 67L,191L,197L,211L,277L,331L,379L,397L,401L,541L,617L,631L,677L,727L,743L,751L,821L,937L,947L,971L,991L,1129L,1163L,1171L,1217L,1277L,1289L,1327L,1381L,1409L,1427L,1471L,1549L,1559L,1597L,1601L,1607L,1783L,1801L,1831L,1871L,1901L,2011L,2017L,2081L,2111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144326Inst : IEnumerable<long>
{
public static readonly long[] Value=A144326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144326.Bytes);
public long this[int i]=>Value[i];

public static A144326Inst Instance=new A144326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144325
{
public static readonly long[] Value={ 97L,127L,157L,307L,337L,367L,487L,547L,607L,757L,787L,907L,967L,997L,1087L,1117L,1237L,1447L,1567L,1627L,1657L,1747L,1777L,1867L,1987L,2287L,2437L,2617L,2647L,2677L,2767L,2797L,2857L,2887L,3067L,3217L,3307L,3457L,3517L,3547L,3607L,3637L,3727L,3847L,3907L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144325Inst : IEnumerable<long>
{
public static readonly long[] Value=A144325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144325.Bytes);
public long this[int i]=>Value[i];

public static A144325Inst Instance=new A144325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144324
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,4L,4L,1L,1L,8L,16L,9L,1L,1L,16L,64L,70L,18L,1L,1L,32L,256L,540L,280L,40L,1L,1L,64L,1024L,4216L,4320L,1168L,80L,1L,1L,128L,4096L,33264L,67456L,35008L,4672L,168L,1L,1L,256L,16384L,264160L,1064448L,1083136L,280064L,18884L,340L,1L,1L,512L,65536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144324Inst : IEnumerable<long>
{
public static readonly long[] Value=A144324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144324.Bytes);
public long this[int i]=>Value[i];

public static A144324Inst Instance=new A144324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144323
{
public static readonly BigInteger[] Value={ 1L,1L,512L,262144L,134348544L,68786454528L,35218798673920L,18032024921047040L,9232396828183582208UL,BigInteger.Parse("4726987176064286720000"),BigInteger.Parse("2420217434180064678903808"),BigInteger.Parse("1239151326300193115598749696"),BigInteger.Parse("634445479065716907074042200064") };
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
public class A144323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144323Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144323.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144323Inst Instance=new A144323Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144322
{
public static readonly BigInteger[] Value={ 1L,1L,256L,65536L,16809856L,4303323136L,1101667434496L,282026863230976L,72198881268083456L,BigInteger.Parse("18482913606768459776"),BigInteger.Parse("4731625884430073102336"),BigInteger.Parse("1211296226414098714198016"),BigInteger.Parse("310091833962291289108054016") };
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
public class A144322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144322Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144322.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144322Inst Instance=new A144322Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144321
{
public static readonly BigInteger[] Value={ 1L,1L,128L,16384L,2105280L,269475840L,34494988288L,4415358500864L,565166154790272L,72341267946323968L,9259682331352899584UL,BigInteger.Parse("1185239338413171146752"),BigInteger.Parse("151710635321300728430592"),BigInteger.Parse("19418961321126493239115776"),BigInteger.Parse("2485627049104751885136429056") };
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
public class A144321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144321Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144321.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144321Inst Instance=new A144321Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144320
{
public static readonly BigInteger[] Value={ 1L,1L,64L,4096L,264160L,16906240L,1082257408L,69264474112L,4432942899904L,283708353851392L,18157335711582208L,1162069485541261312L,BigInteger.Parse("74372447143871647744"),BigInteger.Parse("4759836617207785455616"),BigInteger.Parse("304629543505661931028480") };
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
public class A144320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144320Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144320.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144320Inst Instance=new A144320Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144319
{
public static readonly BigInteger[] Value={ 1L,1L,32L,1024L,33264L,1064448L,34094080L,1091010560L,34913358688L,1117227985920L,35751328547328L,1144042513514496L,36609361521378304L,1171499568684105728L,BigInteger.Parse("37487986231712710656"),BigInteger.Parse("1199615559415862673408") };
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
public class A144319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144319Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144319.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144319Inst Instance=new A144319Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144318
{
public static readonly BigInteger[] Value={ 1L,1L,16L,256L,4216L,67456L,1083136L,17330176L,277344816L,4437547776L,71001776256L,1136028420096L,18176471920896L,290823550734336L,4653177071702016L,74450833163421696L,1191213334782285596L,BigInteger.Parse("19059413356516569536"),BigInteger.Parse("304950613771087329536"),BigInteger.Parse("4879209820337397272576") };
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
public class A144318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144318Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144318.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144318Inst Instance=new A144318Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144317
{
public static readonly long[] Value={ 1L,1L,8L,64L,540L,4320L,35008L,280064L,2244152L,17955008L,143670304L,1149362432L,9195171392L,73561371136L,588492929536L,4707943678208L,37663565234758L,301308521878064L,2410468302643136L,19283746421145088L,154269972376667232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144317Inst : IEnumerable<long>
{
public static readonly long[] Value=A144317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144317.Bytes);
public long this[int i]=>Value[i];

public static A144317Inst Instance=new A144317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144316
{
public static readonly long[] Value={ 1L,1L,4L,16L,70L,280L,1168L,4672L,18884L,75632L,303368L,1213472L,4858064L,19432256L,77743040L,310975520L,1243959873L,4975839492L,19903598208L,79614392832L,318458493192L,1273834028832L,5095339755744L,20381359022976L,81525450936496L,326101803775384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144316Inst : IEnumerable<long>
{
public static readonly long[] Value=A144316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144316.Bytes);
public long this[int i]=>Value[i];

public static A144316Inst Instance=new A144316Inst();

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