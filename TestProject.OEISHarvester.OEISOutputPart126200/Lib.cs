using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A155505
{
public static readonly long[] Value={ 14L,26L,41L,44L,46L,49L,56L,65L,74L,76L,89L,94L,104L,106L,110L,121L,126L,140L,154L,161L,164L,169L,176L,184L,185L,190L,196L,206L,209L,224L,234L,236L,241L,254L,260L,265L,266L,281L,286L,296L,304L,314L,329L,334L,346L,350L,356L,361L,364L,369L,376L,385L,394L,396L,401L,409L,410L,414L,416L,424L,440L,441L,446L,449L,460L,481L,484L,490L,494L,504L,506L,521L,524L,526L,529L,554L,556L,560L,569L,74L,585L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155505Inst : IEnumerable<long>
{
public static readonly long[] Value=A155505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155505.Bytes);
public long this[int i]=>Value[i];

public static A155505Inst Instance=new A155505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155506
{
public static readonly long[] Value={ 2L,4L,8L,14L,22L,32L,42L,54L,68L,82L,98L,116L,134L,154L,176L,200L,224L,250L,278L,306L,336L,368L,400L,434L,470L,508L,546L,586L,628L,670L,714L,760L,808L,856L,906L,958L,1010L,1064L,1120L,1178L,1236L,1296L,1358L,1420L,1484L,1550L,1616L,1684L,1754L,1826L,1898L,1972L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155506Inst : IEnumerable<long>
{
public static readonly long[] Value=A155506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155506.Bytes);
public long this[int i]=>Value[i];

public static A155506Inst Instance=new A155506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155507
{
public static readonly long[] Value={ 199L,991L,91199L,99119L,111119L,111919L,119191L,191911L,911111L,919111L,991999L,999199L,1191119L,1191191L,1191991L,1911911L,1991911L,9111911L,11111911L,11191991L,11911111L,11919991L,19111991L,19911191L,19919111L,19991911L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155507Inst : IEnumerable<long>
{
public static readonly long[] Value=A155507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155507.Bytes);
public long this[int i]=>Value[i];

public static A155507Inst Instance=new A155507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155508
{
public static readonly long[] Value={ 199L,91199L,111119L,111919L,119191L,991999L,1191119L,1191191L,1191991L,11111911L,11191991L,11919991L,19111991L,91111199L,111111199L,111199199L,191111119L,199991999L,919919999L,1111111999L,1191111991L,1199111191L,1911199999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155508Inst : IEnumerable<long>
{
public static readonly long[] Value=A155508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155508.Bytes);
public long this[int i]=>Value[i];

public static A155508Inst Instance=new A155508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155509
{
public static readonly long[] Value={ 991L,99119L,191911L,911111L,919111L,999199L,1911911L,1991911L,9111911L,11911111L,19911191L,19919111L,19991911L,99111119L,911111191L,991111111L,991991111L,999199991L,999919919L,1911119911L,1919991191L,1991111911L,1991919191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155509Inst : IEnumerable<long>
{
public static readonly long[] Value=A155509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155509.Bytes);
public long this[int i]=>Value[i];

public static A155509Inst Instance=new A155509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155510
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,9L,12L,16L,21L,24L,25L,36L,40L,45L,46L,56L,60L,80L,81L,96L,106L,120L,126L,145L,190L,225L,256L,270L,351L,400L,505L,576L,610L,666L,720L,721L,826L,855L,946L,1071L,1072L,1170L,1225L,1233L,1330L,1338L,1345L,1386L,1450L,1575L,1576L,1792L,1890L,2080L,2241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155510Inst : IEnumerable<long>
{
public static readonly long[] Value=A155510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155510.Bytes);
public long this[int i]=>Value[i];

public static A155510Inst Instance=new A155510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155511
{
public static readonly long[] Value={ 4841L,4843L,4847L,4849L,6401L,6403L,6407L,6409L,14801L,14803L,14807L,14809L,15941L,15943L,15947L,15949L,19091L,19093L,19097L,19099L,19511L,19513L,19517L,19519L,19631L,19633L,19637L,19639L,24581L,24583L,24587L,24589L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155511Inst : IEnumerable<long>
{
public static readonly long[] Value=A155511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155511.Bytes);
public long this[int i]=>Value[i];

public static A155511Inst Instance=new A155511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155512
{
public static readonly long[] Value={ 10011101L,10111001L,100100111L,111001001L,1000110101L,1001001011L,1010001101L,1010011111L,1010110001L,1011000101L,1101001001L,1111100101L,10010100101L,10100000011L,10100000111L,10100101001L,10111001011L,11000000101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155512Inst : IEnumerable<long>
{
public static readonly long[] Value=A155512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155512.Bytes);
public long this[int i]=>Value[i];

public static A155512Inst Instance=new A155512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155513
{
public static readonly long[] Value={ 10011101L,100100111L,1000110101L,1001001011L,1010001101L,1010011111L,10010100101L,10100000011L,10100000111L,10111001011L,100000010101L,100000011011L,100101110111L,100101111001L,100110101011L,100110101111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155513Inst : IEnumerable<long>
{
public static readonly long[] Value=A155513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155513.Bytes);
public long this[int i]=>Value[i];

public static A155513Inst Instance=new A155513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155514
{
public static readonly long[] Value={ 10111001L,111001001L,1010110001L,1011000101L,1101001001L,1111100101L,10100101001L,11000000101L,11010011101L,11100000101L,100111101001L,101010000001L,101010111001L,110000000101L,110011010101L,110101011001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155514Inst : IEnumerable<long>
{
public static readonly long[] Value=A155514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155514.Bytes);
public long this[int i]=>Value[i];

public static A155514Inst Instance=new A155514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155515
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,3L,2L,3L,5L,4L,8L,12L,10L,15L,23L,22L,33L,42L,47L,64L,79L,90L,122L,147L,169L,219L,264L,312L,387L,465L,546L,679L,799L,950L,1151L,1365L,1599L,1937L,2270L,2678L,3181L,3735L,4374L,5192L,6046L,7082L,8318L,9684L,11281L,13208L,15313L,17798L,20702L,23951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155515Inst : IEnumerable<long>
{
public static readonly long[] Value=A155515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155515.Bytes);
public long this[int i]=>Value[i];

public static A155515Inst Instance=new A155515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155516
{
public static readonly long[] Value={ 1L,1L,1L,1L,20L,1L,1L,105L,105L,1L,1L,336L,1764L,336L,1L,1L,825L,13860L,13860L,825L,1L,1L,1716L,70785L,226512L,70785L,1716L,1L,1L,3185L,273273L,2147145L,2147145L,273273L,3185L,1L,1L,5440L,866320L,14158144L,34763300L,14158144L,866320L,5440L,1L,1L,8721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155516Inst : IEnumerable<long>
{
public static readonly long[] Value=A155516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155516.Bytes);
public long this[int i]=>Value[i];

public static A155516Inst Instance=new A155516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155517
{
public static readonly long[] Value={ 0L,1L,0L,2L,4L,0L,2L,16L,0L,8L,64L,48L,0L,8L,384L,288L,0L,48L,2880L,1536L,576L,0L,48L,23040L,12288L,4608L,0L,384L,208896L,115200L,30720L,7680L,0L,384L,2088960L,1152000L,307200L,76800L,0L,3840L,23193600L,12533760L,3456000L,614400L,115200L,0L,3840L,278323200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155517Inst : IEnumerable<long>
{
public static readonly long[] Value=A155517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155517.Bytes);
public long this[int i]=>Value[i];

public static A155517Inst Instance=new A155517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155518
{
public static readonly long[] Value={ 1L,0L,0L,4L,16L,64L,384L,2880L,23040L,208896L,2088960L,23193600L,278323200L,3640688640L,50969640960L,768126320640L,12290021130240L,209688566169600L,3774394191052800L,71921062285148160L,1438421245702963200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155518Inst : IEnumerable<long>
{
public static readonly long[] Value=A155518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155518.Bytes);
public long this[int i]=>Value[i];

public static A155518Inst Instance=new A155518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155519
{
public static readonly long[] Value={ 1L,2L,4L,16L,72L,432L,2880L,23040L,201600L,2016000L,21772800L,261273600L,3353011200L,46942156800L,697426329600L,11158821273600L,188305108992000L,3389491961856000L,64023737057280000L,1280474741145600000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155519Inst : IEnumerable<long>
{
public static readonly long[] Value=A155519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155519.Bytes);
public long this[int i]=>Value[i];

public static A155519Inst Instance=new A155519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155520
{
public static readonly long[] Value={ 1L,2L,3L,2L,4L,2L,6L,1L,1L,5L,2L,6L,9L,1L,4L,4L,4L,2L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155520Inst : IEnumerable<long>
{
public static readonly long[] Value=A155520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155520.Bytes);
public long this[int i]=>Value[i];

public static A155520Inst Instance=new A155520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155521
{
public static readonly ulong[] Value={ 0L,1L,1L,7L,31L,191L,1331L,10655L,95887L,958879L,10547659L,126571919L,1645434935L,23036089103L,345541336531L,5528661384511L,93987243536671L,1691770383660095L,32143637289541787L,642872745790835759L,13500327661607550919UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155521Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A155521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155521.Bytes);
public ulong this[int i]=>Value[i];

public static A155521Inst Instance=new A155521Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155522
{
public static readonly long[] Value={ 1L,3L,0L,1L,0L,2L,9L,9L,9L,5L,6L,6L,3L,9L,8L,1L,1L,9L,5L,2L,1L,3L,7L,3L,8L,8L,9L,4L,7L,2L,4L,4L,9L,3L,0L,2L,6L,7L,6L,8L,1L,8L,9L,8L,8L,1L,4L,6L,2L,1L,0L,8L,5L,4L,1L,3L,1L,0L,4L,2L,7L,4L,6L,1L,1L,2L,7L,1L,0L,8L,1L,8L,9L,2L,7L,4L,4L,2L,4L,5L,0L,9L,4L,8L,6L,9L,2L,7L,2L,5L,2L,1L,1L,8L,1L,8L,6L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155522Inst : IEnumerable<long>
{
public static readonly long[] Value=A155522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155522.Bytes);
public long this[int i]=>Value[i];

public static A155522Inst Instance=new A155522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155523
{
public static readonly long[] Value={ 1L,2L,4L,9L,3L,1L,7L,3L,9L,4L,1L,0L,7L,0L,1L,5L,3L,5L,6L,6L,7L,2L,3L,2L,2L,6L,5L,2L,7L,1L,9L,5L,2L,3L,9L,5L,5L,8L,6L,7L,5L,7L,4L,9L,3L,4L,3L,8L,4L,3L,9L,9L,8L,7L,6L,8L,4L,9L,5L,9L,2L,7L,5L,5L,4L,7L,0L,6L,1L,0L,0L,3L,2L,7L,6L,5L,3L,2L,0L,5L,7L,5L,0L,8L,5L,8L,8L,1L,2L,9L,7L,7L,0L,6L,8L,1L,1L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155523Inst : IEnumerable<long>
{
public static readonly long[] Value=A155523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155523.Bytes);
public long this[int i]=>Value[i];

public static A155523Inst Instance=new A155523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155524
{
public static readonly long[] Value={ 1L,2L,0L,5L,5L,7L,1L,3L,5L,3L,6L,8L,0L,2L,5L,6L,6L,5L,9L,3L,0L,4L,0L,3L,7L,5L,0L,9L,2L,0L,4L,9L,7L,8L,6L,0L,7L,1L,0L,6L,3L,3L,0L,2L,0L,0L,1L,3L,0L,4L,5L,4L,6L,2L,7L,5L,0L,4L,0L,5L,7L,0L,5L,2L,6L,7L,0L,7L,5L,8L,9L,9L,1L,0L,4L,3L,1L,4L,1L,8L,3L,4L,2L,9L,0L,3L,1L,6L,9L,3L,5L,3L,8L,5L,2L,2L,5L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155524Inst : IEnumerable<long>
{
public static readonly long[] Value=A155524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155524.Bytes);
public long this[int i]=>Value[i];

public static A155524Inst Instance=new A155524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155525
{
public static readonly long[] Value={ 1L,1L,6L,7L,9L,4L,9L,8L,7L,1L,9L,2L,9L,9L,4L,2L,8L,3L,4L,2L,1L,6L,5L,8L,5L,6L,9L,9L,7L,2L,5L,2L,0L,3L,0L,0L,6L,8L,8L,3L,6L,5L,4L,5L,2L,9L,6L,4L,6L,9L,0L,6L,1L,7L,5L,1L,2L,3L,1L,5L,0L,5L,6L,0L,2L,1L,3L,9L,8L,7L,8L,5L,5L,7L,8L,4L,0L,5L,9L,6L,3L,0L,9L,2L,4L,2L,3L,8L,2L,3L,0L,9L,3L,9L,6L,2L,5L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155525Inst : IEnumerable<long>
{
public static readonly long[] Value=A155525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155525.Bytes);
public long this[int i]=>Value[i];

public static A155525Inst Instance=new A155525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155526
{
public static readonly long[] Value={ 1L,1L,3L,5L,1L,5L,2L,4L,0L,4L,5L,8L,6L,3L,4L,9L,4L,3L,8L,0L,0L,3L,2L,2L,6L,3L,0L,7L,1L,7L,8L,0L,3L,1L,6L,2L,3L,7L,0L,8L,2L,4L,9L,1L,2L,6L,7L,3L,8L,8L,1L,4L,4L,6L,5L,0L,5L,3L,6L,1L,7L,9L,6L,5L,8L,5L,4L,2L,8L,7L,6L,1L,4L,4L,0L,2L,1L,2L,0L,6L,1L,7L,4L,6L,9L,8L,4L,5L,1L,1L,9L,5L,3L,0L,6L,6L,2L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155526Inst : IEnumerable<long>
{
public static readonly long[] Value=A155526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155526.Bytes);
public long this[int i]=>Value[i];

public static A155526Inst Instance=new A155526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155527
{
public static readonly long[] Value={ 1L,1L,0L,6L,2L,3L,2L,1L,7L,8L,5L,3L,7L,4L,1L,8L,0L,8L,4L,3L,9L,2L,4L,5L,0L,3L,6L,1L,1L,2L,8L,2L,1L,2L,0L,1L,1L,3L,1L,0L,0L,1L,5L,9L,8L,1L,2L,5L,1L,5L,2L,1L,8L,5L,7L,1L,1L,0L,6L,8L,3L,8L,3L,5L,6L,7L,8L,0L,6L,7L,2L,6L,6L,2L,5L,5L,2L,7L,2L,1L,9L,2L,6L,4L,8L,8L,4L,0L,3L,7L,6L,5L,9L,2L,3L,5L,1L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155527Inst : IEnumerable<long>
{
public static readonly long[] Value=A155527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155527.Bytes);
public long this[int i]=>Value[i];

public static A155527Inst Instance=new A155527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155528
{
public static readonly long[] Value={ 1L,0L,8L,0L,4L,8L,2L,0L,2L,3L,7L,2L,1L,8L,4L,0L,5L,8L,6L,9L,6L,7L,5L,7L,9L,8L,5L,7L,3L,7L,2L,3L,4L,7L,5L,4L,3L,9L,6L,6L,2L,0L,7L,8L,4L,8L,2L,5L,6L,1L,4L,5L,1L,5L,3L,0L,1L,3L,6L,8L,9L,0L,9L,8L,9L,5L,3L,9L,8L,3L,6L,9L,4L,1L,5L,2L,1L,5L,6L,3L,0L,3L,9L,6L,2L,5L,3L,4L,9L,3L,5L,8L,3L,9L,8L,4L,2L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155528Inst : IEnumerable<long>
{
public static readonly long[] Value=A155528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155528.Bytes);
public long this[int i]=>Value[i];

public static A155528Inst Instance=new A155528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155529
{
public static readonly long[] Value={ 1L,0L,5L,7L,3L,6L,2L,0L,5L,1L,4L,1L,0L,1L,8L,5L,0L,2L,9L,6L,4L,5L,3L,8L,3L,4L,8L,0L,9L,5L,8L,5L,7L,6L,1L,3L,9L,6L,8L,6L,0L,2L,3L,9L,9L,5L,5L,9L,3L,1L,6L,8L,6L,0L,6L,4L,9L,5L,2L,3L,2L,7L,4L,8L,6L,1L,2L,5L,9L,7L,9L,0L,2L,0L,3L,6L,8L,1L,8L,5L,0L,0L,5L,1L,0L,7L,1L,4L,9L,6L,4L,4L,0L,8L,2L,8L,8L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155529Inst : IEnumerable<long>
{
public static readonly long[] Value=A155529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155529.Bytes);
public long this[int i]=>Value[i];

public static A155529Inst Instance=new A155529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155530
{
public static readonly long[] Value={ 1L,0L,3L,6L,4L,5L,2L,2L,3L,6L,7L,6L,5L,0L,4L,3L,6L,0L,9L,4L,7L,0L,4L,3L,1L,3L,9L,9L,9L,3L,0L,8L,9L,5L,7L,2L,5L,8L,8L,4L,1L,8L,4L,8L,4L,5L,0L,4L,6L,6L,6L,8L,7L,2L,6L,1L,5L,1L,0L,8L,2L,0L,2L,9L,6L,9L,6L,5L,7L,2L,2L,2L,9L,7L,8L,5L,9L,5L,1L,1L,6L,1L,2L,4L,8L,8L,5L,1L,8L,0L,1L,1L,5L,0L,3L,2L,5L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155530Inst : IEnumerable<long>
{
public static readonly long[] Value=A155530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155530.Bytes);
public long this[int i]=>Value[i];

public static A155530Inst Instance=new A155530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155531
{
public static readonly long[] Value={ 1L,0L,1L,7L,4L,2L,0L,3L,9L,6L,4L,6L,6L,1L,7L,8L,9L,2L,2L,5L,0L,9L,3L,7L,5L,4L,9L,0L,9L,5L,2L,3L,5L,1L,1L,6L,1L,8L,7L,9L,2L,5L,0L,8L,0L,5L,8L,4L,8L,6L,8L,9L,1L,5L,2L,4L,7L,3L,6L,8L,3L,2L,1L,7L,8L,4L,2L,3L,2L,2L,9L,9L,9L,0L,8L,2L,0L,7L,8L,8L,2L,5L,1L,1L,9L,9L,4L,4L,3L,9L,3L,3L,3L,8L,6L,4L,4L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155531Inst : IEnumerable<long>
{
public static readonly long[] Value=A155531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155531.Bytes);
public long this[int i]=>Value[i];

public static A155531Inst Instance=new A155531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155532
{
public static readonly long[] Value={ 9L,8L,3L,9L,7L,4L,4L,4L,4L,2L,1L,3L,3L,5L,4L,0L,6L,0L,6L,0L,0L,2L,0L,7L,1L,9L,7L,2L,6L,0L,9L,0L,1L,9L,0L,5L,3L,2L,1L,0L,9L,6L,3L,1L,3L,8L,1L,9L,3L,4L,6L,9L,7L,8L,7L,9L,3L,3L,2L,5L,5L,7L,4L,5L,0L,1L,6L,5L,5L,6L,5L,3L,6L,1L,5L,8L,3L,2L,0L,6L,0L,8L,5L,2L,7L,4L,9L,3L,6L,1L,9L,5L,4L,8L,3L,2L,1L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155532Inst : IEnumerable<long>
{
public static readonly long[] Value=A155532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155532.Bytes);
public long this[int i]=>Value[i];

public static A155532Inst Instance=new A155532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155533
{
public static readonly long[] Value={ 9L,6L,9L,1L,6L,5L,6L,8L,3L,9L,9L,0L,9L,2L,2L,3L,8L,6L,7L,9L,5L,6L,0L,0L,2L,9L,0L,7L,6L,6L,2L,6L,2L,8L,7L,7L,8L,1L,9L,5L,3L,7L,4L,5L,0L,1L,6L,4L,2L,8L,8L,7L,9L,7L,6L,4L,8L,3L,2L,1L,8L,1L,2L,8L,7L,0L,2L,9L,1L,9L,8L,2L,0L,9L,0L,8L,6L,8L,8L,9L,4L,9L,8L,3L,3L,9L,2L,9L,2L,6L,0L,4L,8L,5L,6L,9L,9L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155533Inst : IEnumerable<long>
{
public static readonly long[] Value=A155533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155533.Bytes);
public long this[int i]=>Value[i];

public static A155533Inst Instance=new A155533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155534
{
public static readonly long[] Value={ 9L,5L,5L,4L,2L,5L,8L,6L,5L,0L,3L,1L,0L,5L,9L,3L,3L,6L,9L,5L,7L,7L,7L,5L,3L,8L,8L,7L,3L,1L,8L,5L,4L,1L,5L,1L,9L,9L,9L,9L,2L,1L,2L,6L,3L,7L,6L,8L,4L,8L,0L,7L,2L,9L,2L,7L,7L,7L,9L,4L,8L,7L,1L,7L,7L,4L,1L,8L,9L,4L,6L,6L,3L,0L,2L,0L,6L,2L,8L,7L,1L,7L,3L,6L,2L,9L,0L,0L,0L,4L,3L,6L,5L,3L,9L,8L,0L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155534Inst : IEnumerable<long>
{
public static readonly long[] Value=A155534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155534.Bytes);
public long this[int i]=>Value[i];

public static A155534Inst Instance=new A155534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155535
{
public static readonly long[] Value={ 9L,4L,2L,6L,3L,1L,0L,6L,7L,1L,4L,7L,7L,8L,5L,4L,2L,3L,9L,7L,3L,7L,7L,5L,0L,3L,2L,0L,9L,4L,3L,6L,4L,4L,0L,5L,2L,4L,6L,3L,4L,3L,3L,2L,7L,2L,7L,7L,1L,4L,8L,8L,2L,1L,5L,3L,8L,5L,0L,8L,3L,4L,1L,6L,4L,9L,2L,5L,9L,9L,3L,3L,4L,9L,0L,0L,0L,4L,0L,0L,8L,4L,5L,5L,2L,2L,9L,0L,8L,2L,1L,1L,4L,6L,8L,5L,0L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155535Inst : IEnumerable<long>
{
public static readonly long[] Value=A155535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155535.Bytes);
public long this[int i]=>Value[i];

public static A155535Inst Instance=new A155535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155536
{
public static readonly long[] Value={ 4L,3L,9L,2L,3L,1L,7L,4L,2L,2L,7L,7L,8L,7L,6L,0L,2L,8L,8L,8L,9L,5L,7L,0L,8L,2L,6L,1L,1L,7L,9L,6L,4L,7L,3L,1L,7L,4L,0L,0L,8L,4L,1L,0L,3L,3L,6L,5L,8L,6L,2L,1L,8L,4L,4L,1L,3L,3L,0L,4L,4L,3L,7L,8L,6L,1L,1L,4L,1L,9L,0L,7L,6L,6L,5L,6L,5L,5L,1L,5L,4L,9L,0L,2L,0L,1L,4L,1L,4L,7L,4L,0L,8L,8L,2L,9L,9L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155536Inst : IEnumerable<long>
{
public static readonly long[] Value=A155536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155536.Bytes);
public long this[int i]=>Value[i];

public static A155536Inst Instance=new A155536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155537
{
public static readonly long[] Value={ 3L,5L,5L,9L,27L,9L,17L,102L,102L,17L,33L,330L,660L,330L,33L,65L,975L,3250L,3250L,975L,65L,129L,2709L,13545L,22575L,13545L,2709L,129L,257L,7196L,50372L,125930L,125930L,50372L,7196L,257L,513L,18468L,172368L,603288L,904932L,603288L,172368L,18468L,513L,1025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155537Inst : IEnumerable<long>
{
public static readonly long[] Value=A155537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155537.Bytes);
public long this[int i]=>Value[i];

public static A155537Inst Instance=new A155537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155538
{
public static readonly BigInteger[] Value={ BigInteger.Parse("115792089237316195423570985008687907853269984665640564039457584007913129639936"),BigInteger.Parse("340282366920938463463374607431768211456"),BigInteger.Parse("18446744073709551616"),4294967296L,65536L,256L,16L,4L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
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
public class A155538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155538Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155538.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155538Inst Instance=new A155538Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155539
{
public static readonly BigInteger[] Value={ 1L,5L,57L,945L,18785L,423393L,10609137L,292475249L,8804293473L,287589316833L,10137858491849L,383799398752905L,15536767912476993L,669920208810550337L,BigInteger.Parse("30659724555890596833"),BigInteger.Parse("1484638520651877849057"),BigInteger.Parse("75846305139481944586817") };
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
public class A155539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155539Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155539.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155539Inst Instance=new A155539Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155540
{
public static readonly long[] Value={ 3L,6L,5L,2L,4L,2L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155540Inst : IEnumerable<long>
{
public static readonly long[] Value=A155540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155540.Bytes);
public long this[int i]=>Value[i];

public static A155540Inst Instance=new A155540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155541
{
public static readonly long[] Value={ 2L,7L,7L,1L,2L,4L,3L,7L,4L,9L,1L,6L,1L,4L,2L,2L,2L,6L,0L,0L,6L,7L,9L,2L,8L,3L,0L,7L,0L,8L,2L,4L,5L,7L,7L,1L,8L,0L,6L,6L,4L,7L,1L,3L,3L,4L,5L,9L,4L,2L,4L,3L,4L,7L,9L,3L,6L,8L,9L,9L,2L,5L,7L,7L,2L,7L,9L,8L,8L,6L,1L,9L,8L,7L,0L,2L,8L,1L,2L,2L,1L,0L,8L,3L,4L,3L,0L,0L,9L,8L,9L,3L,3L,7L,5L,0L,8L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155541Inst : IEnumerable<long>
{
public static readonly long[] Value=A155541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155541.Bytes);
public long this[int i]=>Value[i];

public static A155541Inst Instance=new A155541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155542
{
public static readonly BigInteger[] Value={ 2L,18L,194L,2002L,20866L,216978L,2257474L,23484242L,244310786L,2541592338L,26440508354L,275063875282L,2861523711106L,29768786570898L,309688385344834L,3221726747031122L,33516023609869826L,348671357554736658L,3627271450684638914L,BigInteger.Parse("37734955544345527762") };
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
public class A155542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155542Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155542.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155542Inst Instance=new A155542Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155543
{
public static readonly long[] Value={ 2L,4L,16L,64L,256L,1024L,4096L,16384L,65536L,262144L,1048576L,4194304L,16777216L,67108864L,268435456L,1073741824L,4294967296L,17179869184L,68719476736L,274877906944L,1099511627776L,4398046511104L,17592186044416L,70368744177664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155543Inst : IEnumerable<long>
{
public static readonly long[] Value=A155543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155543.Bytes);
public long this[int i]=>Value[i];

public static A155543Inst Instance=new A155543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155544
{
public static readonly long[] Value={ 187L,190L,193L,194L,240L,275L,280L,303L,318L,331L,345L,404L,430L,466L,468L,470L,471L,476L,481L,494L,521L,532L,566L,603L,604L,669L,706L,733L,859L,917L,935L,946L,962L,979L,981L,984L,995L,1020L,1107L,1117L,1140L,1224L,1227L,1230L,1231L,1242L,1245L,1246L,1251L,1253L,1268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155544Inst : IEnumerable<long>
{
public static readonly long[] Value=A155544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155544.Bytes);
public long this[int i]=>Value[i];

public static A155544Inst Instance=new A155544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155545
{
public static readonly long[] Value={ 2L,1L,9L,6L,1L,5L,8L,7L,1L,1L,3L,8L,9L,3L,8L,0L,1L,4L,4L,4L,4L,7L,8L,5L,4L,1L,3L,0L,5L,8L,9L,8L,2L,3L,6L,5L,8L,7L,0L,0L,4L,2L,0L,5L,1L,6L,8L,2L,9L,3L,1L,0L,9L,2L,2L,0L,6L,6L,5L,2L,2L,1L,8L,9L,3L,0L,5L,7L,0L,9L,5L,3L,8L,3L,2L,8L,2L,7L,5L,7L,7L,4L,5L,1L,0L,0L,7L,0L,7L,3L,7L,0L,4L,4L,1L,4L,9L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155545Inst : IEnumerable<long>
{
public static readonly long[] Value=A155545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155545.Bytes);
public long this[int i]=>Value[i];

public static A155545Inst Instance=new A155545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155546
{
public static readonly long[] Value={ -1L,2L,7L,5L,12L,19L,8L,17L,26L,35L,11L,22L,33L,44L,55L,14L,27L,40L,53L,66L,79L,17L,32L,47L,62L,77L,92L,107L,20L,37L,54L,71L,88L,105L,122L,139L,23L,42L,61L,80L,99L,118L,137L,156L,175L,26L,47L,68L,89L,110L,131L,152L,173L,194L,215L,29L,52L,75L,98L,121L,144L,167L,190L,213L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155546Inst : IEnumerable<long>
{
public static readonly long[] Value=A155546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155546.Bytes);
public long this[int i]=>Value[i];

public static A155546Inst Instance=new A155546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155547
{
public static readonly long[] Value={ 2L,7L,13L,19L,23L,29L,31L,43L,53L,61L,67L,173L,179L,193L,199L,223L,227L,281L,283L,311L,317L,337L,347L,409L,419L,433L,443L,457L,461L,463L,467L,491L,503L,521L,523L,541L,547L,569L,577L,593L,599L,601L,607L,619L,641L,647L,653L,809L,811L,827L,839L,857L,859L,941L,947L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155547Inst : IEnumerable<long>
{
public static readonly long[] Value=A155547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155547.Bytes);
public long this[int i]=>Value[i];

public static A155547Inst Instance=new A155547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155548
{
public static readonly long[] Value={ 2L,3L,7L,17L,37L,47L,73L,83L,89L,97L,113L,163L,179L,193L,197L,251L,347L,359L,383L,397L,421L,431L,443L,487L,541L,547L,571L,593L,607L,617L,631L,653L,673L,677L,719L,727L,743L,751L,761L,787L,821L,829L,857L,877L,881L,883L,947L,971L,1009L,1013L,1019L,1021L,1051L,1087L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155548Inst : IEnumerable<long>
{
public static readonly long[] Value=A155548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155548.Bytes);
public long this[int i]=>Value[i];

public static A155548Inst Instance=new A155548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155549
{
public static readonly long[] Value={ 16L,26L,49L,77L,91L,121L,169L,205L,209L,289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155549Inst : IEnumerable<long>
{
public static readonly long[] Value=A155549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155549.Bytes);
public long this[int i]=>Value[i];

public static A155549Inst Instance=new A155549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155550
{
public static readonly long[] Value={ -2L,1L,6L,4L,11L,18L,7L,16L,25L,34L,10L,21L,32L,43L,54L,13L,26L,39L,52L,65L,78L,16L,31L,46L,61L,76L,91L,106L,19L,36L,53L,70L,87L,104L,121L,138L,22L,41L,60L,79L,98L,117L,136L,155L,174L,25L,46L,67L,88L,109L,130L,151L,172L,193L,214L,28L,51L,74L,97L,120L,143L,166L,189L,212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155550Inst : IEnumerable<long>
{
public static readonly long[] Value=A155550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155550.Bytes);
public long this[int i]=>Value[i];

public static A155550Inst Instance=new A155550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155551
{
public static readonly long[] Value={ -5L,-2L,3L,1L,8L,15L,4L,13L,22L,31L,7L,18L,29L,40L,51L,10L,23L,36L,49L,62L,75L,13L,28L,43L,58L,73L,88L,103L,16L,33L,50L,67L,84L,101L,118L,135L,19L,38L,57L,76L,95L,114L,133L,152L,171L,22L,43L,64L,85L,106L,127L,148L,169L,190L,211L,25L,48L,71L,94L,117L,140L,163L,186L,209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155551Inst : IEnumerable<long>
{
public static readonly long[] Value=A155551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155551.Bytes);
public long this[int i]=>Value[i];

public static A155551Inst Instance=new A155551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155552
{
public static readonly long[] Value={ 5L,13L,23L,29L,43L,53L,79L,127L,157L,167L,173L,223L,227L,229L,233L,239L,257L,263L,271L,277L,283L,293L,313L,317L,337L,353L,373L,379L,433L,523L,557L,563L,577L,647L,757L,773L,797L,839L,853L,859L,863L,887L,977L,1103L,1117L,1123L,1153L,1171L,1187L,1193L,1217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155552Inst : IEnumerable<long>
{
public static readonly long[] Value=A155552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155552.Bytes);
public long this[int i]=>Value[i];

public static A155552Inst Instance=new A155552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155553
{
public static readonly long[] Value={ 1L,8L,9L,1L,6L,6L,8L,1L,4L,9L,6L,0L,8L,1L,5L,2L,8L,5L,1L,8L,9L,7L,8L,8L,2L,7L,0L,4L,8L,1L,8L,4L,1L,2L,3L,2L,4L,1L,4L,1L,2L,2L,5L,3L,2L,9L,5L,8L,4L,0L,0L,0L,3L,3L,8L,3L,6L,6L,2L,9L,2L,8L,9L,2L,3L,4L,6L,6L,2L,4L,3L,6L,3L,9L,2L,4L,4L,1L,3L,2L,6L,3L,9L,3L,5L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155553Inst : IEnumerable<long>
{
public static readonly long[] Value=A155553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155553.Bytes);
public long this[int i]=>Value[i];

public static A155553Inst Instance=new A155553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155554
{
public static readonly long[] Value={ 1L,6L,9L,9L,1L,8L,0L,3L,2L,5L,2L,6L,7L,1L,5L,0L,2L,5L,6L,1L,1L,5L,7L,9L,5L,9L,1L,2L,4L,6L,0L,0L,0L,0L,4L,5L,6L,4L,5L,3L,6L,3L,9L,0L,9L,5L,7L,4L,4L,0L,8L,9L,5L,6L,6L,4L,9L,7L,6L,0L,7L,5L,3L,1L,4L,4L,9L,9L,5L,2L,6L,2L,7L,3L,3L,1L,4L,2L,2L,8L,4L,7L,1L,5L,8L,6L,8L,9L,3L,6L,0L,8L,9L,4L,3L,2L,8L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155554Inst : IEnumerable<long>
{
public static readonly long[] Value=A155554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155554.Bytes);
public long this[int i]=>Value[i];

public static A155554Inst Instance=new A155554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155555
{
public static readonly long[] Value={ 11L,19L,31L,41L,59L,61L,67L,71L,101L,103L,107L,109L,131L,137L,139L,149L,151L,181L,191L,199L,211L,241L,269L,281L,307L,311L,331L,349L,367L,389L,401L,409L,419L,439L,449L,457L,461L,463L,467L,479L,491L,499L,503L,509L,521L,569L,587L,599L,601L,613L,619L,641L,643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155555Inst : IEnumerable<long>
{
public static readonly long[] Value=A155555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155555.Bytes);
public long this[int i]=>Value[i];

public static A155555Inst Instance=new A155555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155556
{
public static readonly long[] Value={ 1L,1L,4L,44L,1144L,1056L,65208L,53152L,7824960L,5450016L,4677376L,1932765120L,1119751776L,786197984L,970248090240L,457228062720L,253156757568L,204411475840L,982861315413120L,369853933363200L,156721804462080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155556Inst : IEnumerable<long>
{
public static readonly long[] Value=A155556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155556.Bytes);
public long this[int i]=>Value[i];

public static A155556Inst Instance=new A155556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155557
{
public static readonly long[] Value={ 53089L,53093L,53101L,53113L,53129L,53149L,53173L,53201L,53233L,53269L,53309L,53353L,53401L,53453L,53509L,53569L,53633L,53701L,53773L,53849L,53929L,54013L,54101L,54193L,54289L,54389L,54493L,54601L,54713L,54829L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155557Inst : IEnumerable<long>
{
public static readonly long[] Value=A155557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155557.Bytes);
public long this[int i]=>Value[i];

public static A155557Inst Instance=new A155557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155558
{
public static readonly BigInteger[] Value={ 1L,1L,6L,138L,10488L,8280L,2485656L,1392696L,1794643632L,663449904L,448448112L,3910528474128L,904634615952L,375908525712L,25621782562486656L,3570752184568704L,852504801992064L,514242863174016L,BigInteger.Parse("504057328351799983488") };
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
public class A155558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155558Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155558.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155558Inst Instance=new A155558Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155559
{
public static readonly long[] Value={ 0L,2L,4L,8L,16L,32L,64L,128L,256L,512L,1024L,2048L,4096L,8192L,16384L,32768L,65536L,131072L,262144L,524288L,1048576L,2097152L,4194304L,8388608L,16777216L,33554432L,67108864L,134217728L,268435456L,536870912L,1073741824L,2147483648L,4294967296L,8589934592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155559Inst : IEnumerable<long>
{
public static readonly long[] Value=A155559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155559.Bytes);
public long this[int i]=>Value[i];

public static A155559Inst Instance=new A155559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155560
{
public static readonly long[] Value={ 13L,37L,52L,61L,73L,97L,100L,109L,117L,148L,157L,169L,181L,193L,208L,229L,241L,244L,277L,292L,313L,325L,333L,337L,349L,373L,388L,397L,400L,409L,421L,433L,436L,457L,468L,481L,541L,549L,577L,592L,601L,613L,628L,637L,657L,661L,673L,676L,709L,724L,733L,757L,769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155560Inst : IEnumerable<long>
{
public static readonly long[] Value=A155560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155560.Bytes);
public long this[int i]=>Value[i];

public static A155560Inst Instance=new A155560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155561
{
public static readonly long[] Value={ 17L,18L,34L,41L,68L,72L,73L,82L,89L,97L,113L,136L,137L,146L,153L,162L,164L,178L,193L,194L,225L,226L,233L,241L,242L,257L,272L,274L,281L,288L,289L,292L,306L,313L,328L,337L,353L,356L,369L,386L,388L,401L,409L,425L,433L,449L,450L,452L,457L,466L,482L,514L,521L,544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155561Inst : IEnumerable<long>
{
public static readonly long[] Value=A155561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155561.Bytes);
public long this[int i]=>Value[i];

public static A155561Inst Instance=new A155561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155562
{
public static readonly long[] Value={ 0L,1L,2L,4L,8L,9L,16L,17L,18L,25L,32L,34L,36L,41L,49L,50L,64L,68L,72L,73L,81L,82L,89L,97L,98L,100L,113L,121L,128L,136L,137L,144L,146L,153L,162L,164L,169L,178L,193L,194L,196L,200L,225L,226L,233L,241L,242L,256L,257L,272L,274L,281L,288L,289L,292L,306L,313L,324L,328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155562Inst : IEnumerable<long>
{
public static readonly long[] Value=A155562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155562.Bytes);
public long this[int i]=>Value[i];

public static A155562Inst Instance=new A155562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155563
{
public static readonly long[] Value={ 0L,1L,4L,9L,13L,16L,25L,36L,37L,49L,52L,61L,64L,73L,81L,97L,100L,109L,117L,121L,144L,148L,157L,169L,181L,193L,196L,208L,225L,229L,241L,244L,256L,277L,289L,292L,313L,324L,325L,333L,337L,349L,361L,373L,388L,397L,400L,409L,421L,433L,436L,441L,457L,468L,481L,484L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155563Inst : IEnumerable<long>
{
public static readonly long[] Value=A155563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155563.Bytes);
public long this[int i]=>Value[i];

public static A155563Inst Instance=new A155563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155564
{
public static readonly long[] Value={ 0L,1L,3L,4L,9L,12L,16L,19L,25L,27L,36L,43L,48L,49L,57L,64L,67L,73L,75L,76L,81L,97L,100L,108L,121L,129L,139L,144L,147L,163L,169L,171L,172L,192L,193L,196L,201L,211L,219L,225L,228L,241L,243L,256L,268L,283L,289L,291L,292L,300L,304L,307L,313L,324L,331L,337L,361L,363L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155564Inst : IEnumerable<long>
{
public static readonly long[] Value=A155564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155564.Bytes);
public long this[int i]=>Value[i];

public static A155564Inst Instance=new A155564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155565
{
public static readonly long[] Value={ 0L,1L,4L,5L,9L,16L,20L,25L,29L,36L,41L,45L,49L,61L,64L,80L,81L,89L,100L,101L,109L,116L,121L,125L,144L,145L,149L,164L,169L,180L,181L,196L,205L,225L,229L,241L,244L,245L,256L,261L,269L,281L,289L,305L,320L,324L,349L,356L,361L,369L,389L,400L,401L,404L,405L,409L,421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155565Inst : IEnumerable<long>
{
public static readonly long[] Value=A155565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155565.Bytes);
public long this[int i]=>Value[i];

public static A155565Inst Instance=new A155565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155566
{
public static readonly long[] Value={ 0L,1L,4L,9L,10L,16L,25L,36L,40L,49L,58L,64L,73L,81L,90L,97L,100L,106L,121L,144L,145L,160L,169L,193L,196L,202L,225L,232L,241L,250L,256L,265L,289L,292L,298L,313L,324L,337L,346L,360L,361L,388L,394L,400L,409L,424L,433L,441L,457L,484L,490L,505L,522L,529L,538L,576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155566Inst : IEnumerable<long>
{
public static readonly long[] Value=A155566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155566.Bytes);
public long this[int i]=>Value[i];

public static A155566Inst Instance=new A155566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155567
{
public static readonly long[] Value={ 0L,1L,4L,6L,9L,16L,24L,25L,36L,41L,49L,54L,64L,81L,86L,89L,96L,100L,121L,129L,134L,144L,150L,164L,166L,169L,196L,201L,214L,216L,225L,241L,246L,249L,256L,281L,289L,294L,321L,324L,326L,344L,356L,361L,369L,384L,400L,401L,409L,441L,449L,454L,484L,486L,489L,516L,521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155567Inst : IEnumerable<long>
{
public static readonly long[] Value=A155567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155567.Bytes);
public long this[int i]=>Value[i];

public static A155567Inst Instance=new A155567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155568
{
public static readonly long[] Value={ 0L,1L,4L,8L,9L,16L,25L,29L,32L,36L,37L,49L,53L,64L,72L,81L,100L,109L,113L,116L,121L,128L,137L,144L,148L,149L,169L,193L,196L,197L,200L,212L,225L,232L,233L,256L,261L,277L,281L,288L,289L,296L,317L,324L,333L,337L,361L,373L,389L,392L,400L,401L,421L,424L,436L,441L,449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155568Inst : IEnumerable<long>
{
public static readonly long[] Value=A155568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155568.Bytes);
public long this[int i]=>Value[i];

public static A155568Inst Instance=new A155568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155569
{
public static readonly long[] Value={ 0L,1L,4L,6L,9L,16L,22L,24L,25L,33L,36L,49L,54L,64L,73L,81L,88L,96L,97L,100L,118L,121L,132L,144L,150L,166L,169L,177L,193L,196L,198L,214L,216L,225L,241L,249L,256L,262L,289L,292L,294L,297L,313L,321L,324L,337L,352L,358L,361L,384L,388L,393L,400L,409L,433L,438L,441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155569Inst : IEnumerable<long>
{
public static readonly long[] Value=A155569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155569.Bytes);
public long this[int i]=>Value[i];

public static A155569Inst Instance=new A155569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155570
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,21L,25L,36L,49L,61L,64L,81L,84L,100L,109L,121L,129L,144L,169L,181L,189L,196L,201L,225L,229L,241L,244L,256L,289L,301L,309L,324L,336L,349L,361L,381L,400L,409L,421L,436L,441L,469L,484L,489L,516L,525L,529L,541L,549L,576L,601L,625L,661L,669L,676L,709L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155570Inst : IEnumerable<long>
{
public static readonly long[] Value=A155570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155570.Bytes);
public long this[int i]=>Value[i];

public static A155570Inst Instance=new A155570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155571
{
public static readonly long[] Value={ 61L,109L,181L,229L,241L,244L,349L,409L,421L,436L,541L,549L,601L,661L,709L,724L,769L,829L,900L,916L,964L,976L,981L,1009L,1021L,1069L,1129L,1201L,1225L,1249L,1321L,1381L,1396L,1429L,1489L,1521L,1525L,1549L,1609L,1621L,1629L,1636L,1669L,1684L,1741L,1744L,1789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155571Inst : IEnumerable<long>
{
public static readonly long[] Value=A155571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155571.Bytes);
public long this[int i]=>Value[i];

public static A155571Inst Instance=new A155571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155572
{
public static readonly long[] Value={ 41L,89L,164L,225L,241L,281L,356L,369L,401L,409L,449L,521L,569L,601L,641L,656L,761L,769L,801L,809L,881L,900L,929L,964L,1009L,1025L,1049L,1124L,1129L,1201L,1249L,1289L,1321L,1361L,1409L,1424L,1476L,1481L,1489L,1521L,1601L,1604L,1609L,1636L,1681L,1721L,1796L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155572Inst : IEnumerable<long>
{
public static readonly long[] Value=A155572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155572.Bytes);
public long this[int i]=>Value[i];

public static A155572Inst Instance=new A155572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155573
{
public static readonly long[] Value={ 73L,97L,193L,241L,292L,313L,337L,388L,409L,433L,457L,577L,601L,657L,673L,769L,772L,873L,900L,937L,964L,1009L,1033L,1129L,1153L,1156L,1168L,1201L,1249L,1252L,1297L,1321L,1348L,1489L,1521L,1552L,1609L,1636L,1657L,1732L,1737L,1753L,1777L,1801L,1825L,1828L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155573Inst : IEnumerable<long>
{
public static readonly long[] Value=A155573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155573.Bytes);
public long this[int i]=>Value[i];

public static A155573Inst Instance=new A155573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155574
{
public static readonly long[] Value={ 12L,19L,36L,43L,48L,57L,67L,73L,76L,97L,108L,129L,139L,144L,147L,163L,171L,172L,192L,193L,201L,211L,219L,228L,241L,268L,283L,291L,292L,300L,304L,307L,313L,324L,331L,337L,361L,379L,387L,388L,409L,417L,432L,433L,441L,457L,475L,484L,489L,499L,507L,513L,516L,523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155574Inst : IEnumerable<long>
{
public static readonly long[] Value=A155574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155574.Bytes);
public long this[int i]=>Value[i];

public static A155574Inst Instance=new A155574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155575
{
public static readonly long[] Value={ 29L,41L,45L,61L,89L,101L,109L,116L,145L,149L,164L,180L,181L,205L,225L,229L,241L,244L,245L,261L,269L,281L,305L,349L,356L,369L,389L,401L,404L,405L,409L,421L,436L,445L,449L,461L,464L,505L,509L,521L,541L,545L,549L,569L,580L,596L,601L,641L,656L,661L,701L,709L,720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155575Inst : IEnumerable<long>
{
public static readonly long[] Value=A155575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155575.Bytes);
public long this[int i]=>Value[i];

public static A155575Inst Instance=new A155575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155576
{
public static readonly long[] Value={ 10L,25L,40L,58L,73L,90L,97L,100L,106L,145L,160L,193L,202L,225L,232L,241L,250L,265L,292L,298L,313L,337L,346L,360L,388L,394L,400L,409L,424L,433L,457L,490L,505L,522L,538L,577L,580L,586L,601L,625L,634L,640L,657L,673L,730L,745L,769L,772L,778L,808L,810L,841L,865L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155576Inst : IEnumerable<long>
{
public static readonly long[] Value=A155576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155576.Bytes);
public long this[int i]=>Value[i];

public static A155576Inst Instance=new A155576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155577
{
public static readonly long[] Value={ 6L,9L,24L,36L,41L,54L,81L,86L,89L,96L,129L,134L,144L,150L,164L,166L,201L,214L,216L,225L,241L,246L,249L,281L,294L,321L,324L,326L,344L,356L,369L,384L,401L,409L,441L,449L,454L,486L,489L,516L,521L,534L,536L,566L,569L,576L,600L,601L,614L,641L,656L,664L,681L,694L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155577Inst : IEnumerable<long>
{
public static readonly long[] Value=A155577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155577.Bytes);
public long this[int i]=>Value[i];

public static A155577Inst Instance=new A155577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155578
{
public static readonly long[] Value={ 8L,29L,32L,37L,53L,72L,109L,113L,116L,128L,137L,148L,149L,193L,197L,200L,212L,232L,233L,261L,277L,281L,288L,296L,317L,333L,337L,373L,389L,392L,400L,401L,421L,424L,436L,449L,452L,457L,464L,477L,512L,541L,548L,557L,569L,592L,596L,613L,617L,641L,648L,653L,673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155578Inst : IEnumerable<long>
{
public static readonly long[] Value=A155578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155578.Bytes);
public long this[int i]=>Value[i];

public static A155578Inst Instance=new A155578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155579
{
public static readonly long[] Value={ 2L,3L,12L,63L,378L,2457L,16848L,120042L,880308L,6602310L,50417640L,390736710L,3065780340L,24307258410L,194458067280L,1567818167445L,12726994535730L,103937122041795L,853378475711580L,7040372424620535L,58334514375427290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155579Inst : IEnumerable<long>
{
public static readonly long[] Value=A155579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155579.Bytes);
public long this[int i]=>Value[i];

public static A155579Inst Instance=new A155579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155580
{
public static readonly long[] Value={ 1L,1L,2L,5L,10L,30L,180L,585L,1430L,3575L,9100L,31850L,83300L,220150L,792540L,11888100L,32167800L,87567900L,1576222200L,4334611050L,11971782900L,33194488950L,92367273600L,257858638800L,722004188640L,18050104716000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155580Inst : IEnumerable<long>
{
public static readonly long[] Value=A155580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155580.Bytes);
public long this[int i]=>Value[i];

public static A155580Inst Instance=new A155580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155581
{
public static readonly long[] Value={ 1L,1L,2L,7L,28L,84L,384L,1824L,6080L,30400L,304000L,1064000L,12768000L,67488000L,359936000L,1934656000L,30954496000L,526226432000L,2880397312000L,15842185216000L,316843704320000L,1757042360320000L,38654931927040000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155581Inst : IEnumerable<long>
{
public static readonly long[] Value=A155581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155581.Bytes);
public long this[int i]=>Value[i];

public static A155581Inst Instance=new A155581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155582
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,2L,7L,2L,1L,1L,3L,3L,3L,3L,1L,1L,6L,9L,20L,9L,6L,1L,1L,7L,21L,35L,35L,21L,7L,1L,1L,8L,28L,56L,70L,56L,28L,8L,1L,1L,5L,36L,84L,126L,126L,84L,36L,5L,1L,1L,10L,25L,120L,210L,252L,210L,120L,25L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155582Inst : IEnumerable<long>
{
public static readonly long[] Value=A155582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155582.Bytes);
public long this[int i]=>Value[i];

public static A155582Inst Instance=new A155582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155583
{
public static readonly long[] Value={ 1L,1L,2L,6L,12L,28L,36L,36L,216L,216L,720L,1512L,1512L,2520L,12096L,12096L,12096L,10080L,60480L,108864L,108864L,54432L,604800L,604800L,1088640L,544320L,326592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155583Inst : IEnumerable<long>
{
public static readonly long[] Value=A155583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155583.Bytes);
public long this[int i]=>Value[i];

public static A155583Inst Instance=new A155583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155584
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,2L,0L,1L,3L,3L,0L,1L,4L,5L,4L,0L,1L,5L,10L,7L,5L,0L,1L,6L,17L,13L,9L,6L,0L,1L,7L,26L,21L,28L,15L,7L,0L,1L,8L,37L,31L,65L,40L,17L,8L,0L,1L,9L,50L,43L,126L,85L,82L,21L,9L,0L,1L,8L,65L,57L,217L,156L,257L,91L,27L,10L,0L,1L,8L,10L,73L,344L,259L,626L,273L,112L,31L,11L,0L,1L,8L,11L,80L,513L,400L,1297L,651L,325L,121L,33L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155584Inst : IEnumerable<long>
{
public static readonly long[] Value=A155584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155584.Bytes);
public long this[int i]=>Value[i];

public static A155584Inst Instance=new A155584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155585
{
public static readonly BigInteger[] Value={ 1L,1L,0L,-2L,0L,16L,0L,-272L,0L,7936L,0L,-353792L,0L,22368256L,0L,-1903757312L,0L,209865342976L,0L,-29088885112832L,0L,4951498053124096L,0L,-1015423886506852352L,0L,BigInteger.Parse("246921480190207983616"),0L,BigInteger.Parse("-70251601603943959887872"),0L,BigInteger.Parse("23119184187809597841473536"),0L };
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
public class A155585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155585Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A155585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155585.Bytes);
public BigInteger this[int i]=>Value[i];

public static A155585Inst Instance=new A155585Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155586
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,5L,2L,1L,1L,1L,14L,5L,2L,1L,1L,1L,42L,14L,5L,2L,1L,1L,1L,132L,42L,14L,5L,2L,1L,1L,1L,429L,132L,42L,14L,5L,2L,1L,1L,1L,1430L,429L,132L,42L,14L,5L,2L,1L,1L,1L,4862L,1430L,429L,132L,42L,14L,5L,2L,1L,1L,1L,16796L,4862L,1430L,429L,132L,42L,14L,5L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155586Inst : IEnumerable<long>
{
public static readonly long[] Value=A155586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155586.Bytes);
public long this[int i]=>Value[i];

public static A155586Inst Instance=new A155586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155587
{
public static readonly long[] Value={ 1L,2L,3L,5L,10L,24L,66L,198L,627L,2057L,6919L,23715L,82501L,290513L,1033413L,3707853L,13402698L,48760368L,178405158L,656043858L,2423307048L,8987427468L,33453694488L,124936258128L,467995871778L,1757900019102L,6619846420554L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155587Inst : IEnumerable<long>
{
public static readonly long[] Value=A155587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155587.Bytes);
public long this[int i]=>Value[i];

public static A155587Inst Instance=new A155587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155588
{
public static readonly long[] Value={ 1L,6L,28L,132L,640L,3156L,15688L,78252L,390880L,1953636L,9766648L,48830172L,244144720L,1220711316L,6103532008L,30517610892L,152587956160L,762939584196L,3814697527768L,19073486852412L,95367432689200L,476837160300276L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155588Inst : IEnumerable<long>
{
public static readonly long[] Value=A155588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155588.Bytes);
public long this[int i]=>Value[i];

public static A155588Inst Instance=new A155588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155589
{
public static readonly long[] Value={ 1L,7L,39L,223L,1311L,7807L,46719L,280063L,1679871L,10078207L,60467199L,362799103L,2176786431L,13060702207L,78364180479L,470185017343L,2821109972991L,16926659575807L,101559956930559L,609359740534783L,3656158441111551L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155589Inst : IEnumerable<long>
{
public static readonly long[] Value=A155589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155589.Bytes);
public long this[int i]=>Value[i];

public static A155589Inst Instance=new A155589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155590
{
public static readonly long[] Value={ 1L,8L,52L,350L,2416L,16838L,117712L,823670L,5765056L,40354118L,282476272L,1977328790L,13841291296L,96889018598L,678223089232L,4747561542710L,33232930635136L,232630514118278L,1628413598172592L,11398895185897430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155590Inst : IEnumerable<long>
{
public static readonly long[] Value=A155590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155590.Bytes);
public long this[int i]=>Value[i];

public static A155590Inst Instance=new A155590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155591
{
public static readonly long[] Value={ 1L,5L,6L,4L,5L,7L,5L,0L,3L,4L,0L,5L,3L,5L,7L,9L,6L,1L,3L,8L,0L,4L,5L,5L,0L,1L,6L,7L,1L,7L,4L,9L,0L,8L,5L,3L,6L,1L,4L,3L,2L,2L,7L,9L,1L,1L,1L,8L,6L,7L,9L,2L,5L,9L,5L,0L,4L,5L,4L,0L,9L,2L,6L,2L,3L,0L,7L,7L,5L,2L,3L,1L,4L,2L,0L,0L,4L,0L,9L,4L,9L,9L,0L,1L,0L,2L,8L,1L,5L,4L,4L,5L,8L,4L,3L,6L,1L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155591Inst : IEnumerable<long>
{
public static readonly long[] Value=A155591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155591.Bytes);
public long this[int i]=>Value[i];

public static A155591Inst Instance=new A155591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155592
{
public static readonly long[] Value={ 1L,9L,67L,519L,4111L,32799L,262207L,2097279L,16777471L,134218239L,1073742847L,8589936639L,68719480831L,549755822079L,4398046527487L,35184372121599L,281474976776191L,2251799813816319L,18014398509744127L,144115188076380159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155592Inst : IEnumerable<long>
{
public static readonly long[] Value=A155592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155592.Bytes);
public long this[int i]=>Value[i];

public static A155592Inst Instance=new A155592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155593
{
public static readonly long[] Value={ 1L,10L,84L,736L,6576L,59080L,531504L,4783096L,43046976L,387421000L,3486785424L,31381061656L,282429540576L,2541865836520L,22876792471344L,205891132127416L,1853020188917376L,16677181699797640L,150094635297261264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155593Inst : IEnumerable<long>
{
public static readonly long[] Value=A155593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155593.Bytes);
public long this[int i]=>Value[i];

public static A155593Inst Instance=new A155593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155594
{
public static readonly long[] Value={ 1L,11L,103L,1007L,10015L,100031L,1000063L,10000127L,100000255L,1000000511L,10000001023L,100000002047L,1000000004095L,10000000008191L,100000000016383L,1000000000032767L,10000000000065535L,100000000000131071L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155594Inst : IEnumerable<long>
{
public static readonly long[] Value=A155594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155594.Bytes);
public long this[int i]=>Value[i];

public static A155594Inst Instance=new A155594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155595
{
public static readonly long[] Value={ 1L,12L,124L,1338L,14656L,161082L,1771624L,19487298L,214359136L,2357948202L,25937425624L,285311672658L,3138428380816L,34522712152122L,379749833599624L,4177248169448418L,45949729863637696L,505447028499424842L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155595Inst : IEnumerable<long>
{
public static readonly long[] Value=A155595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155595.Bytes);
public long this[int i]=>Value[i];

public static A155595Inst Instance=new A155595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155596
{
public static readonly long[] Value={ 1L,4L,22L,118L,610L,3094L,15562L,77998L,390370L,1952614L,9764602L,48826078L,244136530L,1220694934L,6103499242L,30517545358L,152587825090L,762939322054L,3814697003482L,19073485803838L,95367430592050L,476837156105974L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155596Inst : IEnumerable<long>
{
public static readonly long[] Value=A155596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155596.Bytes);
public long this[int i]=>Value[i];

public static A155596Inst Instance=new A155596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155597
{
public static readonly long[] Value={ 1L,5L,33L,209L,1281L,7745L,46593L,279809L,1679361L,10077185L,60465153L,362795009L,2176778241L,13060685825L,78364147713L,470184951809L,2821109841921L,16926659313665L,101559956406273L,609359739486209L,3656158439014401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155597Inst : IEnumerable<long>
{
public static readonly long[] Value=A155597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155597.Bytes);
public long this[int i]=>Value[i];

public static A155597Inst Instance=new A155597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155598
{
public static readonly long[] Value={ 1L,6L,46L,336L,2386L,16776L,117586L,823416L,5764546L,40353096L,282474226L,1977324696L,13841283106L,96889002216L,678223056466L,4747561477176L,33232930504066L,232630513856136L,1628413597648306L,11398895184848856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155598Inst : IEnumerable<long>
{
public static readonly long[] Value=A155598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155598.Bytes);
public long this[int i]=>Value[i];

public static A155598Inst Instance=new A155598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155599
{
public static readonly long[] Value={ 1L,7L,61L,505L,4081L,32737L,262081L,2097025L,16776961L,134217217L,1073740801L,8589932545L,68719472641L,549755805697L,4398046494721L,35184372056065L,281474976645121L,2251799813554177L,18014398509219841L,144115188075331585L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155599Inst : IEnumerable<long>
{
public static readonly long[] Value=A155599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155599.Bytes);
public long this[int i]=>Value[i];

public static A155599Inst Instance=new A155599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155600
{
public static readonly long[] Value={ 1L,8L,78L,722L,6546L,59018L,531378L,4782842L,43046466L,387419978L,3486783378L,31381057562L,282429532386L,2541865820138L,22876792438578L,205891132061882L,1853020188786306L,16677181699535498L,150094635296736978L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155600Inst : IEnumerable<long>
{
public static readonly long[] Value=A155600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155600.Bytes);
public long this[int i]=>Value[i];

public static A155600Inst Instance=new A155600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155601
{
public static readonly long[] Value={ 1L,9L,97L,993L,9985L,99969L,999937L,9999873L,99999745L,999999489L,9999998977L,99999997953L,999999995905L,9999999991809L,99999999983617L,999999999967233L,9999999999934465L,99999999999868929L,999999999999737857L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155601Inst : IEnumerable<long>
{
public static readonly long[] Value=A155601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155601.Bytes);
public long this[int i]=>Value[i];

public static A155601Inst Instance=new A155601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155602
{
public static readonly long[] Value={ 1L,6L,24L,90L,336L,1266L,4824L,18570L,72096L,281826L,1107624L,4371450L,17308656L,68703186L,273218424L,1088090730L,4338014016L,17309009346L,69106897224L,276040168410L,1102998412176L,4408506864306L,17623567104024L,70462887356490L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155602Inst : IEnumerable<long>
{
public static readonly long[] Value=A155602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155602.Bytes);
public long this[int i]=>Value[i];

public static A155602Inst Instance=new A155602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155603
{
public static readonly long[] Value={ 1L,7L,33L,151L,705L,3367L,16353L,80311L,397185L,1972807L,9824673L,49005271L,244672065L,1222297447L,6108298593L,30531927031L,152630937345L,763068593287L,3815084686113L,19074648589591L,95370918425025L,476847618556327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155603Inst : IEnumerable<long>
{
public static readonly long[] Value=A155603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155603.Bytes);
public long this[int i]=>Value[i];

public static A155603Inst Instance=new A155603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A155604
{
public static readonly long[] Value={ 1L,8L,44L,242L,1376L,8018L,47384L,282122L,1686176L,10097378L,60525224L,362974202L,2177313776L,13062288338L,78368947064L,470199333482L,2821152954176L,16926788584898L,101560344088904L,609360902271962L,3656161926847376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A155604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A155604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A155604Inst : IEnumerable<long>
{
public static readonly long[] Value=A155604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A155604.Bytes);
public long this[int i]=>Value[i];

public static A155604Inst Instance=new A155604Inst();

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