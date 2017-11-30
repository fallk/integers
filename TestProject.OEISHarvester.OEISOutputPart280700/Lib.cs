using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A096087
{
public static readonly long[] Value={ 0L,1L,0L,1L,2L,0L,1L,3L,0L,1L,2L,3L,4L,0L,1L,2L,3L,4L,5L,0L,1L,6L,0L,1L,3L,5L,7L,0L,1L,8L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,0L,1L,3L,4L,5L,7L,8L,9L,11L,0L,1L,5L,8L,12L,0L,1L,6L,7L,8L,13L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,0L,1L,3L,5L,7L,8L,9L,11L,13L,15L,0L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096087Inst : IEnumerable<long>
{
public static readonly long[] Value=A096087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096087.Bytes);
public long this[int i]=>Value[i];

public static A096087Inst Instance=new A096087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096088
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,3L,4L,0L,1L,2L,4L,0L,1L,0L,1L,4L,7L,0L,1L,5L,6L,0L,1L,3L,4L,5L,9L,0L,1L,4L,9L,0L,1L,3L,9L,0L,1L,2L,4L,7L,8L,9L,11L,0L,1L,6L,10L,0L,1L,0L,1L,4L,13L,16L,0L,1L,4L,7L,9L,10L,13L,16L,0L,1L,4L,5L,6L,7L,9L,11L,16L,17L,0L,1L,5L,16L,0L,1L,4L,7L,9L,15L,16L,18L,0L,1L,3L,4L,5L,9L,11L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096088Inst : IEnumerable<long>
{
public static readonly long[] Value=A096088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096088.Bytes);
public long this[int i]=>Value[i];

public static A096088Inst Instance=new A096088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096089
{
public static readonly long[] Value={ 10L,1L,1L,2L,2L,3L,3L,4L,4L,4L,10L,1L,1L,1L,1L,2L,2L,2L,2L,3L,10L,2L,1L,1L,1L,1L,1L,1L,2L,2L,10L,2L,1L,1L,1L,1L,1L,1L,1L,1L,10L,3L,2L,1L,1L,1L,1L,1L,1L,1L,10L,3L,2L,1L,1L,1L,1L,1L,1L,1L,10L,4L,2L,1L,1L,1L,1L,1L,1L,1L,10L,4L,2L,2L,1L,1L,1L,1L,1L,1L,10L,4L,3L,2L,1L,1L,1L,1L,1L,1L,100L,10L,17L,23L,29L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096089Inst : IEnumerable<long>
{
public static readonly long[] Value=A096089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096089.Bytes);
public long this[int i]=>Value[i];

public static A096089Inst Instance=new A096089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096090
{
public static readonly long[] Value={ 1L,13L,15L,17L,116L,117L,119L,1119L,0L,10L,506L,304L,203L,508L,305L,509L,102L,1012L,307L,205L,308L,2035L,103L,1033L,2056L,207L,1013L,2067L,104L,1044L,209L,1034L,1024L,105L,1055L,1014L,1045L,106L,1035L,2029L,107L,10225L,1046L,1015L,108L,1036L,109L,1078L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096090Inst : IEnumerable<long>
{
public static readonly long[] Value=A096090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096090.Bytes);
public long this[int i]=>Value[i];

public static A096090Inst Instance=new A096090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096091
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,20L,22L,30L,33L,40L,44L,50L,55L,60L,66L,70L,77L,80L,88L,90L,99L,100L,101L,105L,108L,110L,111L,150L,180L,200L,202L,220L,222L,300L,303L,330L,333L,400L,404L,405L,440L,444L,450L,500L,501L,504L,505L,510L,540L,550L,555L,600L,606L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096091Inst : IEnumerable<long>
{
public static readonly long[] Value=A096091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096091.Bytes);
public long this[int i]=>Value[i];

public static A096091Inst Instance=new A096091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096092
{
public static readonly long[] Value={ 10L,20L,30L,40L,50L,60L,70L,80L,90L,100L,105L,108L,110L,120L,130L,140L,150L,160L,170L,180L,190L,200L,210L,220L,230L,240L,250L,260L,270L,280L,290L,300L,310L,320L,330L,340L,350L,360L,370L,380L,390L,400L,405L,410L,420L,430L,440L,450L,460L,470L,480L,490L,500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096092Inst : IEnumerable<long>
{
public static readonly long[] Value=A096092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096092.Bytes);
public long this[int i]=>Value[i];

public static A096092Inst Instance=new A096092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096093
{
public static readonly long[] Value={ 105L,108L,405L,702L,703L,1001L,1005L,1008L,1053L,2002L,2016L,2025L,2079L,2106L,3003L,3024L,3042L,3045L,3105L,3402L,4004L,4005L,5005L,5049L,6006L,6031L,6045L,6048L,6072L,6075L,6084L,6105L,6804L,7007L,7011L,7128L,7425L,8008L,8019L,8092L,8316L,8712L,9009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096093Inst : IEnumerable<long>
{
public static readonly long[] Value=A096093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096093.Bytes);
public long this[int i]=>Value[i];

public static A096093Inst Instance=new A096093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096094
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,1L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096094Inst : IEnumerable<long>
{
public static readonly long[] Value=A096094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096094.Bytes);
public long this[int i]=>Value[i];

public static A096094Inst Instance=new A096094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096095
{
public static readonly BigInteger[] Value={ 1L,1L,2L,3L,5L,8L,13L,111L,124L,235L,359L,5814L,511613L,5161427L,567210310L,5612371737L,511795811047L,5161310711827714L,BigInteger.Parse("51618211410616387511"),BigInteger.Parse("51611337272013271110141225"),BigInteger.Parse("5161138888102246817264128736"),BigInteger.Parse("5111274911111537425910883742699511"),BigInteger.Parse("511127910722491311155271156169109106711171247") };
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
public class A096095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096095Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A096095.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A096095.Bytes);
public BigInteger this[int i]=>Value[i];

public static A096095Inst Instance=new A096095Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096096
{
public static readonly BigInteger[] Value={ 1L,2L,2L,4L,8L,32L,16L,312L,112L,314L,318L,9132L,3316L,273312L,99112L,6327314L,1863318L,62412219132L,2166273316L,4461247273312L,22244244999112L,8824441628186327314L,BigInteger.Parse("821283223224271863318"),BigInteger.Parse("81616128831243225662412219132"),BigInteger.Parse("64614329441512128872166273316") };
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
public class A096096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096096Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A096096.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A096096.Bytes);
public BigInteger this[int i]=>Value[i];

public static A096096Inst Instance=new A096096Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096097
{
public static readonly BigInteger[] Value={ 2L,1L,3L,71L,7L,10177L,2100001L,101770000001L,4603L,13L,107L,4013L,23L,BigInteger.Parse("3097349301044927552199565217412468305904367"),1847L,37L,367767021959L,54371L,3229L,17L,520063L,29L,389L,8059L,732713L,11L,7123120001L,137L,294563L };
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
public class A096097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096097Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A096097.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A096097.Bytes);
public BigInteger this[int i]=>Value[i];

public static A096097Inst Instance=new A096097Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096098
{
public static readonly BigInteger[] Value={ 2L,1L,3L,71L,7L,21L,599L,173L,11L,23L,161L,49L,13L,9L,131L,19L,33L,17L,1489L,331L,3989L,69L,BigInteger.Parse("3097350956401900335673788279883089441874368101"),349387L,5651L,443L,29L,51L,479470832244949L,661L,1129L,1873L,181L,BigInteger.Parse("1544577973887516219070997863"),521L };
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
public class A096098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096098Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A096098.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A096098.Bytes);
public BigInteger this[int i]=>Value[i];

public static A096098Inst Instance=new A096098Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096099
{
public static readonly long[] Value={ 1L,2L,3L,5L,5L,2L,13L,25L,8L,22L,16L,26L,35L,35L,11L,26L,48L,58L,6L,46L,4L,77L,83L,29L,33L,187L,61L,78L,81L,23L,183L,15L,22L,68L,8L,137L,84L,178L,99L,7L,71L,82L,142L,241L,133L,71L,56L,19L,32L,318L,157L,199L,303L,16L,201L,201L,213L,257L,355L,229L,365L,379L,345L,27L,52L,19L,272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096099Inst : IEnumerable<long>
{
public static readonly long[] Value=A096099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096099.Bytes);
public long this[int i]=>Value[i];

public static A096099Inst Instance=new A096099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096132
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,84L,4686825L,1L,12870L,3284214703056L,BigInteger.Parse("10078751602022313874633200"),1L,3268760L,9064807833193439800L,BigInteger.Parse("25006639164538285144538957539300707000"),BigInteger.Parse("137658555538877668586244095134027016988748997970545868021484500"),1L };
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
public class A096132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096132Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A096132.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A096132.Bytes);
public BigInteger this[int i]=>Value[i];

public static A096132Inst Instance=new A096132Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096133
{
public static readonly long[] Value={ 0L,0L,0L,0L,3L,0L,0L,0L,4L,0L,0L,5L,5L,5L,0L,0L,0L,0L,0L,6L,0L,0L,7L,7L,21L,7L,7L,0L,0L,0L,8L,0L,8L,16L,8L,0L,0L,9L,0L,9L,9L,27L,9L,9L,0L,0L,0L,10L,0L,0L,40L,10L,0L,10L,0L,0L,11L,11L,33L,11L,55L,11L,33L,44L,11L,0L,0L,0L,0L,0L,12L,0L,12L,0L,0L,24L,12L,0L,0L,13L,13L,13L,13L,13L,13L,65L,91L,39L,13L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096133Inst : IEnumerable<long>
{
public static readonly long[] Value=A096133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096133.Bytes);
public long this[int i]=>Value[i];

public static A096133Inst Instance=new A096133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096134
{
public static readonly long[] Value={ 2L,4L,9L,12L,5L,18L,7L,80L,9L,40L,11L,48L,65L,112L,15L,128L,85L,18L,209L,100L,21L,44L,391L,24L,125L,208L,27L,224L,493L,30L,341L,64L,231L,68L,175L,36L,185L,418L,39L,80L,697L,84L,215L,88L,225L,46L,329L,48L,539L,100L,153L,364L,1007L,54L,715L,56L,285L,58L,767L,120L,61L,1178L,315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096134Inst : IEnumerable<long>
{
public static readonly long[] Value=A096134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096134.Bytes);
public long this[int i]=>Value[i];

public static A096134Inst Instance=new A096134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096135
{
public static readonly long[] Value={ 1L,3L,2L,4L,5L,6L,7L,9L,10L,8L,11L,12L,13L,14L,15L,16L,17L,18L,19L,21L,20L,22L,23L,24L,25L,28L,26L,27L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096135Inst : IEnumerable<long>
{
public static readonly long[] Value=A096135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096135.Bytes);
public long this[int i]=>Value[i];

public static A096135Inst Instance=new A096135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096136
{
public static readonly long[] Value={ 1L,16L,152L,19777L,222426283L,26953032020L,3176060754661L,366289154167942L,41537711571381605L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096136Inst : IEnumerable<long>
{
public static readonly long[] Value=A096136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096136.Bytes);
public long this[int i]=>Value[i];

public static A096136Inst Instance=new A096136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096137
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,2L,3L,3L,4L,5L,6L,1L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,7L,8L,9L,10L,1L,2L,3L,3L,4L,4L,5L,5L,5L,6L,6L,6L,7L,7L,7L,8L,8L,8L,9L,9L,9L,10L,10L,10L,11L,11L,12L,12L,13L,14L,15L,1L,2L,3L,3L,4L,4L,5L,5L,5L,6L,6L,6L,6L,7L,7L,7L,7L,8L,8L,8L,8L,9L,9L,9L,9L,9L,10L,10L,10L,10L,10L,11L,11L,11L,11L,11L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096137Inst : IEnumerable<long>
{
public static readonly long[] Value=A096137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096137.Bytes);
public long this[int i]=>Value[i];

public static A096137Inst Instance=new A096137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096138
{
public static readonly long[] Value={ 1L,2L,6L,42L,12L,27L,981L,8487L,38367L,76383L,312048L,6754473L,94180878L,2922358131L,56917353834L,443166776019L,3232915383357L,62400967429185L,5154511838165811L,22613367632090301L,123698372027088474L,8246495954814631272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096138Inst : IEnumerable<long>
{
public static readonly long[] Value=A096138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096138.Bytes);
public long this[int i]=>Value[i];

public static A096138Inst Instance=new A096138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096139
{
public static readonly long[] Value={ 1L,3L,3L,4L,3L,4L,5L,4L,6L,6L,5L,8L,5L,4L,8L,6L,7L,8L,5L,6L,10L,8L,7L,12L,8L,6L,12L,6L,7L,14L,7L,10L,12L,6L,10L,14L,11L,10L,14L,10L,9L,18L,9L,8L,20L,8L,9L,14L,8L,12L,18L,12L,11L,18L,14L,14L,22L,12L,11L,24L,7L,10L,20L,8L,14L,20L,11L,10L,18L,16L,15L,22L,11L,10L,26L,10L,16L,22L,11L,16L,20L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096139Inst : IEnumerable<long>
{
public static readonly long[] Value=A096139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096139.Bytes);
public long this[int i]=>Value[i];

public static A096139Inst Instance=new A096139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096140
{
public static readonly long[] Value={ 0L,1L,3L,10L,29L,81L,220L,589L,1563L,4126L,10857L,28513L,74792L,196041L,513619L,1345282L,3522981L,9224881L,24153636L,63239221L,165569195L,433476726L,1134874513L,2971168705L,7778667024L,20364889681L,53316094755L,139583544634L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096140Inst : IEnumerable<long>
{
public static readonly long[] Value=A096140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096140.Bytes);
public long this[int i]=>Value[i];

public static A096140Inst Instance=new A096140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096141
{
public static readonly BigInteger[] Value={ 1L,13L,216L,4578L,119525L,3729451L,135771160L,5658574916L,265921407297L,13918657338925L,803220053336096L,50674352524725590L,3470170166345203477L,BigInteger.Parse("256369124879898560271"),BigInteger.Parse("20325382637400264402000") };
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
public class A096141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096141Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A096141.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A096141.Bytes);
public BigInteger this[int i]=>Value[i];

public static A096141Inst Instance=new A096141Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096142
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,0L,0L,2L,0L,0L,2L,0L,2L,3L,0L,0L,2L,3L,0L,2L,0L,0L,2L,0L,2L,3L,0L,2L,3L,0L,0L,2L,3L,0L,2L,0L,0L,2L,3L,0L,2L,0L,2L,3L,0L,2L,3L,4L,0L,2L,0L,0L,2L,0L,0L,2L,0L,2L,3L,4L,6L,5L,6L,0L,2L,0L,2L,3L,0L,0L,2L,3L,4L,5L,0L,0L,2L,3L,0L,2L,3L,0L,2L,0L,2L,3L,0L,2L,3L,0L,0L,2L,3L,4L,5L,0L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096142Inst : IEnumerable<long>
{
public static readonly long[] Value=A096142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096142.Bytes);
public long this[int i]=>Value[i];

public static A096142Inst Instance=new A096142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096143
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096143Inst : IEnumerable<long>
{
public static readonly long[] Value=A096143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096143.Bytes);
public long this[int i]=>Value[i];

public static A096143Inst Instance=new A096143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096144
{
public static readonly long[] Value={ 1L,1L,1L,2L,0L,1L,2L,2L,0L,1L,4L,1L,1L,0L,1L,4L,3L,2L,1L,0L,1L,7L,3L,2L,1L,1L,0L,1L,8L,6L,2L,3L,1L,1L,0L,1L,12L,5L,6L,2L,2L,1L,1L,0L,1L,14L,11L,5L,4L,3L,2L,1L,1L,0L,1L,21L,11L,8L,5L,4L,2L,2L,1L,1L,0L,1L,24L,17L,11L,9L,4L,5L,2L,2L,1L,1L,0L,1L,34L,20L,15L,9L,8L,4L,4L,2L,2L,1L,1L,0L,1L,41L,30L,18L,14L,9L,7L,5L,4L,2L,2L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096144Inst : IEnumerable<long>
{
public static readonly long[] Value=A096144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096144.Bytes);
public long this[int i]=>Value[i];

public static A096144Inst Instance=new A096144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096145
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,4L,6L,4L,1L,1L,5L,1L,1L,5L,1L,1L,6L,6L,2L,6L,6L,1L,1L,7L,3L,8L,8L,3L,7L,1L,1L,8L,10L,11L,7L,11L,10L,8L,1L,1L,9L,9L,12L,9L,9L,12L,9L,9L,1L,1L,1L,9L,3L,3L,9L,3L,3L,9L,1L,1L,1L,2L,10L,12L,6L,12L,12L,6L,12L,10L,2L,1L,1L,3L,12L,4L,18L,18L,15L,18L,18L,4L,12L,3L,1L,1L,4L,15L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096145Inst : IEnumerable<long>
{
public static readonly long[] Value=A096145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096145.Bytes);
public long this[int i]=>Value[i];

public static A096145Inst Instance=new A096145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096146
{
public static readonly long[] Value={ 2L,5L,7L,19L,71L,97L,3691L,191861L,138907099L,708158977L,26947261171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096146Inst : IEnumerable<long>
{
public static readonly long[] Value=A096146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096146.Bytes);
public long this[int i]=>Value[i];

public static A096146Inst Instance=new A096146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096147
{
public static readonly BigInteger[] Value={ 3L,11L,41L,571L,2131L,110771L,1542841L,15558008491L,808717138331L,BigInteger.Parse("1663476485027525263506023431291963826940251"),BigInteger.Parse("33648911495192637123958375850447995878147331088460770783226682531") };
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
public class A096147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096147Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A096147.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A096147.Bytes);
public BigInteger this[int i]=>Value[i];

public static A096147Inst Instance=new A096147Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096180
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,1L,4L,4L,3L,1L,16L,20L,16L,7L,1L,16L,20L,12L,6L,5L,1L,96L,136L,92L,48L,36L,11L,1L,192L,272L,136L,124L,66L,38L,11L,1L,576L,720L,464L,360L,206L,122L,58L,13L,1L,576L,720L,392L,384L,188L,154L,70L,26L,9L,1L,5760L,7776L,4640L,4232L,2264L,1728L,854L,330L,116L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096180Inst : IEnumerable<long>
{
public static readonly long[] Value=A096180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096180.Bytes);
public long this[int i]=>Value[i];

public static A096180Inst Instance=new A096180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096181
{
public static readonly long[] Value={ 17L,15L,17L,22L,28L,36L,46L,60L,76L,98L,125L,158L,201L,254L,320L,403L,506L,634L,793L,989L,1233L,1533L,1904L,2360L,2922L,3612L,4459L,5498L,6771L,8328L,10231L,12556L,15393L,18851L,23063L,28189L,34423L,41998L,51195L,62353L,75883L,92274L,112119L,136131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096181Inst : IEnumerable<long>
{
public static readonly long[] Value=A096181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096181.Bytes);
public long this[int i]=>Value[i];

public static A096181Inst Instance=new A096181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096182
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,10L,13L,16L,19L,22L,26L,30L,34L,38L,42L,46L,51L,56L,61L,66L,71L,76L,82L,88L,94L,100L,106L,112L,118L,124L,130L,136L,142L,148L,155L,162L,169L,176L,183L,190L,197L,204L,211L,218L,225L,232L,240L,248L,256L,264L,272L,280L,288L,296L,304L,312L,320L,328L,336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096182Inst : IEnumerable<long>
{
public static readonly long[] Value=A096182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096182.Bytes);
public long this[int i]=>Value[i];

public static A096182Inst Instance=new A096182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096183
{
public static readonly long[] Value={ 1L,2L,10L,22L,46L,76L,148L,232L,352L,487L,727L,991L,1279L,1643L,2035L,2455L,3095L,3775L,4495L,5350L,6250L,7195L,8515L,9895L,11335L,12835L,14551L,16333L,18181L,20095L,22255L,24487L,26791L,29167L,32261L,35446L,38722L,42089L,45813L,49635L,53555L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096183Inst : IEnumerable<long>
{
public static readonly long[] Value=A096183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096183.Bytes);
public long this[int i]=>Value[i];

public static A096183Inst Instance=new A096183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096184
{
public static readonly long[] Value={ 1L,2L,6L,10L,16L,22L,34L,46L,61L,76L,100L,124L,148L,176L,204L,232L,272L,312L,352L,397L,442L,487L,547L,607L,667L,727L,793L,859L,925L,991L,1063L,1135L,1207L,1279L,1370L,1461L,1552L,1643L,1741L,1839L,1937L,2035L,2140L,2245L,2350L,2455L,2583L,2711L,2839L,2967L,3095L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096184Inst : IEnumerable<long>
{
public static readonly long[] Value=A096184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096184.Bytes);
public long this[int i]=>Value[i];

public static A096184Inst Instance=new A096184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096185
{
public static readonly long[] Value={ 3L,4L,8L,9L,16L,25L,33L,40L,116L,201L,208L,504L,579L,964L,1060L,1160L,1508L,1969L,4615L,7311L,65964L,83121L,87396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096185Inst : IEnumerable<long>
{
public static readonly long[] Value=A096185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096185.Bytes);
public long this[int i]=>Value[i];

public static A096185Inst Instance=new A096185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096186
{
public static readonly long[] Value={ 1L,2L,4L,9L,12L,14L,19L,26L,28L,72L,79L,273L,565L,990L,1166L,2205L,4212L,5340L,5562L,9877L,10297L,14316L,35908L,48410L,61525L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096186Inst : IEnumerable<long>
{
public static readonly long[] Value=A096186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096186.Bytes);
public long this[int i]=>Value[i];

public static A096186Inst Instance=new A096186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096187
{
public static readonly long[] Value={ 3L,9L,11L,16L,27L,38L,67L,193L,3471L,155343L,623325L,1080229L,3411233L,32457502L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096187Inst : IEnumerable<long>
{
public static readonly long[] Value=A096187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096187.Bytes);
public long this[int i]=>Value[i];

public static A096187Inst Instance=new A096187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096188
{
public static readonly long[] Value={ 1L,3L,3L,7L,13L,14L,14L,27L,27L,46L,99L,549L,913L,2637L,3830L,3929L,15500L,55253L,85854L,246166L,1052057L,2490138L,2521393L,16086534L,29730193L,38774343L,84328391L,317160458L,371478595L,600277187L,811735945L,849656112L,139143919171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096188Inst : IEnumerable<long>
{
public static readonly long[] Value=A096188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096188.Bytes);
public long this[int i]=>Value[i];

public static A096188Inst Instance=new A096188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096189
{
public static readonly long[] Value={ 2L,4L,4L,8L,702L,4009L,7367L,10741L,14787L,21899L,33647L,228471L,312343L,1020763L,1230193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096189Inst : IEnumerable<long>
{
public static readonly long[] Value=A096189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096189.Bytes);
public long this[int i]=>Value[i];

public static A096189Inst Instance=new A096189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096190
{
public static readonly long[] Value={ 2L,2L,18L,42L,82L,92L,171L,776L,2748L,11549L,19263L,49723L,65791L,179653L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096190Inst : IEnumerable<long>
{
public static readonly long[] Value=A096190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096190.Bytes);
public long this[int i]=>Value[i];

public static A096190Inst Instance=new A096190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096191
{
public static readonly long[] Value={ 1L,9L,55L,345L,2251L,15183L,104959L,739161L,5280931L,38165259L,278415919L,2046924399L,15148345759L,112738423359L,843126957055L,6332299624281L,47737325577619L,361077477684435L,2739270870994735L,20836827035351595L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096191Inst : IEnumerable<long>
{
public static readonly long[] Value=A096191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096191.Bytes);
public long this[int i]=>Value[i];

public static A096191Inst Instance=new A096191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096192
{
public static readonly long[] Value={ 1L,17L,163L,1809L,21251L,263843L,3395015L,44916497L,607041379L,8345319267L,116335834055L,1640651321763L,23365271704711L,335556407724359L,4854133484555663L,70666388112940817L,1034529673001901731L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096192Inst : IEnumerable<long>
{
public static readonly long[] Value=A096192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096192.Bytes);
public long this[int i]=>Value[i];

public static A096192Inst Instance=new A096192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096193
{
public static readonly long[] Value={ 1L,2L,3L,3L,3L,3L,10L,19L,27L,32L,41L,209L,351L,809L,1235L,3337L,4109L,43834L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096193Inst : IEnumerable<long>
{
public static readonly long[] Value=A096193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096193.Bytes);
public long this[int i]=>Value[i];

public static A096193Inst Instance=new A096193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096194
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,7L,13L,27L,45L,212L,388L,735L,3422L,3913L,11095L,18232L,20624L,54745L,426826L,617936L,3424833L,3494454L,3664162L,5238283L,5650352L,17373150L,168850488L,716822623L,729646247L,1226034011L,3976121167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096194Inst : IEnumerable<long>
{
public static readonly long[] Value=A096194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096194.Bytes);
public long this[int i]=>Value[i];

public static A096194Inst Instance=new A096194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096195
{
public static readonly long[] Value={ 2L,8L,16L,64L,106L,324L,696L,1856L,4046L,10240L,19084L,49152L,98110L,218140L,464084L,1047744L,2123446L,4718592L,9632740L,20666444L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096195Inst : IEnumerable<long>
{
public static readonly long[] Value=A096195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096195.Bytes);
public long this[int i]=>Value[i];

public static A096195Inst Instance=new A096195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096244
{
public static readonly long[] Value={ 4L,16L,73L,288L,1117L,4472L,18120L,74643L,315174L,1348936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096244Inst : IEnumerable<long>
{
public static readonly long[] Value=A096244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096244.Bytes);
public long this[int i]=>Value[i];

public static A096244Inst Instance=new A096244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096245
{
public static readonly long[] Value={ 5L,25L,186L,1398L,11500L,99074L,893062L,8352961L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096245Inst : IEnumerable<long>
{
public static readonly long[] Value=A096245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096245.Bytes);
public long this[int i]=>Value[i];

public static A096245Inst Instance=new A096245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096246
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,19L,23L,29L,37L,43L,47L,53L,59L,61L,73L,79L,83L,101L,107L,109L,137L,149L,151L,157L,163L,167L,173L,179L,197L,211L,229L,277L,281L,293L,307L,311L,313L,317L,331L,347L,349L,359L,389L,397L,419L,421L,457L,461L,467L,557L,563L,569L,587L,599L,601L,613L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096246Inst : IEnumerable<long>
{
public static readonly long[] Value=A096246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096246.Bytes);
public long this[int i]=>Value[i];

public static A096246Inst Instance=new A096246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096247
{
public static readonly long[] Value={ 0L,3L,7L,3L,5L,7L,0L,3L,7L,0L,4L,0L,5L,4L,1L,9L,7L,6L,0L,3L,3L,0L,5L,9L,8L,0L,0L,6L,6L,1L,3L,7L,9L,4L,6L,6L,8L,8L,1L,9L,8L,2L,4L,1L,6L,1L,9L,8L,7L,2L,2L,6L,8L,3L,3L,5L,5L,0L,4L,7L,0L,6L,9L,7L,7L,4L,6L,0L,0L,7L,5L,7L,9L,0L,8L,0L,6L,9L,1L,2L,1L,4L,9L,5L,3L,9L,2L,7L,4L,1L,3L,0L,8L,5L,7L,3L,6L,5L,1L,6L,8L,3L,5L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096247Inst : IEnumerable<long>
{
public static readonly long[] Value=A096247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096247.Bytes);
public long this[int i]=>Value[i];

public static A096247Inst Instance=new A096247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096248
{
public static readonly long[] Value={ 0L,0L,0L,3L,2L,1L,2L,1L,4L,2L,6L,5L,6L,8L,2L,2L,0L,3L,7L,0L,3L,3L,5L,8L,2L,4L,5L,2L,1L,7L,5L,0L,4L,8L,4L,8L,4L,2L,7L,0L,5L,2L,9L,8L,8L,6L,4L,2L,6L,6L,8L,9L,3L,2L,9L,9L,1L,1L,2L,9L,8L,8L,3L,1L,4L,3L,9L,1L,1L,7L,2L,3L,8L,7L,1L,8L,1L,1L,7L,6L,2L,5L,3L,5L,4L,2L,0L,6L,6L,5L,5L,3L,7L,4L,8L,6L,2L,1L,7L,4L,1L,0L,0L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096248Inst : IEnumerable<long>
{
public static readonly long[] Value=A096248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096248.Bytes);
public long this[int i]=>Value[i];

public static A096248Inst Instance=new A096248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096249
{
public static readonly long[] Value={ 0L,0L,4L,1L,2L,8L,0L,2L,6L,3L,3L,7L,4L,7L,7L,5L,2L,6L,1L,0L,8L,7L,5L,9L,7L,4L,4L,6L,3L,8L,2L,6L,3L,1L,9L,0L,5L,2L,2L,2L,2L,2L,2L,5L,9L,9L,6L,3L,1L,2L,0L,7L,3L,0L,7L,1L,1L,9L,7L,8L,3L,4L,2L,0L,2L,6L,1L,3L,7L,5L,5L,3L,1L,5L,0L,1L,1L,4L,4L,2L,8L,4L,3L,7L,6L,5L,3L,0L,1L,3L,5L,6L,0L,9L,9L,2L,5L,0L,4L,5L,1L,3L,4L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096249Inst : IEnumerable<long>
{
public static readonly long[] Value=A096249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096249.Bytes);
public long this[int i]=>Value[i];

public static A096249Inst Instance=new A096249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096250
{
public static readonly long[] Value={ 1L,1L,2L,9L,1L,7L,6L,2L,8L,2L,0L,5L,0L,2L,6L,8L,4L,7L,4L,9L,3L,8L,2L,9L,8L,5L,6L,6L,7L,0L,3L,9L,0L,5L,3L,6L,8L,1L,4L,2L,5L,0L,0L,5L,4L,0L,3L,7L,4L,3L,9L,4L,6L,4L,9L,1L,0L,7L,2L,7L,6L,3L,2L,2L,4L,4L,3L,5L,8L,4L,7L,3L,3L,0L,7L,3L,9L,2L,8L,5L,4L,3L,4L,0L,7L,1L,0L,3L,2L,7L,9L,4L,3L,4L,1L,2L,7L,2L,8L,9L,3L,1L,6L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096250Inst : IEnumerable<long>
{
public static readonly long[] Value=A096250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096250.Bytes);
public long this[int i]=>Value[i];

public static A096250Inst Instance=new A096250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096251
{
public static readonly long[] Value={ 1L,7L,7L,8L,8L,7L,7L,4L,2L,2L,0L,8L,4L,6L,6L,3L,9L,1L,2L,4L,6L,0L,3L,6L,5L,1L,8L,9L,3L,6L,8L,2L,5L,0L,3L,6L,9L,2L,8L,7L,4L,9L,3L,0L,3L,8L,1L,6L,8L,6L,8L,1L,5L,1L,2L,6L,0L,4L,7L,5L,8L,6L,6L,0L,2L,7L,8L,2L,5L,3L,4L,2L,7L,5L,6L,3L,9L,0L,1L,8L,3L,4L,6L,2L,5L,1L,7L,9L,8L,7L,0L,9L,4L,3L,9L,1L,8L,9L,0L,5L,0L,5L,4L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096251Inst : IEnumerable<long>
{
public static readonly long[] Value=A096251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096251.Bytes);
public long this[int i]=>Value[i];

public static A096251Inst Instance=new A096251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096252
{
public static readonly long[] Value={ 4L,-4L,8L,-32L,-32L,-64L,-256L,256L,-512L,2048L,2048L,4096L,16384L,-16384L,32768L,-131072L,-131072L,-262144L,-1048576L,1048576L,-2097152L,8388608L,8388608L,16777216L,67108864L,-67108864L,134217728L,-536870912L,-536870912L,-1073741824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096252Inst : IEnumerable<long>
{
public static readonly long[] Value=A096252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096252.Bytes);
public long this[int i]=>Value[i];

public static A096252Inst Instance=new A096252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096253
{
public static readonly long[] Value={ 1L,6L,3L,8L,0L,3L,1L,2L,1L,7L,9L,1L,2L,4L,6L,4L,1L,8L,0L,7L,2L,8L,4L,2L,9L,7L,3L,2L,5L,8L,1L,5L,4L,3L,0L,4L,9L,6L,3L,4L,1L,8L,5L,6L,3L,9L,2L,8L,5L,1L,2L,9L,8L,6L,7L,3L,8L,9L,9L,1L,8L,5L,4L,0L,8L,8L,3L,0L,0L,2L,5L,4L,7L,9L,9L,5L,6L,4L,9L,7L,3L,9L,0L,4L,2L,4L,2L,8L,9L,8L,8L,0L,8L,8L,2L,7L,3L,8L,8L,6L,1L,9L,1L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096253Inst : IEnumerable<long>
{
public static readonly long[] Value=A096253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096253.Bytes);
public long this[int i]=>Value[i];

public static A096253Inst Instance=new A096253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096254
{
public static readonly long[] Value={ 1L,2L,3L,8L,18L,20L,31L,42L,103L,175L,181L,531L,706L,1077L,1177L,1552L,19737L,32197L,51508L,58275L,62233L,90033L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096254Inst : IEnumerable<long>
{
public static readonly long[] Value=A096254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096254.Bytes);
public long this[int i]=>Value[i];

public static A096254Inst Instance=new A096254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096255
{
public static readonly long[] Value={ 2L,4L,8L,0L,5L,4L,8L,3L,0L,2L,1L,5L,8L,7L,0L,8L,3L,9L,1L,6L,0L,4L,0L,6L,3L,5L,3L,9L,3L,0L,1L,1L,4L,3L,3L,2L,2L,1L,3L,3L,3L,8L,3L,8L,3L,6L,6L,8L,8L,9L,4L,3L,3L,0L,2L,3L,2L,6L,2L,2L,1L,5L,5L,3L,6L,9L,7L,4L,7L,1L,0L,2L,6L,3L,4L,0L,1L,4L,7L,4L,7L,9L,6L,1L,7L,4L,6L,0L,9L,1L,8L,6L,3L,9L,4L,3L,0L,4L,3L,7L,0L,5L,0L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096255Inst : IEnumerable<long>
{
public static readonly long[] Value=A096255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096255.Bytes);
public long this[int i]=>Value[i];

public static A096255Inst Instance=new A096255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096256
{
public static readonly long[] Value={ 0L,4L,6L,0L,2L,8L,6L,4L,2L,5L,2L,5L,6L,9L,8L,9L,9L,5L,7L,4L,9L,2L,9L,2L,9L,6L,0L,0L,8L,3L,9L,9L,8L,0L,3L,5L,5L,2L,9L,8L,1L,4L,2L,2L,2L,0L,8L,6L,7L,4L,1L,5L,1L,9L,7L,5L,4L,7L,7L,9L,9L,2L,8L,5L,3L,3L,9L,2L,9L,4L,4L,8L,4L,2L,4L,1L,9L,0L,0L,7L,9L,4L,2L,5L,5L,6L,1L,8L,2L,1L,5L,3L,8L,0L,4L,4L,6L,7L,4L,7L,6L,1L,6L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096256Inst : IEnumerable<long>
{
public static readonly long[] Value=A096256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096256.Bytes);
public long this[int i]=>Value[i];

public static A096256Inst Instance=new A096256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096257
{
public static readonly long[] Value={ 8L,2L,3L,633L,19703L,89L,69L,56L,46L,39L,33L,29L,25L,22L,20L,18L,16L,14L,13L,12L,11L,10L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,138L,133L,128L,124L,120L,116L,113L,109L,106L,103L,100L,97L,95L,92L,90L,87L,85L,83L,81L,79L,77L,75L,74L,72L,70L,69L,67L,66L,65L,63L,62L,61L,59L,58L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096257Inst : IEnumerable<long>
{
public static readonly long[] Value=A096257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096257.Bytes);
public long this[int i]=>Value[i];

public static A096257Inst Instance=new A096257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096258
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,1L,1L,1L,1L,2L,3L,2L,2L,3L,4L,5L,5L,4L,6L,8L,8L,9L,11L,11L,13L,16L,17L,19L,22L,23L,27L,31L,32L,36L,43L,47L,52L,57L,61L,70L,80L,84L,93L,105L,114L,127L,141L,150L,167L,188L,202L,220L,244L,264L,291L,322L,346L,377L,416L,450L,493L,540L,580L,633L,696L,750L,814L,888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096258Inst : IEnumerable<long>
{
public static readonly long[] Value=A096258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096258.Bytes);
public long this[int i]=>Value[i];

public static A096258Inst Instance=new A096258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096259
{
public static readonly long[] Value={ 1L,2L,6L,24L,70L,180L,294L,112L,270L,900L,330L,792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096259Inst : IEnumerable<long>
{
public static readonly long[] Value=A096259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096259.Bytes);
public long this[int i]=>Value[i];

public static A096259Inst Instance=new A096259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096500
{
public static readonly long[] Value={ 1L,2L,0L,2L,0L,4L,0L,0L,0L,2L,0L,4L,0L,0L,0L,2L,0L,4L,0L,0L,0L,6L,0L,0L,0L,0L,0L,2L,0L,6L,0L,0L,0L,0L,0L,4L,0L,0L,0L,2L,0L,4L,0L,0L,0L,6L,0L,0L,0L,0L,0L,6L,0L,0L,0L,0L,0L,2L,0L,6L,0L,0L,0L,0L,0L,4L,0L,0L,0L,2L,0L,6L,0L,0L,0L,0L,0L,4L,0L,0L,0L,6L,0L,0L,0L,0L,0L,8L,0L,0L,0L,0L,0L,0L,0L,4L,0L,0L,0L,2L,0L,4L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096500Inst : IEnumerable<long>
{
public static readonly long[] Value=A096500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096500.Bytes);
public long this[int i]=>Value[i];

public static A096500Inst Instance=new A096500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096501
{
public static readonly long[] Value={ 0L,4L,1L,0L,2L,0L,2L,0L,0L,0L,4L,0L,2L,0L,0L,0L,4L,0L,2L,0L,0L,0L,4L,0L,0L,0L,0L,0L,6L,0L,2L,0L,0L,0L,0L,0L,6L,0L,0L,0L,4L,0L,2L,0L,0L,0L,4L,0L,0L,0L,0L,0L,6L,0L,0L,0L,0L,0L,6L,0L,2L,0L,0L,0L,0L,0L,6L,0L,0L,0L,4L,0L,2L,0L,0L,0L,0L,0L,6L,0L,0L,0L,4L,0L,0L,0L,0L,0L,6L,0L,0L,0L,0L,0L,0L,0L,8L,0L,0L,0L,4L,0L,2L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096501Inst : IEnumerable<long>
{
public static readonly long[] Value=A096501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096501.Bytes);
public long this[int i]=>Value[i];

public static A096501Inst Instance=new A096501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096502
{
public static readonly long[] Value={ 2L,3L,3L,39L,4L,4L,4L,5L,6L,5L,5L,6L,5L,5L,5L,7L,6L,6L,11L,7L,6L,29L,6L,6L,7L,6L,6L,7L,6L,6L,6L,8L,8L,7L,7L,10L,9L,7L,8L,9L,7L,8L,7L,7L,8L,7L,8L,10L,7L,7L,26L,9L,7L,8L,7L,7L,10L,7L,7L,8L,7L,7L,7L,47L,8L,14L,9L,11L,10L,9L,10L,8L,9L,8L,8L,31L,8L,8L,15L,8L,10L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096502Inst : IEnumerable<long>
{
public static readonly long[] Value=A096502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096502.Bytes);
public long this[int i]=>Value[i];

public static A096502Inst Instance=new A096502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096503
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,14L,15L,16L,18L,20L,23L,24L,30L,46L,67L,69L,89L,92L,115L,134L,138L,178L,184L,223L,230L,276L,446L,669L,892L,1043L,1115L,1338L,1341L,1784L,2086L,2230L,2676L,2682L,446669L,666667L,893338L,895043L,902423L,1333334L,1340007L,1786676L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096503Inst : IEnumerable<long>
{
public static readonly long[] Value=A096503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096503.Bytes);
public long this[int i]=>Value[i];

public static A096503Inst Instance=new A096503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096504
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,2L,6L,4L,6L,4L,4L,6L,8L,8L,6L,8L,22L,8L,8L,22L,66L,44L,88L,44L,88L,66L,44L,88L,88L,222L,88L,88L,222L,444L,444L,888L,888L,444L,888L,888L,888L,888L,888L,888L,444444L,666666L,444444L,888888L,888888L,666666L,888888L,888888L,888888L,888888L,888888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096504Inst : IEnumerable<long>
{
public static readonly long[] Value=A096504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096504.Bytes);
public long this[int i]=>Value[i];

public static A096504Inst Instance=new A096504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096505
{
public static readonly BigInteger[] Value={ 3L,5L,7L,23L,67L,89L,223L,666667L,22222223L,66666667L,666666667L,22222222223L,66666666667L,88888888888889L,88888888888888889L,BigInteger.Parse("66666666666666666667"),BigInteger.Parse("66666666666666666666667"),BigInteger.Parse("88888888888888888888888888888888889") };
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
public class A096505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096505Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A096505.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A096505.Bytes);
public BigInteger this[int i]=>Value[i];

public static A096505Inst Instance=new A096505Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096506
{
public static readonly long[] Value={ 1L,2L,3L,8L,11L,36L,95L,101L,128L,260L,351L,467L,645L,1011L,1178L,1217L,2442L,3761L,3806L,15617L,26459L,63117L,88545L,93497L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096506Inst : IEnumerable<long>
{
public static readonly long[] Value=A096506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096506.Bytes);
public long this[int i]=>Value[i];

public static A096506Inst Instance=new A096506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096507
{
public static readonly long[] Value={ 1L,2L,6L,8L,9L,11L,20L,23L,41L,63L,66L,119L,122L,149L,252L,284L,305L,592L,746L,875L,1204L,1364L,2240L,2403L,5106L,5776L,5813L,12456L,14235L,39606L,55544L,84239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096507Inst : IEnumerable<long>
{
public static readonly long[] Value=A096507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096507.Bytes);
public long this[int i]=>Value[i];

public static A096507Inst Instance=new A096507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096508
{
public static readonly long[] Value={ 2L,14L,17L,35L,4175L,4472L,9812L,12260L,12341L,13760L,14576L,53411L,144683L,148328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096508Inst : IEnumerable<long>
{
public static readonly long[] Value=A096508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096508.Bytes);
public long this[int i]=>Value[i];

public static A096508Inst Instance=new A096508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096509
{
public static readonly long[] Value={ 0L,2L,4L,4L,4L,4L,4L,5L,4L,5L,4L,3L,3L,4L,3L,4L,3L,3L,3L,3L,4L,3L,4L,3L,4L,4L,5L,5L,5L,4L,4L,3L,4L,3L,3L,2L,2L,2L,3L,3L,3L,2L,3L,3L,4L,3L,3L,2L,3L,3L,3L,2L,2L,1L,2L,3L,3L,3L,3L,3L,3L,4L,4L,4L,3L,4L,3L,4L,4L,3L,3L,3L,2L,3L,3L,4L,3L,4L,3L,3L,3L,3L,3L,4L,3L,3L,2L,2L,1L,1L,1L,2L,2L,2L,1L,2L,2L,3L,3L,3L,3L,4L,3L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096509Inst : IEnumerable<long>
{
public static readonly long[] Value=A096509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096509.Bytes);
public long this[int i]=>Value[i];

public static A096509Inst Instance=new A096509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096510
{
public static readonly long[] Value={ 1L,54L,2L,12L,3L,8L,4792L,75991L,284736L,6561003L,51448375L,964669618L,18320500423L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096510Inst : IEnumerable<long>
{
public static readonly long[] Value=A096510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096510.Bytes);
public long this[int i]=>Value[i];

public static A096510Inst Instance=new A096510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096511
{
public static readonly long[] Value={ 1L,300L,324L,895L,896L,897L,898L,899L,1077L,1078L,1079L,1138L,1139L,1140L,1141L,1142L,1268L,1340L,1341L,1342L,1343L,1344L,1345L,1346L,1347L,1348L,1349L,1350L,1351L,1352L,1390L,1646L,1647L,1648L,1768L,1922L,1960L,1961L,1962L,1963L,1964L,2170L,2320L,2321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096511Inst : IEnumerable<long>
{
public static readonly long[] Value=A096511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096511.Bytes);
public long this[int i]=>Value[i];

public static A096511Inst Instance=new A096511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096512
{
public static readonly long[] Value={ 54L,89L,90L,91L,95L,115L,119L,143L,145L,204L,206L,207L,208L,209L,210L,211L,212L,213L,214L,215L,216L,218L,219L,220L,296L,297L,298L,299L,301L,302L,303L,304L,320L,321L,322L,323L,325L,326L,327L,328L,329L,330L,390L,409L,410L,411L,471L,475L,476L,477L,478L,479L,531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096512Inst : IEnumerable<long>
{
public static readonly long[] Value=A096512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096512.Bytes);
public long this[int i]=>Value[i];

public static A096512Inst Instance=new A096512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096513
{
public static readonly long[] Value={ 2L,36L,37L,38L,42L,48L,52L,53L,55L,73L,87L,88L,92L,93L,94L,96L,97L,113L,114L,116L,117L,118L,120L,121L,137L,138L,139L,140L,141L,142L,144L,146L,147L,148L,149L,150L,156L,158L,159L,160L,180L,181L,182L,183L,184L,186L,188L,189L,190L,200L,201L,202L,203L,205L,217L,221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096513Inst : IEnumerable<long>
{
public static readonly long[] Value=A096513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096513.Bytes);
public long this[int i]=>Value[i];

public static A096513Inst Instance=new A096513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096514
{
public static readonly long[] Value={ 12L,13L,15L,17L,18L,19L,20L,22L,24L,32L,34L,35L,39L,40L,41L,43L,44L,46L,47L,49L,50L,51L,56L,57L,58L,59L,60L,61L,65L,67L,70L,71L,72L,74L,75L,77L,79L,80L,81L,82L,83L,85L,86L,98L,99L,100L,101L,103L,107L,109L,110L,111L,112L,122L,131L,133L,134L,135L,136L,151L,152L,153L,154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096514Inst : IEnumerable<long>
{
public static readonly long[] Value=A096514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096514.Bytes);
public long this[int i]=>Value[i];

public static A096514Inst Instance=new A096514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096515
{
public static readonly long[] Value={ 3L,4L,5L,6L,7L,9L,11L,14L,16L,21L,23L,25L,26L,30L,31L,33L,45L,62L,63L,64L,66L,68L,69L,76L,78L,84L,102L,104L,105L,106L,108L,123L,124L,125L,127L,128L,129L,130L,132L,163L,167L,168L,169L,173L,175L,193L,194L,195L,196L,197L,227L,228L,229L,233L,235L,237L,238L,239L,245L,257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096515Inst : IEnumerable<long>
{
public static readonly long[] Value=A096515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096515.Bytes);
public long this[int i]=>Value[i];

public static A096515Inst Instance=new A096515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096516
{
public static readonly long[] Value={ 8L,10L,27L,28L,29L,126L,1026L,1283L,1284L,1285L,1295L,1296L,1297L,1299L,1431L,1485L,1486L,1487L,1488L,1489L,1491L,1605L,1613L,1614L,1615L,1869L,1871L,1872L,1873L,1874L,1875L,1995L,2135L,2136L,2137L,2205L,2385L,2685L,2691L,2795L,2796L,2797L,3322L,3458L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096516Inst : IEnumerable<long>
{
public static readonly long[] Value=A096516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096516.Bytes);
public long this[int i]=>Value[i];

public static A096516Inst Instance=new A096516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096517
{
public static readonly long[] Value={ 4792L,5648L,5650L,9429L,13687L,13688L,13689L,14553L,14631L,16063L,16064L,16065L,16066L,16067L,18051L,19423L,19424L,19425L,19426L,19427L,19431L,21021L,22280L,22281L,22282L,24102L,26690L,26691L,26692L,26720L,26721L,26722L,27740L,27741L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096517Inst : IEnumerable<long>
{
public static readonly long[] Value=A096517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096517.Bytes);
public long this[int i]=>Value[i];

public static A096517Inst Instance=new A096517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096518
{
public static readonly long[] Value={ 75991L,85841L,88801L,88805L,88807L,88808L,88809L,88810L,88811L,93491L,113155L,113159L,113161L,113165L,163984L,163985L,163986L,165708L,165709L,165710L,165711L,165712L,165713L,165714L,166854L,191454L,191460L,198828L,198829L,198830L,223836L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096518Inst : IEnumerable<long>
{
public static readonly long[] Value=A096518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096518.Bytes);
public long this[int i]=>Value[i];

public static A096518Inst Instance=new A096518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096519
{
public static readonly long[] Value={ 284736L,595953L,855723L,855725L,855726L,855727L,1146785L,1146786L,1146787L,1616612L,1616618L,1616624L,1652884L,1654028L,1718708L,1749272L,1954358L,2176624L,2580658L,2580659L,2580660L,2580661L,2580662L,2831672L,2839942L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096519Inst : IEnumerable<long>
{
public static readonly long[] Value=A096519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096519.Bytes);
public long this[int i]=>Value[i];

public static A096519Inst Instance=new A096519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096520
{
public static readonly long[] Value={ 2L,3L,3L,3L,2L,3L,2L,2L,1L,3L,1L,3L,1L,1L,2L,3L,2L,5L,1L,4L,1L,2L,4L,2L,0L,2L,0L,2L,2L,5L,3L,3L,2L,0L,0L,3L,2L,2L,3L,2L,2L,3L,1L,4L,0L,2L,2L,1L,0L,2L,1L,2L,1L,1L,2L,2L,4L,1L,0L,1L,4L,0L,2L,2L,0L,3L,3L,2L,2L,2L,1L,1L,1L,3L,1L,3L,3L,3L,2L,1L,2L,4L,1L,3L,1L,3L,1L,1L,5L,3L,2L,1L,2L,2L,4L,2L,0L,4L,0L,1L,1L,2L,0L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096520Inst : IEnumerable<long>
{
public static readonly long[] Value=A096520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096520.Bytes);
public long this[int i]=>Value[i];

public static A096520Inst Instance=new A096520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096521
{
public static readonly long[] Value={ 25L,9L,1L,2L,20L,18L,127L,844L,573L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096521Inst : IEnumerable<long>
{
public static readonly long[] Value=A096521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096521.Bytes);
public long this[int i]=>Value[i];

public static A096521Inst Instance=new A096521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096522
{
public static readonly long[] Value={ 25L,27L,34L,35L,45L,49L,59L,62L,65L,97L,99L,103L,106L,113L,120L,139L,142L,169L,176L,181L,183L,185L,186L,208L,215L,216L,223L,227L,232L,237L,256L,259L,267L,269L,293L,298L,302L,309L,332L,333L,334L,340L,349L,358L,361L,362L,364L,371L,373L,381L,387L,403L,426L,433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096522Inst : IEnumerable<long>
{
public static readonly long[] Value=A096522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096522.Bytes);
public long this[int i]=>Value[i];

public static A096522Inst Instance=new A096522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096523
{
public static readonly long[] Value={ 127L,505L,573L,619L,670L,714L,743L,844L,963L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096523Inst : IEnumerable<long>
{
public static readonly long[] Value=A096523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096523.Bytes);
public long this[int i]=>Value[i];

public static A096523Inst Instance=new A096523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096524
{
public static readonly long[] Value={ 6L,8L,20L,36L,38L,42L,48L,50L,66L,72L,78L,96L,128L,140L,150L,152L,188L,212L,216L,218L,272L,296L,300L,318L,330L,336L,360L,366L,372L,386L,398L,408L,422L,446L,462L,482L,488L,492L,498L,542L,546L,552L,560L,570L,582L,608L,630L,638L,672L,678L,710L,716L,740L,756L,780L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096524Inst : IEnumerable<long>
{
public static readonly long[] Value=A096524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096524.Bytes);
public long this[int i]=>Value[i];

public static A096524Inst Instance=new A096524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096525
{
public static readonly long[] Value={ 607L,809L,20021L,36037L,38039L,42043L,48049L,50051L,66067L,72073L,78079L,96097L,1280129L,1400141L,1500151L,1520153L,1880189L,2120213L,2160217L,2180219L,2720273L,2960297L,3000301L,3180319L,3300331L,3360337L,3600361L,3660367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096525Inst : IEnumerable<long>
{
public static readonly long[] Value=A096525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096525.Bytes);
public long this[int i]=>Value[i];

public static A096525Inst Instance=new A096525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096526
{
public static readonly long[] Value={ 324L,400L,484L,490L,530L,544L,576L,630L,660L,672L,684L,690L,714L,722L,750L,756L,768L,770L,772L,777L,780L,792L,804L,810L,819L,828L,832L,833L,840L,841L,846L,852L,858L,864L,868L,870L,872L,876L,888L,892L,901L,906L,910L,918L,920L,924L,930L,936L,940L,948L,952L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096526Inst : IEnumerable<long>
{
public static readonly long[] Value=A096526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096526.Bytes);
public long this[int i]=>Value[i];

public static A096526Inst Instance=new A096526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096527
{
public static readonly long[] Value={ 0L,0L,0L,6L,0L,0L,0L,12L,6L,4L,0L,12L,0L,4L,4L,4L,0L,0L,0L,16L,12L,0L,0L,20L,6L,4L,12L,20L,0L,0L,0L,0L,4L,4L,24L,48L,0L,4L,12L,50L,0L,0L,0L,4L,12L,0L,0L,0L,0L,0L,0L,16L,0L,0L,24L,136L,12L,4L,0L,286L,0L,0L,96L,0L,24L,0L,0L,30L,0L,0L,0L,0L,0L,0L,32L,16L,4L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096527Inst : IEnumerable<long>
{
public static readonly long[] Value=A096527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096527.Bytes);
public long this[int i]=>Value[i];

public static A096527Inst Instance=new A096527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096528
{
public static readonly long[] Value={ 0L,0L,0L,3L,0L,0L,0L,6L,3L,2L,0L,6L,0L,2L,2L,2L,0L,0L,0L,8L,6L,0L,0L,10L,3L,2L,6L,10L,0L,0L,0L,0L,2L,2L,12L,24L,0L,2L,6L,25L,0L,0L,0L,2L,6L,0L,0L,0L,0L,0L,0L,8L,0L,0L,12L,68L,6L,2L,0L,143L,0L,0L,48L,0L,12L,0L,0L,15L,0L,0L,0L,0L,0L,0L,16L,8L,2L,0L,0L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096528Inst : IEnumerable<long>
{
public static readonly long[] Value=A096528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096528.Bytes);
public long this[int i]=>Value[i];

public static A096528Inst Instance=new A096528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096529
{
public static readonly long[] Value={ 4L,8L,9L,10L,12L,14L,15L,16L,20L,21L,24L,25L,26L,27L,28L,33L,34L,35L,36L,38L,39L,40L,44L,45L,52L,55L,56L,57L,58L,60L,63L,65L,68L,75L,76L,77L,81L,84L,85L,86L,88L,92L,93L,99L,100L,104L,105L,111L,115L,117L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096529Inst : IEnumerable<long>
{
public static readonly long[] Value=A096529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096529.Bytes);
public long this[int i]=>Value[i];

public static A096529Inst Instance=new A096529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096530
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,11L,13L,17L,18L,19L,22L,23L,29L,30L,31L,32L,37L,41L,42L,43L,46L,47L,48L,49L,50L,51L,53L,54L,59L,61L,62L,64L,66L,67L,69L,70L,71L,72L,73L,74L,78L,79L,80L,82L,83L,87L,89L,90L,91L,94L,95L,96L,97L,98L,101L,102L,103L,106L,107L,108L,109L,110L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096530Inst : IEnumerable<long>
{
public static readonly long[] Value=A096530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096530.Bytes);
public long this[int i]=>Value[i];

public static A096530Inst Instance=new A096530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096531
{
public static readonly long[] Value={ 0L,0L,4L,9L,34L,71L,245L,543L,1835L,4223L,14167L,33279L,111279L,264191L,882015L,2105343L,7023295L,16809983L,56055167L,134348799L,447916799L,1074266111L,3581236735L,8592031743L,28641504255L,68727865343L,229098477567L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096531Inst : IEnumerable<long>
{
public static readonly long[] Value=A096531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096531.Bytes);
public long this[int i]=>Value[i];

public static A096531Inst Instance=new A096531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096548
{
public static readonly long[] Value={ 7L,289L,7L,33603L,309403L,593499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096548Inst : IEnumerable<long>
{
public static readonly long[] Value=A096548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096548.Bytes);
public long this[int i]=>Value[i];

public static A096548Inst Instance=new A096548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096549
{
public static readonly long[] Value={ 1L,6L,10L,11L,19L,43L,50L,50L,71L,71L,523L,590L,590L,12106L,12106L,12106L,12106L,56590L,505206L,1570511L,1570511L,4033966L,4033966L,9525771L,24045606L,24045606L,57862019L,183002599L,183002599L,877875719L,877875719L,877875719L,3789535319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096549Inst : IEnumerable<long>
{
public static readonly long[] Value=A096549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096549.Bytes);
public long this[int i]=>Value[i];

public static A096549Inst Instance=new A096549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096550
{
public static readonly long[] Value={ 1L,16807L,282475249L,1622650073L,984943658L,1144108930L,470211272L,101027544L,1457850878L,1458777923L,2007237709L,823564440L,1115438165L,1784484492L,74243042L,114807987L,1137522503L,1441282327L,16531729L,823378840L,143542612L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096550Inst : IEnumerable<long>
{
public static readonly long[] Value=A096550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096550.Bytes);
public long this[int i]=>Value[i];

public static A096550Inst Instance=new A096550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096551
{
public static readonly long[] Value={ 1L,69069L,475559465L,2801775573L,1790562961L,3104832285L,4238970681L,2135332261L,381957665L,1744831853L,1303896393L,1945705589L,2707602097L,4198202557L,3820321881L,201201733L,2583294017L,4003049741L,2417848425L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096551Inst : IEnumerable<long>
{
public static readonly long[] Value=A096551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096551.Bytes);
public long this[int i]=>Value[i];

public static A096551Inst Instance=new A096551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096552
{
public static readonly long[] Value={ 0L,1L,69070L,475628535L,3277404108L,772999773L,3877832058L,3821835443L,1662200408L,2044158073L,3788989926L,797919023L,2743624612L,1156259413L,1059494674L,584849259L,786050992L,3369345009L,3077427454L,1200308583L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096552Inst : IEnumerable<long>
{
public static readonly long[] Value=A096552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096552.Bytes);
public long this[int i]=>Value[i];

public static A096552Inst Instance=new A096552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096553
{
public static readonly long[] Value={ 1L,1103527590L,377401575L,662824084L,1147902781L,2035015474L,368800899L,1508029952L,486256185L,1062517886L,267834847L,180171308L,836760821L,595337866L,790425851L,2111915288L,1149758321L,1644289366L,1388290519L,1647418052L,1675546029L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096553Inst : IEnumerable<long>
{
public static readonly long[] Value=A096553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096553.Bytes);
public long this[int i]=>Value[i];

public static A096553Inst Instance=new A096553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096554
{
public static readonly long[] Value={ 0L,21468L,9988L,22117L,3498L,16927L,16045L,19741L,12122L,8410L,12261L,27052L,5659L,9758L,21087L,25875L,32368L,26233L,15212L,17661L,20496L,8191L,23065L,23471L,32096L,10781L,14596L,23212L,24244L,5661L,514L,25643L,1350L,19576L,8051L,18234L,16882L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096554Inst : IEnumerable<long>
{
public static readonly long[] Value=A096554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096554.Bytes);
public long this[int i]=>Value[i];

public static A096554Inst Instance=new A096554Inst();

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