using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A275534
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,9L,12L,15L,18L,22L,25L,29L,33L,37L,43L,46L,51L,56L,62L,68L,75L,79L,86L,93L,102L,107L,114L,119L,127L,136L,143L,150L,160L,169L,179L,184L,195L,206L,215L,223L,233L,242L,254L,264L,274L,285L,297L,307L,318L,330L,339L,350L,362L,376L,386L,400L,415L,428L,441L,452L,465L,483L,498L,510L,525L,541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275534Inst : IEnumerable<long>
{
public static readonly long[] Value=A275534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275534.Bytes);
public long this[int i]=>Value[i];

public static A275534Inst Instance=new A275534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275535
{
public static readonly long[] Value={ 3L,6L,3L,12L,5L,6L,7L,24L,9L,10L,11L,12L,13L,14L,15L,48L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,96L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,192L,65L,66L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275535Inst : IEnumerable<long>
{
public static readonly long[] Value=A275535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275535.Bytes);
public long this[int i]=>Value[i];

public static A275535Inst Instance=new A275535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275536
{
public static readonly long[] Value={ 1L,2L,11L,3L,12L,21L,111L,4L,13L,22L,112L,31L,121L,211L,1111L,5L,14L,23L,113L,32L,122L,212L,1112L,41L,131L,221L,1121L,311L,1211L,2111L,11111L,6L,15L,24L,114L,33L,123L,213L,1113L,42L,132L,222L,1122L,312L,1212L,2112L,11112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275536Inst : IEnumerable<long>
{
public static readonly long[] Value=A275536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275536.Bytes);
public long this[int i]=>Value[i];

public static A275536Inst Instance=new A275536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275537
{
public static readonly long[] Value={ 5L,10L,14L,18L,21L,25L,29L,32L,35L,39L,42L,46L,49L,53L,56L,60L,63L,66L,70L,73L,76L,80L,83L,87L,90L,93L,97L,100L,104L,107L,110L,114L,117L,120L,124L,127L,130L,134L,137L,140L,144L,147L,151L,154L,157L,161L,164L,167L,171L,174L,177L,181L,184L,187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275537Inst : IEnumerable<long>
{
public static readonly long[] Value=A275537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275537.Bytes);
public long this[int i]=>Value[i];

public static A275537Inst Instance=new A275537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275538
{
public static readonly long[] Value={ 1L,3L,4L,9L,10L,13L,19L,21L,25L,28L,70L,81L,97L,106L,291L,369L,460L,577L,4705L,5427L,7153L,7191L,7885L,12070L,20794L,34855L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275538Inst : IEnumerable<long>
{
public static readonly long[] Value=A275538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275538.Bytes);
public long this[int i]=>Value[i];

public static A275538Inst Instance=new A275538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275539
{
public static readonly BigInteger[] Value={ 1L,2L,4L,12L,36L,160L,810L,5376L,41160L,366336L,3638250L,39959040L,479126340L,6227619840L,87180183090L,1307684044800L,20922822320400L,355687603568640L,6402374325997650L,121645103938928640L,2432902021271221500L,BigInteger.Parse("51090942249743155200"),BigInteger.Parse("1124000728080092512650") };
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
public class A275539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275539Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275539.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275539Inst Instance=new A275539Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275588
{
public static readonly BigInteger[] Value={ 1L,1L,2L,16L,BigInteger.Parse("429496729600000000000000000000000000000000") };
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
public class A275588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275588Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275588.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275588Inst Instance=new A275588Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275589
{
public static readonly long[] Value={ 1L,4L,6L,8L,9L,1L,0L,1L,1L,1L,1L,1L,4L,1L,1L,6L,1L,1L,8L,1L,9L,0L,1L,4L,6L,8L,9L,0L,1L,4L,6L,8L,9L,4L,0L,4L,1L,4L,4L,4L,4L,4L,4L,6L,4L,4L,8L,4L,9L,0L,1L,4L,6L,8L,9L,6L,0L,6L,1L,6L,6L,6L,4L,6L,6L,6L,6L,6L,8L,6L,9L,0L,1L,4L,6L,8L,9L,8L,0L,8L,1L,8L,8L,8L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275589Inst : IEnumerable<long>
{
public static readonly long[] Value=A275589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275589.Bytes);
public long this[int i]=>Value[i];

public static A275589Inst Instance=new A275589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275590
{
public static readonly long[] Value={ 1L,4L,2L,3L,6L,7L,5L,8L,10L,9L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,26L,27L,28L,24L,25L,29L,30L,31L,32L,33L,36L,37L,38L,40L,34L,35L,39L,41L,42L,43L,44L,45L,49L,50L,54L,46L,47L,48L,51L,52L,53L,55L,59L,60L,64L,65L,69L,70L,74L,56L,57L,58L,61L,62L,63L,66L,67L,68L,71L,72L,73L,75L,79L,81L,82L,83L,86L,87L,88L,91L,92L,76L,77L,78L,80L,84L,85L,89L,90L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275590Inst : IEnumerable<long>
{
public static readonly long[] Value=A275590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275590.Bytes);
public long this[int i]=>Value[i];

public static A275590Inst Instance=new A275590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275591
{
public static readonly long[] Value={ 1L,11L,23L,37L,53L,71L,91L,113L,137L,163L,191L,221L,253L,287L,323L,361L,401L,443L,487L,533L,581L,631L,683L,737L,793L,851L,911L,973L,1037L,1103L,1171L,1241L,1313L,1387L,1463L,1541L,1621L,1703L,1787L,1873L,1961L,2051L,2143L,2237L,2333L,2431L,2531L,2633L,2737L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275591Inst : IEnumerable<long>
{
public static readonly long[] Value=A275591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275591.Bytes);
public long this[int i]=>Value[i];

public static A275591Inst Instance=new A275591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275592
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,12L,16L,26L,35L,56L,74L,117L,154L,241L,317L,492L,645L,998L,1306L,2014L,2634L,4053L,5296L,8139L,10630L,16321L,21310L,32699L,42684L,65472L,85452L,131038L,171012L,262198L,342161L,524552L,684497L,1049300L,1369216L,2098849L,2738710L,4198011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275592Inst : IEnumerable<long>
{
public static readonly long[] Value=A275592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275592.Bytes);
public long this[int i]=>Value[i];

public static A275592Inst Instance=new A275592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275593
{
public static readonly BigInteger[] Value={ 1L,1L,1L,2L,6L,30L,270L,5100L,229380L,27535260L,9496469340L,10086965678520L,34571745136244520L,BigInteger.Parse("403054252638271664040"),BigInteger.Parse("16565160940382442188713320"),BigInteger.Parse("2510059126960200448967150682000"),BigInteger.Parse("1444160075122431073529236697462766000") };
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
public class A275593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275593Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275593.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275593Inst Instance=new A275593Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275594
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,2L,6L,24L,144L,1464L,26808L,935184L,67404816L,10401844896L,3508019017056L,2732681228689152L,5018025242941566336L,BigInteger.Parse("21914759744001662937984"),BigInteger.Parse("238559201308551667344338304"),BigInteger.Parse("6565759935393013059564090526464") };
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
public class A275594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275594Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275594.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275594Inst Instance=new A275594Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275595
{
public static readonly long[] Value={ 1L,1L,1L,4L,2L,1L,38L,10L,3L,1L,728L,100L,18L,4L,1L,26704L,1856L,192L,28L,5L,1L,1866256L,63728L,3528L,320L,40L,6L,1L,251548592L,4169200L,114792L,5912L,490L,54L,7L,1L,66296291072L,535647520L,7034832L,184576L,9200L,708L,70L,8L,1L,34496488594816L,137186152064L,858485568L,10624672L,278840L,13608L,980L,88L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275595Inst : IEnumerable<long>
{
public static readonly long[] Value=A275595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275595.Bytes);
public long this[int i]=>Value[i];

public static A275595Inst Instance=new A275595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275596
{
public static readonly long[] Value={ 11L,17L,23L,31L,37L,59L,73L,83L,97L,103L,167L,233L,257L,263L,307L,359L,401L,431L,433L,443L,467L,479L,487L,491L,499L,569L,727L,733L,743L,773L,839L,863L,877L,911L,919L,971L,991L,1013L,1039L,1069L,1091L,1097L,1103L,1153L,1163L,1193L,1229L,1237L,1297L,1409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275596Inst : IEnumerable<long>
{
public static readonly long[] Value=A275596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275596.Bytes);
public long this[int i]=>Value[i];

public static A275596Inst Instance=new A275596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275597
{
public static readonly BigInteger[] Value={ 1L,2L,7L,52L,851L,28786L,1933879L,255839048L,66839167987L,34634544150646L,35712147523562999L,BigInteger.Parse("73426704068062929628"),BigInteger.Parse("301419821377908100819123"),BigInteger.Parse("2472253358027383404798964442"),BigInteger.Parse("40532633024489540112983979301783"),BigInteger.Parse("1328660090565074145503909701745941840") };
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
public class A275597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275597Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275597.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275597Inst Instance=new A275597Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275598
{
public static readonly long[] Value={ 11L,13L,23L,47L,193L,383L,577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275598Inst : IEnumerable<long>
{
public static readonly long[] Value=A275598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275598.Bytes);
public long this[int i]=>Value[i];

public static A275598Inst Instance=new A275598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275599
{
public static readonly long[] Value={ 1L,3L,1L,7L,4L,1L,15L,12L,4L,1L,31L,27L,13L,4L,1L,63L,61L,34L,13L,4L,1L,127L,124L,77L,35L,13L,4L,1L,255L,258L,165L,86L,35L,13L,4L,1L,511L,513L,348L,185L,87L,35L,13L,4L,1L,1023L,1039L,698L,399L,196L,87L,35L,13L,4L,1L,2047L,2062L,1410L,811L,423L,197L,87L,35L,13L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275599Inst : IEnumerable<long>
{
public static readonly long[] Value=A275599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275599.Bytes);
public long this[int i]=>Value[i];

public static A275599Inst Instance=new A275599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275600
{
public static readonly long[] Value={ 0L,1L,2L,6L,36L,37L,260L,1302L,1376L,1380L,1381L,1382L,1556L,1560L,1561L,1562L,16932L,562500L,562501L,562502L,562506L,562512L,562536L,562537L,562752L,562760L,23610752L,23610756L,23610757L,23610786L,23615750L,23615760L,23615761L,23615762L,23615785L,23615786L,23626310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275600Inst : IEnumerable<long>
{
public static readonly long[] Value=A275600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275600.Bytes);
public long this[int i]=>Value[i];

public static A275600Inst Instance=new A275600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275601
{
public static readonly long[] Value={ 1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275601Inst : IEnumerable<long>
{
public static readonly long[] Value=A275601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275601.Bytes);
public long this[int i]=>Value[i];

public static A275601Inst Instance=new A275601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275602
{
public static readonly long[] Value={ 1L,3L,7L,9L,11L,17L,21L,23L,13L,19L,27L,29L,33L,47L,39L,41L,31L,57L,61L,37L,43L,63L,67L,53L,49L,51L,59L,69L,71L,77L,83L,79L,73L,81L,91L,87L,97L,109L,89L,101L,111L,113L,99L,1037L,121L,107L,93L,103L,123L,127L,129L,131L,119L,1023L,1031L,117L,1039L,133L,1009L,153L,157L,141L,143L,139L,137L,149L,159L,161L,151L,163L,171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275602Inst : IEnumerable<long>
{
public static readonly long[] Value=A275602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275602.Bytes);
public long this[int i]=>Value[i];

public static A275602Inst Instance=new A275602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275603
{
public static readonly long[] Value={ 1L,2L,5L,8L,11L,14L,23L,12L,19L,6L,7L,4L,3L,10L,9L,16L,13L,20L,31L,24L,25L,18L,17L,26L,29L,32L,15L,22L,35L,38L,41L,30L,37L,28L,27L,34L,21L,50L,39L,46L,43L,40L,49L,48L,55L,36L,53L,76L,33L,52L,51L,64L,57L,56L,47L,68L,45L,58L,65L,44L,67L,60L,59L,62L,73L,42L,61L,54L,71L,80L,63L,74L,77L,94L,75L,82L,79L,72L,83L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275603Inst : IEnumerable<long>
{
public static readonly long[] Value=A275603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275603.Bytes);
public long this[int i]=>Value[i];

public static A275603Inst Instance=new A275603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275652
{
public static readonly BigInteger[] Value={ 1L,10L,300L,11440L,485100L,21841260L,1022041020L,49128552000L,2408829328620L,119918393838100L,6042249840712800L,307438844121252480L,15770112362658517500UL,BigInteger.Parse("814459593645444166560"),BigInteger.Parse("42308586942403276440000"),BigInteger.Parse("2208850973597860123741440"),BigInteger.Parse("115825519836558228435979500") };
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
public class A275652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275652Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275652.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275652Inst Instance=new A275652Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275653
{
public static readonly BigInteger[] Value={ 1L,18L,1050L,77616L,6370650L,554822268L,50199951984L,4664758248000L,442077195513690L,42533571002422500L,4141601026094832300L,BigInteger.Parse("407220411993767798400"),BigInteger.Parse("40363606408574136870000"),BigInteger.Parse("4028061310168832261158176"),BigInteger.Parse("404311537318239680601595200"),BigInteger.Parse("40785601782042745410592271616") };
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
public class A275653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275653Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275653.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275653Inst Instance=new A275653Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275654
{
public static readonly BigInteger[] Value={ 1L,28L,2646L,316540L,42031990L,5921058528L,866486466720L,130220534668224L,19958454291525750L,3105489721784166640L,BigInteger.Parse("489023391870111994896"),BigInteger.Parse("77758775451291032116200"),BigInteger.Parse("12464212878673327376454304"),BigInteger.Parse("2011515147856766922731424000") };
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
public class A275654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275654Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275654.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275654Inst Instance=new A275654Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275655
{
public static readonly BigInteger[] Value={ 1L,40L,5544L,972400L,189290920L,39089615040L,8385425017200L,1847301025078080L,415026659401497000L,BigInteger.Parse("94660194875011205440"),BigInteger.Parse("21850091031597537252544"),BigInteger.Parse("5092815839064962373499680"),BigInteger.Parse("1196622940864849837505171824"),BigInteger.Parse("283073284848591452381449360000") };
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
public class A275655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275655Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275655.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275655Inst Instance=new A275655Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275656
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,1L,2L,3L,1L,1L,2L,3L,2L,2L,3L,2L,1L,1L,2L,2L,2L,2L,4L,2L,2L,1L,1L,4L,2L,2L,3L,3L,1L,2L,3L,3L,3L,1L,2L,3L,2L,1L,2L,4L,2L,3L,5L,3L,2L,3L,2L,4L,2L,1L,4L,2L,2L,2L,2L,5L,3L,3L,4L,4L,2L,1L,3L,5L,2L,3L,4L,1L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275656Inst : IEnumerable<long>
{
public static readonly long[] Value=A275656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275656.Bytes);
public long this[int i]=>Value[i];

public static A275656Inst Instance=new A275656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275657
{
public static readonly long[] Value={ 1L,2L,4L,3L,5L,6L,7L,22L,20L,8L,9L,10L,11L,12L,23L,13L,25L,27L,14L,15L,32L,33L,21L,16L,17L,35L,37L,52L,18L,19L,40L,41L,42L,53L,55L,57L,72L,73L,75L,77L,222L,223L,24L,43L,225L,227L,232L,233L,235L,237L,26L,44L,45L,252L,253L,28L,46L,47L,255L,257L,220L,48L,49L,60L,61L,62L,272L,273L,275L,63L,277L,322L,323L,29L,64L,65L,325L,327L,332L,221L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275657Inst : IEnumerable<long>
{
public static readonly long[] Value=A275657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275657.Bytes);
public long this[int i]=>Value[i];

public static A275657Inst Instance=new A275657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275658
{
public static readonly long[] Value={ 1L,2L,4L,9L,10L,11L,12L,13L,14L,16L,18L,64L,66L,100L,101L,112L,113L,1024L,1025L,1026L,1027L,1028L,1029L,1030L,1031L,1032L,1033L,1034L,1035L,1036L,1037L,1038L,1039L,1040L,1041L,1042L,1043L,1044L,1045L,1046L,1047L,1048L,1049L,1050L,1051L,1052L,1053L,1054L,1055L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275658Inst : IEnumerable<long>
{
public static readonly long[] Value=A275658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275658.Bytes);
public long this[int i]=>Value[i];

public static A275658Inst Instance=new A275658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275659
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,5L,7L,8L,9L,12L,10L,11L,20L,14L,16L,13L,18L,19L,15L,21L,40L,41L,44L,22L,23L,24L,46L,48L,49L,17L,25L,26L,60L,61L,64L,66L,27L,28L,68L,69L,80L,81L,84L,42L,29L,86L,88L,89L,90L,43L,30L,91L,94L,96L,98L,99L,31L,100L,101L,104L,106L,108L,109L,45L,32L,33L,34L,110L,111L,114L,116L,47L,35L,36L,118L,119L,140L,141L,144L,37L,38L,146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275659Inst : IEnumerable<long>
{
public static readonly long[] Value=A275659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275659.Bytes);
public long this[int i]=>Value[i];

public static A275659Inst Instance=new A275659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275660
{
public static readonly long[] Value={ 1L,13L,19L,34L,43L,53L,58L,89L,103L,151L,229L,251L,254L,329L,341L,349L,404L,433L,463L,593L,674L,701L,739L,859L,1033L,1223L,1429L,1483L,1506L,1670L,1709L,1826L,1846L,1886L,1889L,1948L,1951L,2067L,2091L,2143L,2255L,2308L,2431L,2699L,3001L,3079L,3319L,3739L,4003L,4093L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275660Inst : IEnumerable<long>
{
public static readonly long[] Value=A275660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275660.Bytes);
public long this[int i]=>Value[i];

public static A275660Inst Instance=new A275660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275661
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275661Inst : IEnumerable<long>
{
public static readonly long[] Value=A275661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275661.Bytes);
public long this[int i]=>Value[i];

public static A275661Inst Instance=new A275661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275662
{
public static readonly long[] Value={ 1L,3L,1L,7L,6L,1L,15L,18L,7L,1L,31L,48L,17L,9L,1L,63L,109L,49L,20L,11L,1L,127L,240L,115L,52L,24L,13L,1L,255L,498L,258L,122L,61L,28L,15L,1L,511L,1026L,551L,261L,136L,71L,32L,17L,1L,1023L,2065L,1163L,531L,298L,157L,81L,36L,19L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275662Inst : IEnumerable<long>
{
public static readonly long[] Value=A275662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275662.Bytes);
public long this[int i]=>Value[i];

public static A275662Inst Instance=new A275662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275663
{
public static readonly long[] Value={ 1L,1L,3L,2L,3L,3L,3L,2L,4L,3L,3L,3L,3L,3L,3L,3L,3L,4L,3L,3L,4L,3L,3L,3L,4L,3L,5L,3L,3L,3L,5L,3L,5L,3L,3L,5L,3L,3L,3L,3L,5L,4L,5L,3L,3L,3L,5L,3L,4L,4L,3L,3L,3L,5L,5L,3L,5L,3L,3L,3L,3L,5L,3L,4L,5L,5L,3L,3L,3L,3L,5L,5L,5L,3L,5L,3L,3L,3L,3L,3L,4L,5L,5L,4L,5L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275663Inst : IEnumerable<long>
{
public static readonly long[] Value=A275663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275663.Bytes);
public long this[int i]=>Value[i];

public static A275663Inst Instance=new A275663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275664
{
public static readonly BigInteger[] Value={ 2L,4L,6L,14L,86L,3614L,6526886L,21300113901614L,BigInteger.Parse("226847426110843688722000886"),BigInteger.Parse("25729877366557343481074291996721923093306518970391614") };
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
public class A275664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275664Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275664.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275664Inst Instance=new A275664Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275665
{
public static readonly long[] Value={ 1L,6L,10L,12L,14L,15L,18L,20L,21L,22L,24L,26L,28L,33L,34L,35L,36L,38L,39L,40L,44L,45L,46L,48L,50L,51L,52L,54L,55L,56L,57L,58L,62L,63L,65L,68L,69L,72L,74L,75L,76L,77L,80L,82L,85L,86L,87L,88L,91L,92L,93L,94L,95L,96L,98L,99L,100L,104L,106L,108L,111L,112L,115L,116L,117L,118L,119L,122L,123L,124L,129L,133L,134L,135L,136L,141L,142L,143L,144L,145L,146L,147L,148L,152L,153L,155L,158L,159L,160L,161L,162L,164L,165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275665Inst : IEnumerable<long>
{
public static readonly long[] Value=A275665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275665.Bytes);
public long this[int i]=>Value[i];

public static A275665Inst Instance=new A275665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275666
{
public static readonly long[] Value={ 2L,3L,6L,2L,5L,5L,10L,3L,5L,5L,6L,10L,2L,4L,6L,12L,3L,3L,4L,12L,4L,5L,5L,6L,10L,12L,2L,7L,7L,7L,14L,3L,6L,7L,7L,7L,14L,4L,6L,7L,7L,7L,12L,14L,5L,5L,7L,7L,7L,10L,14L,2L,3L,10L,15L,2L,4L,10L,12L,15L,2L,5L,6L,15L,15L,3L,3L,5L,15L,15L,3L,3L,6L,10L,15L,3L,5L,5L,5L,15L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275666Inst : IEnumerable<long>
{
public static readonly long[] Value=A275666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275666.Bytes);
public long this[int i]=>Value[i];

public static A275666Inst Instance=new A275666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275667
{
public static readonly long[] Value={ 1L,3L,7L,9L,7L,21L,25L,27L,7L,21L,49L,63L,25L,75L,103L,81L,7L,21L,49L,63L,49L,147L,175L,189L,25L,75L,175L,225L,103L,309L,409L,243L,7L,21L,49L,63L,49L,147L,175L,189L,49L,147L,343L,441L,175L,525L,721L,567L,25L,75L,175L,225L,175L,525L,625L,675L,103L,309L,721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275667Inst : IEnumerable<long>
{
public static readonly long[] Value=A275667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275667.Bytes);
public long this[int i]=>Value[i];

public static A275667Inst Instance=new A275667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275780
{
public static readonly long[] Value={ 1L,1L,2L,4L,12L,43L,160L,668L,3098L,15465L,83100L,477651L,2914505L,18795814L,127790544L,911448954L,6808162094L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275780Inst : IEnumerable<long>
{
public static readonly long[] Value=A275780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275780.Bytes);
public long this[int i]=>Value[i];

public static A275780Inst Instance=new A275780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275781
{
public static readonly long[] Value={ 0L,0L,0L,1L,3L,9L,43L,209L,1042L,5682L,32875L,200919L,1299092L,8848623L,63108778L,471509591L,3671980053L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275781Inst : IEnumerable<long>
{
public static readonly long[] Value=A275781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275781.Bytes);
public long this[int i]=>Value[i];

public static A275781Inst Instance=new A275781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275782
{
public static readonly long[] Value={ 0L,11L,10L,100L,101L,102L,120L,1002L,1022L,1012L,1021L,1023L,1201L,1203L,1230L,10023L,10121L,10120L,10201L,10123L,10232L,10213L,10231L,10234L,12132L,12013L,12031L,12034L,12301L,12304L,12340L,100234L,101201L,101213L,101232L,101203L,101231L,101230L,102031L,101234L,102132L,102130L,102301L,102134L,102342L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275782Inst : IEnumerable<long>
{
public static readonly long[] Value=A275782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275782.Bytes);
public long this[int i]=>Value[i];

public static A275782Inst Instance=new A275782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275783
{
public static readonly long[] Value={ 2L,3L,6L,11L,44L,64L,83L,123L,166L,381L,446L,1221L,1540L,3156L,5117L,5476L,6291L,6353L,13053L,15158L,23904L,78288L,82254L,91230L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275783Inst : IEnumerable<long>
{
public static readonly long[] Value=A275783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275783.Bytes);
public long this[int i]=>Value[i];

public static A275783Inst Instance=new A275783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275784
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,2L,1L,1L,0L,1L,4L,5L,1L,1L,0L,1L,12L,53L,16L,1L,1L,0L,1L,36L,761L,936L,61L,1L,1L,0L,1L,120L,12661L,87336L,25325L,272L,1L,1L,0L,1L,400L,229705L,9929000L,18528505L,933980L,1385L,1L,1L,0L,1L,1400L,4410665L,1267945800L,17504311533L,6376563600L,45504649L,7936L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275784Inst : IEnumerable<long>
{
public static readonly long[] Value=A275784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275784.Bytes);
public long this[int i]=>Value[i];

public static A275784Inst Instance=new A275784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275785
{
public static readonly long[] Value={ 3L,5L,11L,23L,29L,31L,37L,89L,113L,127L,139L,149L,199L,251L,293L,331L,337L,367L,409L,521L,523L,631L,701L,787L,797L,953L,1087L,1129L,1151L,1259L,1277L,1327L,1361L,1381L,1399L,1657L,1669L,1847L,1933L,1949L,1951L,1973L,2477L,2503L,2579L,2633L,2861L,2879L,2971L,2999L,3089L,3137L,3163L,3229L,3407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275785Inst : IEnumerable<long>
{
public static readonly long[] Value=A275785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275785.Bytes);
public long this[int i]=>Value[i];

public static A275785Inst Instance=new A275785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275786
{
public static readonly long[] Value={ 1L,3L,6L,30L,15L,378L,28L,1080L,270L,2475L,66L,294840L,91L,8820L,10800L,146880L,153L,2908710L,190L,5197500L,38808L,50094L,276L,3184272000L,4875L,95823L,102060L,35809200L,435L,17401230000L,496L,77552640L,222156L,273105L,264600L,1511016670800L,703L,422370L,425880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275786Inst : IEnumerable<long>
{
public static readonly long[] Value=A275786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275786.Bytes);
public long this[int i]=>Value[i];

public static A275786Inst Instance=new A275786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275787
{
public static readonly BigInteger[] Value={ 5L,41L,509L,8469L,176217L,4400325L,128203049L,4268957449L,159922273421L,6656731517249L,304797275277365L,15224868078068845L,823874409422614577L,BigInteger.Parse("48012621942105876301"),BigInteger.Parse("2997884066292303095889"),BigInteger.Parse("199666128081901473290833"),BigInteger.Parse("14129411123649333432720277"),BigInteger.Parse("1058688691179737704258634521"),BigInteger.Parse("83732563305101190468369022317"),BigInteger.Parse("6971039973751002759723517967941") };
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
public class A275787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275787Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275787.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275787Inst Instance=new A275787Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275788
{
public static readonly long[] Value={ 0L,1L,3L,7L,13L,25L,49L,99L,199L,399L,797L,1593L,3185L,6371L,12743L,25487L,50973L,101945L,203889L,407779L,815559L,1631119L,3262237L,6524473L,13048945L,26097891L,52195783L,104391567L,208783133L,417566265L,835132529L,1670265059L,3340530119L,6681060239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275788Inst : IEnumerable<long>
{
public static readonly long[] Value=A275788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275788.Bytes);
public long this[int i]=>Value[i];

public static A275788Inst Instance=new A275788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275789
{
public static readonly long[] Value={ 1L,4L,6L,8L,12L,12L,6L,20L,7L,12L,12L,24L,24L,12L,12L,30L,12L,28L,30L,24L,24L,12L,12L,60L,30L,24L,30L,24L,60L,12L,24L,24L,12L,36L,12L,56L,18L,60L,24L,60L,24L,24L,30L,24L,84L,12L,12L,30L,36L,60L,12L,168L,36L,60L,12L,60L,60L,60L,60L,24L,30L,24L,42L,128L,24L,12L,18L,24L,24L,12L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275789Inst : IEnumerable<long>
{
public static readonly long[] Value=A275789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275789.Bytes);
public long this[int i]=>Value[i];

public static A275789Inst Instance=new A275789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275790
{
public static readonly long[] Value={ 1L,8L,1L,-32L,11L,3L,-736L,-92L,9L,15L,2816L,-593L,-249L,-65L,35L,48976L,6122L,1581L,-970L,-1295L,315L,-951424L,61252L,67791L,46030L,18515L,-21735L,3465L,-1045952L,-130744L,-92082L,-30445L,14455L,53928L,-25179L,3003L,26933248L,1069361L,-1666047L,-634255L,-1167740L,-1258236L,1562253L,-471471L,45045L,634836808L,79354601L,24881793L,17914550L,30289840L,12635028L,-71064609L,42480438L,-9594585L,765765L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275790Inst : IEnumerable<long>
{
public static readonly long[] Value=A275790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275790.Bytes);
public long this[int i]=>Value[i];

public static A275790Inst Instance=new A275790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275791
{
public static readonly long[] Value={ 1L,-4L,1L,4L,-5L,1L,0L,12L,-7L,1L,4L,-21L,25L,-9L,1L,-8L,30L,-63L,42L,-11L,1L,0L,-44L,131L,-138L,63L,-13L,1L,0L,72L,-246L,365L,-253L,88L,-15L,1L,4L,-85L,425L,-837L,808L,-416L,117L,-17L,1L,-4L,85L,-685L,1734L,-2200L,1552L,-635L,150L,-19L,1L,8L,-134L,1053L,-3319L,5326L,-4888L,2705L,-918L,187L,-21L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275791Inst : IEnumerable<long>
{
public static readonly long[] Value=A275791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275791.Bytes);
public long this[int i]=>Value[i];

public static A275791Inst Instance=new A275791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275792
{
public static readonly long[] Value={ 1L,1L,5L,0L,9L,8L,2L,3L,6L,8L,0L,9L,4L,6L,7L,6L,3L,8L,6L,3L,6L,3L,6L,8L,9L,8L,9L,6L,9L,5L,2L,6L,7L,5L,0L,5L,8L,3L,0L,9L,6L,6L,7L,0L,9L,5L,5L,1L,8L,7L,4L,9L,1L,0L,9L,8L,3L,9L,6L,4L,5L,7L,8L,4L,5L,0L,5L,0L,4L,2L,6L,9L,1L,0L,9L,1L,3L,6L,6L,7L,4L,1L,4L,0L,9L,6L,6L,7L,5L,5L,3L,7L,0L,6L,3L,0L,5L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275792Inst : IEnumerable<long>
{
public static readonly long[] Value=A275792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275792.Bytes);
public long this[int i]=>Value[i];

public static A275792Inst Instance=new A275792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275793
{
public static readonly long[] Value={ 9L,43L,249L,1451L,8457L,49291L,287289L,1674443L,9759369L,56881771L,331531257L,1932305771L,11262303369L,65641514443L,382586783289L,2229879185291L,12996688328457L,75750250785451L,441504816384249L,2573278647520043L,14998167068736009L,87415723764896011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275793Inst : IEnumerable<long>
{
public static readonly long[] Value=A275793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275793.Bytes);
public long this[int i]=>Value[i];

public static A275793Inst Instance=new A275793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275794
{
public static readonly long[] Value={ 2L,15L,88L,513L,2990L,17427L,101572L,592005L,3450458L,20110743L,117214000L,683173257L,3981825542L,23207779995L,135264854428L,788381346573L,4595023225010L,26781758003487L,156095524795912L,909791390771985L,5302652819835998L,30906125528244003L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275794Inst : IEnumerable<long>
{
public static readonly long[] Value=A275794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275794.Bytes);
public long this[int i]=>Value[i];

public static A275794Inst Instance=new A275794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275795
{
public static readonly long[] Value={ 11L,57L,331L,1929L,11243L,65529L,381931L,2226057L,12974411L,75620409L,440748043L,2568867849L,14972459051L,87265886457L,508622859691L,2964471271689L,17278204770443L,100704757350969L,586950339335371L,3420997278661257L,19939033332632171L,116213202717131769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275795Inst : IEnumerable<long>
{
public static readonly long[] Value=A275795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275795.Bytes);
public long this[int i]=>Value[i];

public static A275795Inst Instance=new A275795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275828
{
public static readonly long[] Value={ 1L,8L,6L,6L,7L,6L,0L,3L,9L,9L,1L,7L,3L,8L,6L,2L,0L,9L,2L,9L,9L,0L,8L,7L,2L,0L,6L,2L,4L,9L,6L,4L,6L,3L,6L,4L,2L,1L,9L,2L,2L,1L,8L,8L,2L,6L,7L,0L,5L,7L,6L,1L,3L,4L,8L,8L,3L,5L,5L,3L,0L,8L,1L,2L,9L,0L,4L,9L,0L,8L,0L,7L,0L,1L,2L,1L,6L,6L,8L,7L,2L,7L,0L,5L,2L,8L,4L,2L,7L,1L,6L,8L,5L,7L,3L,4L,2L,1L,5L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275828Inst : IEnumerable<long>
{
public static readonly long[] Value=A275828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275828.Bytes);
public long this[int i]=>Value[i];

public static A275828Inst Instance=new A275828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275829
{
public static readonly BigInteger[] Value={ 1L,1L,2L,12L,140L,2564L,68728L,2539632L,123686800L,7677924688L,591741636128L,55438330474944L,6204888219697856L,817697605612952384L,BigInteger.Parse("125322509904814743424"),BigInteger.Parse("22102340129003429880576"),BigInteger.Parse("4444468680409243484516608"),BigInteger.Parse("1010802175212828388101900544"),BigInteger.Parse("258152577318424951261637001728") };
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
public class A275829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275829Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275829.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275829Inst Instance=new A275829Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275830
{
public static readonly long[] Value={ 3L,-7L,49L,-196L,1029L,-4802L,24010L,-117649L,588245L,-2941225L,14823774L,-74942413L,380476866L,-1936973136L,9886633715L,-50563069571L,259029803333L,-1328763571296L,6823754590093L,-35073821767334L,180407337377834L,-928487386730281L,4780794440512601L,-24625601552074341L,126883328914736618L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275830Inst : IEnumerable<long>
{
public static readonly long[] Value=A275830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275830.Bytes);
public long this[int i]=>Value[i];

public static A275830Inst Instance=new A275830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275831
{
public static readonly long[] Value={ 3L,0L,14L,21L,98L,245L,833L,2401L,7546L,22638L,69629L,211288L,645869L,1966419L,6000099L,18286016L,55765626L,170002805L,518361494L,1580379017L,4818550093L,14691183577L,44792503770L,136568135690L,416385811429L,1269524476220L,3870677629833L,11801372013543L,35981414742371L,109704347503632L,334479507291398L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275831Inst : IEnumerable<long>
{
public static readonly long[] Value=A275831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275831.Bytes);
public long this[int i]=>Value[i];

public static A275831Inst Instance=new A275831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275832
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,3L,1L,2L,1L,4L,3L,4L,1L,3L,1L,4L,2L,4L,2L,3L,2L,4L,3L,4L,1L,2L,1L,3L,2L,3L,1L,2L,1L,5L,4L,5L,1L,4L,1L,5L,2L,5L,3L,4L,3L,5L,4L,5L,1L,2L,1L,4L,3L,4L,1L,2L,1L,5L,4L,5L,1L,3L,1L,5L,3L,5L,2L,3L,2L,5L,4L,5L,1L,3L,1L,4L,2L,4L,1L,3L,1L,5L,3L,5L,1L,4L,1L,5L,2L,5L,2L,4L,2L,5L,3L,5L,2L,3L,2L,4L,3L,4L,2L,3L,2L,5L,4L,5L,2L,4L,2L,5L,3L,5L,3L,4L,3L,5L,4L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275832Inst : IEnumerable<long>
{
public static readonly long[] Value=A275832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275832.Bytes);
public long this[int i]=>Value[i];

public static A275832Inst Instance=new A275832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275833
{
public static readonly long[] Value={ 0L,2L,3L,5L,6L,8L,10L,12L,13L,14L,19L,22L,24L,26L,27L,29L,30L,32L,33L,35L,36L,38L,39L,41L,42L,44L,45L,47L,48L,50L,52L,54L,56L,57L,59L,60L,61L,62L,63L,64L,65L,67L,69L,71L,72L,73L,74L,78L,79L,80L,81L,82L,83L,84L,86L,87L,89L,93L,94L,95L,97L,100L,103L,105L,107L,111L,112L,113L,114L,116L,117L,119L,120L,122L,123L,125L,126L,128L,130L,132L,133L,134L,139L,142L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275833Inst : IEnumerable<long>
{
public static readonly long[] Value=A275833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275833.Bytes);
public long this[int i]=>Value[i];

public static A275833Inst Instance=new A275833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275834
{
public static readonly long[] Value={ 1L,4L,7L,9L,11L,15L,16L,17L,18L,20L,21L,23L,25L,28L,31L,34L,37L,40L,43L,46L,49L,51L,53L,55L,58L,66L,68L,70L,75L,76L,77L,85L,88L,90L,91L,92L,96L,98L,99L,101L,102L,104L,106L,108L,109L,110L,115L,118L,121L,124L,127L,129L,131L,135L,136L,137L,138L,140L,141L,143L,145L,148L,151L,153L,155L,159L,160L,161L,162L,164L,165L,167L,169L,172L,175L,177L,179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275834Inst : IEnumerable<long>
{
public static readonly long[] Value=A275834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275834.Bytes);
public long this[int i]=>Value[i];

public static A275834Inst Instance=new A275834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275835
{
public static readonly long[] Value={ 0L,1L,6L,3L,4L,2L,56L,20L,36L,17L,21L,9L,48L,15L,30L,13L,16L,7L,18L,8L,24L,10L,12L,5L,495L,135L,74L,31L,132L,53L,582L,401L,147L,59L,157L,158L,361L,116L,216L,173L,117L,47L,136L,155L,380L,46L,78L,82L,420L,111L,61L,25L,108L,45L,490L,347L,123L,51L,133L,134L,312L,93L,192L,149L,94L,41L,112L,131L,327L,40L,64L,68L,360L,270L,80L,38L,88L,89L,416L,303L,99L,44L,109L,110L,288L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275835Inst : IEnumerable<long>
{
public static readonly long[] Value=A275835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275835.Bytes);
public long this[int i]=>Value[i];

public static A275835Inst Instance=new A275835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275836
{
public static readonly long[] Value={ 0L,1L,5L,3L,4L,23L,2L,17L,19L,11L,21L,99L,22L,15L,111L,13L,16L,9L,18L,95L,7L,10L,118L,119L,20L,51L,101L,98L,106L,107L,14L,27L,113L,110L,85L,89L,8L,623L,75L,91L,69L,65L,115L,707L,81L,53L,45L,41L,12L,103L,659L,57L,94L,29L,615L,611L,6L,93L,579L,33L,100L,50L,603L,695L,70L,689L,112L,97L,71L,507L,616L,719L,114L,109L,26L,711L,88L,647L,46L,641L,74L,117L,47L,441L,688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275836Inst : IEnumerable<long>
{
public static readonly long[] Value=A275836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275836.Bytes);
public long this[int i]=>Value[i];

public static A275836Inst Instance=new A275836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275837
{
public static readonly long[] Value={ 0L,1L,2L,4L,18L,5L,6L,22L,12L,3L,96L,20L,72L,17L,14L,19L,114L,13L,94L,10L,11L,23L,108L,15L,24L,79L,84L,100L,101L,21L,48L,102L,8L,9L,600L,71L,480L,49L,78L,118L,119L,16L,65L,73L,98L,99L,696L,27L,360L,594L,62L,63L,70L,112L,54L,113L,74L,7L,45L,95L,552L,116L,50L,117L,672L,603L,454L,569L,37L,40L,29L,106L,444L,41L,36L,107L,85L,97L,38L,621L,86L,82L,545L,110L,528L,59L,56L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275837Inst : IEnumerable<long>
{
public static readonly long[] Value=A275837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275837.Bytes);
public long this[int i]=>Value[i];

public static A275837Inst Instance=new A275837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275838
{
public static readonly long[] Value={ 0L,1L,2L,9L,3L,5L,6L,57L,32L,33L,19L,20L,8L,17L,14L,23L,41L,13L,4L,15L,11L,29L,7L,21L,24L,133L,272L,47L,293L,70L,150L,263L,152L,357L,109L,110L,74L,68L,78L,163L,69L,73L,135L,545L,249L,58L,230L,220L,30L,37L,62L,225L,100L,161L,54L,127L,86L,285L,209L,85L,182L,172L,50L,51L,197L,42L,104L,231L,105L,431L,52L,35L,12L,43L,56L,99L,213L,95L,38L,25L,134L,153L,81L,341L,26L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275838Inst : IEnumerable<long>
{
public static readonly long[] Value=A275838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275838.Bytes);
public long this[int i]=>Value[i];

public static A275838Inst Instance=new A275838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275839
{
public static readonly long[] Value={ 0L,1L,2L,5L,6L,14L,24L,54L,120L,145L,264L,411L,464L,720L,842L,1560L,2042L,2408L,2670L,5040L,5766L,10800L,13686L,16590L,18144L,40320L,45384L,85680L,105864L,106153L,131184L,141960L,145728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275839Inst : IEnumerable<long>
{
public static readonly long[] Value=A275839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275839.Bytes);
public long this[int i]=>Value[i];

public static A275839Inst Instance=new A275839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275840
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,2L,2L,2L,3L,4L,3L,3L,3L,2L,1L,1L,1L,0L,1L,2L,2L,2L,3L,4L,4L,4L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,8L,8L,8L,9L,10L,9L,9L,10L,10L,10L,10L,10L,10L,10L,10L,9L,9L,10L,10L,9L,9L,10L,10L,9L,9L,10L,10L,10L,10L,10L,10L,10L,10L,9L,9L,9L,8L,7L,7L,7L,6L,5L,5L,5L,4L,4L,4L,4L,4L,4L,4L,3L,3L,3L,2L,1L,1L,1L,0L,1L,2L,2L,2L,3L,4L,4L,4L,5L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275840Inst : IEnumerable<long>
{
public static readonly long[] Value=A275840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275840.Bytes);
public long this[int i]=>Value[i];

public static A275840Inst Instance=new A275840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275841
{
public static readonly long[] Value={ 0L,2L,12L,3L,16L,1L,72L,14L,11L,13L,90L,8L,70L,6L,7L,17L,84L,9L,58L,76L,77L,15L,78L,5L,480L,53L,36L,94L,95L,10L,47L,54L,74L,75L,576L,19L,474L,45L,52L,88L,89L,4L,33L,71L,92L,93L,552L,483L,358L,449L,26L,28L,21L,82L,29L,83L,62L,73L,501L,60L,431L,86L,43L,87L,528L,579L,206L,417L,493L,496L,485L,57L,203L,497L,492L,55L,38L,91L,494L,597L,48L,50L,294L,80L,288L,24L,25L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275841Inst : IEnumerable<long>
{
public static readonly long[] Value=A275841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275841.Bytes);
public long this[int i]=>Value[i];

public static A275841Inst Instance=new A275841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275842
{
public static readonly long[] Value={ 0L,5L,1L,3L,41L,23L,13L,14L,11L,17L,29L,8L,2L,9L,7L,21L,4L,15L,104L,35L,231L,52L,209L,285L,85L,86L,50L,127L,51L,54L,105L,431L,197L,42L,182L,172L,26L,177L,76L,125L,100L,225L,161L,62L,134L,37L,153L,30L,80L,183L,81L,341L,38L,25L,31L,75L,165L,71L,18L,119L,59L,269L,56L,141L,99L,137L,107L,111L,213L,95L,12L,43L,6L,57L,32L,33L,19L,20L,22L,129L,83L,87L,53L,55L,16L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275842Inst : IEnumerable<long>
{
public static readonly long[] Value=A275842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275842.Bytes);
public long this[int i]=>Value[i];

public static A275842Inst Instance=new A275842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275843
{
public static readonly long[] Value={ 0L,1L,3L,5L,9L,12L,23L,33L,53L,71L,75L,81L,119L,153L,252L,360L,361L,372L,492L,719L,873L,1493L,1511L,2183L,2231L,2279L,2879L,2889L,2913L,2961L,3033L,3675L,3681L,5039L,5913L,10332L,15195L,15201L,18081L,18795L,18801L,20160L,20161L,20163L,20165L,20213L,20235L,20520L,20521L,21653L,23835L,25253L,25271L,26693L,26711L,27431L,30732L,40319L,46233L,82133L,82151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275843Inst : IEnumerable<long>
{
public static readonly long[] Value=A275843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275843.Bytes);
public long this[int i]=>Value[i];

public static A275843Inst Instance=new A275843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275876
{
public static readonly long[] Value={ 0L,-4L,-8L,-4L,16L,60L,136L,252L,416L,636L,920L,1276L,1712L,2236L,2856L,3580L,4416L,5372L,6456L,7676L,9040L,10556L,12232L,14076L,16096L,18300L,20696L,23292L,26096L,29116L,32360L,35836L,39552L,43516L,47736L,52220L,56976L,62012L,67336L,72956L,78880L,85116L,91672L,98556L,105776L,113340L,121256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275876Inst : IEnumerable<long>
{
public static readonly long[] Value=A275876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275876.Bytes);
public long this[int i]=>Value[i];

public static A275876Inst Instance=new A275876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275877
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,8L,6L,11L,7L,12L,15L,16L,10L,9L,17L,19L,13L,24L,25L,22L,14L,18L,31L,27L,20L,26L,33L,21L,34L,37L,38L,43L,35L,39L,36L,40L,23L,49L,41L,28L,52L,29L,47L,32L,53L,46L,44L,55L,30L,60L,54L,45L,61L,48L,50L,66L,51L,73L,57L,70L,71L,76L,78L,83L,81L,77L,72L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275877Inst : IEnumerable<long>
{
public static readonly long[] Value=A275877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275877.Bytes);
public long this[int i]=>Value[i];

public static A275877Inst Instance=new A275877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275878
{
public static readonly long[] Value={ 7L,61L,331L,547L,1951L,2437L,3571L,4219L,7351L,8269L,9241L,10267L,13669L,23497L,25117L,55897L,60919L,74419L,89269L,92401L,102121L,112327L,115837L,126691L,145861L,170647L,202021L,231019L,241117L,246247L,251431L,267307L,283669L,329677L,347821L,360187L,372769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275878Inst : IEnumerable<long>
{
public static readonly long[] Value=A275878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275878.Bytes);
public long this[int i]=>Value[i];

public static A275878Inst Instance=new A275878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275879
{
public static readonly long[] Value={ 13L,97L,193L,409L,769L,2593L,4729L,6481L,12289L,15361L,55681L,331777L,417793L,737281L,786433L,2752513L,6684673L,8650753L,36175873L,69206017L,75079681L,155344897L,270532609L,435486721L,824717353L,860301577L,1380974593L,1845657601L,3221225473L,3255828481L,3281584129L,8531146753L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275879Inst : IEnumerable<long>
{
public static readonly long[] Value=A275879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275879.Bytes);
public long this[int i]=>Value[i];

public static A275879Inst Instance=new A275879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275880
{
public static readonly long[] Value={ 26L,244L,305L,338L,9755L,18205L,33076L,48775L,60707L,70673L,82690L,92410L,95990L,101651L,112102L,165380L,167690L,184820L,191980L,211178L,224204L,232373L,258322L,274730L,297743L,330760L,335380L,369640L,383960L,422356L,448408L,516644L,516934L,549460L,583444L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275880Inst : IEnumerable<long>
{
public static readonly long[] Value=A275880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275880.Bytes);
public long this[int i]=>Value[i];

public static A275880Inst Instance=new A275880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275881
{
public static readonly long[] Value={ 1105L,14365L,34765L,303535L,309485L,353365L,508255L,510605L,527945L,729305L,746405L,796717L,839185L,872695L,1010105L,1418345L,1488715L,1511015L,1625479L,1863845L,1992905L,2091233L,3028765L,3350545L,3745669L,4695605L,5061631L,6289897L,6391745L,6775877L,7816889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275881Inst : IEnumerable<long>
{
public static readonly long[] Value=A275881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275881.Bytes);
public long this[int i]=>Value[i];

public static A275881Inst Instance=new A275881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275882
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,3L,3L,4L,5L,7L,7L,11L,9L,12L,14L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275882Inst : IEnumerable<long>
{
public static readonly long[] Value=A275882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275882.Bytes);
public long this[int i]=>Value[i];

public static A275882Inst Instance=new A275882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275883
{
public static readonly long[] Value={ 1L,3L,4L,6L,6L,8L,10L,11L,13L,14L,16L,18L,16L,20L,19L,22L,21L,24L,26L,24L,27L,29L,30L,32L,35L,35L,38L,40L,37L,41L,43L,43L,43L,43L,47L,47L,47L,52L,53L,51L,54L,56L,58L,55L,60L,59L,59L,62L,64L,63L,67L,66L,68L,73L,74L,71L,74L,73L,77L,78L,75L,79L,80L,87L,83L,84L,86L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275883Inst : IEnumerable<long>
{
public static readonly long[] Value=A275883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275883.Bytes);
public long this[int i]=>Value[i];

public static A275883Inst Instance=new A275883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275884
{
public static readonly long[] Value={ 1L,2L,3L,6L,7L,8L,9L,12L,14L,16L,17L,18L,19L,22L,23L,24L,25L,28L,30L,32L,33L,35L,36L,37L,39L,41L,44L,45L,46L,47L,48L,51L,52L,53L,55L,57L,60L,61L,62L,63L,65L,66L,68L,70L,72L,73L,74L,76L,79L,81L,82L,83L,84L,87L,88L,89L,92L,93L,94L,96L,97L,98L,100L,103L,105L,106L,107L,109L,110L,112L,114L,115L,118L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275884Inst : IEnumerable<long>
{
public static readonly long[] Value=A275884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275884.Bytes);
public long this[int i]=>Value[i];

public static A275884Inst Instance=new A275884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275885
{
public static readonly long[] Value={ 2L,2L,1L,1L,2L,2L,1L,1L,1L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,2L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,1L,2L,1L,2L,2L,1L,1L,2L,2L,2L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,2L,1L,1L,2L,2L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,2L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275885Inst : IEnumerable<long>
{
public static readonly long[] Value=A275885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275885.Bytes);
public long this[int i]=>Value[i];

public static A275885Inst Instance=new A275885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275886
{
public static readonly long[] Value={ 3L,4L,1L,1L,4L,4L,1L,1L,2L,3L,1L,1L,5L,3L,1L,1L,4L,2L,1L,1L,3L,1L,1L,4L,3L,3L,3L,1L,1L,3L,2L,1L,2L,2L,2L,4L,2L,2L,4L,1L,1L,4L,1L,1L,3L,2L,3L,1L,1L,4L,3L,3L,4L,3L,3L,1L,1L,4L,4L,3L,1L,1L,5L,2L,2L,4L,1L,2L,2L,1L,3L,2L,1L,1L,4L,4L,1L,1L,4L,2L,3L,2L,1L,3L,2L,3L,2L,3L,3L,3L,2L,2L,2L,1L,3L,2L,3L,3L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275886Inst : IEnumerable<long>
{
public static readonly long[] Value=A275886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275886.Bytes);
public long this[int i]=>Value[i];

public static A275886Inst Instance=new A275886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275887
{
public static readonly long[] Value={ 2L,2L,2L,5L,2L,2L,1L,5L,1L,1L,2L,2L,1L,4L,1L,2L,2L,2L,1L,1L,1L,6L,6L,1L,1L,1L,2L,2L,3L,3L,1L,4L,1L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,3L,1L,1L,1L,3L,1L,3L,2L,1L,1L,3L,1L,2L,2L,5L,1L,7L,2L,3L,1L,2L,2L,3L,1L,4L,1L,1L,1L,1L,2L,2L,1L,4L,1L,1L,1L,4L,3L,5L,1L,1L,1L,4L,1L,2L,1L,1L,1L,1L,1L,2L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275887Inst : IEnumerable<long>
{
public static readonly long[] Value=A275887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275887.Bytes);
public long this[int i]=>Value[i];

public static A275887Inst Instance=new A275887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275888
{
public static readonly long[] Value={ 1L,1L,3L,1L,1L,1L,3L,2L,2L,1L,1L,1L,3L,1L,1L,1L,3L,2L,2L,1L,2L,1L,1L,2L,2L,3L,1L,1L,1L,1L,3L,1L,1L,2L,2L,3L,1L,1L,1L,2L,1L,2L,2L,2L,1L,1L,2L,3L,2L,1L,1L,1L,3L,1L,1L,3L,1L,1L,2L,1L,1L,2L,3L,2L,1L,1L,2L,1L,2L,2L,1L,3L,1L,2L,1L,2L,1L,1L,1L,3L,1L,3L,1L,2L,1L,1L,1L,2L,3L,2L,1L,1L,1L,3L,2L,2L,1L,1L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275888Inst : IEnumerable<long>
{
public static readonly long[] Value=A275888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275888.Bytes);
public long this[int i]=>Value[i];

public static A275888Inst Instance=new A275888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275889
{
public static readonly long[] Value={ 1L,5L,1L,2L,2L,5L,1L,5L,1L,2L,2L,3L,4L,2L,2L,1L,6L,1L,4L,2L,2L,1L,5L,3L,2L,2L,4L,2L,1L,2L,5L,1L,4L,1L,4L,4L,2L,1L,2L,4L,3L,2L,3L,1L,3L,3L,5L,1L,3L,1L,3L,5L,2L,1L,2L,5L,1L,2L,2L,4L,3L,4L,2L,2L,1L,5L,1L,4L,1L,4L,1L,5L,1L,4L,1L,4L,2L,1L,2L,5L,1L,5L,1L,4L,2L,2L,1L,6L,1L,3L,1L,3L,5L,2L,3L,1L,3L,2L,4L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275889Inst : IEnumerable<long>
{
public static readonly long[] Value=A275889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275889.Bytes);
public long this[int i]=>Value[i];

public static A275889Inst Instance=new A275889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275890
{
public static readonly long[] Value={ 1L,2L,3L,3L,3L,4L,5L,6L,7L,7L,7L,8L,8L,9L,9L,10L,11L,12L,13L,13L,13L,14L,15L,16L,17L,17L,17L,18L,18L,19L,19L,20L,21L,21L,22L,23L,24L,24L,25L,25L,26L,26L,26L,27L,28L,29L,30L,31L,31L,31L,32L,33L,34L,34L,35L,35L,36L,36L,36L,37L,38L,39L,40L,40L,41L,42L,42L,43L,43L,44L,44L,45L,46L,47L,47L,48L,48L,48L,49L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275890Inst : IEnumerable<long>
{
public static readonly long[] Value=A275890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275890.Bytes);
public long this[int i]=>Value[i];

public static A275890Inst Instance=new A275890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275891
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,2L,2L,2L,2L,3L,4L,4L,5L,5L,6L,6L,6L,6L,6L,7L,8L,8L,8L,8L,8L,9L,10L,10L,11L,11L,12L,12L,12L,13L,13L,13L,13L,14L,14L,15L,15L,16L,17L,17L,17L,17L,17L,17L,18L,19L,19L,19L,19L,20L,20L,21L,21L,22L,23L,23L,23L,23L,23L,24L,24L,24L,25L,25L,26L,26L,27L,27L,27L,27L,28L,28L,29L,30L,30L,31L,31L,31L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275891Inst : IEnumerable<long>
{
public static readonly long[] Value=A275891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275891.Bytes);
public long this[int i]=>Value[i];

public static A275891Inst Instance=new A275891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276036
{
public static readonly long[] Value={ 1L,4L,5L,6L,2L,3L,9L,12L,13L,14L,8L,15L,7L,18L,11L,20L,10L,26L,17L,25L,19L,27L,30L,21L,23L,29L,31L,22L,16L,41L,45L,32L,34L,24L,38L,36L,39L,33L,37L,46L,43L,28L,35L,42L,56L,55L,57L,50L,51L,62L,53L,60L,64L,71L,58L,69L,40L,74L,68L,54L,63L,80L,65L,82L,73L,47L,87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276036Inst : IEnumerable<long>
{
public static readonly long[] Value=A276036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276036.Bytes);
public long this[int i]=>Value[i];

public static A276036Inst Instance=new A276036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276037
{
public static readonly long[] Value={ 1L,5L,11L,15L,51L,55L,111L,115L,151L,155L,511L,515L,551L,555L,1111L,1115L,1151L,1155L,1511L,1515L,1551L,1555L,5111L,5115L,5151L,5155L,5511L,5515L,5551L,5555L,11111L,11115L,11151L,11155L,11511L,11515L,11551L,11555L,15111L,15115L,15151L,15155L,15511L,15515L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276037Inst : IEnumerable<long>
{
public static readonly long[] Value=A276037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276037.Bytes);
public long this[int i]=>Value[i];

public static A276037Inst Instance=new A276037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276038
{
public static readonly long[] Value={ 1L,6L,11L,16L,23L,32L,49L,61L,66L,94L,111L,116L,123L,132L,149L,161L,166L,194L,213L,229L,231L,236L,263L,292L,312L,321L,326L,334L,343L,362L,389L,398L,419L,433L,469L,491L,496L,611L,616L,623L,632L,649L,661L,666L,694L,839L,893L,914L,922L,938L,941L,946L,964L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276038Inst : IEnumerable<long>
{
public static readonly long[] Value=A276038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276038.Bytes);
public long this[int i]=>Value[i];

public static A276038Inst Instance=new A276038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276039
{
public static readonly long[] Value={ 1L,7L,11L,17L,71L,77L,111L,117L,171L,177L,711L,717L,771L,777L,1111L,1117L,1171L,1177L,1711L,1717L,1771L,1777L,7111L,7117L,7171L,7177L,7711L,7717L,7771L,7777L,11111L,11117L,11171L,11177L,11711L,11717L,11771L,11777L,17111L,17117L,17171L,17177L,17711L,17717L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276039Inst : IEnumerable<long>
{
public static readonly long[] Value=A276039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276039.Bytes);
public long this[int i]=>Value[i];

public static A276039Inst Instance=new A276039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276040
{
public static readonly long[] Value={ 1L,4L,6L,8L,10L,12L,14L,12L,18L,20L,22L,24L,26L,28L,30L,24L,34L,36L,38L,40L,42L,44L,46L,36L,50L,52L,45L,56L,58L,60L,62L,48L,66L,68L,70L,72L,74L,76L,78L,60L,82L,84L,86L,88L,90L,92L,94L,72L,98L,100L,102L,104L,106L,90L,110L,84L,114L,116L,118L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276040Inst : IEnumerable<long>
{
public static readonly long[] Value=A276040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276040.Bytes);
public long this[int i]=>Value[i];

public static A276040Inst Instance=new A276040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276041
{
public static readonly long[] Value={ 1L,6L,28L,104L,336L,992L,2752L,7296L,18688L,46592L,113664L,272384L,643072L,1499136L,3457024L,7897088L,17891328L,40239104L,89915392L,199753728L,441450496L,970981376L,2126512128L,4638900224L,10083106816L,21843935232L,47177531392L,101602820096L,218238025728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276041Inst : IEnumerable<long>
{
public static readonly long[] Value=A276041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276041.Bytes);
public long this[int i]=>Value[i];

public static A276041Inst Instance=new A276041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276042
{
public static readonly long[] Value={ 1L,4L,16L,62L,230L,812L,2728L,8752L,26944L,80000L,230144L,644096L,1759744L,4707328L,12359680L,31920128L,81231872L,204013568L,506331136L,1243217920L,3022913536L,7285243904L,17415274496L,41321234432L,97370767360L,227993976832L,530713673728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276042Inst : IEnumerable<long>
{
public static readonly long[] Value=A276042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276042.Bytes);
public long this[int i]=>Value[i];

public static A276042Inst Instance=new A276042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276043
{
public static readonly long[] Value={ 1L,2L,3L,5L,33L,6L,105L,14L,22L,33L,651L,24L,2667L,105L,66L,54L,57337L,88L,172011L,114L,210L,1302L,2752491L,120L,510L,5334L,472L,378L,199753347L,264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276043Inst : IEnumerable<long>
{
public static readonly long[] Value=A276043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276043.Bytes);
public long this[int i]=>Value[i];

public static A276043Inst Instance=new A276043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276044
{
public static readonly long[] Value={ 1L,3L,5L,7L,17L,13L,85L,31L,37L,65L,1285L,61L,4369L,193L,185L,143L,65537L,181L,327685L,241L,577L,3281L,5570645L,403L,1297L,12289L,1057L,1037L,286331153L,779L,1431655765L,899L,9509L,197633L,5629L,1333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276044Inst : IEnumerable<long>
{
public static readonly long[] Value=A276044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276044.Bytes);
public long this[int i]=>Value[i];

public static A276044Inst Instance=new A276044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276045
{
public static readonly long[] Value={ 7L,13L,17L,19L,43L,47L,59L,61L,71L,79L,101L,107L,109L,149L,151L,163L,167L,197L,223L,257L,263L,271L,311L,317L,347L,349L,353L,383L,389L,401L,421L,439L,449L,461L,479L,503L,521L,523L,557L,569L,599L,601L,613L,631L,673L,677L,691L,701L,811L,821L,827L,839L,853L,863L,881L,919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276045Inst : IEnumerable<long>
{
public static readonly long[] Value=A276045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276045.Bytes);
public long this[int i]=>Value[i];

public static A276045Inst Instance=new A276045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276046
{
public static readonly long[] Value={ 1L,2L,10L,16L,78L,97L,125L,138L,192L,242L,290L,373L,408L,467L,583L,892L,899L,1709L,1944L,2154L,3618L,5225L,8974L,9377L,12504L,20042L,49106L,63073L,92152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276046Inst : IEnumerable<long>
{
public static readonly long[] Value=A276046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276046.Bytes);
public long this[int i]=>Value[i];

public static A276046Inst Instance=new A276046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276047
{
public static readonly long[] Value={ 1L,2L,3L,7L,15L,22L,30L,35L,44L,73L,89L,91L,224L,533L,821L,1037L,1338L,1458L,1777L,2046L,2257L,2877L,3047L,3407L,13398L,42766L,55906L,61625L,66653L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276047Inst : IEnumerable<long>
{
public static readonly long[] Value=A276047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276047.Bytes);
public long this[int i]=>Value[i];

public static A276047Inst Instance=new A276047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276048
{
public static readonly BigInteger[] Value={ 0L,2L,9L,2L,625L,1L,117649L,2L,9L,1L,25937424601L,1L,23298085122481L,1L,1L,2L,BigInteger.Parse("48661191875666868481"),1L,BigInteger.Parse("104127350297911241532841"),1L,1L,1L,BigInteger.Parse("907846434775996175406740561329"),1L,625L,1L,9L,1L,BigInteger.Parse("88540901833145211536614766025207452637361"),1L };
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
public class A276048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276048Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276048.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276048Inst Instance=new A276048Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276049
{
public static readonly long[] Value={ 19L,29L,41L,71L,79L,89L,101L,103L,113L,139L,197L,199L,223L,271L,281L,307L,349L,353L,367L,379L,401L,439L,449L,461L,463L,491L,499L,521L,571L,607L,617L,619L,641L,643L,701L,727L,739L,761L,769L,811L,821L,859L,881L,911L,919L,929L,941L,953L,967L,991L,1039L,1061L,1063L,1087L,1181L,1217L,1231L,1279L,1289L,1301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276049Inst : IEnumerable<long>
{
public static readonly long[] Value=A276049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276049.Bytes);
public long this[int i]=>Value[i];

public static A276049Inst Instance=new A276049Inst();

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