using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A020961
{
public static readonly long[] Value={ 4L,11L,16L,23L,31L,36L,44L,49L,57L,64L,69L,77L,85L,91L,98L,103L,111L,119L,124L,131L,137L,145L,153L,158L,165L,173L,178L,186L,191L,200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020961Inst : IEnumerable<long>
{
public static readonly long[] Value=A020961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020961.Bytes);
public long this[int i]=>Value[i];

public static A020961Inst Instance=new A020961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020960
{
public static readonly long[] Value={ 2L,6L,9L,13L,18L,21L,26L,29L,34L,38L,41L,46L,51L,55L,59L,62L,67L,72L,75L,79L,83L,88L,93L,96L,100L,105L,108L,113L,116L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020960Inst : IEnumerable<long>
{
public static readonly long[] Value=A020960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020960.Bytes);
public long this[int i]=>Value[i];

public static A020960Inst Instance=new A020960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020959
{
public static readonly long[] Value={ 1L,3L,5L,7L,10L,12L,15L,17L,20L,22L,24L,27L,30L,33L,35L,37L,40L,43L,45L,47L,50L,53L,56L,58L,60L,63L,65L,68L,70L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020959Inst : IEnumerable<long>
{
public static readonly long[] Value=A020959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020959.Bytes);
public long this[int i]=>Value[i];

public static A020959Inst Instance=new A020959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020958
{
public static readonly long[] Value={ 5L,9L,16L,28L,48L,81L,134L,221L,361L,589L,957L,1554L,2519L,4082L,6610L,10702L,17322L,28035L,45368L,73415L,118795L,192223L,311031L,503268L,814313L,1317596L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020958Inst : IEnumerable<long>
{
public static readonly long[] Value=A020958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020958.Bytes);
public long this[int i]=>Value[i];

public static A020958Inst Instance=new A020958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020957
{
public static readonly long[] Value={ 3L,6L,11L,19L,32L,54L,89L,147L,240L,392L,637L,1035L,1678L,2720L,4405L,7133L,11546L,18688L,30243L,48941L,79194L,128146L,207351L,335509L,542872L,878394L,1421279L,2299687L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020957Inst : IEnumerable<long>
{
public static readonly long[] Value=A020957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020957.Bytes);
public long this[int i]=>Value[i];

public static A020957Inst Instance=new A020957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020956
{
public static readonly long[] Value={ 1L,2L,4L,8L,14L,25L,42L,71L,117L,193L,315L,514L,835L,1356L,2198L,3562L,5768L,9339L,15116L,24465L,39591L,64067L,103669L,167748L,271429L,439190L,710632L,1149836L,1860482L,3010333L,4870830L,7881179L,12752025L,20633221L,33385263L,54018502L,87403783L,141422304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020956Inst : IEnumerable<long>
{
public static readonly long[] Value=A020956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020956.Bytes);
public long this[int i]=>Value[i];

public static A020956Inst Instance=new A020956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020955
{
public static readonly BigInteger[] Value={ 1L,1L,2L,81L,4194304L,1490116119384765625L,BigInteger.Parse("226267027688376192080197927193400943822503936"),BigInteger.Parse("258086210989349276047917817413172383631691140276099547911280598425927853437317437263620645695945672001") };
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
public class A020955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020955Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A020955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020955.Bytes);
public BigInteger this[int i]=>Value[i];

public static A020955Inst Instance=new A020955Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020954
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,10L,64L,18L,22L,20L,1024L,38L,36L,40L,70L,44L,42L,72L,132L,142L,76L,74L,88L,86L,82L,90L,138L,84L,156L,152L,150L,146L,162L,154L,186L,148L,280L,278L,168L,164L,322L,172L,180L,276L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020954Inst : IEnumerable<long>
{
public static readonly long[] Value=A020954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020954.Bytes);
public long this[int i]=>Value[i];

public static A020954Inst Instance=new A020954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020953
{
public static readonly long[] Value={ 0L,10L,20L,40L,42L,160L,82L,84L,162L,166L,164L,172L,170L,324L,328L,348L,332L,330L,338L,700L,652L,650L,664L,662L,658L,666L,1290L,660L,676L,684L,1302L,1298L,682L,1306L,1338L,1300L,1348L,1320L,1316L,1324L,1332L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020953Inst : IEnumerable<long>
{
public static readonly long[] Value=A020953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020953.Bytes);
public long this[int i]=>Value[i];

public static A020953Inst Instance=new A020953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020952
{
public static readonly long[] Value={ 2L,1L,3L,1L,4L,3L,4L,1L,5L,4L,7L,3L,7L,4L,5L,1L,6L,5L,9L,4L,11L,7L,10L,3L,10L,7L,11L,4L,9L,5L,6L,1L,7L,6L,11L,5L,14L,9L,13L,4L,15L,11L,18L,7L,17L,10L,13L,3L,13L,10L,17L,7L,18L,11L,15L,4L,13L,9L,14L,5L,11L,6L,7L,1L,8L,7L,13L,6L,17L,11L,16L,5L,19L,14L,23L,9L,22L,13L,17L,4L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020952Inst : IEnumerable<long>
{
public static readonly long[] Value=A020952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020952.Bytes);
public long this[int i]=>Value[i];

public static A020952Inst Instance=new A020952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020951
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,2L,1L,2L,1L,1L,0L,1L,1L,2L,1L,3L,2L,3L,1L,3L,2L,3L,1L,2L,1L,1L,0L,1L,1L,2L,1L,3L,2L,3L,1L,4L,3L,5L,2L,5L,3L,4L,1L,4L,3L,5L,2L,5L,3L,4L,1L,3L,2L,3L,1L,2L,1L,1L,0L,1L,1L,2L,1L,3L,2L,3L,1L,4L,3L,5L,2L,5L,3L,4L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020951Inst : IEnumerable<long>
{
public static readonly long[] Value=A020951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020951.Bytes);
public long this[int i]=>Value[i];

public static A020951Inst Instance=new A020951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020950
{
public static readonly long[] Value={ 0L,2L,4L,8L,10L,32L,18L,20L,34L,38L,36L,44L,42L,68L,72L,92L,76L,74L,82L,188L,84L,140L,138L,152L,150L,146L,154L,266L,148L,164L,172L,278L,274L,170L,282L,314L,276L,536L,324L,296L,292L,578L,300L,308L,364L,332L,298L,566L,330L,338L,552L,548L,562L,1274L,340L,584L,564L,614L,628L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020950Inst : IEnumerable<long>
{
public static readonly long[] Value=A020950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020950.Bytes);
public long this[int i]=>Value[i];

public static A020950Inst Instance=new A020950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020949
{
public static readonly long[] Value={ 1L,4L,11L,10L,20L,24L,22L,42L,89L,44L,46L,84L,100L,88L,96L,90L,92L,204L,170L,202L,192L,190L,178L,184L,180L,188L,186L,338L,382L,340L,366L,354L,358L,390L,360L,356L,376L,364L,674L,362L,378L,680L,372L,676L,684L,710L,812L,682L,752L,708L,810L,1346L,732L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020949Inst : IEnumerable<long>
{
public static readonly long[] Value=A020949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020949.Bytes);
public long this[int i]=>Value[i];

public static A020949Inst Instance=new A020949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020948
{
public static readonly long[] Value={ 1L,8L,16L,32L,34L,128L,66L,68L,130L,134L,132L,140L,138L,260L,264L,284L,268L,266L,274L,572L,276L,524L,522L,536L,534L,530L,538L,1034L,532L,548L,556L,1046L,1042L,554L,1050L,1082L,1044L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020948Inst : IEnumerable<long>
{
public static readonly long[] Value=A020948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020948.Bytes);
public long this[int i]=>Value[i];

public static A020948Inst Instance=new A020948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020947
{
public static readonly long[] Value={ 2L,6L,15L,14L,28L,61L,30L,58L,121L,60L,62L,116L,241L,120L,245L,122L,124L,469L,234L,806L,509L,254L,242L,248L,244L,252L,250L,466L,510L,468L,494L,482L,486L,977L,488L,484L,504L,492L,930L,490L,506L,936L,500L,932L,940L,966L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020947Inst : IEnumerable<long>
{
public static readonly long[] Value=A020947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020947.Bytes);
public long this[int i]=>Value[i];

public static A020947Inst Instance=new A020947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020946
{
public static readonly long[] Value={ 0L,1L,3L,5L,9L,11L,33L,19L,21L,35L,39L,37L,45L,43L,69L,73L,93L,77L,75L,83L,189L,85L,141L,139L,153L,151L,147L,155L,267L,149L,165L,173L,279L,275L,171L,283L,315L,277L,537L,325L,297L,293L,579L,301L,309L,365L,333L,299L,567L,331L,339L,553L,549L,563L,1275L,341L,585L,565L,615L,629L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020946Inst : IEnumerable<long>
{
public static readonly long[] Value=A020946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020946.Bytes);
public long this[int i]=>Value[i];

public static A020946Inst Instance=new A020946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020945
{
public static readonly long[] Value={ 1L,1L,0L,2L,2L,1L,1L,2L,1L,4L,3L,3L,0L,2L,2L,3L,1L,3L,2L,5L,3L,7L,4L,6L,2L,3L,1L,2L,1L,4L,3L,5L,2L,4L,2L,4L,2L,5L,3L,7L,4L,8L,4L,10L,6L,11L,5L,10L,5L,8L,3L,5L,2L,4L,2L,3L,1L,3L,2L,5L,3L,7L,4L,8L,4L,7L,3L,6L,3L,6L,3L,6L,3L,6L,3L,7L,4L,8L,4L,10L,6L,11L,5L,12L,7L,12L,5L,14L,9L,16L,7L,17L,10L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020945Inst : IEnumerable<long>
{
public static readonly long[] Value=A020945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020945.Bytes);
public long this[int i]=>Value[i];

public static A020945Inst Instance=new A020945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020944
{
public static readonly long[] Value={ -1L,1L,0L,1L,1L,0L,1L,1L,2L,1L,1L,0L,1L,1L,2L,1L,3L,2L,3L,1L,2L,1L,1L,0L,1L,1L,2L,1L,3L,2L,3L,1L,4L,3L,5L,2L,5L,3L,4L,1L,3L,2L,3L,1L,2L,1L,1L,0L,1L,1L,2L,1L,3L,2L,3L,1L,4L,3L,5L,2L,5L,3L,4L,1L,5L,4L,7L,3L,8L,5L,7L,2L,7L,5L,8L,3L,7L,4L,5L,1L,4L,3L,5L,2L,5L,3L,4L,1L,3L,2L,3L,1L,2L,1L,1L,0L,1L,1L,2L,1L,3L,2L,3L,1L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020944Inst : IEnumerable<long>
{
public static readonly long[] Value=A020944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020944.Bytes);
public long this[int i]=>Value[i];

public static A020944Inst Instance=new A020944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020943
{
public static readonly long[] Value={ 0L,1L,1L,1L,0L,2L,2L,2L,0L,1L,1L,2L,1L,4L,3L,4L,1L,2L,1L,1L,0L,2L,2L,3L,1L,3L,2L,5L,3L,7L,4L,7L,3L,5L,2L,3L,1L,3L,2L,2L,0L,1L,1L,2L,1L,4L,3L,5L,2L,4L,2L,4L,2L,5L,3L,7L,4L,8L,4L,10L,6L,11L,5L,11L,6L,10L,4L,8L,4L,7L,3L,5L,2L,4L,2L,4L,2L,5L,3L,4L,1L,2L,1L,1L,0L,2L,2L,3L,1L,3L,2L,5L,3L,7L,4L,8L,4L,7L,3L,6L,3L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020943Inst : IEnumerable<long>
{
public static readonly long[] Value=A020943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020943.Bytes);
public long this[int i]=>Value[i];

public static A020943Inst Instance=new A020943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020942
{
public static readonly long[] Value={ 1L,5L,7L,10L,14L,18L,20L,24L,26L,29L,33L,35L,38L,42L,46L,48L,51L,55L,59L,61L,65L,67L,70L,74L,78L,80L,84L,86L,89L,93L,95L,98L,102L,106L,108L,112L,114L,117L,121L,123L,126L,130L,134L,136L,139L,143L,147L,149L,153L,155L,158L,162L,164L,167L,171L,175L,177L,180L,184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020942Inst : IEnumerable<long>
{
public static readonly long[] Value=A020942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020942.Bytes);
public long this[int i]=>Value[i];

public static A020942Inst Instance=new A020942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020925
{
public static readonly long[] Value={ 1L,-26L,286L,-1716L,6006L,-12012L,12012L,-3432L,-858L,-572L,-572L,-728L,-1092L,-1848L,-3432L,-6864L,-14586L,-32604L,-76076L,-184184L,-460460L,-1184040L,-3121560L,-8414640L,-23140260L,-64792728L,-184410072L,-532740208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020925Inst : IEnumerable<long>
{
public static readonly long[] Value=A020925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020925.Bytes);
public long this[int i]=>Value[i];

public static A020925Inst Instance=new A020925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020924
{
public static readonly long[] Value={ 1L,26L,390L,4420L,41990L,352716L,2704156L,19315400L,130378950L,840219900L,5209363380L,31256180280L,182327718300L,1037865473400L,5782393351800L,31610416989840L,169905991320390L,899502306990300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020924Inst : IEnumerable<long>
{
public static readonly long[] Value=A020924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020924.Bytes);
public long this[int i]=>Value[i];

public static A020924Inst Instance=new A020924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020923
{
public static readonly long[] Value={ 1L,-22L,198L,-924L,2310L,-2772L,924L,264L,198L,220L,308L,504L,924L,1848L,3960L,8976L,21318L,52668L,134596L,354200L,956340L,2641320L,7443720L,21360240L,62300700L,184410072L,553230216L,1680180656L,5160554872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020923Inst : IEnumerable<long>
{
public static readonly long[] Value=A020923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020923.Bytes);
public long this[int i]=>Value[i];

public static A020923Inst Instance=new A020923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020922
{
public static readonly long[] Value={ 1L,22L,286L,2860L,24310L,184756L,1293292L,8498776L,53117350L,318704100L,1848483780L,10418726760L,57302997180L,308554600200L,1630931458200L,8480843582640L,43464323361030L,219878341708740L,1099391708543700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020922Inst : IEnumerable<long>
{
public static readonly long[] Value=A020922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020922.Bytes);
public long this[int i]=>Value[i];

public static A020922Inst Instance=new A020922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020921
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,1L,0L,2L,3L,1L,0L,2L,5L,4L,1L,0L,4L,10L,10L,5L,1L,0L,2L,11L,19L,15L,6L,1L,0L,6L,21L,35L,35L,21L,7L,1L,0L,4L,22L,52L,69L,56L,28L,8L,1L,0L,6L,33L,83L,126L,126L,84L,36L,9L,1L,0L,4L,34L,110L,205L,251L,210L,120L,45L,10L,1L,0L,10L,55L,165L,330L,462L,462L,330L,165L,55L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020921Inst : IEnumerable<long>
{
public static readonly long[] Value=A020921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020921.Bytes);
public long this[int i]=>Value[i];

public static A020921Inst Instance=new A020921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020920
{
public static readonly long[] Value={ 1L,18L,198L,1716L,12870L,87516L,554268L,3325608L,19122246L,106234700L,573667380L,3024791640L,15628090140L,79342611480L,396713057400L,1957117749840L,9540949030470L,46021048264620L,219878341708740L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020920Inst : IEnumerable<long>
{
public static readonly long[] Value=A020920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020920.Bytes);
public long this[int i]=>Value[i];

public static A020920Inst Instance=new A020920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020919
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,0L,4L,0L,8L,9L,1L,0L,2L,3L,0L,0L,0L,0L,6L,0L,0L,1L,1L,2L,0L,5L,7L,0L,0L,5L,0L,0L,1L,1L,0L,3L,0L,0L,0L,4L,0L,0L,0L,1L,1L,2L,3L,5L,0L,0L,0L,0L,8L,0L,1L,0L,2L,0L,0L,7L,0L,0L,6L,0L,9L,1L,1L,2L,3L,5L,7L,0L,4L,0L,0L,9L,1L,0L,2L,3L,0L,0L,0L,0L,0L,8L,0L,1L,1L,2L,3L,5L,7L,0L,4L,0L,8L,0L,1L,1L,2L,3L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020919Inst : IEnumerable<long>
{
public static readonly long[] Value=A020919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020919.Bytes);
public long this[int i]=>Value[i];

public static A020919Inst Instance=new A020919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020918
{
public static readonly long[] Value={ 1L,14L,126L,924L,6006L,36036L,204204L,1108536L,5819814L,29745716L,148728580L,730122120L,3528923580L,16830250920L,79342611480L,370265520240L,1712478031110L,7857252142740L,35794148650260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020918Inst : IEnumerable<long>
{
public static readonly long[] Value=A020918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020918.Bytes);
public long this[int i]=>Value[i];

public static A020918Inst Instance=new A020918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020917
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,5L,5L,5L,6L,6L,6L,9L,9L,9L,10L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020917Inst : IEnumerable<long>
{
public static readonly long[] Value=A020917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020917.Bytes);
public long this[int i]=>Value[i];

public static A020917Inst Instance=new A020917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020916
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,0L,0L,24L,96L,0L,0L,10000L,60736L,0L,0L,20511168L,168661760L,0L,0L,134002359296L,1398597049856L,0L,0L,2146989255011328L,27232259080056832L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020916Inst : IEnumerable<long>
{
public static readonly long[] Value=A020916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020916.Bytes);
public long this[int i]=>Value[i];

public static A020916Inst Instance=new A020916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020915
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,4L,5L,6L,6L,7L,7L,8L,9L,9L,10L,11L,11L,12L,12L,13L,14L,14L,15L,16L,16L,17L,18L,18L,19L,19L,20L,21L,21L,22L,23L,23L,24L,24L,25L,26L,26L,27L,28L,28L,29L,30L,30L,31L,31L,32L,33L,33L,34L,35L,35L,36L,36L,37L,38L,38L,39L,40L,40L,41L,42L,42L,43L,43L,44L,45L,45L,46L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020915Inst : IEnumerable<long>
{
public static readonly long[] Value=A020915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020915.Bytes);
public long this[int i]=>Value[i];

public static A020915Inst Instance=new A020915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020914
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,10L,12L,13L,15L,16L,18L,20L,21L,23L,24L,26L,27L,29L,31L,32L,34L,35L,37L,39L,40L,42L,43L,45L,46L,48L,50L,51L,53L,54L,56L,58L,59L,61L,62L,64L,65L,67L,69L,70L,72L,73L,75L,77L,78L,80L,81L,83L,85L,86L,88L,89L,91L,92L,94L,96L,97L,99L,100L,102L,104L,105L,107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020914Inst : IEnumerable<long>
{
public static readonly long[] Value=A020914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020914.Bytes);
public long this[int i]=>Value[i];

public static A020914Inst Instance=new A020914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020913
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,2L,3L,3L,3L,4L,4L,4L,4L,5L,5L,5L,6L,6L,6L,7L,7L,7L,7L,8L,8L,8L,9L,9L,9L,10L,10L,10L,10L,11L,11L,11L,12L,12L,12L,13L,13L,13L,13L,14L,14L,14L,15L,15L,15L,16L,16L,16L,16L,17L,17L,17L,18L,18L,18L,19L,19L,19L,19L,20L,20L,20L,21L,21L,21L,22L,22L,22L,22L,23L,23L,23L,24L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020913Inst : IEnumerable<long>
{
public static readonly long[] Value=A020913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020913.Bytes);
public long this[int i]=>Value[i];

public static A020913Inst Instance=new A020913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020912
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,3L,3L,3L,4L,4L,4L,5L,5L,5L,6L,6L,7L,7L,7L,8L,8L,8L,9L,9L,9L,10L,10L,10L,11L,11L,11L,12L,12L,12L,13L,13L,13L,14L,14L,14L,15L,15L,16L,16L,16L,17L,17L,17L,18L,18L,18L,19L,19L,19L,20L,20L,20L,21L,21L,21L,22L,22L,22L,23L,23L,24L,24L,24L,25L,25L,25L,26L,26L,26L,27L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020912Inst : IEnumerable<long>
{
public static readonly long[] Value=A020912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020912.Bytes);
public long this[int i]=>Value[i];

public static A020912Inst Instance=new A020912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020911
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,3L,3L,4L,4L,5L,5L,5L,6L,6L,7L,7L,8L,8L,9L,9L,9L,10L,10L,11L,11L,12L,12L,12L,13L,13L,14L,14L,15L,15L,16L,16L,16L,17L,17L,18L,18L,19L,19L,19L,20L,20L,21L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020911Inst : IEnumerable<long>
{
public static readonly long[] Value=A020911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020911.Bytes);
public long this[int i]=>Value[i];

public static A020911Inst Instance=new A020911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020910
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,3L,5L,6L,6L,8L,7L,6L,8L,8L,11L,9L,12L,10L,12L,13L,13L,14L,18L,13L,16L,16L,15L,19L,19L,18L,18L,15L,20L,16L,20L,25L,23L,24L,21L,22L,23L,23L,28L,28L,28L,24L,33L,28L,25L,36L,33L,34L,37L,39L,38L,30L,35L,31L,31L,33L,41L,45L,46L,39L,38L,47L,50L,47L,45L,43L,49L,51L,49L,46L,44L,50L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020910Inst : IEnumerable<long>
{
public static readonly long[] Value=A020910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020910.Bytes);
public long this[int i]=>Value[i];

public static A020910Inst Instance=new A020910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020909
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,4L,5L,6L,6L,7L,8L,8L,9L,10L,10L,11L,12L,13L,13L,14L,15L,15L,16L,17L,17L,18L,19L,19L,20L,21L,22L,22L,23L,24L,24L,25L,26L,26L,27L,28L,28L,29L,30L,31L,31L,32L,33L,33L,34L,35L,35L,36L,37L,38L,38L,39L,40L,40L,41L,42L,42L,43L,44L,44L,45L,46L,47L,47L,48L,49L,49L,50L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020909Inst : IEnumerable<long>
{
public static readonly long[] Value=A020909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020909.Bytes);
public long this[int i]=>Value[i];

public static A020909Inst Instance=new A020909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020908
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,3L,3L,3L,6L,3L,6L,6L,5L,6L,8L,7L,6L,7L,7L,8L,8L,11L,12L,13L,9L,9L,12L,6L,10L,14L,13L,14L,11L,15L,12L,16L,18L,17L,18L,18L,20L,18L,15L,17L,21L,19L,21L,20L,19L,18L,21L,20L,20L,19L,22L,19L,21L,24L,28L,25L,28L,28L,24L,25L,28L,29L,25L,29L,31L,30L,29L,27L,33L,31L,32L,31L,29L,32L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020908Inst : IEnumerable<long>
{
public static readonly long[] Value=A020908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020908.Bytes);
public long this[int i]=>Value[i];

public static A020908Inst Instance=new A020908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020907
{
public static readonly long[] Value={ 2L,5L,9L,11L,14L,17L,20L,24L,27L,32L,35L,37L,41L,44L,47L,51L,54L,56L,58L,62L,65L,68L,70L,74L,77L,81L,83L,87L,90L,92L,95L,97L,101L,104L,107L,110L,112L,116L,119L,123L,126L,128L,132L,135L,137L,140L,143L,145L,149L,152L,155L,158L,161L,163L,167L,170L,174L,177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020907Inst : IEnumerable<long>
{
public static readonly long[] Value=A020907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020907.Bytes);
public long this[int i]=>Value[i];

public static A020907Inst Instance=new A020907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020906
{
public static readonly long[] Value={ 1L,2L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020906Inst : IEnumerable<long>
{
public static readonly long[] Value=A020906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020906.Bytes);
public long this[int i]=>Value[i];

public static A020906Inst Instance=new A020906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020905
{
public static readonly long[] Value={ 14L,23L,76L,93L,241L,312L,373L,388L,504L,912L,956L,1117L,1528L,2088L,2064L,3564L,3744L,4092L,6022L,6816L,8664L,9664L,13281L,15632L,17364L,19199L,19717L,21183L,21913L,24630L,24720L,27429L,31954L,32517L,35881L,37784L,37669L,41947L,49704L,50868L,55439L,57313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020905Inst : IEnumerable<long>
{
public static readonly long[] Value=A020905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020905.Bytes);
public long this[int i]=>Value[i];

public static A020905Inst Instance=new A020905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020904
{
public static readonly long[] Value={ 2L,4L,7L,9L,11L,13L,16L,18L,22L,24L,27L,29L,31L,34L,37L,39L,42L,44L,46L,48L,51L,53L,56L,58L,61L,63L,65L,67L,69L,72L,74L,76L,79L,81L,84L,86L,88L,90L,92L,94L,97L,99L,101L,103L,106L,108L,111L,113L,115L,117L,121L,123L,126L,128L,130L,132L,135L,137L,139L,142L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020904Inst : IEnumerable<long>
{
public static readonly long[] Value=A020904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020904.Bytes);
public long this[int i]=>Value[i];

public static A020904Inst Instance=new A020904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020903
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020903Inst : IEnumerable<long>
{
public static readonly long[] Value=A020903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020903.Bytes);
public long this[int i]=>Value[i];

public static A020903Inst Instance=new A020903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020902
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,5L,7L,8L,11L,13L,16L,18L,22L,26L,30L,35L,39L,46L,51L,60L,67L,76L,84L,94L,105L,119L,133L,147L,162L,176L,196L,218L,240L,263L,286L,310L,340L,374L,409L,441L,476L,515L,559L,608L,662L,711L,762L,817L,883L,955L,1030L,1104L,1177L,1257L,1352L,1453L,1559L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020902Inst : IEnumerable<long>
{
public static readonly long[] Value=A020902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020902.Bytes);
public long this[int i]=>Value[i];

public static A020902Inst Instance=new A020902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020901
{
public static readonly long[] Value={ 3L,4L,6L,8L,11L,12L,15L,16L,19L,23L,24L,29L,30L,31L,34L,37L,40L,42L,46L,47L,47L,51L,53L,56L,61L,62L,63L,66L,66L,68L,75L,77L,80L,80L,86L,87L,91L,93L,95L,97L,99L,100L,105L,106L,107L,108L,115L,121L,123L,124L,125L,127L,128L,133L,136L,138L,139L,141L,145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020901Inst : IEnumerable<long>
{
public static readonly long[] Value=A020901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020901.Bytes);
public long this[int i]=>Value[i];

public static A020901Inst Instance=new A020901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020900
{
public static readonly long[] Value={ 2L,3L,4L,6L,8L,9L,11L,12L,14L,16L,18L,21L,22L,23L,24L,27L,30L,30L,32L,34L,34L,37L,38L,40L,44L,46L,46L,47L,47L,48L,54L,55L,58L,59L,62L,62L,65L,66L,67L,68L,71L,72L,75L,76L,77L,78L,82L,86L,87L,88L,90L,91L,92L,95L,97L,99L,99L,100L,101L,102L,103L,106L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020900Inst : IEnumerable<long>
{
public static readonly long[] Value=A020900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020900.Bytes);
public long this[int i]=>Value[i];

public static A020900Inst Instance=new A020900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020899
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,12L,13L,17L,19L,20L,21L,25L,27L,28L,30L,31L,32L,34L,38L,40L,41L,43L,44L,45L,48L,49L,50L,52L,55L,59L,61L,62L,64L,65L,66L,69L,70L,71L,73L,77L,78L,79L,81L,84L,88L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020899Inst : IEnumerable<long>
{
public static readonly long[] Value=A020899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020899.Bytes);
public long this[int i]=>Value[i];

public static A020899Inst Instance=new A020899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020898
{
public static readonly long[] Value={ 2L,6L,7L,9L,12L,13L,15L,17L,19L,20L,22L,26L,28L,30L,31L,33L,34L,35L,37L,42L,43L,49L,50L,51L,53L,58L,61L,62L,63L,65L,67L,68L,69L,70L,71L,75L,78L,79L,84L,85L,86L,87L,89L,90L,91L,92L,94L,97L,98L,103L,105L,106L,107L,110L,114L,115L,117L,123L,124L,126L,127L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020898Inst : IEnumerable<long>
{
public static readonly long[] Value=A020898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020898.Bytes);
public long this[int i]=>Value[i];

public static A020898Inst Instance=new A020898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020897
{
public static readonly long[] Value={ 2L,6L,7L,9L,12L,13L,15L,16L,17L,19L,20L,22L,26L,28L,30L,31L,33L,34L,35L,37L,42L,43L,48L,49L,50L,51L,53L,54L,56L,58L,61L,62L,63L,65L,67L,68L,69L,70L,71L,72L,75L,78L,79L,84L,85L,86L,87L,89L,90L,91L,92L,94L,96L,97L,98L,103L,104L,105L,106L,107L,110L,114L,115L,117L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020897Inst : IEnumerable<long>
{
public static readonly long[] Value=A020897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020897.Bytes);
public long this[int i]=>Value[i];

public static A020897Inst Instance=new A020897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020896
{
public static readonly long[] Value={ 2L,31L,33L,64L,211L,242L,244L,275L,486L,781L,992L,1023L,1025L,1056L,1267L,2048L,2101L,2882L,3093L,3124L,3126L,3157L,3368L,4149L,4651L,6250L,6752L,7533L,7744L,7775L,7777L,7808L,8019L,8800L,9031L,10901L,13682L,15552L,15783L,15961L,16564L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020896Inst : IEnumerable<long>
{
public static readonly long[] Value=A020896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020896.Bytes);
public long this[int i]=>Value[i];

public static A020896Inst Instance=new A020896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020895
{
public static readonly long[] Value={ 2L,7L,9L,19L,26L,28L,35L,37L,61L,63L,65L,91L,98L,117L,124L,126L,127L,133L,169L,215L,217L,218L,271L,279L,316L,331L,335L,341L,342L,370L,386L,387L,397L,407L,468L,469L,485L,511L,539L,547L,559L,602L,604L,631L,637L,657L,665L,721L,730L,737L,793L,817L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020895Inst : IEnumerable<long>
{
public static readonly long[] Value=A020895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020895.Bytes);
public long this[int i]=>Value[i];

public static A020895Inst Instance=new A020895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020894
{
public static readonly long[] Value={ 0L,2L,7L,9L,16L,19L,26L,28L,35L,37L,54L,56L,61L,63L,65L,72L,91L,98L,117L,124L,126L,127L,128L,133L,152L,169L,189L,208L,215L,217L,218L,224L,243L,250L,271L,279L,280L,296L,316L,331L,335L,341L,342L,344L,351L,370L,386L,387L,397L,407L,432L,448L,468L,469L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020894Inst : IEnumerable<long>
{
public static readonly long[] Value=A020894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020894.Bytes);
public long this[int i]=>Value[i];

public static A020894Inst Instance=new A020894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020877
{
public static readonly long[] Value={ 10L,34L,106L,344L,1102L,3546L,11394L,36628L,117730L,378426L,1216378L,3909832L,12567446L,40395794L,129844994L,417363332L,1341539194L,4312135922L,13860583626L,44552347608L,143205490526L,460308235562L,1479577849602L,4755836293844L,15286778495570L,49136593930954L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020877Inst : IEnumerable<long>
{
public static readonly long[] Value=A020877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020877.Bytes);
public long this[int i]=>Value[i];

public static A020877Inst Instance=new A020877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020876
{
public static readonly long[] Value={ 2L,5L,15L,50L,175L,625L,2250L,8125L,29375L,106250L,384375L,1390625L,5031250L,18203125L,65859375L,238281250L,862109375L,3119140625L,11285156250L,40830078125L,147724609375L,534472656250L,1933740234375L,6996337890625L,25312988281250L,91583251953125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020876Inst : IEnumerable<long>
{
public static readonly long[] Value=A020876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020876.Bytes);
public long this[int i]=>Value[i];

public static A020876Inst Instance=new A020876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020875
{
public static readonly long[] Value={ 0L,4L,12L,36L,72L,140L,228L,364L,528L,756L,1020L,1364L,1752L,2236L,2772L,3420L,4128L,4964L,5868L,6916L,8040L,9324L,10692L,12236L,13872L,15700L,17628L,19764L,22008L,24476L,27060L,29884L,32832L,36036L,39372L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020875Inst : IEnumerable<long>
{
public static readonly long[] Value=A020875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020875.Bytes);
public long this[int i]=>Value[i];

public static A020875Inst Instance=new A020875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020874
{
public static readonly long[] Value={ 0L,3L,30L,135L,452L,1295L,3378L,8295L,19560L,44847L,100790L,223223L,488940L,1061775L,2289882L,4910535L,10480208L,22275695L,47178270L,99605847L,209704980L,440390223L,922733570L,1929364775L,4026514872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020874Inst : IEnumerable<long>
{
public static readonly long[] Value=A020874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020874.Bytes);
public long this[int i]=>Value[i];

public static A020874Inst Instance=new A020874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020873
{
public static readonly long[] Value={ 2L,3L,7L,15L,29L,53L,95L,171L,313L,585L,1115L,2159L,4229L,8349L,16567L,32979L,65777L,131345L,262451L,524631L,1048957L,2097573L,4194767L,8389115L,16777769L,33555033L,67109515L,134218431L,268436213L,536871725L,1073742695L,2147484579L,4294968289L,8589935649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020873Inst : IEnumerable<long>
{
public static readonly long[] Value=A020873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020873.Bytes);
public long this[int i]=>Value[i];

public static A020873Inst Instance=new A020873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020872
{
public static readonly long[] Value={ 34L,241L,1582L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020872Inst : IEnumerable<long>
{
public static readonly long[] Value=A020872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020872.Bytes);
public long this[int i]=>Value[i];

public static A020872Inst Instance=new A020872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020871
{
public static readonly long[] Value={ 0L,3L,16L,81L,392L,1815L,8112L,35301L,150544L,632043L,2620880L,10759353L,43804824L,177105279L,711809392L,2846259405L,11330543648L,44929049811L,177540878736L,699402223137L,2747583822760L,10766828545767L,42095796462896L,164244726238389L,639620518118448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020871Inst : IEnumerable<long>
{
public static readonly long[] Value=A020871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020871.Bytes);
public long this[int i]=>Value[i];

public static A020871Inst Instance=new A020871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020870
{
public static readonly long[] Value={ 38L,205L,1092L,5719L,29486L,150049L,755432L,3769771L,18673250L,91917621L,450025692L,2193031871L,10643233110L,51467250249L,248079277008L,1192335047635L,5715823515722L,27336235315037L,130457855039172L,621374856379623L,2954332179898174L,14023263123496049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020870Inst : IEnumerable<long>
{
public static readonly long[] Value=A020870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020870.Bytes);
public long this[int i]=>Value[i];

public static A020870Inst Instance=new A020870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020869
{
public static readonly long[] Value={ 34L,222L,1280L,6955L,36378L,185178L,923696L,4535991L,22000490L,105640634L,503067648L,2379006071L,11183747330L,52306745310L,243553038816L,1129612848795L,5221079904978L,24057393297286L,110543216068160L,506673892786803L,2317069421129034L,10574292843014802L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020869Inst : IEnumerable<long>
{
public static readonly long[] Value=A020869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020869.Bytes);
public long this[int i]=>Value[i];

public static A020869Inst Instance=new A020869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020868
{
public static readonly long[] Value={ 60L,397L,2464L,14809L,87000L,502261L,2859968L,16105801L,89879304L,497792981L,2739398160L,14992582713L,81664018712L,442972209365L,2394012778496L,12896089147849L,69266060508360L,371057114908533L,1983022462947472L,10574870140601337L,56281372512713240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020868Inst : IEnumerable<long>
{
public static readonly long[] Value=A020868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020868.Bytes);
public long this[int i]=>Value[i];

public static A020868Inst Instance=new A020868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020867
{
public static readonly long[] Value={ 19L,132L,851L,5298L,32068L,190711L,1120947L,6537903L,37935984L,219360837L,1265462984L,7288685420L,41935203469L,241094585397L,1385405494499L,7958227879396L,45703889854759L,262433722095008L,1506738689157576L,8650141792937245L,49657618346464719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020867Inst : IEnumerable<long>
{
public static readonly long[] Value=A020867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020867.Bytes);
public long this[int i]=>Value[i];

public static A020867Inst Instance=new A020867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020866
{
public static readonly long[] Value={ 41L,265L,1697L,10897L,69941L,448945L,2881697L,18497137L,118730021L,762108145L,4891844657L,31399932337L,201550911701L,1293721577905L,8304182337857L,53303156937457L,342144045482501L,2196165379031665L,14096818096762577L,90485116626705457L,580808823292457141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020866Inst : IEnumerable<long>
{
public static readonly long[] Value=A020866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020866.Bytes);
public long this[int i]=>Value[i];

public static A020866Inst Instance=new A020866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020865
{
public static readonly long[] Value={ 0L,4L,38L,328L,2686L,21224L,163982L,1249784L,9447102L,71056840L,532854638L,3988597144L,29822927134L,222836912744L,1664351910350L,12427793513528L,92784673372542L,692656225953544L,5170521713987630L,38595421782328024L,288089831076277726L,2150375933904641960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020865Inst : IEnumerable<long>
{
public static readonly long[] Value=A020865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020865.Bytes);
public long this[int i]=>Value[i];

public static A020865Inst Instance=new A020865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020864
{
public static readonly long[] Value={ 3L,5L,8L,4L,9L,6L,2L,5L,0L,0L,7L,2L,1L,1L,5L,6L,1L,8L,1L,4L,5L,3L,7L,3L,8L,9L,4L,3L,9L,4L,7L,8L,1L,6L,5L,0L,8L,7L,5L,9L,8L,1L,4L,4L,0L,7L,6L,9L,2L,4L,8L,1L,0L,6L,0L,4L,5L,5L,7L,5L,2L,6L,5L,4L,5L,4L,1L,0L,9L,8L,2L,2L,7L,7L,9L,4L,3L,5L,8L,5L,6L,2L,5L,2L,2L,2L,8L,0L,4L,7L,4L,9L,1L,8L,0L,8L,8L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020864Inst : IEnumerable<long>
{
public static readonly long[] Value=A020864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020864.Bytes);
public long this[int i]=>Value[i];

public static A020864Inst Instance=new A020864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020863
{
public static readonly long[] Value={ 3L,4L,5L,9L,4L,3L,1L,6L,1L,8L,6L,3L,7L,2L,9L,7L,2L,5L,6L,1L,9L,9L,3L,6L,3L,0L,4L,6L,7L,2L,5L,7L,9L,2L,9L,5L,8L,7L,0L,3L,2L,3L,1L,5L,2L,5L,6L,8L,1L,7L,6L,8L,0L,7L,1L,3L,1L,2L,8L,0L,1L,6L,4L,5L,7L,2L,6L,3L,3L,0L,6L,1L,9L,7L,2L,0L,0L,1L,8L,3L,5L,2L,7L,0L,9L,4L,9L,1L,2L,9L,9L,2L,8L,6L,9L,0L,0L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020863Inst : IEnumerable<long>
{
public static readonly long[] Value=A020863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020863.Bytes);
public long this[int i]=>Value[i];

public static A020863Inst Instance=new A020863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020862
{
public static readonly long[] Value={ 3L,3L,2L,1L,9L,2L,8L,0L,9L,4L,8L,8L,7L,3L,6L,2L,3L,4L,7L,8L,7L,0L,3L,1L,9L,4L,2L,9L,4L,8L,9L,3L,9L,0L,1L,7L,5L,8L,6L,4L,8L,3L,1L,3L,9L,3L,0L,2L,4L,5L,8L,0L,6L,1L,2L,0L,5L,4L,7L,5L,6L,3L,9L,5L,8L,1L,5L,9L,3L,4L,7L,7L,6L,6L,0L,8L,6L,2L,5L,2L,1L,5L,8L,5L,0L,1L,3L,9L,7L,4L,3L,3L,5L,9L,3L,7L,0L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020862Inst : IEnumerable<long>
{
public static readonly long[] Value=A020862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020862.Bytes);
public long this[int i]=>Value[i];

public static A020862Inst Instance=new A020862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020861
{
public static readonly long[] Value={ 3L,1L,6L,9L,9L,2L,5L,0L,0L,1L,4L,4L,2L,3L,1L,2L,3L,6L,2L,9L,0L,7L,4L,7L,7L,8L,8L,7L,8L,9L,5L,6L,3L,3L,0L,1L,7L,5L,1L,9L,6L,2L,8L,8L,1L,5L,3L,8L,4L,9L,6L,2L,1L,2L,0L,9L,1L,1L,5L,0L,5L,3L,0L,9L,0L,8L,2L,1L,9L,6L,4L,5L,5L,5L,8L,8L,7L,1L,7L,1L,2L,5L,0L,4L,4L,5L,6L,0L,9L,4L,9L,8L,3L,6L,1L,7L,6L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020861Inst : IEnumerable<long>
{
public static readonly long[] Value=A020861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020861.Bytes);
public long this[int i]=>Value[i];

public static A020861Inst Instance=new A020861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020860
{
public static readonly long[] Value={ 2L,8L,0L,7L,3L,5L,4L,9L,2L,2L,0L,5L,7L,6L,0L,4L,1L,0L,7L,4L,4L,1L,9L,6L,9L,3L,1L,7L,2L,3L,1L,8L,3L,0L,8L,0L,8L,6L,4L,1L,0L,2L,6L,6L,2L,5L,9L,6L,6L,1L,4L,0L,7L,8L,3L,6L,7L,7L,2L,9L,1L,7L,2L,4L,0L,7L,0L,3L,2L,0L,8L,4L,8L,8L,6L,2L,1L,9L,2L,9L,8L,6L,4L,9L,7L,8L,6L,0L,9L,9L,9L,1L,7L,0L,2L,1L,0L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020860Inst : IEnumerable<long>
{
public static readonly long[] Value=A020860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020860.Bytes);
public long this[int i]=>Value[i];

public static A020860Inst Instance=new A020860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020859
{
public static readonly long[] Value={ 2L,5L,8L,4L,9L,6L,2L,5L,0L,0L,7L,2L,1L,1L,5L,6L,1L,8L,1L,4L,5L,3L,7L,3L,8L,9L,4L,3L,9L,4L,7L,8L,1L,6L,5L,0L,8L,7L,5L,9L,8L,1L,4L,4L,0L,7L,6L,9L,2L,4L,8L,1L,0L,6L,0L,4L,5L,5L,7L,5L,2L,6L,5L,4L,5L,4L,1L,0L,9L,8L,2L,2L,7L,7L,9L,4L,3L,5L,8L,5L,6L,2L,5L,2L,2L,2L,8L,0L,4L,7L,4L,9L,1L,8L,0L,8L,8L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020859Inst : IEnumerable<long>
{
public static readonly long[] Value=A020859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020859.Bytes);
public long this[int i]=>Value[i];

public static A020859Inst Instance=new A020859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020858
{
public static readonly long[] Value={ 2L,3L,2L,1L,9L,2L,8L,0L,9L,4L,8L,8L,7L,3L,6L,2L,3L,4L,7L,8L,7L,0L,3L,1L,9L,4L,2L,9L,4L,8L,9L,3L,9L,0L,1L,7L,5L,8L,6L,4L,8L,3L,1L,3L,9L,3L,0L,2L,4L,5L,8L,0L,6L,1L,2L,0L,5L,4L,7L,5L,6L,3L,9L,5L,8L,1L,5L,9L,3L,4L,7L,7L,6L,6L,0L,8L,6L,2L,5L,2L,1L,5L,8L,5L,0L,1L,3L,9L,7L,4L,3L,3L,5L,9L,3L,7L,0L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020858Inst : IEnumerable<long>
{
public static readonly long[] Value=A020858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020858.Bytes);
public long this[int i]=>Value[i];

public static A020858Inst Instance=new A020858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020857
{
public static readonly long[] Value={ 1L,5L,8L,4L,9L,6L,2L,5L,0L,0L,7L,2L,1L,1L,5L,6L,1L,8L,1L,4L,5L,3L,7L,3L,8L,9L,4L,3L,9L,4L,7L,8L,1L,6L,5L,0L,8L,7L,5L,9L,8L,1L,4L,4L,0L,7L,6L,9L,2L,4L,8L,1L,0L,6L,0L,4L,5L,5L,7L,5L,2L,6L,5L,4L,5L,4L,1L,0L,9L,8L,2L,2L,7L,7L,9L,4L,3L,5L,8L,5L,6L,2L,5L,2L,2L,2L,8L,0L,4L,7L,4L,9L,1L,8L,0L,8L,8L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020857Inst : IEnumerable<long>
{
public static readonly long[] Value=A020857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020857.Bytes);
public long this[int i]=>Value[i];

public static A020857Inst Instance=new A020857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020856
{
public static readonly long[] Value={ 1L,0L,0L,5L,0L,3L,7L,8L,1L,5L,2L,5L,9L,2L,1L,2L,0L,7L,5L,4L,8L,9L,3L,7L,3L,5L,5L,6L,5L,6L,6L,8L,7L,4L,7L,5L,2L,7L,0L,5L,1L,7L,8L,3L,4L,7L,1L,4L,8L,2L,8L,8L,9L,6L,8L,8L,0L,5L,6L,6L,1L,2L,5L,6L,3L,9L,8L,9L,3L,4L,7L,4L,0L,1L,8L,4L,5L,5L,8L,7L,4L,1L,4L,2L,6L,9L,2L,2L,2L,4L,2L,1L,6L,0L,0L,8L,8L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020856Inst : IEnumerable<long>
{
public static readonly long[] Value=A020856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020856.Bytes);
public long this[int i]=>Value[i];

public static A020856Inst Instance=new A020856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020855
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,5L,2L,5L,4L,4L,5L,5L,2L,2L,1L,0L,7L,4L,9L,1L,4L,4L,0L,6L,3L,3L,7L,4L,4L,3L,5L,4L,9L,8L,6L,2L,7L,5L,4L,9L,7L,6L,5L,6L,2L,5L,2L,6L,9L,2L,4L,8L,6L,2L,3L,6L,9L,7L,6L,2L,8L,3L,8L,4L,2L,7L,9L,0L,9L,4L,6L,2L,7L,4L,7L,2L,9L,3L,3L,5L,9L,9L,1L,7L,8L,8L,4L,8L,2L,3L,8L,8L,0L,5L,4L,5L,8L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020855Inst : IEnumerable<long>
{
public static readonly long[] Value=A020855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020855.Bytes);
public long this[int i]=>Value[i];

public static A020855Inst Instance=new A020855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020854
{
public static readonly long[] Value={ 1L,0L,1L,5L,3L,4L,6L,1L,6L,5L,1L,3L,3L,6L,1L,9L,0L,4L,3L,4L,7L,8L,9L,9L,0L,8L,6L,7L,5L,1L,7L,2L,8L,0L,8L,7L,4L,4L,0L,1L,6L,6L,3L,5L,3L,4L,7L,8L,7L,9L,1L,3L,8L,3L,2L,1L,3L,6L,4L,0L,7L,6L,8L,3L,4L,8L,8L,2L,9L,2L,8L,4L,3L,6L,8L,1L,2L,0L,3L,9L,8L,2L,4L,8L,3L,8L,3L,5L,1L,3L,2L,3L,8L,3L,0L,3L,3L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020854Inst : IEnumerable<long>
{
public static readonly long[] Value=A020854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020854.Bytes);
public long this[int i]=>Value[i];

public static A020854Inst Instance=new A020854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020853
{
public static readonly long[] Value={ 1L,0L,2L,0L,6L,2L,0L,7L,2L,6L,1L,5L,9L,6L,5L,7L,5L,4L,0L,9L,1L,5L,5L,3L,5L,0L,3L,1L,1L,2L,7L,4L,5L,4L,7L,4L,6L,6L,5L,2L,4L,7L,8L,1L,1L,6L,9L,4L,0L,2L,7L,9L,2L,2L,0L,1L,8L,0L,2L,8L,8L,5L,6L,9L,6L,8L,7L,9L,0L,0L,1L,5L,7L,2L,7L,3L,8L,8L,1L,2L,6L,1L,0L,5L,8L,2L,7L,4L,7L,6L,3L,7L,9L,3L,6L,0L,0L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020853Inst : IEnumerable<long>
{
public static readonly long[] Value=A020853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020853.Bytes);
public long this[int i]=>Value[i];

public static A020853Inst Instance=new A020853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020852
{
public static readonly long[] Value={ 1L,0L,2L,5L,9L,7L,8L,3L,5L,2L,0L,8L,5L,1L,5L,4L,0L,9L,5L,4L,5L,6L,6L,7L,5L,0L,7L,3L,6L,7L,3L,6L,4L,2L,1L,3L,6L,7L,6L,3L,4L,2L,9L,8L,8L,4L,2L,4L,6L,0L,5L,1L,6L,8L,7L,5L,7L,8L,0L,7L,8L,9L,4L,7L,9L,7L,0L,5L,3L,4L,9L,2L,3L,4L,1L,6L,8L,6L,8L,3L,5L,3L,3L,5L,2L,4L,9L,6L,0L,1L,0L,1L,0L,9L,2L,7L,0L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020852Inst : IEnumerable<long>
{
public static readonly long[] Value=A020852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020852.Bytes);
public long this[int i]=>Value[i];

public static A020852Inst Instance=new A020852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020851
{
public static readonly long[] Value={ 1L,0L,3L,1L,4L,2L,1L,2L,4L,6L,2L,5L,8L,7L,9L,3L,4L,0L,7L,2L,4L,9L,8L,8L,0L,9L,7L,3L,4L,9L,4L,1L,8L,2L,2L,7L,5L,9L,2L,0L,4L,4L,1L,5L,9L,4L,4L,6L,3L,2L,6L,3L,7L,8L,6L,2L,2L,7L,6L,2L,9L,5L,1L,9L,8L,1L,2L,0L,2L,5L,5L,1L,7L,8L,2L,6L,9L,4L,6L,8L,8L,6L,0L,0L,8L,8L,5L,7L,3L,0L,6L,2L,2L,0L,9L,4L,8L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020851Inst : IEnumerable<long>
{
public static readonly long[] Value=A020851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020851.Bytes);
public long this[int i]=>Value[i];

public static A020851Inst Instance=new A020851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020850
{
public static readonly long[] Value={ 1L,0L,3L,6L,9L,5L,1L,6L,9L,4L,7L,3L,0L,4L,2L,5L,2L,6L,8L,3L,6L,1L,2L,9L,3L,6L,6L,1L,0L,1L,4L,2L,6L,4L,8L,5L,8L,4L,8L,4L,6L,1L,3L,3L,0L,0L,3L,2L,9L,3L,8L,1L,9L,7L,9L,2L,7L,9L,5L,8L,8L,9L,1L,2L,6L,5L,9L,2L,7L,8L,1L,0L,9L,5L,3L,4L,2L,6L,3L,4L,1L,1L,0L,6L,4L,5L,2L,2L,0L,1L,1L,7L,5L,2L,0L,0L,0L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020850Inst : IEnumerable<long>
{
public static readonly long[] Value=A020850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020850.Bytes);
public long this[int i]=>Value[i];

public static A020850Inst Instance=new A020850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020849
{
public static readonly long[] Value={ 1L,0L,4L,2L,5L,7L,2L,0L,7L,0L,2L,8L,5L,3L,7L,3L,8L,1L,3L,3L,9L,0L,7L,4L,7L,4L,0L,5L,2L,5L,2L,7L,5L,9L,5L,4L,7L,8L,2L,5L,3L,7L,1L,0L,9L,6L,0L,6L,6L,1L,1L,5L,0L,7L,5L,3L,2L,2L,8L,9L,3L,2L,8L,5L,7L,4L,9L,6L,2L,1L,1L,3L,8L,2L,4L,0L,7L,5L,3L,0L,6L,1L,4L,1L,1L,3L,4L,5L,9L,6L,6L,6L,1L,6L,7L,2L,1L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020849Inst : IEnumerable<long>
{
public static readonly long[] Value=A020849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020849.Bytes);
public long this[int i]=>Value[i];

public static A020849Inst Instance=new A020849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020848
{
public static readonly long[] Value={ 1L,0L,4L,8L,2L,8L,4L,8L,3L,6L,7L,2L,1L,9L,1L,8L,2L,9L,5L,7L,7L,2L,1L,1L,1L,6L,3L,2L,9L,9L,2L,5L,5L,6L,6L,3L,7L,6L,4L,2L,4L,4L,3L,3L,2L,4L,4L,5L,1L,1L,4L,9L,1L,8L,0L,1L,1L,8L,8L,4L,8L,1L,9L,0L,0L,1L,1L,3L,8L,7L,4L,2L,0L,1L,1L,6L,0L,9L,9L,6L,9L,4L,3L,1L,6L,2L,4L,4L,1L,4L,9L,9L,4L,4L,0L,9L,0L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020848Inst : IEnumerable<long>
{
public static readonly long[] Value=A020848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020848.Bytes);
public long this[int i]=>Value[i];

public static A020848Inst Instance=new A020848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020847
{
public static readonly long[] Value={ 1L,0L,5L,4L,0L,9L,2L,5L,5L,3L,3L,8L,9L,4L,5L,9L,7L,7L,7L,3L,3L,2L,9L,6L,4L,5L,1L,4L,8L,1L,0L,9L,0L,6L,1L,7L,7L,9L,0L,6L,5L,1L,8L,3L,7L,9L,7L,7L,5L,0L,7L,2L,2L,7L,5L,6L,1L,9L,1L,6L,8L,2L,8L,4L,2L,6L,4L,1L,9L,8L,1L,4L,6L,2L,1L,3L,0L,7L,9L,4L,0L,7L,1L,1L,4L,7L,4L,9L,3L,6L,9L,4L,5L,9L,7L,6L,6L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020847Inst : IEnumerable<long>
{
public static readonly long[] Value=A020847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020847.Bytes);
public long this[int i]=>Value[i];

public static A020847Inst Instance=new A020847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020846
{
public static readonly long[] Value={ 1L,0L,5L,9L,9L,9L,7L,8L,8L,0L,0L,0L,6L,3L,5L,9L,9L,7L,8L,8L,0L,0L,0L,7L,4L,1L,9L,9L,7L,3L,2L,8L,8L,0L,9L,7L,9L,4L,3L,6L,3L,6L,2L,0L,9L,3L,6L,4L,2L,1L,4L,8L,4L,6L,2L,9L,9L,5L,8L,4L,0L,6L,1L,2L,2L,4L,4L,9L,4L,6L,3L,9L,4L,3L,3L,5L,4L,0L,6L,5L,2L,3L,4L,3L,1L,5L,7L,6L,0L,6L,5L,9L,4L,2L,7L,3L,9L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020846Inst : IEnumerable<long>
{
public static readonly long[] Value=A020846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020846.Bytes);
public long this[int i]=>Value[i];

public static A020846Inst Instance=new A020846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020829
{
public static readonly long[] Value={ 1L,1L,7L,8L,5L,1L,1L,3L,0L,1L,9L,7L,7L,5L,7L,9L,2L,0L,7L,3L,3L,4L,7L,4L,0L,6L,0L,3L,5L,0L,8L,0L,8L,1L,7L,3L,2L,1L,4L,1L,3L,9L,3L,2L,2L,9L,4L,8L,0L,7L,9L,0L,0L,6L,0L,9L,8L,0L,5L,6L,6L,4L,4L,8L,3L,2L,5L,6L,1L,0L,3L,9L,8L,7L,1L,8L,4L,2L,2L,5L,3L,2L,3L,7L,5L,3L,2L,2L,9L,4L,5L,2L,7L,3L,0L,3L,4L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020829Inst : IEnumerable<long>
{
public static readonly long[] Value=A020829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020829.Bytes);
public long this[int i]=>Value[i];

public static A020829Inst Instance=new A020829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020828
{
public static readonly long[] Value={ 1L,1L,8L,6L,7L,8L,1L,6L,5L,8L,1L,9L,3L,8L,5L,3L,3L,2L,8L,2L,5L,8L,3L,2L,9L,5L,6L,4L,2L,5L,3L,9L,0L,6L,4L,8L,3L,3L,2L,5L,0L,7L,0L,7L,6L,0L,7L,8L,3L,2L,0L,4L,2L,2L,7L,2L,7L,7L,1L,5L,6L,4L,9L,7L,0L,8L,8L,3L,4L,1L,6L,2L,0L,1L,0L,6L,3L,6L,6L,6L,2L,7L,5L,3L,3L,1L,9L,6L,2L,7L,2L,8L,5L,9L,0L,0L,9L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020828Inst : IEnumerable<long>
{
public static readonly long[] Value=A020828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020828.Bytes);
public long this[int i]=>Value[i];

public static A020828Inst Instance=new A020828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020827
{
public static readonly long[] Value={ 1L,1L,9L,5L,2L,2L,8L,6L,0L,9L,3L,3L,4L,3L,9L,3L,6L,3L,9L,9L,6L,8L,8L,1L,7L,1L,7L,9L,6L,9L,3L,1L,2L,4L,9L,8L,4L,8L,4L,6L,8L,7L,9L,0L,9L,8L,9L,9L,8L,1L,0L,3L,1L,4L,2L,5L,8L,7L,4L,1L,6L,4L,9L,0L,1L,1L,4L,8L,8L,3L,9L,6L,0L,8L,4L,9L,0L,2L,4L,2L,9L,9L,7L,5L,8L,3L,0L,6L,7L,3L,1L,3L,7L,8L,5L,0L,2L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020827Inst : IEnumerable<long>
{
public static readonly long[] Value=A020827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020827.Bytes);
public long this[int i]=>Value[i];

public static A020827Inst Instance=new A020827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020826
{
public static readonly long[] Value={ 1L,2L,0L,3L,8L,5L,8L,5L,3L,0L,8L,5L,7L,6L,9L,2L,0L,0L,7L,6L,2L,0L,9L,0L,7L,6L,4L,4L,1L,8L,9L,4L,9L,1L,5L,9L,5L,6L,8L,5L,8L,2L,8L,1L,5L,2L,0L,2L,2L,5L,5L,8L,8L,0L,8L,6L,1L,3L,3L,6L,0L,6L,3L,3L,1L,9L,3L,8L,5L,2L,9L,0L,3L,3L,9L,4L,6L,5L,9L,6L,4L,8L,3L,8L,6L,5L,7L,9L,4L,9L,3L,9L,4L,6L,7L,1L,8L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020826Inst : IEnumerable<long>
{
public static readonly long[] Value=A020826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020826.Bytes);
public long this[int i]=>Value[i];

public static A020826Inst Instance=new A020826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020825
{
public static readonly long[] Value={ 1L,2L,1L,2L,6L,7L,8L,1L,2L,5L,1L,8L,1L,6L,6L,4L,8L,6L,7L,5L,9L,4L,5L,3L,2L,3L,1L,0L,5L,8L,0L,6L,1L,0L,8L,8L,9L,7L,4L,9L,1L,7L,6L,2L,4L,2L,7L,5L,6L,9L,4L,7L,1L,8L,6L,5L,8L,7L,8L,3L,3L,4L,0L,3L,8L,5L,1L,4L,5L,7L,1L,6L,0L,6L,8L,7L,5L,3L,5L,7L,6L,2L,8L,1L,9L,9L,5L,9L,8L,9L,7L,2L,9L,7L,2L,6L,0L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020825Inst : IEnumerable<long>
{
public static readonly long[] Value=A020825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020825.Bytes);
public long this[int i]=>Value[i];

public static A020825Inst Instance=new A020825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020824
{
public static readonly long[] Value={ 1L,2L,2L,1L,6L,9L,4L,4L,4L,3L,5L,6L,3L,0L,5L,2L,2L,3L,4L,3L,2L,1L,4L,4L,8L,3L,1L,7L,1L,2L,4L,4L,6L,7L,0L,8L,3L,4L,1L,4L,9L,9L,8L,0L,3L,2L,1L,6L,3L,8L,8L,6L,5L,6L,1L,6L,5L,1L,7L,4L,8L,5L,3L,7L,7L,1L,9L,9L,5L,0L,3L,9L,0L,2L,1L,8L,0L,7L,4L,3L,2L,0L,2L,0L,0L,5L,8L,5L,7L,7L,1L,8L,8L,6L,2L,4L,9L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020824Inst : IEnumerable<long>
{
public static readonly long[] Value=A020824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020824.Bytes);
public long this[int i]=>Value[i];

public static A020824Inst Instance=new A020824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020823
{
public static readonly long[] Value={ 1L,2L,3L,0L,9L,1L,4L,9L,0L,9L,7L,9L,3L,3L,2L,7L,3L,2L,7L,3L,4L,2L,4L,0L,6L,6L,0L,1L,2L,5L,2L,4L,3L,0L,3L,5L,5L,8L,3L,3L,9L,7L,0L,3L,1L,6L,1L,7L,0L,5L,0L,1L,9L,4L,3L,5L,8L,3L,5L,7L,2L,0L,5L,9L,7L,7L,7L,7L,1L,4L,6L,6L,7L,0L,9L,7L,0L,7L,1L,6L,2L,0L,4L,5L,4L,4L,1L,7L,8L,1L,8L,6L,2L,8L,4L,7L,5L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020823Inst : IEnumerable<long>
{
public static readonly long[] Value=A020823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020823.Bytes);
public long this[int i]=>Value[i];

public static A020823Inst Instance=new A020823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020822
{
public static readonly long[] Value={ 1L,2L,4L,0L,3L,4L,7L,3L,4L,5L,8L,9L,2L,0L,8L,4L,5L,6L,1L,9L,0L,2L,5L,5L,5L,8L,8L,1L,5L,8L,5L,1L,9L,5L,5L,5L,8L,6L,3L,6L,0L,6L,0L,9L,7L,0L,0L,9L,3L,6L,2L,6L,6L,7L,5L,0L,6L,7L,1L,6L,8L,0L,5L,9L,8L,8L,6L,7L,4L,9L,9L,9L,2L,4L,6L,5L,4L,9L,0L,4L,9L,2L,7L,6L,3L,1L,0L,0L,6L,5L,6L,4L,1L,8L,0L,3L,5L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020822Inst : IEnumerable<long>
{
public static readonly long[] Value=A020822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020822.Bytes);
public long this[int i]=>Value[i];

public static A020822Inst Instance=new A020822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020821
{
public static readonly long[] Value={ 1L,2L,5L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020821Inst : IEnumerable<long>
{
public static readonly long[] Value=A020821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020821.Bytes);
public long this[int i]=>Value[i];

public static A020821Inst Instance=new A020821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020820
{
public static readonly long[] Value={ 1L,2L,5L,9L,8L,8L,1L,5L,7L,6L,6L,9L,7L,4L,2L,4L,0L,9L,0L,7L,1L,5L,0L,5L,5L,1L,2L,0L,7L,8L,0L,6L,0L,0L,2L,0L,2L,7L,1L,9L,1L,7L,1L,0L,3L,9L,5L,6L,3L,0L,7L,1L,5L,1L,4L,4L,6L,1L,1L,1L,1L,6L,4L,7L,2L,3L,8L,6L,0L,4L,2L,0L,1L,5L,3L,8L,2L,3L,0L,2L,9L,8L,9L,3L,3L,5L,2L,0L,4L,2L,2L,1L,3L,0L,7L,3L,5L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020820Inst : IEnumerable<long>
{
public static readonly long[] Value=A020820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020820.Bytes);
public long this[int i]=>Value[i];

public static A020820Inst Instance=new A020820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020819
{
public static readonly long[] Value={ 1L,2L,7L,0L,0L,0L,1L,2L,7L,0L,0L,0L,1L,9L,0L,5L,0L,0L,3L,1L,7L,5L,0L,0L,5L,5L,5L,6L,2L,6L,0L,0L,0L,1L,2L,6L,8L,3L,3L,5L,6L,5L,9L,0L,5L,1L,9L,3L,8L,8L,4L,7L,3L,8L,6L,2L,2L,5L,6L,1L,9L,7L,6L,6L,1L,7L,9L,6L,3L,8L,8L,4L,6L,2L,6L,0L,9L,1L,9L,0L,4L,1L,4L,3L,9L,7L,0L,8L,2L,8L,2L,4L,5L,9L,4L,7L,5L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020819Inst : IEnumerable<long>
{
public static readonly long[] Value=A020819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020819.Bytes);
public long this[int i]=>Value[i];

public static A020819Inst Instance=new A020819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020818
{
public static readonly long[] Value={ 1L,2L,8L,0L,3L,6L,8L,7L,9L,9L,3L,2L,8L,9L,5L,9L,7L,3L,6L,7L,4L,2L,5L,7L,7L,4L,9L,7L,6L,6L,5L,4L,2L,6L,4L,6L,1L,2L,4L,0L,7L,0L,5L,7L,6L,0L,1L,0L,6L,3L,2L,1L,8L,5L,2L,4L,8L,8L,0L,7L,2L,7L,4L,7L,5L,7L,2L,2L,5L,9L,9L,3L,2L,6L,1L,2L,5L,7L,8L,2L,0L,5L,6L,4L,3L,5L,1L,3L,6L,1L,5L,1L,2L,5L,7L,3L,8L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020818Inst : IEnumerable<long>
{
public static readonly long[] Value=A020818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020818.Bytes);
public long this[int i]=>Value[i];

public static A020818Inst Instance=new A020818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020817
{
public static readonly long[] Value={ 1L,2L,9L,0L,9L,9L,4L,4L,4L,8L,7L,3L,5L,8L,0L,5L,6L,2L,8L,3L,9L,3L,0L,8L,8L,4L,6L,6L,5L,9L,4L,1L,3L,3L,2L,0L,3L,6L,1L,0L,9L,7L,3L,9L,0L,1L,7L,6L,3L,8L,6L,3L,6L,0L,8L,8L,6L,2L,5L,2L,4L,5L,8L,8L,7L,0L,4L,4L,9L,4L,3L,6L,3L,9L,7L,8L,9L,9L,3L,0L,1L,1L,1L,7L,3L,0L,9L,5L,7L,9L,2L,2L,8L,6L,2L,2L,4L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020817Inst : IEnumerable<long>
{
public static readonly long[] Value=A020817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020817.Bytes);
public long this[int i]=>Value[i];

public static A020817Inst Instance=new A020817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020816
{
public static readonly long[] Value={ 1L,3L,0L,1L,8L,8L,9L,1L,0L,9L,8L,0L,8L,2L,3L,8L,6L,7L,3L,8L,5L,9L,2L,6L,8L,9L,8L,6L,7L,3L,4L,1L,3L,0L,9L,2L,7L,6L,3L,7L,7L,0L,3L,5L,7L,2L,4L,7L,7L,0L,9L,8L,9L,7L,0L,8L,5L,1L,6L,5L,0L,2L,5L,1L,5L,1L,4L,4L,9L,8L,5L,8L,6L,1L,0L,0L,4L,5L,9L,2L,9L,6L,9L,2L,4L,7L,5L,3L,8L,5L,2L,1L,9L,6L,8L,4L,3L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020816Inst : IEnumerable<long>
{
public static readonly long[] Value=A020816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020816.Bytes);
public long this[int i]=>Value[i];

public static A020816Inst Instance=new A020816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020815
{
public static readonly long[] Value={ 1L,3L,1L,3L,0L,6L,4L,3L,2L,8L,5L,9L,7L,2L,2L,5L,5L,6L,6L,4L,9L,3L,3L,4L,6L,7L,2L,8L,8L,2L,0L,4L,0L,0L,5L,1L,8L,1L,6L,5L,6L,3L,8L,8L,9L,5L,2L,6L,6L,6L,5L,4L,9L,0L,8L,4L,3L,9L,7L,3L,8L,6L,6L,2L,1L,5L,8L,6L,8L,1L,4L,0L,6L,4L,4L,3L,6L,2L,0L,9L,0L,4L,2L,4L,8L,6L,6L,7L,1L,9L,2L,1L,3L,5L,7L,1L,5L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020815Inst : IEnumerable<long>
{
public static readonly long[] Value=A020815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020815.Bytes);
public long this[int i]=>Value[i];

public static A020815Inst Instance=new A020815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020814
{
public static readonly long[] Value={ 1L,3L,2L,4L,5L,3L,2L,3L,5L,7L,0L,6L,5L,0L,4L,3L,8L,0L,6L,5L,3L,2L,7L,5L,1L,7L,2L,0L,5L,1L,6L,8L,6L,2L,6L,4L,1L,7L,9L,3L,3L,6L,7L,4L,9L,2L,0L,3L,9L,1L,8L,9L,4L,9L,7L,9L,4L,7L,1L,2L,7L,5L,2L,7L,3L,1L,7L,6L,7L,0L,5L,1L,8L,2L,3L,1L,1L,9L,4L,9L,4L,6L,5L,9L,3L,4L,1L,2L,6L,4L,4L,5L,8L,7L,2L,8L,4L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020814Inst : IEnumerable<long>
{
public static readonly long[] Value=A020814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020814.Bytes);
public long this[int i]=>Value[i];

public static A020814Inst Instance=new A020814Inst();

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