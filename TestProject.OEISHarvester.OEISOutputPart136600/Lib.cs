using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A165905
{
public static readonly BigInteger[] Value={ 1L,2L,4L,16L,48L,224L,1472L,7552L,80384L,782848L,8406016L,170625024L,2540736512L,64470204416L,2076557099008L,55281408770048L,3099925187854336L,147249506912960512L,8547656292050141184L,BigInteger.Parse("871531919951033532416") };
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
public class A165905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165905Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A165905.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A165905.Bytes);
public BigInteger this[int i]=>Value[i];

public static A165905Inst Instance=new A165905Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165906
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,4L,4L,5L,5L,5L,6L,6L,6L,7L,7L,8L,8L,9L,9L,9L,10L,11L,11L,11L,11L,12L,13L,13L,14L,15L,14L,15L,15L,16L,16L,17L,17L,17L,18L,18L,19L,20L,20L,20L,21L,22L,22L,21L,22L,23L,23L,24L,25L,25L,25L,26L,26L,27L,27L,28L,29L,29L,28L,29L,30L,31L,30L,31L,31L,32L,32L,33L,33L,34L,34L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165906Inst : IEnumerable<long>
{
public static readonly long[] Value=A165906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165906.Bytes);
public long this[int i]=>Value[i];

public static A165906Inst Instance=new A165906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165907
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,4L,4L,5L,5L,5L,6L,6L,6L,7L,8L,8L,8L,9L,9L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165907Inst : IEnumerable<long>
{
public static readonly long[] Value=A165907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165907.Bytes);
public long this[int i]=>Value[i];

