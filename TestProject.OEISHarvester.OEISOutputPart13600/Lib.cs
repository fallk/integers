using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A090440
{
public static readonly long[] Value={ 1L,24L,36L,12L,1L,1440L,5760L,6120L,2520L,456L,36L,1L,172800L,1339200L,2808000L,2420640L,1025280L,232920L,29400L,2040L,72L,1L,36288000L,471744000L,1643846400L,2381702400L,1745755200L,721224000L,178941600L,27624960L,2689920L,163800L,6000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090440Inst : IEnumerable<long>
{
public static readonly long[] Value=A090440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090440.Bytes);
public long this[int i]=>Value[i];

public static A090440Inst Instance=new A090440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090439
{
public static readonly BigInteger[] Value={ 1L,5L,37L,-887L,-168919L,-21607859L,-2799384755L,-337767590383L,-11912361112367L,21032925955607701L,16703816669710968821UL,BigInteger.Parse("10654267957172226744985"),BigInteger.Parse("6614425802684094455696377"),BigInteger.Parse("4120103872599589439389105373") };
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
public class A090439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090439Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A090439.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A090439.Bytes);
public BigInteger this[int i]=>Value[i];

public static A090439Inst Instance=new A090439Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090438
{
public static readonly long[] Value={ 1L,12L,8L,1L,360L,480L,180L,24L,1L,20160L,40320L,25200L,6720L,840L,48L,1L,1814400L,4838400L,4233600L,1693440L,352800L,40320L,2520L,80L,1L,239500800L,798336000L,898128000L,479001600L,139708800L,23950080L,2494800L,158400L,5940L,120L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090438Inst : IEnumerable<long>
{
public static readonly long[] Value=A090438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090438.Bytes);
public long this[int i]=>Value[i];

public static A090438Inst Instance=new A090438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090437
{
public static readonly BigInteger[] Value={ 1L,1L,-17L,-299L,1921L,451621L,23016631L,-138672407L,-208026131039L,-31455532865879L,-2214855733827329L,358045039222582141L,BigInteger.Parse("197933737480453452193"),BigInteger.Parse("51028310360637930765901"),BigInteger.Parse("6769736050165112232649351"),BigInteger.Parse("-1644881699523140953828119599") };
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
public class A090437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090437Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A090437.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A090437.Bytes);
public BigInteger this[int i]=>Value[i];

public static A090437Inst Instance=new A090437Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090436
{
public static readonly BigInteger[] Value={ 1L,5L,100L,27500L,687500L,7075062500L,3594287401375000L,BigInteger.Parse("81456034414253835114625000"),BigInteger.Parse("35683959264371194185124824344091625000"),BigInteger.Parse("140789696830026154896057937831705061406034875000") };
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
public class A090436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090436Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A090436.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A090436.Bytes);
public BigInteger this[int i]=>Value[i];

public static A090436Inst Instance=new A090436Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090403
{
public static readonly long[] Value={ 5L,17L,29L,37L,53L,71L,79L,89L,137L,149L,151L,157L,173L,179L,193L,211L,227L,229L,257L,263L,281L,349L,353L,359L,373L,383L,397L,409L,419L,421L,433L,439L,487L,491L,563L,577L,593L,607L,631L,643L,653L,659L,677L,701L,709L,733L,751L,757L,787L,823L,827L,877L,947L,953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090403Inst : IEnumerable<long>
{
public static readonly long[] Value=A090403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090403.Bytes);
public long this[int i]=>Value[i];

public static A090403Inst Instance=new A090403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090402
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,1L,3L,1L,1L,1L,3L,4L,4L,3L,1L,1L,2L,1L,4L,1L,2L,1L,1L,5L,3L,5L,5L,3L,5L,1L,1L,3L,2L,1L,5L,1L,2L,3L,1L,1L,7L,5L,3L,6L,6L,3L,5L,7L,1L,1L,4L,3L,2L,1L,6L,1L,2L,3L,4L,1L,1L,9L,7L,5L,3L,7L,7L,3L,5L,7L,9L,1L,1L,5L,4L,3L,2L,1L,7L,1L,2L,3L,4L,5L,1L,1L,11L,9L,7L,5L,3L,8L,8L,3L,5L,7L,9L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090402Inst : IEnumerable<long>
{
public static readonly long[] Value=A090402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090402.Bytes);
public long this[int i]=>Value[i];

public static A090402Inst Instance=new A090402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090401
{
public static readonly long[] Value={ 1L,3L,9L,27L,78L,225L,648L,1863L,5355L,15390L,44226L,127089L,365202L,1049436L,3015630L,8665623L,24901263L,71555481L,205619553L,590861790L,1697881581L,4878978300L,14020076241L,40287643353L,115769285316L,332670921048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090401Inst : IEnumerable<long>
{
public static readonly long[] Value=A090401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090401.Bytes);
public long this[int i]=>Value[i];

public static A090401Inst Instance=new A090401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090400
{
public static readonly long[] Value={ 1L,3L,9L,24L,63L,162L,414L,1053L,2673L,6777L,17172L,43497L,110160L,278964L,706401L,1788723L,4529277L,11468628L,29039715L,73531314L,186188058L,471445029L,1193741145L,3022659261L,7653642696L,19379704653L,49071136176L,124252480440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090400Inst : IEnumerable<long>
{
public static readonly long[] Value=A090400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090400.Bytes);
public long this[int i]=>Value[i];

public static A090400Inst Instance=new A090400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090399
{
public static readonly long[] Value={ 1L,2L,4L,8L,14L,24L,40L,64L,100L,152L,224L,320L,440L,576L,704L,768L,656L,160L,-1088L,-3712L,-8736L,-17792L,-33408L,-59392L,-101312L,-167040L,-267264L,-415744L,-628864L,-923648L,-1312768L,-1794048L,-2330368L,-2813440L,-3001344L,-2414592L,-168448L,5289984L,16582656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090399Inst : IEnumerable<long>
{
public static readonly long[] Value=A090399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090399.Bytes);
public long this[int i]=>Value[i];

public static A090399Inst Instance=new A090399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090398
{
public static readonly long[] Value={ 2L,9L,20L,36L,57L,83L,113L,147L,187L,231L,279L,332L,390L,453L,520L,591L,668L,748L,834L,924L,1019L,1118L,1222L,1331L,1444L,1562L,1685L,1812L,1943L,2080L,2221L,2366L,2517L,2672L,2831L,2995L,3164L,3337L,3515L,3698L,3885L,4077L,4273L,4474L,4680L,4891L,5106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090398Inst : IEnumerable<long>
{
public static readonly long[] Value=A090398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090398.Bytes);
public long this[int i]=>Value[i];

public static A090398Inst Instance=new A090398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090397
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,5L,7L,6L,10L,8L,8L,5L,8L,13L,7L,10L,13L,10L,11L,10L,14L,19L,15L,13L,12L,13L,16L,17L,15L,11L,17L,24L,21L,29L,23L,18L,23L,24L,26L,31L,28L,26L,29L,31L,24L,31L,28L,26L,20L,18L,18L,23L,30L,33L,36L,36L,31L,33L,38L,37L,35L,37L,29L,40L,43L,45L,39L,37L,40L,39L,42L,47L,41L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090397Inst : IEnumerable<long>
{
public static readonly long[] Value=A090397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090397.Bytes);
public long this[int i]=>Value[i];

public static A090397Inst Instance=new A090397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090396
{
public static readonly long[] Value={ 0L,1L,1L,1L,3L,5L,2L,5L,1L,9L,6L,5L,4L,1L,13L,13L,15L,15L,17L,19L,19L,21L,0L,3L,10L,17L,22L,27L,1L,3L,15L,27L,8L,19L,1L,15L,31L,11L,28L,7L,27L,3L,26L,3L,23L,41L,20L,5L,37L,17L,46L,25L,0L,33L,13L,49L,30L,7L,43L,19L,52L,29L,14L,61L,41L,19L,5L,59L,50L,37L,22L,7L,67L,55L,43L,29L,15L,3L,68L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090396Inst : IEnumerable<long>
{
public static readonly long[] Value=A090396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090396.Bytes);
public long this[int i]=>Value[i];

public static A090396Inst Instance=new A090396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090395
{
public static readonly long[] Value={ 1L,1L,3L,4L,5L,3L,7L,2L,3L,5L,11L,2L,13L,7L,15L,16L,17L,3L,19L,10L,21L,11L,23L,3L,25L,13L,27L,14L,29L,15L,31L,16L,33L,17L,35L,4L,37L,19L,39L,5L,41L,21L,43L,22L,15L,23L,47L,24L,49L,25L,51L,26L,53L,27L,55L,7L,57L,29L,59L,5L,61L,31L,21L,64L,65L,33L,67L,34L,69L,35L,71L,6L,73L,37L,25L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090395Inst : IEnumerable<long>
{
public static readonly long[] Value=A090395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090395.Bytes);
public long this[int i]=>Value[i];

public static A090395Inst Instance=new A090395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090394
{
public static readonly long[] Value={ 0L,40320L,95616L,170856L,272584L,409360L,592296L,835702L,1157857L,1581921L,2137005L,2859417L,3794103L,4996303L,6533443L,8487285L,10956358L,14058694L,17934894L,22751550L,28705050L,36025794L,44982850L,55889080L,69106767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090394Inst : IEnumerable<long>
{
public static readonly long[] Value=A090394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090394.Bytes);
public long this[int i]=>Value[i];

public static A090394Inst Instance=new A090394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090393
{
public static readonly long[] Value={ 0L,5040L,12288L,22572L,36992L,56990L,84432L,121703L,171816L,238536L,326520L,441474L,590328L,781430L,1024760L,1332165L,1717616L,2197488L,2790864L,3519864L,4410000L,5490558L,6795008L,8361443L,10233048L,12458600L,15093000L,18197838L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090393Inst : IEnumerable<long>
{
public static readonly long[] Value=A090393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090393.Bytes);
public long this[int i]=>Value[i];

public static A090393Inst Instance=new A090393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090392
{
public static readonly long[] Value={ 0L,720L,1812L,3428L,5768L,9090L,13721L,20069L,28636L,40032L,54990L,74382L,99236L,130754L,170331L,219575L,280328L,354688L,445032L,554040L,684720L,840434L,1024925L,1242345L,1497284L,1794800L,2140450L,2540322L,3001068L,3529938L,4134815L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090392Inst : IEnumerable<long>
{
public static readonly long[] Value=A090392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090392.Bytes);
public long this[int i]=>Value[i];

public static A090392Inst Instance=new A090392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090391
{
public static readonly long[] Value={ 0L,120L,312L,606L,1040L,1661L,2526L,3703L,5272L,7326L,9972L,13332L,17544L,22763L,29162L,36933L,46288L,57460L,70704L,86298L,104544L,125769L,150326L,178595L,210984L,247930L,289900L,337392L,390936L,451095L,518466L,593681L,677408L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090391Inst : IEnumerable<long>
{
public static readonly long[] Value=A090391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090391.Bytes);
public long this[int i]=>Value[i];

public static A090391Inst Instance=new A090391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090390
{
public static readonly long[] Value={ 1L,1L,9L,49L,289L,1681L,9801L,57121L,332929L,1940449L,11309769L,65918161L,384199201L,2239277041L,13051463049L,76069501249L,443365544449L,2584123765441L,15061377048201L,87784138523761L,511643454094369L,2982076586042449L,17380816062160329L,101302819786919521L,590436102659356801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090390Inst : IEnumerable<long>
{
public static readonly long[] Value=A090390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090390.Bytes);
public long this[int i]=>Value[i];

public static A090390Inst Instance=new A090390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090389
{
public static readonly long[] Value={ 2L,11L,29L,47L,83L,101L,137L,173L,191L,227L,263L,281L,317L,353L,389L,443L,461L,479L,569L,587L,641L,659L,677L,821L,839L,857L,911L,929L,947L,983L,1019L,1091L,1109L,1163L,1181L,1217L,1289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090389Inst : IEnumerable<long>
{
public static readonly long[] Value=A090389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090389.Bytes);
public long this[int i]=>Value[i];

public static A090389Inst Instance=new A090389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090388
{
public static readonly long[] Value={ 2L,7L,3L,2L,0L,5L,0L,8L,0L,7L,5L,6L,8L,8L,7L,7L,2L,9L,3L,5L,2L,7L,4L,4L,6L,3L,4L,1L,5L,0L,5L,8L,7L,2L,3L,6L,6L,9L,4L,2L,8L,0L,5L,2L,5L,3L,8L,1L,0L,3L,8L,0L,6L,2L,8L,0L,5L,5L,8L,0L,6L,9L,7L,9L,4L,5L,1L,9L,3L,3L,0L,1L,6L,9L,0L,8L,8L,0L,0L,0L,3L,7L,0L,8L,1L,1L,4L,6L,1L,8L,6L,7L,5L,7L,2L,4L,8L,5L,7L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090388Inst : IEnumerable<long>
{
public static readonly long[] Value=A090388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090388.Bytes);
public long this[int i]=>Value[i];

public static A090388Inst Instance=new A090388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090355
{
public static readonly BigInteger[] Value={ 1L,3L,15L,109L,1086L,14178L,232906L,4647006L,109376595L,2967406345L,91130074437L,3123199831983L,118106517900868L,4883161763750820L,219076867059030300L,10597531747143624820UL,BigInteger.Parse("549768536732090716371"),BigInteger.Parse("30443800514118532762329") };
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
public class A090355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090355Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A090355.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A090355.Bytes);
public BigInteger this[int i]=>Value[i];

public static A090355Inst Instance=new A090355Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090354
{
public static readonly BigInteger[] Value={ 1L,1L,3L,19L,190L,2574L,43922L,903986L,21784659L,601478195L,18715354049L,647834803569L,24688869993252L,1027073272425876L,46309250293477020L,2249435671825385244L,BigInteger.Parse("117101538463333719891"),BigInteger.Parse("6503918951175618656403") };
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
public class A090354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090354Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A090354.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A090354.Bytes);
public BigInteger this[int i]=>Value[i];

public static A090354Inst Instance=new A090354Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090353
{
public static readonly BigInteger[] Value={ 1L,1L,4L,28L,286L,3886L,66260L,1361972L,32784353L,904412593L,28124223808L,973106096392L,37073604836768L,1541948625066176L,69513081435903392L,3376138396206853792L,BigInteger.Parse("175739519606046355540"),BigInteger.Parse("9760024269508314079444") };
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
public class A090353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090353Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A090353.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A090353.Bytes);
public BigInteger this[int i]=>Value[i];

public static A090353Inst Instance=new A090353Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090352
{
public static readonly BigInteger[] Value={ 1L,2L,7L,36L,255L,2370L,27713L,393352L,6582068L,126888632L,2767912036L,67362737168L,1808596304964L,53083358012760L,1690443996202428L,58039582729688320L,2136931230333535178L,BigInteger.Parse("83981145793974066484") };
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
public class A090352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090352Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A090352.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A090352.Bytes);
public BigInteger this[int i]=>Value[i];

public static A090352Inst Instance=new A090352Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090351
{
public static readonly BigInteger[] Value={ 1L,1L,3L,15L,108L,1032L,12388L,179572L,3052986L,59555338L,1310677726L,32114051862L,866766965308L,25547102523604L,816335926158372L,28107705687291892L,1037367351120788551L,BigInteger.Parse("40852168787823027351"),BigInteger.Parse("1709792654612819858341") };
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
public class A090351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090351Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A090351.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A090351.Bytes);
public BigInteger this[int i]=>Value[i];

public static A090351Inst Instance=new A090351Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090350
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,3L,2L,2L,3L,6L,3L,7L,4L,4L,5L,10L,5L,11L,6L,6L,7L,14L,7L,8L,8L,9L,9L,19L,10L,20L,10L,11L,11L,12L,12L,25L,13L,13L,14L,28L,14L,29L,15L,15L,16L,32L,16L,17L,17L,18L,18L,37L,19L,19L,20L,20L,21L,42L,21L,43L,22L,22L,23L,23L,24L,48L,24L,25L,25L,51L,26L,52L,26L,27L,27L,28L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090350Inst : IEnumerable<long>
{
public static readonly long[] Value=A090350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090350.Bytes);
public long this[int i]=>Value[i];

public static A090350Inst Instance=new A090350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090349
{
public static readonly long[] Value={ 1L,2L,1L,3L,3L,1L,4L,6L,0L,1L,5L,10L,10L,0L,1L,6L,15L,20L,0L,0L,1L,7L,21L,35L,35L,0L,0L,1L,8L,28L,0L,70L,0L,0L,0L,1L,9L,36L,84L,126L,126L,0L,0L,0L,1L,10L,45L,120L,0L,252L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090349Inst : IEnumerable<long>
{
public static readonly long[] Value=A090349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090349.Bytes);
public long this[int i]=>Value[i];

public static A090349Inst Instance=new A090349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090348
{
public static readonly long[] Value={ 2L,7L,9L,11L,23L,25L,29L,37L,43L,53L,67L,71L,79L,107L,109L,113L,127L,137L,149L,151L,163L,169L,179L,191L,193L,197L,211L,233L,239L,263L,277L,281L,289L,317L,331L,337L,347L,359L,361L,373L,379L,389L,401L,421L,431L,443L,449L,457L,463L,487L,491L,499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090348Inst : IEnumerable<long>
{
public static readonly long[] Value=A090348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090348.Bytes);
public long this[int i]=>Value[i];

public static A090348Inst Instance=new A090348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090347
{
public static readonly BigInteger[] Value={ 1L,3L,8L,5L,-156L,-1253L,48L,116937L,1236140L,-4517689L,-317599800L,-3473788019L,43408737540L,2033846838675L,19004486417504L,-643679274285679L,-24665731809676452L,-135665006897593601L,15018201730467027960UL };
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
public class A090347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090347Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A090347.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A090347.Bytes);
public BigInteger this[int i]=>Value[i];

public static A090347Inst Instance=new A090347Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090346
{
public static readonly long[] Value={ 2L,4L,6L,6L,8L,8L,9L,8L,6L,12L,6L,8L,12L,12L,9L,10L,16L,8L,8L,15L,8L,10L,6L,8L,12L,12L,16L,16L,8L,20L,8L,6L,12L,18L,18L,12L,14L,16L,12L,12L,24L,12L,16L,16L,18L,8L,8L,18L,16L,16L,8L,24L,12L,6L,16L,12L,24L,6L,12L,12L,21L,24L,8L,20L,24L,20L,6L,18L,16L,16L,8L,12L,12L,10L,8L,6L,8L,16L,20L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090346Inst : IEnumerable<long>
{
public static readonly long[] Value=A090346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090346.Bytes);
public long this[int i]=>Value[i];

public static A090346Inst Instance=new A090346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090345
{
public static readonly long[] Value={ 1L,0L,1L,1L,3L,5L,12L,24L,55L,119L,272L,612L,1411L,3247L,7565L,17667L,41561L,98099L,232696L,553784L,1322813L,3169065L,7614583L,18342921L,44294991L,107200829L,259983346L,631718606L,1537737567L,3749440151L,9156561590L,22394270034L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090345Inst : IEnumerable<long>
{
public static readonly long[] Value=A090345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090345.Bytes);
public long this[int i]=>Value[i];

public static A090345Inst Instance=new A090345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090344
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,11L,23L,47L,102L,221L,493L,1105L,2516L,5763L,13328L,30995L,72556L,170655L,403351L,957135L,2279948L,5449013L,13063596L,31406517L,75701508L,182902337L,442885683L,1074604289L,2612341856L,6361782007L,15518343597L,37912613631L,92758314874L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090344Inst : IEnumerable<long>
{
public static readonly long[] Value=A090344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090344.Bytes);
public long this[int i]=>Value[i];

public static A090344Inst Instance=new A090344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090343
{
public static readonly long[] Value={ -5L,-3L,-4L,-2L,-1L,-2L,-4L,-1L,-7L,-2L,3L,-1L,-4L,1L,-11L,-1L,7L,-5L,-4L,0L,0L,-2L,14L,-2L,-19L,5L,-22L,1L,15L,-9L,19L,0L,-23L,-2L,-4L,-1L,-4L,9L,-27L,-4L,30L,-13L,-4L,4L,-3L,13L,27L,-6L,-39L,1L,4L,4L,31L,-20L,-43L,1L,-39L,-2L,46L,0L,43L,17L,-54L,-9L,-8L,2L,-4L,9L,-47L,-25L,58L,-11L,55L,21L,-66L,10L,6L,-25L,-4L,-1L,-10L,-2L,51L,-3L,-67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090343Inst : IEnumerable<long>
{
public static readonly long[] Value=A090343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090343.Bytes);
public long this[int i]=>Value[i];

public static A090343Inst Instance=new A090343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090342
{
public static readonly long[] Value={ -4L,-3L,-2L,-3L,-1L,-1L,0L,-5L,-1L,-6L,2L,-1L,5L,-8L,0L,-11L,8L,-2L,6L,-14L,1L,3L,8L,0L,-1L,-14L,-1L,-20L,19L,-4L,12L,-2L,4L,-18L,-9L,-6L,26L,-20L,4L,-32L,26L,1L,18L,-32L,0L,11L,35L,-9L,-3L,-41L,9L,1L,40L,-11L,-15L,-46L,10L,-30L,26L,-1L,49L,15L,-3L,-55L,-3L,-10L,53L,-50L,14L,-59L,32L,-1L,50L,21L,-5L,-56L,5L,6L,36L,-70L,-2L,21L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090342Inst : IEnumerable<long>
{
public static readonly long[] Value=A090342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090342.Bytes);
public long this[int i]=>Value[i];

public static A090342Inst Instance=new A090342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090341
{
public static readonly long[] Value={ -3L,-2L,-2L,-1L,-2L,-1L,1L,-1L,-5L,0L,-2L,-2L,5L,1L,-9L,0L,-2L,-1L,9L,-4L,-13L,4L,13L,-6L,1L,4L,-20L,1L,-2L,0L,17L,-9L,2L,9L,-25L,-11L,21L,10L,-25L,-1L,-2L,-3L,32L,-10L,-36L,14L,33L,-1L,-6L,-5L,-33L,6L,37L,-2L,-6L,-18L,-37L,19L,-2L,-21L,48L,21L,-5L,-4L,-49L,-5L,41L,7L,-45L,2L,-2L,-27L,60L,16L,-5L,5L,-61L,5L,67L,-30L,-71L,29L,61L,-31L,-10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090341Inst : IEnumerable<long>
{
public static readonly long[] Value=A090341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090341.Bytes);
public long this[int i]=>Value[i];

public static A090341Inst Instance=new A090341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090340
{
public static readonly long[] Value={ -2L,-1L,-1L,-1L,0L,-2L,1L,0L,-1L,-4L,4L,-6L,4L,1L,0L,-9L,9L,-11L,10L,-1L,-3L,-10L,14L,-1L,-5L,6L,-2L,-18L,19L,-21L,21L,-4L,-5L,7L,2L,-27L,16L,5L,5L,-30L,29L,-31L,28L,4L,-14L,-22L,36L,-3L,2L,-8L,3L,-36L,42L,-5L,3L,-9L,-9L,-28L,47L,-49L,28L,20L,1L,-6L,2L,-51L,46L,-5L,12L,-57L,59L,-61L,34L,26L,-10L,5L,0L,-61L,66L,1L,-31L,-40L,69L,-8L,-23L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090340Inst : IEnumerable<long>
{
public static readonly long[] Value=A090340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090340.Bytes);
public long this[int i]=>Value[i];

public static A090340Inst Instance=new A090340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090307
{
public static readonly long[] Value={ 2L,18L,326L,5886L,106274L,1918818L,34644998L,625528782L,11294163074L,203920464114L,3681862517126L,66477445772382L,1200275886420002L,21671443401332418L,391286257110403526L,7064824071388595886L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090307Inst : IEnumerable<long>
{
public static readonly long[] Value=A090307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090307.Bytes);
public long this[int i]=>Value[i];

public static A090307Inst Instance=new A090307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090306
{
public static readonly BigInteger[] Value={ 2L,17L,291L,4964L,84679L,1444507L,24641298L,420346573L,7170533039L,122319408236L,2086600473051L,35594527450103L,607193567124802L,10357885168571737L,176691241432844331L,3014108989526925364L,BigInteger.Parse("51416544063390575519") };
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
public class A090306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090306Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A090306.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A090306.Bytes);
public BigInteger this[int i]=>Value[i];

public static A090306Inst Instance=new A090306Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090305
{
public static readonly BigInteger[] Value={ 2L,16L,258L,4144L,66562L,1069136L,17172738L,275832944L,4430499842L,71163830416L,1143051786498L,18359992414384L,294902930416642L,4736806879080656L,76083812995707138L,1222077814810394864L,BigInteger.Parse("19629328849962024962") };
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
public class A090305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090305Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A090305.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A090305.Bytes);
public BigInteger this[int i]=>Value[i];

public static A090305Inst Instance=new A090305Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090304
{
public static readonly long[] Value={ 1L,2L,3L,6L,11L,14L,26L,32L,37L,38L,50L,56L,62L,67L,68L,74L,86L,92L,97L,98L,104L,110L,116L,121L,122L,127L,128L,145L,157L,164L,187L,194L,205L,206L,211L,217L,223L,224L,247L,248L,254L,272L,277L,289L,290L,301L,307L,314L,325L,332L,337L,338L,343L,344L,350L,367L,373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090304Inst : IEnumerable<long>
{
public static readonly long[] Value=A090304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090304.Bytes);
public long this[int i]=>Value[i];

public static A090304Inst Instance=new A090304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090303
{
public static readonly long[] Value={ 0L,0L,0L,2L,3L,0L,5L,3L,7L,5L,0L,7L,11L,0L,13L,11L,7L,13L,17L,3L,19L,17L,13L,19L,23L,0L,17L,23L,19L,13L,29L,0L,31L,29L,7L,31L,0L,0L,37L,23L,31L,37L,41L,3L,43L,41L,37L,43L,47L,0L,41L,47L,43L,37L,53L,0L,47L,53L,31L,43L,59L,0L,61L,59L,37L,61L,0L,0L,67L,53L,61L,67L,71L,0L,73L,71L,67L,73L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090303Inst : IEnumerable<long>
{
public static readonly long[] Value=A090303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090303.Bytes);
public long this[int i]=>Value[i];

public static A090303Inst Instance=new A090303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090302
{
public static readonly long[] Value={ 0L,2L,3L,3L,5L,5L,7L,7L,3L,7L,11L,11L,13L,13L,5L,13L,17L,17L,19L,19L,11L,19L,23L,23L,19L,23L,17L,13L,29L,29L,31L,31L,23L,31L,29L,0L,37L,37L,29L,37L,41L,41L,43L,43L,17L,43L,47L,47L,43L,47L,41L,37L,53L,53L,19L,53L,47L,43L,59L,59L,61L,61L,53L,61L,59L,11L,67L,67L,59L,67L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090302Inst : IEnumerable<long>
{
public static readonly long[] Value=A090302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090302.Bytes);
public long this[int i]=>Value[i];

public static A090302Inst Instance=new A090302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090301
{
public static readonly long[] Value={ 2L,15L,227L,3420L,51527L,776325L,11696402L,176222355L,2655031727L,40001698260L,602680505627L,9080209282665L,136805819745602L,2061167505466695L,31054318401746027L,467875943531657100L,7049193471376602527L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090301Inst : IEnumerable<long>
{
public static readonly long[] Value=A090301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090301.Bytes);
public long this[int i]=>Value[i];

public static A090301Inst Instance=new A090301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090300
{
public static readonly long[] Value={ 2L,14L,198L,2786L,39202L,551614L,7761798L,109216786L,1536796802L,21624372014L,304278004998L,4281516441986L,60245508192802L,847718631141214L,11928306344169798L,167844007449518386L,2361744410637427202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090300Inst : IEnumerable<long>
{
public static readonly long[] Value=A090300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090300.Bytes);
public long this[int i]=>Value[i];

public static A090300Inst Instance=new A090300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090299
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,1L,5L,10L,5L,1L,14L,35L,22L,7L,1L,42L,126L,93L,38L,9L,1L,132L,462L,386L,187L,58L,11L,1L,429L,1716L,1586L,874L,325L,82L,13L,1L,1430L,6435L,6476L,3958L,1686L,515L,110L,15L,1L,4862L,24310L,26333L,17548L,8330L,2934L,765L,142L,17L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090299Inst : IEnumerable<long>
{
public static readonly long[] Value=A090299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090299.Bytes);
public long this[int i]=>Value[i];

public static A090299Inst Instance=new A090299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090298
{
public static readonly long[] Value={ 1L,9L,2L,11L,8L,3L,19L,12L,7L,4L,21L,18L,13L,6L,5L,29L,22L,17L,14L,10L,31L,28L,23L,16L,15L,39L,32L,27L,24L,20L,41L,38L,33L,26L,25L,49L,42L,37L,34L,30L,51L,48L,43L,36L,35L,59L,52L,47L,44L,40L,61L,58L,53L,46L,45L,69L,62L,57L,54L,50L,71L,68L,63L,56L,55L,79L,72L,67L,64L,60L,81L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090298Inst : IEnumerable<long>
{
public static readonly long[] Value=A090298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090298.Bytes);
public long this[int i]=>Value[i];

public static A090298Inst Instance=new A090298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090297
{
public static readonly long[] Value={ 42L,462L,1586L,3958L,8330L,15694L,27314L,44758L,69930L,105102L,152946L,216566L,299530L,405902L,540274L,707798L,914218L,1165902L,1469874L,1833846L,2266250L,2776270L,3373874L,4069846L,4875818L,5804302L,6868722L,8083446L,9463818L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090297Inst : IEnumerable<long>
{
public static readonly long[] Value=A090297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090297.Bytes);
public long this[int i]=>Value[i];

public static A090297Inst Instance=new A090297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090296
{
public static readonly long[] Value={ 14L,126L,386L,874L,1686L,2934L,4746L,7266L,10654L,15086L,20754L,27866L,36646L,47334L,60186L,75474L,93486L,114526L,138914L,166986L,199094L,235606L,276906L,323394L,375486L,433614L,498226L,569786L,648774L,735686L,831034L,935346L,1049166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090296Inst : IEnumerable<long>
{
public static readonly long[] Value=A090296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090296.Bytes);
public long this[int i]=>Value[i];

public static A090296Inst Instance=new A090296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090295
{
public static readonly BigInteger[] Value={ 0L,1L,0L,-1L,1L,-1L,1L,-17L,41L,-3359L,1319L,-234061L,77141L,-25222469L,113513L,-775879541L,964485937L,-6450310315L,178425130799L,-217586071308601L,2282867060899L,-4350162631605877L,13410469018835099L,BigInteger.Parse("-30904230668771778781"),1713176573537644627L,BigInteger.Parse("-3114541600222419096787") };
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
public class A090295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090295Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A090295.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A090295.Bytes);
public BigInteger this[int i]=>Value[i];

public static A090295Inst Instance=new A090295Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090294
{
public static readonly long[] Value={ 5L,35L,93L,187L,325L,515L,765L,1083L,1477L,1955L,2525L,3195L,3973L,4867L,5885L,7035L,8325L,9763L,11357L,13115L,15045L,17155L,19453L,21947L,24645L,27555L,30685L,34043L,37637L,41475L,45565L,49915L,54533L,59427L,64605L,70075L,75845L,81923L,88317L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090294Inst : IEnumerable<long>
{
public static readonly long[] Value=A090294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090294.Bytes);
public long this[int i]=>Value[i];

public static A090294Inst Instance=new A090294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090293
{
public static readonly long[] Value={ 10L,9L,8L,7L,46L,15L,44L,43L,42L,41L,90L,239L,488L,237L,486L,35L,484L,233L,482L,231L,80L,229L,478L,227L,476L,75L,474L,223L,472L,221L,70L,219L,2468L,1217L,2466L,285L,2464L,1213L,2462L,1289L,460L,1209L,2458L,1293L,2456L,205L,2454L,1297L,2452L,1201L,150L,1301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090293Inst : IEnumerable<long>
{
public static readonly long[] Value=A090293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090293.Bytes);
public long this[int i]=>Value[i];

public static A090293Inst Instance=new A090293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090292
{
public static readonly long[] Value={ 100L,81L,64L,49L,2116L,225L,1936L,1849L,1764L,1681L,8100L,57121L,238144L,56169L,236196L,1225L,234256L,54289L,232324L,53361L,6400L,52441L,228484L,51529L,226576L,5625L,224676L,49729L,222784L,48841L,4900L,47961L,6091024L,1481089L,6081156L,81225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090292Inst : IEnumerable<long>
{
public static readonly long[] Value=A090292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090292.Bytes);
public long this[int i]=>Value[i];

public static A090292Inst Instance=new A090292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090243
{
public static readonly long[] Value={ 1L,7L,2L,11L,6L,3L,13L,10L,5L,4L,19L,14L,9L,8L,23L,18L,15L,12L,25L,22L,17L,16L,31L,26L,21L,20L,35L,30L,27L,24L,37L,34L,29L,28L,43L,38L,33L,32L,47L,42L,39L,36L,49L,46L,41L,40L,55L,50L,45L,44L,59L,54L,51L,48L,61L,58L,53L,52L,67L,62L,57L,56L,71L,66L,63L,60L,73L,70L,65L,64L,79L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090243Inst : IEnumerable<long>
{
public static readonly long[] Value=A090243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090243.Bytes);
public long this[int i]=>Value[i];

public static A090243Inst Instance=new A090243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090242
{
public static readonly BigInteger[] Value={ 0L,1L,1L,2L,9L,125L,32768L,815730721L,154472377739119461L,BigInteger.Parse("144896287389534090178492559785984"),BigInteger.Parse("148707010444932320126692907511838968493975698947906494140625"),BigInteger.Parse("164607782908174441344270105333730757465593941470198419854718194253607242940724175602015628380155976898641449") };
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
public class A090242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090242Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A090242.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A090242.Bytes);
public BigInteger this[int i]=>Value[i];

public static A090242Inst Instance=new A090242Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090241
{
public static readonly BigInteger[] Value={ 0L,1L,1L,8L,243L,390625L,549755813888L,BigInteger.Parse("247064529073450392704413") };
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
public class A090241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090241Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A090241.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A090241.Bytes);
public BigInteger this[int i]=>Value[i];

public static A090241Inst Instance=new A090241Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090240
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,8L,9L,10L,11L,13L,14L,15L,17L,19L,21L,24L,25L,26L,27L,29L,31L,35L,37L,39L,41L,42L,44L,45L,46L,47L,48L,49L,50L,51L,53L,54L,60L,61L,70L,73L,75L,77L,78L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,91L,92L,94L,96L,97L,99L,101L,102L,105L,106L,107L,108L,110L,114L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090240Inst : IEnumerable<long>
{
public static readonly long[] Value=A090240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090240.Bytes);
public long this[int i]=>Value[i];

public static A090240Inst Instance=new A090240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090239
{
public static readonly long[] Value={ 2L,0L,1L,0L,1L,2L,1L,2L,0L,0L,1L,2L,1L,2L,0L,2L,0L,1L,1L,2L,0L,2L,0L,1L,0L,1L,2L,0L,1L,2L,1L,2L,0L,2L,0L,1L,1L,2L,0L,2L,0L,1L,0L,1L,2L,2L,0L,1L,0L,1L,2L,1L,2L,0L,1L,2L,0L,2L,0L,1L,0L,1L,2L,2L,0L,1L,0L,1L,2L,1L,2L,0L,0L,1L,2L,1L,2L,0L,2L,0L,1L,0L,1L,2L,1L,2L,0L,2L,0L,1L,1L,2L,0L,2L,0L,1L,0L,1L,2L,2L,0L,1L,0L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090239Inst : IEnumerable<long>
{
public static readonly long[] Value=A090239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090239.Bytes);
public long this[int i]=>Value[i];

public static A090239Inst Instance=new A090239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090238
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,1L,0L,6L,4L,1L,0L,24L,16L,6L,1L,0L,120L,72L,30L,8L,1L,0L,720L,372L,152L,48L,10L,1L,0L,5040L,2208L,828L,272L,70L,12L,1L,0L,40320L,14976L,4968L,1576L,440L,96L,14L,1L,0L,362880L,115200L,33192L,9696L,2720L,664L,126L,16L,1L,0L,3628800L,996480L,247968L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090238Inst : IEnumerable<long>
{
public static readonly long[] Value=A090238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090238.Bytes);
public long this[int i]=>Value[i];

public static A090238Inst Instance=new A090238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090237
{
public static readonly BigInteger[] Value={ 1L,8L,103L,1916L,58369L,2474474L,149329111L,10799140436L,1104684106441L,119612262552092L,16537863728067439L,2484826470387072806L,BigInteger.Parse("447865969660134667129"),BigInteger.Parse("86094083836577627060684") };
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
public class A090237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090237Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A090237.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A090237.Bytes);
public BigInteger this[int i]=>Value[i];

public static A090237Inst Instance=new A090237Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090236
{
public static readonly long[] Value={ 11L,13L,17L,31L,47L,53L,71L,79L,97L,113L,127L,131L,137L,139L,191L,199L,227L,229L,233L,313L,317L,331L,347L,349L,353L,359L,367L,419L,449L,457L,467L,479L,491L,503L,557L,569L,571L,577L,607L,617L,619L,647L,677L,691L,751L,757L,761L,797L,829L,839L,859L,911L,919L,929L,937L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090236Inst : IEnumerable<long>
{
public static readonly long[] Value=A090236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090236.Bytes);
public long this[int i]=>Value[i];

public static A090236Inst Instance=new A090236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090235
{
public static readonly long[] Value={ 2L,3L,5L,11L,29L,73L,167L,353L,709L,1399L,2819L,5987L,13469L,31379L,73453L,169151L,379787L,831031L,1779097L,3746051L,7796147L,16099711L,33087851L,67838549L,139068731L,285699959L,589374871L,1222450387L,2549640251L,5340811127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090235Inst : IEnumerable<long>
{
public static readonly long[] Value=A090235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090235.Bytes);
public long this[int i]=>Value[i];

public static A090235Inst Instance=new A090235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090234
{
public static readonly long[] Value={ 2L,1L,1L,3L,5L,1L,3L,1L,5L,11L,15L,1L,1L,21L,5L,11L,3L,1L,43L,9L,17L,13L,1L,1L,9L,7L,41L,23L,21L,25L,27L,9L,3L,1L,9L,3L,13L,11L,19L,3L,1L,35L,1L,23L,29L,5L,11L,27L,1L,39L,15L,9L,47L,75L,73L,11L,61L,1L,57L,3L,93L,57L,117L,69L,7L,93L,51L,33L,97L,143L,87L,65L,261L,15L,23L,39L,29L,55L,45L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090234Inst : IEnumerable<long>
{
public static readonly long[] Value=A090234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090234.Bytes);
public long this[int i]=>Value[i];

public static A090234Inst Instance=new A090234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090233
{
public static readonly long[] Value={ 11L,31L,71L,13L,41L,13L,17L,31L,13L,331L,761L,313L,751L,971L,919L,911L,661L,881L,211L,311L,571L,113L,541L,761L,313L,751L,521L,691L,661L,431L,421L,631L,619L,163L,331L,541L,317L,311L,281L,271L,491L,241L,211L,419L,137L,131L,127L,313L,281L,271L,251L,199L,191L,181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090233Inst : IEnumerable<long>
{
public static readonly long[] Value=A090233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090233.Bytes);
public long this[int i]=>Value[i];

public static A090233Inst Instance=new A090233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090232
{
public static readonly long[] Value={ 1789L,1797L,1801L,1809L,1817L,1825L,1829L,1837L,1841L,1841L,1845L,1849L,1850L,1853L,1857L,1861L,1865L,1869L,1877L,1881L,1881L,1885L,1889L,1893L,1897L,1901L,1909L,1913L,1921L,1923L,1929L,1933L,1945L,1953L,1961L,1963L,1969L,1974L,1977L,1981L,1989L,1993L,2001L,2009L,2017L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090232Inst : IEnumerable<long>
{
public static readonly long[] Value=A090232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090232.Bytes);
public long this[int i]=>Value[i];

public static A090232Inst Instance=new A090232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090231
{
public static readonly BigInteger[] Value={ 2L,3L,53L,7L,11L,13L,171311753L,19L,23L,292319L,31L,3731292319L,41L,4341373129L,47L,5347L,5953474341373129L,615953474341L,6761L,71L,7371676159L,797371676159L,837973716761L,BigInteger.Parse("8983797371676159534743413731292319171311753"),97L,101L };
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
public class A090231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090231Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A090231.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A090231.Bytes);
public BigInteger this[int i]=>Value[i];

public static A090231Inst Instance=new A090231Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090230
{
public static readonly long[] Value={ 12L,99L,169L,395L,499L,595L,606L,693L,824L,827L,840L,940L,1282L,1291L,1384L,1594L,1705L,1742L,1905L,2020L,2060L,2153L,2257L,2302L,2359L,2367L,2507L,2546L,2557L,2710L,2724L,2791L,2832L,2857L,3036L,3051L,3280L,3309L,3429L,3497L,3518L,3591L,3651L,3709L,3867L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090230Inst : IEnumerable<long>
{
public static readonly long[] Value=A090230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090230.Bytes);
public long this[int i]=>Value[i];

public static A090230Inst Instance=new A090230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090229
{
public static readonly long[] Value={ 1L,0L,7L,13L,13L,21L,89L,233L,233L,377L,1597L,1597L,2584L,4181L,6765L,28657L,28657L,46368L,75025L,121393L,514229L,514229L,832040L,1346269L,2178309L,3524578L,5702887L,9227465L,14930352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090229Inst : IEnumerable<long>
{
public static readonly long[] Value=A090229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090229.Bytes);
public long this[int i]=>Value[i];

public static A090229Inst Instance=new A090229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090228
{
public static readonly long[] Value={ 0L,1L,8L,168L,714L,1870L,7920L,54288L,229970L,602070L,2550408L,10803704L,28284465L,74049690L,193864606L,821223648L,3478759200L,9107509825L,23843770274L,62423800998L,264431464440L,1120149658760L,2932589879121L,7677619978602L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090228Inst : IEnumerable<long>
{
public static readonly long[] Value=A090228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090228.Bytes);
public long this[int i]=>Value[i];

public static A090228Inst Instance=new A090228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090195
{
public static readonly long[] Value={ 2L,41L,163L,181L,211L,431L,463L,613L,653L,853L,1163L,1381L,1483L,1613L,1801L,1861L,1873L,2011L,2063L,2141L,2221L,2243L,2411L,2633L,2851L,3041L,3181L,3583L,3623L,4211L,4241L,4363L,4421L,4463L,4483L,4603L,5563L,5581L,5821L,5851L,6113L,6143L,6203L,6553L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090195Inst : IEnumerable<long>
{
public static readonly long[] Value=A090195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090195.Bytes);
public long this[int i]=>Value[i];

public static A090195Inst Instance=new A090195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090194
{
public static readonly long[] Value={ 2L,43L,61L,263L,433L,461L,601L,641L,653L,661L,821L,857L,1061L,1063L,1187L,1361L,1423L,1487L,1613L,1811L,1871L,1877L,2063L,2081L,2143L,2161L,2621L,2801L,2837L,3061L,3163L,3581L,3623L,3631L,3643L,3851L,4561L,5087L,5261L,5381L,5623L,5807L,5861L,6011L,6053L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090194Inst : IEnumerable<long>
{
public static readonly long[] Value=A090194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090194.Bytes);
public long this[int i]=>Value[i];

public static A090194Inst Instance=new A090194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090193
{
public static readonly long[] Value={ 1L,2L,0L,2L,0L,1L,0L,1L,2L,2L,0L,1L,0L,1L,2L,1L,2L,0L,0L,1L,2L,1L,2L,0L,2L,0L,1L,2L,0L,1L,0L,1L,2L,1L,2L,0L,0L,1L,2L,1L,2L,0L,2L,0L,1L,1L,2L,0L,2L,0L,1L,0L,1L,2L,0L,1L,2L,1L,2L,0L,2L,0L,1L,1L,2L,0L,2L,0L,1L,0L,1L,2L,2L,0L,1L,0L,1L,2L,1L,2L,0L,2L,0L,1L,0L,1L,2L,1L,2L,0L,0L,1L,2L,1L,2L,0L,2L,0L,1L,1L,2L,0L,2L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090193Inst : IEnumerable<long>
{
public static readonly long[] Value=A090193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090193.Bytes);
public long this[int i]=>Value[i];

public static A090193Inst Instance=new A090193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090192
{
public static readonly long[] Value={ 1L,1L,0L,-1L,0L,2L,0L,-5L,0L,14L,0L,-42L,0L,132L,0L,-429L,0L,1430L,0L,-4862L,0L,16796L,0L,-58786L,0L,208012L,0L,-742900L,0L,2674440L,0L,-9694845L,0L,35357670L,0L,-129644790L,0L,477638700L,0L,-1767263190L,0L,6564120420L,0L,-24466267020L,0L,91482563640L,0L,-343059613650L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090192Inst : IEnumerable<long>
{
public static readonly long[] Value=A090192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090192.Bytes);
public long this[int i]=>Value[i];

public static A090192Inst Instance=new A090192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090191
{
public static readonly long[] Value={ 23L,47L,83L,167L,173L,263L,359L,383L,389L,467L,479L,503L,509L,557L,563L,587L,653L,719L,797L,839L,863L,887L,907L,971L,983L,1103L,1187L,1259L,1283L,1307L,1367L,1439L,1499L,1511L,1523L,1571L,1579L,1637L,1733L,1823L,1907L,1913L,2039L,2063L,2099L,2203L,2207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090191Inst : IEnumerable<long>
{
public static readonly long[] Value=A090191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090191.Bytes);
public long this[int i]=>Value[i];

public static A090191Inst Instance=new A090191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090190
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,17L,19L,29L,31L,37L,41L,43L,53L,59L,61L,67L,71L,73L,79L,89L,97L,101L,103L,107L,109L,113L,127L,131L,137L,139L,149L,151L,157L,163L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L,239L,241L,251L,257L,269L,271L,277L,281L,283L,293L,307L,311L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090190Inst : IEnumerable<long>
{
public static readonly long[] Value=A090190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090190.Bytes);
public long this[int i]=>Value[i];

public static A090190Inst Instance=new A090190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090189
{
public static readonly long[] Value={ 3L,2L,1L,1L,1L,1L,2L,1L,3L,5L,2L,4L,6L,3L,5L,7L,26L,5L,7L,11L,10L,1L,1L,1L,11L,5L,3L,8L,3L,20L,14L,4L,2L,39L,1L,16L,4L,6L,3L,56L,8L,7L,17L,14L,4L,21L,7L,13L,13L,22L,30L,10L,22L,6L,2L,43L,3L,17L,26L,21L,32L,10L,28L,30L,15L,28L,22L,74L,23L,33L,11L,8L,1L,4L,3L,5L,2L,29L,3L,68L,36L,14L,1L,133L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090189Inst : IEnumerable<long>
{
public static readonly long[] Value=A090189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090189.Bytes);
public long this[int i]=>Value[i];

public static A090189Inst Instance=new A090189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090188
{
public static readonly BigInteger[] Value={ 3L,7L,23L,199L,2297L,30013L,1021001L,9699667L,669278581L,32348466119L,401120980223L,29682952539199L,1825501581163217L,39248283995010043L,3074448912942456997L,BigInteger.Parse("228124109340330313051"),BigInteger.Parse("49991769104009528615759") };
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
public class A090188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090188Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A090188.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A090188.Bytes);
public BigInteger this[int i]=>Value[i];

public static A090188Inst Instance=new A090188Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090187
{
public static readonly long[] Value={ 2L,13L,79L,101L,167L,211L,233L,277L,409L,431L,541L,563L,607L,673L,739L,761L,827L,937L,1069L,1091L,1201L,1223L,1289L,1399L,1487L,1531L,1553L,1597L,1619L,1663L,1861L,1949L,1993L,2081L,2213L,2389L,2411L,2477L,2521L,2543L,2609L,2719L,2741L,2851L,2917L,2939L,3049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090187Inst : IEnumerable<long>
{
public static readonly long[] Value=A090187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090187.Bytes);
public long this[int i]=>Value[i];

public static A090187Inst Instance=new A090187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090186
{
public static readonly BigInteger[] Value={ 5L,11L,37L,431L,13873L,30047L,510529L,9699713L,446185769L,51757545871L,601681470427L,22262214404471L,2434002108217723L,13082761331670077L,1229779565176982873L,BigInteger.Parse("32589158477190044789"),BigInteger.Parse("1922760350154212639131") };
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
public class A090186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090186Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A090186.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A090186.Bytes);
public BigInteger this[int i]=>Value[i];

public static A090186Inst Instance=new A090186Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090185
{
public static readonly long[] Value={ 1L,1L,1L,2L,6L,1L,1L,1L,2L,8L,3L,3L,8L,1L,2L,1L,1L,5L,12L,10L,1L,2L,18L,4L,3L,4L,14L,26L,2L,7L,38L,3L,15L,13L,8L,23L,42L,6L,45L,12L,5L,11L,26L,2L,3L,2L,16L,9L,7L,21L,39L,21L,76L,2L,18L,16L,42L,37L,6L,23L,10L,8L,51L,28L,33L,8L,94L,22L,4L,2L,11L,53L,1L,53L,10L,3L,10L,97L,19L,25L,4L,4L,15L,38L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090185Inst : IEnumerable<long>
{
public static readonly long[] Value=A090185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090185.Bytes);
public long this[int i]=>Value[i];

public static A090185Inst Instance=new A090185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090184
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,2L,3L,3L,4L,5L,5L,6L,7L,9L,10L,11L,13L,14L,17L,19L,22L,25L,28L,33L,37L,41L,43L,49L,55L,65L,73L,82L,86L,97L,109L,122L,129L,145L,163L,171L,193L,217L,244L,257L,289L,325L,342L,365L,385L,433L,487L,513L,577L,649L,683L,730L,769L,865L,973L,1025L,1094L,1153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090184Inst : IEnumerable<long>
{
public static readonly long[] Value=A090184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090184.Bytes);
public long this[int i]=>Value[i];

public static A090184Inst Instance=new A090184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090183
{
public static readonly long[] Value={ 5L,2L,3L,6L,3L,4L,1L,4L,5L,2L,3L,6L,5L,2L,1L,6L,3L,4L,1L,6L,3L,4L,1L,6L,5L,2L,3L,6L,3L,4L,1L,4L,3L,4L,3L,6L,5L,2L,1L,4L,5L,4L,1L,4L,5L,4L,1L,6L,3L,2L,1L,6L,5L,2L,1L,6L,3L,4L,3L,6L,3L,4L,3L,4L,5L,4L,1L,6L,3L,4L,3L,4L,5L,2L,3L,4L,3L,2L,1L,4L,5L,2L,3L,4L,5L,2L,3L,6L,3L,4L,1L,4L,5L,2L,1L,6L,3L,4L,3L,6L,3L,2L,3L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090183Inst : IEnumerable<long>
{
public static readonly long[] Value=A090183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090183.Bytes);
public long this[int i]=>Value[i];

public static A090183Inst Instance=new A090183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090182
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,5L,3L,1L,1L,1L,14L,17L,4L,1L,1L,1L,42L,171L,43L,5L,1L,1L,1L,132L,3113L,1252L,89L,6L,1L,1L,1L,429L,106419L,104098L,5885L,161L,7L,1L,1L,1L,1430L,7035649L,25511272L,1518897L,20466L,265L,8L,1L,1L,1L,4862L,915028347L,18649337311L,1558435125L,12833546L,57799L,407L,9L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090182Inst : IEnumerable<long>
{
public static readonly long[] Value=A090182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090182.Bytes);
public long this[int i]=>Value[i];

public static A090182Inst Instance=new A090182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090181
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,1L,3L,1L,0L,1L,6L,6L,1L,0L,1L,10L,20L,10L,1L,0L,1L,15L,50L,50L,15L,1L,0L,1L,21L,105L,175L,105L,21L,1L,0L,1L,28L,196L,490L,490L,196L,28L,1L,0L,1L,36L,336L,1176L,1764L,1176L,336L,36L,1L,0L,1L,45L,540L,2520L,5292L,5292L,2520L,540L,45L,1L,0L,1L,55L,825L,4950L,13860L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090181Inst : IEnumerable<long>
{
public static readonly long[] Value=A090181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090181.Bytes);
public long this[int i]=>Value[i];

public static A090181Inst Instance=new A090181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090180
{
public static readonly long[] Value={ 2L,3L,23L,61L,131L,151L,331L,601L,661L,1013L,1033L,1103L,1123L,1231L,1237L,1259L,1307L,1321L,1811L,2131L,2621L,2861L,3301L,4021L,4159L,4373L,4463L,4733L,4759L,4801L,5059L,5101L,6151L,6229L,6397L,6737L,7079L,7369L,7433L,8191L,9109L,10181L,10691L,11119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090180Inst : IEnumerable<long>
{
public static readonly long[] Value=A090180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090180.Bytes);
public long this[int i]=>Value[i];

public static A090180Inst Instance=new A090180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090131
{
public static readonly long[] Value={ 1L,3L,4L,2L,-4L,-12L,-16L,-8L,16L,48L,64L,32L,-64L,-192L,-256L,-128L,256L,768L,1024L,512L,-1024L,-3072L,-4096L,-2048L,4096L,12288L,16384L,8192L,-16384L,-49152L,-65536L,-32768L,65536L,196608L,262144L,131072L,-262144L,-786432L,-1048576L,-524288L,1048576L,3145728L,4194304L,2097152L,-4194304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090131Inst : IEnumerable<long>
{
public static readonly long[] Value=A090131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090131.Bytes);
public long this[int i]=>Value[i];

public static A090131Inst Instance=new A090131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090130
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,77L,684L,34297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090130Inst : IEnumerable<long>
{
public static readonly long[] Value=A090130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090130.Bytes);
public long this[int i]=>Value[i];

public static A090130Inst Instance=new A090130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090129
{
public static readonly long[] Value={ 1L,2L,2L,4L,8L,16L,32L,64L,128L,256L,512L,1024L,2048L,4096L,8192L,16384L,32768L,65536L,131072L,262144L,524288L,1048576L,2097152L,4194304L,8388608L,16777216L,33554432L,67108864L,134217728L,268435456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090129Inst : IEnumerable<long>
{
public static readonly long[] Value=A090129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090129.Bytes);
public long this[int i]=>Value[i];

public static A090129Inst Instance=new A090129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090128
{
public static readonly long[] Value={ 1L,3L,4L,7L,6L,12L,8L,15L,13L,18L,28L,14L,24L,31L,39L,20L,42L,32L,36L,60L,40L,56L,30L,72L,63L,48L,54L,91L,38L,90L,96L,44L,84L,78L,124L,57L,93L,98L,120L,80L,168L,62L,104L,127L,144L,68L,126L,195L,74L,114L,140L,186L,121L,224L,108L,132L,180L,234L,112L,128L,252L,171L,156L,217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090128Inst : IEnumerable<long>
{
public static readonly long[] Value=A090128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090128.Bytes);
public long this[int i]=>Value[i];

public static A090128Inst Instance=new A090128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090127
{
public static readonly long[] Value={ 1L,2L,4L,6L,10L,12L,8L,16L,18L,22L,20L,28L,30L,24L,36L,40L,42L,46L,32L,52L,58L,60L,48L,66L,44L,70L,72L,78L,54L,82L,64L,56L,88L,96L,100L,102L,106L,108L,112L,110L,80L,126L,84L,130L,136L,138L,92L,120L,148L,150L,156L,104L,132L,162L,166L,172L,116L,178L,180L,144L,160L,190L,192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090127Inst : IEnumerable<long>
{
public static readonly long[] Value=A090127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090127.Bytes);
public long this[int i]=>Value[i];

public static A090127Inst Instance=new A090127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090126
{
public static readonly long[] Value={ 6L,30L,42L,66L,2730L,510L,798L,330L,138L,870L,14322L,1919190L,13530L,1806L,690L,282L,46410L,1590L,354L,56786730L,64722L,4686L,140100870L,3318L,230010L,498L,3404310L,61410L,272118L,1410L,4501770L,33330L,4326L,642L,209191710L,1518L,1671270L,1770L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090126Inst : IEnumerable<long>
{
public static readonly long[] Value=A090126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090126.Bytes);
public long this[int i]=>Value[i];

public static A090126Inst Instance=new A090126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090125
{
public static readonly long[] Value={ 5L,2L,2L,2L,411L,195L,2L,392L,141L,105L,1161L,909L,69L,3243L,171L,370L,1659L,165L,26289L,1065L,8541L,19593L,43521L,1323L,84651L,25767L,25641L,7029L,63009L,693L,231L,957L,2601L,7137L,368265L,14769L,8169L,13071L,23679L,45L,13875L,6693L,136611L,34869L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090125Inst : IEnumerable<long>
{
public static readonly long[] Value=A090125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090125.Bytes);
public long this[int i]=>Value[i];

public static A090125Inst Instance=new A090125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090124
{
public static readonly BigInteger[] Value={ 5L,4L,8L,16L,11727599043051L,54980371265625L,128L,BigInteger.Parse("557556054479199010816"),BigInteger.Parse("22027845102081762861"),BigInteger.Parse("162889462677744140625"),BigInteger.Parse("803596764671634487466709"),BigInteger.Parse("14231716419191575233132742871310396257144854491849") };
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
public class A090124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090124Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A090124.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A090124.Bytes);
public BigInteger this[int i]=>Value[i];

public static A090124Inst Instance=new A090124Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090123
{
public static readonly long[] Value={ 1L,411L,741L,819L,4041L,6165L,6315L,6861L,10281L,11025L,12489L,12579L,13119L,14331L,15225L,16095L,19125L,19881L,19929L,20799L,22461L,24051L,24885L,25815L,25971L,26979L,27075L,29955L,30801L,31641L,32661L,37371L,38361L,39369L,41181L,42681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090123Inst : IEnumerable<long>
{
public static readonly long[] Value=A090123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090123.Bytes);
public long this[int i]=>Value[i];

public static A090123Inst Instance=new A090123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090122
{
public static readonly long[] Value={ 2L,3L,21L,34L,46L,87L,99L,129L,141L,220L,242L,254L,266L,278L,279L,476L,526L,550L,616L,627L,657L,772L,777L,783L,795L,1072L,1088L,1322L,1442L,1486L,1540L,1552L,1586L,1653L,1725L,1833L,1959L,1994L,2001L,2043L,2068L,2192L,2224L,2360L,2384L,2432L,2734L,2770L,2866L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090122Inst : IEnumerable<long>
{
public static readonly long[] Value=A090122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090122.Bytes);
public long this[int i]=>Value[i];

public static A090122Inst Instance=new A090122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090121
{
public static readonly long[] Value={ 2L,129L,189L,369L,435L,549L,555L,561L,819L,1245L,1491L,1719L,1779L,1839L,1875L,1935L,2175L,2289L,2415L,2451L,2595L,2709L,2769L,3141L,3441L,4401L,4611L,4851L,5655L,5775L,6075L,6099L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090121Inst : IEnumerable<long>
{
public static readonly long[] Value=A090121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090121.Bytes);
public long this[int i]=>Value[i];

public static A090121Inst Instance=new A090121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090120
{
public static readonly long[] Value={ 3L,4L,9L,10L,14L,15L,20L,21L,26L,33L,40L,110L,117L,124L,146L,206L,237L,250L,273L,303L,309L,326L,340L,350L,387L,429L,436L,440L,441L,447L,470L,513L,561L,573L,609L,634L,686L,704L,807L,897L,920L,1004L,1035L,1054L,1060L,1071L,1113L,1124L,1143L,1156L,1233L,1239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090120Inst : IEnumerable<long>
{
public static readonly long[] Value=A090120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090120.Bytes);
public long this[int i]=>Value[i];

public static A090120Inst Instance=new A090120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090119
{
public static readonly long[] Value={ 5L,11L,29L,367L,149L,631L,127L,1949L,541L,907L,3251L,1693L,2503L,10427L,5779L,10831L,10007L,22229L,30631L,25301L,121123L,76207L,93047L,157627L,212557L,35729L,119027L,1121509L,190979L,672439L,693943L,1004027L,259099L,1646101L,675713L,1207841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090119Inst : IEnumerable<long>
{
public static readonly long[] Value=A090119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090119.Bytes);
public long this[int i]=>Value[i];

public static A090119Inst Instance=new A090119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090118
{
public static readonly long[] Value={ 3L,7L,23L,359L,139L,619L,113L,1933L,523L,887L,3229L,1669L,2477L,10399L,5749L,10799L,9973L,22193L,30593L,25261L,121081L,76163L,93001L,157579L,212507L,35677L,118973L,1121453L,190921L,672379L,693881L,1003963L,259033L,1646033L,675643L,1207769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090118Inst : IEnumerable<long>
{
public static readonly long[] Value=A090118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090118.Bytes);
public long this[int i]=>Value[i];

public static A090118Inst Instance=new A090118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090117
{
public static readonly long[] Value={ 4L,9L,25L,361L,144L,625L,121L,1936L,529L,900L,3249L,1681L,2500L,10404L,5776L,10816L,10000L,22201L,30625L,25281L,121104L,76176L,93025L,157609L,212521L,35721L,119025L,1121481L,190969L,672400L,693889L,1004004L,259081L,1646089L,675684L,1207801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090117Inst : IEnumerable<long>
{
public static readonly long[] Value=A090117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090117.Bytes);
public long this[int i]=>Value[i];

public static A090117Inst Instance=new A090117Inst();

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