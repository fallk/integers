using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A249682
{
public static readonly long[] Value={ 3L,7L,11L,17L,21L,15L,25L,31L,37L,43L,33L,45L,39L,51L,61L,65L,67L,71L,77L,83L,85L,75L,81L,87L,93L,99L,105L,111L,115L,119L,125L,131L,133L,143L,123L,129L,141L,147L,153L,135L,159L,165L,171L,177L,175L,185L,187L,197L,205L,203L,217L,183L,201L,189L,195L,207L,213L,219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249682Inst : IEnumerable<long>
{
public static readonly long[] Value=A249682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249682.Bytes);
public long this[int i]=>Value[i];

public static A249682Inst Instance=new A249682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249683
{
public static readonly long[] Value={ 1L,2L,4L,3L,5L,8L,7L,11L,6L,9L,10L,13L,14L,16L,19L,17L,22L,20L,12L,15L,18L,23L,26L,28L,25L,29L,31L,32L,34L,37L,24L,21L,27L,30L,35L,38L,41L,43L,40L,44L,46L,47L,49L,50L,52L,33L,36L,39L,42L,48L,45L,53L,56L,55L,58L,59L,61L,62L,64L,67L,68L,71L,65L,70L,73L,76L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249683Inst : IEnumerable<long>
{
public static readonly long[] Value=A249683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249683.Bytes);
public long this[int i]=>Value[i];

public static A249683Inst Instance=new A249683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249684
{
public static readonly long[] Value={ 1L,2L,3L,5L,11L,14L,26L,29L,32L,56L,59L,62L,95L,98L,101L,137L,140L,143L,146L,152L,200L,203L,206L,209L,215L,221L,224L,281L,287L,290L,293L,296L,299L,302L,305L,365L,371L,374L,377L,380L,383L,386L,392L,398L,401L,485L,488L,491L,497L,500L,503L,506L,509L,512L,518L,521L,533L,614L,620L,623L,626L,629L,632L,635L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249684Inst : IEnumerable<long>
{
public static readonly long[] Value=A249684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249684.Bytes);
public long this[int i]=>Value[i];

public static A249684Inst Instance=new A249684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249685
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,10L,12L,18L,20L,24L,30L,36L,42L,54L,60L,66L,72L,78L,84L,90L,102L,108L,114L,120L,126L,138L,148L,150L,156L,168L,174L,180L,186L,192L,198L,204L,210L,222L,228L,234L,240L,246L,252L,260L,268L,270L,282L,288L,294L,300L,312L,318L,324L,330L,336L,342L,350L,354L,360L,372L,378L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249685Inst : IEnumerable<long>
{
public static readonly long[] Value=A249685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249685.Bytes);
public long this[int i]=>Value[i];

public static A249685Inst Instance=new A249685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249686
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,2L,1L,2L,3L,2L,5L,6L,5L,6L,7L,6L,5L,10L,9L,8L,7L,6L,7L,10L,9L,10L,13L,12L,13L,16L,15L,14L,15L,14L,13L,16L,15L,14L,15L,14L,13L,16L,15L,16L,17L,16L,17L,16L,15L,16L,17L,16L,17L,18L,17L,20L,21L,20L,23L,28L,27L,26L,27L,26L,25L,30L,29L,28L,27L,26L,25L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249686Inst : IEnumerable<long>
{
public static readonly long[] Value=A249686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249686.Bytes);
public long this[int i]=>Value[i];

public static A249686Inst Instance=new A249686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249687
{
public static readonly BigInteger[] Value={ 1L,553536L,38763309456L,461981718937600L,747014438142000900L,BigInteger.Parse("409894695538614337536"),BigInteger.Parse("111023999702812768360000"),BigInteger.Parse("18079702144559278473609216"),BigInteger.Parse("1994247119540837731954644225") };
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
public class A249687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249687Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249687.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249687Inst Instance=new A249687Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249688
{
public static readonly long[] Value={ 1L,576L,63504L,2166784L,23328900L,36578304L,280361536L,7136870400L,12914731449L,13437446400L,285809990544L,137599451136L,333781196644L,161488244736L,1481478465600L,974437482496L,47691924412356L,7438885314624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249688Inst : IEnumerable<long>
{
public static readonly long[] Value=A249688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249688.Bytes);
public long this[int i]=>Value[i];

public static A249688Inst Instance=new A249688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249689
{
public static readonly long[] Value={ 16L,65L,91L,1514L,1993L,1994L,2452L,2722L,3047L,3214L,3931L,3957L,4356L,4366L,5191L,5581L,5805L,5806L,7519L,8871L,9228L,9752L,10036L,10037L,10039L,10040L,10963L,10964L,11278L,11279L,12015L,12281L,12595L,12665L,13262L,13618L,13648L,15102L,15103L,18529L,18991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249689Inst : IEnumerable<long>
{
public static readonly long[] Value=A249689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249689.Bytes);
public long this[int i]=>Value[i];

public static A249689Inst Instance=new A249689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249690
{
public static readonly long[] Value={ 2L,19L,131L,179L,1223L,1373L,1931L,4217L,6907L,10861L,9433L,9371L,39877L,63353L,98491L,90749L,83873L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249690Inst : IEnumerable<long>
{
public static readonly long[] Value=A249690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249690.Bytes);
public long this[int i]=>Value[i];

public static A249690Inst Instance=new A249690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249691
{
public static readonly long[] Value={ 2L,7L,36L,204L,1210L,7371L,45696L,286824L,1817046L,11593725L,74397180L,479634480L,3104160696L,20155648324L,131239189440L,856606186128L,5602957906638L,36716657444145L,241006055925180L,1584293462159100L,10428491209564890L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249691Inst : IEnumerable<long>
{
public static readonly long[] Value=A249691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249691.Bytes);
public long this[int i]=>Value[i];

public static A249691Inst Instance=new A249691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249692
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,33L,20L,73L,47L,193L,113L,683L,103L,433L,45L,562L,1313L,10307L,4013L,12613L,9133L,10643L,5537L,31307L,16727L,50923L,66463L,195227L,92237L,229913L,125L,342763L,2248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249692Inst : IEnumerable<long>
{
public static readonly long[] Value=A249692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249692.Bytes);
public long this[int i]=>Value[i];

public static A249692Inst Instance=new A249692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249693
{
public static readonly long[] Value={ 1L,2L,0L,5L,4L,8L,3L,11L,7L,14L,6L,17L,10L,20L,9L,23L,13L,26L,12L,29L,16L,32L,15L,35L,19L,38L,18L,41L,22L,44L,21L,47L,25L,50L,24L,53L,28L,56L,27L,59L,31L,62L,30L,65L,34L,68L,33L,71L,37L,74L,36L,77L,40L,80L,39L,83L,43L,86L,42L,89L,46L,92L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249693Inst : IEnumerable<long>
{
public static readonly long[] Value=A249693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249693.Bytes);
public long this[int i]=>Value[i];

public static A249693Inst Instance=new A249693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249694
{
public static readonly long[] Value={ 1L,2L,1L,1L,4L,1L,1L,2L,1L,1L,2L,1L,1L,2L,3L,1L,2L,5L,1L,2L,1L,1L,2L,1L,1L,6L,1L,1L,2L,1L,1L,2L,3L,1L,2L,3L,1L,4L,3L,1L,2L,1L,1L,2L,1L,3L,2L,1L,3L,4L,1L,1L,8L,1L,1L,6L,1L,1L,6L,1L,1L,2L,5L,1L,2L,3L,1L,4L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,4L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249694Inst : IEnumerable<long>
{
public static readonly long[] Value=A249694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249694.Bytes);
public long this[int i]=>Value[i];

public static A249694Inst Instance=new A249694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249695
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,3L,0L,1L,2L,3L,0L,1L,6L,3L,7L,1L,2L,3L,4L,1L,6L,3L,0L,1L,2L,3L,12L,1L,6L,3L,5L,1L,2L,3L,4L,1L,6L,3L,8L,1L,2L,3L,12L,1L,6L,3L,21L,1L,2L,3L,4L,1L,6L,3L,24L,1L,2L,3L,12L,1L,6L,3L,1L,1L,2L,3L,4L,1L,6L,3L,8L,1L,2L,3L,12L,1L,6L,3L,16L,1L,2L,3L,4L,1L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249695Inst : IEnumerable<long>
{
public static readonly long[] Value=A249695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249695.Bytes);
public long this[int i]=>Value[i];

public static A249695Inst Instance=new A249695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249696
{
public static readonly long[] Value={ 1L,1L,2L,4L,11L,34L,153L,1035L,12247L,274153L,11999059L,1018915198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249696Inst : IEnumerable<long>
{
public static readonly long[] Value=A249696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249696.Bytes);
public long this[int i]=>Value[i];

public static A249696Inst Instance=new A249696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249697
{
public static readonly long[] Value={ 1L,8L,9L,64L,73L,516L,589L,4160L,4749L,33540L,38289L,270416L,308704L,2180232L,2488936L,17578149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249697Inst : IEnumerable<long>
{
public static readonly long[] Value=A249697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249697.Bytes);
public long this[int i]=>Value[i];

public static A249697Inst Instance=new A249697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249698
{
public static readonly BigInteger[] Value={ 1L,0L,6L,0L,2426L,0L,7553776L,0L,90192976308L,0L,2939813898295990L,0L,BigInteger.Parse("213701821328573755046"),0L,BigInteger.Parse("30292525174041077292043440"),0L,BigInteger.Parse("7609302838629919155170452856136"),0L,BigInteger.Parse("3152886110080180503361685427596189430"),0L,BigInteger.Parse("2038143533263759863560759054752335955960482") };
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
public class A249698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249698Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249698.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249698Inst Instance=new A249698Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249699
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,691L,0L,1L,0L,3617L,0L,43867L,0L,174611L,0L,77683L,0L,236364091L,0L,657931L,0L,3392780147L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249699Inst : IEnumerable<long>
{
public static readonly long[] Value=A249699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249699.Bytes);
public long this[int i]=>Value[i];

public static A249699Inst Instance=new A249699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249700
{
public static readonly BigInteger[] Value={ 1L,1L,1L,72L,1L,14400L,1L,1270080L,1L,87091200L,1L,5269017600L,1L,203997201408000L,1L,15692092416000L,1L,2902409413263360000L,1L,BigInteger.Parse("1747310222272462848000"),1L,BigInteger.Parse("337200218333282304000000"),1L,BigInteger.Parse("7135156619932253552640000"),1L,BigInteger.Parse("1016294482039046201671680000000") };
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
public class A249700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249700Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249700.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249700Inst Instance=new A249700Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249701
{
public static readonly long[] Value={ 39L,69L,125L,221L,377L,659L,1177L,2119L,3805L,6857L,12437L,22681L,41475L,76011L,139645L,257161L,474439L,876539L,1621387L,3002407L,5564769L,10321599L,19156321L,35571383L,66081147L,122803551L,228283091L,424467169L,789412673L,1468380739L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249701Inst : IEnumerable<long>
{
public static readonly long[] Value=A249701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249701.Bytes);
public long this[int i]=>Value[i];

public static A249701Inst Instance=new A249701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249702
{
public static readonly long[] Value={ 100L,208L,440L,896L,1724L,3440L,7056L,14544L,29620L,60416L,124156L,256448L,529304L,1091952L,2255920L,4669824L,9673196L,20037568L,41516752L,86070656L,178513920L,370298992L,768179120L,1593817584L,3307416676L,6864100336L,14246134420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249702Inst : IEnumerable<long>
{
public static readonly long[] Value=A249702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249702.Bytes);
public long this[int i]=>Value[i];

public static A249702Inst Instance=new A249702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249703
{
public static readonly long[] Value={ 205L,485L,1153L,2601L,5425L,11925L,27113L,61725L,137593L,307437L,694273L,1576625L,3567829L,8061981L,18257849L,41462221L,94184277L,213859241L,485808309L,1104769313L,2514006025L,5722098441L,13027345657L,29673996009L,67626829493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249703Inst : IEnumerable<long>
{
public static readonly long[] Value=A249703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249703.Bytes);
public long this[int i]=>Value[i];

public static A249703Inst Instance=new A249703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249704
{
public static readonly long[] Value={ 366L,966L,2524L,6172L,13666L,32500L,80360L,198164L,474302L,1140694L,2782978L,6829394L,16652268L,40525818L,98972744L,242571962L,594328514L,1454961448L,3564476384L,8746203338L,21475833432L,52737244176L,129543959312L,318439317418L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249704Inst : IEnumerable<long>
{
public static readonly long[] Value=A249704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249704.Bytes);
public long this[int i]=>Value[i];

public static A249704Inst Instance=new A249704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249705
{
public static readonly long[] Value={ 595L,1729L,4893L,12789L,29673L,75495L,200489L,528755L,1341901L,3434085L,8949133L,23454657L,60890031L,157756415L,410782645L,1074162701L,2805580083L,7318553467L,19112582503L,50014143783L,130956449801L,342843638551L,897866650281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249705Inst : IEnumerable<long>
{
public static readonly long[] Value=A249705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249705.Bytes);
public long this[int i]=>Value[i];

public static A249705Inst Instance=new A249705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249706
{
public static readonly long[] Value={ 904L,2864L,8688L,24032L,57912L,156416L,442144L,1235840L,3295784L,8902160L,24576568L,68205968L,186882480L,511124496L,1407327072L,3893357456L,10747255576L,29617387520L,81753189024L,226221330256L,626221254528L,1732751390816L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249706Inst : IEnumerable<long>
{
public static readonly long[] Value=A249706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249706.Bytes);
public long this[int i]=>Value[i];

public static A249706Inst Instance=new A249706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249707
{
public static readonly long[] Value={ 10L,39L,14L,100L,69L,20L,205L,208L,125L,28L,366L,485L,440L,221L,38L,595L,966L,1153L,896L,377L,52L,904L,1729L,2524L,2601L,1724L,659L,72L,1305L,2864L,4893L,6172L,5425L,3440L,1177L,100L,1810L,4473L,8688L,12789L,13666L,11925L,7056L,2119L,138L,2431L,6670L,14433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249707Inst : IEnumerable<long>
{
public static readonly long[] Value=A249707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249707.Bytes);
public long this[int i]=>Value[i];

public static A249707Inst Instance=new A249707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249708
{
public static readonly long[] Value={ 14L,69L,208L,485L,966L,1729L,2864L,4473L,6670L,9581L,13344L,18109L,24038L,31305L,40096L,50609L,63054L,77653L,94640L,114261L,136774L,162449L,191568L,224425L,261326L,302589L,348544L,399533L,455910L,518041L,586304L,661089L,742798L,831845L,928656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249708Inst : IEnumerable<long>
{
public static readonly long[] Value=A249708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249708.Bytes);
public long this[int i]=>Value[i];

public static A249708Inst Instance=new A249708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249709
{
public static readonly long[] Value={ 20L,125L,440L,1153L,2524L,4893L,8688L,14433L,22756L,34397L,50216L,71201L,98476L,133309L,177120L,231489L,298164L,379069L,476312L,592193L,729212L,890077L,1077712L,1295265L,1546116L,1833885L,2162440L,2535905L,2958668L,3435389L,3971008L,4570753L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249709Inst : IEnumerable<long>
{
public static readonly long[] Value=A249709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249709.Bytes);
public long this[int i]=>Value[i];

public static A249709Inst Instance=new A249709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249710
{
public static readonly long[] Value={ 28L,221L,896L,2601L,6172L,12789L,24032L,41937L,69052L,108493L,164000L,239993L,341628L,474853L,646464L,864161L,1136604L,1473469L,1885504L,2384585L,2983772L,3697365L,4540960L,5531505L,6687356L,8028333L,9575776L,11352601L,13383356L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249710Inst : IEnumerable<long>
{
public static readonly long[] Value=A249710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249710.Bytes);
public long this[int i]=>Value[i];

public static A249710Inst Instance=new A249710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249711
{
public static readonly long[] Value={ 38L,377L,1724L,5425L,13666L,29673L,57912L,104289L,176350L,283481L,437108L,650897L,940954L,1326025L,1827696L,2470593L,3282582L,4294969L,5542700L,7064561L,8903378L,11106217L,13724584L,16814625L,20437326L,24658713L,29550052L,35188049L,41655050L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249711Inst : IEnumerable<long>
{
public static readonly long[] Value=A249711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249711.Bytes);
public long this[int i]=>Value[i];

public static A249711Inst Instance=new A249711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249712
{
public static readonly long[] Value={ 52L,659L,3440L,11925L,32500L,75495L,156416L,297321L,528340L,889339L,1431728L,2220413L,3335892L,4876495L,6960768L,9730001L,13350900L,18018403L,23958640L,31432037L,40736564L,52211127L,66239104L,83252025L,103733396L,128222667L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249712Inst : IEnumerable<long>
{
public static readonly long[] Value=A249712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249712.Bytes);
public long this[int i]=>Value[i];

public static A249712Inst Instance=new A249712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249713
{
public static readonly long[] Value={ 72L,1177L,7056L,27113L,80360L,200489L,442144L,888465L,1659976L,2924889L,4910896L,7918521L,12336104L,18656489L,27495488L,39612193L,55931208L,77566873L,105849552L,142354057L,188930280L,247736105L,321272672L,412422065L,524487496L,661236057L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249713Inst : IEnumerable<long>
{
public static readonly long[] Value=A249713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249713.Bytes);
public long this[int i]=>Value[i];

public static A249713Inst Instance=new A249713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249714
{
public static readonly long[] Value={ 0L,1L,3L,6L,7L,12L,21L,24L,48L,96L,192L,384L,768L,1536L,3072L,6144L,12288L,24576L,49152L,98304L,196608L,393216L,786432L,1572864L,3145728L,6291456L,12582912L,25165824L,50331648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249714Inst : IEnumerable<long>
{
public static readonly long[] Value=A249714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249714.Bytes);
public long this[int i]=>Value[i];

public static A249714Inst Instance=new A249714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249715
{
public static readonly long[] Value={ 0L,4L,6L,13L,15L,27L,47L,55L,111L,223L,447L,895L,1791L,3583L,7167L,14335L,28671L,57343L,114687L,229375L,458751L,917503L,1835007L,3670015L,7340031L,14680063L,29360127L,58720255L,117440511L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249715Inst : IEnumerable<long>
{
public static readonly long[] Value=A249715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249715.Bytes);
public long this[int i]=>Value[i];

public static A249715Inst Instance=new A249715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249716
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,20L,1L,8L,9L,45L,1L,12L,1287L,364L,6435L,16L,136L,18L,171L,20L,5985L,1540L,1L,24L,25L,325L,27L,28L,3654L,4060L,169911L,32L,528L,5984L,52360L,36L,666L,8436L,82251L,40L,820L,11480L,145008513L,44L,45L,1035L,12551759587422L,48L,49L,50L,1275L,52L,292825L,54L,1485L,56L,1596L,30856L,45057474L,60L,55525372L,37820L,63L,64L,2080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249716Inst : IEnumerable<long>
{
public static readonly long[] Value=A249716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249716.Bytes);
public long this[int i]=>Value[i];

public static A249716Inst Instance=new A249716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249717
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,1L,2L,3L,3L,1L,2L,3L,2L,3L,2L,2L,3L,3L,2L,3L,2L,1L,2L,5L,5L,3L,2L,3L,2L,3L,2L,2L,2L,2L,2L,3L,2L,3L,2L,2L,2L,3L,2L,3L,3L,3L,2L,7L,5L,5L,2L,5L,3L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,5L,2L,5L,2L,3L,2L,3L,3L,3L,2L,3L,2L,3L,2L,2L,3L,3L,2L,3L,2L,3L,2L,2L,7L,3L,2L,5L,2L,5L,2L,2L,2L,5L,2L,3L,2L,3L,2L,2L,2L,2L,2L,3L,3L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249717Inst : IEnumerable<long>
{
public static readonly long[] Value=A249717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249717.Bytes);
public long this[int i]=>Value[i];

public static A249717Inst Instance=new A249717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249718
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,1L,2L,3L,3L,1L,2L,3L,2L,3L,2L,2L,3L,3L,2L,3L,2L,1L,2L,5L,5L,3L,2L,3L,2L,3L,2L,2L,2L,2L,3L,3L,2L,3L,2L,2L,2L,3L,2L,3L,3L,3L,2L,7L,5L,5L,2L,5L,3L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,2L,5L,2L,5L,2L,3L,2L,3L,3L,3L,2L,3L,2L,3L,2L,2L,3L,3L,2L,3L,2L,3L,2L,2L,7L,3L,5L,5L,5L,5L,2L,2L,2L,5L,3L,3L,3L,3L,2L,2L,2L,2L,2L,3L,3L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249718Inst : IEnumerable<long>
{
public static readonly long[] Value=A249718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249718.Bytes);
public long this[int i]=>Value[i];

public static A249718Inst Instance=new A249718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249719
{
public static readonly long[] Value={ 5L,8L,14L,15L,16L,17L,20L,23L,24L,25L,26L,32L,35L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,56L,59L,60L,61L,62L,65L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,86L,89L,95L,96L,97L,98L,101L,104L,105L,106L,107L,113L,116L,122L,123L,124L,125L,126L,127L,128L,129L,130L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249719Inst : IEnumerable<long>
{
public static readonly long[] Value=A249719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249719.Bytes);
public long this[int i]=>Value[i];

public static A249719Inst Instance=new A249719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249720
{
public static readonly long[] Value={ 10L,16L,28L,30L,32L,34L,40L,46L,48L,50L,52L,64L,70L,82L,84L,86L,88L,90L,92L,94L,96L,98L,100L,102L,104L,106L,112L,118L,120L,122L,124L,130L,136L,138L,140L,142L,144L,146L,148L,150L,152L,154L,156L,158L,160L,172L,178L,190L,192L,194L,196L,202L,208L,210L,212L,214L,226L,232L,244L,246L,248L,250L,252L,254L,256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249720Inst : IEnumerable<long>
{
public static readonly long[] Value=A249720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249720.Bytes);
public long this[int i]=>Value[i];

public static A249720Inst Instance=new A249720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249721
{
public static readonly long[] Value={ 0L,2L,4L,6L,8L,12L,14L,18L,20L,22L,24L,26L,36L,38L,42L,44L,54L,56L,58L,60L,62L,66L,68L,72L,74L,76L,78L,80L,108L,110L,114L,116L,126L,128L,132L,134L,162L,164L,166L,168L,170L,174L,176L,180L,182L,184L,186L,188L,198L,200L,204L,206L,216L,218L,220L,222L,224L,228L,230L,234L,236L,238L,240L,242L,324L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249721Inst : IEnumerable<long>
{
public static readonly long[] Value=A249721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249721.Bytes);
public long this[int i]=>Value[i];

public static A249721Inst Instance=new A249721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249722
{
public static readonly long[] Value={ 4L,6L,8L,12L,14L,16L,17L,20L,22L,24L,25L,26L,28L,30L,32L,33L,34L,35L,38L,40L,41L,42L,44L,48L,49L,50L,51L,52L,53L,56L,57L,58L,60L,61L,62L,64L,65L,66L,67L,68L,69L,70L,71L,74L,76L,77L,78L,80L,84L,86L,88L,89L,92L,94L,96L,97L,98L,100L,101L,102L,104L,105L,106L,107L,112L,113L,114L,115L,116L,120L,121L,122L,124L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249722Inst : IEnumerable<long>
{
public static readonly long[] Value=A249722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249722.Bytes);
public long this[int i]=>Value[i];

public static A249722Inst Instance=new A249722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249723
{
public static readonly long[] Value={ 9L,10L,13L,15L,18L,19L,21L,27L,29L,31L,37L,39L,43L,45L,46L,47L,54L,55L,59L,63L,75L,79L,81L,82L,83L,85L,87L,90L,91L,93L,95L,99L,103L,109L,111L,117L,118L,119L,123L,126L,127L,135L,139L,151L,153L,154L,157L,159L,162L,163L,165L,167L,171L,175L,181L,183L,187L,189L,190L,191L,198L,199L,207L,219L,223L,225L,226L,229L,231L,234L,235L,237L,239L,243L,245L,247L,251L,253L,255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249723Inst : IEnumerable<long>
{
public static readonly long[] Value=A249723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249723.Bytes);
public long this[int i]=>Value[i];

public static A249723Inst Instance=new A249723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249724
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,11L,12L,14L,16L,17L,20L,22L,23L,24L,25L,26L,28L,30L,32L,33L,34L,35L,36L,38L,40L,41L,42L,44L,48L,49L,50L,51L,52L,53L,56L,57L,58L,60L,61L,62L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,76L,77L,78L,80L,84L,86L,88L,89L,92L,94L,96L,97L,98L,100L,101L,102L,104L,105L,106L,107L,108L,110L,112L,113L,114L,115L,116L,120L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249724Inst : IEnumerable<long>
{
public static readonly long[] Value=A249724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249724.Bytes);
public long this[int i]=>Value[i];

public static A249724Inst Instance=new A249724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249725
{
public static readonly long[] Value={ 1L,3L,2L,6L,4L,5L,7L,10L,11L,8L,16L,9L,22L,12L,29L,15L,37L,17L,46L,13L,56L,23L,67L,14L,79L,30L,92L,18L,106L,38L,121L,21L,137L,47L,154L,24L,172L,57L,191L,19L,211L,68L,232L,31L,254L,80L,277L,20L,301L,93L,326L,39L,352L,107L,379L,25L,407L,122L,436L,48L,466L,138L,497L,28L,529L,155L,562L,58L,596L,173L,631L,32L,667L,192L,704L,69L,742L,212L,781L,26L,821L,233L,862L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249725Inst : IEnumerable<long>
{
public static readonly long[] Value=A249725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249725.Bytes);
public long this[int i]=>Value[i];

public static A249725Inst Instance=new A249725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249726
{
public static readonly long[] Value={ 36L,72L,73L,108L,110L,144L,145L,147L,180L,216L,217L,218L,221L,252L,288L,289L,291L,295L,324L,326L,360L,361L,396L,432L,433L,434L,435L,437L,443L,468L,504L,505L,540L,542L,576L,577L,579L,583L,612L,648L,649L,650L,653L,684L,720L,721L,723L,756L,758L,792L,793L,828L,864L,865L,866L,867L,869L,871L,875L,887L,900L,936L,937L,972L,974L,1008L,1009L,1011L,1044L,1080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249726Inst : IEnumerable<long>
{
public static readonly long[] Value=A249726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249726.Bytes);
public long this[int i]=>Value[i];

public static A249726Inst Instance=new A249726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249727
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,2L,3L,1L,2L,3L,1L,2L,3L,4L,1L,2L,3L,4L,1L,2L,3L,4L,1L,2L,3L,4L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,6L,1L,2L,3L,4L,5L,6L,1L,2L,3L,4L,5L,6L,1L,2L,3L,4L,5L,6L,1L,2L,3L,4L,5L,6L,7L,1L,2L,3L,4L,5L,6L,7L,1L,2L,3L,4L,5L,6L,7L,8L,1L,2L,3L,4L,5L,6L,7L,8L,1L,2L,3L,4L,5L,6L,7L,8L,1L,2L,3L,4L,5L,6L,7L,8L,1L,2L,3L,4L,5L,6L,7L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249727Inst : IEnumerable<long>
{
public static readonly long[] Value=A249727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249727.Bytes);
public long this[int i]=>Value[i];

public static A249727Inst Instance=new A249727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249728
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,4L,5L,5L,5L,6L,6L,6L,7L,7L,7L,7L,8L,8L,8L,8L,9L,9L,9L,9L,10L,10L,10L,10L,11L,11L,11L,11L,11L,12L,12L,12L,12L,12L,13L,13L,13L,13L,13L,13L,14L,14L,14L,14L,14L,14L,15L,15L,15L,15L,15L,15L,16L,16L,16L,16L,16L,16L,17L,17L,17L,17L,17L,17L,17L,18L,18L,18L,18L,18L,18L,18L,19L,19L,19L,19L,19L,19L,19L,19L,20L,20L,20L,20L,20L,20L,20L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249728Inst : IEnumerable<long>
{
public static readonly long[] Value=A249728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249728.Bytes);
public long this[int i]=>Value[i];

public static A249728Inst Instance=new A249728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249729
{
public static readonly long[] Value={ 21L,27L,33L,39L,42L,45L,51L,54L,55L,57L,63L,65L,66L,69L,73L,75L,78L,81L,84L,85L,87L,90L,91L,93L,95L,99L,102L,103L,105L,108L,110L,111L,114L,115L,117L,119L,123L,125L,126L,129L,130L,132L,133L,135L,137L,138L,141L,145L,146L,150L,155L,156L,159L,161L,162L,165L,167L,168L,170L,171L,174L,175L,177L,180L,181L,182L,183L,185L,186L,187L,189L,190L,195L,197L,198L,201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249729Inst : IEnumerable<long>
{
public static readonly long[] Value=A249729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249729.Bytes);
public long this[int i]=>Value[i];

public static A249729Inst Instance=new A249729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249730
{
public static readonly long[] Value={ 1L,9L,15L,25L,35L,49L,77L,121L,143L,147L,153L,169L,221L,289L,323L,361L,437L,529L,667L,841L,899L,961L,1147L,1369L,1517L,1681L,1763L,1849L,2021L,2209L,2491L,2809L,3127L,3481L,3599L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249730Inst : IEnumerable<long>
{
public static readonly long[] Value=A249730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249730.Bytes);
public long this[int i]=>Value[i];

public static A249730Inst Instance=new A249730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249731
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,0L,1L,0L,6L,-2L,0L,0L,3L,0L,3L,-2L,13L,12L,-1L,2L,13L,-2L,3L,0L,15L,12L,11L,-20L,-4L,-12L,-12L,-14L,21L,14L,20L,24L,1L,2L,11L,-4L,20L,20L,11L,6L,29L,-18L,-4L,-6L,22L,26L,32L,18L,32L,22L,-25L,-34L,9L,-4L,-1L,-6L,9L,0L,15L,-50L,25L,36L,23L,32L,49L,32L,44L,48L,13L,26L,43L,10L,41L,40L,31L,24L,73L,-12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249731Inst : IEnumerable<long>
{
public static readonly long[] Value=A249731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249731.Bytes);
public long this[int i]=>Value[i];

public static A249731Inst Instance=new A249731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249732
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,0L,1L,0L,6L,4L,3L,0L,7L,2L,3L,0L,14L,12L,11L,8L,13L,6L,7L,0L,19L,14L,11L,4L,17L,6L,7L,0L,30L,28L,27L,24L,29L,22L,23L,16L,33L,26L,23L,12L,29L,14L,15L,0L,43L,38L,35L,28L,37L,22L,23L,8L,45L,34L,27L,12L,37L,14L,15L,0L,62L,60L,59L,56L,61L,54L,55L,48L,65L,58L,55L,44L,61L,46L,47L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249732Inst : IEnumerable<long>
{
public static readonly long[] Value=A249732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249732.Bytes);
public long this[int i]=>Value[i];

public static A249732Inst Instance=new A249732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249733
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,6L,3L,0L,4L,2L,0L,2L,1L,0L,12L,6L,0L,8L,4L,0L,4L,2L,0L,24L,21L,18L,19L,14L,9L,14L,7L,0L,28L,20L,12L,20L,13L,6L,12L,6L,0L,32L,19L,6L,21L,12L,3L,10L,5L,0L,48L,42L,36L,38L,28L,18L,28L,14L,0L,50L,37L,24L,36L,24L,12L,22L,11L,0L,52L,32L,12L,34L,20L,6L,16L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249733Inst : IEnumerable<long>
{
public static readonly long[] Value=A249733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249733.Bytes);
public long this[int i]=>Value[i];

public static A249733Inst Instance=new A249733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249734
{
public static readonly long[] Value={ 3L,9L,15L,27L,21L,45L,33L,81L,75L,63L,39L,135L,51L,99L,105L,243L,57L,225L,69L,189L,165L,117L,87L,405L,147L,153L,375L,297L,93L,315L,111L,729L,195L,171L,231L,675L,123L,207L,255L,567L,129L,495L,141L,351L,525L,261L,159L,1215L,363L,441L,285L,459L,177L,1125L,273L,891L,345L,279L,183L,945L,201L,333L,825L,2187L,357L,585L,213L,513L,435L,693L,219L,2025L,237L,369L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249734Inst : IEnumerable<long>
{
public static readonly long[] Value=A249734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249734.Bytes);
public long this[int i]=>Value[i];

public static A249734Inst Instance=new A249734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249735
{
public static readonly long[] Value={ 1L,5L,7L,11L,25L,13L,17L,35L,19L,23L,55L,29L,49L,125L,31L,37L,65L,77L,41L,85L,43L,47L,175L,53L,121L,95L,59L,91L,115L,61L,67L,275L,119L,71L,145L,73L,79L,245L,143L,83L,625L,89L,133L,155L,97L,187L,185L,161L,101L,325L,103L,107L,385L,109L,113L,205L,127L,203L,425L,209L,169L,215L,343L,131L,235L,137L,253L,875L,139L,149L,265L,221L,217L,605L,151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249735Inst : IEnumerable<long>
{
public static readonly long[] Value=A249735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249735.Bytes);
public long this[int i]=>Value[i];

public static A249735Inst Instance=new A249735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249736
{
public static readonly long[] Value={ 0L,1L,3L,6L,10L,15L,21L,28L,6L,15L,25L,6L,18L,1L,15L,0L,16L,3L,21L,10L,0L,21L,13L,6L,0L,25L,21L,18L,16L,15L,15L,16L,18L,21L,25L,0L,6L,13L,21L,0L,10L,21L,3L,16L,0L,15L,1L,18L,6L,25L,15L,6L,28L,21L,15L,10L,6L,3L,1L,0L,0L,1L,3L,6L,10L,15L,21L,28L,6L,15L,25L,6L,18L,1L,15L,0L,16L,3L,21L,10L,0L,21L,13L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249736Inst : IEnumerable<long>
{
public static readonly long[] Value=A249736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249736.Bytes);
public long this[int i]=>Value[i];

public static A249736Inst Instance=new A249736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249737
{
public static readonly BigInteger[] Value={ 1L,0L,5L,0L,1992L,0L,6167551L,0L,73432708224L,0L,2389444075877425L,0L,BigInteger.Parse("173496878823412858880"),0L,BigInteger.Parse("24573448663070711791073155"),0L,BigInteger.Parse("6168942712247503719875933929472"),0L,BigInteger.Parse("2554865971518520622455831203134760669"),0L,BigInteger.Parse("1650933998542152349112398040415912949710848"),0L };
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
public class A249737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249737Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249737.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249737Inst Instance=new A249737Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249738
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,2L,0L,3L,1L,4L,0L,5L,0L,6L,3L,7L,0L,8L,0L,9L,5L,10L,0L,11L,1L,12L,7L,13L,0L,14L,0L,15L,9L,16L,5L,17L,0L,18L,11L,19L,0L,20L,0L,21L,13L,22L,0L,23L,1L,24L,15L,25L,0L,26L,7L,27L,17L,28L,0L,29L,0L,30L,19L,31L,11L,32L,0L,33L,21L,34L,0L,35L,0L,36L,23L,37L,7L,38L,0L,39L,25L,40L,0L,41L,13L,42L,27L,43L,0L,44L,11L,45L,29L,46L,17L,47L,0L,48L,31L,49L,0L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249738Inst : IEnumerable<long>
{
public static readonly long[] Value=A249738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249738.Bytes);
public long this[int i]=>Value[i];

public static A249738Inst Instance=new A249738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249739
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,1L,2L,3L,1L,1L,2L,1L,1L,1L,2L,1L,3L,1L,2L,1L,1L,1L,2L,5L,1L,3L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,3L,1L,1L,2L,7L,5L,1L,2L,1L,3L,1L,2L,1L,1L,1L,2L,1L,1L,3L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,5L,2L,1L,1L,1L,2L,3L,1L,1L,2L,1L,1L,1L,2L,1L,3L,1L,2L,1L,1L,1L,2L,1L,7L,3L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,3L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249739Inst : IEnumerable<long>
{
public static readonly long[] Value=A249739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249739.Bytes);
public long this[int i]=>Value[i];

public static A249739Inst Instance=new A249739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249740
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,1L,2L,3L,1L,1L,2L,1L,1L,1L,2L,1L,3L,1L,2L,1L,1L,1L,2L,5L,1L,3L,2L,1L,1L,1L,2L,1L,1L,1L,3L,1L,1L,1L,2L,1L,1L,1L,2L,3L,1L,1L,2L,7L,5L,1L,2L,1L,3L,1L,2L,1L,1L,1L,2L,1L,1L,3L,2L,1L,1L,1L,2L,1L,1L,1L,3L,1L,1L,5L,2L,1L,1L,1L,2L,3L,1L,1L,2L,1L,1L,1L,2L,1L,3L,1L,2L,1L,1L,1L,2L,1L,7L,3L,5L,1L,1L,1L,2L,1L,1L,1L,3L,1L,1L,1L,2L,1L,1L,1L,2L,3L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249740Inst : IEnumerable<long>
{
public static readonly long[] Value=A249740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249740.Bytes);
public long this[int i]=>Value[i];

public static A249740Inst Instance=new A249740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249741
{
public static readonly long[] Value={ 1L,3L,2L,5L,8L,4L,7L,14L,24L,6L,9L,20L,34L,48L,10L,11L,26L,54L,76L,120L,12L,13L,32L,64L,90L,142L,168L,16L,15L,38L,84L,118L,186L,220L,288L,18L,17L,44L,94L,132L,208L,246L,322L,360L,22L,19L,50L,114L,160L,252L,298L,390L,436L,528L,28L,21L,56L,124L,202L,318L,376L,492L,550L,666L,840L,30L,23L,62L,144L,216L,340L,402L,526L,588L,712L,898L,960L,36L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249741Inst : IEnumerable<long>
{
public static readonly long[] Value=A249741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249741.Bytes);
public long this[int i]=>Value[i];

public static A249741Inst Instance=new A249741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249742
{
public static readonly long[] Value={ 1L,3L,2L,6L,4L,10L,7L,5L,11L,15L,16L,21L,22L,8L,29L,28L,37L,36L,46L,12L,56L,45L,67L,9L,79L,17L,92L,55L,106L,66L,121L,23L,137L,13L,154L,78L,172L,30L,191L,91L,211L,105L,232L,38L,254L,120L,277L,14L,301L,47L,326L,136L,352L,18L,379L,57L,407L,153L,436L,171L,466L,68L,497L,24L,529L,190L,562L,80L,596L,210L,631L,231L,667L,93L,704L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249742Inst : IEnumerable<long>
{
public static readonly long[] Value=A249742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249742.Bytes);
public long this[int i]=>Value[i];

public static A249742Inst Instance=new A249742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249743
{
public static readonly long[] Value={ 1L,8L,34L,90L,208L,376L,628L,816L,1218L,1768L,2200L,2922L,3648L,4342L,5028L,5988L,7728L,8478L,10116L,11572L,12628L,14298L,16018L,17710L,21630L,23128L,24616L,26856L,28666L,30622L,35686L,38382L,42606L,44062L,50212L,52698L,56362L,60798L,63960L,68680L,73210L,76200L,82702L,85498L,90028L,92136L,101068L,109492L,114180L,119308L,126052L,133122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249743Inst : IEnumerable<long>
{
public static readonly long[] Value=A249743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249743.Bytes);
public long this[int i]=>Value[i];

public static A249743Inst Instance=new A249743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249744
{
public static readonly long[] Value={ 0L,0L,0L,2L,0L,4L,0L,6L,3L,8L,0L,10L,0L,12L,9L,14L,0L,16L,0L,18L,15L,20L,0L,22L,5L,24L,21L,26L,0L,28L,0L,30L,27L,32L,25L,34L,0L,36L,33L,38L,0L,40L,0L,42L,39L,44L,0L,46L,7L,48L,45L,50L,0L,52L,35L,54L,51L,56L,0L,58L,0L,60L,57L,62L,55L,64L,0L,66L,63L,68L,0L,70L,0L,72L,69L,74L,49L,76L,0L,78L,75L,80L,0L,82L,65L,84L,81L,86L,0L,88L,77L,90L,87L,92L,85L,94L,0L,96L,93L,98L,0L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249744Inst : IEnumerable<long>
{
public static readonly long[] Value=A249744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249744.Bytes);
public long this[int i]=>Value[i];

public static A249744Inst Instance=new A249744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249745
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,9L,10L,5L,12L,15L,8L,16L,19L,21L,22L,13L,24L,11L,27L,30L,17L,31L,34L,36L,18L,37L,40L,20L,42L,28L,26L,45L,49L,51L,52L,54L,55L,29L,33L,25L,14L,57L,64L,43L,66L,69L,39L,35L,70L,75L,44L,76L,48L,79L,82L,61L,84L,23L,87L,90L,47L,46L,91L,96L,97L,99L,58L,56L,60L,100L,62L,73L,72L,106L,112L,114L,115L,65L,117L,120L,38L,94L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249745Inst : IEnumerable<long>
{
public static readonly long[] Value=A249745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249745.Bytes);
public long this[int i]=>Value[i];

public static A249745Inst Instance=new A249745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249746
{
public static readonly long[] Value={ 1L,2L,3L,4L,9L,5L,6L,12L,7L,8L,19L,10L,17L,42L,11L,13L,22L,26L,14L,29L,15L,16L,59L,18L,41L,32L,20L,31L,39L,21L,23L,92L,40L,24L,49L,25L,27L,82L,48L,28L,209L,30L,45L,52L,33L,63L,62L,54L,34L,109L,35L,36L,129L,37L,38L,69L,43L,68L,142L,70L,57L,72L,115L,44L,79L,46L,85L,292L,47L,50L,89L,74L,73L,202L,51L,53L,159L,87L,55L,99L,107L,56L,152L,58L,97L,192L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249746Inst : IEnumerable<long>
{
public static readonly long[] Value=A249746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249746.Bytes);
public long this[int i]=>Value[i];

public static A249746Inst Instance=new A249746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249747
{
public static readonly BigInteger[] Value={ 1L,2L,8L,51L,496L,6041L,97155L,1746481L,38377034L,1053921489L,31722366805L,1127475187757L,45429396874080L,1910408631449923L,87682336584597009L,4571067440374822934L,BigInteger.Parse("260160909199262899454"),BigInteger.Parse("15823372061924831882182"),BigInteger.Parse("1034588557961336117180784"),BigInteger.Parse("72606463908572608290939197"),BigInteger.Parse("5235472173106695729625747152"),BigInteger.Parse("407296805992490241506213234700") };
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
public class A249747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249747Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249747.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249747Inst Instance=new A249747Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249748
{
public static readonly long[] Value={ 1L,0L,4L,6L,8L,9L,9L,1L,9L,2L,6L,2L,5L,9L,5L,4L,2L,4L,1L,1L,1L,3L,4L,2L,5L,1L,8L,3L,2L,5L,3L,1L,1L,8L,1L,7L,9L,7L,6L,7L,8L,9L,0L,4L,6L,4L,7L,5L,6L,4L,7L,1L,8L,4L,1L,1L,5L,5L,8L,4L,7L,4L,4L,5L,8L,2L,7L,7L,7L,5L,7L,6L,8L,6L,4L,3L,5L,1L,3L,5L,2L,4L,0L,2L,3L,7L,7L,1L,8L,5L,9L,3L,0L,7L,5L,3L,6L,8L,1L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249748Inst : IEnumerable<long>
{
public static readonly long[] Value=A249748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249748.Bytes);
public long this[int i]=>Value[i];

public static A249748Inst Instance=new A249748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249749
{
public static readonly long[] Value={ 2L,3L,7L,13L,19L,43L,53L,59L,79L,89L,97L,109L,127L,131L,151L,173L,251L,269L,281L,311L,359L,443L,449L,479L,521L,547L,631L,647L,857L,883L,929L,941L,991L,1123L,1187L,1217L,1327L,1429L,1847L,1999L,2137L,2267L,2297L,2371L,2423L,2803L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249749Inst : IEnumerable<long>
{
public static readonly long[] Value=A249749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249749.Bytes);
public long this[int i]=>Value[i];

public static A249749Inst Instance=new A249749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249750
{
public static readonly long[] Value={ 0L,7L,70L,703L,7026L,70229L,702309L,7023027L,70230484L,702304875L,7023049293L,70230492763L,702304928492L,7023049277919L,70230492773355L,702304927727064L,7023049277265686L,70230492772676557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249750Inst : IEnumerable<long>
{
public static readonly long[] Value=A249750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249750.Bytes);
public long this[int i]=>Value[i];

public static A249750Inst Instance=new A249750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249751
{
public static readonly long[] Value={ 3L,4L,7L,8L,67L,260L,379L,1191L,1471L,5076L,25807L,58591L,103780L,134947L,137347L,170587L,203236L,272611L,285391L,420211L,453748L,538735L,540856L,592411L,618451L,680707L,778807L,1163067L,1306936L,1520443L,1700947L,1891336L,2099203L,2831011L,3481960L,4020031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249751Inst : IEnumerable<long>
{
public static readonly long[] Value=A249751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249751.Bytes);
public long this[int i]=>Value[i];

public static A249751Inst Instance=new A249751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249752
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,6L,14L,52L,60L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249752Inst : IEnumerable<long>
{
public static readonly long[] Value=A249752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249752.Bytes);
public long this[int i]=>Value[i];

public static A249752Inst Instance=new A249752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249753
{
public static readonly long[] Value={ 1L,3L,7L,17L,40L,99L,246L,642L,1690L,4554L,12436L,34132L,95230L,263934L,744956L,2075132L,5892430L,16456014L,46871196L,131068572L,373897870L,1046231694L,2986898716L,8360588572L,23878057870L,66847653774L,190955945756L,534633021212L,1527373517710L,4276471354254L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249753Inst : IEnumerable<long>
{
public static readonly long[] Value=A249753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249753.Bytes);
public long this[int i]=>Value[i];

public static A249753Inst Instance=new A249753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249754
{
public static readonly BigInteger[] Value={ 1L,2L,7L,51L,814L,27562L,1881132L,252352192L,66437453648L,34544598832464L,35670629662833824L,BigInteger.Parse("73386908116413720320"),BigInteger.Parse("301341520134976454507520"),BigInteger.Parse("2471940307185604520086223360"),BigInteger.Parse("40530105576773294054842498631680"),BigInteger.Parse("1328619037998490196005266772240585728"),BigInteger.Parse("87091009170221273841091095272951672891392") };
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
public class A249754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249754Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A249754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249754.Bytes);
public BigInteger this[int i]=>Value[i];

public static A249754Inst Instance=new A249754Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249755
{
public static readonly long[] Value={ 1L,1L,3L,1L,7L,3L,1L,12L,10L,3L,1L,18L,22L,13L,3L,1L,25L,40L,35L,16L,3L,1L,33L,65L,75L,51L,19L,3L,1L,42L,98L,140L,126L,70L,22L,3L,1L,52L,140L,238L,266L,196L,92L,25L,3L,1L,63L,192L,378L,504L,462L,288L,117L,28L,3L,1L,75L,255L,570L,882L,966L,750L,405L,145L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249755Inst : IEnumerable<long>
{
public static readonly long[] Value=A249755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249755.Bytes);
public long this[int i]=>Value[i];

public static A249755Inst Instance=new A249755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249756
{
public static readonly long[] Value={ 1L,1L,2L,1L,5L,2L,1L,9L,7L,2L,1L,14L,16L,9L,2L,1L,20L,30L,25L,11L,2L,1L,27L,50L,55L,36L,13L,2L,1L,35L,77L,105L,91L,49L,15L,2L,1L,44L,112L,182L,196L,140L,64L,17L,2L,1L,54L,156L,294L,378L,336L,204L,81L,19L,2L,1L,65L,210L,450L,672L,714L,540L,285L,100L,21L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249756Inst : IEnumerable<long>
{
public static readonly long[] Value=A249756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249756.Bytes);
public long this[int i]=>Value[i];

public static A249756Inst Instance=new A249756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249757
{
public static readonly long[] Value={ 1L,1L,3L,1L,8L,3L,1L,15L,11L,3L,1L,24L,26L,14L,3L,1L,35L,50L,40L,17L,3L,1L,48L,85L,90L,57L,20L,3L,1L,63L,133L,175L,147L,77L,23L,3L,1L,80L,196L,308L,322L,224L,100L,26L,3L,1L,99L,276L,504L,630L,546L,324L,126L,29L,3L,1L,120L,375L,780L,1134L,1176L,870L,450L,155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249757Inst : IEnumerable<long>
{
public static readonly long[] Value=A249757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249757.Bytes);
public long this[int i]=>Value[i];

public static A249757Inst Instance=new A249757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249758
{
public static readonly long[] Value={ 1L,2L,2L,4L,7L,2L,8L,19L,11L,2L,16L,47L,41L,15L,2L,32L,111L,129L,71L,19L,2L,64L,255L,369L,271L,109L,23L,2L,128L,575L,993L,911L,489L,155L,27L,2L,256L,1279L,2561L,2815L,1889L,799L,209L,31L,2L,512L,2815L,6401L,8191L,6593L,3487L,1217L,271L,35L,2L,1024L,6143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249758Inst : IEnumerable<long>
{
public static readonly long[] Value=A249758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249758.Bytes);
public long this[int i]=>Value[i];

public static A249758Inst Instance=new A249758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249759
{
public static readonly long[] Value={ 3L,5L,17L,65537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249759Inst : IEnumerable<long>
{
public static readonly long[] Value=A249759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249759.Bytes);
public long this[int i]=>Value[i];

public static A249759Inst Instance=new A249759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249760
{
public static readonly long[] Value={ 2L,4L,16L,65536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249760Inst : IEnumerable<long>
{
public static readonly long[] Value=A249760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249760.Bytes);
public long this[int i]=>Value[i];

public static A249760Inst Instance=new A249760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249761
{
public static readonly long[] Value={ 3L,7L,31L,131071L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249761Inst : IEnumerable<long>
{
public static readonly long[] Value=A249761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249761.Bytes);
public long this[int i]=>Value[i];

public static A249761Inst Instance=new A249761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249762
{
public static readonly long[] Value={ 1L,1L,3L,5L,13L,50L,133L,360L,875L,2254L,6336L,17331L,47199L,124476L,330344L,889454L,2400961L,6485476L,17392906L,46616158L,125153478L,336529923L,905611165L,2434088873L,6539233985L,17567977887L,47214493386L,126927551197L,341177175540L,916960655233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249762Inst : IEnumerable<long>
{
public static readonly long[] Value=A249762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249762.Bytes);
public long this[int i]=>Value[i];

public static A249762Inst Instance=new A249762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249763
{
public static readonly long[] Value={ 1L,2L,8L,18L,49L,72L,98L,128L,196L,200L,242L,288L,361L,392L,441L,676L,968L,1369L,1521L,1568L,1764L,1800L,2178L,2401L,2450L,2888L,3200L,3362L,3528L,3969L,4232L,5000L,5476L,5776L,5929L,6241L,6272L,7056L,7200L,7442L,7688L,7938L,8281L,8450L,8649L,9025L,9522L,9604L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249763Inst : IEnumerable<long>
{
public static readonly long[] Value=A249763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249763.Bytes);
public long this[int i]=>Value[i];

public static A249763Inst Instance=new A249763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249764
{
public static readonly long[] Value={ 15L,30L,105L,120L,150L,222L,375L,585L,1500L,1695L,1755L,1800L,2700L,3449L,3750L,3840L,4891L,6720L,7680L,12000L,13583L,14400L,15000L,18750L,19200L,20940L,28134L,30000L,34800L,35625L,46875L,48000L,68400L,72504L,75000L,93750L,120000L,128400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249764Inst : IEnumerable<long>
{
public static readonly long[] Value=A249764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249764.Bytes);
public long this[int i]=>Value[i];

public static A249764Inst Instance=new A249764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249765
{
public static readonly long[] Value={ 7L,23957L,56483L,74651L,316782L,13594764L,14473747L,30056837L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249765Inst : IEnumerable<long>
{
public static readonly long[] Value=A249765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249765.Bytes);
public long this[int i]=>Value[i];

public static A249765Inst Instance=new A249765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249766
{
public static readonly long[] Value={ 11L,12L,15L,22L,24L,33L,36L,44L,48L,55L,66L,77L,88L,99L,101L,102L,104L,105L,110L,120L,125L,150L,202L,204L,208L,210L,220L,240L,250L,303L,306L,312L,315L,330L,360L,375L,404L,408L,416L,420L,440L,480L,505L,510L,520L,525L,550L,606L,612L,624L,630L,660L,707L,714L,728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249766Inst : IEnumerable<long>
{
public static readonly long[] Value=A249766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249766.Bytes);
public long this[int i]=>Value[i];

public static A249766Inst Instance=new A249766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249767
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,3L,0L,1L,1L,3L,0L,2L,0L,3L,3L,1L,0L,2L,0L,2L,3L,3L,0L,2L,1L,3L,1L,2L,0L,2L,0L,1L,3L,3L,3L,2L,0L,3L,3L,2L,0L,2L,0L,2L,2L,3L,0L,2L,1L,2L,3L,2L,0L,2L,3L,2L,3L,3L,0L,3L,0L,3L,2L,1L,3L,2L,0L,2L,3L,2L,0L,2L,0L,3L,2L,2L,3L,2L,0L,2L,1L,3L,0L,3L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249767Inst : IEnumerable<long>
{
public static readonly long[] Value=A249767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249767.Bytes);
public long this[int i]=>Value[i];

public static A249767Inst Instance=new A249767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249768
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,10L,8L,2L,2L,58L,104L,186L,292L,442L,410L,2L,2L,3434L,6856L,13674L,27192L,53912L,105770L,205628L,389108L,732762L,1286970L,2181624L,3237606L,5206764L,4527418L,2204L,2L,40384330L,80768648L,161537226L,323074168L,646146872L,1292283522L,2584509436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249768Inst : IEnumerable<long>
{
public static readonly long[] Value=A249768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249768.Bytes);
public long this[int i]=>Value[i];

public static A249768Inst Instance=new A249768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249769
{
public static readonly long[] Value={ 1L,3L,2L,18L,6L,114L,24L,792L,120L,6120L,720L,52560L,5040L,498960L,40320L,5201280L,362880L,59149440L,3628800L,729388800L,39916800L,9699782400L,479001600L,138431462400L,6227020800L,2110960051200L,87178291200L,34261068441600L,1307674368000L,589761139968000L,20922789888000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249769Inst : IEnumerable<long>
{
public static readonly long[] Value=A249769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249769.Bytes);
public long this[int i]=>Value[i];

public static A249769Inst Instance=new A249769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249770
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249770Inst : IEnumerable<long>
{
public static readonly long[] Value=A249770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249770.Bytes);
public long this[int i]=>Value[i];

public static A249770Inst Instance=new A249770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249771
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,3L,1L,2L,1L,1L,1L,1L,1L,3L,3L,2L,1L,1L,1L,3L,2L,1L,2L,2L,1L,1L,1L,1L,1L,1L,3L,4L,3L,2L,1L,1L,1L,5L,2L,2L,1L,3L,1L,3L,3L,2L,1L,1L,1L,1L,3L,5L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249771Inst : IEnumerable<long>
{
public static readonly long[] Value=A249771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249771.Bytes);
public long this[int i]=>Value[i];

public static A249771Inst Instance=new A249771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249772
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,2L,0L,0L,1L,10L,0L,12L,2L,1L,0L,16L,0L,9L,1L,2L,10L,11L,0L,5L,12L,0L,2L,14L,1L,6L,0L,10L,16L,2L,0L,4L,9L,12L,1L,40L,2L,3L,10L,1L,11L,23L,0L,14L,5L,16L,12L,26L,0L,10L,2L,9L,14L,58L,1L,60L,6L,2L,0L,12L,10L,33L,16L,11L,2L,35L,0L,36L,4L,5L,9L,10L,12L,78L,1L,0L,40L,82L,2L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249772Inst : IEnumerable<long>
{
public static readonly long[] Value=A249772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249772.Bytes);
public long this[int i]=>Value[i];

public static A249772Inst Instance=new A249772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249773
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,2L,1L,1L,1L,2L,3L,1L,1L,5L,1L,1L,2L,2L,1L,1L,3L,1L,1L,2L,2L,1L,1L,3L,7L,1L,1L,5L,2L,3L,9L,2L,1L,1L,3L,4L,1L,1L,3L,2L,1L,2L,5L,2L,1L,1L,3L,4L,1L,1L,3L,2L,1L,2L,5L,10L,2L,1L,7L,9L,1L,3L,4L,5L,1L,13L,1L,3L,2L,1L,2L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249773Inst : IEnumerable<long>
{
public static readonly long[] Value=A249773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249773.Bytes);
public long this[int i]=>Value[i];

public static A249773Inst Instance=new A249773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249774
{
public static readonly long[] Value={ 2L,0L,3L,5L,3L,17L,3L,29L,11L,7L,2L,17L,3L,19L,5L,5L,7L,0L,4L,14L,42L,11L,2L,3L,5L,5L,35L,8L,1512L,6L,36L,11L,164L,4L,4L,2L,2L,7L,2L,2027L,23L,16L,7L,0L,375L,2L,9L,20L,24L,3L,2L,3L,57L,2L,2L,2L,186L,2L,7L,16L,145L,51L,3L,687L,3L,3L,2L,104L,23L,7L,2L,3L,7L,2L,34L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249774Inst : IEnumerable<long>
{
public static readonly long[] Value=A249774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249774.Bytes);
public long this[int i]=>Value[i];

public static A249774Inst Instance=new A249774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249775
{
public static readonly long[] Value={ 3L,0L,11L,19L,17L,79L,23L,151L,67L,53L,37L,107L,47L,131L,67L,71L,83L,0L,79L,137L,293L,131L,89L,101L,109L,113L,283L,149L,12923L,149L,317L,181L,1193L,157L,163L,157L,163L,193L,173L,18041L,307L,269L,227L,0L,2897L,211L,257L,331L,359L,239L,239L,251L,599L,257L,263L,269L,1531L,277L,313L,379L,1259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249775Inst : IEnumerable<long>
{
public static readonly long[] Value=A249775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249775.Bytes);
public long this[int i]=>Value[i];

public static A249775Inst Instance=new A249775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249776
{
public static readonly long[] Value={ 1L,7L,1L,1L,0L,4L,1L,2L,9L,6L,8L,4L,4L,8L,4L,8L,4L,6L,4L,1L,1L,7L,0L,8L,7L,4L,6L,3L,1L,0L,4L,4L,5L,4L,0L,6L,7L,9L,9L,3L,2L,1L,9L,3L,2L,6L,9L,2L,4L,8L,1L,9L,5L,9L,7L,7L,0L,0L,8L,0L,7L,8L,5L,8L,3L,9L,4L,9L,2L,5L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249776Inst : IEnumerable<long>
{
public static readonly long[] Value=A249776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249776.Bytes);
public long this[int i]=>Value[i];

public static A249776Inst Instance=new A249776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249777
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,2L,1L,2L,3L,0L,5L,6L,0L,6L,7L,3L,2L,10L,1L,5L,6L,3L,7L,10L,0L,10L,13L,0L,13L,16L,0L,5L,15L,1L,11L,16L,1L,6L,15L,2L,11L,16L,4L,16L,17L,2L,17L,12L,5L,16L,17L,3L,17L,18L,0L,20L,21L,0L,23L,28L,0L,23L,27L,1L,15L,30L,3L,17L,26L,4L,19L,28L,2L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249777Inst : IEnumerable<long>
{
public static readonly long[] Value=A249777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249777.Bytes);
public long this[int i]=>Value[i];

public static A249777Inst Instance=new A249777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249778
{
public static readonly long[] Value={ 2L,7L,3L,4L,11L,25L,9L,19L,16L,49L,17L,59L,67L,121L,81L,169L,43L,115L,64L,191L,293L,361L,289L,587L,269L,841L,863L,961L,1031L,1369L,441L,1681L,1867L,2209L,1849L,2809L,65L,529L,256L,643L,3481L,3517L,1639L,1877L,3721L,4489L,5041L,5329L,5591L,6241L,3557L,6889L,7921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249778Inst : IEnumerable<long>
{
public static readonly long[] Value=A249778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249778.Bytes);
public long this[int i]=>Value[i];

public static A249778Inst Instance=new A249778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249779
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,22L,20L,28L,2L,494L,912L,1672L,2376L,4836L,4160L,4184L,2L,131038L,261800L,522272L,1035804L,2053288L,3977272L,7742352L,13942968L,28016020L,47111040L,84948528L,92072064L,272727022L,249686810L,167376688L,2L,8589934526L,17179867992L,34359725136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249779Inst : IEnumerable<long>
{
public static readonly long[] Value=A249779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249779.Bytes);
public long this[int i]=>Value[i];

public static A249779Inst Instance=new A249779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249780
{
public static readonly long[] Value={ 9L,49L,15L,961L,21L,16129L,51L,511L,93L,2047L,39L,67092481L,381L,1057L,771L,17179607041L,219L,274876858369L,123L,2359L,2049L,8388607L,723L,55831L,24573L,1838599L,381L,486737L,993L,4611686014132420609L,196611L,4196353L,393213L,3810551L,327L,137438953471L,1572861L,849583L,185043L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249780Inst : IEnumerable<long>
{
public static readonly long[] Value=A249780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249780.Bytes);
public long this[int i]=>Value[i];

public static A249780Inst Instance=new A249780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A249781
{
public static readonly long[] Value={ 1L,-3L,1L,3L,-1L,1L,-4L,1L,1L,-1L,0L,-1L,2L,4L,-1L,-5L,6L,-3L,-4L,1L,-4L,8L,0L,-3L,1L,2L,1L,-4L,-6L,3L,8L,1L,0L,-10L,4L,3L,2L,-4L,2L,3L,-6L,4L,-4L,-8L,-1L,0L,0L,7L,9L,-3L,6L,-2L,-6L,1L,0L,4L,-4L,10L,0L,-3L,-10L,-8L,-4L,11L,-2L,-8L,-4L,10L,0L,-4L,0L,1L,2L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A249781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A249781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A249781Inst : IEnumerable<long>
{
public static readonly long[] Value=A249781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A249781.Bytes);
public long this[int i]=>Value[i];

public static A249781Inst Instance=new A249781Inst();

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