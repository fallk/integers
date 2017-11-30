using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A277845
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,10L,9L,18L,17L,24L,20L,22L,44L,40L,36L,30L,27L,25L,23L,21L,19L,28L,26L,32L,29L,31L,34L,37L,74L,67L,60L,54L,49L,45L,41L,42L,38L,35L,70L,63L,57L,50L,55L,110L,99L,90L,81L,73L,66L,72L,65L,59L,64L,58L,53L,48L,52L,47L,43L,39L,78L,71L,142L,100L,101L,91L,82L,80L,88L,96L,87L,79L,86L,92L,83L,75L,68L,62L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277845Inst : IEnumerable<long>
{
public static readonly long[] Value=A277845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277845.Bytes);
public long this[int i]=>Value[i];

public static A277845Inst Instance=new A277845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277846
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,10L,9L,18L,17L,24L,20L,22L,44L,40L,36L,30L,27L,25L,23L,21L,19L,28L,26L,32L,29L,31L,34L,37L,74L,67L,60L,54L,49L,45L,41L,42L,38L,35L,70L,63L,57L,50L,55L,110L,99L,90L,81L,73L,66L,72L,65L,59L,64L,58L,53L,48L,52L,47L,43L,39L,78L,71L,88L,80L,160L,100L,101L,91L,82L,84L,76L,69L,75L,68L,62L,56L,51L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277846Inst : IEnumerable<long>
{
public static readonly long[] Value=A277846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277846.Bytes);
public long this[int i]=>Value[i];

public static A277846Inst Instance=new A277846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277847
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,4L,4L,2L,4L,4L,6L,4L,4L,8L,4L,2L,2L,8L,10L,4L,8L,12L,12L,4L,6L,8L,10L,8L,8L,8L,16L,2L,12L,4L,8L,8L,10L,20L,8L,4L,6L,16L,22L,12L,8L,24L,24L,4L,22L,12L,4L,8L,14L,20L,12L,8L,20L,16L,30L,8L,16L,32L,16L,2L,8L,24L,34L,4L,24L,16L,36L,8L,10L,20L,12L,20L,24L,16L,40L,4L,28L,12L,42L,16L,4L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277847Inst : IEnumerable<long>
{
public static readonly long[] Value=A277847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277847.Bytes);
public long this[int i]=>Value[i];

