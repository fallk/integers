using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A077579
{
public static readonly long[] Value={ 1L,3L,5L,8L,15L,16L,23L,48L,96L,155L,208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077579Inst : IEnumerable<long>
{
public static readonly long[] Value=A077579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077579.Bytes);
public long this[int i]=>Value[i];

public static A077579Inst Instance=new A077579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077580
{
public static readonly long[] Value={ 1L,3L,4L,7L,6L,17L,8L,15L,13L,23L,12L,35L,14L,31L,28L,31L,18L,53L,20L,49L,37L,47L,24L,71L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077580Inst : IEnumerable<long>
{
public static readonly long[] Value=A077580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077580.Bytes);
public long this[int i]=>Value[i];

public static A077580Inst Instance=new A077580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077581
{
public static readonly long[] Value={ 1L,1L,3L,1L,2L,4L,1L,3L,5L,7L,1L,2L,3L,4L,6L,1L,5L,7L,11L,13L,17L,1L,2L,3L,4L,5L,6L,8L,1L,3L,5L,7L,9L,11L,13L,15L,1L,2L,4L,5L,7L,8L,10L,11L,13L,1L,3L,7L,9L,11L,13L,17L,19L,21L,23L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,1L,5L,7L,11L,13L,17L,19L,23L,25L,29L,31L,35L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077581Inst : IEnumerable<long>
{
public static readonly long[] Value=A077581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077581.Bytes);
public long this[int i]=>Value[i];

public static A077581Inst Instance=new A077581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077582
{
public static readonly long[] Value={ 1L,4L,7L,16L,16L,54L,29L,64L,61L,124L,67L,216L,92L,228L,211L,256L,154L,486L,191L,500L,385L,532L,277L,864L,391L,732L,547L,914L,436L,1688L,497L,1024L,895L,1228L,890L,1944L,704L,1524L,1232L,2000L,862L,3090L,947L,2128L,1897L,2212L,1129L,3456L,1401L,3124L,2068L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077582Inst : IEnumerable<long>
{
public static readonly long[] Value=A077582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077582.Bytes);
public long this[int i]=>Value[i];

public static A077582Inst Instance=new A077582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077583
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,9L,4L,6L,8L,10L,5L,10L,15L,20L,25L,6L,8L,9L,10L,12L,14L,7L,14L,21L,28L,35L,42L,49L,8L,10L,12L,14L,16L,18L,20L,22L,9L,12L,15L,18L,21L,24L,27L,30L,33L,10L,12L,14L,15L,16L,18L,20L,22L,24L,25L,11L,22L,33L,44L,55L,66L,77L,88L,99L,110L,121L,12L,14L,15L,16L,18L,20L,21L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077583Inst : IEnumerable<long>
{
public static readonly long[] Value=A077583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077583.Bytes);
public long this[int i]=>Value[i];

public static A077583Inst Instance=new A077583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077584
{
public static readonly long[] Value={ 1L,4L,9L,10L,25L,14L,49L,22L,33L,25L,121L,28L,169L,36L,45L,46L,289L,44L,361L,52L,69L,60L,529L,58L,145L,72L,105L,76L,841L,69L,961L,94L,114L,96L,145L,88L,1369L,108L,138L,105L,1681L,99L,1849L,122L,140L,132L,2209L,118L,385L,132L,186L,146L,2809L,134L,253L,152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077584Inst : IEnumerable<long>
{
public static readonly long[] Value=A077584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077584.Bytes);
public long this[int i]=>Value[i];

public static A077584Inst Instance=new A077584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077585
{
public static readonly BigInteger[] Value={ 0L,1L,7L,127L,32767L,2147483647L,9223372036854775807L,BigInteger.Parse("170141183460469231731687303715884105727"),BigInteger.Parse("57896044618658097711785492504343953926634992332820282019728792003956564819967") };
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
public class A077585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077585Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077585.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077585Inst Instance=new A077585Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077586
{
public static readonly BigInteger[] Value={ 7L,127L,2147483647L,BigInteger.Parse("170141183460469231731687303715884105727") };
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
public class A077586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077586Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077586.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077586Inst Instance=new A077586Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077587
{
public static readonly long[] Value={ 1L,3L,9L,29L,98L,342L,1221L,4433L,16302L,60554L,226746L,854658L,3239044L,12332140L,47137005L,180780345L,695367510L,2681600130L,10364759790L,40142121030L,155748675420L,605274171060L,2355676013730L,9180275261274L,35819645937228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077587Inst : IEnumerable<long>
{
public static readonly long[] Value=A077587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077587.Bytes);
public long this[int i]=>Value[i];

public static A077587Inst Instance=new A077587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077588
{
public static readonly long[] Value={ 1L,2L,8L,20L,38L,62L,92L,128L,170L,218L,272L,332L,398L,470L,548L,632L,722L,818L,920L,1028L,1142L,1262L,1388L,1520L,1658L,1802L,1952L,2108L,2270L,2438L,2612L,2792L,2978L,3170L,3368L,3572L,3782L,3998L,4220L,4448L,4682L,4922L,5168L,5420L,5678L,5942L,6212L,6488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077588Inst : IEnumerable<long>
{
public static readonly long[] Value=A077588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077588.Bytes);
public long this[int i]=>Value[i];

public static A077588Inst Instance=new A077588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077589
{
public static readonly long[] Value={ 4L,3L,8L,2L,8L,2L,9L,3L,6L,7L,2L,7L,0L,3L,2L,1L,1L,1L,6L,2L,6L,9L,7L,5L,1L,6L,3L,5L,5L,1L,2L,6L,4L,8L,2L,4L,2L,6L,7L,8L,9L,7L,3L,5L,1L,6L,4L,6L,3L,9L,4L,6L,0L,3L,6L,0L,9L,2L,2L,1L,2L,4L,0L,4L,9L,5L,7L,9L,1L,5L,3L,2L,2L,2L,2L,6L,9L,5L,6L,8L,7L,6L,6L,9L,1L,7L,2L,1L,4L,0L,5L,3L,8L,2L,0L,4L,0L,7L,5L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077589Inst : IEnumerable<long>
{
public static readonly long[] Value=A077589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077589.Bytes);
public long this[int i]=>Value[i];

public static A077589Inst Instance=new A077589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077590
{
public static readonly long[] Value={ 3L,6L,0L,5L,9L,2L,4L,7L,1L,8L,7L,1L,3L,8L,5L,4L,8L,5L,9L,5L,2L,9L,4L,0L,5L,2L,6L,9L,0L,6L,0L,0L,0L,6L,5L,3L,8L,2L,6L,5L,7L,7L,0L,3L,0L,7L,8L,6L,0L,2L,7L,0L,0L,4L,7L,4L,1L,4L,5L,1L,2L,9L,8L,3L,8L,0L,4L,6L,0L,1L,9L,5L,2L,1L,1L,5L,0L,7L,7L,3L,0L,5L,3L,2L,9L,2L,2L,7L,5L,4L,1L,4L,0L,0L,2L,5L,6L,8L,6L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077590Inst : IEnumerable<long>
{
public static readonly long[] Value=A077590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077590.Bytes);
public long this[int i]=>Value[i];

public static A077590Inst Instance=new A077590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077591
{
public static readonly long[] Value={ 1L,2L,18L,50L,98L,162L,242L,338L,450L,578L,722L,882L,1058L,1250L,1458L,1682L,1922L,2178L,2450L,2738L,3042L,3362L,3698L,4050L,4418L,4802L,5202L,5618L,6050L,6498L,6962L,7442L,7938L,8450L,8978L,9522L,10082L,10658L,11250L,11858L,12482L,13122L,13778L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077591Inst : IEnumerable<long>
{
public static readonly long[] Value=A077591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077591.Bytes);
public long this[int i]=>Value[i];

public static A077591Inst Instance=new A077591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077592
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,2L,1L,1L,4L,3L,3L,1L,1L,5L,4L,6L,2L,1L,1L,6L,5L,10L,3L,4L,1L,1L,7L,6L,15L,4L,9L,2L,1L,1L,8L,7L,21L,5L,16L,3L,4L,1L,1L,9L,8L,28L,6L,25L,4L,10L,3L,1L,1L,10L,9L,36L,7L,36L,5L,20L,6L,4L,1L,1L,11L,10L,45L,8L,49L,6L,35L,10L,9L,2L,1L,1L,12L,11L,55L,9L,64L,7L,56L,15L,16L,3L,6L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077592Inst : IEnumerable<long>
{
public static readonly long[] Value=A077592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077592.Bytes);
public long this[int i]=>Value[i];

public static A077592Inst Instance=new A077592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077593
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,0L,1L,2L,1L,0L,1L,3L,3L,1L,0L,1L,4L,5L,4L,1L,0L,1L,5L,7L,8L,5L,1L,0L,1L,6L,9L,13L,10L,6L,1L,0L,1L,7L,11L,19L,16L,14L,7L,1L,0L,1L,8L,13L,26L,23L,25L,16L,8L,1L,0L,1L,9L,15L,34L,31L,39L,28L,20L,9L,1L,0L,1L,10L,17L,43L,40L,56L,43L,38L,23L,10L,1L,0L,1L,11L,19L,53L,50L,76L,61L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077593Inst : IEnumerable<long>
{
public static readonly long[] Value=A077593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077593.Bytes);
public long this[int i]=>Value[i];

public static A077593Inst Instance=new A077593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077594
{
public static readonly long[] Value={ 196L,89L,49L,18L,9L,14L,7L,6L,3L,4L,2L,1L,10000L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077594Inst : IEnumerable<long>
{
public static readonly long[] Value=A077594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077594.Bytes);
public long this[int i]=>Value[i];

public static A077594Inst Instance=new A077594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077595
{
public static readonly long[] Value={ 1L,4L,28L,96L,1328L,4672L,33472L,121856L,3597056L,13417472L,33655808L,127508480L,5829259264L,22308732928L,171393728512L,660468137984L,40831182635008L,22589996269568L,175323994652672L,681560447647744L,10614717931323392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077595Inst : IEnumerable<long>
{
public static readonly long[] Value=A077595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077595.Bytes);
public long this[int i]=>Value[i];

public static A077595Inst Instance=new A077595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077596
{
public static readonly long[] Value={ 1L,2L,4L,8L,15L,30L,57L,108L,206L,393L,752L,1439L,2772L,5334L,10327L,19967L,38808L,75319L,146844L,285862L,558723L,1090370L,2135551L,4176224L,8193490L,16050930L,31537017L,61872863L,121721157L,239115024L,470918888L,926141652L,1825708221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077596Inst : IEnumerable<long>
{
public static readonly long[] Value=A077596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077596.Bytes);
public long this[int i]=>Value[i];

public static A077596Inst Instance=new A077596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077597
{
public static readonly long[] Value={ 0L,2L,4L,7L,9L,13L,15L,19L,22L,26L,28L,34L,36L,40L,44L,49L,51L,57L,59L,65L,69L,73L,75L,83L,86L,90L,94L,100L,102L,110L,112L,118L,122L,126L,130L,139L,141L,145L,149L,157L,159L,167L,169L,175L,181L,185L,187L,197L,200L,206L,210L,216L,218L,226L,230L,238L,242L,246L,248L,260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077597Inst : IEnumerable<long>
{
public static readonly long[] Value=A077597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077597.Bytes);
public long this[int i]=>Value[i];

public static A077597Inst Instance=new A077597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077598
{
public static readonly long[] Value={ 0L,0L,2L,8L,15L,30L,43L,67L,90L,123L,149L,203L,237L,290L,343L,415L,464L,556L,613L,716L,800L,899L,972L,1126L,1218L,1342L,1458L,1616L,1716L,1916L,2026L,2215L,2365L,2540L,2690L,2959L,3098L,3300L,3485L,3762L,3919L,4221L,4388L,4667L,4921L,5179L,5364L,5762L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077598Inst : IEnumerable<long>
{
public static readonly long[] Value=A077598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077598.Bytes);
public long this[int i]=>Value[i];

public static A077598Inst Instance=new A077598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077599
{
public static readonly long[] Value={ 8L,9L,24L,45L,100L,117L,120L,125L,135L,171L,175L,180L,184L,224L,243L,248L,256L,261L,270L,304L,312L,324L,342L,343L,344L,360L,369L,405L,459L,468L,472L,475L,477L,486L,507L,513L,520L,531L,536L,578L,584L,603L,608L,625L,639L,640L,657L,664L,675L,704L,711L,720L,728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077599Inst : IEnumerable<long>
{
public static readonly long[] Value=A077599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077599.Bytes);
public long this[int i]=>Value[i];

public static A077599Inst Instance=new A077599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077600
{
public static readonly long[] Value={ 0L,1L,2L,3L,2L,3L,2L,5L,4L,3L,2L,5L,4L,3L,4L,5L,4L,5L,2L,5L,4L,3L,2L,7L,6L,5L,6L,5L,4L,5L,4L,7L,4L,5L,4L,7L,6L,5L,6L,7L,4L,5L,4L,5L,6L,5L,4L,7L,6L,7L,6L,5L,4L,7L,4L,5L,4L,5L,4L,7L,6L,5L,8L,7L,6L,5L,6L,9L,6L,5L,4L,9L,8L,5L,8L,9L,4L,5L,4L,7L,8L,7L,4L,7L,6L,7L,6L,7L,4L,9L,4L,7L,8L,5L,6L,7L,6L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077600Inst : IEnumerable<long>
{
public static readonly long[] Value=A077600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077600.Bytes);
public long this[int i]=>Value[i];

public static A077600Inst Instance=new A077600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077601
{
public static readonly long[] Value={ 2L,9L,8L,7L,4L,5L,8L,1L,3L,6L,6L,8L,7L,2L,2L,0L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077601Inst : IEnumerable<long>
{
public static readonly long[] Value=A077601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077601.Bytes);
public long this[int i]=>Value[i];

public static A077601Inst Instance=new A077601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077602
{
public static readonly long[] Value={ 1L,5L,3L,0L,1L,9L,1L,4L,1L,4L,0L,1L,6L,5L,4L,9L,1L,8L,7L,1L,5L,4L,3L,6L,2L,3L,6L,1L,4L,9L,2L,6L,3L,3L,0L,2L,0L,2L,5L,9L,5L,1L,2L,3L,7L,4L,1L,1L,1L,5L,7L,1L,0L,0L,7L,0L,7L,0L,6L,0L,1L,1L,1L,3L,9L,3L,1L,7L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077602Inst : IEnumerable<long>
{
public static readonly long[] Value=A077602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077602.Bytes);
public long this[int i]=>Value[i];

public static A077602Inst Instance=new A077602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077603
{
public static readonly long[] Value={ 2L,3L,3L,4L,3L,3L,3L,5L,4L,3L,3L,5L,3L,3L,3L,6L,3L,5L,3L,5L,3L,3L,3L,3L,4L,3L,5L,5L,3L,3L,3L,7L,3L,3L,3L,4L,3L,3L,3L,3L,3L,3L,3L,5L,5L,3L,3L,9L,4L,5L,3L,5L,3L,3L,3L,3L,3L,3L,3L,5L,3L,3L,5L,8L,3L,3L,3L,5L,3L,3L,3L,13L,3L,3L,5L,5L,3L,3L,3L,9L,6L,3L,3L,5L,3L,3L,3L,3L,3L,5L,3L,5L,3L,3L,3L,5L,3L,5L,5L,4L,3L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077603Inst : IEnumerable<long>
{
public static readonly long[] Value=A077603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077603.Bytes);
public long this[int i]=>Value[i];

public static A077603Inst Instance=new A077603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077604
{
public static readonly long[] Value={ 0L,1L,1L,4L,1L,1L,2L,1L,6L,1L,3L,10L,6L,148L,2L,3L,3L,2L,1L,4L,3L,1L,23L,1L,10L,4L,3L,2L,1L,1L,7L,2L,8L,1L,2L,7L,1L,17L,19L,5L,6L,1L,1L,1L,1L,2L,7L,1L,1L,1L,1L,17L,2L,4L,1L,1L,5L,40L,6L,6L,2L,14L,3L,2L,6L,1L,1L,1L,1L,3L,1L,100L,1L,7L,7L,4L,4L,1L,1L,2L,3L,2L,1L,2L,7L,1L,1L,4L,1L,3L,1L,5L,1L,1L,2L,1L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077604Inst : IEnumerable<long>
{
public static readonly long[] Value=A077604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077604.Bytes);
public long this[int i]=>Value[i];

public static A077604Inst Instance=new A077604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077605
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077605Inst : IEnumerable<long>
{
public static readonly long[] Value=A077605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077605.Bytes);
public long this[int i]=>Value[i];

public static A077605Inst Instance=new A077605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077606
{
public static readonly long[] Value={ 1L,-1L,0L,0L,1L,0L,0L,-1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077606Inst : IEnumerable<long>
{
public static readonly long[] Value=A077606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077606.Bytes);
public long this[int i]=>Value[i];

public static A077606Inst Instance=new A077606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077607
{
public static readonly BigInteger[] Value={ 1L,-2L,-2L,-8L,-44L,-296L,-2312L,-20384L,-199376L,-2138336L,-24936416L,-314142848L,-4252773824L,-61594847360L,-950757812864L,-15586971531776L,-270569513970944L,-4959071121374720L,-95721139472072192L,-1941212789888952320L,BigInteger.Parse("-41271304403571227648") };
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
public class A077607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077607Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077607.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077607Inst Instance=new A077607Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077608
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,1L,1L,2L,1L,3L,4L,3L,7L,7L,8L,14L,15L,21L,28L,33L,47L,58L,75L,103L,125L,167L,220L,275L,370L,474L,610L,806L,1028L,1347L,1752L,2253L,2954L,3812L,4944L,6451L,8329L,10841L,14077L,18226L,23720L,30745L,39903L,51857L,67214L,87313L,113340L,147017L,190974L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077608Inst : IEnumerable<long>
{
public static readonly long[] Value=A077608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077608.Bytes);
public long this[int i]=>Value[i];

public static A077608Inst Instance=new A077608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077609
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,1L,4L,1L,5L,1L,2L,3L,6L,1L,7L,1L,2L,4L,8L,1L,9L,1L,2L,5L,10L,1L,11L,1L,3L,4L,12L,1L,13L,1L,2L,7L,14L,1L,3L,5L,15L,1L,16L,1L,17L,1L,2L,9L,18L,1L,19L,1L,4L,5L,20L,1L,3L,7L,21L,1L,2L,11L,22L,1L,23L,1L,2L,3L,4L,6L,8L,12L,24L,1L,25L,1L,2L,13L,26L,1L,3L,9L,27L,1L,4L,7L,28L,1L,29L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077609Inst : IEnumerable<long>
{
public static readonly long[] Value=A077609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077609.Bytes);
public long this[int i]=>Value[i];

public static A077609Inst Instance=new A077609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077610
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,1L,4L,1L,5L,1L,2L,3L,6L,1L,7L,1L,8L,1L,9L,1L,2L,5L,10L,1L,11L,1L,3L,4L,12L,1L,13L,1L,2L,7L,14L,1L,3L,5L,15L,1L,16L,1L,17L,1L,2L,9L,18L,1L,19L,1L,4L,5L,20L,1L,3L,7L,21L,1L,2L,11L,22L,1L,23L,1L,3L,8L,24L,1L,25L,1L,2L,13L,26L,1L,27L,1L,4L,7L,28L,1L,29L,1L,2L,3L,5L,6L,10L,15L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077610Inst : IEnumerable<long>
{
public static readonly long[] Value=A077610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077610.Bytes);
public long this[int i]=>Value[i];

public static A077610Inst Instance=new A077610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077611
{
public static readonly BigInteger[] Value={ 0L,0L,4L,12L,144L,720L,8640L,60480L,806400L,7257600L,108864000L,1197504000L,20118067200L,261534873600L,4881984307200L,73229764608000L,1506440871936000L,25609494822912000L,576213633515520000L,10948059036794880000UL,BigInteger.Parse("267619220899430400000"),BigInteger.Parse("5620003638888038400000") };
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
public class A077611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077611Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077611.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077611Inst Instance=new A077611Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077612
{
public static readonly long[] Value={ 0L,0L,0L,12L,48L,720L,4320L,60480L,483840L,7257600L,72576000L,1197504000L,14370048000L,261534873600L,3661488230400L,73229764608000L,1171676233728000L,25609494822912000L,460970906812416000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077612Inst : IEnumerable<long>
{
public static readonly long[] Value=A077612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077612.Bytes);
public long this[int i]=>Value[i];

public static A077612Inst Instance=new A077612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077613
{
public static readonly long[] Value={ 0L,1L,4L,24L,144L,1080L,8640L,80640L,806400L,9072000L,108864000L,1437004800L,20118067200L,305124019200L,4881984307200L,83691159552000L,1506440871936000L,28810681675776000L,576213633515520000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077613Inst : IEnumerable<long>
{
public static readonly long[] Value=A077613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077613.Bytes);
public long this[int i]=>Value[i];

public static A077613Inst Instance=new A077613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077614
{
public static readonly long[] Value={ 1L,0L,1L,2L,0L,1L,1L,2L,0L,0L,0L,1L,1L,1L,1L,1L,1L,2L,0L,1L,0L,0L,1L,2L,1L,1L,0L,1L,0L,1L,3L,3L,0L,0L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,2L,1L,1L,1L,0L,2L,3L,2L,1L,1L,0L,0L,1L,0L,2L,2L,1L,1L,1L,0L,1L,0L,0L,2L,3L,0L,2L,1L,0L,0L,0L,1L,3L,1L,0L,1L,2L,1L,0L,1L,0L,1L,2L,0L,0L,0L,0L,2L,2L,1L,2L,2L,1L,0L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077614Inst : IEnumerable<long>
{
public static readonly long[] Value=A077614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077614.Bytes);
public long this[int i]=>Value[i];

public static A077614Inst Instance=new A077614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077615
{
public static readonly long[] Value={ 1L,4L,31L,255L,431L,432L,1727L,2700L,21599L,21600L,10800L,10799L,43200L,43199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077615Inst : IEnumerable<long>
{
public static readonly long[] Value=A077615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077615.Bytes);
public long this[int i]=>Value[i];

public static A077615Inst Instance=new A077615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077616
{
public static readonly long[] Value={ 1L,10L,63L,324L,1485L,6318L,25515L,99144L,373977L,1377810L,4979799L,17714700L,62178597L,215765046L,741360195L,2525407632L,8537599665L,28669116186L,95692860783L,317684800980L,1049522104701L,3451916556990L,11307641812443L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077616Inst : IEnumerable<long>
{
public static readonly long[] Value=A077616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077616.Bytes);
public long this[int i]=>Value[i];

public static A077616Inst Instance=new A077616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077617
{
public static readonly long[] Value={ 12L,16L,24L,40L,45L,48L,56L,84L,100L,105L,132L,136L,140L,165L,168L,189L,204L,210L,224L,228L,261L,264L,272L,297L,315L,330L,345L,357L,372L,378L,380L,405L,441L,444L,450L,464L,465L,468L,477L,496L,513L,520L,522L,525L,536L,544L,546L,561L,564L,567L,588L,608L,621L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077617Inst : IEnumerable<long>
{
public static readonly long[] Value=A077617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077617.Bytes);
public long this[int i]=>Value[i];

public static A077617Inst Instance=new A077617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077618
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,2L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,0L,2L,0L,0L,1L,7L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,2L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,0L,1L,6L,1L,0L,1L,2L,1L,0L,1L,1L,0L,0L,1L,3L,1L,0L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,0L,0L,1L,4L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077618Inst : IEnumerable<long>
{
public static readonly long[] Value=A077618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077618.Bytes);
public long this[int i]=>Value[i];

public static A077618Inst Instance=new A077618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077619
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,7L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,6L,1L,1L,2L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,4L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,5L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,4L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077619Inst : IEnumerable<long>
{
public static readonly long[] Value=A077619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077619.Bytes);
public long this[int i]=>Value[i];

public static A077619Inst Instance=new A077619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077620
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,11L,13L,14L,15L,17L,19L,21L,22L,23L,29L,31L,33L,34L,35L,37L,38L,39L,41L,42L,43L,46L,47L,53L,55L,57L,58L,59L,61L,62L,65L,67L,69L,71L,73L,74L,77L,79L,82L,83L,85L,86L,87L,89L,91L,93L,94L,95L,97L,101L,103L,105L,106L,107L,109L,110L,111L,113L,114L,115L,118L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077620Inst : IEnumerable<long>
{
public static readonly long[] Value=A077620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077620.Bytes);
public long this[int i]=>Value[i];

public static A077620Inst Instance=new A077620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077621
{
public static readonly long[] Value={ 6L,10L,26L,30L,51L,66L,70L,78L,102L,122L,130L,154L,165L,174L,177L,182L,190L,210L,222L,238L,246L,266L,273L,282L,285L,291L,310L,318L,330L,345L,357L,362L,366L,370L,390L,399L,406L,418L,426L,429L,438L,455L,462L,483L,510L,518L,530L,533L,534L,546L,555L,561L,570L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077621Inst : IEnumerable<long>
{
public static readonly long[] Value=A077621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077621.Bytes);
public long this[int i]=>Value[i];

public static A077621Inst Instance=new A077621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077622
{
public static readonly long[] Value={ 1L,2L,7L,27L,190L,1621L,17271L,200536L,2757881L,47108763L,843069901L,17797435824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077622Inst : IEnumerable<long>
{
public static readonly long[] Value=A077622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077622.Bytes);
public long this[int i]=>Value[i];

public static A077622Inst Instance=new A077622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077623
{
public static readonly long[] Value={ 1L,2L,4L,1L,5L,0L,6L,1L,5L,2L,4L,3L,3L,4L,2L,5L,1L,6L,0L,7L,1L,6L,2L,5L,3L,4L,4L,3L,5L,2L,6L,1L,7L,0L,8L,1L,7L,2L,6L,3L,5L,4L,4L,5L,3L,6L,2L,7L,1L,8L,0L,9L,1L,8L,2L,7L,3L,6L,4L,5L,5L,4L,6L,3L,7L,2L,8L,1L,9L,0L,10L,1L,9L,2L,8L,3L,7L,4L,6L,5L,5L,6L,4L,7L,3L,8L,2L,9L,1L,10L,0L,11L,1L,10L,2L,9L,3L,8L,4L,7L,5L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077623Inst : IEnumerable<long>
{
public static readonly long[] Value=A077623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077623.Bytes);
public long this[int i]=>Value[i];

public static A077623Inst Instance=new A077623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077624
{
public static readonly long[] Value={ 2L,4L,3L,8L,10L,16L,22L,32L,44L,64L,90L,128L,180L,256L,362L,512L,724L,1024L,1448L,2048L,2896L,4096L,5792L,8192L,11584L,16384L,23170L,32768L,46340L,65536L,92680L,131072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077624Inst : IEnumerable<long>
{
public static readonly long[] Value=A077624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077624.Bytes);
public long this[int i]=>Value[i];

public static A077624Inst Instance=new A077624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077625
{
public static readonly long[] Value={ 1L,2L,4L,6L,10L,14L,22L,30L,44L,62L,90L,126L,180L,254L,362L,510L,724L,1022L,1448L,2046L,2896L,4094L,5792L,8190L,11584L,16382L,23170L,32766L,46340L,65534L,92680L,131070L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077625Inst : IEnumerable<long>
{
public static readonly long[] Value=A077625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077625.Bytes);
public long this[int i]=>Value[i];

public static A077625Inst Instance=new A077625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077626
{
public static readonly long[] Value={ 2L,6L,10L,18L,30L,54L,92L,162L,280L,486L,840L,1458L,2524L,4374L,7574L,13122L,22726L,39366L,68182L,118098L,204550L,354294L,613654L,1062882L,1840964L,3188646L,5522896L,9565938L,16568690L,28697814L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077626Inst : IEnumerable<long>
{
public static readonly long[] Value=A077626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077626.Bytes);
public long this[int i]=>Value[i];

public static A077626Inst Instance=new A077626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077627
{
public static readonly long[] Value={ 2L,4L,10L,16L,30L,52L,92L,160L,280L,484L,840L,1456L,2524L,4372L,7574L,13120L,22726L,39364L,68182L,118096L,204550L,354292L,613654L,1062880L,1840964L,3188644L,5522896L,9565936L,16568690L,28697812L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077627Inst : IEnumerable<long>
{
public static readonly long[] Value=A077627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077627.Bytes);
public long this[int i]=>Value[i];

public static A077627Inst Instance=new A077627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077628
{
public static readonly long[] Value={ 3L,4L,3L,8L,14L,16L,42L,32L,82L,64L,270L,128L,518L,256L,642L,512L,2126L,1024L,7098L,2048L,7502L,4096L,14550L,8192L,19810L,16384L,108802L,32768L,101154L,65536L,299166L,131072L,360298L,262144L,891666L,524288L,2128896L,1048576L,8352642L,2097152L,4466878L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077628Inst : IEnumerable<long>
{
public static readonly long[] Value=A077628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077628.Bytes);
public long this[int i]=>Value[i];

public static A077628Inst Instance=new A077628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077629
{
public static readonly long[] Value={ 0L,3L,7L,7L,25L,15L,63L,31L,125L,63L,187L,127L,1081L,255L,1091L,511L,1247L,1023L,11217L,2047L,11999L,4095L,20259L,8191L,66077L,16383L,88609L,32767L,55491L,65535L,284231L,131071L,413199L,262143L,585102L,524287L,3351311L,1048575L,3462843L,2097151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077629Inst : IEnumerable<long>
{
public static readonly long[] Value=A077629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077629.Bytes);
public long this[int i]=>Value[i];

public static A077629Inst Instance=new A077629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077630
{
public static readonly long[] Value={ 2L,6L,18L,18L,86L,54L,344L,162L,650L,486L,3246L,1458L,11542L,4374L,19196L,13122L,83672L,39366L,434242L,118098L,248278L,354294L,5669112L,1062882L,10522426L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077630Inst : IEnumerable<long>
{
public static readonly long[] Value=A077630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077630.Bytes);
public long this[int i]=>Value[i];

public static A077630Inst Instance=new A077630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077631
{
public static readonly long[] Value={ 2L,5L,10L,17L,56L,53L,160L,161L,346L,485L,1850L,1457L,3764L,4373L,13468L,13121L,43572L,39365L,192642L,118097L,226348L,354293L,2646006L,1062881L,1871694L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077631Inst : IEnumerable<long>
{
public static readonly long[] Value=A077631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077631.Bytes);
public long this[int i]=>Value[i];

public static A077631Inst Instance=new A077631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077632
{
public static readonly BigInteger[] Value={ 2L,4L,3L,8L,10L,16L,66L,32L,220L,64L,235620L,128L,360360L,256L,2508660L,512L,16290726273360L,1024L,BigInteger.Parse("23508390120198798054240"),2048L,BigInteger.Parse("465977246353354335600"),4096L,BigInteger.Parse("3026207803243202829468977760"),8192L };
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
public class A077632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077632Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077632.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077632Inst Instance=new A077632Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077633
{
public static readonly BigInteger[] Value={ 1L,2L,4L,6L,30L,14L,462L,30L,924L,62L,360L,126L,88623545610600L,254L,5364840L,510L,214057116L,1022L,BigInteger.Parse("473045752778491241949600"),2046L,BigInteger.Parse("3968969477588889464597306400"),4094L,BigInteger.Parse("16579321550270765937400453704000") };
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
public class A077633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077633Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077633.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077633Inst Instance=new A077633Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077634
{
public static readonly BigInteger[] Value={ 2L,6L,30L,18L,90L,54L,106260L,162L,26040L,486L,341725784400L,1458L,BigInteger.Parse("6564164506066423389173040"),4374L,177815552218920L,13122L,BigInteger.Parse("2998833665484118393000638135815684490471025925316000"),39366L };
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
public class A077634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077634Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077634.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077634Inst Instance=new A077634Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077635
{
public static readonly BigInteger[] Value={ 2L,4L,10L,16L,210L,52L,10764L,160L,840L,484L,78225840L,1456L,5729631692400L,4372L,BigInteger.Parse("932723933480442148565520"),13120L,BigInteger.Parse("202096081896183783466278120"),39364L,BigInteger.Parse("1505075187143521116689096930825555405884185492185368021027531191578186233461600") };
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
public class A077635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077635Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077635.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077635Inst Instance=new A077635Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077636
{
public static readonly long[] Value={ 0L,1L,2L,2L,4L,2L,2L,2L,4L,8L,18L,14L,36L,38L,232L,268L,110L,280L,4348L,3244L,32684L,148184L,207616L,9988L,1946132L,2154482L,13319736L,8971624L,12345748L,69705504L,159413696L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077636Inst : IEnumerable<long>
{
public static readonly long[] Value=A077636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077636.Bytes);
public long this[int i]=>Value[i];

public static A077636Inst Instance=new A077636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077637
{
public static readonly long[] Value={ 1L,2L,4L,6L,14L,40L,56L,100L,332L,1200L,1696L,7000L,30514L,146344L,327236L,566792L,3052270L,16994324L,24033604L,146190716L,936077324L,6138269514L,42081855636L,111338124722L,810553782854L,6225981742592L,48626471887292L,68768216033362L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077637Inst : IEnumerable<long>
{
public static readonly long[] Value=A077637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077637.Bytes);
public long this[int i]=>Value[i];

public static A077637Inst Instance=new A077637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077638
{
public static readonly long[] Value={ 1L,2L,6L,8L,18L,42L,57L,105L,372L,1344L,1800L,7291L,32524L,150567L,342906L,738854L,3298239L,20772345L,36965663L,184510241L,1433356755L,7840220998L,56906577387L,113611483212L,843530932394L,6257315565011L,60692272232438L,70311381976766L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077638Inst : IEnumerable<long>
{
public static readonly long[] Value=A077638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077638.Bytes);
public long this[int i]=>Value[i];

public static A077638Inst Instance=new A077638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077639
{
public static readonly BigInteger[] Value={ 1L,2L,4L,6L,14L,40L,56L,100L,2988L,13200L,805600L,1323000L,1744790520L,112326337200L,BigInteger.Parse("10154793943770044128560"),BigInteger.Parse("26773964343922343708160"),185027354760601080L,BigInteger.Parse("1418008957437634586640") };
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
public class A077639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077639Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077639.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077639Inst Instance=new A077639Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077640
{
public static readonly long[] Value={ 217070L,671346L,826824L,1092747L,1092748L,1427370L,2097048L,2779370L,3112819L,3306444L,3597723L,3994820L,4063774L,4442874L,4630544L,4842474L,5436375L,5479619L,5610644L,5634122L,6315019L,6474220L,6626319L,6677864L,7128471L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077640Inst : IEnumerable<long>
{
public static readonly long[] Value=A077640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077640.Bytes);
public long this[int i]=>Value[i];

public static A077640Inst Instance=new A077640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077641
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,4L,4L,5L,6L,7L,7L,8L,8L,8L,8L,9L,10L,11L,12L,13L,14L,15L,14L,15L,15L,16L,16L,17L,18L,19L,19L,19L,20L,21L,21L,22L,23L,23L,23L,24L,24L,25L,25L,26L,27L,28L,28L,29L,30L,30L,31L,32L,33L,34L,35L,36L,37L,38L,37L,38L,38L,39L,38L,39L,40L,41L,41L,41L,42L,43L,43L,44L,45L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077641Inst : IEnumerable<long>
{
public static readonly long[] Value=A077641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077641.Bytes);
public long this[int i]=>Value[i];

public static A077641Inst Instance=new A077641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077642
{
public static readonly long[] Value={ 1L,7L,61L,607L,6077L,60787L,607951L,6079284L,60792732L,607927092L,6079270913L,60792710227L,607927101577L,6079271018873L,60792710185938L,607927101853650L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077642Inst : IEnumerable<long>
{
public static readonly long[] Value=A077642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077642.Bytes);
public long this[int i]=>Value[i];

public static A077642Inst Instance=new A077642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077643
{
public static readonly long[] Value={ 1L,2L,3L,5L,9L,19L,39L,79L,157L,310L,621L,1246L,2491L,4980L,9958L,19924L,39844L,79672L,159365L,318736L,637457L,1274916L,2549816L,5099651L,10199363L,20398663L,40797299L,81594571L,163189087L,326378438L,652756861L,1305513511L,2611026987L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077643Inst : IEnumerable<long>
{
public static readonly long[] Value=A077643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077643.Bytes);
public long this[int i]=>Value[i];

public static A077643Inst Instance=new A077643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077644
{
public static readonly long[] Value={ 1L,2L,9L,32L,107L,347L,1108L,3515L,11132L,35219L,111391L,352269L,1113996L,3522791L,11140072L,35228031L,111400846L,352280442L,1114008610L,3522804578L,11140086260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077644Inst : IEnumerable<long>
{
public static readonly long[] Value=A077644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077644.Bytes);
public long this[int i]=>Value[i];

public static A077644Inst Instance=new A077644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077645
{
public static readonly BigInteger[] Value={ 17L,1043L,75067L,5660269L,448660141L,37096005486L,3165774592333L,276006465392920L,24460302301867259L,2196082920489474703L,BigInteger.Parse("199246255311162951776"),BigInteger.Parse("18234121474806961230363") };
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
public class A077645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077645Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077645.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077645Inst Instance=new A077645Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077646
{
public static readonly long[] Value={ 45L,63L,75L,90L,99L,117L,120L,126L,147L,150L,153L,168L,171L,198L,207L,216L,234L,243L,261L,264L,279L,280L,294L,306L,312L,333L,342L,363L,369L,387L,405L,408L,414L,420L,423L,440L,456L,477L,486L,507L,520L,522L,531L,540L,549L,552L,558L,603L,616L,639L,657L,660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077646Inst : IEnumerable<long>
{
public static readonly long[] Value=A077646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077646.Bytes);
public long this[int i]=>Value[i];

public static A077646Inst Instance=new A077646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077647
{
public static readonly long[] Value={ 1092747L,7216618L,8870024L,8870025L,14379271L,22635347L,24816974L,25047846L,33678771L,33908368L,33908369L,34394371L,34682346L,37923938L,49250144L,49250145L,53379270L,69147868L,69147869L,70918820L,70918821L,71927247L,72913022L,83605071L,85972019L,90571646L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077647Inst : IEnumerable<long>
{
public static readonly long[] Value=A077647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077647.Bytes);
public long this[int i]=>Value[i];

public static A077647Inst Instance=new A077647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077648
{
public static readonly long[] Value={ 2L,3L,5L,7L,1L,1L,1L,1L,2L,2L,3L,3L,4L,4L,4L,5L,5L,6L,6L,7L,7L,7L,8L,8L,9L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077648Inst : IEnumerable<long>
{
public static readonly long[] Value=A077648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077648.Bytes);
public long this[int i]=>Value[i];

public static A077648Inst Instance=new A077648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077649
{
public static readonly long[] Value={ 4L,6L,8L,9L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077649Inst : IEnumerable<long>
{
public static readonly long[] Value=A077649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077649.Bytes);
public long this[int i]=>Value[i];

public static A077649Inst Instance=new A077649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077650
{
public static readonly long[] Value={ 1L,3L,4L,7L,6L,1L,8L,1L,1L,1L,1L,2L,1L,2L,2L,3L,1L,3L,2L,4L,3L,3L,2L,6L,3L,4L,4L,5L,3L,7L,3L,6L,4L,5L,4L,9L,3L,6L,5L,9L,4L,9L,4L,8L,7L,7L,4L,1L,5L,9L,7L,9L,5L,1L,7L,1L,8L,9L,6L,1L,6L,9L,1L,1L,8L,1L,6L,1L,9L,1L,7L,1L,7L,1L,1L,1L,9L,1L,8L,1L,1L,1L,8L,2L,1L,1L,1L,1L,9L,2L,1L,1L,1L,1L,1L,2L,9L,1L,1L,2L,1L,2L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077650Inst : IEnumerable<long>
{
public static readonly long[] Value=A077650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077650.Bytes);
public long this[int i]=>Value[i];

public static A077650Inst Instance=new A077650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077651
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,2L,6L,4L,6L,4L,1L,4L,1L,6L,8L,8L,1L,6L,1L,8L,1L,1L,2L,8L,2L,1L,1L,1L,2L,8L,3L,1L,2L,1L,2L,1L,3L,1L,2L,1L,4L,1L,4L,2L,2L,2L,4L,1L,4L,2L,3L,2L,5L,1L,4L,2L,3L,2L,5L,1L,6L,3L,3L,3L,4L,2L,6L,3L,4L,2L,7L,2L,7L,3L,4L,3L,6L,2L,7L,3L,5L,4L,8L,2L,6L,4L,5L,4L,8L,2L,7L,4L,6L,4L,7L,3L,9L,4L,6L,4L,1L,3L,1L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077651Inst : IEnumerable<long>
{
public static readonly long[] Value=A077651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077651.Bytes);
public long this[int i]=>Value[i];

public static A077651Inst Instance=new A077651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077652
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,101L,131L,151L,181L,191L,313L,353L,373L,383L,727L,757L,787L,797L,919L,929L,1021L,1031L,1051L,1061L,1091L,1151L,1171L,1181L,1201L,1231L,1291L,1301L,1321L,1361L,1381L,1451L,1471L,1481L,1511L,1531L,1571L,1601L,1621L,1721L,1741L,1801L,1811L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077652Inst : IEnumerable<long>
{
public static readonly long[] Value=A077652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077652.Bytes);
public long this[int i]=>Value[i];

public static A077652Inst Instance=new A077652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077653
{
public static readonly long[] Value={ 1L,2L,2L,1L,3L,0L,4L,1L,3L,2L,2L,3L,1L,4L,0L,5L,1L,4L,2L,3L,3L,2L,4L,1L,5L,0L,6L,1L,5L,2L,4L,3L,3L,4L,2L,5L,1L,6L,0L,7L,1L,6L,2L,5L,3L,4L,4L,3L,5L,2L,6L,1L,7L,0L,8L,1L,7L,2L,6L,3L,5L,4L,4L,5L,3L,6L,2L,7L,1L,8L,0L,9L,1L,8L,2L,7L,3L,6L,4L,5L,5L,4L,6L,3L,7L,2L,8L,1L,9L,0L,10L,1L,9L,2L,8L,3L,7L,4L,6L,5L,5L,6L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077653Inst : IEnumerable<long>
{
public static readonly long[] Value=A077653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077653.Bytes);
public long this[int i]=>Value[i];

public static A077653Inst Instance=new A077653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077654
{
public static readonly long[] Value={ 4L,10L,12L,16L,22L,24L,25L,27L,28L,32L,34L,38L,40L,42L,45L,46L,49L,52L,55L,57L,58L,60L,62L,64L,66L,70L,72L,76L,77L,80L,82L,84L,85L,87L,88L,91L,92L,93L,94L,100L,102L,104L,106L,108L,110L,112L,115L,117L,118L,121L,122L,123L,124L,126L,129L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077654Inst : IEnumerable<long>
{
public static readonly long[] Value=A077654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077654.Bytes);
public long this[int i]=>Value[i];

public static A077654Inst Instance=new A077654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077655
{
public static readonly long[] Value={ 0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,2L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,1L,0L,0L,0L,0L,0L,0L,2L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077655Inst : IEnumerable<long>
{
public static readonly long[] Value=A077655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077655.Bytes);
public long this[int i]=>Value[i];

public static A077655Inst Instance=new A077655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077656
{
public static readonly long[] Value={ 1L,3L,4L,5L,6L,7L,8L,10L,11L,12L,13L,15L,16L,17L,18L,19L,20L,22L,23L,24L,26L,28L,29L,30L,31L,32L,35L,36L,37L,39L,40L,41L,42L,43L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,76L,77L,78L,79L,80L,81L,82L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077656Inst : IEnumerable<long>
{
public static readonly long[] Value=A077656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077656.Bytes);
public long this[int i]=>Value[i];

public static A077656Inst Instance=new A077656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077657
{
public static readonly long[] Value={ 1L,2L,33L,603L,602L,2522L,211673L,3405123L,3405122L,49799889L,202536181L,3195380868L,5208143601L,85843948321L,97524222465L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077657Inst : IEnumerable<long>
{
public static readonly long[] Value=A077657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077657.Bytes);
public long this[int i]=>Value[i];

public static A077657Inst Instance=new A077657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077658
{
public static readonly long[] Value={ 4L,55L,55L,91L,407L,493L,493L,893L,1189L,1189L,1643L,1681L,1681L,7597L,7597L,7597L,7597L,7597L,7597L,7597L,7979L,7979L,9167L,9167L,11227L,11227L,11227L,28757L,28757L,28757L,28757L,28757L,28757L,28757L,28757L,36349L,36349L,36349L,39917L,39917L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077658Inst : IEnumerable<long>
{
public static readonly long[] Value=A077658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077658.Bytes);
public long this[int i]=>Value[i];

public static A077658Inst Instance=new A077658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077659
{
public static readonly long[] Value={ 2L,2L,4L,2L,2L,4L,2L,4L,2L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077659Inst : IEnumerable<long>
{
public static readonly long[] Value=A077659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077659.Bytes);
public long this[int i]=>Value[i];

public static A077659Inst Instance=new A077659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077660
{
public static readonly long[] Value={ 1L,6L,18L,28L,75L,59L,196L,120L,189L,176L,726L,243L,1183L,356L,450L,496L,2601L,554L,3610L,717L,933L,908L,6348L,990L,2125L,1280L,1782L,1447L,12615L,1492L,15376L,2016L,2432L,2216L,3120L,2241L,26011L,2780L,3451L,2901L,35301L,2967L,40678L,3672L,4148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077660Inst : IEnumerable<long>
{
public static readonly long[] Value=A077660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077660.Bytes);
public long this[int i]=>Value[i];

public static A077660Inst Instance=new A077660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077661
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,9L,2L,4L,6L,8L,5L,10L,15L,20L,25L,2L,3L,4L,6L,8L,9L,7L,14L,21L,28L,35L,42L,49L,2L,4L,6L,8L,10L,12L,14L,16L,3L,6L,9L,12L,15L,18L,21L,24L,27L,2L,4L,5L,6L,8L,10L,12L,14L,15L,16L,11L,22L,33L,44L,55L,66L,77L,88L,99L,110L,121L,2L,3L,4L,6L,8L,9L,10L,12L,14L,15L,16L,18L,13L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077661Inst : IEnumerable<long>
{
public static readonly long[] Value=A077661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077661.Bytes);
public long this[int i]=>Value[i];

public static A077661Inst Instance=new A077661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077662
{
public static readonly long[] Value={ 1L,4L,9L,8L,25L,9L,49L,16L,27L,16L,121L,18L,169L,24L,33L,32L,289L,27L,361L,34L,49L,40L,529L,36L,125L,48L,81L,49L,841L,40L,961L,64L,84L,64L,112L,54L,1369L,72L,102L,66L,1681L,58L,1849L,80L,96L,88L,2209L,72L,343L,84L,136L,96L,2809L,81L,200L,98L,153L,112L,3481L,82L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077662Inst : IEnumerable<long>
{
public static readonly long[] Value=A077662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077662.Bytes);
public long this[int i]=>Value[i];

public static A077662Inst Instance=new A077662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077663
{
public static readonly long[] Value={ 1L,6L,18L,20L,75L,32L,196L,72L,135L,92L,726L,117L,1183L,184L,258L,272L,2601L,257L,3610L,351L,541L,464L,6348L,450L,1625L,652L,1134L,712L,12615L,632L,15376L,1056L,1427L,1124L,2007L,999L,26011L,1408L,2032L,1367L,35301L,1261L,40678L,1816L,2219L,2072L,53016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077663Inst : IEnumerable<long>
{
public static readonly long[] Value=A077663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077663.Bytes);
public long this[int i]=>Value[i];

public static A077663Inst Instance=new A077663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077664
{
public static readonly long[] Value={ 2L,3L,5L,4L,5L,7L,5L,7L,9L,11L,6L,7L,8L,9L,11L,7L,11L,13L,17L,19L,23L,8L,9L,10L,11L,12L,13L,15L,9L,11L,13L,15L,17L,19L,21L,23L,10L,11L,13L,14L,16L,17L,19L,20L,22L,11L,13L,17L,19L,21L,23L,27L,29L,31L,33L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,23L,13L,17L,19L,23L,25L,29L,31L,35L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077664Inst : IEnumerable<long>
{
public static readonly long[] Value=A077664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077664.Bytes);
public long this[int i]=>Value[i];

public static A077664Inst Instance=new A077664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077665
{
public static readonly long[] Value={ 2L,5L,7L,11L,11L,23L,15L,23L,22L,33L,23L,47L,27L,45L,43L,47L,35L,71L,39L,69L,58L,69L,47L,95L,56L,81L,67L,93L,59L,139L,63L,95L,86L,105L,86L,143L,75L,117L,101L,139L,83L,187L,87L,139L,128L,141L,95L,191L,106L,173L,131L,163L,107L,215L,129L,185L,146L,177L,119L,283L,123L,189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077665Inst : IEnumerable<long>
{
public static readonly long[] Value=A077665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077665.Bytes);
public long this[int i]=>Value[i];

public static A077665Inst Instance=new A077665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077666
{
public static readonly long[] Value={ 2L,8L,16L,32L,41L,90L,78L,128L,142L,224L,188L,360L,261L,424L,436L,512L,443L,810L,552L,900L,826L,1016L,806L,1440L,1016L,1408L,1276L,1698L,1277L,2588L,1458L,2048L,1984L,2384L,2115L,3240L,2073L,2968L,2753L,3600L,2543L,4854L,2796L,4064L,3922L,4328L,3338L,5760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077666Inst : IEnumerable<long>
{
public static readonly long[] Value=A077666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077666.Bytes);
public long this[int i]=>Value[i];

public static A077666Inst Instance=new A077666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077667
{
public static readonly long[] Value={ 6L,10L,14L,18L,4L,8L,9L,10L,14L,15L,6L,10L,12L,14L,18L,20L,22L,26L,6L,12L,15L,21L,24L,30L,33L,39L,42L,4L,6L,8L,12L,14L,15L,16L,18L,22L,24L,8L,9L,10L,14L,15L,16L,18L,20L,21L,22L,26L,27L,4L,6L,8L,10L,12L,16L,18L,20L,21L,22L,24L,26L,30L,32L,6L,9L,10L,12L,18L,20L,21L,24L,25L,27L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077667Inst : IEnumerable<long>
{
public static readonly long[] Value=A077667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077667.Bytes);
public long this[int i]=>Value[i];

public static A077667Inst Instance=new A077667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077668
{
public static readonly long[] Value={ 18L,15L,26L,42L,24L,27L,32L,40L,42L,34L,44L,57L,48L,46L,160L,56L,96L,60L,51L,76L,93L,72L,126L,66L,80L,111L,78L,69L,92L,110L,96L,86L,406L,92L,147L,108L,92L,225L,110L,165L,120L,96L,128L,161L,142L,273L,105L,140L,201L,118L,124L,152L,174L,156L,374L,123L,148L,261L,168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077668Inst : IEnumerable<long>
{
public static readonly long[] Value=A077668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077668.Bytes);
public long this[int i]=>Value[i];

public static A077668Inst Instance=new A077668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077669
{
public static readonly long[] Value={ 6L,4L,8L,6L,10L,12L,6L,12L,15L,21L,4L,6L,8L,12L,14L,8L,9L,10L,14L,15L,16L,4L,6L,8L,10L,12L,16L,18L,6L,9L,10L,12L,18L,20L,21L,24L,6L,10L,12L,14L,18L,20L,22L,24L,26L,4L,8L,10L,12L,14L,15L,16L,20L,21L,22L,6L,8L,12L,14L,15L,16L,18L,22L,24L,25L,26L,6L,9L,12L,14L,15L,18L,24L,27L,28L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077669Inst : IEnumerable<long>
{
public static readonly long[] Value=A077669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077669.Bytes);
public long this[int i]=>Value[i];

public static A077669Inst Instance=new A077669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077670
{
public static readonly long[] Value={ 6L,8L,12L,21L,14L,16L,18L,24L,26L,22L,26L,35L,30L,32L,95L,36L,63L,40L,35L,50L,60L,48L,85L,48L,54L,75L,56L,49L,62L,75L,66L,62L,273L,65L,105L,76L,66L,154L,80L,120L,86L,72L,90L,114L,102L,190L,77L,100L,147L,86L,93L,108L,125L,112L,273L,91L,110L,189L,122L,99L,270L,128L,189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077670Inst : IEnumerable<long>
{
public static readonly long[] Value=A077670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077670.Bytes);
public long this[int i]=>Value[i];

public static A077670Inst Instance=new A077670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077671
{
public static readonly long[] Value={ 10L,105L,120L,153L,190L,210L,253L,300L,325L,351L,496L,630L,780L,820L,946L,1035L,1378L,1485L,1830L,1891L,2080L,2145L,2415L,2701L,2850L,3081L,3160L,3570L,3655L,3741L,3916L,4005L,4095L,4371L,4560L,4851L,4950L,5050L,5356L,5460L,5565L,5778L,6105L,6555L,7021L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077671Inst : IEnumerable<long>
{
public static readonly long[] Value=A077671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077671.Bytes);
public long this[int i]=>Value[i];

public static A077671Inst Instance=new A077671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077672
{
public static readonly long[] Value={ 1L,6L,45L,-1L,15L,36L,21L,120L,-1L,210L,66L,36L,78L,210L,45L,-1L,1326L,378L,190L,120L,210L,66L,1035L,4560L,-1L,78L,1485L,1540L,435L,300L,465L,902496L,1485L,3570L,105L,-1L,17205L,4560L,2145L,120L,861L,630L,903L,157080L,4095L,276L,9870L,41328L,-1L,300L,153L,780L,5565L,1185030L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077672Inst : IEnumerable<long>
{
public static readonly long[] Value=A077672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077672.Bytes);
public long this[int i]=>Value[i];

public static A077672Inst Instance=new A077672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077673
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,17L,29L,46L,74L,119L,195L,319L,521L,859L,1407L,2315L,3810L,6267L,10303L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077673Inst : IEnumerable<long>
{
public static readonly long[] Value=A077673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077673.Bytes);
public long this[int i]=>Value[i];

public static A077673Inst Instance=new A077673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077674
{
public static readonly long[] Value={ 2L,3L,5L,6L,7L,22L,23L,26L,33L,35L,37L,53L,55L,57L,62L,65L,66L,67L,73L,77L,222L,223L,226L,227L,233L,235L,237L,253L,255L,257L,262L,263L,265L,266L,267L,273L,277L,322L,323L,326L,327L,335L,337L,353L,355L,357L,362L,365L,366L,367L,373L,377L,523L,526L,527L,533L,535L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077674Inst : IEnumerable<long>
{
public static readonly long[] Value=A077674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077674.Bytes);
public long this[int i]=>Value[i];

public static A077674Inst Instance=new A077674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077675
{
public static readonly long[] Value={ 11L,14L,19L,41L,89L,91L,94L,111L,114L,118L,119L,141L,149L,181L,191L,194L,199L,411L,418L,419L,449L,481L,489L,491L,494L,498L,499L,811L,814L,818L,849L,881L,889L,894L,898L,899L,911L,914L,919L,941L,949L,989L,991L,994L,998L,1111L,1114L,1118L,1119L,1141L,1149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077675Inst : IEnumerable<long>
{
public static readonly long[] Value=A077675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077675.Bytes);
public long this[int i]=>Value[i];

public static A077675Inst Instance=new A077675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077676
{
public static readonly long[] Value={ 25L,36L,225L,256L,576L,625L,676L,5625L,5776L,7225L,27225L,27556L,37636L,55225L,65536L,75625L,225625L,226576L,235225L,265225L,266256L,275625L,276676L,367236L,525625L,553536L,732736L,765625L,767376L,2322576L,2325625L,2356225L,2637376L,2673225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077676Inst : IEnumerable<long>
{
public static readonly long[] Value=A077676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077676.Bytes);
public long this[int i]=>Value[i];

public static A077676Inst Instance=new A077676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077677
{
public static readonly long[] Value={ 1L,10L,11L,13L,14L,15L,17L,19L,101L,102L,103L,105L,106L,107L,109L,110L,111L,113L,114L,115L,118L,119L,122L,123L,127L,129L,130L,131L,133L,134L,137L,138L,139L,141L,142L,143L,145L,146L,149L,151L,154L,155L,157L,158L,159L,161L,163L,165L,166L,167L,170L,173L,174L,177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077677Inst : IEnumerable<long>
{
public static readonly long[] Value=A077677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077677.Bytes);
public long this[int i]=>Value[i];

public static A077677Inst Instance=new A077677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077678
{
public static readonly long[] Value={ 2L,21L,22L,23L,26L,29L,201L,202L,203L,205L,206L,209L,210L,211L,213L,214L,215L,217L,218L,219L,221L,222L,223L,226L,227L,229L,230L,231L,233L,235L,237L,238L,239L,241L,246L,247L,249L,251L,253L,254L,255L,257L,258L,259L,262L,263L,265L,266L,267L,269L,271L,273L,274L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077678Inst : IEnumerable<long>
{
public static readonly long[] Value=A077678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077678.Bytes);
public long this[int i]=>Value[i];

public static A077678Inst Instance=new A077678Inst();

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