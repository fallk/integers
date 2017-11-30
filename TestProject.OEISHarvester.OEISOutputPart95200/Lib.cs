using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A114841
{
public static readonly long[] Value={ 15L,16L,18L,21L,33L,35L,37L,38L,39L,46L,49L,51L,58L,62L,65L,67L,82L,86L,103L,106L,119L,122L,125L,139L,142L,145L,158L,166L,179L,181L,226L,233L,235L,241L,257L,263L,274L,281L,299L,301L,317L,337L,383L,389L,419L,457L,463L,473L,479L,491L,521L,541L,557L,619L,643L,659L,706L,719L,739L,751L,857L,863L,877L,881L,883L,911L,947L,983L,1021L,1033L,1061L,1069L,1109L,1117L,1123L,1181L,1187L,1193L,1213L,1226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114841Inst : IEnumerable<long>
{
public static readonly long[] Value=A114841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114841.Bytes);
public long this[int i]=>Value[i];

public static A114841Inst Instance=new A114841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114842
{
public static readonly long[] Value={ 8L,9L,10L,12L,14L,19L,22L,25L,26L,31L,34L,41L,53L,59L,61L,71L,73L,79L,89L,94L,101L,107L,109L,113L,121L,127L,151L,167L,173L,191L,193L,199L,227L,251L,271L,277L,293L,331L,353L,397L,401L,467L,587L,599L,601L,613L,631L,653L,743L,991L,1091L,1223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114842Inst : IEnumerable<long>
{
public static readonly long[] Value=A114842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114842.Bytes);
public long this[int i]=>Value[i];

public static A114842Inst Instance=new A114842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114843
{
public static readonly long[] Value={ 20L,24L,27L,28L,32L,52L,55L,74L,77L,85L,87L,91L,93L,97L,115L,123L,143L,146L,149L,157L,161L,163L,178L,187L,197L,209L,211L,214L,215L,221L,223L,239L,242L,249L,262L,269L,283L,287L,307L,311L,313L,321L,334L,349L,379L,391L,393L,409L,421L,453L,487L,493L,499L,523L,581L,586L,617L,641L,647L,677L,691L,707L,709L,787L,794L,811L,823L,839L,853L,859L,887L,907L,913L,929L,941L,953L,1031L,1049L,1063L,1093L,1229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114843Inst : IEnumerable<long>
{
public static readonly long[] Value=A114843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114843.Bytes);
public long this[int i]=>Value[i];

public static A114843Inst Instance=new A114843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114844
{
public static readonly long[] Value={ 9L,10L,14L,15L,40L,43046761L,43046763L,44726379L,44726404L,44732965L,44733590L,44766358L,432186847L,432186848L,432193409L,432193652L,432193656L,432193683L,432226451L,432226515L,432273171L,432273172L,432273208L,432338744L,432340931L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114844Inst : IEnumerable<long>
{
public static readonly long[] Value=A114844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114844.Bytes);
public long this[int i]=>Value[i];

public static A114844Inst Instance=new A114844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114845
{
public static readonly long[] Value={ 4L,14L,38L,134L,254L,13238L,252254L,691958L,952814L,3316238L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114845Inst : IEnumerable<long>
{
public static readonly long[] Value=A114845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114845.Bytes);
public long this[int i]=>Value[i];

public static A114845Inst Instance=new A114845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114846
{
public static readonly BigInteger[] Value={ 2L,21L,3005L,818503L,285271753811L,302868879571453L,BigInteger.Parse("827239906198908668177"),BigInteger.Parse("1978419534015213180291979"),BigInteger.Parse("20880467973995895295470056270567"),BigInteger.Parse("2567686153152369372568088512776472510483469"),BigInteger.Parse("17069174130715013119956465106241589193164734431") };
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
public class A114846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114846Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114846.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A114846.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114846Inst Instance=new A114846Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114847
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,19L,31L,43L,61L,73L,101L,103L,107L,109L,113L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L,239L,241L,251L,257L,263L,269L,271L,277L,281L,283L,293L,307L,311L,313L,317L,331L,337L,347L,349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114847Inst : IEnumerable<long>
{
public static readonly long[] Value=A114847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114847.Bytes);
public long this[int i]=>Value[i];

public static A114847Inst Instance=new A114847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114848
{
public static readonly long[] Value={ 1L,1L,2L,4L,1L,10L,4L,28L,13L,1L,82L,44L,6L,248L,153L,27L,1L,770L,536L,116L,8L,2440L,1889L,486L,46L,1L,7858L,6696L,1992L,240L,10L,25644L,23849L,8042L,1180L,70L,1L,84618L,85276L,32124L,5552L,430L,12L,281844L,305933L,127287L,25306L,2430L,99L,1L,946338L,1100692L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114848Inst : IEnumerable<long>
{
public static readonly long[] Value=A114848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114848.Bytes);
public long this[int i]=>Value[i];

public static A114848Inst Instance=new A114848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114849
{
public static readonly long[] Value={ 0L,3L,31L,257L,1950L,14164L,100464L,702919L,4878575L,33695365L,232040622L,1595043816L,10952137040L,75149854091L,515435467055L,3534332855753L,24230970910510L,166108203507452L,1138635489987488L,7804802111777935L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114849Inst : IEnumerable<long>
{
public static readonly long[] Value=A114849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114849.Bytes);
public long this[int i]=>Value[i];

public static A114849Inst Instance=new A114849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114850
{
public static readonly BigInteger[] Value={ 256L,46656L,387420489L,10000000000L,11112006825558016L,437893890380859375L,BigInteger.Parse("5842587018385982521381124421"),BigInteger.Parse("341427877364219557396646723584"),BigInteger.Parse("88817841970012523233890533447265625") };
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
public class A114850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114850Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114850.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A114850.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114850Inst Instance=new A114850Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114851
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,2L,4L,5L,10L,14L,27L,41L,78L,126L,237L,399L,745L,1292L,2404L,4259L,7915L,14242L,26477L,48197L,89721L,164766L,307294L,568191L,1061969L,1974266L,3698247L,6905523L,12964449L,24295796L,45711211L,85926575L,161996298L,305314162L,576707409L,1089395667L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114851Inst : IEnumerable<long>
{
public static readonly long[] Value=A114851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114851.Bytes);
public long this[int i]=>Value[i];

public static A114851Inst Instance=new A114851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114852
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,1L,1L,2L,1L,6L,5L,13L,14L,37L,44L,101L,134L,298L,431L,883L,1361L,2736L,4405L,8574L,14334L,27465L,47146L,89270L,156360L,293840L,522913L,978447L,1761907L,3288605L,5977863L,11148652L,20414058L,38071898L,70125402L,130880047L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114852Inst : IEnumerable<long>
{
public static readonly long[] Value=A114852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114852.Bytes);
public long this[int i]=>Value[i];

public static A114852Inst Instance=new A114852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114853
{
public static readonly long[] Value={ 1L,2L,9L,32L,208L,972L,7843L,43690L,409968L,2604166L,27447010L,193491763L,2241278030L,17224712961L,216027868615L,1787142709274L,24006211998207L,211773735868781L,3021737893128258L,28218694885361552L,424936725846414486L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114853Inst : IEnumerable<long>
{
public static readonly long[] Value=A114853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114853.Bytes);
public long this[int i]=>Value[i];

public static A114853Inst Instance=new A114853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114854
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,8L,10L,20L,26L,51L,64L,128L,163L,326L,416L,834L,1067L,2148L,2755L,5559L,7147L,14449L,18613L,37696L,48638L,98650L,127463L,258857L,334864L,680822L,881657L,1794294L,2325750L,4737361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114854Inst : IEnumerable<long>
{
public static readonly long[] Value=A114854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114854.Bytes);
public long this[int i]=>Value[i];

public static A114854Inst Instance=new A114854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114855
{
public static readonly long[] Value={ 1L,-2L,0L,0L,0L,4L,0L,0L,-5L,0L,0L,0L,0L,0L,0L,0L,7L,0L,0L,0L,0L,-8L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,10L,0L,0L,0L,0L,0L,0L,-11L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,13L,0L,0L,0L,0L,0L,0L,0L,0L,-14L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,16L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-17L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114855Inst : IEnumerable<long>
{
public static readonly long[] Value=A114855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114855.Bytes);
public long this[int i]=>Value[i];

public static A114855Inst Instance=new A114855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114856
{
public static readonly long[] Value={ 126L,134L,195L,211L,232L,254L,288L,367L,377L,379L,397L,400L,461L,507L,518L,529L,567L,578L,595L,618L,626L,637L,654L,668L,692L,694L,703L,715L,728L,766L,777L,793L,795L,807L,819L,848L,857L,869L,887L,964L,992L,995L,1016L,1028L,1034L,1043L,1046L,1071L,1086L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114856Inst : IEnumerable<long>
{
public static readonly long[] Value=A114856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114856.Bytes);
public long this[int i]=>Value[i];

public static A114856Inst Instance=new A114856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114857
{
public static readonly long[] Value={ 1L,7L,8L,4L,5L,5L,9L,9L,5L,4L,0L,4L,1L,0L,8L,6L,0L,8L,1L,6L,8L,2L,6L,3L,3L,8L,4L,1L,2L,5L,1L,9L,0L,9L,7L,0L,3L,5L,6L,9L,3L,2L,8L,7L,4L,3L,3L,6L,9L,6L,4L,5L,2L,3L,9L,2L,1L,1L,8L,1L,1L,4L,8L,5L,9L,4L,8L,1L,6L,8L,7L,0L,0L,9L,2L,0L,1L,6L,0L,9L,5L,2L,1L,1L,7L,5L,1L,3L,4L,0L,4L,0L,8L,4L,8L,8L,2L,0L,8L,6L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114857Inst : IEnumerable<long>
{
public static readonly long[] Value=A114857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114857.Bytes);
public long this[int i]=>Value[i];

public static A114857Inst Instance=new A114857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114858
{
public static readonly long[] Value={ 2L,3L,1L,7L,0L,2L,8L,2L,7L,0L,1L,2L,4L,6L,3L,0L,9L,2L,7L,8L,9L,9L,6L,6L,4L,3L,5L,3L,8L,3L,0L,1L,5L,3L,2L,0L,5L,1L,7L,4L,7L,0L,9L,8L,3L,2L,6L,8L,4L,1L,6L,4L,6L,9L,7L,0L,8L,3L,0L,0L,8L,8L,5L,1L,9L,0L,2L,2L,9L,6L,6L,0L,3L,1L,9L,9L,3L,6L,0L,9L,3L,9L,0L,3L,3L,1L,0L,5L,7L,7L,4L,8L,3L,4L,4L,6L,3L,9L,1L,6L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114858Inst : IEnumerable<long>
{
public static readonly long[] Value=A114858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114858.Bytes);
public long this[int i]=>Value[i];

public static A114858Inst Instance=new A114858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114859
{
public static readonly BigInteger[] Value={ 1L,1L,193L,143L,27319L,7103567L,797653L,686720159L,2371559272031L,95739689923L,1395350636248391L,63900308633475133L,529306891755787837L,12737935334233822633UL,BigInteger.Parse("3609754387565898974963447737") };
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
public class A114859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114859Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114859.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A114859.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114859Inst Instance=new A114859Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114860
{
public static readonly BigInteger[] Value={ 12L,90L,90720L,302400L,239500800L,245188944000L,104613949440L,333456963840000L,4180167995867136000L,603108220176000000L,BigInteger.Parse("31022420086661971968000"),BigInteger.Parse("4962375400581280281600000") };
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
public class A114860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114860Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114860.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A114860.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114860Inst Instance=new A114860Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114861
{
public static readonly long[] Value={ 2L,1L,4L,3L,7L,5L,6L,11L,8L,9L,10L,13L,12L,17L,14L,15L,16L,19L,18L,23L,20L,21L,22L,25L,24L,29L,26L,27L,28L,31L,30L,37L,32L,33L,34L,35L,36L,41L,38L,39L,40L,43L,42L,47L,44L,45L,46L,49L,48L,53L,50L,51L,52L,55L,54L,59L,56L,57L,58L,61L,60L,67L,62L,63L,64L,65L,66L,71L,68L,69L,70L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114861Inst : IEnumerable<long>
{
public static readonly long[] Value=A114861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114861.Bytes);
public long this[int i]=>Value[i];

public static A114861Inst Instance=new A114861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114862
{
public static readonly long[] Value={ 2L,1L,4L,3L,6L,7L,5L,9L,10L,11L,8L,13L,12L,15L,16L,17L,14L,19L,18L,21L,22L,23L,20L,25L,24L,27L,28L,29L,26L,31L,30L,33L,34L,35L,36L,37L,32L,39L,40L,41L,38L,43L,42L,45L,46L,47L,44L,49L,48L,51L,52L,53L,50L,55L,54L,57L,58L,59L,56L,61L,60L,63L,64L,65L,66L,67L,62L,69L,70L,71L,68L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114862Inst : IEnumerable<long>
{
public static readonly long[] Value=A114862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114862.Bytes);
public long this[int i]=>Value[i];

public static A114862Inst Instance=new A114862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114863
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,2L,3L,3L,4L,7L,7L,10L,18L,18L,26L,45L,44L,64L,113L,112L,163L,287L,285L,416L,733L,731L,1067L,1885L,1885L,2755L,4873L,4881L,7147L,12659L,12697L,18613L,33007L,33143L,48638L,86337L,86777L,127463L,226454L,227795L,334864L,595382L,599342L,881657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114863Inst : IEnumerable<long>
{
public static readonly long[] Value=A114863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114863.Bytes);
public long this[int i]=>Value[i];

public static A114863Inst Instance=new A114863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114864
{
public static readonly long[] Value={ 9L,8L,1L,7L,5L,5L,0L,1L,3L,0L,1L,0L,7L,1L,1L,7L,3L,9L,7L,2L,0L,4L,8L,8L,1L,6L,6L,4L,9L,9L,3L,7L,7L,7L,8L,3L,5L,9L,6L,5L,7L,9L,8L,0L,2L,3L,3L,0L,2L,1L,7L,0L,5L,3L,5L,2L,3L,5L,6L,3L,6L,2L,6L,9L,3L,5L,8L,2L,7L,4L,8L,5L,3L,5L,8L,5L,2L,7L,0L,5L,1L,0L,7L,4L,3L,3L,6L,8L,5L,8L,6L,4L,2L,2L,9L,2L,0L,6L,2L,2L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114864Inst : IEnumerable<long>
{
public static readonly long[] Value=A114864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114864.Bytes);
public long this[int i]=>Value[i];

public static A114864Inst Instance=new A114864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114865
{
public static readonly long[] Value={ 3L,5L,3L,0L,9L,7L,2L,8L,2L,9L,0L,1L,6L,6L,0L,7L,4L,3L,7L,7L,0L,4L,2L,4L,4L,4L,8L,7L,9L,8L,6L,4L,5L,9L,8L,1L,5L,4L,0L,7L,2L,0L,8L,1L,7L,9L,0L,9L,0L,7L,4L,1L,8L,7L,3L,8L,5L,9L,0L,2L,8L,0L,2L,4L,7L,0L,0L,7L,6L,0L,9L,2L,2L,2L,2L,0L,9L,0L,1L,7L,2L,4L,2L,6L,2L,8L,7L,4L,0L,4L,9L,0L,5L,6L,6L,9L,4L,9L,9L,7L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114865Inst : IEnumerable<long>
{
public static readonly long[] Value=A114865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114865.Bytes);
public long this[int i]=>Value[i];

public static A114865Inst Instance=new A114865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114866
{
public static readonly long[] Value={ 6L,2L,8L,9L,8L,3L,5L,9L,8L,8L,8L,3L,6L,9L,0L,2L,7L,7L,9L,6L,6L,5L,0L,9L,0L,1L,0L,0L,8L,2L,1L,8L,5L,3L,3L,9L,6L,6L,5L,8L,3L,1L,2L,9L,4L,5L,1L,9L,2L,7L,8L,9L,5L,4L,5L,3L,5L,7L,7L,6L,5L,5L,3L,9L,0L,2L,7L,4L,7L,8L,7L,6L,3L,7L,9L,3L,6L,5L,1L,9L,9L,4L,2L,3L,8L,6L,5L,9L,4L,4L,5L,7L,1L,8L,0L,1L,8L,6L,2L,0L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114866Inst : IEnumerable<long>
{
public static readonly long[] Value=A114866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114866.Bytes);
public long this[int i]=>Value[i];

public static A114866Inst Instance=new A114866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114867
{
public static readonly long[] Value={ 15L,22L,33L,45L,67L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114867Inst : IEnumerable<long>
{
public static readonly long[] Value=A114867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114867.Bytes);
public long this[int i]=>Value[i];

public static A114867Inst Instance=new A114867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114868
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,1L,1L,2L,3L,2L,3L,4L,7L,6L,7L,10L,17L,14L,18L,26L,41L,36L,44L,64L,104L,91L,112L,163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114868Inst : IEnumerable<long>
{
public static readonly long[] Value=A114868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114868.Bytes);
public long this[int i]=>Value[i];

public static A114868Inst Instance=new A114868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114869
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,1L,1L,1L,1L,2L,2L,2L,2L,3L,4L,6L,5L,5L,7L,10L,16L,12L,14L,18L,26L,39L,31L,35L,45L,64L,98L,79L,88L,114L,163L,249L,200L,223L,291L,416L,636L,511L,572L,745L,1067L,1634L,1316L,1474L,1922L,2755L,4222L,3405L,3817L,4982L,7147L,10961L,8848L,9925L,12966L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114869Inst : IEnumerable<long>
{
public static readonly long[] Value=A114869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114869.Bytes);
public long this[int i]=>Value[i];

public static A114869Inst Instance=new A114869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114870
{
public static readonly long[] Value={ 0L,1L,5L,25L,141L,911L,6703L,55581L,513929L,5248891L,58724211L,714554633L,9397715341L,132870076119L,2009977939271L,32396622193141L,554297204755473L,10034223725151731L,191617109450287579L,3849745645109036001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114870Inst : IEnumerable<long>
{
public static readonly long[] Value=A114870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114870.Bytes);
public long this[int i]=>Value[i];

public static A114870Inst Instance=new A114870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114871
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,10L,12L,16L,18L,20L,22L,28L,30L,32L,36L,40L,42L,46L,52L,54L,58L,60L,64L,66L,70L,72L,78L,82L,88L,96L,100L,102L,106L,108L,110L,112L,126L,128L,130L,136L,138L,148L,150L,156L,162L,166L,172L,178L,180L,190L,192L,196L,198L,210L,222L,226L,228L,232L,238L,240L,250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114871Inst : IEnumerable<long>
{
public static readonly long[] Value=A114871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114871.Bytes);
public long this[int i]=>Value[i];

public static A114871Inst Instance=new A114871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114872
{
public static readonly long[] Value={ 14L,24L,26L,34L,38L,44L,48L,50L,56L,62L,68L,74L,76L,80L,84L,86L,90L,92L,94L,98L,104L,114L,116L,118L,120L,122L,124L,132L,134L,140L,142L,144L,146L,152L,154L,158L,160L,164L,168L,170L,174L,176L,182L,184L,186L,188L,194L,200L,202L,204L,206L,208L,212L,214L,216L,218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114872Inst : IEnumerable<long>
{
public static readonly long[] Value=A114872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114872.Bytes);
public long this[int i]=>Value[i];

public static A114872Inst Instance=new A114872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114873
{
public static readonly long[] Value={ 1L,8L,10L,12L,20L,22L,28L,30L,32L,36L,40L,46L,52L,54L,58L,60L,64L,66L,70L,72L,78L,82L,88L,96L,102L,106L,108L,110L,112L,126L,128L,130L,136L,138L,148L,150L,166L,172L,178L,180L,190L,192L,196L,198L,210L,222L,226L,228L,232L,238L,240L,250L,262L,268L,270L,272L,276L,280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114873Inst : IEnumerable<long>
{
public static readonly long[] Value=A114873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114873.Bytes);
public long this[int i]=>Value[i];

public static A114873Inst Instance=new A114873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114874
{
public static readonly long[] Value={ 2L,4L,6L,16L,18L,42L,100L,156L,162L,256L,486L,1458L,2028L,4422L,6162L,14406L,19182L,22650L,23548L,26406L,37056L,39366L,62500L,65536L,77658L,113232L,121452L,143262L,208392L,292140L,342732L,375156L,412806L,527802L,564898L,590592L,697048L,843642L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114874Inst : IEnumerable<long>
{
public static readonly long[] Value=A114874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114874.Bytes);
public long this[int i]=>Value[i];

public static A114874Inst Instance=new A114874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114875
{
public static readonly long[] Value={ 3L,9L,2L,2L,6L,4L,6L,1L,3L,9L,2L,0L,9L,1L,5L,1L,7L,2L,7L,4L,7L,1L,5L,3L,1L,4L,4L,6L,7L,1L,4L,5L,9L,9L,5L,1L,3L,7L,3L,0L,3L,2L,3L,9L,7L,1L,5L,0L,6L,5L,0L,5L,2L,0L,9L,5L,6L,8L,2L,9L,8L,4L,8L,5L,2L,5L,4L,7L,2L,0L,8L,0L,3L,1L,5L,0L,3L,3L,8L,2L,8L,4L,8L,8L,0L,6L,5L,0L,5L,2L,3L,1L,0L,4L,1L,4L,5L,6L,9L,1L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114875Inst : IEnumerable<long>
{
public static readonly long[] Value=A114875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114875.Bytes);
public long this[int i]=>Value[i];

public static A114875Inst Instance=new A114875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114876
{
public static readonly BigInteger[] Value={ 1L,4L,108L,442368L,51200000L,52428800000L,43177371238400000L,BigInteger.Parse("60766747818779941065981952"),BigInteger.Parse("23542283154891408151173909109014528"),BigInteger.Parse("60268244876522004867005207319077191680000000000") };
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
public class A114876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114876Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114876.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A114876.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114876Inst Instance=new A114876Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114877
{
public static readonly BigInteger[] Value={ 1L,3L,125L,2100875L,2977309629L,118890080527911L,BigInteger.Parse("12677461389063582955701"),BigInteger.Parse("7895300107107819831516439618359375"),BigInteger.Parse("4725033556599120988065310720798566300246484375") };
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
public class A114877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114877Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114877.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A114877.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114877Inst Instance=new A114877Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114878
{
public static readonly long[] Value={ 0L,4L,74L,1024L,12750L,150952L,1739556L,19740728L,222003850L,2483142420L,27682969578L,307999242192L,3422552275480L,38003214330588L,421781012676970L,4679808933074296L,51914858228808470L,575847287536870136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114878Inst : IEnumerable<long>
{
public static readonly long[] Value=A114878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114878.Bytes);
public long this[int i]=>Value[i];

public static A114878Inst Instance=new A114878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114879
{
public static readonly long[] Value={ 2L,4L,5L,10L,20L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114879Inst : IEnumerable<long>
{
public static readonly long[] Value=A114879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114879.Bytes);
public long this[int i]=>Value[i];

public static A114879Inst Instance=new A114879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114880
{
public static readonly BigInteger[] Value={ 1L,212L,2111L,22222L,21112L,222111222L,212121212L,22112121L,212221222212L,2221221221222L,222222222222222L,22222222222222222L,1121212211122121211L,2121212121212121212L,112221112211111121L,BigInteger.Parse("21111111111111111111") };
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
public class A114880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114880Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114880.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A114880.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114880Inst Instance=new A114880Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114881
{
public static readonly long[] Value={ 1L,2L,3L,4L,8L,5L,6L,24L,14L,7L,10L,48L,34L,20L,9L,12L,120L,76L,54L,26L,11L,16L,168L,142L,90L,64L,32L,13L,18L,288L,220L,186L,118L,84L,38L,15L,22L,360L,322L,246L,208L,132L,94L,44L,17L,28L,528L,436L,390L,298L,252L,160L,114L,50L,19L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114881Inst : IEnumerable<long>
{
public static readonly long[] Value=A114881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114881.Bytes);
public long this[int i]=>Value[i];

public static A114881Inst Instance=new A114881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114882
{
public static readonly long[] Value={ 1L,3L,2L,5L,4L,7L,6L,8L,10L,9L,12L,11L,16L,24L,18L,13L,22L,15L,28L,48L,30L,17L,36L,14L,40L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114882Inst : IEnumerable<long>
{
public static readonly long[] Value=A114882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114882.Bytes);
public long this[int i]=>Value[i];

public static A114882Inst Instance=new A114882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114883
{
public static readonly long[] Value={ 1L,2L,4L,3L,12L,7L,5L,24L,17L,10L,6L,60L,38L,27L,13L,8L,84L,71L,45L,32L,16L,9L,144L,110L,93L,59L,42L,19L,11L,180L,161L,123L,104L,66L,47L,22L,14L,264L,218L,195L,149L,126L,80L,57L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114883Inst : IEnumerable<long>
{
public static readonly long[] Value=A114883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114883.Bytes);
public long this[int i]=>Value[i];

public static A114883Inst Instance=new A114883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114884
{
public static readonly long[] Value={ 4L,4L,5L,6L,2L,2L,4L,0L,3L,1L,9L,6L,8L,3L,3L,3L,3L,4L,0L,8L,8L,5L,2L,7L,9L,6L,7L,4L,9L,0L,1L,5L,1L,9L,9L,8L,2L,1L,2L,2L,1L,2L,2L,2L,2L,1L,7L,0L,4L,6L,0L,1L,4L,3L,6L,6L,3L,4L,7L,3L,6L,2L,0L,5L,7L,1L,4L,3L,5L,2L,9L,4L,7L,0L,9L,8L,2L,9L,4L,8L,4L,0L,7L,1L,3L,3L,6L,9L,0L,1L,3L,2L,9L,7L,8L,5L,2L,4L,9L,1L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114884Inst : IEnumerable<long>
{
public static readonly long[] Value=A114884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114884.Bytes);
public long this[int i]=>Value[i];

public static A114884Inst Instance=new A114884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114885
{
public static readonly long[] Value={ 1L,2L,4L,9L,13L,20L,43L,80L,326L,775L,3894L,5629L,7103L,10523L,61005L,355588L,1124509L,1824015L,2052357L,2719588L,5241202L,10253662L,17480124L,42664033L,83470664L,282411553L,328711697L,432040721L,1247136427L,4461350728L,15082139743L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114885Inst : IEnumerable<long>
{
public static readonly long[] Value=A114885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114885.Bytes);
public long this[int i]=>Value[i];

public static A114885Inst Instance=new A114885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114886
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,26L,27L,29L,30L,31L,32L,33L,34L,36L,37L,38L,39L,40L,42L,43L,44L,45L,47L,48L,49L,50L,51L,52L,53L,55L,56L,57L,58L,59L,60L,61L,62L,63L,65L,66L,67L,68L,69L,70L,71L,74L,75L,76L,77L,78L,80L,81L,82L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114886Inst : IEnumerable<long>
{
public static readonly long[] Value=A114886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114886.Bytes);
public long this[int i]=>Value[i];

public static A114886Inst Instance=new A114886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114887
{
public static readonly BigInteger[] Value={ 120L,672L,32760L,2178540L,1379454720L,14182439040L,518666803200L,30823866178560L,BigInteger.Parse("71065075104190073088"),BigInteger.Parse("154345556085770649600"),BigInteger.Parse("9186050031556349952000"),BigInteger.Parse("680489641226538823680000") };
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
public class A114887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114887Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114887.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A114887.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114887Inst Instance=new A114887Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114888
{
public static readonly BigInteger[] Value={ 1379454720L,14182439040L,BigInteger.Parse("680489641226538823680000"),BigInteger.Parse("15229814702070563916152832000"),BigInteger.Parse("34111227434420791224041472000"),BigInteger.Parse("1423615645454579571642097845619575340668304766095889698652160000000") };
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
public class A114888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114888Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114888.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A114888.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114888Inst Instance=new A114888Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114889
{
public static readonly long[] Value={ 1L,3L,4L,7L,9L,10L,11L,12L,13L,19L,21L,22L,25L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,55L,57L,58L,61L,63L,64L,65L,66L,67L,73L,75L,76L,79L,81L,82L,83L,84L,85L,86L,87L,88L,89L,90L,91L,92L,93L,94L,95L,96L,97L,98L,99L,100L,101L,102L,103L,104L,105L,106L,107L,108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114889Inst : IEnumerable<long>
{
public static readonly long[] Value=A114889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114889.Bytes);
public long this[int i]=>Value[i];

public static A114889Inst Instance=new A114889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114890
{
public static readonly long[] Value={ 2L,1L,3L,2L,1L,1L,1L,1L,6L,2L,1L,3L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,15L,2L,1L,3L,2L,1L,1L,1L,1L,6L,2L,1L,3L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,42L,2L,1L,3L,2L,1L,1L,1L,1L,6L,2L,1L,3L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114890Inst : IEnumerable<long>
{
public static readonly long[] Value=A114890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114890.Bytes);
public long this[int i]=>Value[i];

public static A114890Inst Instance=new A114890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114891
{
public static readonly long[] Value={ 1L,3L,5L,8L,12L,14L,18L,20L,24L,26L,30L,32L,38L,42L,44L,48L,50L,54L,56L,60L,62L,68L,72L,74L,78L,80L,84L,86L,90L,92L,98L,102L,104L,108L,110L,114L,116L,120L,122L,128L,132L,134L,138L,140L,144L,146L,150L,152L,158L,162L,164L,168L,170L,174L,176L,180L,182L,188L,192L,194L,198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114891Inst : IEnumerable<long>
{
public static readonly long[] Value=A114891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114891.Bytes);
public long this[int i]=>Value[i];

public static A114891Inst Instance=new A114891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114892
{
public static readonly long[] Value={ 2L,2L,3L,4L,2L,4L,2L,4L,2L,4L,2L,6L,4L,2L,4L,2L,4L,2L,4L,2L,6L,4L,2L,4L,2L,4L,2L,4L,2L,6L,4L,2L,4L,2L,4L,2L,4L,2L,6L,4L,2L,4L,2L,4L,2L,4L,2L,6L,4L,2L,4L,2L,4L,2L,4L,2L,6L,4L,2L,4L,2L,4L,2L,4L,2L,10L,2L,4L,2L,4L,2L,4L,2L,6L,4L,2L,4L,2L,4L,2L,4L,2L,6L,4L,2L,4L,2L,4L,2L,4L,2L,6L,4L,2L,4L,2L,4L,2L,4L,2L,6L,4L,2L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114892Inst : IEnumerable<long>
{
public static readonly long[] Value=A114892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114892.Bytes);
public long this[int i]=>Value[i];

public static A114892Inst Instance=new A114892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114893
{
public static readonly long[] Value={ 9L,1L,4L,6L,6L,9L,8L,1L,9L,3L,1L,7L,1L,4L,5L,9L,2L,6L,5L,8L,6L,6L,1L,9L,7L,6L,6L,3L,4L,6L,6L,3L,4L,1L,2L,5L,2L,7L,8L,4L,1L,3L,8L,5L,9L,9L,3L,7L,6L,8L,8L,1L,6L,4L,9L,1L,1L,1L,8L,1L,3L,7L,9L,1L,7L,0L,1L,8L,2L,0L,5L,1L,6L,8L,3L,8L,0L,4L,2L,0L,5L,7L,7L,1L,7L,0L,9L,0L,6L,7L,6L,6L,6L,5L,4L,7L,2L,3L,0L,2L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114893Inst : IEnumerable<long>
{
public static readonly long[] Value=A114893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114893.Bytes);
public long this[int i]=>Value[i];

public static A114893Inst Instance=new A114893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114894
{
public static readonly long[] Value={ 1L,2L,4L,3L,16L,5L,64L,9L,37L,6L,12L,7L,4096L,22L,76L,129L,65536L,10L,262144L,13L,25L,35L,24L,60L,301L,1366L,131329L,15L,117L,39L,1073741824L,32769L,81L,21846L,36L,19L,112L,87382L,40L,94L,6684L,74L,216L,58L,316L,71L,1176L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114894Inst : IEnumerable<long>
{
public static readonly long[] Value=A114894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114894.Bytes);
public long this[int i]=>Value[i];

public static A114894Inst Instance=new A114894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114895
{
public static readonly BigInteger[] Value={ 2L,3L,5L,11L,53L,971L,15413L,50123L,4144181L,17175725003L,51543751733L,223334155211L,BigInteger.Parse("77371252455336043847040053"),BigInteger.Parse("5070525029660462269942965781451") };
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
public class A114895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114895Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114895.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A114895.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114895Inst Instance=new A114895Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114896
{
public static readonly long[] Value={ 1L,2L,2L,2L,4L,2L,3L,4L,4L,3L,2L,6L,4L,6L,2L,4L,4L,6L,6L,4L,4L,2L,8L,4L,9L,4L,8L,2L,4L,4L,8L,6L,6L,8L,4L,4L,3L,8L,4L,12L,4L,12L,4L,8L,3L,4L,6L,8L,6L,8L,8L,6L,8L,6L,4L,2L,8L,6L,12L,4L,16L,4L,12L,6L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114896Inst : IEnumerable<long>
{
public static readonly long[] Value=A114896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114896.Bytes);
public long this[int i]=>Value[i];

public static A114896Inst Instance=new A114896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114897
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,1L,4L,1L,1L,2L,7L,2L,7L,1L,1L,4L,11L,3L,9L,2L,4L,4L,11L,0L,2L,4L,4L,11L,11L,6L,14L,2L,5L,7L,6L,8L,16L,10L,4L,15L,13L,9L,13L,10L,5L,9L,14L,5L,9L,9L,11L,10L,17L,6L,9L,11L,13L,19L,20L,11L,22L,8L,17L,14L,13L,14L,20L,13L,13L,22L,23L,9L,20L,8L,12L,16L,11L,13L,21L,13L,13L,16L,14L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114897Inst : IEnumerable<long>
{
public static readonly long[] Value=A114897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114897.Bytes);
public long this[int i]=>Value[i];

public static A114897Inst Instance=new A114897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114898
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,2L,1L,0L,3L,4L,5L,4L,4L,2L,7L,5L,6L,5L,5L,1L,4L,5L,3L,6L,6L,7L,8L,6L,7L,7L,6L,5L,5L,6L,11L,16L,13L,9L,9L,11L,12L,13L,7L,4L,6L,11L,10L,12L,8L,7L,8L,12L,12L,15L,17L,14L,12L,11L,15L,16L,15L,14L,11L,13L,16L,21L,22L,18L,12L,11L,16L,17L,14L,12L,12L,12L,20L,17L,10L,8L,14L,14L,16L,13L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114898Inst : IEnumerable<long>
{
public static readonly long[] Value=A114898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114898.Bytes);
public long this[int i]=>Value[i];

public static A114898Inst Instance=new A114898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114899
{
public static readonly long[] Value={ 0L,0L,2L,3L,1L,3L,1L,2L,2L,3L,5L,5L,4L,3L,6L,4L,6L,7L,4L,5L,4L,3L,3L,4L,4L,8L,9L,9L,10L,6L,3L,6L,5L,8L,10L,9L,7L,14L,14L,13L,12L,10L,6L,11L,10L,7L,6L,11L,7L,11L,13L,9L,10L,12L,10L,14L,14L,19L,15L,13L,13L,16L,11L,15L,18L,16L,14L,18L,17L,20L,18L,12L,11L,16L,10L,13L,16L,13L,12L,18L,12L,10L,9L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114899Inst : IEnumerable<long>
{
public static readonly long[] Value=A114899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114899.Bytes);
public long this[int i]=>Value[i];

public static A114899Inst Instance=new A114899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114900
{
public static readonly long[] Value={ 2L,4L,8L,24L,60L,152L,400L,1032L,2656L,6876L,17776L,45912L,118664L,306680L,792480L,2047984L,5292564L,13677160L,35345112L,91340568L,236046088L,610000528L,1576390448L,4073776744L,10527631456L,27205966108L,70306845872L,181690021616L,469531293752L,1213383282936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114900Inst : IEnumerable<long>
{
public static readonly long[] Value=A114900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114900.Bytes);
public long this[int i]=>Value[i];

public static A114900Inst Instance=new A114900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114901
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,1L,5L,3L,10L,10L,21L,22L,49L,51L,105L,126L,233L,292L,529L,678L,1181L,1585L,2654L,3654L,6016L,8416L,13606L,19395L,30840L,44517L,70087L,102070L,159304L,233941L,362429L,535520L,825358L,1225117L,1880220L,2801749L,4285086L,6404354L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114901Inst : IEnumerable<long>
{
public static readonly long[] Value=A114901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114901.Bytes);
public long this[int i]=>Value[i];

public static A114901Inst Instance=new A114901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114902
{
public static readonly BigInteger[] Value={ 1L,1L,1L,7L,21L,81L,793L,4929L,33029L,388537L,3751311L,37585989L,523395777L,6814401361L,90789460427L,1486639926417L,24213653736389L,403184436319401L,7665459211898263L,149067938821523349L,2971265450045056871L,BigInteger.Parse("64800464138121854877"),BigInteger.Parse("1460876941168812354947") };
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
public class A114902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114902Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114902.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A114902.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114902Inst Instance=new A114902Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114903
{
public static readonly BigInteger[] Value={ 2L,4L,12L,76L,572L,5204L,59340L,782996L,11707324L,197988340L,3720933092L,76811352116L,1730660689580L,42251140165108L,1110607948991028L,31279537587370916L,939737174809843644L,BigInteger.Parse("29996522608581396788"),BigInteger.Parse("1013814287146517455812"),BigInteger.Parse("36168456215193554061044") };
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
public class A114903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114903Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114903.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A114903.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114903Inst Instance=new A114903Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114904
{
public static readonly long[] Value={ 1L,3L,4L,5L,6L,7L,8L,9L,10L,11L,14L,16L,17L,19L,20L,21L,23L,24L,25L,27L,29L,31L,32L,33L,34L,35L,37L,38L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114904Inst : IEnumerable<long>
{
public static readonly long[] Value=A114904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114904.Bytes);
public long this[int i]=>Value[i];

public static A114904Inst Instance=new A114904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114905
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,1L,3L,2L,1L,2L,3L,2L,2L,2L,2L,4L,1L,4L,1L,4L,0L,5L,3L,4L,2L,1L,2L,4L,5L,3L,4L,2L,2L,2L,2L,2L,6L,2L,6L,1L,5L,1L,1L,2L,6L,8L,4L,2L,3L,5L,4L,3L,1L,2L,3L,5L,5L,5L,4L,3L,2L,2L,4L,5L,4L,3L,5L,6L,5L,2L,2L,4L,3L,6L,5L,2L,2L,4L,8L,4L,6L,1L,6L,3L,4L,4L,6L,1L,6L,3L,4L,10L,4L,5L,4L,5L,2L,8L,2L,5L,4L,5L,2L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114905Inst : IEnumerable<long>
{
public static readonly long[] Value=A114905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114905.Bytes);
public long this[int i]=>Value[i];

public static A114905Inst Instance=new A114905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114906
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,0L,2L,1L,3L,0L,2L,3L,2L,2L,2L,4L,1L,4L,1L,4L,0L,5L,3L,4L,2L,1L,2L,4L,5L,3L,4L,2L,2L,2L,2L,2L,6L,2L,6L,1L,5L,1L,1L,2L,6L,8L,4L,2L,3L,5L,4L,3L,1L,2L,3L,5L,5L,5L,4L,3L,2L,2L,4L,5L,4L,3L,5L,6L,5L,2L,2L,4L,3L,6L,5L,2L,2L,4L,8L,4L,6L,1L,6L,3L,4L,4L,6L,1L,6L,3L,4L,10L,4L,5L,4L,5L,2L,8L,2L,5L,4L,5L,2L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114906Inst : IEnumerable<long>
{
public static readonly long[] Value=A114906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114906.Bytes);
public long this[int i]=>Value[i];

public static A114906Inst Instance=new A114906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114907
{
public static readonly long[] Value={ 1L,3L,2L,0L,3L,2L,3L,6L,3L,1L,6L,9L,3L,7L,3L,9L,1L,4L,7L,8L,5L,5L,6L,2L,4L,2L,2L,0L,0L,2L,9L,1L,1L,1L,5L,5L,6L,8L,6L,5L,2L,4L,6L,7L,2L,0L,5L,6L,9L,4L,6L,6L,8L,2L,6L,6L,3L,8L,8L,9L,6L,8L,4L,6L,6L,7L,0L,8L,1L,1L,2L,8L,4L,6L,0L,8L,9L,9L,0L,5L,5L,4L,2L,8L,7L,5L,2L,0L,0L,6L,2L,8L,2L,7L,6L,7L,9L,7L,3L,5L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114907Inst : IEnumerable<long>
{
public static readonly long[] Value=A114907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114907.Bytes);
public long this[int i]=>Value[i];

public static A114907Inst Instance=new A114907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114908
{
public static readonly BigInteger[] Value={ 4444L,545421L,5555521412L,555555514322L,5555555551435323L,555555553453434223L,BigInteger.Parse("5555555551222222222314"),BigInteger.Parse("555545555455554555545555"),BigInteger.Parse("5555555555555441321122544214"),BigInteger.Parse("555554544444352442424321331153") };
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
public class A114908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114908Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114908.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A114908.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114908Inst Instance=new A114908Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114909
{
public static readonly long[] Value={ 5L,55L,656L,6662L,55555L,6565321L,66566566L,666566633L,6666612543L,65656565656L,666666666513L,66656665654315L,656565653543211L,6666666666666212L,66566566566566566L,665665665623461651L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114909Inst : IEnumerable<long>
{
public static readonly long[] Value=A114909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114909.Bytes);
public long this[int i]=>Value[i];

public static A114909Inst Instance=new A114909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114910
{
public static readonly BigInteger[] Value={ 75L,7773L,666666L,76764321L,7777777112L,777677767456L,77756664344152L,7777777577731365L,777776766661314425L,BigInteger.Parse("76767676767643755321"),BigInteger.Parse("7777777777376745252236"),BigInteger.Parse("777777777777777777374555") };
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
public class A114910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114910Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114910.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A114910.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114910Inst Instance=new A114910Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114911
{
public static readonly BigInteger[] Value={ 7L,777L,8787L,886845L,7777777L,878754321L,8888787871L,887885887811L,8878878767816L,878787878787878L,8888888677748678L,888888887867751312L,8787878787873543211L,BigInteger.Parse("888878888387777136788"),BigInteger.Parse("8888888888486868617568") };
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
public class A114911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114911Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114911.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A114911.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114911Inst Instance=new A114911Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114912
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,0L,2L,0L,1L,3L,1L,2L,0L,1L,1L,0L,5L,1L,1L,1L,6L,2L,0L,3L,1L,1L,0L,6L,1L,8L,3L,2L,1L,6L,9L,0L,2L,3L,5L,1L,0L,2L,1L,1L,3L,11L,8L,1L,1L,6L,1L,0L,1L,10L,1L,1L,2L,0L,3L,6L,7L,2L,1L,9L,2L,3L,2L,1L,13L,1L,0L,5L,9L,1L,1L,1L,1L,0L,1L,3L,9L,2L,6L,1L,1L,6L,6L,1L,1L,1L,1L,11L,0L,5L,6L,1L,2L,8L,6L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114912Inst : IEnumerable<long>
{
public static readonly long[] Value=A114912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114912.Bytes);
public long this[int i]=>Value[i];

public static A114912Inst Instance=new A114912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114913
{
public static readonly long[] Value={ 3L,4L,8L,10L,13L,14L,17L,18L,19L,24L,25L,28L,32L,39L,42L,43L,47L,48L,50L,52L,54L,55L,62L,67L,69L,73L,74L,75L,76L,78L,83L,84L,87L,88L,89L,90L,95L,99L,101L,103L,105L,108L,109L,112L,113L,118L,119L,123L,125L,127L,130L,132L,134L,138L,140L,143L,144L,147L,149L,153L,154L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114913Inst : IEnumerable<long>
{
public static readonly long[] Value=A114913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114913.Bytes);
public long this[int i]=>Value[i];

public static A114913Inst Instance=new A114913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114914
{
public static readonly long[] Value={ 76L,101L,149L,198L,201L,251L,326L,351L,368L,394L,426L,451L,476L,489L,492L,514L,601L,626L,639L,683L,688L,701L,801L,835L,879L,884L,933L,973L,976L,1051L,1076L,1098L,1168L,1176L,1178L,1201L,1215L,1227L,1251L,1301L,1351L,1359L,1374L,1376L,1459L,1551L,1570L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114914Inst : IEnumerable<long>
{
public static readonly long[] Value=A114914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114914.Bytes);
public long this[int i]=>Value[i];

public static A114914Inst Instance=new A114914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114915
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,0L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,0L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114915Inst : IEnumerable<long>
{
public static readonly long[] Value=A114915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114915.Bytes);
public long this[int i]=>Value[i];

public static A114915Inst Instance=new A114915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114916
{
public static readonly long[] Value={ 1L,5L,7L,7L,6L,0L,9L,7L,7L,2L,3L,4L,2L,2L,0L,7L,3L,7L,7L,1L,5L,6L,0L,7L,3L,2L,1L,2L,1L,5L,0L,8L,9L,7L,3L,3L,0L,7L,5L,4L,9L,5L,6L,8L,1L,3L,0L,9L,0L,7L,8L,2L,3L,9L,1L,6L,0L,4L,3L,9L,9L,7L,1L,4L,7L,7L,9L,5L,6L,0L,7L,8L,1L,6L,0L,7L,8L,7L,0L,0L,1L,2L,5L,2L,1L,7L,4L,3L,7L,7L,4L,4L,1L,4L,0L,6L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114916Inst : IEnumerable<long>
{
public static readonly long[] Value=A114916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114916.Bytes);
public long this[int i]=>Value[i];

public static A114916Inst Instance=new A114916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114917
{
public static readonly long[] Value={ 1L,0L,1L,1L,4L,1L,71L,106L,1051L,2759L,19552L,51041L,864579L,3134132L,34990671L,211464345L,1832236004L,11261632321L,109973219879L,659853699654L,8379292553185L,58134013363151L,676374746166550L,5912498819726335L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114917Inst : IEnumerable<long>
{
public static readonly long[] Value=A114917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114917.Bytes);
public long this[int i]=>Value[i];

public static A114917Inst Instance=new A114917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114918
{
public static readonly long[] Value={ 1L,0L,1L,1L,4L,10L,41L,140L,659L,2885L,14956L,77990L,452409L,2678676L,17176251L,113458801L,795016044L,5760341506L,43802563937L,344138100628L,2817486388739L,23809341016525L,208552149482436L,1882541647472398L,17549345518850193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114918Inst : IEnumerable<long>
{
public static readonly long[] Value=A114918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114918.Bytes);
public long this[int i]=>Value[i];

public static A114918Inst Instance=new A114918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114919
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,2L,1L,1L,2L,3L,2L,3L,3L,1L,3L,4L,2L,4L,1L,4L,1L,1L,6L,2L,4L,2L,1L,2L,3L,7L,2L,4L,2L,4L,2L,2L,6L,6L,1L,6L,2L,4L,1L,2L,1L,2L,9L,3L,3L,3L,5L,3L,4L,0L,3L,7L,2L,8L,3L,6L,2L,1L,2L,7L,2L,6L,7L,7L,2L,5L,4L,7L,3L,2L,1L,5L,4L,7L,9L,5L,4L,4L,6L,2L,7L,2L,3L,4L,6L,2L,7L,7L,8L,3L,6L,4L,5L,3L,5L,3L,6L,4L,5L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114919Inst : IEnumerable<long>
{
public static readonly long[] Value=A114919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114919.Bytes);
public long this[int i]=>Value[i];

public static A114919Inst Instance=new A114919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114920
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,2L,1L,2L,2L,2L,3L,4L,1L,3L,1L,2L,3L,4L,1L,4L,0L,2L,4L,3L,4L,2L,2L,1L,4L,6L,2L,5L,2L,3L,1L,2L,5L,6L,3L,4L,2L,4L,2L,2L,2L,6L,7L,2L,6L,1L,5L,1L,3L,2L,6L,5L,7L,4L,2L,4L,5L,4L,3L,2L,2L,4L,7L,7L,3L,7L,2L,3L,3L,4L,3L,7L,2L,3L,11L,3L,5L,3L,9L,2L,4L,1L,5L,3L,9L,2L,4L,8L,5L,9L,4L,6L,2L,4L,2L,8L,4L,6L,2L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114920Inst : IEnumerable<long>
{
public static readonly long[] Value=A114920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114920.Bytes);
public long this[int i]=>Value[i];

public static A114920Inst Instance=new A114920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114921
{
public static readonly long[] Value={ 1L,0L,1L,2L,4L,6L,11L,16L,27L,40L,63L,92L,141L,202L,299L,426L,614L,862L,1222L,1694L,2362L,3242L,4456L,6054L,8229L,11072L,14891L,19872L,26477L,35050L,46320L,60866L,79827L,104194L,135703L,176008L,227791L,293702L,377874L,484554L,620011L,790952L,1006924L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114921Inst : IEnumerable<long>
{
public static readonly long[] Value=A114921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114921.Bytes);
public long this[int i]=>Value[i];

public static A114921Inst Instance=new A114921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114922
{
public static readonly BigInteger[] Value={ 88L,999993L,88888888L,9898654321L,999998986863L,9999999999924214L,999999999999962944L,BigInteger.Parse("99999899999899978513"),BigInteger.Parse("9999999999999999976315"),BigInteger.Parse("99899899899899899899899899"),BigInteger.Parse("9999999999999999999999912715") };
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
public class A114922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114922Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114922.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A114922.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114922Inst Instance=new A114922Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114923
{
public static readonly long[] Value={ 709L,1033L,2767L,2791L,2917L,3727L,3769L,5647L,5657L,5737L,7039L,7321L,8089L,8291L,8387L,9433L,9473L,9851L,12073L,12343L,13417L,14083L,14561L,14723L,14831L,14969L,15313L,18127L,19841L,25033L,28081L,28477L,29153L,29179L,32771L,33161L,33199L,33377L,34337L,36713L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114923Inst : IEnumerable<long>
{
public static readonly long[] Value=A114923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114923.Bytes);
public long this[int i]=>Value[i];

public static A114923Inst Instance=new A114923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114924
{
public static readonly long[] Value={ 17L,12491L,14723L,42437L,57089L,58193L,61051L,63131L,63347L,64553L,64567L,64577L,64591L,64601L,64661L,64679L,64951L,65071L,65173L,65293L,65881L,66863L,69931L,79817L,99551L,129083L,165103L,263071L,284833L,1407647L,1515259L,4303027L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114924Inst : IEnumerable<long>
{
public static readonly long[] Value=A114924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114924.Bytes);
public long this[int i]=>Value[i];

public static A114924Inst Instance=new A114924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114925
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,4L,6L,8L,10L,3L,5L,7L,9L,11L,2L,5L,8L,11L,3L,6L,9L,12L,3L,7L,10L,4L,7L,11L,4L,8L,12L,4L,9L,13L,4L,10L,5L,9L,14L,5L,10L,6L,10L,7L,12L,5L,11L,5L,12L,6L,11L,6L,12L,7L,13L,5L,13L,6L,13L,7L,14L,6L,14L,7L,15L,6L,15L,7L,16L,7L,17L,8L,13L,8L,14L,8L,15L,8L,16L,8L,17L,9L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114925Inst : IEnumerable<long>
{
public static readonly long[] Value=A114925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114925.Bytes);
public long this[int i]=>Value[i];

public static A114925Inst Instance=new A114925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114926
{
public static readonly long[] Value={ 1L,23L,526L,536L,1802L,4735L,17191L,38524L,235652L,36235483L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114926Inst : IEnumerable<long>
{
public static readonly long[] Value=A114926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114926.Bytes);
public long this[int i]=>Value[i];

public static A114926Inst Instance=new A114926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114927
{
public static readonly long[] Value={ 41L,291552L,692133L,2946762L,8231796L,21732508611L,27892659612L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114927Inst : IEnumerable<long>
{
public static readonly long[] Value=A114927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114927.Bytes);
public long this[int i]=>Value[i];

public static A114927Inst Instance=new A114927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114928
{
public static readonly long[] Value={ 42L,402L,492L,4000002L,57906504L,400000002L,4000000002L,6279090751L,62698513951L,400000000002L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114928Inst : IEnumerable<long>
{
public static readonly long[] Value=A114928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114928.Bytes);
public long this[int i]=>Value[i];

public static A114928Inst Instance=new A114928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114929
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,4L,2L,2L,4L,9L,5L,1L,5L,9L,21L,12L,3L,3L,12L,21L,51L,30L,9L,1L,9L,30L,51L,127L,76L,25L,4L,4L,25L,76L,127L,323L,196L,69L,14L,1L,14L,69L,196L,323L,835L,512L,189L,44L,5L,5L,44L,189L,512L,835L,2188L,1353L,518L,133L,20L,1L,20L,133L,518L,1353L,2188L,5798L,3610L,1422L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114929Inst : IEnumerable<long>
{
public static readonly long[] Value=A114929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114929.Bytes);
public long this[int i]=>Value[i];

public static A114929Inst Instance=new A114929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114930
{
public static readonly long[] Value={ 6180L,27630L,2914830L,4471740L,27000630L,637062480L,27000000630L,679410757980L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114930Inst : IEnumerable<long>
{
public static readonly long[] Value=A114930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114930.Bytes);
public long this[int i]=>Value[i];

public static A114930Inst Instance=new A114930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114931
{
public static readonly long[] Value={ 10L,20L,40L,50L,80L,210L,420L,630L,711L,831L,840L,2910L,29910L,40320L,80640L,98361L,673140L,865580L,8656341L,466760130L,694602930L,821412711L,23465346510L,40396039620L,63130473930L,234000006510L,464205665820L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114931Inst : IEnumerable<long>
{
public static readonly long[] Value=A114931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114931.Bytes);
public long this[int i]=>Value[i];

public static A114931Inst Instance=new A114931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114932
{
public static readonly long[] Value={ 0L,0L,1L,25L,267L,2265L,17471L,128765L,927067L,6591505L,46545591L,327428805L,2298406067L,16114352345L,112902172111L,790721005645L,5536667136267L,38763140938785L,271367842141031L,1899678231827285L,13298160713181667L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114932Inst : IEnumerable<long>
{
public static readonly long[] Value=A114932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114932.Bytes);
public long this[int i]=>Value[i];

public static A114932Inst Instance=new A114932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114933
{
public static readonly long[] Value={ 0L,0L,0L,32L,1094L,23055L,405475L,6575842L,102567444L,1569195485L,23775369725L,358461659952L,5391042181294L,80974624209115L,1215462744452775L,18238484835400862L,273628186560143144L,4104820038944901945L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114933Inst : IEnumerable<long>
{
public static readonly long[] Value=A114933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114933.Bytes);
public long this[int i]=>Value[i];

public static A114933Inst Instance=new A114933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114934
{
public static readonly BigInteger[] Value={ 0L,0L,0L,21L,2773L,148365L,5878391L,204819447L,6721694469L,214306917321L,6736603947907L,210284186632443L,6541309609120385L,203129541349695597L,6302428271530970943L,BigInteger.Parse("195459285517696665759"),BigInteger.Parse("6060542952694406463421") };
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
public class A114934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114934Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114934.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A114934.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114934Inst Instance=new A114934Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114935
{
public static readonly long[] Value={ 0L,1L,6L,44L,332L,2476L,18136L,130824L,933372L,6610676L,46603616L,327603904L,2298933412L,16115938476L,112906938696L,790735321784L,5536710117452L,38763269947876L,271368229299376L,1899679393564464L,1329816419891749L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114935Inst : IEnumerable<long>
{
public static readonly long[] Value=A114935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114935.Bytes);
public long this[int i]=>Value[i];

public static A114935Inst Instance=new A114935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114936
{
public static readonly long[] Value={ 0L,1L,10L,135L,1992L,30166L,458885L,6965225L,105358102L,1588998756L,23915093535L,359444209015L,5397938190512L,81022969645346L,1215801458118985L,18240857019892005L,273644796626023722L,4104936328561231936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114936Inst : IEnumerable<long>
{
public static readonly long[] Value=A114936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114936.Bytes);
public long this[int i]=>Value[i];

public static A114936Inst Instance=new A114936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114937
{
public static readonly BigInteger[] Value={ 0L,1L,15L,336L,8880L,254596L,7606446L,231899522L,7137539256L,220623286632L,6831984816402L,211719998195278L,6562887569336652L,203453536535818388L,6307290799931347878L,BigInteger.Parse("195532244201392935354"),BigInteger.Parse("6061637498660735815968") };
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
public class A114937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114937Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114937.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A114937.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114937Inst Instance=new A114937Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114938
{
public static readonly BigInteger[] Value={ 0L,2L,30L,864L,39480L,2631600L,241133760L,29083420800L,4467125013120L,851371260364800L,197158144895712000L,BigInteger.Parse("54528028997584665600"),BigInteger.Parse("17752366094818747392000"),BigInteger.Parse("6720318485119046923315200"),BigInteger.Parse("2927066537906697348594432000"),BigInteger.Parse("1453437879238150456164433920000") };
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
public class A114938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114938Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114938.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A114938.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114938Inst Instance=new A114938Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114939
{
public static readonly BigInteger[] Value={ 0L,1L,7L,216L,10956L,803400L,83003040L,11579823360L,2080493573760L,469031859192960L,129727461014726400L,BigInteger.Parse("43176116371928601600"),BigInteger.Parse("17025803126147196057600"),BigInteger.Parse("7850538273249476117913600") };
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
public class A114939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114939Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A114939.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A114939.Bytes);
public BigInteger this[int i]=>Value[i];

public static A114939Inst Instance=new A114939Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A114940
{
public static readonly long[] Value={ 1L,2L,7L,9L,8L,8L,3L,0L,0L,1L,3L,7L,3L,0L,2L,2L,4L,9L,3L,9L,0L,8L,4L,6L,2L,3L,0L,1L,2L,0L,1L,3L,9L,1L,8L,8L,8L,2L,3L,5L,6L,3L,8L,9L,0L,7L,7L,3L,9L,0L,2L,8L,8L,1L,1L,4L,7L,2L,3L,8L,8L,2L,1L,5L,8L,0L,5L,3L,7L,3L,7L,1L,7L,8L,9L,6L,8L,4L,5L,4L,0L,1L,2L,1L,5L,4L,6L,4L,0L,4L,9L,2L,5L,6L,1L,2L,6L,5L,9L,1L,5L,3L,7L,3L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A114940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A114940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A114940Inst : IEnumerable<long>
{
public static readonly long[] Value=A114940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A114940.Bytes);
public long this[int i]=>Value[i];

public static A114940Inst Instance=new A114940Inst();

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