public static A277847Inst Instance=new A277847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277848
{
public static readonly long[] Value={ 1L,7L,2L,5L,18L,21L,11L,8L,28L,35L,46L,74L,54L,25L,3L,129L,32L,39L,78L,58L,133L,43L,62L,6L,95L,91L,152L,171L,87L,71L,190L,16L,148L,328L,19L,181L,167L,51L,227L,405L,618L,355L,344L,254L,440L,83L,926L,22L,67L,277L,100L,157L,1400L,195L,333L,186L,1144L,232L,259L,445L,282L,105L,12L,237L,110L,115L,388L,211L,468L,383L,492L,144L,594L,307L,366L,206L,126L,533L,324L,9L,463L,642L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277848Inst : IEnumerable<long>
{
public static readonly long[] Value=A277848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277848.Bytes);
public long this[int i]=>Value[i];

public static A277848Inst Instance=new A277848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277849
{
public static readonly BigInteger[] Value={ 0L,0L,1L,22L,343L,4664L,58985L,713306L,8367627L,96021949L,1083676281L,12071330713L,133058986145L,1454046651577L,15775034417009L,170096023182441L,1824417021947873L,19478738120713305L,207133060219478737L,2194787392318244180L,BigInteger.Parse("23182441824417009723") };
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
public class A277849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277849Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277849.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277849Inst Instance=new A277849Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277850
{
public static readonly BigInteger[] Value={ 0L,1L,2L,4L,16L,3L,9L,81L,5L,25L,625L,7L,49L,2401L,8L,64L,4096L,16777216L,17L,289L,6L,36L,1296L,1679616L,15L,225L,50625L,11L,121L,14641L,10L,100L,10000L,100000000L,19L,361L,130321L,12L,144L,20736L,429981696L,20L,400L,160000L,25600000000L,24L,576L,331776L,13L,169L,28561L,815730721L,21L,441L,194481L,37822859361L,BigInteger.Parse("1430568690241985328321") };
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
public class A277850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277850Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277850.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277850Inst Instance=new A277850Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277851
{
public static readonly long[] Value={ 3L,6L,7L,8L,11L,13L,14L,18L,19L,20L,21L,22L,23L,25L,26L,29L,30L,32L,34L,35L,38L,39L,40L,43L,44L,45L,47L,51L,53L,54L,56L,58L,62L,67L,68L,69L,70L,71L,72L,74L,75L,77L,78L,80L,82L,83L,87L,89L,90L,91L,92L,94L,97L,98L,99L,102L,103L,104L,105L,106L,107L,108L,110L,111L,112L,115L,117L,118L,119L,120L,122L,123L,125L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277851Inst : IEnumerable<long>
{
public static readonly long[] Value=A277851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277851.Bytes);
public long this[int i]=>Value[i];

public static A277851Inst Instance=new A277851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277852
{
public static readonly long[] Value={ 1L,2L,4L,5L,9L,15L,16L,24L,59L,61L,81L,100L,124L,129L,152L,169L,196L,249L,305L,400L,425L,475L,520L,556L,565L,676L,771L,795L,904L,939L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277852Inst : IEnumerable<long>
{
public static readonly long[] Value=A277852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277852.Bytes);
public long this[int i]=>Value[i];

public static A277852Inst Instance=new A277852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277853
{
public static readonly long[] Value={ 1L,2L,4L,5L,21L,27L,44L,104L,173L,365L,369L,500L,590L,735L,840L,987L,1564L,1797L,2415L,3368L,3545L,4025L,4466L,5018L,5477L,6686L,7239L,8025L,8182L,9369L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277853Inst : IEnumerable<long>
{
public static readonly long[] Value=A277853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277853.Bytes);
public long this[int i]=>Value[i];

public static A277853Inst Instance=new A277853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277854
{
public static readonly long[] Value={ 1L,2L,4L,5L,9L,15L,16L,48L,64L,86L,100L,144L,169L,3364L,3969L,4096L,195364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277854Inst : IEnumerable<long>
{
public static readonly long[] Value=A277854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277854.Bytes);
public long this[int i]=>Value[i];

public static A277854Inst Instance=new A277854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277855
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,2L,1L,1L,1L,4L,3L,3L,3L,2L,2L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,5L,4L,4L,4L,4L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277855Inst : IEnumerable<long>
{
public static readonly long[] Value=A277855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277855.Bytes);
public long this[int i]=>Value[i];

public static A277855Inst Instance=new A277855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277856
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,111L,212L,216L,612L,1111L,1113L,1131L,1311L,2112L,3111L,4224L,4416L,6144L,11111L,11133L,11313L,11331L,11711L,13113L,13131L,13311L,21112L,21132L,21312L,23112L,23424L,31113L,31131L,31311L,33111L,42432L,42624L,111111L,211112L,211116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277856Inst : IEnumerable<long>
{
public static readonly long[] Value=A277856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277856.Bytes);
public long this[int i]=>Value[i];

public static A277856Inst Instance=new A277856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277857
{
public static readonly long[] Value={ 1L,2L,8L,9L,10L,16L,17L,29L,36L,64L,72L,73L,80L,81L,128L,136L,153L,160L,197L,218L,232L,244L,277L,281L,288L,314L,349L,397L,405L,433L,466L,468L,512L,514L,521L,557L,576L,577L,584L,586L,593L,637L,640L,648L,701L,738L,757L,794L,801L,853L,857L,881L,882L,953L,980L,1024L,1028L,1088L,1152L,1217L,1224L,1249L,1268L,1280L,1332L,1341L,1396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277857Inst : IEnumerable<long>
{
public static readonly long[] Value=A277857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277857.Bytes);
public long this[int i]=>Value[i];

public static A277857Inst Instance=new A277857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277858
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,10L,9L,18L,17L,24L,20L,22L,44L,40L,36L,30L,27L,25L,23L,21L,19L,28L,26L,32L,29L,31L,34L,37L,74L,67L,60L,54L,49L,45L,41L,42L,38L,35L,70L,63L,57L,50L,55L,110L,99L,90L,81L,73L,66L,72L,65L,59L,64L,58L,53L,48L,52L,47L,43L,39L,78L,71L,142L,100L,101L,91L,82L,80L,88L,96L,87L,79L,86L,92L,83L,75L,68L,62L,56L,51L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277858Inst : IEnumerable<long>
{
public static readonly long[] Value=A277858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277858.Bytes);
public long this[int i]=>Value[i];

public static A277858Inst Instance=new A277858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277859
{
public static readonly long[] Value={ 2L,3L,2L,4L,2L,7L,2L,3L,2L,11L,2L,4L,2L,3L,2L,4L,2L,19L,2L,3L,2L,23L,2L,4L,2L,3L,2L,4L,2L,31L,2L,3L,2L,5L,2L,4L,2L,3L,2L,4L,2L,9L,2L,3L,2L,47L,2L,4L,2L,3L,2L,4L,2L,5L,2L,3L,2L,59L,2L,4L,2L,3L,2L,4L,2L,45L,2L,3L,2L,15L,2L,4L,2L,3L,2L,4L,2L,9L,2L,3L,2L,83L,2L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277859Inst : IEnumerable<long>
{
public static readonly long[] Value=A277859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277859.Bytes);
public long this[int i]=>Value[i];

public static A277859Inst Instance=new A277859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277892
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,3L,1L,2L,1L,4L,2L,5L,2L,2L,2L,6L,1L,7L,2L,2L,1L,8L,1L,3L,2L,2L,2L,9L,1L,10L,1L,3L,2L,3L,2L,11L,2L,2L,1L,12L,1L,13L,3L,3L,1L,14L,2L,4L,2L,3L,2L,15L,1L,3L,1L,3L,4L,16L,3L,17L,3L,3L,2L,4L,1L,18L,3L,3L,1L,19L,1L,20L,2L,2L,3L,4L,2L,21L,3L,3L,2L,22L,3L,3L,2L,2L,1L,23L,2L,4L,3L,5L,3L,4L,1L,24L,1L,3L,2L,25L,1L,26L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277892Inst : IEnumerable<long>
{
public static readonly long[] Value=A277892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277892.Bytes);
public long this[int i]=>Value[i];

public static A277892Inst Instance=new A277892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277893
{
public static readonly long[] Value={ 0L,4L,6L,9L,8L,25L,10L,12L,18L,49L,14L,93L,15L,16L,20L,169L,22L,287L,21L,26L,24L,361L,30L,33L,27L,28L,34L,529L,32L,802L,40L,35L,36L,44L,38L,934L,39L,48L,42L,1333L,46L,1681L,45L,51L,54L,1754L,50L,58L,52L,55L,64L,2209L,56L,57L,66L,60L,65L,2809L,62L,2966L,63L,68L,74L,77L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277893Inst : IEnumerable<long>
{
public static readonly long[] Value=A277893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277893.Bytes);
public long this[int i]=>Value[i];

public static A277893Inst Instance=new A277893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277894
{
public static readonly long[] Value={ 0L,0L,0L,0L,3L,0L,4L,0L,6L,5L,8L,0L,9L,0L,12L,14L,15L,0L,10L,0L,16L,20L,18L,0L,22L,7L,21L,26L,27L,0L,24L,0L,30L,25L,28L,33L,34L,0L,36L,38L,32L,0L,40L,0L,35L,44L,42L,0L,39L,11L,48L,45L,50L,0L,46L,51L,54L,55L,49L,0L,57L,0L,60L,62L,52L,58L,56L,0L,63L,68L,66L,0L,70L,0L,64L,74L,69L,65L,75L,0L,76L,80L,78L,0L,81L,84L,82L,86L,72L,0L,87L,77L,85L,13L,92L,91L,88L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277894Inst : IEnumerable<long>
{
public static readonly long[] Value=A277894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277894.Bytes);
public long this[int i]=>Value[i];

public static A277894Inst Instance=new A277894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277895
{
public static readonly long[] Value={ 0L,1L,2L,1L,3L,1L,4L,2L,5L,1L,3L,1L,4L,5L,6L,1L,6L,1L,7L,8L,7L,1L,8L,2L,9L,10L,11L,1L,9L,1L,10L,3L,12L,4L,13L,1L,14L,15L,11L,1L,12L,1L,5L,6L,13L,1L,16L,2L,17L,7L,18L,1L,14L,8L,15L,9L,3L,1L,10L,1L,11L,12L,19L,4L,16L,1L,13L,14L,17L,1L,18L,1L,20L,21L,15L,5L,22L,1L,16L,17L,23L,1L,18L,19L,24L,25L,19L,1L,26L,6L,20L,2L,21L,7L,20L,1L,21L,22L,27L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277895Inst : IEnumerable<long>
{
public static readonly long[] Value=A277895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277895.Bytes);
public long this[int i]=>Value[i];

public static A277895Inst Instance=new A277895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277896
{
public static readonly long[] Value={ 0L,0L,4L,0L,9L,8L,25L,0L,12L,18L,49L,16L,121L,50L,20L,0L,169L,24L,289L,27L,28L,98L,361L,32L,45L,242L,36L,75L,529L,40L,841L,0L,44L,338L,63L,48L,961L,578L,52L,54L,1369L,56L,1681L,147L,60L,722L,1849L,64L,175L,90L,68L,363L,2209L,72L,99L,150L,76L,1058L,2809L,80L,3481L,1682L,84L,0L,117L,88L,3721L,507L,92L,126L,4489L,96L,5041L,1922L,100L,867L,275L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277896Inst : IEnumerable<long>
{
public static readonly long[] Value=A277896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277896.Bytes);
public long this[int i]=>Value[i];

public static A277896Inst Instance=new A277896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277897
{
public static readonly long[] Value={ 3L,5L,4L,7L,9L,6L,11L,25L,12L,8L,13L,49L,33L,14L,10L,17L,93L,58L,35L,15L,18L,19L,169L,119L,65L,44L,16L,22L,23L,287L,185L,121L,77L,45L,20L,24L,29L,361L,289L,209L,124L,91L,51L,21L,30L,31L,529L,437L,299L,214L,143L,95L,55L,26L,32L,37L,802L,589L,473L,323L,221L,161L,106L,57L,27L,40L,41L,934L,841L,611L,493L,327L,247L,177L,111L,60L,28L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277897Inst : IEnumerable<long>
{
public static readonly long[] Value=A277897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277897.Bytes);
public long this[int i]=>Value[i];

public static A277897Inst Instance=new A277897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277898
{
public static readonly long[] Value={ 3L,4L,5L,6L,9L,7L,8L,12L,25L,11L,10L,14L,33L,49L,13L,18L,15L,35L,58L,93L,17L,22L,16L,44L,65L,119L,169L,19L,24L,20L,45L,77L,121L,185L,287L,23L,30L,21L,51L,91L,124L,209L,289L,361L,29L,32L,26L,55L,95L,143L,214L,299L,437L,529L,31L,40L,27L,57L,106L,161L,221L,323L,473L,589L,802L,37L,42L,28L,60L,111L,177L,247L,327L,493L,611L,841L,934L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277898Inst : IEnumerable<long>
{
public static readonly long[] Value=A277898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277898.Bytes);
public long this[int i]=>Value[i];

public static A277898Inst Instance=new A277898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277899
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,0L,2L,1L,2L,0L,1L,0L,0L,0L,3L,2L,3L,1L,3L,2L,2L,0L,2L,1L,2L,0L,1L,0L,0L,0L,4L,3L,4L,2L,4L,3L,3L,1L,3L,3L,3L,2L,3L,2L,2L,0L,3L,2L,3L,1L,3L,2L,2L,0L,2L,1L,2L,0L,1L,0L,0L,0L,5L,4L,5L,3L,5L,4L,4L,2L,4L,4L,4L,3L,4L,3L,4L,1L,4L,3L,4L,3L,4L,3L,4L,2L,4L,3L,4L,2L,3L,2L,2L,0L,4L,3L,4L,2L,4L,3L,3L,1L,3L,3L,3L,2L,3L,2L,3L,0L,3L,2L,3L,1L,3L,2L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277899Inst : IEnumerable<long>
{
public static readonly long[] Value=A277899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277899.Bytes);
public long this[int i]=>Value[i];

public static A277899Inst Instance=new A277899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277900
{
public static readonly long[] Value={ 4L,9L,25L,49L,93L,169L,287L,361L,529L,802L,934L,1333L,1681L,1754L,2209L,2809L,2966L,3482L,4453L,5041L,5329L,6241L,5378L,6374L,9167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277900Inst : IEnumerable<long>
{
public static readonly long[] Value=A277900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277900.Bytes);
public long this[int i]=>Value[i];

public static A277900Inst Instance=new A277900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277901
{
public static readonly long[] Value={ 1L,2L,3L,7L,6L,5L,4L,13L,9L,10L,14L,15L,11L,8L,12L,25L,23L,27L,26L,30L,31L,28L,18L,17L,21L,22L,29L,19L,24L,20L,16L,49L,43L,57L,50L,45L,55L,52L,46L,34L,61L,62L,33L,59L,36L,54L,56L,51L,41L,42L,63L,47L,58L,39L,44L,37L,53L,40L,38L,60L,35L,32L,48L,97L,83L,125L,98L,75L,103L,100L,86L,119L,109L,110L,89L,107L,92L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277901Inst : IEnumerable<long>
{
public static readonly long[] Value=A277901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277901.Bytes);
public long this[int i]=>Value[i];

public static A277901Inst Instance=new A277901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277902
{
public static readonly long[] Value={ 1L,2L,3L,7L,6L,5L,4L,14L,9L,10L,13L,15L,8L,11L,12L,31L,24L,23L,28L,30L,25L,26L,17L,29L,16L,19L,18L,22L,27L,20L,21L,62L,43L,40L,61L,45L,56L,59L,54L,58L,49L,50L,33L,55L,36L,39L,52L,63L,32L,35L,48L,38L,57L,46L,37L,47L,34L,53L,44L,60L,41L,42L,51L,127L,102L,85L,124L,120L,121L,122L,83L,95L,112L,115L,68L,118L,89L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277902Inst : IEnumerable<long>
{
public static readonly long[] Value=A277902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277902.Bytes);
public long this[int i]=>Value[i];

public static A277902Inst Instance=new A277902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277903
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,4L,4L,4L,4L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277903Inst : IEnumerable<long>
{
public static readonly long[] Value=A277903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277903.Bytes);
public long this[int i]=>Value[i];

public static A277903Inst Instance=new A277903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277904
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,0L,1L,2L,3L,0L,1L,2L,3L,0L,1L,2L,3L,4L,5L,0L,1L,2L,3L,4L,5L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277904Inst : IEnumerable<long>
{
public static readonly long[] Value=A277904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277904.Bytes);
public long this[int i]=>Value[i];

public static A277904Inst Instance=new A277904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277905
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,5L,9L,12L,16L,10L,18L,24L,32L,15L,20L,27L,36L,48L,64L,30L,40L,54L,72L,96L,128L,7L,25L,45L,60L,80L,81L,108L,144L,192L,256L,14L,50L,90L,120L,160L,162L,216L,288L,384L,512L,21L,28L,75L,100L,135L,180L,240L,243L,320L,324L,432L,576L,768L,1024L,42L,56L,150L,200L,270L,360L,480L,486L,640L,648L,864L,1152L,1536L,2048L,35L,63L,84L,112L,125L,225L,300L,400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277905Inst : IEnumerable<long>
{
public static readonly long[] Value=A277905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277905.Bytes);
public long this[int i]=>Value[i];

public static A277905Inst Instance=new A277905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277906
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,2L,6L,4L,6L,4L,6L,4L,12L,6L,8L,8L,16L,6L,12L,8L,12L,6L,6L,8L,12L,12L,12L,12L,12L,8L,30L,16L,12L,16L,24L,12L,36L,12L,24L,16L,24L,12L,30L,12L,24L,6L,6L,16L,30L,12L,32L,24L,12L,12L,24L,24L,36L,12L,6L,16L,60L,30L,36L,32L,48L,12L,30L,32L,12L,24L,30L,24L,72L,36L,24L,36L,60L,24L,30L,32L,24L,24L,6L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277906Inst : IEnumerable<long>
{
public static readonly long[] Value=A277906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277906.Bytes);
public long this[int i]=>Value[i];

public static A277906Inst Instance=new A277906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277907
{
public static readonly long[] Value={ 5L,7L,11L,13L,17L,19L,41L,43L,59L,61L,67L,71L,97L,101L,103L,107L,109L,113L,127L,131L,137L,139L,149L,151L,179L,181L,191L,193L,197L,199L,227L,229L,269L,271L,277L,281L,307L,311L,313L,317L,347L,349L,379L,383L,419L,421L,431L,433L,439L,443L,461L,463L,487L,491L,499L,503L,599L,601L,617L,619L,643L,647L,739L,743L,823L,827L,853L,857L,859L,863L,877L,881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277907Inst : IEnumerable<long>
{
public static readonly long[] Value=A277907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277907.Bytes);
public long this[int i]=>Value[i];

public static A277907Inst Instance=new A277907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277940
{
public static readonly long[] Value={ 0L,14L,172L,2353L,31011L,410047L,5417792L,71585918L,945856876L,12497509310L,165128212197L,2181820850641L,28828157762271L,380903262040913L,5032832696491638L,66498262088947407L,878634186243031144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277940Inst : IEnumerable<long>
{
public static readonly long[] Value=A277940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277940.Bytes);
public long this[int i]=>Value[i];

public static A277940Inst Instance=new A277940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277941
{
public static readonly BigInteger[] Value={ 0L,74L,2353L,84970L,2967962L,103960169L,3638916907L,127378891305L,4458779090218L,156075459353260L,5463275862035992L,191236872538989228L,6694068173580106896L,BigInteger.Parse("234319606216204278149"),BigInteger.Parse("8202139030768885667342"),BigInteger.Parse("287108218400489269268262") };
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
public class A277941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277941Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277941.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277941Inst Instance=new A277941Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277942
{
public static readonly BigInteger[] Value={ 0L,377L,31011L,2967962L,273135341L,25229090418L,2328401610722L,214902490767900L,19834301854942268L,1830596543877749997L,BigInteger.Parse("168953877741724924425"),BigInteger.Parse("15593502858029836985937"),BigInteger.Parse("1439193533932774658262451") };
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
public class A277942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277942Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277942.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277942Inst Instance=new A277942Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277943
{
public static readonly BigInteger[] Value={ 0L,1932L,410047L,103960169L,25229090418L,6148196379968L,1496942405776739L,364495804481147439L,BigInteger.Parse("88750646285150436813"),BigInteger.Parse("21609806138412948338367"),BigInteger.Parse("5261747594998909650325381"),BigInteger.Parse("1281177047045409510827679072") };
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
public class A277943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277943Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277943.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277943Inst Instance=new A277943Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277944
{
public static readonly BigInteger[] Value={ 0L,9888L,5417792L,3638916907L,2328401610722L,1496942405776739L,961449638681471934L,BigInteger.Parse("617565158334129571727"),BigInteger.Parse("396670564634000349956925"),BigInteger.Parse("254787185951114841200863621"),BigInteger.Parse("163653378309250439597669572808") };
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
public class A277944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277944Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277944.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277944Inst Instance=new A277944Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277945
{
public static readonly long[] Value={ 0L,0L,0L,0L,3L,0L,0L,14L,14L,0L,0L,74L,172L,74L,0L,0L,377L,2353L,2353L,377L,0L,0L,1932L,31011L,84970L,31011L,1932L,0L,0L,9888L,410047L,2967962L,2967962L,410047L,9888L,0L,0L,50619L,5417792L,103960169L,273135341L,103960169L,5417792L,50619L,0L,0L,259118L,71585918L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277945Inst : IEnumerable<long>
{
public static readonly long[] Value=A277945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277945.Bytes);
public long this[int i]=>Value[i];

public static A277945Inst Instance=new A277945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277946
{
public static readonly long[] Value={ 121L,10201L,12100L,22201L,1002001L,1020100L,1022121L,1210000L,1212201L,2220100L,100020001L,100200100L,100220121L,102010000L,102212100L,121000000L,121022001L,121220100L,210221001L,222010000L,10000200001L,10002000100L,10002200121L,10020010000L,10020210201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277946Inst : IEnumerable<long>
{
public static readonly long[] Value=A277946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277946.Bytes);
public long this[int i]=>Value[i];

public static A277946Inst Instance=new A277946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277947
{
public static readonly long[] Value={ 12321L,123201L,130321L,1232100L,1320201L,3101121L,12320100L,13032100L,102030201L,102232321L,103002201L,123210000L,123232201L,132020100L,310112100L,1232010000L,1303210000L,1322122321L,1332323001L,2103231321L,10022212321L,10130221201L,10203020100L,10203222121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277947Inst : IEnumerable<long>
{
public static readonly long[] Value=A277947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277947.Bytes);
public long this[int i]=>Value[i];

public static A277947Inst Instance=new A277947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277948
{
public static readonly long[] Value={ 4L,144L,324L,400L,441L,1024L,1444L,2304L,2401L,10404L,14400L,23104L,32041L,32400L,33124L,40000L,40401L,44100L,101124L,102400L,103041L,110224L,114244L,121104L,131044L,144400L,203401L,204304L,213444L,230400L,232324L,240100L,300304L,301401L,421201L,1004004L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277948Inst : IEnumerable<long>
{
public static readonly long[] Value=A277948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277948.Bytes);
public long this[int i]=>Value[i];

public static A277948Inst Instance=new A277948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277949
{
public static readonly long[] Value={ 1L,1L,4L,6L,4L,1L,1L,4L,10L,16L,19L,16L,10L,4L,1L,1L,4L,10L,20L,31L,40L,44L,40L,31L,20L,10L,4L,1L,1L,4L,10L,20L,35L,52L,68L,80L,85L,80L,68L,52L,35L,20L,10L,4L,1L,1L,4L,10L,20L,35L,56L,80L,104L,125L,140L,146L,140L,125L,104L,80L,56L,35L,20L,10L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277949Inst : IEnumerable<long>
{
public static readonly long[] Value=A277949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277949.Bytes);
public long this[int i]=>Value[i];

public static A277949Inst Instance=new A277949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277950
{
public static readonly long[] Value={ 1L,1L,5L,10L,10L,5L,1L,1L,5L,15L,30L,45L,51L,45L,30L,15L,5L,1L,1L,5L,15L,35L,65L,101L,135L,155L,155L,135L,101L,65L,35L,15L,5L,1L,1L,5L,15L,35L,70L,121L,185L,255L,320L,365L,381L,365L,320L,255L,185L,121L,70L,35L,15L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277950Inst : IEnumerable<long>
{
public static readonly long[] Value=A277950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277950.Bytes);
public long this[int i]=>Value[i];

public static A277950Inst Instance=new A277950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277951
{
public static readonly long[] Value={ 1L,1L,6L,15L,20L,15L,6L,1L,1L,6L,21L,50L,90L,126L,141L,126L,90L,50L,21L,6L,1L,1L,6L,21L,56L,120L,216L,336L,456L,546L,580L,546L,456L,336L,216L,120L,56L,21L,6L,1L,1L,6L,21L,56L,126L,246L,426L,666L,951L,1246L,1506L,1686L,1751L,1686L,1506L,1246L,951L,666L,426L,246L,126L,56L,21L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277951Inst : IEnumerable<long>
{
public static readonly long[] Value=A277951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277951.Bytes);
public long this[int i]=>Value[i];

public static A277951Inst Instance=new A277951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277952
{
public static readonly ulong[] Value={ 1L,11L,110L,1110L,11010L,111010L,1101010L,11101010L,110101010L,1110101010L,11010101010L,111010101010L,1101010101010L,11101010101010L,110101010101010L,1110101010101010L,11010101010101010L,111010101010101010L,1101010101010101010L,11101010101010101010UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277952Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A277952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277952.Bytes);
public ulong this[int i]=>Value[i];

public static A277952Inst Instance=new A277952Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277953
{
public static readonly ulong[] Value={ 1L,11L,11L,111L,1011L,10111L,101011L,1010111L,10101011L,101010111L,1010101011L,10101010111L,101010101011L,1010101010111L,10101010101011L,101010101010111L,1010101010101011L,10101010101010111L,101010101010101011L,1010101010101010111L,10101010101010101011UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277953Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A277953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277953.Bytes);
public ulong this[int i]=>Value[i];

public static A277953Inst Instance=new A277953Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277954
{
public static readonly long[] Value={ 1L,3L,6L,14L,26L,58L,106L,234L,426L,938L,1706L,3754L,6826L,15018L,27306L,60074L,109226L,240298L,436906L,961194L,1747626L,3844778L,6990506L,15379114L,27962026L,61516458L,111848106L,246065834L,447392426L,984263338L,1789569706L,3937053354L,7158278826L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277954Inst : IEnumerable<long>
{
public static readonly long[] Value=A277954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277954.Bytes);
public long this[int i]=>Value[i];

public static A277954Inst Instance=new A277954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277955
{
public static readonly long[] Value={ 1L,3L,3L,7L,11L,23L,43L,87L,171L,343L,683L,1367L,2731L,5463L,10923L,21847L,43691L,87383L,174763L,349527L,699051L,1398103L,2796203L,5592407L,11184811L,22369623L,44739243L,89478487L,178956971L,357913943L,715827883L,1431655767L,2863311531L,5726623063L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277955Inst : IEnumerable<long>
{
public static readonly long[] Value=A277955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277955.Bytes);
public long this[int i]=>Value[i];

public static A277955Inst Instance=new A277955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277972
{
public static readonly long[] Value={ 1L,2L,3L,8L,5L,4L,14L,15L,24L,10L,12L,13L,16L,6L,7L,17L,26L,18L,9L,11L,19L,20L,21L,22L,23L,25L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,64L,60L,61L,62L,63L,65L,66L,67L,68L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277972Inst : IEnumerable<long>
{
public static readonly long[] Value=A277972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277972.Bytes);
public long this[int i]=>Value[i];

public static A277972Inst Instance=new A277972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277973
{
public static readonly long[] Value={ 0L,0L,0L,1L,6L,25L,91L,311L,1029L,3346L,10778L,34544L,110444L,352785L,1126885L,3601617L,11521648L,36899528L,118322448L,379908707L,1221423149L,3932113059L,12675055399L,40909511880L,132200481507L,427718677728L,1385419058692L,4492446685542L,14582927712740L,47385785436719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277973Inst : IEnumerable<long>
{
public static readonly long[] Value=A277973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277973.Bytes);
public long this[int i]=>Value[i];

public static A277973Inst Instance=new A277973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277974
{
public static readonly long[] Value={ 0L,1L,4L,13L,38L,101L,252L,594L,1340L,2907L,6104L,12447L,24744L,48068L,91476L,170838L,313646L,566824L,1009628L,1774290L,3079338L,5282172L,8962288L,15050848L,25032420L,41255101L,67406472L,109236685L,175654072L,280371510L,444372452L,699579062L,1094289564L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277974Inst : IEnumerable<long>
{
public static readonly long[] Value=A277974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277974.Bytes);
public long this[int i]=>Value[i];

public static A277974Inst Instance=new A277974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277975
{
public static readonly long[] Value={ 1L,6L,56L,431L,2931L,18556L,112306L,659181L,3784181L,21362306L,119018556L,656127931L,3585815431L,19454956056L,104904174806L,562667846681L,3004074096681L,15974044799806L,84638595581056L,447034835815431L,2354383468627931L,12367963790893556L,64820051193237306L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277975Inst : IEnumerable<long>
{
public static readonly long[] Value=A277975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277975.Bytes);
public long this[int i]=>Value[i];

public static A277975Inst Instance=new A277975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277976
{
public static readonly long[] Value={ 0L,26L,58L,96L,140L,190L,246L,308L,376L,450L,530L,616L,708L,806L,910L,1020L,1136L,1258L,1386L,1520L,1660L,1806L,1958L,2116L,2280L,2450L,2626L,2808L,2996L,3190L,3390L,3596L,3808L,4026L,4250L,4480L,4716L,4958L,5206L,5460L,5720L,5986L,6258L,6536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277976Inst : IEnumerable<long>
{
public static readonly long[] Value=A277976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277976.Bytes);
public long this[int i]=>Value[i];

public static A277976Inst Instance=new A277976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277977
{
public static readonly long[] Value={ 0L,1L,19L,96L,298L,715L,1461L,2674L,4516L,7173L,10855L,15796L,22254L,30511L,40873L,53670L,69256L,88009L,110331L,136648L,167410L,203091L,244189L,291226L,344748L,405325L,473551L,550044L,635446L,730423L,835665L,951886L,1079824L,1220241L,1373923L,1541680L,1724346L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277977Inst : IEnumerable<long>
{
public static readonly long[] Value=A277977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277977.Bytes);
public long this[int i]=>Value[i];

public static A277977Inst Instance=new A277977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277978
{
public static readonly long[] Value={ 0L,12L,30L,54L,84L,120L,162L,210L,264L,324L,390L,462L,540L,624L,714L,810L,912L,1020L,1134L,1254L,1380L,1512L,1650L,1794L,1944L,2100L,2262L,2430L,2604L,2784L,2970L,3162L,3360L,3564L,3774L,3990L,4212L,4440L,4674L,4914L,5160L,5412L,5670L,5934L,6204L,6480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277978Inst : IEnumerable<long>
{
public static readonly long[] Value=A277978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277978.Bytes);
public long this[int i]=>Value[i];

public static A277978Inst Instance=new A277978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277979
{
public static readonly long[] Value={ 0L,22L,52L,90L,136L,190L,252L,322L,400L,486L,580L,682L,792L,910L,1036L,1170L,1312L,1462L,1620L,1786L,1960L,2142L,2332L,2530L,2736L,2950L,3172L,3402L,3640L,3886L,4140L,4402L,4672L,4950L,5236L,5530L,5832L,6142L,6460L,6786L,7120L,7462L,7812L,8170L,8536L,8910L,9292L,9682L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277979Inst : IEnumerable<long>
{
public static readonly long[] Value=A277979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277979.Bytes);
public long this[int i]=>Value[i];

public static A277979Inst Instance=new A277979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277980
{
public static readonly long[] Value={ 0L,30L,84L,162L,264L,390L,540L,714L,912L,1134L,1380L,1650L,1944L,2262L,2604L,2970L,3360L,3774L,4212L,4674L,5160L,5670L,6204L,6762L,7344L,7950L,8580L,9234L,9912L,10614L,11340L,12090L,12864L,13662L,14484L,15330L,16200L,17094L,18012L,18954L,19920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277980Inst : IEnumerable<long>
{
public static readonly long[] Value=A277980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277980.Bytes);
public long this[int i]=>Value[i];

public static A277980Inst Instance=new A277980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277981
{
public static readonly long[] Value={ -20L,2L,32L,70L,116L,170L,232L,302L,380L,466L,560L,662L,772L,890L,1016L,1150L,1292L,1442L,1600L,1766L,1940L,2122L,2312L,2510L,2716L,2930L,3152L,3382L,3620L,3866L,4120L,4382L,4652L,4930L,5216L,5510L,5812L,6122L,6440L,6766L,7100L,7442L,7792L,8150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277981Inst : IEnumerable<long>
{
public static readonly long[] Value=A277981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277981.Bytes);
public long this[int i]=>Value[i];

public static A277981Inst Instance=new A277981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277982
{
public static readonly long[] Value={ -30L,-8L,38L,108L,202L,320L,462L,628L,818L,1032L,1270L,1532L,1818L,2128L,2462L,2820L,3202L,3608L,4038L,4492L,4970L,5472L,5998L,6548L,7122L,7720L,8342L,8988L,9658L,10352L,11070L,11812L,12578L,13368L,14182L,15020L,15882L,16768L,17678L,18612L,19570L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277982Inst : IEnumerable<long>
{
public static readonly long[] Value=A277982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277982.Bytes);
public long this[int i]=>Value[i];

public static A277982Inst Instance=new A277982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277983
{
public static readonly long[] Value={ 36L,12L,96L,288L,588L,996L,1512L,2136L,2868L,3708L,4656L,5712L,6876L,8148L,9528L,11016L,12612L,14316L,16128L,18048L,20076L,22212L,24456L,26808L,29268L,31836L,34512L,37296L,40188L,43188L,46296L,49512L,52836L,56268L,59808L,63456L,67212L,71076L,75048L,79128L,83316L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277983Inst : IEnumerable<long>
{
public static readonly long[] Value=A277983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277983.Bytes);
public long this[int i]=>Value[i];

public static A277983Inst Instance=new A277983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277984
{
public static readonly long[] Value={ 0L,24L,156L,396L,744L,1200L,1764L,2436L,3216L,4104L,5100L,6204L,7416L,8736L,10164L,11700L,13344L,15096L,16956L,18924L,21000L,23184L,25476L,27876L,30384L,33000L,35724L,38556L,41496L,44544L,47700L,50964L,54336L,57816L,61404L,65100L,68904L,72816L,76836L,80964L,85200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277984Inst : IEnumerable<long>
{
public static readonly long[] Value=A277984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277984.Bytes);
public long this[int i]=>Value[i];

public static A277984Inst Instance=new A277984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277985
{
public static readonly long[] Value={ 6L,24L,204L,546L,1050L,1716L,2544L,3534L,4686L,6000L,7476L,9114L,10914L,12876L,15000L,17286L,19734L,22344L,25116L,28050L,31146L,34404L,37824L,41406L,45150L,49056L,53124L,57354L,61746L,66300L,71016L,75894L,80934L,86136L,91500L,97026L,102714L,108564L,114576L,120750L,127086L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277985Inst : IEnumerable<long>
{
public static readonly long[] Value=A277985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277985.Bytes);
public long this[int i]=>Value[i];

public static A277985Inst Instance=new A277985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277986
{
public static readonly long[] Value={ -14L,60L,134L,208L,282L,356L,430L,504L,578L,652L,726L,800L,874L,948L,1022L,1096L,1170L,1244L,1318L,1392L,1466L,1540L,1614L,1688L,1762L,1836L,1910L,1984L,2058L,2132L,2206L,2280L,2354L,2428L,2502L,2576L,2650L,2724L,2798L,2872L,2946L,3020L,3094L,3168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277986Inst : IEnumerable<long>
{
public static readonly long[] Value=A277986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277986.Bytes);
public long this[int i]=>Value[i];

public static A277986Inst Instance=new A277986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277987
{
public static readonly long[] Value={ -28L,72L,172L,272L,372L,472L,572L,672L,772L,872L,972L,1072L,1172L,1272L,1372L,1472L,1572L,1672L,1772L,1872L,1972L,2072L,2172L,2272L,2372L,2472L,2572L,2672L,2772L,2872L,2972L,3072L,3172L,3272L,3372L,3472L,3572L,3672L,3772L,3872L,3972L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277987Inst : IEnumerable<long>
{
public static readonly long[] Value=A277987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277987.Bytes);
public long this[int i]=>Value[i];

public static A277987Inst Instance=new A277987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278036
{
public static readonly ulong[] Value={ 4L,40L,416L,3808L,33472L,282752L,2339072L,19077632L,154350592L,1242703872L,9977483264L,79979520000L,640542392320L,5127428276224L,41032860631040L,328320884015104L,2626816281149440L,21015595535826944L,168129300578435072L,1345053647156805632L,10760510547561545728UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278036Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A278036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278036.Bytes);
public ulong this[int i]=>Value[i];

public static A278036Inst Instance=new A278036Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278037
{
public static readonly BigInteger[] Value={ 10L,300L,9405L,271701L,7586055L,207778365L,5643858222L,152750888154L,4128157816596L,111500380788894L,3010918493945871L,81298895147719695L,2195110845820568241L,BigInteger.Parse("59268393196729777359"),BigInteger.Parse("1600250528431547974368"),BigInteger.Parse("43206802254989454564468"),BigInteger.Parse("1166584027787796828029022") };
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
public class A278037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278037Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278037.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278037Inst Instance=new A278037Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278038
{
public static readonly long[] Value={ 0L,1L,10L,11L,100L,101L,110L,1000L,1001L,1010L,1011L,1100L,1101L,10000L,10001L,10010L,10011L,10100L,10101L,10110L,11000L,11001L,11010L,11011L,100000L,100001L,100010L,100011L,100100L,100101L,100110L,101000L,101001L,101010L,101011L,101100L,101101L,110000L,110001L,110010L,110011L,110100L,110101L,110110L,1000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278038Inst : IEnumerable<long>
{
public static readonly long[] Value=A278038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278038.Bytes);
public long this[int i]=>Value[i];

public static A278038Inst Instance=new A278038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278039
{
public static readonly long[] Value={ 0L,2L,4L,6L,7L,9L,11L,13L,15L,17L,19L,20L,22L,24L,26L,28L,30L,31L,33L,35L,37L,39L,41L,43L,44L,46L,48L,50L,51L,53L,55L,57L,59L,61L,63L,64L,66L,68L,70L,72L,74L,75L,77L,79L,81L,83L,85L,87L,88L,90L,92L,94L,96L,98L,100L,101L,103L,105L,107L,109L,111L,112L,114L,116L,118L,120L,122L,124L,125L,127L,129L,131L,132L,134L,136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278039Inst : IEnumerable<long>
{
public static readonly long[] Value=A278039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278039.Bytes);
public long this[int i]=>Value[i];

public static A278039Inst Instance=new A278039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278040
{
public static readonly long[] Value={ 1L,5L,8L,12L,14L,18L,21L,25L,29L,32L,36L,38L,42L,45L,49L,52L,56L,58L,62L,65L,69L,73L,76L,80L,82L,86L,89L,93L,95L,99L,102L,106L,110L,113L,117L,119L,123L,126L,130L,133L,137L,139L,143L,146L,150L,154L,157L,161L,163L,167L,170L,174L,178L,181L,185L,187L,191L,194L,198L,201L,205L,207L,211L,214L,218L,222L,225L,229L,231L,235L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278040Inst : IEnumerable<long>
{
public static readonly long[] Value=A278040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278040.Bytes);
public long this[int i]=>Value[i];

public static A278040Inst Instance=new A278040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278041
{
public static readonly long[] Value={ 3L,10L,16L,23L,27L,34L,40L,47L,54L,60L,67L,71L,78L,84L,91L,97L,104L,108L,115L,121L,128L,135L,141L,148L,152L,159L,165L,172L,176L,183L,189L,196L,203L,209L,216L,220L,227L,233L,240L,246L,253L,257L,264L,270L,277L,284L,290L,297L,301L,308L,314L,321L,328L,334L,341L,345L,352L,358L,365L,371L,378L,382L,389L,395L,402L,409L,415L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278041Inst : IEnumerable<long>
{
public static readonly long[] Value=A278041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278041.Bytes);
public long this[int i]=>Value[i];

public static A278041Inst Instance=new A278041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278042
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,1L,1L,3L,2L,2L,1L,2L,1L,4L,3L,3L,2L,3L,2L,2L,3L,2L,2L,1L,5L,4L,4L,3L,4L,3L,3L,4L,3L,3L,2L,3L,2L,4L,3L,3L,2L,3L,2L,2L,6L,5L,5L,4L,5L,4L,4L,5L,4L,4L,3L,4L,3L,5L,4L,4L,3L,4L,3L,3L,4L,3L,3L,2L,5L,4L,4L,3L,4L,3L,3L,4L,3L,3L,2L,3L,2L,7L,6L,6L,5L,6L,5L,5L,6L,5L,5L,4L,5L,4L,6L,5L,5L,4L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278042Inst : IEnumerable<long>
{
public static readonly long[] Value=A278042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278042.Bytes);
public long this[int i]=>Value[i];

public static A278042Inst Instance=new A278042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278043
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,2L,1L,2L,2L,3L,2L,3L,1L,2L,2L,3L,2L,3L,3L,2L,3L,3L,4L,1L,2L,2L,3L,2L,3L,3L,2L,3L,3L,4L,3L,4L,2L,3L,3L,4L,3L,4L,4L,1L,2L,2L,3L,2L,3L,3L,2L,3L,3L,4L,3L,4L,2L,3L,3L,4L,3L,4L,4L,3L,4L,4L,5L,2L,3L,3L,4L,3L,4L,4L,3L,4L,4L,5L,4L,5L,1L,2L,2L,3L,2L,3L,3L,2L,3L,3L,4L,3L,4L,2L,3L,3L,4L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278043Inst : IEnumerable<long>
{
public static readonly long[] Value=A278043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278043.Bytes);
public long this[int i]=>Value[i];

public static A278043Inst Instance=new A278043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278044
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,3L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278044Inst : IEnumerable<long>
{
public static readonly long[] Value=A278044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278044.Bytes);
public long this[int i]=>Value[i];

public static A278044Inst Instance=new A278044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278045
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,0L,1L,3L,0L,1L,0L,2L,0L,4L,0L,1L,0L,2L,0L,1L,3L,0L,1L,0L,5L,0L,1L,0L,2L,0L,1L,3L,0L,1L,0L,2L,0L,4L,0L,1L,0L,2L,0L,1L,6L,0L,1L,0L,2L,0L,1L,3L,0L,1L,0L,2L,0L,4L,0L,1L,0L,2L,0L,1L,3L,0L,1L,0L,5L,0L,1L,0L,2L,0L,1L,3L,0L,1L,0L,2L,0L,7L,0L,1L,0L,2L,0L,1L,3L,0L,1L,0L,2L,0L,4L,0L,1L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278045Inst : IEnumerable<long>
{
public static readonly long[] Value=A278045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278045.Bytes);
public long this[int i]=>Value[i];

public static A278045Inst Instance=new A278045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278046
{
public static readonly long[] Value={ 1L,4L,18L,44L,124L,186L,424L,636L,1038L,1378L,2368L,2852L,4516L,5510L,7030L,8734L,12542L,14168L,19526L,22206L,26658L,30728L,40342L,44190L,54590L,61402L,72328L,80196L,99684L,105644L,129514L,143162L,161422L,176926L,201566L,214538L,255386L,277160L,307736L,329096L,384856L,402412L,466826L,499166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278046Inst : IEnumerable<long>
{
public static readonly long[] Value=A278046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278046.Bytes);
public long this[int i]=>Value[i];

public static A278046Inst Instance=new A278046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278047
{
public static readonly ulong[] Value={ 1L,1L,7L,4L,37L,53L,707L,85L,179077L,289613L,379721L,641671L,62836087L,35819033L,6367281023L,55181728027L,13442946373L,490167893L,596530310479L,576997238399L,116144361532321L,4931206160615L,164890340129357L,1514840590670747L,10181612956306486603UL,3295813969039399097L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278047Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A278047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278047.Bytes);
public ulong this[int i]=>Value[i];

public static A278047Inst Instance=new A278047Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278048
{
public static readonly long[] Value={ 2L,3L,30L,21L,252L,396L,6435L,858L,2042040L,3527160L,5290740L,9360540L,1029659400L,617795640L,116454478140L,1061790830100L,283144221360L,10644519600L,14060345939640L,14060345939640L,2960272834318800L,130015019445168L,4653946718775900L,43747099156493460L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278048Inst : IEnumerable<long>
{
public static readonly long[] Value=A278048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278048.Bytes);
public long this[int i]=>Value[i];

public static A278048Inst Instance=new A278048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278049
{
public static readonly long[] Value={ 2L,5L,11L,17L,29L,35L,53L,65L,83L,95L,125L,137L,173L,191L,215L,239L,287L,305L,359L,383L,419L,449L,515L,539L,599L,635L,689L,725L,809L,833L,923L,971L,1031L,1079L,1151L,1187L,1295L,1349L,1421L,1469L,1589L,1625L,1751L,1811L,1883L,1949L,2087L,2135L,2261L,2321L,2417L,2489L,2645L,2699L,2819L,2891L,2999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278049Inst : IEnumerable<long>
{
public static readonly long[] Value=A278049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278049.Bytes);
public long this[int i]=>Value[i];

public static A278049Inst Instance=new A278049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278050
{
public static readonly long[] Value={ 1L,2L,9L,38L,347L,4189L,11767L,1733L,1548081L,31464371L,14680543L,353517989L,3350216417L,10571768267L,2114915577977L,69039991480573L,538250871701L,110983833313L,328448743696081L,48484885139543L,553270527392631611L,2736415713954900433L,286367762285513933L,2754025786313797907L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278050Inst : IEnumerable<long>
{
public static readonly long[] Value=A278050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278050.Bytes);
public long this[int i]=>Value[i];

public static A278050Inst Instance=new A278050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278051
{
public static readonly long[] Value={ 2L,3L,10L,35L,252L,2772L,6435L,858L,680680L,12932920L,5290740L,121687020L,1029659400L,3088978200L,582272390700L,18050444111700L,128701918800L,25740383760L,70301729698200L,10043104242600L,109530094869795600L,523310453266801200L,51193413906534900L,481218090721428060L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278051Inst : IEnumerable<long>
{
public static readonly long[] Value=A278051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278051.Bytes);
public long this[int i]=>Value[i];

public static A278051Inst Instance=new A278051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278068
{
public static readonly long[] Value={ 57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,59L,2L,116L,2L,116L,2L,116L,2L,116L,2L,116L,2L,116L,2L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278068Inst : IEnumerable<long>
{
public static readonly long[] Value=A278068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278068.Bytes);
public long this[int i]=>Value[i];

public static A278068Inst Instance=new A278068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278069
{
public static readonly BigInteger[] Value={ 1L,0L,3L,-32L,465L,-8544L,190435L,-4996032L,150869313L,-5155334720L,196677847971L,-8286870547680L,382200680031313L,-19152276311294112L,1036167879649219395L,BigInteger.Parse("-60195061159370501504"),BigInteger.Parse("3737352803142621672705"),BigInteger.Parse("-246970483156591884266112"),BigInteger.Parse("17306865588065164490357443") };
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
public class A278069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278069Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278069.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278069Inst Instance=new A278069Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278070
{
public static readonly BigInteger[] Value={ 1L,2L,11L,106L,1457L,25946L,566827L,14665106L,438351041L,14862109042L,563501581931L,23624177026682L,1085079390005041L,54185293223976266L,2922842896378005707L,BigInteger.Parse("169366580127359119906"),BigInteger.Parse("10492171932362920604417"),BigInteger.Parse("691986726674000405367266"),BigInteger.Parse("48408260338825019327539531") };
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
public class A278070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278070Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278070.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278070Inst Instance=new A278070Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278071
{
public static readonly long[] Value={ 1L,1L,-1L,6L,-4L,1L,60L,-36L,9L,-1L,840L,-480L,120L,-16L,1L,15120L,-8400L,2100L,-300L,25L,-1L,332640L,-181440L,45360L,-6720L,630L,-36L,1L,8648640L,-4656960L,1164240L,-176400L,17640L,-1176L,49L,-1L,259459200L,-138378240L,34594560L,-5322240L,554400L,-40320L,2016L,-64L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278071Inst : IEnumerable<long>
{
public static readonly long[] Value=A278071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278071.Bytes);
public long this[int i]=>Value[i];

public static A278071Inst Instance=new A278071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278072
{
public static readonly long[] Value={ 1L,-1L,1L,1L,1L,1L,-1L,4L,3L,1L,1L,10L,11L,5L,1L,-1L,32L,37L,22L,7L,1L,1L,100L,128L,88L,37L,9L,1L,-1L,329L,444L,341L,171L,56L,11L,1L,1L,1101L,1558L,1297L,739L,294L,79L,13L,1L,-1L,3761L,5514L,4891L,3069L,1406L,465L,106L,15L,1L,1L,13035L,19680L,18365L,12435L,6346L,2442L,692L,137L,17L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278072Inst : IEnumerable<long>
{
public static readonly long[] Value=A278072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278072.Bytes);
public long this[int i]=>Value[i];

public static A278072Inst Instance=new A278072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278073
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,20L,0L,1L,168L,1680L,0L,1L,1364L,55440L,369600L,0L,1L,10920L,1561560L,33633600L,168168000L,0L,1L,87380L,42771456L,2385102720L,34306272000L,137225088000L,0L,1L,699048L,1160164320L,158411809920L,5105916816000L,54752810112000L,182509367040000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278073Inst : IEnumerable<long>
{
public static readonly long[] Value=A278073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278073.Bytes);
public long this[int i]=>Value[i];

public static A278073Inst Instance=new A278073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278074
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,70L,0L,1L,990L,34650L,0L,1L,16510L,2702700L,63063000L,0L,1L,261630L,213519150L,17459442000L,305540235000L,0L,1L,4196350L,17651304000L,4350310965000L,231905038365000L,3246670537110000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278074Inst : IEnumerable<long>
{
public static readonly long[] Value=A278074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278074.Bytes);
public long this[int i]=>Value[i];

public static A278074Inst Instance=new A278074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278075
{
public static readonly long[] Value={ 1L,0L,1L,0L,-1L,2L,0L,1L,-6L,6L,0L,-1L,14L,-36L,24L,0L,1L,-30L,150L,-240L,120L,0L,-1L,62L,-540L,1560L,-1800L,720L,0L,1L,-126L,1806L,-8400L,16800L,-15120L,5040L,0L,-1L,254L,-5796L,40824L,-126000L,191520L,-141120L,40320L,0L,1L,-510L,18150L,-186480L,834120L,-1905120L,2328480L,-1451520L,362880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278075Inst : IEnumerable<long>
{
public static readonly long[] Value=A278075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278075.Bytes);
public long this[int i]=>Value[i];

public static A278075Inst Instance=new A278075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278076
{
public static readonly long[] Value={ 0L,1L,8L,9L,24L,25L,32L,33L,48L,49L,56L,57L,86L,87L,94L,95L,110L,111L,118L,119L,134L,135L,142L,143L,1260L,1261L,1268L,1269L,1284L,1285L,1292L,1293L,1308L,1309L,1316L,1317L,1346L,1347L,1354L,1355L,1370L,1371L,1378L,1379L,1394L,1395L,1402L,1403L,1890L,1891L,1898L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278076Inst : IEnumerable<long>
{
public static readonly long[] Value=A278076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278076.Bytes);
public long this[int i]=>Value[i];

public static A278076Inst Instance=new A278076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278077
{
public static readonly long[] Value={ 0L,1L,-1L,2L,-5L,15L,-48L,161L,-558L,1985L,-7205L,26577L,-99333L,375366L,-1431740L,5504906L,-21313444L,83023692L,-325152548L,1279534265L,-5056843296L,20062512404L,-79875018700L,319021150220L,-1277884425750L,5132427441726L,-20664323290494L,83388318193363L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278077Inst : IEnumerable<long>
{
public static readonly long[] Value=A278077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278077.Bytes);
public long this[int i]=>Value[i];

public static A278077Inst Instance=new A278077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278078
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,2L,2L,2L,3L,3L,4L,4L,4L,4L,5L,5L,5L,6L,6L,6L,6L,7L,7L,7L,8L,8L,8L,8L,8L,9L,9L,9L,9L,10L,10L,10L,10L,10L,11L,11L,11L,11L,11L,12L,12L,12L,12L,13L,13L,13L,13L,13L,13L,14L,14L,14L,14L,14L,14L,14L,15L,15L,15L,15L,15L,16L,16L,16L,16L,16L,16L,17L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278078Inst : IEnumerable<long>
{
public static readonly long[] Value=A278078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278078.Bytes);
public long this[int i]=>Value[i];

public static A278078Inst Instance=new A278078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278079
{
public static readonly BigInteger[] Value={ 0L,1L,0L,56L,1280L,59136L,3727360L,317295616L,34977546240L,4848147562496L,825249675345920L,169237314418507776L,BigInteger.Parse("41153580031698534400"),BigInteger.Parse("11708600267324004499456"),BigInteger.Parse("3853197364634932928839680"),BigInteger.Parse("1452327126187528216207425536"),BigInteger.Parse("621567950620088261848869109760") };
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
public class A278079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278079Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278079.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278079Inst Instance=new A278079Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278080
{
public static readonly BigInteger[] Value={ 0L,0L,1L,-5L,126L,1490L,118151L,8256885L,808428076L,100199284180L,15432169163901L,2889536106161375L,646438926423519626L,BigInteger.Parse("170294687860735726470"),BigInteger.Parse("52177485058722877649251"),BigInteger.Parse("18397662218707151323777465"),BigInteger.Parse("7396641315814156362154666776") };
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
public class A278080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278080Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278080.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278080Inst Instance=new A278080Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278081
{
public static readonly long[] Value={ 1L,2L,6L,8L,6L,10L,14L,12L,16L,18L,16L,24L,30L,18L,30L,32L,20L,48L,38L,28L,40L,42L,36L,48L,56L,32L,54L,60L,36L,58L,62L,48L,84L,66L,48L,72L,72L,60L,80L,80L,54L,82L,96L,60L,88L,112L,64L,108L,96L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278081Inst : IEnumerable<long>
{
public static readonly long[] Value=A278081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278081.Bytes);
public long this[int i]=>Value[i];

public static A278081Inst Instance=new A278081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278082
{
public static readonly long[] Value={ 1L,1L,2L,0L,4L,2L,8L,0L,6L,4L,11L,0L,14L,8L,8L,0L,18L,6L,20L,0L,16L,11L,22L,0L,20L,14L,18L,0L,30L,8L,30L,0L,22L,18L,32L,0L,36L,20L,28L,0L,42L,16L,44L,0L,24L,22L,46L,0L,56L,20L,36L,0L,52L,18L,44L,0L,40L,30L,58L,0L,62L,30L,48L,0L,56L,22L,66L,0L,44L,32L,70L,0L,74L,36L,40L,0L,88L,28L,80L,0L,54L,42L,84L,0L,72L,44L,60L,0L,88L,24L,112L,0L,60L,46L,80L,0L,96L,56L,66L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278082Inst : IEnumerable<long>
{
public static readonly long[] Value=A278082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278082.Bytes);
public long this[int i]=>Value[i];

public static A278082Inst Instance=new A278082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278083
{
public static readonly long[] Value={ 1L,4L,4L,8L,12L,12L,12L,16L,16L,20L,32L,24L,20L,36L,28L,32L,48L,32L,36L,48L,40L,44L,48L,48L,56L,64L,52L,48L,80L,60L,60L,96L,48L,68L,96L,72L,72L,80L,96L,80L,108L,84L,64L,112L,88L,96L,128L,80L,96L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278083Inst : IEnumerable<long>
{
public static readonly long[] Value=A278083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278083.Bytes);
public long this[int i]=>Value[i];

public static A278083Inst Instance=new A278083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278212
{
public static readonly long[] Value={ 0L,2L,8L,20L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278212Inst : IEnumerable<long>
{
public static readonly long[] Value=A278212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278212.Bytes);
public long this[int i]=>Value[i];

public static A278212Inst Instance=new A278212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278213
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,1L,0L,0L,4L,6L,8L,8L,8L,8L,6L,4L,0L,0L,5L,10L,13L,16L,17L,18L,19L,20L,19L,18L,17L,16L,12L,8L,4L,0L,0L,8L,14L,20L,24L,28L,30L,32L,34L,35L,36L,38L,38L,38L,37L,36L,36L,32L,28L,24L,20L,16L,12L,8L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278213Inst : IEnumerable<long>
{
public static readonly long[] Value=A278213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278213.Bytes);
public long this[int i]=>Value[i];

public static A278213Inst Instance=new A278213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278214
{
public static readonly long[] Value={ 0L,0L,0L,3L,4L,3L,0L,0L,8L,12L,16L,17L,16L,14L,12L,8L,0L,0L,11L,20L,29L,36L,38L,40L,40L,40L,38L,36L,34L,32L,24L,16L,8L,0L,0L,16L,28L,40L,52L,64L,67L,70L,73L,74L,75L,76L,74L,72L,72L,72L,72L,64L,56L,48L,40L,32L,24L,16L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278214Inst : IEnumerable<long>
{
public static readonly long[] Value=A278214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278214.Bytes);
public long this[int i]=>Value[i];

public static A278214Inst Instance=new A278214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278215
{
public static readonly long[] Value={ 0L,0L,0L,2L,4L,2L,0L,0L,4L,8L,12L,12L,12L,9L,6L,4L,0L,0L,6L,12L,18L,24L,26L,28L,26L,24L,22L,20L,18L,16L,12L,8L,4L,0L,0L,8L,16L,24L,32L,40L,44L,48L,48L,48L,46L,44L,44L,42L,40L,38L,36L,32L,28L,24L,20L,16L,12L,8L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278215Inst : IEnumerable<long>
{
public static readonly long[] Value=A278215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278215.Bytes);
public long this[int i]=>Value[i];

public static A278215Inst Instance=new A278215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278216
{
public static readonly long[] Value={ 4L,0L,0L,4L,0L,0L,1L,0L,3L,1L,0L,3L,0L,0L,0L,2L,2L,0L,2L,2L,0L,1L,0L,0L,4L,0L,0L,3L,0L,0L,2L,0L,2L,0L,0L,4L,0L,0L,1L,2L,1L,1L,0L,3L,0L,1L,0L,0L,3L,0L,1L,3L,0L,1L,1L,0L,3L,0L,0L,3L,0L,0L,0L,3L,1L,0L,2L,2L,0L,0L,1L,1L,2L,1L,1L,2L,0L,0L,1L,0L,3L,1L,0L,3L,0L,1L,0L,1L,3L,0L,1L,2L,0L,1L,0L,1L,2L,0L,0L,4L,0L,0L,2L,0L,2L,1L,0L,3L,1L,0L,0L,2L,1L,0L,1L,3L,0L,1L,0L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278216Inst : IEnumerable<long>
{
public static readonly long[] Value=A278216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278216.Bytes);
public long this[int i]=>Value[i];

public static A278216Inst Instance=new A278216Inst();

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