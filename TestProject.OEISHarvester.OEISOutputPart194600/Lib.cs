using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A225057
{
public static readonly long[] Value={ 2L,2L,2L,2L,47L,3L,53L,677L,823L,227L,1907L,1103L,17L,163L,2693L,1213L,277L,2767L,887L,8353L,1013L,773L,6967L,1423L,2593L,9643L,157L,18013L,263L,2137L,2837L,107L,3467L,2137L,17L,2777L,1453L,2683L,7963L,3517L,2767L,53527L,8563L,227L,367L,27673L,30853L,5087L,7723L,14753L,41687L,137L,48647L,26357L,16747L,2797L,9887L,35933L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225057Inst : IEnumerable<long>
{
public static readonly long[] Value=A225057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225057.Bytes);
public long this[int i]=>Value[i];

public static A225057Inst Instance=new A225057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225058
{
public static readonly long[] Value={ -1L,1L,1L,3L,0L,5L,3L,7L,1L,9L,5L,11L,2L,13L,7L,15L,3L,17L,9L,19L,4L,21L,11L,23L,5L,25L,13L,27L,6L,29L,15L,31L,7L,33L,17L,35L,8L,37L,19L,39L,9L,41L,21L,43L,10L,45L,23L,47L,11L,49L,25L,51L,12L,53L,27L,55L,13L,57L,29L,59L,14L,61L,31L,63L,15L,65L,33L,67L,16L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225058Inst : IEnumerable<long>
{
public static readonly long[] Value=A225058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225058.Bytes);
public long this[int i]=>Value[i];

public static A225058Inst Instance=new A225058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225059
{
public static readonly long[] Value={ 3L,4L,6L,9L,10L,11L,12L,13L,15L,18L,20L,21L,23L,25L,27L,30L,31L,32L,33L,35L,36L,38L,40L,41L,42L,43L,45L,46L,47L,48L,49L,51L,52L,54L,56L,57L,59L,61L,62L,63L,65L,66L,67L,69L,70L,71L,72L,73L,74L,76L,77L,78L,79L,80L,81L,82L,83L,85L,86L,89L,91L,92L,95L,96L,97L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225059Inst : IEnumerable<long>
{
public static readonly long[] Value=A225059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225059.Bytes);
public long this[int i]=>Value[i];

public static A225059Inst Instance=new A225059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225060
{
public static readonly long[] Value={ 3L,15L,23L,39L,47L,71L,95L,119L,167L,191L,215L,239L,311L,431L,479L,551L,671L,719L,791L,839L,959L,1151L,1319L,1511L,1559L,1679L,1991L,2159L,2351L,2519L,2831L,2999L,3071L,3671L,3839L,3911L,4031L,4079L,4199L,4679L,4991L,5351L,5519L,5591L,5711L,6431L,6551L,7391L,8111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225060Inst : IEnumerable<long>
{
public static readonly long[] Value=A225060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225060.Bytes);
public long this[int i]=>Value[i];

public static A225060Inst Instance=new A225060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225061
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,10L,11L,13L,14L,15L,19L,21L,25L,26L,30L,31L,32L,33L,36L,41L,45L,49L,51L,52L,56L,60L,63L,64L,68L,73L,76L,81L,82L,83L,84L,85L,88L,91L,92L,93L,97L,99L,109L,114L,117L,120L,121L,126L,134L,135L,138L,139L,153L,156L,161L,165L,174L,178L,181L,185L,195L,202L,205L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225061Inst : IEnumerable<long>
{
public static readonly long[] Value=A225061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225061.Bytes);
public long this[int i]=>Value[i];

public static A225061Inst Instance=new A225061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225062
{
public static readonly long[] Value={ 4L,1L,1L,11L,1L,1L,3L,1L,6L,2L,1L,3L,1L,1L,8L,1L,8L,2L,3L,1L,3L,3L,1L,1L,4L,22L,4L,2L,2L,4L,6L,1L,98L,1L,3L,1L,3L,1L,1L,3L,3L,1L,1L,1L,9L,2L,16L,1L,1L,1L,3L,3L,1L,11L,2L,1L,2L,1L,2L,5L,1L,11L,1L,7L,4L,1L,4L,12L,8L,1L,6L,1L,1L,1L,1L,4L,2L,2L,3L,2L,1L,1L,7L,1L,8L,8L,1L,117L,4L,6L,3L,1L,3L,1L,1L,4L,2L,2L,7L,1L,2L,1L,1L,3L,21L,1L,9L,6L,1L,1L,4L,2L,2L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225062Inst : IEnumerable<long>
{
public static readonly long[] Value=A225062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225062.Bytes);
public long this[int i]=>Value[i];

public static A225062Inst Instance=new A225062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225063
{
public static readonly long[] Value={ 5L,4L,2L,3L,4L,3L,3L,4L,15L,6L,4L,6L,6L,3L,6L,3L,4L,7L,3L,7L,18L,4L,6L,4L,3L,7L,6L,25L,7L,3L,3L,4L,3L,31L,6L,4L,3L,6L,3L,13L,10L,12L,4L,3L,13L,4L,6L,3L,21L,4L,43L,10L,4L,9L,6L,10L,7L,21L,28L,19L,3L,6L,13L,4L,6L,33L,7L,15L,28L,19L,10L,6L,18L,18L,6L,21L,4L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225063Inst : IEnumerable<long>
{
public static readonly long[] Value=A225063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225063.Bytes);
public long this[int i]=>Value[i];

public static A225063Inst Instance=new A225063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225064
{
public static readonly long[] Value={ 2L,2L,1L,2L,0L,2L,9L,9L,9L,7L,9L,2L,1L,1L,7L,6L,5L,3L,8L,9L,2L,4L,9L,1L,9L,3L,4L,2L,1L,5L,9L,9L,1L,7L,9L,5L,6L,8L,5L,3L,2L,6L,3L,1L,9L,4L,9L,3L,5L,1L,4L,8L,2L,6L,1L,4L,3L,8L,9L,7L,6L,7L,1L,4L,5L,8L,8L,2L,3L,9L,1L,2L,5L,0L,3L,7L,4L,7L,9L,4L,3L,8L,0L,2L,1L,4L,7L,9L,4L,9L,4L,9L,4L,6L,7L,0L,7L,4L,7L,3L,3L,5L,5L,9L,7L,0L,2L,5L,7L,7L,7L,3L,1L,4L,0L,2L,9L,1L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225064Inst : IEnumerable<long>
{
public static readonly long[] Value=A225064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225064.Bytes);
public long this[int i]=>Value[i];

public static A225064Inst Instance=new A225064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225065
{
public static readonly long[] Value={ 2L,20L,53L,54L,81L,90L,101L,116L,127L,146L,177L,258L,287L,314L,321L,353L,407L,416L,438L,474L,580L,639L,686L,690L,797L,863L,913L,922L,981L,1045L,1079L,1219L,1235L,1259L,1418L,1493L,1496L,1552L,1637L,1783L,1866L,2011L,2058L,2063L,2158L,2298L,2333L,2422L,2529L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225065Inst : IEnumerable<long>
{
public static readonly long[] Value=A225065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225065.Bytes);
public long this[int i]=>Value[i];

public static A225065Inst Instance=new A225065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225066
{
public static readonly BigInteger[] Value={ 6L,2850L,79800L,2162160L,134734320L,15518903400L,174626020800L,19794628854000L,659394533191680L,659394533191680L,659394533191680L,BigInteger.Parse("38022361747469489295360") };
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
public class A225066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225066Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A225066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225066.Bytes);
public BigInteger this[int i]=>Value[i];

public static A225066Inst Instance=new A225066Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225067
{
public static readonly BigInteger[] Value={ 7L,6426L,35224L,2077992L,3610893055L,14209771072L,118896888880L,6400213601782L,22535310978496008L,22535310978496008L,BigInteger.Parse("2418562185097611420000"),BigInteger.Parse("2462278542548750181849600") };
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
public class A225067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225067Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A225067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225067.Bytes);
public BigInteger this[int i]=>Value[i];

public static A225067Inst Instance=new A225067Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225068
{
public static readonly BigInteger[] Value={ 8L,1408L,2165800L,37333296L,19384601600L,69370076160L,69370076160L,56288711711232000L,7917914554368000000L,BigInteger.Parse("199449790781142859776") };
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
public class A225068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225068Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A225068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225068.Bytes);
public BigInteger this[int i]=>Value[i];

public static A225068Inst Instance=new A225068Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225069
{
public static readonly BigInteger[] Value={ 9L,265926L,9909504L,28123200L,34171875L,9833523682950L,189619679700L,1489258878162739200L,BigInteger.Parse("32051313254079000000000"),BigInteger.Parse("231538926078057635957250"),BigInteger.Parse("5980078350588060426240000") };
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
public class A225069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225069Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A225069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225069.Bytes);
public BigInteger this[int i]=>Value[i];

public static A225069Inst Instance=new A225069Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225070
{
public static readonly BigInteger[] Value={ 10L,69300L,9729720L,4257000L,967412160L,4104100000L,1408951239696000L,59860503846000000L,BigInteger.Parse("1542547619019487080000"),BigInteger.Parse("39054496014386012160000"),BigInteger.Parse("450510331438947780000000") };
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
public class A225070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225070Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A225070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225070.Bytes);
public BigInteger this[int i]=>Value[i];

public static A225070Inst Instance=new A225070Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225071
{
public static readonly long[] Value={ 0L,12L,16L,20L,16L,28L,24L,32L,32L,36L,24L,36L,64L,32L,48L,44L,32L,72L,64L,48L,72L,60L,56L,60L,40L,56L,72L,112L,64L,76L,88L,56L,136L,92L,80L,76L,88L,72L,64L,108L,72L,124L,160L,88L,112L,104L,64L,144L,112L,80L,144L,132L,80L,140L,128L,104L,160L,160L,104L,112L,136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225071Inst : IEnumerable<long>
{
public static readonly long[] Value=A225071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225071.Bytes);
public long this[int i]=>Value[i];

public static A225071Inst Instance=new A225071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225072
{
public static readonly long[] Value={ 0L,3L,4L,5L,4L,7L,6L,8L,8L,9L,6L,9L,16L,8L,12L,11L,8L,18L,16L,12L,18L,15L,14L,15L,10L,14L,18L,28L,16L,19L,22L,14L,34L,23L,20L,19L,22L,18L,16L,27L,18L,31L,40L,22L,28L,26L,16L,36L,28L,20L,36L,33L,20L,35L,32L,26L,40L,40L,26L,28L,34L,24L,46L,37L,28L,45L,30L,34L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225072Inst : IEnumerable<long>
{
public static readonly long[] Value=A225072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225072.Bytes);
public long this[int i]=>Value[i];

public static A225072Inst Instance=new A225072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225073
{
public static readonly long[] Value={ 0L,0L,3L,3L,3L,12L,9L,35L,-2L,48L,65L,72L,65L,72L,73L,183L,357L,500L,357L,500L,480L,1250L,2201L,2201L,-6L,4347L,4426L,4226L,9911L,13005L,20871L,22511L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225073Inst : IEnumerable<long>
{
public static readonly long[] Value=A225073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225073.Bytes);
public long this[int i]=>Value[i];

public static A225073Inst Instance=new A225073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225074
{
public static readonly long[] Value={ 0L,3L,3L,9L,-2L,65L,65L,73L,357L,357L,480L,2201L,-6L,4426L,9911L,20871L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225074Inst : IEnumerable<long>
{
public static readonly long[] Value=A225074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225074.Bytes);
public long this[int i]=>Value[i];

public static A225074Inst Instance=new A225074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225075
{
public static readonly long[] Value={ 0L,3L,12L,35L,48L,72L,72L,183L,500L,500L,1250L,2201L,4347L,4226L,13005L,22511L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225075Inst : IEnumerable<long>
{
public static readonly long[] Value=A225075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225075.Bytes);
public long this[int i]=>Value[i];

public static A225075Inst Instance=new A225075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225076
{
public static readonly long[] Value={ 1L,1L,22L,1L,1L,236L,1446L,236L,1L,1L,2178L,58479L,201244L,58479L,2178L,1L,1L,19672L,1736668L,19971304L,49441990L,19971304L,1736668L,19672L,1L,1L,177134L,46525293L,1356555432L,9480267666L,19107752148L,9480267666L,1356555432L,46525293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225076Inst : IEnumerable<long>
{
public static readonly long[] Value=A225076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225076.Bytes);
public long this[int i]=>Value[i];

public static A225076Inst Instance=new A225076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225077
{
public static readonly long[] Value={ 17L,37L,59L,103L,137L,149L,313L,467L,491L,883L,911L,1277L,1423L,1619L,1783L,2137L,2473L,2729L,4127L,4933L,5437L,5507L,6043L,6359L,10039L,10453L,11717L,13397L,15809L,17489L,20807L,21821L,23027L,27631L,28307L,28813L,29669L,33029L,36947L,39103L,44203L,48281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225077Inst : IEnumerable<long>
{
public static readonly long[] Value=A225077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225077.Bytes);
public long this[int i]=>Value[i];

public static A225077Inst Instance=new A225077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225078
{
public static readonly long[] Value={ 1L,2L,4L,6L,14L,20L,26L,36L,54L,74L,116L,120L,126L,130L,134L,160L,176L,204L,210L,230L,236L,256L,264L,284L,300L,314L,340L,386L,420L,440L,466L,490L,496L,544L,594L,636L,644L,714L,750L,760L,784L,816L,930L,950L,986L,1070L,1124L,1140L,1146L,1156L,1174L,1176L,1210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225078Inst : IEnumerable<long>
{
public static readonly long[] Value=A225078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225078.Bytes);
public long this[int i]=>Value[i];

public static A225078Inst Instance=new A225078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225079
{
public static readonly long[] Value={ 1L,10L,11L,19L,31L,38L,43L,44L,50L,64L,85L,94L,95L,121L,131L,139L,142L,154L,158L,166L,175L,176L,179L,194L,206L,211L,212L,214L,226L,229L,233L,238L,256L,260L,265L,284L,286L,292L,295L,329L,340L,353L,362L,364L,365L,380L,397L,400L,418L,428L,449L,464L,467L,470L,491L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225079Inst : IEnumerable<long>
{
public static readonly long[] Value=A225079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225079.Bytes);
public long this[int i]=>Value[i];

public static A225079Inst Instance=new A225079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225080
{
public static readonly long[] Value={ 0L,1L,1L,1L,3L,1L,5L,2L,5L,2L,7L,4L,6L,5L,9L,4L,10L,6L,11L,6L,10L,8L,14L,9L,13L,11L,19L,7L,12L,9L,18L,9L,22L,14L,23L,11L,12L,12L,22L,11L,22L,16L,30L,14L,19L,15L,31L,15L,27L,18L,41L,12L,23L,16L,26L,17L,25L,22L,36L,16L,25L,20L,40L,20L,46L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225080Inst : IEnumerable<long>
{
public static readonly long[] Value=A225080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225080.Bytes);
public long this[int i]=>Value[i];

public static A225080Inst Instance=new A225080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225081
{
public static readonly long[] Value={ 1L,2L,1L,2L,4L,2L,1L,2L,4L,8L,4L,2L,4L,2L,1L,2L,4L,8L,4L,8L,16L,8L,4L,2L,4L,8L,4L,2L,4L,2L,1L,2L,4L,8L,4L,8L,16L,8L,4L,8L,16L,32L,16L,8L,16L,8L,4L,2L,4L,8L,4L,8L,16L,8L,4L,2L,4L,8L,4L,2L,4L,2L,1L,2L,4L,8L,4L,8L,16L,8L,4L,8L,16L,32L,16L,8L,16L,8L,4L,8L,16L,32L,16L,32L,64L,32L,16L,8L,16L,32L,16L,8L,16L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225081Inst : IEnumerable<long>
{
public static readonly long[] Value=A225081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225081.Bytes);
public long this[int i]=>Value[i];

public static A225081Inst Instance=new A225081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225082
{
public static readonly long[] Value={ 101L,103L,107L,109L,113L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L,223L,229L,233L,239L,263L,269L,283L,293L,307L,311L,317L,331L,337L,347L,367L,397L,401L,421L,431L,433L,443L,457L,461L,463L,467L,487L,491L,503L,509L,523L,563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225082Inst : IEnumerable<long>
{
public static readonly long[] Value=A225082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225082.Bytes);
public long this[int i]=>Value[i];

public static A225082Inst Instance=new A225082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225083
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,31L,37L,41L,43L,47L,53L,73L,89L,97L,101L,103L,107L,113L,127L,131L,151L,157L,163L,167L,173L,179L,181L,191L,197L,199L,211L,223L,229L,241L,263L,281L,283L,313L,331L,337L,347L,349L,353L,367L,373L,409L,421L,433L,439L,443L,457L,487L,491L,509L,523L,541L,547L,587L,617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225083Inst : IEnumerable<long>
{
public static readonly long[] Value=A225083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225083.Bytes);
public long this[int i]=>Value[i];

public static A225083Inst Instance=new A225083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225084
{
public static readonly long[] Value={ 1L,2L,0L,3L,1L,0L,5L,2L,1L,0L,7L,6L,2L,1L,0L,11L,12L,6L,2L,1L,0L,15L,26L,14L,6L,2L,1L,0L,22L,50L,33L,14L,6L,2L,1L,0L,30L,97L,72L,34L,14L,6L,2L,1L,0L,42L,180L,156L,77L,34L,14L,6L,2L,1L,0L,56L,332L,328L,173L,78L,34L,14L,6L,2L,1L,0L,77L,600L,681L,378L,177L,78L,34L,14L,6L,2L,1L,0L,101L,1078L,1393L,818L,393L,178L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225084Inst : IEnumerable<long>
{
public static readonly long[] Value=A225084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225084.Bytes);
public long this[int i]=>Value[i];

public static A225084Inst Instance=new A225084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225085
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,4L,5L,7L,8L,8L,7L,13L,15L,16L,16L,11L,23L,29L,31L,32L,32L,15L,41L,55L,61L,63L,64L,64L,22L,72L,105L,119L,125L,127L,128L,128L,30L,127L,199L,233L,247L,253L,255L,256L,256L,42L,222L,378L,455L,489L,503L,509L,511L,512L,512L,56L,388L,716L,889L,967L,1001L,1015L,1021L,1023L,1024L,1024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225085Inst : IEnumerable<long>
{
public static readonly long[] Value=A225085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225085.Bytes);
public long this[int i]=>Value[i];

public static A225085Inst Instance=new A225085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225086
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,9L,11L,13L,15L,17L,19L,21L,23L,25L,28L,30L,32L,35L,37L,40L,43L,45L,48L,51L,53L,56L,59L,62L,65L,68L,71L,74L,77L,80L,83L,87L,90L,93L,96L,100L,103L,106L,110L,113L,117L,120L,124L,128L,131L,135L,139L,142L,146L,150L,154L,157L,161L,165L,169L,173L,177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225086Inst : IEnumerable<long>
{
public static readonly long[] Value=A225086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225086.Bytes);
public long this[int i]=>Value[i];

public static A225086Inst Instance=new A225086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225087
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,11L,14L,17L,21L,25L,29L,34L,39L,45L,51L,57L,63L,70L,77L,85L,92L,101L,109L,118L,127L,137L,147L,157L,168L,179L,190L,202L,214L,226L,239L,252L,266L,280L,294L,309L,324L,339L,355L,371L,387L,404L,422L,439L,457L,476L,494L,514L,533L,553L,574L,594L,615L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225087Inst : IEnumerable<long>
{
public static readonly long[] Value=A225087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225087.Bytes);
public long this[int i]=>Value[i];

public static A225087Inst Instance=new A225087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225088
{
public static readonly long[] Value={ 1L,2L,4L,7L,11L,16L,22L,29L,38L,47L,59L,72L,86L,102L,121L,141L,163L,187L,214L,243L,274L,308L,345L,385L,427L,473L,521L,573L,628L,687L,749L,815L,885L,959L,1037L,1119L,1206L,1297L,1393L,1493L,1598L,1708L,1824L,1944L,2070L,2202L,2339L,2482L,2631L,2785L,2947L,3114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225088Inst : IEnumerable<long>
{
public static readonly long[] Value=A225088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225088.Bytes);
public long this[int i]=>Value[i];

public static A225088Inst Instance=new A225088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225089
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,0L,2L,0L,1L,2L,1L,2L,1L,0L,1L,4L,3L,1L,0L,3L,2L,4L,4L,2L,5L,5L,4L,3L,5L,0L,6L,3L,2L,8L,7L,6L,8L,2L,7L,0L,10L,6L,5L,4L,7L,8L,10L,9L,8L,4L,3L,10L,9L,11L,14L,9L,12L,7L,6L,10L,9L,0L,14L,13L,12L,7L,6L,5L,10L,17L,13L,15L,0L,13L,12L,16L,15L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225089Inst : IEnumerable<long>
{
public static readonly long[] Value=A225089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225089.Bytes);
public long this[int i]=>Value[i];

public static A225089Inst Instance=new A225089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225090
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,5L,7L,8L,9L,8L,11L,8L,13L,11L,15L,14L,17L,14L,19L,11L,13L,17L,23L,13L,25L,20L,27L,22L,29L,23L,31L,26L,33L,26L,35L,18L,37L,29L,23L,22L,41L,17L,43L,34L,45L,35L,47L,24L,49L,38L,51L,25L,53L,30L,23L,20L,33L,44L,59L,19L,61L,47L,39L,44L,65L,50L,67L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225090Inst : IEnumerable<long>
{
public static readonly long[] Value=A225090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225090.Bytes);
public long this[int i]=>Value[i];

public static A225090Inst Instance=new A225090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225091
{
public static readonly long[] Value={ 1L,7L,13L,5L,7L,11L,7L,25L,31L,7L,43L,49L,37L,13L,29L,1L,13L,29L,73L,79L,19L,41L,97L,85L,73L,97L,7L,91L,133L,121L,59L,115L,103L,127L,71L,157L,17L,115L,65L,17L,71L,37L,17L,169L,175L,163L,187L,175L,17L,89L,23L,217L,49L,55L,217L,107L,211L,181L,241L,211L,199L,205L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225091Inst : IEnumerable<long>
{
public static readonly long[] Value=A225091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225091.Bytes);
public long this[int i]=>Value[i];

public static A225091Inst Instance=new A225091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225092
{
public static readonly long[] Value={ 1L,4L,6L,2L,6L,2L,2L,9L,1L,2L,3L,9L,0L,7L,4L,0L,2L,0L,5L,2L,8L,0L,9L,1L,3L,0L,8L,0L,3L,0L,9L,9L,2L,0L,1L,6L,8L,6L,3L,4L,9L,0L,7L,0L,3L,8L,2L,1L,2L,9L,2L,0L,0L,3L,2L,9L,3L,8L,3L,2L,5L,2L,0L,2L,3L,0L,1L,1L,3L,0L,4L,7L,2L,7L,9L,4L,5L,0L,9L,5L,5L,5L,8L,7L,1L,3L,3L,8L,3L,9L,4L,6L,2L,8L,8L,7L,6L,7L,8L,3L,4L,6L,7L,3L,2L,9L,1L,7L,8L,1L,5L,1L,3L,0L,7L,6L,7L,1L,2L,5L,5L,1L,9L,0L,6L,7L,7L,3L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225092Inst : IEnumerable<long>
{
public static readonly long[] Value=A225092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225092.Bytes);
public long this[int i]=>Value[i];

public static A225092Inst Instance=new A225092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225093
{
public static readonly long[] Value={ 2L,3L,7L,13L,5L,11L,31L,43L,37L,29L,73L,79L,19L,41L,97L,59L,103L,127L,71L,157L,17L,163L,89L,23L,107L,211L,181L,241L,199L,131L,67L,101L,61L,271L,277L,149L,313L,307L,47L,367L,173L,397L,331L,409L,179L,197L,191L,457L,251L,499L,239L,233L,487L,139L,547L,523L,571L,151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225093Inst : IEnumerable<long>
{
public static readonly long[] Value=A225093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225093.Bytes);
public long this[int i]=>Value[i];

public static A225093Inst Instance=new A225093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225094
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,0L,1L,1L,6L,2L,0L,1L,1L,24L,54L,2L,0L,1L,1L,120L,1944L,384L,2L,0L,1L,1L,720L,99000L,132000L,2550L,2L,0L,1L,1L,5040L,6966000L,79716000L,8059800L,16506L,2L,0L,1L,1L,40320L,655678800L,78928416000L,57010275000L,471369024L,105840L,2L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225094Inst : IEnumerable<long>
{
public static readonly long[] Value=A225094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225094.Bytes);
public long this[int i]=>Value[i];

public static A225094Inst Instance=new A225094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225095
{
public static readonly BigInteger[] Value={ 0L,1L,5L,41L,444L,5979L,96375L,1810297L,38845520L,937702437L,25154615815L,742476758297L,23915618605956L,834831863473087L,31395048114431183L,1265451184688113105L,BigInteger.Parse("54426870391856267072"),BigInteger.Parse("2488054366709505840265"),BigInteger.Parse("120468464465317265258991"),BigInteger.Parse("6158924799179729969013985") };
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
public class A225095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225095Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A225095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225095.Bytes);
public BigInteger this[int i]=>Value[i];

public static A225095Inst Instance=new A225095Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225096
{
public static readonly BigInteger[] Value={ 1L,0L,2L,384L,132000L,79716000L,78928416000L,120481708032000L,269702267433984000L,BigInteger.Parse("850271305403520000000"),BigInteger.Parse("3652393464869909760000000"),BigInteger.Parse("20798525597035736309760000000"),BigInteger.Parse("153427251286862484058423296000000"),BigInteger.Parse("1437639344607855309441929920512000000") };
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
public class A225096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225096Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A225096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225096.Bytes);
public BigInteger this[int i]=>Value[i];

public static A225096Inst Instance=new A225096Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225097
{
public static readonly long[] Value={ 3L,11L,13L,43L,67L,109L,15101L,43997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225097Inst : IEnumerable<long>
{
public static readonly long[] Value=A225097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225097.Bytes);
public long this[int i]=>Value[i];

public static A225097Inst Instance=new A225097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225098
{
public static readonly long[] Value={ 2L,3L,7L,13L,15L,21L,43L,49L,63L,69L,127L,155L,183L,211L,231L,237L,259L,265L,273L,293L,301L,323L,335L,391L,435L,441L,447L,489L,505L,573L,595L,671L,713L,715L,743L,757L,797L,811L,951L,959L,973L,979L,987L,993L,1035L,1147L,1197L,1287L,1359L,1393L,1415L,1429L,1443L,1491L,1525L,1597L,1617L,1653L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225098Inst : IEnumerable<long>
{
public static readonly long[] Value=A225098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225098.Bytes);
public long this[int i]=>Value[i];

public static A225098Inst Instance=new A225098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225099
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,1L,0L,1L,1L,1L,2L,0L,0L,0L,1L,2L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,2L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225099Inst : IEnumerable<long>
{
public static readonly long[] Value=A225099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225099.Bytes);
public long this[int i]=>Value[i];

public static A225099Inst Instance=new A225099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225100
{
public static readonly long[] Value={ 0L,12L,36L,370L,3770L,12410L,202130L,197210L,81770L,9151610L,16046810L,12625730L,21899930L,95336930L,9549410L,416392730L,1016275130L,338609570L,789396530L,601741010L,254885930L,10083683090L,4690939370L,29207671610L,30431277890L,22264417370L,23231920010L,10838858810L,37462976330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225100Inst : IEnumerable<long>
{
public static readonly long[] Value=A225100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225100.Bytes);
public long this[int i]=>Value[i];

public static A225100Inst Instance=new A225100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225101
{
public static readonly long[] Value={ 0L,1L,2L,7L,6L,31L,18L,127L,170L,511L,186L,2047L,630L,8191L,10922L,32767L,7710L,131071L,27594L,524287L,699050L,2097151L,364722L,8388607L,6710886L,33554431L,44739242L,19173961L,18512790L,536870911L,69273666L,2147483647L,2863311530L,8589934591L,34359738366L,34359738367L,3714566310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225101Inst : IEnumerable<long>
{
public static readonly long[] Value=A225101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225101.Bytes);
public long this[int i]=>Value[i];

public static A225101Inst Instance=new A225101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225102
{
public static readonly long[] Value={ 12L,13L,17L,20L,24L,25L,29L,31L,33L,34L,35L,36L,40L,41L,43L,48L,52L,53L,57L,58L,59L,65L,68L,72L,73L,74L,76L,80L,81L,85L,89L,90L,91L,96L,97L,106L,108L,113L,125L,129L,130L,132L,133L,134L,136L,137L,141L,144L,145L,146L,148L,150L,152L,153L,155L,157L,160L,170L,173L,174L,177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225102Inst : IEnumerable<long>
{
public static readonly long[] Value=A225102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225102.Bytes);
public long this[int i]=>Value[i];

public static A225102Inst Instance=new A225102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225103
{
public static readonly long[] Value={ 36L,41L,57L,89L,113L,129L,130L,137L,153L,177L,185L,297L,305L,368L,370L,377L,410L,425L,537L,545L,561L,593L,633L,650L,657L,850L,857L,868L,873L,890L,969L,986L,1010L,1130L,1385L,1490L,1690L,1730L,1802L,1865L,1881L,1898L,1970L,2210L,2213L,2217L,2236L,2330L,2337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225103Inst : IEnumerable<long>
{
public static readonly long[] Value=A225103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225103.Bytes);
public long this[int i]=>Value[i];

public static A225103Inst Instance=new A225103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225104
{
public static readonly long[] Value={ 370L,650L,2210L,3770L,5330L,6290L,7202L,10370L,10730L,11570L,12410L,12818L,13130L,14690L,15170L,15650L,16250L,16490L,18122L,18530L,19370L,19610L,21170L,22490L,24050L,24650L,25010L,26690L,28730L,29930L,30290L,30770L,31610L,32810L,33410L,34970L,36482L,36490L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225104Inst : IEnumerable<long>
{
public static readonly long[] Value=A225104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225104.Bytes);
public long this[int i]=>Value[i];

public static A225104Inst Instance=new A225104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225105
{
public static readonly long[] Value={ 3L,5L,7L,9L,11L,13L,15L,17L,19L,23L,25L,29L,35L,37L,39L,53L,59L,61L,67L,75L,79L,87L,89L,99L,101L,105L,113L,115L,119L,131L,149L,153L,157L,173L,179L,181L,187L,197L,211L,219L,229L,241L,247L,249L,255L,267L,269L,277L,281L,307L,317L,329L,349L,371L,373L,383L,397L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225105Inst : IEnumerable<long>
{
public static readonly long[] Value=A225105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225105.Bytes);
public long this[int i]=>Value[i];

public static A225105Inst Instance=new A225105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225106
{
public static readonly long[] Value={ 9L,25L,81L,125L,512L,5041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225106Inst : IEnumerable<long>
{
public static readonly long[] Value=A225106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225106.Bytes);
public long this[int i]=>Value[i];

public static A225106Inst Instance=new A225106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225107
{
public static readonly BigInteger[] Value={ 3L,24L,228L,2256L,22512L,225024L,2250048L,22500096L,225000192L,2250000384L,22500000768L,225000001536L,2250000003072L,22500000006144L,225000000012288L,2250000000024576L,22500000000049152L,225000000000098304L,2250000000000196608L,BigInteger.Parse("22500000000000393216") };
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
public class A225107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225107Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A225107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225107.Bytes);
public BigInteger this[int i]=>Value[i];

public static A225107Inst Instance=new A225107Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225108
{
public static readonly BigInteger[] Value={ 1L,2L,8L,42L,288L,2280L,21600L,226800L,2701440L,35199360L,504403200L,7783776000L,130288435200L,2322678758400L,44286571929600L,894449267712000L,19144352747520000L,431093162852352000L,10224590808047616000UL,BigInteger.Parse("253873324553232384000"),BigInteger.Parse("6602896050191400960000") };
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
public class A225108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225108Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A225108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225108.Bytes);
public BigInteger this[int i]=>Value[i];

public static A225108Inst Instance=new A225108Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225109
{
public static readonly BigInteger[] Value={ 1L,3L,15L,117L,1185L,15123L,230895L,4116837L,83860545L,1921996323L,48942778575L,1370953667157L,41893214676705L,1386843017916723L,49441928730798255L,1888542637550347077L,BigInteger.Parse("76946148390480577665"),BigInteger.Parse("3331009898404800736323"),BigInteger.Parse("152682246738275154625935"),BigInteger.Parse("7387240827905368219116597") };
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
public class A225109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225109Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A225109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225109.Bytes);
public BigInteger this[int i]=>Value[i];

public static A225109Inst Instance=new A225109Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225110
{
public static readonly long[] Value={ 1L,6L,18L,28L,42L,54L,66L,78L,102L,114L,120L,126L,138L,162L,174L,180L,186L,196L,198L,222L,234L,246L,258L,282L,294L,306L,318L,342L,354L,366L,378L,402L,414L,426L,438L,462L,474L,486L,496L,498L,522L,534L,546L,558L,582L,594L,606L,618L,642L,654L,666L,672L,678L,702L,714L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225110Inst : IEnumerable<long>
{
public static readonly long[] Value=A225110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225110.Bytes);
public long this[int i]=>Value[i];

public static A225110Inst Instance=new A225110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225111
{
public static readonly BigInteger[] Value={ 1L,1L,2L,384L,8059800L,38606650125120L,BigInteger.Parse("71646205399259162031360"),BigInteger.Parse("78385944219935192681549282987212800"),BigInteger.Parse("71605824043564034004713155518007394441060661360000"),BigInteger.Parse("73473023853389304132357517396557811159635782691183541179936000000000") };
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
public class A225111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225111Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A225111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225111.Bytes);
public BigInteger this[int i]=>Value[i];

public static A225111Inst Instance=new A225111Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225112
{
public static readonly long[] Value={ 1L,2L,2L,1L,6L,6L,3L,8L,9L,9L,5L,0L,1L,3L,7L,1L,8L,3L,6L,0L,6L,9L,9L,7L,8L,9L,5L,1L,5L,1L,1L,5L,1L,8L,9L,7L,3L,3L,9L,7L,0L,4L,1L,0L,1L,8L,9L,9L,2L,9L,1L,7L,5L,1L,7L,6L,8L,0L,4L,9L,7L,2L,0L,8L,3L,3L,4L,9L,6L,2L,2L,7L,4L,6L,3L,7L,9L,5L,2L,0L,9L,8L,6L,2L,1L,3L,5L,1L,3L,2L,8L,4L,8L,8L,3L,1L,5L,4L,4L,1L,2L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225112Inst : IEnumerable<long>
{
public static readonly long[] Value=A225112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225112.Bytes);
public long this[int i]=>Value[i];

public static A225112Inst Instance=new A225112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225113
{
public static readonly long[] Value={ 6L,5L,8L,4L,7L,2L,3L,2L,5L,6L,9L,9L,6L,3L,4L,1L,3L,6L,4L,8L,7L,0L,9L,8L,8L,9L,7L,1L,6L,6L,0L,0L,5L,2L,7L,5L,9L,0L,5L,5L,8L,1L,7L,5L,6L,2L,4L,9L,0L,4L,1L,8L,5L,7L,2L,6L,2L,7L,9L,5L,3L,5L,1L,2L,0L,5L,1L,7L,0L,8L,7L,9L,6L,6L,7L,6L,6L,8L,2L,2L,7L,7L,6L,3L,3L,3L,8L,6L,3L,7L,0L,6L,3L,1L,2L,9L,9L,9L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225113Inst : IEnumerable<long>
{
public static readonly long[] Value=A225113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225113.Bytes);
public long this[int i]=>Value[i];

public static A225113Inst Instance=new A225113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225114
{
public static readonly long[] Value={ 1L,1L,3L,9L,28L,87L,272L,850L,2659L,8318L,26025L,81427L,254777L,797175L,2494307L,7804529L,24419909L,76408475L,239077739L,748060606L,2340639096L,7323726778L,22915525377L,71701378526L,224349545236L,701976998795L,2196446204672L,6872555567553L,21503836486190L,67284284442622L,210528708959146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225114Inst : IEnumerable<long>
{
public static readonly long[] Value=A225114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225114.Bytes);
public long this[int i]=>Value[i];

public static A225114Inst Instance=new A225114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225115
{
public static readonly BigInteger[] Value={ 3L,15L,120L,528L,4095L,139128L,160554240L,812293020528L,BigInteger.Parse("379188080252621270252095320") };
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
public class A225115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225115Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A225115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225115.Bytes);
public BigInteger this[int i]=>Value[i];

public static A225115Inst Instance=new A225115Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225116
{
public static readonly long[] Value={ 1L,5L,24L,110L,480L,2000L,8064L,32240L,130560L,531200L,2095104L,8030720L,33546240L,156569600L,536838144L,243660800L,8589803520L,244224819200L,137438429184L,-28539130347520L,2199021158400L,4960294141952000L,35184363700224L,-1015283149035274240L,562949919866880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225116Inst : IEnumerable<long>
{
public static readonly long[] Value=A225116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225116.Bytes);
public long this[int i]=>Value[i];

public static A225116Inst Instance=new A225116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225117
{
public static readonly long[] Value={ 1L,2L,1L,4L,13L,1L,8L,93L,60L,1L,16L,545L,1131L,251L,1L,32L,2933L,14498L,10678L,1018L,1L,64L,15177L,154113L,262438L,88998L,4089L,1L,128L,77101L,1475736L,4890287L,3870352L,692499L,16376L,1L,256L,388321L,13270807L,77404933L,117758659L,50476003L,5175013L,65527L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225117Inst : IEnumerable<long>
{
public static readonly long[] Value=A225117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225117.Bytes);
public long this[int i]=>Value[i];

public static A225117Inst Instance=new A225117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225118
{
public static readonly long[] Value={ 1L,3L,1L,9L,22L,1L,27L,235L,121L,1L,81L,1996L,3446L,620L,1L,243L,15349L,63854L,40314L,3119L,1L,729L,112546L,963327L,1434812L,422087L,15618L,1L,2187L,806047L,12960063L,37898739L,26672209L,4157997L,78117L,1L,6561L,5705752L,162711868L,840642408L,1151050534L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225118Inst : IEnumerable<long>
{
public static readonly long[] Value=A225118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225118.Bytes);
public long this[int i]=>Value[i];

public static A225118Inst Instance=new A225118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225119
{
public static readonly long[] Value={ 8L,7L,4L,0L,1L,9L,1L,8L,4L,7L,6L,4L,0L,3L,9L,9L,3L,6L,8L,2L,1L,6L,1L,3L,1L,9L,6L,6L,3L,0L,3L,7L,3L,1L,3L,7L,8L,9L,4L,2L,5L,1L,6L,5L,0L,4L,7L,7L,2L,0L,7L,7L,2L,0L,9L,3L,8L,9L,4L,0L,5L,6L,7L,9L,3L,3L,5L,9L,6L,8L,6L,2L,3L,5L,6L,8L,0L,4L,7L,5L,0L,0L,7L,6L,7L,6L,5L,1L,7L,7L,6L,5L,3L,8L,0L,9L,6L,9L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225119Inst : IEnumerable<long>
{
public static readonly long[] Value=A225119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225119.Bytes);
public long this[int i]=>Value[i];

public static A225119Inst Instance=new A225119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225120
{
public static readonly long[] Value={ 49L,64L,144L,256L,576L,625L,1156L,1296L,1444L,1521L,2209L,2916L,3364L,3844L,3969L,4096L,4356L,4489L,4624L,6889L,7744L,8649L,9025L,9216L,9409L,9604L,10201L,10404L,10609L,10816L,12321L,12996L,13456L,14161L,15129L,15376L,15625L,15876L,17956L,18496L,18769L,20164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225120Inst : IEnumerable<long>
{
public static readonly long[] Value=A225120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225120.Bytes);
public long this[int i]=>Value[i];

public static A225120Inst Instance=new A225120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225121
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,5L,15L,21L,56L,246L,525L,1573L,5764L,14092L,41405L,136995L,772552L,2148290L,8806629L,31679365L,155743665L,495240074L,2049655762L,7403470138L,32627363920L,207316068370L,784695179515L,3721285661481L,16967347935561L,82192321793926L,455572563875425L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225121Inst : IEnumerable<long>
{
public static readonly long[] Value=A225121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225121.Bytes);
public long this[int i]=>Value[i];

public static A225121Inst Instance=new A225121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225122
{
public static readonly long[] Value={ 0L,1L,1L,7L,1L,43L,23L,337L,22L,1091L,563L,12701L,1627L,172673L,88069L,179141L,5692L,3141493L,1593269L,61309987L,7759469L,8966941L,31730711L,1474162241L,93044486L,7510486741L,3788707301L,22918154531L,2888008157L,675037481999L,340028535787L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225122Inst : IEnumerable<long>
{
public static readonly long[] Value=A225122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225122.Bytes);
public long this[int i]=>Value[i];

public static A225122Inst Instance=new A225122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225123
{
public static readonly long[] Value={ 1L,2L,2L,18L,3L,150L,90L,1470L,105L,5670L,3150L,76230L,10395L,1171170L,630630L,1351350L,45045L,26036010L,13783770L,552882330L,72747675L,87297210L,320089770L,15393408030L,1003917915L,83659826250L,43503109650L,271057837050L,35137127025L,8442949665150L,4367042930250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225123Inst : IEnumerable<long>
{
public static readonly long[] Value=A225123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225123.Bytes);
public long this[int i]=>Value[i];

public static A225123Inst Instance=new A225123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225124
{
public static readonly long[] Value={ 1L,2L,4L,8L,3L,32L,21L,128L,85L,512L,151L,2048L,1365L,8192L,5461L,32768L,14563L,131072L,87381L,524288L,349525L,2097152L,932067L,8388608L,5592405L,33554432L,22369621L,134217728L,26512143L,536870912L,357913941L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225124Inst : IEnumerable<long>
{
public static readonly long[] Value=A225124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225124.Bytes);
public long this[int i]=>Value[i];

public static A225124Inst Instance=new A225124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225125
{
public static readonly long[] Value={ 1L,6L,9L,2L,9L,9L,2L,4L,6L,8L,4L,1L,3L,6L,0L,1L,2L,4L,4L,6L,7L,8L,0L,1L,3L,8L,3L,4L,8L,9L,8L,1L,0L,8L,7L,0L,8L,0L,7L,8L,6L,9L,8L,6L,7L,1L,5L,6L,8L,0L,7L,2L,3L,4L,9L,5L,6L,8L,8L,0L,1L,5L,7L,7L,8L,9L,4L,7L,6L,4L,3L,7L,2L,1L,3L,1L,9L,8L,7L,9L,8L,7L,2L,7L,9L,1L,8L,7L,3L,6L,3L,9L,6L,3L,5L,4L,4L,9L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225125Inst : IEnumerable<long>
{
public static readonly long[] Value=A225125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225125.Bytes);
public long this[int i]=>Value[i];

public static A225125Inst Instance=new A225125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225126
{
public static readonly long[] Value={ 0L,1L,4L,2L,7L,3L,10L,4L,13L,5L,16L,6L,19L,7L,22L,8L,25L,9L,28L,10L,31L,11L,34L,12L,37L,13L,40L,14L,43L,15L,46L,16L,49L,17L,52L,18L,55L,19L,58L,20L,61L,21L,64L,22L,67L,23L,70L,24L,73L,25L,76L,26L,79L,27L,82L,28L,85L,29L,88L,30L,91L,31L,94L,32L,97L,33L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225126Inst : IEnumerable<long>
{
public static readonly long[] Value=A225126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225126.Bytes);
public long this[int i]=>Value[i];

public static A225126Inst Instance=new A225126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225127
{
public static readonly long[] Value={ 1L,-4L,10L,-24L,59L,-146L,360L,-886L,2182L,-5376L,13244L,-32624L,80364L,-197968L,487672L,-1201319L,2959297L,-7289859L,17957662L,-44236464L,108971015L,-268436517L,661259918L,-1628931424L,4012669610L,-9884711639L,24349755585L,-59982589144L,147759635098L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225127Inst : IEnumerable<long>
{
public static readonly long[] Value=A225127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225127.Bytes);
public long this[int i]=>Value[i];

public static A225127Inst Instance=new A225127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225128
{
public static readonly long[] Value={ 1L,-7L,16L,-52L,412L,-2068L,6964L,-19960L,81880L,-396844L,1448908L,-3853348L,9668860L,-45544768L,238303744L,-764868256L,1962327904L,-9820441204L,62744531956L,-306405293056L,1228176071080L,-5276516025688L,26307346186816L,-126143746044604L,534479888324932L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225128Inst : IEnumerable<long>
{
public static readonly long[] Value=A225128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225128.Bytes);
public long this[int i]=>Value[i];

public static A225128Inst Instance=new A225128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225129
{
public static readonly long[] Value={ 1L,-13L,84L,-712L,6916L,-55788L,432584L,-3555212L,28927916L,-229458788L,1847086584L,-14858027212L,118242773916L,-945499611788L,7556178053084L,-60048635124212L,477995366994916L,-3810212526827288L,30296614848644584L,-240796293647346212L,1916211884628153416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225129Inst : IEnumerable<long>
{
public static readonly long[] Value=A225129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225129.Bytes);
public long this[int i]=>Value[i];

public static A225129Inst Instance=new A225129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225130
{
public static readonly long[] Value={ 1L,-11L,36L,-36L,36L,-3786L,63786L,-405036L,1215036L,-4368786L,45022536L,-380988786L,2242736286L,-7681046286L,26949825036L,-435049072536L,4543990507536L,-25626723348786L,80068989783786L,-100028016375036L,1579550678122536L,-31186023693776286L,252408733196148786L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225130Inst : IEnumerable<long>
{
public static readonly long[] Value=A225130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225130.Bytes);
public long this[int i]=>Value[i];

public static A225130Inst Instance=new A225130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225131
{
public static readonly long[] Value={ 1L,-13L,36L,-258L,5622L,-31716L,-83460L,1766388L,-2952900L,59171652L,-2614259136L,25907667528L,-87008484996L,410147565360L,-10353918172170L,73320103253412L,409638469731702L,-7210516315882284L,18236866211886120L,-161388385633551558L,6594430509454957926L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225131Inst : IEnumerable<long>
{
public static readonly long[] Value=A225131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225131.Bytes);
public long this[int i]=>Value[i];

public static A225131Inst Instance=new A225131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225132
{
public static readonly long[] Value={ 1L,-1L,1L,-2L,3L,-4L,5L,-8L,12L,-16L,22L,-32L,45L,-62L,87L,-124L,175L,-244L,343L,-484L,679L,-952L,1339L,-1884L,2646L,-3716L,5224L,-7342L,10313L,-14490L,20365L,-28618L,40210L,-56502L,79400L,-111570L,156769L,-220290L,309553L,-434974L,611210L,-858864L,1206862L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225132Inst : IEnumerable<long>
{
public static readonly long[] Value=A225132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225132.Bytes);
public long this[int i]=>Value[i];

public static A225132Inst Instance=new A225132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225133
{
public static readonly long[] Value={ 4L,143L,669L,2088L,8318L,30885L,87643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225133Inst : IEnumerable<long>
{
public static readonly long[] Value=A225133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225133.Bytes);
public long this[int i]=>Value[i];

public static A225133Inst Instance=new A225133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225134
{
public static readonly long[] Value={ 1L,4L,4L,6L,6L,0L,1L,4L,3L,2L,4L,2L,9L,8L,6L,4L,1L,7L,4L,5L,9L,7L,3L,3L,3L,9L,8L,7L,5L,9L,7L,6L,6L,1L,4L,8L,0L,6L,8L,7L,3L,2L,1L,0L,4L,2L,2L,8L,2L,2L,8L,0L,0L,2L,6L,3L,6L,3L,9L,0L,4L,7L,7L,2L,0L,9L,8L,5L,7L,0L,7L,6L,5L,9L,8L,3L,1L,0L,1L,6L,1L,4L,7L,4L,9L,2L,3L,5L,7L,2L,0L,0L,8L,1L,0L,9L,7L,6L,3L,0L,9L,9L,7L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225134Inst : IEnumerable<long>
{
public static readonly long[] Value=A225134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225134.Bytes);
public long this[int i]=>Value[i];

public static A225134Inst Instance=new A225134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225135
{
public static readonly long[] Value={ 25L,225L,289L,361L,529L,729L,2025L,2401L,2601L,2809L,3025L,4761L,5041L,5329L,5929L,7225L,7569L,11025L,11449L,11881L,13225L,15129L,19881L,20449L,21609L,22801L,23409L,24649L,25281L,26569L,27225L,29241L,29929L,31329L,32041L,32761L,34969L,36481L,39601L,47089L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225135Inst : IEnumerable<long>
{
public static readonly long[] Value=A225135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225135.Bytes);
public long this[int i]=>Value[i];

public static A225135Inst Instance=new A225135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225136
{
public static readonly long[] Value={ 88L,128L,188L,208L,278L,288L,308L,428L,448L,458L,508L,528L,638L,668L,688L,708L,758L,768L,788L,808L,812L,818L,820L,827L,828L,830L,842L,844L,845L,850L,852L,863L,866L,868L,870L,875L,876L,878L,888L,892L,898L,899L,928L,988L,998L,1028L,1058L,1108L,1148L,1168L,1178L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225136Inst : IEnumerable<long>
{
public static readonly long[] Value=A225136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225136.Bytes);
public long this[int i]=>Value[i];

public static A225136Inst Instance=new A225136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225137
{
public static readonly long[] Value={ 4L,25L,168L,1228L,9592L,78529L,664614L,5761262L,50847534L,455065829L,4118207819L,37608740621L,346064579205L,3204855540243L,29843276960952L,279224843911465L,2623449162422369L,24739367527714285L,234057667278287556L,2220873676061063755L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225137Inst : IEnumerable<long>
{
public static readonly long[] Value=A225137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225137.Bytes);
public long this[int i]=>Value[i];

public static A225137Inst Instance=new A225137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225138
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,-31L,-35L,193L,0L,-13318L,-153006L,-828603L,957634L,86210559L,1293461717L,13497122460L,107995231864L,586760026575L,-1942949L,-54073500144915L,-897247302459084L,-9393904607181950L,-54876701507521387L,379565456321952448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225138Inst : IEnumerable<long>
{
public static readonly long[] Value=A225138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225138.Bytes);
public long this[int i]=>Value[i];

public static A225138Inst Instance=new A225138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225139
{
public static readonly long[] Value={ 1234567891L,9101112131L,1516171819L,3343536373L,3940414243L,5758596061L,6566676869L,6676869707L,7778798081L,8384858687L,8990919293L,1021031041L,1081091101L,1091101111L,1311411511L,1141151161L,1411511611L,1171181191L,1181191201L,1221231241L,1361371381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225139Inst : IEnumerable<long>
{
public static readonly long[] Value=A225139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225139.Bytes);
public long this[int i]=>Value[i];

public static A225139Inst Instance=new A225139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225140
{
public static readonly long[] Value={ 3058681397L,9366074429L,4297660373L,9518560871L,3089343571L,3185847179L,3254335943L,4964175449L,5449177511L,7823223677L,3677140151L,7587498161L,2968890571L,4423024093L,2302409359L,2434336217L,5694535157L,8251380499L,7306380317L,4450349861L,6335655779L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225140Inst : IEnumerable<long>
{
public static readonly long[] Value=A225140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225140.Bytes);
public long this[int i]=>Value[i];

public static A225140Inst Instance=new A225140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225141
{
public static readonly long[] Value={ 7460575007L,2252257379L,6079057763L,5316126547L,7447839221L,5414146799L,2933188807L,8997407299L,7407299869L,2998696009L,9869600953L,2368469479L,6947930299L,7714456831L,1445683123L,6619147987L,8715043283L,7724849201L,8492011193L,1193531621L,2117195173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225141Inst : IEnumerable<long>
{
public static readonly long[] Value=A225141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225141.Bytes);
public long this[int i]=>Value[i];

public static A225141Inst Instance=new A225141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225142
{
public static readonly long[] Value={ 1406926327L,2632779269L,9269005729L,9045278351L,9706754921L,2196759527L,3835844717L,6468440141L,6844014103L,8216511287L,8763773147L,3473538331L,6273655727L,9618858059L,5430487121L,1300849327L,9325853203L,6189528329L,6802254197L,3054479927L,4479927817L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225142Inst : IEnumerable<long>
{
public static readonly long[] Value=A225142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225142.Bytes);
public long this[int i]=>Value[i];

public static A225142Inst Instance=new A225142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225143
{
public static readonly long[] Value={ 9499012067L,4990120679L,3040043189L,1896233719L,2337190679L,9628724687L,2510068721L,8721400547L,9681155879L,5587948903L,7564558769L,9632356367L,3235636709L,3200805163L,4445184059L,3876314227L,2276587939L,1979084773L,9420451591L,9120818099L,9345444877L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225143Inst : IEnumerable<long>
{
public static readonly long[] Value=A225143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225143.Bytes);
public long this[int i]=>Value[i];

public static A225143Inst Instance=new A225143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225144
{
public static readonly long[] Value={ 0L,3L,11L,18L,42L,45L,93L,84L,164L,135L,255L,198L,366L,273L,497L,360L,648L,459L,819L,570L,1010L,693L,1221L,828L,1452L,975L,1703L,1134L,1974L,1305L,2265L,1488L,2576L,1683L,2907L,1890L,3258L,2109L,3629L,2340L,4020L,2583L,4431L,2838L,4862L,3105L,5313L,3384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225144Inst : IEnumerable<long>
{
public static readonly long[] Value=A225144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225144.Bytes);
public long this[int i]=>Value[i];

public static A225144Inst Instance=new A225144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225145
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225145Inst : IEnumerable<long>
{
public static readonly long[] Value=A225145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225145.Bytes);
public long this[int i]=>Value[i];

public static A225145Inst Instance=new A225145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225146
{
public static readonly long[] Value={ 0L,1L,0L,7L,2L,7L,1L,0L,8L,0L,1L,0L,2L,6L,5L,1L,2L,2L,4L,5L,4L,1L,5L,6L,3L,6L,8L,5L,4L,8L,3L,0L,9L,4L,2L,2L,0L,0L,2L,9L,0L,5L,9L,8L,4L,4L,8L,3L,6L,4L,3L,3L,6L,5L,5L,0L,7L,6L,8L,0L,0L,3L,3L,4L,8L,1L,3L,4L,0L,0L,9L,3L,4L,8L,0L,0L,4L,2L,7L,6L,0L,4L,9L,3L,6L,6L,3L,8L,6L,1L,0L,9L,0L,4L,5L,2L,8L,0L,7L,4L,7L,4L,8L,8L,8L,0L,6L,5L,2L,2L,7L,4L,9L,4L,7L,0L,4L,4L,5L,6L,6L,7L,2L,9L,4L,7L,0L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225146Inst : IEnumerable<long>
{
public static readonly long[] Value=A225146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225146.Bytes);
public long this[int i]=>Value[i];

public static A225146Inst Instance=new A225146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225147
{
public static readonly BigInteger[] Value={ -1L,2L,5L,-46L,-205L,3362L,22265L,-515086L,-4544185L,135274562L,1491632525L,-54276473326L,-718181418565L,30884386347362L,476768795646785L,-23657073914466766L,-417370516232719345L,BigInteger.Parse("23471059057478981762"),BigInteger.Parse("465849831125196593045"),BigInteger.Parse("-29279357851856595135406") };
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
public class A225147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225147Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A225147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225147.Bytes);
public BigInteger this[int i]=>Value[i];

public static A225147Inst Instance=new A225147Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225148
{
public static readonly long[] Value={ 127L,1093L,2801L,19531L,22621L,30941L,55987L,88741L,131071L,245411L,292561L,346201L,524287L,637421L,732541L,797161L,837931L,2625641L,3500201L,3835261L,5229043L,6377551L,8108731L,12207031L,15018571L,16007041L,21700501L,25646167L,28792661L,30397351L,35615581L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225148Inst : IEnumerable<long>
{
public static readonly long[] Value=A225148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225148.Bytes);
public long this[int i]=>Value[i];

public static A225148Inst Instance=new A225148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225149
{
public static readonly BigInteger[] Value={ 1L,3L,45L,945L,14175L,93555L,638512875L,273648375L,44405668125L,194896477400625L,32157918771103125L,201717854109646875L,BigInteger.Parse("3028793579456347828125"),BigInteger.Parse("698952364489926421875"),BigInteger.Parse("80664808595725181953125"),BigInteger.Parse("5660878804669082674070015625") };
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
public class A225149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225149Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A225149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225149.Bytes);
public BigInteger this[int i]=>Value[i];

public static A225149Inst Instance=new A225149Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225150
{
public static readonly long[] Value={ 6L,21L,40L,52L,60L,90L,288L,301L,657L,697L,1333L,1909L,2041L,2176L,3856L,3901L,5536L,6517L,15025L,24601L,26977L,30105L,87360L,96361L,105301L,130153L,163201L,250321L,275833L,296341L,389593L,486877L,495529L,524961L,542413L,808861L,1005421L,1005649L,1055833L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225150Inst : IEnumerable<long>
{
public static readonly long[] Value=A225150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225150.Bytes);
public long this[int i]=>Value[i];

public static A225150Inst Instance=new A225150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225151
{
public static readonly long[] Value={ 12544L,15376L,19044L,20164L,27556L,28561L,42436L,45369L,45796L,75076L,81796L,86436L,87025L,89401L,98596L,114244L,116964L,123201L,124609L,125316L,126025L,127449L,128164L,131044L,139876L,141376L,150544L,174724L,175561L,184041L,188356L,190969L,191844L,207025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225151Inst : IEnumerable<long>
{
public static readonly long[] Value=A225151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225151.Bytes);
public long this[int i]=>Value[i];

public static A225151Inst Instance=new A225151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225152
{
public static readonly long[] Value={ 2L,0L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225152Inst : IEnumerable<long>
{
public static readonly long[] Value=A225152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225152.Bytes);
public long this[int i]=>Value[i];

public static A225152Inst Instance=new A225152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225153
{
public static readonly long[] Value={ 1L,2L,4L,5L,1L,1L,184L,1L,1L,8L,1L,7L,1L,12L,3L,1L,4L,2L,1L,2L,1L,125L,1L,2L,1L,1L,2L,2L,5L,12L,7L,1L,8L,2L,1L,6L,1L,3L,2L,1L,2L,1L,14L,1L,1L,1L,3L,1L,1L,6485L,1L,1L,1L,3L,1L,2L,1L,1L,1L,17L,1L,2L,3L,3L,3L,2L,7L,1L,2L,1L,8L,1L,9L,1L,1L,7L,1L,4L,9L,1L,1L,1L,1L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225153Inst : IEnumerable<long>
{
public static readonly long[] Value=A225153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225153.Bytes);
public long this[int i]=>Value[i];

public static A225153Inst Instance=new A225153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225154
{
public static readonly long[] Value={ 1L,2L,4L,7L,11L,14L,18L,23L,27L,32L,38L,43L,49L,55L,62L,68L,75L,82L,90L,97L,105L,113L,121L,130L,138L,147L,156L,166L,175L,185L,194L,204L,214L,225L,235L,246L,257L,267L,279L,290L,301L,313L,325L,336L,349L,361L,373L,385L,398L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225154Inst : IEnumerable<long>
{
public static readonly long[] Value=A225154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225154.Bytes);
public long this[int i]=>Value[i];

public static A225154Inst Instance=new A225154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225155
{
public static readonly long[] Value={ 5L,7L,7L,3L,5L,0L,4L,9L,7L,2L,5L,8L,4L,8L,5L,4L,5L,8L,5L,5L,0L,1L,1L,4L,8L,9L,2L,3L,7L,6L,8L,7L,0L,6L,1L,3L,9L,2L,3L,1L,2L,7L,6L,3L,0L,4L,2L,7L,2L,7L,5L,8L,0L,1L,6L,0L,9L,7L,0L,3L,3L,9L,6L,8L,1L,4L,5L,0L,3L,8L,3L,9L,4L,8L,3L,7L,8L,8L,2L,5L,4L,4L,0L,4L,0L,2L,1L,9L,9L,6L,0L,6L,4L,3L,1L,3L,2L,2L,8L,7L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A225155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225155Inst : IEnumerable<long>
{
public static readonly long[] Value=A225155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225155.Bytes);
public long this[int i]=>Value[i];

public static A225155Inst Instance=new A225155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A225156
{
public static readonly BigInteger[] Value={ 1L,2L,7L,67L,5623L,37772347L,1653794703916063L,BigInteger.Parse("3104205768420613437667191487267"),BigInteger.Parse("10767416908549848056705041797805600349527548164015760674541223") };
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
public class A225156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A225156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A225156Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A225156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A225156.Bytes);
public BigInteger this[int i]=>Value[i];

public static A225156Inst Instance=new A225156Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}