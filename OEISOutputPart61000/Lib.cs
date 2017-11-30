using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A074686
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,7L,4L,5L,6L,22L,21L,17L,18L,20L,10L,9L,11L,12L,13L,14L,15L,16L,19L,64L,63L,58L,59L,62L,46L,45L,48L,49L,50L,54L,55L,57L,61L,27L,26L,23L,24L,25L,29L,28L,30L,31L,32L,33L,34L,35L,36L,38L,37L,39L,40L,41L,42L,43L,44L,47L,51L,52L,53L,56L,60L,196L,195L,189L,190L,194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074686Inst : IEnumerable<long>
{
public static readonly long[] Value=A074686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074686.Bytes);
public long this[int i]=>Value[i];

public static A074686Inst Instance=new A074686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074687
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,7L,8L,4L,5L,15L,14L,16L,17L,18L,19L,20L,22L,13L,9L,21L,10L,11L,12L,39L,40L,41L,37L,38L,43L,42L,44L,45L,46L,47L,48L,49L,50L,52L,51L,53L,54L,55L,60L,61L,62L,34L,33L,63L,36L,27L,23L,56L,57L,64L,35L,24L,58L,26L,32L,29L,59L,25L,28L,30L,31L,113L,112L,114L,115L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074687Inst : IEnumerable<long>
{
public static readonly long[] Value=A074687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074687.Bytes);
public long this[int i]=>Value[i];

public static A074687Inst Instance=new A074687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074688
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,8L,4L,5L,6L,18L,20L,21L,22L,17L,10L,9L,11L,12L,13L,14L,15L,19L,16L,50L,55L,61L,57L,49L,62L,59L,63L,64L,58L,46L,45L,54L,48L,26L,27L,23L,24L,25L,29L,28L,30L,31L,32L,33L,34L,35L,36L,38L,37L,39L,40L,41L,51L,52L,56L,60L,42L,43L,44L,47L,53L,148L,162L,167L,181L,147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074688Inst : IEnumerable<long>
{
public static readonly long[] Value=A074688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074688.Bytes);
public long this[int i]=>Value[i];

public static A074688Inst Instance=new A074688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074689
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,7L,4L,5L,6L,22L,21L,17L,18L,20L,9L,10L,11L,12L,13L,14L,15L,19L,16L,64L,63L,58L,59L,62L,45L,46L,48L,49L,50L,54L,55L,61L,57L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,51L,52L,60L,56L,42L,43L,44L,47L,53L,196L,195L,189L,190L,194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074689Inst : IEnumerable<long>
{
public static readonly long[] Value=A074689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074689.Bytes);
public long this[int i]=>Value[i];

public static A074689Inst Instance=new A074689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074690
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,7L,8L,5L,4L,14L,15L,16L,17L,18L,19L,20L,22L,11L,12L,21L,13L,10L,9L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,60L,61L,62L,28L,29L,63L,30L,31L,32L,56L,57L,64L,33L,34L,59L,36L,25L,26L,58L,35L,27L,24L,23L,107L,108L,109L,110L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074690Inst : IEnumerable<long>
{
public static readonly long[] Value=A074690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074690.Bytes);
public long this[int i]=>Value[i];

