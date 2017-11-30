using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A212157
{
public static readonly long[] Value={ 1L,1L,-1L,1L,-1L,-1L,1L,1L,1L,-1L,1L,-1L,-1L,1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,-1L,1L,-1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,-1L,1L,1L,1L,-1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,-1L,1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,1L,1L,-1L,1L,-1L,1L,-1L,-1L,-1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212157Inst : IEnumerable<long>
{
public static readonly long[] Value=A212157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212157.Bytes);
public long this[int i]=>Value[i];

public static A212157Inst Instance=new A212157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212158
{
public static readonly BigInteger[] Value={ 1L,2L,6L,120L,720L,40320L,362880L,39916800L,87178291200L,1307674368000L,6402373705728000L,2432902008176640000L,BigInteger.Parse("51090942171709440000"),BigInteger.Parse("25852016738884976640000"),BigInteger.Parse("403291461126605635584000000"),BigInteger.Parse("8841761993739701954543616000000") };
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
public class A212158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212158Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A212158.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A212158.Bytes);
public BigInteger this[int i]=>Value[i];

public static A212158Inst Instance=new A212158Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212159
{
public static readonly long[] Value={ 1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,1L,-1L,1L,-1L,1L,1L,-1L,1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,1L,-1L,-1L,1L,1L,1L,1L,-1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,-1L,1L,-1L,1L,1L,-1L,-1L,1L,-1L,1L,-1L,-1L,1L,1L,-1L,1L,1L,-1L,-1L,-1L,-1L,1L,-1L,1L,-1L,1L,1L,-1L,-1L,-1L,1L,1L,1L,1L,1L,1L,1L,-1L,-1L,1L,-1L,1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212159Inst : IEnumerable<long>
{
public static readonly long[] Value=A212159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212159.Bytes);
public long this[int i]=>Value[i];

public static A212159Inst Instance=new A212159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212160
{
public static readonly long[] Value={ 2L,10L,15L,23L,28L,36L,41L,49L,54L,62L,67L,75L,80L,88L,93L,101L,106L,114L,119L,127L,132L,140L,145L,153L,158L,166L,171L,179L,184L,192L,197L,205L,210L,218L,223L,231L,236L,244L,249L,257L,262L,270L,275L,283L,288L,296L,301L,309L,314L,322L,327L,335L,340L,348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212160Inst : IEnumerable<long>
{
public static readonly long[] Value=A212160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212160.Bytes);
public long this[int i]=>Value[i];

public static A212160Inst Instance=new A212160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212161
{
public static readonly long[] Value={ 6L,10L,23L,27L,40L,44L,57L,61L,74L,78L,91L,95L,108L,112L,125L,129L,142L,146L,159L,163L,176L,180L,193L,197L,210L,214L,227L,231L,244L,248L,261L,265L,278L,282L,295L,299L,312L,316L,329L,333L,346L,350L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212161Inst : IEnumerable<long>
{
public static readonly long[] Value=A212161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212161.Bytes);
public long this[int i]=>Value[i];

public static A212161Inst Instance=new A212161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212162
{
public static readonly long[] Value={ 1L,0L,1L,-5L,8L,-4L,0L,1L,-16L,112L,-448L,1120L,-1791L,1786L,-1012L,248L,0L,1L,-33L,510L,-4898L,32703L,-160859L,602408L,-1749715L,3975561L,-7068408L,9755858L,-10265148L,7968348L,-4304712L,1445104L,-226720L,0L,1L,-56L,1508L,-25992L,321994L,-3051871L,23000726L,-141421592L,722137763L,-3101089711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212162Inst : IEnumerable<long>
{
public static readonly long[] Value=A212162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212162.Bytes);
public long this[int i]=>Value[i];

public static A212162Inst Instance=new A212162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212163
{
public static readonly long[] Value={ 1L,0L,2L,0L,0L,3L,0L,0L,6L,4L,0L,0L,6L,48L,5L,0L,0L,6L,1056L,180L,6L,0L,0L,6L,45696L,32940L,480L,7L,0L,0L,6L,4034304L,30847500L,393600L,1050L,8L,0L,0L,6L,739642368L,148039757460L,3312560640L,2735250L,2016L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212163Inst : IEnumerable<long>
{
public static readonly long[] Value=A212163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212163.Bytes);
public long this[int i]=>Value[i];

public static A212163Inst Instance=new A212163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212164
{
public static readonly long[] Value={ 4L,8L,9L,16L,24L,25L,27L,32L,40L,48L,49L,54L,56L,64L,72L,80L,81L,88L,96L,104L,108L,112L,121L,125L,128L,135L,136L,144L,152L,160L,162L,169L,176L,184L,189L,192L,200L,208L,216L,224L,232L,240L,243L,248L,250L,256L,272L,288L,289L,296L,297L,304L,320L,324L,328L,336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212164Inst : IEnumerable<long>
{
public static readonly long[] Value=A212164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212164.Bytes);
public long this[int i]=>Value[i];

public static A212164Inst Instance=new A212164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212165
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,9L,11L,12L,13L,16L,17L,18L,19L,20L,23L,24L,25L,27L,28L,29L,31L,32L,36L,37L,40L,41L,43L,44L,45L,47L,48L,49L,50L,52L,53L,54L,56L,59L,61L,63L,64L,67L,68L,71L,72L,73L,75L,76L,79L,80L,81L,83L,88L,89L,92L,96L,97L,98L,99L,100L,101L,103L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212165Inst : IEnumerable<long>
{
public static readonly long[] Value=A212165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212165.Bytes);
public long this[int i]=>Value[i];

public static A212165Inst Instance=new A212165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212166
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,11L,12L,13L,17L,18L,19L,20L,23L,28L,29L,31L,36L,37L,41L,43L,44L,45L,47L,50L,52L,53L,59L,61L,63L,67L,68L,71L,73L,75L,76L,79L,83L,89L,92L,97L,98L,99L,100L,101L,103L,107L,109L,113L,116L,117L,120L,124L,127L,131L,137L,139L,147L,148L,149L,151L,153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212166Inst : IEnumerable<long>
{
public static readonly long[] Value=A212166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212166.Bytes);
public long this[int i]=>Value[i];

public static A212166Inst Instance=new A212166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212167
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,10L,11L,12L,13L,14L,15L,17L,18L,19L,20L,21L,22L,23L,26L,28L,29L,30L,31L,33L,34L,35L,36L,37L,38L,39L,41L,42L,43L,44L,45L,46L,47L,50L,51L,52L,53L,55L,57L,58L,59L,60L,61L,62L,63L,65L,66L,67L,68L,69L,70L,71L,73L,74L,75L,76L,77L,78L,79L,82L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212167Inst : IEnumerable<long>
{
public static readonly long[] Value=A212167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212167.Bytes);
public long this[int i]=>Value[i];

public static A212167Inst Instance=new A212167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212168
{
public static readonly long[] Value={ 6L,10L,14L,15L,21L,22L,26L,30L,33L,34L,35L,38L,39L,42L,46L,51L,55L,57L,58L,60L,62L,65L,66L,69L,70L,74L,77L,78L,82L,84L,85L,86L,87L,90L,91L,93L,94L,95L,102L,105L,106L,110L,111L,114L,115L,118L,119L,122L,123L,126L,129L,130L,132L,133L,134L,138L,140L,141L,142L,143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212168Inst : IEnumerable<long>
{
public static readonly long[] Value=A212168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212168.Bytes);
public long this[int i]=>Value[i];

public static A212168Inst Instance=new A212168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212169
{
public static readonly long[] Value={ 1L,2L,4L,12L,24L,36L,48L,120L,240L,360L,720L,1680L,5040L,10080L,15120L,20160L,25200L,45360L,50400L,110880L,221760L,332640L,554400L,665280L,2882880L,8648640L,14414400L,17297280L,43243200L,294053760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212169Inst : IEnumerable<long>
{
public static readonly long[] Value=A212169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212169.Bytes);
public long this[int i]=>Value[i];

public static A212169Inst Instance=new A212169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212170
{
public static readonly BigInteger[] Value={ 1L,2L,48L,207360L,5643509760000L,BigInteger.Parse("74508333765820416000000000"),BigInteger.Parse("68238227014337640914957453230080000000000000000"),BigInteger.Parse("958098594568198616022876832154309463351366075411333120000000000000000000000000") };
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
public class A212170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212170Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A212170.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A212170.Bytes);
public BigInteger this[int i]=>Value[i];

public static A212170Inst Instance=new A212170Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212171
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,1L,1L,3L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,4L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,3L,1L,2L,1L,1L,3L,2L,1L,1L,1L,1L,1L,1L,5L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,4L,1L,2L,2L,1L,1L,1L,2L,1L,1L,3L,1L,1L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212171Inst : IEnumerable<long>
{
public static readonly long[] Value=A212171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212171.Bytes);
public long this[int i]=>Value[i];

public static A212171Inst Instance=new A212171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212172
{
public static readonly long[] Value={ 0L,0L,0L,2L,0L,0L,0L,3L,2L,0L,0L,2L,0L,0L,0L,4L,0L,2L,0L,2L,0L,0L,0L,3L,2L,0L,3L,2L,0L,0L,0L,5L,0L,0L,0L,2L,2L,0L,0L,0L,3L,0L,0L,0L,2L,2L,0L,0L,4L,2L,2L,0L,2L,0L,3L,0L,3L,0L,0L,0L,2L,0L,0L,2L,6L,0L,0L,0L,2L,0L,0L,0L,3L,2L,0L,0L,2L,2L,0L,0L,0L,4L,4L,0L,0L,2L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212172Inst : IEnumerable<long>
{
public static readonly long[] Value=A212172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212172.Bytes);
public long this[int i]=>Value[i];

public static A212172Inst Instance=new A212172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212173
{
public static readonly long[] Value={ 1L,1L,1L,4L,1L,1L,1L,8L,4L,1L,1L,4L,1L,1L,1L,16L,1L,4L,1L,4L,1L,1L,1L,8L,4L,1L,8L,4L,1L,1L,1L,32L,1L,1L,1L,36L,1L,1L,1L,8L,1L,1L,1L,4L,4L,1L,1L,16L,4L,4L,1L,4L,1L,8L,1L,8L,1L,1L,1L,4L,1L,1L,4L,64L,1L,1L,1L,4L,1L,1L,1L,72L,1L,1L,4L,4L,1L,1L,1L,16L,16L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212173Inst : IEnumerable<long>
{
public static readonly long[] Value=A212173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212173.Bytes);
public long this[int i]=>Value[i];

public static A212173Inst Instance=new A212173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212174
{
public static readonly long[] Value={ 2L,3L,2L,2L,4L,2L,2L,3L,2L,3L,2L,5L,2L,2L,3L,2L,2L,4L,2L,2L,2L,3L,3L,2L,2L,6L,2L,3L,2L,2L,2L,4L,4L,2L,3L,2L,2L,5L,2L,2L,2L,2L,3L,3L,2L,4L,2L,2L,3L,2L,2L,3L,2L,7L,2L,3L,3L,2L,4L,2L,2L,2L,2L,3L,2L,2L,5L,4L,2L,3L,2L,2L,2L,2L,4L,2L,2L,3L,2L,3L,6L,2L,2L,2L,3L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212174Inst : IEnumerable<long>
{
public static readonly long[] Value=A212174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212174.Bytes);
public long this[int i]=>Value[i];

public static A212174Inst Instance=new A212174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212175
{
public static readonly long[] Value={ 0L,0L,2L,0L,3L,2L,4L,3L,0L,5L,2L,2L,4L,2L,6L,3L,2L,5L,3L,7L,4L,2L,2L,2L,6L,0L,3L,3L,4L,8L,5L,2L,3L,2L,7L,2L,4L,3L,5L,9L,6L,2L,4L,2L,8L,3L,5L,3L,2L,2L,2L,6L,10L,3L,3L,7L,2L,2L,2L,4L,4L,5L,2L,9L,4L,6L,3L,3L,2L,2L,7L,11L,4L,3L,8L,2L,0L,3L,2L,5L,4L,6L,2L,10L,5L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212175Inst : IEnumerable<long>
{
public static readonly long[] Value=A212175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212175.Bytes);
public long this[int i]=>Value[i];

public static A212175Inst Instance=new A212175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212176
{
public static readonly long[] Value={ 2L,3L,4L,5L,2L,2L,6L,3L,2L,7L,4L,2L,3L,3L,8L,5L,2L,4L,3L,9L,6L,2L,5L,3L,2L,2L,2L,10L,7L,2L,4L,4L,6L,3L,3L,2L,2L,11L,8L,2L,5L,4L,7L,3L,4L,2L,2L,12L,9L,2L,6L,4L,3L,3L,2L,8L,3L,5L,2L,2L,5L,5L,13L,10L,2L,7L,4L,4L,3L,2L,9L,3L,6L,2L,2L,6L,5L,14L,11L,2L,8L,4L,5L,3L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212176Inst : IEnumerable<long>
{
public static readonly long[] Value=A212176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212176.Bytes);
public long this[int i]=>Value[i];

public static A212176Inst Instance=new A212176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212177
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212177Inst : IEnumerable<long>
{
public static readonly long[] Value=A212177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212177.Bytes);
public long this[int i]=>Value[i];

public static A212177Inst Instance=new A212177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212178
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,1L,1L,0L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,2L,1L,0L,2L,1L,1L,2L,2L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,3L,1L,1L,2L,2L,2L,2L,2L,1L,1L,2L,3L,1L,1L,2L,2L,0L,2L,2L,2L,1L,1L,2L,3L,1L,1L,2L,2L,1L,2L,2L,3L,2L,1L,3L,2L,1L,2L,3L,2L,1L,2L,1L,2L,2L,1L,2L,2L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212178Inst : IEnumerable<long>
{
public static readonly long[] Value=A212178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212178.Bytes);
public long this[int i]=>Value[i];

public static A212178Inst Instance=new A212178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212179
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,1L,2L,1L,2L,2L,1L,2L,2L,1L,2L,2L,3L,1L,2L,2L,2L,3L,1L,2L,2L,2L,3L,1L,2L,2L,3L,2L,3L,2L,1L,2L,2L,3L,2L,3L,2L,1L,2L,2L,3L,3L,2L,3L,2L,3L,1L,2L,2L,3L,4L,2L,3L,2L,3L,2L,3L,1L,2L,2L,3L,4L,2L,3L,2L,3L,2L,3L,1L,2L,3L,2L,3L,4L,2L,3L,3L,2L,3L,2L,3L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212179Inst : IEnumerable<long>
{
public static readonly long[] Value=A212179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212179.Bytes);
public long this[int i]=>Value[i];

public static A212179Inst Instance=new A212179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212180
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,1L,3L,2L,1L,1L,2L,1L,1L,1L,4L,1L,2L,1L,2L,1L,1L,1L,3L,2L,1L,3L,2L,1L,1L,1L,5L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,2L,2L,1L,1L,4L,2L,2L,1L,2L,1L,3L,1L,3L,1L,1L,1L,2L,1L,1L,2L,6L,1L,1L,1L,2L,1L,1L,1L,5L,1L,1L,2L,2L,1L,1L,1L,4L,4L,1L,1L,2L,1L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212180Inst : IEnumerable<long>
{
public static readonly long[] Value=A212180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212180.Bytes);
public long this[int i]=>Value[i];

public static A212180Inst Instance=new A212180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212181
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,1L,1L,1L,3L,1L,1L,3L,1L,1L,1L,5L,1L,3L,1L,3L,1L,1L,1L,1L,3L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,9L,1L,1L,1L,1L,1L,1L,1L,3L,3L,1L,1L,5L,3L,3L,1L,3L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,3L,7L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,3L,3L,1L,1L,1L,5L,5L,1L,1L,3L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212181Inst : IEnumerable<long>
{
public static readonly long[] Value=A212181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212181.Bytes);
public long this[int i]=>Value[i];

public static A212181Inst Instance=new A212181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212182
{
public static readonly long[] Value={ 0L,1L,2L,1L,1L,2L,1L,3L,1L,2L,2L,4L,1L,2L,1L,1L,3L,1L,1L,2L,2L,1L,4L,1L,1L,3L,2L,1L,4L,2L,1L,3L,1L,1L,1L,2L,2L,1L,1L,4L,1L,1L,1L,3L,2L,1L,1L,4L,2L,1L,1L,3L,3L,1L,1L,5L,2L,1L,1L,4L,3L,1L,1L,6L,2L,1L,1L,4L,2L,2L,1L,3L,2L,1L,1L,1L,4L,4L,1L,1L,5L,2L,2L,1L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212182Inst : IEnumerable<long>
{
public static readonly long[] Value=A212182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212182.Bytes);
public long this[int i]=>Value[i];

public static A212182Inst Instance=new A212182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212183
{
public static readonly long[] Value={ 1L,1L,3L,1L,3L,1L,9L,5L,3L,1L,9L,5L,3L,15L,1L,9L,5L,3L,15L,1L,9L,5L,21L,45L,3L,25L,27L,15L,1L,9L,5L,21L,45L,3L,25L,27L,7L,15L,1L,9L,5L,21L,45L,3L,25L,27L,7L,15L,63L,1L,9L,75L,5L,21L,45L,3L,25L,27L,7L,15L,63L,1L,9L,75L,5L,21L,45L,3L,25L,105L,27L,7L,15L,63L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212183Inst : IEnumerable<long>
{
public static readonly long[] Value=A212183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212183.Bytes);
public long this[int i]=>Value[i];

public static A212183Inst Instance=new A212183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212184
{
public static readonly long[] Value={ 0L,0L,2L,0L,2L,3L,2L,2L,4L,2L,3L,2L,2L,4L,3L,2L,4L,2L,3L,2L,2L,4L,3L,2L,4L,2L,3L,3L,5L,2L,4L,3L,6L,2L,4L,2L,2L,3L,2L,4L,4L,5L,2L,2L,4L,2L,3L,3L,5L,2L,4L,3L,6L,2L,4L,2L,2L,5L,3L,4L,4L,5L,2L,2L,6L,3L,4L,2L,3L,3L,5L,2L,4L,3L,6L,2L,4L,2L,2L,5L,3L,4L,4L,5L,2L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212184Inst : IEnumerable<long>
{
public static readonly long[] Value=A212184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212184.Bytes);
public long this[int i]=>Value[i];

public static A212184Inst Instance=new A212184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212185
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,2L,1L,1L,1L,2L,1L,2L,2L,1L,2L,1L,2L,2L,2L,2L,2L,2L,3L,2L,2L,3L,2L,2L,2L,2L,2L,3L,2L,2L,3L,2L,2L,2L,2L,2L,2L,3L,2L,2L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,2L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,2L,3L,3L,2L,3L,3L,2L,3L,3L,3L,3L,3L,3L,4L,2L,4L,3L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212185Inst : IEnumerable<long>
{
public static readonly long[] Value=A212185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212185.Bytes);
public long this[int i]=>Value[i];

public static A212185Inst Instance=new A212185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212186
{
public static readonly long[] Value={ 3L,1L,0L,4L,3L,7L,9L,0L,1L,7L,8L,5L,5L,5L,5L,5L,0L,9L,8L,1L,8L,1L,7L,6L,9L,8L,6L,3L,1L,8L,7L,7L,9L,4L,7L,6L,7L,2L,2L,8L,9L,0L,9L,2L,0L,3L,3L,6L,1L,3L,6L,8L,3L,5L,0L,9L,7L,2L,4L,8L,8L,8L,2L,6L,1L,9L,6L,8L,1L,4L,0L,3L,2L,6L,9L,9L,3L,9L,9L,9L,5L,8L,0L,2L,7L,8L,4L,6L,5L,6L,6L,3L,6L,1L,4L,8L,3L,9L,7L,6L,5L,8L,2L,8L,1L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212186Inst : IEnumerable<long>
{
public static readonly long[] Value=A212186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212186.Bytes);
public long this[int i]=>Value[i];

public static A212186Inst Instance=new A212186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212187
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,11L,15L,22L,30L,41L,55L,75L,97L,129L,166L,213L,272L,343L,430L,536L,664L,822L,1008L,1230L,1495L,1808L,2178L,2616L,3122L,3720L,4416L,5221L,6164L,7249L,8497L,9941L,11593L,13481L,15665L,18150L,20971L,24184L,27827L,31974L,36650L,41944L,47930L,54670L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212187Inst : IEnumerable<long>
{
public static readonly long[] Value=A212187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212187.Bytes);
public long this[int i]=>Value[i];

public static A212187Inst Instance=new A212187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212188
{
public static readonly long[] Value={ 1L,2L,5L,4L,13L,24L,27L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212188Inst : IEnumerable<long>
{
public static readonly long[] Value=A212188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212188.Bytes);
public long this[int i]=>Value[i];

public static A212188Inst Instance=new A212188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212189
{
public static readonly long[] Value={ 1L,1L,3L,2L,7L,12L,14L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212189Inst : IEnumerable<long>
{
public static readonly long[] Value=A212189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212189.Bytes);
public long this[int i]=>Value[i];

public static A212189Inst Instance=new A212189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212190
{
public static readonly long[] Value={ 25L,49L,81L,100L,196L,289L,324L,400L,529L,784L,1089L,1156L,1296L,1600L,2116L,3136L,4225L,4356L,4624L,5184L,6400L,8464L,12544L,16641L,16900L,17424L,18496L,20736L,25600L,33856L,50176L,66049L,66564L,67600L,69696L,73984L,82944L,102400L,135424L,200704L,263169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212190Inst : IEnumerable<long>
{
public static readonly long[] Value=A212190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212190.Bytes);
public long this[int i]=>Value[i];

public static A212190Inst Instance=new A212190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212191
{
public static readonly long[] Value={ 5L,7L,9L,10L,14L,17L,18L,20L,23L,28L,33L,34L,36L,40L,46L,56L,65L,66L,68L,72L,80L,92L,112L,129L,130L,132L,136L,144L,160L,184L,224L,257L,258L,260L,264L,272L,288L,320L,368L,448L,513L,514L,516L,520L,528L,544L,576L,640L,736L,896L,1025L,1026L,1028L,1032L,1040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212191Inst : IEnumerable<long>
{
public static readonly long[] Value=A212191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212191.Bytes);
public long this[int i]=>Value[i];

public static A212191Inst Instance=new A212191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212192
{
public static readonly long[] Value={ 21L,28L,276L,1540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212192Inst : IEnumerable<long>
{
public static readonly long[] Value=A212192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212192.Bytes);
public long this[int i]=>Value[i];

public static A212192Inst Instance=new A212192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212193
{
public static readonly long[] Value={ 1L,0L,0L,2L,0L,0L,1L,0L,0L,2L,2L,3L,2L,0L,0L,3L,0L,0L,1L,3L,1L,3L,0L,0L,1L,0L,0L,2L,2L,3L,2L,2L,3L,3L,3L,3L,2L,2L,3L,2L,0L,0L,3L,0L,0L,3L,3L,3L,3L,0L,0L,3L,0L,0L,1L,3L,1L,3L,3L,3L,1L,3L,1L,3L,3L,3L,3L,0L,0L,3L,0L,0L,1L,3L,1L,3L,0L,0L,1L,0L,0L,2L,2L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212193Inst : IEnumerable<long>
{
public static readonly long[] Value=A212193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212193.Bytes);
public long this[int i]=>Value[i];

public static A212193Inst Instance=new A212193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212194
{
public static readonly long[] Value={ 1L,0L,1L,-5L,8L,-4L,0L,1L,-16L,112L,-448L,1120L,-1791L,1786L,-1012L,248L,0L,1L,-33L,510L,-4898L,32703L,-160859L,602408L,-1749715L,3975561L,-7068408L,9755858L,-10265148L,7968348L,-4304712L,1445104L,-226720L,0L,1L,-56L,1508L,-25992L,321994L,-3051871L,23000726L,-141421592L,722137763L,-3101089710L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212194Inst : IEnumerable<long>
{
public static readonly long[] Value=A212194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212194.Bytes);
public long this[int i]=>Value[i];

public static A212194Inst Instance=new A212194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212195
{
public static readonly long[] Value={ 1L,0L,2L,0L,0L,3L,0L,0L,6L,4L,0L,0L,6L,48L,5L,0L,0L,6L,1056L,180L,6L,0L,0L,6L,45696L,32940L,480L,7L,0L,0L,6L,4038432L,30847500L,393600L,1050L,8L,0L,0L,6L,743601024L,148046704020L,3312560640L,2735250L,2016L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212195Inst : IEnumerable<long>
{
public static readonly long[] Value=A212195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212195.Bytes);
public long this[int i]=>Value[i];

public static A212195Inst Instance=new A212195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212196
{
public static readonly BigInteger[] Value={ 1L,-1L,2L,-8L,8L,-32L,6112L,-3712L,362624L,-71706112L,3341113856L,-79665268736L,1090547664896L,-38770843648L,106053090598912L,-5507347586961932288L,BigInteger.Parse("136847762542978039808"),BigInteger.Parse("-45309996254420664320"),BigInteger.Parse("3447910579774800362340352"),BigInteger.Parse("-916174777198089643491328") };
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
public class A212196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212196Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A212196.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A212196.Bytes);
public BigInteger this[int i]=>Value[i];

public static A212196Inst Instance=new A212196Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212197
{
public static readonly long[] Value={ 1L,2L,6L,14L,42L,114L,602L,798L,1806L,5334L,34314L,101346L,229362L,4357878L,9786714L,12198858L,168241542L,185947566L,231778302L,524550894L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212197Inst : IEnumerable<long>
{
public static readonly long[] Value=A212197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212197.Bytes);
public long this[int i]=>Value[i];

public static A212197Inst Instance=new A212197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212198
{
public static readonly long[] Value={ 1L,2L,6L,24L,116L,632L,3720L,23072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212198Inst : IEnumerable<long>
{
public static readonly long[] Value=A212198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212198.Bytes);
public long this[int i]=>Value[i];

public static A212198Inst Instance=new A212198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212199
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,5L,11L,39L,113L,377L,1207L,4043L,13509L,45957L,157171L,542671L,1884665L,6586993L,23137647L,81662355L,289414157L,1029598333L,3675337963L,13160833623L,47261437761L,170164260713L,614154154791L,2221545593179L,8052506141653L,29244341625077L,106397352342243L,387745600670175L,1415284544031241L,5173441096267489L,18937206005320415L,69409364862108451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212199Inst : IEnumerable<long>
{
public static readonly long[] Value=A212199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212199.Bytes);
public long this[int i]=>Value[i];

public static A212199Inst Instance=new A212199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212200
{
public static readonly long[] Value={ 1L,3L,3L,15L,15L,15L,15L,5L,15L,5L,15L,15L,5L,5L,15L,85L,85L,255L,255L,85L,85L,255L,255L,85L,85L,255L,255L,255L,255L,85L,85L,255L,255L,255L,255L,85L,255L,85L,255L,255L,255L,255L,255L,255L,85L,255L,85L,255L,85L,85L,255L,255L,255L,255L,255L,255L,255L,255L,255L,255L,85L,85L,255L,255L,51L,255L,255L,255L,51L,255L,255L,17L,255L,85L,255L,17L,255L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212200Inst : IEnumerable<long>
{
public static readonly long[] Value=A212200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212200.Bytes);
public long this[int i]=>Value[i];

public static A212200Inst Instance=new A212200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212201
{
public static readonly long[] Value={ 1L,3L,15L,85L,255L,21845L,65535L,1431655765L,4294967295L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212201Inst : IEnumerable<long>
{
public static readonly long[] Value=A212201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212201.Bytes);
public long this[int i]=>Value[i];

public static A212201Inst Instance=new A212201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212202
{
public static readonly long[] Value={ 1L,2L,4L,16L,18L,256L,258L,65536L,65540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212202Inst : IEnumerable<long>
{
public static readonly long[] Value=A212202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212202.Bytes);
public long this[int i]=>Value[i];

public static A212202Inst Instance=new A212202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212203
{
public static readonly long[] Value={ 1L,3L,15L,5L,85L,255L,51L,17L,21845L,65535L,4369L,13107L,1285L,771L,3855L,257L,1431655765L,4294967295L,84215045L,858993459L,50529027L,286331153L,252645135L,16843009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212203Inst : IEnumerable<long>
{
public static readonly long[] Value=A212203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212203.Bytes);
public long this[int i]=>Value[i];

public static A212203Inst Instance=new A212203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212204
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,18L,65L,72L,256L,258L,260L,266L,4101L,4132L,4167L,4290L,65536L,65540L,65542L,65544L,65594L,65600L,65658L,65694L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212204Inst : IEnumerable<long>
{
public static readonly long[] Value=A212204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212204.Bytes);
public long this[int i]=>Value[i];

public static A212204Inst Instance=new A212204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212205
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,18L,36L,86L,172L,426L,852L,2162L,4324L,11166L,22332L,58438L,116876L,309042L,618084L,1648154L,3296308L,8851206L,17702412L,47813790L,95627580L,259585002L,519170004L,1415431266L,2830862532L,7747200558L,15494401116L,42545600310L,85091200620L,234346445154L,468692890308L,1294260644906L,2588521289812L,7165245015510L,14330490031020L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212205Inst : IEnumerable<long>
{
public static readonly long[] Value=A212205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212205.Bytes);
public long this[int i]=>Value[i];

public static A212205Inst Instance=new A212205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212206
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,0L,1L,4L,0L,0L,12L,2L,0L,0L,12L,30L,0L,0L,4L,100L,28L,0L,0L,0L,140L,280L,9L,0L,0L,0L,90L,980L,360L,0L,0L,0L,22L,1680L,2940L,220L,0L,0L,0L,0L,1540L,10584L,4620L,52L,0L,0L,0L,0L,728L,20790L,33264L,4004L,0L,0L,0L,0L,140L,24024L,121968L,60060L,1820L,0L,0L,0L,0L,0L,16380L,264264L,396396L,65520L,340L,0L,0L,0L,0L,0L,6120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212206Inst : IEnumerable<long>
{
public static readonly long[] Value=A212206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212206.Bytes);
public long this[int i]=>Value[i];

public static A212206Inst Instance=new A212206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212207
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,1L,6L,9L,4L,1L,10L,26L,25L,8L,1L,15L,60L,95L,65L,16L,1L,21L,120L,280L,309L,161L,32L,1L,28L,217L,700L,1113L,924L,385L,64L,1L,36L,364L,1554L,3346L,3948L,2596L,897L,128L,1L,45L,576L,3150L,8820L,13902L,12864L,6957L,2049L,256L,1L,55L,870L,5940L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212207Inst : IEnumerable<long>
{
public static readonly long[] Value=A212207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212207.Bytes);
public long this[int i]=>Value[i];

public static A212207Inst Instance=new A212207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212208
{
public static readonly long[] Value={ 1L,0L,1L,-6L,11L,-6L,0L,1L,-20L,174L,-859L,2627L,-5082L,6048L,-4023L,1134L,0L,1L,-42L,825L,-10054L,85011L,-528254L,2491825L,-9084089L,25795983L,-57031153L,97292827L,-125639547L,118705077L,-77301243L,30931875L,-5709042L,0L,1L,-72L,2492L,-55183L,877812L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212208Inst : IEnumerable<long>
{
public static readonly long[] Value=A212208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212208.Bytes);
public long this[int i]=>Value[i];

public static A212208Inst Instance=new A212208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212209
{
public static readonly long[] Value={ 1L,0L,2L,0L,0L,3L,0L,0L,0L,4L,0L,0L,0L,24L,5L,0L,0L,0L,72L,120L,6L,0L,0L,0L,168L,6720L,360L,7L,0L,0L,0L,360L,935040L,126360L,840L,8L,0L,0L,0L,744L,325061760L,265035240L,1128960L,1680L,9L,0L,0L,0L,1512L,283192323840L,3322711053720L,17160407040L,6510000L,3024L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212209Inst : IEnumerable<long>
{
public static readonly long[] Value=A212209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212209.Bytes);
public long this[int i]=>Value[i];

public static A212209Inst Instance=new A212209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212210
{
public static readonly long[] Value={ -1L,-1L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,1L,2L,-1L,0L,1L,1L,1L,1L,0L,1L,2L,1L,2L,1L,2L,0L,1L,1L,1L,1L,1L,2L,2L,0L,0L,1L,0L,1L,1L,2L,1L,1L,-1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,2L,1L,2L,1L,1L,1L,2L,-1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,2L,1L,2L,1L,2L,2L,2L,1L,2L,2L,3L,0L,1L,1L,1L,1L,1L,2L,2L,1L,1L,2L,2L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212210Inst : IEnumerable<long>
{
public static readonly long[] Value=A212210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212210.Bytes);
public long this[int i]=>Value[i];

public static A212210Inst Instance=new A212210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212211
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,0L,0L,1L,1L,2L,0L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,1L,1L,1L,1L,2L,2L,0L,1L,0L,1L,1L,2L,1L,1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,1L,1L,2L,1L,2L,1L,1L,1L,2L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,2L,2L,1L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212211Inst : IEnumerable<long>
{
public static readonly long[] Value=A212211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212211.Bytes);
public long this[int i]=>Value[i];

public static A212211Inst Instance=new A212211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212212
{
public static readonly long[] Value={ -1L,-1L,-1L,0L,0L,0L,-1L,0L,0L,-1L,0L,0L,1L,0L,0L,-1L,0L,0L,0L,0L,-1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,1L,2L,1L,2L,1L,2L,1L,0L,-1L,0L,1L,1L,1L,1L,1L,1L,0L,-1L,0L,0L,1L,1L,2L,1L,2L,1L,1L,0L,0L,-1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,-1L,0L,0L,1L,0L,1L,1L,2L,1L,1L,0L,1L,0L,0L,0L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212212Inst : IEnumerable<long>
{
public static readonly long[] Value=A212212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212212.Bytes);
public long this[int i]=>Value[i];

public static A212212Inst Instance=new A212212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212213
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,0L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,2L,1L,2L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,1L,0L,1L,1L,2L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,2L,2L,1L,2L,1L,2L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212213Inst : IEnumerable<long>
{
public static readonly long[] Value=A212213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212213.Bytes);
public long this[int i]=>Value[i];

public static A212213Inst Instance=new A212213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212214
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,8L,14L,18L,29L,39L,57L,74L,109L,138L,192L,247L,335L,421L,565L,703L,926L,1151L,1484L,1828L,2349L,2868L,3624L,4423L,5538L,6706L,8345L,10048L,12394L,14895L,18219L,21789L,26549L,31596L,38226L,45415L,54656L,64654L,77501L,91368L,109003L,128244L,152279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212214Inst : IEnumerable<long>
{
public static readonly long[] Value=A212214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212214.Bytes);
public long this[int i]=>Value[i];

public static A212214Inst Instance=new A212214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212215
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,1L,0L,2L,1L,2L,0L,5L,1L,4L,2L,9L,1L,11L,2L,16L,5L,18L,3L,33L,8L,31L,11L,52L,11L,64L,16L,83L,29L,100L,26L,152L,39L,159L,59L,233L,61L,280L,83L,354L,129L,423L,122L,591L,180L,644L,241L,864L,260L,1050L,341L,1282L,472L,1523L,490L,2016L,655L,2224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212215Inst : IEnumerable<long>
{
public static readonly long[] Value=A212215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212215.Bytes);
public long this[int i]=>Value[i];

public static A212215Inst Instance=new A212215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212216
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,6L,7L,8L,12L,15L,18L,25L,28L,34L,44L,51L,59L,75L,87L,103L,124L,143L,163L,198L,228L,261L,310L,354L,404L,479L,538L,612L,708L,802L,907L,1049L,1175L,1320L,1518L,1711L,1910L,2187L,2431L,2724L,3097L,3447L,3843L,4348L,4818L,5373L,6032L,6693L,7420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212216Inst : IEnumerable<long>
{
public static readonly long[] Value=A212216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212216.Bytes);
public long this[int i]=>Value[i];

public static A212216Inst Instance=new A212216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212217
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,1L,0L,1L,1L,2L,0L,3L,1L,3L,2L,5L,0L,7L,2L,8L,3L,10L,1L,15L,6L,14L,6L,21L,6L,28L,9L,26L,14L,38L,12L,50L,16L,47L,26L,70L,19L,82L,31L,87L,47L,111L,33L,141L,58L,143L,71L,182L,63L,228L,93L,231L,117L,289L,102L,364L,148L,354L,187L,462L,172L,537L,227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212217Inst : IEnumerable<long>
{
public static readonly long[] Value=A212217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212217.Bytes);
public long this[int i]=>Value[i];

public static A212217Inst Instance=new A212217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212218
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,2L,3L,3L,4L,4L,4L,5L,6L,5L,7L,7L,8L,9L,10L,9L,11L,12L,13L,14L,16L,14L,18L,21L,19L,20L,23L,23L,28L,28L,28L,30L,36L,33L,39L,42L,39L,44L,50L,46L,54L,57L,56L,62L,69L,64L,71L,77L,82L,85L,89L,84L,99L,107L,103L,111L,119L,117L,132L,137L,137L,142L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212218Inst : IEnumerable<long>
{
public static readonly long[] Value=A212218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212218.Bytes);
public long this[int i]=>Value[i];

public static A212218Inst Instance=new A212218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212219
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,1L,0L,1L,1L,1L,0L,2L,1L,1L,1L,3L,0L,3L,1L,3L,2L,3L,1L,5L,3L,3L,2L,6L,4L,5L,3L,6L,6L,7L,2L,11L,5L,8L,6L,12L,7L,10L,8L,12L,11L,14L,8L,17L,11L,16L,13L,19L,13L,23L,15L,22L,17L,25L,18L,29L,24L,24L,23L,36L,25L,34L,25L,42L,34L,39L,30L,47L,40L,48L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212219Inst : IEnumerable<long>
{
public static readonly long[] Value=A212219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212219.Bytes);
public long this[int i]=>Value[i];

public static A212219Inst Instance=new A212219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212220
{
public static readonly long[] Value={ 1L,-3L,2L,0L,1L,-12L,58L,-137L,154L,-64L,0L,1L,-27L,324L,-2223L,9414L,-24879L,39528L,-33966L,11828L,0L,1L,-48L,1064L,-14244L,126936L,-784788L,3409590L,-10329081L,21197804L,-27779384L,20648794L,-6476644L,0L,1L,-75L,2650L,-58100L,878200L,-9632440L,78681510L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212220Inst : IEnumerable<long>
{
public static readonly long[] Value=A212220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212220.Bytes);
public long this[int i]=>Value[i];

public static A212220Inst Instance=new A212220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212221
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,1L,3L,0L,0L,1L,12L,6L,0L,0L,1L,30L,78L,10L,0L,0L,1L,66L,474L,340L,15L,0L,0L,1L,138L,2238L,4780L,1095L,21L,0L,0L,1L,282L,9546L,46420L,32955L,2856L,28L,0L,0L,1L,570L,38958L,385660L,617775L,168546L,6412L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212221Inst : IEnumerable<long>
{
public static readonly long[] Value=A212221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212221.Bytes);
public long this[int i]=>Value[i];

public static A212221Inst Instance=new A212221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212222
{
public static readonly long[] Value={ 0L,1L,1386L,1387L,485353L,981435L,4423035L,14187855L,19652536L,19652537L,19654636L,19654637L,23059876L,23059877L,23063359L,23837177L,25009516L,25009517L,41185278L,41185279L,41409018L,41409019L,49650315L,50262556L,50262557L,58622956L,58622957L,58623315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212222Inst : IEnumerable<long>
{
public static readonly long[] Value=A212222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212222.Bytes);
public long this[int i]=>Value[i];

public static A212222Inst Instance=new A212222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212223
{
public static readonly long[] Value={ 2L,6L,6L,882L,1386L,2007986541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212223Inst : IEnumerable<long>
{
public static readonly long[] Value=A212223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212223.Bytes);
public long this[int i]=>Value[i];

public static A212223Inst Instance=new A212223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212224
{
public static readonly long[] Value={ 1L,3L,5L,8L,4L,5L,6L,2L,7L,4L,1L,8L,2L,9L,8L,8L,4L,3L,5L,2L,0L,6L,1L,8L,0L,6L,0L,0L,5L,0L,1L,8L,7L,9L,4L,5L,6L,5L,9L,8L,0L,8L,8L,1L,8L,4L,6L,2L,3L,7L,0L,9L,1L,9L,3L,2L,5L,6L,0L,1L,0L,2L,5L,3L,2L,8L,9L,1L,1L,3L,0L,5L,7L,9L,8L,5L,1L,8L,7L,8L,2L,9L,5L,1L,0L,8L,1L,5L,9L,1L,1L,9L,7L,7L,5L,0L,2L,1L,3L,8L,8L,2L,2L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212224Inst : IEnumerable<long>
{
public static readonly long[] Value=A212224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212224.Bytes);
public long this[int i]=>Value[i];

public static A212224Inst Instance=new A212224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212225
{
public static readonly long[] Value={ 3L,0L,6L,3L,4L,8L,9L,6L,2L,5L,3L,0L,0L,3L,3L,1L,2L,2L,1L,1L,5L,6L,7L,5L,7L,0L,1L,1L,9L,9L,7L,7L,0L,6L,8L,9L,2L,3L,5L,2L,5L,7L,8L,5L,6L,3L,8L,7L,5L,6L,9L,8L,3L,8L,3L,2L,9L,3L,4L,9L,1L,2L,1L,5L,9L,7L,8L,9L,1L,6L,1L,2L,6L,7L,4L,7L,5L,3L,4L,5L,6L,6L,7L,4L,1L,3L,9L,1L,8L,8L,1L,5L,0L,4L,8L,1L,7L,9L,2L,6L,3L,8L,2L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212225Inst : IEnumerable<long>
{
public static readonly long[] Value=A212225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212225.Bytes);
public long this[int i]=>Value[i];

public static A212225Inst Instance=new A212225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212226
{
public static readonly long[] Value={ 50L,124L,311L,775L,1895L,4663L,11518L,28446L,70145L,172951L,426630L,1052487L,2596184L,6403675L,15795627L,38963018L,96109484L,237070048L,584773118L,1442444418L,3558040343L,8776520278L,21648797430L,53400493513L,131721540000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212226Inst : IEnumerable<long>
{
public static readonly long[] Value=A212226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212226.Bytes);
public long this[int i]=>Value[i];

public static A212226Inst Instance=new A212226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212227
{
public static readonly long[] Value={ 435L,1113L,2902L,7596L,19834L,51440L,131950L,339564L,876777L,2267261L,5864274L,15159987L,39161060L,101136977L,261240954L,674934552L,1743897567L,4505828919L,11641402990L,30075908053L,77701600604L,200746256554L,518645274018L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212227Inst : IEnumerable<long>
{
public static readonly long[] Value=A212227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212227.Bytes);
public long this[int i]=>Value[i];

public static A212227Inst Instance=new A212227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212228
{
public static readonly long[] Value={ 3834L,10002L,26637L,71427L,191853L,514687L,1376128L,3659968L,9662878L,25562476L,67800449L,180120882L,478897973L,1273545563L,3386125989L,8999257525L,23906208533L,63493578634L,168644397152L,447996097328L,1190222549456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212228Inst : IEnumerable<long>
{
public static readonly long[] Value=A212228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212228.Bytes);
public long this[int i]=>Value[i];

public static A212228Inst Instance=new A212228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212229
{
public static readonly long[] Value={ 34001L,89911L,242780L,660796L,1804448L,4931630L,13468524L,36711516L,99762134L,269986256L,726810250L,1959270880L,5292416365L,14316932524L,38765529832L,105016326560L,284539410032L,770899685027L,2088100303095L,5654125322731L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212229Inst : IEnumerable<long>
{
public static readonly long[] Value=A212229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212229.Bytes);
public long this[int i]=>Value[i];

public static A212229Inst Instance=new A212229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212230
{
public static readonly long[] Value={ 302615L,808403L,2204646L,6062948L,16740414L,46305966L,128148456L,354470546L,979272751L,2700150083L,7425872754L,20355794336L,55576133157L,151888056136L,415782103202L,1139624300299L,3126418458642L,8581964181953L,23565242287322L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212230Inst : IEnumerable<long>
{
public static readonly long[] Value=A212230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212230.Bytes);
public long this[int i]=>Value[i];

public static A212230Inst Instance=new A212230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212231
{
public static readonly long[] Value={ 2699598L,7269626L,19976155L,55360211L,154089343L,429886243L,1200645159L,3354267511L,9367667604L,26139182862L,72841658426L,202630826716L,562443898300L,1557047060794L,4296908081691L,11867091374754L,32817710013245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212231Inst : IEnumerable<long>
{
public static readonly long[] Value=A212231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212231.Bytes);
public long this[int i]=>Value[i];

public static A212231Inst Instance=new A212231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212232
{
public static readonly long[] Value={ 6L,50L,14L,435L,124L,31L,3834L,1113L,311L,70L,34001L,10002L,2902L,775L,157L,302615L,89911L,26637L,7596L,1895L,353L,2699598L,808403L,242780L,71427L,19834L,4663L,793L,24121674L,7269626L,2204646L,660796L,191853L,51440L,11518L,1782L,215786649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212232Inst : IEnumerable<long>
{
public static readonly long[] Value=A212232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212232.Bytes);
public long this[int i]=>Value[i];

public static A212232Inst Instance=new A212232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212233
{
public static readonly long[] Value={ 6L,50L,435L,3834L,34001L,302615L,2699598L,24121674L,215786649L,1932081885L,17311097568L,155188936431L,1391839527240L,12487516404434L,112071578930795L,1006067340461802L,9033468257955009L,81126883587357557L,728697257578499280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212233Inst : IEnumerable<long>
{
public static readonly long[] Value=A212233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212233.Bytes);
public long this[int i]=>Value[i];

public static A212233Inst Instance=new A212233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212234
{
public static readonly long[] Value={ 14L,124L,1113L,10002L,89911L,808403L,7269626L,65380788L,588072207L,5289869433L,47586806448L,428105244789L,3851528519268L,34652238703192L,311776035394625L,2805210936456962L,25240510718260791L,227111596463339585L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212234Inst : IEnumerable<long>
{
public static readonly long[] Value=A212234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212234.Bytes);
public long this[int i]=>Value[i];

public static A212234Inst Instance=new A212234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212235
{
public static readonly long[] Value={ 31L,311L,2902L,26637L,242780L,2204646L,19976155L,180744711L,1633768428L,14757208260L,133224377745L,1202213897088L,10845157390965L,97807813761227L,881892198839574L,7950191559259765L,71659250039164212L,645816864760873772L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212235Inst : IEnumerable<long>
{
public static readonly long[] Value=A212235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212235.Bytes);
public long this[int i]=>Value[i];

public static A212235Inst Instance=new A212235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212236
{
public static readonly long[] Value={ 70L,775L,7596L,71427L,660796L,6062948L,55360211L,503916387L,4577086146L,41509589394L,376014757137L,3403088304192L,30777595344747L,278194559997967L,2513387971773920L,22698724065174107L,204927838029912468L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212236Inst : IEnumerable<long>
{
public static readonly long[] Value=A212236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212236.Bytes);
public long this[int i]=>Value[i];

public static A212236Inst Instance=new A212236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212237
{
public static readonly long[] Value={ 157L,1895L,19834L,191853L,1804448L,16740414L,154089343L,1411275807L,12881812440L,117296944044L,1066131740757L,9676805664696L,87736143094569L,794774081112347L,7194441026799642L,65086616352089797L,588530376516453384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212237Inst : IEnumerable<long>
{
public static readonly long[] Value=A212237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212237.Bytes);
public long this[int i]=>Value[i];

public static A212237Inst Instance=new A212237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212238
{
public static readonly long[] Value={ 353L,4663L,51440L,514687L,4931630L,46305966L,429886243L,3962696059L,36354382954L,332393767866L,3031533285381L,27595759169532L,250826014161861L,2277103688384513L,20652344756363304L,187156724402029627L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212238Inst : IEnumerable<long>
{
public static readonly long[] Value=A212238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212238.Bytes);
public long this[int i]=>Value[i];

public static A212238Inst Instance=new A212238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212239
{
public static readonly long[] Value={ 793L,11518L,131950L,1376128L,13468524L,128148456L,1200645159L,11143104246L,102770036310L,943639250739L,8636456931969L,78848824010001L,718489851092745L,6537040547889223L,59402114237433426L,539234176052230974L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212239Inst : IEnumerable<long>
{
public static readonly long[] Value=A212239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212239.Bytes);
public long this[int i]=>Value[i];

public static A212239Inst Instance=new A212239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212240
{
public static readonly long[] Value={ 0L,1L,16L,80L,251L,612L,1269L,2354L,4021L,6449L,9844L,14427L,20458L,28203L,37972L,50073L,64876L,82725L,104046L,129222L,158741L,193024L,232607L,277956L,329675L,388248L,454353L,528508L,611435L,703712L,806121L,919242L,1043953L,1180865L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212240Inst : IEnumerable<long>
{
public static readonly long[] Value=A212240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212240.Bytes);
public long this[int i]=>Value[i];

public static A212240Inst Instance=new A212240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212241
{
public static readonly long[] Value={ 0L,1L,15L,76L,243L,598L,1249L,2326L,3984L,6405L,9786L,14363L,20378L,28117L,37864L,49965L,64740L,82591L,103877L,129062L,158543L,192832L,232371L,277740L,329399L,388002L,454043L,528220L,611087L,703402L,805721L,918898L,1043520L,1180469L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212241Inst : IEnumerable<long>
{
public static readonly long[] Value=A212241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212241.Bytes);
public long this[int i]=>Value[i];

public static A212241Inst Instance=new A212241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212242
{
public static readonly long[] Value={ 1L,2L,53L,204L,625L,1556L,3357L,6558L,11809L,20000L,32211L,49762L,74263L,107564L,151875L,209716L,283967L,377918L,495219L,640000L,816821L,1030722L,1287273L,1592524L,1953125L,2376276L,2869777L,3442078L,4102229L,4860000L,5725831L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212242Inst : IEnumerable<long>
{
public static readonly long[] Value=A212242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212242.Bytes);
public long this[int i]=>Value[i];

public static A212242Inst Instance=new A212242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212243
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,4L,7L,8L,14L,13L,24L,19L,33L,26L,48L,32L,60L,41L,75L,49L,92L,58L,109L,66L,127L,76L,146L,88L,168L,96L,184L,106L,212L,122L,227L,126L,263L,140L,271L,158L,304L,163L,326L,175L,363L,196L,366L,198L,425L,212L,416L,240L,474L,238L,488L,250L,528L,284L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212243Inst : IEnumerable<long>
{
public static readonly long[] Value=A212243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212243.Bytes);
public long this[int i]=>Value[i];

public static A212243Inst Instance=new A212243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212244
{
public static readonly long[] Value={ 0L,0L,3L,9L,13L,22L,31L,37L,48L,60L,69L,81L,93L,102L,118L,136L,142L,154L,178L,184L,202L,220L,229L,250L,265L,280L,295L,315L,333L,345L,372L,378L,400L,424L,433L,457L,481L,487L,511L,535L,550L,568L,595L,607L,625L,661L,676L,688L,712L,724L,757L,775L,787L,817L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212244Inst : IEnumerable<long>
{
public static readonly long[] Value=A212244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212244.Bytes);
public long this[int i]=>Value[i];

public static A212244Inst Instance=new A212244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212245
{
public static readonly long[] Value={ 0L,0L,0L,4L,12L,15L,21L,36L,45L,46L,64L,76L,88L,91L,114L,120L,144L,156L,153L,186L,204L,201L,235L,235L,268L,271L,289L,316L,334L,340L,361L,382L,408L,408L,444L,465L,465L,489L,519L,525L,576L,573L,589L,616L,652L,640L,664L,709L,736L,748L,760L,778L,826L,808L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212245Inst : IEnumerable<long>
{
public static readonly long[] Value=A212245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212245.Bytes);
public long this[int i]=>Value[i];

public static A212245Inst Instance=new A212245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212246
{
public static readonly long[] Value={ 0L,0L,4L,21L,65L,155L,315L,574L,966L,1530L,2310L,3355L,4719L,6461L,8645L,11340L,14620L,18564L,23256L,28785L,35245L,42735L,51359L,61226L,72450L,85150L,99450L,115479L,133371L,153265L,175305L,199640L,226424L,255816L,287980L,323085L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212246Inst : IEnumerable<long>
{
public static readonly long[] Value=A212246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212246.Bytes);
public long this[int i]=>Value[i];

public static A212246Inst Instance=new A212246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212247
{
public static readonly long[] Value={ 0L,1L,4L,13L,29L,56L,95L,150L,222L,315L,430L,571L,739L,938L,1169L,1436L,1740L,2085L,2472L,2905L,3385L,3916L,4499L,5138L,5834L,6591L,7410L,8295L,9247L,10270L,11365L,12536L,13784L,15113L,16524L,18021L,19605L,21280L,23047L,24910L,26870L,28931L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212247Inst : IEnumerable<long>
{
public static readonly long[] Value=A212247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212247.Bytes);
public long this[int i]=>Value[i];

public static A212247Inst Instance=new A212247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212248
{
public static readonly long[] Value={ 1L,-1L,1L,0L,-1L,0L,1L,-1L,0L,-1L,1L,1L,0L,1L,-1L,-2L,5L,0L,3L,1L,2L,-9L,5L,0L,2L,4L,-2L,9L,-9L,-21L,0L,-15L,5L,-10L,-9L,9L,50L,-105L,0L,-62L,-19L,-18L,-54L,-9L,-50L,267L,-141L,0L,-56L,-119L,42L,-126L,-63L,50L,-267L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212248Inst : IEnumerable<long>
{
public static readonly long[] Value=A212248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212248.Bytes);
public long this[int i]=>Value[i];

public static A212248Inst Instance=new A212248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212249
{
public static readonly long[] Value={ 0L,1L,12L,63L,202L,496L,1034L,1923L,3289L,5280L,8062L,11820L,16761L,23110L,31111L,41030L,53151L,67777L,85233L,105862L,130026L,158109L,190513L,227659L,269990L,317967L,372070L,432801L,500680L,576246L,660060L,752701L,854767L,966878L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212249Inst : IEnumerable<long>
{
public static readonly long[] Value=A212249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212249.Bytes);
public long this[int i]=>Value[i];

public static A212249Inst Instance=new A212249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212250
{
public static readonly long[] Value={ 0L,0L,4L,18L,54L,129L,262L,478L,807L,1281L,1938L,2821L,3975L,5451L,7305L,9595L,12385L,15744L,19743L,24459L,29974L,36372L,43743L,52182L,61786L,72658L,84906L,98640L,113976L,131035L,149940L,170820L,193809L,219043L,246664L,276819L,309657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212250Inst : IEnumerable<long>
{
public static readonly long[] Value=A212250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212250.Bytes);
public long this[int i]=>Value[i];

public static A212250Inst Instance=new A212250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212251
{
public static readonly long[] Value={ 0L,0L,1L,6L,15L,30L,54L,87L,131L,189L,261L,349L,456L,582L,729L,900L,1095L,1316L,1566L,1845L,2155L,2499L,2877L,3291L,3744L,4236L,4769L,5346L,5967L,6634L,7350L,8115L,8931L,9801L,10725L,11705L,12744L,13842L,15001L,16224L,17511L,18864L,20286L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212251Inst : IEnumerable<long>
{
public static readonly long[] Value=A212251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212251.Bytes);
public long this[int i]=>Value[i];

public static A212251Inst Instance=new A212251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212252
{
public static readonly long[] Value={ 0L,0L,0L,3L,11L,24L,45L,76L,117L,171L,240L,324L,426L,548L,690L,855L,1045L,1260L,1503L,1776L,2079L,2415L,2786L,3192L,3636L,4120L,4644L,5211L,5823L,6480L,7185L,7940L,8745L,9603L,10516L,11484L,12510L,13596L,14742L,15951L,17225L,18564L,19971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212252Inst : IEnumerable<long>
{
public static readonly long[] Value=A212252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212252.Bytes);
public long this[int i]=>Value[i];

public static A212252Inst Instance=new A212252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212253
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,6L,10L,12L,18L,23L,31L,39L,54L,66L,86L,107L,137L,168L,213L,259L,323L,392L,482L,580L,711L,850L,1029L,1228L,1476L,1750L,2093L,2470L,2934L,3453L,4078L,4780L,5625L,6566L,7689L,8952L,10440L,12113L,14080L,16286L,18865L,21764L,25127L,28910L,33289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212253Inst : IEnumerable<long>
{
public static readonly long[] Value=A212253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212253.Bytes);
public long this[int i]=>Value[i];

public static A212253Inst Instance=new A212253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212254
{
public static readonly long[] Value={ 0L,0L,0L,1L,4L,11L,21L,37L,59L,88L,125L,172L,228L,296L,376L,469L,576L,699L,837L,993L,1167L,1360L,1573L,1808L,2064L,2344L,2648L,2977L,3332L,3715L,4125L,4565L,5035L,5536L,6069L,6636L,7236L,7872L,8544L,9253L,10000L,10787L,11613L,12481L,13391L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212254Inst : IEnumerable<long>
{
public static readonly long[] Value=A212254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212254.Bytes);
public long this[int i]=>Value[i];

public static A212254Inst Instance=new A212254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212255
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,8L,9L,16L,17L,18L,22L,32L,33L,43L,50L,54L,55L,68L,69L,85L,89L,96L,106L,125L,126L,151L,161L,162L,169L,191L,195L,220L,221L,231L,244L,284L,285L,313L,329L,339L,343L,380L,387L,415L,425L,429L,448L,485L,486L,523L,548L,561L,571L,611L,612L,685L,692L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212255Inst : IEnumerable<long>
{
public static readonly long[] Value=A212255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212255.Bytes);
public long this[int i]=>Value[i];

public static A212255Inst Instance=new A212255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A212256
{
public static readonly long[] Value={ 0L,1L,1L,4L,13L,1L,22L,1L,13L,10L,22L,1L,61L,1L,18L,102L,13L,1L,82L,1L,156L,79L,1L,1L,184L,1L,1L,10L,183L,1L,297L,1L,13L,105L,1L,181L,298L,1L,1L,16L,285L,1L,378L,1L,64L,405L,1L,1L,358L,1L,37L,13L,96L,1L,163L,130L,402L,31L,1L,1L,944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A212256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A212256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A212256Inst : IEnumerable<long>
{
public static readonly long[] Value=A212256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A212256.Bytes);
public long this[int i]=>Value[i];

public static A212256Inst Instance=new A212256Inst();

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