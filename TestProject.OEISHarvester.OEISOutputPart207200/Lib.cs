using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A245582
{
public static readonly long[] Value={ 1L,2L,2L,8L,6L,32L,20L,100L,54L,260L,152L,684L,348L,1640L,884L,3728L,1974L,8672L,4556L,19420L,10056L,42736L,22508L,94164L,48636L,204632L,106472L,441764L,228444L,950216L,491120L,2031556L,1046454L,4323888L,2228192L,9174400L,4713252L,19398584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245582Inst : IEnumerable<long>
{
public static readonly long[] Value=A245582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245582.Bytes);
public long this[int i]=>Value[i];

public static A245582Inst Instance=new A245582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245583
{
public static readonly long[] Value={ 293L,439L,547L,1093L,1171L,2341L,3511L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245583Inst : IEnumerable<long>
{
public static readonly long[] Value=A245583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245583.Bytes);
public long this[int i]=>Value[i];

public static A245583Inst Instance=new A245583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245584
{
public static readonly long[] Value={ 1L,2L,3L,12L,122L,1222L,12222L,122222L,1222222L,12222222L,122222222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245584Inst : IEnumerable<long>
{
public static readonly long[] Value=A245584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245584.Bytes);
public long this[int i]=>Value[i];

public static A245584Inst Instance=new A245584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245585
{
public static readonly long[] Value={ 19L,23L,33L,35L,47L,59L,63L,71L,75L,77L,95L,103L,107L,118L,124L,129L,131L,143L,147L,155L,161L,167L,179L,187L,195L,201L,203L,206L,209L,215L,217L,223L,236L,239L,243L,247L,248L,251L,271L,275L,280L,283L,285L,287L,294L,299L,311L,316L,323L,327L,329L,332L,334L,339L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245585Inst : IEnumerable<long>
{
public static readonly long[] Value=A245585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245585.Bytes);
public long this[int i]=>Value[i];

public static A245585Inst Instance=new A245585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245586
{
public static readonly long[] Value={ 1L,3L,7L,9L,11L,13L,15L,17L,19L,2L,52L,20L,23L,43L,54L,97L,46L,22L,4L,8L,27L,128L,40L,47L,91L,56L,42L,44L,64L,10L,77L,29L,223L,107L,98L,55L,57L,102L,120L,12L,60L,124L,241L,255L,101L,103L,92L,99L,151L,14L,95L,62L,199L,45L,326L,121L,116L,48L,106L,16L,111L,113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245586Inst : IEnumerable<long>
{
public static readonly long[] Value=A245586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245586.Bytes);
public long this[int i]=>Value[i];

public static A245586Inst Instance=new A245586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245587
{
public static readonly long[] Value={ 18L,35L,50L,1680L,2664L,3350L,4130L,5000L,166800L,251664L,333500L,401330L,500000L,16668000L,25016664L,33335000L,40013330L,50000000L,1666680000L,2500166664L,3333350000L,4000133330L,5000000000L,166666800000L,250001666664L,333333500000L,400001333330L,500000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245587Inst : IEnumerable<long>
{
public static readonly long[] Value=A245587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245587.Bytes);
public long this[int i]=>Value[i];

public static A245587Inst Instance=new A245587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245588
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,1L,2L,2L,3L,3L,2L,3L,3L,1L,2L,2L,3L,3L,2L,3L,3L,4L,4L,3L,4L,4L,2L,3L,3L,4L,4L,3L,4L,4L,1L,2L,2L,3L,3L,2L,3L,3L,4L,4L,3L,4L,4L,2L,3L,3L,4L,4L,3L,4L,4L,5L,5L,4L,5L,5L,3L,4L,4L,5L,5L,4L,5L,5L,2L,3L,3L,4L,4L,3L,4L,4L,5L,5L,4L,5L,5L,3L,4L,4L,5L,5L,4L,5L,5L,1L,2L,2L,3L,3L,2L,3L,3L,4L,4L,3L,4L,4L,2L,3L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245588Inst : IEnumerable<long>
{
public static readonly long[] Value=A245588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245588.Bytes);
public long this[int i]=>Value[i];

public static A245588Inst Instance=new A245588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245589
{
public static readonly long[] Value={ 53L,593L,1747L,2287L,4013L,4409L,5563L,6317L,8117L,10657L,10853L,11933L,12547L,12583L,12653L,15161L,16937L,17047L,17851L,18341L,19603L,19949L,20107L,22051L,26693L,31051L,32993L,35851L,35911L,39113L,42209L,42533L,44041L,46889L,47527L,48259L,50417L,51461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245589Inst : IEnumerable<long>
{
public static readonly long[] Value=A245589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245589.Bytes);
public long this[int i]=>Value[i];

public static A245589Inst Instance=new A245589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245590
{
public static readonly long[] Value={ 2L,3L,7L,17L,23L,41L,47L,53L,59L,101L,149L,157L,173L,179L,193L,211L,229L,233L,239L,241L,251L,311L,347L,349L,353L,359L,373L,379L,383L,389L,409L,421L,439L,443L,457L,479L,499L,509L,521L,541L,571L,577L,599L,619L,641L,661L,691L,701L,719L,751L,761L,769L,809L,823L,829L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245590Inst : IEnumerable<long>
{
public static readonly long[] Value=A245590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245590.Bytes);
public long this[int i]=>Value[i];

public static A245590Inst Instance=new A245590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245591
{
public static readonly long[] Value={ 8L,216L,5268024L,59319000L,114791256L,209584584L,543338496L,970299000L,1137893184L,1177583616L,1505060136L,1728000000L,4065356736L,5545233000L,5890514616L,7011739944L,8947094976L,9340607016L,10941048000L,13824000000L,14996130696L,17293606056L,17657244864L,17902480896L,20480864256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245591Inst : IEnumerable<long>
{
public static readonly long[] Value=A245591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245591.Bytes);
public long this[int i]=>Value[i];

public static A245591Inst Instance=new A245591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245592
{
public static readonly long[] Value={ 4L,4L,0L,6L,8L,6L,7L,9L,3L,5L,0L,9L,7L,7L,1L,5L,1L,2L,6L,1L,6L,3L,0L,4L,6L,6L,2L,4L,8L,9L,8L,9L,6L,1L,5L,4L,5L,1L,4L,0L,8L,0L,1L,6L,4L,1L,3L,0L,8L,1L,7L,7L,0L,5L,3L,7L,6L,6L,4L,7L,8L,0L,4L,3L,2L,6L,6L,8L,8L,5L,9L,2L,1L,1L,1L,0L,1L,3L,0L,4L,3L,9L,1L,6L,8L,5L,3L,4L,4L,5L,9L,5L,5L,1L,2L,8L,0L,2L,1L,4L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245592Inst : IEnumerable<long>
{
public static readonly long[] Value=A245592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245592.Bytes);
public long this[int i]=>Value[i];

public static A245592Inst Instance=new A245592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245593
{
public static readonly BigInteger[] Value={ 1L,121L,1367631L,1523548331041L,BigInteger.Parse("169342410709747836551"),BigInteger.Parse("1881665133128606900860142518161"),BigInteger.Parse("2090750117762021873788017450039922462386871"),BigInteger.Parse("232305712669729896500117628007183171975956078054818623681"),BigInteger.Parse("2581174768482624149493549155062886015819364354785066837288515125486819591"),BigInteger.Parse("2867971987924469323820403313431021627485478704243749999500499658223600043001340850612575601") };
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
public class A245593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245593Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245593.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245593.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245593Inst Instance=new A245593Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245594
{
public static readonly long[] Value={ 1L,2L,3L,9L,14L,161L,261L,5727L,12127L,16394L,20029238L,577738261L,2637324098L,45019843643L,54756012358L,142046769201L,2144325306742L,2247950127743L,34462584090334L,223385072880447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245594Inst : IEnumerable<long>
{
public static readonly long[] Value=A245594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245594.Bytes);
public long this[int i]=>Value[i];

public static A245594Inst Instance=new A245594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245595
{
public static readonly long[] Value={ 0L,0L,2L,-1L,-2L,-1L,7L,-5L,-5L,11L,10L,-11L,11L,12L,2L,17L,-2L,19L,-15L,-26L,33L,17L,-22L,-11L,18L,8L,18L,-27L,17L,51L,-37L,-34L,28L,-4L,66L,-37L,-69L,-58L,45L,-81L,-20L,-86L,-19L,17L,-12L,-30L,35L,-32L,5L,-11L,-8L,-45L,12L,-111L,-28L,-71L,76L,59L,102L,-25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245595Inst : IEnumerable<long>
{
public static readonly long[] Value=A245595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245595.Bytes);
public long this[int i]=>Value[i];

public static A245595Inst Instance=new A245595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245596
{
public static readonly long[] Value={ 1L,0L,0L,2L,1L,1L,4L,3L,4L,8L,9L,12L,19L,24L,33L,48L,64L,88L,124L,169L,233L,324L,445L,614L,850L,1171L,1616L,2233L,3080L,4251L,5870L,8100L,11180L,15434L,21301L,29401L,40584L,56015L,77316L,106720L,147301L,203316L,280635L,387352L,534653L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245596Inst : IEnumerable<long>
{
public static readonly long[] Value=A245596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245596.Bytes);
public long this[int i]=>Value[i];

public static A245596Inst Instance=new A245596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245597
{
public static readonly long[] Value={ 2L,2L,4L,8L,10L,56L,46L,6L,4L,102L,98L,90L,52L,12L,28L,418L,426L,482L,38L,28L,140L,26L,354L,882L,756L,268L,146L,4L,260L,76L,48L,288L,1584L,38L,1102L,2688L,464L,3500L,16L,5146L,2562L,2072L,1020L,726L,306L,1796L,38L,866L,508L,800L,3480L,132L,750L,4170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245597Inst : IEnumerable<long>
{
public static readonly long[] Value=A245597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245597.Bytes);
public long this[int i]=>Value[i];

public static A245597Inst Instance=new A245597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245598
{
public static readonly long[] Value={ 3L,4L,8L,4L,42L,60L,8L,198L,8L,54L,130L,778L,108L,178L,924L,44L,180L,706L,4L,170L,474L,30L,480L,1578L,214L,416L,34L,132L,2940L,60L,834L,666L,336L,168L,408L,216L,538L,114L,60L,266L,188L,58L,36L,1504L,4868L,2398L,430L,4L,1940L,408L,2036L,3038L,1146L,1902L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245598Inst : IEnumerable<long>
{
public static readonly long[] Value=A245598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245598.Bytes);
public long this[int i]=>Value[i];

public static A245598Inst Instance=new A245598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245599
{
public static readonly long[] Value={ 1L,11L,91L,731L,5851L,46811L,374491L,2995931L,23967451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245599Inst : IEnumerable<long>
{
public static readonly long[] Value=A245599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245599.Bytes);
public long this[int i]=>Value[i];

public static A245599Inst Instance=new A245599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245600
{
public static readonly long[] Value={ 2L,2L,2L,7L,5L,109L,23L,3L,2L,2843L,1879L,643L,809L,1153L,653L,2969L,4679L,241L,19L,9749L,6247L,13L,2003L,5639L,3061L,13799L,73L,2L,6733L,113L,2917L,24977L,2411L,19L,6473L,12457L,3187L,6133L,4967L,22643L,26723L,1279L,2837L,5347L,353L,9721L,19L,433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245600Inst : IEnumerable<long>
{
public static readonly long[] Value=A245600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245600.Bytes);
public long this[int i]=>Value[i];

public static A245600Inst Instance=new A245600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245601
{
public static readonly long[] Value={ 3L,2L,7L,2L,181L,503L,43L,281L,919L,397L,2099L,389L,163L,89L,5641L,751L,1951L,353L,2L,3709L,4673L,1607L,769L,7699L,107L,7069L,17L,13147L,7841L,97L,5741L,2383L,5557L,251L,9661L,14969L,269L,2753L,18451L,2797L,4729L,29L,15649L,5387L,8539L,13001L,1481L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245601Inst : IEnumerable<long>
{
public static readonly long[] Value=A245601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245601.Bytes);
public long this[int i]=>Value[i];

public static A245601Inst Instance=new A245601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245602
{
public static readonly long[] Value={ -1L,-3L,-7L,-6L,-15L,-60L,-31L,-390L,-120L,-63L,-2100L,-2520L,-127L,-10206L,-31920L,-5040L,-255L,-46620L,-317520L,-181440L,-511L,-204630L,-2739240L,-3780000L,-362880L,-1023L,-874500L,-21538440L,-59875200L,-19958400L,-2047L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245602Inst : IEnumerable<long>
{
public static readonly long[] Value=A245602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245602.Bytes);
public long this[int i]=>Value[i];

public static A245602Inst Instance=new A245602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245603
{
public static readonly long[] Value={ 1L,2L,4L,3L,8L,5L,6L,16L,9L,7L,10L,12L,32L,17L,11L,13L,18L,14L,20L,24L,33L,19L,64L,15L,21L,25L,34L,22L,26L,36L,28L,40L,65L,35L,23L,27L,48L,37L,29L,41L,66L,38L,128L,30L,42L,49L,50L,68L,67L,44L,39L,52L,72L,129L,31L,43L,51L,69L,56L,45L,80L,53L,130L,73L,57L,70L,46L,54L,81L,96L,74L,58L,82L,131L,132L,76L,71L,256L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245603Inst : IEnumerable<long>
{
public static readonly long[] Value=A245603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245603.Bytes);
public long this[int i]=>Value[i];

public static A245603Inst Instance=new A245603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245604
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,7L,10L,5L,9L,11L,15L,12L,16L,18L,24L,8L,14L,17L,22L,19L,25L,28L,35L,20L,26L,29L,36L,31L,39L,44L,55L,13L,21L,27L,34L,30L,38L,42L,51L,32L,40L,45L,56L,50L,60L,67L,81L,37L,46L,47L,57L,52L,62L,68L,82L,59L,65L,72L,86L,79L,93L,105L,121L,23L,33L,41L,49L,48L,58L,66L,77L,53L,64L,71L,85L,76L,90L,99L,111L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245604Inst : IEnumerable<long>
{
public static readonly long[] Value=A245604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245604.Bytes);
public long this[int i]=>Value[i];

public static A245604Inst Instance=new A245604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245605
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,9L,10L,7L,8L,13L,18L,17L,26L,11L,12L,37L,34L,25L,74L,15L,16L,69L,50L,21L,14L,19L,20L,33L,138L,41L,66L,35L,52L,53L,22L,277L,82L,31L,32L,45L,554L,65L,90L,27L,36L,1109L,130L,101L,42L,43L,28L,73L,2218L,149L,30L,71L,104L,57L,146L,209L,114L,51L,148L,133L,70L,293L,418L,555L,164L,141L,586L,329L,282L,75L,68L,105L,106L,1173L,658L,23L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245605Inst : IEnumerable<long>
{
public static readonly long[] Value=A245605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245605.Bytes);
public long this[int i]=>Value[i];

public static A245605Inst Instance=new A245605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245606
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,9L,10L,7L,8L,15L,16L,11L,26L,21L,22L,13L,12L,27L,28L,25L,36L,81L,82L,19L,14L,45L,52L,125L,56L,39L,40L,29L,18L,33L,46L,17L,126L,99L,100L,31L,50L,51L,226L,41L,626L,129L,130L,89L,24L,63L,34L,35L,176L,87L,154L,59L,344L,825L,298L,115L,86L,189L,190L,43L,32L,105L,76L,23L,66L,57L,88L,53L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245606Inst : IEnumerable<long>
{
public static readonly long[] Value=A245606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245606.Bytes);
public long this[int i]=>Value[i];

public static A245606Inst Instance=new A245606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245607
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,9L,13L,6L,17L,37L,8L,25L,7L,10L,69L,33L,26L,11L,41L,16L,277L,45L,18L,65L,21L,14L,1109L,15L,52L,73L,57L,74L,35L,209L,82L,293L,141L,34L,53L,329L,12L,1173L,31L,36L,213L,149L,104L,43L,49L,20L,145L,173L,138L,81L,581L,114L,553L,71L,90L,133L,101L,282L,19L,325L,24L,457L,165L,50L,77L,97L,62L,105L,555L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245607Inst : IEnumerable<long>
{
public static readonly long[] Value=A245607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245607.Bytes);
public long this[int i]=>Value[i];

public static A245607Inst Instance=new A245607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245608
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,8L,13L,11L,6L,14L,18L,41L,7L,26L,28L,20L,9L,23L,63L,50L,25L,113L,313L,65L,12L,17L,88L,77L,172L,149L,43L,95L,16L,38L,33L,44L,10L,413L,163L,221L,19L,74L,48L,191L,22L,476L,118L,179L,49L,68L,138L,29L,39L,527L,78L,215L,31L,635L,1593L,227L,102L,71L,688L,242L,24L,122L,193L,104L,15L,98L,58L,176L,30L,32L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245608Inst : IEnumerable<long>
{
public static readonly long[] Value=A245608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245608.Bytes);
public long this[int i]=>Value[i];

public static A245608Inst Instance=new A245608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245609
{
public static readonly long[] Value={ 1L,3L,2L,6L,9L,26L,8L,5L,56L,344L,21L,36L,4L,11L,204L,86L,25L,16L,176L,39L,518L,24L,125L,1376L,14L,7L,1268L,10L,51L,3186L,126L,1015L,298L,476L,305L,3204L,590L,115L,50L,5636L,15L,7118L,22L,825L,162L,2388L,153L,34L,626L,45L,4356L,144L,301L,156L,4374L,131L,816L,454L,49L,260L,44L,995L,52L,168L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245609Inst : IEnumerable<long>
{
public static readonly long[] Value=A245609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245609.Bytes);
public long this[int i]=>Value[i];

public static A245609Inst Instance=new A245609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245610
{
public static readonly long[] Value={ 1L,3L,2L,13L,8L,4L,26L,7L,5L,28L,14L,172L,149L,25L,41L,18L,635L,102L,113L,1194L,11L,43L,428L,22L,17L,6L,77L,88L,71L,259L,527L,130L,227L,48L,74L,12L,677L,235L,20L,688L,68L,634L,5711L,61L,50L,1593L,1490L,27612L,59L,39L,29L,63L,11438L,10119L,4748L,9L,344L,238L,413L,1602L,941L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245610Inst : IEnumerable<long>
{
public static readonly long[] Value=A245610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245610.Bytes);
public long this[int i]=>Value[i];

public static A245610Inst Instance=new A245610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245611
{
public static readonly long[] Value={ 0L,1L,3L,7L,2L,15L,31L,6L,63L,127L,14L,255L,5L,4L,511L,1023L,30L,13L,2047L,62L,4095L,8191L,12L,16383L,11L,126L,32767L,29L,254L,65535L,131071L,28L,61L,262143L,510L,524287L,1048575L,10L,27L,2097151L,8L,4194303L,125L,1022L,8388607L,59L,2046L,253L,16777215L,60L,33554431L,67108863L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245611Inst : IEnumerable<long>
{
public static readonly long[] Value=A245611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245611.Bytes);
public long this[int i]=>Value[i];

public static A245611Inst Instance=new A245611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245612
{
public static readonly long[] Value={ 1L,2L,5L,3L,14L,13L,8L,4L,41L,63L,38L,25L,23L,18L,11L,6L,122L,313L,188L,172L,113L,123L,74L,61L,68L,88L,53L,39L,32L,28L,17L,7L,365L,1563L,938L,1201L,563L,858L,515L,666L,338L,613L,368L,424L,221L,303L,182L,85L,203L,438L,263L,270L,158L,193L,116L,72L,95L,138L,83L,46L,50L,33L,20L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245612Inst : IEnumerable<long>
{
public static readonly long[] Value=A245612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245612.Bytes);
public long this[int i]=>Value[i];

public static A245612Inst Instance=new A245612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245613
{
public static readonly long[] Value={ 1L,2L,4L,3L,8L,6L,5L,16L,9L,7L,11L,10L,32L,18L,13L,12L,17L,15L,22L,20L,35L,19L,66L,14L,24L,21L,34L,25L,23L,33L,31L,45L,63L,37L,27L,26L,41L,36L,29L,43L,69L,40L,134L,30L,47L,39L,44L,68L,71L,50L,38L,46L,67L,131L,28L,49L,42L,70L,64L,52L,92L,48L,127L,65L,61L,75L,55L,51L,89L,83L,73L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245613Inst : IEnumerable<long>
{
public static readonly long[] Value=A245613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245613.Bytes);
public long this[int i]=>Value[i];

public static A245613Inst Instance=new A245613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245614
{
public static readonly long[] Value={ 1L,2L,4L,3L,7L,6L,10L,5L,9L,12L,11L,16L,15L,24L,18L,8L,17L,14L,22L,20L,26L,19L,29L,25L,28L,36L,35L,55L,39L,44L,31L,13L,30L,27L,21L,38L,34L,51L,46L,42L,37L,57L,40L,47L,32L,52L,45L,62L,56L,50L,68L,60L,82L,81L,67L,121L,86L,93L,105L,72L,65L,79L,33L,59L,64L,23L,53L,48L,41L,58L,49L,85L,71L,77L,66L,111L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245614Inst : IEnumerable<long>
{
public static readonly long[] Value=A245614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245614.Bytes);
public long this[int i]=>Value[i];

public static A245614Inst Instance=new A245614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245615
{
public static readonly long[] Value={ 1L,2L,1L,0L,1L,2L,3L,2L,3L,2L,3L,4L,3L,4L,5L,6L,7L,6L,7L,8L,9L,8L,7L,8L,9L,10L,10L,11L,12L,11L,13L,12L,13L,12L,13L,13L,14L,13L,15L,16L,17L,18L,16L,16L,17L,16L,15L,16L,17L,17L,17L,18L,17L,18L,19L,20L,21L,23L,23L,22L,21L,22L,23L,24L,22L,23L,22L,23L,23L,22L,22L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245615Inst : IEnumerable<long>
{
public static readonly long[] Value=A245615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245615.Bytes);
public long this[int i]=>Value[i];

public static A245615Inst Instance=new A245615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245616
{
public static readonly long[] Value={ 44L,117L,240L,240L,252L,275L,88L,234L,480L,85L,132L,720L,160L,231L,792L,132L,351L,720L,480L,504L,550L,176L,468L,960L,170L,264L,1440L,220L,585L,1200L,720L,756L,825L,320L,462L,1584L,264L,702L,1440L,308L,819L,1680L,255L,396L,2160L,960L,1008L,1100L,352L,936L,1920L,480L,693L,2376L,396L,1053L,2160L,429L,880L,2340L,340L,528L,2880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245616Inst : IEnumerable<long>
{
public static readonly long[] Value=A245616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245616.Bytes);
public long this[int i]=>Value[i];

public static A245616Inst Instance=new A245616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245617
{
public static readonly long[] Value={ 1L,2L,3L,7L,4L,1L,2L,5L,7L,5L,7L,3L,6L,1L,1L,0L,2L,2L,8L,7L,1L,9L,6L,1L,0L,6L,4L,6L,6L,7L,2L,8L,7L,4L,2L,9L,7L,7L,3L,2L,0L,4L,8L,1L,9L,6L,5L,4L,8L,4L,4L,3L,8L,4L,4L,1L,7L,1L,8L,2L,5L,6L,4L,0L,5L,3L,0L,4L,2L,8L,8L,5L,0L,9L,1L,3L,8L,8L,5L,5L,8L,6L,1L,9L,3L,5L,2L,4L,9L,7L,6L,2L,6L,8L,4L,5L,3L,3L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245617Inst : IEnumerable<long>
{
public static readonly long[] Value=A245617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245617.Bytes);
public long this[int i]=>Value[i];

public static A245617Inst Instance=new A245617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245618
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,2L,2L,1L,1L,1L,4L,4L,1L,1L,1L,2L,3L,8L,3L,2L,1L,1L,1L,1L,5L,5L,1L,1L,1L,1L,2L,2L,6L,10L,6L,2L,2L,1L,1L,1L,4L,8L,16L,16L,8L,4L,1L,1L,1L,2L,3L,12L,24L,32L,24L,12L,3L,2L,1L,1L,1L,1L,9L,36L,56L,56L,36L,9L,1L,1L,1L,1L,2L,2L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245618Inst : IEnumerable<long>
{
public static readonly long[] Value=A245618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245618.Bytes);
public long this[int i]=>Value[i];

public static A245618Inst Instance=new A245618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245619
{
public static readonly long[] Value={ 1L,2L,4L,4L,8L,12L,20L,16L,32L,60L,116L,208L,380L,608L,904L,860L,1720L,3436L,6868L,13712L,27356L,54408L,107848L,211500L,413364L,785328L,1469288L,2591452L,4583052L,7074876L,10413552L,10096084L,20192168L,40384332L,80768660L,161537296L,323074460L,646148360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245619Inst : IEnumerable<long>
{
public static readonly long[] Value=A245619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245619.Bytes);
public long this[int i]=>Value[i];

public static A245619Inst Instance=new A245619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245620
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,2L,2L,3L,4L,7L,10L,17L,28L,47L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245620Inst : IEnumerable<long>
{
public static readonly long[] Value=A245620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245620.Bytes);
public long this[int i]=>Value[i];

public static A245620Inst Instance=new A245620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245621
{
public static readonly long[] Value={ 0L,2L,1L,29L,8L,122L,27L,323L,64L,674L,125L,1217L,216L,1994L,343L,3047L,512L,4418L,729L,6149L,1000L,8282L,1331L,10859L,1728L,13922L,2197L,17513L,2744L,21674L,3375L,26447L,4096L,31874L,4913L,37997L,5832L,44858L,6859L,52499L,8000L,60962L,9261L,70289L,10648L,80522L,12167L,91703L,13824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245621Inst : IEnumerable<long>
{
public static readonly long[] Value=A245621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245621.Bytes);
public long this[int i]=>Value[i];

public static A245621Inst Instance=new A245621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245622
{
public static readonly long[] Value={ 11L,17L,19L,41L,61L,71L,101L,107L,109L,113L,127L,131L,149L,151L,157L,167L,179L,181L,191L,197L,199L,211L,241L,251L,271L,281L,311L,401L,419L,421L,461L,491L,521L,541L,571L,601L,617L,619L,641L,661L,691L,701L,719L,751L,761L,811L,821L,881L,911L,919L,941L,971L,991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245622Inst : IEnumerable<long>
{
public static readonly long[] Value=A245622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245622.Bytes);
public long this[int i]=>Value[i];

public static A245622Inst Instance=new A245622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245623
{
public static readonly long[] Value={ 3L,23L,37L,43L,53L,73L,83L,223L,233L,239L,263L,283L,293L,307L,313L,331L,337L,347L,349L,353L,359L,367L,373L,379L,383L,389L,397L,433L,439L,443L,463L,503L,523L,563L,593L,643L,653L,673L,683L,733L,739L,743L,773L,823L,839L,853L,863L,883L,937L,953L,983L,1033L,1303L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245623Inst : IEnumerable<long>
{
public static readonly long[] Value=A245623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245623.Bytes);
public long this[int i]=>Value[i];

public static A245623Inst Instance=new A245623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245624
{
public static readonly long[] Value={ 1L,15L,8L,84L,27L,249L,64L,552L,125L,1035L,216L,1740L,343L,2709L,512L,3984L,729L,5607L,1000L,7620L,1331L,10065L,1728L,12984L,2197L,16419L,2744L,20412L,3375L,25005L,4096L,30240L,4913L,36159L,5832L,42804L,6859L,50217L,8000L,58440L,9261L,67515L,10648L,77484L,12167L,88389L,13824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245624Inst : IEnumerable<long>
{
public static readonly long[] Value=A245624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245624.Bytes);
public long this[int i]=>Value[i];

public static A245624Inst Instance=new A245624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245625
{
public static readonly long[] Value={ 0L,2L,1L,13L,4L,34L,9L,65L,16L,106L,25L,157L,36L,218L,49L,289L,64L,370L,81L,461L,100L,562L,121L,673L,144L,794L,169L,925L,196L,1066L,225L,1217L,256L,1378L,1514L,324L,1693L,361L,1882L,400L,2081L,441L,2290L,484L,2509L,529L,2738L,576L,2977L,625L,3226L,676L,3485L,729L,3754L,784L,4033L,841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245625Inst : IEnumerable<long>
{
public static readonly long[] Value=A245625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245625.Bytes);
public long this[int i]=>Value[i];

public static A245625Inst Instance=new A245625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245626
{
public static readonly long[] Value={ 0L,0L,3L,3L,0L,1L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245626Inst : IEnumerable<long>
{
public static readonly long[] Value=A245626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245626.Bytes);
public long this[int i]=>Value[i];

public static A245626Inst Instance=new A245626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245627
{
public static readonly long[] Value={ 0L,2L,4L,6L,8L,10L,12L,14L,16L,18L,2L,4L,6L,8L,10L,12L,14L,16L,18L,11L,4L,6L,8L,10L,12L,14L,16L,18L,11L,13L,6L,8L,10L,12L,14L,16L,18L,11L,13L,15L,8L,10L,12L,14L,16L,18L,11L,13L,15L,17L,10L,12L,14L,16L,18L,11L,13L,15L,17L,19L,12L,14L,16L,18L,11L,13L,15L,17L,19L,21L,14L,16L,18L,11L,13L,15L,17L,19L,21L,23L,16L,18L,11L,13L,15L,17L,19L,21L,23L,25L,18L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245627Inst : IEnumerable<long>
{
public static readonly long[] Value=A245627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245627.Bytes);
public long this[int i]=>Value[i];

public static A245627Inst Instance=new A245627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245628
{
public static readonly long[] Value={ 1L,2L,23L,3L,34L,4L,44L,5L,55L,556L,6L,66L,667L,7L,77L,777L,8L,88L,888L,889L,9L,99L,999L,991L,22L,33L,344L,445L,555L,56L,666L,6677L,7777L,78L,8888L,8889L,9999L,99991L,223L,334L,444L,5555L,566L,6666L,77777L,778L,88888L,8899L,99999L,9912L,233L,3444L,45L,55556L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245628Inst : IEnumerable<long>
{
public static readonly long[] Value=A245628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245628.Bytes);
public long this[int i]=>Value[i];

public static A245628Inst Instance=new A245628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245629
{
public static readonly long[] Value={ 1L,14L,42L,60L,336L,1638L,2160L,4064L,4130L,4464L,5148L,6678L,7900L,9856L,12192L,13144L,16464L,23220L,24206L,26001L,28665L,44460L,49680L,53464L,105656L,117800L,125685L,158160L,159489L,168597L,173060L,232128L,276080L,309504L,320580L,372384L,475488L,542430L,580072L,613500L,699112L,708900L,787644L,834561L,843200L,885456L,914872L,1215396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245629Inst : IEnumerable<long>
{
public static readonly long[] Value=A245629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245629.Bytes);
public long this[int i]=>Value[i];

public static A245629Inst Instance=new A245629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245630
{
public static readonly long[] Value={ 1L,6L,15L,35L,36L,77L,90L,143L,210L,216L,221L,225L,323L,437L,462L,525L,540L,667L,858L,899L,1147L,1155L,1225L,1260L,1296L,1326L,1350L,1517L,1763L,1938L,2021L,2145L,2491L,2622L,2695L,2772L,3127L,3150L,3240L,3315L,3375L,3599L,4002L,4087L,4757L,4845L,5005L,5148L,5183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245630Inst : IEnumerable<long>
{
public static readonly long[] Value=A245630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245630.Bytes);
public long this[int i]=>Value[i];

public static A245630Inst Instance=new A245630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245631
{
public static readonly long[] Value={ 25L,7L,43L,913L,12L,4L,29L,5184L,261L,648L,7649L,5L,31L,8877L,625L,6375L,28L,5193L,683L,5379L,6L,6981L,8328L,389L,15456L,2144L,44L,7496L,791L,48625L,4432L,768L,75L,3L,937L,52264L,3248L,9017L,304L,96L,73281L,875L,8976L,10944L,6533L,656L,4552L,26809L,13L,653L,2L,68024L,1441L,872L,1368L,39752L,1787L,32L,319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245631Inst : IEnumerable<long>
{
public static readonly long[] Value=A245631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245631.Bytes);
public long this[int i]=>Value[i];

public static A245631Inst Instance=new A245631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245632
{
public static readonly long[] Value={ 6L,5L,2L,9L,12L,4L,29L,1L,61L,0L,56L,1L,31L,4L,21L,9L,28L,49L,6L,25L,6L,5L,104L,3L,6L,244L,44L,9L,16L,25L,25L,4L,64L,3L,344L,1L,21L,44L,69L,0L,209L,25L,56L,1L,369L,24L,61L,4L,13L,41L,2L,9L,29L,76L,225L,25L,6L,32L,29L,84L,504L,5L,504L,516L,61L,564L,6L,59L,169L,56L,289L,9L,96L,529L,69L,176L,44L,4L,21L,656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245632Inst : IEnumerable<long>
{
public static readonly long[] Value=A245632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245632.Bytes);
public long this[int i]=>Value[i];

public static A245632Inst Instance=new A245632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245633
{
public static readonly long[] Value={ 1L,1L,2L,6L,28L,164L,1137L,8928L,76875L,710152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245633Inst : IEnumerable<long>
{
public static readonly long[] Value=A245633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245633.Bytes);
public long this[int i]=>Value[i];

public static A245633Inst Instance=new A245633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245634
{
public static readonly long[] Value={ 0L,6L,4L,3L,3L,2L,3L,0L,5L,7L,3L,13L,11L,0L,17L,0L,15L,0L,7L,0L,0L,15L,5L,0L,79L,0L,0L,0L,15L,0L,0L,0L,65L,0L,47L,0L,39L,0L,37L,0L,9L,0L,0L,45L,44L,0L,11L,0L,103L,0L,71L,0L,11L,0L,119L,0L,5L,0L,0L,0L,0L,0L,0L,0L,33L,0L,75L,0L,77L,0L,51L,143L,0L,0L,67L,0L,69L,0L,25L,0L,131L,0L,0L,0L,57L,0L,8887L,0L,221L,0L,291L,0L,0L,0L,0L,0L,101L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245634Inst : IEnumerable<long>
{
public static readonly long[] Value=A245634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245634.Bytes);
public long this[int i]=>Value[i];

public static A245634Inst Instance=new A245634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245635
{
public static readonly long[] Value={ 2L,2L,5L,2L,4L,4L,3L,9L,5L,2L,2L,2L,6L,5L,6L,1L,9L,6L,6L,6L,0L,8L,2L,2L,9L,9L,5L,8L,8L,7L,7L,9L,4L,2L,1L,3L,8L,4L,8L,6L,1L,6L,8L,5L,4L,6L,2L,0L,4L,2L,7L,4L,1L,9L,0L,1L,0L,8L,3L,0L,6L,1L,5L,2L,9L,6L,0L,2L,3L,1L,4L,3L,9L,2L,5L,0L,9L,9L,0L,9L,7L,3L,7L,4L,7L,1L,4L,1L,9L,5L,0L,9L,3L,6L,2L,2L,8L,3L,6L,9L,2L,7L,4L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245635Inst : IEnumerable<long>
{
public static readonly long[] Value=A245635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245635.Bytes);
public long this[int i]=>Value[i];

public static A245635Inst Instance=new A245635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245636
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245636Inst : IEnumerable<long>
{
public static readonly long[] Value=A245636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245636.Bytes);
public long this[int i]=>Value[i];

public static A245636Inst Instance=new A245636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245637
{
public static readonly long[] Value={ 7L,0L,4L,1L,6L,9L,9L,6L,0L,4L,3L,7L,4L,7L,4L,4L,6L,0L,0L,1L,1L,4L,4L,2L,1L,0L,7L,8L,5L,7L,1L,2L,3L,8L,1L,0L,5L,8L,7L,5L,9L,7L,2L,6L,8L,6L,9L,3L,4L,5L,6L,5L,5L,5L,4L,7L,8L,2L,9L,7L,6L,1L,5L,8L,4L,6L,0L,8L,7L,0L,7L,8L,3L,8L,1L,3L,3L,1L,9L,0L,7L,5L,0L,8L,1L,3L,7L,8L,8L,6L,6L,6L,0L,0L,3L,4L,1L,6L,8L,0L,7L,3L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245637Inst : IEnumerable<long>
{
public static readonly long[] Value=A245637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245637.Bytes);
public long this[int i]=>Value[i];

public static A245637Inst Instance=new A245637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245638
{
public static readonly long[] Value={ 4L,0L,9L,7L,3L,2L,1L,8L,3L,7L,0L,2L,3L,9L,6L,3L,4L,2L,9L,9L,0L,5L,6L,8L,8L,2L,3L,4L,9L,7L,6L,6L,4L,5L,9L,6L,4L,5L,4L,0L,9L,4L,3L,2L,0L,2L,8L,1L,4L,0L,8L,3L,8L,7L,3L,9L,5L,2L,3L,4L,8L,4L,0L,0L,3L,9L,7L,0L,5L,7L,4L,0L,4L,7L,1L,0L,9L,5L,0L,5L,2L,4L,3L,0L,7L,1L,3L,6L,7L,3L,3L,5L,4L,1L,6L,4L,8L,8L,9L,7L,9L,7L,4L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245638Inst : IEnumerable<long>
{
public static readonly long[] Value=A245638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245638.Bytes);
public long this[int i]=>Value[i];

public static A245638Inst Instance=new A245638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245639
{
public static readonly long[] Value={ 2L,3L,5L,11L,17L,19L,23L,31L,59L,67L,79L,89L,103L,107L,137L,173L,193L,229L,233L,241L,257L,263L,271L,311L,317L,353L,359L,383L,409L,431L,479L,509L,521L,523L,541L,563L,569L,577L,593L,599L,613L,641L,709L,739L,751L,787L,829L,887L,907L,919L,947L,971L,983L,1033L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245639Inst : IEnumerable<long>
{
public static readonly long[] Value=A245639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245639.Bytes);
public long this[int i]=>Value[i];

public static A245639Inst Instance=new A245639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245640
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,17L,43L,61L,67L,73L,97L,127L,131L,137L,167L,241L,281L,307L,353L,433L,463L,467L,541L,557L,631L,641L,647L,653L,661L,673L,683L,821L,853L,857L,907L,911L,991L,1033L,1063L,1103L,1117L,1123L,1291L,1307L,1433L,1453L,1511L,1523L,1553L,1567L,1571L,1597L,1601L,1607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245640Inst : IEnumerable<long>
{
public static readonly long[] Value=A245640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245640.Bytes);
public long this[int i]=>Value[i];

public static A245640Inst Instance=new A245640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245641
{
public static readonly long[] Value={ 2L,3L,5L,17L,67L,137L,241L,353L,541L,641L,907L,1033L,1307L,1453L,1607L,1621L,1733L,1811L,2053L,2243L,2273L,2377L,2621L,2963L,3677L,3701L,3881L,3943L,4861L,5261L,5647L,6101L,6823L,7723L,7877L,8081L,8101L,8447L,8923L,9467L,10111L,10223L,11483L,11617L,12161L,12203L,12227L,12457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245641Inst : IEnumerable<long>
{
public static readonly long[] Value=A245641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245641.Bytes);
public long this[int i]=>Value[i];

public static A245641Inst Instance=new A245641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245642
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,3L,3L,6L,5L,7L,5L,11L,5L,7L,10L,10L,7L,15L,3L,15L,12L,11L,7L,25L,11L,11L,15L,15L,7L,28L,5L,20L,18L,11L,16L,35L,9L,13L,20L,27L,9L,34L,9L,21L,32L,15L,9L,43L,9L,27L,24L,23L,11L,41L,20L,33L,24L,19L,11L,66L,7L,15L,36L,26L,22L,44L,11L,23L,24L,38L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245642Inst : IEnumerable<long>
{
public static readonly long[] Value=A245642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245642.Bytes);
public long this[int i]=>Value[i];

public static A245642Inst Instance=new A245642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245643
{
public static readonly long[] Value={ 1L,-6L,8L,16L,-38L,-16L,48L,64L,-56L,-150L,112L,112L,-112L,-80L,160L,192L,-294L,-288L,248L,304L,-272L,-160L,368L,320L,-336L,-726L,400L,448L,-448L,-240L,544L,640L,-568L,-864L,736L,608L,-950L,-400L,656L,832L,-784L,-1152L,864L,1008L,-784L,-496L,1184L,896L,-1136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245643Inst : IEnumerable<long>
{
public static readonly long[] Value=A245643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245643.Bytes);
public long this[int i]=>Value[i];

public static A245643Inst Instance=new A245643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245644
{
public static readonly long[] Value={ 1L,3L,5L,7L,11L,13L,14L,15L,17L,19L,21L,23L,24L,29L,31L,33L,35L,37L,39L,41L,42L,43L,46L,47L,51L,52L,53L,55L,56L,57L,59L,61L,62L,65L,66L,67L,69L,70L,71L,73L,77L,79L,80L,83L,85L,87L,89L,91L,93L,94L,95L,97L,101L,103L,105L,107L,109L,111L,113L,114L,115L,117L,119L,120L,123L,127L,129L,131L,133L,137L,138L,139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245644Inst : IEnumerable<long>
{
public static readonly long[] Value=A245644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245644.Bytes);
public long this[int i]=>Value[i];

public static A245644Inst Instance=new A245644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245645
{
public static readonly long[] Value={ 7L,3L,8L,1L,1L,7L,5L,9L,4L,0L,8L,9L,5L,6L,5L,7L,9L,7L,0L,9L,8L,7L,2L,6L,6L,8L,7L,5L,4L,6L,5L,1L,3L,0L,3L,3L,2L,6L,6L,5L,6L,4L,6L,1L,1L,0L,2L,9L,5L,3L,4L,7L,5L,7L,7L,6L,1L,9L,1L,0L,2L,1L,8L,6L,6L,1L,8L,1L,5L,1L,4L,0L,3L,0L,5L,5L,9L,1L,4L,4L,5L,5L,0L,0L,8L,7L,3L,4L,4L,5L,7L,2L,2L,9L,8L,8L,5L,4L,1L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245645Inst : IEnumerable<long>
{
public static readonly long[] Value=A245645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245645.Bytes);
public long this[int i]=>Value[i];

public static A245645Inst Instance=new A245645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245646
{
public static readonly long[] Value={ 3L,9L,100L,900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245646Inst : IEnumerable<long>
{
public static readonly long[] Value=A245646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245646.Bytes);
public long this[int i]=>Value[i];

public static A245646Inst Instance=new A245646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245647
{
public static readonly long[] Value={ 4L,12L,105L,2625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245647Inst : IEnumerable<long>
{
public static readonly long[] Value=A245647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245647.Bytes);
public long this[int i]=>Value[i];

public static A245647Inst Instance=new A245647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245648
{
public static readonly long[] Value={ 5L,15L,145L,2775L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245648Inst : IEnumerable<long>
{
public static readonly long[] Value=A245648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245648.Bytes);
public long this[int i]=>Value[i];

public static A245648Inst Instance=new A245648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245649
{
public static readonly long[] Value={ 3L,5L,12L,27L,39L,41L,48L,63L,324L,1275L,1599L,2259L,2304L,3124L,3724L,14295L,19464L,21659L,40655L,44659L,262983L,338064L,485463L,505407L,686700L,696795L,898528L,1595384L,10377100L,12332927L,14452991L,14883967L,21024479L,23068975L,25527535L,30971420L,37471143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245649Inst : IEnumerable<long>
{
public static readonly long[] Value=A245649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245649.Bytes);
public long this[int i]=>Value[i];

public static A245649Inst Instance=new A245649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245650
{
public static readonly long[] Value={ 31L,41L,59L,67L,101L,107L,139L,179L,193L,199L,211L,229L,239L,269L,271L,281L,293L,307L,313L,353L,353L,353L,379L,397L,409L,431L,439L,449L,449L,457L,467L,479L,491L,499L,509L,521L,547L,563L,599L,607L,617L,641L,659L,673L,709L,719L,739L,751L,761L,769L,809L,811L,821L,827L,859L,863L,881L,883L,911L,911L,919L,929L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245650Inst : IEnumerable<long>
{
public static readonly long[] Value=A245650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245650.Bytes);
public long this[int i]=>Value[i];

public static A245650Inst Instance=new A245650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245651
{
public static readonly long[] Value={ 3L,1L,8L,7L,7L,6L,6L,2L,5L,9L,2L,5L,0L,2L,9L,6L,7L,5L,4L,8L,0L,0L,8L,1L,7L,6L,9L,7L,7L,8L,0L,1L,3L,1L,8L,1L,9L,7L,2L,1L,2L,4L,1L,8L,6L,7L,8L,7L,8L,7L,0L,1L,7L,0L,1L,9L,7L,5L,4L,9L,6L,8L,1L,7L,8L,9L,5L,7L,3L,2L,3L,4L,2L,6L,0L,2L,2L,9L,9L,0L,0L,6L,4L,0L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245651Inst : IEnumerable<long>
{
public static readonly long[] Value=A245651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245651.Bytes);
public long this[int i]=>Value[i];

public static A245651Inst Instance=new A245651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245652
{
public static readonly long[] Value={ 1L,1L,3L,6L,5L,5L,9L,9L,1L,8L,7L,8L,6L,6L,0L,0L,6L,4L,3L,2L,3L,6L,0L,3L,4L,3L,6L,6L,1L,4L,0L,9L,5L,3L,4L,4L,7L,3L,4L,3L,8L,2L,2L,8L,7L,5L,0L,3L,4L,3L,8L,3L,3L,2L,6L,1L,6L,7L,2L,6L,3L,8L,1L,5L,6L,8L,4L,3L,1L,1L,4L,7L,2L,4L,7L,9L,4L,4L,7L,9L,4L,8L,7L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245652Inst : IEnumerable<long>
{
public static readonly long[] Value=A245652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245652.Bytes);
public long this[int i]=>Value[i];

public static A245652Inst Instance=new A245652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245653
{
public static readonly long[] Value={ 3L,5L,2L,9L,6L,2L,2L,2L,2L,9L,0L,5L,8L,7L,7L,1L,1L,1L,6L,0L,8L,0L,3L,4L,8L,7L,4L,4L,0L,4L,9L,9L,6L,1L,2L,9L,2L,9L,2L,7L,5L,2L,5L,3L,9L,5L,3L,0L,6L,2L,3L,2L,2L,3L,3L,8L,9L,5L,6L,7L,2L,5L,5L,8L,1L,9L,7L,6L,2L,7L,4L,0L,5L,8L,3L,3L,4L,8L,6L,4L,6L,1L,0L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245653Inst : IEnumerable<long>
{
public static readonly long[] Value=A245653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245653.Bytes);
public long this[int i]=>Value[i];

public static A245653Inst Instance=new A245653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245654
{
public static readonly long[] Value={ 1L,4L,8L,8L,0L,7L,8L,5L,4L,5L,5L,9L,9L,7L,1L,0L,2L,9L,4L,6L,5L,6L,2L,4L,6L,0L,3L,1L,5L,8L,2L,3L,5L,7L,6L,6L,1L,8L,9L,3L,5L,1L,6L,1L,5L,2L,6L,0L,2L,9L,9L,0L,8L,0L,7L,7L,4L,9L,7L,2L,6L,8L,2L,5L,0L,1L,2L,5L,0L,5L,4L,8L,0L,6L,9L,1L,8L,5L,8L,3L,5L,7L,8L,8L,9L,9L,2L,9L,2L,5L,5L,3L,9L,5L,6L,8L,7L,4L,9L,2L,9L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245654Inst : IEnumerable<long>
{
public static readonly long[] Value=A245654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245654.Bytes);
public long this[int i]=>Value[i];

public static A245654Inst Instance=new A245654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245655
{
public static readonly long[] Value={ 5L,7L,4L,3L,6L,2L,3L,7L,3L,3L,0L,9L,3L,1L,1L,4L,7L,6L,9L,1L,6L,6L,7L,0L,8L,0L,1L,6L,8L,1L,5L,0L,7L,2L,4L,6L,9L,7L,2L,1L,8L,8L,4L,6L,0L,9L,7L,0L,8L,7L,5L,4L,2L,4L,0L,6L,9L,0L,2L,2L,4L,7L,9L,1L,2L,2L,0L,2L,8L,6L,8L,9L,4L,0L,3L,7L,1L,7L,7L,3L,3L,7L,7L,1L,5L,7L,3L,8L,0L,5L,2L,5L,3L,5L,4L,1L,0L,6L,4L,2L,6L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245655Inst : IEnumerable<long>
{
public static readonly long[] Value=A245655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245655.Bytes);
public long this[int i]=>Value[i];

public static A245655Inst Instance=new A245655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245656
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245656Inst : IEnumerable<long>
{
public static readonly long[] Value=A245656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245656.Bytes);
public long this[int i]=>Value[i];

public static A245656Inst Instance=new A245656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245657
{
public static readonly long[] Value={ 3L,107L,113L,179L,317L,443L,487L,599L,641L,653L,751L,773L,937L,977L,991L,1021L,1087L,1103L,1187L,1201L,1213L,1217L,1301L,1409L,1427L,1439L,1483L,1553L,1559L,1579L,1609L,1637L,1693L,1747L,1777L,1787L,1789L,1861L,1949L,1987L,1993L,2081L,2129L,2239L,2281L,2287L,2293L,2351L,2393L,2477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245657Inst : IEnumerable<long>
{
public static readonly long[] Value=A245657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245657.Bytes);
public long this[int i]=>Value[i];

public static A245657Inst Instance=new A245657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245658
{
public static readonly BigInteger[] Value={ 1L,1L,22L,1624L,264962L,79136637L,38671111558L,28642761340956L,30413158977739302L,BigInteger.Parse("44371247722932580948"),BigInteger.Parse("86030010617294195269924"),BigInteger.Parse("215785986252313362542154058"),BigInteger.Parse("684854225048414942925120331598"),BigInteger.Parse("2699657503162253569920254747627596"),BigInteger.Parse("13010506207186236974375590663943378970") };
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
public class A245658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245658Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245658.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245658.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245658Inst Instance=new A245658Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245659
{
public static readonly long[] Value={ 281683L,496789L,823421L,1352753L,1719217L,6174109L,8643149L,9761051L,9843529L,16191167L,19132121L,19745797L,23490473L,28457797L,31820429L,32860271L,36552277L,37068569L,43506569L,44776981L,46808903L,55035047L,55957807L,67194403L,75099137L,83092897L,86580421L,89135089L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245659Inst : IEnumerable<long>
{
public static readonly long[] Value=A245659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245659.Bytes);
public long this[int i]=>Value[i];

public static A245659Inst Instance=new A245659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245660
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,2L,1L,2L,4L,5L,4L,12L,13L,20L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245660Inst : IEnumerable<long>
{
public static readonly long[] Value=A245660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245660.Bytes);
public long this[int i]=>Value[i];

public static A245660Inst Instance=new A245660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245661
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,3L,1L,2L,2L,3L,1L,3L,1L,3L,2L,2L,1L,5L,1L,2L,2L,3L,1L,3L,1L,4L,2L,2L,2L,4L,1L,2L,2L,5L,1L,3L,1L,3L,3L,2L,1L,7L,1L,3L,2L,3L,1L,5L,2L,5L,2L,2L,1L,5L,1L,2L,3L,5L,2L,3L,1L,3L,2L,3L,1L,7L,1L,2L,3L,3L,2L,3L,1L,7L,3L,2L,1L,5L,2L,2L,2L,5L,1L,5L,2L,3L,2L,2L,2L,9L,1L,3L,3L,4L,1L,3L,1L,5L,3L,2L,1L,7L,1L,3L,2L,7L,1L,3L,2L,3L,3L,2L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245661Inst : IEnumerable<long>
{
public static readonly long[] Value=A245661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245661.Bytes);
public long this[int i]=>Value[i];

public static A245661Inst Instance=new A245661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245662
{
public static readonly long[] Value={ 1119414L,52734279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245662Inst : IEnumerable<long>
{
public static readonly long[] Value=A245662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245662.Bytes);
public long this[int i]=>Value[i];

public static A245662Inst Instance=new A245662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245663
{
public static readonly long[] Value={ 10L,43L,86L,87L,188L,156L,291L,364L,432L,410L,7L,510L,4L,4L,4L,813L,4L,1079L,4L,1900L,6L,10L,6L,2330L,2147L,5L,3463L,2401L,7L,2522L,5L,3884L,5L,5L,8316L,3621L,5L,8L,8L,4866L,5L,5L,5L,5L,6302L,5L,5L,8616L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245663Inst : IEnumerable<long>
{
public static readonly long[] Value=A245663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245663.Bytes);
public long this[int i]=>Value[i];

public static A245663Inst Instance=new A245663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245664
{
public static readonly long[] Value={ 16L,34L,36L,66L,70L,78L,88L,92L,100L,120L,124L,144L,154L,160L,162L,186L,210L,216L,248L,250L,256L,260L,262L,268L,300L,330L,336L,340L,342L,366L,378L,394L,396L,404L,428L,474L,484L,486L,512L,520L,538L,552L,574L,582L,630L,636L,640L,696L,700L,706L,708L,714L,718L,722L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245664Inst : IEnumerable<long>
{
public static readonly long[] Value=A245664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245664.Bytes);
public long this[int i]=>Value[i];

public static A245664Inst Instance=new A245664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245665
{
public static readonly BigInteger[] Value={ 1L,81L,3961L,153341L,5213287L,164060352L,4927007100L,143938455225L,4142847526101L,118504614869214L,3389618010035458L,97376389179852540L,2818543211543628620L,BigInteger.Parse("82388635477750176388"),BigInteger.Parse("2436180769576352799396"),BigInteger.Parse("72958306889459609898731"),BigInteger.Parse("2214789502139053994814716") };
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
public class A245665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245665Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245665.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245665.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245665Inst Instance=new A245665Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245666
{
public static readonly BigInteger[] Value={ 1L,100L,5941L,275705L,11110464L,410474625L,14353045401L,484748595081L,16029615164446L,523952747921310L,17044414451764396L,554568496974014588L,18113988555378974988UL,BigInteger.Parse("595604303387826752023"),BigInteger.Parse("19755504320385394380715"),BigInteger.Parse("662039152774864970449891") };
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
public class A245666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245666Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245666.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245666.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245666Inst Instance=new A245666Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245667
{
public static readonly long[] Value={ 1L,0L,1L,0L,3L,1L,0L,10L,16L,1L,0L,35L,175L,45L,1L,0L,126L,1771L,1131L,96L,1L,0L,462L,17906L,23611L,4501L,175L,1L,0L,1716L,184920L,461154L,161876L,13588L,288L,1L,0L,6435L,1958979L,8837823L,5179791L,759501L,34245L,441L,1L,0L,24310L,21253375L,169844455L,157279903L,36156355L,2785525L,75925L,640L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245667Inst : IEnumerable<long>
{
public static readonly long[] Value=A245667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245667.Bytes);
public long this[int i]=>Value[i];

public static A245667Inst Instance=new A245667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245668
{
public static readonly long[] Value={ 1L,-3L,3L,-1L,-3L,6L,-3L,0L,3L,3L,-12L,6L,-1L,-12L,12L,0L,-3L,12L,9L,-12L,6L,-6L,-12L,0L,-3L,-15L,18L,5L,0L,18L,-6L,0L,3L,-6L,-24L,12L,3L,-12L,18L,0L,-12L,24L,-6L,-12L,6L,18L,-24L,0L,-1L,-27L,21L,-6L,-12L,18L,15L,0L,12L,-6L,-12L,18L,0L,-36L,24L,0L,-3L,24L,-12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245668Inst : IEnumerable<long>
{
public static readonly long[] Value=A245668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245668.Bytes);
public long this[int i]=>Value[i];

public static A245668Inst Instance=new A245668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245669
{
public static readonly long[] Value={ 1L,3L,3L,1L,0L,3L,6L,3L,3L,6L,6L,3L,0L,6L,6L,1L,6L,9L,6L,0L,0L,12L,12L,3L,7L,6L,9L,6L,0L,12L,6L,3L,6L,6L,12L,3L,0L,12L,12L,6L,6L,12L,18L,6L,0L,12L,12L,3L,7L,15L,12L,0L,0L,9L,12L,6L,12L,18L,6L,6L,0L,18L,18L,1L,12L,12L,18L,6L,0L,12L,12L,9L,12L,18L,15L,6L,0L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245669Inst : IEnumerable<long>
{
public static readonly long[] Value=A245669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245669.Bytes);
public long this[int i]=>Value[i];

public static A245669Inst Instance=new A245669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245670
{
public static readonly long[] Value={ 4L,9L,7L,4L,2L,2L,6L,1L,1L,9L,2L,8L,5L,6L,4L,2L,1L,8L,7L,6L,8L,4L,9L,7L,5L,6L,2L,1L,6L,4L,4L,2L,6L,2L,7L,4L,3L,9L,8L,5L,4L,7L,1L,0L,6L,6L,9L,0L,6L,5L,7L,5L,8L,5L,5L,6L,2L,5L,9L,5L,4L,2L,4L,6L,5L,4L,1L,2L,4L,4L,7L,3L,4L,4L,6L,4L,0L,1L,0L,3L,8L,2L,7L,2L,0L,9L,3L,2L,2L,9L,2L,0L,2L,9L,6L,0L,1L,1L,8L,9L,1L,7L,5L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245670Inst : IEnumerable<long>
{
public static readonly long[] Value=A245670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245670.Bytes);
public long this[int i]=>Value[i];

public static A245670Inst Instance=new A245670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245671
{
public static readonly long[] Value={ 1729L,5188L,2594L,1297L,3892L,1946L,973L,2920L,1460L,730L,365L,1096L,548L,274L,137L,412L,206L,103L,310L,155L,466L,233L,700L,350L,175L,526L,263L,790L,395L,1186L,593L,1780L,890L,445L,1336L,668L,334L,167L,502L,251L,754L,377L,1132L,566L,283L,850L,425L,1276L,638L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245671Inst : IEnumerable<long>
{
public static readonly long[] Value=A245671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245671.Bytes);
public long this[int i]=>Value[i];

public static A245671Inst Instance=new A245671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245672
{
public static readonly long[] Value={ 3L,1L,4L,8L,7L,0L,2L,3L,1L,3L,5L,9L,6L,2L,0L,1L,7L,8L,0L,7L,5L,1L,7L,3L,9L,1L,9L,4L,1L,8L,8L,0L,6L,8L,7L,7L,0L,5L,8L,9L,6L,3L,4L,2L,4L,5L,9L,0L,1L,4L,0L,5L,5L,1L,0L,8L,4L,0L,8L,0L,3L,0L,7L,2L,7L,3L,1L,0L,8L,0L,5L,9L,4L,7L,6L,1L,4L,6L,7L,3L,1L,9L,7L,9L,7L,5L,2L,0L,2L,4L,1L,2L,0L,2L,0L,4L,9L,6L,4L,0L,4L,2L,3L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245672Inst : IEnumerable<long>
{
public static readonly long[] Value=A245672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245672.Bytes);
public long this[int i]=>Value[i];

public static A245672Inst Instance=new A245672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245673
{
public static readonly long[] Value={ 3L,5L,0L,7L,0L,4L,8L,0L,7L,5L,8L,7L,0L,6L,3L,6L,7L,3L,0L,8L,2L,6L,8L,5L,9L,0L,1L,0L,8L,9L,8L,2L,8L,9L,0L,0L,5L,7L,3L,6L,4L,2L,0L,3L,5L,6L,5L,8L,2L,2L,6L,9L,0L,6L,0L,6L,1L,7L,5L,0L,7L,9L,9L,3L,7L,5L,5L,4L,8L,5L,5L,0L,3L,2L,5L,7L,0L,7L,2L,8L,9L,8L,5L,7L,3L,8L,7L,2L,5L,1L,8L,8L,2L,3L,7L,9L,4L,1L,2L,2L,3L,2L,0L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245673Inst : IEnumerable<long>
{
public static readonly long[] Value=A245673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245673.Bytes);
public long this[int i]=>Value[i];

public static A245673Inst Instance=new A245673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245674
{
public static readonly long[] Value={ 2L,79L,107L,173L,257L,359L,383L,523L,593L,971L,1493L,1811L,1867L,2273L,2357L,3187L,4111L,4723L,6389L,7607L,8101L,8699L,9473L,11027L,12157L,12227L,15017L,16301L,16987L,18797L,19801L,19913L,20071L,20323L,21313L,22003L,22307L,23203L,24229L,24733L,24859L,24943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245674Inst : IEnumerable<long>
{
public static readonly long[] Value=A245674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245674.Bytes);
public long this[int i]=>Value[i];

public static A245674Inst Instance=new A245674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245675
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,3L,7L,4L,1L,2L,5L,7L,5L,7L,3L,6L,1L,1L,0L,2L,2L,8L,7L,1L,9L,6L,1L,0L,6L,4L,6L,6L,7L,2L,8L,7L,4L,2L,9L,7L,7L,3L,2L,0L,4L,8L,1L,9L,6L,5L,4L,8L,4L,4L,3L,8L,4L,4L,1L,7L,1L,8L,2L,5L,6L,4L,0L,5L,3L,0L,4L,2L,8L,8L,5L,0L,9L,1L,3L,8L,8L,5L,5L,8L,6L,1L,9L,3L,5L,2L,4L,9L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245675Inst : IEnumerable<long>
{
public static readonly long[] Value=A245675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245675.Bytes);
public long this[int i]=>Value[i];

public static A245675Inst Instance=new A245675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245676
{
public static readonly long[] Value={ 1L,3L,2L,6L,3L,7L,5L,11L,5L,10L,7L,14L,7L,16L,11L,20L,9L,17L,13L,22L,12L,25L,18L,27L,14L,24L,20L,31L,18L,36L,26L,37L,19L,34L,28L,38L,24L,45L,34L,47L,26L,41L,36L,49L,35L,61L,44L,54L,32L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245676Inst : IEnumerable<long>
{
public static readonly long[] Value=A245676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245676.Bytes);
public long this[int i]=>Value[i];

public static A245676Inst Instance=new A245676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245677
{
public static readonly long[] Value={ 1L,1L,11L,1L,79L,26L,339L,34L,5297L,62L,69071L,1165L,11723L,9844L,471181L,2625L,8960447L,73244L,8231001L,243757L,1031626241L,151100L,4178462515L,2651758L,10396147563L,11843614L,64166447971L,362476L,1989542332021L,97275764008L,1830230212061L,57286319768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245677Inst : IEnumerable<long>
{
public static readonly long[] Value=A245677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245677.Bytes);
public long this[int i]=>Value[i];

public static A245677Inst Instance=new A245677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245678
{
public static readonly long[] Value={ 2L,3L,12L,5L,60L,35L,280L,63L,2520L,77L,27720L,1287L,8008L,6435L,144144L,2431L,2450448L,46189L,3695120L,146965L,232792560L,96577L,1070845776L,1300075L,2974571600L,5014575L,11473347600L,215441L,332727080400L,31556720475L,486207248800L,20419054425L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245678Inst : IEnumerable<long>
{
public static readonly long[] Value=A245678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245678.Bytes);
public long this[int i]=>Value[i];

public static A245678Inst Instance=new A245678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245679
{
public static readonly long[] Value={ 0L,0L,0L,6L,25L,69L,154L,300L,531L,875L,1364L,2034L,2925L,4081L,5550L,7384L,9639L,12375L,15656L,19550L,24129L,29469L,35650L,42756L,50875L,60099L,70524L,82250L,95381L,110025L,126294L,144304L,164175L,186031L,210000L,236214L,264809L,295925L,329706L,366300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245679Inst : IEnumerable<long>
{
public static readonly long[] Value=A245679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245679.Bytes);
public long this[int i]=>Value[i];

public static A245679Inst Instance=new A245679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245680
{
public static readonly long[] Value={ 1035L,1089L,1359L,1386L,1782L,2178L,2475L,10035L,10089L,10350L,10449L,10890L,10899L,10989L,11688L,11883L,12375L,12903L,13029L,13359L,13449L,13590L,13599L,13659L,13860L,13986L,14085L,14247L,14724L,14859L,15192L,16782L,17604L,17802L,17820L,17832L,17982L,18027L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245680Inst : IEnumerable<long>
{
public static readonly long[] Value=A245680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245680.Bytes);
public long this[int i]=>Value[i];

public static A245680Inst Instance=new A245680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245681
{
public static readonly long[] Value={ 157181L,244603L,276371L,491371L,1266631L,1954531L,2511911L,2866837L,4070201L,4285381L,4311037L,4682297L,4826897L,5200123L,5531353L,5644267L,6195731L,6581591L,7738001L,8290837L,8606053L,8760107L,8770547L,9309907L,9521453L,10562147L,11142413L,11532163L,12206021L,12631111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A245681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245681Inst : IEnumerable<long>
{
public static readonly long[] Value=A245681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245681.Bytes);
public long this[int i]=>Value[i];

public static A245681Inst Instance=new A245681Inst();

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