public static A074690Inst Instance=new A074690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074691
{
public static readonly long[] Value={ 2L,3L,5L,13L,89L,233L,610L,987L,1597L,10946L,28657L,514229L,3524578L,9227465L,24157817L,39088169L,63245986L,433494437L,701408733L,1134903170L,1836311903L,2971215073L,7778742049L,20365011074L,365435296162L,591286729879L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074691Inst : IEnumerable<long>
{
public static readonly long[] Value=A074691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074691.Bytes);
public long this[int i]=>Value[i];

public static A074691Inst Instance=new A074691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074724
{
public static readonly long[] Value={ 3L,3L,9L,3L,3L,9L,3L,3L,27L,3L,3L,9L,3L,3L,9L,3L,3L,27L,3L,3L,9L,3L,3L,9L,3L,3L,81L,3L,3L,9L,3L,3L,9L,3L,3L,27L,3L,3L,9L,3L,3L,9L,3L,3L,27L,3L,3L,9L,3L,3L,9L,3L,3L,81L,3L,3L,9L,3L,3L,9L,3L,3L,27L,3L,3L,9L,3L,3L,9L,3L,3L,27L,3L,3L,9L,3L,3L,9L,3L,3L,243L,3L,3L,9L,3L,3L,9L,3L,3L,27L,3L,3L,9L,3L,3L,9L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074724Inst : IEnumerable<long>
{
public static readonly long[] Value=A074724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074724.Bytes);
public long this[int i]=>Value[i];

public static A074724Inst Instance=new A074724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074725
{
public static readonly long[] Value={ 1L,2L,4L,5L,11L,13L,14L,17L,22L,23L,25L,26L,29L,31L,34L,38L,41L,43L,46L,47L,53L,59L,61L,62L,67L,71L,73L,74L,82L,83L,86L,89L,94L,101L,103L,106L,107L,109L,113L,118L,121L,122L,125L,127L,131L,134L,137L,142L,146L,149L,151L,155L,158L,163L,166L,167L,173L,175L,179L,181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074725Inst : IEnumerable<long>
{
public static readonly long[] Value=A074725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074725.Bytes);
public long this[int i]=>Value[i];

public static A074725Inst Instance=new A074725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074726
{
public static readonly long[] Value={ 12L,18L,24L,30L,36L,40L,42L,48L,54L,60L,72L,80L,84L,90L,96L,108L,120L,126L,132L,140L,144L,150L,156L,160L,162L,168L,180L,192L,198L,200L,204L,210L,216L,225L,228L,234L,240L,252L,264L,270L,276L,280L,288L,294L,300L,306L,312L,315L,320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074726Inst : IEnumerable<long>
{
public static readonly long[] Value=A074726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074726.Bytes);
public long this[int i]=>Value[i];

public static A074726Inst Instance=new A074726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074727
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,6L,7L,4L,1L,2L,4L,16L,1L,6L,6L,2L,3L,1L,3L,3L,6L,3L,5L,1L,2L,1L,2L,2L,2L,15L,1L,15L,1L,7L,3L,2L,21L,5L,15L,4L,16L,1L,8L,1L,7L,1L,2L,7L,7L,2L,1L,20L,2L,15L,1L,6L,1L,1L,8L,22L,2L,1L,20L,64L,3L,1L,31L,14L,22L,19L,66L,7L,1L,14L,1L,15L,10L,7L,2L,6L,19L,1L,4L,8L,2L,1L,7L,18L,3L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074727Inst : IEnumerable<long>
{
public static readonly long[] Value=A074727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074727.Bytes);
public long this[int i]=>Value[i];

public static A074727Inst Instance=new A074727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074728
{
public static readonly BigInteger[] Value={ 1L,3L,10L,39L,176L,903L,5174L,32623L,223792L,1655463L,13110758L,110510007L,986490272L,9287036671L,91872460702L,952034494431L,10305790066208L,116254839687543L,1363631057783942L,16599343732844455L,209328335818064176L,2730323984395924623L,BigInteger.Parse("36780442970179975646") };
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
public class A074728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074728Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A074728.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A074728.Bytes);
public BigInteger this[int i]=>Value[i];

public static A074728Inst Instance=new A074728Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074729
{
public static readonly long[] Value={ 1L,2L,6L,14L,22L,30L,89L,96L,120L,121L,169L,219L,221L,228L,253L,259L,323L,357L,397L,431L,467L,485L,554L,579L,719L,726L,739L,740L,778L,803L,841L,873L,881L,902L,923L,1004L,1014L,1028L,1262L,1313L,1331L,1527L,1568L,1734L,1790L,1822L,1862L,1903L,1926L,2045L,2063L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074729Inst : IEnumerable<long>
{
public static readonly long[] Value=A074729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074729.Bytes);
public long this[int i]=>Value[i];

public static A074729Inst Instance=new A074729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074730
{
public static readonly long[] Value={ 1L,121L,169L,841L,2047288797225L,61838862885361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074730Inst : IEnumerable<long>
{
public static readonly long[] Value=A074730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074730.Bytes);
public long this[int i]=>Value[i];

public static A074730Inst Instance=new A074730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074731
{
public static readonly long[] Value={ 1L,9L,576L,9025L,39582418599936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074731Inst : IEnumerable<long>
{
public static readonly long[] Value=A074731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074731.Bytes);
public long this[int i]=>Value[i];

public static A074731Inst Instance=new A074731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074732
{
public static readonly long[] Value={ 0L,1L,2L,2L,2L,3L,3L,4L,5L,6L,8L,10L,13L,16L,21L,27L,34L,44L,56L,72L,93L,119L,153L,197L,254L,327L,421L,542L,698L,899L,1158L,1492L,1922L,2477L,3191L,4112L,5298L,6827L,8797L,11335L,14606L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074732Inst : IEnumerable<long>
{
public static readonly long[] Value=A074732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074732.Bytes);
public long this[int i]=>Value[i];

public static A074732Inst Instance=new A074732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074733
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,8L,12L,17L,25L,36L,53L,77L,112L,164L,239L,349L,510L,745L,1089L,1592L,2327L,3401L,4971L,7266L,10621L,15525L,22693L,33171L,48486L,70873L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074733Inst : IEnumerable<long>
{
public static readonly long[] Value=A074733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074733.Bytes);
public long this[int i]=>Value[i];

public static A074733Inst Instance=new A074733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074734
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,1L,2L,0L,0L,3L,3L,3L,0L,0L,3L,8L,6L,4L,0L,0L,6L,13L,16L,10L,5L,0L,0L,6L,22L,33L,28L,15L,6L,0L,0L,10L,31L,60L,67L,45L,21L,7L,0L,0L,10L,48L,97L,136L,120L,68L,28L,8L,0L,0L,15L,62L,158L,244L,271L,198L,98L,36L,9L,0L,0L,15L,86L,234L,424L,535L,492L,308L,136L,45L,10L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074734Inst : IEnumerable<long>
{
public static readonly long[] Value=A074734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074734.Bytes);
public long this[int i]=>Value[i];

public static A074734Inst Instance=new A074734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074735
{
public static readonly long[] Value={ 0L,3L,1L,2L,0L,3L,2L,8L,0L,1L,1L,1L,0L,3L,3L,2L,0L,2L,1L,3L,0L,2L,2L,2L,0L,1L,1L,1L,0L,7L,4L,4L,0L,4L,1L,2L,0L,4L,2L,3L,0L,1L,1L,1L,0L,2L,3L,4L,0L,2L,1L,8L,0L,4L,2L,3L,0L,1L,1L,1L,0L,6L,5L,4L,0L,3L,1L,2L,0L,5L,2L,4L,0L,1L,1L,1L,0L,5L,3L,2L,0L,2L,1L,3L,0L,2L,2L,2L,0L,1L,1L,1L,0L,4L,4L,5L,0L,6L,1L,2L,0L,3L,2L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074735Inst : IEnumerable<long>
{
public static readonly long[] Value=A074735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074735.Bytes);
public long this[int i]=>Value[i];

public static A074735Inst Instance=new A074735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074736
{
public static readonly long[] Value={ 4L,8L,36L,32L,108L,128L,900L,216L,972L,2048L,4500L,8192L,8748L,1944L,44100L,131072L,13500L,524288L,112500L,17496L,708588L,8388608L,308700L,7776L,6377292L,27000L,2812500L,536870912L,337500L,2147483648L,5336100L,1417176L,516560652L,69984L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074736Inst : IEnumerable<long>
{
public static readonly long[] Value=A074736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074736.Bytes);
public long this[int i]=>Value[i];

public static A074736Inst Instance=new A074736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074737
{
public static readonly long[] Value={ 1L,1L,3L,6L,11L,14L,15L,24L,27L,36L,39L,41L,42L,51L,54L,56L,57L,66L,69L,74L,77L,87L,93L,96L,107L,114L,122L,126L,129L,131L,132L,143L,150L,162L,165L,189L,195L,200L,215L,227L,230L,234L,236L,237L,252L,258L,260L,261L,276L,282L,284L,285L,300L,306L,308L,309L,324L,330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074737Inst : IEnumerable<long>
{
public static readonly long[] Value=A074737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074737.Bytes);
public long this[int i]=>Value[i];

public static A074737Inst Instance=new A074737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074738
{
public static readonly long[] Value={ 0L,8L,6L,0L,7L,1L,3L,3L,2L,0L,5L,5L,9L,3L,4L,2L,0L,6L,8L,8L,7L,5L,7L,3L,0L,9L,8L,7L,7L,6L,9L,2L,2L,6L,7L,7L,7L,6L,0L,5L,9L,1L,1L,0L,9L,5L,3L,0L,3L,3L,3L,1L,7L,3L,4L,9L,2L,0L,2L,0L,2L,3L,6L,6L,6L,5L,4L,2L,2L,6L,3L,5L,8L,1L,4L,6L,2L,2L,8L,7L,9L,7L,9L,9L,3L,8L,0L,5L,3L,4L,6L,0L,2L,5L,2L,8L,7L,6L,8L,0L,7L,1L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074738Inst : IEnumerable<long>
{
public static readonly long[] Value=A074738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074738.Bytes);
public long this[int i]=>Value[i];

public static A074738Inst Instance=new A074738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074739
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,18L,20L,21L,22L,24L,26L,28L,30L,33L,34L,35L,36L,38L,39L,40L,42L,44L,45L,46L,48L,50L,51L,52L,54L,55L,56L,57L,58L,60L,62L,63L,65L,66L,68L,69L,70L,72L,74L,75L,76L,77L,78L,80L,82L,84L,85L,86L,87L,88L,90L,91L,92L,93L,94L,95L,96L,98L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074739Inst : IEnumerable<long>
{
public static readonly long[] Value=A074739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074739.Bytes);
public long this[int i]=>Value[i];

public static A074739Inst Instance=new A074739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074756
{
public static readonly long[] Value={ 2L,3L,4L,5L,8L,7L,11L,14L,21L,11L,20L,13L,26L,30L,26L,17L,27L,19L,54L,40L,60L,23L,42L,48L,48L,45L,44L,29L,108L,31L,54L,53L,66L,58L,90L,37L,55L,90L,75L,41L,77L,43L,59L,58L,126L,47L,130L,559L,559L,144L,77L,53L,123L,105L,105L,90L,74L,59L,119L,61L,119L,176L,344L,126L,126L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074756Inst : IEnumerable<long>
{
public static readonly long[] Value=A074756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074756.Bytes);
public long this[int i]=>Value[i];

public static A074756Inst Instance=new A074756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074757
{
public static readonly long[] Value={ 34L,46L,62L,74L,86L,94L,142L,188L,202L,214L,218L,231L,243L,244L,262L,278L,302L,356L,375L,394L,422L,423L,428L,436L,446L,459L,478L,494L,584L,596L,604L,621L,628L,634L,664L,698L,716L,837L,861L,885L,903L,916L,922L,944L,956L,982L,1004L,1017L,1018L,1028L,1042L,1052L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074757Inst : IEnumerable<long>
{
public static readonly long[] Value=A074757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074757.Bytes);
public long this[int i]=>Value[i];

public static A074757Inst Instance=new A074757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074758
{
public static readonly long[] Value={ 2L,6L,8L,6L,0L,9L,1L,7L,0L,9L,6L,1L,2L,8L,3L,2L,7L,9L,1L,1L,1L,6L,4L,7L,8L,7L,4L,8L,7L,2L,4L,8L,7L,1L,1L,4L,4L,5L,0L,7L,2L,6L,9L,6L,2L,5L,8L,1L,1L,7L,7L,6L,9L,2L,1L,5L,8L,4L,4L,5L,1L,3L,1L,5L,4L,9L,5L,5L,4L,7L,2L,8L,2L,8L,5L,7L,3L,3L,9L,6L,9L,8L,4L,2L,6L,0L,8L,8L,8L,6L,3L,6L,1L,3L,7L,7L,5L,5L,2L,6L,9L,1L,6L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074758Inst : IEnumerable<long>
{
public static readonly long[] Value=A074758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074758.Bytes);
public long this[int i]=>Value[i];

public static A074758Inst Instance=new A074758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074759
{
public static readonly BigInteger[] Value={ 1L,1L,2L,3L,16L,25L,396L,721L,11264L,46089L,602200L,3628801L,133494912L,479001601L,7692266960L,95904273375L,1914926104576L,20922789888001L,628693317946656L,6402373705728001L,182635841123840000L,2496321046987530021L,BigInteger.Parse("55826951075231672512"),BigInteger.Parse("1124000727777607680001") };
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
public class A074759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074759Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A074759.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A074759.Bytes);
public BigInteger this[int i]=>Value[i];

public static A074759Inst Instance=new A074759Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074760
{
public static readonly long[] Value={ 0L,2L,3L,0L,9L,5L,7L,0L,8L,9L,6L,6L,1L,2L,1L,0L,3L,3L,8L,1L,4L,3L,1L,0L,2L,4L,7L,9L,0L,6L,4L,9L,5L,2L,9L,1L,6L,2L,1L,9L,3L,2L,1L,2L,7L,1L,5L,2L,0L,5L,0L,7L,5L,9L,5L,2L,5L,3L,9L,2L,0L,7L,2L,2L,1L,2L,9L,7L,1L,3L,5L,6L,4L,7L,6L,7L,2L,4L,5L,7L,9L,9L,7L,0L,7L,9L,8L,5L,6L,9L,5L,1L,1L,7L,0L,9L,8L,3L,3L,3L,6L,4L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074760Inst : IEnumerable<long>
{
public static readonly long[] Value=A074760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074760.Bytes);
public long this[int i]=>Value[i];

public static A074760Inst Instance=new A074760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074761
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,1L,3L,1L,9L,1L,4L,5L,1L,1L,12L,1L,27L,7L,6L,1L,81L,1L,7L,1L,54L,1L,407L,1L,1L,11L,9L,13L,494L,1L,10L,13L,423L,1L,981L,1L,137L,115L,12L,1L,1309L,1L,59L,17L,193L,1L,240L,21L,1207L,19L,15L,1L,47274L,1L,16L,239L,1L,25L,3284L,1L,333L,23L,3731L,1L,42109L,1L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074761Inst : IEnumerable<long>
{
public static readonly long[] Value=A074761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074761.Bytes);
public long this[int i]=>Value[i];

public static A074761Inst Instance=new A074761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074762
{
public static readonly long[] Value={ 633L,634L,635L,636L,637L,638L,639L,877L,878L,879L,880L,881L,882L,883L,884L,1185L,5061L,33459L,438240L,682290L,17263489L,188423892L,991790057L,7231603790L,75314706735L,62651040995719L,296757769625554L,4295141978111813L,14929328605861651L,516659008545595106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074762Inst : IEnumerable<long>
{
public static readonly long[] Value=A074762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074762.Bytes);
public long this[int i]=>Value[i];

public static A074762Inst Instance=new A074762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074763
{
public static readonly long[] Value={ 2L,1L,4L,4L,8L,10L,20L,34L,60L,100L,188L,348L,632L,1162L,2192L,4114L,7712L,14542L,27596L,52480L,99880L,190558L,364724L,699248L,1342184L,2580796L,4971068L,9587560L,18512792L,35790376L,69273668L,134219794L,260301176L,505286416L,981706832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074763Inst : IEnumerable<long>
{
public static readonly long[] Value=A074763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074763.Bytes);
public long this[int i]=>Value[i];

public static A074763Inst Instance=new A074763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074764
{
public static readonly long[] Value={ 1L,4L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074764Inst : IEnumerable<long>
{
public static readonly long[] Value=A074764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074764.Bytes);
public long this[int i]=>Value[i];

public static A074764Inst Instance=new A074764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074765
{
public static readonly long[] Value={ 0L,2L,2L,2L,4L,5L,5L,7L,8L,6L,10L,11L,10L,13L,12L,13L,15L,16L,14L,18L,18L,17L,20L,20L,22L,22L,22L,25L,26L,26L,26L,29L,26L,30L,28L,31L,32L,33L,32L,34L,35L,35L,37L,39L,40L,39L,42L,44L,42L,44L,48L,46L,49L,44L,50L,48L,49L,49L,53L,52L,52L,56L,53L,57L,57L,60L,60L,60L,61L,61L,65L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074765Inst : IEnumerable<long>
{
public static readonly long[] Value=A074765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074765.Bytes);
public long this[int i]=>Value[i];

public static A074765Inst Instance=new A074765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074766
{
public static readonly long[] Value={ -2L,-1L,0L,1L,2L,5L,2L,7L,6L,3L,6L,3L,6L,7L,4L,9L,4L,11L,10L,11L,14L,13L,10L,21L,10L,11L,18L,21L,24L,25L,8L,17L,10L,25L,16L,21L,22L,19L,24L,23L,22L,29L,18L,27L,24L,35L,22L,9L,18L,33L,40L,39L,42L,37L,32L,31L,24L,41L,34L,37L,46L,35L,24L,33L,42L,43L,28L,27L,24L,41L,44L,37L,32L,37L,30L,39L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074766Inst : IEnumerable<long>
{
public static readonly long[] Value=A074766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074766.Bytes);
public long this[int i]=>Value[i];

public static A074766Inst Instance=new A074766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074767
{
public static readonly long[] Value={ 4L,9L,6L,25L,9L,49L,10L,15L,25L,121L,15L,169L,49L,25L,18L,289L,21L,361L,25L,49L,121L,529L,27L,35L,169L,33L,49L,841L,35L,961L,34L,121L,289L,49L,39L,1369L,361L,169L,55L,1681L,49L,1849L,121L,55L,529L,2209L,51L,77L,55L,289L,169L,2809L,57L,121L,77L,361L,841L,3481L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074767Inst : IEnumerable<long>
{
public static readonly long[] Value=A074767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074767.Bytes);
public long this[int i]=>Value[i];

public static A074767Inst Instance=new A074767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074768
{
public static readonly BigInteger[] Value={ 0L,1L,-4L,42L,-736L,18200L,-582624L,22918672L,-1069947904L,57826348416L,-3551472064000L,244313618844416L,-18609923667234816L,1554954961060953088L,BigInteger.Parse("-141407678375562489856"),BigInteger.Parse("13904110871649987840000") };
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
public class A074768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074768Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A074768.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A074768.Bytes);
public BigInteger this[int i]=>Value[i];

public static A074768Inst Instance=new A074768Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074769
{
public static readonly long[] Value={ 2L,21L,16L,40L,120L,238L,96L,261L,150L,0L,288L,767L,2002L,405L,160L,170L,2016L,0L,1980L,693L,1078L,2645L,0L,625L,650L,0L,784L,0L,3540L,341L,256L,1815L,2414L,0L,720L,0L,0L,1638L,1680L,1271L,966L,8127L,2552L,0L,0L,4841L,2160L,2205L,1300L,1326L,3588L,7685L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074769Inst : IEnumerable<long>
{
public static readonly long[] Value=A074769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074769.Bytes);
public long this[int i]=>Value[i];

public static A074769Inst Instance=new A074769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074770
{
public static readonly long[] Value={ 45L,117L,225L,273L,297L,345L,357L,405L,465L,513L,561L,621L,693L,705L,765L,777L,825L,837L,861L,885L,945L,1005L,1113L,1125L,1185L,1197L,1281L,1305L,1395L,1425L,1521L,1545L,1593L,1617L,1701L,1725L,1845L,1881L,1905L,1953L,1965L,2025L,2037L,2121L,2277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074770Inst : IEnumerable<long>
{
public static readonly long[] Value=A074770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074770.Bytes);
public long this[int i]=>Value[i];

public static A074770Inst Instance=new A074770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074771
{
public static readonly long[] Value={ 62L,74L,134L,146L,254L,398L,404L,458L,482L,494L,554L,566L,614L,626L,662L,674L,692L,758L,764L,794L,818L,854L,914L,998L,1034L,1094L,1124L,1214L,1238L,1286L,1322L,1394L,1454L,1514L,1538L,1646L,1658L,1682L,1826L,1844L,1874L,1934L,2078L,2114L,2174L,2234L,2246L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074771Inst : IEnumerable<long>
{
public static readonly long[] Value=A074771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074771.Bytes);
public long this[int i]=>Value[i];

public static A074771Inst Instance=new A074771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074852
{
public static readonly long[] Value={ 9L,25L,27L,81L,125L,6561L,24389L,59049L,161051L,357911L,571787L,1442897L,4782969L,5177717L,14348907L,18191447L,30080231L,73560059L,80062991L,118370771L,127263527L,131872229L,318611987L,344472101L,440711081L,461889917L,590589719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074852Inst : IEnumerable<long>
{
public static readonly long[] Value=A074852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074852.Bytes);
public long this[int i]=>Value[i];

public static A074852Inst Instance=new A074852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074853
{
public static readonly long[] Value={ 900L,1764L,4356L,4900L,6084L,7560L,10404L,11025L,11880L,12100L,12996L,13440L,14040L,16632L,16900L,18360L,19044L,19656L,20520L,21000L,21120L,23716L,24840L,24960L,25704L,27225L,28728L,28900L,29568L,30276L,30888L,31320L,32640L,33000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074853Inst : IEnumerable<long>
{
public static readonly long[] Value=A074853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074853.Bytes);
public long this[int i]=>Value[i];

public static A074853Inst Instance=new A074853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074854
{
public static readonly long[] Value={ 1L,3L,5L,13L,17L,57L,65L,209L,321L,801L,1025L,3905L,4097L,9407L,21505L,53505L,65537L,233985L,262145L,885761L,1327105L,3147777L,4194305L,16060417L,17825793L,50339841L,84148225L,220217345L,268435457L,990937089L,1073741825L,3506503681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074854Inst : IEnumerable<long>
{
public static readonly long[] Value=A074854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074854.Bytes);
public long this[int i]=>Value[i];

public static A074854Inst Instance=new A074854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074855
{
public static readonly long[] Value={ 2L,3L,7L,19L,29L,37L,61L,211L,521L,613L,1579L,2131L,2467L,2551L,3331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074855Inst : IEnumerable<long>
{
public static readonly long[] Value=A074855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074855.Bytes);
public long this[int i]=>Value[i];

public static A074855Inst Instance=new A074855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074856
{
public static readonly long[] Value={ 2L,5L,13L,17L,31L,37L,61L,79L,89L,97L,109L,127L,139L,193L,229L,277L,307L,311L,313L,349L,373L,379L,401L,409L,439L,457L,499L,541L,569L,571L,577L,653L,661L,691L,701L,709L,751L,811L,823L,829L,877L,991L,1021L,1069L,1087L,1201L,1291L,1381L,1429L,1483L,1549L,1597L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074856Inst : IEnumerable<long>
{
public static readonly long[] Value=A074856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074856.Bytes);
public long this[int i]=>Value[i];

public static A074856Inst Instance=new A074856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074857
{
public static readonly long[] Value={ 2L,17L,19L,23L,31L,37L,43L,53L,59L,137L,139L,151L,157L,179L,181L,191L,197L,199L,211L,307L,317L,337L,347L,367L,397L,599L,1423L,1433L,1453L,1483L,1493L,1523L,1543L,1583L,1613L,1693L,1723L,1733L,1753L,1759L,1777L,1783L,1787L,1789L,1801L,1811L,1823L,1831L,1847L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074857Inst : IEnumerable<long>
{
public static readonly long[] Value=A074857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074857.Bytes);
public long this[int i]=>Value[i];

public static A074857Inst Instance=new A074857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074858
{
public static readonly long[] Value={ 1L,1L,1L,3L,5L,9L,17L,31L,57L,159L,229L,463L,1643L,3028L,5035L,11524L,24762L,41591L,108864L,177197L,305575L,951573L,2048919L,3575995L,6000073L,18774470L,30770296L,53244772L,91462849L,213915324L,333122408L,641864151L,1398505871L,2844591355L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074858Inst : IEnumerable<long>
{
public static readonly long[] Value=A074858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074858.Bytes);
public long this[int i]=>Value[i];

public static A074858Inst Instance=new A074858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074859
{
public static readonly BigInteger[] Value={ 1L,1L,1L,2L,6L,20L,240L,420L,2688L,18144L,120960L,2661120L,7983360L,103783680L,1037836800L,12454041600L,149448499200L,1693749657600L,60974987673600L,289631191449600L,5792623828992000L,121645100408832000L,3568256278659072000L,BigInteger.Parse("30776210403434496000"),BigInteger.Parse("738629049682427904000"),BigInteger.Parse("12310484161373798400000") };
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
public class A074859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074859Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A074859.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A074859.Bytes);
public BigInteger this[int i]=>Value[i];

public static A074859Inst Instance=new A074859Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074860
{
public static readonly long[] Value={ 1L,1L,1L,3L,5L,9L,17L,31L,111L,195L,319L,1021L,2525L,4639L,11092L,25708L,64083L,173846L,292644L,979061L,2073724L,2680995L,7115676L,17380240L,30136219L,41109707L,136581181L,298634398L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074860Inst : IEnumerable<long>
{
public static readonly long[] Value=A074860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074860.Bytes);
public long this[int i]=>Value[i];

public static A074860Inst Instance=new A074860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074861
{
public static readonly long[] Value={ 1L,1L,1L,3L,5L,9L,17L,85L,138L,960L,958L,1759L,10499L,109831L,247873L,617044L,958359L,1773317L,8528346L,14525888L,102424570L,170715000L,164793813L,394338733L,656748025L,1177078610L,1027388860L,1378392568L,9510483643L,12805616091L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074861Inst : IEnumerable<long>
{
public static readonly long[] Value=A074861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074861.Bytes);
public long this[int i]=>Value[i];

public static A074861Inst Instance=new A074861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074862
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,7L,13L,43L,76L,139L,1063L,4633L,7963L,11593L,50173L,83677L,157951L,314005L,774907L,1447279L,11097082L,39016342L,62877022L,84245371L,91872178L,150920986L,815588944L,1243396636L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074862Inst : IEnumerable<long>
{
public static readonly long[] Value=A074862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074862.Bytes);
public long this[int i]=>Value[i];

public static A074862Inst Instance=new A074862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074863
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,7L,13L,25L,49L,94L,199L,394L,781L,1423L,3589L,6286L,11485L,24601L,52225L,95137L,230374L,388378L,766114L,1458025L,3085549L,6183571L,11138812L,25616473L,52394659L,90903760L,190798003L,371558074L,748909162L,1317996148L,2739360475L,5277120958L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074863Inst : IEnumerable<long>
{
public static readonly long[] Value=A074863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074863.Bytes);
public long this[int i]=>Value[i];

public static A074863Inst Instance=new A074863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074864
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,7L,13L,25L,49L,112L,244L,502L,1051L,2206L,3904L,7816L,19243L,37174L,66697L,144349L,292510L,563698L,1879315L,3401746L,6192718L,15630610L,33434152L,63708721L,106919440L,197375245L,342218854L,597294436L,1527006682L,3125687152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074864Inst : IEnumerable<long>
{
public static readonly long[] Value=A074864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074864.Bytes);
public long this[int i]=>Value[i];

public static A074864Inst Instance=new A074864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074865
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,7L,13L,25L,67L,157L,316L,1195L,2635L,9910L,21796L,33268L,108541L,264685L,566431L,1384927L,2251855L,10267813L,23278831L,68031385L,119376340L,223452859L,339327088L,1399568407L,3282220573L,12169858759L,23849465446L,130434244321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074865Inst : IEnumerable<long>
{
public static readonly long[] Value=A074865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074865.Bytes);
public long this[int i]=>Value[i];

public static A074865Inst Instance=new A074865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074866
{
public static readonly long[] Value={ 46L,134L,138L,161L,184L,230L,299L,322L,402L,414L,483L,552L,598L,623L,644L,670L,690L,805L,874L,897L,966L,1173L,1196L,1208L,1242L,1246L,1288L,1495L,1608L,1610L,1702L,1794L,1869L,1909L,1932L,1990L,1992L,2010L,2024L,2070L,2185L,2202L,2346L,2415L,2576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074866Inst : IEnumerable<long>
{
public static readonly long[] Value=A074866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074866.Bytes);
public long this[int i]=>Value[i];

public static A074866Inst Instance=new A074866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074867
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,8L,13L,11L,4L,5L,9L,14L,13L,7L,10L,7L,7L,14L,11L,5L,6L,11L,7L,8L,15L,13L,8L,11L,9L,10L,9L,9L,18L,17L,15L,12L,7L,9L,16L,15L,11L,6L,7L,13L,10L,3L,3L,6L,9L,15L,14L,9L,13L,12L,5L,7L,12L,9L,11L,10L,1L,1L,2L,3L,5L,8L,13L,11L,4L,5L,9L,14L,13L,7L,10L,7L,7L,14L,11L,5L,6L,11L,7L,8L,15L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074867Inst : IEnumerable<long>
{
public static readonly long[] Value=A074867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074867.Bytes);
public long this[int i]=>Value[i];

public static A074867Inst Instance=new A074867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074884
{
public static readonly long[] Value={ 2L,7L,17L,19L,59L,167L,197L,227L,317L,457L,521L,1637L,1861L,1997L,2053L,3833L,5227L,19891L,47303L,54973L,58603L,124567L,138163L,170167L,707467L,1637429L,1940777L,3717731L,4722079L,17886697L,27507569L,73342163L,154205101L,160561133L,186668543L,429364379L,458121431L,1459411661L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074884Inst : IEnumerable<long>
{
public static readonly long[] Value=A074884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074884.Bytes);
public long this[int i]=>Value[i];

public static A074884Inst Instance=new A074884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074885
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,11L,14L,15L,23L,30L,35L,38L,39L,42L,47L,62L,71L,78L,83L,87L,95L,110L,119L,138L,143L,155L,158L,167L,182L,195L,203L,210L,215L,222L,227L,230L,255L,263L,282L,287L,302L,318L,327L,335L,383L,390L,395L,398L,435L,447L,455L,462L,483L,503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074885Inst : IEnumerable<long>
{
public static readonly long[] Value=A074885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074885.Bytes);
public long this[int i]=>Value[i];

public static A074885Inst Instance=new A074885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074886
{
public static readonly long[] Value={ 14L,110L,274L,435L,1298L,4608L,4646L,5384L,9214L,10154L,10778L,11912L,13035L,13844L,15026L,18698L,21346L,22958L,25642L,26846L,27466L,32078L,34546L,41164L,49570L,77374L,80438L,85875L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074886Inst : IEnumerable<long>
{
public static readonly long[] Value=A074886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074886.Bytes);
public long this[int i]=>Value[i];

public static A074886Inst Instance=new A074886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074887
{
public static readonly long[] Value={ 915L,12957L,20745L,26985L,54621L,97785L,111615L,188013L,191775L,197631L,231045L,258687L,428745L,565761L,726645L,793653L,807639L,829857L,941451L,1048719L,1084587L,1224111L,1233027L,1863255L,1920681L,1973805L,2043489L,2129883L,2254119L,2265417L,2300151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074887Inst : IEnumerable<long>
{
public static readonly long[] Value=A074887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074887.Bytes);
public long this[int i]=>Value[i];

public static A074887Inst Instance=new A074887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074888
{
public static readonly long[] Value={ 1029L,1312L,1635L,1755L,1918L,37562L,55743L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074888Inst : IEnumerable<long>
{
public static readonly long[] Value=A074888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074888.Bytes);
public long this[int i]=>Value[i];

public static A074888Inst Instance=new A074888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074889
{
public static readonly long[] Value={ 524L,928L,1179L,1252L,1292L,1372L,1736L,2101L,2525L,2817L,4103L,4213L,4949L,8327L,8657L,8767L,10109L,10219L,19781L,23711L,25021L,27331L,28841L,34571L,41003L,41204L,45244L,45644L,46243L,47263L,48863L,49684L,50173L,52124L,53303L,53324L,56164L,56323L,56564L,56643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074889Inst : IEnumerable<long>
{
public static readonly long[] Value=A074889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074889.Bytes);
public long this[int i]=>Value[i];

public static A074889Inst Instance=new A074889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074890
{
public static readonly long[] Value={ 1L,3L,6L,13L,25L,55L,100L,222L,401L,891L,1602L,3559L,6428L,14258L,25647L,56936L,102860L,228154L,410339L,910998L,1645813L,3650437L,6565453L,14576121L,26332935L,58407052L,105047514L,233217299L,421327294L,934513441L,1680759539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074890Inst : IEnumerable<long>
{
public static readonly long[] Value=A074890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074890.Bytes);
public long this[int i]=>Value[i];

public static A074890Inst Instance=new A074890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074891
{
public static readonly long[] Value={ 15L,35L,357L,1045L,3339L,5049L,10659L,12441L,24871L,24969L,29029L,50065L,58435L,64285L,87685L,99693L,132957L,137885L,140335L,353133L,423657L,596037L,655707L,734517L,745503L,894387L,1390753L,1406427L,1529983L,1641783L,1739507L,1823877L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074891Inst : IEnumerable<long>
{
public static readonly long[] Value=A074891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074891.Bytes);
public long this[int i]=>Value[i];

public static A074891Inst Instance=new A074891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074892
{
public static readonly long[] Value={ 1L,3L,5L,11L,23L,55L,87L,123L,383L,501L,957L,1015L,3565L,3777L,5667L,6141L,9069L,11033L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074892Inst : IEnumerable<long>
{
public static readonly long[] Value=A074892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074892.Bytes);
public long this[int i]=>Value[i];

public static A074892Inst Instance=new A074892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074893
{
public static readonly long[] Value={ 3L,10L,19L,2L,1L,2L,2L,1L,6L,1L,6L,19L,17L,1L,7L,1L,2L,2L,1L,10L,2L,6L,2L,1L,3L,2L,1L,21L,5L,1L,15L,1L,1L,4L,1L,1L,1L,443L,2L,1L,4L,3L,1L,1L,6L,26L,6L,2L,39L,4L,1L,2L,6L,1L,1L,2L,4L,7L,1L,5L,1L,3L,1L,3L,5L,10L,1L,9L,5L,1L,2L,4L,10L,1L,1L,5L,1L,1L,3L,2L,2L,2L,2L,1L,4L,1L,1L,1L,1L,11L,1L,4L,1L,2L,2L,2L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074893Inst : IEnumerable<long>
{
public static readonly long[] Value=A074893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074893.Bytes);
public long this[int i]=>Value[i];

public static A074893Inst Instance=new A074893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074894
{
public static readonly long[] Value={ 3L,6L,27L,486L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074894Inst : IEnumerable<long>
{
public static readonly long[] Value=A074894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074894.Bytes);
public long this[int i]=>Value[i];

public static A074894Inst Instance=new A074894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074895
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,14L,16L,17L,31L,32L,34L,35L,37L,38L,71L,73L,74L,76L,79L,91L,92L,95L,97L,98L,101L,104L,106L,107L,112L,113L,118L,119L,124L,125L,128L,131L,133L,134L,136L,142L,145L,146L,149L,151L,152L,157L,164L,166L,167L,172L,175L,179L,181L,182L,188L,191L,194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074895Inst : IEnumerable<long>
{
public static readonly long[] Value=A074895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074895.Bytes);
public long this[int i]=>Value[i];

public static A074895Inst Instance=new A074895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074896
{
public static readonly long[] Value={ 1L,4L,9L,18L,46L,52L,61L,63L,94L,121L,144L,148L,163L,169L,423L,441L,484L,487L,522L,526L,652L,675L,676L,691L,925L,927L,961L,982L,1042L,1062L,1089L,1251L,1273L,1297L,1405L,1426L,1656L,1674L,1828L,1843L,1861L,4032L,4069L,4072L,4201L,4264L,4276L,4441L,4477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074896Inst : IEnumerable<long>
{
public static readonly long[] Value=A074896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074896.Bytes);
public long this[int i]=>Value[i];

public static A074896Inst Instance=new A074896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074897
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,8L,10L,12L,13L,14L,16L,18L,19L,22L,23L,24L,28L,30L,32L,34L,36L,39L,40L,41L,42L,46L,48L,50L,52L,54L,55L,56L,57L,58L,60L,64L,66L,70L,72L,74L,76L,78L,80L,84L,86L,88L,90L,92L,94L,96L,98L,101L,102L,104L,106L,107L,108L,110L,112L,114L,116L,118L,122L,124L,126L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074897Inst : IEnumerable<long>
{
public static readonly long[] Value=A074897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074897.Bytes);
public long this[int i]=>Value[i];

public static A074897Inst Instance=new A074897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074898
{
public static readonly long[] Value={ 1L,6L,7L,9L,11L,15L,17L,20L,21L,25L,26L,27L,29L,31L,33L,35L,37L,38L,43L,44L,45L,47L,49L,51L,53L,59L,61L,62L,63L,65L,67L,68L,69L,71L,73L,75L,77L,79L,81L,82L,83L,85L,87L,89L,91L,93L,95L,97L,99L,100L,103L,105L,109L,111L,113L,115L,117L,119L,120L,121L,123L,125L,127L,128L,129L,131L,133L,134L,135L,137L,139L,141L,143L,145L,146L,149L,151L,153L,155L,157L,158L,159L,161L,163L,165L,167L,168L,169L,170L,171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074898Inst : IEnumerable<long>
{
public static readonly long[] Value=A074898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074898.Bytes);
public long this[int i]=>Value[i];

public static A074898Inst Instance=new A074898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074899
{
public static readonly long[] Value={ 1L,3L,6L,12L,19L,21L,28L,36L,51L,54L,55L,63L,66L,82L,87L,91L,99L,102L,132L,147L,153L,165L,168L,171L,252L,307L,309L,351L,352L,379L,381L,417L,423L,451L,501L,505L,523L,534L,564L,577L,582L,594L,595L,604L,613L,627L,631L,645L,649L,654L,666L,672L,694L,753L,766L,771L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074899Inst : IEnumerable<long>
{
public static readonly long[] Value=A074899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074899.Bytes);
public long this[int i]=>Value[i];

public static A074899Inst Instance=new A074899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074948
{
public static readonly long[] Value={ 2L,9L,3L,7L,5L,7L,2L,1L,6L,9L,3L,2L,7L,9L,3L,0L,6L,4L,3L,2L,4L,6L,2L,5L,2L,9L,0L,9L,9L,2L,2L,2L,4L,1L,0L,0L,7L,4L,1L,8L,0L,4L,1L,7L,2L,6L,0L,9L,6L,5L,7L,0L,8L,7L,9L,7L,8L,2L,3L,2L,1L,8L,1L,3L,9L,8L,6L,1L,0L,5L,3L,8L,1L,3L,7L,5L,3L,6L,0L,7L,3L,5L,0L,2L,7L,4L,0L,1L,8L,9L,5L,4L,5L,3L,4L,4L,1L,4L,3L,1L,6L,1L,5L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074948Inst : IEnumerable<long>
{
public static readonly long[] Value=A074948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074948.Bytes);
public long this[int i]=>Value[i];

public static A074948Inst Instance=new A074948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074949
{
public static readonly long[] Value={ 1L,1L,6L,6L,60L,60L,140L,420L,2520L,2520L,27720L,27720L,360360L,360360L,72072L,360360L,12252240L,12252240L,77597520L,46558512L,25865840L,33256080L,118982864L,5354228880L,8923714800L,3824449200L,80313433200L,80313433200L,2329089562800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074949Inst : IEnumerable<long>
{
public static readonly long[] Value=A074949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074949.Bytes);
public long this[int i]=>Value[i];

public static A074949Inst Instance=new A074949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074950
{
public static readonly long[] Value={ 2L,9L,1L,4L,6L,4L,7L,4L,8L,9L,0L,6L,6L,2L,6L,6L,1L,8L,0L,1L,0L,7L,1L,0L,9L,6L,3L,1L,0L,7L,5L,6L,0L,5L,9L,3L,7L,5L,0L,4L,3L,6L,7L,9L,4L,0L,9L,5L,8L,3L,3L,2L,1L,9L,7L,4L,6L,7L,1L,6L,5L,7L,6L,1L,0L,5L,2L,6L,7L,4L,9L,0L,0L,8L,2L,8L,2L,3L,2L,8L,0L,1L,0L,4L,3L,5L,0L,3L,3L,9L,0L,8L,5L,5L,8L,0L,9L,8L,8L,6L,5L,4L,6L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074950Inst : IEnumerable<long>
{
public static readonly long[] Value=A074950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074950.Bytes);
public long this[int i]=>Value[i];

public static A074950Inst Instance=new A074950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074951
{
public static readonly long[] Value={ 2L,1L,10L,1L,2L,1L,1L,10L,1L,1L,2L,1L,11L,1L,5L,1L,1L,7L,58L,3L,1L,2L,2L,7L,13L,3L,1L,20L,1L,20L,1L,2L,8L,2L,1L,1L,2L,1L,1L,14L,3L,4L,1L,1L,1L,1L,8L,1L,6L,4L,1L,3L,1L,2L,2L,1L,1L,12L,42L,9L,1L,1L,1L,1L,6L,1L,1L,3L,8L,2L,7L,1L,1L,2L,2L,1L,1L,3L,1L,17L,1L,3L,2L,4L,1L,2L,1L,4L,3L,1L,1L,1L,7L,13L,22L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074951Inst : IEnumerable<long>
{
public static readonly long[] Value=A074951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074951.Bytes);
public long this[int i]=>Value[i];

public static A074951Inst Instance=new A074951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074952
{
public static readonly long[] Value={ 2L,1L,15L,54L,15L,1L,2L,2L,1L,2L,19L,3L,2L,1L,1L,19L,1L,3L,2L,4L,1L,5L,1L,1L,1L,1L,5L,8L,2L,1L,1L,2L,3L,1L,1L,2L,3L,1L,2L,9L,2L,3L,18L,5L,63L,2L,1L,1L,4L,13L,3L,10L,1L,5L,1L,20L,1L,6L,1L,38L,2L,1L,4L,57L,1L,8L,12L,9L,2L,1L,2L,1L,1L,4L,10L,1L,1L,1L,15L,2L,4L,1L,1L,1L,1L,9L,2L,2L,3L,54L,1L,39L,1L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074952Inst : IEnumerable<long>
{
public static readonly long[] Value=A074952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074952.Bytes);
public long this[int i]=>Value[i];

public static A074952Inst Instance=new A074952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074953
{
public static readonly long[] Value={ 5L,9L,15L,24L,36L,51L,66L,87L,105L,123L,144L,165L,186L,195L,213L,234L,255L,276L,297L,330L,384L,426L,447L,492L,546L,585L,609L,630L,651L,735L,816L,825L,843L,870L,951L,1026L,1041L,1056L,1077L,1122L,1191L,1254L,1284L,1296L,1311L,1374L,1440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074953Inst : IEnumerable<long>
{
public static readonly long[] Value=A074953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074953.Bytes);
public long this[int i]=>Value[i];

public static A074953Inst Instance=new A074953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074954
{
public static readonly long[] Value={ 9L,27L,4L,8L,9L,0L,8L,9L,25L,2197L,27L,16L,49L,0L,16L,25L,25L,27L,27L,36L,25L,49L,27L,25L,125L,27L,36L,32L,225L,6889L,32L,36L,49L,0L,36L,100L,64L,1369L,64L,49L,49L,0L,484L,125L,49L,289L,128L,49L,81L,0L,100L,196L,729L,81L,64L,64L,121L,0L,900L,64L,125L,0L,64L,100L,81L,0L,1156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074954Inst : IEnumerable<long>
{
public static readonly long[] Value=A074954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074954.Bytes);
public long this[int i]=>Value[i];

public static A074954Inst Instance=new A074954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074955
{
public static readonly long[] Value={ 2L,1L,13L,3L,1L,1L,1L,42L,1L,2L,1L,5L,5L,1L,1L,1L,1L,4L,2L,1L,2L,4L,8L,1L,3L,1L,1L,1L,1L,1L,1L,1L,4L,18L,1L,1L,1L,12L,3L,1L,8L,1L,1L,2L,3L,1L,2L,5L,2L,2L,2L,1L,2L,6L,2L,4L,4L,3L,1L,1L,19L,730L,1L,30L,1L,51L,2L,1L,2L,6L,1L,1L,1L,4L,7L,20L,96L,38L,5L,3L,3L,10L,1L,1L,3L,3L,2L,2L,3L,74L,1L,1L,941L,1L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074955Inst : IEnumerable<long>
{
public static readonly long[] Value=A074955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074955.Bytes);
public long this[int i]=>Value[i];

public static A074955Inst Instance=new A074955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074956
{
public static readonly long[] Value={ 2L,1L,12L,1L,1L,6L,1L,136L,11L,1L,1L,4L,1L,5L,2L,9L,1L,2L,1L,4L,3L,2L,4L,2L,3L,2L,1L,46L,7L,1L,6L,2L,1L,3L,14L,4L,6L,8L,6L,3L,1L,2L,1L,6L,1L,2L,1L,3L,2L,1L,1L,1L,1L,1L,7L,1L,1L,6L,1L,3L,9L,10L,1L,1L,227L,1L,2L,1L,1L,9L,2L,7L,1L,2L,2L,1L,2L,1L,3L,1L,2L,1L,5L,1L,170L,1L,17L,1L,5L,2L,3L,10L,7L,1L,10L,1L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074956Inst : IEnumerable<long>
{
public static readonly long[] Value=A074956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074956.Bytes);
public long this[int i]=>Value[i];

public static A074956Inst Instance=new A074956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074957
{
public static readonly long[] Value={ 2L,9L,2L,6L,1L,0L,8L,5L,5L,1L,5L,7L,2L,3L,0L,4L,6L,9L,6L,6L,6L,5L,8L,9L,5L,7L,1L,0L,1L,7L,0L,5L,5L,8L,5L,3L,1L,0L,6L,6L,2L,0L,5L,7L,5L,5L,3L,7L,9L,8L,4L,5L,6L,2L,7L,4L,4L,2L,4L,1L,5L,5L,1L,2L,4L,2L,1L,5L,2L,6L,8L,6L,8L,5L,1L,1L,9L,8L,6L,4L,4L,5L,1L,9L,3L,9L,4L,0L,9L,3L,5L,4L,6L,3L,2L,2L,7L,4L,5L,6L,4L,1L,8L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074957Inst : IEnumerable<long>
{
public static readonly long[] Value=A074957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074957.Bytes);
public long this[int i]=>Value[i];

public static A074957Inst Instance=new A074957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074958
{
public static readonly long[] Value={ 2L,4L,7L,4L,6L,8L,0L,4L,3L,6L,2L,3L,6L,3L,0L,4L,4L,6L,2L,6L,0L,6L,6L,5L,9L,6L,0L,3L,5L,9L,1L,4L,0L,1L,4L,8L,9L,2L,5L,1L,6L,7L,4L,0L,9L,4L,0L,6L,6L,7L,3L,5L,8L,6L,6L,8L,2L,6L,1L,8L,2L,7L,4L,0L,6L,3L,0L,4L,8L,5L,8L,9L,6L,2L,0L,7L,0L,0L,7L,2L,5L,2L,3L,9L,2L,6L,8L,3L,4L,9L,4L,6L,3L,8L,2L,6L,6L,9L,9L,7L,9L,9L,8L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074958Inst : IEnumerable<long>
{
public static readonly long[] Value=A074958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074958.Bytes);
public long this[int i]=>Value[i];

public static A074958Inst Instance=new A074958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074959
{
public static readonly long[] Value={ 3L,9L,3L,6L,2L,3L,5L,5L,0L,3L,6L,4L,9L,5L,5L,5L,4L,7L,7L,9L,7L,8L,9L,2L,6L,1L,7L,5L,5L,0L,0L,7L,4L,7L,8L,9L,7L,8L,2L,7L,8L,9L,7L,6L,4L,0L,7L,3L,7L,1L,6L,3L,9L,4L,2L,4L,5L,8L,2L,0L,1L,2L,2L,6L,3L,4L,9L,5L,9L,8L,9L,7L,8L,7L,9L,1L,4L,7L,2L,9L,8L,0L,7L,8L,6L,2L,6L,6L,5L,4L,4L,1L,9L,8L,7L,2L,6L,9L,1L,1L,6L,5L,6L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074959Inst : IEnumerable<long>
{
public static readonly long[] Value=A074959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074959.Bytes);
public long this[int i]=>Value[i];

public static A074959Inst Instance=new A074959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074960
{
public static readonly long[] Value={ 3L,1L,14L,1L,2L,6L,1L,1L,2L,5L,2L,1L,2L,1L,4L,7L,1L,7L,9L,1L,4L,1L,20L,1L,1L,1L,1L,1L,1L,4L,2L,10L,1L,2L,1L,5L,1L,4L,2L,2L,2L,30L,1L,18L,2L,6L,1L,1L,1L,1L,6L,1L,1L,2L,12L,6L,1L,2L,6L,1L,17L,5L,2L,1L,6L,2L,3L,1L,5L,1L,1L,3L,1L,1L,2L,4L,11L,1L,4L,2L,11L,1L,1L,23L,1L,1L,3L,1L,5L,3L,1L,1L,1L,2L,21L,1L,1L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074960Inst : IEnumerable<long>
{
public static readonly long[] Value=A074960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074960.Bytes);
public long this[int i]=>Value[i];

public static A074960Inst Instance=new A074960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074961
{
public static readonly long[] Value={ 2L,2L,9L,2L,1L,2L,12L,1L,1L,16L,3L,3L,1L,7L,21L,1L,3L,1L,1L,2L,19L,7L,2L,1L,15L,1L,6L,1L,6L,4L,1L,5L,2L,2L,1L,1L,1L,2L,1L,12L,1L,12L,3L,1L,1L,1L,3L,18L,1L,1L,2L,4L,8L,16L,1L,3L,1L,30L,1L,4L,13L,1L,2L,1L,3L,9L,3L,5L,4L,7L,4L,1L,1L,3L,3L,30L,3L,7L,4L,10L,2L,19L,1L,4L,4L,1L,1L,9L,33L,1L,3L,1L,7L,8L,11L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074961Inst : IEnumerable<long>
{
public static readonly long[] Value=A074961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074961.Bytes);
public long this[int i]=>Value[i];

public static A074961Inst Instance=new A074961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074962
{
public static readonly long[] Value={ 1L,2L,8L,2L,4L,2L,7L,1L,2L,9L,1L,0L,0L,6L,2L,2L,6L,3L,6L,8L,7L,5L,3L,4L,2L,5L,6L,8L,8L,6L,9L,7L,9L,1L,7L,2L,7L,7L,6L,7L,6L,8L,8L,9L,2L,7L,3L,2L,5L,0L,0L,1L,1L,9L,2L,0L,6L,3L,7L,4L,0L,0L,2L,1L,7L,4L,0L,4L,0L,6L,3L,0L,8L,8L,5L,8L,8L,2L,6L,4L,6L,1L,1L,2L,9L,7L,3L,6L,4L,9L,1L,9L,5L,8L,2L,0L,2L,3L,7L,4L,3L,9L,4L,2L,0L,6L,4L,6L,1L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074962Inst : IEnumerable<long>
{
public static readonly long[] Value=A074962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074962.Bytes);
public long this[int i]=>Value[i];

public static A074962Inst Instance=new A074962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074963
{
public static readonly long[] Value={ 1L,7L,13L,31L,42L,91L,96L,127L,195L,234L,234L,403L,403L,480L,576L,744L,744L,847L,847L,1170L,1344L,1344L,1344L,1651L,1860L,1860L,1860L,2240L,2240L,2880L,2880L,3048L,3048L,3048L,3048L,4368L,4368L,4368L,4368L,5040L,5040L,5952L,5952L,5952L,6552L,6552L,6552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074963Inst : IEnumerable<long>
{
public static readonly long[] Value=A074963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074963.Bytes);
public long this[int i]=>Value[i];

public static A074963Inst Instance=new A074963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074964
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,12L,18L,24L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074964Inst : IEnumerable<long>
{
public static readonly long[] Value=A074964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074964.Bytes);
public long this[int i]=>Value[i];

public static A074964Inst Instance=new A074964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074965
{
public static readonly long[] Value={ 5L,17L,29L,41L,61L,73L,97L,101L,113L,137L,149L,157L,181L,193L,197L,241L,269L,281L,313L,373L,401L,421L,433L,449L,457L,461L,521L,541L,569L,601L,617L,641L,673L,733L,769L,809L,821L,857L,881L,929L,937L,953L,1009L,1021L,1033L,1049L,1061L,1117L,1201L,1229L,1277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074965Inst : IEnumerable<long>
{
public static readonly long[] Value=A074965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074965.Bytes);
public long this[int i]=>Value[i];

public static A074965Inst Instance=new A074965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074966
{
public static readonly long[] Value={ 1L,1L,2L,1L,12L,7L,4L,43L,10L,19L,62L,35L,16L,27L,28L,13L,74L,107L,18L,91L,32L,87L,14L,95L,96L,43L,68L,135L,120L,19L,58L,7L,58L,63L,54L,31L,42L,115L,10L,157L,110L,13L,4L,403L,122L,457L,534L,37L,18L,31L,226L,253L,20L,193L,102L,177L,392L,45L,194L,257L,102L,79L,454L,231L,306L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074966Inst : IEnumerable<long>
{
public static readonly long[] Value=A074966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074966.Bytes);
public long this[int i]=>Value[i];

public static A074966Inst Instance=new A074966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074967
{
public static readonly long[] Value={ 1L,4L,5L,4L,7L,2L,3L,10L,33L,42L,19L,12L,17L,52L,59L,18L,65L,2L,51L,2L,23L,120L,35L,2L,63L,10L,39L,186L,7L,74L,47L,200L,53L,24L,19L,48L,333L,56L,57L,192L,127L,348L,63L,124L,213L,60L,359L,2L,213L,2L,387L,526L,269L,252L,863L,16L,131L,370L,503L,294L,83L,68L,317L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074967Inst : IEnumerable<long>
{
public static readonly long[] Value=A074967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074967.Bytes);
public long this[int i]=>Value[i];

public static A074967Inst Instance=new A074967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074968
{
public static readonly long[] Value={ 3L,5L,10L,15L,25L,28L,38L,41L,51L,64L,69L,82L,89L,94L,104L,116L,130L,133L,147L,156L,160L,173L,181L,195L,211L,224L,227L,234L,237L,246L,276L,286L,300L,303L,323L,330L,341L,353L,361L,377L,390L,392L,412L,415L,426L,431L,459L,485L,493L,496L,504L,516L,520L,542L,554L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074968Inst : IEnumerable<long>
{
public static readonly long[] Value=A074968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074968.Bytes);
public long this[int i]=>Value[i];

public static A074968Inst Instance=new A074968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074969
{
public static readonly long[] Value={ 30030L,39270L,43890L,46410L,51870L,53130L,60060L,62790L,66990L,67830L,71610L,72930L,78540L,79170L,81510L,82110L,84630L,85470L,87780L,90090L,91770L,92820L,94710L,98670L,99330L,101010L,102102L,103530L,103740L,106260L,106590L,108570L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074969Inst : IEnumerable<long>
{
public static readonly long[] Value=A074969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074969.Bytes);
public long this[int i]=>Value[i];

public static A074969Inst Instance=new A074969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074970
{
public static readonly long[] Value={ 0L,1L,2L,2L,18L,0L,3L,2L,3L,3L,26L,1L,9L,3L,7L,3L,6L,3L,56L,11L,9L,15L,42L,2L,10L,3L,3L,0L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074970Inst : IEnumerable<long>
{
public static readonly long[] Value=A074970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074970.Bytes);
public long this[int i]=>Value[i];

public static A074970Inst Instance=new A074970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074971
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,3L,1L,2L,1L,1L,1L,4L,1L,1L,1L,2L,1L,4L,1L,1L,1L,1L,1L,6L,1L,1L,1L,3L,1L,3L,1L,1L,1L,1L,1L,6L,1L,1L,1L,1L,1L,4L,1L,2L,1L,1L,1L,32L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,25L,1L,1L,1L,1L,1L,2L,1L,4L,1L,1L,1L,24L,1L,1L,1L,2L,1L,24L,1L,1L,1L,1L,1L,12L,1L,1L,1L,3L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074971Inst : IEnumerable<long>
{
public static readonly long[] Value=A074971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074971.Bytes);
public long this[int i]=>Value[i];

public static A074971Inst Instance=new A074971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074972
{
public static readonly long[] Value={ 18L,17L,15L,13L,9L,7L,3L,1L,17L,11L,9L,3L,19L,17L,13L,7L,1L,19L,13L,9L,7L,1L,17L,11L,3L,19L,17L,13L,11L,7L,13L,9L,3L,1L,11L,9L,3L,17L,13L,7L,1L,19L,9L,7L,3L,1L,9L,17L,13L,11L,7L,1L,19L,9L,3L,17L,11L,9L,3L,19L,17L,7L,13L,9L,7L,3L,9L,3L,13L,11L,7L,1L,13L,7L,1L,17L,11L,3L,19L,11L,1L,19L,9L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074972Inst : IEnumerable<long>
{
public static readonly long[] Value=A074972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074972.Bytes);
public long this[int i]=>Value[i];

public static A074972Inst Instance=new A074972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074973
{
public static readonly long[] Value={ 1L,4L,11L,20L,17L,67L,104L,56L,125L,165L,182L,316L,236L,359L,407L,1254L,667L,836L,1521L,1210L,1966L,3197L,1520L,2294L,2279L,2046L,5410L,5472L,1965L,6702L,13947L,10138L,12122L,16760L,7659L,22325L,16784L,13072L,36169L,17852L,15414L,69872L,23814L,16370L,46752L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074973Inst : IEnumerable<long>
{
public static readonly long[] Value=A074973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074973.Bytes);
public long this[int i]=>Value[i];

public static A074973Inst Instance=new A074973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074974
{
public static readonly long[] Value={ 15L,26L,33L,39L,50L,51L,57L,62L,68L,69L,75L,79L,82L,86L,93L,97L,99L,118L,127L,141L,147L,165L,167L,172L,178L,181L,187L,207L,217L,235L,239L,242L,244L,248L,253L,257L,259L,271L,275L,277L,284L,293L,295L,325L,329L,345L,356L,358L,363L,365L,369L,385L,401L,407L,410L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074974Inst : IEnumerable<long>
{
public static readonly long[] Value=A074974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074974.Bytes);
public long this[int i]=>Value[i];

public static A074974Inst Instance=new A074974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074975
{
public static readonly long[] Value={ 24L,42L,66L,96L,104L,108L,114L,140L,156L,174L,176L,180L,222L,224L,228L,270L,282L,288L,336L,352L,354L,392L,396L,400L,444L,448L,464L,516L,532L,534L,560L,572L,576L,594L,644L,650L,666L,702L,704L,708L,714L,720L,740L,756L,760L,774L,780L,800L,810L,822L,828L,870L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074975Inst : IEnumerable<long>
{
public static readonly long[] Value=A074975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074975.Bytes);
public long this[int i]=>Value[i];

public static A074975Inst Instance=new A074975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074976
{
public static readonly long[] Value={ 3L,2L,2L,1L,3L,2L,4L,2L,2L,5L,2L,3L,6L,3L,2L,2L,8L,3L,4L,8L,3L,4L,3L,2L,5L,10L,5L,10L,5L,2L,6L,4L,12L,2L,12L,4L,4L,6L,4L,4L,13L,3L,14L,7L,14L,2L,2L,7L,15L,8L,5L,15L,3L,5L,5L,5L,16L,6L,8L,17L,3L,2L,9L,18L,9L,3L,6L,4L,19L,9L,6L,5L,6L,6L,10L,7L,5L,10L,5L,4L,20L,4L,21L,7L,10L,7L,5L,11L,21L,11L,4L,5L,11L,6L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074976Inst : IEnumerable<long>
{
public static readonly long[] Value=A074976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074976.Bytes);
public long this[int i]=>Value[i];

public static A074976Inst Instance=new A074976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A074977
{
public static readonly long[] Value={ 1L,10L,55L,161L,209L,551L,649L,1079L,1189L,3401L,6049L,6319L,9701L,12151L,14279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A074977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A074977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A074977Inst : IEnumerable<long>
{
public static readonly long[] Value=A074977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A074977.Bytes);
public long this[int i]=>Value[i];

public static A074977Inst Instance=new A074977Inst();

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