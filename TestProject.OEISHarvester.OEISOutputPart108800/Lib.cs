using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A141641
{
public static readonly long[] Value={ 4L,6L,8L,13L,15L,17L,19L,22L,24L,26L,28L,31L,33L,35L,37L,39L,40L,42L,44L,46L,48L,51L,53L,55L,57L,59L,60L,62L,64L,66L,68L,71L,73L,75L,77L,79L,80L,82L,84L,86L,88L,91L,93L,95L,97L,99L,103L,105L,107L,109L,112L,114L,116L,118L,121L,123L,125L,127L,129L,130L,132L,134L,136L,138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141641Inst : IEnumerable<long>
{
public static readonly long[] Value=A141641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141641.Bytes);
public long this[int i]=>Value[i];

public static A141641Inst Instance=new A141641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141642
{
public static readonly long[] Value={ 12L,14L,16L,20L,21L,25L,30L,32L,34L,38L,49L,50L,52L,56L,58L,65L,70L,74L,76L,85L,92L,94L,98L,102L,104L,106L,110L,111L,115L,119L,120L,122L,124L,128L,133L,140L,142L,146L,148L,155L,160L,164L,166L,175L,182L,184L,188L,200L,201L,203L,205L,209L,210L,212L,214L,218L,221L,230L,232L,236L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141642Inst : IEnumerable<long>
{
public static readonly long[] Value=A141642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141642.Bytes);
public long this[int i]=>Value[i];

public static A141642Inst Instance=new A141642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141643
{
public static readonly long[] Value={ 24L,91963648L,10200236032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141643Inst : IEnumerable<long>
{
public static readonly long[] Value=A141643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141643.Bytes);
public long this[int i]=>Value[i];

public static A141643Inst Instance=new A141643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141644
{
public static readonly long[] Value={ 3L,19L,41L,173L,181L,281L,347L,373L,401L,409L,433L,449L,461L,461L,479L,499L,509L,541L,547L,571L,577L,619L,691L,701L,709L,859L,881L,919L,929L,1087L,1091L,1093L,1097L,1193L,1229L,1367L,1367L,1481L,1483L,1511L,1523L,1553L,1559L,1579L,1601L,1667L,1697L,1699L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141644Inst : IEnumerable<long>
{
public static readonly long[] Value=A141644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141644.Bytes);
public long this[int i]=>Value[i];

public static A141644Inst Instance=new A141644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141645
{
public static readonly BigInteger[] Value={ 8910720L,17428320L,8583644160L,57629644800L,206166804480L,1416963251404800L,15338300494970880L,6275163455171297280L,BigInteger.Parse("200286975596707184640"),BigInteger.Parse("215594611071909888000"),BigInteger.Parse("5997579964837140234240"),BigInteger.Parse("39887491844324122951680") };
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
public class A141645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141645Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A141645.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A141645.Bytes);
public BigInteger this[int i]=>Value[i];

public static A141645Inst Instance=new A141645Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141646
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141646Inst : IEnumerable<long>
{
public static readonly long[] Value=A141646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141646.Bytes);
public long this[int i]=>Value[i];

public static A141646Inst Instance=new A141646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141647
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,0L,2L,1L,1L,2L,0L,0L,2L,1L,0L,0L,0L,2L,1L,1L,0L,2L,0L,1L,2L,2L,1L,0L,0L,0L,0L,2L,0L,1L,1L,0L,0L,2L,1L,0L,2L,2L,2L,1L,0L,0L,0L,0L,0L,2L,2L,1L,1L,1L,0L,0L,0L,2L,2L,2L,0L,0L,1L,2L,1L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,0L,1L,0L,2L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141647Inst : IEnumerable<long>
{
public static readonly long[] Value=A141647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141647.Bytes);
public long this[int i]=>Value[i];

public static A141647Inst Instance=new A141647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141648
{
public static readonly long[] Value={ 1L,1L,3L,1L,4L,2L,1L,0L,3L,3L,1L,0L,4L,4L,2L,1L,0L,0L,0L,4L,3L,1L,0L,1L,4L,1L,0L,2L,1L,0L,0L,0L,0L,0L,3L,3L,1L,0L,0L,0L,1L,0L,3L,4L,2L,1L,0L,0L,0L,0L,0L,2L,0L,1L,3L,1L,0L,0L,0L,0L,3L,3L,2L,4L,1L,2L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,3L,3L,1L,0L,0L,0L,0L,1L,1L,0L,4L,4L,3L,2L,2L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,4L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141648Inst : IEnumerable<long>
{
public static readonly long[] Value=A141648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141648.Bytes);
public long this[int i]=>Value[i];

public static A141648Inst Instance=new A141648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141649
{
public static readonly long[] Value={ 1L,1L,4L,1L,6L,3L,1L,6L,0L,4L,1L,0L,5L,4L,3L,1L,0L,0L,0L,1L,4L,1L,0L,1L,5L,4L,6L,3L,1L,0L,0L,0L,0L,0L,6L,4L,1L,0L,0L,0L,0L,4L,6L,2L,3L,1L,0L,0L,0L,0L,6L,1L,0L,6L,4L,1L,0L,0L,0L,1L,1L,4L,1L,2L,3L,3L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,4L,1L,0L,0L,0L,2L,5L,3L,2L,4L,0L,5L,0L,3L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,6L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141649Inst : IEnumerable<long>
{
public static readonly long[] Value=A141649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141649.Bytes);
public long this[int i]=>Value[i];

public static A141649Inst Instance=new A141649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141650
{
public static readonly long[] Value={ 5L,7L,3L,13L,7L,11L,29L,17L,37L,7L,5L,53L,59L,67L,19L,13L,41L,83L,31L,107L,131L,19L,47L,71L,29L,157L,193L,41L,19L,241L,61L,251L,137L,47L,97L,311L,23L,331L,67L,397L,137L,211L,73L,149L,229L,157L,79L,41L,251L,503L,43L,173L,263L,269L,619L,311L,659L,691L,353L,739L,199L,421L,281L,853L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141650Inst : IEnumerable<long>
{
public static readonly long[] Value=A141650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141650.Bytes);
public long this[int i]=>Value[i];

public static A141650Inst Instance=new A141650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141651
{
public static readonly long[] Value={ 2L,2L,11L,2L,5L,19L,43L,23L,19L,31L,23L,79L,29L,59L,43L,139L,179L,181L,31L,223L,233L,79L,281L,293L,151L,157L,317L,53L,163L,109L,337L,359L,181L,43L,199L,83L,109L,463L,467L,241L,491L,523L,89L,607L,103L,631L,79L,643L,673L,233L,89L,179L,757L,773L,89L,821L,823L,839L,859L,433L,293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141651Inst : IEnumerable<long>
{
public static readonly long[] Value=A141651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141651.Bytes);
public long this[int i]=>Value[i];

public static A141651Inst Instance=new A141651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141652
{
public static readonly long[] Value={ 2L,2L,3L,2L,7L,5L,7L,17L,23L,29L,19L,41L,11L,17L,37L,41L,31L,101L,17L,53L,113L,59L,41L,127L,43L,13L,11L,139L,29L,157L,89L,61L,37L,103L,109L,113L,239L,251L,137L,101L,61L,307L,313L,337L,373L,127L,101L,137L,419L,113L,457L,461L,239L,479L,167L,103L,181L,139L,47L,193L,101L,107L,653L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141652Inst : IEnumerable<long>
{
public static readonly long[] Value=A141652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141652.Bytes);
public long this[int i]=>Value[i];

public static A141652Inst Instance=new A141652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141653
{
public static readonly long[] Value={ 4L,9L,4L,8L,18L,21L,22L,4L,25L,15L,16L,35L,12L,10L,42L,45L,24L,18L,55L,57L,20L,33L,36L,38L,39L,40L,27L,28L,86L,87L,30L,46L,52L,105L,108L,16L,38L,20L,62L,63L,133L,27L,46L,28L,72L,76L,51L,154L,52L,158L,20L,162L,55L,21L,172L,58L,177L,60L,93L,187L,189L,98L,198L,40L,203L,102L,104L,70L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141653Inst : IEnumerable<long>
{
public static readonly long[] Value=A141653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141653.Bytes);
public long this[int i]=>Value[i];

public static A141653Inst Instance=new A141653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141654
{
public static readonly long[] Value={ 2L,4L,14L,16L,20L,22L,26L,29L,31L,33L,35L,36L,37L,39L,43L,46L,49L,52L,55L,56L,59L,65L,68L,69L,71L,73L,74L,78L,79L,80L,83L,90L,93L,99L,100L,107L,109L,110L,113L,114L,121L,124L,125L,126L,131L,132L,135L,143L,145L,148L,153L,155L,164L,168L,171L,179L,182L,184L,185L,195L,196L,197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141654Inst : IEnumerable<long>
{
public static readonly long[] Value=A141654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141654.Bytes);
public long this[int i]=>Value[i];

public static A141654Inst Instance=new A141654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141655
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,9L,7L,8L,11L,17L,11L,13L,16L,21L,32L,13L,15L,18L,22L,30L,44L,17L,19L,22L,27L,33L,45L,67L,19L,21L,24L,28L,34L,42L,56L,84L,23L,25L,28L,32L,38L,45L,57L,76L,114L,29L,31L,35L,39L,45L,53L,63L,79L,106L,159L,31L,33L,37L,41L,46L,53L,61L,74L,92L,123L,185L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141655Inst : IEnumerable<long>
{
public static readonly long[] Value=A141655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141655.Bytes);
public long this[int i]=>Value[i];

public static A141655Inst Instance=new A141655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141688
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,1L,26L,26L,1L,1L,99L,416L,99L,1L,1L,352L,5407L,5407L,352L,1L,1L,1200L,62616L,227094L,62616L,1200L,1L,1L,3977L,673728L,8212854L,8212854L,673728L,3977L,1L,1L,12918L,6889153L,269486766L,903413940L,269486766L,6889153L,12918L,1L,1L,41338L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141688Inst : IEnumerable<long>
{
public static readonly long[] Value=A141688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141688.Bytes);
public long this[int i]=>Value[i];

public static A141688Inst Instance=new A141688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141689
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,7L,7L,1L,1L,15L,36L,15L,1L,1L,31L,156L,156L,31L,1L,1L,63L,603L,1218L,603L,63L,1L,1L,127L,2157L,7827L,7827L,2157L,127L,1L,1L,255L,7318L,44145L,78130L,44145L,7318L,255L,1L,1L,511L,23938L,227638L,655240L,655240L,227638L,23938L,511L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141689Inst : IEnumerable<long>
{
public static readonly long[] Value=A141689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141689.Bytes);
public long this[int i]=>Value[i];

public static A141689Inst Instance=new A141689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141690
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,1L,19L,19L,1L,1L,48L,126L,48L,1L,1L,109L,594L,594L,109L,1L,1L,234L,2367L,4812L,2367L,234L,1L,1L,487L,8565L,31203L,31203L,8565L,487L,1L,1L,996L,29188L,176412L,312310L,176412L,29188L,996L,1L,1L,2017L,95644L,910300L,2620582L,2620582L,910300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141690Inst : IEnumerable<long>
{
public static readonly long[] Value=A141690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141690.Bytes);
public long this[int i]=>Value[i];

public static A141690Inst Instance=new A141690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141691
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,15L,15L,1L,1L,37L,96L,37L,1L,1L,83L,448L,448L,83L,1L,1L,177L,1779L,3614L,1779L,177L,1L,1L,367L,6429L,23411L,23411L,6429L,367L,1L,1L,749L,21898L,132323L,234250L,132323L,21898L,749L,1L,1L,1515L,71742L,682746L,1965468L,1965468L,682746L,71742L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141691Inst : IEnumerable<long>
{
public static readonly long[] Value=A141691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141691.Bytes);
public long this[int i]=>Value[i];

public static A141691Inst Instance=new A141691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141692
{
public static readonly long[] Value={ 0L,-1L,1L,-2L,0L,2L,-3L,-3L,3L,3L,-4L,-8L,0L,8L,4L,-5L,-15L,-10L,10L,15L,5L,-6L,-24L,-30L,0L,30L,24L,6L,-7L,-35L,-63L,-35L,35L,63L,35L,7L,-8L,-48L,-112L,-112L,0L,112L,112L,48L,8L,-9L,-63L,-180L,-252L,-126L,126L,252L,180L,63L,9L,-10L,-80L,-270L,-480L,-420L,0L,420L,480L,270L,80L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141692Inst : IEnumerable<long>
{
public static readonly long[] Value=A141692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141692.Bytes);
public long this[int i]=>Value[i];

public static A141692Inst Instance=new A141692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141693
{
public static readonly long[] Value={ 0L,-1L,1L,-2L,0L,2L,-3L,-4L,1L,3L,-4L,-22L,0L,2L,4L,-5L,-78L,-66L,26L,3L,5L,-6L,-228L,-604L,0L,114L,4L,6L,-7L,-600L,-3573L,-2416L,1191L,360L,5L,7L,-8L,-1482L,-17172L,-31238L,0L,8586L,988L,6L,8L,-9L,-3514L,-73040L,-264702L,-156190L,88234L,43824L,2510L,7L,9L,-10L,-8104L,-287040L,-1820768L,-2620708L,0L,910384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141693Inst : IEnumerable<long>
{
public static readonly long[] Value=A141693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141693.Bytes);
public long this[int i]=>Value[i];

public static A141693Inst Instance=new A141693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141694
{
public static readonly long[] Value={ 12L,34L,56L,78L,100L,122L,144L,166L,188L,210L,232L,254L,276L,298L,320L,342L,364L,386L,408L,430L,452L,474L,496L,518L,540L,562L,584L,606L,628L,650L,672L,694L,716L,738L,760L,782L,804L,826L,848L,870L,892L,914L,936L,958L,980L,1002L,1024L,1046L,1068L,1090L,1112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141694Inst : IEnumerable<long>
{
public static readonly long[] Value=A141694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141694.Bytes);
public long this[int i]=>Value[i];

public static A141694Inst Instance=new A141694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141695
{
public static readonly long[] Value={ 0L,3L,-3L,3L,5L,-8L,3L,5L,7L,-15L,3L,5L,7L,9L,-24L,3L,5L,7L,9L,11L,-35L,3L,5L,7L,9L,11L,13L,-48L,3L,5L,7L,9L,11L,13L,15L,-63L,3L,5L,7L,9L,11L,13L,15L,17L,-80L,3L,5L,7L,9L,11L,13L,15L,17L,19L,-99L,3L,5L,7L,9L,11L,13L,15L,17L,19L,21L,-120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141695Inst : IEnumerable<long>
{
public static readonly long[] Value=A141695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141695.Bytes);
public long this[int i]=>Value[i];

public static A141695Inst Instance=new A141695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141696
{
public static readonly long[] Value={ 1L,1L,1L,1L,8L,1L,1L,27L,27L,1L,1L,70L,186L,70L,1L,1L,161L,886L,886L,161L,1L,1L,348L,3543L,7208L,3543L,348L,1L,1L,727L,12837L,46787L,46787L,12837L,727L,1L,1L,1490L,43768L,264590L,468430L,264590L,43768L,1490L,1L,1L,3021L,143448L,1365408L,3930810L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141696Inst : IEnumerable<long>
{
public static readonly long[] Value=A141696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141696.Bytes);
public long this[int i]=>Value[i];

public static A141696Inst Instance=new A141696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141697
{
public static readonly long[] Value={ 1L,1L,1L,1L,16L,1L,1L,59L,59L,1L,1L,158L,426L,158L,1L,1L,369L,2054L,2054L,369L,1L,1L,804L,8247L,16792L,8247L,804L,1L,1L,1687L,29925L,109123L,109123L,29925L,1687L,1L,1L,3466L,102088L,617302L,1092910L,617302L,102088L,3466L,1L,1L,7037L,334664L,3185840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141697Inst : IEnumerable<long>
{
public static readonly long[] Value=A141697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141697.Bytes);
public long this[int i]=>Value[i];

public static A141697Inst Instance=new A141697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141698
{
public static readonly long[] Value={ 6L,12L,15L,18L,21L,24L,30L,33L,35L,36L,42L,45L,48L,54L,57L,60L,63L,65L,66L,72L,75L,77L,84L,90L,96L,99L,105L,108L,114L,120L,126L,132L,135L,143L,144L,147L,150L,161L,162L,168L,171L,175L,180L,185L,189L,192L,195L,198L,201L,209L,210L,216L,221L,225L,228L,231L,240L,245L,252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141698Inst : IEnumerable<long>
{
public static readonly long[] Value=A141698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141698.Bytes);
public long this[int i]=>Value[i];

public static A141698Inst Instance=new A141698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141699
{
public static readonly long[] Value={ 34L,39L,46L,51L,55L,68L,69L,74L,82L,85L,87L,91L,92L,93L,94L,95L,106L,111L,115L,117L,118L,119L,123L,129L,133L,134L,136L,141L,142L,145L,148L,153L,155L,158L,159L,164L,177L,178L,183L,184L,187L,188L,194L,202L,203L,205L,207L,212L,213L,214L,215L,217L,219L,226L,235L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141699Inst : IEnumerable<long>
{
public static readonly long[] Value=A141699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141699.Bytes);
public long this[int i]=>Value[i];

public static A141699Inst Instance=new A141699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141700
{
public static readonly long[] Value={ 0L,2L,0L,3L,0L,0L,2L,2L,0L,0L,5L,0L,0L,0L,0L,0L,3L,2L,0L,0L,0L,7L,0L,0L,0L,0L,0L,0L,2L,2L,0L,2L,0L,0L,0L,0L,3L,0L,3L,0L,0L,0L,0L,0L,0L,0L,5L,0L,0L,2L,0L,0L,0L,0L,0L,11L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,3L,0L,2L,0L,0L,0L,0L,0L,0L,13L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,7L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141700Inst : IEnumerable<long>
{
public static readonly long[] Value=A141700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141700.Bytes);
public long this[int i]=>Value[i];

public static A141700Inst Instance=new A141700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141701
{
public static readonly long[] Value={ 0L,2L,0L,3L,0L,0L,4L,2L,0L,0L,5L,0L,0L,0L,0L,5L,3L,2L,0L,0L,0L,7L,0L,0L,0L,0L,0L,0L,6L,4L,0L,2L,0L,0L,0L,0L,6L,0L,3L,0L,0L,0L,0L,0L,0L,7L,5L,0L,0L,2L,0L,0L,0L,0L,0L,11L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,7L,5L,4L,3L,0L,2L,0L,0L,0L,0L,0L,0L,13L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,9L,7L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141701Inst : IEnumerable<long>
{
public static readonly long[] Value=A141701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141701.Bytes);
public long this[int i]=>Value[i];

public static A141701Inst Instance=new A141701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141702
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,2L,1L,0L,1L,1L,0L,1L,0L,0L,0L,0L,1L,1L,0L,2L,0L,0L,0L,1L,1L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,2L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,2L,1L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,2L,0L,0L,0L,3L,1L,2L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141702Inst : IEnumerable<long>
{
public static readonly long[] Value=A141702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141702.Bytes);
public long this[int i]=>Value[i];

public static A141702Inst Instance=new A141702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141703
{
public static readonly long[] Value={ 0L,1L,3L,6L,0L,5L,2L,2L,1L,2L,7L,5L,7L,11L,3L,3L,1L,10L,3L,7L,4L,1L,2L,5L,6L,2L,5L,3L,10L,5L,5L,11L,4L,6L,2L,9L,11L,7L,2L,3L,4L,11L,6L,10L,0L,7L,17L,5L,4L,6L,1L,5L,10L,7L,5L,4L,4L,14L,8L,9L,2L,5L,12L,9L,16L,2L,16L,15L,2L,6L,5L,2L,9L,8L,8L,3L,1L,7L,13L,7L,3L,13L,5L,14L,6L,8L,4L,9L,6L,4L,1L,1L,9L,7L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141703Inst : IEnumerable<long>
{
public static readonly long[] Value=A141703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141703.Bytes);
public long this[int i]=>Value[i];

public static A141703Inst Instance=new A141703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141736
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,1L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141736Inst : IEnumerable<long>
{
public static readonly long[] Value=A141736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141736.Bytes);
public long this[int i]=>Value[i];

public static A141736Inst Instance=new A141736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141737
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,1L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141737Inst : IEnumerable<long>
{
public static readonly long[] Value=A141737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141737.Bytes);
public long this[int i]=>Value[i];

public static A141737Inst Instance=new A141737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141738
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141738Inst : IEnumerable<long>
{
public static readonly long[] Value=A141738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141738.Bytes);
public long this[int i]=>Value[i];

public static A141738Inst Instance=new A141738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141739
{
public static readonly long[] Value={ 1L,3L,5L,8L,14L,18L,23L,31L,39L,47L,55L,65L,74L,86L,98L,113L,131L,145L,161L,177L,193L,209L,227L,243L,260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141739Inst : IEnumerable<long>
{
public static readonly long[] Value=A141739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141739.Bytes);
public long this[int i]=>Value[i];

public static A141739Inst Instance=new A141739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141740
{
public static readonly long[] Value={ 1L,1L,4L,6L,10L,13L,19L,28L,35L,42L,51L,59L,70L,78L,91L,107L,125L,139L,153L,167L,189L,209L,229L,254L,276L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141740Inst : IEnumerable<long>
{
public static readonly long[] Value=A141740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141740.Bytes);
public long this[int i]=>Value[i];

public static A141740Inst Instance=new A141740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141741
{
public static readonly long[] Value={ 35L,41L,45L,70L,71L,78L,82L,83L,90L,91L,94L,110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141741Inst : IEnumerable<long>
{
public static readonly long[] Value=A141741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141741.Bytes);
public long this[int i]=>Value[i];

public static A141741Inst Instance=new A141741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141742
{
public static readonly long[] Value={ 3L,6L,7L,12L,13L,14L,15L,24L,25L,26L,27L,28L,29L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141742Inst : IEnumerable<long>
{
public static readonly long[] Value=A141742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141742.Bytes);
public long this[int i]=>Value[i];

public static A141742Inst Instance=new A141742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141743
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141743Inst : IEnumerable<long>
{
public static readonly long[] Value=A141743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141743.Bytes);
public long this[int i]=>Value[i];

public static A141743Inst Instance=new A141743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141744
{
public static readonly long[] Value={ 0L,2L,3L,3L,2L,3L,5L,7L,7L,9L,13L,10L,10L,14L,11L,17L,10L,16L,20L,18L,16L,20L,20L,21L,23L,25L,26L,26L,25L,26L,26L,34L,28L,40L,36L,30L,36L,38L,36L,42L,38L,40L,44L,40L,36L,44L,46L,51L,37L,45L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141744Inst : IEnumerable<long>
{
public static readonly long[] Value=A141744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141744.Bytes);
public long this[int i]=>Value[i];

public static A141744Inst Instance=new A141744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141745
{
public static readonly long[] Value={ 1L,1L,2L,4L,7L,8L,8L,8L,10L,10L,8L,13L,15L,13L,18L,14L,23L,19L,17L,21L,25L,23L,25L,26L,26L,26L,27L,29L,32L,33L,35L,29L,37L,27L,33L,41L,37L,37L,41L,37L,43L,43L,41L,47L,53L,47L,47L,44L,60L,54L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141745Inst : IEnumerable<long>
{
public static readonly long[] Value=A141745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141745.Bytes);
public long this[int i]=>Value[i];

public static A141745Inst Instance=new A141745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141746
{
public static readonly long[] Value={ 0L,5L,7L,76L,18L,1281L,1872L,19850L,5518L,334438L,470902L,4989654L,1187177L,83965631L,122705027L,1300996004L,361349378L,21919223969L,30854252783L,327011301795L,77754211611L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141746Inst : IEnumerable<long>
{
public static readonly long[] Value=A141746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141746.Bytes);
public long this[int i]=>Value[i];

public static A141746Inst Instance=new A141746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141747
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,0L,1L,0L,1L,1L,2L,0L,1L,0L,0L,0L,2L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,2L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141747Inst : IEnumerable<long>
{
public static readonly long[] Value=A141747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141747.Bytes);
public long this[int i]=>Value[i];

public static A141747Inst Instance=new A141747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141748
{
public static readonly long[] Value={ 2L,3L,4L,7L,9L,10L,13L,19L,25L,28L,29L,31L,33L,41L,43L,59L,65L,67L,73L,82L,83L,85L,89L,91L,97L,113L,129L,131L,137L,145L,155L,209L,244L,245L,247L,251L,257L,265L,275L,283L,307L,337L,371L,499L,513L,515L,521L,539L,593L,730L,731L,733L,737L,745L,755L,761L,793L,857L,985L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141748Inst : IEnumerable<long>
{
public static readonly long[] Value=A141748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141748.Bytes);
public long this[int i]=>Value[i];

public static A141748Inst Instance=new A141748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141749
{
public static readonly long[] Value={ 1L,1L,9L,1L,7L,2L,1L,0L,2L,9L,1L,0L,8L,10L,2L,1L,0L,0L,10L,0L,9L,1L,0L,3L,4L,6L,7L,2L,1L,0L,0L,0L,0L,0L,4L,9L,1L,0L,0L,0L,7L,7L,1L,7L,2L,1L,0L,0L,0L,0L,0L,0L,9L,8L,9L,1L,0L,0L,0L,0L,7L,8L,10L,6L,6L,2L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,10L,9L,1L,0L,0L,0L,1L,1L,4L,2L,5L,5L,6L,5L,2L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141749Inst : IEnumerable<long>
{
public static readonly long[] Value=A141749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141749.Bytes);
public long this[int i]=>Value[i];

public static A141749Inst Instance=new A141749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141750
{
public static readonly long[] Value={ 2L,3L,19L,23L,37L,41L,61L,67L,71L,73L,79L,89L,97L,109L,127L,137L,149L,173L,181L,211L,223L,227L,251L,257L,269L,283L,293L,311L,317L,347L,349L,353L,359L,367L,373L,383L,389L,397L,401L,419L,439L,457L,461L,463L,479L,487L,499L,503L,509L,523L,547L,557L,587L,593L,607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141750Inst : IEnumerable<long>
{
public static readonly long[] Value=A141750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141750.Bytes);
public long this[int i]=>Value[i];

public static A141750Inst Instance=new A141750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141751
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,5L,5L,3L,1L,13L,13L,8L,4L,1L,34L,34L,21L,11L,5L,1L,89L,89L,55L,29L,14L,6L,1L,233L,233L,144L,76L,37L,17L,7L,1L,610L,610L,377L,199L,97L,45L,20L,8L,1L,1597L,1597L,987L,521L,254L,118L,53L,23L,9L,1L,4181L,4181L,2584L,1364L,665L,309L,139L,61L,26L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141751Inst : IEnumerable<long>
{
public static readonly long[] Value=A141751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141751.Bytes);
public long this[int i]=>Value[i];

public static A141751Inst Instance=new A141751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141816
{
public static readonly long[] Value={ 160225L,160225L,456025L,456025L,801125L,801125L,801125L,801125L,1185665L,1185665L,1185665L,2280125L,4032145L,2280125L,4032145L,4005625L,6326125L,6456125L,6569225L,5226065L,4032145L,4005625L,4005625L,5928325L,6326125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141816Inst : IEnumerable<long>
{
public static readonly long[] Value=A141816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141816.Bytes);
public long this[int i]=>Value[i];

public static A141816Inst Instance=new A141816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141817
{
public static readonly long[] Value={ 64L,81L,121L,324L,361L,441L,484L,529L,625L,676L,729L,784L,841L,961L,1521L,1681L,2116L,2401L,2601L,2916L,3025L,3136L,3249L,3364L,3481L,3721L,4225L,4356L,4624L,4761L,5041L,5184L,5329L,5476L,5625L,5929L,6084L,6241L,6400L,6561L,6724L,7056L,7225L,7396L,7569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141817Inst : IEnumerable<long>
{
public static readonly long[] Value=A141817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141817.Bytes);
public long this[int i]=>Value[i];

public static A141817Inst Instance=new A141817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141818
{
public static readonly long[] Value={ 23L,31L,41L,43L,53L,61L,67L,71L,73L,83L,89L,97L,101L,131L,151L,181L,191L,211L,223L,241L,251L,263L,271L,281L,311L,313L,317L,331L,353L,401L,419L,421L,431L,433L,461L,463L,491L,503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141818Inst : IEnumerable<long>
{
public static readonly long[] Value=A141818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141818.Bytes);
public long this[int i]=>Value[i];

public static A141818Inst Instance=new A141818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141819
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,9L,11L,13L,14L,15L,16L,17L,19L,20L,21L,23L,25L,27L,28L,29L,31L,33L,34L,35L,37L,38L,39L,41L,42L,43L,45L,47L,49L,51L,52L,53L,55L,57L,58L,59L,61L,62L,63L,65L,66L,67L,68L,70L,71L,73L,75L,77L,78L,79L,81L,83L,84L,85L,86L,87L,89L,90L,91L,93L,94L,95L,97L,98L,99L,101L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141819Inst : IEnumerable<long>
{
public static readonly long[] Value=A141819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141819.Bytes);
public long this[int i]=>Value[i];

public static A141819Inst Instance=new A141819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141820
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,9L,10L,12L,14L,15L,16L,18L,21L,24L,25L,26L,28L,30L,32L,33L,36L,40L,42L,45L,48L,52L,54L,56L,60L,65L,66L,68L,70L,72L,74L,75L,78L,80L,82L,84L,87L,88L,90L,92L,96L,100L,102L,105L,108L,112L,114L,116L,120L,125L,126L,128L,132L,135L,136L,140L,145L,150L,151L,152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141820Inst : IEnumerable<long>
{
public static readonly long[] Value=A141820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141820.Bytes);
public long this[int i]=>Value[i];

public static A141820Inst Instance=new A141820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141821
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,5L,3L,7L,3L,8L,5L,5L,11L,4L,7L,12L,13L,7L,9L,8L,17L,7L,7L,7L,19L,19L,23L,12L,11L,12L,25L,10L,13L,27L,11L,10L,9L,14L,11L,29L,11L,31L,31L,19L,17L,34L,37L,18L,19L,40L,41L,14L,17L,21L,15L,16L,17L,18L,47L,17L,23L,46L,45L,46L,25L,49L,49L,50L,29L,26L,19L,27L,31L,29L,55L,34L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141821Inst : IEnumerable<long>
{
public static readonly long[] Value=A141821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141821.Bytes);
public long this[int i]=>Value[i];

public static A141821Inst Instance=new A141821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141822
{
public static readonly long[] Value={ 2L,2L,3L,2L,5L,2L,2L,3L,3L,2L,2L,2L,3L,3L,3L,2L,2L,2L,4L,2L,3L,3L,3L,3L,2L,2L,4L,2L,2L,2L,3L,3L,2L,3L,3L,3L,4L,3L,3L,2L,4L,2L,2L,2L,2L,2L,3L,2L,2L,3L,3L,3L,5L,2L,3L,3L,3L,3L,3L,3L,3L,2L,2L,2L,3L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,3L,3L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,2L,4L,3L,3L,3L,3L,3L,4L,2L,3L,2L,2L,2L,3L,3L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141822Inst : IEnumerable<long>
{
public static readonly long[] Value=A141822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141822.Bytes);
public long this[int i]=>Value[i];

public static A141822Inst Instance=new A141822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141823
{
public static readonly long[] Value={ 20L,28L,38L,42L,90L,96L,156L,164L,216L,228L,252L,318L,336L,350L,384L,386L,442L,508L,558L,770L,876L,922L,978L,1014L,1155L,1170L,1410L,1450L,1692L,1870L,2052L,2370L,3618L,5052L,6234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141823Inst : IEnumerable<long>
{
public static readonly long[] Value=A141823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141823.Bytes);
public long this[int i]=>Value[i];

public static A141823Inst Instance=new A141823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141824
{
public static readonly ulong[] Value={ 1L,2L,4L,9L,24L,75L,269L,1095L,5039L,26084L,150356L,952526L,6553011L,48553418L,385693800L,3277413802L,29741002168L,287555932433L,2952769116993L,32079033571080L,367336668735826L,4419518218479215L,55733223965845539L,735448682261126767L,10142738983005750681UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141824Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A141824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141824.Bytes);
public ulong this[int i]=>Value[i];

public static A141824Inst Instance=new A141824Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141825
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,8L,9L,10L,12L,13L,16L,18L,24L,25L,26L,27L,28L,30L,31L,32L,33L,34L,36L,37L,40L,42L,48L,49L,50L,51L,52L,60L,61L,64L,66L,72L,73L,76L,90L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141825Inst : IEnumerable<long>
{
public static readonly long[] Value=A141825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141825.Bytes);
public long this[int i]=>Value[i];

public static A141825Inst Instance=new A141825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141826
{
public static readonly long[] Value={ 0L,4L,3L,12L,16L,19L,20L,7L,8L,15L,11L,23L,77L,73L,74L,85L,86L,78L,82L,90L,94L,89L,93L,81L,63L,60L,64L,71L,67L,51L,48L,56L,59L,68L,55L,52L,108L,112L,111L,104L,107L,119L,115L,99L,96L,103L,100L,116L,46L,45L,42L,29L,25L,34L,33L,41L,37L,26L,38L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141826Inst : IEnumerable<long>
{
public static readonly long[] Value=A141826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141826.Bytes);
public long this[int i]=>Value[i];

public static A141826Inst Instance=new A141826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141827
{
public static readonly BigInteger[] Value={ 1L,4L,31L,418L,8917L,278656L,12037939L,688168846L,50334635593L,4586743668412L,509638185379111L,67832842473959674L,10655922890454756061UL,BigInteger.Parse("1950921882527424922168"),BigInteger.Parse("411794588127327229725307") };
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
public class A141827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141827Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A141827.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A141827.Bytes);
public BigInteger this[int i]=>Value[i];

public static A141827Inst Instance=new A141827Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141828
{
public static readonly BigInteger[] Value={ 1L,5L,79L,3199L,272981L,42653281L,11055730435L,4424134795739L,2588750874763849L,2123099311165701661L,BigInteger.Parse("2358999234628557401111"),BigInteger.Parse("3453810779419670890966615"),BigInteger.Parse("6510747302004208690462157149"),BigInteger.Parse("15496121141045183700690805861049") };
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
public class A141828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141828Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A141828.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A141828.Bytes);
public BigInteger this[int i]=>Value[i];

public static A141828Inst Instance=new A141828Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141829
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,4L,2L,3L,2L,2L,5L,4L,2L,3L,2L,3L,2L,6L,3L,2L,5L,3L,2L,4L,4L,2L,3L,2L,4L,6L,3L,3L,2L,4L,2L,5L,5L,3L,2L,3L,2L,8L,2L,4L,2L,6L,7L,3L,2L,4L,3L,2L,8L,3L,3L,2L,2L,5L,4L,2L,4L,3L,3L,2L,4L,3L,5L,7L,2L,4L,3L,2L,4L,5L,3L,2L,3L,4L,5L,6L,2L,8L,2L,5L,3L,2L,5L,4L,2L,3L,2L,2L,3L,4L,3L,2L,3L,2L,6L,6L,5L,3L,2L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141829Inst : IEnumerable<long>
{
public static readonly long[] Value=A141829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141829.Bytes);
public long this[int i]=>Value[i];

public static A141829Inst Instance=new A141829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141830
{
public static readonly long[] Value={ 2L,3L,5L,11L,13L,17L,29L,37L,41L,59L,61L,71L,97L,101L,107L,109L,137L,149L,179L,191L,193L,197L,227L,229L,239L,269L,277L,281L,311L,313L,347L,349L,397L,419L,431L,457L,461L,521L,541L,569L,599L,601L,613L,617L,641L,659L,673L,757L,769L,809L,821L,827L,853L,857L,877L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141830Inst : IEnumerable<long>
{
public static readonly long[] Value=A141830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141830.Bytes);
public long this[int i]=>Value[i];

public static A141830Inst Instance=new A141830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141831
{
public static readonly long[] Value={ 7L,19L,23L,31L,43L,47L,53L,67L,73L,79L,83L,89L,103L,113L,127L,131L,139L,151L,157L,163L,167L,173L,181L,199L,211L,223L,233L,241L,251L,257L,263L,271L,283L,293L,307L,317L,331L,337L,353L,359L,367L,373L,379L,383L,389L,401L,409L,421L,433L,439L,443L,449L,463L,467L,479L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141831Inst : IEnumerable<long>
{
public static readonly long[] Value=A141831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141831.Bytes);
public long this[int i]=>Value[i];

public static A141831Inst Instance=new A141831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141960
{
public static readonly long[] Value={ 19L,73L,127L,181L,397L,613L,829L,883L,937L,991L,1153L,1423L,1531L,1693L,1747L,1801L,2017L,2179L,2287L,2341L,2503L,2557L,2719L,3259L,3313L,3529L,3583L,3637L,3691L,3853L,3907L,4177L,4231L,4339L,4447L,4663L,4933L,4987L,5419L,5527L,5581L,5689L,5743L,5851L,6067L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141960Inst : IEnumerable<long>
{
public static readonly long[] Value=A141960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141960.Bytes);
public long this[int i]=>Value[i];

public static A141960Inst Instance=new A141960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141961
{
public static readonly long[] Value={ 47L,101L,263L,317L,479L,587L,641L,857L,911L,1019L,1181L,1289L,1451L,1559L,1613L,1667L,1721L,2099L,2153L,2207L,2423L,2477L,2531L,2693L,2801L,2909L,2963L,3449L,3557L,3719L,3881L,3989L,4259L,4421L,4583L,4637L,4691L,4799L,5231L,5393L,5501L,5717L,5879L,5987L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141961Inst : IEnumerable<long>
{
public static readonly long[] Value=A141961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141961.Bytes);
public long this[int i]=>Value[i];

public static A141961Inst Instance=new A141961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141962
{
public static readonly long[] Value={ 103L,157L,211L,373L,643L,751L,859L,967L,1021L,1129L,1237L,1291L,1399L,1453L,1669L,1723L,1777L,1831L,1993L,2371L,2749L,2803L,2857L,3019L,3181L,3343L,3559L,3613L,4099L,4153L,4261L,4423L,4639L,4801L,4909L,5179L,5233L,5449L,5503L,5557L,5827L,5881L,6043L,6151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141962Inst : IEnumerable<long>
{
public static readonly long[] Value=A141962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141962.Bytes);
public long this[int i]=>Value[i];

public static A141962Inst Instance=new A141962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141963
{
public static readonly long[] Value={ 23L,131L,239L,293L,347L,401L,509L,563L,617L,887L,941L,1049L,1103L,1319L,1373L,1427L,1481L,1697L,1913L,2129L,2237L,2399L,2777L,2939L,3209L,3371L,3533L,3803L,3911L,4019L,4073L,4127L,4289L,4397L,4451L,4721L,4937L,5099L,5153L,5261L,5477L,5531L,5639L,5693L,5801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141963Inst : IEnumerable<long>
{
public static readonly long[] Value=A141963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141963.Bytes);
public long this[int i]=>Value[i];

public static A141963Inst Instance=new A141963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141964
{
public static readonly long[] Value={ 79L,241L,349L,457L,619L,673L,727L,997L,1051L,1213L,1321L,1429L,1483L,1699L,1753L,1861L,2131L,2239L,2293L,2347L,2617L,2671L,2833L,2887L,3049L,3319L,3373L,3643L,3697L,3967L,4021L,4129L,4507L,4561L,4723L,4831L,4993L,5101L,5209L,5479L,5641L,5749L,5857L,6073L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141964Inst : IEnumerable<long>
{
public static readonly long[] Value=A141964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141964.Bytes);
public long this[int i]=>Value[i];

public static A141964Inst Instance=new A141964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141965
{
public static readonly long[] Value={ 53L,107L,269L,431L,593L,647L,701L,809L,863L,971L,1187L,1511L,1619L,1889L,1997L,2213L,2267L,2591L,2699L,2753L,2861L,2969L,3023L,3347L,3617L,3671L,3779L,3833L,4049L,4157L,4211L,4373L,4481L,4643L,4751L,4967L,5021L,5237L,5399L,5507L,5669L,5939L,6047L,6101L,6263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141965Inst : IEnumerable<long>
{
public static readonly long[] Value=A141965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141965.Bytes);
public long this[int i]=>Value[i];

public static A141965Inst Instance=new A141965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141966
{
public static readonly long[] Value={ 3L,31L,59L,199L,227L,283L,311L,367L,479L,563L,619L,647L,787L,983L,1039L,1123L,1151L,1291L,1319L,1459L,1487L,1543L,1571L,1627L,1823L,1879L,1907L,2131L,2243L,2383L,2411L,2467L,2551L,2579L,2663L,2719L,2803L,2887L,2971L,2999L,3083L,3167L,3251L,3307L,3391L,3559L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141966Inst : IEnumerable<long>
{
public static readonly long[] Value=A141966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141966.Bytes);
public long this[int i]=>Value[i];

public static A141966Inst Instance=new A141966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141967
{
public static readonly long[] Value={ 5L,61L,89L,173L,229L,257L,313L,397L,509L,593L,677L,733L,761L,929L,1013L,1069L,1097L,1153L,1181L,1237L,1321L,1433L,1489L,1601L,1657L,1741L,1993L,2161L,2273L,2357L,2441L,2609L,2693L,2749L,2777L,2833L,2861L,2917L,3001L,3169L,3253L,3449L,3533L,3617L,3673L,3701L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141967Inst : IEnumerable<long>
{
public static readonly long[] Value=A141967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141967.Bytes);
public long this[int i]=>Value[i];

public static A141967Inst Instance=new A141967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141968
{
public static readonly long[] Value={ 37L,149L,233L,317L,373L,401L,457L,541L,569L,653L,709L,821L,877L,1129L,1213L,1297L,1381L,1409L,1493L,1549L,1801L,1913L,1997L,2053L,2081L,2137L,2221L,2333L,2389L,2417L,2473L,2557L,2753L,2837L,3061L,3089L,3229L,3257L,3313L,3593L,3677L,3733L,3761L,3929L,4013L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141968Inst : IEnumerable<long>
{
public static readonly long[] Value=A141968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141968.Bytes);
public long this[int i]=>Value[i];

public static A141968Inst Instance=new A141968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141969
{
public static readonly long[] Value={ 11L,67L,151L,179L,263L,347L,431L,487L,571L,599L,683L,739L,823L,907L,991L,1019L,1103L,1187L,1327L,1439L,1523L,1579L,1607L,1663L,1747L,1831L,1999L,2027L,2083L,2111L,2251L,2447L,2503L,2531L,2671L,2699L,3119L,3203L,3259L,3343L,3371L,3511L,3539L,3623L,3847L,3931L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141969Inst : IEnumerable<long>
{
public static readonly long[] Value=A141969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141969.Bytes);
public long this[int i]=>Value[i];

public static A141969Inst Instance=new A141969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141970
{
public static readonly long[] Value={ 13L,41L,97L,181L,293L,349L,433L,461L,601L,769L,797L,853L,881L,937L,1021L,1049L,1217L,1301L,1553L,1609L,1637L,1693L,1721L,1777L,1861L,1889L,1973L,2029L,2113L,2141L,2281L,2309L,2393L,2477L,2617L,2729L,2897L,2953L,3037L,3121L,3373L,3457L,3541L,3709L,3793L,3821L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141970Inst : IEnumerable<long>
{
public static readonly long[] Value=A141970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141970.Bytes);
public long this[int i]=>Value[i];

public static A141970Inst Instance=new A141970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141971
{
public static readonly long[] Value={ 43L,71L,127L,211L,239L,379L,463L,491L,547L,631L,659L,743L,827L,883L,911L,967L,1051L,1163L,1303L,1471L,1499L,1583L,1667L,1723L,2003L,2087L,2143L,2311L,2339L,2423L,2591L,2647L,2731L,2843L,2927L,3011L,3067L,3319L,3347L,3571L,3739L,3767L,3823L,3851L,3907L,4019L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141971Inst : IEnumerable<long>
{
public static readonly long[] Value=A141971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141971.Bytes);
public long this[int i]=>Value[i];

public static A141971Inst Instance=new A141971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141972
{
public static readonly long[] Value={ 17L,73L,101L,157L,241L,269L,353L,409L,521L,577L,661L,773L,829L,857L,941L,997L,1109L,1193L,1249L,1277L,1361L,1613L,1669L,1697L,1753L,1949L,2089L,2341L,2593L,2621L,2677L,2789L,2957L,3041L,3181L,3209L,3433L,3461L,3517L,3769L,3797L,3853L,3881L,4021L,4049L,4133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141972Inst : IEnumerable<long>
{
public static readonly long[] Value=A141972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141972.Bytes);
public long this[int i]=>Value[i];

public static A141972Inst Instance=new A141972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141973
{
public static readonly long[] Value={ 19L,47L,103L,131L,271L,383L,439L,467L,523L,607L,691L,719L,859L,887L,971L,1223L,1279L,1307L,1447L,1531L,1559L,1699L,1783L,1811L,1867L,1951L,1979L,2063L,2203L,2287L,2371L,2399L,2539L,2707L,2791L,2819L,2903L,3323L,3407L,3463L,3491L,3547L,3631L,3659L,3911L,3967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141973Inst : IEnumerable<long>
{
public static readonly long[] Value=A141973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141973.Bytes);
public long this[int i]=>Value[i];

public static A141973Inst Instance=new A141973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141974
{
public static readonly long[] Value={ 23L,79L,107L,163L,191L,331L,359L,443L,499L,751L,863L,919L,947L,1031L,1087L,1171L,1283L,1367L,1423L,1451L,1619L,1759L,1787L,1871L,2011L,2039L,2179L,2207L,2347L,2459L,2543L,2683L,2711L,2767L,2851L,2879L,2963L,3019L,3187L,3271L,3299L,3467L,3607L,3691L,3719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141974Inst : IEnumerable<long>
{
public static readonly long[] Value=A141974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141974.Bytes);
public long this[int i]=>Value[i];

public static A141974Inst Instance=new A141974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141975
{
public static readonly long[] Value={ 53L,109L,137L,193L,277L,389L,557L,613L,641L,809L,977L,1033L,1061L,1117L,1201L,1229L,1453L,1481L,1621L,1733L,1789L,1873L,1901L,2069L,2153L,2237L,2293L,2377L,2657L,2713L,2741L,2797L,2909L,3049L,3217L,3301L,3329L,3413L,3469L,3581L,3637L,3833L,3889L,3917L,4001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141975Inst : IEnumerable<long>
{
public static readonly long[] Value=A141975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141975.Bytes);
public long this[int i]=>Value[i];

public static A141975Inst Instance=new A141975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142008
{
public static readonly long[] Value={ 97L,283L,593L,1151L,1213L,1399L,1523L,1709L,2081L,2143L,2267L,2887L,3011L,3259L,3631L,4003L,4127L,4561L,4871L,4933L,5119L,5801L,5987L,6173L,6359L,6421L,6607L,6793L,6917L,7103L,7351L,7537L,7723L,8219L,8467L,8839L,8963L,9397L,9521L,9769L,10079L,10141L,10513L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142008Inst : IEnumerable<long>
{
public static readonly long[] Value=A142008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142008.Bytes);
public long this[int i]=>Value[i];

public static A142008Inst Instance=new A142008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142009
{
public static readonly long[] Value={ 5L,67L,191L,439L,563L,811L,997L,1307L,1493L,1741L,2113L,2237L,2423L,2609L,2671L,2857L,3167L,3229L,3539L,3911L,4159L,4283L,4903L,5399L,5647L,6143L,6329L,6577L,6701L,6763L,6949L,7321L,7507L,7817L,7879L,8623L,8747L,8933L,9181L,9491L,9677L,9739L,10111L,10607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142009Inst : IEnumerable<long>
{
public static readonly long[] Value=A142009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142009.Bytes);
public long this[int i]=>Value[i];

public static A142009Inst Instance=new A142009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142010
{
public static readonly long[] Value={ 37L,223L,347L,409L,719L,967L,1091L,1153L,1277L,2083L,2207L,2269L,2393L,2579L,3137L,3323L,3571L,3881L,3943L,4129L,4253L,5059L,5431L,5741L,5927L,6113L,6299L,6361L,6547L,6733L,6857L,7043L,7229L,7477L,8221L,8779L,9151L,9337L,9461L,9833L,10267L,10391L,10453L,10639L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142010Inst : IEnumerable<long>
{
public static readonly long[] Value=A142010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142010.Bytes);
public long this[int i]=>Value[i];

public static A142010Inst Instance=new A142010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142011
{
public static readonly long[] Value={ 7L,131L,193L,317L,379L,503L,751L,937L,1061L,1123L,1433L,1619L,1867L,2053L,2239L,2549L,2797L,3169L,3541L,3727L,3851L,4099L,4409L,4657L,4967L,5153L,5711L,5897L,6269L,6703L,6827L,7013L,7757L,8191L,8377L,8501L,8563L,9059L,9431L,9679L,9803L,10733L,11353L,12097L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142011Inst : IEnumerable<long>
{
public static readonly long[] Value=A142011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142011.Bytes);
public long this[int i]=>Value[i];

public static A142011Inst Instance=new A142011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142012
{
public static readonly long[] Value={ 101L,163L,349L,659L,907L,1031L,1093L,1217L,1279L,2333L,2767L,2953L,3449L,3511L,3697L,3821L,4007L,4441L,4751L,4813L,4937L,4999L,5309L,5557L,5743L,5867L,6053L,6301L,6673L,6983L,7417L,7541L,7603L,7727L,7789L,8161L,8719L,9029L,9091L,9277L,9463L,9587L,9649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142012Inst : IEnumerable<long>
{
public static readonly long[] Value=A142012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142012.Bytes);
public long this[int i]=>Value[i];

public static A142012Inst Instance=new A142012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142013
{
public static readonly long[] Value={ 71L,257L,443L,691L,877L,1063L,1187L,1249L,1373L,1559L,1621L,1931L,1993L,2179L,2551L,2861L,3109L,3853L,4349L,4597L,4721L,4783L,4969L,5279L,5527L,5651L,6271L,6581L,6829L,7573L,7759L,7883L,8069L,8317L,8627L,8689L,8999L,9371L,9433L,9619L,9743L,9929L,10177L,10301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142013Inst : IEnumerable<long>
{
public static readonly long[] Value=A142013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142013.Bytes);
public long this[int i]=>Value[i];

public static A142013Inst Instance=new A142013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142014
{
public static readonly long[] Value={ 41L,103L,227L,599L,661L,971L,1033L,1777L,1901L,2087L,2273L,2459L,2521L,2707L,3079L,3203L,3389L,3637L,3761L,3823L,3947L,4133L,4567L,4691L,4877L,5683L,5807L,5869L,6427L,6551L,6737L,7109L,7481L,7853L,8039L,8101L,8287L,8597L,8783L,8969L,9341L,9403L,10271L,10333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142014Inst : IEnumerable<long>
{
public static readonly long[] Value=A142014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142014.Bytes);
public long this[int i]=>Value[i];

public static A142014Inst Instance=new A142014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142015
{
public static readonly long[] Value={ 11L,73L,197L,383L,569L,631L,941L,1499L,1747L,1871L,1933L,2243L,2677L,2801L,3049L,3359L,3607L,3793L,3917L,4289L,4723L,4909L,5281L,5591L,5653L,5839L,6211L,6397L,6521L,7079L,7451L,7699L,7823L,8009L,8443L,8629L,8753L,9001L,9187L,9311L,9497L,9931L,10303L,10427L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142015Inst : IEnumerable<long>
{
public static readonly long[] Value=A142015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142015.Bytes);
public long this[int i]=>Value[i];

public static A142015Inst Instance=new A142015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142016
{
public static readonly long[] Value={ 43L,167L,229L,353L,601L,787L,911L,1097L,1283L,1531L,2027L,2089L,2213L,2399L,2647L,2833L,2957L,3019L,3329L,3391L,3701L,4073L,4259L,4507L,4817L,5003L,5189L,5437L,5623L,6367L,6491L,6553L,6863L,7297L,7607L,7669L,7793L,8537L,8599L,8971L,9157L,9281L,9343L,9467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142016Inst : IEnumerable<long>
{
public static readonly long[] Value=A142016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142016.Bytes);
public long this[int i]=>Value[i];

public static A142016Inst Instance=new A142016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142017
{
public static readonly long[] Value={ 13L,137L,199L,509L,571L,757L,881L,1129L,1439L,1811L,1873L,1997L,2617L,2741L,2803L,2927L,3299L,3361L,3547L,3671L,3733L,3919L,4229L,4663L,4787L,4973L,5407L,5531L,5717L,5779L,5903L,6089L,6151L,6337L,6709L,6833L,7019L,7577L,7639L,7949L,8011L,8693L,8941L,9127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142017Inst : IEnumerable<long>
{
public static readonly long[] Value=A142017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142017.Bytes);
public long this[int i]=>Value[i];

public static A142017Inst Instance=new A142017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142018
{
public static readonly long[] Value={ 107L,293L,479L,541L,727L,1223L,1409L,1471L,1657L,2029L,2153L,2339L,2711L,2897L,3083L,3331L,3517L,3889L,4013L,4261L,4447L,4943L,5501L,5563L,5749L,6121L,6679L,6803L,7237L,7547L,7919L,8167L,8291L,8353L,8539L,8663L,8849L,9221L,9283L,10151L,10337L,10399L,10709L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142018Inst : IEnumerable<long>
{
public static readonly long[] Value=A142018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142018.Bytes);
public long this[int i]=>Value[i];

public static A142018Inst Instance=new A142018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142019
{
public static readonly long[] Value={ 139L,263L,449L,821L,883L,1069L,1193L,1627L,1999L,2309L,2371L,2557L,3301L,3673L,3797L,4231L,4603L,4789L,5099L,5347L,5471L,5657L,5843L,6029L,6091L,6277L,6959L,7207L,7331L,7393L,7517L,7703L,7951L,8447L,8819L,9067L,9377L,9439L,9749L,9811L,10369L,11113L,11299L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142019Inst : IEnumerable<long>
{
public static readonly long[] Value=A142019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142019.Bytes);
public long this[int i]=>Value[i];

public static A142019Inst Instance=new A142019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142020
{
public static readonly long[] Value={ 47L,109L,233L,419L,853L,977L,1039L,1163L,1597L,1721L,1783L,1907L,2341L,2713L,2837L,3023L,3209L,3271L,3457L,3581L,3643L,3767L,4139L,4201L,4759L,5441L,5503L,5689L,5813L,6247L,6619L,6991L,7177L,7487L,7549L,7673L,8231L,8293L,9161L,9533L,9719L,9781L,9967L,10091L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142020Inst : IEnumerable<long>
{
public static readonly long[] Value=A142020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142020.Bytes);
public long this[int i]=>Value[i];

public static A142020Inst Instance=new A142020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142021
{
public static readonly long[] Value={ 17L,79L,389L,761L,823L,947L,1009L,1319L,1381L,1567L,1753L,1877L,2063L,2311L,2621L,2683L,3613L,3923L,4357L,4481L,4729L,5039L,5101L,5659L,5783L,6217L,6899L,6961L,7333L,7457L,7643L,7829L,8263L,8387L,8573L,8821L,9007L,9689L,10061L,10247L,10433L,10867L,11177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142021Inst : IEnumerable<long>
{
public static readonly long[] Value=A142021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142021.Bytes);
public long this[int i]=>Value[i];

public static A142021Inst Instance=new A142021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142022
{
public static readonly long[] Value={ 173L,359L,421L,607L,1103L,1289L,1723L,1847L,2281L,2467L,2591L,2777L,2963L,3583L,3769L,4079L,4327L,4451L,4513L,4637L,5009L,5381L,5443L,5939L,6311L,6373L,6869L,7489L,8171L,8233L,8419L,8543L,9349L,9473L,9721L,9907L,10093L,10589L,10651L,10837L,11519L,11953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142022Inst : IEnumerable<long>
{
public static readonly long[] Value=A142022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142022.Bytes);
public long this[int i]=>Value[i];

public static A142022Inst Instance=new A142022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142023
{
public static readonly long[] Value={ 19L,577L,701L,887L,1259L,1321L,1693L,1879L,2003L,2251L,2437L,3119L,3181L,3491L,3677L,3739L,3863L,4049L,4111L,4297L,4421L,4483L,4793L,5227L,5351L,5413L,6343L,6529L,6653L,7211L,7459L,7583L,8017L,8389L,8513L,8699L,8761L,9133L,9257L,9319L,9629L,10559L,10993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142023Inst : IEnumerable<long>
{
public static readonly long[] Value=A142023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142023.Bytes);
public long this[int i]=>Value[i];

public static A142023Inst Instance=new A142023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142072
{
public static readonly long[] Value={ 19L,53L,223L,257L,359L,461L,563L,631L,733L,937L,971L,1039L,1277L,1447L,1481L,1549L,1583L,1753L,1787L,1889L,2161L,2297L,2399L,2467L,2671L,2909L,3011L,3079L,3181L,3623L,3691L,3793L,3929L,4099L,4133L,4201L,4337L,4507L,4643L,4813L,5051L,5119L,5153L,5323L,5527L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142072Inst : IEnumerable<long>
{
public static readonly long[] Value=A142072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142072.Bytes);
public long this[int i]=>Value[i];

public static A142072Inst Instance=new A142072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142073
{
public static readonly long[] Value={ 1L,1L,-1L,1L,-1L,1L,1L,-4L,2L,1L,7L,-16L,8L,1L,21L,-28L,-26L,48L,-16L,1L,51L,32L,-356L,408L,-136L,1L,113L,492L,-1774L,1072L,912L,-1088L,272L,1L,239L,2592L,-5008L,-6656L,20736L,-15872L,3968L,1L,493L,10628L,-50L,-94432L,154528L,-57856L,-45056L,39680L,-7936L,1L,1003L,38768L,108820L,-621352L,455608L,848384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142073Inst : IEnumerable<long>
{
public static readonly long[] Value=A142073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142073.Bytes);
public long this[int i]=>Value[i];

public static A142073Inst Instance=new A142073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142074
{
public static readonly long[] Value={ 12L,35L,81L,147L,213L,321L,411L,477L,589L,677L,783L,873L,987L,1113L,1179L,1257L,1447L,1539L,1667L,1797L,1909L,2001L,2127L,2201L,2457L,2523L,2631L,2767L,2899L,2987L,3093L,3237L,3423L,3501L,3717L,3843L,3957L,4109L,4219L,4371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142074Inst : IEnumerable<long>
{
public static readonly long[] Value=A142074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142074.Bytes);
public long this[int i]=>Value[i];

public static A142074Inst Instance=new A142074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142075
{
public static readonly long[] Value={ 1L,1L,2L,1L,8L,4L,1L,22L,44L,8L,1L,52L,264L,208L,16L,1L,114L,1208L,2416L,912L,32L,1L,240L,4764L,19328L,19056L,3840L,64L,1L,494L,17172L,124952L,249904L,137376L,15808L,128L,1L,1004L,58432L,705872L,2499040L,2823488L,934912L,64256L,256L,1L,2026L,191360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142075Inst : IEnumerable<long>
{
public static readonly long[] Value=A142075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142075.Bytes);
public long this[int i]=>Value[i];

public static A142075Inst Instance=new A142075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142076
{
public static readonly long[] Value={ 71L,211L,281L,421L,491L,631L,701L,911L,1051L,1471L,2311L,2381L,2521L,2591L,2731L,2801L,3011L,3221L,3361L,3571L,3851L,4201L,4271L,4481L,4621L,4691L,4831L,5531L,5741L,5881L,6091L,6301L,6581L,6791L,7001L,7211L,7351L,7561L,7841L,8191L,8681L,8821L,9241L,9311L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142076Inst : IEnumerable<long>
{
public static readonly long[] Value=A142076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142076.Bytes);
public long this[int i]=>Value[i];

public static A142076Inst Instance=new A142076Inst();

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