public static A165907Inst Instance=new A165907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165908
{
public static readonly long[] Value={ 1L,2L,-1L,6L,-3L,-2L,30L,-15L,-10L,-6L,42L,-21L,-14L,-6L,30L,-15L,-10L,-6L,66L,-33L,-22L,-6L,2730L,-1365L,-910L,-546L,-390L,-210L,12L,-3L,-2L,-3060L,-255L,-170L,-102L,-30L,44688L,-399L,-266L,-114L,-42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165908Inst : IEnumerable<long>
{
public static readonly long[] Value=A165908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165908.Bytes);
public long this[int i]=>Value[i];

public static A165908Inst Instance=new A165908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165909
{
public static readonly long[] Value={ 0L,1L,1L,1L,5L,8L,7L,5L,12L,25L,22L,14L,39L,42L,30L,14L,68L,60L,76L,35L,70L,110L,92L,42L,125L,169L,126L,84L,203L,150L,186L,72L,165L,289L,175L,96L,333L,342L,208L,135L,410L,308L,430L,198L,225L,460L,423L,124L,490L,525L,408L,299L,689L,549L,385L,252L,532L,841L,767L,270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165909Inst : IEnumerable<long>
{
public static readonly long[] Value=A165909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165909.Bytes);
public long this[int i]=>Value[i];

public static A165909Inst Instance=new A165909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165910
{
public static readonly long[] Value={ 1L,4L,18L,62L,210L,666L,2063L,6226L,18484L,54100L,156620L,449268L,1278981L,3617544L,10175590L,28485218L,79406350L,220536910L,610487875L,1684974790L,4638298536L,12737460744L,34902844728L,95449821672L,260554112425L,710056257196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165910Inst : IEnumerable<long>
{
public static readonly long[] Value=A165910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165910.Bytes);
public long this[int i]=>Value[i];

public static A165910Inst Instance=new A165910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165911
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,5L,2L,7L,3L,10L,13L,23L,6L,29L,35L,2L,37L,39L,38L,77L,115L,6L,11L,17L,14L,31L,15L,46L,61L,107L,42L,149L,191L,170L,19L,21L,10L,31L,41L,6L,47L,53L,10L,21L,31L,26L,57L,83L,70L,51L,11L,62L,73L,15L,22L,37L,59L,6L,65L,71L,34L,105L,139L,122L,87L,209L,74L,283L,357L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165911Inst : IEnumerable<long>
{
public static readonly long[] Value=A165911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165911.Bytes);
public long this[int i]=>Value[i];

public static A165911Inst Instance=new A165911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165912
{
public static readonly long[] Value={ 2L,0L,2L,2L,4L,6L,12L,20L,38L,66L,124L,224L,420L,774L,1456L,2720L,5140L,9690L,18396L,34918L,66576L,127038L,243148L,465920L,894784L,1720530L,3314018L,6390930L,12341860L,23860200L,46182444L,89477120L,173534032L,336857610L,654471204L,1272578048L,2476377540L,4822410222L,9397535280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165912Inst : IEnumerable<long>
{
public static readonly long[] Value=A165912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165912.Bytes);
public long this[int i]=>Value[i];

public static A165912Inst Instance=new A165912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165913
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,1L,2L,1L,1L,7L,1L,5L,6L,1L,3L,5L,1L,1L,3L,10L,1L,2L,7L,11L,1L,6L,10L,1L,1L,2L,13L,15L,1L,7L,10L,13L,1L,5L,6L,7L,11L,17L,1L,5L,1L,7L,15L,1L,3L,5L,11L,14L,15L,1L,2L,3L,6L,13L,1L,1L,6L,11L,14L,19L,21L,1L,3L,10L,13L,14L,17L,22L,23L,1L,7L,10L,13L,19L,22L,1L,21L,1L,5L,6L,7L,13L,22L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165913Inst : IEnumerable<long>
{
public static readonly long[] Value=A165913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165913.Bytes);
public long this[int i]=>Value[i];

public static A165913Inst Instance=new A165913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165914
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,4L,3L,1L,8L,12L,9L,1L,14L,21L,17L,1L,31L,31L,47L,6L,23L,49L,25L,1L,72L,103L,72L,22L,77L,72L,58L,18L,72L,177L,121L,14L,176L,180L,79L,1L,202L,172L,276L,76L,95L,249L,184L,34L,298L,318L,251L,60L,362L,263L,137L,1L,242L,479L,448L,22L,456L,432L,214L,149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165914Inst : IEnumerable<long>
{
public static readonly long[] Value=A165914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165914.Bytes);
public long this[int i]=>Value[i];

public static A165914Inst Instance=new A165914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165915
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,2L,1L,2L,3L,3L,1L,3L,4L,3L,1L,4L,4L,6L,2L,3L,6L,5L,1L,6L,8L,6L,2L,7L,6L,7L,2L,5L,10L,7L,2L,10L,11L,6L,1L,10L,8L,14L,4L,5L,12L,11L,2L,12L,13L,10L,4L,15L,11L,8L,1L,9L,17L,17L,2L,16L,16L,7L,5L,11L,11L,21L,6L,9L,12L,15L,1L,19L,23L,12L,6L,13L,14L,21L,3L,18L,24L,24L,4L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165915Inst : IEnumerable<long>
{
public static readonly long[] Value=A165915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165915.Bytes);
public long this[int i]=>Value[i];

public static A165915Inst Instance=new A165915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165916
{
public static readonly long[] Value={ 2L,2L,3L,2L,3L,2L,5L,3L,5L,6L,2L,3L,5L,6L,7L,2L,3L,5L,6L,2L,3L,7L,2L,6L,7L,10L,2L,3L,5L,6L,7L,10L,11L,2L,5L,6L,7L,11L,3L,5L,6L,10L,13L,2L,3L,5L,7L,11L,13L,14L,2L,3L,5L,6L,7L,10L,11L,13L,14L,15L,3L,5L,6L,7L,10L,11L,14L,2L,3L,5L,6L,11L,14L,15L,17L,2L,3L,10L,13L,14L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165916Inst : IEnumerable<long>
{
public static readonly long[] Value=A165916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165916.Bytes);
public long this[int i]=>Value[i];

public static A165916Inst Instance=new A165916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165917
{
public static readonly long[] Value={ 0L,0L,2L,5L,5L,7L,14L,23L,16L,12L,25L,44L,31L,37L,55L,86L,56L,73L,57L,117L,100L,95L,141L,188L,117L,86L,143L,193L,138L,172L,216L,287L,233L,161L,251L,393L,231L,264L,403L,520L,319L,390L,328L,571L,552L,398L,509L,706L,442L,422L,489L,731L,429L,581L,707L,898L,657L,477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165917Inst : IEnumerable<long>
{
public static readonly long[] Value=A165917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165917.Bytes);
public long this[int i]=>Value[i];

public static A165917Inst Instance=new A165917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165918
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,2L,3L,5L,4L,3L,4L,7L,5L,5L,7L,10L,7L,8L,6L,11L,10L,8L,10L,15L,10L,8L,11L,15L,10L,12L,12L,18L,15L,11L,15L,21L,13L,13L,19L,25L,16L,19L,14L,25L,24L,17L,19L,29L,19L,18L,21L,28L,17L,22L,25L,33L,25L,18L,19L,35L,21L,22L,32L,34L,28L,29L,20L,36L,33L,31L,29L,44L,26L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165918Inst : IEnumerable<long>
{
public static readonly long[] Value=A165918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165918.Bytes);
public long this[int i]=>Value[i];

public static A165918Inst Instance=new A165918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165919
{
public static readonly long[] Value={ 4L,4L,4L,4L,4L,4L,9L,4L,9L,4L,9L,4L,9L,12L,4L,8L,9L,4L,9L,4L,9L,4L,8L,9L,16L,4L,9L,16L,4L,9L,16L,4L,9L,16L,4L,9L,16L,18L,4L,9L,12L,16L,20L,4L,8L,9L,12L,16L,18L,4L,9L,12L,16L,4L,9L,16L,24L,4L,9L,12L,16L,25L,4L,9L,16L,25L,4L,8L,9L,16L,25L,4L,9L,16L,20L,24L,25L,28L,4L,9L,16L,24L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165919Inst : IEnumerable<long>
{
public static readonly long[] Value=A165919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165919.Bytes);
public long this[int i]=>Value[i];

public static A165919Inst Instance=new A165919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165920
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,3L,6L,10L,19L,33L,62L,112L,210L,387L,728L,1360L,2570L,4845L,9198L,17459L,33288L,63519L,121574L,232960L,447392L,860265L,1657009L,3195465L,6170930L,11930100L,23091222L,44738560L,86767016L,168428805L,327235602L,636289024L,1238188770L,2411205111L,4698767640L,9162588158L,17878237850L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165920Inst : IEnumerable<long>
{
public static readonly long[] Value=A165920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165920.Bytes);
public long this[int i]=>Value[i];

public static A165920Inst Instance=new A165920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165921
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,3L,4L,9L,15L,31L,53L,105L,189L,363L,672L,1285L,2407L,4599L,8704L,16641L,31713L,60787L,116390L,223696L,429975L,828495L,1597440L,3085465L,5964488L,11545611L,22368256L,43383477L,84212475L,163617801L,318140816L,619094385L,1205595657L,2349383715L,4581280972L,8939118925L,17452532040L,34093383807L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165921Inst : IEnumerable<long>
{
public static readonly long[] Value=A165921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165921.Bytes);
public long this[int i]=>Value[i];

public static A165921Inst Instance=new A165921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165922
{
public static readonly long[] Value={ 1L,2L,2L,5L,1L,7L,5L,3L,2L,3L,1L,5L,9L,5L,3L,7L,8L,8L,7L,8L,0L,2L,9L,4L,7L,7L,7L,4L,0L,2L,8L,8L,2L,0L,9L,8L,0L,8L,8L,3L,0L,8L,1L,0L,6L,7L,4L,8L,1L,4L,2L,3L,6L,7L,2L,8L,8L,7L,4L,8L,0L,0L,4L,5L,0L,9L,1L,1L,7L,8L,4L,5L,2L,1L,5L,3L,9L,3L,2L,8L,7L,7L,4L,2L,3L,0L,6L,6L,7L,3L,0L,7L,1L,8L,1L,5L,7L,5L,3L,1L,5L,7L,2L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165922Inst : IEnumerable<long>
{
public static readonly long[] Value=A165922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165922.Bytes);
public long this[int i]=>Value[i];

public static A165922Inst Instance=new A165922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165923
{
public static readonly long[] Value={ 0L,0L,0L,0L,4L,4L,4L,4L,4L,13L,13L,13L,25L,21L,13L,13L,37L,29L,29L,29L,47L,61L,67L,41L,53L,66L,54L,62L,126L,78L,128L,54L,93L,112L,54L,82L,157L,162L,129L,134L,208L,136L,154L,122L,130L,211L,239L,90L,192L,207L,157L,239L,327L,286L,248L,251L,290L,362L,319L,248L,459L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165923Inst : IEnumerable<long>
{
public static readonly long[] Value=A165923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165923.Bytes);
public long this[int i]=>Value[i];

public static A165923Inst Instance=new A165923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165924
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,1L,1L,1L,2L,2L,2L,3L,3L,2L,2L,4L,3L,3L,3L,4L,5L,6L,4L,4L,5L,4L,5L,7L,5L,8L,4L,6L,7L,4L,5L,8L,8L,7L,7L,10L,7L,7L,7L,6L,11L,12L,5L,9L,8L,7L,9L,11L,10L,9L,10L,10L,12L,12L,9L,14L,15L,8L,6L,9L,12L,12L,11L,14L,11L,20L,10L,17L,14L,9L,13L,10L,13L,18L,8L,12L,17L,17L,11L,12L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165924Inst : IEnumerable<long>
{
public static readonly long[] Value=A165924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165924.Bytes);
public long this[int i]=>Value[i];

public static A165924Inst Instance=new A165924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165925
{
public static readonly long[] Value={ 8L,8L,8L,8L,8L,12L,8L,12L,8L,12L,12L,8L,12L,8L,12L,18L,8L,12L,18L,8L,12L,20L,8L,18L,20L,8L,18L,20L,8L,12L,18L,20L,8L,18L,20L,24L,8L,12L,18L,20L,24L,12L,18L,20L,24L,27L,8L,12L,18L,27L,8L,12L,18L,20L,27L,28L,12L,24L,27L,8L,12L,18L,20L,24L,27L,28L,8L,18L,20L,24L,28L,32L,12L,20L,24L,27L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165925Inst : IEnumerable<long>
{
public static readonly long[] Value=A165925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165925.Bytes);
public long this[int i]=>Value[i];

public static A165925Inst Instance=new A165925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165926
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,8L,8L,8L,8L,8L,12L,20L,20L,12L,20L,38L,38L,40L,26L,20L,46L,58L,70L,82L,101L,65L,113L,63L,137L,130L,111L,169L,141L,102L,97L,130L,125L,91L,163L,145L,177L,213L,177L,149L,298L,244L,278L,378L,296L,260L,301L,393L,390L,407L,335L,378L,449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165926Inst : IEnumerable<long>
{
public static readonly long[] Value=A165926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165926.Bytes);
public long this[int i]=>Value[i];

public static A165926Inst Instance=new A165926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165927
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,2L,2L,1L,2L,3L,3L,3L,2L,1L,3L,4L,4L,5L,5L,4L,6L,3L,7L,6L,5L,8L,7L,5L,5L,6L,6L,4L,7L,7L,7L,9L,5L,4L,11L,8L,10L,12L,10L,9L,10L,12L,11L,12L,10L,10L,13L,9L,8L,15L,18L,16L,13L,13L,14L,12L,15L,6L,16L,10L,13L,18L,15L,19L,16L,11L,21L,18L,14L,14L,20L,20L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165927Inst : IEnumerable<long>
{
public static readonly long[] Value=A165927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165927.Bytes);
public long this[int i]=>Value[i];

public static A165927Inst Instance=new A165927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165928
{
public static readonly BigInteger[] Value={ 1L,6L,176L,22016L,11206656L,22917677056L,187672890966016L,6149102341220990976L,BigInteger.Parse("805956695324444019654656"),BigInteger.Parse("422551006026622876918350872576"),BigInteger.Parse("886152419740143991345671872421298176") };
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
public class A165928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165928Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A165928.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A165928.Bytes);
public BigInteger this[int i]=>Value[i];

public static A165928Inst Instance=new A165928Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165929
{
public static readonly long[] Value={ 1L,1L,3L,6L,12L,24L,48L,120L,264L,480L,1104L,2064L,4128L,10752L,19320L,38328L,91992L,170016L,369600L,745560L,1854720L,3845760L,7765296L,14990520L,29910120L,59856720L,119710416L,298755600L,667297320L,1446528360L,4011171840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165929Inst : IEnumerable<long>
{
public static readonly long[] Value=A165929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165929.Bytes);
public long this[int i]=>Value[i];

public static A165929Inst Instance=new A165929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165930
{
public static readonly long[] Value={ 1L,1L,2L,3L,2L,3L,6L,6L,8L,6L,4L,8L,6L,8L,7L,2L,2L,6L,5L,4L,12L,8L,8L,4L,4L,12L,8L,4L,12L,10L,6L,4L,8L,8L,12L,16L,4L,8L,8L,8L,4L,8L,8L,4L,4L,8L,8L,4L,4L,12L,8L,4L,16L,4L,12L,4L,8L,8L,4L,4L,16L,8L,12L,8L,8L,8L,18L,18L,12L,8L,8L,4L,8L,4L,8L,4L,4L,16L,4L,4L,16L,4L,8L,8L,8L,4L,8L,4L,24L,8L,4L,12L,8L,8L,4L,4L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165930Inst : IEnumerable<long>
{
public static readonly long[] Value=A165930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165930.Bytes);
public long this[int i]=>Value[i];

public static A165930Inst Instance=new A165930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165931
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,6L,8L,22L,24L,44L,112L,120L,176L,520L,692L,1732L,1440L,2592L,4032L,6480L,11088L,18720L,23760L,43200L,69984L,123120L,174960L,321732L,408240L,641520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165931Inst : IEnumerable<long>
{
public static readonly long[] Value=A165931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165931.Bytes);
public long this[int i]=>Value[i];

public static A165931Inst Instance=new A165931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165932
{
public static readonly long[] Value={ 22L,33L,44L,55L,66L,77L,88L,99L,111L,121L,141L,171L,181L,191L,222L,232L,242L,282L,292L,313L,323L,333L,343L,353L,373L,414L,444L,454L,464L,484L,494L,505L,545L,555L,565L,575L,595L,616L,626L,646L,656L,666L,676L,686L,717L,727L,737L,757L,767L,787L,797L,818L,828L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165932Inst : IEnumerable<long>
{
public static readonly long[] Value=A165932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165932.Bytes);
public long this[int i]=>Value[i];

public static A165932Inst Instance=new A165932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165933
{
public static readonly BigInteger[] Value={ 1L,4L,35L,536L,16775L,1060976L,135007759L,34460631520L,17617985239071L,18027600169142208L,BigInteger.Parse("36907002795598798911"),BigInteger.Parse("151143401509104346210176"),BigInteger.Parse("1238053384151947477501575295"),BigInteger.Parse("20283338091738780737237428502272") };
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
public class A165933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165933Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A165933.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A165933.Bytes);
public BigInteger this[int i]=>Value[i];

public static A165933Inst Instance=new A165933Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165934
{
public static readonly long[] Value={ 11L,80651L,67L,251L,368881L,80651L,23L,1451L,251L,23L,10093L,61L,362927L,363269L,10093L,372973L,263L,10111L,59L,362941L,107L,363773L,10139L,107L,364513L,10139L,725827L,263L,365173L,364513L,12967L,737287L,10093L,10111L,374041L,776401L,162727L,725827L,725827L,368647L,10093L,263L,363269L,257L,363157L,80657L,443543L,73L,444971L,727211L,735853L,735853L,19L,29L,109L,363271L,20173L,17L,257L,10099L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165934Inst : IEnumerable<long>
{
public static readonly long[] Value=A165934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165934.Bytes);
public long this[int i]=>Value[i];

public static A165934Inst Instance=new A165934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165935
{
public static readonly long[] Value={ 1L,-242L,2883L,-13924L,45125L,-115926L,255367L,-504008L,915849L,-1560250L,2523851L,-3912492L,5853133L,-8495774L,12015375L,-16613776L,22521617L,-30000258L,39343699L,-50880500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165935Inst : IEnumerable<long>
{
public static readonly long[] Value=A165935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165935.Bytes);
public long this[int i]=>Value[i];

public static A165935Inst Instance=new A165935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165936
{
public static readonly long[] Value={ 1309L,1310L,1311L,1885L,1886L,1887L,2013L,2014L,2015L,2665L,2666L,2667L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165936Inst : IEnumerable<long>
{
public static readonly long[] Value=A165936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165936.Bytes);
public long this[int i]=>Value[i];

public static A165936Inst Instance=new A165936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165937
{
public static readonly BigInteger[] Value={ 1L,2L,19L,964L,334965L,742714950L,10042408885191L,814556580116590856L,BigInteger.Parse("393147641272746246076745"),BigInteger.Parse("1123539400297807898234860367690"),BigInteger.Parse("18948227277012085227250633551784337179"),BigInteger.Parse("1881331163508674280605070386666674939623268684") };
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
public class A165937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165937Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A165937.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A165937.Bytes);
public BigInteger this[int i]=>Value[i];

public static A165937Inst Instance=new A165937Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165938
{
public static readonly BigInteger[] Value={ 2L,34L,2786L,1331714L,3710155682L,60245508192802L,5701755387019728962L,BigInteger.Parse("3145168096065837266706434"),BigInteger.Parse("10111847525912679844192131854786"),BigInteger.Parse("189482250299273866835746159841800035874"),BigInteger.Parse("20694642381734231604510939638726181796865594402") };
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
public class A165938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165938Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A165938.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A165938.Bytes);
public BigInteger this[int i]=>Value[i];

public static A165938Inst Instance=new A165938Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165939
{
public static readonly BigInteger[] Value={ 1L,23L,506L,11132L,244904L,5387888L,118533536L,2607737792L,57370231424L,1262145091328L,27767192008963L,610878224191620L,13439320932093441L,295665060503367324L,6504631331014936812L,BigInteger.Parse("143101889281027434912") };
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
public class A165939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165939Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A165939.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A165939.Bytes);
public BigInteger this[int i]=>Value[i];

public static A165939Inst Instance=new A165939Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165940
{
public static readonly BigInteger[] Value={ 1L,2L,10L,152L,7684L,1352096L,852120928L,1960591940480L,16697154282192928L,BigInteger.Parse("531801639623740649984"),BigInteger.Parse("63854080509077223292639744"),BigInteger.Parse("29089348119991257994736112048128") };
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
public class A165940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165940Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A165940.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A165940.Bytes);
public BigInteger this[int i]=>Value[i];

public static A165940Inst Instance=new A165940Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165941
{
public static readonly long[] Value={ 1L,2L,2L,6L,10L,18L,42L,78L,154L,314L,626L,1246L,2498L,4994L,9970L,19974L,39930L,79826L,159706L,319374L,638714L,1277530L,2554978L,5109854L,10219922L,20439714L,40879234L,81758854L,163517466L,327034514L,654069866L,1308139246L,2616277578L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165941Inst : IEnumerable<long>
{
public static readonly long[] Value=A165941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165941.Bytes);
public long this[int i]=>Value[i];

public static A165941Inst Instance=new A165941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165942
{
public static readonly long[] Value={ 3418L,16777500L,2520413L,3418L,16777500L,2520413L,3418L,16777500L,2520413L,3418L,16777500L,2520413L,3418L,16777500L,2520413L,3418L,16777500L,2520413L,3418L,16777500L,2520413L,3418L,16777500L,2520413L,3418L,16777500L,2520413L,3418L,16777500L,2520413L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165942Inst : IEnumerable<long>
{
public static readonly long[] Value=A165942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165942.Bytes);
public long this[int i]=>Value[i];

public static A165942Inst Instance=new A165942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165943
{
public static readonly long[] Value={ 0L,77L,63L,525L,56L,1365L,483L,2597L,210L,4221L,1295L,6237L,462L,8645L,2499L,11445L,812L,14637L,4095L,18221L,1260L,22197L,6083L,26565L,1806L,31325L,8463L,36477L,2450L,42021L,11235L,47957L,3192L,54285L,14399L,61005L,4032L,68117L,17955L,75621L,4970L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165943Inst : IEnumerable<long>
{
public static readonly long[] Value=A165943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165943.Bytes);
public long this[int i]=>Value[i];

public static A165943Inst Instance=new A165943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165944
{
public static readonly long[] Value={ 11L,19L,41L,71L,419L,599L,929L,1481L,1979L,2351L,2969L,3659L,4691L,13109L,19181L,19739L,25121L,27059L,30449L,32579L,53129L,57839L,66821L,69959L,86729L,98909L,122849L,125669L,129959L,140249L,144779L,176819L,202949L,219491L,250499L,254519L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165944Inst : IEnumerable<long>
{
public static readonly long[] Value=A165944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165944.Bytes);
public long this[int i]=>Value[i];

public static A165944Inst Instance=new A165944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165945
{
public static readonly long[] Value={ 29L,67L,5849L,3375149L,7078079L,7762589L,11852579L,17173769L,42144539L,46656359L,80621999L,87528827L,91125449L,102503699L,132651509L,142237169L,173741669L,264609929L,287496659L,320014187L,567664379L,686129849L,700227959L,851972339L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165945Inst : IEnumerable<long>
{
public static readonly long[] Value=A165945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165945.Bytes);
public long this[int i]=>Value[i];

public static A165945Inst Instance=new A165945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165946
{
public static readonly long[] Value={ 3L,11L,223L,1741L,5851L,27031L,74131L,216061L,1061311L,1259821L,2000503L,4251691L,5832181L,13824241L,21024853L,30371641L,37933393L,49028263L,54010531L,67917721L,84028111L,123506491L,162771883L,185193571L,191103553L,216000601L,229221541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165946Inst : IEnumerable<long>
{
public static readonly long[] Value=A165946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165946.Bytes);
public long this[int i]=>Value[i];

public static A165946Inst Instance=new A165946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165947
{
public static readonly long[] Value={ 11L,19L,23L,31L,43L,47L,53L,59L,67L,71L,73L,79L,83L,101L,103L,107L,113L,127L,131L,139L,151L,157L,163L,167L,173L,179L,191L,193L,199L,211L,223L,227L,233L,239L,241L,251L,263L,269L,271L,283L,293L,307L,311L,313L,331L,347L,353L,359L,367L,373L,379L,383L,409L,419L,421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165947Inst : IEnumerable<long>
{
public static readonly long[] Value=A165947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165947.Bytes);
public long this[int i]=>Value[i];

public static A165947Inst Instance=new A165947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165948
{
public static readonly long[] Value={ 2376L,866L,367L,8737L,282876L,24626L,7347L,74383L,6246L,68383L,3439L,6623L,3623L,87323L,2286723L,784623L,343247347L,3432474383L,343246246L,3432468383L,834683L,834684866L,834684367L,8346848737L,834684282876L,83468424626L,8346847347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165948Inst : IEnumerable<long>
{
public static readonly long[] Value=A165948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165948.Bytes);
public long this[int i]=>Value[i];

public static A165948Inst Instance=new A165948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165949
{
public static readonly long[] Value={ 1L,1L,7L,1L,11L,91L,1L,17L,133L,11L,23L,91L,1L,29L,2387L,17L,1L,63973L,1L,451L,301L,23L,47L,1547L,11L,53L,133L,29L,59L,1892891L,1L,17L,10787L,1L,781L,4670029L,1L,1L,553L,7667L,83L,113477L,1L,2047L,45353L,47L,1L,150059L,1L,1111L,721L,53L,107L,6973057L,253L,55709L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165949Inst : IEnumerable<long>
{
public static readonly long[] Value=A165949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165949.Bytes);
public long this[int i]=>Value[i];

public static A165949Inst Instance=new A165949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165950
{
public static readonly BigInteger[] Value={ 2L,12L,216L,10600L,1306620L,384471444L,261548825328L,402632012394000L,1381332938730123060L,BigInteger.Parse("10440873023366019273820"),BigInteger.Parse("172308823347127690038311496") };
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
public class A165950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165950Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A165950.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A165950.Bytes);
public BigInteger this[int i]=>Value[i];

public static A165950Inst Instance=new A165950Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165951
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,0L,0L,1L,3L,0L,3L,0L,0L,1L,5L,0L,3L,0L,1L,7L,0L,5L,3L,0L,0L,0L,5L,3L,0L,0L,5L,5L,0L,3L,0L,7L,0L,1L,11L,0L,5L,0L,13L,0L,0L,9L,3L,7L,5L,0L,0L,15L,0L,7L,0L,13L,0L,11L,0L,0L,3L,0L,3L,19L,0L,0L,3L,0L,5L,0L,0L,19L,9L,0L,3L,17L,0L,0L,0L,0L,9L,0L,21L,0L,15L,5L,0L,0L,0L,7L,7L,25L,7L,9L,3L,21L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165951Inst : IEnumerable<long>
{
public static readonly long[] Value=A165951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165951.Bytes);
public long this[int i]=>Value[i];

public static A165951Inst Instance=new A165951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165952
{
public static readonly long[] Value={ 3L,6L,7L,5L,5L,2L,5L,9L,6L,9L,4L,7L,8L,6L,1L,3L,6L,6L,3L,4L,0L,8L,8L,4L,3L,3L,2L,2L,0L,8L,6L,4L,6L,2L,9L,4L,2L,6L,4L,9L,2L,4L,3L,2L,0L,2L,4L,4L,4L,2L,7L,1L,0L,1L,8L,6L,6L,2L,4L,4L,0L,1L,3L,5L,2L,7L,3L,5L,3L,5L,3L,5L,6L,4L,6L,1L,7L,9L,8L,6L,3L,2L,2L,6L,9L,2L,0L,0L,1L,9L,2L,1L,5L,4L,4L,7L,2L,5L,9L,4L,7L,1L,7L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165952Inst : IEnumerable<long>
{
public static readonly long[] Value=A165952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165952.Bytes);
public long this[int i]=>Value[i];

public static A165952Inst Instance=new A165952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165953
{
public static readonly long[] Value={ 6L,6L,4L,9L,0L,8L,8L,9L,4L,2L,0L,5L,3L,2L,6L,6L,4L,3L,1L,1L,4L,4L,2L,8L,4L,4L,6L,7L,0L,8L,6L,3L,3L,7L,1L,6L,1L,6L,4L,8L,7L,6L,5L,8L,0L,5L,5L,5L,6L,9L,1L,9L,3L,8L,1L,0L,5L,7L,5L,9L,2L,6L,0L,5L,7L,2L,2L,9L,6L,4L,7L,1L,8L,1L,8L,7L,7L,3L,2L,5L,9L,7L,4L,9L,7L,0L,8L,9L,0L,0L,2L,6L,9L,2L,0L,9L,2L,5L,9L,8L,9L,8L,2L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165953Inst : IEnumerable<long>
{
public static readonly long[] Value=A165953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165953.Bytes);
public long this[int i]=>Value[i];

public static A165953Inst Instance=new A165953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165954
{
public static readonly long[] Value={ 6L,0L,5L,4L,6L,1L,3L,8L,2L,9L,1L,2L,5L,2L,5L,5L,8L,3L,3L,8L,6L,2L,6L,5L,2L,0L,5L,1L,2L,8L,0L,4L,4L,4L,9L,0L,3L,0L,0L,8L,4L,5L,4L,0L,8L,8L,0L,1L,4L,2L,8L,8L,9L,3L,3L,2L,0L,0L,9L,3L,5L,0L,0L,0L,8L,3L,8L,2L,9L,5L,6L,8L,3L,8L,2L,0L,7L,2L,7L,2L,7L,8L,5L,3L,6L,2L,4L,2L,6L,2L,5L,9L,6L,8L,8L,1L,3L,0L,5L,1L,9L,3L,2L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165954Inst : IEnumerable<long>
{
public static readonly long[] Value=A165954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165954.Bytes);
public long this[int i]=>Value[i];

public static A165954Inst Instance=new A165954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165955
{
public static readonly long[] Value={ 1L,13L,21L,29L,35L,39L,47L,51L,57L,65L,71L,75L,81L,85L,93L,97L,103L,111L,115L,121L,127L,131L,137L,141L,145L,151L,159L,167L,173L,177L,181L,185L,189L,193L,199L,205L,209L,217L,221L,225L,229L,237L,241L,247L,251L,257L,263L,267L,273L,277L,285L,289L,293L,297L,305L,313L,317L,321L,325L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165955Inst : IEnumerable<long>
{
public static readonly long[] Value=A165955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165955.Bytes);
public long this[int i]=>Value[i];

public static A165955Inst Instance=new A165955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165956
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,4L,4L,2L,8L,8L,5L,6L,9L,7L,7L,4L,11L,11L,10L,10L,12L,8L,9L,10L,14L,13L,11L,11L,14L,12L,10L,4L,13L,13L,13L,13L,12L,13L,13L,14L,18L,17L,10L,15L,19L,18L,16L,13L,18L,18L,20L,17L,26L,21L,19L,21L,22L,21L,26L,24L,20L,21L,12L,5L,14L,14L,14L,14L,15L,17L,17L,19L,19L,16L,23L,22L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165956Inst : IEnumerable<long>
{
public static readonly long[] Value=A165956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165956.Bytes);
public long this[int i]=>Value[i];

public static A165956Inst Instance=new A165956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165957
{
public static readonly long[] Value={ 1L,4L,6L,8L,9L,0L,2L,4L,5L,6L,8L,0L,2L,4L,8L,10L,12L,14L,16L,0L,6L,9L,12L,15L,18L,24L,27L,0L,8L,16L,20L,24L,32L,36L,0L,5L,10L,20L,25L,30L,35L,40L,0L,12L,18L,24L,30L,36L,48L,54L,0L,14L,28L,35L,42L,49L,56L,0L,8L,16L,32L,40L,48L,56L,64L,0L,9L,18L,27L,36L,45L,54L,72L,81L,0L,0L,0L,0L,0L,0L,0L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165957Inst : IEnumerable<long>
{
public static readonly long[] Value=A165957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165957.Bytes);
public long this[int i]=>Value[i];

public static A165957Inst Instance=new A165957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165958
{
public static readonly long[] Value={ 0L,3L,2L,1L,6L,5L,4L,9L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165958Inst : IEnumerable<long>
{
public static readonly long[] Value=A165958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165958.Bytes);
public long this[int i]=>Value[i];

public static A165958Inst Instance=new A165958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165959
{
public static readonly long[] Value={ 2L,3L,5L,5L,5L,11L,3L,7L,3L,9L,5L,11L,7L,9L,7L,11L,15L,13L,27L,25L,21L,15L,13L,11L,5L,17L,7L,3L,11L,9L,15L,9L,21L,13L,3L,15L,13L,7L,5L,15L,11L,11L,17L,15L,27L,21L,15L,13L,7L,21L,19L,15L,9L,3L,17L,15L,7L,7L,7L,9L,9L,17L,15L,11L,9L,5L,5L,21L,17L,11L,7L,15L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165959Inst : IEnumerable<long>
{
public static readonly long[] Value=A165959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165959.Bytes);
public long this[int i]=>Value[i];

public static A165959Inst Instance=new A165959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165960
{
public static readonly long[] Value={ 3L,20L,100L,612L,4389L,35688L,325395L,3288490L,36489992L,441093864L,5770007009L,81213878830L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165960Inst : IEnumerable<long>
{
public static readonly long[] Value=A165960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165960.Bytes);
public long this[int i]=>Value[i];

public static A165960Inst Instance=new A165960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165961
{
public static readonly long[] Value={ 1L,5L,20L,102L,627L,4461L,36155L,328849L,3317272L,36757822L,443846693L,5800991345L,81593004021L,1228906816941L,19733699436636L,336554404751966L,6075478765948135L,115734570482611885L,2320148441078578447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165961Inst : IEnumerable<long>
{
public static readonly long[] Value=A165961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165961.Bytes);
public long this[int i]=>Value[i];

public static A165961Inst Instance=new A165961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165962
{
public static readonly BigInteger[] Value={ 1L,5L,18L,95L,600L,4307L,35168L,321609L,3257109L,36199762L,438126986L,5736774126L,80808984725L,1218563180295L,19587031966352L,334329804347219L,6039535339644630L,115118210694558105L,2308967760171049528L,BigInteger.Parse("48613722701436777455"),BigInteger.Parse("1072008447320752890459") };
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
public class A165962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165962Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A165962.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A165962.Bytes);
public BigInteger this[int i]=>Value[i];

public static A165962Inst Instance=new A165962Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165963
{
public static readonly long[] Value={ 0L,16L,80L,516L,3794L,31456L,290970L,2974380L,33311520L,405773448L,5342413414L,75612301688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165963Inst : IEnumerable<long>
{
public static readonly long[] Value=A165963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165963.Bytes);
public long this[int i]=>Value[i];

public static A165963Inst Instance=new A165963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165964
{
public static readonly long[] Value={ 1L,1L,0L,4L,16L,86L,542L,3932L,32330L,297438L,3028320L,33814454L,410954878L,5400878692L,76329470882L,1154445436334L,18606430004984L,318369275913710L,5764046146341198L,110091446931897180L,2212282487296335866L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165964Inst : IEnumerable<long>
{
public static readonly long[] Value=A165964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165964.Bytes);
public long this[int i]=>Value[i];

public static A165964Inst Instance=new A165964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165965
{
public static readonly BigInteger[] Value={ 1L,24L,552L,12696L,292008L,6716184L,154472232L,3552861336L,81715810728L,1879463646744L,43227663874836L,994236269114880L,22867434189496512L,525950986355068032L,12096872686089474624UL,BigInteger.Parse("278228071778284843776") };
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
public class A165965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165965Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A165965.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A165965.Bytes);
public BigInteger this[int i]=>Value[i];

public static A165965Inst Instance=new A165965Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165966
{
public static readonly long[] Value={ 36L,120L,276L,300L,2556L,3240L,5460L,8256L,12720L,23436L,26796L,34980L,41616L,46056L,56616L,59340L,103740L,122760L,139656L,147696L,157080L,185136L,195000L,231540L,277140L,333336L,353220L,386760L,401856L,516636L,609960L,860016L,1001820L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165966Inst : IEnumerable<long>
{
public static readonly long[] Value=A165966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165966.Bytes);
public long this[int i]=>Value[i];

public static A165966Inst Instance=new A165966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165967
{
public static readonly BigInteger[] Value={ 1L,25L,600L,14400L,345600L,8294400L,199065600L,4777574400L,114661785600L,2751882854400L,66045188505300L,1585084524120000L,38042028578707500L,913008685884840000L,BigInteger.Parse("21912208461136800000"),BigInteger.Parse("525893003064898560000") };
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
public class A165967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165967Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A165967.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A165967.Bytes);
public BigInteger this[int i]=>Value[i];

public static A165967Inst Instance=new A165967Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165968
{
public static readonly BigInteger[] Value={ 0L,1L,2L,10L,68L,604L,6584L,85048L,1269680L,21505552L,407414816L,8535396256L,195927013952L,4890027052480L,131842951699328L,3818743350945664L,118253903175951104L,3898687202158805248L,BigInteger.Parse("136339489775029813760"),BigInteger.Parse("5040776996774472673792") };
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
public class A165968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165968Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A165968.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A165968.Bytes);
public BigInteger this[int i]=>Value[i];

public static A165968Inst Instance=new A165968Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165969
{
public static readonly long[] Value={ 3L,16L,5L,90L,36L,14L,576L,252L,128L,54L,4200L,1920L,1080L,600L,264L,34560L,16200L,9600L,5940L,3456L,1560L,317520L,151200L,92400L,60480L,39312L,23520L,10800L,3225600L,1552320L,967680L,655200L,451584L,302400L,184320L,85680L,35925120L,17418240L,11007360L,7620480L,5443200L,3870720L,2643840L,1632960L,766080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165969Inst : IEnumerable<long>
{
public static readonly long[] Value=A165969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165969.Bytes);
public long this[int i]=>Value[i];

public static A165969Inst Instance=new A165969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165970
{
public static readonly BigInteger[] Value={ 1L,12L,14515200L,BigInteger.Parse("420505587390873600000"),BigInteger.Parse("6848282921689337839624757371207680000000000"),BigInteger.Parse("592617982969061328644755583860005865281724398591341934673920000000000000000") };
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
public class A165970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165970Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A165970.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A165970.Bytes);
public BigInteger this[int i]=>Value[i];

public static A165970Inst Instance=new A165970Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165971
{
public static readonly long[] Value={ 1L,5L,9L,13L,15L,15L,19L,19L,21L,25L,27L,27L,29L,29L,33L,33L,35L,39L,39L,41L,43L,43L,45L,45L,45L,47L,51L,55L,57L,57L,57L,57L,57L,57L,59L,61L,61L,65L,65L,65L,65L,69L,69L,71L,71L,73L,75L,75L,77L,77L,81L,81L,81L,81L,85L,89L,89L,89L,89L,89L,91L,91L,91L,91L,91L,93L,97L,99L,99L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165971Inst : IEnumerable<long>
{
public static readonly long[] Value=A165971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165971.Bytes);
public long this[int i]=>Value[i];

public static A165971Inst Instance=new A165971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165972
{
public static readonly long[] Value={ 1L,4L,6L,10L,12L,16L,18L,22L,28L,30L,36L,40L,42L,46L,52L,58L,60L,66L,70L,72L,78L,82L,88L,96L,100L,102L,106L,108L,112L,126L,130L,136L,138L,148L,150L,156L,162L,166L,172L,178L,180L,190L,192L,196L,198L,210L,222L,226L,228L,232L,238L,240L,250L,256L,262L,268L,270L,276L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165972Inst : IEnumerable<long>
{
public static readonly long[] Value=A165972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165972.Bytes);
public long this[int i]=>Value[i];

public static A165972Inst Instance=new A165972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165973
{
public static readonly BigInteger[] Value={ 1L,26L,650L,16250L,406250L,10156250L,253906250L,6347656250L,158691406250L,3967285156250L,99182128905925L,2479553222640000L,61988830565797200L,1549720764139860000L,BigInteger.Parse("38743019103369750000"),BigInteger.Parse("968575477581075000000") };
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
public class A165973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165973Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A165973.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A165973.Bytes);
public BigInteger this[int i]=>Value[i];

public static A165973Inst Instance=new A165973Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165974
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,3L,0L,0L,1L,2L,3L,5L,0L,0L,0L,1L,2L,3L,4L,5L,7L,9L,0L,0L,0L,1L,1L,2L,3L,4L,6L,7L,9L,11L,0L,0L,0L,0L,1L,2L,2L,3L,4L,5L,7L,8L,9L,11L,13L,15L,0L,0L,0L,0L,1L,1L,2L,3L,4L,5L,6L,7L,8L,10L,11L,13L,15L,17L,0L,0L,0L,0L,1L,1L,2L,2L,3L,4L,5L,6L,7L,8L,9L,11L,12L,14L,15L,17L,19L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165974Inst : IEnumerable<long>
{
public static readonly long[] Value=A165974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165974.Bytes);
public long this[int i]=>Value[i];

public static A165974Inst Instance=new A165974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165975
{
public static readonly BigInteger[] Value={ 1L,2L,112L,261360L,27983155200L,143829595278720000L,BigInteger.Parse("36441048083860298170220544"),BigInteger.Parse("463109968103790656729135319264000000"),BigInteger.Parse("298869615482782118878970689211942578421760000000") };
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
public class A165975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165975Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A165975.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A165975.Bytes);
public BigInteger this[int i]=>Value[i];

public static A165975Inst Instance=new A165975Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165976
{
public static readonly long[] Value={ 1L,3L,17L,117L,887L,7131L,59661L,513897L,4526603L,40588263L,369277481L,3400840845L,31644776383L,297079014771L,2810553697989L,26770090211793L,256510096740243L,2470981627433919L,23916768109136289L,232485664356533877L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165976Inst : IEnumerable<long>
{
public static readonly long[] Value=A165976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165976.Bytes);
public long this[int i]=>Value[i];

public static A165976Inst Instance=new A165976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165977
{
public static readonly long[] Value={ 11L,59L,83L,103L,131L,251L,419L,563L,607L,659L,971L,1063L,1091L,1103L,1427L,1447L,1811L,1931L,1979L,2287L,2383L,2411L,2543L,2939L,3251L,3299L,3659L,3779L,3967L,4091L,4259L,4931L,5099L,5171L,5407L,5783L,5939L,6247L,6299L,6607L,6779L,6899L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165977Inst : IEnumerable<long>
{
public static readonly long[] Value=A165977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165977.Bytes);
public long this[int i]=>Value[i];

public static A165977Inst Instance=new A165977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165978
{
public static readonly long[] Value={ 2L,7L,71L,79L,113L,29L,97L,971L,83L,277L,163L,233L,37L,53L,59L,197L,73L,43L,431L,479L,1597L,15971L,383L,1277L,43L,431L,479L,1597L,15971L,383L,1277L,43L,431L,479L,1597L,15971L,383L,1277L,43L,431L,479L,1597L,15971L,383L,1277L,43L,431L,479L,1597L,15971L,383L,1277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165978Inst : IEnumerable<long>
{
public static readonly long[] Value=A165978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165978.Bytes);
public long this[int i]=>Value[i];

public static A165978Inst Instance=new A165978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165979
{
public static readonly BigInteger[] Value={ 1L,27L,702L,18252L,474552L,12338352L,320797152L,8340725952L,216858874752L,5638330743552L,146596599332001L,3811511582622900L,99099301147958475L,2576581829840760300L,BigInteger.Parse("66991127575699606500"),BigInteger.Parse("1741769316964025575200") };
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
public class A165979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165979Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A165979.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A165979.Bytes);
public BigInteger this[int i]=>Value[i];

public static A165979Inst Instance=new A165979Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165980
{
public static readonly BigInteger[] Value={ 1L,28L,756L,20412L,551124L,14880348L,401769396L,10847773692L,292889889684L,7908027021468L,213516729579258L,5764951698629760L,155653695862728336L,4202649788286235104L,BigInteger.Parse("113471544283527738672"),BigInteger.Parse("3063731695649832497472") };
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
public class A165980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165980Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A165980.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A165980.Bytes);
public BigInteger this[int i]=>Value[i];

public static A165980Inst Instance=new A165980Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165981
{
public static readonly long[] Value={ 17L,43L,61L,73L,271L,313L,331L,373L,397L,409L,521L,691L,733L,751L,773L,859L,1051L,1063L,1153L,1171L,1231L,1459L,1613L,1669L,1759L,1823L,1933L,2053L,2131L,2473L,2551L,2707L,2843L,2917L,2953L,2999L,3163L,3221L,3331L,3371L,3469L,3517L,3541L,3583L,3671L,3719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165981Inst : IEnumerable<long>
{
public static readonly long[] Value=A165981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165981.Bytes);
public long this[int i]=>Value[i];

public static A165981Inst Instance=new A165981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165982
{
public static readonly long[] Value={ 19L,53L,101L,113L,163L,191L,227L,239L,353L,443L,461L,491L,523L,569L,593L,683L,821L,887L,1019L,1103L,1123L,1289L,1307L,1319L,1481L,1693L,1721L,1783L,1811L,1871L,1997L,2203L,2237L,2273L,2333L,2459L,2741L,2789L,3001L,3023L,3089L,3251L,3313L,3373L,3407L,3491L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165982Inst : IEnumerable<long>
{
public static readonly long[] Value=A165982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165982.Bytes);
public long this[int i]=>Value[i];

public static A165982Inst Instance=new A165982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165983
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,4L,1L,1L,1L,4L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,4L,1L,1L,1L,4L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,4L,1L,1L,1L,4L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,4L,1L,1L,1L,4L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,4L,1L,1L,1L,4L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,4L,1L,1L,1L,4L,1L,1L,1L,2L,1L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165983Inst : IEnumerable<long>
{
public static readonly long[] Value=A165983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165983.Bytes);
public long this[int i]=>Value[i];

public static A165983Inst Instance=new A165983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165984
{
public static readonly BigInteger[] Value={ 1L,36L,3654L,766480L,275234400L,151111164204L,117774526188844L,123672890985095232L,BigInteger.Parse("168324948170849366820"),BigInteger.Parse("288216356245328994082600"),BigInteger.Parse("606320062786763763996747618"),BigInteger.Parse("1537230010624231669678572481296") };
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
public class A165984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165984Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A165984.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A165984.Bytes);
public BigInteger this[int i]=>Value[i];

public static A165984Inst Instance=new A165984Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165985
{
public static readonly long[] Value={ 23L,31L,67L,79L,139L,151L,167L,181L,277L,337L,379L,433L,479L,541L,641L,709L,739L,757L,797L,811L,919L,1069L,1087L,1237L,1279L,1399L,1619L,1697L,1787L,1801L,1951L,2083L,2137L,2207L,2311L,2503L,2557L,2659L,2713L,2767L,2833L,2939L,3049L,3061L,3079L,3169L,3301L,3547L,3677L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165985Inst : IEnumerable<long>
{
public static readonly long[] Value=A165985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165985.Bytes);
public long this[int i]=>Value[i];

public static A165985Inst Instance=new A165985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165986
{
public static readonly long[] Value={ 6L,14L,26L,38L,74L,86L,134L,158L,194L,206L,218L,254L,326L,386L,446L,458L,554L,614L,626L,698L,758L,794L,878L,914L,926L,974L,998L,1226L,1286L,1346L,1478L,1514L,1538L,1646L,1706L,1718L,1754L,1766L,1814L,1874L,1934L,2018L,2174L,2186L,2426L,2558L,2594L,2606L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165986Inst : IEnumerable<long>
{
public static readonly long[] Value=A165986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165986.Bytes);
public long this[int i]=>Value[i];

public static A165986Inst Instance=new A165986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165987
{
public static readonly long[] Value={ 1099258818702L,8792791182238L,29674231047422L,70337212371066L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165987Inst : IEnumerable<long>
{
public static readonly long[] Value=A165987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165987.Bytes);
public long this[int i]=>Value[i];

public static A165987Inst Instance=new A165987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165988
{
public static readonly long[] Value={ 0L,3L,12L,9L,24L,15L,36L,21L,48L,27L,60L,33L,72L,39L,84L,45L,96L,51L,108L,57L,120L,63L,132L,69L,144L,75L,156L,81L,168L,87L,180L,93L,192L,99L,204L,105L,216L,111L,228L,117L,240L,123L,252L,129L,264L,135L,276L,141L,288L,147L,300L,153L,312L,159L,324L,165L,336L,171L,348L,177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165988Inst : IEnumerable<long>
{
public static readonly long[] Value=A165988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165988.Bytes);
public long this[int i]=>Value[i];

public static A165988Inst Instance=new A165988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165989
{
public static readonly long[] Value={ 534L,659L,1727L,1852L,2920L,3045L,4113L,4238L,5306L,5431L,6499L,6624L,7692L,7817L,8885L,9010L,10078L,10203L,11271L,11396L,12464L,12589L,13657L,13782L,14850L,14975L,16043L,16168L,17236L,17361L,18429L,18554L,19622L,19747L,20815L,20940L,22008L,22133L,23201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165989Inst : IEnumerable<long>
{
public static readonly long[] Value=A165989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165989.Bytes);
public long this[int i]=>Value[i];

public static A165989Inst Instance=new A165989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165990
{
public static readonly long[] Value={ 3L,7L,12L,15L,99L,188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165990Inst : IEnumerable<long>
{
public static readonly long[] Value=A165990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165990.Bytes);
public long this[int i]=>Value[i];

public static A165990Inst Instance=new A165990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165991
{
public static readonly long[] Value={ 0L,5L,8L,9L,10L,11L,13L,14L,17L,19L,20L,21L,22L,23L,24L,25L,26L,27L,29L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L,85L,86L,87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165991Inst : IEnumerable<long>
{
public static readonly long[] Value=A165991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165991.Bytes);
public long this[int i]=>Value[i];

public static A165991Inst Instance=new A165991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165992
{
public static readonly long[] Value={ 1L,3L,3L,9L,12L,12L,27L,39L,51L,51L,81L,120L,171L,222L,222L,243L,363L,534L,756L,978L,978L,729L,1092L,1626L,2382L,3360L,4338L,4338L,2187L,3279L,4905L,7287L,10647L,14985L,19323L,19323L,6561L,9840L,14745L,22032L,32679L,47664L,66987L,86310L,86310L,19683L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165992Inst : IEnumerable<long>
{
public static readonly long[] Value=A165992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165992.Bytes);
public long this[int i]=>Value[i];

public static A165992Inst Instance=new A165992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165993
{
public static readonly long[] Value={ 0L,1L,4L,11L,31L,44L,80L,103L,157L,252L,293L,420L,520L,575L,695L,884L,1105L,1180L,1431L,1617L,1704L,2007L,2217L,2552L,3040L,3300L,3439L,3713L,3852L,4144L,5255L,5595L,6120L,6305L,7252L,7457L,8060L,8695L,9141L,9804L,10507L,10740L,11983L,12224L,12740L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165993Inst : IEnumerable<long>
{
public static readonly long[] Value=A165993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165993.Bytes);
public long this[int i]=>Value[i];

public static A165993Inst Instance=new A165993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165994
{
public static readonly long[] Value={ 0L,1L,2L,4L,7L,9L,12L,14L,18L,23L,25L,30L,34L,36L,40L,45L,51L,53L,58L,62L,64L,70L,73L,79L,87L,90L,92L,96L,98L,102L,115L,119L,125L,127L,136L,138L,144L,150L,154L,159L,165L,167L,177L,179L,182L,184L,196L,208L,211L,213L,217L,223L,225L,235L,240L,246L,252L,254L,260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165994Inst : IEnumerable<long>
{
public static readonly long[] Value=A165994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165994.Bytes);
public long this[int i]=>Value[i];

public static A165994Inst Instance=new A165994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165995
{
public static readonly long[] Value={ 0L,1L,2L,7L,9L,16L,19L,28L,40L,54L,60L,76L,81L,100L,121L,143L,151L,177L,184L,210L,241L,272L,281L,314L,349L,386L,424L,465L,480L,522L,538L,582L,628L,677L,728L,782L,800L,856L,910L,970L,991L,1051L,1072L,1133L,1198L,1263L,1285L,1353L,1424L,1497L,1571L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165995Inst : IEnumerable<long>
{
public static readonly long[] Value=A165995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165995.Bytes);
public long this[int i]=>Value[i];

public static A165995Inst Instance=new A165995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165996
{
public static readonly long[] Value={ 1L,4L,4L,9L,13L,13L,16L,29L,42L,42L,25L,54L,96L,138L,138L,36L,90L,186L,324L,462L,462L,49L,139L,325L,649L,1111L,1573L,1573L,64L,203L,528L,1177L,2288L,3861L,5434L,5434L,81L,284L,812L,1989L,4277L,8138L,13572L,19006L,19006L,100L,384L,1196L,3185L,7462L,15600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165996Inst : IEnumerable<long>
{
public static readonly long[] Value=A165996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165996.Bytes);
public long this[int i]=>Value[i];

public static A165996Inst Instance=new A165996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165997
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,1L,3L,5L,1L,4L,9L,9L,1L,5L,14L,23L,23L,1L,6L,20L,43L,66L,1L,7L,27L,70L,136L,136L,1L,8L,35L,105L,241L,377L,377L,1L,9L,44L,149L,390L,767L,1144L,1L,10L,54L,203L,593L,1360L,2504L,2504L,1L,11L,65L,268L,861L,2221L,4725L,7229L,7229L,1L,12L,77L,345L,1206L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165997Inst : IEnumerable<long>
{
public static readonly long[] Value=A165997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165997.Bytes);
public long this[int i]=>Value[i];

public static A165997Inst Instance=new A165997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165998
{
public static readonly long[] Value={ 1L,6L,3L,12L,5L,18L,7L,24L,9L,30L,11L,36L,13L,42L,15L,48L,17L,54L,19L,60L,21L,66L,23L,72L,25L,78L,27L,84L,29L,90L,31L,96L,33L,102L,35L,108L,37L,114L,39L,120L,41L,126L,43L,132L,45L,138L,47L,144L,49L,150L,51L,156L,53L,162L,55L,168L,57L,174L,59L,180L,61L,186L,63L,192L,65L,198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165998Inst : IEnumerable<long>
{
public static readonly long[] Value=A165998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165998.Bytes);
public long this[int i]=>Value[i];

public static A165998Inst Instance=new A165998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165999
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,3L,2L,1L,4L,5L,1L,5L,9L,1L,6L,14L,9L,1L,7L,20L,23L,1L,8L,27L,43L,1L,9L,35L,70L,1L,10L,44L,105L,70L,1L,11L,54L,149L,175L,1L,12L,65L,203L,324L,1L,13L,77L,268L,527L,1L,14L,90L,345L,795L,1L,15L,104L,435L,1140L,795L,1L,16L,119L,539L,1575L,1935L,1L,17L,135L,658L,2114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165999Inst : IEnumerable<long>
{
public static readonly long[] Value=A165999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165999.Bytes);
public long this[int i]=>Value[i];

public static A165999Inst Instance=new A165999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166000
{
public static readonly long[] Value={ 12253L,14747L,65173L,83003L,93253L,95747L,109139L,147253L,176747L,213349L,255253L,282253L,284747L,287437L,305267L,311747L,315517L,336253L,338747L,364699L,365747L,444253L,452579L,471253L,525253L,554747L,583789L,633253L,716747L,741253L,743747L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166000Inst : IEnumerable<long>
{
public static readonly long[] Value=A166000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166000.Bytes);
public long this[int i]=>Value[i];

public static A166000Inst Instance=new A166000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166001
{
public static readonly long[] Value={ 751379L,2414507L,2839621L,3170371L,4469629L,5736371L,21154909L,22556371L,22991629L,23313371L,23748629L,24338371L,28372621L,31628371L,32079757L,33009629L,41078371L,42270629L,43465307L,44446621L,49746667L,50579339L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166001Inst : IEnumerable<long>
{
public static readonly long[] Value=A166001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166001.Bytes);
public long this[int i]=>Value[i];

public static A166001Inst Instance=new A166001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166002
{
public static readonly long[] Value={ 1934869L,6136619L,11195869L,11845499L,12385381L,33919619L,39139381L,39790381L,52937869L,53209381L,53631131L,54601619L,58690381L,62892131L,67951381L,77212381L,80224619L,88874869L,94544869L,95734381L,99936131L,103805869L,108827869L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166002Inst : IEnumerable<long>
{
public static readonly long[] Value=A166002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166002.Bytes);
public long this[int i]=>Value[i];

public static A166002Inst Instance=new A166002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166003
{
public static readonly long[] Value={ 47527L,186247L,218527L,245149L,269953L,377543L,390449L,432277L,447823L,453053L,469649L,518123L,568177L,584911L,589273L,606323L,632347L,661547L,761347L,831751L,848213L,897577L,913327L,925949L,952253L,1172351L,1205647L,1220347L,1241477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A166003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166003Inst : IEnumerable<long>
{
public static readonly long[] Value=A166003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A166003.Bytes);
public long this[int i]=>Value[i];

public static A166003Inst Instance=new A166003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A166004
{
public static readonly BigInteger[] Value={ 1L,29L,812L,22736L,636608L,17825024L,499100672L,13974818816L,391294926848L,10956257951744L,306775222648426L,8589706234144560L,240511774555729782L,6734329687551532752L,BigInteger.Parse("188561231251193685024"),BigInteger.Parse("5279714475026444683776") };
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
public class A166004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A166004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A166004Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A166004.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A166004.Bytes);
public BigInteger this[int i]=>Value[i];

public static A166004Inst Instance=new A166004Inst();

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