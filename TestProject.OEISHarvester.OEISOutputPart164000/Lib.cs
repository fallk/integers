using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A194457
{
public static readonly BigInteger[] Value={ 1L,2L,4L,-16L,-704L,-17728L,-337616L,11402624L,3549329536L,595083636992L,71290751812864L,-14356598757876736L,BigInteger.Parse("-25888783158323201024"),BigInteger.Parse("-24314339173695033407488"),BigInteger.Parse("-15893228305971746577453056"),BigInteger.Parse("17044727383475526594464251904"),BigInteger.Parse("160878265780790778493935871983616") };
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
public class A194457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194457Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194457.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194457.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194457Inst Instance=new A194457Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194458
{
public static readonly long[] Value={ 1L,3L,6L,10L,15L,17L,21L,27L,35L,45L,48L,54L,63L,75L,90L,94L,102L,114L,130L,150L,155L,165L,180L,200L,225L,227L,231L,237L,245L,255L,259L,267L,279L,295L,315L,321L,333L,351L,375L,405L,413L,429L,453L,485L,525L,535L,555L,585L,625L,675L,678L,684L,693L,705L,720L,726L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194458Inst : IEnumerable<long>
{
public static readonly long[] Value=A194458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194458.Bytes);
public long this[int i]=>Value[i];

public static A194458Inst Instance=new A194458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194459
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,2L,4L,6L,8L,10L,3L,6L,9L,12L,15L,4L,8L,12L,16L,20L,5L,10L,15L,20L,25L,2L,4L,6L,8L,10L,4L,8L,12L,16L,20L,6L,12L,18L,24L,30L,8L,16L,24L,32L,40L,10L,20L,30L,40L,50L,3L,6L,9L,12L,15L,6L,12L,18L,24L,30L,9L,18L,27L,36L,45L,12L,24L,36L,48L,60L,15L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194459Inst : IEnumerable<long>
{
public static readonly long[] Value=A194459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194459.Bytes);
public long this[int i]=>Value[i];

public static A194459Inst Instance=new A194459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194460
{
public static readonly long[] Value={ 1L,4L,18L,82L,370L,1648L,7252L,31582L,136338L,584248L,2488156L,10540484L,44450068L,186715072L,781628008L,3262239862L,13579324498L,56391614632L,233686316428L,966556003132L,3990942300508L,16453094542432L,67733512006168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194460Inst : IEnumerable<long>
{
public static readonly long[] Value=A194460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194460.Bytes);
public long this[int i]=>Value[i];

public static A194460Inst Instance=new A194460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194461
{
public static readonly long[] Value={ 3L,6L,8L,9L,11L,12L,16L,19L,21L,22L,24L,25L,29L,32L,42L,45L,55L,58L,61L,63L,64L,66L,67L,71L,74L,76L,77L,79L,80L,84L,87L,97L,100L,110L,113L,116L,118L,119L,121L,122L,126L,129L,131L,132L,134L,135L,139L,142L,144L,145L,147L,148L,150L,151L,152L,153L,154L,155L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194461Inst : IEnumerable<long>
{
public static readonly long[] Value=A194461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194461.Bytes);
public long this[int i]=>Value[i];

public static A194461Inst Instance=new A194461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194462
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,10L,13L,14L,15L,17L,18L,20L,23L,26L,27L,28L,30L,31L,33L,34L,35L,36L,37L,38L,39L,40L,41L,43L,44L,46L,47L,48L,49L,50L,51L,52L,53L,54L,56L,57L,59L,60L,62L,65L,68L,69L,70L,72L,73L,75L,78L,81L,82L,83L,85L,86L,88L,89L,90L,91L,92L,93L,94L,95L,96L,98L,99L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194462Inst : IEnumerable<long>
{
public static readonly long[] Value=A194462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194462.Bytes);
public long this[int i]=>Value[i];

public static A194462Inst Instance=new A194462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194463
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,9L,11L,12L,16L,17L,21L,22L,23L,24L,25L,27L,28L,29L,30L,32L,33L,37L,38L,42L,43L,44L,45L,46L,48L,49L,50L,51L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,69L,70L,71L,72L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L,84L,85L,86L,87L,88L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194463Inst : IEnumerable<long>
{
public static readonly long[] Value=A194463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194463.Bytes);
public long this[int i]=>Value[i];

public static A194463Inst Instance=new A194463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194464
{
public static readonly long[] Value={ 5L,10L,13L,14L,15L,18L,19L,20L,26L,31L,34L,35L,36L,39L,40L,41L,47L,52L,68L,73L,89L,94L,99L,102L,103L,104L,107L,108L,109L,115L,120L,123L,124L,125L,128L,129L,130L,136L,141L,157L,162L,178L,183L,188L,191L,192L,193L,196L,197L,198L,204L,209L,212L,213L,214L,217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194464Inst : IEnumerable<long>
{
public static readonly long[] Value=A194464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194464.Bytes);
public long this[int i]=>Value[i];

public static A194464Inst Instance=new A194464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194465
{
public static readonly long[] Value={ 1L,2L,4L,7L,8L,9L,11L,12L,13L,14L,15L,16L,18L,19L,21L,24L,25L,26L,28L,31L,38L,41L,42L,43L,45L,48L,49L,50L,52L,53L,54L,55L,56L,57L,59L,60L,62L,65L,66L,67L,69L,70L,71L,72L,73L,74L,76L,77L,78L,79L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,90L,91L,93L,94L,95L,96L,97L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194465Inst : IEnumerable<long>
{
public static readonly long[] Value=A194465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194465.Bytes);
public long this[int i]=>Value[i];

public static A194465Inst Instance=new A194465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194466
{
public static readonly long[] Value={ 3L,5L,6L,10L,17L,20L,22L,23L,27L,29L,30L,32L,33L,34L,35L,36L,37L,39L,40L,44L,46L,47L,51L,58L,61L,63L,64L,68L,75L,92L,99L,102L,104L,105L,109L,116L,119L,121L,122L,126L,128L,129L,131L,132L,133L,134L,135L,136L,138L,139L,143L,145L,146L,150L,157L,160L,162L,163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194466Inst : IEnumerable<long>
{
public static readonly long[] Value=A194466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194466.Bytes);
public long this[int i]=>Value[i];

public static A194466Inst Instance=new A194466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194467
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,9L,10L,12L,13L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194467Inst : IEnumerable<long>
{
public static readonly long[] Value=A194467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194467.Bytes);
public long this[int i]=>Value[i];

public static A194467Inst Instance=new A194467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194468
{
public static readonly long[] Value={ 7L,11L,14L,26L,52L,97L,104L,108L,111L,123L,149L,153L,156L,160L,163L,164L,165L,167L,175L,179L,182L,194L,201L,205L,208L,220L,317L,362L,369L,373L,376L,388L,414L,582L,679L,724L,731L,735L,738L,750L,776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194468Inst : IEnumerable<long>
{
public static readonly long[] Value=A194468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194468.Bytes);
public long this[int i]=>Value[i];

public static A194468Inst Instance=new A194468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194469
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,9L,10L,12L,16L,17L,18L,20L,25L,26L,30L,36L,37L,38L,39L,41L,42L,49L,50L,52L,54L,55L,56L,64L,65L,66L,68L,70L,72L,81L,82L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194469Inst : IEnumerable<long>
{
public static readonly long[] Value=A194469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194469.Bytes);
public long this[int i]=>Value[i];

public static A194469Inst Instance=new A194469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194470
{
public static readonly long[] Value={ 3L,7L,8L,11L,13L,14L,15L,19L,21L,22L,23L,24L,27L,28L,29L,31L,32L,33L,34L,34L,40L,43L,44L,45L,46L,47L,48L,51L,53L,57L,58L,59L,60L,61L,62L,63L,67L,69L,71L,73L,74L,75L,76L,77L,78L,79L,80L,83L,85L,86L,87L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194470Inst : IEnumerable<long>
{
public static readonly long[] Value=A194470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194470.Bytes);
public long this[int i]=>Value[i];

public static A194470Inst Instance=new A194470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194471
{
public static readonly BigInteger[] Value={ 1L,2L,9L,79L,1065L,19401L,445933L,12389021L,403897553L,15120448273L,639345572181L,30138682861365L,1567316344601593L,89137628104427033L,5503952108613407933L,BigInteger.Parse("366697176991277153341"),BigInteger.Parse("26220726323043177903009"),BigInteger.Parse("2002962250253424509250081") };
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
public class A194471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194471Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194471.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194471.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194471Inst Instance=new A194471Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194472
{
public static readonly long[] Value={ 24L,2016L,8190L,42336L,45864L,392448L,714240L,1571328L,61900800L,91963648L,211891200L,1931236608L,2013143040L,4428914688L,10200236032L,214204956672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194472Inst : IEnumerable<long>
{
public static readonly long[] Value=A194472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194472.Bytes);
public long this[int i]=>Value[i];

public static A194472Inst Instance=new A194472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194473
{
public static readonly long[] Value={ 3L,2L,7L,9L,1L,8L,5L,8L,3L,3L,3L,8L,6L,6L,8L,2L,4L,8L,1L,7L,0L,1L,1L,3L,0L,2L,0L,6L,2L,5L,2L,3L,1L,4L,6L,2L,0L,3L,7L,0L,1L,4L,3L,4L,9L,0L,0L,9L,5L,7L,5L,0L,9L,8L,0L,4L,5L,8L,6L,1L,3L,7L,5L,3L,4L,2L,0L,2L,3L,6L,3L,2L,0L,2L,2L,6L,1L,5L,0L,9L,5L,0L,4L,0L,7L,6L,5L,5L,4L,6L,0L,3L,3L,9L,9L,2L,1L,1L,9L,9L,6L,3L,3L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194473Inst : IEnumerable<long>
{
public static readonly long[] Value=A194473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194473.Bytes);
public long this[int i]=>Value[i];

public static A194473Inst Instance=new A194473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194474
{
public static readonly long[] Value={ 7L,4L,4L,3L,6L,4L,4L,6L,4L,4L,4L,8L,0L,0L,7L,4L,6L,2L,8L,8L,9L,0L,8L,1L,3L,4L,0L,0L,5L,8L,2L,5L,7L,6L,6L,3L,9L,3L,2L,2L,3L,1L,3L,7L,4L,4L,7L,6L,2L,5L,0L,2L,8L,1L,3L,1L,6L,5L,5L,0L,2L,9L,4L,3L,7L,2L,4L,3L,2L,1L,2L,7L,7L,6L,2L,5L,5L,1L,5L,8L,0L,5L,3L,1L,0L,7L,3L,5L,7L,3L,9L,6L,5L,6L,9L,7L,7L,5L,1L,8L,0L,4L,1L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194474Inst : IEnumerable<long>
{
public static readonly long[] Value=A194474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194474.Bytes);
public long this[int i]=>Value[i];

public static A194474Inst Instance=new A194474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194475
{
public static readonly long[] Value={ 0L,1L,17L,105L,410L,1225L,3066L,6762L,13560L,25245L,44275L,73931L,118482L,183365L,275380L,402900L,576096L,807177L,1110645L,1503565L,2005850L,2640561L,3434222L,4417150L,5623800L,7093125L,8868951L,11000367L,13542130L,16555085L,20106600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194475Inst : IEnumerable<long>
{
public static readonly long[] Value=A194475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194475.Bytes);
public long this[int i]=>Value[i];

public static A194475Inst Instance=new A194475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194476
{
public static readonly long[] Value={ 0L,0L,6L,114L,879L,4284L,15729L,47565L,124803L,293733L,634293L,1277133L,2426424L,4389567L,7615062L,12739902L,20647962L,32540958L,50023656L,75205116L,110817861L,160356966L,228241167L,319998195L,442476645L,604086795L,815072895L,1087819551L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194476Inst : IEnumerable<long>
{
public static readonly long[] Value=A194476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194476.Bytes);
public long this[int i]=>Value[i];

public static A194476Inst Instance=new A194476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194477
{
public static readonly long[] Value={ 0L,0L,0L,39L,909L,8568L,50526L,221508L,789453L,2412333L,6542316L,16127397L,36762726L,78495417L,158548572L,305303544L,563965038L,1004432454L,1732013856L,2901747051L,4737236427L,7555075374L,11796103242L,18064943820L,27179490195L,40232239515L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194477Inst : IEnumerable<long>
{
public static readonly long[] Value=A194477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194477.Bytes);
public long this[int i]=>Value[i];

public static A194477Inst Instance=new A194477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194478
{
public static readonly long[] Value={ 0L,0L,0L,1L,337L,8733L,96478L,668028L,3413828L,14054915L,49171641L,151422970L,420674150L,1073422309L,2550004472L,5699074284L,12082541388L,24462528078L,47555986746L,89173692795L,161899772067L,285517344145L,490447009030L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194478Inst : IEnumerable<long>
{
public static readonly long[] Value=A194478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194478.Bytes);
public long this[int i]=>Value[i];

public static A194478Inst Instance=new A194478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194479
{
public static readonly long[] Value={ 0L,0L,0L,0L,15L,3525L,98473L,1237434L,9821400L,57367112L,268378248L,1059987987L,3661533037L,11341971885L,32090198922L,84099053568L,206386405560L,478423135296L,1054963957500L,2225704950054L,4514320792971L,8838377453829L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194479Inst : IEnumerable<long>
{
public static readonly long[] Value=A194479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194479.Bytes);
public long this[int i]=>Value[i];

public static A194479Inst Instance=new A194479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194480
{
public static readonly long[] Value={ 1L,0L,3L,0L,3L,6L,0L,1L,15L,10L,0L,0L,17L,45L,15L,0L,0L,6L,105L,105L,21L,0L,0L,0L,114L,410L,210L,28L,0L,0L,0L,39L,879L,1225L,378L,36L,0L,0L,0L,1L,909L,4284L,3066L,630L,45L,0L,0L,0L,0L,337L,8568L,15729L,6762L,990L,55L,0L,0L,0L,0L,15L,8733L,50526L,47565L,13560L,1485L,66L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194480Inst : IEnumerable<long>
{
public static readonly long[] Value=A194480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194480.Bytes);
public long this[int i]=>Value[i];

public static A194480Inst Instance=new A194480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194481
{
public static readonly long[] Value={ 0L,0L,15L,207L,1347L,5922L,20307L,58527L,148239L,339669L,718344L,1422564L,2666664L,4771221L,8201466L,13615266L,21922146L,34354926L,52555653L,78677613L,115505313L,166594428L,236433813L,330631785L,456128985L,621440235L,836927910L,1115109450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194481Inst : IEnumerable<long>
{
public static readonly long[] Value=A194481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194481.Bytes);
public long this[int i]=>Value[i];

public static A194481Inst Instance=new A194481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194482
{
public static readonly long[] Value={ 0L,0L,6L,234L,2817L,19362L,94584L,365904L,1193283L,3413619L,8800704L,20845968L,46017972L,95710797L,189154056L,357631176L,650438802L,1143119610L,1948614426L,3232108278L,5230489803L,8277505236L,12835867968L,19537783320L,29235566685L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194482Inst : IEnumerable<long>
{
public static readonly long[] Value=A194482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194482.Bytes);
public long this[int i]=>Value[i];

public static A194482Inst Instance=new A194482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194483
{
public static readonly long[] Value={ 0L,0L,1L,165L,4135L,47010L,337860L,1790472L,7622340L,27489825L,87018360L,247874770L,647091588L,1569661600L,3576049620L,7716906900L,15881735580L,31347485274L,59618165895L,109678780695L,195827638105L,340301983890L,576974687080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194483Inst : IEnumerable<long>
{
public static readonly long[] Value=A194483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194483.Bytes);
public long this[int i]=>Value[i];

public static A194483Inst Instance=new A194483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194484
{
public static readonly long[] Value={ 0L,0L,0L,63L,4080L,83745L,927471L,6924357L,39196161L,180512640L,708150465L,2442836682L,7582054194L,21540941994L,56763356130L,140189208510L,327211061058L,726712057836L,1544399756262L,3155463833625L,6223010262480L,11886291766899L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194484Inst : IEnumerable<long>
{
public static readonly long[] Value=A194484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194484.Bytes);
public long this[int i]=>Value[i];

public static A194484Inst Instance=new A194484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194485
{
public static readonly long[] Value={ 1L,0L,3L,0L,3L,6L,0L,1L,15L,10L,0L,0L,20L,45L,15L,0L,0L,15L,120L,105L,21L,0L,0L,6L,207L,455L,210L,28L,0L,0L,1L,234L,1347L,1330L,378L,36L,0L,0L,0L,165L,2817L,5922L,3276L,630L,45L,0L,0L,0L,63L,4135L,19362L,20307L,7140L,990L,55L,0L,0L,0L,9L,4080L,47010L,94584L,58527L,14190L,1485L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194485Inst : IEnumerable<long>
{
public static readonly long[] Value=A194485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194485.Bytes);
public long this[int i]=>Value[i];

public static A194485Inst Instance=new A194485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194486
{
public static readonly long[] Value={ 0L,3L,13L,37L,87L,178L,328L,558L,892L,1357L,1983L,2803L,3853L,5172L,6802L,8788L,11178L,14023L,17377L,21297L,25843L,31078L,37068L,43882L,51592L,60273L,70003L,80863L,92937L,106312L,121078L,137328L,155158L,174667L,195957L,219133L,244303L,271578L,301072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194486Inst : IEnumerable<long>
{
public static readonly long[] Value=A194486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194486.Bytes);
public long this[int i]=>Value[i];

public static A194486Inst Instance=new A194486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194487
{
public static readonly long[] Value={ 0L,1L,12L,62L,253L,804L,2136L,4958L,10376L,20013L,36144L,61846L,101163L,159286L,242748L,359634L,519806L,735143L,1019796L,1390458L,1866649L,2471016L,3229648L,4172406L,5333268L,6750689L,8467976L,10533678L,13001991L,15933178L,19394004L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194487Inst : IEnumerable<long>
{
public static readonly long[] Value=A194487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194487.Bytes);
public long this[int i]=>Value[i];

public static A194487Inst Instance=new A194487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194488
{
public static readonly long[] Value={ 0L,0L,4L,46L,407L,2168L,8685L,28376L,79611L,198334L,449336L,942072L,1852096L,3449261L,6133944L,10482661L,17304542L,27710241L,43194961L,65737379L,97916361L,143047462L,205341311L,290086086L,403856389L,554750936L,752661582L,1009576306L,1339918886L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194488Inst : IEnumerable<long>
{
public static readonly long[] Value=A194488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194488.Bytes);
public long this[int i]=>Value[i];

public static A194488Inst Instance=new A194488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194489
{
public static readonly long[] Value={ 0L,0L,0L,13L,387L,3727L,23496L,111433L,429343L,1407755L,4061432L,10561723L,25208796L,55996244L,117021864L,232070481L,439779278L,800893832L,1408234986L,2400123737L,3978154435L,6430366713L,10161044648L,15728568633L,23892962265L,35675014169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194489Inst : IEnumerable<long>
{
public static readonly long[] Value=A194489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194489.Bytes);
public long this[int i]=>Value[i];

public static A194489Inst Instance=new A194489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194490
{
public static readonly long[] Value={ 0L,0L,0L,1L,230L,4257L,44005L,312296L,1693828L,7449231L,27785786L,90732814L,265594944L,709634275L,1755164932L,4063548824L,8885486966L,18484419808L,36802865115L,70481362597L,130377759323L,233782433461L,407584477894L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194490Inst : IEnumerable<long>
{
public static readonly long[] Value=A194490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194490.Bytes);
public long this[int i]=>Value[i];

public static A194490Inst Instance=new A194490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194491
{
public static readonly long[] Value={ 0L,0L,0L,0L,88L,3300L,58630L,641678L,5025711L,30209361L,147914590L,614046090L,2226985986L,7218141771L,21280624486L,57867863073L,146765501360L,350324696309L,792870137966L,1711961366458L,3544779914099L,7069433034465L,13630030399362L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194491Inst : IEnumerable<long>
{
public static readonly long[] Value=A194491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194491.Bytes);
public long this[int i]=>Value[i];

public static A194491Inst Instance=new A194491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194492
{
public static readonly long[] Value={ 1L,0L,3L,0L,3L,6L,0L,1L,13L,10L,0L,0L,12L,37L,15L,0L,0L,4L,62L,87L,21L,0L,0L,0L,46L,253L,178L,28L,0L,0L,0L,13L,407L,804L,328L,36L,0L,0L,0L,1L,387L,2168L,2136L,558L,45L,0L,0L,0L,0L,230L,3727L,8685L,4958L,892L,55L,0L,0L,0L,0L,88L,4257L,23496L,28376L,10376L,1357L,66L,0L,0L,0L,0L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194492Inst : IEnumerable<long>
{
public static readonly long[] Value=A194492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194492.Bytes);
public long this[int i]=>Value[i];

public static A194492Inst Instance=new A194492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194493
{
public static readonly long[] Value={ 0L,0L,0L,0L,12L,82L,330L,1008L,2566L,5742L,11652L,21926L,38802L,65322L,105428L,164214L,248022L,364764L,523998L,737334L,1018488L,1383768L,1852104L,2445628L,3189660L,4113396L,5249848L,6636636L,8315880L,10335110L,12747090L,15610860L,18991490L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194493Inst : IEnumerable<long>
{
public static readonly long[] Value=A194493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194493.Bytes);
public long this[int i]=>Value[i];

public static A194493Inst Instance=new A194493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194494
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,8L,118L,802L,3708L,13280L,39734L,104000L,244948L,530632L,1072776L,2048056L,3723314L,6492342L,10915254L,17777372L,28147380L,43465356L,65624634L,97098802L,141050688L,201509798L,283514112L,393348562L,538725268L,729098516L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194494Inst : IEnumerable<long>
{
public static readonly long[] Value=A194494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194494.Bytes);
public long this[int i]=>Value[i];

public static A194494Inst Instance=new A194494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194495
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,4L,114L,1384L,9890L,50662L,205512L,698688L,2074530L,5525902L,13476246L,30522678L,64968996L,131070600L,252492296L,467017054L,833501728L,1440839952L,2420878990L,3964168632L,6342428908L,9934738024L,15264432954L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194495Inst : IEnumerable<long>
{
public static readonly long[] Value=A194495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194495.Bytes);
public long this[int i]=>Value[i];

public static A194495Inst Instance=new A194495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194496
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,64L,1644L,19306L,146718L,820218L,3670288L,13846830L,45661556L,134896662L,364019248L,909633276L,2129318414L,4709083054L,9912162234L,19970298696L,38707229282L,72458290216L,131476840106L,231906957348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194496Inst : IEnumerable<long>
{
public static readonly long[] Value=A194496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194496.Bytes);
public long this[int i]=>Value[i];

public static A194496Inst Instance=new A194496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194497
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,10L,1210L,27198L,322782L,2564988L,15372702L,74615814L,306900410L,1105651074L,3569169990L,10512880400L,28628691842L,72880455042L,174895586328L,398556484840L,867314768878L,1811576604968L,3646385889888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194497Inst : IEnumerable<long>
{
public static readonly long[] Value=A194497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194497.Bytes);
public long this[int i]=>Value[i];

public static A194497Inst Instance=new A194497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194498
{
public static readonly long[] Value={ 1L,0L,3L,0L,0L,6L,0L,0L,2L,10L,0L,0L,0L,12L,15L,0L,0L,0L,0L,38L,21L,0L,0L,0L,0L,12L,92L,28L,0L,0L,0L,0L,0L,82L,188L,36L,0L,0L,0L,0L,0L,8L,330L,344L,45L,0L,0L,0L,0L,0L,0L,118L,1008L,580L,55L,0L,0L,0L,0L,0L,0L,4L,802L,2566L,920L,66L,0L,0L,0L,0L,0L,0L,0L,114L,3708L,5742L,1390L,78L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194498Inst : IEnumerable<long>
{
public static readonly long[] Value=A194498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194498.Bytes);
public long this[int i]=>Value[i];

public static A194498Inst Instance=new A194498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194499
{
public static readonly long[] Value={ 2L,8L,72L,1020L,32768L,2097152L,268460064L,68721573888L,35184372088832L,36028797020012544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194499Inst : IEnumerable<long>
{
public static readonly long[] Value=A194499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194499.Bytes);
public long this[int i]=>Value[i];

public static A194499Inst Instance=new A194499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194500
{
public static readonly long[] Value={ 3L,27L,776L,59052L,14348907L,10460353203L,22876792454961L,150094717239776832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194500Inst : IEnumerable<long>
{
public static readonly long[] Value=A194500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194500.Bytes);
public long this[int i]=>Value[i];

public static A194500Inst Instance=new A194500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194501
{
public static readonly long[] Value={ 4L,64L,4160L,1048560L,1073741824L,4398046511104L,72057594037927936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194501Inst : IEnumerable<long>
{
public static readonly long[] Value=A194501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194501.Bytes);
public long this[int i]=>Value[i];

public static A194501Inst Instance=new A194501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194502
{
public static readonly BigInteger[] Value={ 5L,125L,15804L,9765630L,30517578125L,476837158203125L,BigInteger.Parse("37252902986083985625") };
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
public class A194502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194502Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194502.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194502.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194502Inst Instance=new A194502Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194503
{
public static readonly long[] Value={ 6L,216L,46872L,60466140L,470184984576L,21936950640377856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194503Inst : IEnumerable<long>
{
public static readonly long[] Value=A194503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194503.Bytes);
public long this[int i]=>Value[i];

public static A194503Inst Instance=new A194503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194504
{
public static readonly long[] Value={ 7L,343L,118096L,282475256L,4747561509943L,558545864083284007L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194504Inst : IEnumerable<long>
{
public static readonly long[] Value=A194504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194504.Bytes);
public long this[int i]=>Value[i];

public static A194504Inst Instance=new A194504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194505
{
public static readonly long[] Value={ 1L,2L,1L,3L,8L,4L,4L,27L,72L,2L,5L,64L,776L,1020L,1L,6L,125L,4160L,59052L,32768L,1L,7L,216L,15804L,1048560L,14348907L,2097152L,1L,8L,343L,46872L,9765630L,1073741824L,10460353203L,268460064L,16L,9L,512L,118096L,60466140L,30517578125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194505Inst : IEnumerable<long>
{
public static readonly long[] Value=A194505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194505.Bytes);
public long this[int i]=>Value[i];

public static A194505Inst Instance=new A194505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194506
{
public static readonly BigInteger[] Value={ 3L,12L,120L,360L,1008L,20160L,259200L,907200L,6652800L,19160064L,39626496000L,62270208000L,603542016000L,640493568000L,1067062284288000L,4001483566080000L,4174096582656000L,162193467211776000L,13651830701752320000UL,BigInteger.Parse("481714597618974720000") };
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
public class A194506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194506Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194506.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194506.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194506Inst Instance=new A194506Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194507
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,5L,8L,10L,7L,12L,9L,14L,18L,11L,15L,16L,13L,20L,24L,22L,30L,21L,17L,26L,28L,19L,36L,27L,25L,42L,23L,32L,34L,40L,33L,38L,48L,29L,35L,44L,31L,39L,60L,54L,50L,46L,45L,52L,66L,37L,56L,58L,51L,41L,70L,72L,43L,62L,78L,84L,64L,57L,49L,90L,47L,68L,55L,63L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194507Inst : IEnumerable<long>
{
public static readonly long[] Value=A194507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194507.Bytes);
public long this[int i]=>Value[i];

public static A194507Inst Instance=new A194507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194508
{
public static readonly long[] Value={ -1L,1L,0L,2L,1L,0L,2L,1L,3L,2L,1L,3L,2L,4L,3L,2L,4L,3L,5L,4L,3L,5L,4L,6L,5L,4L,6L,5L,7L,6L,5L,7L,6L,8L,7L,6L,8L,7L,9L,8L,7L,9L,8L,10L,9L,8L,10L,9L,11L,10L,9L,11L,10L,12L,11L,10L,12L,11L,13L,12L,11L,13L,12L,14L,13L,12L,14L,13L,15L,14L,13L,15L,14L,16L,15L,14L,16L,15L,17L,16L,15L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194508Inst : IEnumerable<long>
{
public static readonly long[] Value=A194508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194508.Bytes);
public long this[int i]=>Value[i];

public static A194508Inst Instance=new A194508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194509
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,2L,1L,2L,1L,2L,3L,2L,3L,2L,3L,4L,3L,4L,3L,4L,5L,4L,5L,4L,5L,6L,5L,6L,5L,6L,7L,6L,7L,6L,7L,8L,7L,8L,7L,8L,9L,8L,9L,8L,9L,10L,9L,10L,9L,10L,11L,10L,11L,10L,11L,12L,11L,12L,11L,12L,13L,12L,13L,12L,13L,14L,13L,14L,13L,14L,15L,14L,15L,14L,15L,16L,15L,16L,15L,16L,17L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194509Inst : IEnumerable<long>
{
public static readonly long[] Value=A194509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194509.Bytes);
public long this[int i]=>Value[i];

public static A194509Inst Instance=new A194509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194510
{
public static readonly long[] Value={ 3L,1L,-1L,2L,0L,3L,1L,4L,2L,0L,3L,1L,4L,2L,5L,3L,1L,4L,2L,5L,3L,6L,4L,2L,5L,3L,6L,4L,7L,5L,3L,6L,4L,7L,5L,8L,6L,4L,7L,5L,8L,6L,9L,7L,5L,8L,6L,9L,7L,10L,8L,6L,9L,7L,10L,8L,11L,9L,7L,10L,8L,11L,9L,12L,10L,8L,11L,9L,12L,10L,13L,11L,9L,12L,10L,13L,11L,14L,12L,10L,13L,11L,14L,12L,15L,13L,11L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194510Inst : IEnumerable<long>
{
public static readonly long[] Value=A194510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194510.Bytes);
public long this[int i]=>Value[i];

public static A194510Inst Instance=new A194510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194511
{
public static readonly long[] Value={ -1L,0L,1L,0L,1L,0L,1L,0L,1L,2L,1L,2L,1L,2L,1L,2L,3L,2L,3L,2L,3L,2L,3L,4L,3L,4L,3L,4L,3L,4L,5L,4L,5L,4L,5L,4L,5L,6L,5L,6L,5L,6L,5L,6L,7L,6L,7L,6L,7L,6L,7L,8L,7L,8L,7L,8L,7L,8L,9L,8L,9L,8L,9L,8L,9L,10L,9L,10L,9L,10L,9L,10L,11L,10L,11L,10L,11L,10L,11L,12L,11L,12L,11L,12L,11L,12L,13L,12L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194511Inst : IEnumerable<long>
{
public static readonly long[] Value=A194511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194511.Bytes);
public long this[int i]=>Value[i];

public static A194511Inst Instance=new A194511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194512
{
public static readonly long[] Value={ 4L,1L,5L,2L,-1L,3L,0L,4L,1L,5L,2L,6L,3L,0L,4L,1L,5L,2L,6L,3L,7L,4L,1L,5L,2L,6L,3L,7L,4L,8L,5L,2L,6L,3L,7L,4L,8L,5L,9L,6L,3L,7L,4L,8L,5L,9L,6L,10L,7L,4L,8L,5L,9L,6L,10L,7L,11L,8L,5L,9L,6L,10L,7L,11L,8L,12L,9L,6L,10L,7L,11L,8L,12L,9L,13L,10L,7L,11L,8L,12L,9L,13L,10L,14L,11L,8L,12L,9L,13L,10L,14L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194512Inst : IEnumerable<long>
{
public static readonly long[] Value=A194512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194512.Bytes);
public long this[int i]=>Value[i];

public static A194512Inst Instance=new A194512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194513
{
public static readonly long[] Value={ -1L,0L,-1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,10L,9L,10L,9L,10L,9L,10L,9L,10L,11L,10L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194513Inst : IEnumerable<long>
{
public static readonly long[] Value=A194513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194513.Bytes);
public long this[int i]=>Value[i];

public static A194513Inst Instance=new A194513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194514
{
public static readonly long[] Value={ -1L,2L,1L,0L,-1L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,4L,3L,2L,1L,4L,3L,2L,5L,4L,3L,2L,5L,4L,3L,6L,5L,4L,3L,6L,5L,4L,7L,6L,5L,4L,7L,6L,5L,8L,7L,6L,5L,8L,7L,6L,9L,8L,7L,6L,9L,8L,7L,10L,9L,8L,7L,10L,9L,8L,11L,10L,9L,8L,11L,10L,9L,12L,11L,10L,9L,12L,11L,10L,13L,12L,11L,10L,13L,12L,11L,14L,13L,12L,11L,14L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194514Inst : IEnumerable<long>
{
public static readonly long[] Value=A194514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194514.Bytes);
public long this[int i]=>Value[i];

public static A194514Inst Instance=new A194514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194515
{
public static readonly long[] Value={ 1L,-1L,0L,1L,2L,0L,1L,2L,0L,1L,2L,3L,1L,2L,3L,1L,2L,3L,4L,2L,3L,4L,2L,3L,4L,5L,3L,4L,5L,3L,4L,5L,6L,4L,5L,6L,4L,5L,6L,7L,5L,6L,7L,5L,6L,7L,8L,6L,7L,8L,6L,7L,8L,9L,7L,8L,9L,7L,8L,9L,10L,8L,9L,10L,8L,9L,10L,11L,9L,10L,11L,9L,10L,11L,12L,10L,11L,12L,10L,11L,12L,13L,11L,12L,13L,11L,12L,13L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194515Inst : IEnumerable<long>
{
public static readonly long[] Value=A194515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194515.Bytes);
public long this[int i]=>Value[i];

public static A194515Inst Instance=new A194515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194516
{
public static readonly long[] Value={ 2L,-1L,1L,3L,0L,2L,-1L,1L,3L,0L,2L,4L,1L,3L,0L,2L,4L,1L,3L,5L,2L,4L,1L,3L,5L,2L,4L,6L,3L,5L,2L,4L,6L,3L,5L,7L,4L,6L,3L,5L,7L,4L,6L,8L,5L,7L,4L,6L,8L,5L,7L,9L,6L,8L,5L,7L,9L,6L,8L,10L,7L,9L,6L,8L,10L,7L,9L,11L,8L,10L,7L,9L,11L,8L,10L,12L,9L,11L,8L,10L,12L,9L,11L,13L,10L,12L,9L,11L,13L,10L,12L,14L,11L,13L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194516Inst : IEnumerable<long>
{
public static readonly long[] Value=A194516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194516.Bytes);
public long this[int i]=>Value[i];

public static A194516Inst Instance=new A194516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194517
{
public static readonly long[] Value={ -1L,1L,0L,-1L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,3L,2L,1L,3L,2L,1L,3L,2L,4L,3L,2L,4L,3L,2L,4L,3L,5L,4L,3L,5L,4L,3L,5L,4L,6L,5L,4L,6L,5L,4L,6L,5L,7L,6L,5L,7L,6L,5L,7L,6L,8L,7L,6L,8L,7L,6L,8L,7L,9L,8L,7L,9L,8L,7L,9L,8L,10L,9L,8L,10L,9L,8L,10L,9L,11L,10L,9L,11L,10L,9L,11L,10L,12L,11L,10L,12L,11L,10L,12L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194517Inst : IEnumerable<long>
{
public static readonly long[] Value=A194517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194517.Bytes);
public long this[int i]=>Value[i];

public static A194517Inst Instance=new A194517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194518
{
public static readonly long[] Value={ -2L,3L,1L,-1L,4L,2L,0L,5L,3L,1L,-1L,4L,2L,0L,5L,3L,1L,6L,4L,2L,0L,5L,3L,1L,6L,4L,2L,7L,5L,3L,1L,6L,4L,2L,7L,5L,3L,8L,6L,4L,2L,7L,5L,3L,8L,6L,4L,9L,7L,5L,3L,8L,6L,4L,9L,7L,5L,10L,8L,6L,4L,9L,7L,5L,10L,8L,6L,11L,9L,7L,5L,10L,8L,6L,11L,9L,7L,12L,10L,8L,6L,11L,9L,7L,12L,10L,8L,13L,11L,9L,7L,12L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194518Inst : IEnumerable<long>
{
public static readonly long[] Value=A194518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194518.Bytes);
public long this[int i]=>Value[i];

public static A194518Inst Instance=new A194518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194519
{
public static readonly long[] Value={ 1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,2L,0L,1L,2L,0L,1L,2L,0L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,4L,2L,3L,4L,2L,3L,4L,2L,3L,4L,5L,3L,4L,5L,3L,4L,5L,3L,4L,5L,6L,4L,5L,6L,4L,5L,6L,4L,5L,6L,7L,5L,6L,7L,5L,6L,7L,5L,6L,7L,8L,6L,7L,8L,6L,7L,8L,6L,7L,8L,9L,7L,8L,9L,7L,8L,9L,7L,8L,9L,10L,8L,9L,10L,8L,9L,10L,8L,9L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194519Inst : IEnumerable<long>
{
public static readonly long[] Value=A194519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194519.Bytes);
public long this[int i]=>Value[i];

public static A194519Inst Instance=new A194519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194520
{
public static readonly long[] Value={ 3L,-2L,1L,4L,-1L,2L,5L,0L,3L,4L,1L,4L,-1L,2L,5L,0L,3L,6L,1L,4L,5L,2L,5L,0L,3L,6L,1L,4L,7L,2L,5L,6L,3L,6L,1L,4L,7L,2L,5L,8L,3L,6L,7L,4L,7L,2L,5L,8L,3L,6L,9L,4L,7L,8L,5L,8L,3L,6L,9L,4L,7L,10L,5L,8L,9L,6L,9L,4L,7L,10L,5L,8L,11L,6L,9L,10L,7L,10L,5L,8L,11L,6L,9L,12L,7L,10L,11L,8L,11L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194520Inst : IEnumerable<long>
{
public static readonly long[] Value=A194520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194520.Bytes);
public long this[int i]=>Value[i];

public static A194520Inst Instance=new A194520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194521
{
public static readonly long[] Value={ -1L,1L,0L,-1L,1L,0L,3L,1L,0L,-1L,1L,0L,2L,1L,0L,2L,1L,4L,2L,1L,0L,2L,1L,3L,2L,1L,3L,2L,5L,3L,2L,1L,3L,2L,4L,3L,2L,4L,3L,6L,4L,3L,2L,4L,3L,5L,4L,3L,5L,4L,7L,5L,4L,3L,5L,4L,6L,5L,4L,6L,5L,8L,6L,5L,4L,6L,5L,7L,6L,5L,7L,6L,9L,7L,6L,5L,7L,6L,8L,7L,6L,8L,7L,10L,8L,7L,6L,8L,7L,9L,8L,7L,9L,8L,11L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194521Inst : IEnumerable<long>
{
public static readonly long[] Value=A194521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194521.Bytes);
public long this[int i]=>Value[i];

public static A194521Inst Instance=new A194521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194522
{
public static readonly long[] Value={ -1L,-2L,2L,1L,0L,-1L,3L,2L,1L,0L,-1L,3L,2L,1L,0L,4L,3L,2L,1L,0L,4L,3L,2L,1L,5L,4L,3L,2L,1L,5L,4L,3L,2L,6L,5L,4L,3L,2L,6L,5L,4L,3L,7L,6L,5L,4L,3L,7L,6L,5L,4L,8L,7L,6L,5L,4L,8L,7L,6L,5L,9L,8L,7L,6L,5L,9L,8L,7L,6L,10L,9L,8L,7L,6L,10L,9L,8L,7L,11L,10L,9L,8L,7L,11L,10L,9L,8L,12L,11L,10L,9L,8L,12L,11L,10L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194522Inst : IEnumerable<long>
{
public static readonly long[] Value=A194522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194522.Bytes);
public long this[int i]=>Value[i];

public static A194522Inst Instance=new A194522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194523
{
public static readonly long[] Value={ 1L,2L,1L,0L,1L,2L,-1L,0L,1L,2L,3L,2L,1L,2L,3L,0L,1L,2L,3L,4L,3L,2L,3L,4L,1L,2L,3L,4L,5L,4L,3L,4L,5L,2L,3L,4L,5L,6L,5L,4L,5L,6L,3L,4L,5L,6L,7L,6L,5L,6L,7L,4L,5L,6L,7L,8L,7L,6L,7L,8L,5L,6L,7L,8L,9L,8L,7L,8L,9L,6L,7L,8L,9L,10L,9L,8L,9L,10L,7L,8L,9L,10L,11L,10L,9L,10L,11L,8L,9L,10L,11L,12L,11L,10L,11L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194523Inst : IEnumerable<long>
{
public static readonly long[] Value=A194523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194523.Bytes);
public long this[int i]=>Value[i];

public static A194523Inst Instance=new A194523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194524
{
public static readonly long[] Value={ 2L,4L,-1L,1L,3L,-2L,0L,2L,4L,-1L,1L,3L,5L,0L,2L,4L,-1L,1L,3L,5L,0L,2L,4L,6L,1L,3L,5L,0L,2L,4L,6L,1L,3L,5L,7L,2L,4L,6L,1L,3L,5L,7L,2L,4L,6L,8L,3L,5L,7L,2L,4L,6L,8L,3L,5L,7L,9L,4L,6L,8L,3L,5L,7L,9L,4L,6L,8L,10L,5L,7L,9L,4L,6L,8L,10L,5L,7L,9L,11L,6L,8L,10L,5L,7L,9L,11L,6L,8L,10L,12L,7L,9L,11L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194524Inst : IEnumerable<long>
{
public static readonly long[] Value=A194524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194524.Bytes);
public long this[int i]=>Value[i];

public static A194524Inst Instance=new A194524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194525
{
public static readonly long[] Value={ -1L,-2L,1L,0L,-1L,2L,1L,0L,-1L,2L,1L,0L,-1L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,0L,3L,2L,1L,4L,3L,2L,1L,4L,3L,2L,1L,4L,3L,2L,5L,4L,3L,2L,5L,4L,3L,2L,5L,4L,3L,6L,5L,4L,3L,6L,5L,4L,3L,6L,5L,4L,7L,6L,5L,4L,7L,6L,5L,4L,7L,6L,5L,8L,7L,6L,5L,8L,7L,6L,5L,8L,7L,6L,9L,8L,7L,6L,9L,8L,7L,6L,9L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194525Inst : IEnumerable<long>
{
public static readonly long[] Value=A194525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194525.Bytes);
public long this[int i]=>Value[i];

public static A194525Inst Instance=new A194525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194526
{
public static readonly long[] Value={ -1L,-2L,3L,2L,1L,0L,-1L,-2L,3L,2L,-1L,0L,-1L,4L,3L,2L,1L,0L,-1L,4L,3L,0L,1L,0L,5L,4L,3L,2L,1L,0L,5L,4L,1L,2L,1L,6L,5L,4L,3L,2L,1L,6L,5L,2L,3L,2L,7L,6L,5L,4L,3L,2L,7L,6L,3L,4L,3L,8L,7L,6L,5L,4L,3L,8L,7L,4L,5L,4L,9L,8L,7L,6L,5L,4L,9L,8L,5L,6L,5L,10L,9L,8L,7L,6L,5L,10L,9L,6L,7L,6L,11L,10L,9L,8L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194526Inst : IEnumerable<long>
{
public static readonly long[] Value=A194526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194526.Bytes);
public long this[int i]=>Value[i];

public static A194526Inst Instance=new A194526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194527
{
public static readonly long[] Value={ 1L,2L,-2L,-1L,0L,1L,2L,3L,-1L,0L,2L,2L,3L,-1L,0L,1L,2L,3L,4L,0L,1L,3L,3L,4L,0L,1L,2L,3L,4L,5L,1L,2L,4L,4L,5L,1L,2L,3L,4L,5L,6L,2L,3L,5L,5L,6L,2L,3L,4L,5L,6L,7L,3L,4L,6L,6L,7L,3L,4L,5L,6L,7L,8L,4L,5L,7L,7L,8L,4L,5L,6L,7L,8L,9L,5L,6L,8L,8L,9L,5L,6L,7L,8L,9L,10L,6L,7L,9L,9L,10L,6L,7L,8L,9L,10L,11L,7L,8L,10L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194527Inst : IEnumerable<long>
{
public static readonly long[] Value=A194527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194527.Bytes);
public long this[int i]=>Value[i];

public static A194527Inst Instance=new A194527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194528
{
public static readonly long[] Value={ -3L,2L,-1L,4L,1L,-2L,3L,0L,-3L,2L,-1L,-4L,1L,-2L,3L,0L,5L,2L,-1L,4L,1L,-2L,3L,0L,-3L,2L,-1L,4L,1L,6L,3L,0L,5L,2L,-1L,4L,1L,-2L,3L,0L,5L,2L,7L,4L,1L,6L,3L,0L,5L,2L,-1L,4L,1L,6L,3L,8L,5L,2L,7L,4L,1L,6L,3L,0L,5L,2L,7L,4L,9L,6L,3L,8L,5L,2L,7L,4L,1L,6L,3L,8L,5L,10L,7L,4L,9L,6L,3L,8L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194528Inst : IEnumerable<long>
{
public static readonly long[] Value=A194528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194528.Bytes);
public long this[int i]=>Value[i];

public static A194528Inst Instance=new A194528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194529
{
public static readonly long[] Value={ 2L,-1L,1L,-2L,0L,2L,-1L,1L,3L,0L,2L,4L,1L,3L,0L,2L,-1L,1L,3L,0L,2L,4L,1L,3L,5L,2L,4L,1L,3L,0L,2L,4L,1L,3L,5L,2L,4L,6L,3L,5L,2L,4L,1L,3L,5L,2L,4L,6L,3L,5L,7L,4L,6L,3L,5L,2L,4L,6L,3L,5L,7L,4L,6L,8L,5L,7L,4L,6L,3L,5L,7L,4L,6L,8L,5L,7L,9L,6L,8L,5L,7L,4L,6L,8L,5L,7L,9L,6L,8L,10L,7L,9L,6L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194529Inst : IEnumerable<long>
{
public static readonly long[] Value=A194529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194529.Bytes);
public long this[int i]=>Value[i];

public static A194529Inst Instance=new A194529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194530
{
public static readonly BigInteger[] Value={ 0L,1L,3L,9L,32L,132L,623L,3314L,19628L,128126L,914005L,7074517L,59050739L,528741491L,5055414317L,51406084221L,553946196892L,6305737560455L,75610546284387L,952559077043183L,12579235034203780L,173759983171005721L,2505751777457313815L,BigInteger.Parse("37657189917162605826") };
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
public class A194530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194530Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194530.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194530.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194530Inst Instance=new A194530Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194531
{
public static readonly long[] Value={ 0L,1L,1L,2L,5L,5L,7L,28L,3L,15L,55L,22L,13L,91L,35L,40L,34L,51L,57L,190L,35L,77L,253L,92L,25L,325L,117L,126L,203L,145L,155L,496L,44L,187L,595L,210L,111L,703L,247L,260L,205L,287L,301L,946L,165L,345L,1081L,376L,98L,1225L,425L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194531Inst : IEnumerable<long>
{
public static readonly long[] Value=A194531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194531.Bytes);
public long this[int i]=>Value[i];

public static A194531Inst Instance=new A194531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194532
{
public static readonly long[] Value={ 1L,21L,91L,336L,651L,1911L,2451L,5376L,7371L,13671L,14763L,30576L,28731L,51471L,59241L,86016L,83811L,154791L,130683L,218736L,223041L,310023L,280371L,489216L,406875L,603351L,597051L,823536L,708123L,1244061L,924483L,1376256L,1343433L,1760031L,1595601L,2476656L,1875531L,2744343L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194532Inst : IEnumerable<long>
{
public static readonly long[] Value=A194532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194532.Bytes);
public long this[int i]=>Value[i];

public static A194532Inst Instance=new A194532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194533
{
public static readonly long[] Value={ 1L,85L,820L,5440L,16276L,69700L,120100L,348160L,597780L,1383460L,1786324L,4460800L,4855540L,10208500L,13346320L,22282240L,24221380L,50811300L,47176564L,88541440L,98482000L,151837540L,148316260L,285491200L,254312500L,412720900L,435781620L,653344000L,595531444L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194533Inst : IEnumerable<long>
{
public static readonly long[] Value=A194533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194533.Bytes);
public long this[int i]=>Value[i];

public static A194533Inst Instance=new A194533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194534
{
public static readonly BigInteger[] Value={ 1L,4L,59L,1851L,119548L,16039294L,4460214471L,2572187445993L,3075932897564028L,7627704068111688574L,BigInteger.Parse("39223874584658826539499"),BigInteger.Parse("418261269510360187893175534"),BigInteger.Parse("9248796169262343437995449320699"),BigInteger.Parse("424095060368117191810477243815045914") };
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
public class A194534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194534Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194534.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194534.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194534Inst Instance=new A194534Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194535
{
public static readonly BigInteger[] Value={ 1L,4L,116L,16556L,7721920L,11525456507L,54979732214116L,838387866908847478L,BigInteger.Parse("40866499579695484000499"),BigInteger.Parse("6367568042830726931523028453"),BigInteger.Parse("3171485572844765112503023656979959") };
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
public class A194535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194535Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194535.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194535.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194535Inst Instance=new A194535Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194536
{
public static readonly BigInteger[] Value={ 1L,4L,131L,43785L,79201795L,627974590650L,21399815343394998L,BigInteger.Parse("3132305932642809585983"),BigInteger.Parse("1969210116072259125767299138") };
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
public class A194536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194536Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194536.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194536.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194536Inst Instance=new A194536Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194537
{
public static readonly BigInteger[] Value={ 1L,4L,132L,62038L,286773762L,8096809998526L,1243336605965267360L,BigInteger.Parse("1026437889413641002431445") };
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
public class A194537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194537Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194537.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194537.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194537Inst Instance=new A194537Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194538
{
public static readonly BigInteger[] Value={ 1L,4L,132L,67377L,543350470L,40994098419294L,BigInteger.Parse("21253155706215768591"),BigInteger.Parse("71381360690596538575641162") };
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
public class A194538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194538Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194538.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194538.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194538Inst Instance=new A194538Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194539
{
public static readonly BigInteger[] Value={ 1L,4L,132L,68106L,703256449L,108504879480483L,BigInteger.Parse("153378412416345530447") };
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
public class A194539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194539Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194539.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194539.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194539Inst Instance=new A194539Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194540
{
public static readonly long[] Value={ 1L,1L,3L,1L,4L,6L,1L,4L,59L,12L,1L,4L,116L,1851L,23L,1L,4L,131L,16556L,119548L,43L,1L,4L,132L,43785L,7721920L,16039294L,79L,1L,4L,132L,62038L,79201795L,11525456507L,4460214471L,143L,1L,4L,132L,67377L,286773762L,627974590650L,54979732214116L,2572187445993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194540Inst : IEnumerable<long>
{
public static readonly long[] Value=A194540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194540.Bytes);
public long this[int i]=>Value[i];

public static A194540Inst Instance=new A194540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194541
{
public static readonly long[] Value={ 1L,5L,16L,47L,130L,357L,973L,2647L,7197L,19564L,53181L,144561L,392958L,1068172L,2903593L,7892784L,21454811L,58320223L,158530804L,430931404L,1171393005L,3184176320L,8655488630L,23528057461L,63955891057L,173850136486L,472573666887L,1284588411309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194541Inst : IEnumerable<long>
{
public static readonly long[] Value=A194541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194541.Bytes);
public long this[int i]=>Value[i];

public static A194541Inst Instance=new A194541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194542
{
public static readonly long[] Value={ 1L,2L,15L,18L,36L,42L,72L,78L,84L,126L,132L,140L,165L,168L,192L,200L,204L,234L,252L,260L,264L,270L,280L,288L,348L,400L,408L,440L,462L,504L,520L,546L,560L,741L,816L,825L,880L,882L,888L,912L,1040L,1044L,1248L,1464L,1470L,1632L,1638L,1692L,1710L,1749L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194542Inst : IEnumerable<long>
{
public static readonly long[] Value=A194542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194542.Bytes);
public long this[int i]=>Value[i];

public static A194542Inst Instance=new A194542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194543
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,3L,2L,1L,1L,5L,2L,2L,1L,1L,7L,3L,2L,2L,1L,1L,11L,4L,3L,2L,2L,1L,1L,15L,5L,3L,3L,2L,2L,1L,1L,22L,6L,4L,3L,3L,2L,2L,1L,1L,30L,8L,5L,4L,3L,3L,2L,2L,1L,1L,42L,10L,6L,4L,4L,3L,3L,2L,2L,1L,1L,56L,12L,7L,5L,4L,4L,3L,3L,2L,2L,1L,1L,77L,15L,9L,6L,5L,4L,4L,3L,3L,2L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194543Inst : IEnumerable<long>
{
public static readonly long[] Value=A194543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194543.Bytes);
public long this[int i]=>Value[i];

public static A194543Inst Instance=new A194543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194544
{
public static readonly long[] Value={ 0L,0L,2L,3L,10L,14L,33L,46L,87L,125L,208L,291L,461L,633L,942L,1292L,1851L,2491L,3484L,4629L,6321L,8326L,11143L,14513L,19168L,24720L,32185L,41193L,53030L,67297L,85830L,108116L,136651L,171040L,214462L,266731L,332197L,410730L,508201L,625082L,768920L,940938L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194544Inst : IEnumerable<long>
{
public static readonly long[] Value=A194544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194544.Bytes);
public long this[int i]=>Value[i];

public static A194544Inst Instance=new A194544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194545
{
public static readonly long[] Value={ 0L,1L,2L,4L,11L,16L,33L,48L,89L,134L,214L,305L,478L,663L,976L,1356L,1934L,2617L,3654L,4877L,6652L,8808L,11772L,15386L,20329L,26308L,34249L,43987L,56651L,72079L,92008L,116171L,146967L,184381L,231399L,288398L,359581L,445426L,551721L,679868L,837238L,1026256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194545Inst : IEnumerable<long>
{
public static readonly long[] Value=A194545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194545.Bytes);
public long this[int i]=>Value[i];

public static A194545Inst Instance=new A194545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194546
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,2L,3L,2L,4L,1L,2L,3L,2L,4L,3L,5L,1L,2L,3L,2L,4L,3L,5L,2L,4L,3L,6L,1L,2L,3L,2L,4L,3L,5L,2L,4L,3L,6L,3L,5L,4L,7L,1L,2L,3L,2L,4L,3L,5L,2L,4L,3L,6L,3L,5L,4L,7L,2L,4L,3L,6L,5L,4L,8L,1L,2L,3L,2L,4L,3L,5L,2L,4L,3L,6L,3L,5L,4L,7L,2L,4L,3L,6L,5L,4L,8L,3L,5L,4L,7L,3L,6L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194546Inst : IEnumerable<long>
{
public static readonly long[] Value=A194546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194546.Bytes);
public long this[int i]=>Value[i];

public static A194546Inst Instance=new A194546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194547
{
public static readonly long[] Value={ 0L,-1L,1L,-2L,0L,2L,-3L,-1L,1L,0L,3L,-4L,-2L,0L,-1L,2L,1L,4L,-5L,-3L,-1L,-2L,1L,0L,3L,-1L,2L,1L,5L,-6L,-4L,-2L,-3L,0L,-1L,2L,-2L,1L,0L,4L,0L,3L,2L,6L,-7L,-5L,-3L,-4L,-1L,-2L,1L,-3L,0L,-1L,3L,-1L,2L,1L,5L,-2L,1L,0L,4L,3L,2L,7L,-8L,-6L,-4L,-5L,-2L,-3L,0L,-4L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194547Inst : IEnumerable<long>
{
public static readonly long[] Value=A194547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194547.Bytes);
public long this[int i]=>Value[i];

public static A194547Inst Instance=new A194547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194548
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,1L,3L,2L,2L,1L,3L,2L,2L,1L,4L,3L,3L,2L,2L,2L,1L,4L,3L,3L,2L,3L,2L,2L,1L,5L,4L,4L,3L,3L,3L,2L,3L,2L,2L,2L,1L,5L,4L,4L,3L,4L,3L,3L,2L,3L,3L,2L,2L,2L,1L,6L,5L,5L,4L,4L,4L,3L,4L,3L,3L,3L,2L,4L,3L,3L,2L,3L,2L,2L,2L,1L,6L,5L,5L,4L,5L,4L,4L,3L,4L,4L,3L,3L,3L,2L,4L,3L,3L,3L,2L,3L,2L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194548Inst : IEnumerable<long>
{
public static readonly long[] Value=A194548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194548.Bytes);
public long this[int i]=>Value[i];

public static A194548Inst Instance=new A194548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194549
{
public static readonly long[] Value={ 1L,1L,2L,0L,3L,1L,4L,-1L,2L,1L,5L,0L,3L,2L,6L,-2L,1L,0L,4L,3L,2L,7L,-1L,2L,1L,5L,0L,4L,3L,8L,-3L,0L,-1L,3L,2L,1L,6L,1L,5L,4L,3L,9L,-2L,1L,0L,4L,-1L,3L,2L,7L,2L,1L,6L,5L,4L,10L,-4L,-1L,-2L,2L,1L,0L,5L,0L,4L,3L,2L,8L,-1L,3L,2L,7L,1L,6L,5L,4L,11L,-3L,0L,-1L,3L,-2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194549Inst : IEnumerable<long>
{
public static readonly long[] Value=A194549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194549.Bytes);
public long this[int i]=>Value[i];

public static A194549Inst Instance=new A194549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194550
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,1L,2L,1L,4L,1L,3L,1L,5L,1L,2L,1L,4L,1L,3L,1L,6L,1L,3L,1L,5L,1L,4L,1L,7L,1L,2L,1L,4L,1L,3L,1L,6L,1L,5L,1L,4L,1L,8L,1L,3L,1L,5L,1L,4L,1L,7L,1L,3L,1L,6L,1L,5L,1L,9L,1L,2L,1L,4L,1L,3L,1L,6L,1L,5L,1L,4L,1L,8L,1L,4L,1L,7L,1L,6L,1L,5L,1L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194550Inst : IEnumerable<long>
{
public static readonly long[] Value=A194550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194550.Bytes);
public long this[int i]=>Value[i];

public static A194550Inst Instance=new A194550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194551
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,3L,6L,4L,7L,5L,4L,8L,3L,6L,5L,9L,4L,7L,6L,5L,10L,5L,4L,8L,7L,6L,11L,3L,6L,5L,9L,4L,8L,7L,6L,12L,4L,7L,6L,5L,10L,5L,9L,8L,7L,13L,5L,4L,8L,7L,6L,11L,6L,5L,10L,9L,8L,7L,14L,3L,6L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194551Inst : IEnumerable<long>
{
public static readonly long[] Value=A194551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194551.Bytes);
public long this[int i]=>Value[i];

public static A194551Inst Instance=new A194551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194552
{
public static readonly long[] Value={ 0L,2L,5L,13L,23L,47L,75L,131L,203L,323L,477L,729L,1041L,1517L,2132L,3012L,4134L,5718L,7713L,10453L,13918L,18538L,24357L,32037L,41612L,54040L,69538L,89362L,113925L,145095L,183473L,231697L,290899L,364577L,454632L,566016L,701436L,867800L,1069430L,1315550L,1612595L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194552Inst : IEnumerable<long>
{
public static readonly long[] Value=A194552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194552.Bytes);
public long this[int i]=>Value[i];

public static A194552Inst Instance=new A194552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194553
{
public static readonly BigInteger[] Value={ 1L,33554433L,847322163875L,1126747195452067L,299149123783795749L,BigInteger.Parse("28728311253806654501"),BigInteger.Parse("1369498907693894602183"),BigInteger.Parse("39120000482621126610375"),BigInteger.Parse("755676919554809750479817"),BigInteger.Parse("10717897987691852588770249"),BigInteger.Parse("118347059433883722041830251") };
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
public class A194553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194553Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A194553.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A194553.Bytes);
public BigInteger this[int i]=>Value[i];

public static A194553Inst Instance=new A194553Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194554
{
public static readonly long[] Value={ 9L,7L,5L,6L,7L,8L,8L,4L,7L,8L,0L,3L,6L,6L,9L,3L,8L,5L,6L,4L,3L,4L,6L,8L,9L,6L,6L,0L,5L,5L,4L,2L,3L,1L,1L,0L,5L,2L,2L,9L,4L,6L,9L,7L,1L,6L,4L,8L,1L,0L,8L,5L,3L,7L,6L,8L,8L,7L,2L,0L,2L,6L,5L,0L,3L,7L,8L,0L,6L,6L,8L,4L,2L,2L,9L,8L,4L,5L,8L,4L,4L,2L,7L,9L,4L,9L,0L,8L,2L,6L,2L,6L,7L,2L,7L,4L,4L,1L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194554Inst : IEnumerable<long>
{
public static readonly long[] Value=A194554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194554.Bytes);
public long this[int i]=>Value[i];

public static A194554Inst Instance=new A194554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194555
{
public static readonly long[] Value={ 2L,1L,9L,2L,0L,4L,8L,9L,4L,9L,0L,0L,8L,7L,6L,1L,3L,2L,8L,9L,0L,7L,6L,7L,9L,4L,9L,7L,4L,4L,6L,5L,7L,2L,6L,5L,8L,7L,3L,6L,9L,2L,6L,4L,6L,1L,1L,9L,0L,7L,9L,6L,3L,9L,2L,6L,4L,8L,5L,0L,9L,2L,1L,7L,3L,8L,9L,3L,1L,7L,0L,7L,6L,5L,2L,1L,9L,9L,7L,4L,7L,2L,2L,3L,5L,3L,0L,1L,9L,5L,4L,0L,6L,1L,5L,3L,4L,6L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194555Inst : IEnumerable<long>
{
public static readonly long[] Value=A194555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194555.Bytes);
public long this[int i]=>Value[i];

public static A194555Inst Instance=new A194555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A194556
{
public static readonly long[] Value={ 1L,5L,4L,3L,8L,8L,8L,7L,3L,5L,8L,5L,5L,2L,5L,8L,3L,1L,8L,3L,6L,0L,4L,4L,6L,0L,0L,1L,3L,0L,7L,4L,9L,0L,9L,7L,1L,8L,8L,7L,1L,4L,9L,4L,2L,7L,9L,6L,8L,0L,2L,7L,2L,4L,1L,2L,8L,5L,4L,3L,3L,0L,4L,5L,3L,2L,9L,4L,4L,1L,8L,3L,6L,3L,0L,2L,2L,0L,7L,2L,0L,7L,9L,6L,9L,2L,3L,7L,0L,7L,3L,2L,6L,2L,5L,7L,6L,1L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A194556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A194556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A194556Inst : IEnumerable<long>
{
public static readonly long[] Value=A194556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A194556.Bytes);
public long this[int i]=>Value[i];

public static A194556Inst Instance=new A194556Inst();

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