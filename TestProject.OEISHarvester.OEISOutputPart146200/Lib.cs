using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A175505
{
public static readonly long[] Value={ 1L,1L,5L,5L,3L,13L,13L,21L,53L,7L,7L,49L,25L,29L,31L,85L,11L,109L,37L,27L,43L,15L,15L,193L,83L,53L,485L,113L,19L,59L,61L,341L,67L,23L,71L,433L,73L,77L,79L,107L,27L,83L,85L,59L,271L,31L,31L,769L,685L,167L,103L,209L,35L,973L,37L,449L,115L,39L,39L,239L,121L,125L,379L,1365L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175505Inst : IEnumerable<long>
{
public static readonly long[] Value=A175505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175505.Bytes);
public long this[int i]=>Value[i];

public static A175505Inst Instance=new A175505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175506
{
public static readonly long[] Value={ 1L,1L,3L,2L,1L,3L,3L,4L,9L,1L,1L,6L,3L,3L,3L,8L,1L,9L,3L,2L,3L,1L,1L,12L,5L,3L,27L,6L,1L,3L,3L,16L,3L,1L,3L,18L,3L,3L,3L,4L,1L,3L,3L,2L,9L,1L,1L,24L,21L,5L,3L,6L,1L,27L,1L,12L,3L,1L,1L,6L,3L,3L,9L,32L,3L,3L,3L,2L,3L,3L,1L,36L,3L,3L,15L,6L,3L,3L,3L,8L,81L,1L,1L,6L,1L,3L,3L,4L,1L,9L,1L,2L,3L,1L,3L,48L,3L,21L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175506Inst : IEnumerable<long>
{
public static readonly long[] Value=A175506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175506.Bytes);
public long this[int i]=>Value[i];

public static A175506Inst Instance=new A175506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175507
{
public static readonly long[] Value={ 7980L,8190L,9360L,10920L,11760L,11880L,12870L,13230L,13860L,14820L,15960L,16380L,16740L,17640L,17940L,18216L,18270L,18360L,18720L,18810L,18900L,19040L,19080L,19140L,19656L,19740L,20196L,20580L,20790L,20880L,21168L,21560L,21840L,22176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175507Inst : IEnumerable<long>
{
public static readonly long[] Value=A175507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175507.Bytes);
public long this[int i]=>Value[i];

public static A175507Inst Instance=new A175507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175508
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,4L,3L,7L,5L,7L,6L,10L,7L,10L,9L,15L,10L,14L,11L,17L,13L,17L,14L,22L,16L,20L,19L,24L,19L,24L,20L,31L,23L,26L,23L,32L,25L,30L,27L,37L,28L,34L,29L,39L,33L,37L,32L,46L,33L,41L,37L,46L,37L,46L,40L,52L,41L,48L,42L,54L,43L,51L,47L,63L,47L,56L,48L,61L,51L,58L,51L,68L,52L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175508Inst : IEnumerable<long>
{
public static readonly long[] Value=A175508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175508.Bytes);
public long this[int i]=>Value[i];

public static A175508Inst Instance=new A175508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175509
{
public static readonly long[] Value={ -2L,-2L,-3L,2L,-2L,4L,-4L,2L,1L,5L,-4L,1L,7L,9L,9L,1L,-3L,9L,8L,7L,7L,9L,11L,5L,-2L,4L,-3L,-1L,6L,11L,12L,16L,17L,19L,2L,-5L,-11L,-10L,-1L,7L,10L,16L,9L,12L,21L,13L,15L,16L,15L,22L,11L,10L,11L,13L,9L,17L,7L,9L,11L,12L,17L,6L,-4L,3L,7L,7L,15L,27L,21L,25L,28L,35L,37L,43L,43L,41L,31L,31L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175509Inst : IEnumerable<long>
{
public static readonly long[] Value=A175509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175509.Bytes);
public long this[int i]=>Value[i];

public static A175509Inst Instance=new A175509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175510
{
public static readonly long[] Value={ -1L,1L,3L,7L,15L,25L,33L,43L,45L,55L,63L,61L,69L,55L,81L,37L,63L,67L,93L,73L,141L,133L,159L,163L,207L,217L,231L,247L,261L,355L,363L,349L,375L,343L,477L,469L,483L,439L,465L,457L,531L,439L,447L,439L,453L,505L,525L,439L,441L,469L,477L,469L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175510Inst : IEnumerable<long>
{
public static readonly long[] Value=A175510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175510.Bytes);
public long this[int i]=>Value[i];

public static A175510Inst Instance=new A175510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175511
{
public static readonly long[] Value={ 0L,0L,1L,4L,8L,11L,13L,16L,21L,32L,29L,40L,47L,48L,55L,60L,69L,71L,79L,85L,88L,96L,101L,109L,120L,125L,124L,129L,132L,139L,163L,169L,180L,183L,192L,191L,199L,208L,215L,225L,236L,239L,253L,253L,260L,257L,280L,303L,309L,312L,311L,320L,323L,341L,348L,357L,361L,364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175511Inst : IEnumerable<long>
{
public static readonly long[] Value=A175511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175511.Bytes);
public long this[int i]=>Value[i];

public static A175511Inst Instance=new A175511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175512
{
public static readonly long[] Value={ 0L,1L,1L,3L,2L,4L,4L,7L,1L,3L,5L,1L,0L,2L,4L,4L,7L,1L,3L,16L,19L,9L,16L,1L,22L,8L,10L,21L,5L,28L,22L,7L,28L,6L,17L,28L,4L,16L,19L,22L,25L,10L,40L,43L,28L,3L,34L,40L,31L,34L,13L,40L,8L,1L,49L,43L,10L,9L,34L,19L,22L,8L,19L,40L,52L,64L,0L,66L,37L,49L,52L,55L,58L,70L,37L,49L,11L,64L,6L,25L,28L,67L,43L,55L,40L,20L,64L,13L,8L,28L,49L,34L,82L,0L,79L,82L,85L,61L,73L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175512Inst : IEnumerable<long>
{
public static readonly long[] Value=A175512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175512.Bytes);
public long this[int i]=>Value[i];

public static A175512Inst Instance=new A175512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175513
{
public static readonly long[] Value={ 1L,2L,13L,753L,767L,1336L,1771L,1773L,1911L,2487L,3527L,4192L,5061L,5343L,5973L,6341L,7062L,7777L,8932L,9153L,15301L,17976L,18713L,19543L,20318L,22253L,24068L,27461L,29416L,29502L,31383L,31593L,31616L,31693L,36026L,36087L,41456L,42966L,44711L,45453L,45493L,46766L,49067L,50602L,51212L,51393L,53193L,56762L,58267L,60332L,60918L,64126L,65727L,67872L,71266L,72011L,75861L,78728L,79652L,82978L,85246L,86207L,86988L,87793L,90873L,91753L,94173L,97297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175513Inst : IEnumerable<long>
{
public static readonly long[] Value=A175513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175513.Bytes);
public long this[int i]=>Value[i];

public static A175513Inst Instance=new A175513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175514
{
public static readonly BigInteger[] Value={ 0L,1L,30L,31L,3900L,3901L,93900L,93901L,97000L,97001L,1270000000L,1270000001L,496864267596900L,496864267596901L,596044970707000L,596044970707001L,300522773449238130L,300522773449238131L,1549835974179703900L,1549835974179703901L,BigInteger.Parse("39043445740978906900"),BigInteger.Parse("39043445740978906901"),BigInteger.Parse("1156389717140148910000"),BigInteger.Parse("1156389717140148910001"),BigInteger.Parse("4850340461737111735130"),BigInteger.Parse("4850340461737111735131") };
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
public class A175514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175514Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A175514.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A175514.Bytes);
public BigInteger this[int i]=>Value[i];

public static A175514Inst Instance=new A175514Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175515
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,9L,10L,14L,15L,21L,22L,25L,26L,33L,34L,35L,38L,39L,46L,49L,51L,55L,57L,58L,62L,65L,69L,74L,77L,82L,85L,86L,87L,91L,93L,94L,95L,106L,111L,115L,118L,119L,121L,122L,123L,129L,133L,134L,141L,142L,143L,145L,146L,155L,158L,159L,161L,166L,169L,177L,178L,183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175515Inst : IEnumerable<long>
{
public static readonly long[] Value=A175515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175515.Bytes);
public long this[int i]=>Value[i];

public static A175515Inst Instance=new A175515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175516
{
public static readonly long[] Value={ 2L,2L,6L,12L,60L,60L,252L,504L,504L,504L,7260L,7260L,10296L,11760L,11760L,11760L,56160L,56160L,198016L,198016L,1176480L,1323008L,2992500L,6240366L,13442580L,13442580L,37536408L,37536408L,90725804L,90725804L,319800096L,319800096L,319800096L,800640126L,2201169600L,2201169600L,4656965040L,5250966084L,5250966084L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175516Inst : IEnumerable<long>
{
public static readonly long[] Value=A175516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175516.Bytes);
public long this[int i]=>Value[i];

public static A175516Inst Instance=new A175516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175517
{
public static readonly long[] Value={ 1913L,18379L,19013L,25013L,34613L,35879L,36979L,37379L,37813L,40013L,40213L,45613L,48091L,49279L,51613L,55313L,56179L,56713L,58613L,63079L,63179L,64091L,65479L,66413L,74779L,75913L,76213L,76579L,76679L,85313L,88379L,90379L,90679L,93113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175517Inst : IEnumerable<long>
{
public static readonly long[] Value=A175517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175517.Bytes);
public long this[int i]=>Value[i];

public static A175517Inst Instance=new A175517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175518
{
public static readonly long[] Value={ 1L,17L,101L,501L,1627L,2133L,2143L,2201L,2243L,3086L,3536L,3869L,4163L,4398L,4477L,5598L,5948L,5982L,6101L,6998L,7113L,7807L,8501L,8693L,9177L,9928L,10927L,11127L,11177L,11545L,11836L,12427L,12780L,13043L,13998L,14227L,14448L,14517L,14822L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175518Inst : IEnumerable<long>
{
public static readonly long[] Value=A175518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175518.Bytes);
public long this[int i]=>Value[i];

public static A175518Inst Instance=new A175518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175519
{
public static readonly long[] Value={ 13L,157L,4513L,19813L,78241L,98347L,111847L,128047L,130657L,161563L,163363L,168457L,205267L,384817L,599341L,602401L,743179L,765031L,833197L,833467L,964021L,996763L,1023133L,1028047L,1200307L,1235263L,1258267L,1478857L,1523551L,1549957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175519Inst : IEnumerable<long>
{
public static readonly long[] Value=A175519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175519.Bytes);
public long this[int i]=>Value[i];

public static A175519Inst Instance=new A175519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175520
{
public static readonly long[] Value={ 3L,3L,6L,6L,4L,1L,10L,10L,10L,10L,15L,15L,20L,20L,15L,15L,20L,15L,6L,15L,15L,6L,21L,35L,35L,35L,35L,35L,35L,21L,21L,21L,21L,7L,35L,7L,21L,21L,7L,21L,21L,7L,28L,56L,56L,70L,70L,56L,56L,56L,56L,56L,28L,56L,70L,70L,70L,70L,28L,56L,28L,56L,70L,70L,56L,56L,56L,70L,56L,56L,28L,56L,56L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175520Inst : IEnumerable<long>
{
public static readonly long[] Value=A175520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175520.Bytes);
public long this[int i]=>Value[i];

public static A175520Inst Instance=new A175520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175521
{
public static readonly long[] Value={ 1L,1105L,1387L,1729L,2047L,2701L,2821L,3277L,4033L,4369L,4681L,5461L,6601L,7957L,8911L,10261L,10585L,11305L,13741L,13747L,13981L,14491L,15709L,15841L,16705L,18721L,19951L,23377L,29341L,30121L,30889L,31417L,31609L,31621L,34945L,39865L,41041L,41665L,42799L,46657L,49141L,49981L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175521Inst : IEnumerable<long>
{
public static readonly long[] Value=A175521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175521.Bytes);
public long this[int i]=>Value[i];

public static A175521Inst Instance=new A175521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175522
{
public static readonly long[] Value={ 2L,25L,95L,111L,119L,123L,125L,169L,187L,219L,221L,247L,289L,335L,365L,411L,415L,445L,485L,493L,505L,629L,655L,685L,695L,697L,731L,767L,815L,841L,871L,943L,949L,965L,985L,1003L,1139L,1207L,1241L,1261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175522Inst : IEnumerable<long>
{
public static readonly long[] Value=A175522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175522.Bytes);
public long this[int i]=>Value[i];

public static A175522Inst Instance=new A175522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175523
{
public static readonly long[] Value={ 1L,12L,25L,54L,113L,226L,453L,910L,1821L,3644L,7303L,14610L,29231L,58462L,116939L,233892L,467803L,935616L,1871237L,3742486L,7484979L,14969998L,29939999L,59880012L,119760031L,239520072L,479040191L,958080388L,1916160779L,3832321566L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175523Inst : IEnumerable<long>
{
public static readonly long[] Value=A175523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175523.Bytes);
public long this[int i]=>Value[i];

public static A175523Inst Instance=new A175523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175524
{
public static readonly long[] Value={ 1L,3L,5L,7L,11L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,121L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175524Inst : IEnumerable<long>
{
public static readonly long[] Value=A175524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175524.Bytes);
public long this[int i]=>Value[i];

public static A175524Inst Instance=new A175524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175525
{
public static readonly long[] Value={ 1L,2L,5L,140L,158L,428L,788L,887L,914L,1814L,1895L,1976L,2579L,2732L,3074L,3299L,3641L,4658L,4874L,5378L,5423L,5504L,6170L,6440L,6944L,8060L,8249L,8915L,9041L,9158L,9725L,9824L,10661L,11291L,13820L,15305L,17051L,17393L,18716L,19589L,20876L,21641L,23756L,24188L,25961L,28409L,30632L,31307L,32387L,33215L,34970L,35240L,36653L,36977L,41558L,43970L,44951L,47444L,51764L,52655L,53375L,53852L,54104L,56831L,57506L,59153L,66479L,68063L,73562L,78485L,79286L,87908L,92093L,102029L,106934L,114854L,116321L,134051L,139397L,184037L,192353L,256469L,281381L,301118L,469004L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175525Inst : IEnumerable<long>
{
public static readonly long[] Value=A175525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175525.Bytes);
public long this[int i]=>Value[i];

public static A175525Inst Instance=new A175525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175526
{
public static readonly long[] Value={ 4L,6L,8L,9L,10L,12L,14L,15L,16L,18L,20L,21L,22L,24L,26L,27L,28L,30L,32L,33L,34L,35L,36L,38L,39L,40L,42L,44L,45L,46L,48L,49L,50L,51L,52L,54L,55L,56L,57L,58L,60L,62L,63L,64L,65L,66L,68L,69L,70L,72L,74L,75L,76L,77L,78L,80L,81L,82L,84L,85L,86L,87L,88L,90L,91L,92L,93L,94L,96L,98L,99L,100L,102L,104L,105L,106L,108L,110L,112L,114L,115L,116L,117L,118L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175526Inst : IEnumerable<long>
{
public static readonly long[] Value=A175526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175526.Bytes);
public long this[int i]=>Value[i];

public static A175526Inst Instance=new A175526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175527
{
public static readonly long[] Value={ 1L,4L,16L,19L,22L,25L,37L,40L,34L,46L,67L,52L,55L,58L,97L,73L,85L,88L,91L,85L,115L,91L,121L,106L,109L,121L,133L,118L,121L,133L,163L,184L,169L,181L,193L,169L,172L,175L,178L,199L,193L,214L,226L,238L,169L,190L,247L,241L,208L,247L,232L,253L,292L,241L,316L,292L,268L,271L,301L,286L,298L,337L,304L,325L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175527Inst : IEnumerable<long>
{
public static readonly long[] Value=A175527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175527.Bytes);
public long this[int i]=>Value[i];

public static A175527Inst Instance=new A175527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175528
{
public static readonly long[] Value={ 0L,0L,1L,2L,0L,1L,5L,2L,1L,7L,8L,7L,6L,13L,13L,5L,3L,1L,9L,15L,7L,11L,14L,13L,21L,3L,10L,9L,17L,13L,29L,9L,16L,23L,29L,28L,27L,26L,4L,33L,9L,16L,23L,37L,10L,17L,6L,16L,2L,32L,49L,32L,29L,46L,17L,44L,43L,11L,50L,58L,32L,56L,10L,45L,33L,61L,60L,18L,67L,66L,47L,1L,17L,15L,22L,69L,18L,61L,5L,11L,73L,63L,42L,40L,29L,18L,7L,57L,12L,46L,53L,53L,49L,11L,18L,40L,84L,39L,37L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175528Inst : IEnumerable<long>
{
public static readonly long[] Value=A175528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175528.Bytes);
public long this[int i]=>Value[i];

public static A175528Inst Instance=new A175528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175529
{
public static readonly long[] Value={ 1L,2L,27L,252L,508L,1037L,2126L,4335L,8691L,17527L,35216L,70560L,141316L,282692L,565716L,1132725L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175529Inst : IEnumerable<long>
{
public static readonly long[] Value=A175529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175529.Bytes);
public long this[int i]=>Value[i];

public static A175529Inst Instance=new A175529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175530
{
public static readonly long[] Value={ 7056721L,79397009999L,443372888629441L,582920080863121L,2491924062668039L,14522256850701599L,39671149333495681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175530Inst : IEnumerable<long>
{
public static readonly long[] Value=A175530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175530.Bytes);
public long this[int i]=>Value[i];

public static A175530Inst Instance=new A175530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175531
{
public static readonly long[] Value={ 443372888629441L,39671149333495681L,842526563598720001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175531Inst : IEnumerable<long>
{
public static readonly long[] Value=A175531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175531.Bytes);
public long this[int i]=>Value[i];

public static A175531Inst Instance=new A175531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175532
{
public static readonly long[] Value={ 1L,9L,13L,25L,133L,193L,18673L,57313L,1032313L,4387273L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175532Inst : IEnumerable<long>
{
public static readonly long[] Value=A175532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175532.Bytes);
public long this[int i]=>Value[i];

public static A175532Inst Instance=new A175532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175533
{
public static readonly long[] Value={ 3L,7L,19L,55L,139L,859L,2119L,112999L,333679L,10040119L,15363619L,548687179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175533Inst : IEnumerable<long>
{
public static readonly long[] Value=A175533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175533.Bytes);
public long this[int i]=>Value[i];

public static A175533Inst Instance=new A175533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175534
{
public static readonly long[] Value={ 3362L,3473L,4194L,4743L,5024L,5378L,5378L,5522L,5634L,6048L,6722L,6722L,6952L,7394L,7697L,8073L,8114L,8258L,8456L,8498L,8514L,8786L,9097L,9800L,10088L,10430L,10592L,10688L,10728L,11138L,11456L,11585L,11666L,11744L,11880L,12040L,12082L,12152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175534Inst : IEnumerable<long>
{
public static readonly long[] Value=A175534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175534.Bytes);
public long this[int i]=>Value[i];

public static A175534Inst Instance=new A175534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175535
{
public static readonly long[] Value={ 110952L,12952L,10152L,8073L,129128L,78808L,34088L,13001L,142472L,100577L,61832L,14344L,154880L,36089L,5120L,1936L,161154L,52290L,41346L,5310L,163982L,149618L,106418L,2482L,166880L,63520L,33824L,6176L,167778L,130338L,70366L,3618L,172706L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175535Inst : IEnumerable<long>
{
public static readonly long[] Value=A175535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175535.Bytes);
public long this[int i]=>Value[i];

public static A175535Inst Instance=new A175535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175536
{
public static readonly long[] Value={ 482L,1288L,1282L,2482L,2720L,2018L,1346L,4082L,3775L,1696L,2114L,674L,2457L,4487L,2912L,1728L,3767L,4738L,4088L,3383L,3586L,4439L,5544L,5576L,3368L,3970L,2177L,3473L,3672L,3746L,1313L,6104L,3218L,6752L,8856L,7841L,8082L,4232L,5714L,10424L,3776L,2849L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175536Inst : IEnumerable<long>
{
public static readonly long[] Value=A175536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175536.Bytes);
public long this[int i]=>Value[i];

public static A175536Inst Instance=new A175536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175537
{
public static readonly long[] Value={ 359L,1016L,567L,882L,1376L,1346L,863L,3314L,2466L,1008L,1022L,167L,1512L,1442L,1712L,576L,3122L,1346L,953L,1106L,1890L,2450L,3672L,1649L,728L,2114L,1072L,2768L,2728L,743L,1088L,1640L,2258L,1712L,5544L,5384L,5607L,2009L,1682L,8072L,1553L,1120L,1436L,3346L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175537Inst : IEnumerable<long>
{
public static readonly long[] Value=A175537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175537.Bytes);
public long this[int i]=>Value[i];

public static A175537Inst Instance=new A175537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175538
{
public static readonly long[] Value={ 2L,8L,162L,18L,305L,98L,98L,407L,450L,513L,2L,2L,792L,2L,224L,208L,722L,23L,8L,338L,135L,50L,1512L,200L,113L,386L,224L,1856L,297L,98L,208L,296L,878L,137L,1345L,2360L,18L,392L,527L,392L,848L,176L,8L,135L,584L,704L,401L,1058L,32L,288L,722L,855L,1817L,143L,848L,1640L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175538Inst : IEnumerable<long>
{
public static readonly long[] Value=A175538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175538.Bytes);
public long this[int i]=>Value[i];

public static A175538Inst Instance=new A175538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175539
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,12L,17L,25L,36L,51L,73L,104L,148L,210L,297L,421L,596L,843L,1193L,1688L,2388L,3378L,4778L,6758L,9558L,13518L,19118L,27037L,38237L,54076L,76476L,108154L,152953L,216309L,305908L,432620L,611818L,865242L,1223637L,1730485L,2447276L,3460971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175539Inst : IEnumerable<long>
{
public static readonly long[] Value=A175539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175539.Bytes);
public long this[int i]=>Value[i];

public static A175539Inst Instance=new A175539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175540
{
public static readonly long[] Value={ 1L,3L,5L,8L,10L,13L,15L,18L,22L,24L,28L,31L,33L,36L,40L,44L,46L,50L,53L,55L,59L,62L,66L,71L,74L,76L,79L,81L,84L,92L,95L,99L,101L,107L,109L,113L,117L,120L,124L,128L,130L,136L,138L,141L,143L,150L,157L,160L,162L,165L,169L,171L,177L,181L,185L,189L,191L,195L,198L,200L,206L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175540Inst : IEnumerable<long>
{
public static readonly long[] Value=A175540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175540.Bytes);
public long this[int i]=>Value[i];

public static A175540Inst Instance=new A175540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175541
{
public static readonly BigInteger[] Value={ 10L,101L,1011L,10111L,101111L,10111111L,101111111L,1011111111111L,10111111111111111111UL,BigInteger.Parse("101111111111111111111111111111111111"),BigInteger.Parse("1011111111111111111111111111111111111111") };
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
public class A175541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175541Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A175541.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A175541.Bytes);
public BigInteger this[int i]=>Value[i];

public static A175541Inst Instance=new A175541Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175542
{
public static readonly long[] Value={ 1L,2L,1L,4L,2L,6L,1L,8L,4L,10L,5L,12L,6L,14L,1L,16L,8L,18L,9L,20L,10L,22L,3L,24L,12L,26L,13L,28L,14L,30L,1L,32L,16L,34L,17L,36L,18L,38L,19L,40L,20L,42L,21L,44L,22L,46L,23L,48L,24L,50L,25L,52L,26L,54L,27L,56L,28L,58L,29L,60L,30L,62L,1L,64L,32L,66L,33L,68L,34L,70L,35L,72L,36L,74L,37L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175542Inst : IEnumerable<long>
{
public static readonly long[] Value=A175542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175542.Bytes);
public long this[int i]=>Value[i];

public static A175542Inst Instance=new A175542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175543
{
public static readonly long[] Value={ 0L,5L,9L,17L,27L,33L,51L,65L,85L,99L,119L,129L,165L,195L,231L,257L,297L,325L,365L,387L,427L,455L,495L,513L,585L,645L,717L,771L,843L,903L,975L,1025L,1105L,1161L,1241L,1285L,1365L,1421L,1501L,1539L,1619L,1675L,1755L,1799L,1879L,1935L,2015L,2049L,2193L,2313L,2457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175543Inst : IEnumerable<long>
{
public static readonly long[] Value=A175543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175543.Bytes);
public long this[int i]=>Value[i];

public static A175543Inst Instance=new A175543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175544
{
public static readonly long[] Value={ 1L,3L,7L,15L,21L,31L,45L,63L,73L,93L,107L,127L,153L,189L,219L,255L,273L,313L,341L,381L,403L,443L,471L,511L,561L,633L,693L,765L,819L,891L,951L,1023L,1057L,1137L,1193L,1273L,1317L,1397L,1453L,1533L,1571L,1651L,1707L,1787L,1831L,1911L,1967L,2047L,2145L,2289L,2409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175544Inst : IEnumerable<long>
{
public static readonly long[] Value=A175544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175544.Bytes);
public long this[int i]=>Value[i];

public static A175544Inst Instance=new A175544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175545
{
public static readonly long[] Value={ 3L,27L,33L,333L,369L,909L,2151L,2439L,2997L,3333L,27027L,33333L,37683L,41841L,76923L,90909L,142857L,194841L,243603L,333333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175545Inst : IEnumerable<long>
{
public static readonly long[] Value=A175545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175545.Bytes);
public long this[int i]=>Value[i];

public static A175545Inst Instance=new A175545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175546
{
public static readonly long[] Value={ 19L,37L,59L,109L,127L,149L,239L,307L,419L,691L,1009L,1049L,1229L,1319L,2129L,2309L,2477L,3119L,4019L,5009L,6091L,8093L,8297L,9199L,10139L,10799L,11093L,12007L,12391L,13499L,14009L,14489L,15091L,15497L,18397L,20297L,20899L,21799L,22109L,23599L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175546Inst : IEnumerable<long>
{
public static readonly long[] Value=A175546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175546.Bytes);
public long this[int i]=>Value[i];

public static A175546Inst Instance=new A175546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175547
{
public static readonly long[] Value={ 123456789L,214365897L,341278956L,432189675L,567891234L,658917342L,789523461L,896742513L,975634128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175547Inst : IEnumerable<long>
{
public static readonly long[] Value=A175547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175547.Bytes);
public long this[int i]=>Value[i];

public static A175547Inst Instance=new A175547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175548
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,2L,1L,4L,3L,2L,2L,3L,3L,2L,2L,5L,2L,4L,2L,3L,1L,2L,2L,4L,5L,3L,2L,3L,4L,2L,1L,6L,2L,4L,2L,5L,3L,4L,3L,4L,3L,2L,3L,3L,4L,2L,2L,5L,4L,5L,2L,3L,4L,4L,2L,4L,2L,4L,4L,3L,5L,2L,3L,7L,3L,2L,2L,6L,2L,2L,2L,4L,3L,4L,5L,3L,2L,3L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175548Inst : IEnumerable<long>
{
public static readonly long[] Value=A175548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175548.Bytes);
public long this[int i]=>Value[i];

public static A175548Inst Instance=new A175548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175549
{
public static readonly long[] Value={ 0L,26L,98L,290L,578L,1154L,1730L,2882L,4034L,5762L,7490L,10370L,12674L,16706L,20162L,24770L,29378L,36290L,41474L,50114L,57026L,66242L,74882L,87554L,96770L,111170L,123266L,138818L,152642L,172802L,186626L,209666L,228098L,251138L,271874L,299522L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175549Inst : IEnumerable<long>
{
public static readonly long[] Value=A175549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175549.Bytes);
public long this[int i]=>Value[i];

public static A175549Inst Instance=new A175549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175550
{
public static readonly long[] Value={ 1L,6L,6L,44L,232L,84L,138L,133L,336L,396L,28656L,3016L,84L,514228L,335824L,152214L,67830L,4440L,261744L,504628L,108373609L,47124L,3295440L,2971215072L,49349664L,45240L,4438362040L,203028L,3599596L,10841042784L,104340657248L,252736776688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175550Inst : IEnumerable<long>
{
public static readonly long[] Value=A175550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175550.Bytes);
public long this[int i]=>Value[i];

public static A175550Inst Instance=new A175550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175551
{
public static readonly BigInteger[] Value={ 3L,76923L,47619L,BigInteger.Parse("1123595505617977528089887640449438202247191") };
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
public class A175551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175551Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A175551.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A175551.Bytes);
public BigInteger this[int i]=>Value[i];

public static A175551Inst Instance=new A175551Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175552
{
public static readonly long[] Value={ 1L,2L,5L,7L,22L,490L,724L,778L,868L,994L,1109L,1390L,1415L,1462L,1642L,1739L,1829L,2146L,2362L,3136L,4954L,6437L,6628L,7103L,11200L,12424L,12863L,14242L,14249L,15059L,15203L,16222L,17140L,18353L,19192L,21233L,22853L,24106L,24574L,24833L,26896L,27652L,28253L,30323L,31306L,31594L,32386L,33790L,34985L,36184L,36310L,40673L,42196L,43931L,45911L,45983L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175552Inst : IEnumerable<long>
{
public static readonly long[] Value=A175552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175552.Bytes);
public long this[int i]=>Value[i];

public static A175552Inst Instance=new A175552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175553
{
public static readonly long[] Value={ 1L,4L,7L,8L,10L,12L,13L,14L,16L,18L,19L,20L,22L,23L,24L,25L,26L,28L,30L,31L,32L,33L,34L,36L,37L,38L,40L,42L,43L,44L,46L,47L,48L,49L,50L,52L,53L,54L,55L,56L,58L,60L,61L,62L,63L,64L,66L,67L,68L,70L,72L,73L,74L,75L,76L,78L,79L,80L,82L,83L,84L,85L,86L,88L,89L,90L,91L,92L,93L,94L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175553Inst : IEnumerable<long>
{
public static readonly long[] Value=A175553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175553.Bytes);
public long this[int i]=>Value[i];

public static A175553Inst Instance=new A175553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175554
{
public static readonly long[] Value={ 1L,6L,960L,40037760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175554Inst : IEnumerable<long>
{
public static readonly long[] Value=A175554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175554.Bytes);
public long this[int i]=>Value[i];

public static A175554Inst Instance=new A175554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175555
{
public static readonly long[] Value={ 5L,25L,2L,1L,125L,1L,8L,0L,0L,625L,0L,5L,0L,41L,4L,0L,3L,0L,3125L,0L,0L,2L,0L,25L,0L,2L,0L,0L,208L,2L,1L,0L,0L,17L,0L,1L,0L,15625L,0L,0L,1L,0L,13L,0L,1L,1L,0L,125L,0L,1L,0L,0L,11L,0L,1L,0L,0L,1041L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175555Inst : IEnumerable<long>
{
public static readonly long[] Value=A175555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175555.Bytes);
public long this[int i]=>Value[i];

public static A175555Inst Instance=new A175555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175556
{
public static readonly long[] Value={ 8L,9L,98L,108L,125L,196L,225L,576L,676L,864L,900L,1000L,1352L,1568L,1568L,1764L,2000L,2601L,3087L,3993L,4232L,4418L,4913L,5324L,5400L,6348L,7225L,7776L,8100L,8100L,8192L,9216L,12348L,12482L,15123L,15376L,15552L,16464L,16928L,17576L,18225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175556Inst : IEnumerable<long>
{
public static readonly long[] Value=A175556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175556.Bytes);
public long this[int i]=>Value[i];

public static A175556Inst Instance=new A175556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175557
{
public static readonly long[] Value={ 5L,2L,5L,41L,3L,2L,2L,2L,17L,13L,11L,89L,7L,5L,5L,5L,41L,3L,3L,347L,3L,3L,3L,29L,2L,2L,2L,2L,26041L,2L,2L,2L,23L,2L,2L,2L,2L,2L,17L,13L,13L,1201L,11L,11L,107L,919L,89L,7L,7L,7L,7L,7L,7L,61L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,41L,4111L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175557Inst : IEnumerable<long>
{
public static readonly long[] Value=A175557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175557.Bytes);
public long this[int i]=>Value[i];

public static A175557Inst Instance=new A175557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175558
{
public static readonly BigInteger[] Value={ 1L,167L,27889L,4657463L,777796321L,129891985607L,21691961596369L,3622557586593623L,604967116961135041L,BigInteger.Parse("101029508532509551847"),BigInteger.Parse("16871927924929095158449"),BigInteger.Parse("2817611963463158891460983"),BigInteger.Parse("470541197898347534873984161"),BigInteger.Parse("78580380049024038323955354887"),BigInteger.Parse("13122923468187014400100544266129"),BigInteger.Parse("2191528219187231404816790892443543"),BigInteger.Parse("365985212604267644604404079038071681"),BigInteger.Parse("61119530504912696648935481199357970727") };
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
public class A175558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175558Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A175558.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A175558.Bytes);
public BigInteger this[int i]=>Value[i];

public static A175558Inst Instance=new A175558Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175559
{
public static readonly long[] Value={ 1L,14L,34L,35L,49L,65L,73L,77L,70L,80L,121L,119L,136L,131L,106L,143L,148L,182L,136L,176L,169L,251L,220L,209L,244L,257L,268L,233L,265L,335L,298L,329L,349L,332L,373L,389L,343L,374L,331L,350L,355L,371L,433L,428L,430L,476L,463L,488L,451L,473L,529L,530L,463L,569L,514L,545L,583L,593L,562L,596L,586L,635L,601L,647L,598L,695L,649L,662L,718L,647L,742L,713L,685L,725L,709L,755L,742L,884L,775L,851L,790L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175559Inst : IEnumerable<long>
{
public static readonly long[] Value=A175559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175559.Bytes);
public long this[int i]=>Value[i];

public static A175559Inst Instance=new A175559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175560
{
public static readonly long[] Value={ 0L,0L,2L,1L,0L,1L,0L,6L,8L,1L,9L,4L,1L,8L,8L,4L,12L,10L,5L,9L,20L,0L,2L,4L,7L,8L,17L,13L,16L,28L,19L,29L,2L,33L,4L,19L,4L,27L,38L,35L,2L,13L,41L,34L,26L,3L,18L,19L,32L,29L,20L,47L,39L,28L,50L,23L,23L,40L,6L,46L,25L,43L,17L,22L,45L,55L,59L,38L,26L,42L,3L,37L,68L,43L,5L,58L,37L,73L,61L,70L,44L,67L,65L,73L,77L,61L,38L,24L,39L,1L,13L,61L,89L,18L,69L,88L,68L,97L,26L,86L,18L,52L,37L,38L,29L,103L,48L,28L,22L,106L,11L,27L,42L,40L,77L,26L,107L,57L,56L,118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175560Inst : IEnumerable<long>
{
public static readonly long[] Value=A175560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175560.Bytes);
public long this[int i]=>Value[i];

public static A175560Inst Instance=new A175560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175561
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,6L,16L,2L,44L,1L,232L,84L,60L,138L,133L,144L,336L,10L,420L,396L,1580L,66L,1500L,733L,908L,84L,803L,60L,1546L,1060L,675L,1511L,1228L,1172L,325L,363L,566L,30L,1935L,420L,1237L,1402L,834L,118L,76L,1547L,1148L,1500L,985L,956L,509L,489L,614L,907L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175561Inst : IEnumerable<long>
{
public static readonly long[] Value=A175561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175561.Bytes);
public long this[int i]=>Value[i];

public static A175561Inst Instance=new A175561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175562
{
public static readonly BigInteger[] Value={ 0L,0L,0L,3L,0L,0L,769230L,476190L,2941176470588235L,18L,BigInteger.Parse("11235955056179775280898876404494382022471910"),4L };
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
public class A175562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175562Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A175562.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A175562.Bytes);
public BigInteger this[int i]=>Value[i];

public static A175562Inst Instance=new A175562Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175563
{
public static readonly long[] Value={ 1L,2L,15L,334L,18521L,2293896L,586774783L,292184148320L,270280183791969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175563Inst : IEnumerable<long>
{
public static readonly long[] Value=A175563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175563.Bytes);
public long this[int i]=>Value[i];

public static A175563Inst Instance=new A175563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175564
{
public static readonly long[] Value={ 1L,2L,14L,156L,840L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175564Inst : IEnumerable<long>
{
public static readonly long[] Value=A175564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175564.Bytes);
public long this[int i]=>Value[i];

public static A175564Inst Instance=new A175564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175565
{
public static readonly long[] Value={ 2L,3L,5L,11L,13L,23L,31L,37L,41L,43L,53L,101L,103L,113L,131L,137L,151L,211L,223L,233L,241L,251L,307L,311L,313L,331L,337L,401L,421L,431L,433L,443L,503L,1009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175565Inst : IEnumerable<long>
{
public static readonly long[] Value=A175565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175565.Bytes);
public long this[int i]=>Value[i];

public static A175565Inst Instance=new A175565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175566
{
public static readonly long[] Value={ 3L,3L,7L,1171L,64591L,25153801L,25153801L,4747505071L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175566Inst : IEnumerable<long>
{
public static readonly long[] Value=A175566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175566.Bytes);
public long this[int i]=>Value[i];

public static A175566Inst Instance=new A175566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175567
{
public static readonly long[] Value={ 0L,1L,0L,6L,0L,15L,0L,0L,0L,45L,0L,66L,0L,0L,0L,120L,0L,153L,0L,0L,0L,231L,0L,0L,0L,0L,0L,378L,0L,435L,0L,0L,0L,0L,0L,630L,0L,0L,0L,780L,0L,861L,0L,0L,0L,1035L,0L,0L,0L,0L,0L,1326L,0L,0L,0L,0L,0L,1653L,0L,1770L,0L,0L,0L,0L,0L,2145L,0L,0L,0L,2415L,0L,2556L,0L,0L,0L,0L,0L,3003L,0L,0L,0L,3321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175567Inst : IEnumerable<long>
{
public static readonly long[] Value=A175567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175567.Bytes);
public long this[int i]=>Value[i];

public static A175567Inst Instance=new A175567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175568
{
public static readonly long[] Value={ 4747505071L,10817047081L,21071155561L,41279978041L,44304317821L,49710893611L,58845917971L,79925475841L,96466884361L,106120099471L,107001847261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175568Inst : IEnumerable<long>
{
public static readonly long[] Value=A175568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175568.Bytes);
public long this[int i]=>Value[i];

public static A175568Inst Instance=new A175568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175569
{
public static readonly long[] Value={ 2L,3L,10L,19L,30L,44L,59L,77L,100L,124L,150L,181L,216L,252L,289L,328L,371L,416L,464L,515L,567L,620L,675L,739L,807L,879L,962L,1046L,1131L,1217L,1312L,1413L,1522L,1633L,1746L,1861L,1978L,2101L,2226L,2355L,2488L,2623L,2761L,2902L,3044L,3189L,3335L,3484L,3642L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175569Inst : IEnumerable<long>
{
public static readonly long[] Value=A175569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175569.Bytes);
public long this[int i]=>Value[i];

public static A175569Inst Instance=new A175569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175570
{
public static readonly long[] Value={ 9L,9L,8L,6L,8L,5L,2L,2L,2L,2L,1L,8L,4L,3L,8L,1L,3L,5L,4L,4L,1L,6L,0L,0L,7L,8L,7L,8L,6L,0L,2L,0L,6L,5L,4L,9L,6L,7L,8L,3L,6L,4L,5L,4L,6L,1L,2L,6L,5L,1L,4L,4L,1L,1L,4L,0L,4L,1L,2L,6L,4L,5L,1L,2L,2L,9L,7L,1L,2L,7L,5L,2L,5L,5L,9L,0L,3L,1L,0L,8L,9L,4L,5L,5L,4L,8L,2L,1L,8L,4L,5L,3L,8L,6L,2L,9L,7L,9L,7L,8L,4L,0L,7L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175570Inst : IEnumerable<long>
{
public static readonly long[] Value=A175570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175570.Bytes);
public long this[int i]=>Value[i];

public static A175570Inst Instance=new A175570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175571
{
public static readonly long[] Value={ 9L,9L,6L,1L,5L,7L,8L,2L,8L,0L,7L,7L,0L,8L,8L,0L,6L,4L,0L,0L,6L,3L,1L,9L,3L,6L,8L,6L,3L,0L,9L,7L,5L,2L,8L,1L,5L,1L,1L,3L,9L,5L,5L,2L,9L,3L,8L,8L,2L,6L,4L,9L,4L,3L,2L,0L,7L,9L,8L,3L,2L,1L,5L,1L,2L,4L,4L,6L,2L,8L,6L,5L,0L,1L,8L,2L,7L,4L,8L,1L,9L,2L,8L,9L,6L,5L,9L,8L,3L,2L,2L,7L,0L,5L,2L,4L,4L,7L,5L,5L,9L,9L,0L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175571Inst : IEnumerable<long>
{
public static readonly long[] Value=A175571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175571.Bytes);
public long this[int i]=>Value[i];

public static A175571Inst Instance=new A175571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175572
{
public static readonly long[] Value={ 9L,8L,8L,9L,4L,4L,5L,5L,1L,7L,4L,1L,1L,0L,5L,3L,3L,6L,1L,0L,8L,4L,2L,2L,6L,3L,3L,2L,2L,8L,3L,7L,7L,8L,2L,1L,3L,1L,5L,8L,6L,0L,8L,8L,7L,0L,6L,2L,7L,3L,3L,9L,1L,0L,7L,8L,1L,9L,9L,2L,4L,0L,1L,6L,3L,9L,0L,1L,5L,1L,9L,4L,6L,9L,8L,0L,1L,8L,1L,9L,6L,4L,1L,1L,9L,1L,0L,4L,6L,8L,9L,9L,9L,7L,9L,9L,9L,3L,3L,7L,8L,5L,6L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175572Inst : IEnumerable<long>
{
public static readonly long[] Value=A175572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175572.Bytes);
public long this[int i]=>Value[i];

public static A175572Inst Instance=new A175572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175573
{
public static readonly long[] Value={ 1L,0L,8L,6L,4L,3L,4L,8L,1L,1L,2L,1L,3L,3L,0L,8L,0L,1L,4L,5L,7L,5L,3L,1L,6L,1L,2L,1L,5L,1L,0L,2L,2L,3L,4L,5L,7L,0L,7L,0L,2L,0L,5L,7L,0L,7L,2L,4L,5L,2L,1L,8L,8L,8L,5L,9L,2L,0L,7L,9L,0L,3L,1L,5L,9L,8L,1L,8L,5L,6L,7L,3L,2L,2L,6L,7L,1L,0L,9L,7L,9L,5L,9L,6L,0L,5L,6L,1L,6L,1L,8L,4L,8L,9L,6L,7L,9L,7L,6L,4L,0L,3L,7L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175573Inst : IEnumerable<long>
{
public static readonly long[] Value=A175573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175573.Bytes);
public long this[int i]=>Value[i];

public static A175573Inst Instance=new A175573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175574
{
public static readonly long[] Value={ 1L,1L,8L,0L,3L,4L,0L,5L,9L,9L,0L,1L,6L,0L,9L,6L,2L,2L,6L,0L,4L,5L,3L,3L,7L,9L,4L,0L,5L,5L,8L,4L,8L,8L,5L,8L,7L,2L,3L,3L,7L,1L,6L,6L,3L,4L,8L,8L,1L,4L,4L,7L,2L,9L,9L,5L,1L,5L,8L,6L,4L,3L,9L,9L,4L,0L,4L,3L,0L,4L,1L,8L,0L,7L,2L,0L,7L,1L,5L,7L,9L,4L,9L,7L,8L,4L,5L,8L,6L,1L,6L,1L,9L,5L,8L,0L,7L,9L,5L,4L,2L,0L,9L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175574Inst : IEnumerable<long>
{
public static readonly long[] Value=A175574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175574.Bytes);
public long this[int i]=>Value[i];

public static A175574Inst Instance=new A175574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175575
{
public static readonly long[] Value={ 2L,6L,9L,6L,7L,6L,3L,0L,0L,5L,9L,4L,1L,8L,9L,6L,7L,8L,3L,3L,3L,9L,6L,7L,8L,6L,1L,1L,7L,7L,7L,7L,6L,3L,6L,6L,3L,8L,2L,9L,3L,4L,4L,8L,2L,7L,2L,1L,5L,2L,0L,0L,6L,5L,1L,6L,9L,9L,7L,3L,3L,1L,5L,9L,3L,1L,9L,4L,1L,4L,9L,4L,2L,4L,3L,2L,5L,7L,8L,4L,1L,4L,0L,7L,7L,9L,6L,0L,6L,8L,6L,1L,3L,7L,6L,6L,8L,8L,5L,7L,3L,6L,2L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175575Inst : IEnumerable<long>
{
public static readonly long[] Value=A175575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175575.Bytes);
public long this[int i]=>Value[i];

public static A175575Inst Instance=new A175575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175576
{
public static readonly long[] Value={ 3L,7L,0L,8L,1L,4L,9L,3L,5L,4L,6L,0L,2L,7L,4L,3L,8L,3L,6L,8L,6L,7L,7L,0L,0L,6L,9L,4L,3L,9L,0L,5L,2L,0L,0L,9L,2L,4L,3L,5L,1L,9L,7L,6L,4L,7L,0L,4L,3L,5L,3L,3L,8L,1L,1L,1L,7L,1L,8L,5L,6L,0L,9L,0L,1L,1L,2L,0L,4L,3L,5L,5L,3L,6L,7L,6L,2L,3L,9L,9L,5L,6L,7L,1L,4L,5L,4L,3L,7L,2L,3L,3L,0L,0L,7L,4L,3L,7L,9L,4L,5L,5L,5L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175576Inst : IEnumerable<long>
{
public static readonly long[] Value=A175576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175576.Bytes);
public long this[int i]=>Value[i];

public static A175576Inst Instance=new A175576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175577
{
public static readonly long[] Value={ 1L,2L,7L,8L,1L,8L,5L,1L,5L,9L,0L,9L,0L,9L,4L,6L,1L,7L,9L,5L,4L,0L,3L,9L,0L,9L,4L,8L,3L,6L,7L,5L,7L,1L,3L,3L,8L,4L,2L,3L,9L,0L,1L,5L,3L,6L,8L,5L,1L,4L,0L,2L,0L,2L,0L,1L,7L,0L,3L,4L,6L,3L,8L,0L,4L,1L,6L,5L,7L,9L,9L,9L,1L,8L,3L,0L,6L,2L,0L,8L,2L,4L,4L,1L,8L,3L,6L,3L,2L,4L,5L,2L,0L,5L,0L,0L,7L,9L,6L,2L,3L,0L,5L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175577Inst : IEnumerable<long>
{
public static readonly long[] Value=A175577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175577.Bytes);
public long this[int i]=>Value[i];

public static A175577Inst Instance=new A175577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175578
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,6L,5L,9L,6L,6L,8L,9L,9L,2L,5L,1L,8L,8L,7L,5L,7L,3L,9L,3L,7L,5L,7L,9L,0L,1L,5L,8L,7L,9L,6L,4L,5L,3L,5L,3L,8L,1L,1L,4L,1L,6L,4L,8L,5L,5L,0L,4L,9L,8L,0L,6L,0L,6L,1L,7L,0L,2L,6L,9L,2L,9L,8L,1L,9L,2L,6L,0L,3L,3L,6L,1L,5L,4L,2L,6L,6L,9L,5L,8L,2L,6L,0L,9L,2L,1L,0L,6L,8L,8L,8L,7L,7L,8L,1L,0L,7L,2L,6L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175578Inst : IEnumerable<long>
{
public static readonly long[] Value=A175578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175578.Bytes);
public long this[int i]=>Value[i];

public static A175578Inst Instance=new A175578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175579
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,5L,6L,3L,1L,15L,21L,12L,4L,1L,53L,84L,54L,20L,5L,1L,217L,380L,270L,110L,30L,6L,1L,1014L,1926L,1490L,660L,195L,42L,7L,1L,5335L,10840L,9020L,4300L,1365L,315L,56L,8L,1L,31240L,67195L,59550L,30290L,10255L,2520L,476L,72L,9L,1L,201608L,455379L,426405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175579Inst : IEnumerable<long>
{
public static readonly long[] Value=A175579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175579.Bytes);
public long this[int i]=>Value[i];

public static A175579Inst Instance=new A175579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175580
{
public static readonly long[] Value={ 25153801L,507079861L,610817971L,942962791L,1040241511L,1223511871L,1797884761L,2200595671L,2291395471L,2304999061L,2429694541L,3078011161L,3509229571L,3733373491L,3896865631L,4017254011L,4747505071L,4847389471L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175580Inst : IEnumerable<long>
{
public static readonly long[] Value=A175580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175580.Bytes);
public long this[int i]=>Value[i];

public static A175580Inst Instance=new A175580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175581
{
public static readonly long[] Value={ 119780L,2414666L,2908657L,4490299L,4953531L,5826247L,8561356L,10479027L,10911407L,10976186L,11569974L,14657196L,16710617L,17777969L,18556503L,19129781L,22607167L,23082807L,23543359L,25241957L,26655168L,32729717L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175581Inst : IEnumerable<long>
{
public static readonly long[] Value=A175581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175581.Bytes);
public long this[int i]=>Value[i];

public static A175581Inst Instance=new A175581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175582
{
public static readonly long[] Value={ 6L,14L,21L,30L,28L,36L,45L,48L,62L,60L,60L,84L,72L,72L,84L,93L,112L,90L,117L,126L,108L,105L,140L,124L,120L,180L,156L,168L,144L,168L,186L,196L,189L,240L,180L,186L,273L,192L,254L,234L,252L,217L,288L,300L,252L,228L,252L,280L,273L,372L,252L,364L,264L,294L,360L,360L,279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175582Inst : IEnumerable<long>
{
public static readonly long[] Value=A175582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175582.Bytes);
public long this[int i]=>Value[i];

public static A175582Inst Instance=new A175582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175583
{
public static readonly long[] Value={ 12L,40L,70L,80L,88L,160L,272L,320L,490L,544L,928L,1184L,1312L,1332L,1575L,1696L,1888L,2420L,2560L,2624L,2628L,3380L,3392L,3712L,3920L,4030L,4100L,4736L,5120L,5248L,5696L,5830L,6464L,6664L,6784L,7232L,7424L,7808L,8228L,8704L,8784L,8925L,9680L,10100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175583Inst : IEnumerable<long>
{
public static readonly long[] Value=A175583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175583.Bytes);
public long this[int i]=>Value[i];

public static A175583Inst Instance=new A175583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175584
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,23L,31L,41L,43L,53L,61L,71L,101L,103L,107L,109L,113L,127L,131L,151L,163L,181L,211L,223L,227L,233L,241L,251L,263L,271L,307L,311L,313L,317L,331L,353L,401L,409L,421L,431L,433L,443L,503L,509L,521L,523L,541L,601L,607L,613L,617L,631L,701L,709L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175584Inst : IEnumerable<long>
{
public static readonly long[] Value=A175584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175584.Bytes);
public long this[int i]=>Value[i];

public static A175584Inst Instance=new A175584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175585
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,9L,10L,11L,12L,15L,18L,19L,20L,21L,25L,30L,32L,35L,38L,39L,40L,45L,46L,47L,48L,49L,50L,51L,52L,55L,56L,60L,65L,71L,79L,85L,90L,95L,100L,101L,102L,103L,104L,105L,106L,110L,111L,112L,115L,119L,120L,131L,145L,146L,147L,149L,150L,152L,153L,155L,156L,162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175585Inst : IEnumerable<long>
{
public static readonly long[] Value=A175585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175585.Bytes);
public long this[int i]=>Value[i];

public static A175585Inst Instance=new A175585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175586
{
public static readonly long[] Value={ 10L,14L,21L,22L,26L,33L,34L,38L,39L,46L,51L,55L,57L,58L,62L,65L,69L,74L,82L,85L,86L,87L,91L,93L,94L,95L,106L,111L,115L,118L,119L,122L,123L,129L,133L,134L,141L,142L,145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175586Inst : IEnumerable<long>
{
public static readonly long[] Value=A175586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175586.Bytes);
public long this[int i]=>Value[i];

public static A175586Inst Instance=new A175586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175587
{
public static readonly long[] Value={ 4L,6L,9L,14L,21L,26L,33L,35L,38L,49L,51L,58L,65L,82L,85L,87L,94L,111L,118L,121L,123L,134L,141L,143L,145L,158L,161L,166L,169L,206L,209L,214L,217L,219L,221L,226L,237L,254L,259L,262L,265L,267L,274L,287L,289L,291L,298L,301L,303L,305L,334L,339L,341L,346L,365L,382L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175587Inst : IEnumerable<long>
{
public static readonly long[] Value=A175587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175587.Bytes);
public long this[int i]=>Value[i];

public static A175587Inst Instance=new A175587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175588
{
public static readonly long[] Value={ 4L,10L,14L,35L,39L,49L,55L,65L,69L,91L,95L,121L,142L,146L,155L,159L,169L,178L,187L,201L,205L,209L,213L,217L,221L,235L,249L,253L,259L,265L,274L,278L,287L,291L,295L,299L,303L,309L,319L,323L,327L,341L,355L,361L,365L,371L,377L,381L,391L,395L,417L,427L,437L,446L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175588Inst : IEnumerable<long>
{
public static readonly long[] Value=A175588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175588.Bytes);
public long this[int i]=>Value[i];

public static A175588Inst Instance=new A175588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175589
{
public static readonly long[] Value={ 1L,3L,6L,9L,12L,18L,57L,84L,87L,102L,117L,216L,234L,288L,360L,468L,477L,681L,741L,798L,987L,1029L,1161L,1245L,1251L,1266L,1449L,1458L,1500L,1677L,2214L,2232L,2703L,2880L,3090L,3117L,3333L,3345L,3351L,3789L,4176L,4512L,4779L,4932L,4980L,5763L,6213L,6846L,6903L,6918L,8097L,8712L,9285L,10404L,11085L,11274L,11532L,11922L,12369L,12378L,14871L,16710L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175589Inst : IEnumerable<long>
{
public static readonly long[] Value=A175589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175589.Bytes);
public long this[int i]=>Value[i];

public static A175589Inst Instance=new A175589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175590
{
public static readonly long[] Value={ 19940L,49147L,54585L,118923L,136825L,183554L,204323L,204324L,262932L,304675L,361275L,361322L,476377L,486962L,506905L,619722L,668211L,734948L,854018L,937025L,938203L,999649L,1062025L,1118275L,1335572L,1336075L,1356324L,1466225L,1541491L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175590Inst : IEnumerable<long>
{
public static readonly long[] Value=A175590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175590.Bytes);
public long this[int i]=>Value[i];

public static A175590Inst Instance=new A175590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175591
{
public static readonly long[] Value={ 0L,2L,1L,6L,0L,6L,5L,6L,14L,6L,4L,24L,6L,2L,6L,13L,28L,2L,27L,30L,6L,1L,32L,12L,6L,60L,30L,36L,6L,28L,36L,40L,29L,72L,6L,10L,93L,6L,62L,36L,48L,9L,78L,84L,32L,6L,28L,52L,39L,132L,6L,112L,6L,34L,96L,90L,7L,60L,80L,6L,48L,134L,6L,45L,28L,108L,6L,61L,102L,160L,38L,48L,72L,22L,26L,6L,225L,28L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175591Inst : IEnumerable<long>
{
public static readonly long[] Value=A175591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175591.Bytes);
public long this[int i]=>Value[i];

public static A175591Inst Instance=new A175591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175592
{
public static readonly long[] Value={ 4L,9L,16L,25L,30L,36L,49L,64L,70L,72L,81L,84L,100L,120L,121L,144L,169L,196L,225L,240L,256L,270L,280L,286L,288L,289L,308L,324L,336L,361L,378L,400L,440L,441L,480L,484L,495L,525L,528L,529L,540L,576L,594L,625L,630L,646L,648L,672L,676L,728L,729L,750L,756L,784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175592Inst : IEnumerable<long>
{
public static readonly long[] Value=A175592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175592.Bytes);
public long this[int i]=>Value[i];

public static A175592Inst Instance=new A175592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175593
{
public static readonly long[] Value={ 4L,6L,12L,14L,15L,21L,24L,30L,36L,40L,51L,54L,63L,69L,75L,84L,90L,96L,99L,114L,120L,135L,141L,156L,174L,180L,210L,216L,231L,261L,285L,300L,309L,321L,330L,364L,405L,411L,414L,420L,429L,441L,510L,516L,525L,531L,546L,576L,615L,639L,645L,651L,660L,684L,714L,726L,741L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175593Inst : IEnumerable<long>
{
public static readonly long[] Value=A175593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175593.Bytes);
public long this[int i]=>Value[i];

public static A175593Inst Instance=new A175593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175594
{
public static readonly long[] Value={ 0L,8L,12L,15L,16L,20L,21L,24L,28L,30L,32L,33L,35L,36L,39L,40L,42L,44L,45L,48L,51L,52L,55L,56L,57L,60L,63L,64L,65L,66L,68L,69L,70L,72L,75L,76L,77L,78L,80L,84L,85L,87L,88L,90L,91L,92L,93L,95L,96L,99L,100L,102L,104L,105L,108L,110L,111L,112L,114L,115L,116L,117L,119L,120L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175594Inst : IEnumerable<long>
{
public static readonly long[] Value=A175594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175594.Bytes);
public long this[int i]=>Value[i];

public static A175594Inst Instance=new A175594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175595
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,2L,1L,1L,0L,3L,1L,1L,0L,0L,5L,1L,1L,2L,1L,0L,7L,1L,1L,2L,0L,0L,0L,11L,1L,1L,2L,3L,2L,0L,0L,15L,1L,1L,2L,3L,1L,1L,1L,0L,22L,1L,1L,2L,3L,5L,3L,2L,0L,0L,30L,1L,1L,2L,3L,5L,2L,3L,0L,0L,0L,42L,1L,1L,2L,3L,5L,7L,6L,3L,1L,0L,0L,56L,1L,1L,2L,3L,5L,7L,5L,5L,4L,2L,1L,0L,77L,1L,1L,2L,3L,5L,7L,11L,9L,7L,4L,2L,0L,0L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175595Inst : IEnumerable<long>
{
public static readonly long[] Value=A175595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175595.Bytes);
public long this[int i]=>Value[i];

public static A175595Inst Instance=new A175595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175596
{
public static readonly BigInteger[] Value={ 1L,3L,9L,54L,162L,1458L,4374L,43740L,262440L,2361960L,7085880L,127545840L,382637520L,3443737680L,30993639120L,464904586800L,1394713760400L,25104847687200L,75314543061600L,1355661775108800L,12200955975979200L,109808603783812800L,329425811351438400L,9882774340543152000UL,BigInteger.Parse("59296646043258912000"),BigInteger.Parse("533669814389330208000"),BigInteger.Parse("5336698143893302080000"),BigInteger.Parse("96060566590079437440000"),BigInteger.Parse("288181699770238312320000"),BigInteger.Parse("7780905893796434432640000") };
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
public class A175596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175596Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A175596.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A175596.Bytes);
public BigInteger this[int i]=>Value[i];

public static A175596Inst Instance=new A175596Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175597
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,1L,3L,1L,1L,1L,1L,2L,1L,1L,4L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,5L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,3L,1L,1L,1L,2L,1L,1L,6L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175597Inst : IEnumerable<long>
{
public static readonly long[] Value=A175597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175597.Bytes);
public long this[int i]=>Value[i];

public static A175597Inst Instance=new A175597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175598
{
public static readonly long[] Value={ 0L,95800L,217519L,414560L,2682440L,15365639L,18796760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175598Inst : IEnumerable<long>
{
public static readonly long[] Value=A175598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175598.Bytes);
public long this[int i]=>Value[i];

public static A175598Inst Instance=new A175598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175599
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,0L,2L,1L,0L,1L,0L,1L,2L,0L,3L,2L,1L,1L,1L,0L,1L,2L,1L,1L,1L,1L,1L,2L,3L,0L,4L,3L,2L,2L,1L,1L,1L,2L,2L,1L,0L,1L,1L,1L,2L,3L,2L,2L,1L,0L,1L,1L,1L,2L,0L,2L,2L,2L,2L,3L,4L,0L,5L,4L,3L,3L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,2L,3L,3L,2L,1L,1L,1L,0L,1L,2L,2L,1L,1L,1L,2L,2L,3L,4L,3L,3L,2L,1L,1L,1L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175599Inst : IEnumerable<long>
{
public static readonly long[] Value=A175599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175599.Bytes);
public long this[int i]=>Value[i];

public static A175599Inst Instance=new A175599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175600
{
public static readonly long[] Value={ 53L,149L,293L,389L,773L,1109L,1493L,1637L,1733L,2309L,2693L,2837L,3413L,3989L,4133L,4373L,4517L,5189L,5717L,5813L,6197L,6389L,7013L,7109L,8069L,8117L,9173L,9749L,10709L,10853L,11813L,12149L,12197L,12437L,12917L,13829L,13877L,14549L,15077L,15173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175600Inst : IEnumerable<long>
{
public static readonly long[] Value=A175600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175600.Bytes);
public long this[int i]=>Value[i];

public static A175600Inst Instance=new A175600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175601
{
public static readonly long[] Value={ 7L,637L,6937L,69937L,699937L,6999937L,69999937L,699999937L,6999999937L,69999999937L,699999999937L,6999999999937L,69999999999937L,699999999999937L,6999999999999937L,69999999999999937L,699999999999999937L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175601Inst : IEnumerable<long>
{
public static readonly long[] Value=A175601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175601.Bytes);
public long this[int i]=>Value[i];

public static A175601Inst Instance=new A175601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175602
{
public static readonly long[] Value={ 56L,776L,7976L,79976L,799976L,7999976L,79999976L,799999976L,7999999976L,79999999976L,799999999976L,7999999999976L,79999999999976L,799999999999976L,7999999999999976L,79999999999999976L,799999999999999976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175602Inst : IEnumerable<long>
{
public static readonly long[] Value=A175602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175602.Bytes);
public long this[int i]=>Value[i];

public static A175602Inst Instance=new A175602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175603
{
public static readonly long[] Value={ 40L,760L,7960L,79960L,799960L,7999960L,79999960L,799999960L,7999999960L,79999999960L,799999999960L,7999999999960L,79999999999960L,799999999999960L,7999999999999960L,79999999999999960L,799999999999999960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175603Inst : IEnumerable<long>
{
public static readonly long[] Value=A175603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175603.Bytes);
public long this[int i]=>Value[i];

public static A175603Inst Instance=new A175603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175604
{
public static readonly long[] Value={ 24L,744L,7944L,79944L,799944L,7999944L,79999944L,799999944L,7999999944L,79999999944L,799999999944L,7999999999944L,79999999999944L,799999999999944L,7999999999999944L,79999999999999944L,799999999999999944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175604Inst : IEnumerable<long>
{
public static readonly long[] Value=A175604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175604.Bytes);
public long this[int i]=>Value[i];

public static A175604Inst Instance=new A175604Inst();

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